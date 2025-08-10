// New-RscMutationAws.cs
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
    /// Create a new RscQuery object for any of the 37
    /// operations in the 'AWS' API domain:
    /// AddAuthenticationServerBasedCloudAccount, AddIamUserBasedCloudAccount, BulkDeleteCloudAccountWithoutCft, CloudAccountsMigrateInitiate, CreateAccount, CreateAutomaticTargetMapping, CreateCloudNativeStorageSetting, CreateCluster, CreateComputeSetting, CreateExocomputeConfigs, CreateReaderTarget, CreateTarget, DeleteComputeSetting, DeleteExocomputeConfigs, DisconnectExocomputeCluster, ExocomputeClusterConnect, FinalizeCloudAccountDeletion, FinalizeCloudAccountProtection, PatchAuthenticationServerBasedCloudAccount, PatchIamUserBasedCloudAccount, PrepareCloudAccountDeletion, PrepareFeatureUpdateForCloudAccount, RegisterFeatureArtifacts, StartExocomputeDisableJob, UpdateAccount, UpdateAutomaticTargetMapping, UpdateCloudAccount, UpdateCloudAccountFeature, UpdateCloudNativeStorageSetting, UpdateComputeSetting, UpdateExocomputeConfigs, UpdateIamPair, UpdateTarget, UpgradeCloudAccountFeaturesWithoutCft, UpgradeIamUserBasedCloudAccountPermissions, ValidateAndCreateCloudAccount, or ValidateAndInitiateOutpostAccount.
    /// </summary>
    /// <description>
    /// New-RscMutationAws creates a new
    /// mutation object for operations
    /// in the 'AWS' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 37 operations
    /// in the 'AWS' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddAuthenticationServerBasedCloudAccount, AddIamUserBasedCloudAccount, BulkDeleteCloudAccountWithoutCft, CloudAccountsMigrateInitiate, CreateAccount, CreateAutomaticTargetMapping, CreateCloudNativeStorageSetting, CreateCluster, CreateComputeSetting, CreateExocomputeConfigs, CreateReaderTarget, CreateTarget, DeleteComputeSetting, DeleteExocomputeConfigs, DisconnectExocomputeCluster, ExocomputeClusterConnect, FinalizeCloudAccountDeletion, FinalizeCloudAccountProtection, PatchAuthenticationServerBasedCloudAccount, PatchIamUserBasedCloudAccount, PrepareCloudAccountDeletion, PrepareFeatureUpdateForCloudAccount, RegisterFeatureArtifacts, StartExocomputeDisableJob, UpdateAccount, UpdateAutomaticTargetMapping, UpdateCloudAccount, UpdateCloudAccountFeature, UpdateCloudNativeStorageSetting, UpdateComputeSetting, UpdateExocomputeConfigs, UpdateIamPair, UpdateTarget, UpgradeCloudAccountFeaturesWithoutCft, UpgradeIamUserBasedCloudAccountPermissions, ValidateAndCreateCloudAccount, or ValidateAndInitiateOutpostAccount.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationAws -AddAuthenticationServerBasedCloudAccount).Info().
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
    /// (New-RscMutationAws -AddAuthenticationServerBasedCloudAccount).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddAuthenticationServerBasedCloudAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: AddAuthenticationServerBasedCloudAccount
    /// 
    /// $query = New-RscMutationAws -Operation AddAuthenticationServerBasedCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 	# REQUIRED
    /// 	awsAccountName = $someString
    /// 	# OPTIONAL
    /// 	awsRegions = @(
    /// 		$someAwsAuthServerBasedCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsAuthServerBasedCloudAccountRegion]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	nativeId = $someString
    /// 	# OPTIONAL
    /// 	agencyName = $someString
    /// 	# OPTIONAL
    /// 	roleName = $someString
    /// 	# OPTIONAL
    /// 	authServerHostName = $someString
    /// 	# OPTIONAL
    /// 	authServerUserClientCertId = @{
    /// 		# REQUIRED
    /// 		id = $someInt64
    /// 	}
    /// 	# OPTIONAL
    /// 	authServerCaCertId = @{
    /// 		# REQUIRED
    /// 		id = $someInt64
    /// 	}
    /// 	# OPTIONAL
    /// 	awsCaCertId = @{
    /// 		# REQUIRED
    /// 		id = $someInt64
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddAwsAuthenticationServerBasedCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddIamUserBasedCloudAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: AddIamUserBasedCloudAccount
    /// 
    /// $query = New-RscMutationAws -Operation AddIamUserBasedCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	accessKey = $someString
    /// 	# OPTIONAL
    /// 	secretKey = $someString
    /// 	# REQUIRED
    /// 	nativeId = $someString
    /// 	# REQUIRED
    /// 	cloudAccountName = $someString
    /// 	# OPTIONAL
    /// 	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 	# OPTIONAL
    /// 	awsRegions = @(
    /// 		$someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	roleArn = $someString
    /// 	# OPTIONAL
    /// 	externalArtifactMap = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			externalArtifactKey = $someAwsCloudExternalArtifact # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudExternalArtifact]) for enum values.
    /// 			# OPTIONAL
    /// 			externalArtifactValue = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddAwsIamUserBasedCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkDeleteCloudAccountWithoutCft operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: BulkDeleteCloudAccountWithoutCft
    /// 
    /// $query = New-RscMutationAws -Operation BulkDeleteCloudAccountWithoutCft
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsNativeId = $someString
    /// 	# OPTIONAL
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkDeleteAwsCloudAccountWithoutCftReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountsMigrateInitiate operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CloudAccountsMigrateInitiate
    /// 
    /// $query = New-RscMutationAws -Operation CloudAccountsMigrateInitiate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# OPTIONAL
    /// 	awsRoleCustomization = @{
    /// 		# OPTIONAL
    /// 		crossAccountRoleName = $someString
    /// 		# OPTIONAL
    /// 		crossAccountRolePath = $someString
    /// 		# OPTIONAL
    /// 		masterRoleName = $someString
    /// 		# OPTIONAL
    /// 		masterRolePath = $someString
    /// 		# OPTIONAL
    /// 		workerRoleName = $someString
    /// 		# OPTIONAL
    /// 		workerRolePath = $someString
    /// 		# OPTIONAL
    /// 		instanceProfileName = $someString
    /// 		# OPTIONAL
    /// 		instanceProfilePath = $someString
    /// 		# OPTIONAL
    /// 		ec2RecoveryRolePath = $someString
    /// 		# OPTIONAL
    /// 		lambdaRolePath = $someString
    /// 		# OPTIONAL
    /// 		lambdaRoleName = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	roleChainingAccountId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsCloudAccountsMigrateInitiateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CreateAccount
    /// 
    /// $query = New-RscMutationAws -Operation CreateAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	secretKey = $someString
    /// 	# OPTIONAL
    /// 	stsEndpoint = $someString
    /// 	# OPTIONAL
    /// 	stsRegion = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudAccount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateAutomaticTargetMapping operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CreateAutomaticTargetMapping
    /// 
    /// $query = New-RscMutationAws -Operation CreateAutomaticTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	bucketPrefix = $someString
    /// 	# REQUIRED
    /// 	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
    /// 	# REQUIRED
    /// 	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	kmsMasterKeyId = $someString
    /// 	# OPTIONAL
    /// 	rsaKey = $someString
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	proxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	clusterUuidList = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	awsComputeSettingsId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCloudNativeStorageSetting operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CreateCloudNativeStorageSetting
    /// 
    /// $query = New-RscMutationAws -Operation CreateCloudNativeStorageSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	bucketPrefix = $someString
    /// 	# REQUIRED
    /// 	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
    /// 	# OPTIONAL
    /// 	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	kmsMasterKeyId = $someString
    /// 	# REQUIRED
    /// 	cloudNativeLocTemplateType = $someCloudNativeLocTemplateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
    /// 	# OPTIONAL
    /// 	bucketTags = @{
    /// 		# REQUIRED
    /// 		tagList = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				key = $someString
    /// 				# REQUIRED
    /// 				value = $someString
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCloudNativeAwsStorageSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCluster operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CreateCluster
    /// 
    /// $query = New-RscMutationAws -Operation CreateCluster
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
    /// Write-Host $result.GetType().Name # prints: CcProvisionJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateComputeSetting operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CreateComputeSetting
    /// 
    /// $query = New-RscMutationAws -Operation CreateComputeSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	subnetId = $someString
    /// 	# OPTIONAL
    /// 	vpcId = $someString
    /// 	# OPTIONAL
    /// 	securityGroupId = $someString
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	isSecurityGroupPolarisManaged = $someBoolean
    /// 	# OPTIONAL
    /// 	clusterInterfaceCidrs = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			clusterName = $someString
    /// 			# OPTIONAL
    /// 			clusterId = $someString
    /// 			# OPTIONAL
    /// 			interfaceCidr = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					interfaceType = $someInterfaceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InterfaceType]) for enum values.
    /// 					# OPTIONAL
    /// 					cidr = $someString
    /// 					# OPTIONAL
    /// 					selected = $someBoolean
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
    /// Write-Host $result.GetType().Name # prints: AwsComputeSettings
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateExocomputeConfigs operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CreateExocomputeConfigs
    /// 
    /// $query = New-RscMutationAws -Operation CreateExocomputeConfigs
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	configs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			region = $someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
    /// 			# OPTIONAL
    /// 			clusterSecurityGroupId = $someString
    /// 			# OPTIONAL
    /// 			vpcId = $someString
    /// 			# OPTIONAL
    /// 			nodeSecurityGroupId = $someString
    /// 			# OPTIONAL
    /// 			subnets = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					subnetId = $someString
    /// 					# REQUIRED
    /// 					availabilityZone = $someString
    /// 					# OPTIONAL
    /// 					podSubnetId = $someString
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			isRscManaged = $someBoolean
    /// 			# OPTIONAL
    /// 			clusterName = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	triggerHealthCheck = $someBoolean
    /// 	# OPTIONAL
    /// 	optionalHealthChecks = @{
    /// 		# OPTIONAL
    /// 		archivalHealthCheckParams = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				locationId = $someString
    /// 				# REQUIRED
    /// 				name = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		runCloudslabCheck = $someBoolean
    /// 		# OPTIONAL
    /// 		runGcsConnectivityCheck = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateAwsExocomputeConfigsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateReaderTarget operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CreateReaderTarget
    /// 
    /// $query = New-RscMutationAws -Operation CreateReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	bucketName = $someString
    /// 	# REQUIRED
    /// 	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
    /// 	# REQUIRED
    /// 	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	kmsMasterKeyId = $someString
    /// 	# OPTIONAL
    /// 	rsaKey = $someString
    /// 	# OPTIONAL
    /// 	encryptionPassword = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	proxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	awsComputeSettingsId = $someString
    /// 	# OPTIONAL
    /// 	cloudComputeSettings = @{
    /// 		# OPTIONAL
    /// 		subnetId = $someString
    /// 		# OPTIONAL
    /// 		vpcId = $someString
    /// 		# OPTIONAL
    /// 		securityGroupId = $someString
    /// 		# OPTIONAL
    /// 		computeProxySettings = @{
    /// 			# OPTIONAL
    /// 			proxyServer = $someString
    /// 			# OPTIONAL
    /// 			portNumber = $someInt
    /// 			# OPTIONAL
    /// 			username = $someString
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# OPTIONAL
    /// 			protocol = $someString
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	awsRetrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
    /// 	# REQUIRED
    /// 	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
    /// 	# OPTIONAL
    /// 	s3Endpoint = $someString
    /// 	# OPTIONAL
    /// 	kmsEndpoint = $someString
    /// 	# OPTIONAL
    /// 	computeProxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	awsIamPairId = $someString
    /// 	# OPTIONAL
    /// 	archivalDataSourceIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
    /// 	# OPTIONAL
    /// 	awsKmsKey = @{
    /// 		# REQUIRED
    /// 		keyManagerId = $someString
    /// 		# REQUIRED
    /// 		keyId = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateTarget operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: CreateTarget
    /// 
    /// $query = New-RscMutationAws -Operation CreateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	bucketName = $someString
    /// 	# REQUIRED
    /// 	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
    /// 	# REQUIRED
    /// 	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	kmsMasterKeyId = $someString
    /// 	# OPTIONAL
    /// 	rsaKey = $someString
    /// 	# OPTIONAL
    /// 	encryptionPassword = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	proxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	awsComputeSettingsId = $someString
    /// 	# OPTIONAL
    /// 	cloudComputeSettings = @{
    /// 		# OPTIONAL
    /// 		subnetId = $someString
    /// 		# OPTIONAL
    /// 		vpcId = $someString
    /// 		# OPTIONAL
    /// 		securityGroupId = $someString
    /// 		# OPTIONAL
    /// 		computeProxySettings = @{
    /// 			# OPTIONAL
    /// 			proxyServer = $someString
    /// 			# OPTIONAL
    /// 			portNumber = $someInt
    /// 			# OPTIONAL
    /// 			username = $someString
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# OPTIONAL
    /// 			protocol = $someString
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	computeProxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	awsRetrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		lockDurationDays = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	s3Endpoint = $someString
    /// 	# OPTIONAL
    /// 	kmsEndpoint = $someString
    /// 	# OPTIONAL
    /// 	awsIamPairId = $someString
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
    /// 	# OPTIONAL
    /// 	awsKmsKey = @{
    /// 		# REQUIRED
    /// 		keyManagerId = $someString
    /// 		# REQUIRED
    /// 		keyId = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteComputeSetting operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: DeleteComputeSetting
    /// 
    /// $query = New-RscMutationAws -Operation DeleteComputeSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// }
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
    /// Runs the DeleteExocomputeConfigs operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: DeleteExocomputeConfigs
    /// 
    /// $query = New-RscMutationAws -Operation DeleteExocomputeConfigs
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	configIdsToBeDeleted = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteAwsExocomputeConfigsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DisconnectExocomputeCluster operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: DisconnectExocomputeCluster
    /// 
    /// $query = New-RscMutationAws -Operation DisconnectExocomputeCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterId = $someString
    /// }
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
    /// Runs the ExocomputeClusterConnect operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: ExocomputeClusterConnect
    /// 
    /// $query = New-RscMutationAws -Operation ExocomputeClusterConnect
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterName = $someString
    /// 	# REQUIRED
    /// 	exocomputeConfigId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AwsExocomputeClusterConnectReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FinalizeCloudAccountDeletion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: FinalizeCloudAccountDeletion
    /// 
    /// $query = New-RscMutationAws -Operation FinalizeCloudAccountDeletion
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# OPTIONAL
    /// 	awsIamPairId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FinalizeAwsCloudAccountDeletionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FinalizeCloudAccountProtection operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: FinalizeCloudAccountProtection
    /// 
    /// $query = New-RscMutationAws -Operation FinalizeCloudAccountProtection
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	action = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
    /// 	# OPTIONAL
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	awsAdminAccount = @{
    /// 		# OPTIONAL
    /// 		id = $someString
    /// 		# OPTIONAL
    /// 		nativeId = $someString
    /// 		# OPTIONAL
    /// 		accountName = $someString
    /// 		# OPTIONAL
    /// 		seamlessFlowEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		orgName = $someString
    /// 		# OPTIONAL
    /// 		outpostAwsNativeId = $someString
    /// 		# OPTIONAL
    /// 		orgId = $someString
    /// 		# OPTIONAL
    /// 		cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 	}
    /// 	# REQUIRED
    /// 	awsChildAccounts = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			id = $someString
    /// 			# OPTIONAL
    /// 			nativeId = $someString
    /// 			# OPTIONAL
    /// 			accountName = $someString
    /// 			# OPTIONAL
    /// 			seamlessFlowEnabled = $someBoolean
    /// 			# OPTIONAL
    /// 			orgName = $someString
    /// 			# OPTIONAL
    /// 			outpostAwsNativeId = $someString
    /// 			# OPTIONAL
    /// 			orgId = $someString
    /// 			# OPTIONAL
    /// 			cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	awsRegions = @(
    /// 		$someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	stackName = $someString
    /// 	# OPTIONAL
    /// 	stackSetName = $someString
    /// 	# OPTIONAL
    /// 	externalId = $someString
    /// 	# OPTIONAL
    /// 	featureVersion = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 			# OPTIONAL
    /// 			version = $someInt
    /// 			# OPTIONAL
    /// 			permissionsGroupVersions = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					permissionsGroup = $somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 					# OPTIONAL
    /// 					version = $someInt
    /// 				}
    /// 			)
    /// 		}
    /// 	)
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
    /// 	# OPTIONAL
    /// 	awsIamPairId = $someString
    /// 	# OPTIONAL
    /// 	orgId = $someString
    /// 	# OPTIONAL
    /// 	awsChildOus = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			nativeId = $someString
    /// 			# OPTIONAL
    /// 			name = $someString
    /// 			# OPTIONAL
    /// 			cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FinalizeAwsCloudAccountProtectionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PatchAuthenticationServerBasedCloudAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: PatchAuthenticationServerBasedCloudAccount
    /// 
    /// $query = New-RscMutationAws -Operation PatchAuthenticationServerBasedCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsCloudAccountId = $someString
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# OPTIONAL
    /// 	awsRegions = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAwsAuthServerBasedCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsAuthServerBasedCloudAccountRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	roleName = @{
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	authServerUserClientCertId = @{
    /// 		# REQUIRED
    /// 		id = $someInt64
    /// 	}
    /// 	# OPTIONAL
    /// 	authServerCaCertId = @{
    /// 		# REQUIRED
    /// 		id = $someInt64
    /// 	}
    /// }
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
    /// Runs the PatchIamUserBasedCloudAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: PatchIamUserBasedCloudAccount
    /// 
    /// $query = New-RscMutationAws -Operation PatchIamUserBasedCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsCloudAccountId = $someString
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# OPTIONAL
    /// 	awsRegions = @{
    /// 		# REQUIRED
    /// 		regions = @(
    /// 			$someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	awsUserKeys = @{
    /// 		# REQUIRED
    /// 		accessKey = $someString
    /// 		# REQUIRED
    /// 		secretKey = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	awsRoleArn = @{
    /// 		# REQUIRED
    /// 		roleArn = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	externalArtifactMap = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			externalArtifactKey = $someAwsCloudExternalArtifact # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudExternalArtifact]) for enum values.
    /// 			# OPTIONAL
    /// 			externalArtifactValue = $someString
    /// 		}
    /// 	)
    /// }
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
    /// Runs the PrepareCloudAccountDeletion operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: PrepareCloudAccountDeletion
    /// 
    /// $query = New-RscMutationAws -Operation PrepareCloudAccountDeletion
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# OPTIONAL
    /// 	awsRoleCustomization = @{
    /// 		# OPTIONAL
    /// 		crossAccountRoleName = $someString
    /// 		# OPTIONAL
    /// 		crossAccountRolePath = $someString
    /// 		# OPTIONAL
    /// 		masterRoleName = $someString
    /// 		# OPTIONAL
    /// 		masterRolePath = $someString
    /// 		# OPTIONAL
    /// 		workerRoleName = $someString
    /// 		# OPTIONAL
    /// 		workerRolePath = $someString
    /// 		# OPTIONAL
    /// 		instanceProfileName = $someString
    /// 		# OPTIONAL
    /// 		instanceProfilePath = $someString
    /// 		# OPTIONAL
    /// 		ec2RecoveryRolePath = $someString
    /// 		# OPTIONAL
    /// 		lambdaRolePath = $someString
    /// 		# OPTIONAL
    /// 		lambdaRoleName = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	awsIamPairId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PrepareAwsCloudAccountDeletionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PrepareFeatureUpdateForCloudAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: PrepareFeatureUpdateForCloudAccount
    /// 
    /// $query = New-RscMutationAws -Operation PrepareFeatureUpdateForCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
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
    /// 	# OPTIONAL
    /// 	awsRoleCustomization = @{
    /// 		# OPTIONAL
    /// 		crossAccountRoleName = $someString
    /// 		# OPTIONAL
    /// 		crossAccountRolePath = $someString
    /// 		# OPTIONAL
    /// 		masterRoleName = $someString
    /// 		# OPTIONAL
    /// 		masterRolePath = $someString
    /// 		# OPTIONAL
    /// 		workerRoleName = $someString
    /// 		# OPTIONAL
    /// 		workerRolePath = $someString
    /// 		# OPTIONAL
    /// 		instanceProfileName = $someString
    /// 		# OPTIONAL
    /// 		instanceProfilePath = $someString
    /// 		# OPTIONAL
    /// 		ec2RecoveryRolePath = $someString
    /// 		# OPTIONAL
    /// 		lambdaRolePath = $someString
    /// 		# OPTIONAL
    /// 		lambdaRoleName = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	awsIamPairId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PrepareFeatureUpdateForAwsCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RegisterFeatureArtifacts operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: RegisterFeatureArtifacts
    /// 
    /// $query = New-RscMutationAws -Operation RegisterFeatureArtifacts
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsArtifacts = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			awsNativeId = $someString
    /// 			# REQUIRED
    /// 			externalArtifacts = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					externalArtifactValue = $someString
    /// 					# OPTIONAL
    /// 					externalArtifactKey = $someAwsCloudExternalArtifact # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudExternalArtifact]) for enum values.
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			features = @(
    /// 				$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 			)
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	roleChainingAccountId = $someString
    /// 	# OPTIONAL
    /// 	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RegisterAwsFeatureArtifactsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartExocomputeDisableJob operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: StartExocomputeDisableJob
    /// 
    /// $query = New-RscMutationAws -Operation StartExocomputeDisableJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpdateAccount
    /// 
    /// $query = New-RscMutationAws -Operation UpdateAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	secretKey = $someString
    /// 	# OPTIONAL
    /// 	stsEndpoint = $someString
    /// 	# OPTIONAL
    /// 	stsRegion = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudAccount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAutomaticTargetMapping operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpdateAutomaticTargetMapping
    /// 
    /// $query = New-RscMutationAws -Operation UpdateAutomaticTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
    /// 	# OPTIONAL
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	proxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	clusterUuidList = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	awsComputeSettingsId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCloudAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpdateCloudAccount
    /// 
    /// $query = New-RscMutationAws -Operation UpdateCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	awsAccountName = $someString
    /// }
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
    /// Runs the UpdateCloudAccountFeature operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpdateCloudAccountFeature
    /// 
    /// $query = New-RscMutationAws -Operation UpdateCloudAccountFeature
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	action = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# OPTIONAL
    /// 	awsRegions = @(
    /// 		$someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	roleArn = $someString
    /// 	# OPTIONAL
    /// 	stackArn = $someString
    /// 	# OPTIONAL
    /// 	awsAccountName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateAwsCloudAccountFeatureReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCloudNativeStorageSetting operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpdateCloudNativeStorageSetting
    /// 
    /// $query = New-RscMutationAws -Operation UpdateCloudNativeStorageSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
    /// 	# OPTIONAL
    /// 	kmsMasterKeyId = $someString
    /// 	# OPTIONAL
    /// 	bucketTags = @{
    /// 		# REQUIRED
    /// 		tagList = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				key = $someString
    /// 				# REQUIRED
    /// 				value = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	deleteAllBucketTags = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCloudNativeAwsStorageSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateComputeSetting operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpdateComputeSetting
    /// 
    /// $query = New-RscMutationAws -Operation UpdateComputeSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	subnetId = $someString
    /// 	# OPTIONAL
    /// 	vpcId = $someString
    /// 	# OPTIONAL
    /// 	securityGroupId = $someString
    /// }
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
    /// Runs the UpdateExocomputeConfigs operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpdateExocomputeConfigs
    /// 
    /// $query = New-RscMutationAws -Operation UpdateExocomputeConfigs
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	configs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			region = $someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
    /// 			# OPTIONAL
    /// 			clusterSecurityGroupId = $someString
    /// 			# OPTIONAL
    /// 			vpcId = $someString
    /// 			# OPTIONAL
    /// 			nodeSecurityGroupId = $someString
    /// 			# OPTIONAL
    /// 			subnets = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					subnetId = $someString
    /// 					# REQUIRED
    /// 					availabilityZone = $someString
    /// 					# OPTIONAL
    /// 					podSubnetId = $someString
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			isRscManaged = $someBoolean
    /// 			# OPTIONAL
    /// 			clusterName = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	triggerHealthCheck = $someBoolean
    /// 	# OPTIONAL
    /// 	optionalHealthChecks = @{
    /// 		# OPTIONAL
    /// 		archivalHealthCheckParams = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				locationId = $someString
    /// 				# REQUIRED
    /// 				name = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		runCloudslabCheck = $someBoolean
    /// 		# OPTIONAL
    /// 		runGcsConnectivityCheck = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateAwsExocomputeConfigsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateIamPair operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpdateIamPair
    /// 
    /// $query = New-RscMutationAws -Operation UpdateIamPair
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	awsIamPairId = $someString
    /// 	# OPTIONAL
    /// 	awsIamRoleName = $someString
    /// }
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
    /// Runs the UpdateTarget operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpdateTarget
    /// 
    /// $query = New-RscMutationAws -Operation UpdateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
    /// 	# OPTIONAL
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	proxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	awsComputeSettingsId = $someString
    /// 	# OPTIONAL
    /// 	cloudComputeSettings = @{
    /// 		# OPTIONAL
    /// 		subnetId = $someString
    /// 		# OPTIONAL
    /// 		vpcId = $someString
    /// 		# OPTIONAL
    /// 		securityGroupId = $someString
    /// 		# OPTIONAL
    /// 		computeProxySettings = @{
    /// 			# OPTIONAL
    /// 			proxyServer = $someString
    /// 			# OPTIONAL
    /// 			portNumber = $someInt
    /// 			# OPTIONAL
    /// 			username = $someString
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# OPTIONAL
    /// 			protocol = $someString
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	computeProxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	awsRetrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		lockDurationDays = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	s3Endpoint = $someString
    /// 	# OPTIONAL
    /// 	kmsEndpoint = $someString
    /// 	# OPTIONAL
    /// 	bypassProxy = $someBoolean
    /// 	# OPTIONAL
    /// 	awsIamPairId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpgradeCloudAccountFeaturesWithoutCft operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpgradeCloudAccountFeaturesWithoutCft
    /// 
    /// $query = New-RscMutationAws -Operation UpgradeCloudAccountFeaturesWithoutCft
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsCloudAccountId = $someString
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
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpgradeIamUserBasedCloudAccountPermissions operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: UpgradeIamUserBasedCloudAccountPermissions
    /// 
    /// $query = New-RscMutationAws -Operation UpgradeIamUserBasedCloudAccountPermissions
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsCloudAccountId = $someString
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
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateAndCreateCloudAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: ValidateAndCreateCloudAccount
    /// 
    /// $query = New-RscMutationAws -Operation ValidateAndCreateCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	action = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
    /// 	# OPTIONAL
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	awsAdminAccount = @{
    /// 		# OPTIONAL
    /// 		id = $someString
    /// 		# OPTIONAL
    /// 		nativeId = $someString
    /// 		# OPTIONAL
    /// 		accountName = $someString
    /// 		# OPTIONAL
    /// 		seamlessFlowEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		orgName = $someString
    /// 		# OPTIONAL
    /// 		outpostAwsNativeId = $someString
    /// 		# OPTIONAL
    /// 		orgId = $someString
    /// 		# OPTIONAL
    /// 		cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 	}
    /// 	# REQUIRED
    /// 	awsChildAccounts = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			id = $someString
    /// 			# OPTIONAL
    /// 			nativeId = $someString
    /// 			# OPTIONAL
    /// 			accountName = $someString
    /// 			# OPTIONAL
    /// 			seamlessFlowEnabled = $someBoolean
    /// 			# OPTIONAL
    /// 			orgName = $someString
    /// 			# OPTIONAL
    /// 			outpostAwsNativeId = $someString
    /// 			# OPTIONAL
    /// 			orgId = $someString
    /// 			# OPTIONAL
    /// 			cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	awsRoleCustomization = @{
    /// 		# OPTIONAL
    /// 		crossAccountRoleName = $someString
    /// 		# OPTIONAL
    /// 		crossAccountRolePath = $someString
    /// 		# OPTIONAL
    /// 		masterRoleName = $someString
    /// 		# OPTIONAL
    /// 		masterRolePath = $someString
    /// 		# OPTIONAL
    /// 		workerRoleName = $someString
    /// 		# OPTIONAL
    /// 		workerRolePath = $someString
    /// 		# OPTIONAL
    /// 		instanceProfileName = $someString
    /// 		# OPTIONAL
    /// 		instanceProfilePath = $someString
    /// 		# OPTIONAL
    /// 		ec2RecoveryRolePath = $someString
    /// 		# OPTIONAL
    /// 		lambdaRolePath = $someString
    /// 		# OPTIONAL
    /// 		lambdaRoleName = $someString
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
    /// 	# OPTIONAL
    /// 	awsIamPair = @{
    /// 		# OPTIONAL
    /// 		awsIamPairId = $someString
    /// 		# OPTIONAL
    /// 		awsIamRoleName = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	outpostAwsNativeId = $someString
    /// 	# OPTIONAL
    /// 	orgId = $someString
    /// 	# OPTIONAL
    /// 	awsChildOus = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			nativeId = $someString
    /// 			# OPTIONAL
    /// 			name = $someString
    /// 			# OPTIONAL
    /// 			cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	roleChainingAccountId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateAndCreateAwsCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateAndInitiateOutpostAccount operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: ValidateAndInitiateOutpostAccount
    /// 
    /// $query = New-RscMutationAws -Operation ValidateAndInitiateOutpostAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	outpostAwsNativeId = $someString
    /// 	# OPTIONAL
    /// 	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateAndInitiateAwsOutpostAccountReply
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
        "RscMutationAws",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationAws : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddAuthenticationServerBasedCloudAccount",
                "AddIamUserBasedCloudAccount",
                "BulkDeleteCloudAccountWithoutCft",
                "CloudAccountsMigrateInitiate",
                "CreateAccount",
                "CreateAutomaticTargetMapping",
                "CreateCloudNativeStorageSetting",
                "CreateCluster",
                "CreateComputeSetting",
                "CreateExocomputeConfigs",
                "CreateReaderTarget",
                "CreateTarget",
                "DeleteComputeSetting",
                "DeleteExocomputeConfigs",
                "DisconnectExocomputeCluster",
                "ExocomputeClusterConnect",
                "FinalizeCloudAccountDeletion",
                "FinalizeCloudAccountProtection",
                "PatchAuthenticationServerBasedCloudAccount",
                "PatchIamUserBasedCloudAccount",
                "PrepareCloudAccountDeletion",
                "PrepareFeatureUpdateForCloudAccount",
                "RegisterFeatureArtifacts",
                "StartExocomputeDisableJob",
                "UpdateAccount",
                "UpdateAutomaticTargetMapping",
                "UpdateCloudAccount",
                "UpdateCloudAccountFeature",
                "UpdateCloudNativeStorageSetting",
                "UpdateComputeSetting",
                "UpdateExocomputeConfigs",
                "UpdateIamPair",
                "UpdateTarget",
                "UpgradeCloudAccountFeaturesWithoutCft",
                "UpgradeIamUserBasedCloudAccountPermissions",
                "ValidateAndCreateCloudAccount",
                "ValidateAndInitiateOutpostAccount",
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
                    case "AddAuthenticationServerBasedCloudAccount":
                        this.ProcessRecord_AddAuthenticationServerBasedCloudAccount();
                        break;
                    case "AddIamUserBasedCloudAccount":
                        this.ProcessRecord_AddIamUserBasedCloudAccount();
                        break;
                    case "BulkDeleteCloudAccountWithoutCft":
                        this.ProcessRecord_BulkDeleteCloudAccountWithoutCft();
                        break;
                    case "CloudAccountsMigrateInitiate":
                        this.ProcessRecord_CloudAccountsMigrateInitiate();
                        break;
                    case "CreateAccount":
                        this.ProcessRecord_CreateAccount();
                        break;
                    case "CreateAutomaticTargetMapping":
                        this.ProcessRecord_CreateAutomaticTargetMapping();
                        break;
                    case "CreateCloudNativeStorageSetting":
                        this.ProcessRecord_CreateCloudNativeStorageSetting();
                        break;
                    case "CreateCluster":
                        this.ProcessRecord_CreateCluster();
                        break;
                    case "CreateComputeSetting":
                        this.ProcessRecord_CreateComputeSetting();
                        break;
                    case "CreateExocomputeConfigs":
                        this.ProcessRecord_CreateExocomputeConfigs();
                        break;
                    case "CreateReaderTarget":
                        this.ProcessRecord_CreateReaderTarget();
                        break;
                    case "CreateTarget":
                        this.ProcessRecord_CreateTarget();
                        break;
                    case "DeleteComputeSetting":
                        this.ProcessRecord_DeleteComputeSetting();
                        break;
                    case "DeleteExocomputeConfigs":
                        this.ProcessRecord_DeleteExocomputeConfigs();
                        break;
                    case "DisconnectExocomputeCluster":
                        this.ProcessRecord_DisconnectExocomputeCluster();
                        break;
                    case "ExocomputeClusterConnect":
                        this.ProcessRecord_ExocomputeClusterConnect();
                        break;
                    case "FinalizeCloudAccountDeletion":
                        this.ProcessRecord_FinalizeCloudAccountDeletion();
                        break;
                    case "FinalizeCloudAccountProtection":
                        this.ProcessRecord_FinalizeCloudAccountProtection();
                        break;
                    case "PatchAuthenticationServerBasedCloudAccount":
                        this.ProcessRecord_PatchAuthenticationServerBasedCloudAccount();
                        break;
                    case "PatchIamUserBasedCloudAccount":
                        this.ProcessRecord_PatchIamUserBasedCloudAccount();
                        break;
                    case "PrepareCloudAccountDeletion":
                        this.ProcessRecord_PrepareCloudAccountDeletion();
                        break;
                    case "PrepareFeatureUpdateForCloudAccount":
                        this.ProcessRecord_PrepareFeatureUpdateForCloudAccount();
                        break;
                    case "RegisterFeatureArtifacts":
                        this.ProcessRecord_RegisterFeatureArtifacts();
                        break;
                    case "StartExocomputeDisableJob":
                        this.ProcessRecord_StartExocomputeDisableJob();
                        break;
                    case "UpdateAccount":
                        this.ProcessRecord_UpdateAccount();
                        break;
                    case "UpdateAutomaticTargetMapping":
                        this.ProcessRecord_UpdateAutomaticTargetMapping();
                        break;
                    case "UpdateCloudAccount":
                        this.ProcessRecord_UpdateCloudAccount();
                        break;
                    case "UpdateCloudAccountFeature":
                        this.ProcessRecord_UpdateCloudAccountFeature();
                        break;
                    case "UpdateCloudNativeStorageSetting":
                        this.ProcessRecord_UpdateCloudNativeStorageSetting();
                        break;
                    case "UpdateComputeSetting":
                        this.ProcessRecord_UpdateComputeSetting();
                        break;
                    case "UpdateExocomputeConfigs":
                        this.ProcessRecord_UpdateExocomputeConfigs();
                        break;
                    case "UpdateIamPair":
                        this.ProcessRecord_UpdateIamPair();
                        break;
                    case "UpdateTarget":
                        this.ProcessRecord_UpdateTarget();
                        break;
                    case "UpgradeCloudAccountFeaturesWithoutCft":
                        this.ProcessRecord_UpgradeCloudAccountFeaturesWithoutCft();
                        break;
                    case "UpgradeIamUserBasedCloudAccountPermissions":
                        this.ProcessRecord_UpgradeIamUserBasedCloudAccountPermissions();
                        break;
                    case "ValidateAndCreateCloudAccount":
                        this.ProcessRecord_ValidateAndCreateCloudAccount();
                        break;
                    case "ValidateAndInitiateOutpostAccount":
                        this.ProcessRecord_ValidateAndInitiateOutpostAccount();
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
        // addAwsAuthenticationServerBasedCloudAccount.
        internal void ProcessRecord_AddAuthenticationServerBasedCloudAccount()
        {
            this._logger.name += " -AddAuthenticationServerBasedCloudAccount";
            // Create new graphql operation addAwsAuthenticationServerBasedCloudAccount
            InitMutationAddAwsAuthenticationServerBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // addAwsIamUserBasedCloudAccount.
        internal void ProcessRecord_AddIamUserBasedCloudAccount()
        {
            this._logger.name += " -AddIamUserBasedCloudAccount";
            // Create new graphql operation addAwsIamUserBasedCloudAccount
            InitMutationAddAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteAwsCloudAccountWithoutCft.
        internal void ProcessRecord_BulkDeleteCloudAccountWithoutCft()
        {
            this._logger.name += " -BulkDeleteCloudAccountWithoutCft";
            // Create new graphql operation bulkDeleteAwsCloudAccountWithoutCft
            InitMutationBulkDeleteAwsCloudAccountWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // awsCloudAccountsMigrateInitiate.
        internal void ProcessRecord_CloudAccountsMigrateInitiate()
        {
            this._logger.name += " -CloudAccountsMigrateInitiate";
            // Create new graphql operation awsCloudAccountsMigrateInitiate
            InitMutationAwsCloudAccountsMigrateInitiate();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsAccount.
        internal void ProcessRecord_CreateAccount()
        {
            this._logger.name += " -CreateAccount";
            // Create new graphql operation createAwsAccount
            InitMutationCreateAwsAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAwsTargetMapping.
        internal void ProcessRecord_CreateAutomaticTargetMapping()
        {
            this._logger.name += " -CreateAutomaticTargetMapping";
            // Create new graphql operation createAutomaticAwsTargetMapping
            InitMutationCreateAutomaticAwsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAwsStorageSetting.
        internal void ProcessRecord_CreateCloudNativeStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeStorageSetting";
            // Create new graphql operation createCloudNativeAwsStorageSetting
            InitMutationCreateCloudNativeAwsStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsCluster.
        internal void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Create new graphql operation createAwsCluster
            InitMutationCreateAwsCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsComputeSetting.
        internal void ProcessRecord_CreateComputeSetting()
        {
            this._logger.name += " -CreateComputeSetting";
            // Create new graphql operation createAwsComputeSetting
            InitMutationCreateAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsExocomputeConfigs.
        internal void ProcessRecord_CreateExocomputeConfigs()
        {
            this._logger.name += " -CreateExocomputeConfigs";
            // Create new graphql operation createAwsExocomputeConfigs
            InitMutationCreateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsReaderTarget.
        internal void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Create new graphql operation createAwsReaderTarget
            InitMutationCreateAwsReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAwsTarget.
        internal void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Create new graphql operation createAwsTarget
            InitMutationCreateAwsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsComputeSetting.
        internal void ProcessRecord_DeleteComputeSetting()
        {
            this._logger.name += " -DeleteComputeSetting";
            // Create new graphql operation deleteAwsComputeSetting
            InitMutationDeleteAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAwsExocomputeConfigs.
        internal void ProcessRecord_DeleteExocomputeConfigs()
        {
            this._logger.name += " -DeleteExocomputeConfigs";
            // Create new graphql operation deleteAwsExocomputeConfigs
            InitMutationDeleteAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // disconnectAwsExocomputeCluster.
        internal void ProcessRecord_DisconnectExocomputeCluster()
        {
            this._logger.name += " -DisconnectExocomputeCluster";
            // Create new graphql operation disconnectAwsExocomputeCluster
            InitMutationDisconnectAwsExocomputeCluster();
        }

        // This parameter set invokes a single graphql operation:
        // awsExocomputeClusterConnect.
        internal void ProcessRecord_ExocomputeClusterConnect()
        {
            this._logger.name += " -ExocomputeClusterConnect";
            // Create new graphql operation awsExocomputeClusterConnect
            InitMutationAwsExocomputeClusterConnect();
        }

        // This parameter set invokes a single graphql operation:
        // finalizeAwsCloudAccountDeletion.
        internal void ProcessRecord_FinalizeCloudAccountDeletion()
        {
            this._logger.name += " -FinalizeCloudAccountDeletion";
            // Create new graphql operation finalizeAwsCloudAccountDeletion
            InitMutationFinalizeAwsCloudAccountDeletion();
        }

        // This parameter set invokes a single graphql operation:
        // finalizeAwsCloudAccountProtection.
        internal void ProcessRecord_FinalizeCloudAccountProtection()
        {
            this._logger.name += " -FinalizeCloudAccountProtection";
            // Create new graphql operation finalizeAwsCloudAccountProtection
            InitMutationFinalizeAwsCloudAccountProtection();
        }

        // This parameter set invokes a single graphql operation:
        // patchAwsAuthenticationServerBasedCloudAccount.
        internal void ProcessRecord_PatchAuthenticationServerBasedCloudAccount()
        {
            this._logger.name += " -PatchAuthenticationServerBasedCloudAccount";
            // Create new graphql operation patchAwsAuthenticationServerBasedCloudAccount
            InitMutationPatchAwsAuthenticationServerBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // patchAwsIamUserBasedCloudAccount.
        internal void ProcessRecord_PatchIamUserBasedCloudAccount()
        {
            this._logger.name += " -PatchIamUserBasedCloudAccount";
            // Create new graphql operation patchAwsIamUserBasedCloudAccount
            InitMutationPatchAwsIamUserBasedCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // prepareAwsCloudAccountDeletion.
        internal void ProcessRecord_PrepareCloudAccountDeletion()
        {
            this._logger.name += " -PrepareCloudAccountDeletion";
            // Create new graphql operation prepareAwsCloudAccountDeletion
            InitMutationPrepareAwsCloudAccountDeletion();
        }

        // This parameter set invokes a single graphql operation:
        // prepareFeatureUpdateForAwsCloudAccount.
        internal void ProcessRecord_PrepareFeatureUpdateForCloudAccount()
        {
            this._logger.name += " -PrepareFeatureUpdateForCloudAccount";
            // Create new graphql operation prepareFeatureUpdateForAwsCloudAccount
            InitMutationPrepareFeatureUpdateForAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // registerAwsFeatureArtifacts.
        internal void ProcessRecord_RegisterFeatureArtifacts()
        {
            this._logger.name += " -RegisterFeatureArtifacts";
            // Create new graphql operation registerAwsFeatureArtifacts
            InitMutationRegisterAwsFeatureArtifacts();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsExocomputeDisableJob.
        internal void ProcessRecord_StartExocomputeDisableJob()
        {
            this._logger.name += " -StartExocomputeDisableJob";
            // Create new graphql operation startAwsExocomputeDisableJob
            InitMutationStartAwsExocomputeDisableJob();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsAccount.
        internal void ProcessRecord_UpdateAccount()
        {
            this._logger.name += " -UpdateAccount";
            // Create new graphql operation updateAwsAccount
            InitMutationUpdateAwsAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAwsTargetMapping.
        internal void ProcessRecord_UpdateAutomaticTargetMapping()
        {
            this._logger.name += " -UpdateAutomaticTargetMapping";
            // Create new graphql operation updateAutomaticAwsTargetMapping
            InitMutationUpdateAutomaticAwsTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsCloudAccount.
        internal void ProcessRecord_UpdateCloudAccount()
        {
            this._logger.name += " -UpdateCloudAccount";
            // Create new graphql operation updateAwsCloudAccount
            InitMutationUpdateAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsCloudAccountFeature.
        internal void ProcessRecord_UpdateCloudAccountFeature()
        {
            this._logger.name += " -UpdateCloudAccountFeature";
            // Create new graphql operation updateAwsCloudAccountFeature
            InitMutationUpdateAwsCloudAccountFeature();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAwsStorageSetting.
        internal void ProcessRecord_UpdateCloudNativeStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeStorageSetting";
            // Create new graphql operation updateCloudNativeAwsStorageSetting
            InitMutationUpdateCloudNativeAwsStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsComputeSetting.
        internal void ProcessRecord_UpdateComputeSetting()
        {
            this._logger.name += " -UpdateComputeSetting";
            // Create new graphql operation updateAwsComputeSetting
            InitMutationUpdateAwsComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsExocomputeConfigs.
        internal void ProcessRecord_UpdateExocomputeConfigs()
        {
            this._logger.name += " -UpdateExocomputeConfigs";
            // Create new graphql operation updateAwsExocomputeConfigs
            InitMutationUpdateAwsExocomputeConfigs();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsIamPair.
        internal void ProcessRecord_UpdateIamPair()
        {
            this._logger.name += " -UpdateIamPair";
            // Create new graphql operation updateAwsIamPair
            InitMutationUpdateAwsIamPair();
        }

        // This parameter set invokes a single graphql operation:
        // updateAwsTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Create new graphql operation updateAwsTarget
            InitMutationUpdateAwsTarget();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAwsCloudAccountFeaturesWithoutCft.
        internal void ProcessRecord_UpgradeCloudAccountFeaturesWithoutCft()
        {
            this._logger.name += " -UpgradeCloudAccountFeaturesWithoutCft";
            // Create new graphql operation upgradeAwsCloudAccountFeaturesWithoutCft
            InitMutationUpgradeAwsCloudAccountFeaturesWithoutCft();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAwsIamUserBasedCloudAccountPermissions.
        internal void ProcessRecord_UpgradeIamUserBasedCloudAccountPermissions()
        {
            this._logger.name += " -UpgradeIamUserBasedCloudAccountPermissions";
            // Create new graphql operation upgradeAwsIamUserBasedCloudAccountPermissions
            InitMutationUpgradeAwsIamUserBasedCloudAccountPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // validateAndCreateAwsCloudAccount.
        internal void ProcessRecord_ValidateAndCreateCloudAccount()
        {
            this._logger.name += " -ValidateAndCreateCloudAccount";
            // Create new graphql operation validateAndCreateAwsCloudAccount
            InitMutationValidateAndCreateAwsCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // validateAndInitiateAwsOutpostAccount.
        internal void ProcessRecord_ValidateAndInitiateOutpostAccount()
        {
            this._logger.name += " -ValidateAndInitiateOutpostAccount";
            // Create new graphql operation validateAndInitiateAwsOutpostAccount
            InitMutationValidateAndInitiateAwsOutpostAccount();
        }


        // Create new GraphQL Mutation:
        // addAwsAuthenticationServerBasedCloudAccount(input: AddAwsAuthenticationServerBasedCloudAccountInput!): AddAwsAuthenticationServerBasedCloudAccountReply!
        internal void InitMutationAddAwsAuthenticationServerBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAwsAuthenticationServerBasedCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAwsAuthenticationServerBasedCloudAccount",
                "($input: AddAwsAuthenticationServerBasedCloudAccountInput!)",
                "AddAwsAuthenticationServerBasedCloudAccountReply",
                Mutation.AddAwsAuthenticationServerBasedCloudAccount,
                Mutation.AddAwsAuthenticationServerBasedCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	awsAccountName = $someString
	# OPTIONAL
	awsRegions = @(
		$someAwsAuthServerBasedCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsAuthServerBasedCloudAccountRegion]) for enum values.
	)
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	nativeId = $someString
	# OPTIONAL
	agencyName = $someString
	# OPTIONAL
	roleName = $someString
	# OPTIONAL
	authServerHostName = $someString
	# OPTIONAL
	authServerUserClientCertId = @{
		# REQUIRED
		id = $someInt64
	}
	# OPTIONAL
	authServerCaCertId = @{
		# REQUIRED
		id = $someInt64
	}
	# OPTIONAL
	awsCaCertId = @{
		# REQUIRED
		id = $someInt64
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // addAwsIamUserBasedCloudAccount(input: AddAwsIamUserBasedCloudAccountInput!): AddAwsIamUserBasedCloudAccountReply!
        internal void InitMutationAddAwsIamUserBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAwsIamUserBasedCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAwsIamUserBasedCloudAccount",
                "($input: AddAwsIamUserBasedCloudAccountInput!)",
                "AddAwsIamUserBasedCloudAccountReply",
                Mutation.AddAwsIamUserBasedCloudAccount,
                Mutation.AddAwsIamUserBasedCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	accessKey = $someString
	# OPTIONAL
	secretKey = $someString
	# REQUIRED
	nativeId = $someString
	# REQUIRED
	cloudAccountName = $someString
	# OPTIONAL
	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# OPTIONAL
	awsRegions = @(
		$someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	roleArn = $someString
	# OPTIONAL
	externalArtifactMap = @(
		@{
			# OPTIONAL
			externalArtifactKey = $someAwsCloudExternalArtifact # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudExternalArtifact]) for enum values.
			# OPTIONAL
			externalArtifactValue = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteAwsCloudAccountWithoutCft(input: BulkDeleteAwsCloudAccountWithoutCftInput!): BulkDeleteAwsCloudAccountWithoutCftReply!
        internal void InitMutationBulkDeleteAwsCloudAccountWithoutCft()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteAwsCloudAccountWithoutCftInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteAwsCloudAccountWithoutCft",
                "($input: BulkDeleteAwsCloudAccountWithoutCftInput!)",
                "BulkDeleteAwsCloudAccountWithoutCftReply",
                Mutation.BulkDeleteAwsCloudAccountWithoutCft,
                Mutation.BulkDeleteAwsCloudAccountWithoutCftFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsNativeId = $someString
	# OPTIONAL
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // awsCloudAccountsMigrateInitiate(input: AwsCloudAccountsMigrateInitiateInput!): AwsCloudAccountsMigrateInitiateReply!
        internal void InitMutationAwsCloudAccountsMigrateInitiate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsCloudAccountsMigrateInitiateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAwsCloudAccountsMigrateInitiate",
                "($input: AwsCloudAccountsMigrateInitiateInput!)",
                "AwsCloudAccountsMigrateInitiateReply",
                Mutation.AwsCloudAccountsMigrateInitiate,
                Mutation.AwsCloudAccountsMigrateInitiateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# OPTIONAL
	awsRoleCustomization = @{
		# OPTIONAL
		crossAccountRoleName = $someString
		# OPTIONAL
		crossAccountRolePath = $someString
		# OPTIONAL
		masterRoleName = $someString
		# OPTIONAL
		masterRolePath = $someString
		# OPTIONAL
		workerRoleName = $someString
		# OPTIONAL
		workerRolePath = $someString
		# OPTIONAL
		instanceProfileName = $someString
		# OPTIONAL
		instanceProfilePath = $someString
		# OPTIONAL
		ec2RecoveryRolePath = $someString
		# OPTIONAL
		lambdaRolePath = $someString
		# OPTIONAL
		lambdaRoleName = $someString
	}
	# OPTIONAL
	roleChainingAccountId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAwsAccount(input: CreateAwsAccountInput!): CloudAccount!
        internal void InitMutationCreateAwsAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsAccount",
                "($input: CreateAwsAccountInput!)",
                "CloudAccount",
                Mutation.CreateAwsAccount,
                Mutation.CreateAwsAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# OPTIONAL
	description = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	secretKey = $someString
	# OPTIONAL
	stsEndpoint = $someString
	# OPTIONAL
	stsRegion = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAutomaticAwsTargetMapping(input: CreateAutomaticAwsTargetMappingInput!): TargetMapping!
        internal void InitMutationCreateAutomaticAwsTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticAwsTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAutomaticAwsTargetMapping",
                "($input: CreateAutomaticAwsTargetMappingInput!)",
                "TargetMapping",
                Mutation.CreateAutomaticAwsTargetMapping,
                Mutation.CreateAutomaticAwsTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	bucketPrefix = $someString
	# REQUIRED
	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# REQUIRED
	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = $someString
	# OPTIONAL
	rsaKey = $someString
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	clusterUuidList = @(
		$someString
	)
	# OPTIONAL
	awsComputeSettingsId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeAwsStorageSetting(input: CreateCloudNativeAwsStorageSettingInput!): CreateCloudNativeAwsStorageSettingReply!
        internal void InitMutationCreateCloudNativeAwsStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeAwsStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeAwsStorageSetting",
                "($input: CreateCloudNativeAwsStorageSettingInput!)",
                "CreateCloudNativeAwsStorageSettingReply",
                Mutation.CreateCloudNativeAwsStorageSetting,
                Mutation.CreateCloudNativeAwsStorageSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	bucketPrefix = $someString
	# REQUIRED
	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# OPTIONAL
	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = $someString
	# REQUIRED
	cloudNativeLocTemplateType = $someCloudNativeLocTemplateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
	# OPTIONAL
	bucketTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = $someString
				# REQUIRED
				value = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAwsCluster(input: CreateAwsClusterInput!): CcProvisionJobReply!
        internal void InitMutationCreateAwsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsCluster",
                "($input: CreateAwsClusterInput!)",
                "CcProvisionJobReply",
                Mutation.CreateAwsCluster,
                Mutation.CreateAwsClusterFieldSpec,
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

        // Create new GraphQL Mutation:
        // createAwsComputeSetting(input: CreateAwsComputeSettingInput!): AwsComputeSettings!
        internal void InitMutationCreateAwsComputeSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsComputeSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsComputeSetting",
                "($input: CreateAwsComputeSettingInput!)",
                "AwsComputeSettings",
                Mutation.CreateAwsComputeSetting,
                Mutation.CreateAwsComputeSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	subnetId = $someString
	# OPTIONAL
	vpcId = $someString
	# OPTIONAL
	securityGroupId = $someString
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	isSecurityGroupPolarisManaged = $someBoolean
	# OPTIONAL
	clusterInterfaceCidrs = @(
		@{
			# OPTIONAL
			clusterName = $someString
			# OPTIONAL
			clusterId = $someString
			# OPTIONAL
			interfaceCidr = @(
				@{
					# OPTIONAL
					interfaceType = $someInterfaceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InterfaceType]) for enum values.
					# OPTIONAL
					cidr = $someString
					# OPTIONAL
					selected = $someBoolean
				}
			)
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAwsExocomputeConfigs(input: CreateAwsExocomputeConfigsInput!): CreateAwsExocomputeConfigsReply!
        internal void InitMutationCreateAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsExocomputeConfigsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsExocomputeConfigs",
                "($input: CreateAwsExocomputeConfigsInput!)",
                "CreateAwsExocomputeConfigsReply",
                Mutation.CreateAwsExocomputeConfigs,
                Mutation.CreateAwsExocomputeConfigsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	configs = @(
		@{
			# REQUIRED
			region = $someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
			# OPTIONAL
			clusterSecurityGroupId = $someString
			# OPTIONAL
			vpcId = $someString
			# OPTIONAL
			nodeSecurityGroupId = $someString
			# OPTIONAL
			subnets = @(
				@{
					# REQUIRED
					subnetId = $someString
					# REQUIRED
					availabilityZone = $someString
					# OPTIONAL
					podSubnetId = $someString
				}
			)
			# OPTIONAL
			isRscManaged = $someBoolean
			# OPTIONAL
			clusterName = $someString
		}
	)
	# OPTIONAL
	triggerHealthCheck = $someBoolean
	# OPTIONAL
	optionalHealthChecks = @{
		# OPTIONAL
		archivalHealthCheckParams = @(
			@{
				# REQUIRED
				locationId = $someString
				# REQUIRED
				name = $someString
			}
		)
		# OPTIONAL
		runCloudslabCheck = $someBoolean
		# OPTIONAL
		runGcsConnectivityCheck = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAwsReaderTarget(input: CreateAwsReaderTargetInput!): Target!
        internal void InitMutationCreateAwsReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsReaderTarget",
                "($input: CreateAwsReaderTargetInput!)",
                "Target",
                Mutation.CreateAwsReaderTarget,
                Mutation.CreateAwsReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	bucketName = $someString
	# REQUIRED
	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# REQUIRED
	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = $someString
	# OPTIONAL
	rsaKey = $someString
	# OPTIONAL
	encryptionPassword = $someString
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	awsComputeSettingsId = $someString
	# OPTIONAL
	cloudComputeSettings = @{
		# OPTIONAL
		subnetId = $someString
		# OPTIONAL
		vpcId = $someString
		# OPTIONAL
		securityGroupId = $someString
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = $someString
			# OPTIONAL
			portNumber = $someInt
			# OPTIONAL
			username = $someString
			# OPTIONAL
			password = $someString
			# OPTIONAL
			protocol = $someString
		}
	}
	# OPTIONAL
	awsRetrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
	# OPTIONAL
	s3Endpoint = $someString
	# OPTIONAL
	kmsEndpoint = $someString
	# OPTIONAL
	computeProxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	awsIamPairId = $someString
	# OPTIONAL
	archivalDataSourceIds = @(
		$someString
	)
	# REQUIRED
	bypassProxy = $someBoolean
	# OPTIONAL
	awsKmsKey = @{
		# REQUIRED
		keyManagerId = $someString
		# REQUIRED
		keyId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAwsTarget(input: CreateAwsTargetInput!): Target!
        internal void InitMutationCreateAwsTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsTarget",
                "($input: CreateAwsTargetInput!)",
                "Target",
                Mutation.CreateAwsTarget,
                Mutation.CreateAwsTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	bucketName = $someString
	# REQUIRED
	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# REQUIRED
	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = $someString
	# OPTIONAL
	rsaKey = $someString
	# OPTIONAL
	encryptionPassword = $someString
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	awsComputeSettingsId = $someString
	# OPTIONAL
	cloudComputeSettings = @{
		# OPTIONAL
		subnetId = $someString
		# OPTIONAL
		vpcId = $someString
		# OPTIONAL
		securityGroupId = $someString
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = $someString
			# OPTIONAL
			portNumber = $someInt
			# OPTIONAL
			username = $someString
			# OPTIONAL
			password = $someString
			# OPTIONAL
			protocol = $someString
		}
	}
	# OPTIONAL
	computeProxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	awsRetrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = $someInt
	}
	# OPTIONAL
	s3Endpoint = $someString
	# OPTIONAL
	kmsEndpoint = $someString
	# OPTIONAL
	awsIamPairId = $someString
	# REQUIRED
	bypassProxy = $someBoolean
	# OPTIONAL
	awsKmsKey = @{
		# REQUIRED
		keyManagerId = $someString
		# REQUIRED
		keyId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAwsComputeSetting(input: DeleteAwsComputeSettingInput!): Void
        internal void InitMutationDeleteAwsComputeSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsComputeSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAwsComputeSetting",
                "($input: DeleteAwsComputeSettingInput!)",
                "System.String",
                Mutation.DeleteAwsComputeSetting,
                Mutation.DeleteAwsComputeSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAwsExocomputeConfigs(input: DeleteAwsExocomputeConfigsInput!): DeleteAwsExocomputeConfigsReply!
        internal void InitMutationDeleteAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsExocomputeConfigsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAwsExocomputeConfigs",
                "($input: DeleteAwsExocomputeConfigsInput!)",
                "DeleteAwsExocomputeConfigsReply",
                Mutation.DeleteAwsExocomputeConfigs,
                Mutation.DeleteAwsExocomputeConfigsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	configIdsToBeDeleted = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // disconnectAwsExocomputeCluster(input: DisconnectAwsExocomputeClusterInput!): Void
        internal void InitMutationDisconnectAwsExocomputeCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DisconnectAwsExocomputeClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDisconnectAwsExocomputeCluster",
                "($input: DisconnectAwsExocomputeClusterInput!)",
                "System.String",
                Mutation.DisconnectAwsExocomputeCluster,
                Mutation.DisconnectAwsExocomputeClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // awsExocomputeClusterConnect(input: AwsExocomputeClusterConnectInput!): AwsExocomputeClusterConnectReply!
        internal void InitMutationAwsExocomputeClusterConnect()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsExocomputeClusterConnectInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAwsExocomputeClusterConnect",
                "($input: AwsExocomputeClusterConnectInput!)",
                "AwsExocomputeClusterConnectReply",
                Mutation.AwsExocomputeClusterConnect,
                Mutation.AwsExocomputeClusterConnectFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterName = $someString
	# REQUIRED
	exocomputeConfigId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // finalizeAwsCloudAccountDeletion(input: FinalizeAwsCloudAccountDeletionInput!): FinalizeAwsCloudAccountDeletionReply!
        internal void InitMutationFinalizeAwsCloudAccountDeletion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FinalizeAwsCloudAccountDeletionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationFinalizeAwsCloudAccountDeletion",
                "($input: FinalizeAwsCloudAccountDeletionInput!)",
                "FinalizeAwsCloudAccountDeletionReply",
                Mutation.FinalizeAwsCloudAccountDeletion,
                Mutation.FinalizeAwsCloudAccountDeletionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	awsIamPairId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // finalizeAwsCloudAccountProtection(input: FinalizeAwsCloudAccountProtectionInput!): FinalizeAwsCloudAccountProtectionReply!
        internal void InitMutationFinalizeAwsCloudAccountProtection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FinalizeAwsCloudAccountProtectionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationFinalizeAwsCloudAccountProtection",
                "($input: FinalizeAwsCloudAccountProtectionInput!)",
                "FinalizeAwsCloudAccountProtectionReply",
                Mutation.FinalizeAwsCloudAccountProtection,
                Mutation.FinalizeAwsCloudAccountProtectionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	action = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
	# OPTIONAL
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	awsAdminAccount = @{
		# OPTIONAL
		id = $someString
		# OPTIONAL
		nativeId = $someString
		# OPTIONAL
		accountName = $someString
		# OPTIONAL
		seamlessFlowEnabled = $someBoolean
		# OPTIONAL
		orgName = $someString
		# OPTIONAL
		outpostAwsNativeId = $someString
		# OPTIONAL
		orgId = $someString
		# OPTIONAL
		cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	}
	# REQUIRED
	awsChildAccounts = @(
		@{
			# OPTIONAL
			id = $someString
			# OPTIONAL
			nativeId = $someString
			# OPTIONAL
			accountName = $someString
			# OPTIONAL
			seamlessFlowEnabled = $someBoolean
			# OPTIONAL
			orgName = $someString
			# OPTIONAL
			outpostAwsNativeId = $someString
			# OPTIONAL
			orgId = $someString
			# OPTIONAL
			cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		}
	)
	# OPTIONAL
	awsRegions = @(
		$someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	stackName = $someString
	# OPTIONAL
	stackSetName = $someString
	# OPTIONAL
	externalId = $someString
	# OPTIONAL
	featureVersion = @(
		@{
			# REQUIRED
			feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			# OPTIONAL
			version = $someInt
			# OPTIONAL
			permissionsGroupVersions = @(
				@{
					# REQUIRED
					permissionsGroup = $somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
					# OPTIONAL
					version = $someInt
				}
			)
		}
	)
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
	# OPTIONAL
	awsIamPairId = $someString
	# OPTIONAL
	orgId = $someString
	# OPTIONAL
	awsChildOus = @(
		@{
			# OPTIONAL
			nativeId = $someString
			# OPTIONAL
			name = $someString
			# OPTIONAL
			cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // patchAwsAuthenticationServerBasedCloudAccount(input: PatchAwsAuthenticationServerBasedCloudAccountInput!): Boolean!
        internal void InitMutationPatchAwsAuthenticationServerBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchAwsAuthenticationServerBasedCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchAwsAuthenticationServerBasedCloudAccount",
                "($input: PatchAwsAuthenticationServerBasedCloudAccountInput!)",
                "System.Boolean",
                Mutation.PatchAwsAuthenticationServerBasedCloudAccount,
                Mutation.PatchAwsAuthenticationServerBasedCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsCloudAccountId = $someString
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	awsRegions = @{
		# REQUIRED
		regions = @(
			$someAwsAuthServerBasedCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsAuthServerBasedCloudAccountRegion]) for enum values.
		)
	}
	# OPTIONAL
	roleName = @{
		# REQUIRED
		name = $someString
	}
	# OPTIONAL
	authServerUserClientCertId = @{
		# REQUIRED
		id = $someInt64
	}
	# OPTIONAL
	authServerCaCertId = @{
		# REQUIRED
		id = $someInt64
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // patchAwsIamUserBasedCloudAccount(input: PatchAwsIamUserBasedCloudAccountInput!): Boolean!
        internal void InitMutationPatchAwsIamUserBasedCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchAwsIamUserBasedCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchAwsIamUserBasedCloudAccount",
                "($input: PatchAwsIamUserBasedCloudAccountInput!)",
                "System.Boolean",
                Mutation.PatchAwsIamUserBasedCloudAccount,
                Mutation.PatchAwsIamUserBasedCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsCloudAccountId = $someString
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	awsRegions = @{
		# REQUIRED
		regions = @(
			$someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
		)
	}
	# OPTIONAL
	awsUserKeys = @{
		# REQUIRED
		accessKey = $someString
		# REQUIRED
		secretKey = $someString
	}
	# OPTIONAL
	awsRoleArn = @{
		# REQUIRED
		roleArn = $someString
	}
	# OPTIONAL
	externalArtifactMap = @(
		@{
			# OPTIONAL
			externalArtifactKey = $someAwsCloudExternalArtifact # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudExternalArtifact]) for enum values.
			# OPTIONAL
			externalArtifactValue = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // prepareAwsCloudAccountDeletion(input: PrepareAwsCloudAccountDeletionInput!): PrepareAwsCloudAccountDeletionReply!
        internal void InitMutationPrepareAwsCloudAccountDeletion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PrepareAwsCloudAccountDeletionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPrepareAwsCloudAccountDeletion",
                "($input: PrepareAwsCloudAccountDeletionInput!)",
                "PrepareAwsCloudAccountDeletionReply",
                Mutation.PrepareAwsCloudAccountDeletion,
                Mutation.PrepareAwsCloudAccountDeletionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	awsRoleCustomization = @{
		# OPTIONAL
		crossAccountRoleName = $someString
		# OPTIONAL
		crossAccountRolePath = $someString
		# OPTIONAL
		masterRoleName = $someString
		# OPTIONAL
		masterRolePath = $someString
		# OPTIONAL
		workerRoleName = $someString
		# OPTIONAL
		workerRolePath = $someString
		# OPTIONAL
		instanceProfileName = $someString
		# OPTIONAL
		instanceProfilePath = $someString
		# OPTIONAL
		ec2RecoveryRolePath = $someString
		# OPTIONAL
		lambdaRolePath = $someString
		# OPTIONAL
		lambdaRoleName = $someString
	}
	# OPTIONAL
	awsIamPairId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // prepareFeatureUpdateForAwsCloudAccount(input: PrepareFeatureUpdateForAwsCloudAccountInput!): PrepareFeatureUpdateForAwsCloudAccountReply!
        internal void InitMutationPrepareFeatureUpdateForAwsCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PrepareFeatureUpdateForAwsCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPrepareFeatureUpdateForAwsCloudAccount",
                "($input: PrepareFeatureUpdateForAwsCloudAccountInput!)",
                "PrepareFeatureUpdateForAwsCloudAccountReply",
                Mutation.PrepareFeatureUpdateForAwsCloudAccount,
                Mutation.PrepareFeatureUpdateForAwsCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# OPTIONAL
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
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
	# OPTIONAL
	awsRoleCustomization = @{
		# OPTIONAL
		crossAccountRoleName = $someString
		# OPTIONAL
		crossAccountRolePath = $someString
		# OPTIONAL
		masterRoleName = $someString
		# OPTIONAL
		masterRolePath = $someString
		# OPTIONAL
		workerRoleName = $someString
		# OPTIONAL
		workerRolePath = $someString
		# OPTIONAL
		instanceProfileName = $someString
		# OPTIONAL
		instanceProfilePath = $someString
		# OPTIONAL
		ec2RecoveryRolePath = $someString
		# OPTIONAL
		lambdaRolePath = $someString
		# OPTIONAL
		lambdaRoleName = $someString
	}
	# OPTIONAL
	awsIamPairId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // registerAwsFeatureArtifacts(input: RegisterAwsFeatureArtifactsInput!): RegisterAwsFeatureArtifactsReply!
        internal void InitMutationRegisterAwsFeatureArtifacts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAwsFeatureArtifactsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterAwsFeatureArtifacts",
                "($input: RegisterAwsFeatureArtifactsInput!)",
                "RegisterAwsFeatureArtifactsReply",
                Mutation.RegisterAwsFeatureArtifacts,
                Mutation.RegisterAwsFeatureArtifactsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsArtifacts = @(
		@{
			# REQUIRED
			awsNativeId = $someString
			# REQUIRED
			externalArtifacts = @(
				@{
					# REQUIRED
					externalArtifactValue = $someString
					# OPTIONAL
					externalArtifactKey = $someAwsCloudExternalArtifact # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudExternalArtifact]) for enum values.
				}
			)
			# REQUIRED
			features = @(
				$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			)
		}
	)
	# OPTIONAL
	roleChainingAccountId = $someString
	# OPTIONAL
	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAwsExocomputeDisableJob(input: StartAwsExocomputeDisableJobInput!): AsyncJobStatus!
        internal void InitMutationStartAwsExocomputeDisableJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsExocomputeDisableJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAwsExocomputeDisableJob",
                "($input: StartAwsExocomputeDisableJobInput!)",
                "AsyncJobStatus",
                Mutation.StartAwsExocomputeDisableJob,
                Mutation.StartAwsExocomputeDisableJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAwsAccount(input: UpdateAwsAccountInput!): CloudAccount!
        internal void InitMutationUpdateAwsAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAwsAccount",
                "($input: UpdateAwsAccountInput!)",
                "CloudAccount",
                Mutation.UpdateAwsAccount,
                Mutation.UpdateAwsAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	name = $someString
	# OPTIONAL
	description = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	secretKey = $someString
	# OPTIONAL
	stsEndpoint = $someString
	# OPTIONAL
	stsRegion = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAutomaticAwsTargetMapping(input: UpdateAutomaticAwsTargetMappingInput!): TargetMapping!
        internal void InitMutationUpdateAutomaticAwsTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutomaticAwsTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAutomaticAwsTargetMapping",
                "($input: UpdateAutomaticAwsTargetMappingInput!)",
                "TargetMapping",
                Mutation.UpdateAutomaticAwsTargetMapping,
                Mutation.UpdateAutomaticAwsTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# OPTIONAL
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	clusterUuidList = @(
		$someString
	)
	# OPTIONAL
	awsComputeSettingsId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAwsCloudAccount(input: UpdateAwsCloudAccountInput!): Void
        internal void InitMutationUpdateAwsCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAwsCloudAccount",
                "($input: UpdateAwsCloudAccountInput!)",
                "System.String",
                Mutation.UpdateAwsCloudAccount,
                Mutation.UpdateAwsCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# OPTIONAL
	awsAccountName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAwsCloudAccountFeature(input: UpdateAwsCloudAccountFeatureInput!): UpdateAwsCloudAccountFeatureReply!
        internal void InitMutationUpdateAwsCloudAccountFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsCloudAccountFeatureInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAwsCloudAccountFeature",
                "($input: UpdateAwsCloudAccountFeatureInput!)",
                "UpdateAwsCloudAccountFeatureReply",
                Mutation.UpdateAwsCloudAccountFeature,
                Mutation.UpdateAwsCloudAccountFeatureFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	action = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	awsRegions = @(
		$someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	roleArn = $someString
	# OPTIONAL
	stackArn = $someString
	# OPTIONAL
	awsAccountName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeAwsStorageSetting(input: UpdateCloudNativeAwsStorageSettingInput!): UpdateCloudNativeAwsStorageSettingReply!
        internal void InitMutationUpdateCloudNativeAwsStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeAwsStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeAwsStorageSetting",
                "($input: UpdateCloudNativeAwsStorageSettingInput!)",
                "UpdateCloudNativeAwsStorageSettingReply",
                Mutation.UpdateCloudNativeAwsStorageSetting,
                Mutation.UpdateCloudNativeAwsStorageSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = $someString
	# OPTIONAL
	bucketTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = $someString
				# REQUIRED
				value = $someString
			}
		)
	}
	# OPTIONAL
	deleteAllBucketTags = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAwsComputeSetting(input: UpdateAwsComputeSettingInput!): AwsComputeSettings!
        internal void InitMutationUpdateAwsComputeSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsComputeSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAwsComputeSetting",
                "($input: UpdateAwsComputeSettingInput!)",
                "AwsComputeSettings",
                Mutation.UpdateAwsComputeSetting,
                Mutation.UpdateAwsComputeSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	subnetId = $someString
	# OPTIONAL
	vpcId = $someString
	# OPTIONAL
	securityGroupId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAwsExocomputeConfigs(input: UpdateAwsExocomputeConfigsInput!): UpdateAwsExocomputeConfigsReply!
        internal void InitMutationUpdateAwsExocomputeConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsExocomputeConfigsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAwsExocomputeConfigs",
                "($input: UpdateAwsExocomputeConfigsInput!)",
                "UpdateAwsExocomputeConfigsReply",
                Mutation.UpdateAwsExocomputeConfigs,
                Mutation.UpdateAwsExocomputeConfigsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	configs = @(
		@{
			# REQUIRED
			region = $someAwsCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
			# OPTIONAL
			clusterSecurityGroupId = $someString
			# OPTIONAL
			vpcId = $someString
			# OPTIONAL
			nodeSecurityGroupId = $someString
			# OPTIONAL
			subnets = @(
				@{
					# REQUIRED
					subnetId = $someString
					# REQUIRED
					availabilityZone = $someString
					# OPTIONAL
					podSubnetId = $someString
				}
			)
			# OPTIONAL
			isRscManaged = $someBoolean
			# OPTIONAL
			clusterName = $someString
		}
	)
	# OPTIONAL
	triggerHealthCheck = $someBoolean
	# OPTIONAL
	optionalHealthChecks = @{
		# OPTIONAL
		archivalHealthCheckParams = @(
			@{
				# REQUIRED
				locationId = $someString
				# REQUIRED
				name = $someString
			}
		)
		# OPTIONAL
		runCloudslabCheck = $someBoolean
		# OPTIONAL
		runGcsConnectivityCheck = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAwsIamPair(input: UpdateAwsIamPairInput!): Void
        internal void InitMutationUpdateAwsIamPair()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsIamPairInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAwsIamPair",
                "($input: UpdateAwsIamPairInput!)",
                "System.String",
                Mutation.UpdateAwsIamPair,
                Mutation.UpdateAwsIamPairFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	awsIamPairId = $someString
	# OPTIONAL
	awsIamRoleName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAwsTarget(input: UpdateAwsTargetInput!): Target!
        internal void InitMutationUpdateAwsTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAwsTarget",
                "($input: UpdateAwsTargetInput!)",
                "Target",
                Mutation.UpdateAwsTarget,
                Mutation.UpdateAwsTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	storageClass = $someAwsStorageClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# OPTIONAL
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	awsComputeSettingsId = $someString
	# OPTIONAL
	cloudComputeSettings = @{
		# OPTIONAL
		subnetId = $someString
		# OPTIONAL
		vpcId = $someString
		# OPTIONAL
		securityGroupId = $someString
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = $someString
			# OPTIONAL
			portNumber = $someInt
			# OPTIONAL
			username = $someString
			# OPTIONAL
			password = $someString
			# OPTIONAL
			protocol = $someString
		}
	}
	# OPTIONAL
	computeProxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	awsRetrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = $someInt
	}
	# OPTIONAL
	s3Endpoint = $someString
	# OPTIONAL
	kmsEndpoint = $someString
	# OPTIONAL
	bypassProxy = $someBoolean
	# OPTIONAL
	awsIamPairId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeAwsCloudAccountFeaturesWithoutCft(input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!): Boolean!
        internal void InitMutationUpgradeAwsCloudAccountFeaturesWithoutCft()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAwsCloudAccountFeaturesWithoutCftInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeAwsCloudAccountFeaturesWithoutCft",
                "($input: UpgradeAwsCloudAccountFeaturesWithoutCftInput!)",
                "System.Boolean",
                Mutation.UpgradeAwsCloudAccountFeaturesWithoutCft,
                Mutation.UpgradeAwsCloudAccountFeaturesWithoutCftFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsCloudAccountId = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeAwsIamUserBasedCloudAccountPermissions(input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!): Boolean!
        internal void InitMutationUpgradeAwsIamUserBasedCloudAccountPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAwsIamUserBasedCloudAccountPermissionsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeAwsIamUserBasedCloudAccountPermissions",
                "($input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!)",
                "System.Boolean",
                Mutation.UpgradeAwsIamUserBasedCloudAccountPermissions,
                Mutation.UpgradeAwsIamUserBasedCloudAccountPermissionsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsCloudAccountId = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // validateAndCreateAwsCloudAccount(input: ValidateAndCreateAwsCloudAccountInput!): ValidateAndCreateAwsCloudAccountReply!
        internal void InitMutationValidateAndCreateAwsCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAndCreateAwsCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateAndCreateAwsCloudAccount",
                "($input: ValidateAndCreateAwsCloudAccountInput!)",
                "ValidateAndCreateAwsCloudAccountReply",
                Mutation.ValidateAndCreateAwsCloudAccount,
                Mutation.ValidateAndCreateAwsCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	action = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
	# OPTIONAL
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	awsAdminAccount = @{
		# OPTIONAL
		id = $someString
		# OPTIONAL
		nativeId = $someString
		# OPTIONAL
		accountName = $someString
		# OPTIONAL
		seamlessFlowEnabled = $someBoolean
		# OPTIONAL
		orgName = $someString
		# OPTIONAL
		outpostAwsNativeId = $someString
		# OPTIONAL
		orgId = $someString
		# OPTIONAL
		cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	}
	# REQUIRED
	awsChildAccounts = @(
		@{
			# OPTIONAL
			id = $someString
			# OPTIONAL
			nativeId = $someString
			# OPTIONAL
			accountName = $someString
			# OPTIONAL
			seamlessFlowEnabled = $someBoolean
			# OPTIONAL
			orgName = $someString
			# OPTIONAL
			outpostAwsNativeId = $someString
			# OPTIONAL
			orgId = $someString
			# OPTIONAL
			cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		}
	)
	# OPTIONAL
	awsRoleCustomization = @{
		# OPTIONAL
		crossAccountRoleName = $someString
		# OPTIONAL
		crossAccountRolePath = $someString
		# OPTIONAL
		masterRoleName = $someString
		# OPTIONAL
		masterRolePath = $someString
		# OPTIONAL
		workerRoleName = $someString
		# OPTIONAL
		workerRolePath = $someString
		# OPTIONAL
		instanceProfileName = $someString
		# OPTIONAL
		instanceProfilePath = $someString
		# OPTIONAL
		ec2RecoveryRolePath = $someString
		# OPTIONAL
		lambdaRolePath = $someString
		# OPTIONAL
		lambdaRoleName = $someString
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
	# OPTIONAL
	awsIamPair = @{
		# OPTIONAL
		awsIamPairId = $someString
		# OPTIONAL
		awsIamRoleName = $someString
	}
	# OPTIONAL
	outpostAwsNativeId = $someString
	# OPTIONAL
	orgId = $someString
	# OPTIONAL
	awsChildOus = @(
		@{
			# OPTIONAL
			nativeId = $someString
			# OPTIONAL
			name = $someString
			# OPTIONAL
			cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		}
	)
	# OPTIONAL
	roleChainingAccountId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // validateAndInitiateAwsOutpostAccount(input: ValidateAndInitiateAwsOutpostAccountInput!): ValidateAndInitiateAwsOutpostAccountReply!
        internal void InitMutationValidateAndInitiateAwsOutpostAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAndInitiateAwsOutpostAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateAndInitiateAwsOutpostAccount",
                "($input: ValidateAndInitiateAwsOutpostAccountInput!)",
                "ValidateAndInitiateAwsOutpostAccountReply",
                Mutation.ValidateAndInitiateAwsOutpostAccount,
                Mutation.ValidateAndInitiateAwsOutpostAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	outpostAwsNativeId = $someString
	# OPTIONAL
	cloudType = $someAwsCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
}"
            );
        }


    } // class New_RscMutationAws
}