#Requires -Version 3
function Get-RscSnapshot {
    <#
    .SYNOPSIS
    Retrieves snapshots for a protected workload in Rubrik Security Cloud.

    .DESCRIPTION
    Returns snapshots taken for a given workload object. Pipe any workload object
    (VM, database, fileset, etc.) to this cmdlet to list its snapshots. You can
    filter by time range or retrieve only the latest snapshot. Use -Id to fetch
    a single snapshot by its RSC identifier.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Get snapshots for a specific VM
    Get-RscVmwareVm -Name "jake-001" | Get-RscSnapshot

.PARAMETER Id
    The RSC snapshot ID.

    .PARAMETER InputObject
    A workload object to retrieve snapshots for. Pipe from any Get-Rsc* workload cmdlet.

    .PARAMETER BeforeTime
    Return only snapshots taken before this date and time.

    .PARAMETER AfterTime
    Return only snapshots taken after this date and time.

    .PARAMETER Latest
    Return only the most recent snapshot.

    .EXAMPLE
    # Get all snapshots for a specific VM
    Get-RscVmwareVm -Name "web-server-01" | Get-RscSnapshot

    .EXAMPLE
    # Get the latest snapshot for each workload in an SLA
    Get-RscSla "Gold" | Get-RscWorkload | Get-RscSnapshot -Latest

    .EXAMPLE
    # Get snapshots within a date range
    Get-RscMssqlDatabase -Name "AdventureWorks" | Get-RscSnapshot -BeforeTime "2024-01-15" -AfterTime "2024-01-01"
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Object"
    )]
    Param(
        [Parameter(
            Mandatory = $true,
            ParameterSetName = "Id"
        )]
        [String]$Id,
        [Parameter(
            Mandatory = $true,
            ValueFromPipeline = $true,
            ParameterSetName = "Object"
        )]
        [RubrikSecurityCloud.Types.BaseType]$InputObject,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            ParameterSetName = "Object"
        )]
        [datetime]$BeforeTime,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            ParameterSetName = "Object"
        )]
        [datetime]$AfterTime,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            ParameterSetName = "Object"
        )]
        [switch]$Latest,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery

    )
    
    Process {

        function snapshotById($snapshotQuery) {
            try {
                $result = Invoke-Rsc $snapshotQuery
                return $result
            }
            catch {
                return $null
            }
        }

        $cdmSnapshotFieldDef = Get-RscType -Name CdmSnapshot -InitialProperties `
            id,`
            date,`
            isCorrupted,`
            isIndexed,`
            isUnindexable,`
            indexingAttempts,`
            expirationDate,`
            isOnDemandSnapshot,`
            snappableId,`
            isQuarantined,`
            slaDomain.name,slaDomain.id,`
            isDownloadedSnapshot,`
            expiryHint,`
            parentSnapshotId,`
            isRetentionLocked,`
            cdmId,`
            cdmVersion,`
            snapshotRetentionInfo.isCustomRetentionApplied,`
            snapshotRetentionInfo.localInfo.name,`
            snapshotRetentionInfo.localInfo.isSnapshotPresent,`
            snapshotRetentionInfo.localInfo.isExpirationDateCalculated,`
            snapshotRetentionInfo.localInfo.expirationTime,`
            snapshotRetentionInfo.localInfo.snapshotFrequency,`
            snapshotRetentionInfo.localInfo.isExpirationInformationUnavailable,`
            snapshotRetentionInfo.localInfo.locationId,`
            snapshotRetentionInfo.archivalInfos.name,`
            snapshotRetentionInfo.archivalInfos.isSnapshotPresent,`
            snapshotRetentionInfo.archivalInfos.isExpirationDateCalculated,`
            snapshotRetentionInfo.archivalInfos.expirationTime,`
            snapshotRetentionInfo.archivalInfos.snapshotFrequency,`
            snapshotRetentionInfo.archivalInfos.isExpirationInformationUnavailable,`
            snapshotRetentionInfo.archivalInfos.locationId,`
            snapshotRetentionInfo.replicationInfos.name,`
            snapshotRetentionInfo.replicationInfos.isSnapshotPresent,`
            snapshotRetentionInfo.replicationInfos.isExpirationDateCalculated,`
            snapshotRetentionInfo.replicationInfos.expirationTime,`
            snapshotRetentionInfo.replicationInfos.snapshotFrequency,`
            snapshotRetentionInfo.replicationInfos.isExpirationInformationUnavailable,`
            snapshotRetentionInfo.replicationInfos.locationId,`
            isSapHanaIncrementalSnapshot,`
            legalHoldInfo.shouldHoldInPlace,`
            resourceSpec,`
            cluster.name,cluster.id,`
            fileCount,`
            isAnomaly,`
            hasDelta,`
            slaDomain.name,slaDomain.id,`
            consistencyLevel,`
            MssqlAppMetadata.EndBackupTimestampMs

        $polarisSnapshotFieldDef = Get-RscType -Name PolarisSnapshot -InitialProperties `
            id,`
            date,`
            isCorrupted,`
            isIndexed,`
            isUnindexable,`
            indexingAttempts,`
            expirationDate,`
            isOnDemandSnapshot,`
            snappableId,`
            isQuarantined,`
            slaDomain.name,slaDomain.id,`
            isDownloadedSnapshot,`
            expiryHint,`
            isExpired,`
            isDeletedFromSource,`
            isReplicated,`
            isArchived,`
            indexTime,`
            unexpiredArchivedSnapshotCount,`
            isReplica,`
            isArchivalCopy,`
            hasUnexpiredReplica,`
            hasUnexpiredArchivedCopy,`
            parentSnapshotId


        # The query is different for getting a single object by ID.
        # getting an error with a specific snapshot? It's probably SPARK-20396.
        if ($Id) {
            Write-Verbose "Trying RSC snapshot query..."
            $polarisSnapshotQuery = New-RscQuery -Gql polarisSnapshot
            $polarisSnapshotQuery.var.snapshotFid = $Id
            $polarisSnapshotQuery.field = $polarisSnapshotFieldDef
            if ( $AsQuery ) { return $polarisSnapshotQuery }
            $result = snapshotById($polarisSnapshotQuery)
            if ($null -ne $result) {
                return $result
            }
            else {
                Write-Verbose "Trying CDM snapshot query..."
                $cdmSnapshotQuery = New-RscQuery -Gql snapshot
                $cdmSnapshotQuery.var.snapshotFid = $Id
                $cdmSnapshotQuery.field = $cdmSnapshotFieldDef

                $result = snapshotById($cdmSnapshotQuery)
                if ($null -ne $result) {
                    return $result
                }
            }
            $result
        }
        else {
            $query = New-RscQuery -Gql snapshotOfASnappableConnection

            # This is for pipeline support from Get-RscWorkload.
            # Most objects in the API return .id with the RSC FID, but Get-RscWorkload(snappableConnection) returns .fid for the RSC FID, and .id is the CDM ID.
            # Additionally, we need to check for MSSQL databases, because database snapshots are tied to the DAG ID, not the MSSQL Object ID.
            if ($InputObject -is [RubrikSecurityCloud.Types.Snappable]) {
                if ($InputObject.objectType -eq [RubrikSecurityCloud.Types.ObjectTypeEnum]::MSSQL) {
                    Write-Error "MSSQL snapshots cannot be retrieved using Get-RscWorkload. Please use Get-RscMssqlDatabase."
                    return
                }
                $query.var.workloadId = $InputObject.fid
            }
            else {
                $query.var.workloadId = $InputObject.id
            }

            # MSSQL database snapshots are tied to the dag ID, not the object ID (fid).
            if ($InputObject -is [RubrikSecurityCloud.Types.MssqlDatabase]) {
                $query.var.workloadId = $inputObject.dagId
            }

            if ($PSBoundParameters.ContainsKey('latest')) {
                $query.var.first = 1
            }

            if ($BeforeTime -and $AfterTime) {
                $query.var.timeRange = New-Object -TypeName RubrikSecurityCloud.Types.TimeRange
                $query.var.timeRange.start = $AfterTime
                $query.var.timeRange.end = $BeforeTime
            }
            elseif (($PSBoundParameters.ContainsKey('BeforeTime') -xor $PSBoundParameters.ContainsKey('AfterTime'))) {
                Write-Error "You must use define both -BeforeTime and -AfterTime parameters."
                return
            }

            $cdmSnapshot = $query.field.nodes.FindIndex({param($item) $item.gettype().name -eq "cdmSnapshot"})
            $polarisSnapshot = $query.field.nodes.FindIndex({param($item) $item.gettype().name -eq "polarisSnapshot"})
            
            # Polaris snapshot type
            $query.field.nodes[$polarisSnapshot] = $polarisSnapshotFieldDef

            # CDM snapshot type
            $query.field.nodes[$cdmSnapshot] = $cdmSnapshotFieldDef

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result.nodes
        }
    }
} 
