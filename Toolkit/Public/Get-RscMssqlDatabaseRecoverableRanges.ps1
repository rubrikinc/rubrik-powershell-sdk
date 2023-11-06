#Requires -Version 3
function Get-RscMssqlDatabaseRecoverableRanges {
    <#
    .SYNOPSIS
    Return a list of ranges of dates that shows when a database can be recovered to. 

    .DESCRIPTION
    Return a list of ranges of dates that shows when a database can be recovered to. The returned information will reflect similar information that is displayed in the Rubrik Security Cloud
    UI. Points between the begin and end times can be recovered to any point in time inside that range. 

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase

    .PARAMETER afterTime
    Used to filter ranges 
    
    .PARAMETER beforeTime
    Used to filter ranges 

    .PARAMETER Detail
    Changes the data profile. This can affect the fields returned

    .PARAMETER IncludeNullProperties
    By default, fields will a NULL are not returned. Supplying this parameter will return all fields, including fields
    with a NULL in them. 

    .PARAMETER AsQuery
    Instead of running the command, the query and variables used for the query will be returned. 

    .EXAMPLE
    Returns all of the ranges the database can be recovered to. 
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoverableRanges -RscMssqlDatabase $RscMssqlDatabase

    .EXAMPLE
    Returns all of the ranges the database can be recovered to filtered to be only after a specific date/time
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoverableRanges -RscMssqlDatabase $RscMssqlDatabase -afterTime

    .EXAMPLE
    Returns all of the ranges the database can be recovered to filtered to be only before a specific date/time
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoverableRanges -RscMssqlDatabase $RscMssqlDatabase -beforeTime
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,
        
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false
        )][datetime]$afterTime,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false
        )][datetime]$beforeTime,

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
        Write-Host "Get-RscMssqlDatabaseRecoverableRanges field profile: $fieldProfile"

        $query = New-RscQueryMssql -Operation RecoverableRanges -FieldProfile $fieldProfile -AddField Data.BeginTime, Data.EndTime
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.GetMssqlDbRecoverableRangesInput
        $query.Var.input.id = $RscMssqlDatabase.id
        if($PSBoundParameters.ContainsKey('afterTime')){
            $query.Var.input.afterTime = $afterTime
        }
        if($PSBoundParameters.ContainsKey('beforeTime')){
            $query.Var.input.beforeTime = $beforeTime
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
