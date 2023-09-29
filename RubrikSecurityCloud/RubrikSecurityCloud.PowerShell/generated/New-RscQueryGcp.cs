// New-RscQueryGcp.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 16
    /// operations in the 'Google Cloud Platform' API domain:
    /// CloudAccountMissingPermissionsForAddition, CloudAccountProjectsByFeature, CloudAccountProjectsForOauth, FeaturePermissionsForCloudAccount, GetDefaultCredentialsServiceAccount, NativeAvailableKmsCryptoKeys, NativeCompatibleMachineTypes, NativeNetworks, NativeProjectsWithAccessibleNetworks, NativeRegions, NativeStoredMachineTypes, NativeStoredMachineTypesInProject, NativeStoredNetworkNames, NativeStoredNetworkNamesInProject, NativeStoredRegions, or NativeStoredRegionsInProject.
    /// </summary>
    /// <description>
    /// New-RscQueryGcp creates a new
    /// query object for operations
    /// in the 'Google Cloud Platform' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 16 operations
    /// in the 'Google Cloud Platform' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -CloudAccountMissingPermissionsForAddition, -CloudAccountProjectsByFeature, -CloudAccountProjectsForOauth, -FeaturePermissionsForCloudAccount, -GetDefaultCredentialsServiceAccount, -NativeAvailableKmsCryptoKeys, -NativeCompatibleMachineTypes, -NativeNetworks, -NativeProjectsWithAccessibleNetworks, -NativeRegions, -NativeStoredMachineTypes, -NativeStoredMachineTypesInProject, -NativeStoredNetworkNames, -NativeStoredNetworkNamesInProject, -NativeStoredRegions, -NativeStoredRegionsInProject.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op CloudAccountMissingPermissionsForAddition,
    /// which is equivalent to specifying -CloudAccountMissingPermissionsForAddition.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryGcp -CloudAccountMissingPermissionsForAddition).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryGcp -CloudAccountMissingPermissionsForAddition).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CloudAccountMissingPermissionsForAddition operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CloudAccountMissingPermissionsForAddition
    /// 
    /// $query = New-RscQueryGcp -CloudAccountMissingPermissionsForAddition
    /// 
    /// # REQUIRED
    /// $query.Var.sessionId = $someString
    /// # REQUIRED
    /// $query.Var.projectIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GcpCloudAccountMissingPermissionsForAddition&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountProjectsByFeature operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CloudAccountProjectsByFeature
    /// 
    /// $query = New-RscQueryGcp -CloudAccountProjectsByFeature
    /// 
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.projectStatusFilters = @(
    /// 	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.projectSearchText = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GcpCloudAccountProjectDetail&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountProjectsForOauth operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: CloudAccountProjectsForOauth
    /// 
    /// $query = New-RscQueryGcp -CloudAccountProjectsForOauth
    /// 
    /// # REQUIRED
    /// $query.Var.sessionId = $someString
    /// # REQUIRED
    /// $query.Var.features = @(
    /// 	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.checkPermissions = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GcpCloudAccountProjectForOauth&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FeaturePermissionsForCloudAccount operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: FeaturePermissionsForCloudAccount
    /// 
    /// $query = New-RscQueryGcp -FeaturePermissionsForCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GcpPermission&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetDefaultCredentialsServiceAccount operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: GetDefaultCredentialsServiceAccount
    /// 
    /// $query = New-RscQueryGcp -GetDefaultCredentialsServiceAccount
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeAvailableKmsCryptoKeys operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeAvailableKmsCryptoKeys
    /// 
    /// $query = New-RscQueryGcp -NativeAvailableKmsCryptoKeys
    /// 
    /// # REQUIRED
    /// $query.Var.projectId = $someString
    /// # REQUIRED
    /// $query.Var.regionName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GcpNativeKmsCryptoKey&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeCompatibleMachineTypes operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeCompatibleMachineTypes
    /// 
    /// $query = New-RscQueryGcp -NativeCompatibleMachineTypes
    /// 
    /// # REQUIRED
    /// $query.Var.targetZone = $someString
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeNetworks operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeNetworks
    /// 
    /// $query = New-RscQueryGcp -NativeNetworks
    /// 
    /// # REQUIRED
    /// $query.Var.projectId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GcpNativeNetwork&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeProjectsWithAccessibleNetworks operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeProjectsWithAccessibleNetworks
    /// 
    /// $query = New-RscQueryGcp -NativeProjectsWithAccessibleNetworks
    /// 
    /// # REQUIRED
    /// $query.Var.projectId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;NetworkHostProject&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeRegions operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeRegions
    /// 
    /// $query = New-RscQueryGcp -NativeRegions
    /// 
    /// # REQUIRED
    /// $query.Var.projectId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GcpNativeRegion&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeStoredMachineTypes operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeStoredMachineTypes
    /// 
    /// $query = New-RscQueryGcp -NativeStoredMachineTypes
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeStoredMachineTypesInProject operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeStoredMachineTypesInProject
    /// 
    /// $query = New-RscQueryGcp -NativeStoredMachineTypesInProject
    /// 
    /// # REQUIRED
    /// $query.Var.projectId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeStoredNetworkNames operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeStoredNetworkNames
    /// 
    /// $query = New-RscQueryGcp -NativeStoredNetworkNames
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeStoredNetworkNamesInProject operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeStoredNetworkNamesInProject
    /// 
    /// $query = New-RscQueryGcp -NativeStoredNetworkNamesInProject
    /// 
    /// # REQUIRED
    /// $query.Var.projectId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeStoredRegions operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeStoredRegions
    /// 
    /// $query = New-RscQueryGcp -NativeStoredRegions
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeStoredRegionsInProject operation
    /// of the 'Google Cloud Platform' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Gcp
    /// # API Operation: NativeStoredRegionsInProject
    /// 
    /// $query = New-RscQueryGcp -NativeStoredRegionsInProject
    /// 
    /// # REQUIRED
    /// $query.Var.projectId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryGcp",
        DefaultParameterSetName = "NativeRegions")
    ]
    public class New_RscQueryGcp : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "CloudAccountMissingPermissionsForAddition",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'CloudAccountMissingPermissionsForAddition' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
Check GCP projects permissions for addition.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpcloudaccountmissingpermissionsforaddition.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CloudAccountMissingPermissionsForAddition { get; set; }

        
        [Parameter(
            ParameterSetName = "CloudAccountProjectsByFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'CloudAccountProjectsByFeature' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of GCP projects configured for a feature.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpcloudaccountprojectsbyfeature.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CloudAccountProjectsByFeature { get; set; }

        
        [Parameter(
            ParameterSetName = "CloudAccountProjectsForOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'CloudAccountProjectsForOauth' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of GCP projects to add after successful authorization.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpcloudaccountprojectsforoauth.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CloudAccountProjectsForOauth { get; set; }

        
        [Parameter(
            ParameterSetName = "FeaturePermissionsForCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'FeaturePermissionsForCloudAccount' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of permissions required to enable the given feature.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allfeaturepermissionsforgcpcloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter FeaturePermissionsForCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "GetDefaultCredentialsServiceAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'GetDefaultCredentialsServiceAccount' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
Returns the service account corresponding to global credentials. Return empty string if global credentials are absent
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/gcpgetdefaultcredentialsserviceaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter GetDefaultCredentialsServiceAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeAvailableKmsCryptoKeys",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeAvailableKmsCryptoKeys' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of GCP KMS Crypto keys accessible in the provided region.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativeavailablekmscryptokeys.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeAvailableKmsCryptoKeys { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeCompatibleMachineTypes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeCompatibleMachineTypes' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of compatible machine types for instance.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativecompatiblemachinetypes.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeCompatibleMachineTypes { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeNetworks",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeNetworks' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of networks available in a GCP project along with subnetworks and firewall rules.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativenetworks.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeNetworks { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeProjectsWithAccessibleNetworks",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeProjectsWithAccessibleNetworks' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of all the GCP projects with accessible networks in this service project.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativeprojectswithaccessiblenetworks.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeProjectsWithAccessibleNetworks { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeRegions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeRegions' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of regions available to a GCP project along with zones.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativeregions.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeRegions { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeStoredMachineTypes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeStoredMachineTypes' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of all the distinct machine types of the GCP instances stored with Polaris.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativestoredmachinetypes.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeStoredMachineTypes { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeStoredMachineTypesInProject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeStoredMachineTypesInProject' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of all the distinct machine types of the GCP instances stored with Polaris.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativestoredmachinetypesinproject.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeStoredMachineTypesInProject { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeStoredNetworkNames",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeStoredNetworkNames' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of all the distinct network names of the GCP instances stored with Polaris.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativestorednetworknames.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeStoredNetworkNames { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeStoredNetworkNamesInProject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeStoredNetworkNamesInProject' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of all the distinct network names of the GCP instances stored with Polaris.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativestorednetworknamesinproject.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeStoredNetworkNamesInProject { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeStoredRegions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeStoredRegions' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of all the distinct regions of the GCP instances stored with Polaris.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativestoredregions.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeStoredRegions { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeStoredRegionsInProject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeStoredRegionsInProject' operation
in the 'Google Cloud Platform' API domain.
Description of the operation:
List of all the distinct regions of the GCP instances stored with Polaris.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allgcpnativestoredregionsinproject.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeStoredRegionsInProject { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "CloudAccountMissingPermissionsForAddition":
                        this.ProcessRecord_CloudAccountMissingPermissionsForAddition();
                        break;
                    case "CloudAccountProjectsByFeature":
                        this.ProcessRecord_CloudAccountProjectsByFeature();
                        break;
                    case "CloudAccountProjectsForOauth":
                        this.ProcessRecord_CloudAccountProjectsForOauth();
                        break;
                    case "FeaturePermissionsForCloudAccount":
                        this.ProcessRecord_FeaturePermissionsForCloudAccount();
                        break;
                    case "GetDefaultCredentialsServiceAccount":
                        this.ProcessRecord_GetDefaultCredentialsServiceAccount();
                        break;
                    case "NativeAvailableKmsCryptoKeys":
                        this.ProcessRecord_NativeAvailableKmsCryptoKeys();
                        break;
                    case "NativeCompatibleMachineTypes":
                        this.ProcessRecord_NativeCompatibleMachineTypes();
                        break;
                    case "NativeNetworks":
                        this.ProcessRecord_NativeNetworks();
                        break;
                    case "NativeProjectsWithAccessibleNetworks":
                        this.ProcessRecord_NativeProjectsWithAccessibleNetworks();
                        break;
                    case "NativeRegions":
                        this.ProcessRecord_NativeRegions();
                        break;
                    case "NativeStoredMachineTypes":
                        this.ProcessRecord_NativeStoredMachineTypes();
                        break;
                    case "NativeStoredMachineTypesInProject":
                        this.ProcessRecord_NativeStoredMachineTypesInProject();
                        break;
                    case "NativeStoredNetworkNames":
                        this.ProcessRecord_NativeStoredNetworkNames();
                        break;
                    case "NativeStoredNetworkNamesInProject":
                        this.ProcessRecord_NativeStoredNetworkNamesInProject();
                        break;
                    case "NativeStoredRegions":
                        this.ProcessRecord_NativeStoredRegions();
                        break;
                    case "NativeStoredRegionsInProject":
                        this.ProcessRecord_NativeStoredRegionsInProject();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // allGcpCloudAccountMissingPermissionsForAddition.
        internal void ProcessRecord_CloudAccountMissingPermissionsForAddition()
        {
            this._logger.name += " -CloudAccountMissingPermissionsForAddition";
            // Create new graphql operation allGcpCloudAccountMissingPermissionsForAddition
            InitQueryAllGcpCloudAccountMissingPermissionsForAddition();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpCloudAccountProjectsByFeature.
        internal void ProcessRecord_CloudAccountProjectsByFeature()
        {
            this._logger.name += " -CloudAccountProjectsByFeature";
            // Create new graphql operation allGcpCloudAccountProjectsByFeature
            InitQueryAllGcpCloudAccountProjectsByFeature();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpCloudAccountProjectsForOauth.
        internal void ProcessRecord_CloudAccountProjectsForOauth()
        {
            this._logger.name += " -CloudAccountProjectsForOauth";
            // Create new graphql operation allGcpCloudAccountProjectsForOauth
            InitQueryAllGcpCloudAccountProjectsForOauth();
        }

        // This parameter set invokes a single graphql operation:
        // allFeaturePermissionsForGcpCloudAccount.
        internal void ProcessRecord_FeaturePermissionsForCloudAccount()
        {
            this._logger.name += " -FeaturePermissionsForCloudAccount";
            // Create new graphql operation allFeaturePermissionsForGcpCloudAccount
            InitQueryAllFeaturePermissionsForGcpCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // gcpGetDefaultCredentialsServiceAccount.
        internal void ProcessRecord_GetDefaultCredentialsServiceAccount()
        {
            this._logger.name += " -GetDefaultCredentialsServiceAccount";
            // Create new graphql operation gcpGetDefaultCredentialsServiceAccount
            InitQueryGcpGetDefaultCredentialsServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeAvailableKmsCryptoKeys.
        internal void ProcessRecord_NativeAvailableKmsCryptoKeys()
        {
            this._logger.name += " -NativeAvailableKmsCryptoKeys";
            // Create new graphql operation allGcpNativeAvailableKmsCryptoKeys
            InitQueryAllGcpNativeAvailableKmsCryptoKeys();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeCompatibleMachineTypes.
        internal void ProcessRecord_NativeCompatibleMachineTypes()
        {
            this._logger.name += " -NativeCompatibleMachineTypes";
            // Create new graphql operation allGcpNativeCompatibleMachineTypes
            InitQueryAllGcpNativeCompatibleMachineTypes();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeNetworks.
        internal void ProcessRecord_NativeNetworks()
        {
            this._logger.name += " -NativeNetworks";
            // Create new graphql operation allGcpNativeNetworks
            InitQueryAllGcpNativeNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeProjectsWithAccessibleNetworks.
        internal void ProcessRecord_NativeProjectsWithAccessibleNetworks()
        {
            this._logger.name += " -NativeProjectsWithAccessibleNetworks";
            // Create new graphql operation allGcpNativeProjectsWithAccessibleNetworks
            InitQueryAllGcpNativeProjectsWithAccessibleNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeRegions.
        internal void ProcessRecord_NativeRegions()
        {
            this._logger.name += " -NativeRegions";
            // Create new graphql operation allGcpNativeRegions
            InitQueryAllGcpNativeRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeStoredMachineTypes.
        internal void ProcessRecord_NativeStoredMachineTypes()
        {
            this._logger.name += " -NativeStoredMachineTypes";
            // Create new graphql operation allGcpNativeStoredMachineTypes
            InitQueryAllGcpNativeStoredMachineTypes();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeStoredMachineTypesInProject.
        internal void ProcessRecord_NativeStoredMachineTypesInProject()
        {
            this._logger.name += " -NativeStoredMachineTypesInProject";
            // Create new graphql operation allGcpNativeStoredMachineTypesInProject
            InitQueryAllGcpNativeStoredMachineTypesInProject();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeStoredNetworkNames.
        internal void ProcessRecord_NativeStoredNetworkNames()
        {
            this._logger.name += " -NativeStoredNetworkNames";
            // Create new graphql operation allGcpNativeStoredNetworkNames
            InitQueryAllGcpNativeStoredNetworkNames();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeStoredNetworkNamesInProject.
        internal void ProcessRecord_NativeStoredNetworkNamesInProject()
        {
            this._logger.name += " -NativeStoredNetworkNamesInProject";
            // Create new graphql operation allGcpNativeStoredNetworkNamesInProject
            InitQueryAllGcpNativeStoredNetworkNamesInProject();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeStoredRegions.
        internal void ProcessRecord_NativeStoredRegions()
        {
            this._logger.name += " -NativeStoredRegions";
            // Create new graphql operation allGcpNativeStoredRegions
            InitQueryAllGcpNativeStoredRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allGcpNativeStoredRegionsInProject.
        internal void ProcessRecord_NativeStoredRegionsInProject()
        {
            this._logger.name += " -NativeStoredRegionsInProject";
            // Create new graphql operation allGcpNativeStoredRegionsInProject
            InitQueryAllGcpNativeStoredRegionsInProject();
        }


        // Create new GraphQL Query:
        // allGcpCloudAccountMissingPermissionsForAddition(sessionId: String!, projectIds: [String!]!): [GcpCloudAccountMissingPermissionsForAddition!]!
        internal void InitQueryAllGcpCloudAccountMissingPermissionsForAddition()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sessionId", "String!"),
                Tuple.Create("projectIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpCloudAccountMissingPermissionsForAddition",
                "($sessionId: String!,$projectIds: [String!]!)",
                "List<GcpCloudAccountMissingPermissionsForAddition>",
                Query.AllGcpCloudAccountMissingPermissionsForAddition_ObjectFieldSpec,
                Query.AllGcpCloudAccountMissingPermissionsForAdditionFieldSpec,
                @"# REQUIRED
$query.Var.sessionId = $someString
# REQUIRED
$query.Var.projectIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allGcpCloudAccountProjectsByFeature(feature: CloudAccountFeature!, projectStatusFilters: [CloudAccountStatus!]!, projectSearchText: String!): [GcpCloudAccountProjectDetail!]!
        internal void InitQueryAllGcpCloudAccountProjectsByFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("projectStatusFilters", "[CloudAccountStatus!]!"),
                Tuple.Create("projectSearchText", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpCloudAccountProjectsByFeature",
                "($feature: CloudAccountFeature!,$projectStatusFilters: [CloudAccountStatus!]!,$projectSearchText: String!)",
                "List<GcpCloudAccountProjectDetail>",
                Query.AllGcpCloudAccountProjectsByFeature_ObjectFieldSpec,
                Query.AllGcpCloudAccountProjectsByFeatureFieldSpec,
                @"# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.projectStatusFilters = @(
	$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
# REQUIRED
$query.Var.projectSearchText = $someString"
            );
        }

        // Create new GraphQL Query:
        // allGcpCloudAccountProjectsForOauth(sessionId: String!, features: [CloudAccountFeature!]!, checkPermissions: Boolean!): [GcpCloudAccountProjectForOauth!]!
        internal void InitQueryAllGcpCloudAccountProjectsForOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sessionId", "String!"),
                Tuple.Create("features", "[CloudAccountFeature!]!"),
                Tuple.Create("checkPermissions", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpCloudAccountProjectsForOauth",
                "($sessionId: String!,$features: [CloudAccountFeature!]!,$checkPermissions: Boolean!)",
                "List<GcpCloudAccountProjectForOauth>",
                Query.AllGcpCloudAccountProjectsForOauth_ObjectFieldSpec,
                Query.AllGcpCloudAccountProjectsForOauthFieldSpec,
                @"# REQUIRED
$query.Var.sessionId = $someString
# REQUIRED
$query.Var.features = @(
	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# REQUIRED
$query.Var.checkPermissions = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // allFeaturePermissionsForGcpCloudAccount(feature: CloudAccountFeature!): [GcpPermission!]!
        internal void InitQueryAllFeaturePermissionsForGcpCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllFeaturePermissionsForGcpCloudAccount",
                "($feature: CloudAccountFeature!)",
                "List<GcpPermission>",
                Query.AllFeaturePermissionsForGcpCloudAccount_ObjectFieldSpec,
                Query.AllFeaturePermissionsForGcpCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // gcpGetDefaultCredentialsServiceAccount: String!
        internal void InitQueryGcpGetDefaultCredentialsServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryGcpGetDefaultCredentialsServiceAccount",
                "",
                "System.String",
                Query.GcpGetDefaultCredentialsServiceAccount_ObjectFieldSpec,
                Query.GcpGetDefaultCredentialsServiceAccountFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeAvailableKmsCryptoKeys(projectId: UUID!, regionName: String!): [GcpNativeKmsCryptoKey!]!
        internal void InitQueryAllGcpNativeAvailableKmsCryptoKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("projectId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeAvailableKmsCryptoKeys",
                "($projectId: UUID!,$regionName: String!)",
                "List<GcpNativeKmsCryptoKey>",
                Query.AllGcpNativeAvailableKmsCryptoKeys_ObjectFieldSpec,
                Query.AllGcpNativeAvailableKmsCryptoKeysFieldSpec,
                @"# REQUIRED
$query.Var.projectId = $someString
# REQUIRED
$query.Var.regionName = $someString"
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeCompatibleMachineTypes(targetZone: String!, snapshotId: UUID!): [String!]!
        internal void InitQueryAllGcpNativeCompatibleMachineTypes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("targetZone", "String!"),
                Tuple.Create("snapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeCompatibleMachineTypes",
                "($targetZone: String!,$snapshotId: UUID!)",
                "List<System.String>",
                Query.AllGcpNativeCompatibleMachineTypes_ObjectFieldSpec,
                Query.AllGcpNativeCompatibleMachineTypesFieldSpec,
                @"# REQUIRED
$query.Var.targetZone = $someString
# REQUIRED
$query.Var.snapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeNetworks(projectId: UUID!): [GcpNativeNetwork!]!
        internal void InitQueryAllGcpNativeNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("projectId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeNetworks",
                "($projectId: UUID!)",
                "List<GcpNativeNetwork>",
                Query.AllGcpNativeNetworks_ObjectFieldSpec,
                Query.AllGcpNativeNetworksFieldSpec,
                @"# REQUIRED
$query.Var.projectId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeProjectsWithAccessibleNetworks(projectId: UUID!): [NetworkHostProject!]!
        internal void InitQueryAllGcpNativeProjectsWithAccessibleNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("projectId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeProjectsWithAccessibleNetworks",
                "($projectId: UUID!)",
                "List<NetworkHostProject>",
                Query.AllGcpNativeProjectsWithAccessibleNetworks_ObjectFieldSpec,
                Query.AllGcpNativeProjectsWithAccessibleNetworksFieldSpec,
                @"# REQUIRED
$query.Var.projectId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeRegions(projectId: UUID!): [GcpNativeRegion!]!
        internal void InitQueryAllGcpNativeRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("projectId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeRegions",
                "($projectId: UUID!)",
                "List<GcpNativeRegion>",
                Query.AllGcpNativeRegions_ObjectFieldSpec,
                Query.AllGcpNativeRegionsFieldSpec,
                @"# REQUIRED
$query.Var.projectId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeStoredMachineTypes: [String!]!
        internal void InitQueryAllGcpNativeStoredMachineTypes()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeStoredMachineTypes",
                "",
                "List<System.String>",
                Query.AllGcpNativeStoredMachineTypes_ObjectFieldSpec,
                Query.AllGcpNativeStoredMachineTypesFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeStoredMachineTypesInProject(projectId: UUID!): [String!]!
        internal void InitQueryAllGcpNativeStoredMachineTypesInProject()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("projectId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeStoredMachineTypesInProject",
                "($projectId: UUID!)",
                "List<System.String>",
                Query.AllGcpNativeStoredMachineTypesInProject_ObjectFieldSpec,
                Query.AllGcpNativeStoredMachineTypesInProjectFieldSpec,
                @"# REQUIRED
$query.Var.projectId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeStoredNetworkNames: [String!]!
        internal void InitQueryAllGcpNativeStoredNetworkNames()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeStoredNetworkNames",
                "",
                "List<System.String>",
                Query.AllGcpNativeStoredNetworkNames_ObjectFieldSpec,
                Query.AllGcpNativeStoredNetworkNamesFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeStoredNetworkNamesInProject(projectId: UUID!): [String!]!
        internal void InitQueryAllGcpNativeStoredNetworkNamesInProject()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("projectId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeStoredNetworkNamesInProject",
                "($projectId: UUID!)",
                "List<System.String>",
                Query.AllGcpNativeStoredNetworkNamesInProject_ObjectFieldSpec,
                Query.AllGcpNativeStoredNetworkNamesInProjectFieldSpec,
                @"# REQUIRED
$query.Var.projectId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeStoredRegions: [String!]!
        internal void InitQueryAllGcpNativeStoredRegions()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeStoredRegions",
                "",
                "List<System.String>",
                Query.AllGcpNativeStoredRegions_ObjectFieldSpec,
                Query.AllGcpNativeStoredRegionsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allGcpNativeStoredRegionsInProject(projectId: UUID!): [String!]!
        internal void InitQueryAllGcpNativeStoredRegionsInProject()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("projectId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllGcpNativeStoredRegionsInProject",
                "($projectId: UUID!)",
                "List<System.String>",
                Query.AllGcpNativeStoredRegionsInProject_ObjectFieldSpec,
                Query.AllGcpNativeStoredRegionsInProjectFieldSpec,
                @"# REQUIRED
$query.Var.projectId = $someString"
            );
        }


    } // class New_RscQueryGcp
}