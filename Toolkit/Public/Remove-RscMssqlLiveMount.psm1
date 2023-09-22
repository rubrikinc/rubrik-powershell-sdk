#Requires -Version 3
function Remove-RscMssqlLiveMount {
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
            Mandatory = $false, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabaseLiveMount]$MssqlLiveMount, 

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $false
        )]
        [Switch]$Force 

    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        #region Create Query
        $query = New-RscGqlMutationDeleteMssqlLiveMount
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.DeleteMssqlLiveMountInput

        $query.Var.input.id = "$($MssqlLiveMount.Fid)"
        $query.Var.input.force = $force

        $query.Invoke()
    } 
}
