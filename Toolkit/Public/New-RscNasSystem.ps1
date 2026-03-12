#Requires -Version 3
function New-RscNasSystem {
    <#
    .SYNOPSIS
    Registers a new NAS system with Rubrik Security Cloud.

    .DESCRIPTION
    Adds a NAS system to RSC for protection. Use one of the vendor-type switches (-Generic, -Isilon, -NetApp, -NutanixFileServer, or -FlashBlade) to specify the system type, which determines the available configuration options and required credentials. Once registered, shares on the NAS system will be discovered automatically or can be added manually with New-RscNasShare.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Cluster
    A Rubrik cluster object to filter by. Pipe from Get-RscCluster.

    .PARAMETER Hostname
    The hostname or IP address of the NAS system.

    .PARAMETER Generic
    Register a generic NAS system.

    .PARAMETER Isilon
    Register a Dell Isilon (PowerScale) NAS system.

    .PARAMETER NetApp
    Register a NetApp NAS system.

    .PARAMETER NutanixFileServer
    Register a Nutanix File Server NAS system.

    .PARAMETER FlashBlade
    Register a Pure Storage FlashBlade NAS system.

    .PARAMETER IsilonChangelistEnabled
    Enable changelist-based backups for all shares on an Isilon NAS system.

    .PARAMETER HasNfsSupport
    Enable NFS protocol support on this NAS system.

    .PARAMETER HasSmbSupport
    Enable SMB protocol support on this NAS system.

    .PARAMETER ApiUsername
    Username for the vendor-specific NAS management API.

    .PARAMETER ApiPassword
    Password for the vendor-specific NAS management API.

    .PARAMETER SmbUsername
    Username for SMB share access.

    .PARAMETER SmbPassword
    Password for SMB share access.

    .PARAMETER ApiToken
    API token for Pure Storage FlashBlade integration.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

Return the query object instead of executing it.

    .EXAMPLE
    Register a generic NAS system with NFS support.

    $cluster = Get-RscCluster -Name "MyCluster"
    $cluster | New-RscNasSystem -Generic -Hostname "10.0.181.171" -HasNfsSupport

    .EXAMPLE
    Register a NetApp NAS system with API and SMB credentials.

    $cluster = Get-RscCluster -Name "MyCluster"
    New-RscNasSystem -Cluster $cluster -NetApp -Hostname "netapp01.example.com" -ApiUsername "admin" -ApiPassword "secret" -SmbUsername "smbuser" -SmbPassword "smbpass"
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
        $mutation = New-RscMutation -Gql registerNasSystem
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