#Requires -Version 3
function Get-RscMssqlInstance {
    <#
    .SYNOPSIS
    Retrieves SQL Server instances managed by Rubrik Security Cloud.

    .DESCRIPTION
    Returns SQL Server instances (standalone or clustered) that are registered
    with Rubrik. You can look up an instance by host name, Windows cluster name,
    or RSC ID. When using -HostName or -WindowsClusterName, the -Name parameter
    specifies the SQL instance name and defaults to MSSQLSERVER.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Return all items. This is the default behavior.

    .PARAMETER HostName
    The fully qualified host name of the SQL Server.

    .PARAMETER WindowsClusterName
    The Windows Failover Cluster name hosting the SQL Server instance.

    .PARAMETER Name
    The SQL Server instance name. Defaults to MSSQLSERVER (the default instance).

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
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

Return the query object instead of executing it.

    .PARAMETER Detail
    Return additional fields beyond the default set.

    .EXAMPLE
    # Get all SQL Server instances
    Get-RscMssqlInstance

    .EXAMPLE
    # Get the default instance on a specific host
    Get-RscMssqlInstance -HostName "sql19.demo.rubrik.com"

    .EXAMPLE
    # Get a named instance on a specific host
    Get-RscMssqlInstance -HostName "sql19.demo.rubrik.com" -Name DEV01
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

        if($Id) {
            Write-Verbose "-  Creating Id Query"
            $query = New-RscQuery -Gql mssqlInstance
            $query.Var.fid = $id
            $query.Field.Cluster = Get-RscType -Name Cluster -InitialProperties Name,Id
            $query.Field.effectiveSlaDomain = Get-RscType -Name GlobalSlaReply -InitialProperties Name,Id
            $query.Field.name = "FETCH"
            $query.Field.id = "FETCH"
            
            if ( $AsQuery ) {
                return $query
            }
            else {
                $results = Invoke-Rsc $query
                return $results
            }
        }
        else {
            $query = New-RscQuery -Gql mssqlTopLevelDescendants 
            $query.Var.filter = @()

            if($HostName) {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = @($HostName)
                $query.Var.filter += $nameFilter
            }
            elseif ($WindowsClusterName) {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = @($WindowsClusterName)
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

            $physicalHostIndex = $query.field.nodes.FindIndex({param($item) $item.gettype().name -eq "PhysicalHost"})
            $windowsClusterIndex = $query.field.nodes.FindIndex({param($item) $item.gettype().name -eq "WindowsCluster"})

            $query.field.Nodes[$physicalHostIndex].cluster = Get-RscType -Name Cluster -InitialProperties name,id
            $query.Field.Nodes[$physicalHostIndex].Vars.descendantConnection.typeFilter = [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::MSSQL_INSTANCE
            $query.field.Nodes[$physicalHostIndex].descendantConnection = New-Object -TypeName RubrikSecurityCloud.Types.PhysicalHostDescendantTypeConnection
            $query.field.Nodes[$physicalHostIndex].descendantConnection.nodes = New-Object -TypeName RubrikSecurityCloud.Types.MssqlInstance

            $mssqlInstanceIndex = $query.field.nodes[$physicalHostIndex].descendantConnection.Nodes.FindIndex({param($item) $item.gettype().name -eq "MssqlInstance"})
            $query.field.Nodes[$physicalHostIndex].descendantConnection.Nodes[$mssqlInstanceIndex].name = "FETCH"
            $query.field.Nodes[$physicalHostIndex].descendantConnection.Nodes[$mssqlInstanceIndex].id = "FETCH"
            $query.Field.Nodes[$physicalHostIndex].descendantConnection.Nodes[$mssqlInstanceIndex].Cluster = Get-RscType -Name Cluster -InitialProperties Name, Id
            $query.Field.Nodes[$physicalHostIndex].descendantConnection.Nodes[$mssqlInstanceIndex].effectiveSlaDomain = Get-RscType -Name GlobalSlaReply -InitialProperties Name, Id
            
            $query.Field.Nodes[$windowsClusterIndex].cluster = Get-RscType -Name Cluster -InitialProperties name,id
            $query.Field.Nodes[$windowsClusterIndex].effectiveSlaDomain = Get-RscType -Name GlobalSlaReply -InitialProperties name,id
            $query.Field.Nodes[$windowsClusterIndex].Vars.descendantConnection.typeFilter = [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::MSSQL_INSTANCE
            $query.field.Nodes[$windowsClusterIndex].descendantConnection = New-Object RubrikSecurityCloud.Types.WindowsClusterDescendantTypeConnection
            $query.field.Nodes[$windowsClusterIndex].descendantConnection.nodes = New-Object -TypeName RubrikSecurityCloud.Types.MssqlInstance

            $mssqlInstanceIndex = $query.field.nodes[$windowsClusterIndex].descendantConnection.Nodes.FindIndex({param($item) $item.gettype().name -eq "MssqlInstance"})
            $query.Field.Nodes[$windowsClusterIndex].descendantConnection.Nodes[$mssqlInstanceIndex].Cluster = Get-RscType -Name Cluster -InitialProperties Name, Id
            $query.Field.Nodes[$windowsClusterIndex].descendantConnection.Nodes[$mssqlInstanceIndex].effectiveSlaDomain = Get-RscType -Name GlobalSlaReply -InitialProperties Name, Id
            $query.field.Nodes[$windowsClusterIndex].descendantConnection.nodes[$mssqlInstanceIndex].name = "FETCH"
            $query.field.Nodes[$windowsClusterIndex].descendantConnection.nodes[$mssqlInstanceIndex].id = "FETCH"

            if ( $AsQuery ) {
                return $query
            }
            else {
                $results = Invoke-Rsc $query

                # If we passed in a specific host or windows cluster name, we return the instances from that host, otherwise, we return the host and windows cluster objects.
                # I'm not a fan of this as returning mixed object types results in bad formatting and goes against 
                if ($HostName -or $WindowsClusterName) {
                    $results.nodes.descendantConnection.nodes
                }
                else {
                    $results.nodes
                }
            }
        }
    } 
}
