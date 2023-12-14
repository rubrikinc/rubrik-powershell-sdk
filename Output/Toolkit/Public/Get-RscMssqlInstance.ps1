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

    .PARAMETER RscHost
    RscHost object retrieved via Get-RscHost

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
            ParameterSetName = "RscHost",
            Mandatory = $false
        )][RubrikSecurityCloud.Types.PhysicalHost]$RscHost,

        [Parameter(
            ParameterSetName = "RscHost",
            Mandatory = $false
        )][String]$InstanceName = "MSSQLSERVER",
        
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
        Write-Debug "-Running Get-RscMssqlInstance"

        #region Create Query
        switch ( $PSCmdlet.ParameterSetName){
            "List"{
                Write-Debug "-  Creating List Query"
                $query = New-RscQueryMssql -Op TopLevelDescendants -FieldProfile $fieldProfile
                $query.Var.filter = @()
                $query.Var.typeFilter = "PhysicalHost"
            }
            "RscHost"{
                Write-Debug "-  Creating Host Query"
                $query = New-RscQueryMssql -Op TopLevelDescendants -FieldProfile $fieldProfile
                $query.Var.filter = @()
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $RscHost.Name
                $query.Var.filter += $nameFilter
            }
            "Id"  {
                Write-Debug "-  Creating Id Query"
                $query = New-RscQueryMssql -Op Instance -FieldProfile $fieldProfile -AddField PhysicalPath
                $query.Var.filter = @()
                $query.Var.fid = $id
            }
        }

        if($RscCluster){
            Write-Debug "-  Creating Cluster Filter"
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
            $clusterFilter.texts = $RscCluster.Id
            $query.Var.filter += $clusterFilter
        }
        #endregion
        if ($AsQuery){
            $result = $query.GqlRequest()
        }else{
            $result = Get-RscPages -Query $query
        }
        # $result = $query.Invoke()
        
        switch ( $PSCmdlet.ParameterSetName ){
            "RscHost" {
                Write-Debug "-  Filtering results based on Instance Name"
                $result = $result | Where-Object {$_.PhysicalChildConnection.Nodes.Name -eq $InstanceName}
            }
        }
        
        $result
    } 
}
