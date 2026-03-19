#Requires -Version 3
function Get-RscMssqlLogShipping {
    <#
    .SYNOPSIS
    Retrieves SQL Server log shipping relationships from Rubrik Security Cloud.

    .DESCRIPTION
    Returns log shipping relationships managed by Rubrik. You can list all
    relationships, look up a specific one by primary database and secondary
    database name, or filter by cluster. Pipe a database object to scope
    results to that database's log shipping targets.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Id
    The RSC object ID.

    .PARAMETER List
    Return all items. This is the default behavior.

    .PARAMETER PrimaryDatabase
    A SQL Server database object, typically obtained from Get-RscMssqlDatabase.

    .PARAMETER SecondaryDatabaseName
    The name of the secondary (target) database in the log shipping relationship.

    .PARAMETER Cluster
    A Rubrik cluster object to filter by. Pipe from Get-RscCluster.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Get all log shipping relationships
    Get-RscMssqlLogShipping

    .EXAMPLE
    # Get log shipping on a specific cluster
    Get-RscCluster -Name "cluster-east" | Get-RscMssqlLogShipping

    .EXAMPLE
    # Get log shipping for a specific database
    Get-RscMssqlDatabase -Name "AdventureWorks" | Get-RscMssqlLogShipping
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
        [RubrikSecurityCloud.Types.Cluster]$Cluster,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {

        if($Id) {
            $query = New-RscQuery -Gql cdmMssqlLogShippingTarget
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

            if ( $AsQuery ) { return $query }
        }
        else {
            $query = New-RscQuery -Gql cdmMssqlLogShippingTargets
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
    
            if ( $AsQuery ) { return $query }
            $result = $query.Invoke()
            $result.Nodes
        }
    } 
}
