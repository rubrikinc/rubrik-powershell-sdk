#Requires -Version 3
function Get-RscMssqlDatabase {
    <#
    .SYNOPSIS
    Returns information about a MSSQL Database

    .DESCRIPTION
    Returns information about a MSSQL Database

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Return a list of MSSQL Databases
    Get-RscMssqlDatabase -List

    .EXAMPLE
    Return a list of MSSQL Databases named AdventureWorks2019
    Get-RscMssqlDatabase -Name AdventureWorks2019

    .EXAMPLE
    Return a list of MSSQL Databases named AdventureWorks2019 on the SQL 2019 Instance
    $RscMssqlInstance = Get-RscMssqlInstance -HostName sql19.demo.com -clusterID hja87-ajb43-v4avna-hnjag
    Get-RscMssqlDatabase -Name AdventureWorks2019 -RscMssqlInstance $RscMssqlInstance

    .EXAMPLE
    Return back all fields, including the fields that are null
    
    Get-RscMssqlDatabase -Name AdventureWorks2019 -IncludeNullProperties

    .EXAMPLE
    Return back just the query that will be run instead of running the query and returning the results

    Get-RscMssqlDatabase -Name AdventureWorks2019 -AsQuery   

    #>

    [CmdletBinding(
        # ___ Example ___
        DefaultParameterSetName = "List"
    )]
    Param(
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
        )][String]$Name,

        [Parameter(ParameterSetName = "Name", Mandatory = $false)]
        [Parameter(
            ParameterSetName = "RscMssqlInstance",
            Mandatory = $false, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.PhysicalHost]$RscMssqlInstance, 

        [Parameter(ParameterSetName = "Name", Mandatory = $false)]
        [Parameter(
            ParameterSetName = "RscMssqlInstanceId",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$RscMssqlInstanceId,
        
        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Detail,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$IncludeNullProperties,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$AsQuery
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Get-RscMssqlDatabase field profile: $fieldProfile"

        #region Create Query
        switch ( $PSCmdlet.ParameterSetName){
            "List" {
                $query = New-RscQueryMssql -Op Databases -FieldProfile $fieldProfile -AddField Nodes.PhysicalPath 
            }
            "Name"{
                $query = New-RscQueryMssql -Op Databases -FieldProfile $fieldProfile `
                    -AddField Nodes.PhysicalPath, `
                    Nodes.PostBackupScript, `
                    Nodes.PreBackupScript, `
                    Nodes.ConfiguredSlaDomain, `
                    Nodes.CopyOnly, `
                    Nodes.HostLogRetention, `
                    Nodes.LogBackupFrequencyInSeconds, `
                    Nodes.LogBackupRetentionInHours       
                $query.Var.filter = @()
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
        If ( $PSBoundParameters.ContainsKey('RscMssqlInstanceId') ) {
            $result = $result.Nodes | Where-Object { $_.PhysicalPath.Fid -eq $RscMssqlInstanceId }
        }


        if ( $AsQuery -eq $true ) {
            $result = $query.GqlRequest()
        }else{
            $result = $query.Invoke()
        }

        if ($null -ne $result.Nodes){
            if ( $IncludeNullProperties -eq $true ) {
                $result.Nodes
            }else{
                $result.Nodes | Remove-NullProperties
            }
        }else{
            if ( $IncludeNullProperties -eq $true ) {
                $result
            }else{
                $result | Remove-NullProperties
            }
        }  
    } 
}
