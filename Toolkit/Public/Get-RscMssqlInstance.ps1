#Requires -Version 3
function Get-RscMssqlInstance{
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

    .PARAMETER HostType
    Can be either Host or FCI. 

    If Host, then you will need to supply RscHost
    If FCI, then you will need to supply WindowsClusterName

    .PARAMETER RscHost
    RscHost object retrieved via Get-RscHost

    .PARAMETER WindowsClusterName
    Windows Cluster Name

    .PARAMETER InstanceName
    SQL Server Instance Name
    
    .PARAMETER Id
    Used to return a specific SQL Server Instance based on the Id assigned inside of Rubrik
    
    .PARAMETER RscCluster
    RscCluster object retrieved via Get-RscCluster

    .PARAMETER Detail
    Changes the data profile. This can affect the fields returned

    .EXAMPLE
    Returns a list of all SQL Server Instances connected to RSC
    Get-RscMssqlInstance -List

    .EXAMPLE
    Returns information about the default instance of SQL on a specific host
    $HostName = "rp-sql19s-001.demo.rubrik.com"
    $RscHost = Get-RscHost -Name $HostName -OsType Windows
    $RscMssqlInstance = Get-RscMssqlInstance -RscHost $RscHost
    
    .EXAMPLE
    Returns information about a specific instance of SQL on a specific host
    $HostName = "rp-sql19s-001.demo.rubrik.com"
    $RscHost = Get-RscHost -Name $HostName -OsType Windows
    $RscMssqlInstance = Get-RscMssqlInstance -RscHost $RscHost -InstanceName DEV01
    
        .EXAMPLE
    Return a RscMssqlInstance Object based on a specific MssqlInstance Id
    Get-RscMssqlInstance -Id "86da734b-2fee-4fdc-bdc8-a73ab5648f" 
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false
        )][Switch]$List,

        [Parameter(
            ParameterSetName = "HostType",
            Mandatory = $false
        )][ValidateSet("Host","FCI")]$HostType,

        [Parameter(ParameterSetName = "HostType")]
        [Parameter(
            ParameterSetName = "RscHost",
            Mandatory = $false
        )][RubrikSecurityCloud.Types.PhysicalHost]$RscHost,

        [Parameter(
            ParameterSetName = "HostType",
            Mandatory = $false
        )][String]$InstanceName = "MSSQLSERVER",

        [Parameter(ParameterSetName = "HostType")]
        [Parameter(
            ParameterSetName = "FCI",
            Mandatory = $false
        )][String]$WindowsClusterName,
        
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$Id,
       
        [Parameter(
            Mandatory = $false
        )][RubrikSecurityCloud.Types.Cluster]$RscCluster,

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Detail
    )
    Process {
        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Verbose "-Running Get-RscMssqlInstance"

        #region Create Query
        
        if ($PSCmdlet.ParameterSetName -eq 'List') {
            Write-Verbose "-  Creating List Query"
            $query = New-RscQueryMssql -Op TopLevelDescendants -FieldProfile $fieldProfile
            $query.Var.typeFilter = @()
            $query.Var.typeFilter += "PhysicalHost"
            $query.Var.typeFilter += "WindowsCluster"
        }
        
        if ($PSBoundParameters.ContainsKey('HostType')) {
            if ($PSBoundParameters.ContainsKey('RscHost')) {
                Write-Verbose "-  Creating Host Query"
                $query = New-RscQueryMssql -Operation TopLevelDescendants -FieldProfile $fieldProfile
                $query.Var.filter = @()
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $RscHost.Name
                $query.Var.filter += $nameFilter
            }
            if ($PSBoundParameters.ContainsKey('WindowsClusterName')) {
                Write-Verbose "-  Creating FCI Query"
                $query = New-RscQueryMssql -Operation TopLevelDescendants #-FieldProfile $fieldProfile
                $query.field.Nodes[4].LogicalChildConnection = New-Object RubrikSecurityCloud.Types.WindowsClusterLogicalChildTypeConnection
                $query.field.Nodes[4].LogicalChildConnection.SelectForRetrieval()
                $query.Var.filter = @()
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $WindowsClusterName
                $query.Var.filter += $nameFilter
            }
        }
        
        if ($PSBoundParameters.ContainsKey('Id')) {
            Write-Verbose "-  Creating Id Query"
            $query = New-RscQueryMssql -Operation Instance -FieldProfile $fieldProfile
            $query.Field.PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
            $query.Field.PhysicalPath.SelectForRetrieval()
            $query.Var.filter = @()
            $query.Var.fid = $id
        }
        
        if ($PSBoundParameters.ContainsKey('RscCluster')) {
            Write-Verbose "-  Creating Cluster Filter"
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
            $clusterFilter.texts = $RscCluster.Id
            $query.Var.filter += $clusterFilter
        }
        #endregion
        
        $results = $query.Invoke()
        if ($PSCmdlet.ParameterSetName -eq 'List') {
            $results.Nodes
        }
        
        if ($PSCmdlet.ParameterSetName -eq 'HostType') {
            if ($PSBoundParameters.ContainsKey('RscHost')) {
                $results = $results.Nodes.PhysicalChildConnection.Nodes | Where-Object {$_.Name -eq $InstanceName}
                $results
            }
            if ($PSBoundParameters.ContainsKey('WindowsClusterName')) {
                $results = $results.Nodes.LogicalChildConnection.Nodes | Where-Object {$_.Name -eq $InstanceName}
                $results
            }
        }
        if ($PSBoundParameters.ContainsKey('Id')) {
            $results
        }
    } 
}
