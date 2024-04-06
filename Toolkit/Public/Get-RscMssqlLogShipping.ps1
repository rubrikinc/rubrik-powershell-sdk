#Requires -Version 3
function Get-RscMssqlLogShipping {
    <#
    .SYNOPSIS
    Returns MSSQL Log Shipping relationships

    .DESCRIPTION
    Returns MSSQL Log Shipping relationships

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Used to create a list of log shipping relationships
    
    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase

    .PARAMETER SecondaryDatabaseName
    Name of the secondary database 

    .PARAMETER RscCluster
    RscCluster object retrieved via Get-RscCluster

    .EXAMPLE
    Returns a list of all log shipping relationships
    Get-RscMssqlLogShipping -List

    .EXAMPLE
    Get a specific log shipping relationship
    $GetRscMssqlLogShipping = @{
        RscMssqlDatabase = $RscMssqlDatabase
        SecondaryDatabaseName = "logshipping_advanced_method"
        RscCluster = $RscCluster
    }
    $RscMssqlLogShipping = Get-RscMssqlLogShipping @GetRscMssqlLogShipping
    

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
            Mandatory = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            ParameterSetName = "Query",
            Mandatory = $false
        )]
        [String]$SecondaryDatabaseName ,

        [Parameter(
            ParameterSetName = "Query",
            Mandatory = $true
        )][RubrikSecurityCloud.Types.Cluster]$RscCluster
    )
    
    Process {
        Write-Debug "- Running Get-RscMssqlDatabase"

        #region Create Query
        switch ( $PSCmdlet.ParameterSetName){
            "List" {
                write-host "did i get here?"
                #region RSC Query
                # $query = New-RscQueryMssql -Op LogShippingTargets `
                #     -AddField Data.makeupReseedLimit, `
                #     Data.mssqlLogShippingSummary.id, `
                #     Data.mssqlLogShippingSummary.lagtime, `
                #     Data.MssqlLogShippingSummary.LastAppliedPoint, `
                #     Data.MssqlLogShippingSummary.Location, `
                #     Data.MssqlLogShippingSummary.PrimaryDatabaseName, `
                #     Data.MssqlLogShippingSummary.SecondaryDatabaseName, `
                #     Data.MssqlLogShippingSummary.Status.Message, `
                #     Data.MssqlLogShippingSummary.Status.Status, `
                #     Data.MssqlLogShippingSummary.PrimaryDatabaseLogBackupFrequency
                # $query.var.input = New-Object -TypeName RubrikSecurityCloud.Types.QueryLogShippingConfigurationsV2Input
                # $query.var.input.clusterUuid = $RscCluster.id
                #endregion
                 $query = New-RscQueryMssql -Operation CdmLogShippingTargets `
                    -AddField Nodes.LagTimeFromPrimary, `
                        Nodes.LastAppliedPoint, `
                        Nodes.Location, `
                        Nodes.LogFrequency, `
                        Nodes.Cluster, `
                        Nodes.PrimaryCluster, `
                        Nodes.PrimaryDatabase.id, `
                        Nodes.PrimaryDatabase.name, `
                        Nodes.SecondaryDatabase.id, `
                        Nodes.SecondaryDatabase.name, `
                        Nodes.SecondaryInstance.id, `
                        Nodes.SecondaryInstance.name

            }
            "Query"{
                #region RSC Query
                # $query = New-RscQueryMssql -Op LogShippingTargets `
                #     -AddField Data.makeupReseedLimit, `
                #     Data.mssqlLogShippingSummary.id, `
                #     Data.mssqlLogShippingSummary.lagtime, `
                #     Data.MssqlLogShippingSummary.LastAppliedPoint, `
                #     Data.MssqlLogShippingSummary.Location, `
                #     Data.MssqlLogShippingSummary.PrimaryDatabaseName, `
                #     Data.MssqlLogShippingSummary.SecondaryDatabaseName, `
                #     Data.MssqlLogShippingSummary.Status.Message, `
                #     Data.MssqlLogShippingSummary.Status.Status, `
                #     Data.MssqlLogShippingSummary.PrimaryDatabaseLogBackupFrequency

                # $query.var.input = New-Object -TypeName RubrikSecurityCloud.Types.QueryLogShippingConfigurationsV2Input
                # $query.var.input.clusterUuid = $RscCluster.id
                # $query.var.input.PrimaryDatabaseName = $RscMssqlDatabase.Name
                # $query.var.input.SecondaryDatabaseName = $SecondaryDatabaseName
                #endregion
                $query = New-RscQueryMssql -Operation CdmLogShippingTargets `
                    -AddField Nodes.LagTimeFromPrimary, `
                        Nodes.LastAppliedPoint, `
                        Nodes.Location, `
                        Nodes.LogFrequency, `
                        Nodes.Cluster, `
                        Nodes.PrimaryDatabase.id, `
                        Nodes.PrimaryDatabase.name, `
                        Nodes.SecondaryDatabase.id, `
                        Nodes.SecondaryDatabase.name, `
                        Nodes.SecondaryInstance.id, `
                        Nodes.SecondaryInstance.name
                       
                $query.Var.filters = @()
                $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterInput
                $clusterFilter.Field = [RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]::CLUSTER_ID
                $clusterFilter.texts = $RscCluster.Id
                $query.Var.filters += $clusterFilter

                $secondaryNameFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterInput
                $secondaryNameFilter.Field = [RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]::SECONDARY_NAME
                $secondaryNameFilter.texts = $SecondaryDatabaseName
                $query.Var.filters += $secondaryNameFilter

                $primaryDBIDFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterInput
                $primaryDBIDFilter.Field = [RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]::PRIMARY_DB_ID
                $primaryDBIDFilter.texts = $RscMssqlDatabase.CdmId
                $query.Var.filters += $primaryDBIDFilter
            }
        }      
        $result = $query.Invoke()
        $result.Nodes
    } 
}
