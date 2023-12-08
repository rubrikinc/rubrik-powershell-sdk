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

    .PARAMETER List
    Used to create a list of Databases
    
    .PARAMETER Name
    Used to return a specific Database based on the name

    .PARAMETER RscMssqlInstance
    SQL Server Instance Object returned from Get-RscMssqlInstance


    .PARAMETER Detail
    Changes the data profile. This can affect the fields returned

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
    #>

    [CmdletBinding(
        # ___ Example ___
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false
        )]
        [Switch]$List,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false
        )][String]$Name,

        [Parameter(
            Mandatory = $false
        )][RubrikSecurityCloud.Types.PhysicalHost]$RscMssqlInstance, 

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false
        )][Switch]$Detail
    )
    
    Process {
        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Debug "- Running Get-RscMssqlDatabase"

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
            $result = $result | Where-Object {$_.PhysicalPath.Fid -eq $RscMssqlInstance.id}    
        }

        $result        
    } 
}
