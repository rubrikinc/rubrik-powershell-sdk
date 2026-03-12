#Requires -Version 3
function Set-RscNasShare {
    <#
    .SYNOPSIS
    Updates the properties of one or more NAS shares in Rubrik Security Cloud.

    .DESCRIPTION
    Bulk-updates the configuration of registered NAS shares. Use New-RscNasShareInput to create the update input objects with the desired property changes, then pass them to this cmdlet. This is useful for changing export points, enabling changelist, or updating credentials on existing shares.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER NasShares
    One or more NAS share update input objects. Create with New-RscNasShareInput.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    $updatedNasShare = New-RscNasShareInput -ExportPoint "/test_mounts/100_mb"
    -NasShareId "d93ddffc-5a70-53f4-9cfa-be54ebeaa5cb"
    -NasSourceId "4322ac6a-8be6-59cb-82e4-fa163fb426e3"
    -IsilonChangelistEnabled

Return the query object instead of executing it.

    .EXAMPLE
    Update a NAS share's export point and enable Isilon changelist.

    $update = New-RscNasShareInput -ExportPoint "/test_mounts/100_mb" -NasShareId "d93ddffc-5a70-53f4-9cfa-be54ebeaa5cb" -NasSourceId "4322ac6a-8be6-59cb-82e4-fa163fb426e3" -IsilonChangelistEnabled
    Set-RscNasShare -NasShares @($update)

    .EXAMPLE
    Bulk-update multiple NAS shares.

    $share1 = New-RscNasShareInput -NasShareId "id1" -NasSourceId "src1" -ExportPoint "/new/path1"
    $share2 = New-RscNasShareInput -NasShareId "id2" -NasSourceId "src2" -ExportPoint "/new/path2"
    Set-RscNasShare -NasShares @($share1, $share2)
    #>

    [CmdletBinding()]
    Param(
        # The list of NAS shares to be updated.
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [RubrikSecurityCloud.Types.UpdateNasShareInput[]]$NasShares,

        # Should Cmdlet return the query object instead of running it.
        [Parameter(Mandatory = $false)]
        [Switch]$AsQuery
    )

    Process {
        $mutation = New-RscMutation -Gql bulkUpdateNasShares
        $mutation.Var.Input =
            New-Object -TypeName RubrikSecurityCloud.Types.BulkUpdateNasSharesInput
        $mutation.Var.Input.BulkUpdateNasShareInput =
            New-Object -TypeName RubrikSecurityCloud.Types.BulkUpdateNasSharesRequestInput
        $mutation.Var.Input.BulkUpdateNasShareInput.NasShares = $NasShares

        $mutation.Field.RefreshNasSharesStatuses = @(New-Object -TypeName `
            RubrikSecurityCloud.Types.AsyncRequestStatus)
        $mutation.Field.RefreshNasSharesStatuses[0].Id = "FETCH"
        $mutation.Field.RefreshNasSharesStatuses[0].NodeId = "FETCH"
        $mutation.Field.RefreshNasSharesStatuses[0].Progress = 1.0
        $mutation.Field.RefreshNasSharesStatuses[0].Status = "FETCH"
        $mutation.Field.RefreshNasSharesStatuses[0].Error =
            New-Object -TypeName RubrikSecurityCloud.Types.RequestErrorInfo
        $mutation.Field.RefreshNasSharesStatuses[0].Error.Message = "FETCH"

        $mutation.Field.ShareDetails = @(New-Object -TypeName `
            RubrikSecurityCloud.Types.NasShareDetail)
        $mutation.Field.ShareDetails[0].Id = "FETCH"
        $mutation.Field.ShareDetails[0].ExportPoint = "FETCH"
        $mutation.Field.ShareDetails[0].ShareType =
            [RubrikSecurityCloud.Types.NasShareDetailShareType]::NAS_SHARE_DETAIL_SHARE_TYPE_SMB

        if ($AsQuery) {
            return $mutation
        }

        $result = Invoke-Rsc -Query $mutation
        $result
    }
}