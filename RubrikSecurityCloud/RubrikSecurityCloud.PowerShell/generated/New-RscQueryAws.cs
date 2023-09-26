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
    /// Create a new RscQuery object for any of the 47
    /// operations in the 'AWS' API domain:
    /// AllAvailabilityZonesByRegion, AllCdmVersions, AllCloudAccountConfigs, AllCloudAccountsWithFeatures, AllComputeSettings, AllDbParameterGroupsByRegion, AllDbSubnetGroupsByRegion, AllEc2KeyPairsByRegion, AllExocomputeConfigs, AllInstanceProfileNames, AllKmsEncryptionKeysByRegion, AllOptionGroupsByRegion, AllPermissionPolicies, AllRegions, AllS3Buckets, AllS3BucketsDetails, AllSupportedRdsDatabaseInstanceClasses, AllVpcs, AllVpcsByRegion, AmiTypeForNativeArchivedSnapshotExport, ArtifactsToDelete, CloudAccountListSecurityGroups, CloudAccountListSubnets, CloudAccountListVpcs, CloudAccountWithFeatures, ComputeSettings, IsNativeEbsVolumeSnapshotRestorable, IsNativeRdsInstanceLaunchConfigurationValid, IsS3BucketNameAvailable, NativeAccount, NativeAccounts, NativeEbsVolume, NativeEbsVolumes, NativeEbsVolumesByName, NativeEc2Instance, NativeEc2Instances, NativeEc2InstancesByName, NativeRdsExportDefaults, NativeRdsInstance, NativeRdsInstances, NativeRdsPointInTimeRestoreWindow, NativeRoot, NativeS3Bucket, RdsInstanceDetails, TrustPolicy, ValidateNativeRdsClusterNameForExport, or ValidateNativeRdsInstanceNameForExport.
    /// </summary>
    /// <description>
    /// New-RscQueryAws creates a new
    /// query object for operations
    /// in the 'AWS' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 47 operations
    /// in the 'AWS' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -AllAvailabilityZonesByRegion, -AllCdmVersions, -AllCloudAccountConfigs, -AllCloudAccountsWithFeatures, -AllComputeSettings, -AllDbParameterGroupsByRegion, -AllDbSubnetGroupsByRegion, -AllEc2KeyPairsByRegion, -AllExocomputeConfigs, -AllInstanceProfileNames, -AllKmsEncryptionKeysByRegion, -AllOptionGroupsByRegion, -AllPermissionPolicies, -AllRegions, -AllS3Buckets, -AllS3BucketsDetails, -AllSupportedRdsDatabaseInstanceClasses, -AllVpcs, -AllVpcsByRegion, -AmiTypeForNativeArchivedSnapshotExport, -ArtifactsToDelete, -CloudAccountListSecurityGroups, -CloudAccountListSubnets, -CloudAccountListVpcs, -CloudAccountWithFeatures, -ComputeSettings, -IsNativeEbsVolumeSnapshotRestorable, -IsNativeRdsInstanceLaunchConfigurationValid, -IsS3BucketNameAvailable, -NativeAccount, -NativeAccounts, -NativeEbsVolume, -NativeEbsVolumes, -NativeEbsVolumesByName, -NativeEc2Instance, -NativeEc2Instances, -NativeEc2InstancesByName, -NativeRdsExportDefaults, -NativeRdsInstance, -NativeRdsInstances, -NativeRdsPointInTimeRestoreWindow, -NativeRoot, -NativeS3Bucket, -RdsInstanceDetails, -TrustPolicy, -ValidateNativeRdsClusterNameForExport, -ValidateNativeRdsInstanceNameForExport.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op AllAvailabilityZonesByRegion,
    /// which is equivalent to specifying -AllAvailabilityZonesByRegion.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryAws -AllAvailabilityZonesByRegion).Info().
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
    /// (New-RscQueryAws -AllAvailabilityZonesByRegion).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AllAvailabilityZonesByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllAvailabilityZonesByRegion
    /// 
    /// $query = New-RscQueryAws -AllAvailabilityZonesByRegion
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
    /// Runs the AllCdmVersions operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllCdmVersions
    /// 
    /// $query = New-RscQueryAws -AllCdmVersions
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
    /// Runs the AllCloudAccountConfigs operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllCloudAccountConfigs
    /// 
    /// $query = New-RscQueryAws -AllCloudAccountConfigs
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
    /// Runs the AllCloudAccountsWithFeatures operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllCloudAccountsWithFeatures
    /// 
    /// $query = New-RscQueryAws -AllCloudAccountsWithFeatures
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
    /// Runs the AllComputeSettings operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllComputeSettings
    /// 
    /// $query = New-RscQueryAws -AllComputeSettings
    /// 
    /// # OPTIONAL
    /// $query.Var.sortBy = $someAwsCloudComputeSettingQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someAwsCloudComputeSettingFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AwsComputeSettings&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AllDbParameterGroupsByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllDbParameterGroupsByRegion
    /// 
    /// $query = New-RscQueryAws -AllDbParameterGroupsByRegion
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
    /// Runs the AllDbSubnetGroupsByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllDbSubnetGroupsByRegion
    /// 
    /// $query = New-RscQueryAws -AllDbSubnetGroupsByRegion
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
    /// Runs the AllEc2KeyPairsByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllEc2KeyPairsByRegion
    /// 
    /// $query = New-RscQueryAws -AllEc2KeyPairsByRegion
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
    /// Runs the AllExocomputeConfigs operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllExocomputeConfigs
    /// 
    /// $query = New-RscQueryAws -AllExocomputeConfigs
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
    /// Runs the AllInstanceProfileNames operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllInstanceProfileNames
    /// 
    /// $query = New-RscQueryAws -AllInstanceProfileNames
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
    /// Runs the AllKmsEncryptionKeysByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllKmsEncryptionKeysByRegion
    /// 
    /// $query = New-RscQueryAws -AllKmsEncryptionKeysByRegion
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
    /// Runs the AllOptionGroupsByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllOptionGroupsByRegion
    /// 
    /// $query = New-RscQueryAws -AllOptionGroupsByRegion
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
    /// Runs the AllPermissionPolicies operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllPermissionPolicies
    /// 
    /// $query = New-RscQueryAws -AllPermissionPolicies
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
    /// Runs the AllRegions operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllRegions
    /// 
    /// $query = New-RscQueryAws -AllRegions
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
    /// Runs the AllS3Buckets operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllS3Buckets
    /// 
    /// $query = New-RscQueryAws -AllS3Buckets
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
    /// Runs the AllS3BucketsDetails operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllS3BucketsDetails
    /// 
    /// $query = New-RscQueryAws -AllS3BucketsDetails
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
    /// Runs the AllSupportedRdsDatabaseInstanceClasses operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllSupportedRdsDatabaseInstanceClasses
    /// 
    /// $query = New-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses
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
    /// Runs the AllVpcs operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllVpcs
    /// 
    /// $query = New-RscQueryAws -AllVpcs
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
    /// Runs the AllVpcsByRegion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AllVpcsByRegion
    /// 
    /// $query = New-RscQueryAws -AllVpcsByRegion
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
    /// <example>
    /// Runs the AmiTypeForNativeArchivedSnapshotExport operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: AmiTypeForNativeArchivedSnapshotExport
    /// 
    /// $query = New-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	destinationRegionId = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 	# REQUIRED
    /// 	destinationAwsAccountRubrikId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AmiTypeForAwsNativeArchivedSnapshotExportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ArtifactsToDelete operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
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
    /// Runs the CloudAccountListSecurityGroups operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
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
    /// # API Domain:    AWS
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
    /// # API Domain:    AWS
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
    /// # API Domain:    AWS
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
    /// Runs the ComputeSettings operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
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
    /// Runs the IsNativeEbsVolumeSnapshotRestorable operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: IsNativeEbsVolumeSnapshotRestorable
    /// 
    /// $query = New-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: IsVolumeSnapshotRestorableReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsNativeRdsInstanceLaunchConfigurationValid operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: IsNativeRdsInstanceLaunchConfigurationValid
    /// 
    /// $query = New-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid
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
    /// $query.Var.dbClass = $someAwsNativeRdsDbInstanceClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
    /// # OPTIONAL
    /// $query.Var.databaseInstanceClass = $someString
    /// # OPTIONAL
    /// $query.Var.primaryAz = $someString
    /// # OPTIONAL
    /// $query.Var.storageType = $someAwsNativeRdsStorageType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsStorageType]) for enum values.
    /// # REQUIRED
    /// $query.Var.isMultiAz = $someBoolean
    /// # OPTIONAL
    /// $query.Var.kmsKeyId = $someString
    /// # OPTIONAL
    /// $query.Var.iops = $someInt
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
    /// Runs the IsS3BucketNameAvailable operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
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
    /// Runs the NativeAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeAccount
    /// 
    /// $query = New-RscQueryAws -NativeAccount
    /// 
    /// # REQUIRED
    /// $query.Var.awsNativeAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.awsNativeProtectionFeature = $someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeAccount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeAccounts operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeAccounts
    /// 
    /// $query = New-RscQueryAws -NativeAccounts
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someAwsNativeAccountSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeAccountSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.accountFilters = @{
    /// 	# OPTIONAL
    /// 	nameSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	cloudTypeFilter = @{
    /// 		# REQUIRED
    /// 		cloudTypes = @(
    /// 			$someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 		)
    /// 	}
    /// }
    /// # OPTIONAL
    /// $query.Var.authorizedOperationFilter = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// # REQUIRED
    /// $query.Var.awsNativeProtectionFeature = $someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeAccountConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeEbsVolume operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeEbsVolume
    /// 
    /// $query = New-RscQueryAws -NativeEbsVolume
    /// 
    /// # REQUIRED
    /// $query.Var.ebsVolumeRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEbsVolume
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeEbsVolumes operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeEbsVolumes
    /// 
    /// $query = New-RscQueryAws -NativeEbsVolumes
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someAwsNativeEbsVolumeSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.ebsVolumeFilters = @{
    /// 	# OPTIONAL
    /// 	nameOrIdSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameOrIdSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	fileRecoveryStatusFilter = @{
    /// 		# REQUIRED
    /// 		statuses = @(
    /// 			$someAwsNativeFileRecoveryStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	typeFilter = @{
    /// 		# REQUIRED
    /// 		ebsVolumeTypes = @(
    /// 			$someAwsNativeEbsVolumeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeType]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	attachedInstanceFilter = @{
    /// 		# REQUIRED
    /// 		ec2InstanceIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	accountFilter = @{
    /// 		# REQUIRED
    /// 		accountIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	regionFilter = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	tagFilter = @{
    /// 		# REQUIRED
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	orgFilter = @{
    /// 		# REQUIRED
    /// 		orgIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEbsVolumeConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeEbsVolumesByName operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeEbsVolumesByName
    /// 
    /// $query = New-RscQueryAws -NativeEbsVolumesByName
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someAwsNativeEbsVolumeSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # REQUIRED
    /// $query.Var.ebsVolumeName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEbsVolumeConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeEc2Instance operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeEc2Instance
    /// 
    /// $query = New-RscQueryAws -NativeEc2Instance
    /// 
    /// # REQUIRED
    /// $query.Var.ec2InstanceRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEc2Instance
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeEc2Instances operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeEc2Instances
    /// 
    /// $query = New-RscQueryAws -NativeEc2Instances
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someAwsNativeEc2InstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.descendantTypeFilter = @(
    /// 	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.ec2InstanceFilters = @{
    /// 	# OPTIONAL
    /// 	nameOrIdSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameOrIdSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	accountFilter = @{
    /// 		# REQUIRED
    /// 		accountIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	fileRecoveryStatusFilter = @{
    /// 		# REQUIRED
    /// 		statuses = @(
    /// 			$someAwsNativeFileRecoveryStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	regionFilter = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	typeFilter = @{
    /// 		# REQUIRED
    /// 		ec2InstanceTypes = @(
    /// 			$someAwsNativeEc2InstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceType]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	vpcFilter = @{
    /// 		# REQUIRED
    /// 		vpcIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	tagFilter = @{
    /// 		# REQUIRED
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	appProtectionStatusFilter = @{
    /// 		# REQUIRED
    /// 		isProtectionSetup = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	rbsStatusFilter = @{
    /// 		# REQUIRED
    /// 		status = $someCloudInstanceRbsConnectionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	orgFilter = @{
    /// 		# REQUIRED
    /// 		orgIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEc2InstanceConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeEc2InstancesByName operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeEc2InstancesByName
    /// 
    /// $query = New-RscQueryAws -NativeEc2InstancesByName
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someAwsNativeEc2InstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # REQUIRED
    /// $query.Var.ec2InstanceName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeEc2InstanceConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeRdsExportDefaults operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeRdsExportDefaults
    /// 
    /// $query = New-RscQueryAws -NativeRdsExportDefaults
    /// 
    /// # REQUIRED
    /// $query.Var.rdsInstanceRubrikId = $someString
    /// # OPTIONAL
    /// $query.Var.snapshotId = $someString
    /// # REQUIRED
    /// $query.Var.isPointInTime = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RdsInstanceExportDefaults
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeRdsInstance operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeRdsInstance
    /// 
    /// $query = New-RscQueryAws -NativeRdsInstance
    /// 
    /// # REQUIRED
    /// $query.Var.rdsInstanceRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeRdsInstance
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeRdsInstances operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeRdsInstances
    /// 
    /// $query = New-RscQueryAws -NativeRdsInstances
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someAwsNativeRdsInstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsInstanceSortFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.rdsInstanceFilters = @{
    /// 	# OPTIONAL
    /// 	nameSubstringFilter = @{
    /// 		# REQUIRED
    /// 		nameSubstring = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	effectiveSlaFilter = @{
    /// 		# REQUIRED
    /// 		effectiveSlaIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	accountFilter = @{
    /// 		# REQUIRED
    /// 		accountIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	vpcFilter = @{
    /// 		# REQUIRED
    /// 		vpcIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	relicFilter = @{
    /// 		# REQUIRED
    /// 		relic = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	tagFilter = @{
    /// 		# REQUIRED
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	regionFilter = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	dbEngineFilter = @{
    /// 		# REQUIRED
    /// 		dbEngines = @(
    /// 			$someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	dbInstanceClassFilter = @{
    /// 		# REQUIRED
    /// 		dbInstanceClasses = @(
    /// 			$someAwsNativeRdsDbInstanceClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	orgFilter = @{
    /// 		# REQUIRED
    /// 		orgIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeRdsInstanceConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeRdsPointInTimeRestoreWindow operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeRdsPointInTimeRestoreWindow
    /// 
    /// $query = New-RscQueryAws -NativeRdsPointInTimeRestoreWindow
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
    /// Write-Host $result.GetType().Name # prints: AwsNativeRdsPointInTimeRestoreWindow
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeRoot operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeRoot
    /// 
    /// $query = New-RscQueryAws -NativeRoot
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeRoot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NativeS3Bucket operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: NativeS3Bucket
    /// 
    /// $query = New-RscQueryAws -NativeS3Bucket
    /// 
    /// # REQUIRED
    /// $query.Var.s3BucketRubrikId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsNativeS3Bucket
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
    /// # API Domain:    AWS
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
    /// Runs the TrustPolicy operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
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
    /// Runs the ValidateNativeRdsClusterNameForExport operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: ValidateNativeRdsClusterNameForExport
    /// 
    /// $query = New-RscQueryAws -ValidateNativeRdsClusterNameForExport
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.rdsClusterName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateAwsNativeRdsClusterNameForExportReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateNativeRdsInstanceNameForExport operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AWS
    /// # API Operation: ValidateNativeRdsInstanceNameForExport
    /// 
    /// $query = New-RscQueryAws -ValidateNativeRdsInstanceNameForExport
    /// 
    /// # REQUIRED
    /// $query.Var.awsAccountRubrikId = $someString
    /// # REQUIRED
    /// $query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.rdsInstanceName = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateAwsNativeRdsInstanceNameForExportReply
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
        DefaultParameterSetName = "AllVpcs")
    ]
    public class New_RscQueryAws : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "AllAvailabilityZonesByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllAvailabilityZonesByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of Availability Zones (AZs) in the specified region on the specified AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allavailabilityzonesbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllAvailabilityZonesByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "AllCdmVersions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllCdmVersions' operation
in the 'AWS' API domain.
Description of the operation:
Get all Rubrik CDM versions in the AWS marketplace.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawscdmversions.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllCdmVersions { get; set; }

        
        [Parameter(
            ParameterSetName = "AllCloudAccountConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllCloudAccountConfigs' operation
in the 'AWS' API domain.
Description of the operation:
List of all AWS cloud account configurations with the given search query.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawscloudaccountconfigs.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllCloudAccountConfigs { get; set; }

        
        [Parameter(
            ParameterSetName = "AllCloudAccountsWithFeatures",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllCloudAccountsWithFeatures' operation
in the 'AWS' API domain.
Description of the operation:
List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawscloudaccountswithfeatures.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllCloudAccountsWithFeatures { get; set; }

        
        [Parameter(
            ParameterSetName = "AllComputeSettings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllComputeSettings' operation
in the 'AWS' API domain.
Description of the operation:
List all aws compute settings.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawscomputesettings.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllComputeSettings { get; set; }

        
        [Parameter(
            ParameterSetName = "AllDbParameterGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllDbParameterGroupsByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/alldbparametergroupsbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllDbParameterGroupsByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "AllDbSubnetGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllDbSubnetGroupsByRegion' operation
in the 'AWS' API domain.
Description of the operation:
All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/alldbsubnetgroupsbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllDbSubnetGroupsByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "AllEc2KeyPairsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllEc2KeyPairsByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allec2keypairsbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllEc2KeyPairsByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "AllExocomputeConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllExocomputeConfigs' operation
in the 'AWS' API domain.
Description of the operation:
List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawsexocomputeconfigs.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllExocomputeConfigs { get; set; }

        
        [Parameter(
            ParameterSetName = "AllInstanceProfileNames",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllInstanceProfileNames' operation
in the 'AWS' API domain.
Description of the operation:
All Rubrik CC-ES instance profiles in the AWS account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawsinstanceprofilenames.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllInstanceProfileNames { get; set; }

        
        [Parameter(
            ParameterSetName = "AllKmsEncryptionKeysByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllKmsEncryptionKeysByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allkmsencryptionkeysbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllKmsEncryptionKeysByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "AllOptionGroupsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllOptionGroupsByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/alloptiongroupsbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllOptionGroupsByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "AllPermissionPolicies",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllPermissionPolicies' operation
in the 'AWS' API domain.
Description of the operation:
Retrieves the permissions policy for all the input features along with any AWS-managed policy ARNs which need to be attached to the roles. Each policy document can be used to create an AWS-managed policy which then needs to be attached to corresponding role.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawspermissionpolicies.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllPermissionPolicies { get; set; }

        
        [Parameter(
            ParameterSetName = "AllRegions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllRegions' operation
in the 'AWS' API domain.
Description of the operation:
All valid AWS regions for this cloud account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allawsregions.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllRegions { get; set; }

        
        [Parameter(
            ParameterSetName = "AllS3Buckets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllS3Buckets' operation
in the 'AWS' API domain.
Description of the operation:
List of all S3 bucket names across regions for the AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/alls3bucketsfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllS3Buckets { get; set; }

        
        [Parameter(
            ParameterSetName = "AllS3BucketsDetails",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllS3BucketsDetails' operation
in the 'AWS' API domain.
Description of the operation:
List of all S3 bucket details across regions for the AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/alls3bucketsdetailsfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllS3BucketsDetails { get; set; }

        
        [Parameter(
            ParameterSetName = "AllSupportedRdsDatabaseInstanceClasses",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllSupportedRdsDatabaseInstanceClasses' operation
in the 'AWS' API domain.
Description of the operation:
List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allsupportedawsrdsdatabaseinstanceclasses.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllSupportedRdsDatabaseInstanceClasses { get; set; }

        
        [Parameter(
            ParameterSetName = "AllVpcs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllVpcs' operation
in the 'AWS' API domain.
Description of the operation:
List of all Virtual Private Clouds (VPCs) in the AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allvpcsfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllVpcs { get; set; }

        
        [Parameter(
            ParameterSetName = "AllVpcsByRegion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AllVpcsByRegion' operation
in the 'AWS' API domain.
Description of the operation:
List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allvpcsbyregionfromaws.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AllVpcsByRegion { get; set; }

        
        [Parameter(
            ParameterSetName = "AmiTypeForNativeArchivedSnapshotExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AmiTypeForNativeArchivedSnapshotExport' operation
in the 'AWS' API domain.
Description of the operation:
Amazon Machine Image (AMI) type for export of an archived EC2 Instance snapshot. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/amitypeforawsnativearchivedsnapshotexport.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AmiTypeForNativeArchivedSnapshotExport { get; set; }

        
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
            ParameterSetName = "IsNativeEbsVolumeSnapshotRestorable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'IsNativeEbsVolumeSnapshotRestorable' operation
in the 'AWS' API domain.
Description of the operation:
Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/isawsnativeebsvolumesnapshotrestorable.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter IsNativeEbsVolumeSnapshotRestorable { get; set; }

        
        [Parameter(
            ParameterSetName = "IsNativeRdsInstanceLaunchConfigurationValid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'IsNativeRdsInstanceLaunchConfigurationValid' operation
in the 'AWS' API domain.
Description of the operation:
Specifies whether the given DbInstance class, storage type, multi-az capability, encryption capability, iops value are supported for the given dbEngine, dbEngineVersion in the specified availability zone. When true, the specification is valid for a RDS Instance and can be used to create a new Instance.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/isawsnativerdsinstancelaunchconfigurationvalid.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter IsNativeRdsInstanceLaunchConfigurationValid { get; set; }

        
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
            ParameterSetName = "NativeAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeAccount' operation
in the 'AWS' API domain.
Description of the operation:
Refers to the AWS Native account that serves as a container for all your AWS resources. The AWS Native account contains information about the metadata related to the AWS Native resources.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativeaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeAccounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeAccounts' operation
in the 'AWS' API domain.
Description of the operation:
Paginated list of all AWS Native accounts.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativeaccounts.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeAccounts { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeEbsVolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeEbsVolume' operation
in the 'AWS' API domain.
Description of the operation:
Refers to the Amazon Elastic Block Store (EBS) Volume represented by a specific ID. For more information, see https://aws.amazon.com/ebs/.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativeebsvolume.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeEbsVolume { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeEbsVolumes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeEbsVolumes' operation
in the 'AWS' API domain.
Description of the operation:
Paginated list of all AWS EBS Volumes.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativeebsvolumes.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeEbsVolumes { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeEbsVolumesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeEbsVolumesByName' operation
in the 'AWS' API domain.
Description of the operation:
Paginated list of all AWS EBS Volumes by name or substring of name.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativeebsvolumesbyname.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeEbsVolumesByName { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeEc2Instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeEc2Instance' operation
in the 'AWS' API domain.
Description of the operation:
Refers to Amazon Elastic Compute Cloud (EC2) Instance represented by a specific ID. For more information, see https://aws.amazon.com/ec2/.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativeec2instance.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeEc2Instance { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeEc2Instances",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeEc2Instances' operation
in the 'AWS' API domain.
Description of the operation:
Paginated list of all AWS EC2 Instances.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativeec2instances.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeEc2Instances { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeEc2InstancesByName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeEc2InstancesByName' operation
in the 'AWS' API domain.
Description of the operation:
Paginated list of all AWS EC2 Instances by name or substring of name.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativeec2instancesbyname.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeEc2InstancesByName { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeRdsExportDefaults",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeRdsExportDefaults' operation
in the 'AWS' API domain.
Description of the operation:
Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativerdsexportdefaults.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeRdsExportDefaults { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeRdsInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeRdsInstance' operation
in the 'AWS' API domain.
Description of the operation:
Refers to AWS Relational Database Service (RDS) represented by a specific ID. For more information, see https://aws.amazon.com/rds/.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativerdsinstance.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeRdsInstance { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeRdsInstances",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeRdsInstances' operation
in the 'AWS' API domain.
Description of the operation:
Paginated list of AWS RDS Instances on AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativerdsinstances.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeRdsInstances { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeRdsPointInTimeRestoreWindow",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeRdsPointInTimeRestoreWindow' operation
in the 'AWS' API domain.
Description of the operation:
Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativerdspointintimerestorewindow.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeRdsPointInTimeRestoreWindow { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeRoot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeRoot' operation
in the 'AWS' API domain.
Description of the operation:
Root of AWS native hierarchy.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnativeroot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeRoot { get; set; }

        
        [Parameter(
            ParameterSetName = "NativeS3Bucket",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'NativeS3Bucket' operation
in the 'AWS' API domain.
Description of the operation:
Represents the Amazon S3 Bucket with a specific ID. For more information, see https://aws.amazon.com/s3/.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/awsnatives3bucket.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter NativeS3Bucket { get; set; }

        
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
            ParameterSetName = "ValidateNativeRdsClusterNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'ValidateNativeRdsClusterNameForExport' operation
in the 'AWS' API domain.
Description of the operation:
Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without an error message for all other failures.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/validateawsnativerdsclusternameforexport.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ValidateNativeRdsClusterNameForExport { get; set; }

        
        [Parameter(
            ParameterSetName = "ValidateNativeRdsInstanceNameForExport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'ValidateNativeRdsInstanceNameForExport' operation
in the 'AWS' API domain.
Description of the operation:
Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false, without an error message for all other failures.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/validateawsnativerdsinstancenameforexport.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ValidateNativeRdsInstanceNameForExport { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AllAvailabilityZonesByRegion":
                        this.ProcessRecord_AllAvailabilityZonesByRegion();
                        break;
                    case "AllCdmVersions":
                        this.ProcessRecord_AllCdmVersions();
                        break;
                    case "AllCloudAccountConfigs":
                        this.ProcessRecord_AllCloudAccountConfigs();
                        break;
                    case "AllCloudAccountsWithFeatures":
                        this.ProcessRecord_AllCloudAccountsWithFeatures();
                        break;
                    case "AllComputeSettings":
                        this.ProcessRecord_AllComputeSettings();
                        break;
                    case "AllDbParameterGroupsByRegion":
                        this.ProcessRecord_AllDbParameterGroupsByRegion();
                        break;
                    case "AllDbSubnetGroupsByRegion":
                        this.ProcessRecord_AllDbSubnetGroupsByRegion();
                        break;
                    case "AllEc2KeyPairsByRegion":
                        this.ProcessRecord_AllEc2KeyPairsByRegion();
                        break;
                    case "AllExocomputeConfigs":
                        this.ProcessRecord_AllExocomputeConfigs();
                        break;
                    case "AllInstanceProfileNames":
                        this.ProcessRecord_AllInstanceProfileNames();
                        break;
                    case "AllKmsEncryptionKeysByRegion":
                        this.ProcessRecord_AllKmsEncryptionKeysByRegion();
                        break;
                    case "AllOptionGroupsByRegion":
                        this.ProcessRecord_AllOptionGroupsByRegion();
                        break;
                    case "AllPermissionPolicies":
                        this.ProcessRecord_AllPermissionPolicies();
                        break;
                    case "AllRegions":
                        this.ProcessRecord_AllRegions();
                        break;
                    case "AllS3Buckets":
                        this.ProcessRecord_AllS3Buckets();
                        break;
                    case "AllS3BucketsDetails":
                        this.ProcessRecord_AllS3BucketsDetails();
                        break;
                    case "AllSupportedRdsDatabaseInstanceClasses":
                        this.ProcessRecord_AllSupportedRdsDatabaseInstanceClasses();
                        break;
                    case "AllVpcs":
                        this.ProcessRecord_AllVpcs();
                        break;
                    case "AllVpcsByRegion":
                        this.ProcessRecord_AllVpcsByRegion();
                        break;
                    case "AmiTypeForNativeArchivedSnapshotExport":
                        this.ProcessRecord_AmiTypeForNativeArchivedSnapshotExport();
                        break;
                    case "ArtifactsToDelete":
                        this.ProcessRecord_ArtifactsToDelete();
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
                    case "ComputeSettings":
                        this.ProcessRecord_ComputeSettings();
                        break;
                    case "IsNativeEbsVolumeSnapshotRestorable":
                        this.ProcessRecord_IsNativeEbsVolumeSnapshotRestorable();
                        break;
                    case "IsNativeRdsInstanceLaunchConfigurationValid":
                        this.ProcessRecord_IsNativeRdsInstanceLaunchConfigurationValid();
                        break;
                    case "IsS3BucketNameAvailable":
                        this.ProcessRecord_IsS3BucketNameAvailable();
                        break;
                    case "NativeAccount":
                        this.ProcessRecord_NativeAccount();
                        break;
                    case "NativeAccounts":
                        this.ProcessRecord_NativeAccounts();
                        break;
                    case "NativeEbsVolume":
                        this.ProcessRecord_NativeEbsVolume();
                        break;
                    case "NativeEbsVolumes":
                        this.ProcessRecord_NativeEbsVolumes();
                        break;
                    case "NativeEbsVolumesByName":
                        this.ProcessRecord_NativeEbsVolumesByName();
                        break;
                    case "NativeEc2Instance":
                        this.ProcessRecord_NativeEc2Instance();
                        break;
                    case "NativeEc2Instances":
                        this.ProcessRecord_NativeEc2Instances();
                        break;
                    case "NativeEc2InstancesByName":
                        this.ProcessRecord_NativeEc2InstancesByName();
                        break;
                    case "NativeRdsExportDefaults":
                        this.ProcessRecord_NativeRdsExportDefaults();
                        break;
                    case "NativeRdsInstance":
                        this.ProcessRecord_NativeRdsInstance();
                        break;
                    case "NativeRdsInstances":
                        this.ProcessRecord_NativeRdsInstances();
                        break;
                    case "NativeRdsPointInTimeRestoreWindow":
                        this.ProcessRecord_NativeRdsPointInTimeRestoreWindow();
                        break;
                    case "NativeRoot":
                        this.ProcessRecord_NativeRoot();
                        break;
                    case "NativeS3Bucket":
                        this.ProcessRecord_NativeS3Bucket();
                        break;
                    case "RdsInstanceDetails":
                        this.ProcessRecord_RdsInstanceDetails();
                        break;
                    case "TrustPolicy":
                        this.ProcessRecord_TrustPolicy();
                        break;
                    case "ValidateNativeRdsClusterNameForExport":
                        this.ProcessRecord_ValidateNativeRdsClusterNameForExport();
                        break;
                    case "ValidateNativeRdsInstanceNameForExport":
                        this.ProcessRecord_ValidateNativeRdsInstanceNameForExport();
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
        // allAvailabilityZonesByRegionFromAws.
        internal void ProcessRecord_AllAvailabilityZonesByRegion()
        {
            this._logger.name += " -AllAvailabilityZonesByRegion";
            // Create new graphql operation allAvailabilityZonesByRegionFromAws
            InitQueryAllAvailabilityZonesByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCdmVersions.
        internal void ProcessRecord_AllCdmVersions()
        {
            this._logger.name += " -AllCdmVersions";
            // Create new graphql operation allAwsCdmVersions
            InitQueryAllAwsCdmVersions();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountConfigs.
        internal void ProcessRecord_AllCloudAccountConfigs()
        {
            this._logger.name += " -AllCloudAccountConfigs";
            // Create new graphql operation allAwsCloudAccountConfigs
            InitQueryAllAwsCloudAccountConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsCloudAccountsWithFeatures.
        internal void ProcessRecord_AllCloudAccountsWithFeatures()
        {
            this._logger.name += " -AllCloudAccountsWithFeatures";
            // Create new graphql operation allAwsCloudAccountsWithFeatures
            InitQueryAllAwsCloudAccountsWithFeatures();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsComputeSettings.
        internal void ProcessRecord_AllComputeSettings()
        {
            this._logger.name += " -AllComputeSettings";
            // Create new graphql operation allAwsComputeSettings
            InitQueryAllAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allDbParameterGroupsByRegionFromAws.
        internal void ProcessRecord_AllDbParameterGroupsByRegion()
        {
            this._logger.name += " -AllDbParameterGroupsByRegion";
            // Create new graphql operation allDbParameterGroupsByRegionFromAws
            InitQueryAllDbParameterGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allDbSubnetGroupsByRegionFromAws.
        internal void ProcessRecord_AllDbSubnetGroupsByRegion()
        {
            this._logger.name += " -AllDbSubnetGroupsByRegion";
            // Create new graphql operation allDbSubnetGroupsByRegionFromAws
            InitQueryAllDbSubnetGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allEc2KeyPairsByRegionFromAws.
        internal void ProcessRecord_AllEc2KeyPairsByRegion()
        {
            this._logger.name += " -AllEc2KeyPairsByRegion";
            // Create new graphql operation allEc2KeyPairsByRegionFromAws
            InitQueryAllEc2KeyPairsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsExocomputeConfigs.
        internal void ProcessRecord_AllExocomputeConfigs()
        {
            this._logger.name += " -AllExocomputeConfigs";
            // Create new graphql operation allAwsExocomputeConfigs
            InitQueryAllAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsInstanceProfileNames.
        internal void ProcessRecord_AllInstanceProfileNames()
        {
            this._logger.name += " -AllInstanceProfileNames";
            // Create new graphql operation allAwsInstanceProfileNames
            InitQueryAllAwsInstanceProfileNames();
        }

        // This parameter set invokes a single graphql operation:
        // allKmsEncryptionKeysByRegionFromAws.
        internal void ProcessRecord_AllKmsEncryptionKeysByRegion()
        {
            this._logger.name += " -AllKmsEncryptionKeysByRegion";
            // Create new graphql operation allKmsEncryptionKeysByRegionFromAws
            InitQueryAllKmsEncryptionKeysByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allOptionGroupsByRegionFromAws.
        internal void ProcessRecord_AllOptionGroupsByRegion()
        {
            this._logger.name += " -AllOptionGroupsByRegion";
            // Create new graphql operation allOptionGroupsByRegionFromAws
            InitQueryAllOptionGroupsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsPermissionPolicies.
        internal void ProcessRecord_AllPermissionPolicies()
        {
            this._logger.name += " -AllPermissionPolicies";
            // Create new graphql operation allAwsPermissionPolicies
            InitQueryAllAwsPermissionPolicies();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsRegions.
        internal void ProcessRecord_AllRegions()
        {
            this._logger.name += " -AllRegions";
            // Create new graphql operation allAwsRegions
            InitQueryAllAwsRegions();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsFromAws.
        internal void ProcessRecord_AllS3Buckets()
        {
            this._logger.name += " -AllS3Buckets";
            // Create new graphql operation allS3BucketsFromAws
            InitQueryAllS3BucketsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allS3BucketsDetailsFromAws.
        internal void ProcessRecord_AllS3BucketsDetails()
        {
            this._logger.name += " -AllS3BucketsDetails";
            // Create new graphql operation allS3BucketsDetailsFromAws
            InitQueryAllS3BucketsDetailsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allSupportedAwsRdsDatabaseInstanceClasses.
        internal void ProcessRecord_AllSupportedRdsDatabaseInstanceClasses()
        {
            this._logger.name += " -AllSupportedRdsDatabaseInstanceClasses";
            // Create new graphql operation allSupportedAwsRdsDatabaseInstanceClasses
            InitQueryAllSupportedAwsRdsDatabaseInstanceClasses();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsFromAws.
        internal void ProcessRecord_AllVpcs()
        {
            this._logger.name += " -AllVpcs";
            // Create new graphql operation allVpcsFromAws
            InitQueryAllVpcsFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // allVpcsByRegionFromAws.
        internal void ProcessRecord_AllVpcsByRegion()
        {
            this._logger.name += " -AllVpcsByRegion";
            // Create new graphql operation allVpcsByRegionFromAws
            InitQueryAllVpcsByRegionFromAws();
        }

        // This parameter set invokes a single graphql operation:
        // amiTypeForAwsNativeArchivedSnapshotExport.
        internal void ProcessRecord_AmiTypeForNativeArchivedSnapshotExport()
        {
            this._logger.name += " -AmiTypeForNativeArchivedSnapshotExport";
            // Create new graphql operation amiTypeForAwsNativeArchivedSnapshotExport
            InitQueryAmiTypeForAwsNativeArchivedSnapshotExport();
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
        // awsComputeSettings.
        internal void ProcessRecord_ComputeSettings()
        {
            this._logger.name += " -ComputeSettings";
            // Create new graphql operation awsComputeSettings
            InitQueryAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeEbsVolumeSnapshotRestorable.
        internal void ProcessRecord_IsNativeEbsVolumeSnapshotRestorable()
        {
            this._logger.name += " -IsNativeEbsVolumeSnapshotRestorable";
            // Create new graphql operation isAwsNativeEbsVolumeSnapshotRestorable
            InitQueryIsAwsNativeEbsVolumeSnapshotRestorable();
        }

        // This parameter set invokes a single graphql operation:
        // isAwsNativeRdsInstanceLaunchConfigurationValid.
        internal void ProcessRecord_IsNativeRdsInstanceLaunchConfigurationValid()
        {
            this._logger.name += " -IsNativeRdsInstanceLaunchConfigurationValid";
            // Create new graphql operation isAwsNativeRdsInstanceLaunchConfigurationValid
            InitQueryIsAwsNativeRdsInstanceLaunchConfigurationValid();
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
        // awsNativeAccount.
        internal void ProcessRecord_NativeAccount()
        {
            this._logger.name += " -NativeAccount";
            // Create new graphql operation awsNativeAccount
            InitQueryAwsNativeAccount();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeAccounts.
        internal void ProcessRecord_NativeAccounts()
        {
            this._logger.name += " -NativeAccounts";
            // Create new graphql operation awsNativeAccounts
            InitQueryAwsNativeAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolume.
        internal void ProcessRecord_NativeEbsVolume()
        {
            this._logger.name += " -NativeEbsVolume";
            // Create new graphql operation awsNativeEbsVolume
            InitQueryAwsNativeEbsVolume();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolumes.
        internal void ProcessRecord_NativeEbsVolumes()
        {
            this._logger.name += " -NativeEbsVolumes";
            // Create new graphql operation awsNativeEbsVolumes
            InitQueryAwsNativeEbsVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEbsVolumesByName.
        internal void ProcessRecord_NativeEbsVolumesByName()
        {
            this._logger.name += " -NativeEbsVolumesByName";
            // Create new graphql operation awsNativeEbsVolumesByName
            InitQueryAwsNativeEbsVolumesByName();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2Instance.
        internal void ProcessRecord_NativeEc2Instance()
        {
            this._logger.name += " -NativeEc2Instance";
            // Create new graphql operation awsNativeEc2Instance
            InitQueryAwsNativeEc2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2Instances.
        internal void ProcessRecord_NativeEc2Instances()
        {
            this._logger.name += " -NativeEc2Instances";
            // Create new graphql operation awsNativeEc2Instances
            InitQueryAwsNativeEc2Instances();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeEc2InstancesByName.
        internal void ProcessRecord_NativeEc2InstancesByName()
        {
            this._logger.name += " -NativeEc2InstancesByName";
            // Create new graphql operation awsNativeEc2InstancesByName
            InitQueryAwsNativeEc2InstancesByName();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsExportDefaults.
        internal void ProcessRecord_NativeRdsExportDefaults()
        {
            this._logger.name += " -NativeRdsExportDefaults";
            // Create new graphql operation awsNativeRdsExportDefaults
            InitQueryAwsNativeRdsExportDefaults();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsInstance.
        internal void ProcessRecord_NativeRdsInstance()
        {
            this._logger.name += " -NativeRdsInstance";
            // Create new graphql operation awsNativeRdsInstance
            InitQueryAwsNativeRdsInstance();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsInstances.
        internal void ProcessRecord_NativeRdsInstances()
        {
            this._logger.name += " -NativeRdsInstances";
            // Create new graphql operation awsNativeRdsInstances
            InitQueryAwsNativeRdsInstances();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRdsPointInTimeRestoreWindow.
        internal void ProcessRecord_NativeRdsPointInTimeRestoreWindow()
        {
            this._logger.name += " -NativeRdsPointInTimeRestoreWindow";
            // Create new graphql operation awsNativeRdsPointInTimeRestoreWindow
            InitQueryAwsNativeRdsPointInTimeRestoreWindow();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeRoot.
        internal void ProcessRecord_NativeRoot()
        {
            this._logger.name += " -NativeRoot";
            // Create new graphql operation awsNativeRoot
            InitQueryAwsNativeRoot();
        }

        // This parameter set invokes a single graphql operation:
        // awsNativeS3Bucket.
        internal void ProcessRecord_NativeS3Bucket()
        {
            this._logger.name += " -NativeS3Bucket";
            // Create new graphql operation awsNativeS3Bucket
            InitQueryAwsNativeS3Bucket();
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
        // awsTrustPolicy.
        internal void ProcessRecord_TrustPolicy()
        {
            this._logger.name += " -TrustPolicy";
            // Create new graphql operation awsTrustPolicy
            InitQueryAwsTrustPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsClusterNameForExport.
        internal void ProcessRecord_ValidateNativeRdsClusterNameForExport()
        {
            this._logger.name += " -ValidateNativeRdsClusterNameForExport";
            // Create new graphql operation validateAwsNativeRdsClusterNameForExport
            InitQueryValidateAwsNativeRdsClusterNameForExport();
        }

        // This parameter set invokes a single graphql operation:
        // validateAwsNativeRdsInstanceNameForExport.
        internal void ProcessRecord_ValidateNativeRdsInstanceNameForExport()
        {
            this._logger.name += " -ValidateNativeRdsInstanceNameForExport";
            // Create new graphql operation validateAwsNativeRdsInstanceNameForExport
            InitQueryValidateAwsNativeRdsInstanceNameForExport();
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
        // allAwsComputeSettings(
        //     sortBy: AwsCloudComputeSettingQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [AwsCloudComputeSettingFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //   ): [AwsComputeSettings!]!
        internal void InitQueryAllAwsComputeSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "AwsCloudComputeSettingQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[AwsCloudComputeSettingFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsComputeSettings",
                "($sortBy: AwsCloudComputeSettingQuerySortByField,$sortOrder: SortOrder,$filter: [AwsCloudComputeSettingFilterInput!],$contextFilter: ContextFilterTypeEnum)",
                "List<AwsComputeSettings>",
                Query.AllAwsComputeSettings_ObjectFieldSpec,
                Query.AllAwsComputeSettingsFieldSpec,
                @"# OPTIONAL
$query.Var.sortBy = $someAwsCloudComputeSettingQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someAwsCloudComputeSettingFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingFilterField]) for enum values.
		# OPTIONAL
		text = $someString
}
)
# OPTIONAL
$query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values."
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

        // Create new GraphQL Query:
        // amiTypeForAwsNativeArchivedSnapshotExport(input: AmiTypeForAwsNativeArchivedSnapshotExportInput!): AmiTypeForAwsNativeArchivedSnapshotExportReply!
        internal void InitQueryAmiTypeForAwsNativeArchivedSnapshotExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AmiTypeForAwsNativeArchivedSnapshotExportInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAmiTypeForAwsNativeArchivedSnapshotExport",
                "($input: AmiTypeForAwsNativeArchivedSnapshotExportInput!)",
                "AmiTypeForAwsNativeArchivedSnapshotExportReply",
                Query.AmiTypeForAwsNativeArchivedSnapshotExport_ObjectFieldSpec,
                Query.AmiTypeForAwsNativeArchivedSnapshotExportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	destinationRegionId = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
	# REQUIRED
	destinationAwsAccountRubrikId = $someString
}"
            );
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
        // isAwsNativeEbsVolumeSnapshotRestorable(snapshotId: String!): IsVolumeSnapshotRestorableReply!
        internal void InitQueryIsAwsNativeEbsVolumeSnapshotRestorable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsNativeEbsVolumeSnapshotRestorable",
                "($snapshotId: String!)",
                "IsVolumeSnapshotRestorableReply",
                Query.IsAwsNativeEbsVolumeSnapshotRestorable_ObjectFieldSpec,
                Query.IsAwsNativeEbsVolumeSnapshotRestorableFieldSpec,
                @"# REQUIRED
$query.Var.snapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // isAwsNativeRdsInstanceLaunchConfigurationValid(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     dbEngine: AwsNativeRdsDbEngine!
        //     dbEngineVersion: String!
        //     dbClass: AwsNativeRdsDbInstanceClass!
        //     databaseInstanceClass: String
        //     primaryAz: String
        //     storageType: AwsNativeRdsStorageType
        //     isMultiAz: Boolean!
        //     kmsKeyId: String
        //     iops: Int
        //   ): Boolean!
        internal void InitQueryIsAwsNativeRdsInstanceLaunchConfigurationValid()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("dbClass", "AwsNativeRdsDbInstanceClass!"),
                Tuple.Create("databaseInstanceClass", "String"),
                Tuple.Create("primaryAz", "String"),
                Tuple.Create("storageType", "AwsNativeRdsStorageType"),
                Tuple.Create("isMultiAz", "Boolean!"),
                Tuple.Create("kmsKeyId", "String"),
                Tuple.Create("iops", "Int"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsNativeRdsInstanceLaunchConfigurationValid",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$dbClass: AwsNativeRdsDbInstanceClass!,$databaseInstanceClass: String,$primaryAz: String,$storageType: AwsNativeRdsStorageType,$isMultiAz: Boolean!,$kmsKeyId: String,$iops: Int)",
                "System.Boolean",
                Query.IsAwsNativeRdsInstanceLaunchConfigurationValid_ObjectFieldSpec,
                Query.IsAwsNativeRdsInstanceLaunchConfigurationValidFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.dbEngine = $someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$query.Var.dbEngineVersion = $someString
# REQUIRED
$query.Var.dbClass = $someAwsNativeRdsDbInstanceClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
# OPTIONAL
$query.Var.databaseInstanceClass = $someString
# OPTIONAL
$query.Var.primaryAz = $someString
# OPTIONAL
$query.Var.storageType = $someAwsNativeRdsStorageType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsStorageType]) for enum values.
# REQUIRED
$query.Var.isMultiAz = $someBoolean
# OPTIONAL
$query.Var.kmsKeyId = $someString
# OPTIONAL
$query.Var.iops = $someInt"
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
        // awsNativeAccount(awsNativeAccountRubrikId: UUID!, awsNativeProtectionFeature: AwsNativeProtectionFeature!): AwsNativeAccount!
        internal void InitQueryAwsNativeAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountRubrikId", "UUID!"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeAccount",
                "($awsNativeAccountRubrikId: UUID!,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)",
                "AwsNativeAccount",
                Query.AwsNativeAccount_ObjectFieldSpec,
                Query.AwsNativeAccountFieldSpec,
                @"# REQUIRED
$query.Var.awsNativeAccountRubrikId = $someString
# REQUIRED
$query.Var.awsNativeProtectionFeature = $someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // awsNativeAccounts(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeAccountSortFields
        //     sortOrder: SortOrder
        //     accountFilters: AwsNativeAccountFilters
        //     authorizedOperationFilter: Operation
        //     awsNativeProtectionFeature: AwsNativeProtectionFeature!
        //   ): AwsNativeAccountConnection!
        internal void InitQueryAwsNativeAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeAccountSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("accountFilters", "AwsNativeAccountFilters"),
                Tuple.Create("authorizedOperationFilter", "Operation"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeAccounts",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeAccountSortFields,$sortOrder: SortOrder,$accountFilters: AwsNativeAccountFilters,$authorizedOperationFilter: Operation,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)",
                "AwsNativeAccountConnection",
                Query.AwsNativeAccounts_ObjectFieldSpec,
                Query.AwsNativeAccountsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeAccountSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeAccountSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.accountFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	cloudTypeFilter = @{
		# REQUIRED
		cloudTypes = @(
			$someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		)
	}
}
# OPTIONAL
$query.Var.authorizedOperationFilter = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
# REQUIRED
$query.Var.awsNativeProtectionFeature = $someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // awsNativeEbsVolume(ebsVolumeRubrikId: UUID!): AwsNativeEbsVolume!
        internal void InitQueryAwsNativeEbsVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ebsVolumeRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEbsVolume",
                "($ebsVolumeRubrikId: UUID!)",
                "AwsNativeEbsVolume",
                Query.AwsNativeEbsVolume_ObjectFieldSpec,
                Query.AwsNativeEbsVolumeFieldSpec,
                @"# REQUIRED
$query.Var.ebsVolumeRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEbsVolumes(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEbsVolumeSortFields
        //     sortOrder: SortOrder
        //     ebsVolumeFilters: AwsNativeEbsVolumeFilters
        //   ): AwsNativeEbsVolumeConnection!
        internal void InitQueryAwsNativeEbsVolumes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEbsVolumeSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ebsVolumeFilters", "AwsNativeEbsVolumeFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEbsVolumes",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeFilters: AwsNativeEbsVolumeFilters)",
                "AwsNativeEbsVolumeConnection",
                Query.AwsNativeEbsVolumes_ObjectFieldSpec,
                Query.AwsNativeEbsVolumesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeEbsVolumeSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.ebsVolumeFilters = @{
	# OPTIONAL
	nameOrIdSubstringFilter = @{
		# REQUIRED
		nameOrIdSubstring = $someString
	}
	# OPTIONAL
	fileRecoveryStatusFilter = @{
		# REQUIRED
		statuses = @(
			$someAwsNativeFileRecoveryStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
		)
	}
	# OPTIONAL
	typeFilter = @{
		# REQUIRED
		ebsVolumeTypes = @(
			$someAwsNativeEbsVolumeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeType]) for enum values.
		)
	}
	# OPTIONAL
	attachedInstanceFilter = @{
		# REQUIRED
		ec2InstanceIds = @(
			$someString
		)
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			$someString
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEbsVolumesByName(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEbsVolumeSortFields
        //     sortOrder: SortOrder
        //     ebsVolumeName: String!
        //   ): AwsNativeEbsVolumeConnection!
        internal void InitQueryAwsNativeEbsVolumesByName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEbsVolumeSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ebsVolumeName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEbsVolumesByName",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeName: String!)",
                "AwsNativeEbsVolumeConnection",
                Query.AwsNativeEbsVolumesByName_ObjectFieldSpec,
                Query.AwsNativeEbsVolumesByNameFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeEbsVolumeSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$query.Var.ebsVolumeName = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEc2Instance(ec2InstanceRubrikId: UUID!): AwsNativeEc2Instance!
        internal void InitQueryAwsNativeEc2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ec2InstanceRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEc2Instance",
                "($ec2InstanceRubrikId: UUID!)",
                "AwsNativeEc2Instance",
                Query.AwsNativeEc2Instance_ObjectFieldSpec,
                Query.AwsNativeEc2InstanceFieldSpec,
                @"# REQUIRED
$query.Var.ec2InstanceRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEc2Instances(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEc2InstanceSortFields
        //     sortOrder: SortOrder
        //     descendantTypeFilter: [HierarchyObjectTypeEnum!]
        //     ec2InstanceFilters: AwsNativeEc2InstanceFilters
        //   ): AwsNativeEc2InstanceConnection!
        internal void InitQueryAwsNativeEc2Instances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEc2InstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("descendantTypeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("ec2InstanceFilters", "AwsNativeEc2InstanceFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEc2Instances",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEc2InstanceSortFields,$sortOrder: SortOrder,$descendantTypeFilter: [HierarchyObjectTypeEnum!],$ec2InstanceFilters: AwsNativeEc2InstanceFilters)",
                "AwsNativeEc2InstanceConnection",
                Query.AwsNativeEc2Instances_ObjectFieldSpec,
                Query.AwsNativeEc2InstancesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeEc2InstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.descendantTypeFilter = @(
	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$query.Var.ec2InstanceFilters = @{
	# OPTIONAL
	nameOrIdSubstringFilter = @{
		# REQUIRED
		nameOrIdSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			$someString
		)
	}
	# OPTIONAL
	fileRecoveryStatusFilter = @{
		# REQUIRED
		statuses = @(
			$someAwsNativeFileRecoveryStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	typeFilter = @{
		# REQUIRED
		ec2InstanceTypes = @(
			$someAwsNativeEc2InstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceType]) for enum values.
		)
	}
	# OPTIONAL
	vpcFilter = @{
		# REQUIRED
		vpcIds = @(
			$someString
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
	}
	# OPTIONAL
	appProtectionStatusFilter = @{
		# REQUIRED
		isProtectionSetup = $someBoolean
	}
	# OPTIONAL
	rbsStatusFilter = @{
		# REQUIRED
		status = $someCloudInstanceRbsConnectionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // awsNativeEc2InstancesByName(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeEc2InstanceSortFields
        //     sortOrder: SortOrder
        //     ec2InstanceName: String!
        //   ): AwsNativeEc2InstanceConnection!
        internal void InitQueryAwsNativeEc2InstancesByName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEc2InstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ec2InstanceName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEc2InstancesByName",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEc2InstanceSortFields,$sortOrder: SortOrder,$ec2InstanceName: String!)",
                "AwsNativeEc2InstanceConnection",
                Query.AwsNativeEc2InstancesByName_ObjectFieldSpec,
                Query.AwsNativeEc2InstancesByNameFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeEc2InstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$query.Var.ec2InstanceName = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsExportDefaults(rdsInstanceRubrikId: UUID!, snapshotId: String, isPointInTime: Boolean!): RdsInstanceExportDefaults!
        internal void InitQueryAwsNativeRdsExportDefaults()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
                Tuple.Create("snapshotId", "String"),
                Tuple.Create("isPointInTime", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsExportDefaults",
                "($rdsInstanceRubrikId: UUID!,$snapshotId: String,$isPointInTime: Boolean!)",
                "RdsInstanceExportDefaults",
                Query.AwsNativeRdsExportDefaults_ObjectFieldSpec,
                Query.AwsNativeRdsExportDefaultsFieldSpec,
                @"# REQUIRED
$query.Var.rdsInstanceRubrikId = $someString
# OPTIONAL
$query.Var.snapshotId = $someString
# REQUIRED
$query.Var.isPointInTime = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsInstance(rdsInstanceRubrikId: UUID!): AwsNativeRdsInstance!
        internal void InitQueryAwsNativeRdsInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsInstance",
                "($rdsInstanceRubrikId: UUID!)",
                "AwsNativeRdsInstance",
                Query.AwsNativeRdsInstance_ObjectFieldSpec,
                Query.AwsNativeRdsInstanceFieldSpec,
                @"# REQUIRED
$query.Var.rdsInstanceRubrikId = $someString"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsInstances(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: AwsNativeRdsInstanceSortFields
        //     sortOrder: SortOrder
        //     rdsInstanceFilters: AwsNativeRdsInstanceFilters
        //   ): AwsNativeRdsInstanceConnection!
        internal void InitQueryAwsNativeRdsInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeRdsInstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("rdsInstanceFilters", "AwsNativeRdsInstanceFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsInstances",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeRdsInstanceSortFields,$sortOrder: SortOrder,$rdsInstanceFilters: AwsNativeRdsInstanceFilters)",
                "AwsNativeRdsInstanceConnection",
                Query.AwsNativeRdsInstances_ObjectFieldSpec,
                Query.AwsNativeRdsInstancesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someAwsNativeRdsInstanceSortFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsInstanceSortFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.rdsInstanceFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = $someString
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			$someString
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			$someString
		)
	}
	# OPTIONAL
	vpcFilter = @{
		# REQUIRED
		vpcIds = @(
			$someString
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = $someBoolean
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			$someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	dbEngineFilter = @{
		# REQUIRED
		dbEngines = @(
			$someAwsNativeRdsDbEngine # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
		)
	}
	# OPTIONAL
	dbInstanceClassFilter = @{
		# REQUIRED
		dbInstanceClasses = @(
			$someAwsNativeRdsDbInstanceClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
		)
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // awsNativeRdsPointInTimeRestoreWindow(
        //     awsAccountRubrikId: UUID!
        //     region: AwsNativeRegion!
        //     rdsInstanceName: String!
        //     rdsDatabaseRubrikId: UUID
        //   ): AwsNativeRdsPointInTimeRestoreWindow!
        internal void InitQueryAwsNativeRdsPointInTimeRestoreWindow()
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
                "QueryAwsNativeRdsPointInTimeRestoreWindow",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)",
                "AwsNativeRdsPointInTimeRestoreWindow",
                Query.AwsNativeRdsPointInTimeRestoreWindow_ObjectFieldSpec,
                Query.AwsNativeRdsPointInTimeRestoreWindowFieldSpec,
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
        // awsNativeRoot: AwsNativeRoot!
        internal void InitQueryAwsNativeRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRoot",
                "",
                "AwsNativeRoot",
                Query.AwsNativeRoot_ObjectFieldSpec,
                Query.AwsNativeRootFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // awsNativeS3Bucket(s3BucketRubrikId: UUID!): AwsNativeS3Bucket!
        internal void InitQueryAwsNativeS3Bucket()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("s3BucketRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeS3Bucket",
                "($s3BucketRubrikId: UUID!)",
                "AwsNativeS3Bucket",
                Query.AwsNativeS3Bucket_ObjectFieldSpec,
                Query.AwsNativeS3BucketFieldSpec,
                @"# REQUIRED
$query.Var.s3BucketRubrikId = $someString"
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
        // validateAwsNativeRdsClusterNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsClusterName: String!): ValidateAwsNativeRdsClusterNameForExportReply!
        internal void InitQueryValidateAwsNativeRdsClusterNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsClusterName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAwsNativeRdsClusterNameForExport",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsClusterName: String!)",
                "ValidateAwsNativeRdsClusterNameForExportReply",
                Query.ValidateAwsNativeRdsClusterNameForExport_ObjectFieldSpec,
                Query.ValidateAwsNativeRdsClusterNameForExportFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.rdsClusterName = $someString"
            );
        }

        // Create new GraphQL Query:
        // validateAwsNativeRdsInstanceNameForExport(awsAccountRubrikId: UUID!, region: AwsNativeRegion!, rdsInstanceName: String!): ValidateAwsNativeRdsInstanceNameForExportReply!
        internal void InitQueryValidateAwsNativeRdsInstanceNameForExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAwsNativeRdsInstanceNameForExport",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!)",
                "ValidateAwsNativeRdsInstanceNameForExportReply",
                Query.ValidateAwsNativeRdsInstanceNameForExport_ObjectFieldSpec,
                Query.ValidateAwsNativeRdsInstanceNameForExportFieldSpec,
                @"# REQUIRED
$query.Var.awsAccountRubrikId = $someString
# REQUIRED
$query.Var.region = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$query.Var.rdsInstanceName = $someString"
            );
        }


    } // class New_RscQueryAws
}