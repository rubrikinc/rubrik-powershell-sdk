#Requires -Version 3
function New-RscMssqlLogBackup {
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

    [CmdletBinding(
    )]
    Param(
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase
    )
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        #region Create Query
        $query = New-RscGqlMutationTakeMssqlLogBackup  
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.TakeMssqlLogBackupInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"
        #endregion
        
        $query.Invoke()

    } 
}
