#Requires -Version 3
function Get-RscMssqlLogShipping {
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
        # ___ Example ___
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false
        )]
        [Switch]$List,
        
        [Parameter(
            ParameterSetName = "Query",
            Mandatory = $false
        )]
        [String]$PrimaryDatabaseName,

        [Parameter(
            ParameterSetName = "Query",
            Mandatory = $false
        )]
        [String]$SecondaryDatabaseName,

        [Parameter(
            Mandatory = $false
        )][RubrikSecurityCloud.Types.Cluster]$RscCluster
    )
    
    Process {
        Write-Debug "- Running Get-RscMssqlDatabase"
        
         #region Create Query
         switch ( $PSCmdlet.ParameterSetName){
            "List" {
                $query = New-RscQueryMssql -Op CdmLogShippingTargets `
                    -AddField Nodes.LagTimeFromPrimary, `
                    Nodes.LastAppliedPoint, `
                    Nodes.Location 
                    # Nodes.Cluster `
                    # Nodes.PrimaryDatabase
                    # Nodes.SecondaryDatabase
                    # Nodes.SecondaryInstance
            }
            "Query"{
                $query = New-RscQueryMssql -Op CdmLogShippingTargets `
                -AddField Nodes.LagTimeFromPrimary, `
                Nodes.LastAppliedPoint, `
                Nodes.Location 
                # Nodes.Cluster `
                # Nodes.PrimaryDatabase
                # Nodes.SecondaryDatabase
                # Nodes.SecondaryInstance

                $query.Var.filters = @()

                if ($PrimaryDatabaseName){
                    $PrimaryDatabaseNameFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterInput
                    $PrimaryDatabaseNameFilter.Field = [RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]::PRIMARY_NAME
                    $PrimaryDatabaseNameFilter.texts = $PrimaryDatabaseName
                    $query.Var.filters += $PrimaryDatabaseNameFilter
                }

                if ($SecondaryDatabaseName){
                    $SecondaryDatabaseNameFilters = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterInput
                    $SecondaryDatabaseNameFilters.Field = [RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]::SECONDARY_NAME
                    $SecondaryDatabaseNameFilters.texts = $SecondaryDatabaseName
                    $query.Var.filters += $SecondaryDatabaseNameFilters
                }

                if ($RscCluster){
                    $RscClusterFilters = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterInput
                    $RscClusterFilters.Field = [RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]::CLUSTER_UUID
                    $RscClusterFilters.texts = $RscCluster.id
                    $query.Var.filters += $RscClusterFilters
                }
            }
         }
        $result = $query.Invoke()
        $result.Nodes
    } 
}
