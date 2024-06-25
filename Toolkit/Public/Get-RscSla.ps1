#Requires -Version 3
function Get-RscSla {
    <#
    .SYNOPSIS
    Retrieves Global SLA Domains defined in Rubrik Security Cloud 

    .DESCRIPTION
    SLA Domains are policies that define how frequently an object is backed up, how long to retain it,
    and rules regarding replication and archival of protected data.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Return all SLA Domains
    Get-RscSla

    .EXAMPLE
    # Return an SLA Domain with 'Gold' in the name
    Get-RscSla "Gold"

    .EXAMPLE
    # You can pipe the output of the cmdlet to another cmdlet. 
    # In this case, we get a list of VMware VMs that are a member of SLAs with 'gold' in the name.
    Get-RscSla "Gold" | Get-RscVmwareVm
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Name"
    )]
    Param(
        [Parameter(
             Mandatory = $false,
             ParameterSetName = "Id"
         )]
         [String]$Id,
        [Parameter(
             Mandatory = $false,
             Position = 0,
             ParameterSetName = "Name"
         )]
         [String]$Name
    )
    
    Process {

        if ($Id) {
            $query = New-RscQuery -GqlQuery slaDomain
            $query.var.id = $Id
            # TODO: SDK currently treating as a clusterSlaDomain, so we can't get globalSlaReply fields.
            #$query.field.BaseFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            #$query.field.BaseFrequency.Unit = New-Object -TypeName RubrikSecurityCloud.Types.RetentionUnit
            #$query.field.BaseFrequency.DurationField = 1
            #$query.field.ProtectedObjectCount = 1
            #$query.field.ArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalSpec
            #$query.field.ArchivalSpecs[0].ArchivalLocationToClusterMapping = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationToClusterMapping
            #$query.field.ArchivalSpecs[0].ArchivalLocationToClusterMapping[0].Location = New-Object -TypeName RubrikSecurityCloud.Types.DlsArchivalLocation
            #$query.field.ArchivalSpecs[0].ArchivalLocationToClusterMapping[0].Location.Name = "Foo"
            #$query.field.ReplicationSpecsV2 = New-Object RubrikSecurityCloud.Types.ReplicationSpecV2
            #$query.field.ReplicationSpecsV2[0].Cluster = New-Object RubrikSecurityCloud.Types.SlaReplicationCluster
            #$query.field.ReplicationSpecsV2[0].Cluster.Name = "This is just here as a placeholder string to indicate that the field should be fetched"
            $result = $query.Invoke()
            $result
        } 
        else {
            $query = New-RscQuery -GqlQuery slaDomains -FieldProfile $fieldProfile
            $query.var.shouldShowProtectedObjectCount = $true
            $query.var.filter = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaFilterInput
            $query.var.filter.Field = [RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]::NAME
            $query.var.filter.Text = $Name
            $query.field.nodes[1].BaseFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $query.field.nodes[1].BaseFrequency.Unit = New-Object -TypeName RubrikSecurityCloud.Types.RetentionUnit
            $query.field.nodes[1].BaseFrequency.DurationField = 1
            $query.field.nodes[1].ProtectedObjectCount = 1
            $query.field.nodes[1].ArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalSpec
            $query.field.nodes[1].ArchivalSpecs[0].ArchivalLocationToClusterMapping = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationToClusterMapping
            $query.field.nodes[1].ArchivalSpecs[0].ArchivalLocationToClusterMapping[0].Location = New-Object -TypeName RubrikSecurityCloud.Types.DlsArchivalLocation
            $query.field.nodes[1].ArchivalSpecs[0].ArchivalLocationToClusterMapping[0].Location.Name = "Foo"
            $query.field.nodes[1].ReplicationSpecsV2 = New-Object RubrikSecurityCloud.Types.ReplicationSpecV2
            $query.field.nodes[1].ReplicationSpecsV2[0].Cluster = New-Object RubrikSecurityCloud.Types.SlaReplicationCluster
            $query.field.nodes[1].ReplicationSpecsV2[0].Cluster.Name = "This is just here as a placeholder string to indicate that the field should be fetched"
            $result = $query.Invoke()
            $result.Nodes
        }
    } 
}
