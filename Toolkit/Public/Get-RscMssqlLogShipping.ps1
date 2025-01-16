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
    
    .PARAMETER PrimaryDatabase
    Database object returned from Get-RscMssqlDatabase

    .PARAMETER SecondaryDatabaseName
    Name of the secondary database 

    .PARAMETER Cluster
    Cluster object retrieved via Get-RscCluster

    .EXAMPLE
    Returns a list of all log shipping relationships
    Get-RscMssqlLogShipping

    .EXAMPLE
    Get a specific log shipping relationship

    Get-RscMssqlLogShipping -PrimaryDatabase (Get-RscMssqlDatabase "foo") -SecondaryDatabaseName "bar" -Cluster (Get-RscCluster "baz")
    
    .EXAMPLE
    Get all log shipping relationships on a specific Rubrik cluster

    Get-RscCluster "foo" | Get-RscMssqlLogShipping

    .EXAMPLE
    Get log shipping relationships for a specific database

    Get-RscMssqlInstance -HostName "foo.example.com" | Get-RscMssqlDatabase "foo" | Get-RscMssqlLogShipping

    #>

    [CmdletBinding(
        # ___ Example ___
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false
        )]
        [String]$Id,
        
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false
        )]
        [Switch]$List,
        
        [Parameter(
            ParameterSetName = "Query",
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [Alias("RscMssqlDatabase")]
        [RubrikSecurityCloud.Types.MssqlDatabase]$PrimaryDatabase,

        [Parameter(
            ParameterSetName = "Query",
            Mandatory = $false
        )]
        [String]$SecondaryDatabaseName ,

        [Parameter(
            ParameterSetName = "Query",
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [Alias("RscCluster")]
        [RubrikSecurityCloud.Types.Cluster]$Cluster
    )
    
    Process {

        if($Id) {
            $query = New-RscQuery -GqlQuery cdmMssqlLogShippingTarget
            $query.var.Fid = $Id

            $query.Field.fid = "FETCH"
            $query.Field.cdmId = "FETCH"
            $query.Field.location = "FETCH"
            $query.Field.LagTimeFromPrimary = 1
            $query.Field.LastAppliedPoint = "1900/01/01"
            $query.Field.State = "FETCH"
            $query.Field.Status = "FETCH"
            $query.Field.LogFrequency = 1
            $query.Field.PrimaryDatabase = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabase
            $query.Field.PrimaryDatabase.Name = "FETCH"
            $query.Field.PrimaryDatabase.Id = "FETCH"
            $query.Field.SecondaryDatabase = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabase
            $query.Field.SecondaryDatabase.Name = "FETCH"
            $query.Field.SecondaryDatabase.Id = "FETCH"
            $query.Field.SecondaryInstance = New-Object -TypeName RubrikSecurityCloud.Types.MssqlInstance
            $query.Field.SecondaryInstance.Name = "FETCH"
            $query.Field.SecondaryInstance.Id = "FETCH"
            $query.Field.Cluster = New-Object RubrikSecurityCloud.Types.Cluster
            $query.Field.Cluster.Name = "FETCH"
            $query.Field.Cluster.Id = "FETCH"
            $query.Field.PrimaryCluster = New-Object RubrikSecurityCloud.Types.Cluster
            $query.Field.PrimaryCluster.Name = "FETCH"
            $query.Field.PrimaryCluster.Id = "FETCH"

        }
        else {
            $query = New-RscQuery -GqlQuery cdmMssqlLogShippingTargets
            $query.Var.filters = @()
    
            if ($Cluster){
                $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterInput
                $clusterFilter.Field = [RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]::CLUSTER_ID
                $clusterFilter.texts = $Cluster.Id
                $query.Var.filters += $clusterFilter
            }
    
            if($SecondaryDatabaseName) {
                $secondaryNameFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterInput
                $secondaryNameFilter.Field = [RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]::SECONDARY_NAME
                $secondaryNameFilter.texts = $SecondaryDatabaseName
                $query.Var.filters += $secondaryNameFilter
            }
    
            if($PrimaryDatabase) {
                $primaryDBIDFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterInput
                $primaryDBIDFilter.Field = [RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]::PRIMARY_DB_ID
                $primaryDBIDFilter.texts = $PrimaryDatabase.CdmId
                $query.Var.filters += $primaryDBIDFilter
            }
    
            $query.Field.Nodes[0].fid = "FETCH"
            $query.Field.Nodes[0].cdmId = "FETCH"
            $query.Field.Nodes[0].location = "FETCH"
            $query.Field.Nodes[0].LagTimeFromPrimary = 1
            $query.Field.Nodes[0].LastAppliedPoint = "1900/01/01"
            $query.Field.Nodes[0].State = "FETCH"
            $query.Field.Nodes[0].Status = "FETCH"
            $query.Field.Nodes[0].LogFrequency = 1
            $query.Field.Nodes[0].PrimaryDatabase = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabase
            $query.Field.Nodes[0].PrimaryDatabase.Name = "FETCH"
            $query.Field.Nodes[0].PrimaryDatabase.Id = "FETCH"
            $query.Field.Nodes[0].SecondaryDatabase = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabase
            $query.Field.Nodes[0].SecondaryDatabase.Name = "FETCH"
            $query.Field.Nodes[0].SecondaryDatabase.Id = "FETCH"
            $query.Field.Nodes[0].SecondaryInstance = New-Object -TypeName RubrikSecurityCloud.Types.MssqlInstance
            $query.Field.Nodes[0].SecondaryInstance.Name = "FETCH"
            $query.Field.Nodes[0].SecondaryInstance.Id = "FETCH"
            $query.Field.Nodes[0].Cluster = New-Object RubrikSecurityCloud.Types.Cluster
            $query.Field.Nodes[0].Cluster.Name = "FETCH"
            $query.Field.Nodes[0].Cluster.Id = "FETCH"
            $query.Field.Nodes[0].PrimaryCluster = New-Object RubrikSecurityCloud.Types.Cluster
            $query.Field.Nodes[0].PrimaryCluster.Name = "FETCH"
            $query.Field.Nodes[0].PrimaryCluster.Id = "FETCH"
    
            $result = $query.Invoke()
            $result.Nodes
        }
    } 
}
