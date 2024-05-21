#Requires -Version 3
function Set-RscNasSystem {
    <#
    .SYNOPSIS
    Update host name of the NAS system or credentials to
    access vendor specific APIs.

    .DESCRIPTION
    This cmdlet can be used to update the properties of a NAS system.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Id
    ID of the registered NAS system.

    .PARAMETER NasSystem
    The object representing the NAS system that needs to be updated.

    .PARAMETER Hostname
    The updated hostname of the NAS system.

    .PARAMETER IsilonChangelistEnabled
    Specifies the default Changelist setting for all shares in the Isilon NAS system.

    .PARAMETER HasNfsSupport
    Specifies whether to enable NFS for this server.

    .PARAMETER HasSmbSupport
    Specifies whether to enable SMB for this server.

    .PARAMETER ApiUsername
    Username to access the vendor-specific NAS API.

    .PARAMETER ApiPassword
    Password associated with the NAS API user account.

    .PARAMETER SmbUsername
    Username to access the NAS server and share.

    .PARAMETER SmbPassword
    Password associated with the NAS user account.

    .PARAMETER ApiToken
    API token to add or update the Pure NAS system with API integration.

    .PARAMETER ResetGeneratedNamespaceSmbCredentials
    Whether to remove the system-generated (not user-supplied) SMB credentials
    in namespaces and recreate them.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Set-RscNasSystem "5dc44746-38d1-56d8-8570-a54b8dae0208"
    -Hostname "10.2.46.54" -ApiUsername "fuser-api" -ApiPassword "124@pass"
    -HasSmbSupport -SmbUsername "smb-user" -SmbPassword "98vsn@pass"

    .EXAMPLE
    $nasSystem = Get-RscNasSystem -Id 5dc44746-38d1-56d8-8570-a54b8dae0208
    $nasSystem | Set-RscNasSystem -Hostname "10.2.46.55"
    -ApiUsername "fuser-api" -ApiPassword "124@pass"
    -HasSmbSupport -SmbUsername "smb-user" -SmbPassword "98vsn@pass"
    #>

    [CmdletBinding(DefaultParameterSetName = "Id")]
    Param(
        # The ID of the NAS system.
        [Parameter(Mandatory = $true, ParameterSetName = "Id", Position = 0)]
        [ValidateNotNullOrEmpty()]
        [String]$Id,

        # The object representing the NAS system.
        [Parameter(Mandatory = $true, ParameterSetName = "NasSystem", ValueFromPipeline = $true)]
        [ValidateNotNullOrEmpty()]
        [RubrikSecurityCloud.Types.NasSystem]$NasSystem,

        # Host name or IP address.
        [Parameter(Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [String]$Hostname,

        # NFS supported.
        [Parameter()]
        [Switch]$HasNfsSupport,

        # SMB supported.
        [Parameter()]
        [Switch]$HasSmbSupport,

        # SMB username.
        [Parameter()]
        [String]$SmbUsername,

        # SMB password.
        [Parameter()]
        [String]$SmbPassword,

        # Username to access the vendor-specific NAS API.
        [Parameter()]
        [ValidateNotNullOrEmpty()]
        [String]$ApiUsername,

        # Password associated with the NAS user account.
        [Parameter()]
        [ValidateNotNullOrEmpty()]
        [String]$ApiPassword,

        # API token to add or update the Pure NAS system with API integration.
        [Parameter()]
        [String]$ApiToken,

        # Should changelist be enabled.
        [Parameter(Mandatory = $false)]
        [Switch]$IsilonChangelistEnabled,

        # Should reset generated namespace Smb credentials.
        [Parameter(Mandatory = $false)]
        [Switch]$ResetGeneratedNamespaceSmbCredentials,

        # Should Cmdlet return the query object instead of running it.
        [Parameter(Mandatory = $false)]
        [Switch]$AsQuery
    )

    Process {
        $NasVendorType = $null

        $mutation = New-RscMutationNas -Operation UpdateNasSystem `
            -AddField Hostname, VendorType
        $mutation.Var.Input =
            New-Object -TypeName RubrikSecurityCloud.Types.UpdateNasSystemInput

        Switch ($PSCmdlet.ParameterSetName) {
            "Id" {
                $NasVendorType = (Get-RscNasSystem -Id $Id).VendorType
                $mutation.Var.Input.Id = $Id
            }
            "NasSystem" {
                $NasVendorType = $NasSystem.VendorType
                $mutation.Var.Input.Id = $NasSystem.Id
            }
        }

        $mutation.Var.Input.NasSystemUpdateProperties =
            New-Object -TypeName RubrikSecurityCloud.Types.NasSystemUpdateInput

        if ($Hostname -ne "") {
            $mutation.Var.Input.NasSystemUpdateProperties.Hostname = $Hostname
        }
        
        Switch ($NasVendorType) {
            "GENERIC" {
                $mutation.Var.Input.NasSystemUpdateProperties.GenericNasSystemParameters =
                    New-Object -TypeName RubrikSecurityCloud.Types.GenericNasSystemParametersInput

                $mutation.Var.Input.NasSystemUpdateProperties.GenericNasSystemParameters.HasNfsSupport = $false
                $mutation.Var.Input.NasSystemUpdateProperties.GenericNasSystemParameters.HasSmbSupport = $false
                if ($HasNfsSupport) {
                    $mutation.Var.Input.NasSystemUpdateProperties.GenericNasSystemParameters.HasNfsSupport = $true
                }
                if ($HasSmbSupport) {
                    $mutation.Var.Input.NasSystemUpdateProperties.GenericNasSystemParameters.HasSmbSupport = $true

                    $mutation.Var.Input.NasSystemUpdateProperties.GenericNasSystemParameters.SmbCredentials =
                        New-Object -TypeName RubrikSecurityCloud.Types.GenericNasSystemCredentialsInput
                    $mutation.Var.Input.NasSystemUpdateProperties.GenericNasSystemParameters.SmbCredentials.Username = $SmbUsername
                    $mutation.Var.Input.NasSystemUpdateProperties.GenericNasSystemParameters.SmbCredentials.Password = $SmbPassword
                }
            }
            "ISILON" {
                $mutation.Var.Input.NasSystemUpdateProperties.NasApiCredentials =
                    New-Object -TypeName RubrikSecurityCloud.Types.NasApiCredentialsInput
                $mutation.Var.Input.NasSystemUpdateProperties.NasApiCredentials.ApiUsername = $ApiUsername
                $mutation.Var.Input.NasSystemUpdateProperties.NasApiCredentials.ApiPassword = $ApiPassword

                $mutation.Var.Input.NasSystemUpdateProperties.SmbCredentials =
                    New-Object -TypeName RubrikSecurityCloud.Types.NasShareCredentialsInput
                $mutation.Var.Input.NasSystemUpdateProperties.SmbCredentials.Username = $SmbUsername
                $mutation.Var.Input.NasSystemUpdateProperties.SmbCredentials.Password = $SmbPassword

                if ($IsilonChangelistEnabled) {
                    $mutation.Var.Input.NasSystemUpdateProperties.IsIsilonChangelistEnabled = $true
                }
            }
            "NETAPP" {
                $mutation.Var.Input.NasSystemUpdateProperties.NasApiCredentials =
                    New-Object -TypeName RubrikSecurityCloud.Types.NasApiCredentialsInput
                $mutation.Var.Input.NasSystemUpdateProperties.NasApiCredentials.ApiUsername = $ApiUsername
                $mutation.Var.Input.NasSystemUpdateProperties.NasApiCredentials.ApiPassword = $ApiPassword

                $mutation.Var.Input.NasSystemUpdateProperties.SmbCredentials =
                    New-Object -TypeName RubrikSecurityCloud.Types.NasShareCredentialsInput
                $mutation.Var.Input.NasSystemUpdateProperties.SmbCredentials.Username = $SmbUsername
                $mutation.Var.Input.NasSystemUpdateProperties.SmbCredentials.Password = $SmbPassword
            }
            "FLASHBLADE" {
                $mutation.Var.Input.NasSystemUpdateProperties.NasFlashBladeApiCredentials =
                    New-Object -TypeName RubrikSecurityCloud.Types.FlashBladeSystemParametersInput

                $mutation.Var.Input.NasSystemUpdateProperties.NasFlashBladeApiCredentials.ApiToken = $ApiToken

                $mutation.Var.Input.NasSystemUpdateProperties.NasFlashBladeApiCredentials.HasSmbSupport = $false
                if ($HasSmbSupport) {
                    $mutation.Var.Input.NasSystemUpdateProperties.NasFlashBladeApiCredentials.HasSmbSupport = $true

                    $mutation.Var.Input.NasSystemUpdateProperties.NasFlashBladeApiCredentials.SmbCredentials =
                        New-Object -TypeName RubrikSecurityCloud.Types.GenericNasSystemCredentialsInput
                    $mutation.Var.Input.NasSystemUpdateProperties.NasFlashBladeApiCredentials.SmbCredentials.Username = $SmbUsername
                    $mutation.Var.Input.NasSystemUpdateProperties.NasFlashBladeApiCredentials.SmbCredentials.Password = $SmbPassword
                }
            }
            "NUTANIX_FILE_SERVER" {
                $mutation.Var.Input.NasSystemUpdateProperties.NutanixFileServerParameters =
                    New-Object -TypeName RubrikSecurityCloud.Types.NutanixFileServerParametersInput

                $mutation.Var.Input.NasSystemUpdateProperties.NutanixFileServerParameters.HasSmbSupport = $false
                if ($HasSmbSupport) {
                    $mutation.Var.Input.NasSystemUpdateProperties.NutanixFileServerParameters.HasSmbSupport = $true

                    $mutation.Var.Input.NasSystemUpdateProperties.NutanixFileServerParameters.SmbCredentials =
                        New-Object -TypeName RubrikSecurityCloud.Types.GenericNasSystemCredentialsInput
                    $mutation.Var.Input.NasSystemUpdateProperties.NutanixFileServerParameters.SmbCredentials.Username = $SmbUsername
                    $mutation.Var.Input.NasSystemUpdateProperties.NutanixFileServerParameters.SmbCredentials.Password = $SmbPassword
                }

                $mutation.Var.Input.NasSystemUpdateProperties.NutanixFileServerParameters.ApiUsername = $ApiUsername
                $mutation.Var.Input.NasSystemUpdateProperties.NutanixFileServerParameters.ApiPassword = $ApiPassword
            }
        }
        
        if ($AsQuery) {
            return $mutation
        }

        $result = Invoke-Rsc -Query $mutation
        $result
    }
}