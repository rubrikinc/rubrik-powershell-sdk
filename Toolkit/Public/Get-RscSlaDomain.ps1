#Requires -Version 3
function Get-RscSlaDomain {
    <#
    .SYNOPSIS
    ___ Add synopsis here ___

    .DESCRIPTION
    ___ Add description here ___

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    ___ Add example here ___
    #>

    [CmdletBinding(

    )]
    Param(

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$Detail,
        [Parameter(
             Mandatory = $false 
         )]
         [String]$Name
    )
    
    Process {

        # Determine input profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }

        $query = (New-RscQuerySla -Operation Domains -FieldProfile $fieldProfile)
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

        $query.Var.filter = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaFilterInput
        $query.var.filter.Field = [RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]::NAME
        $query.var.filter.Text = $Name

        $result = Invoke-Rsc -Query $query
        $result.nodes
    } 
}
