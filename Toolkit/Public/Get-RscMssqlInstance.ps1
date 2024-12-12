#Requires -Version 3
function Get-RscMssqlInstance {
    <#
    .SYNOPSIS
    Returns information about the SQL Server Instances connected to Rubrik Security Cloud

    .DESCRIPTION
    Returns information about the SQL Server Instances connected to Rubrik Security Cloud

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Uses the latest recovery point date and time that Rubrik has for a database

    .PARAMETER HostName
    Host name of the SQL Server Instance

    .PARAMETER WindowsClusterName
    Windows Cluster Name of the SQL Server Instance

    .PARAMETER Name
    SQL Server Instance Name. If not provided, we default to MSSQLSERVER
    
    .PARAMETER Id
    Used to return a specific SQL Server Instance based on the Id assigned inside of Rubrik
    
    .PARAMETER RscCluster
    RscCluster object retrieved via Get-RscCluster

    .PARAMETER Detail
    Changes the data profile. This can affect the fields returned

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Returns a list of all SQL Server Instances connected to RSC
    Get-RscMssqlInstance -List

    .EXAMPLE
    Returns information about the default instance of SQL on a specific host
    $HostName = "rp-sql19s-001.demo.rubrik.com"
    $RscMssqlInstance = Get-RscMssqlInstance -HostName $HostName
    
    .EXAMPLE
    Returns information about a specific instance of SQL on a specific host
    $HostName = "rp-sql19s-001.demo.rubrik.com"
    $RscMssqlInstance = Get-RscMssqlInstance -HostName $HostName -Name DEV01

    .EXAMPLE
    Returns information about a specific instance of SQL on a Windows Cluster
    $WindowsClusterName = "rp-winfcsql"
    $RscMssqlInstance = Get-RscMssqlInstance -WindowsClusterName $WindowsClusterName -Name DEV01
    
    .EXAMPLE
    Return a RscMssqlInstance Object based on a specific MssqlInstance Id
    Get-RscMssqlInstance -Id "86da734b-2fee-4fdc-bdc8-a73ab5648f" 
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(ParameterSetName = "List", Mandatory = $false)]
        [Switch]$List,
        
        [Parameter(ParameterSetName = "ByHostName", Mandatory = $true)]
        [String]$HostName,
        
        [Parameter(ParameterSetName = "ByWindowsClusterName", Mandatory = $true)]
        [String]$WindowsClusterName,

        [Parameter(ParameterSetName = "ByHostName", Mandatory = $false)]
        [Parameter(ParameterSetName = "ByWindowsClusterName", Mandatory = $false)]
        [Alias("InstanceName")]
        [String]$Name = "MSSQLSERVER",
        
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
        [Alias("RscCluster")]
        [RubrikSecurityCloud.Types.Cluster]$Cluster,

        # Filter by Organization
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.Org]$Org,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    Process {
        Write-Verbose "-Running Get-RscMssqlInstance"
        #region Create Query
        switch ($PSCmdlet.ParameterSetName) {
            "List" {
                Write-Verbose "-  Creating List Query"
                $query = New-RscQueryMssql -Op TopLevelDescendants 
                $query.Var.typeFilter = @()
                $query.Var.typeFilter += "PhysicalHost"
                $query.Var.typeFilter += "WindowsCluster"
                $query.var.filter = @()
            }
            { ($_ -eq "ByHostName") -or ($_ -eq "ByWindowsClusterName") } {
                $Name = ""
                if ($HostName) { $Name = $HostName }
                if ($WindowsClusterName) { $Name = $WindowsClusterName }
                $query = New-RscQuery -GqlQuery MssqlTopLevelDescendants 
                $query.Var.filter = @()
                $query.Field.Nodes[3].PhysicalChildConnection.Nodes[5].Cluster = New-Object RubrikSecurityCloud.Types.Cluster
                $query.Field.Nodes[3].PhysicalChildConnection.Nodes[5].Cluster.SelectForRetrieval()
                $query.Field.Nodes[3].PhysicalChildConnection.Nodes[5].PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
                $query.Field.Nodes[3].PhysicalChildConnection.Nodes[5].PhysicalPath.SelectForRetrieval()
    
                $query.field.Nodes[4].LogicalChildConnection = New-Object RubrikSecurityCloud.Types.WindowsClusterLogicalChildTypeConnection
                $query.field.Nodes[4].LogicalChildConnection.SelectForRetrieval()
                $query.Field.Nodes[4].LogicalChildConnection.Nodes[0].PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
                $query.Field.Nodes[4].LogicalChildConnection.Nodes[0].PhysicalPath.SelectForRetrieval()
    
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $Name
                $query.Var.filter += $nameFilter
            }
            "Id" {
                Write-Verbose "-  Creating Id Query"
                $query = New-RscQuery -GqlQuery mssqlInstance
                $query.Field.PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
                $query.Field.PhysicalPath.SelectForRetrieval()
                $query.Var.filter = @()
                $query.Var.fid = $id
            }
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
        #endregion
        
        # Skip sending, return query object:
        if ( $AsQuery ) {
            return $query
        }
        
        # Invoke the query:
        $results = $query.Invoke()
        
        switch ($PSCmdlet.ParameterSetName) {
            "List" {
                $results.Nodes
            }
            { ($_ -eq "ByHostName") -or ($_ -eq "ByWindowsClusterName") } {
                switch ($results.nodes.objectType) {
                    "PHYSICAL_HOST" {
                        $results = $results.Nodes.PhysicalChildConnection.Nodes | Where-Object { $_.Name -eq $InstanceName }
                        $results
                    }
                    "WINDOWS_CLUSTER" {
                        $results = $results.Nodes.LogicalChildConnection.Nodes | Where-Object { $_.Name -eq $InstanceName }
                        $results
                    }
                }
            }
            "Id" {
                $results
            }
        }
    } 
}
