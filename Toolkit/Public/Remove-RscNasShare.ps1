#Requires -Version 3
function Remove-RscNasShare {
    <#
    .SYNOPSIS
    Use this cmdlet to bulk delete multiple NAS shares.

    .DESCRIPTION
    This cmdlet initiates the delete operation for the specified NAS shares.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Ids
    The list of NAS shares to be deleted.

    .PARAMETER NasShares
    The objects representing NAS shares to be deleted.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Remove-RscNasShare -Ids @("b951f770-4519-5820-a451-5b2ff4a50f26", "b951f770-4519-5820-a451-5b2ff4a50f27")

    .EXAMPLE
    Use the powershell pipe to delete the NAS shares.

    $nasShares = Get-RscNasShare -Id "d93ddffc-5a70-53f4-9cfa-be54ebeaa5cb"
    $nasShares | Remove-RscNasShare
    #>

    [CmdletBinding(DefaultParameterSetName = "Id")]
    Param(
        # The IDs of NAS shares to be deleted.
        [Parameter(
            Mandatory = $true,
            HelpMessage = "The IDs of NAS shares to be deleted",
            ParameterSetName = "Id"
        )]
        [ValidateNotNullOrEmpty()]
        [String[]]$Ids,

        # The objects representing NAS shares to be deleted.
        [Parameter(
            ParameterSetName = "NasShare",
            Mandatory = $true,
            ValueFromPipeline = $true,
            HelpMessage = "The objects representing NAS shares to be deleted"
        )]
        [RubrikSecurityCloud.Types.NasShare[]]$NasShares,

        # Should Cmdlet return the query object instead of running it.
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )]
        [Switch]$AsQuery
    )

    Process {
        $mutation = New-RscMutationNas -Operation BulkDeleteNasShares

        if ($PsCmdlet.ParameterSetName -eq "NasShare") {
            $Ids = $NasShares | ForEach-Object { $_.Id }
        }
        $mutation.Var.Input =
            New-Object -TypeName RubrikSecurityCloud.Types.BulkDeleteNasSharesInput
        $mutation.Var.Input.BulkDeleteNasShareRequest =
            New-Object -TypeName RubrikSecurityCloud.Types.BulkDeleteNasSharesRequestInput
        $mutation.Var.Input.BulkDeleteNasShareRequest.Ids = $Ids

        if ($AsQuery) {
            return $mutation
        }

        $result = Invoke-Rsc -Query $mutation
        $result
    }
}
