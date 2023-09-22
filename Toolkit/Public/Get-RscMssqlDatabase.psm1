#Requires -Version 3
function Get-RscMssqlDatabase {
    <#
    .SYNOPSIS
    Get SQL Server Databases

    .DESCRIPTION
    Get SQL Server Databases

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Get-RscMssqlDatabase
    or
    Get-RscMssqlDatabase -List
    Return back a list of SQL Server databases. Host and Instance information is located in PhysicalPath section

    .EXAMPLE
    Get-RscMssqlDatabase -Name master

    Return all databases with the name master. 

    .EXAMPLE
    Get-RscMssqlDatabase -Name master -InstanceID "f2c15060-85a5-54c4-95e7-7c4a948a3e19"

    Return the master database on a specific SQL Server Instance. InstanceId can be retrieved by using Get-RscMssqlInstance

    # .EXAMPLE
    # Get-RscMssqlDatabaseCRL -name master -InstanceID "f2c15060-85a5-54c4-95e7-7c4a948a3e19" -clusterId "39b92c18-d897-4b55-a7f9-17ff178616d0"

    Return the master database on a specific SQL Server Instance. InstanceId can be retrieved by using Get-RscMssqlInstance, and clusterId can be retrieved by using Get-RscCluster
    #>

    [CmdletBinding(DefaultParameterSetName = "List")]
    Param(
        # List parameter set:
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [Switch]$List,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [String]$Name,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false
        )]
        [Parameter(
            ParameterSetName = "RscMssqlInstance",
            Mandatory = $false, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.PhysicalHost]$RscMssqlInstance, 

        [Parameter(
            ParameterSetName = "RscMssqlInstanceId",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false
        )]
        [String]$RscMssqlInstanceId
    )

    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        #region Filters
        $query = New-RscGqlQueryMssqlDatabases -Patch Nodes.PhysicalPath
        $query.Var.filter = @()
        switch ( $PSCmdlet.ParameterSetName){
            "List" {
                
            }
            "Name" {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $Name
                $query.Var.filter += $nameFilter
            }
        }
        #endregion

        
        $result = $query.Invoke()

        If ( $PSBoundParameters.ContainsKey('RscMssqlInstance') ) {
            $Instance = $RscMssqlInstance.PhysicalChildConnection.Nodes | Where-Object {$_.ObjectType -eq "MSSQL_INSTANCE"}
            $result = $result.Nodes | Where-Object { $_.PhysicalPath.Fid -eq $Instance.Id }
        }

        # if ([bool]($result.PSobject.Properties.name -match "Nodes")){
        if ($null -ne $result.Nodes){
            $result.Nodes #| Remove-NullProperties
        }else{
            $result #| Remove-NullProperties
        }
    } 
}
