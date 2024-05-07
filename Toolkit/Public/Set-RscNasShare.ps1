#Requires -Version 3
function Set-RscNasShare {
    <#
    .SYNOPSIS
    Update the properties of Nas share objectgs.
    
    .DESCRIPTION
    This cmdlet can be used to bulk update the configuration of the
    specified NAS shares.
    
    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference
    
    .PARAMETER NasShares
    The list of NAS shares to be updated. Create input objects using New-RscNasShareInput.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.
    
    .EXAMPLE
    $updatedNasShare = New-RscNasShareInput -ExportPoint "/test_mounts/100_mb"
    -NasShareId "d93ddffc-5a70-53f4-9cfa-be54ebeaa5cb"
    -NasSourceId "4322ac6a-8be6-59cb-82e4-fa163fb426e3"
    -IsilonChangelistEnabled

    Set-RscNasShare -NasShares @($updatedNasShare)
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
        $mutation = New-RscMutationNas -Operation BulkUpdateNasShares
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