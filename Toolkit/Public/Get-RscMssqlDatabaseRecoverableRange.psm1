<#
    This cmdlet has been ported from
    https://github.com/rubrikinc/rubrik-sdk-for-powershell/blob/devel/Rubrik/Public/Get-RubrikDatabaseRecoveryPoint.ps1
#>

#Requires -Version 3
function Get-RscMssqlDatabaseRecoverableRange {
    <#  
        .SYNOPSIS
        

        .DESCRIPTION
        
        .PARAMETER RscMssqlDatabaseID
        
        .PARAMETER Latest
        .PARAMETER Latest
        
        .PARAMETER RestoreTime
        
        .NOTES


        .LINK
        Schema reference:
        https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

        MssqlRecoverPointInput Type:
        https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/mssqlrecoverypointinput.doc.html

        .EXAMPLE
        

        .EXAMPLE
        .EXAMPLE
        
        .EXAMPLE
        
    #>
    param(
        # Rubrik's database id value
        [Parameter(
            Position = 0,
            Mandatory = $true,
            ValueFromPipeline = $true)]
        [ValidateNotNullOrEmpty()] 
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase
    )
    # Re-use existing connection, or create a new one:
    Connect-Rsc -ErrorAction Stop | Out-Null

    #region Create query
    $query = New-RscGqlQueryMssqlRecoverableRanges -Patch Data.begintime, data.endtime
    $query.Var.input.id = $RscMssqlDatabase.id
    #endregion
    
    $result = $query.Invoke()

    if ($null -ne $result.Data){
        $result.Data #| Remove-NullProperties
    }else{
        $result #| Remove-NullProperties
    }
}