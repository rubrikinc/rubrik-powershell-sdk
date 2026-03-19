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

        # Shared helper: populate log-shipping target field spec.
        function Set-TargetFields($t) {
            $t.fid = "FETCH"
            $t.cdmId = "FETCH"
            $t.location = "FETCH"
            $t.LagTimeFromPrimary = 1
            $t.LastAppliedPoint = "1900/01/01"
            $t.State = "FETCH"
            $t.Status = "FETCH"
            $t.LogFrequency = 1
            $t.PrimaryDatabase = Get-RscType -Name MssqlDatabase -InitialProperties Name, Id
            $t.SecondaryDatabase = Get-RscType -Name MssqlDatabase -InitialProperties Name, Id
            $t.SecondaryInstance = Get-RscType -Name MssqlInstance -InitialProperties Name, Id
            $t.Cluster = Get-RscType -Name Cluster -InitialProperties Name, Id
            $t.PrimaryCluster = Get-RscType -Name Cluster -InitialProperties Name, Id
        }

        if($Id) {
            $query = New-RscQuery -Gql cdmMssqlLogShippingTarget
            $query.var.Fid = $Id
            Set-TargetFields $query.Field

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

            Set-TargetFields $query.Field.Nodes[0]

            if ( $AsQuery ) { return $query }
            $result = $query.Invoke()
            $result.Nodes
        }
    }
}
