#Requires -Version 3
function New-RscNasShareInput {
    <#
    .SYNOPSIS
    Creates a new Input object for creating or updating a NAS Share.

    .DESCRIPTION
    The New-RscNasShareInput cmdlet creates a new Input object for creating or
    updating a NAS Share using New-RscNasShare or Set-RscNasShare cmdlets.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Username
    Username to access the NAS server and share.

    .PARAMETER Password
    Password associated with the NAS user account.

    .PARAMETER ShareType
    The type of NAS share.

    .PARAMETER ExportPoint
    The NFS export point or SMB share name for the NAS share.

    .PARAMETER IsilonChangelistEnabled
    Specifies whether the Isilon changelist is enabled for the share.

    .PARAMETER NasShareId
    ID of the NAS share that will be updated.

    .PARAMETER NasSourceId
    Managed ID of the NAS system or NAS namespace where shares will be updated.

    .EXAMPLE
    Input for creating NAS share with NFS share type.
    New-RscNasShareInput -ShareType NFS -ExportPoint "/test_mounts/100_mb"

    .EXAMPLE
    Input for updating NAS share.
    New-RscNasShareInput -ExportPoint "/test_mounts/100_mb"
    -NasShareId "d93ddffc-5a70-53f4-9cfa-be54ebeaa5cb"
    -NasSourceId "4322ac6a-8be6-59cb-82e4-fa163fb426e3"
    -IsilonChangelistEnabled
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Create"
    )]
    Param(
        # Username to access the NAS server and share.
        [Parameter(ParameterSetName = "Create")]
        [Parameter(ParameterSetName = "Update")]
        [String]$Username,

        # Password associated with the NAS user account.
        [Parameter(ParameterSetName = "Create")]
        [Parameter(ParameterSetName = "Update")]
        [String]$Password,

        # The type of NAS share.
        [Parameter(ParameterSetName = "Create", Mandatory = $true)]
        [ValidateSet('NFS', 'SMB')]
        [String]$ShareType,

        # The NFS export point or SMB share name for the NAS share.
        [Parameter(ParameterSetName = "Create", Mandatory = $true)]
        [Parameter(ParameterSetName = "Update", Mandatory = $false)]
        [String]$ExportPoint,

        # Specifies whether the Isilon changelist is enabled for the share.
        [Parameter(ParameterSetName = "Update")]
        [Switch]$IsilonChangelistEnabled,

        # ID of the NAS share that will be updated.
        [Parameter(ParameterSetName = "Update", Mandatory = $true)]
        [String]$NasShareId,

        # Managed ID of the NAS system or NAS namespace where shares will be updated.
        [Parameter(ParameterSetName = "Update")]
        [String]$NasSourceId
    )

    Process {
        $input = $null

        if ($PSCmdlet.ParameterSetName -eq 'Create') {
            $input = New-Object -TypeName RubrikSecurityCloud.Types.CreateNasShareInput
            $input.ShareType = [
                RubrikSecurityCloud.Types.CreateNasShareInputShareType]::CREATE_NAS_SHARE_INPUT_SHARE_TYPE_NFS
            if ($ShareType -eq 'SMB') {
                $input.ShareType = [
                    RubrikSecurityCloud.Types.CreateNasShareInputShareType]::CREATE_NAS_SHARE_INPUT_SHARE_TYPE_SMB
            }
        } else {
            $input = New-Object -TypeName RubrikSecurityCloud.Types.UpdateNasShareInput
            $input.Id = $NasShareId
            $input.NasSourceId = $NasSourceId
            if ($IsilonChangelistEnabled) {
                $input.IsIsilonChangelistEnabled = $true
            }
        }

        if ($Password -ne "" -or $Username -ne "") {
            $input.Credentials =
                New-Object -TypeName RubrikSecurityCloud.Types.NasShareCredentialsInput
            $input.Credentials.Username = $Username
            $input.Credentials.Password = $Password
        }

        $input.ExportPoint = $ExportPoint

        $input
    }
}
