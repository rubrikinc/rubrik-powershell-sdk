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
    /// Create a new RscQuery object for any of the 33
    /// operations in the 'AWS' API domain:
    /// AddAuthenticationServerBasedCloudAccount, AddIamUserBasedCloudAccount, BulkDeleteCloudAccountWithoutCft, CreateAccount, CreateAutomaticTargetMapping, CreateCloudNativeStorageSetting, CreateCluster, CreateComputeSetting, CreateExocomputeConfigs, CreateReaderTarget, CreateTarget, DeleteCluster, DeleteComputeSetting, DeleteExocomputeConfigs, FinalizeCloudAccountDeletion, FinalizeCloudAccountProtection, PatchAuthenticationServerBasedCloudAccount, PatchIamUserBasedCloudAccount, PrepareCloudAccountDeletion, PrepareFeatureUpdateForCloudAccount, RegisterFeatureArtifacts, StartExocomputeDisableJob, UpdateAccount, UpdateAutomaticTargetMapping, UpdateCloudAccount, UpdateCloudAccountFeature, UpdateCloudNativeStorageSetting, UpdateComputeSetting, UpdateExocomputeConfigs, UpdateTarget, UpgradeCloudAccountFeaturesWithoutCft, UpgradeIamUserBasedCloudAccountPermissions, or ValidateAndCreateCloudAccount.
    /// </summary>
    /// <description>
    /// New-RscMutationAws creates a new
    /// mutation object for operations
    /// in the 'AWS' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 33 operations
    /// in the 'AWS' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -AddAuthenticationServerBasedCloudAccount, -AddIamUserBasedCloudAccount, -BulkDeleteCloudAccountWithoutCft, -CreateAccount, -CreateAutomaticTargetMapping, -CreateCloudNativeStorageSetting, -CreateCluster, -CreateComputeSetting, -CreateExocomputeConfigs, -CreateReaderTarget, -CreateTarget, -DeleteCluster, -DeleteComputeSetting, -DeleteExocomputeConfigs, -FinalizeCloudAccountDeletion, -FinalizeCloudAccountProtection, -PatchAuthenticationServerBasedCloudAccount, -PatchIamUserBasedCloudAccount, -PrepareCloudAccountDeletion, -PrepareFeatureUpdateForCloudAccount, -RegisterFeatureArtifacts, -StartExocomputeDisableJob, -UpdateAccount, -UpdateAutomaticTargetMapping, -UpdateCloudAccount, -UpdateCloudAccountFeature, -UpdateCloudNativeStorageSetting, -UpdateComputeSetting, -UpdateExocomputeConfigs, -UpdateTarget, -UpgradeCloudAccountFeaturesWithoutCft, -UpgradeIamUserBasedCloudAccountPermissions, -ValidateAndCreateCloudAccount.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op AddAuthenticationServerBasedCloudAccount,
    /// which is equivalent to specifying -AddAuthenticationServerBasedCloudAccount.
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
    /// $query = New-RscMutationAws -AddAuthenticationServerBasedCloudAccount
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
    /// $query = New-RscMutationAws -AddIamUserBasedCloudAccount
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
    /// $query = New-RscMutationAws -BulkDeleteCloudAccountWithoutCft
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
    /// $query = New-RscMutationAws -CreateAccount
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
    /// $query = New-RscMutationAws -CreateAutomaticTargetMapping
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
    /// $query = New-RscMutationAws -CreateCloudNativeStorageSetting
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
    /// $query = New-RscMutationAws -CreateCluster
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
    /// 		dnsSearchDomains = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		dnsNameServers = @(
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
    /// 		tags = $someString
    /// 		# OPTIONAL
    /// 		imageId = $someString
    /// 		# OPTIONAL
    /// 		instanceProfileName = $someString
    /// 		# OPTIONAL
    /// 		cdmProduct = $someString
    /// 		# OPTIONAL
    /// 		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
    /// 		# OPTIONAL
    /// 		securityGroups = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		instanceType = $someAwsInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
    /// 	}
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
    /// $query = New-RscMutationAws -CreateComputeSetting
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
    /// $query = New-RscMutationAws -CreateExocomputeConfigs
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
    /// 			# REQUIRED
    /// 			vpcId = $someString
    /// 			# OPTIONAL
    /// 			nodeSecurityGroupId = $someString
    /// 			# REQUIRED
    /// 			subnets = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					subnetId = $someString
    /// 					# REQUIRED
    /// 					availabilityZone = $someString
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			isRscManaged = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	triggerHealthCheck = $someBoolean
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
    /// $query = New-RscMutationAws -CreateReaderTarget
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
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
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
    /// $query = New-RscMutationAws -CreateTarget
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
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
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
    /// Runs the DeleteCluster operation
    /// of the 'AWS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Aws
    /// # API Operation: DeleteCluster
    /// 
    /// $query = New-RscMutationAws -DeleteCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	clusterName = $someString
    /// 	# OPTIONAL
    /// 	numNodes = $someInt
    /// 	# OPTIONAL
    /// 	isEsType = $someBoolean
    /// 	# OPTIONAL
    /// 	bucketName = $someString
    /// 	# OPTIONAL
    /// 	isNewContainer = $someBoolean
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	region = $someString
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
    /// $query = New-RscMutationAws -DeleteComputeSetting
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
    /// $query = New-RscMutationAws -DeleteExocomputeConfigs
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
    /// $query = New-RscMutationAws -FinalizeCloudAccountDeletion
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
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
    /// $query = New-RscMutationAws -FinalizeCloudAccountProtection
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	action = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
    /// 	# REQUIRED
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
    /// 			# REQUIRED
    /// 			version = $someInt
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
    /// $query = New-RscMutationAws -PatchAuthenticationServerBasedCloudAccount
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
    /// $query = New-RscMutationAws -PatchIamUserBasedCloudAccount
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
    /// $query = New-RscMutationAws -PrepareCloudAccountDeletion
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
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
    /// $query = New-RscMutationAws -PrepareFeatureUpdateForCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
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
    /// $query = New-RscMutationAws -RegisterFeatureArtifacts
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
    /// $query = New-RscMutationAws -StartExocomputeDisableJob
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
    /// $query = New-RscMutationAws -UpdateAccount
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
    /// $query = New-RscMutationAws -UpdateAutomaticTargetMapping
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
    /// $query = New-RscMutationAws -UpdateCloudAccount
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
    /// $query = New-RscMutationAws -UpdateCloudAccountFeature
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
    /// $query = New-RscMutationAws -UpdateCloudNativeStorageSetting
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
    /// $query = New-RscMutationAws -UpdateComputeSetting
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
    /// $query = New-RscMutationAws -UpdateExocomputeConfigs
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
    /// 			# REQUIRED
    /// 			vpcId = $someString
    /// 			# OPTIONAL
    /// 			nodeSecurityGroupId = $someString
    /// 			# REQUIRED
    /// 			subnets = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					subnetId = $someString
    /// 					# REQUIRED
    /// 					availabilityZone = $someString
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			isRscManaged = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	triggerHealthCheck = $someBoolean
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
    /// $query = New-RscMutationAws -UpdateTarget
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
    /// $query = New-RscMutationAws -UpgradeCloudAccountFeaturesWithoutCft
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
    /// $query = New-RscMutationAws -UpgradeIamUserBasedCloudAccountPermissions
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
    /// $query = New-RscMutationAws -ValidateAndCreateCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	action = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
    /// 	# REQUIRED
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
    /// 	}
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationAws",
        DefaultParameterSetName = "CreateTarget")
    ]
    public class New_RscMutationAws : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "AddAuthenticationServerBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AddAuthenticationServerBasedCloudAccount' operation
in the 'AWS' API domain.
Description of the operation:
Validates and adds an authentication server-based AWS cloud account. When validation succeeds, the AWS cloud account is added and the features specified in the request are enabled. When validation fails, an error is not returned, but the cause of the failure is specified in the ""message"" field of the response object.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/addawsauthenticationserverbasedcloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AddAuthenticationServerBasedCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "AddIamUserBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AddIamUserBasedCloudAccount' operation
in the 'AWS' API domain.
Description of the operation:
Adds an IAM user-based AWS cloud account and enables the features specified in the input after successful validation of the request.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/addawsiamuserbasedcloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AddIamUserBasedCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "BulkDeleteCloudAccountWithoutCft",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BulkDeleteCloudAccountWithoutCft' operation
in the 'AWS' API domain.
Description of the operation:
Deletes specified AWS cloud accounts without using CloudFormation Template (CFT).
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/bulkdeleteawscloudaccountwithoutcft.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BulkDeleteCloudAccountWithoutCft { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateAccount' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createawsaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateAutomaticTargetMapping' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createautomaticawstargetmapping.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateAutomaticTargetMapping { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateCloudNativeStorageSetting' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createcloudnativeawsstoragesetting.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateCloudNativeStorageSetting { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateCluster' operation
in the 'AWS' API domain.
Description of the operation:
Create a Rubrik Cloud Cluster on AWS.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createawscluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateComputeSetting' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createawscomputesetting.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateComputeSetting { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateExocomputeConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateExocomputeConfigs' operation
in the 'AWS' API domain.
Description of the operation:
Create AWS Exocompute configs.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createawsexocomputeconfigs.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateExocomputeConfigs { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateReaderTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateReaderTarget' operation
in the 'AWS' API domain.
Description of the operation:
Create a reader type for AWS archival location on a Rubrik cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createawsreadertarget.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateReaderTarget { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateTarget' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createawstarget.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateTarget { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteCluster' operation
in the 'AWS' API domain.
Description of the operation:
Delete a Rubrik Cloud Cluster on AWS.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deleteawscluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteComputeSetting' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deleteawscomputesetting.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteComputeSetting { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteExocomputeConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteExocomputeConfigs' operation
in the 'AWS' API domain.
Description of the operation:
Deletes AWS Exocompute configs.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deleteawsexocomputeconfigs.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteExocomputeConfigs { get; set; }

        
        [Parameter(
            ParameterSetName = "FinalizeCloudAccountDeletion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'FinalizeCloudAccountDeletion' operation
in the 'AWS' API domain.
Description of the operation:
Process and finalize deletion of cloud account is the last step in deletion of a feature from cloud account. This endpoint is a MUST for deletion of disconnected features.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/finalizeawscloudaccountdeletion.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter FinalizeCloudAccountDeletion { get; set; }

        
        [Parameter(
            ParameterSetName = "FinalizeCloudAccountProtection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'FinalizeCloudAccountProtection' operation
in the 'AWS' API domain.
Description of the operation:
Process cloud account. This is the second step after validate and create in addition of a feature for cloud account.The CloudFormation stack should be created after this step using the CloudFormation URL provided in the first step.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/finalizeawscloudaccountprotection.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter FinalizeCloudAccountProtection { get; set; }

        
        [Parameter(
            ParameterSetName = "PatchAuthenticationServerBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'PatchAuthenticationServerBasedCloudAccount' operation
in the 'AWS' API domain.
Description of the operation:
Updates authentication server-based AWS cloud account. Use this mutation to update account details related to role name, certificates, features. The mutation can update one or more certificates associated to an account in a single request. All input fields except account identifier are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/patchawsauthenticationserverbasedcloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PatchAuthenticationServerBasedCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "PatchIamUserBasedCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'PatchIamUserBasedCloudAccount' operation
in the 'AWS' API domain.
Description of the operation:
Updates IAM user-based AWS cloud account. Use this mutation to update account details access/secret keys, role ARN and regions. All input fields except account ID are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/patchawsiamuserbasedcloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PatchIamUserBasedCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "PrepareCloudAccountDeletion",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'PrepareCloudAccountDeletion' operation
in the 'AWS' API domain.
Description of the operation:
Prepare deletion of cloud account. This is the first step to delete AWS cloud account. It generated template for deletion of cloud account and does not change any state of account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/prepareawscloudaccountdeletion.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PrepareCloudAccountDeletion { get; set; }

        
        [Parameter(
            ParameterSetName = "PrepareFeatureUpdateForCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'PrepareFeatureUpdateForCloudAccount' operation
in the 'AWS' API domain.
Description of the operation:
Prepare manual update features to latest version.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/preparefeatureupdateforawscloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PrepareFeatureUpdateForCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "RegisterFeatureArtifacts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RegisterFeatureArtifacts' operation
in the 'AWS' API domain.
Description of the operation:
Registers the AWS account artifacts such as roles in RSC backend while onboarding AWS account in manual flow.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/registerawsfeatureartifacts.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RegisterFeatureArtifacts { get; set; }

        
        [Parameter(
            ParameterSetName = "StartExocomputeDisableJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartExocomputeDisableJob' operation
in the 'AWS' API domain.
Description of the operation:
Starts a job to disable AWS Exocompute feature. When complete, the job will disable exocompute feature for the specified AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startawsexocomputedisablejob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartExocomputeDisableJob { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateAccount' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateawsaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateAutomaticTargetMapping' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateautomaticawstargetmapping.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateAutomaticTargetMapping { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateCloudAccount' operation
in the 'AWS' API domain.
Description of the operation:
Update properties for a given AWS cloud account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateawscloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateCloudAccountFeature",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateCloudAccountFeature' operation
in the 'AWS' API domain.
Description of the operation:
Updates regions, stack ARN, and role ARN for a feature for a given cloud account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateawscloudaccountfeature.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateCloudAccountFeature { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateCloudNativeStorageSetting' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatecloudnativeawsstoragesetting.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateCloudNativeStorageSetting { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateComputeSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateComputeSetting' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateawscomputesetting.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateComputeSetting { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateExocomputeConfigs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateExocomputeConfigs' operation
in the 'AWS' API domain.
Description of the operation:
Update AWS Exocompute configs.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateawsexocomputeconfigs.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateExocomputeConfigs { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateTarget' operation
in the 'AWS' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateawstarget.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateTarget { get; set; }

        
        [Parameter(
            ParameterSetName = "UpgradeCloudAccountFeaturesWithoutCft",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpgradeCloudAccountFeaturesWithoutCft' operation
in the 'AWS' API domain.
Description of the operation:
Updates status of AWS cloud account features to connected if they are in update permissions state. This mutation should be used with caution. It should be invoked only after the latest required permissions are granted to the AWS cloud account user used by Rubrik. This mutation does not verify if the required permissions are actually granted to the user or not. Its usage is restricted to only IAM user-based and authentication server-based AWS cloud accounts.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/upgradeawscloudaccountfeatureswithoutcft.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpgradeCloudAccountFeaturesWithoutCft { get; set; }

        
        [Parameter(
            ParameterSetName = "UpgradeIamUserBasedCloudAccountPermissions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpgradeIamUserBasedCloudAccountPermissions' operation
in the 'AWS' API domain.
Description of the operation:
Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/upgradeawsiamuserbasedcloudaccountpermissions.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpgradeIamUserBasedCloudAccountPermissions { get; set; }

        
        [Parameter(
            ParameterSetName = "ValidateAndCreateCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ValidateAndCreateCloudAccount' operation
in the 'AWS' API domain.
Description of the operation:
Validate and create AWS cloud account. If validation fails, no error is returned and the cause is present in the ""message"" field of return object or within admin/child accounts of return object. In case validation succeeds, it initiates creation of AWS cloud account. This is the first step to set up native protection.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/validateandcreateawscloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ValidateAndCreateCloudAccount { get; set; }



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
                    case "DeleteCluster":
                        this.ProcessRecord_DeleteCluster();
                        break;
                    case "DeleteComputeSetting":
                        this.ProcessRecord_DeleteComputeSetting();
                        break;
                    case "DeleteExocomputeConfigs":
                        this.ProcessRecord_DeleteExocomputeConfigs();
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
        // deleteAwsCluster.
        internal void ProcessRecord_DeleteCluster()
        {
            this._logger.name += " -DeleteCluster";
            // Create new graphql operation deleteAwsCluster
            InitMutationDeleteAwsCluster();
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
                Mutation.AddAwsAuthenticationServerBasedCloudAccount_ObjectFieldSpec,
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
                Mutation.AddAwsIamUserBasedCloudAccount_ObjectFieldSpec,
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
                Mutation.BulkDeleteAwsCloudAccountWithoutCft_ObjectFieldSpec,
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
                Mutation.CreateAwsAccount_ObjectFieldSpec,
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
                Mutation.CreateAutomaticAwsTargetMapping_ObjectFieldSpec,
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
                Mutation.CreateCloudNativeAwsStorageSetting_ObjectFieldSpec,
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
                Mutation.CreateAwsCluster_ObjectFieldSpec,
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
		dnsSearchDomains = @(
			$someString
		)
		# OPTIONAL
		dnsNameServers = @(
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
		tags = $someString
		# OPTIONAL
		imageId = $someString
		# OPTIONAL
		instanceProfileName = $someString
		# OPTIONAL
		cdmProduct = $someString
		# OPTIONAL
		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		securityGroups = @(
			$someString
		)
		# OPTIONAL
		instanceType = $someAwsInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
	}
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
                Mutation.CreateAwsComputeSetting_ObjectFieldSpec,
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
                Mutation.CreateAwsExocomputeConfigs_ObjectFieldSpec,
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
			# REQUIRED
			vpcId = $someString
			# OPTIONAL
			nodeSecurityGroupId = $someString
			# REQUIRED
			subnets = @(
				@{
					# REQUIRED
					subnetId = $someString
					# REQUIRED
					availabilityZone = $someString
				}
			)
			# REQUIRED
			isRscManaged = $someBoolean
		}
	)
	# OPTIONAL
	triggerHealthCheck = $someBoolean
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
                Mutation.CreateAwsReaderTarget_ObjectFieldSpec,
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
	# REQUIRED
	bypassProxy = $someBoolean
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
                Mutation.CreateAwsTarget_ObjectFieldSpec,
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
	# REQUIRED
	bypassProxy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAwsCluster(input: DeleteAwsClusterInput!): CcProvisionJobReply!
        internal void InitMutationDeleteAwsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAwsCluster",
                "($input: DeleteAwsClusterInput!)",
                "CcProvisionJobReply",
                Mutation.DeleteAwsCluster_ObjectFieldSpec,
                Mutation.DeleteAwsClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	clusterName = $someString
	# OPTIONAL
	numNodes = $someInt
	# OPTIONAL
	isEsType = $someBoolean
	# OPTIONAL
	bucketName = $someString
	# OPTIONAL
	isNewContainer = $someBoolean
	# OPTIONAL
	clusterUuid = $someString
	# OPTIONAL
	region = $someString
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
                Mutation.DeleteAwsComputeSetting_ObjectFieldSpec,
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
                Mutation.DeleteAwsExocomputeConfigs_ObjectFieldSpec,
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
                Mutation.FinalizeAwsCloudAccountDeletion_ObjectFieldSpec,
                Mutation.FinalizeAwsCloudAccountDeletionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
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
                Mutation.FinalizeAwsCloudAccountProtection_ObjectFieldSpec,
                Mutation.FinalizeAwsCloudAccountProtectionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	action = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
	# REQUIRED
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
			# REQUIRED
			version = $someInt
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
                Mutation.PatchAwsAuthenticationServerBasedCloudAccount_ObjectFieldSpec,
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
                Mutation.PatchAwsIamUserBasedCloudAccount_ObjectFieldSpec,
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
                Mutation.PrepareAwsCloudAccountDeletion_ObjectFieldSpec,
                Mutation.PrepareAwsCloudAccountDeletionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
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
                Mutation.PrepareFeatureUpdateForAwsCloudAccount_ObjectFieldSpec,
                Mutation.PrepareFeatureUpdateForAwsCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
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
                Mutation.RegisterAwsFeatureArtifacts_ObjectFieldSpec,
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
                Mutation.StartAwsExocomputeDisableJob_ObjectFieldSpec,
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
                Mutation.UpdateAwsAccount_ObjectFieldSpec,
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
                Mutation.UpdateAutomaticAwsTargetMapping_ObjectFieldSpec,
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
                Mutation.UpdateAwsCloudAccount_ObjectFieldSpec,
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
                Mutation.UpdateAwsCloudAccountFeature_ObjectFieldSpec,
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
                Mutation.UpdateCloudNativeAwsStorageSetting_ObjectFieldSpec,
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
                Mutation.UpdateAwsComputeSetting_ObjectFieldSpec,
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
                Mutation.UpdateAwsExocomputeConfigs_ObjectFieldSpec,
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
			# REQUIRED
			vpcId = $someString
			# OPTIONAL
			nodeSecurityGroupId = $someString
			# REQUIRED
			subnets = @(
				@{
					# REQUIRED
					subnetId = $someString
					# REQUIRED
					availabilityZone = $someString
				}
			)
			# REQUIRED
			isRscManaged = $someBoolean
		}
	)
	# OPTIONAL
	triggerHealthCheck = $someBoolean
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
                Mutation.UpdateAwsTarget_ObjectFieldSpec,
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
                Mutation.UpgradeAwsCloudAccountFeaturesWithoutCft_ObjectFieldSpec,
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
                Mutation.UpgradeAwsIamUserBasedCloudAccountPermissions_ObjectFieldSpec,
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
                Mutation.ValidateAndCreateAwsCloudAccount_ObjectFieldSpec,
                Mutation.ValidateAndCreateAwsCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	action = $someCloudAccountAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
	# REQUIRED
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
	}
}"
            );
        }


    } // class New_RscMutationAws
}