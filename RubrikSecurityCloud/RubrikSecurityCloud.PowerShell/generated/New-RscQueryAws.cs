// New-RscQueryAws.cs
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
    /// Create a new RscQuery object for any of the 28
    /// operations in the 'AWS' API domain:
    /// ArtifactsToDelete, AvailabilityZonesByRegion, CdmVersions, CloudAccountConfigs, CloudAccountListSecurityGroups, CloudAccountListSubnets, CloudAccountListVpcs, CloudAccountWithFeatures, CloudAccountsWithFeatures, ComputeSettings, DbParameterGroupsByRegion, DbSubnetGroupsByRegion, Ec2KeyPairsByRegion, ExocomputeConfigs, InstanceProfileNames, IsS3BucketNameAvailable, KmsEncryptionKeysByRegion, OptionGroupsByRegion, PermissionPolicies, RdsInstanceDetails, Regions, S3BucketStateForRecovery, S3Buckets, S3BucketsDetails, SupportedRdsDatabaseInstanceClasses, TrustPolicy, Vpcs, or VpcsByRegion.
    /// </summary>
    /// <description>
    /// New-RscQueryAws creates a new
    /// query object for operations
    /// in the 'AWS' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 28 operations
    /// in the 'AWS' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -ArtifactsToDelete, -AvailabilityZonesByRegion, -CdmVersions, -CloudAccountConfigs, -CloudAccountListSecurityGroups, -CloudAccountListSubnets, -CloudAccountListVpcs, -CloudAccountWithFeatures, -CloudAccountsWithFeatures, -ComputeSettings, -DbParameterGroupsByRegion, -DbSubnetGroupsByRegion, -Ec2KeyPairsByRegion, -ExocomputeConfigs, -InstanceProfileNames, -IsS3BucketNameAvailable, -KmsEncryptionKeysByRegion, -OptionGroupsByRegion, -PermissionPolicies, -RdsInstanceDetails, -Regions, -S3BucketStateForRecovery, -S3Buckets, -S3BucketsDetails, -SupportedRdsDatabaseInstanceClasses, -TrustPolicy, -Vpcs, -VpcsByRegion.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op ArtifactsToDelete,
    /// which is equivalent to specifying -ArtifactsToDelete.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryAws -ArtifactsToDelete).Info().
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
    /// (New-RscQueryAws -ArtifactsToDelete).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ArtifactsToDelete operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: ArtifactsToDelete
    /// 
    /// $query = New-RscQueryAws -ArtifactsToDelete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsNativeId = $someString
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsArtifactsToDelete
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AvailabilityZonesByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: AvailabilityZonesByRegion
    /// 
    /// $query = New-RscQueryAws -AvailabilityZonesByRegion
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
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
    /// Runs the CdmVersions operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CdmVersions
    /// 
    /// $query = New-RscQueryAws -CdmVersions
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	region = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AwsCdmVersion&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountConfigs operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CloudAccountConfigs
    /// 
    /// $query = New-RscQueryAws -CloudAccountConfigs
    /// 
    /// # REQUIRED
    /// $query.Var.awsCloudAccountsArg = @{
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# REQUIRED
    /// 	statusFilters = @(
    /// 		$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	awsAdminAccountFilter = $someString
    /// 	# OPTIONAL
    /// 	columnSearchFilter = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AwsFeatureConfig&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountListSecurityGroups operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CloudAccountListSecurityGroups
    /// 
    /// $query = New-RscQueryAws -CloudAccountListSecurityGroups
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountUuid = $someString
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.vpcID = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsCloudAccountListSecurityGroupsResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountListSubnets operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CloudAccountListSubnets
    /// 
    /// $query = New-RscQueryAws -CloudAccountListSubnets
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountUuid = $someString
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.vpcID = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsCloudAccountListSubnetsResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountListVpcs operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CloudAccountListVpcs
    /// 
    /// $query = New-RscQueryAws -CloudAccountListVpcs
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountUuid = $someString
    /// # REQUIRED
    /// $query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// # REQUIRED
    /// $query.Var.region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsCloudAccountListVpcResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountWithFeatures operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CloudAccountWithFeatures
    /// 
    /// $query = New-RscQueryAws -CloudAccountWithFeatures
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// # REQUIRED
    /// $query.Var.awsCloudAccountArg = @{
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsCloudAccountWithFeatures
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountsWithFeatures operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CloudAccountsWithFeatures
    /// 
    /// $query = New-RscQueryAws -CloudAccountsWithFeatures
    /// 
    /// # REQUIRED
    /// $query.Var.awsCloudAccountsArg = @{
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# REQUIRED
    /// 	statusFilters = @(
    /// 		$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	awsAdminAccountFilter = $someString
    /// 	# OPTIONAL
    /// 	columnSearchFilter = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AwsCloudAccountWithFeatures&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ComputeSettings operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: ComputeSettings
    /// 
    /// $query = New-RscQueryAws -ComputeSettings
    /// 
    /// # REQUIRED
    /// $query.Var.computeSettingId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsComputeSettings
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DbParameterGroupsByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: DbParameterGroupsByRegion
    /// 
    /// $query = New-RscQueryAws -DbParameterGroupsByRegion
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
    /// # REQUIRED
    /// $query.Var.dbEngineVersion = $someString
    /// # OPTIONAL
    /// $query.Var.rdsType = $someAwsNativeRdsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;DbParameterGroup&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DbSubnetGroupsByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: DbSubnetGroupsByRegion
    /// 
    /// $query = New-RscQueryAws -DbSubnetGroupsByRegion
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;SubnetGroup&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Ec2KeyPairsByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: Ec2KeyPairsByRegion
    /// 
    /// $query = New-RscQueryAws -Ec2KeyPairsByRegion
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
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
    /// Runs the ExocomputeConfigs operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: ExocomputeConfigs
    /// 
    /// $query = New-RscQueryAws -ExocomputeConfigs
    /// 
    /// # REQUIRED
    /// $query.Var.awsNativeAccountIdOrNamePrefix = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AwsExocomputeConfig&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InstanceProfileNames operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: InstanceProfileNames
    /// 
    /// $query = New-RscQueryAws -InstanceProfileNames
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someString
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
    /// Runs the IsS3BucketNameAvailable operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: IsS3BucketNameAvailable
    /// 
    /// $query = New-RscQueryAws -IsS3BucketNameAvailable
    /// 
    /// # REQUIRED
    /// $query.Var.bucketName = $someString
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the KmsEncryptionKeysByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: KmsEncryptionKeysByRegion
    /// 
    /// $query = New-RscQueryAws -KmsEncryptionKeysByRegion
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;KmsEncryptionKey&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OptionGroupsByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: OptionGroupsByRegion
    /// 
    /// $query = New-RscQueryAws -OptionGroupsByRegion
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
    /// # REQUIRED
    /// $query.Var.dbEngineVersion = $someString
    /// # REQUIRED
    /// $query.Var.majorEngineVersion = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;OptionGroup&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PermissionPolicies operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: PermissionPolicies
    /// 
    /// $query = New-RscQueryAws -PermissionPolicies
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	featureSpecificDetails = @{
    /// 		# OPTIONAL
    /// 		ec2RecoveryRolePath = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;PermissionPolicy&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RdsInstanceDetails operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: RdsInstanceDetails
    /// 
    /// $query = New-RscQueryAws -RdsInstanceDetails
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.rdsInstanceName = $someString
    /// # OPTIONAL
    /// $query.Var.rdsDatabaseRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RdsInstanceDetailsFromAws
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Regions operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: Regions
    /// 
    /// $query = New-RscQueryAws -Regions
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AwsCloudAccountRegion&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the S3BucketStateForRecovery operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: S3BucketStateForRecovery
    /// 
    /// $query = New-RscQueryAws -S3BucketStateForRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.bucketName = $someString
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetS3BucketStateForRecoveryReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the S3Buckets operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: S3Buckets
    /// 
    /// $query = New-RscQueryAws -S3Buckets
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
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
    /// Runs the S3BucketsDetails operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: S3BucketsDetails
    /// 
    /// $query = New-RscQueryAws -S3BucketsDetails
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # OPTIONAL
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;S3BucketDetails&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SupportedRdsDatabaseInstanceClasses operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: SupportedRdsDatabaseInstanceClasses
    /// 
    /// $query = New-RscQueryAws -SupportedRdsDatabaseInstanceClasses
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
    /// # OPTIONAL
    /// $query.Var.dbEngineVersion = $someString
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
    /// Runs the TrustPolicy operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: TrustPolicy
    /// 
    /// $query = New-RscQueryAws -TrustPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	awsNativeAccounts = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			externalId = $someString
    /// 			# REQUIRED
    /// 			id = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsTrustPolicy
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Vpcs operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: Vpcs
    /// 
    /// $query = New-RscQueryAws -Vpcs
    /// 
    /// # OPTIONAL
    /// $query.Var.awsAccountRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AwsVpc&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VpcsByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: VpcsByRegion
    /// 
    /// $query = New-RscQueryAws -VpcsByRegion
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AwsVpc&gt;
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
        "RscQueryAws",
        DefaultParameterSetName = "Vpcs")
    ]
    public class New_RscQueryAws : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "ArtifactsToDelete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'ArtifactsToDelete' operation
in the 'AWS' API domain.
Description of the operation:
Retrieves the AWS artifacts that need to be deleted when an account is being deleted.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsartifactstodelete.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ArtifactsToDelete { get; set; }

        
        [Parameter(
            ParameterSetName = "AvailabilityZonesByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AvailabilityZonesByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of Availability Zones (AZs) in the specified region on the specified AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allavailabilityzonesbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AvailabilityZonesByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "CdmVersions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'CdmVersions' operation
in the 'AWS' API domain.
Description of the operation:
Get all Rubrik CDM versions in the AWS marketplace.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawscdmversions.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CdmVersions { get; set; }

        
        [Parameter(
            ParameterSetName = "CloudAccountConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'CloudAccountConfigs' operation
in the 'AWS' API domain.
Description of the operation:
List of all AWS cloud account configurations with the given search query.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawscloudaccountconfigs.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CloudAccountConfigs { get; set; }

        
        [Parameter(
            ParameterSetName = "CloudAccountListSecurityGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'CloudAccountListSecurityGroups' operation
in the 'AWS' API domain.
Description of the operation:
Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC).
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awscloudaccountlistsecuritygroups.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CloudAccountListSecurityGroups { get; set; }

        
        [Parameter(
            ParameterSetName = "CloudAccountListSubnets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'CloudAccountListSubnets' operation
in the 'AWS' API domain.
Description of the operation:
Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC).
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awscloudaccountlistsubnets.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CloudAccountListSubnets { get; set; }

        
        [Parameter(
            ParameterSetName = "CloudAccountListVpcs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'CloudAccountListVpcs' operation
in the 'AWS' API domain.
Description of the operation:
Retrieves a list of virtual private clouds (VPCs) in the specific cloud account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awscloudaccountlistvpcs.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CloudAccountListVpcs { get; set; }

        
        [Parameter(
            ParameterSetName = "CloudAccountWithFeatures",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'CloudAccountWithFeatures' operation
in the 'AWS' API domain.
Description of the operation:
List of AWS cloud accounts and the features for each account, classified by ID.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awscloudaccountwithfeatures.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CloudAccountWithFeatures { get; set; }

        
        [Parameter(
            ParameterSetName = "CloudAccountsWithFeatures",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'CloudAccountsWithFeatures' operation
in the 'AWS' API domain.
Description of the operation:
List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawscloudaccountswithfeatures.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CloudAccountsWithFeatures { get; set; }

        
        [Parameter(
            ParameterSetName = "ComputeSettings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'ComputeSettings' operation
in the 'AWS' API domain.
Description of the operation:
Retrieve aws compute settings.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awscomputesettings.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ComputeSettings { get; set; }

        
        [Parameter(
            ParameterSetName = "DbParameterGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'DbParameterGroupsByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/alldbparametergroupsbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DbParameterGroupsByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "DbSubnetGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'DbSubnetGroupsByRegion' operation
in the 'AWS' API domain.
Description of the operation:
All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/alldbsubnetgroupsbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DbSubnetGroupsByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "Ec2KeyPairsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Ec2KeyPairsByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allec2keypairsbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Ec2KeyPairsByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "ExocomputeConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'ExocomputeConfigs' operation
in the 'AWS' API domain.
Description of the operation:
List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawsexocomputeconfigs.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ExocomputeConfigs { get; set; }

        
        [Parameter(
            ParameterSetName = "InstanceProfileNames",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'InstanceProfileNames' operation
in the 'AWS' API domain.
Description of the operation:
All Rubrik CC-ES instance profiles in the AWS account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawsinstanceprofilenames.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter InstanceProfileNames { get; set; }

        
        [Parameter(
            ParameterSetName = "IsS3BucketNameAvailable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'IsS3BucketNameAvailable' operation
in the 'AWS' API domain.
Description of the operation:
Specifies whether an S3 bucket name is available for use in AWS or not. When true, the bucket name is available for use.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/isawss3bucketnameavailable.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter IsS3BucketNameAvailable { get; set; }

        
        [Parameter(
            ParameterSetName = "KmsEncryptionKeysByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'KmsEncryptionKeysByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allkmsencryptionkeysbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter KmsEncryptionKeysByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "OptionGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'OptionGroupsByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/alloptiongroupsbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter OptionGroupsByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "PermissionPolicies",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'PermissionPolicies' operation
in the 'AWS' API domain.
Description of the operation:
Retrieves the permissions policy for all the input features along with any AWS-managed policy ARNs which need to be attached to the roles. Each policy document can be used to create an AWS-managed policy which then needs to be attached to corresponding role.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawspermissionpolicies.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PermissionPolicies { get; set; }

        
        [Parameter(
            ParameterSetName = "RdsInstanceDetails",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'RdsInstanceDetails' operation
in the 'AWS' API domain.
Description of the operation:
Details of the RDS Instance in the AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/rdsinstancedetailsfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RdsInstanceDetails { get; set; }

        
        [Parameter(
            ParameterSetName = "Regions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Regions' operation
in the 'AWS' API domain.
Description of the operation:
All valid AWS regions for this cloud account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawsregions.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Regions { get; set; }

        
        [Parameter(
            ParameterSetName = "S3BucketStateForRecovery",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'S3BucketStateForRecovery' operation
in the 'AWS' API domain.
Description of the operation:
Retrieves the versioning and object ACL state of the Amazon S3 bucket, which is required to initiate the recovery process.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/s3bucketstateforrecovery.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter S3BucketStateForRecovery { get; set; }

        
        [Parameter(
            ParameterSetName = "S3Buckets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'S3Buckets' operation
in the 'AWS' API domain.
Description of the operation:
List of all S3 bucket names across regions for the AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/alls3bucketsfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter S3Buckets { get; set; }

        
        [Parameter(
            ParameterSetName = "S3BucketsDetails",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'S3BucketsDetails' operation
in the 'AWS' API domain.
Description of the operation:
List of all S3 bucket details across regions for the AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/alls3bucketsdetailsfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter S3BucketsDetails { get; set; }

        
        [Parameter(
            ParameterSetName = "SupportedRdsDatabaseInstanceClasses",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'SupportedRdsDatabaseInstanceClasses' operation
in the 'AWS' API domain.
Description of the operation:
List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allsupportedawsrdsdatabaseinstanceclasses.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter SupportedRdsDatabaseInstanceClasses { get; set; }

        
        [Parameter(
            ParameterSetName = "TrustPolicy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'TrustPolicy' operation
in the 'AWS' API domain.
Description of the operation:
Retrieves the AWS trust policy that will be attached with each role (cross-account, exocompute, etc.) in the customer's environment.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awstrustpolicy.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter TrustPolicy { get; set; }

        
        [Parameter(
            ParameterSetName = "Vpcs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Vpcs' operation
in the 'AWS' API domain.
Description of the operation:
List of all Virtual Private Clouds (VPCs) in the AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allvpcsfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Vpcs { get; set; }

        
        [Parameter(
            ParameterSetName = "VpcsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'VpcsByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allvpcsbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter VpcsByRegion { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "ArtifactsToDelete":
                        this.ProcessRecord_ArtifactsToDelete();
                        break;
                    case "AvailabilityZonesByRegion":
                        this.ProcessRecord_AvailabilityZonesByRegion();
                        break;
                    case "CdmVersions":
                        this.ProcessRecord_CdmVersions();
                        break;
                    case "CloudAccountConfigs":
                        this.ProcessRecord_CloudAccountConfigs();
                        break;
                    case "CloudAccountListSecurityGroups":
                        this.ProcessRecord_CloudAccountListSecurityGroups();
                        break;
                    case "CloudAccountListSubnets":
                        this.ProcessRecord_CloudAccountListSubnets();
                        break;
                    case "CloudAccountListVpcs":
                        this.ProcessRecord_CloudAccountListVpcs();
                        break;
                    case "CloudAccountWithFeatures":
                        this.ProcessRecord_CloudAccountWithFeatures();
                        break;
                    case "CloudAccountsWithFeatures":
                        this.ProcessRecord_CloudAccountsWithFeatures();
                        break;
                    case "ComputeSettings":
                        this.ProcessRecord_ComputeSettings();
                        break;
                    case "DbParameterGroupsByRegion":
                        this.ProcessRecord_DbParameterGroupsByRegion();
                        break;
                    case "DbSubnetGroupsByRegion":
                        this.ProcessRecord_DbSubnetGroupsByRegion();
                        break;
                    case "Ec2KeyPairsByRegion":
                        this.ProcessRecord_Ec2KeyPairsByRegion();
                        break;
                    case "ExocomputeConfigs":
                        this.ProcessRecord_ExocomputeConfigs();
                        break;
                    case "InstanceProfileNames":
                        this.ProcessRecord_InstanceProfileNames();
                        break;
                    case "IsS3BucketNameAvailable":
                        this.ProcessRecord_IsS3BucketNameAvailable();
                        break;
                    case "KmsEncryptionKeysByRegion":
                        this.ProcessRecord_KmsEncryptionKeysByRegion();
                        break;
                    case "OptionGroupsByRegion":
                        this.ProcessRecord_OptionGroupsByRegion();
                        break;
                    case "PermissionPolicies":
                        this.ProcessRecord_PermissionPolicies();
                        break;
                    case "RdsInstanceDetails":
                        this.ProcessRecord_RdsInstanceDetails();
                        break;
                    case "Regions":
                        this.ProcessRecord_Regions();
                        break;
                    case "S3BucketStateForRecovery":
                        this.ProcessRecord_S3BucketStateForRecovery();
                        break;
                    case "S3Buckets":
                        this.ProcessRecord_S3Buckets();
                        break;
                    case "S3BucketsDetails":
                        this.ProcessRecord_S3BucketsDetails();
                        break;
                    case "SupportedRdsDatabaseInstanceClasses":
                        this.ProcessRecord_SupportedRdsDatabaseInstanceClasses();
                        break;
                    case "TrustPolicy":
                        this.ProcessRecord_TrustPolicy();
                        break;
                    case "Vpcs":
                        this.ProcessRecord_Vpcs();
                        break;
                    case "VpcsByRegion":
                        this.ProcessRecord_VpcsByRegion();
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
        // awsArtifactsToDelete.
        internal void ProcessRecord_ArtifactsToDelete()
        {
            this._logger.name += " -ArtifactsToDelete";
            // Create new graphql operation awsArtifactsToDelete
            InitQueryAwsArtifactsToDelete();
        }

        // This parameter set invokes a single graphql operation:
        // allAvailabilityZonesByRegionFromAws.
        internal void ProcessRecord_AvailabilityZonesByRegion()
        {
            this._logger.name += " -AvailabilityZonesByRegion";
            // Create new graphql operation allAvailabilityZonesByRegionFromAws
            InitQueryAllAvailabilityZonesByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCdmVersions.
        internal void ProcessRecord_CdmVersions()
        {
            this._logger.name += " -CdmVersions";
            // Create new graphql operation allAwsCdmVersions
            InitQueryAllAwsCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountConfigs.
        internal void ProcessRecord_CloudAccountConfigs()
        {
            this._logger.name += " -CloudAccountConfigs";
            // Create new graphql operation allAwsCloudAccountConfigs
            InitQueryAllAwsCloudAccountConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListSecurityGroups.
        internal void ProcessRecord_CloudAccountListSecurityGroups()
        {
            this._logger.name += " -CloudAccountListSecurityGroups";
            // Create new graphql operation awsCloudAccountListSecurityGroups
            InitQueryAwsCloudAccountListSecurityGroups();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListSubnets.
        internal void ProcessRecord_CloudAccountListSubnets()
        {
            this._logger.name += " -CloudAccountListSubnets";
            // Create new graphql operation awsCloudAccountListSubnets
            InitQueryAwsCloudAccountListSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountListVpcs.
        internal void ProcessRecord_CloudAccountListVpcs()
        {
            this._logger.name += " -CloudAccountListVpcs";
            // Create new graphql operation awsCloudAccountListVpcs
            InitQueryAwsCloudAccountListVpcs();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountWithFeatures.
        internal void ProcessRecord_CloudAccountWithFeatures()
        {
            this._logger.name += " -CloudAccountWithFeatures";
            // Create new graphql operation awsCloudAccountWithFeatures
            InitQueryAwsCloudAccountWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountsWithFeatures.
        internal void ProcessRecord_CloudAccountsWithFeatures()
        {
            this._logger.name += " -CloudAccountsWithFeatures";
            // Create new graphql operation allAwsCloudAccountsWithFeatures
            InitQueryAllAwsCloudAccountsWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // awsComputeSettings.
        internal void ProcessRecord_ComputeSettings()
        {
            this._logger.name += " -ComputeSettings";
            // Create new graphql operation awsComputeSettings
            InitQueryAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allDbParameterGroupsByRegionFromAws.
        internal void ProcessRecord_DbParameterGroupsByRegion()
        {
            this._logger.name += " -DbParameterGroupsByRegion";
            // Create new graphql operation allDbParameterGroupsByRegionFromAws
            InitQueryAllDbParameterGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbSubnetGroupsByRegionFromAws.
        internal void ProcessRecord_DbSubnetGroupsByRegion()
        {
            this._logger.name += " -DbSubnetGroupsByRegion";
            // Create new graphql operation allDbSubnetGroupsByRegionFromAws
            InitQueryAllDbSubnetGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allEc2KeyPairsByRegionFromAws.
        internal void ProcessRecord_Ec2KeyPairsByRegion()
        {
            this._logger.name += " -Ec2KeyPairsByRegion";
            // Create new graphql operation allEc2KeyPairsByRegionFromAws
            InitQueryAllEc2KeyPairsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsExocomputeConfigs.
        internal void ProcessRecord_ExocomputeConfigs()
        {
            this._logger.name += " -ExocomputeConfigs";
            // Create new graphql operation allAwsExocomputeConfigs
            InitQueryAllAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsInstanceProfileNames.
        internal void ProcessRecord_InstanceProfileNames()
        {
            this._logger.name += " -InstanceProfileNames";
            // Create new graphql operation allAwsInstanceProfileNames
            InitQueryAllAwsInstanceProfileNames();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsS3BucketNameAvailable.
        internal void ProcessRecord_IsS3BucketNameAvailable()
        {
            this._logger.name += " -IsS3BucketNameAvailable";
            // Create new graphql operation isAwsS3BucketNameAvailable
            InitQueryIsAwsS3BucketNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // allKmsEncryptionKeysByRegionFromAws.
        internal void ProcessRecord_KmsEncryptionKeysByRegion()
        {
            this._logger.name += " -KmsEncryptionKeysByRegion";
            // Create new graphql operation allKmsEncryptionKeysByRegionFromAws
            InitQueryAllKmsEncryptionKeysByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allOptionGroupsByRegionFromAws.
        internal void ProcessRecord_OptionGroupsByRegion()
        {
            this._logger.name += " -OptionGroupsByRegion";
            // Create new graphql operation allOptionGroupsByRegionFromAws
            InitQueryAllOptionGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsPermissionPolicies.
        internal void ProcessRecord_PermissionPolicies()
        {
            this._logger.name += " -PermissionPolicies";
            // Create new graphql operation allAwsPermissionPolicies
            InitQueryAllAwsPermissionPolicies();
        }

        // This parameter set invokes a single graphql operation:
        // rdsInstanceDetailsFromAws.
        internal void ProcessRecord_RdsInstanceDetails()
        {
            this._logger.name += " -RdsInstanceDetails";
            // Create new graphql operation rdsInstanceDetailsFromAws
            InitQueryRdsInstanceDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsRegions.
        internal void ProcessRecord_Regions()
        {
            this._logger.name += " -Regions";
            // Create new graphql operation allAwsRegions
            InitQueryAllAwsRegions();
        }

        // This parameter set invokes a single graphql operation:
        // s3BucketStateForRecovery.
        internal void ProcessRecord_S3BucketStateForRecovery()
        {
            this._logger.name += " -S3BucketStateForRecovery";
            // Create new graphql operation s3BucketStateForRecovery
            InitQueryS3BucketStateForRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsFromAws.
        internal void ProcessRecord_S3Buckets()
        {
            this._logger.name += " -S3Buckets";
            // Create new graphql operation allS3BucketsFromAws
            InitQueryAllS3BucketsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsDetailsFromAws.
        internal void ProcessRecord_S3BucketsDetails()
        {
            this._logger.name += " -S3BucketsDetails";
            // Create new graphql operation allS3BucketsDetailsFromAws
            InitQueryAllS3BucketsDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allSupportedAwsRdsDatabaseInstanceClasses.
        internal void ProcessRecord_SupportedRdsDatabaseInstanceClasses()
        {
            this._logger.name += " -SupportedRdsDatabaseInstanceClasses";
            // Create new graphql operation allSupportedAwsRdsDatabaseInstanceClasses
            InitQueryAllSupportedAwsRdsDatabaseInstanceClasses();
        }

        // This parameter set invokes a single graphql operation:
        // awsTrustPolicy.
        internal void ProcessRecord_TrustPolicy()
        {
            this._logger.name += " -TrustPolicy";
            // Create new graphql operation awsTrustPolicy
            InitQueryAwsTrustPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsFromAws.
        internal void ProcessRecord_Vpcs()
        {
            this._logger.name += " -Vpcs";
            // Create new graphql operation allVpcsFromAws
            InitQueryAllVpcsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsByRegionFromAws.
        internal void ProcessRecord_VpcsByRegion()
        {
            this._logger.name += " -VpcsByRegion";
            // Create new graphql operation allVpcsByRegionFromAws
            InitQueryAllVpcsByRegionFromAws();
        }


        // Create new GraphQL Query:
        // awsArtifactsToDelete(input: AwsArtifactsToDeleteInput!): AwsArtifactsToDelete!
        internal void InitQueryAwsArtifactsToDelete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsArtifactsToDeleteInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsArtifactsToDelete",
                "($input: AwsArtifactsToDeleteInput!)",
                "AwsArtifactsToDelete",
                Query.AwsArtifactsToDelete_ObjectFieldSpec,
                Query.AwsArtifactsToDeleteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsNativeId = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Query:
        // allAvailabilityZonesByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [String!]!
        internal void InitQueryAllAvailabilityZonesByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAvailabilityZonesByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<System.String>",
                Query.AllAvailabilityZonesByRegionFromAws_ObjectFieldSpec,
                Query.AllAvailabilityZonesByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAwsCdmVersions(input: AwsCdmVersionRequest!): [AwsCdmVersion!]!
        internal void InitQueryAllAwsCdmVersions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsCdmVersionRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsCdmVersions",
                "($input: AwsCdmVersionRequest!)",
                "List<AwsCdmVersion>",
                Query.AllAwsCdmVersions_ObjectFieldSpec,
                Query.AllAwsCdmVersionsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	region = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allAwsCloudAccountConfigs(awsCloudAccountsArg: AwsCloudAccountConfigsInput!): [AwsFeatureConfig!]!
        internal void InitQueryAllAwsCloudAccountConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountConfigsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsCloudAccountConfigs",
                "($awsCloudAccountsArg: AwsCloudAccountConfigsInput!)",
                "List<AwsFeatureConfig>",
                Query.AllAwsCloudAccountConfigs_ObjectFieldSpec,
                Query.AllAwsCloudAccountConfigsFieldSpec,
                @"# REQUIRED
$query.Var.awsCloudAccountsArg = @{
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	statusFilters = @(
		$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
	)
	# OPTIONAL
	awsAdminAccountFilter = $someString
	# OPTIONAL
	columnSearchFilter = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // awsCloudAccountListSecurityGroups(
        //     cloudAccountUuid: UUID!
        //     feature: CloudAccountFeature!
        //     region: AwsRegion!
        //     vpcID: String!
        //   ): AwsCloudAccountListSecurityGroupsResponse!
        internal void InitQueryAwsCloudAccountListSecurityGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
                Tuple.Create("vpcID", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountListSecurityGroups",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)",
                "AwsCloudAccountListSecurityGroupsResponse",
                Query.AwsCloudAccountListSecurityGroups_ObjectFieldSpec,
                Query.AwsCloudAccountListSecurityGroupsFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountUuid = $someString
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
# REQUIRED
$query.Var.vpcID = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsCloudAccountListSubnets(
        //     cloudAccountUuid: UUID!
        //     feature: CloudAccountFeature!
        //     region: AwsRegion!
        //     vpcID: String!
        //   ): AwsCloudAccountListSubnetsResponse!
        internal void InitQueryAwsCloudAccountListSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
                Tuple.Create("vpcID", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountListSubnets",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!,$vpcID: String!)",
                "AwsCloudAccountListSubnetsResponse",
                Query.AwsCloudAccountListSubnets_ObjectFieldSpec,
                Query.AwsCloudAccountListSubnetsFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountUuid = $someString
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
# REQUIRED
$query.Var.vpcID = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsCloudAccountListVpcs(cloudAccountUuid: UUID!, feature: CloudAccountFeature!, region: AwsRegion!): AwsCloudAccountListVpcResponse!
        internal void InitQueryAwsCloudAccountListVpcs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountUuid", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("region", "AwsRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountListVpcs",
                "($cloudAccountUuid: UUID!,$feature: CloudAccountFeature!,$region: AwsRegion!)",
                "AwsCloudAccountListVpcResponse",
                Query.AwsCloudAccountListVpcs_ObjectFieldSpec,
                Query.AwsCloudAccountListVpcsFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountUuid = $someString
# REQUIRED
$query.Var.feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$query.Var.region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // awsCloudAccountWithFeatures(cloudAccountId: UUID!, awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!): AwsCloudAccountWithFeatures!
        internal void InitQueryAwsCloudAccountWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("awsCloudAccountArg", "AwsCloudAccountWithFeaturesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsCloudAccountWithFeatures",
                "($cloudAccountId: UUID!,$awsCloudAccountArg: AwsCloudAccountWithFeaturesInput!)",
                "AwsCloudAccountWithFeatures",
                Query.AwsCloudAccountWithFeatures_ObjectFieldSpec,
                Query.AwsCloudAccountWithFeaturesFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString
# REQUIRED
$query.Var.awsCloudAccountArg = @{
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Query:
        // allAwsCloudAccountsWithFeatures(awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!): [AwsCloudAccountWithFeatures!]!
        internal void InitQueryAllAwsCloudAccountsWithFeatures()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountsWithFeaturesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsCloudAccountsWithFeatures",
                "($awsCloudAccountsArg: AwsCloudAccountsWithFeaturesInput!)",
                "List<AwsCloudAccountWithFeatures>",
                Query.AllAwsCloudAccountsWithFeatures_ObjectFieldSpec,
                Query.AllAwsCloudAccountsWithFeaturesFieldSpec,
                @"# REQUIRED
$query.Var.awsCloudAccountsArg = @{
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	statusFilters = @(
		$someCloudAccountStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
	)
	# OPTIONAL
	awsAdminAccountFilter = $someString
	# OPTIONAL
	columnSearchFilter = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // awsComputeSettings(computeSettingId: UUID!): AwsComputeSettings!
        internal void InitQueryAwsComputeSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("computeSettingId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsComputeSettings",
                "($computeSettingId: UUID!)",
                "AwsComputeSettings",
                Query.AwsComputeSettings_ObjectFieldSpec,
                Query.AwsComputeSettingsFieldSpec,
                @"# REQUIRED
$query.Var.computeSettingId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allDbParameterGroupsByRegionFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     rdsType: AwsNativeRdsType
        //   ): [DbParameterGroup!]!
        internal void InitQueryAllDbParameterGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("rdsType", "AwsNativeRdsType"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDbParameterGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$rdsType: AwsNativeRdsType)",
                "List<DbParameterGroup>",
                Query.AllDbParameterGroupsByRegionFromAws_ObjectFieldSpec,
                Query.AllDbParameterGroupsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$query.Var.dbEngineVersion = $someString
# OPTIONAL
$query.Var.rdsType = $someAwsNativeRdsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allDbSubnetGroupsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [SubnetGroup!]!
        internal void InitQueryAllDbSubnetGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDbSubnetGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<SubnetGroup>",
                Query.AllDbSubnetGroupsByRegionFromAws_ObjectFieldSpec,
                Query.AllDbSubnetGroupsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allEc2KeyPairsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [String!]!
        internal void InitQueryAllEc2KeyPairsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllEc2KeyPairsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<System.String>",
                Query.AllEc2KeyPairsByRegionFromAws_ObjectFieldSpec,
                Query.AllEc2KeyPairsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAwsExocomputeConfigs(awsNativeAccountIdOrNamePrefix: String!): [AwsExocomputeConfig!]!
        internal void InitQueryAllAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountIdOrNamePrefix", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsExocomputeConfigs",
                "($awsNativeAccountIdOrNamePrefix: String!)",
                "List<AwsExocomputeConfig>",
                Query.AllAwsExocomputeConfigs_ObjectFieldSpec,
                Query.AllAwsExocomputeConfigsFieldSpec,
                @"# REQUIRED
$query.Var.awsNativeAccountIdOrNamePrefix = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAwsInstanceProfileNames(cloudAccountId: String!, region: String!): [String!]!
        internal void InitQueryAllAwsInstanceProfileNames()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
                Tuple.Create("region", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsInstanceProfileNames",
                "($cloudAccountId: String!,$region: String!)",
                "List<System.String>",
                Query.AllAwsInstanceProfileNames_ObjectFieldSpec,
                Query.AllAwsInstanceProfileNamesFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString
# REQUIRED
$query.Var.region = $someString"
            );
        }

        // Create new GraphQL Query:
        // isAwsS3BucketNameAvailable(bucketName: String!, awsAccountRubrikId: UUID!): Boolean!
        internal void InitQueryIsAwsS3BucketNameAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("bucketName", "String!"),
                Tuple.Create("awsAccountRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsS3BucketNameAvailable",
                "($bucketName: String!,$awsAccountRubrikId: UUID!)",
                "System.Boolean",
                Query.IsAwsS3BucketNameAvailable_ObjectFieldSpec,
                Query.IsAwsS3BucketNameAvailableFieldSpec,
                @"# REQUIRED
$query.Var.bucketName = $someString
# REQUIRED
$query.Var.awsAccountRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allKmsEncryptionKeysByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [KmsEncryptionKey!]!
        internal void InitQueryAllKmsEncryptionKeysByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllKmsEncryptionKeysByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<KmsEncryptionKey>",
                Query.AllKmsEncryptionKeysByRegionFromAws_ObjectFieldSpec,
                Query.AllKmsEncryptionKeysByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allOptionGroupsByRegionFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     majorEngineVersion: String!
        //   ): [OptionGroup!]!
        internal void InitQueryAllOptionGroupsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("majorEngineVersion", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllOptionGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$majorEngineVersion: String!)",
                "List<OptionGroup>",
                Query.AllOptionGroupsByRegionFromAws_ObjectFieldSpec,
                Query.AllOptionGroupsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$query.Var.dbEngineVersion = $someString
# REQUIRED
$query.Var.majorEngineVersion = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAwsPermissionPolicies(input: AwsGetPermissionPoliciesInput!): [PermissionPolicy!]!
        internal void InitQueryAllAwsPermissionPolicies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsGetPermissionPoliciesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsPermissionPolicies",
                "($input: AwsGetPermissionPoliciesInput!)",
                "List<PermissionPolicy>",
                Query.AllAwsPermissionPolicies_ObjectFieldSpec,
                Query.AllAwsPermissionPoliciesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	featureSpecificDetails = @{
		# OPTIONAL
		ec2RecoveryRolePath = $someString
	}
}"
            );
        }

        // Create new GraphQL Query:
        // rdsInstanceDetailsFromAws(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     rdsInstanceName: String!
        //     rdsDatabaseRubrikId: UUID
        //   ): RdsInstanceDetailsFromAws!
        internal void InitQueryRdsInstanceDetailsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
                Tuple.Create("rdsDatabaseRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRdsInstanceDetailsFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)",
                "RdsInstanceDetailsFromAws",
                Query.RdsInstanceDetailsFromAws_ObjectFieldSpec,
                Query.RdsInstanceDetailsFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.rdsInstanceName = $someString
# OPTIONAL
$query.Var.rdsDatabaseRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAwsRegions(cloudAccountId: String!): [AwsCloudAccountRegion!]!
        internal void InitQueryAllAwsRegions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsRegions",
                "($cloudAccountId: String!)",
                "List<AwsCloudAccountRegion>",
                Query.AllAwsRegions_ObjectFieldSpec,
                Query.AllAwsRegionsFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString"
            );
        }

        // Create new GraphQL Query:
        // s3BucketStateForRecovery(bucketName: String!, awsAccountRubrikId: UUID!, region: AwsNativeRegion!): GetS3BucketStateForRecoveryReply!
        internal void InitQueryS3BucketStateForRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("bucketName", "String!"),
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryS3BucketStateForRecovery",
                "($bucketName: String!,$awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "GetS3BucketStateForRecoveryReply",
                Query.S3BucketStateForRecovery_ObjectFieldSpec,
                Query.S3BucketStateForRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.bucketName = $someString
# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allS3BucketsFromAws(awsAccountRubrikId: UUID!): [String!]!
        internal void InitQueryAllS3BucketsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllS3BucketsFromAws",
                "($awsAccountRubrikId: UUID!)",
                "List<System.String>",
                Query.AllS3BucketsFromAws_ObjectFieldSpec,
                Query.AllS3BucketsFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allS3BucketsDetailsFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion): [S3BucketDetails!]!
        internal void InitQueryAllS3BucketsDetailsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllS3BucketsDetailsFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion)",
                "List<S3BucketDetails>",
                Query.AllS3BucketsDetailsFromAws_ObjectFieldSpec,
                Query.AllS3BucketsDetailsFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# OPTIONAL
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allSupportedAwsRdsDatabaseInstanceClasses(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String
        //   ): [String!]!
        internal void InitQueryAllSupportedAwsRdsDatabaseInstanceClasses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSupportedAwsRdsDatabaseInstanceClasses",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String)",
                "List<System.String>",
                Query.AllSupportedAwsRdsDatabaseInstanceClasses_ObjectFieldSpec,
                Query.AllSupportedAwsRdsDatabaseInstanceClassesFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# OPTIONAL
$query.Var.dbEngineVersion = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsTrustPolicy(input: AwsTrustPolicyInput!): AwsTrustPolicy!
        internal void InitQueryAwsTrustPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsTrustPolicyInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsTrustPolicy",
                "($input: AwsTrustPolicyInput!)",
                "AwsTrustPolicy",
                Query.AwsTrustPolicy_ObjectFieldSpec,
                Query.AwsTrustPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	awsNativeAccounts = @(
		@{
			# OPTIONAL
			externalId = $someString
			# REQUIRED
			id = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Query:
        // allVpcsFromAws(awsAccountRubrikId: UUID): [AwsVpc!]!
        internal void InitQueryAllVpcsFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVpcsFromAws",
                "($awsAccountRubrikId: UUID)",
                "List<AwsVpc>",
                Query.AllVpcsFromAws_ObjectFieldSpec,
                Query.AllVpcsFromAwsFieldSpec,
                @"# OPTIONAL
$query.Var.awsAccountRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allVpcsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [AwsVpc!]!
        internal void InitQueryAllVpcsByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVpcsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<AwsVpc>",
                Query.AllVpcsByRegionFromAws_ObjectFieldSpec,
                Query.AllVpcsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }


    } // class New_RscQueryAws
}