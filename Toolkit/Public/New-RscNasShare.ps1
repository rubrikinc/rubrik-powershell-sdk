#Requires -Version 3
function New-RscNasShare {
    <#
    .SYNOPSIS
    Adds NAS shares to an existing NAS system in Rubrik Security Cloud.

    .DESCRIPTION
    Manually registers NAS shares that were not automatically discovered when the NAS system was added. This is useful for shares that require manual configuration or that are added after the initial NAS system registration. Create share input objects with New-RscNasShareInput.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER NasSystemId
    The RSC object ID of the NAS system where shares will be added.

    .PARAMETER NasShares
    One or more NAS share input objects to add. Create with New-RscNasShareInput.

    .PARAMETER AsQuery
    Return the query object instead of executing it.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Add a single NFS share to a NAS system.

    $share = New-RscNasShareInput -ShareType NFS -ExportPoint "/test_mounts/100_mb"
    New-RscNasShare -NasSystemId "b951f770-4519-5820-a451-5b2ff4a50f26" -NasShares @($share)

    .EXAMPLE
    Add multiple shares at once.

    $nfs = New-RscNasShareInput -ShareType NFS -ExportPoint "/data/exports"
    $smb = New-RscNasShareInput -ShareType SMB -ExportPoint "\\server\share"
    New-RscNasShare -NasSystemId "b951f770-4519-5820-a451-5b2ff4a50f26" -NasShares @($nfs, $smb)
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
        $mutation = New-RscMutation -Gql bulkAddNasShares `
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
