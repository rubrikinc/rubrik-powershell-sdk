#Requires -Version 3
function New-RscNasSystem {
    <#
    .SYNOPSIS
    Used to register a NAS system with Rubrik Security Cloud (RSC)
    to protect it.

    .DESCRIPTION
    This cmdlet can be used to add new NAS systems to RSC. Use one of the
    many switch parameters to specify the vendor type which will unlock
    additional vendor specific configuration options.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Cluster
    The object representing the Rubrik Cdm cluster.

    .PARAMETER Hostname
    The host name or IP address of the NAS system.

    .PARAMETER Generic
    Use this switch when registering a Generic NAS system.

    .PARAMETER Isilon
    Use this switch when registering an Isilon NAS system.

    .PARAMETER NetApp
    Use this switch when registering an NetApp NAS system.

    .PARAMETER NutanixFileServer
    Use this switch when registering an Nutanix File Server NAS system.
    
    .PARAMETER FlashBlade
    Use this switch when registering an FlashBlade NAS system.

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

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    $cluster = Get-RscCluter -Name "Foo"
    $cluster | New-RscNasSystem -Generic -Hostname "10.0.181.171" -HasNfsSupport
    #>

    [CmdletBinding()]
    Param(
        # The object representing the Rubrik Cdm cluster.
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateNotNullOrEmpty()]
        [RubrikSecurityCloud.Types.Cluster]$Cluster,

        # The switch parameters below are used to determine the NAS Vendor type.

        # Use for adding a Generic NAS system.
        [Parameter(ParameterSetName = "Generic", Mandatory = $true)]
        [Switch]$Generic,

        # Use for adding an Isilon NAS system.
        [Parameter(ParameterSetName = "Isilon", Mandatory = $true)]
        [Switch]$Isilon,

        # Use for adding a NetApp NAS system.
        [Parameter(ParameterSetName = "NetApp", Mandatory = $true)]
        [Switch]$NetApp,

        # Use for adding a Nutanix File Server NAS system.
        [Parameter(ParameterSetName = "NutanixFS", Mandatory = $true)]
        [Switch]$NutanixFileServer,

        # Use for adding a Flash Blade NAS system.
        [Parameter(ParameterSetName = "FlashBlade", Mandatory = $true)]
        [Switch]$FlashBlade,

        # Host name or IP address.
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [String]$Hostname,

        # Should changelist be enabled.
        [Parameter(ParameterSetName = "Isilon", Mandatory = $false)]
        [Switch]$IsilonChangelistEnabled,

        # NFS supported.
        [Parameter(ParameterSetName = "Generic")]
        [Switch]$HasNfsSupport,

        # SMB supported.
        [Parameter(ParameterSetName = "Generic")]
        [Parameter(ParameterSetName = "FlashBlade")]
        [Parameter(ParameterSetName = "NutanixFS")]
        [Switch]$HasSmbSupport,

        # SMB username.
        [Parameter()]
        [String]$SmbUsername,

        # SMB password.
        [Parameter()]
        [String]$SmbPassword,
        
        # Username to access the vendor-specific NAS API.
        [Parameter(Mandatory = $true, ParameterSetName = "NutanixFS")]
        [Parameter(Mandatory = $true, ParameterSetName = "Isilon")]
        [Parameter(Mandatory = $true, ParameterSetName = "NetApp")]
        [ValidateNotNullOrEmpty()]
        [String]$ApiUsername,

        # Password associated with the NAS user account.
        [Parameter(Mandatory = $true, ParameterSetName = "NutanixFS")]
        [Parameter(Mandatory = $true, ParameterSetName = "Isilon")]
        [Parameter(Mandatory = $true, ParameterSetName = "NetApp")]
        [ValidateNotNullOrEmpty()]
        [String]$ApiPassword,

        # API token to add or update the Pure NAS system with API integration.
        [Parameter(ParameterSetName = "FlashBlade", Mandatory = $true)]
        [String]$ApiToken,

        # Should Cmdlet return the query object instead of running it.
        [Parameter(Mandatory = $false)]
        [Switch]$AsQuery
    )

    Process {
        $mutation = New-RscMutationNas -Operation RegisterNasSystem
        $mutation.Var.Input =
            New-Object -TypeName RubrikSecurityCloud.Types.RegisterNasSystemInput
        $mutation.Var.Input.ClusterUuid = $Cluster.Id
        $mutation.Var.Input.NasSystem =
            New-Object -TypeName RubrikSecurityCloud.Types.NasSystemRegisterInput
        $mutation.Var.Input.NasSystem.Hostname = $Hostname

        Switch ($PSCmdlet.ParameterSetName) {
            "Generic" {
                $mutation.Var.Input.NasSystem.NasVendorType =
                    [RubrikSecurityCloud.Types.NasVendorType]::NAS_VENDOR_TYPE_GENERIC
                
                $mutation.Var.Input.NasSystem.GenericNasSystemParameters =
                    New-Object -TypeName RubrikSecurityCloud.Types.GenericNasSystemParametersInput
                
                $mutation.Var.Input.NasSystem.GenericNasSystemParameters.HasNfsSupport = $false
                $mutation.Var.Input.NasSystem.GenericNasSystemParameters.HasSmbSupport = $false
                if ($HasNfsSupport) {
                    $mutation.Var.Input.NasSystem.GenericNasSystemParameters.HasNfsSupport = $true
                }
                if ($HasSmbSupport) {
                    $mutation.Var.Input.NasSystem.GenericNasSystemParameters.HasSmbSupport = $true

                    $mutation.Var.Input.NasSystem.GenericNasSystemParameters.SmbCredentials =
                        New-Object -TypeName RubrikSecurityCloud.Types.GenericNasSystemCredentialsInput
                    $mutation.Var.Input.NasSystem.GenericNasSystemParameters.SmbCredentials.Username = $SmbUsername
                    $mutation.Var.Input.NasSystem.GenericNasSystemParameters.SmbCredentials.Password = $SmbPassword
                }
            }
            "NetApp" {
                $mutation.Var.Input.NasSystem.NasVendorType =
                    [RubrikSecurityCloud.Types.NasVendorType]::NAS_VENDOR_TYPE_NETAPP
                
                $mutation.Var.Input.NasSystem.NasTmpApiCredentials =
                    New-Object -TypeName RubrikSecurityCloud.Types.NasApiCredentialsInput
                $mutation.Var.Input.NasSystem.NasTmpApiCredentials.ApiUsername = $ApiUsername
                $mutation.Var.Input.NasSystem.NasTmpApiCredentials.ApiPassword = $ApiPassword

                $mutation.Var.Input.NasSystem.SmbCredentials =
                    New-Object -TypeName RubrikSecurityCloud.Types.NasShareCredentialsInput
                $mutation.Var.Input.NasSystem.SmbCredentials.Username = $SmbUsername
                $mutation.Var.Input.NasSystem.SmbCredentials.Password = $SmbPassword
                
            }
            "Isilon" {
                $mutation.Var.Input.NasSystem.NasVendorType =
                    [RubrikSecurityCloud.Types.NasVendorType]::NAS_VENDOR_TYPE_ISILON
                
                $mutation.Var.Input.NasSystem.NasTmpApiCredentials =
                    New-Object -TypeName RubrikSecurityCloud.Types.NasApiCredentialsInput
                $mutation.Var.Input.NasSystem.NasTmpApiCredentials.ApiUsername = $ApiUsername
                $mutation.Var.Input.NasSystem.NasTmpApiCredentials.ApiPassword = $ApiPassword

                $mutation.Var.Input.NasSystem.SmbCredentials =
                    New-Object -TypeName RubrikSecurityCloud.Types.NasShareCredentialsInput
                $mutation.Var.Input.NasSystem.SmbCredentials.Username = $SmbUsername
                $mutation.Var.Input.NasSystem.SmbCredentials.Password = $SmbPassword

                if ($IsilonChangelistEnabled) {
                     $mutation.Var.Input.NasSystem.IsIsilonChangelistEnabled = $true
                }
            }
            "FlashBlade" {
                $mutation.Var.Input.NasSystem.NasVendorType =
                    [RubrikSecurityCloud.Types.NasVendorType]::NAS_VENDOR_TYPE_FLASHBLADE
                
                $mutation.Var.Input.NasSystem.NasFlashBladeApiCredentials =
                    New-Object -TypeName RubrikSecurityCloud.Types.FlashBladeSystemParametersInput
                
                $mutation.Var.Input.NasSystem.NasFlashBladeApiCredentials.ApiToken = $ApiToken

                $mutation.Var.Input.NasSystem.NasFlashBladeApiCredentials.HasSmbSupport = $false
                if ($HasSmbSupport) {
                    $mutation.Var.Input.NasSystem.NasFlashBladeApiCredentials.HasSmbSupport = $true

                    $mutation.Var.Input.NasSystem.NasFlashBladeApiCredentials.SmbCredentials =
                        New-Object -TypeName RubrikSecurityCloud.Types.GenericNasSystemCredentialsInput
                    $mutation.Var.Input.NasSystem.NasFlashBladeApiCredentials.SmbCredentials.Username = $SmbUsername
                    $mutation.Var.Input.NasSystem.NasFlashBladeApiCredentials.SmbCredentials.Password = $SmbPassword
                }
            }
            "NutanixFS" {
                $mutation.Var.Input.NasSystem.NasVendorType =
                    [RubrikSecurityCloud.Types.NasVendorType]::NAS_VENDOR_TYPE_NUTANIX_FILE_SERVER
                
                $mutation.Var.Input.NasSystem.NutanixFileServerParameters =
                    New-Object -TypeName RubrikSecurityCloud.Types.NutanixFileServerParametersInput
                
                $mutation.Var.Input.NasSystem.NutanixFileServerParameters.HasSmbSupport = $false
                if ($HasSmbSupport) {
                    $mutation.Var.Input.NasSystem.NutanixFileServerParameters.HasSmbSupport = $true

                    $mutation.Var.Input.NasSystem.NutanixFileServerParameters.SmbCredentials =
                        New-Object -TypeName RubrikSecurityCloud.Types.GenericNasSystemCredentialsInput
                    $mutation.Var.Input.NasSystem.NutanixFileServerParameters.SmbCredentials.Username = $SmbUsername
                    $mutation.Var.Input.NasSystem.NutanixFileServerParameters.SmbCredentials.Password = $SmbPassword
                }
                
                $mutation.Var.Input.NasSystem.NutanixFileServerParameters.ApiUsername = $ApiUsername
                $mutation.Var.Input.NasSystem.NutanixFileServerParameters.ApiPassword = $ApiPassword
            }
        }

        $mutation.Field.NasDiscoverJobStatus =
            New-Object -TypeName RubrikSecurityCloud.Types.AsyncRequestStatus
        $mutation.Field.NasDiscoverJobStatus.Id = "FETCH"
        $mutation.Field.NasDiscoverJobStatus.NodeId = "FETCH"
        $mutation.Field.NasDiscoverJobStatus.Progress = 1.0
        $mutation.Field.NasDiscoverJobStatus.Status = "FETCH"
        $mutation.Field.NasDiscoverJobStatus.Error =
            New-Object -TypeName RubrikSecurityCloud.Types.RequestErrorInfo
        $mutation.Field.NasDiscoverJobStatus.Error.Message = "FETCH"

        $mutation.Field.NasSystemSummary =
            New-Object -TypeName RubrikSecurityCloud.Types.UpdateNasSystemReply
        $mutation.Field.NasSystemSummary.Hostname = "FETCH"
        $mutation.Field.NasSystemSummary.Id = "FETCH"
        $mutation.Field.NasSystemSummary.VendorType =
            [RubrikSecurityCloud.Types.NasVendorType]::NAS_VENDOR_TYPE_FLASHBLADE

        if ($AsQuery) {
            return $mutation
        }

        $result = Invoke-Rsc -Query $mutation
        $result | Remove-NullProperties
    }
}