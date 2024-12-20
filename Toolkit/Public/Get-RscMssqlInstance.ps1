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

        if($Id) {
            Write-Verbose "-  Creating Id Query"
            $query = New-RscQuery -GqlQuery mssqlInstance
            $query.Var.fid = $id

            $query.Field.Cluster = New-Object RubrikSecurityCloud.Types.Cluster
            $query.Field.Cluster.name = "FETCH"
            $query.Field.Cluster.id = "FETCH"
            $query.Field.effectiveSlaDomain = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaReply
            $query.Field.effectiveSlaDomain.name = "FETCH"
            $query.Field.effectiveSlaDomain.id = "FETCH"
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
            $query = New-RscQuery -GqlQuery mssqlTopLevelDescendants 
            $query.Var.filter = @()

            if($HostName) {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $HostName
                $query.Var.filter += $nameFilter
            }
            elseif ($WindowsClusterName) {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $WindowsClusterName
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


            $query.field.Nodes[$physicalHostIndex].cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
            $query.field.Nodes[$physicalHostIndex].cluster.name = "FETCH"
            $query.field.Nodes[$physicalHostIndex].cluster.id = "FETCH"
            $query.Field.Nodes[$physicalHostIndex].Vars.descendantConnection.typeFilter = [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::MSSQL_INSTANCE
            $query.field.Nodes[$physicalHostIndex].descendantConnection = New-Object -TypeName RubrikSecurityCloud.Types.PhysicalHostDescendantTypeConnection
            $query.field.Nodes[$physicalHostIndex].descendantConnection.nodes = New-Object -TypeName RubrikSecurityCloud.Types.MssqlInstance

            $mssqlInstanceIndex = $query.field.nodes[$physicalHostIndex].descendantConnection.Nodes.FindIndex({param($item) $item.gettype().name -eq "MssqlInstance"})
            $query.field.Nodes[$physicalHostIndex].descendantConnection.nodes[$mssqlInstanceIndex].name = "FETCH"
            $query.field.Nodes[$physicalHostIndex].descendantConnection.nodes[$mssqlInstanceIndex].id = "FETCH"
            $query.Field.Nodes[$physicalHostIndex].descendantConnection.Nodes[$mssqlInstanceIndex].Cluster = New-Object RubrikSecurityCloud.Types.Cluster
            $query.Field.Nodes[$physicalHostIndex].descendantConnection.Nodes[$mssqlInstanceIndex].Cluster.name = "FETCH"
            $query.Field.Nodes[$physicalHostIndex].descendantConnection.Nodes[$mssqlInstanceIndex].Cluster.id = "FETCH"
            $query.Field.Nodes[$physicalHostIndex].descendantConnection.Nodes[$mssqlInstanceIndex].effectiveSlaDomain = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaReply
            $query.Field.Nodes[$physicalHostIndex].descendantConnection.Nodes[$mssqlInstanceIndex].effectiveSlaDomain.name = "FETCH"
            $query.Field.Nodes[$physicalHostIndex].descendantConnection.Nodes[$mssqlInstanceIndex].effectiveSlaDomain.id = "FETCH"

            
            $query.Field.Nodes[$windowsClusterIndex].cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
            $query.Field.Nodes[$windowsClusterIndex].cluster.name = "FETCH"
            $query.Field.Nodes[$windowsClusterIndex].cluster.id = "FETCH"
            $query.Field.Nodes[$windowsClusterIndex].effectiveSlaDomain = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaReply
            $query.Field.Nodes[$windowsClusterIndex].effectiveSlaDomain.name = "FETCH"
            $query.Field.Nodes[$windowsClusterIndex].effectiveSlaDomain.id = "FETCH"
            $query.Field.Nodes[$windowsClusterIndex].Vars.descendantConnection.typeFilter = [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::MSSQL_INSTANCE
            $query.field.Nodes[$windowsClusterIndex].descendantConnection = New-Object RubrikSecurityCloud.Types.WindowsClusterDescendantTypeConnection
            $query.field.Nodes[$windowsClusterIndex].descendantConnection.nodes = New-Object -TypeName RubrikSecurityCloud.Types.MssqlInstance
            
            $mssqlInstanceIndex = $query.field.nodes[$windowsClusterIndex].descendantConnection.Nodes.FindIndex({param($item) $item.gettype().name -eq "MssqlInstance"})
            $query.Field.Nodes[$windowsClusterIndex].descendantConnection.Nodes[$mssqlInstanceIndex].Cluster = New-Object RubrikSecurityCloud.Types.Cluster
            $query.Field.Nodes[$windowsClusterIndex].descendantConnection.Nodes[$mssqlInstanceIndex].Cluster.name = "FETCH"
            $query.Field.Nodes[$windowsClusterIndex].descendantConnection.Nodes[$mssqlInstanceIndex].Cluster.id = "FETCH"
            $query.Field.Nodes[$windowsClusterIndex].descendantConnection.Nodes[$mssqlInstanceIndex].effectiveSlaDomain = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaReply
            $query.Field.Nodes[$windowsClusterIndex].descendantConnection.Nodes[$mssqlInstanceIndex].effectiveSlaDomain.name = "FETCH"
            $query.Field.Nodes[$windowsClusterIndex].descendantConnection.Nodes[$mssqlInstanceIndex].effectiveSlaDomain.id = "FETCH"
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
