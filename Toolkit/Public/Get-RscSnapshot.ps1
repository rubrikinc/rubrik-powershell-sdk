#Requires -Version 3
function Get-RscSnapshot {
    <#
    .SYNOPSIS
    Retrieves Snapshots for a given protected workload in RSC

    .DESCRIPTION
    This cmdlet uses the GQL query 'snapshotOfASnappableConnection' to retrieve a list of snapshots with a predetermined set of properties.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Get snapshots for a specific VM
    Get-RscVmwareVm -Name "jake-001" | Get-RscSnapshot

    .EXAMPLE
    # Get latest snapshot for all objects in a specific SLA
    Get-RscSla "Gold" | Get-RscWorkload | Get-RscSnapshot -Latest

    .EXAMPLE
    # Get Snapshot from a dat/time range
    Get-RscMssqlDatabase "foo" | Get-RscSnapshot -BeforeTime "2023-04-04" -AfterTime "2023-04-03"
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
        [switch]$Latest

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
            $polarisSnapshotQuery = New-RscQuery -GqlQuery polarisSnapshot
            $polarisSnapshotQuery.var.snapshotFid = $Id
            $polarisSnapshotQuery.field = $polarisSnapshotFieldDef
            $result = snapshotById($polarisSnapshotQuery)
            if ($null -ne $result) {
                return $result
            }
            else {
                Write-Verbose "Trying CDM snapshot query..."
                $cdmSnapshotQuery = New-RscQuery -GqlQuery snapshot
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
            $query = New-RscQuery -GqlQuery snapshotOfASnappableConnection

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

            $result = Invoke-Rsc -Query $query
            $result.nodes
        }    
    }
} 
