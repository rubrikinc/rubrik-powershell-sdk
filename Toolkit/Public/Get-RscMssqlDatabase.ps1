#Requires -Version 3
function Get-RscMssqlDatabase {
    <#
    .SYNOPSIS
    Retrieves SQL Server databases managed by Rubrik Security Cloud.

    .DESCRIPTION
    Returns SQL Server databases that are protected or inventoried by Rubrik. You can
    filter by name, instance, availability group, SLA Domain, cluster, or organization.
    Use -Id to retrieve a single database by its RSC identifier. Use -List (the default)
    to retrieve all databases.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Return all items. This is the default behavior.

    .PARAMETER Name
    Filter by name. Exact match on the database name.

    .PARAMETER RscMssqlInstance
    A SQL Server instance object, typically obtained from Get-RscMssqlInstance.

    .PARAMETER RscMssqlAvailabilityGroup
    A SQL Server availability group object, typically obtained from Get-RscMssqlAvailabilityGroup.

    .PARAMETER Id
    The RSC object ID.

    .PARAMETER Relic
    Include deleted objects that still have snapshots in Rubrik.

    .PARAMETER Replica
    Include replicated copies.

    .PARAMETER Sla
    An SLA Domain object to filter by. Pipe from Get-RscSla.

    .PARAMETER Cluster
    A Rubrik cluster object to filter by. Pipe from Get-RscCluster.

    .PARAMETER Org
    An RSC Organization to filter by. Pipe from Get-RscOrganization.

    .PARAMETER AsQuery
    Return the query object instead of executing it.

    .PARAMETER Detail
    Return additional fields beyond the default set.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Get all SQL Server databases
    Get-RscMssqlDatabase -List

    .EXAMPLE
    # Get a database by name
    Get-RscMssqlDatabase -Name AdventureWorks2019

    .EXAMPLE
    # Get databases on a specific SQL Server instance
    $instance = Get-RscMssqlInstance -HostName sql19.demo.com
    Get-RscMssqlDatabase -Name AdventureWorks2019 -RscMssqlInstance $instance
    #>

    [CmdletBinding(
        # ___ Example ___
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(ParameterSetName = "List", Mandatory = $false)]
        [Switch]$List,

        [Parameter(ParameterSetName = "Name", Mandatory = $true)]
        [String]$Name,

        [Parameter(ParameterSetName = "Name", Mandatory = $false)]
        [Parameter(ParameterSetName = "Instance", Mandatory = $true, ValueFromPipeline = $true)]
        [RubrikSecurityCloud.Types.MssqlInstance]$RscMssqlInstance, 

        [Parameter(ParameterSetName = "Name", Mandatory = $false)]
        [Parameter(ParameterSetName = "AvailabilityGroup", Mandatory = $true, ValueFromPipeline = $true)]
        [RubrikSecurityCloud.Types.MssqlAvailabilityGroup]$RscMssqlAvailabilityGroup, 

        [Parameter(ParameterSetName = "Id", Mandatory = $true)]
        [String]$Id,

        # Include Relics
        [Parameter(
            Mandatory = $false
        )]
        [switch]$Relic,

        # Include Replicas
        [Parameter(
            Mandatory = $false
        )]
        [switch]$Replica,

        # Filter by SLA
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,

        # Filter by Cluster
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.Cluster]$Cluster,

        # Filter by Organization
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.Org]$Org,

        # Return .NET query object for troubleshooting
        [Parameter(
            Mandatory = $false
        )]
        [switch]$AsQuery
    )
    
    Process {
        Write-Debug "- Running Get-RscMssqlDatabase"
        #region Create Query
        switch($PSCmdlet.ParameterSetName){
            "List"{
                $query = New-RscQuery -Gql mssqlDatabases `
                -AddField Nodes.PhysicalPath
                $query.field.nodes[0].Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
                $query.field.nodes[0].Cluster.name = "Fetch"
                $query.field.nodes[0].Cluster.id = "Fetch"
                $query.Var.filter = @()
            }
            { ($_ -eq "Name") -or ($_ -eq "Instance") -or ($_ -eq "AvailabilityGroup")  } {
                $query = New-RscQuery -Gql mssqlDatabases `
                -AddField Nodes.PhysicalPath, `
                    Nodes.PostBackupScript, `
                    Nodes.PreBackupScript, `
                    Nodes.CopyOnly, `
                    Nodes.HostLogRetention, `
                    Nodes.LogBackupFrequencyInSeconds, `
                    Nodes.LogBackupRetentionInHours
                $query.field.nodes[0].Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
                $query.field.nodes[0].Cluster.name = "Fetch"
                $query.field.nodes[0].Cluster.id = "Fetch"
                $query.Var.filter = @()
            }
            "Id"{
                $query = New-RscQuery -Gql mssqlDatabase
                $query.Field.PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
                $query.Field.PhysicalPath.SelectForRetrieval() 
                $query.Var.fid = $Id
            }
        }
        #endregion
        if ($Name){
            $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
            $nameFilter.texts = $Name
            $query.Var.filter += $nameFilter
        }
        if ($Sla) {
            $slaFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $slaFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::EFFECTIVE_SLA
            $slaFilter.Texts = $Sla.id
            $query.var.filter += $slaFilter
        }

        if ($Cluster) {
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
            $clusterFilter.Texts = $Cluster.id
            $query.var.filter += $clusterFilter
        }

        if ($Org) {
            $orgFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $orgFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::ORGANIZATION_ID
            $orgFilter.Texts = $Org.id
            $query.var.filter += $orgFilter
        }

        if ($PSBoundParameters.ContainsKey('relic')) {
            $relicFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $relicFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_RELIC
            $relicFilter.Texts = $Relic
            $query.var.filter += $relicFilter
        }

        if ($PSBoundParameters.ContainsKey('replica')) {
            $replicaFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $replicaFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_REPLICATED
            $replicaFilter.Texts = $Replica
            $query.var.filter += $replicaFilter
        }

        if ($PSBoundParameters.ContainsKey('AsQuery')) {
            $query
        }
        else {
            $results = $query.Invoke()

            switch($PSCmdlet.ParameterSetName){
                "List"{
                    $results.Nodes
                }
                "Id"{
                    $results
                }
                { ($_ -eq "Name") -or ($_ -eq "Instance") -or ($_ -eq "AvailabilityGroup")  } {
                    if ($RscMssqlInstance) {
                        $results = ($results.Nodes | Where-Object {$_.PhysicalPath.Fid -eq $RscMssqlInstance.id})
                        $results
                    }elseif ($RscMssqlAvailabilityGroup) {
                        $results = $results.Nodes | Where-Object {$_.PhysicalPath.Fid -eq $RscMssqlAvailabilityGroup.id}
                        $results                
                    }else{
                        $results.nodes
                    }
                }
            }
        }
    } 
}