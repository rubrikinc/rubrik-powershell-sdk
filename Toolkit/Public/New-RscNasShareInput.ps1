#Requires -Version 3
function New-RscNasShareInput {
    <#
    .SYNOPSIS
    Creates an input object for creating or updating a NAS share.

    .DESCRIPTION
    Builds a typed input that describes a NAS share for registration or
    modification. When ShareType and ExportPoint are provided, a create
    input is returned for use with New-RscNasShare. When NasShareId is
    provided, an update input is returned for use with Set-RscNasShare.
    Credentials are attached automatically when Username or Password are
    supplied.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Username
    Username for authenticating to the NAS server and share.

    .PARAMETER Password
    Password for the NAS user account.

    .PARAMETER ShareType
    Protocol type of the NAS share (NFS or SMB). Required when creating a new share.

    .PARAMETER ExportPoint
    The NFS export path or SMB share name (e.g. "/exports/data" or "ShareName").
    Required when creating a new share.

    .PARAMETER IsilonChangelistEnabled
    Enable the Isilon changelist feature for this share. Only applies when updating.

    .PARAMETER NasShareId
    ID of an existing NAS share to update. Switches to update mode.

    .PARAMETER NasSourceId
    Managed ID of the NAS system or namespace that owns the share being updated.

    .EXAMPLE
    Create an NFS share input and register it.

    $input = New-RscNasShareInput -ShareType NFS -ExportPoint "/test_mounts/100_mb"
    New-RscNasShare -Input $input -NasSourceId "4322ac6a-8be6-59cb-82e4-fa163fb426e3"

    .EXAMPLE
    Update an existing NAS share to enable Isilon changelist.

    $input = New-RscNasShareInput -ExportPoint "/test_mounts/100_mb" `
        -NasShareId "d93ddffc-5a70-53f4-9cfa-be54ebeaa5cb" `
        -NasSourceId "4322ac6a-8be6-59cb-82e4-fa163fb426e3" `
        -IsilonChangelistEnabled
    Set-RscNasShare -Input $input
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
