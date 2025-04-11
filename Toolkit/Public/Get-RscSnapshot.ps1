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
        # The query is different for getting a single object by ID.
        # getting an error with a specific snapshot? It's probably SPARK-20396.
        if ($Id) {
            Write-Verbose "Trying RSC snapshot query..."
            $polarisSnapshotQuery = New-RscQuery -GqlQuery polarisSnapshot
            $polarisSnapshotQuery.var.snapshotFid = $Id
            $polarisSnapshotQuery.field.id = "FETCH"
            $polarisSnapshotQuery.field.date = "1999-01-01"
            $polarisSnapshotQuery.field.isCorrupted = $true
            $polarisSnapshotQuery.field.isIndexed = $true
            $polarisSnapshotQuery.field.isUnindexable = $true
            $polarisSnapshotQuery.field.indexingAttempts = 1
            $polarisSnapshotQuery.field.expirationDate = "1999-01-01"
            $polarisSnapshotQuery.field.isOnDemandSnapshot = $true
            $polarisSnapshotQuery.field.snappableId = "FETCH"
            $polarisSnapshotQuery.field.isQuarantined = $true
            $polarisSnapshotQuery.field.slaDomain = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaReply
            $polarisSnapshotQuery.field.slaDomain.name = "FETCH"
            $polarisSnapshotQuery.field.slaDomain.id = "FETCH"
            $polarisSnapshotQuery.field.isDownloadedSnapshot = $true
            $polarisSnapshotQuery.field.expiryHint = $true
            $polarisSnapshotQuery.field.isExpired = $true
            $polarisSnapshotQuery.field.parentSnapshotId = "FETCH"
            $polarisSnapshotQuery.field.isDeletedFromSource = $true
            $polarisSnapshotQuery.field.isReplicated = $true
            $polarisSnapshotQuery.field.isArchived = $true
            $polarisSnapshotQuery.field.indexTime = "1999-01-01"
            $polarisSnapshotQuery.field.unexpiredArchivedSnapshotCount = 1
            $polarisSnapshotQuery.field.consistencyLevel = [RubrikSecurityCloud.Types.SnapshotConsistencyLevel]::SNAPSHOT_CRASH_CONSISTENT
            $polarisSnapshotQuery.field.isReplica = $true
            $polarisSnapshotQuery.field.isArchivalCopy = $true
            #$polarisSnapshotQuery.field.replicationLocations = New-Object -TypeName RubrikSecurityCloud.Types.DataLocation
            #$polarisSnapshotQuery.field.replicationLocations[0].name = "FETCH"
            #$polarisSnapshotQuery.field.replicationLocations[0].id = "FETCH"
            $polarisSnapshotQuery.field.hasUnexpiredReplica = $true
            $polarisSnapshotQuery.field.hasUnexpiredArchivedCopy = $true
            $result = snapshotById($polarisSnapshotQuery)
            if ($null -ne $result) {
                return $result
            }
            else {
                Write-Verbose "Trying CDM snapshot query..."
                $cdmSnapshotQuery = New-RscQuery -GqlQuery snapshot
                $cdmSnapshotQuery.var.snapshotFid = $Id
                $cdmSnapshotQuery.field.id = "FETCH"
                $cdmSnapshotQuery.field.date = "1999-01-01"
                $cdmSnapshotQuery.field.isCorrupted = $true
                $cdmSnapshotQuery.field.isIndexed = $true
                $cdmSnapshotQuery.field.isUnindexable = $true
                $cdmSnapshotQuery.field.indexingAttempts = 1
                $cdmSnapshotQuery.field.expirationDate = "1999-01-01"
                $cdmSnapshotQuery.field.isOnDemandSnapshot = $true
                $cdmSnapshotQuery.field.snappableId = "FETCH"
                $cdmSnapshotQuery.field.isQuarantined = $true
                $cdmSnapshotQuery.field.slaDomain = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaReply
                $cdmSnapshotQuery.field.slaDomain.name = "FETCH"
                $cdmSnapshotQuery.field.slaDomain.id = "FETCH"
                $cdmSnapshotQuery.field.isDownloadedSnapshot = $true
                $cdmSnapshotQuery.field.expiryHint = $true
                $cdmSnapshotQuery.field.isExpired = $true
                $cdmSnapshotQuery.field.parentSnapshotId = "FETCH"
                $cdmSnapshotQuery.field.isRetentionLocked = $true
                $cdmSnapshotQuery.field.cdmid = "FETCH"
                $cdmSnapshotQuery.field.cdmVersion = "FETCH"
                $cdmSnapshotQuery.field.snapshotRetentionInfo = New-Object -TypeName RubrikSecurityCloud.Types.CdmSnapshotRetentionInfo
                $cdmSnapshotQuery.field.snapshotRetentionInfo.localInfo = New-Object -TypeName RubrikSecurityCloud.Types.CdmSnapshotLocationRetentionInfo
                $cdmSnapshotQuery.field.snapshotRetentionInfo.localInfo.name = "FETCH"
                $cdmSnapshotQuery.field.snapshotRetentionInfo.localInfo.isSnapshotPresent = $true
                $cdmSnapshotQuery.field.snapshotRetentionInfo.localInfo.isExpirationDateCalculated = $true
                $cdmSnapshotQuery.field.snapshotRetentionInfo.localInfo.expirationTime = "1999/01/01"
                $cdmSnapshotQuery.field.snapshotRetentionInfo.localInfo.snapshotFrequency = [RubrikSecurityCloud.Types.SnapshotFrequency]::NA
                $cdmSnapshotQuery.field.snapshotRetentionInfo.localInfo.isExpirationInformationUnavailable = $true
                $cdmSnapshotQuery.field.snapshotRetentionInfo.localInfo.locationId = "FETCH"
                $cdmSnapshotQuery.field.snapshotRetentionInfo.isCustomRetentionApplied = $true
                $cdmSnapshotQuery.field.snapshotRetentionInfo.archivalInfos = New-Object RubrikSecurityCloud.Types.CdmSnapshotLocationRetentionInfo
                $cdmSnapshotQuery.field.snapshotRetentionInfo.archivalInfos[0].name = "FETCH"
                $cdmSnapshotQuery.field.snapshotRetentionInfo.archivalInfos[0].isSnapshotPresent = $true
                $cdmSnapshotQuery.field.snapshotRetentionInfo.archivalInfos[0].isExpirationDateCalculated = $true
                $cdmSnapshotQuery.field.snapshotRetentionInfo.archivalInfos[0].expirationTime = "1999/01/01"
                $cdmSnapshotQuery.field.snapshotRetentionInfo.archivalInfos[0].snapshotFrequency = [RubrikSecurityCloud.Types.SnapshotFrequency]::NA
                $cdmSnapshotQuery.field.snapshotRetentionInfo.archivalInfos[0].isExpirationInformationUnavailable = $true
                $cdmSnapshotQuery.field.snapshotRetentionInfo.archivalInfos[0].locationId = "FETCH"
                $cdmSnapshotQuery.field.snapshotRetentionInfo.replicationInfos = New-Object RubrikSecurityCloud.Types.CdmSnapshotLocationRetentionInfo
                $cdmSnapshotQuery.field.snapshotRetentionInfo.replicationInfos[0].name = "FETCH"
                $cdmSnapshotQuery.field.snapshotRetentionInfo.replicationInfos[0].isSnapshotPresent = $true
                $cdmSnapshotQuery.field.snapshotRetentionInfo.replicationInfos[0].isExpirationDateCalculated = $true
                $cdmSnapshotQuery.field.snapshotRetentionInfo.replicationInfos[0].expirationTime = "1999/01/01"
                $cdmSnapshotQuery.field.snapshotRetentionInfo.replicationInfos[0].snapshotFrequency = [RubrikSecurityCloud.Types.SnapshotFrequency]::NA
                $cdmSnapshotQuery.field.snapshotRetentionInfo.replicationInfos[0].isExpirationInformationUnavailable = $true
                $cdmSnapshotQuery.field.snapshotRetentionInfo.replicationInfos[0].locationId = "FETCH"
                $cdmSnapshotQuery.field.isSapHanaIncrementalSnapshot = $true
                $cdmSnapshotQuery.field.legalHoldInfo = New-Object -TypeName RubrikSecurityCloud.Types.LegalHoldInfo
                $cdmSnapshotQuery.field.legalHoldInfo.shouldHoldInPlace = $true
                $cdmSnapshotQuery.field.resourceSpec = "FETCH"
                $cdmSnapshotQuery.field.cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
                $cdmSnapshotQuery.field.cluster.name = "FETCH"
                $cdmSnapshotQuery.field.cluster.id = "FETCH"
                $cdmSnapshotQuery.field.fileCount = 1
                $cdmSnapshotQuery.field.isAnomaly = $true
                $cdmSnapshotQuery.field.hasDelta = $true
                $cdmSnapshotQuery.field.slaDomain = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaReply
                $cdmSnapshotQuery.field.slaDomain.name = "FETCH"
                $cdmSnapshotQuery.field.slaDomain.id = "FETCH"
                $cdmSnapshotQuery.field.consistencyLevel = [RubrikSecurityCloud.Types.SnapshotConsistencyLevel]::CRASH_CONSISTENT
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

            # Generic fields on all types of snapshots
            $query.field.nodes | ForEach-Object {
                $_.id = "FETCH"
                $_.date = "1999-01-01"
                $_.isCorrupted = $true
                $_.isIndexed = $true
                $_.isUnindexable = $true
                $_.indexingAttempts = 1
                $_.expirationDate = "1999-01-01"
                $_.isOnDemandSnapshot = $true
                $_.snappableId = "FETCH"
                $_.isQuarantined = $true
                $_.slaDomain = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaReply
                $_.slaDomain.name = "FETCH"
                $_.slaDomain.id = "FETCH"
                $_.isDownloadedSnapshot = $true
                $_.expiryHint = $true
                $_.isExpired = $true

            }
            
            # Polaris snapshot type
            $query.field.nodes[$polarisSnapshot].isDeletedFromSource = $true
            $query.field.nodes[$polarisSnapshot].isReplicated = $true
            $query.field.nodes[$polarisSnapshot].isArchived = $true
            $query.field.nodes[$polarisSnapshot].indexTime = "1999-01-01"
            $query.field.nodes[$polarisSnapshot].unexpiredArchivedSnapshotCount = 1
            $query.field.nodes[$polarisSnapshot].consistencyLevel = [RubrikSecurityCloud.Types.SnapshotConsistencyLevel]::SNAPSHOT_CRASH_CONSISTENT
            $query.field.nodes[$polarisSnapshot].isReplica = $true
            $query.field.nodes[$polarisSnapshot].isArchivalCopy = $true
            #$query.field.nodes[$polarisSnapshot].replicationLocations = New-Object -TypeName RubrikSecurityCloud.Types.DataLocation
            #$query.field.nodes[$polarisSnapshot].replicationLocations[0].name = "FETCH"
            #$query.field.nodes[$polarisSnapshot].replicationLocations[0].id = "FETCH"
            $query.field.nodes[$polarisSnapshot].hasUnexpiredReplica = $true
            $query.field.nodes[$polarisSnapshot].hasUnexpiredArchivedCopy = $true
            $query.field.nodes[$polarisSnapshot].parentSnapshotId = "FETCH"

            # CDM snapshot type
            $query.field.nodes[$cdmSnapshot].isRetentionLocked = $true
            $query.field.nodes[$cdmSnapshot].cdmid = "FETCH"
            $query.field.nodes[$cdmSnapshot].cdmVersion = "FETCH"
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo = New-Object -TypeName RubrikSecurityCloud.Types.CdmSnapshotRetentionInfo
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.localInfo = New-Object -TypeName RubrikSecurityCloud.Types.CdmSnapshotLocationRetentionInfo
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.localInfo.name = "FETCH"
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.localInfo.isSnapshotPresent = $true
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.localInfo.isExpirationDateCalculated = $true
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.localInfo.expirationTime = "1999/01/01"
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.localInfo.snapshotFrequency = [RubrikSecurityCloud.Types.SnapshotFrequency]::NA
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.localInfo.isExpirationInformationUnavailable = $true
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.localInfo.locationId = "FETCH"
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.isCustomRetentionApplied = $true
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.archivalInfos = New-Object RubrikSecurityCloud.Types.CdmSnapshotLocationRetentionInfo
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.archivalInfos[0].name = "FETCH"
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.archivalInfos[0].isSnapshotPresent = $true
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.archivalInfos[0].isExpirationDateCalculated = $true
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.archivalInfos[0].expirationTime = "1999/01/01"
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.archivalInfos[0].snapshotFrequency = [RubrikSecurityCloud.Types.SnapshotFrequency]::NA
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.archivalInfos[0].isExpirationInformationUnavailable = $true
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.archivalInfos[0].locationId = "FETCH"
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.replicationInfos = New-Object RubrikSecurityCloud.Types.CdmSnapshotLocationRetentionInfo
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.replicationInfos[0].name = "FETCH"
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.replicationInfos[0].isSnapshotPresent = $true
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.replicationInfos[0].isExpirationDateCalculated = $true
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.replicationInfos[0].expirationTime = "1999/01/01"
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.replicationInfos[0].snapshotFrequency = [RubrikSecurityCloud.Types.SnapshotFrequency]::NA
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.replicationInfos[0].isExpirationInformationUnavailable = $true
            $query.field.nodes[$cdmSnapshot].snapshotRetentionInfo.replicationInfos[0].locationId = "FETCH"
            $query.field.nodes[$cdmSnapshot].isSapHanaIncrementalSnapshot = $true
            $query.field.nodes[$cdmSnapshot].legalHoldInfo = New-Object -TypeName RubrikSecurityCloud.Types.LegalHoldInfo
            $query.field.nodes[$cdmSnapshot].legalHoldInfo.shouldHoldInPlace = $true
            $query.field.nodes[$cdmSnapshot].resourceSpec = "FETCH"
            $query.field.nodes[$cdmSnapshot].cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
            $query.field.nodes[$cdmSnapshot].cluster.name = "FETCH"
            $query.field.nodes[$cdmSnapshot].cluster.id = "FETCH"
            $query.field.nodes[$cdmSnapshot].fileCount = 1
            $query.field.nodes[$cdmSnapshot].isAnomaly = $true
            $query.field.nodes[$cdmSnapshot].hasDelta = $true
            $query.field.nodes[$cdmSnapshot].slaDomain = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaReply
            $query.field.nodes[$cdmSnapshot].slaDomain.name = "FETCH"
            $query.field.nodes[$cdmSnapshot].slaDomain.id = "FETCH"
            $query.field.nodes[$cdmSnapshot].consistencyLevel = [RubrikSecurityCloud.Types.SnapshotConsistencyLevel]::CRASH_CONSISTENT
            $query.field.nodes[$cdmSnapshot].parentSnapshotId = "FETCH"

            $result = Invoke-Rsc -Query $query
            $result.nodes
        }    
    }
} 
