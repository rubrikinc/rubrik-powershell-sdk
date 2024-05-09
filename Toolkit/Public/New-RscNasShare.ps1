#Requires -Version 3
function New-RscNasShare {
    <#
    .SYNOPSIS
    Add Nas shares that were not automatically discovered to a NAS system.

    .DESCRIPTION
    This cmdlet can be used to manually bulk add NAS shares that couldn't
    be automatically discovered when adding the NAS system.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER NasSystemId
    The ID of the NAS system where shares will be added.

    .PARAMETER NasShares
    The list of NAS shares to be added. Create input objects using New-RscNasShareInput.

    .PARAMTER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    $createNasShare = New-RscNasShareInput -ShareType NFS -ExportPoint "/test_mounts/100_mb"
    New-RscNasShare -NasSystemId "b951f770-4519-5820-a451-5b2ff4a50f26" -NasShares @($createNasShare)
     #>
    [CmdletBinding()]
    Param(
        # The ID of the NAS system.
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [String]$NasSystemId,

        # The list of NAS shares to be added.
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [RubrikSecurityCloud.Types.CreateNasShareInput[]]$NasShares,

        # Should Cmdlet return the query object instead of running it.
        [Parameter(Mandatory = $false)]
        [Switch]$AsQuery
    )

    Process {
        $mutation = New-RscMutationNas -Operation BulkAddNasShares `
            -AddField RefreshNasSharesStatus
        $mutation.Var.Input =
            New-Object -TypeName RubrikSecurityCloud.Types.BulkAddNasSharesInput
        $mutation.Var.Input.BulkAddNasShareInput =
            New-Object -TypeName RubrikSecurityCloud.Types.BulkAddNasSharesRequestInput
        $mutation.Var.Input.BulkAddNasShareInput.NasSourceId = $NasSystemId
        $mutation.Var.Input.BulkAddNasShareInput.NasShares = $NasShares

        if ($AsQuery) {
            return $mutation
        }

        $result = Invoke-Rsc -Query $mutation
        $result
    }
}
