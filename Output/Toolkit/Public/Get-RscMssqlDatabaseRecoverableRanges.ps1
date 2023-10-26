#Requires -Version 3
function Get-RscMssqlDatabaseRecoverableRanges {
    <#
    .SYNOPSIS
    ___ Add synopsis here ___

    .DESCRIPTION
    ___ Add description here ___

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    ___ Add example here ___
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

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$Detail
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
        $result = $query.Invoke()

        if ($null -ne $result.Data){
            $result.Data #| Remove-NullProperties
        }else{
            $result #| Remove-NullProperties
        }
    } 
}
