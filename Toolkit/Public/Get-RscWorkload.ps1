#Requires -Version 3
function Get-RscWorkload {
    <#
    .SYNOPSIS
    Retrieves list of protectable objects in Rubrik Security Cloud

    .DESCRIPTION
    This cmdlet uses the GQL query 'snappableConnection' to retrieve a list of protectable objects with a predetermined set of properties.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Get all Workloads
    Get-RscWorkload

    .EXAMPLE
    # Get Workload with specific name
    Get-RscWorkload -Name "jake-001"

    .EXAMPLE
    # Get Workloads by object type
    Get-RscWorkload -Type WINDOWS_FILESET
    
    .EXAMPLE 
    # Get all workloads from a specific SLA
    Get-RscSla -Name "Gold" | Get-RscWorkload

    .EXAMPLE
    # Get all out of compliance workloads on a specific Rubrik Cluster
    Get-RscCluster -Name "MyCluster" | Get-RscWorkload -ComplianceStatus OUT_OF_COMPLIANCE

    .EXAMPLE
    # Get workload with specific RSC ID
    Get-RscWorkload -Id "76CEDF7F-A65E-4264-9DE2-B918CA3CE15D"

    .EXAMPLE
    # Get workload with specific CDM ID
    Get-RscWorkload -CdmId "MssqlDatabase:::76CEDF7F-A65E-4264-9DE2-B918CA3CE15D" -Cluster (Get-RscCluster -Name "MyCluster")

    #>
    [CmdletBinding(DefaultParameterSetName = "Name")]
    Param(
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "CdmId"
        )]
        [String]$CdmId,
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Id"
        )]
        [String[]]$Id,
        [Parameter(
            Mandatory = $false
        )]
        [RubrikSecurityCloud.Types.ObjectTypeEnum[]]$Type,
        [Parameter(
            Mandatory = $false
        )]
        [RubrikSecurityCloud.Types.ObjectTypeEnum[]]$ExcludeType,
        [Parameter(
            Mandatory = $false
        )]
        [RubrikSecurityCloud.Types.ObjectState[]]$State,
        [Parameter(
            Mandatory = $false
        )]
        [RubrikSecurityCloud.Types.ComplianceStatusEnum[]]$ComplianceStatus,
        [Parameter(
            Mandatory = $false
        )]
        [RubrikSecurityCloud.Types.ProtectionStatusEnum[]]$ProtectionStatus,
        [Parameter(
            Mandatory = $false
        )]
        [String]$SearchTerm,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.Cluster]$Cluster,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.Org]$Org
    )
    
    Process {

        $query = New-RscQuery -GqlQuery snappableConnection -FieldProfile EMPTY
        $query.Field.Nodes[0].Id = "FOO"
        $query.Field.Nodes[0].Location = "FOO"
        $query.Field.Nodes[0].complianceStatus = [RubrikSecurityCloud.Types.ComplianceStatusEnum]::IN_COMPLIANCE
        $query.Field.Nodes[0].protectionStatus = [RubrikSecurityCloud.Types.ProtectionStatusEnum]::PROTECTED
        $query.Field.Nodes[0].objectType = [RubrikSecurityCloud.Types.ObjectTypeEnum]::VMWARE_VIRTUAL_MACHINE
        $query.Field.Nodes[0].objectState = [RubrikSecurityCloud.Types.ObjectState]::ACTIVE
        $query.Field.Nodes[0].protectedOn = [System.Datetime]"1/1/2000"
        $query.Field.Nodes[0].totalSnapshots = 1
        $query.Field.Nodes[0].missedSnapshots = 1
        $query.Field.Nodes[0].lastSnapshot = [System.Datetime]"1/1/2000"
        $query.Field.Nodes[0].latestArchivalSnapshot = [System.Datetime]"1/1/2000"
        $query.Field.Nodes[0].latestReplicationSnapshot = [System.Datetime]"1/1/2000"
        $query.Field.Nodes[0].localOnDemandSnapshots = 1
        $query.Field.Nodes[0].localSlaSnapshots = 1
        $query.Field.Nodes[0].archivalSnapshotLag = 1
        $query.Field.Nodes[0].replicationSnapshotLag = 1
        $query.Field.Nodes[0].archivalComplianceStatus = [RubrikSecurityCloud.Types.ComplianceStatusEnum]::IN_COMPLIANCE
        $query.Field.Nodes[0].replicationComplianceStatus = [RubrikSecurityCloud.Types.ComplianceStatusEnum]::IN_COMPLIANCE
        $query.Field.Nodes[0].awaitingFirstFull = $true
        $query.Field.Nodes[0].pullTime = [System.Datetime]"1/1/2000"
        $query.Field.Nodes[0].location = "FOO"
        $query.Field.Nodes[0].localStorage = 1
        $query.Field.Nodes[0].localMeteredData = 1
        $query.Field.Nodes[0].usedBytes = 1
        $query.Field.Nodes[0].provisionedBytes = 1
        $query.Field.Nodes[0].localProtectedData = 1
        $query.Field.Nodes[0].localEffectiveStorage = 1
        $query.Field.Nodes[0].lastSnapshotLogicalBytes = 1
        $query.Field.Nodes[0].orgId = "FOO"
        $query.Field.Nodes[0].sourceProtocol = "FOO"
        $query.Field.Nodes[0].ncdPolicyName = "FOO"
        $query.Field.Nodes[0].ncdLatestArchiveSnapshot = [System.Datetime]"1/1/2000"
        $query.Field.Nodes[0].slaDomain = New-Object RubrikSecurityCloud.Types.GlobalSlaReply
        $query.Field.Nodes[0].slaDomain.name = "FOO"
        $query.Field.Nodes[0].slaDomain.id = "FOO"
        $query.Field.Nodes[0].cluster = New-Object RubrikSecurityCloud.Types.Cluster
        $query.Field.Nodes[0].cluster.name = "FOO"
        $query.Field.Nodes[0].cluster.id = "FOO"
        $query.Field.Nodes[0].fid = "FOO"
        $query.Field.Nodes[0].localSnapshots = 1
        $query.Field.Nodes[0].replicaSnapshots = 1
        $query.Field.Nodes[0].physicalBytes = 1
        $query.Field.Nodes[0].transferredBytes = 1
        $query.Field.Nodes[0].logicalBytes = 1
        $query.Field.Nodes[0].replicaStorage = 1
        $query.Field.Nodes[0].archiveStorage = 1
        $query.Field.Nodes[0].dataReduction = 1
        $query.Field.Nodes[0].logicalDataReduction = 1
        $query.Field.Nodes[0].workloadOrg = New-Object RubrikSecurityCloud.Types.WorkloadOrganization
        $query.Field.Nodes[0].workloadOrg.name = "FOO"
        $query.Field.Nodes[0].workloadOrg.id = "FOO"

        $query.var.filter = New-Object -TypeName RubrikSecurityCloud.Types.SnappableFilterInput

        if ($CdmId) {
            if (!$Cluster) {
                throw "Must provide Cluster to get workload by CDM ID"
            }
            else {
                # Run workloadForeverId, add Id to snappableConnectionFilter then run snappableConnection
                $fidQuery = New-RscQuery -GqlQuery workloadForeverId
                $fidQuery.var.clusterUuid = $Cluster.Id
                $fidQuery.var.managedId = $CdmId
                $fidQueryResult = Invoke-Rsc $fidQuery
                $ForeverId = $fidQueryResult
                $Id = $ForeverId
            }
        }
        if ($Type) {
            $query.var.filter.objectType = $Type
        }
        if ($Id) {
            $query.var.filter.ObjectFid = $Id
        }
        if ($State) {
            $query.var.filter.objectState = $State
        }
        if ($ComplianceStatus) {
            $query.var.filter.complianceStatus = $ComplianceStatus
        }
        if ($ProtectionStatus) {
            $query.var.filter.protectionStatus = $ProtectionStatus
        }
        if ($Sla) {
            $slaFilter = New-Object -TypeName RubrikSecurityCloud.Types.SnappableSlaDomainFilterInput
            $slaFilter.Id = $Sla.Id
            $query.var.filter.slaDomain = $slaFilter
        }
        if ($Cluster) {
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.CommonClusterFilterInput
            $clusterFilter.Id = $Cluster.Id
            $query.var.filter.cluster = $clusterFilter
        }
        if ($Org) {
            $query.var.filter.orgId = $Org.Id
        }

        $result = Invoke-Rsc -Query $query
        $result.nodes
    }
}
