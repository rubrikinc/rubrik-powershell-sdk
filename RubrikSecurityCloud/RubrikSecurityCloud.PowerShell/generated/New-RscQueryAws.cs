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
using System.Linq;
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
    /// Create a new RscQuery object for any of the 35
    /// operations in the 'AWS' API domain:
    /// ArtifactsToDelete, AvailabilityZonesByRegion, BatchSupportedRdsDatabaseInstanceClasses, CdmVersions, CloudAccountConfigs, CloudAccountListSecurityGroups, CloudAccountListSubnets, CloudAccountListVpcs, CloudAccountWithFeatures, CloudAccountsWithFeatures, DbParameterGroupsByRegion, DbSubnetGroupsByRegion, Ec2InstanceTypesByRegion, Ec2KeyPairsByRegion, EligibleAccountsForMigrationToOrg, ExocomputeConfigs, ExocomputeGetClusterConnectionInfo, InstanceProfileNames, IsS3BucketNameAvailable, KmsEncryptionKeysByRegion, MarketplaceSubscriptionInfo, OptionGroupsByRegion, PermissionPolicies, RdsInstanceDetails, Regions, S3BucketStateForRecovery, S3Buckets, S3BucketsDetails, SupportedEksVersions, SupportedRdsDatabaseInstanceClasses, TrustPolicy, ValidateCreateClusterInput, ValidatePermissions, Vpcs, or VpcsByRegion.
    /// </summary>
    /// <description>
    /// New-RscQueryAws creates a new
    /// query object for operations
    /// in the 'AWS' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 35 operations
    /// in the 'AWS' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ArtifactsToDelete, AvailabilityZonesByRegion, BatchSupportedRdsDatabaseInstanceClasses, CdmVersions, CloudAccountConfigs, CloudAccountListSecurityGroups, CloudAccountListSubnets, CloudAccountListVpcs, CloudAccountWithFeatures, CloudAccountsWithFeatures, DbParameterGroupsByRegion, DbSubnetGroupsByRegion, Ec2InstanceTypesByRegion, Ec2KeyPairsByRegion, EligibleAccountsForMigrationToOrg, ExocomputeConfigs, ExocomputeGetClusterConnectionInfo, InstanceProfileNames, IsS3BucketNameAvailable, KmsEncryptionKeysByRegion, MarketplaceSubscriptionInfo, OptionGroupsByRegion, PermissionPolicies, RdsInstanceDetails, Regions, S3BucketStateForRecovery, S3Buckets, S3BucketsDetails, SupportedEksVersions, SupportedRdsDatabaseInstanceClasses, TrustPolicy, ValidateCreateClusterInput, ValidatePermissions, Vpcs, or VpcsByRegion.
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
    /// $query = New-RscQueryAws -Operation ArtifactsToDelete
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
    /// $query = New-RscQueryAws -Operation AvailabilityZonesByRegion
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
    /// Runs the BatchSupportedRdsDatabaseInstanceClasses operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: BatchSupportedRdsDatabaseInstanceClasses
    /// 
    /// $query = New-RscQueryAws -Operation BatchSupportedRdsDatabaseInstanceClasses
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.requests = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
    /// 		# OPTIONAL
    /// 		dbEngineVersion = $someString
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;RdsInstanceClassBatchResult&gt;
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
    /// $query = New-RscQueryAws -Operation CdmVersions
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
    /// $query = New-RscQueryAws -Operation CloudAccountConfigs
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
    /// $query = New-RscQueryAws -Operation CloudAccountListSecurityGroups
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
    /// $query = New-RscQueryAws -Operation CloudAccountListSubnets
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
    /// $query = New-RscQueryAws -Operation CloudAccountListVpcs
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
    /// $query = New-RscQueryAws -Operation CloudAccountWithFeatures
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// # REQUIRED
    /// $query.Var.awsCloudAccountArg = @{
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	includeInternalFeatures = $someBoolean
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
    /// $query = New-RscQueryAws -Operation CloudAccountsWithFeatures
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
    /// 	# OPTIONAL
    /// 	featuresToFilterOut = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 	# OPTIONAL
    /// 	includeInternalFeatures = $someBoolean
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
    /// $query = New-RscQueryAws -Operation DbParameterGroupsByRegion
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
    /// $query = New-RscQueryAws -Operation DbSubnetGroupsByRegion
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
    /// Runs the Ec2InstanceTypesByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: Ec2InstanceTypesByRegion
    /// 
    /// $query = New-RscQueryAws -Operation Ec2InstanceTypesByRegion
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
    /// Write-Host $result.GetType().Name # prints: List&lt;AwsNativeEc2InstanceTypeOffering&gt;
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
    /// $query = New-RscQueryAws -Operation Ec2KeyPairsByRegion
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
    /// Runs the EligibleAccountsForMigrationToOrg operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: EligibleAccountsForMigrationToOrg
    /// 
    /// $query = New-RscQueryAws -Operation EligibleAccountsForMigrationToOrg
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.awsOrganizationUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsCloudAccountConnection
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
    /// $query = New-RscQueryAws -Operation ExocomputeConfigs
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
    /// Runs the ExocomputeGetClusterConnectionInfo operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: ExocomputeGetClusterConnectionInfo
    /// 
    /// $query = New-RscQueryAws -Operation ExocomputeGetClusterConnectionInfo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterName = $someString
    /// 	# REQUIRED
    /// 	exocomputeConfigId = $someString
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	isPrivateExocompute = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsExocomputeGetClusterConnectionInfoReply
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
    /// $query = New-RscQueryAws -Operation InstanceProfileNames
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
    /// $query = New-RscQueryAws -Operation IsS3BucketNameAvailable
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
    /// $query = New-RscQueryAws -Operation KmsEncryptionKeysByRegion
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
    /// Runs the MarketplaceSubscriptionInfo operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: MarketplaceSubscriptionInfo
    /// 
    /// $query = New-RscQueryAws -Operation MarketplaceSubscriptionInfo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	region = $someString
    /// 	# OPTIONAL
    /// 	cdmVersion = $someString
    /// 	# OPTIONAL
    /// 	accountCredentials = @{
    /// 		# OPTIONAL
    /// 		accessKey = $someString
    /// 		# OPTIONAL
    /// 		secretKey = $someString
    /// 		# OPTIONAL
    /// 		token = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	subnetId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CheckAwsMarketplaceSubscriptionReply
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
    /// $query = New-RscQueryAws -Operation OptionGroupsByRegion
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
    /// $query = New-RscQueryAws -Operation PermissionPolicies
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 	# OPTIONAL
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	featureSpecificDetails = @{
    /// 		# OPTIONAL
    /// 		ec2RecoveryRolePath = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	featuresWithPermissionsGroups = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 			# OPTIONAL
    /// 			permissionsGroups = @(
    /// 				$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 			)
    /// 		}
    /// 	)
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
    /// $query = New-RscQueryAws -Operation RdsInstanceDetails
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
    /// $query = New-RscQueryAws -Operation Regions
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
    /// $query = New-RscQueryAws -Operation S3BucketStateForRecovery
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
    /// $query = New-RscQueryAws -Operation S3Buckets
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
    /// $query = New-RscQueryAws -Operation S3BucketsDetails
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
    /// Runs the SupportedEksVersions operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: SupportedEksVersions
    /// 
    /// $query = New-RscQueryAws -Operation SupportedEksVersions
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
    /// $query = New-RscQueryAws -Operation SupportedRdsDatabaseInstanceClasses
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
    /// $query = New-RscQueryAws -Operation TrustPolicy
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
    /// 	# OPTIONAL
    /// 	roleChainingAccountId = $someString
    /// 	# OPTIONAL
    /// 	persistRoleChainingMapping = $someBoolean
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
    /// Runs the ValidateCreateClusterInput operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: ValidateCreateClusterInput
    /// 
    /// $query = New-RscQueryAws -Operation ValidateCreateClusterInput
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	isEsType = $someBoolean
    /// 	# OPTIONAL
    /// 	keepClusterOnFailure = $someBoolean
    /// 	# OPTIONAL
    /// 	region = $someString
    /// 	# OPTIONAL
    /// 	disableApiTermination = $someBoolean
    /// 	# OPTIONAL
    /// 	usePlacementGroups = $someBoolean
    /// 	# OPTIONAL
    /// 	isAzResilient = $someBoolean
    /// 	# OPTIONAL
    /// 	clusterConfig = @{
    /// 		# OPTIONAL
    /// 		userEmail = $someString
    /// 		# OPTIONAL
    /// 		adminPassword = $someString
    /// 		# OPTIONAL
    /// 		clusterName = $someString
    /// 		# OPTIONAL
    /// 		numNodes = $someInt
    /// 		# OPTIONAL
    /// 		dnsNameServers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		dnsSearchDomains = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		ntpServers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureEsConfig = @{
    /// 			# OPTIONAL
    /// 			storageAccount = $someString
    /// 			# OPTIONAL
    /// 			resourceGroup = $someString
    /// 			# OPTIONAL
    /// 			storageSecret = $someString
    /// 			# OPTIONAL
    /// 			containerName = $someString
    /// 			# OPTIONAL
    /// 			shouldCreateContainer = $someBoolean
    /// 			# OPTIONAL
    /// 			enableImmutability = $someBoolean
    /// 			# OPTIONAL
    /// 			managedIdentity = @{
    /// 				# OPTIONAL
    /// 				name = $someString
    /// 				# OPTIONAL
    /// 				clientId = $someString
    /// 				# OPTIONAL
    /// 				resourceGroup = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			endpointSuffix = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		awsEsConfig = @{
    /// 			# OPTIONAL
    /// 			bucketName = $someString
    /// 			# OPTIONAL
    /// 			shouldCreateBucket = $someBoolean
    /// 			# OPTIONAL
    /// 			enableObjectLock = $someBoolean
    /// 			# OPTIONAL
    /// 			enableImmutability = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		ociEsConfig = @{
    /// 			# OPTIONAL
    /// 			bucketName = $someString
    /// 			# OPTIONAL
    /// 			ociNamespace = $someString
    /// 			# OPTIONAL
    /// 			accessKey = $someString
    /// 			# OPTIONAL
    /// 			secretKey = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		gcpEsConfig = @{
    /// 			# OPTIONAL
    /// 			bucketName = $someString
    /// 			# OPTIONAL
    /// 			region = $someString
    /// 			# OPTIONAL
    /// 			shouldCreateBucket = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		dynamicNumNodes = $someInt
    /// 		# OPTIONAL
    /// 		dynamicScalingEnabled = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	vmConfig = @{
    /// 		# OPTIONAL
    /// 		cdmVersion = $someString
    /// 		# OPTIONAL
    /// 		nodeSizeGb = $someInt
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 		# OPTIONAL
    /// 		vpc = $someString
    /// 		# OPTIONAL
    /// 		tags = $someString
    /// 		# OPTIONAL
    /// 		imageId = $someString
    /// 		# OPTIONAL
    /// 		instanceProfileName = $someString
    /// 		# OPTIONAL
    /// 		cdmProduct = $someString
    /// 		# OPTIONAL
    /// 		placementGroupName = $someString
    /// 		# OPTIONAL
    /// 		subnetAzConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				subnet = $someString
    /// 				# OPTIONAL
    /// 				availabilityZone = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
    /// 		# OPTIONAL
    /// 		securityGroups = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		instanceType = $someAwsInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
    /// 		# OPTIONAL
    /// 		networkConfig = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				availabilityZone = $someString
    /// 				# OPTIONAL
    /// 				subnet = $someString
    /// 				# OPTIONAL
    /// 				vpc = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	validations = @(
    /// 		$someClusterCreateValidations # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCreateValidations]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidatePermissions operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: ValidatePermissions
    /// 
    /// $query = New-RscQueryAws -Operation ValidatePermissions
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	accountReqs = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			cloudAccountId = $someString
    /// 			# OPTIONAL
    /// 			featureReqs = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 					# OPTIONAL
    /// 					roleReqs = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							roleType = $someRoleType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RoleType]) for enum values.
    /// 							# OPTIONAL
    /// 							actionReqs = @(
    /// 								@{
    /// 									# OPTIONAL
    /// 									action = $someString
    /// 								}
    /// 							)
    /// 						}
    /// 					)
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsValidatePermissionsReply
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
    /// $query = New-RscQueryAws -Operation Vpcs
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
    /// $query = New-RscQueryAws -Operation VpcsByRegion
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
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryAws : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ArtifactsToDelete",
                "AvailabilityZonesByRegion",
                "BatchSupportedRdsDatabaseInstanceClasses",
                "CdmVersions",
                "CloudAccountConfigs",
                "CloudAccountListSecurityGroups",
                "CloudAccountListSubnets",
                "CloudAccountListVpcs",
                "CloudAccountWithFeatures",
                "CloudAccountsWithFeatures",
                "DbParameterGroupsByRegion",
                "DbSubnetGroupsByRegion",
                "Ec2InstanceTypesByRegion",
                "Ec2KeyPairsByRegion",
                "EligibleAccountsForMigrationToOrg",
                "ExocomputeConfigs",
                "ExocomputeGetClusterConnectionInfo",
                "InstanceProfileNames",
                "IsS3BucketNameAvailable",
                "KmsEncryptionKeysByRegion",
                "MarketplaceSubscriptionInfo",
                "OptionGroupsByRegion",
                "PermissionPolicies",
                "RdsInstanceDetails",
                "Regions",
                "S3BucketStateForRecovery",
                "S3Buckets",
                "S3BucketsDetails",
                "SupportedEksVersions",
                "SupportedRdsDatabaseInstanceClasses",
                "TrustPolicy",
                "ValidateCreateClusterInput",
                "ValidatePermissions",
                "Vpcs",
                "VpcsByRegion",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

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
                    case "BatchSupportedRdsDatabaseInstanceClasses":
                        this.ProcessRecord_BatchSupportedRdsDatabaseInstanceClasses();
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
                    case "DbParameterGroupsByRegion":
                        this.ProcessRecord_DbParameterGroupsByRegion();
                        break;
                    case "DbSubnetGroupsByRegion":
                        this.ProcessRecord_DbSubnetGroupsByRegion();
                        break;
                    case "Ec2InstanceTypesByRegion":
                        this.ProcessRecord_Ec2InstanceTypesByRegion();
                        break;
                    case "Ec2KeyPairsByRegion":
                        this.ProcessRecord_Ec2KeyPairsByRegion();
                        break;
                    case "EligibleAccountsForMigrationToOrg":
                        this.ProcessRecord_EligibleAccountsForMigrationToOrg();
                        break;
                    case "ExocomputeConfigs":
                        this.ProcessRecord_ExocomputeConfigs();
                        break;
                    case "ExocomputeGetClusterConnectionInfo":
                        this.ProcessRecord_ExocomputeGetClusterConnectionInfo();
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
                    case "MarketplaceSubscriptionInfo":
                        this.ProcessRecord_MarketplaceSubscriptionInfo();
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
                    case "SupportedEksVersions":
                        this.ProcessRecord_SupportedEksVersions();
                        break;
                    case "SupportedRdsDatabaseInstanceClasses":
                        this.ProcessRecord_SupportedRdsDatabaseInstanceClasses();
                        break;
                    case "TrustPolicy":
                        this.ProcessRecord_TrustPolicy();
                        break;
                    case "ValidateCreateClusterInput":
                        this.ProcessRecord_ValidateCreateClusterInput();
                        break;
                    case "ValidatePermissions":
                        this.ProcessRecord_ValidatePermissions();
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
        // batchSupportedAwsRdsDatabaseInstanceClasses.
        internal void ProcessRecord_BatchSupportedRdsDatabaseInstanceClasses()
        {
            this._logger.name += " -BatchSupportedRdsDatabaseInstanceClasses";
            // Create new graphql operation batchSupportedAwsRdsDatabaseInstanceClasses
            InitQueryBatchSupportedAwsRdsDatabaseInstanceClasses();
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
        // allEc2InstanceTypesByRegionFromAws.
        internal void ProcessRecord_Ec2InstanceTypesByRegion()
        {
            this._logger.name += " -Ec2InstanceTypesByRegion";
            // Create new graphql operation allEc2InstanceTypesByRegionFromAws
            InitQueryAllEc2InstanceTypesByRegionFromAws();
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
        // eligibleAccountsForMigrationToAwsOrg.
        internal void ProcessRecord_EligibleAccountsForMigrationToOrg()
        {
            this._logger.name += " -EligibleAccountsForMigrationToOrg";
            // Create new graphql operation eligibleAccountsForMigrationToAwsOrg
            InitQueryEligibleAccountsForMigrationToAwsOrg();
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
        // awsExocomputeGetClusterConnectionInfo.
        internal void ProcessRecord_ExocomputeGetClusterConnectionInfo()
        {
            this._logger.name += " -ExocomputeGetClusterConnectionInfo";
            // Create new graphql operation awsExocomputeGetClusterConnectionInfo
            InitQueryAwsExocomputeGetClusterConnectionInfo();
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
        // awsMarketplaceSubscriptionInfo.
        internal void ProcessRecord_MarketplaceSubscriptionInfo()
        {
            this._logger.name += " -MarketplaceSubscriptionInfo";
            // Create new graphql operation awsMarketplaceSubscriptionInfo
            InitQueryAwsMarketplaceSubscriptionInfo();
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
        // allSupportedAwsEksVersions.
        internal void ProcessRecord_SupportedEksVersions()
        {
            this._logger.name += " -SupportedEksVersions";
            // Create new graphql operation allSupportedAwsEksVersions
            InitQueryAllSupportedAwsEksVersions();
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
        // validateCreateAwsClusterInput.
        internal void ProcessRecord_ValidateCreateClusterInput()
        {
            this._logger.name += " -ValidateCreateClusterInput";
            // Create new graphql operation validateCreateAwsClusterInput
            InitQueryValidateCreateAwsClusterInput();
        }

        // This parameter set invokes a single graphql operation:
        // awsValidatePermissions.
        internal void ProcessRecord_ValidatePermissions()
        {
            this._logger.name += " -ValidatePermissions";
            // Create new graphql operation awsValidatePermissions
            InitQueryAwsValidatePermissions();
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
                Query.AwsArtifactsToDelete,
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
                Query.AllAvailabilityZonesByRegionFromAws,
                Query.AllAvailabilityZonesByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // batchSupportedAwsRdsDatabaseInstanceClasses(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, requests: [RdsInstanceClassRequest!]!): [RdsInstanceClassBatchResult!]!
        internal void InitQueryBatchSupportedAwsRdsDatabaseInstanceClasses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("requests", "[RdsInstanceClassRequest!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBatchSupportedAwsRdsDatabaseInstanceClasses",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$requests: [RdsInstanceClassRequest!]!)",
                "List<RdsInstanceClassBatchResult>",
                Query.BatchSupportedAwsRdsDatabaseInstanceClasses,
                Query.BatchSupportedAwsRdsDatabaseInstanceClassesFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.requests = @(
	@{
		# REQUIRED
		dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
		# OPTIONAL
		dbEngineVersion = $someString
}
)"
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
                Query.AllAwsCdmVersions,
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
                Query.AllAwsCloudAccountConfigs,
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
                Query.AwsCloudAccountListSecurityGroups,
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
                Query.AwsCloudAccountListSubnets,
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
                Query.AwsCloudAccountListVpcs,
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
                Query.AwsCloudAccountWithFeatures,
                Query.AwsCloudAccountWithFeaturesFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString
# REQUIRED
$query.Var.awsCloudAccountArg = @{
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	includeInternalFeatures = $someBoolean
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
                Query.AllAwsCloudAccountsWithFeatures,
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
	# OPTIONAL
	featuresToFilterOut = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
	# OPTIONAL
	includeInternalFeatures = $someBoolean
}"
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
                Query.AllDbParameterGroupsByRegionFromAws,
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
                Query.AllDbSubnetGroupsByRegionFromAws,
                Query.AllDbSubnetGroupsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allEc2InstanceTypesByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [AwsNativeEc2InstanceTypeOffering!]!
        internal void InitQueryAllEc2InstanceTypesByRegionFromAws()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllEc2InstanceTypesByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<AwsNativeEc2InstanceTypeOffering>",
                Query.AllEc2InstanceTypesByRegionFromAws,
                Query.AllEc2InstanceTypesByRegionFromAwsFieldSpec,
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
                Query.AllEc2KeyPairsByRegionFromAws,
                Query.AllEc2KeyPairsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // eligibleAccountsForMigrationToAwsOrg(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     awsOrganizationUuid: UUID!
        //   ): AwsCloudAccountConnection!
        internal void InitQueryEligibleAccountsForMigrationToAwsOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("awsOrganizationUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryEligibleAccountsForMigrationToAwsOrg",
                "($first: Int,$after: String,$last: Int,$before: String,$awsOrganizationUuid: UUID!)",
                "AwsCloudAccountConnection",
                Query.EligibleAccountsForMigrationToAwsOrg,
                Query.EligibleAccountsForMigrationToAwsOrgFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.awsOrganizationUuid = $someString"
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
                Query.AllAwsExocomputeConfigs,
                Query.AllAwsExocomputeConfigsFieldSpec,
                @"# REQUIRED
$query.Var.awsNativeAccountIdOrNamePrefix = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsExocomputeGetClusterConnectionInfo(input: AwsExocomputeGetClusterConnectionInput!): AwsExocomputeGetClusterConnectionInfoReply!
        internal void InitQueryAwsExocomputeGetClusterConnectionInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsExocomputeGetClusterConnectionInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsExocomputeGetClusterConnectionInfo",
                "($input: AwsExocomputeGetClusterConnectionInput!)",
                "AwsExocomputeGetClusterConnectionInfoReply",
                Query.AwsExocomputeGetClusterConnectionInfo,
                Query.AwsExocomputeGetClusterConnectionInfoFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterName = $someString
	# REQUIRED
	exocomputeConfigId = $someString
	# OPTIONAL
	clusterUuid = $someString
	# OPTIONAL
	isPrivateExocompute = $someBoolean
}"
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
                Query.AllAwsInstanceProfileNames,
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
                Query.IsAwsS3BucketNameAvailable,
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
                Query.AllKmsEncryptionKeysByRegionFromAws,
                Query.AllKmsEncryptionKeysByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // awsMarketplaceSubscriptionInfo(input: CheckAwsMarketplaceSubscriptionReq!): CheckAwsMarketplaceSubscriptionReply!
        internal void InitQueryAwsMarketplaceSubscriptionInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CheckAwsMarketplaceSubscriptionReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsMarketplaceSubscriptionInfo",
                "($input: CheckAwsMarketplaceSubscriptionReq!)",
                "CheckAwsMarketplaceSubscriptionReply",
                Query.AwsMarketplaceSubscriptionInfo,
                Query.AwsMarketplaceSubscriptionInfoFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	region = $someString
	# OPTIONAL
	cdmVersion = $someString
	# OPTIONAL
	accountCredentials = @{
		# OPTIONAL
		accessKey = $someString
		# OPTIONAL
		secretKey = $someString
		# OPTIONAL
		token = $someString
	}
	# OPTIONAL
	subnetId = $someString
}"
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
                Query.AllOptionGroupsByRegionFromAws,
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
                Query.AllAwsPermissionPolicies,
                Query.AllAwsPermissionPoliciesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# OPTIONAL
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	featureSpecificDetails = @{
		# OPTIONAL
		ec2RecoveryRolePath = $someString
	}
	# OPTIONAL
	featuresWithPermissionsGroups = @(
		@{
			# OPTIONAL
			featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			# OPTIONAL
			permissionsGroups = @(
				$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
			)
		}
	)
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
                Query.RdsInstanceDetailsFromAws,
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
                Query.AllAwsRegions,
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
                Query.S3BucketStateForRecovery,
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
                Query.AllS3BucketsFromAws,
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
                Query.AllS3BucketsDetailsFromAws,
                Query.AllS3BucketsDetailsFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# OPTIONAL
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allSupportedAwsEksVersions: [String!]!
        internal void InitQueryAllSupportedAwsEksVersions()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSupportedAwsEksVersions",
                "",
                "List<System.String>",
                Query.AllSupportedAwsEksVersions,
                Query.AllSupportedAwsEksVersionsFieldSpec,
                @""
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
                Query.AllSupportedAwsRdsDatabaseInstanceClasses,
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
                Query.AwsTrustPolicy,
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
	# OPTIONAL
	roleChainingAccountId = $someString
	# OPTIONAL
	persistRoleChainingMapping = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // validateCreateAwsClusterInput(input: CreateAwsClusterInput!): ValidationReply!
        internal void InitQueryValidateCreateAwsClusterInput()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsClusterInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateCreateAwsClusterInput",
                "($input: CreateAwsClusterInput!)",
                "ValidationReply",
                Query.ValidateCreateAwsClusterInput,
                Query.ValidateCreateAwsClusterInputFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	isEsType = $someBoolean
	# OPTIONAL
	keepClusterOnFailure = $someBoolean
	# OPTIONAL
	region = $someString
	# OPTIONAL
	disableApiTermination = $someBoolean
	# OPTIONAL
	usePlacementGroups = $someBoolean
	# OPTIONAL
	isAzResilient = $someBoolean
	# OPTIONAL
	clusterConfig = @{
		# OPTIONAL
		userEmail = $someString
		# OPTIONAL
		adminPassword = $someString
		# OPTIONAL
		clusterName = $someString
		# OPTIONAL
		numNodes = $someInt
		# OPTIONAL
		dnsNameServers = @(
			$someString
		)
		# OPTIONAL
		dnsSearchDomains = @(
			$someString
		)
		# OPTIONAL
		ntpServers = @(
			$someString
		)
		# OPTIONAL
		azureEsConfig = @{
			# OPTIONAL
			storageAccount = $someString
			# OPTIONAL
			resourceGroup = $someString
			# OPTIONAL
			storageSecret = $someString
			# OPTIONAL
			containerName = $someString
			# OPTIONAL
			shouldCreateContainer = $someBoolean
			# OPTIONAL
			enableImmutability = $someBoolean
			# OPTIONAL
			managedIdentity = @{
				# OPTIONAL
				name = $someString
				# OPTIONAL
				clientId = $someString
				# OPTIONAL
				resourceGroup = $someString
			}
			# OPTIONAL
			endpointSuffix = $someString
		}
		# OPTIONAL
		awsEsConfig = @{
			# OPTIONAL
			bucketName = $someString
			# OPTIONAL
			shouldCreateBucket = $someBoolean
			# OPTIONAL
			enableObjectLock = $someBoolean
			# OPTIONAL
			enableImmutability = $someBoolean
		}
		# OPTIONAL
		ociEsConfig = @{
			# OPTIONAL
			bucketName = $someString
			# OPTIONAL
			ociNamespace = $someString
			# OPTIONAL
			accessKey = $someString
			# OPTIONAL
			secretKey = $someString
		}
		# OPTIONAL
		gcpEsConfig = @{
			# OPTIONAL
			bucketName = $someString
			# OPTIONAL
			region = $someString
			# OPTIONAL
			shouldCreateBucket = $someBoolean
		}
		# OPTIONAL
		dynamicNumNodes = $someInt
		# OPTIONAL
		dynamicScalingEnabled = $someBoolean
	}
	# OPTIONAL
	vmConfig = @{
		# OPTIONAL
		cdmVersion = $someString
		# OPTIONAL
		nodeSizeGb = $someInt
		# OPTIONAL
		subnet = $someString
		# OPTIONAL
		vpc = $someString
		# OPTIONAL
		tags = $someString
		# OPTIONAL
		imageId = $someString
		# OPTIONAL
		instanceProfileName = $someString
		# OPTIONAL
		cdmProduct = $someString
		# OPTIONAL
		placementGroupName = $someString
		# OPTIONAL
		subnetAzConfigs = @(
			@{
				# OPTIONAL
				subnet = $someString
				# OPTIONAL
				availabilityZone = $someString
			}
		)
		# OPTIONAL
		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		securityGroups = @(
			$someString
		)
		# OPTIONAL
		instanceType = $someAwsInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
		# OPTIONAL
		networkConfig = @(
			@{
				# OPTIONAL
				availabilityZone = $someString
				# OPTIONAL
				subnet = $someString
				# OPTIONAL
				vpc = $someString
			}
		)
	}
	# OPTIONAL
	validations = @(
		$someClusterCreateValidations # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCreateValidations]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Query:
        // awsValidatePermissions(input: AwsValidatePermissionsReq!): AwsValidatePermissionsReply!
        internal void InitQueryAwsValidatePermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsValidatePermissionsReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsValidatePermissions",
                "($input: AwsValidatePermissionsReq!)",
                "AwsValidatePermissionsReply",
                Query.AwsValidatePermissions,
                Query.AwsValidatePermissionsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	accountReqs = @(
		@{
			# OPTIONAL
			cloudAccountId = $someString
			# OPTIONAL
			featureReqs = @(
				@{
					# OPTIONAL
					feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
					# OPTIONAL
					roleReqs = @(
						@{
							# OPTIONAL
							roleType = $someRoleType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RoleType]) for enum values.
							# OPTIONAL
							actionReqs = @(
								@{
									# OPTIONAL
									action = $someString
								}
							)
						}
					)
				}
			)
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
                Query.AllVpcsFromAws,
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
                Query.AllVpcsByRegionFromAws,
                Query.AllVpcsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }


    } // class New_RscQueryAws
}