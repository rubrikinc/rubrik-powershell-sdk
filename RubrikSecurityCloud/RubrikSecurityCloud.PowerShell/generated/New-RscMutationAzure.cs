// New-RscMutationAzure.cs
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
    /// Create a new RscQuery object for any of the 45
    /// operations in the 'Azure' API domain:
    /// AddCloudAccount, AddCloudAccountExocomputeConfigurations, AddCloudAccountWithoutOauth, BackupAdDirectory, CloudAccountAddWithCustomerAppInitiate, CompleteAdAppSetup, CompleteAdAppUpdate, CompleteCloudAccountOauth, CreateAccount, CreateAutomaticTargetMapping, CreateCloudNativeRcvStorageSetting, CreateCloudNativeStorageSetting, CreateCluster, CreateReaderTarget, CreateSaasAppAad, CreateTarget, DeleteAdDirectory, DeleteCloudAccount, DeleteCloudAccountExocomputeConfigurations, DeleteCloudAccountWithoutOauth, ExcludeStorageAccountContainers, MapCloudAccountExocomputeSubscription, MapCloudAccountToPersistentStorageLocation, OauthConsentComplete, OauthConsentKickoff, RestoreAdObjectsWithPasswords, SetCloudAccountCustomerAppCredentials, StartAdAppSetup, StartAdAppUpdate, StartCloudAccountOauth, StartDisableCloudAccountJob, StartExportSqlDatabaseDbJob, StartExportSqlManagedInstanceDbJob, UnmapCloudAccountExocomputeSubscription, UnmapPersistentStorageSubscription, UpdateAccount, UpdateAutomaticTargetMapping, UpdateCloudAccount, UpdateCloudNativeRcvStorageSetting, UpdateCloudNativeStorageSetting, UpdateCustomerAppPermissionForSql, UpdateTarget, UpdateTenantForSubscription, UpgradeCloudAccount, or UpgradeCloudAccountPermissionsWithoutOauth.
    /// </summary>
    /// <description>
    /// New-RscMutationAzure creates a new
    /// mutation object for operations
    /// in the 'Azure' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 45 operations
    /// in the 'Azure' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddCloudAccount, AddCloudAccountExocomputeConfigurations, AddCloudAccountWithoutOauth, BackupAdDirectory, CloudAccountAddWithCustomerAppInitiate, CompleteAdAppSetup, CompleteAdAppUpdate, CompleteCloudAccountOauth, CreateAccount, CreateAutomaticTargetMapping, CreateCloudNativeRcvStorageSetting, CreateCloudNativeStorageSetting, CreateCluster, CreateReaderTarget, CreateSaasAppAad, CreateTarget, DeleteAdDirectory, DeleteCloudAccount, DeleteCloudAccountExocomputeConfigurations, DeleteCloudAccountWithoutOauth, ExcludeStorageAccountContainers, MapCloudAccountExocomputeSubscription, MapCloudAccountToPersistentStorageLocation, OauthConsentComplete, OauthConsentKickoff, RestoreAdObjectsWithPasswords, SetCloudAccountCustomerAppCredentials, StartAdAppSetup, StartAdAppUpdate, StartCloudAccountOauth, StartDisableCloudAccountJob, StartExportSqlDatabaseDbJob, StartExportSqlManagedInstanceDbJob, UnmapCloudAccountExocomputeSubscription, UnmapPersistentStorageSubscription, UpdateAccount, UpdateAutomaticTargetMapping, UpdateCloudAccount, UpdateCloudNativeRcvStorageSetting, UpdateCloudNativeStorageSetting, UpdateCustomerAppPermissionForSql, UpdateTarget, UpdateTenantForSubscription, UpgradeCloudAccount, or UpgradeCloudAccountPermissionsWithoutOauth.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationAzure -AddCloudAccount).Info().
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
    /// (New-RscMutationAzure -AddCloudAccount).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddCloudAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AddCloudAccount
    /// 
    /// $query = New-RscMutationAzure -Operation AddCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	tenantDomainName = $someString
    /// 	# REQUIRED
    /// 	subscriptions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			features = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					resourceGroup = @{
    /// 						# REQUIRED
    /// 						name = $someString
    /// 						# OPTIONAL
    /// 						tags = @{
    /// 							# REQUIRED
    /// 							tagList = @(
    /// 								@{
    /// 									# REQUIRED
    /// 									key = $someString
    /// 									# REQUIRED
    /// 									value = $someString
    /// 								}
    /// 							)
    /// 						}
    /// 						# REQUIRED
    /// 						region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 					}
    /// 					# REQUIRED
    /// 					featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 					# OPTIONAL
    /// 					permissionsGroups = @(
    /// 						$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 					)
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			subscription = @{
    /// 				# REQUIRED
    /// 				nativeId = $someString
    /// 				# REQUIRED
    /// 				name = $someString
    /// 			}
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	regions = @(
    /// 		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	isAsynchronous = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddAzureCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddCloudAccountExocomputeConfigurations operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AddCloudAccountExocomputeConfigurations
    /// 
    /// $query = New-RscMutationAzure -Operation AddCloudAccountExocomputeConfigurations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	azureExocomputeRegionConfigs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 			# OPTIONAL
    /// 			subnetNativeId = $someString
    /// 			# REQUIRED
    /// 			isRscManaged = $someBoolean
    /// 			# OPTIONAL
    /// 			podSubnetNativeId = $someString
    /// 			# OPTIONAL
    /// 			podOverlayNetworkCidr = $someString
    /// 			# OPTIONAL
    /// 			optionalConfig = @{
    /// 				# OPTIONAL
    /// 				aksNodeRgPrefix = $someString
    /// 				# OPTIONAL
    /// 				diskEncryptionAtHost = $someBoolean
    /// 				# OPTIONAL
    /// 				additionalWhitelistIps = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				enableUserDefinedRouting = $someBoolean
    /// 				# OPTIONAL
    /// 				shouldWhitelistRubrikIps = $someBoolean
    /// 				# OPTIONAL
    /// 				privateDnsZoneId = $someString
    /// 				# OPTIONAL
    /// 				aksCustomPrivateDnsZoneId = $someString
    /// 				# OPTIONAL
    /// 				aksClusterTier = $someAKSProvisionTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSProvisionTier]) for enum values.
    /// 				# OPTIONAL
    /// 				aksNodeCountBucket = $someAKSNodeCountBucket # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSNodeCountBucket]) for enum values.
    /// 				# OPTIONAL
    /// 				aksClusterAccessType = $someAKSClusterAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSClusterAccessType]) for enum values.
    /// 			}
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
    /// Write-Host $result.GetType().Name # prints: AddAzureCloudAccountExocomputeConfigurationsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddCloudAccountWithoutOauth operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AddCloudAccountWithoutOauth
    /// 
    /// $query = New-RscMutationAzure -Operation AddCloudAccountWithoutOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	tenantDomainName = $someString
    /// 	# REQUIRED
    /// 	subscriptions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			features = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					policyVersion = $someInt
    /// 					# OPTIONAL
    /// 					resourceGroup = @{
    /// 						# REQUIRED
    /// 						name = $someString
    /// 						# OPTIONAL
    /// 						tags = @{
    /// 							# REQUIRED
    /// 							tagList = @(
    /// 								@{
    /// 									# REQUIRED
    /// 									key = $someString
    /// 									# REQUIRED
    /// 									value = $someString
    /// 								}
    /// 							)
    /// 						}
    /// 						# REQUIRED
    /// 						region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 					}
    /// 					# OPTIONAL
    /// 					specificFeatureInput = @{
    /// 						# REQUIRED
    /// 						userAssignedManagedIdentityInput = @{
    /// 							# REQUIRED
    /// 							name = $someString
    /// 							# REQUIRED
    /// 							resourceGroupName = $someString
    /// 							# REQUIRED
    /// 							principalId = $someString
    /// 							# REQUIRED
    /// 							region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 						}
    /// 					}
    /// 					# REQUIRED
    /// 					featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 					# OPTIONAL
    /// 					permissionsGroups = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							permissionsGroup = $somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 							# OPTIONAL
    /// 							version = $someInt
    /// 						}
    /// 					)
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			subscription = @{
    /// 				# REQUIRED
    /// 				nativeId = $someString
    /// 				# REQUIRED
    /// 				name = $someString
    /// 			}
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	regions = @(
    /// 		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	isAsynchronous = $someBoolean
    /// 	# OPTIONAL
    /// 	entraIdGroupId = $someString
    /// 	# OPTIONAL
    /// 	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddAzureCloudAccountWithoutOauthReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupAdDirectory operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: BackupAdDirectory
    /// 
    /// $query = New-RscMutationAzure -Operation BackupAdDirectory
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	snapshotRetentionSlaId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CreateOnDemandJobReply&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudAccountAddWithCustomerAppInitiate operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CloudAccountAddWithCustomerAppInitiate
    /// 
    /// $query = New-RscMutationAzure -Operation CloudAccountAddWithCustomerAppInitiate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	tenantDomainName = $someString
    /// 	# OPTIONAL
    /// 	cloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// 	# OPTIONAL
    /// 	appId = $someString
    /// 	# OPTIONAL
    /// 	appSecretKey = $someString
    /// 	# OPTIONAL
    /// 	redirectUrl = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureCloudAccountAddWithCustomerAppInitiateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CompleteAdAppSetup operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CompleteAdAppSetup
    /// 
    /// $query = New-RscMutationAzure -Operation CompleteAdAppSetup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	domainName = $someString
    /// 	# REQUIRED
    /// 	stateToken = $someString
    /// 	# OPTIONAL
    /// 	kmsSpec = @{
    /// 		# OPTIONAL
    /// 		cloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
    /// 		# OPTIONAL
    /// 		tenantId = $someString
    /// 		# OPTIONAL
    /// 		kmsId = $someString
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecret = $someString
    /// 		# OPTIONAL
    /// 		keyName = $someString
    /// 		# OPTIONAL
    /// 		kekNameColossus = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CompleteAzureAdAppSetupReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CompleteAdAppUpdate operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CompleteAdAppUpdate
    /// 
    /// $query = New-RscMutationAzure -Operation CompleteAdAppUpdate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFid = $someString
    /// 	# REQUIRED
    /// 	stateToken = $someString
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
    /// Runs the CompleteCloudAccountOauth operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CompleteCloudAccountOauth
    /// 
    /// $query = New-RscMutationAzure -Operation CompleteCloudAccountOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	tenantDomainName = $someString
    /// 	# REQUIRED
    /// 	authorizationCode = $someString
    /// 	# REQUIRED
    /// 	redirectUrl = $someString
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	appId = $someString
    /// 	# OPTIONAL
    /// 	appSecretKey = $someString
    /// 	# REQUIRED
    /// 	shouldSkipPermissionChecks = $someBoolean
    /// 	# OPTIONAL
    /// 	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// 	# OPTIONAL
    /// 	resource = $someAzureOauthResource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureOauthResource]) for enum values.
    /// 	# OPTIONAL
    /// 	performBasicOauth = $someBoolean
    /// 	# OPTIONAL
    /// 	shouldKeepRefreshToken = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CompleteAzureCloudAccountOauthReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateAccount
    /// 
    /// $query = New-RscMutationAzure -Operation CreateAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	subscriptionId = $someString
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
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateAutomaticTargetMapping
    /// 
    /// $query = New-RscMutationAzure -Operation CreateAutomaticTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	storageAccountName = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	containerNamePrefix = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	rsaKey = $someString
    /// 	# OPTIONAL
    /// 	computeSettings = @{
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecretKey = $someString
    /// 		# OPTIONAL
    /// 		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		# OPTIONAL
    /// 		generalPurposeStorageName = $someString
    /// 		# OPTIONAL
    /// 		generalPurposeStorageContainer = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		virtualNetworkId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
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
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 		# OPTIONAL
    /// 		subscriptionId = $someString
    /// 	}
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
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
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
    /// Runs the CreateCloudNativeRcvStorageSetting operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateCloudNativeRcvStorageSetting
    /// 
    /// $query = New-RscMutationAzure -Operation CreateCloudNativeRcvStorageSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	rcvRegion = $someRcsRegionEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsRegionEnumType]) for enum values.
    /// 	# OPTIONAL
    /// 	tier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
    /// 	# REQUIRED
    /// 	cloudNativeLocTemplateType = $someCloudNativeLocTemplateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
    /// 	# OPTIONAL
    /// 	redundancy = $someRcvRedundancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcvRedundancy]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCloudNativeRcvAzureStorageSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCloudNativeStorageSetting operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateCloudNativeStorageSetting
    /// 
    /// $query = New-RscMutationAzure -Operation CreateCloudNativeStorageSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	storageAccountName = $someString
    /// 	# REQUIRED
    /// 	containerName = $someString
    /// 	# OPTIONAL
    /// 	storageAccountTags = @{
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
    /// 	storageAccountRegion = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 	# REQUIRED
    /// 	storageTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
    /// 	# REQUIRED
    /// 	redundancy = $someAzureRedundancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRedundancy]) for enum values.
    /// 	# REQUIRED
    /// 	subscriptionNativeId = $someString
    /// 	# REQUIRED
    /// 	cloudNativeLocTemplateType = $someCloudNativeLocTemplateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
    /// 	# OPTIONAL
    /// 	cmkInfo = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			keyVaultName = $someString
    /// 			# OPTIONAL
    /// 			keyName = $someString
    /// 			# OPTIONAL
    /// 			region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	networkAccessType = $someAzureStorageAccountNetworkAccess # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageAccountNetworkAccess]) for enum values.
    /// 	# OPTIONAL
    /// 	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCloudNativeAzureStorageSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCluster operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateCluster
    /// 
    /// $query = New-RscMutationAzure -Operation CreateCluster
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
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		cdmVersion = $someString
    /// 		# OPTIONAL
    /// 		location = $someString
    /// 		# OPTIONAL
    /// 		nodeSizeGb = $someInt
    /// 		# OPTIONAL
    /// 		networkResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		vnetResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		networkSecurityGroup = $someString
    /// 		# OPTIONAL
    /// 		networkSecurityResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		vnet = $someString
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 		# OPTIONAL
    /// 		tags = $someString
    /// 		# OPTIONAL
    /// 		vmImage = $someString
    /// 		# OPTIONAL
    /// 		cdmProduct = $someString
    /// 		# OPTIONAL
    /// 		availabilityZone = $someString
    /// 		# OPTIONAL
    /// 		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
    /// 		# OPTIONAL
    /// 		instanceType = $someAzureInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
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
    /// Runs the CreateReaderTarget operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateReaderTarget
    /// 
    /// $query = New-RscMutationAzure -Operation CreateReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	storageAccountName = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	containerName = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	rsaKey = $someString
    /// 	# OPTIONAL
    /// 	computeSettings = @{
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecretKey = $someString
    /// 		# OPTIONAL
    /// 		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		# OPTIONAL
    /// 		generalPurposeStorageName = $someString
    /// 		# OPTIONAL
    /// 		generalPurposeStorageContainer = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		virtualNetworkId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
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
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 		# OPTIONAL
    /// 		subscriptionId = $someString
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
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		lockDurationDays = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
    /// 	# OPTIONAL
    /// 	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
    /// 	# OPTIONAL
    /// 	archivalDataSourceIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
    /// 	# OPTIONAL
    /// 	azureKeyVaultKey = @{
    /// 		# REQUIRED
    /// 		kmsKeyVaultId = $someString
    /// 		# REQUIRED
    /// 		keyName = $someString
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
    /// Runs the CreateSaasAppAad operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateSaasAppAad
    /// 
    /// $query = New-RscMutationAzure -Operation CreateSaasAppAad
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateAzureSaasAppAadReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateTarget operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateTarget
    /// 
    /// $query = New-RscMutationAzure -Operation CreateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	storageAccountName = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	containerName = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	rsaKey = $someString
    /// 	# OPTIONAL
    /// 	computeSettings = @{
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecretKey = $someString
    /// 		# OPTIONAL
    /// 		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		# OPTIONAL
    /// 		generalPurposeStorageName = $someString
    /// 		# OPTIONAL
    /// 		generalPurposeStorageContainer = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		virtualNetworkId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
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
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 		# OPTIONAL
    /// 		subscriptionId = $someString
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
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		lockDurationDays = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
    /// 	# OPTIONAL
    /// 	accessTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
    /// 	# OPTIONAL
    /// 	azureKeyVaultKey = @{
    /// 		# REQUIRED
    /// 		kmsKeyVaultId = $someString
    /// 		# REQUIRED
    /// 		keyName = $someString
    /// 		# REQUIRED
    /// 		keyVersion = $someString
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
    /// Runs the DeleteAdDirectory operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: DeleteAdDirectory
    /// 
    /// $query = New-RscMutationAzure -Operation DeleteAdDirectory
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteCloudAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: DeleteCloudAccount
    /// 
    /// $query = New-RscMutationAzure -Operation DeleteCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	azureSubscriptionRubrikIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteAzureCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteCloudAccountExocomputeConfigurations operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: DeleteCloudAccountExocomputeConfigurations
    /// 
    /// $query = New-RscMutationAzure -Operation DeleteCloudAccountExocomputeConfigurations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteAzureCloudAccountExocomputeConfigurationsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteCloudAccountWithoutOauth operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: DeleteCloudAccountWithoutOauth
    /// 
    /// $query = New-RscMutationAzure -Operation DeleteCloudAccountWithoutOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	azureSubscriptionRubrikIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteAzureCloudAccountWithoutOauthReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExcludeStorageAccountContainers operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: ExcludeStorageAccountContainers
    /// 
    /// $query = New-RscMutationAzure -Operation ExcludeStorageAccountContainers
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	storageAccountId = $someString
    /// 	# REQUIRED
    /// 	containers = @(
    /// 		$someString
    /// 	)
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
    /// Runs the MapCloudAccountExocomputeSubscription operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: MapCloudAccountExocomputeSubscription
    /// 
    /// $query = New-RscMutationAzure -Operation MapCloudAccountExocomputeSubscription
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	exocomputeCloudAccountId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MapAzureCloudAccountExocomputeSubscriptionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MapCloudAccountToPersistentStorageLocation operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: MapCloudAccountToPersistentStorageLocation
    /// 
    /// $query = New-RscMutationAzure -Operation MapCloudAccountToPersistentStorageLocation
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	persistentStorageId = $someString
    /// 	# REQUIRED
    /// 	azureNativeProtectionFeature = $someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MapAzureCloudAccountToPersistentStorageLocationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OauthConsentComplete operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: OauthConsentComplete
    /// 
    /// $query = New-RscMutationAzure -Operation OauthConsentComplete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	tenantId = $someString
    /// 	# REQUIRED
    /// 	code = $someString
    /// 	# REQUIRED
    /// 	stateToken = $someString
    /// 	# REQUIRED
    /// 	redirectUrl = $someString
    /// 	# OPTIONAL
    /// 	azureAppId = $someString
    /// 	# OPTIONAL
    /// 	azureAppSecret = $someString
    /// 	# REQUIRED
    /// 	azureCloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OauthConsentKickoff operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: OauthConsentKickoff
    /// 
    /// $query = New-RscMutationAzure -Operation OauthConsentKickoff
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureOauthConsentKickoffReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestoreAdObjectsWithPasswords operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: RestoreAdObjectsWithPasswords
    /// 
    /// $query = New-RscMutationAzure -Operation RestoreAdObjectsWithPasswords
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFid = $someString
    /// 	# REQUIRED
    /// 	snapshotFid = $someString
    /// 	# REQUIRED
    /// 	passwordByUserIdMap = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			userId = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	objectTypeToIdMap = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			objectId = $someString
    /// 			# REQUIRED
    /// 			azureAdObjectType = $someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	forceChangePasswordWithMfa = $someBoolean
    /// 	# REQUIRED
    /// 	relationshipRestoreMode = $someAzureAdRelationshipRestoreModeEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdRelationshipRestoreModeEnumType]) for enum values.
    /// 	# OPTIONAL
    /// 	objectRecoveryOptions = @{
    /// 		# OPTIONAL
    /// 		servicePrincipalRecoveryOption = @{
    /// 			# REQUIRED
    /// 			recoverLinkedApplication = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		applicationRecoveryOption = @{
    /// 			# REQUIRED
    /// 			recoverLinkedServicePrincipal = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		userRecoveryOption = @{
    /// 			# REQUIRED
    /// 			generatePasswords = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		conditionalAccessPolicyRecoveryOption = @{
    /// 			# REQUIRED
    /// 			policyConfigs = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					id = $someString
    /// 					# OPTIONAL
    /// 					exportedPolicyName = $someString
    /// 					# REQUIRED
    /// 					recoveryState = $someAzureAdConditionalAccessPolicyStateEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdConditionalAccessPolicyStateEnumType]) for enum values.
    /// 					# OPTIONAL
    /// 					recoveryMethod = $someAzureAdConditionalAccessPolicyRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdConditionalAccessPolicyRecoveryType]) for enum values.
    /// 				}
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		administrativeUnitRecoveryOption = @{
    /// 			# REQUIRED
    /// 			skipRestrictedManagementAdministrativeUnits = $someBoolean
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	attributeRecoveryMode = $someAttributeRecoveryMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeRecoveryMode]) for enum values.
    /// 	# OPTIONAL
    /// 	attributeRecoveryOptions = @{
    /// 		# REQUIRED
    /// 		attributeRecoveryConfigs = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				id = $someString
    /// 				# REQUIRED
    /// 				attributes = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RestoreAzureAdObjectsWithPasswordsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetCloudAccountCustomerAppCredentials operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SetCloudAccountCustomerAppCredentials
    /// 
    /// $query = New-RscMutationAzure -Operation SetCloudAccountCustomerAppCredentials
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	appId = $someString
    /// 	# REQUIRED
    /// 	appSecretKey = $someString
    /// 	# OPTIONAL
    /// 	appTenantId = $someString
    /// 	# OPTIONAL
    /// 	appName = $someString
    /// 	# OPTIONAL
    /// 	tenantDomainName = $someString
    /// 	# REQUIRED
    /// 	shouldReplace = $someBoolean
    /// 	# REQUIRED
    /// 	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
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
    /// Runs the StartAdAppSetup operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartAdAppSetup
    /// 
    /// $query = New-RscMutationAzure -Operation StartAdAppSetup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	domainName = $someString
    /// 	# REQUIRED
    /// 	region = $someAzureAdRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	azureAdApp = @{
    /// 		# OPTIONAL
    /// 		clientId = $someString
    /// 		# OPTIONAL
    /// 		clientSecret = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	permissionAccessMode = $somePermissionAccessMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionAccessMode]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartAzureAdAppSetupReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartAdAppUpdate operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartAdAppUpdate
    /// 
    /// $query = New-RscMutationAzure -Operation StartAdAppUpdate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFid = $someString
    /// 	# OPTIONAL
    /// 	azureAdApp = @{
    /// 		# OPTIONAL
    /// 		clientId = $someString
    /// 		# OPTIONAL
    /// 		clientSecret = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	permissionAccessMode = $somePermissionAccessMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionAccessMode]) for enum values.
    /// 	# OPTIONAL
    /// 	missingObjectTypes = @(
    /// 		$someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartAzureAdAppUpdateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartCloudAccountOauth operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartCloudAccountOauth
    /// 
    /// $query = New-RscMutationAzure -Operation StartCloudAccountOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	tenantDomainName = $someString
    /// 	# OPTIONAL
    /// 	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// 	# OPTIONAL
    /// 	azureRubrikAppUseCase = $someAzureRubrikAppUseCase # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRubrikAppUseCase]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartAzureCloudAccountOauthReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartDisableCloudAccountJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartDisableCloudAccountJob
    /// 
    /// $query = New-RscMutationAzure -Operation StartDisableCloudAccountJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	sessionId = $someString
    /// 	# OPTIONAL
    /// 	deleteSnapshots = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartExportSqlDatabaseDbJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartExportSqlDatabaseDbJob
    /// 
    /// $query = New-RscMutationAzure -Operation StartExportSqlDatabaseDbJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sourceDatabaseRubrikId = $someString
    /// 	# REQUIRED
    /// 	destinationDatabaseName = $someString
    /// 	# OPTIONAL
    /// 	destinationServerRubrikId = $someString
    /// 	# OPTIONAL
    /// 	elasticPoolName = $someString
    /// 	# REQUIRED
    /// 	shouldExportTags = $someBoolean
    /// 	# OPTIONAL
    /// 	azureSqlDatabaseDbPitExportInput = @{
    /// 		# REQUIRED
    /// 		restorePointInTime = $someDateTime
    /// 		# OPTIONAL
    /// 		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	azureSqlDatabaseDbLtrExportInput = @{
    /// 		# REQUIRED
    /// 		sourceSnapshotRubrikId = $someString
    /// 		# REQUIRED
    /// 		destinationResourceGroupName = $someString
    /// 		# REQUIRED
    /// 		destinationServerName = $someString
    /// 		# REQUIRED
    /// 		destinationRegionName = $someString
    /// 		# OPTIONAL
    /// 		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	persistentBackupExportInput = @{
    /// 		# REQUIRED
    /// 		sourceSnapshotRubrikId = $someString
    /// 		# OPTIONAL
    /// 		destinationServerCredentials = @{
    /// 			# REQUIRED
    /// 			login = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
    /// 		# OPTIONAL
    /// 		sessionId = $someString
    /// 		# OPTIONAL
    /// 		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	serviceTier = $someString
    /// 	# OPTIONAL
    /// 	serviceObjectiveName = $someString
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
    /// Runs the StartExportSqlManagedInstanceDbJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartExportSqlManagedInstanceDbJob
    /// 
    /// $query = New-RscMutationAzure -Operation StartExportSqlManagedInstanceDbJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sourceManagedInstanceDatabaseRubrikId = $someString
    /// 	# OPTIONAL
    /// 	destinationManagedInstanceRubrikId = $someString
    /// 	# REQUIRED
    /// 	destinationDatabaseName = $someString
    /// 	# REQUIRED
    /// 	destinationManagedInstanceName = $someString
    /// 	# REQUIRED
    /// 	destinationResourceGroupName = $someString
    /// 	# OPTIONAL
    /// 	azureSqlManagedInstanceDbPitExportInput = @{
    /// 		# REQUIRED
    /// 		restorePointInTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	azureSqlManagedInstanceDbLtrExportInput = @{
    /// 		# REQUIRED
    /// 		sourceSnapshotRubrikId = $someString
    /// 		# REQUIRED
    /// 		destinationRegionName = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	persistentBackupExportInput = @{
    /// 		# REQUIRED
    /// 		sourceSnapshotRubrikId = $someString
    /// 		# OPTIONAL
    /// 		destinationServerCredentials = @{
    /// 			# REQUIRED
    /// 			login = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
    /// 		# OPTIONAL
    /// 		sessionId = $someString
    /// 		# OPTIONAL
    /// 		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	serviceTier = $someString
    /// 	# OPTIONAL
    /// 	serviceObjectiveName = $someString
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
    /// Runs the UnmapCloudAccountExocomputeSubscription operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UnmapCloudAccountExocomputeSubscription
    /// 
    /// $query = New-RscMutationAzure -Operation UnmapCloudAccountExocomputeSubscription
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UnmapAzureCloudAccountExocomputeSubscriptionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnmapPersistentStorageSubscription operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UnmapPersistentStorageSubscription
    /// 
    /// $query = New-RscMutationAzure -Operation UnmapPersistentStorageSubscription
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	applicationCloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# REQUIRED
    /// 	unmappingValidationType = $someUnmappingValidationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values.
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
    /// Runs the UpdateAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateAccount
    /// 
    /// $query = New-RscMutationAzure -Operation UpdateAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	subscriptionId = $someString
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
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateAutomaticTargetMapping
    /// 
    /// $query = New-RscMutationAzure -Operation UpdateAutomaticTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	storageAccountName = $someString
    /// 	# OPTIONAL
    /// 	accessKey = $someString
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	computeSettings = @{
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecretKey = $someString
    /// 		# OPTIONAL
    /// 		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		# OPTIONAL
    /// 		generalPurposeStorageName = $someString
    /// 		# OPTIONAL
    /// 		generalPurposeStorageContainer = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		virtualNetworkId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
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
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 		# OPTIONAL
    /// 		subscriptionId = $someString
    /// 	}
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
    /// 	isConsolidationEnabled = $someBoolean
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
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateCloudAccount
    /// 
    /// $query = New-RscMutationAzure -Operation UpdateCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	subscriptions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			id = $someString
    /// 			# OPTIONAL
    /// 			name = $someString
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	regionsToAdd = @(
    /// 		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	regionsToRemove = @(
    /// 		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateAzureCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCloudNativeRcvStorageSetting operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateCloudNativeRcvStorageSetting
    /// 
    /// $query = New-RscMutationAzure -Operation UpdateCloudNativeRcvStorageSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	redundancyOpt = $someRcvRedundancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcvRedundancy]) for enum values.
    /// 	# OPTIONAL
    /// 	updateChildVaultsOpt = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCloudNativeRcvAzureStorageSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCloudNativeStorageSetting operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateCloudNativeStorageSetting
    /// 
    /// $query = New-RscMutationAzure -Operation UpdateCloudNativeStorageSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	storageAccountTags = @{
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
    /// 	# REQUIRED
    /// 	storageTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
    /// 	# OPTIONAL
    /// 	cmkInfo = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			keyVaultName = $someString
    /// 			# OPTIONAL
    /// 			keyName = $someString
    /// 			# OPTIONAL
    /// 			region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	networkAccessType = $someAzureStorageAccountNetworkAccess # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageAccountNetworkAccess]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCloudNativeAzureStorageSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCustomerAppPermissionForSql operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateCustomerAppPermissionForSql
    /// 
    /// $query = New-RscMutationAzure -Operation UpdateCustomerAppPermissionForSql
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
    /// Runs the UpdateTarget operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateTarget
    /// 
    /// $query = New-RscMutationAzure -Operation UpdateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	storageAccountName = $someString
    /// 	# OPTIONAL
    /// 	accessKey = $someString
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	computeSettings = @{
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecretKey = $someString
    /// 		# OPTIONAL
    /// 		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		# OPTIONAL
    /// 		generalPurposeStorageName = $someString
    /// 		# OPTIONAL
    /// 		generalPurposeStorageContainer = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		virtualNetworkId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
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
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 		# OPTIONAL
    /// 		subscriptionId = $someString
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
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		lockDurationDays = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
    /// 	# OPTIONAL
    /// 	accessTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
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
    /// Runs the UpdateTenantForSubscription operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateTenantForSubscription
    /// 
    /// $query = New-RscMutationAzure -Operation UpdateTenantForSubscription
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	customerSubscriptionId = $someString
    /// 	# REQUIRED
    /// 	tenantDomainName = $someString
    /// 	# REQUIRED
    /// 	cloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
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
    /// Runs the UpgradeCloudAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpgradeCloudAccount
    /// 
    /// $query = New-RscMutationAzure -Operation UpgradeCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# OPTIONAL
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	featuresToUpgrade = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 			# REQUIRED
    /// 			permissionsGroups = @(
    /// 				$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			resourceGroup = @{
    /// 				# REQUIRED
    /// 				name = $someString
    /// 				# OPTIONAL
    /// 				tags = @{
    /// 					# REQUIRED
    /// 					tagList = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							key = $someString
    /// 							# REQUIRED
    /// 							value = $someString
    /// 						}
    /// 					)
    /// 				}
    /// 				# REQUIRED
    /// 				region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 			}
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	azureSubscriptionRubrikIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpgradeAzureCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpgradeCloudAccountPermissionsWithoutOauth operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpgradeCloudAccountPermissionsWithoutOauth
    /// 
    /// $query = New-RscMutationAzure -Operation UpgradeCloudAccountPermissionsWithoutOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# OPTIONAL
    /// 	featureToUpgrade = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 			# REQUIRED
    /// 			permissionsGroups = @(
    /// 				$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			resourceGroup = @{
    /// 				# REQUIRED
    /// 				name = $someString
    /// 				# OPTIONAL
    /// 				tags = @{
    /// 					# REQUIRED
    /// 					tagList = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							key = $someString
    /// 							# REQUIRED
    /// 							value = $someString
    /// 						}
    /// 					)
    /// 				}
    /// 				# REQUIRED
    /// 				region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 			}
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	entraIdGroupId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpgradeAzureCloudAccountPermissionsWithoutOauthReply
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
        "RscMutationAzure",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationAzure : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddCloudAccount",
                "AddCloudAccountExocomputeConfigurations",
                "AddCloudAccountWithoutOauth",
                "BackupAdDirectory",
                "CloudAccountAddWithCustomerAppInitiate",
                "CompleteAdAppSetup",
                "CompleteAdAppUpdate",
                "CompleteCloudAccountOauth",
                "CreateAccount",
                "CreateAutomaticTargetMapping",
                "CreateCloudNativeRcvStorageSetting",
                "CreateCloudNativeStorageSetting",
                "CreateCluster",
                "CreateReaderTarget",
                "CreateSaasAppAad",
                "CreateTarget",
                "DeleteAdDirectory",
                "DeleteCloudAccount",
                "DeleteCloudAccountExocomputeConfigurations",
                "DeleteCloudAccountWithoutOauth",
                "ExcludeStorageAccountContainers",
                "MapCloudAccountExocomputeSubscription",
                "MapCloudAccountToPersistentStorageLocation",
                "OauthConsentComplete",
                "OauthConsentKickoff",
                "RestoreAdObjectsWithPasswords",
                "SetCloudAccountCustomerAppCredentials",
                "StartAdAppSetup",
                "StartAdAppUpdate",
                "StartCloudAccountOauth",
                "StartDisableCloudAccountJob",
                "StartExportSqlDatabaseDbJob",
                "StartExportSqlManagedInstanceDbJob",
                "UnmapCloudAccountExocomputeSubscription",
                "UnmapPersistentStorageSubscription",
                "UpdateAccount",
                "UpdateAutomaticTargetMapping",
                "UpdateCloudAccount",
                "UpdateCloudNativeRcvStorageSetting",
                "UpdateCloudNativeStorageSetting",
                "UpdateCustomerAppPermissionForSql",
                "UpdateTarget",
                "UpdateTenantForSubscription",
                "UpgradeCloudAccount",
                "UpgradeCloudAccountPermissionsWithoutOauth",
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
                    case "AddCloudAccount":
                        this.ProcessRecord_AddCloudAccount();
                        break;
                    case "AddCloudAccountExocomputeConfigurations":
                        this.ProcessRecord_AddCloudAccountExocomputeConfigurations();
                        break;
                    case "AddCloudAccountWithoutOauth":
                        this.ProcessRecord_AddCloudAccountWithoutOauth();
                        break;
                    case "BackupAdDirectory":
                        this.ProcessRecord_BackupAdDirectory();
                        break;
                    case "CloudAccountAddWithCustomerAppInitiate":
                        this.ProcessRecord_CloudAccountAddWithCustomerAppInitiate();
                        break;
                    case "CompleteAdAppSetup":
                        this.ProcessRecord_CompleteAdAppSetup();
                        break;
                    case "CompleteAdAppUpdate":
                        this.ProcessRecord_CompleteAdAppUpdate();
                        break;
                    case "CompleteCloudAccountOauth":
                        this.ProcessRecord_CompleteCloudAccountOauth();
                        break;
                    case "CreateAccount":
                        this.ProcessRecord_CreateAccount();
                        break;
                    case "CreateAutomaticTargetMapping":
                        this.ProcessRecord_CreateAutomaticTargetMapping();
                        break;
                    case "CreateCloudNativeRcvStorageSetting":
                        this.ProcessRecord_CreateCloudNativeRcvStorageSetting();
                        break;
                    case "CreateCloudNativeStorageSetting":
                        this.ProcessRecord_CreateCloudNativeStorageSetting();
                        break;
                    case "CreateCluster":
                        this.ProcessRecord_CreateCluster();
                        break;
                    case "CreateReaderTarget":
                        this.ProcessRecord_CreateReaderTarget();
                        break;
                    case "CreateSaasAppAad":
                        this.ProcessRecord_CreateSaasAppAad();
                        break;
                    case "CreateTarget":
                        this.ProcessRecord_CreateTarget();
                        break;
                    case "DeleteAdDirectory":
                        this.ProcessRecord_DeleteAdDirectory();
                        break;
                    case "DeleteCloudAccount":
                        this.ProcessRecord_DeleteCloudAccount();
                        break;
                    case "DeleteCloudAccountExocomputeConfigurations":
                        this.ProcessRecord_DeleteCloudAccountExocomputeConfigurations();
                        break;
                    case "DeleteCloudAccountWithoutOauth":
                        this.ProcessRecord_DeleteCloudAccountWithoutOauth();
                        break;
                    case "ExcludeStorageAccountContainers":
                        this.ProcessRecord_ExcludeStorageAccountContainers();
                        break;
                    case "MapCloudAccountExocomputeSubscription":
                        this.ProcessRecord_MapCloudAccountExocomputeSubscription();
                        break;
                    case "MapCloudAccountToPersistentStorageLocation":
                        this.ProcessRecord_MapCloudAccountToPersistentStorageLocation();
                        break;
                    case "OauthConsentComplete":
                        this.ProcessRecord_OauthConsentComplete();
                        break;
                    case "OauthConsentKickoff":
                        this.ProcessRecord_OauthConsentKickoff();
                        break;
                    case "RestoreAdObjectsWithPasswords":
                        this.ProcessRecord_RestoreAdObjectsWithPasswords();
                        break;
                    case "SetCloudAccountCustomerAppCredentials":
                        this.ProcessRecord_SetCloudAccountCustomerAppCredentials();
                        break;
                    case "StartAdAppSetup":
                        this.ProcessRecord_StartAdAppSetup();
                        break;
                    case "StartAdAppUpdate":
                        this.ProcessRecord_StartAdAppUpdate();
                        break;
                    case "StartCloudAccountOauth":
                        this.ProcessRecord_StartCloudAccountOauth();
                        break;
                    case "StartDisableCloudAccountJob":
                        this.ProcessRecord_StartDisableCloudAccountJob();
                        break;
                    case "StartExportSqlDatabaseDbJob":
                        this.ProcessRecord_StartExportSqlDatabaseDbJob();
                        break;
                    case "StartExportSqlManagedInstanceDbJob":
                        this.ProcessRecord_StartExportSqlManagedInstanceDbJob();
                        break;
                    case "UnmapCloudAccountExocomputeSubscription":
                        this.ProcessRecord_UnmapCloudAccountExocomputeSubscription();
                        break;
                    case "UnmapPersistentStorageSubscription":
                        this.ProcessRecord_UnmapPersistentStorageSubscription();
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
                    case "UpdateCloudNativeRcvStorageSetting":
                        this.ProcessRecord_UpdateCloudNativeRcvStorageSetting();
                        break;
                    case "UpdateCloudNativeStorageSetting":
                        this.ProcessRecord_UpdateCloudNativeStorageSetting();
                        break;
                    case "UpdateCustomerAppPermissionForSql":
                        this.ProcessRecord_UpdateCustomerAppPermissionForSql();
                        break;
                    case "UpdateTarget":
                        this.ProcessRecord_UpdateTarget();
                        break;
                    case "UpdateTenantForSubscription":
                        this.ProcessRecord_UpdateTenantForSubscription();
                        break;
                    case "UpgradeCloudAccount":
                        this.ProcessRecord_UpgradeCloudAccount();
                        break;
                    case "UpgradeCloudAccountPermissionsWithoutOauth":
                        this.ProcessRecord_UpgradeCloudAccountPermissionsWithoutOauth();
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
        // addAzureCloudAccount.
        internal void ProcessRecord_AddCloudAccount()
        {
            this._logger.name += " -AddCloudAccount";
            // Create new graphql operation addAzureCloudAccount
            InitMutationAddAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_AddCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -AddCloudAccountExocomputeConfigurations";
            // Create new graphql operation addAzureCloudAccountExocomputeConfigurations
            InitMutationAddAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountWithoutOauth.
        internal void ProcessRecord_AddCloudAccountWithoutOauth()
        {
            this._logger.name += " -AddCloudAccountWithoutOauth";
            // Create new graphql operation addAzureCloudAccountWithoutOauth
            InitMutationAddAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // backupAzureAdDirectory.
        internal void ProcessRecord_BackupAdDirectory()
        {
            this._logger.name += " -BackupAdDirectory";
            // Create new graphql operation backupAzureAdDirectory
            InitMutationBackupAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // azureCloudAccountAddWithCustomerAppInitiate.
        internal void ProcessRecord_CloudAccountAddWithCustomerAppInitiate()
        {
            this._logger.name += " -CloudAccountAddWithCustomerAppInitiate";
            // Create new graphql operation azureCloudAccountAddWithCustomerAppInitiate
            InitMutationAzureCloudAccountAddWithCustomerAppInitiate();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureAdAppSetup.
        internal void ProcessRecord_CompleteAdAppSetup()
        {
            this._logger.name += " -CompleteAdAppSetup";
            // Create new graphql operation completeAzureAdAppSetup
            InitMutationCompleteAzureAdAppSetup();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureAdAppUpdate.
        internal void ProcessRecord_CompleteAdAppUpdate()
        {
            this._logger.name += " -CompleteAdAppUpdate";
            // Create new graphql operation completeAzureAdAppUpdate
            InitMutationCompleteAzureAdAppUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureCloudAccountOauth.
        internal void ProcessRecord_CompleteCloudAccountOauth()
        {
            this._logger.name += " -CompleteCloudAccountOauth";
            // Create new graphql operation completeAzureCloudAccountOauth
            InitMutationCompleteAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureAccount.
        internal void ProcessRecord_CreateAccount()
        {
            this._logger.name += " -CreateAccount";
            // Create new graphql operation createAzureAccount
            InitMutationCreateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAzureTargetMapping.
        internal void ProcessRecord_CreateAutomaticTargetMapping()
        {
            this._logger.name += " -CreateAutomaticTargetMapping";
            // Create new graphql operation createAutomaticAzureTargetMapping
            InitMutationCreateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeRcvAzureStorageSetting.
        internal void ProcessRecord_CreateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeRcvStorageSetting";
            // Create new graphql operation createCloudNativeRcvAzureStorageSetting
            InitMutationCreateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAzureStorageSetting.
        internal void ProcessRecord_CreateCloudNativeStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeStorageSetting";
            // Create new graphql operation createCloudNativeAzureStorageSetting
            InitMutationCreateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureCluster.
        internal void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Create new graphql operation createAzureCluster
            InitMutationCreateAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureReaderTarget.
        internal void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Create new graphql operation createAzureReaderTarget
            InitMutationCreateAzureReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureSaasAppAad.
        internal void ProcessRecord_CreateSaasAppAad()
        {
            this._logger.name += " -CreateSaasAppAad";
            // Create new graphql operation createAzureSaasAppAad
            InitMutationCreateAzureSaasAppAad();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureTarget.
        internal void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Create new graphql operation createAzureTarget
            InitMutationCreateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureAdDirectory.
        internal void ProcessRecord_DeleteAdDirectory()
        {
            this._logger.name += " -DeleteAdDirectory";
            // Create new graphql operation deleteAzureAdDirectory
            InitMutationDeleteAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccount.
        internal void ProcessRecord_DeleteCloudAccount()
        {
            this._logger.name += " -DeleteCloudAccount";
            // Create new graphql operation deleteAzureCloudAccount
            InitMutationDeleteAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_DeleteCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -DeleteCloudAccountExocomputeConfigurations";
            // Create new graphql operation deleteAzureCloudAccountExocomputeConfigurations
            InitMutationDeleteAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountWithoutOauth.
        internal void ProcessRecord_DeleteCloudAccountWithoutOauth()
        {
            this._logger.name += " -DeleteCloudAccountWithoutOauth";
            // Create new graphql operation deleteAzureCloudAccountWithoutOauth
            InitMutationDeleteAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAzureStorageAccountContainers.
        internal void ProcessRecord_ExcludeStorageAccountContainers()
        {
            this._logger.name += " -ExcludeStorageAccountContainers";
            // Create new graphql operation excludeAzureStorageAccountContainers
            InitMutationExcludeAzureStorageAccountContainers();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountExocomputeSubscription.
        internal void ProcessRecord_MapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -MapCloudAccountExocomputeSubscription";
            // Create new graphql operation mapAzureCloudAccountExocomputeSubscription
            InitMutationMapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountToPersistentStorageLocation.
        internal void ProcessRecord_MapCloudAccountToPersistentStorageLocation()
        {
            this._logger.name += " -MapCloudAccountToPersistentStorageLocation";
            // Create new graphql operation mapAzureCloudAccountToPersistentStorageLocation
            InitMutationMapAzureCloudAccountToPersistentStorageLocation();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentComplete.
        internal void ProcessRecord_OauthConsentComplete()
        {
            this._logger.name += " -OauthConsentComplete";
            // Create new graphql operation azureOauthConsentComplete
            InitMutationAzureOauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentKickoff.
        internal void ProcessRecord_OauthConsentKickoff()
        {
            this._logger.name += " -OauthConsentKickoff";
            // Create new graphql operation azureOauthConsentKickoff
            InitMutationAzureOauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // restoreAzureAdObjectsWithPasswords.
        internal void ProcessRecord_RestoreAdObjectsWithPasswords()
        {
            this._logger.name += " -RestoreAdObjectsWithPasswords";
            // Create new graphql operation restoreAzureAdObjectsWithPasswords
            InitMutationRestoreAzureAdObjectsWithPasswords();
        }

        // This parameter set invokes a single graphql operation:
        // setAzureCloudAccountCustomerAppCredentials.
        internal void ProcessRecord_SetCloudAccountCustomerAppCredentials()
        {
            this._logger.name += " -SetCloudAccountCustomerAppCredentials";
            // Create new graphql operation setAzureCloudAccountCustomerAppCredentials
            InitMutationSetAzureCloudAccountCustomerAppCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureAdAppSetup.
        internal void ProcessRecord_StartAdAppSetup()
        {
            this._logger.name += " -StartAdAppSetup";
            // Create new graphql operation startAzureAdAppSetup
            InitMutationStartAzureAdAppSetup();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureAdAppUpdate.
        internal void ProcessRecord_StartAdAppUpdate()
        {
            this._logger.name += " -StartAdAppUpdate";
            // Create new graphql operation startAzureAdAppUpdate
            InitMutationStartAzureAdAppUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureCloudAccountOauth.
        internal void ProcessRecord_StartCloudAccountOauth()
        {
            this._logger.name += " -StartCloudAccountOauth";
            // Create new graphql operation startAzureCloudAccountOauth
            InitMutationStartAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureCloudAccountJob.
        internal void ProcessRecord_StartDisableCloudAccountJob()
        {
            this._logger.name += " -StartDisableCloudAccountJob";
            // Create new graphql operation startDisableAzureCloudAccountJob
            InitMutationStartDisableAzureCloudAccountJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlDatabaseDbJob.
        internal void ProcessRecord_StartExportSqlDatabaseDbJob()
        {
            this._logger.name += " -StartExportSqlDatabaseDbJob";
            // Create new graphql operation startExportAzureSqlDatabaseDbJob
            InitMutationStartExportAzureSqlDatabaseDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlManagedInstanceDbJob.
        internal void ProcessRecord_StartExportSqlManagedInstanceDbJob()
        {
            this._logger.name += " -StartExportSqlManagedInstanceDbJob";
            // Create new graphql operation startExportAzureSqlManagedInstanceDbJob
            InitMutationStartExportAzureSqlManagedInstanceDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzureCloudAccountExocomputeSubscription.
        internal void ProcessRecord_UnmapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -UnmapCloudAccountExocomputeSubscription";
            // Create new graphql operation unmapAzureCloudAccountExocomputeSubscription
            InitMutationUnmapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzurePersistentStorageSubscription.
        internal void ProcessRecord_UnmapPersistentStorageSubscription()
        {
            this._logger.name += " -UnmapPersistentStorageSubscription";
            // Create new graphql operation unmapAzurePersistentStorageSubscription
            InitMutationUnmapAzurePersistentStorageSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureAccount.
        internal void ProcessRecord_UpdateAccount()
        {
            this._logger.name += " -UpdateAccount";
            // Create new graphql operation updateAzureAccount
            InitMutationUpdateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAzureTargetMapping.
        internal void ProcessRecord_UpdateAutomaticTargetMapping()
        {
            this._logger.name += " -UpdateAutomaticTargetMapping";
            // Create new graphql operation updateAutomaticAzureTargetMapping
            InitMutationUpdateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureCloudAccount.
        internal void ProcessRecord_UpdateCloudAccount()
        {
            this._logger.name += " -UpdateCloudAccount";
            // Create new graphql operation updateAzureCloudAccount
            InitMutationUpdateAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeRcvAzureStorageSetting.
        internal void ProcessRecord_UpdateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeRcvStorageSetting";
            // Create new graphql operation updateCloudNativeRcvAzureStorageSetting
            InitMutationUpdateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAzureStorageSetting.
        internal void ProcessRecord_UpdateCloudNativeStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeStorageSetting";
            // Create new graphql operation updateCloudNativeAzureStorageSetting
            InitMutationUpdateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomerAppPermissionForAzureSql.
        internal void ProcessRecord_UpdateCustomerAppPermissionForSql()
        {
            this._logger.name += " -UpdateCustomerAppPermissionForSql";
            // Create new graphql operation updateCustomerAppPermissionForAzureSql
            InitMutationUpdateCustomerAppPermissionForAzureSql();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Create new graphql operation updateAzureTarget
            InitMutationUpdateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // azureUpdateTenantForSubscription.
        internal void ProcessRecord_UpdateTenantForSubscription()
        {
            this._logger.name += " -UpdateTenantForSubscription";
            // Create new graphql operation azureUpdateTenantForSubscription
            InitMutationAzureUpdateTenantForSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccount.
        internal void ProcessRecord_UpgradeCloudAccount()
        {
            this._logger.name += " -UpgradeCloudAccount";
            // Create new graphql operation upgradeAzureCloudAccount
            InitMutationUpgradeAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth.
        internal void ProcessRecord_UpgradeCloudAccountPermissionsWithoutOauth()
        {
            this._logger.name += " -UpgradeCloudAccountPermissionsWithoutOauth";
            // Create new graphql operation upgradeAzureCloudAccountPermissionsWithoutOauth
            InitMutationUpgradeAzureCloudAccountPermissionsWithoutOauth();
        }


        // Create new GraphQL Mutation:
        // addAzureCloudAccount(input: AddAzureCloudAccountInput!): AddAzureCloudAccountReply!
        internal void InitMutationAddAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAzureCloudAccount",
                "($input: AddAzureCloudAccountInput!)",
                "AddAzureCloudAccountReply",
                Mutation.AddAzureCloudAccount,
                Mutation.AddAzureCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	tenantDomainName = $someString
	# REQUIRED
	subscriptions = @(
		@{
			# REQUIRED
			features = @(
				@{
					# OPTIONAL
					resourceGroup = @{
						# REQUIRED
						name = $someString
						# OPTIONAL
						tags = @{
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
						# REQUIRED
						region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
					}
					# REQUIRED
					featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
					# OPTIONAL
					permissionsGroups = @(
						$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
					)
				}
			)
			# REQUIRED
			subscription = @{
				# REQUIRED
				nativeId = $someString
				# REQUIRED
				name = $someString
			}
		}
	)
	# REQUIRED
	regions = @(
		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	isAsynchronous = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // addAzureCloudAccountExocomputeConfigurations(input: AddAzureCloudAccountExocomputeConfigurationsInput!): AddAzureCloudAccountExocomputeConfigurationsReply!
        internal void InitMutationAddAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAzureCloudAccountExocomputeConfigurations",
                "($input: AddAzureCloudAccountExocomputeConfigurationsInput!)",
                "AddAzureCloudAccountExocomputeConfigurationsReply",
                Mutation.AddAzureCloudAccountExocomputeConfigurations,
                Mutation.AddAzureCloudAccountExocomputeConfigurationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	azureExocomputeRegionConfigs = @(
		@{
			# REQUIRED
			region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
			# OPTIONAL
			subnetNativeId = $someString
			# REQUIRED
			isRscManaged = $someBoolean
			# OPTIONAL
			podSubnetNativeId = $someString
			# OPTIONAL
			podOverlayNetworkCidr = $someString
			# OPTIONAL
			optionalConfig = @{
				# OPTIONAL
				aksNodeRgPrefix = $someString
				# OPTIONAL
				diskEncryptionAtHost = $someBoolean
				# OPTIONAL
				additionalWhitelistIps = @(
					$someString
				)
				# OPTIONAL
				enableUserDefinedRouting = $someBoolean
				# OPTIONAL
				shouldWhitelistRubrikIps = $someBoolean
				# OPTIONAL
				privateDnsZoneId = $someString
				# OPTIONAL
				aksCustomPrivateDnsZoneId = $someString
				# OPTIONAL
				aksClusterTier = $someAKSProvisionTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSProvisionTier]) for enum values.
				# OPTIONAL
				aksNodeCountBucket = $someAKSNodeCountBucket # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSNodeCountBucket]) for enum values.
				# OPTIONAL
				aksClusterAccessType = $someAKSClusterAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AKSClusterAccessType]) for enum values.
			}
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
        // addAzureCloudAccountWithoutOauth(input: AddAzureCloudAccountWithoutOauthInput!): AddAzureCloudAccountWithoutOauthReply!
        internal void InitMutationAddAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAzureCloudAccountWithoutOauth",
                "($input: AddAzureCloudAccountWithoutOauthInput!)",
                "AddAzureCloudAccountWithoutOauthReply",
                Mutation.AddAzureCloudAccountWithoutOauth,
                Mutation.AddAzureCloudAccountWithoutOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	tenantDomainName = $someString
	# REQUIRED
	subscriptions = @(
		@{
			# REQUIRED
			features = @(
				@{
					# REQUIRED
					policyVersion = $someInt
					# OPTIONAL
					resourceGroup = @{
						# REQUIRED
						name = $someString
						# OPTIONAL
						tags = @{
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
						# REQUIRED
						region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
					}
					# OPTIONAL
					specificFeatureInput = @{
						# REQUIRED
						userAssignedManagedIdentityInput = @{
							# REQUIRED
							name = $someString
							# REQUIRED
							resourceGroupName = $someString
							# REQUIRED
							principalId = $someString
							# REQUIRED
							region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
						}
					}
					# REQUIRED
					featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
					# OPTIONAL
					permissionsGroups = @(
						@{
							# REQUIRED
							permissionsGroup = $somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
							# OPTIONAL
							version = $someInt
						}
					)
				}
			)
			# REQUIRED
			subscription = @{
				# REQUIRED
				nativeId = $someString
				# REQUIRED
				name = $someString
			}
		}
	)
	# REQUIRED
	regions = @(
		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	isAsynchronous = $someBoolean
	# OPTIONAL
	entraIdGroupId = $someString
	# OPTIONAL
	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupAzureAdDirectory(input: BackupAzureAdDirectoryInput!): [CreateOnDemandJobReply!]!
        internal void InitMutationBackupAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupAzureAdDirectoryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupAzureAdDirectory",
                "($input: BackupAzureAdDirectoryInput!)",
                "List<CreateOnDemandJobReply>",
                Mutation.BackupAzureAdDirectory,
                Mutation.BackupAzureAdDirectoryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFids = @(
		$someString
	)
	# OPTIONAL
	snapshotRetentionSlaId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // azureCloudAccountAddWithCustomerAppInitiate(input: AzureCloudAccountAddWithCustomerAppInitiateInput!): AzureCloudAccountAddWithCustomerAppInitiateReply!
        internal void InitMutationAzureCloudAccountAddWithCustomerAppInitiate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureCloudAccountAddWithCustomerAppInitiateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAzureCloudAccountAddWithCustomerAppInitiate",
                "($input: AzureCloudAccountAddWithCustomerAppInitiateInput!)",
                "AzureCloudAccountAddWithCustomerAppInitiateReply",
                Mutation.AzureCloudAccountAddWithCustomerAppInitiate,
                Mutation.AzureCloudAccountAddWithCustomerAppInitiateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	tenantDomainName = $someString
	# OPTIONAL
	cloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
	# OPTIONAL
	appId = $someString
	# OPTIONAL
	appSecretKey = $someString
	# OPTIONAL
	redirectUrl = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeAzureAdAppSetup(input: CompleteAzureAdAppSetupInput!): CompleteAzureAdAppSetupReply!
        internal void InitMutationCompleteAzureAdAppSetup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureAdAppSetupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteAzureAdAppSetup",
                "($input: CompleteAzureAdAppSetupInput!)",
                "CompleteAzureAdAppSetupReply",
                Mutation.CompleteAzureAdAppSetup,
                Mutation.CompleteAzureAdAppSetupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	domainName = $someString
	# REQUIRED
	stateToken = $someString
	# OPTIONAL
	kmsSpec = @{
		# OPTIONAL
		cloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
		# OPTIONAL
		tenantId = $someString
		# OPTIONAL
		kmsId = $someString
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecret = $someString
		# OPTIONAL
		keyName = $someString
		# OPTIONAL
		kekNameColossus = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeAzureAdAppUpdate(input: CompleteAzureAdAppUpdateInput!): Void
        internal void InitMutationCompleteAzureAdAppUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureAdAppUpdateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteAzureAdAppUpdate",
                "($input: CompleteAzureAdAppUpdateInput!)",
                "System.String",
                Mutation.CompleteAzureAdAppUpdate,
                Mutation.CompleteAzureAdAppUpdateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFid = $someString
	# REQUIRED
	stateToken = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeAzureCloudAccountOauth(input: CompleteAzureCloudAccountOauthInput!): CompleteAzureCloudAccountOauthReply!
        internal void InitMutationCompleteAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureCloudAccountOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteAzureCloudAccountOauth",
                "($input: CompleteAzureCloudAccountOauthInput!)",
                "CompleteAzureCloudAccountOauthReply",
                Mutation.CompleteAzureCloudAccountOauth,
                Mutation.CompleteAzureCloudAccountOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	tenantDomainName = $someString
	# REQUIRED
	authorizationCode = $someString
	# REQUIRED
	redirectUrl = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	appId = $someString
	# OPTIONAL
	appSecretKey = $someString
	# REQUIRED
	shouldSkipPermissionChecks = $someBoolean
	# OPTIONAL
	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
	# OPTIONAL
	resource = $someAzureOauthResource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureOauthResource]) for enum values.
	# OPTIONAL
	performBasicOauth = $someBoolean
	# OPTIONAL
	shouldKeepRefreshToken = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureAccount(input: CreateAzureAccountInput!): CloudAccount!
        internal void InitMutationCreateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureAccount",
                "($input: CreateAzureAccountInput!)",
                "CloudAccount",
                Mutation.CreateAzureAccount,
                Mutation.CreateAzureAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# OPTIONAL
	description = $someString
	# REQUIRED
	subscriptionId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAutomaticAzureTargetMapping(input: CreateAutomaticAzureTargetMappingInput!): TargetMapping!
        internal void InitMutationCreateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticAzureTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAutomaticAzureTargetMapping",
                "($input: CreateAutomaticAzureTargetMappingInput!)",
                "TargetMapping",
                Mutation.CreateAutomaticAzureTargetMapping,
                Mutation.CreateAutomaticAzureTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	storageAccountName = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	containerNamePrefix = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = $someString
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecretKey = $someString
		# OPTIONAL
		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = $someString
		# OPTIONAL
		generalPurposeStorageContainer = $someString
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		virtualNetworkId = $someString
		# OPTIONAL
		subnetId = $someString
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
		# OPTIONAL
		cloudAccountId = $someString
		# OPTIONAL
		subscriptionId = $someString
	}
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
	# REQUIRED
	isConsolidationEnabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeRcvAzureStorageSetting(input: CreateCloudNativeRcvAzureStorageSettingInput!): CreateCloudNativeRcvAzureStorageSettingReply!
        internal void InitMutationCreateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeRcvAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeRcvAzureStorageSetting",
                "($input: CreateCloudNativeRcvAzureStorageSettingInput!)",
                "CreateCloudNativeRcvAzureStorageSettingReply",
                Mutation.CreateCloudNativeRcvAzureStorageSetting,
                Mutation.CreateCloudNativeRcvAzureStorageSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# OPTIONAL
	rcvRegion = $someRcsRegionEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsRegionEnumType]) for enum values.
	# OPTIONAL
	tier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# REQUIRED
	cloudNativeLocTemplateType = $someCloudNativeLocTemplateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
	# OPTIONAL
	redundancy = $someRcvRedundancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcvRedundancy]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeAzureStorageSetting(input: CreateCloudNativeAzureStorageSettingInput!): CreateCloudNativeAzureStorageSettingReply!
        internal void InitMutationCreateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeAzureStorageSetting",
                "($input: CreateCloudNativeAzureStorageSettingInput!)",
                "CreateCloudNativeAzureStorageSettingReply",
                Mutation.CreateCloudNativeAzureStorageSetting,
                Mutation.CreateCloudNativeAzureStorageSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	storageAccountName = $someString
	# REQUIRED
	containerName = $someString
	# OPTIONAL
	storageAccountTags = @{
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
	storageAccountRegion = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# REQUIRED
	storageTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# REQUIRED
	redundancy = $someAzureRedundancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRedundancy]) for enum values.
	# REQUIRED
	subscriptionNativeId = $someString
	# REQUIRED
	cloudNativeLocTemplateType = $someCloudNativeLocTemplateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
	# OPTIONAL
	cmkInfo = @(
		@{
			# OPTIONAL
			keyVaultName = $someString
			# OPTIONAL
			keyName = $someString
			# OPTIONAL
			region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		}
	)
	# OPTIONAL
	networkAccessType = $someAzureStorageAccountNetworkAccess # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageAccountNetworkAccess]) for enum values.
	# OPTIONAL
	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureCluster(input: CreateAzureClusterInput!): CcProvisionJobReply!
        internal void InitMutationCreateAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureCluster",
                "($input: CreateAzureClusterInput!)",
                "CcProvisionJobReply",
                Mutation.CreateAzureCluster,
                Mutation.CreateAzureClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	isEsType = $someBoolean
	# OPTIONAL
	keepClusterOnFailure = $someBoolean
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
		resourceGroup = $someString
		# OPTIONAL
		cdmVersion = $someString
		# OPTIONAL
		location = $someString
		# OPTIONAL
		nodeSizeGb = $someInt
		# OPTIONAL
		networkResourceGroup = $someString
		# OPTIONAL
		vnetResourceGroup = $someString
		# OPTIONAL
		networkSecurityGroup = $someString
		# OPTIONAL
		networkSecurityResourceGroup = $someString
		# OPTIONAL
		vnet = $someString
		# OPTIONAL
		subnet = $someString
		# OPTIONAL
		tags = $someString
		# OPTIONAL
		vmImage = $someString
		# OPTIONAL
		cdmProduct = $someString
		# OPTIONAL
		availabilityZone = $someString
		# OPTIONAL
		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		instanceType = $someAzureInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
	}
	# OPTIONAL
	validations = @(
		$someClusterCreateValidations # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCreateValidations]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureReaderTarget(input: CreateAzureReaderTargetInput!): Target!
        internal void InitMutationCreateAzureReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureReaderTarget",
                "($input: CreateAzureReaderTargetInput!)",
                "Target",
                Mutation.CreateAzureReaderTarget,
                Mutation.CreateAzureReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	storageAccountName = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	containerName = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# OPTIONAL
	rsaKey = $someString
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecretKey = $someString
		# OPTIONAL
		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = $someString
		# OPTIONAL
		generalPurposeStorageContainer = $someString
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		virtualNetworkId = $someString
		# OPTIONAL
		subnetId = $someString
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
		# OPTIONAL
		cloudAccountId = $someString
		# OPTIONAL
		subscriptionId = $someString
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
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = $someInt
	}
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
	# OPTIONAL
	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# OPTIONAL
	archivalDataSourceIds = @(
		$someString
	)
	# REQUIRED
	bypassProxy = $someBoolean
	# OPTIONAL
	azureKeyVaultKey = @{
		# REQUIRED
		kmsKeyVaultId = $someString
		# REQUIRED
		keyName = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureSaasAppAad: CreateAzureSaasAppAadReply!
        internal void InitMutationCreateAzureSaasAppAad()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureSaasAppAad",
                "",
                "CreateAzureSaasAppAadReply",
                Mutation.CreateAzureSaasAppAad,
                Mutation.CreateAzureSaasAppAadFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // createAzureTarget(input: CreateAzureTargetInput!): Target!
        internal void InitMutationCreateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureTarget",
                "($input: CreateAzureTargetInput!)",
                "Target",
                Mutation.CreateAzureTarget,
                Mutation.CreateAzureTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	storageAccountName = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	containerName = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# OPTIONAL
	rsaKey = $someString
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecretKey = $someString
		# OPTIONAL
		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = $someString
		# OPTIONAL
		generalPurposeStorageContainer = $someString
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		virtualNetworkId = $someString
		# OPTIONAL
		subnetId = $someString
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
		# OPTIONAL
		cloudAccountId = $someString
		# OPTIONAL
		subscriptionId = $someString
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
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = $someInt
	}
	# OPTIONAL
	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# OPTIONAL
	accessTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# REQUIRED
	bypassProxy = $someBoolean
	# OPTIONAL
	azureKeyVaultKey = @{
		# REQUIRED
		kmsKeyVaultId = $someString
		# REQUIRED
		keyName = $someString
		# REQUIRED
		keyVersion = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureAdDirectory(input: DeleteAzureAdDirectoryInput!): CreateOnDemandJobReply!
        internal void InitMutationDeleteAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureAdDirectoryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureAdDirectory",
                "($input: DeleteAzureAdDirectoryInput!)",
                "CreateOnDemandJobReply",
                Mutation.DeleteAzureAdDirectory,
                Mutation.DeleteAzureAdDirectoryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCloudAccount(input: DeleteAzureCloudAccountInput!): DeleteAzureCloudAccountReply!
        internal void InitMutationDeleteAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCloudAccount",
                "($input: DeleteAzureCloudAccountInput!)",
                "DeleteAzureCloudAccountReply",
                Mutation.DeleteAzureCloudAccount,
                Mutation.DeleteAzureCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCloudAccountExocomputeConfigurations(input: DeleteAzureCloudAccountExocomputeConfigurationsInput!): DeleteAzureCloudAccountExocomputeConfigurationsReply!
        internal void InitMutationDeleteAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCloudAccountExocomputeConfigurations",
                "($input: DeleteAzureCloudAccountExocomputeConfigurationsInput!)",
                "DeleteAzureCloudAccountExocomputeConfigurationsReply",
                Mutation.DeleteAzureCloudAccountExocomputeConfigurations,
                Mutation.DeleteAzureCloudAccountExocomputeConfigurationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCloudAccountWithoutOauth(input: DeleteAzureCloudAccountWithoutOauthInput!): DeleteAzureCloudAccountWithoutOauthReply!
        internal void InitMutationDeleteAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCloudAccountWithoutOauth",
                "($input: DeleteAzureCloudAccountWithoutOauthInput!)",
                "DeleteAzureCloudAccountWithoutOauthReply",
                Mutation.DeleteAzureCloudAccountWithoutOauth,
                Mutation.DeleteAzureCloudAccountWithoutOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // excludeAzureStorageAccountContainers(input: ExcludeAzureStorageAccountContainersInput!): Void
        internal void InitMutationExcludeAzureStorageAccountContainers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAzureStorageAccountContainersInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExcludeAzureStorageAccountContainers",
                "($input: ExcludeAzureStorageAccountContainersInput!)",
                "System.String",
                Mutation.ExcludeAzureStorageAccountContainers,
                Mutation.ExcludeAzureStorageAccountContainersFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	storageAccountId = $someString
	# REQUIRED
	containers = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // mapAzureCloudAccountExocomputeSubscription(input: MapAzureCloudAccountExocomputeSubscriptionInput!): MapAzureCloudAccountExocomputeSubscriptionReply!
        internal void InitMutationMapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMapAzureCloudAccountExocomputeSubscription",
                "($input: MapAzureCloudAccountExocomputeSubscriptionInput!)",
                "MapAzureCloudAccountExocomputeSubscriptionReply",
                Mutation.MapAzureCloudAccountExocomputeSubscription,
                Mutation.MapAzureCloudAccountExocomputeSubscriptionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
	# REQUIRED
	exocomputeCloudAccountId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // mapAzureCloudAccountToPersistentStorageLocation(input: MapAzureCloudAccountToPersistentStorageLocationInput!): MapAzureCloudAccountToPersistentStorageLocationReply!
        internal void InitMutationMapAzureCloudAccountToPersistentStorageLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountToPersistentStorageLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMapAzureCloudAccountToPersistentStorageLocation",
                "($input: MapAzureCloudAccountToPersistentStorageLocationInput!)",
                "MapAzureCloudAccountToPersistentStorageLocationReply",
                Mutation.MapAzureCloudAccountToPersistentStorageLocation,
                Mutation.MapAzureCloudAccountToPersistentStorageLocationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
	# REQUIRED
	persistentStorageId = $someString
	# REQUIRED
	azureNativeProtectionFeature = $someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // azureOauthConsentComplete(input: AzureOauthConsentCompleteInput!): RequestStatus!
        internal void InitMutationAzureOauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureOauthConsentCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAzureOauthConsentComplete",
                "($input: AzureOauthConsentCompleteInput!)",
                "RequestStatus",
                Mutation.AzureOauthConsentComplete,
                Mutation.AzureOauthConsentCompleteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	tenantId = $someString
	# REQUIRED
	code = $someString
	# REQUIRED
	stateToken = $someString
	# REQUIRED
	redirectUrl = $someString
	# OPTIONAL
	azureAppId = $someString
	# OPTIONAL
	azureAppSecret = $someString
	# REQUIRED
	azureCloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // azureOauthConsentKickoff: AzureOauthConsentKickoffReply!
        internal void InitMutationAzureOauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAzureOauthConsentKickoff",
                "",
                "AzureOauthConsentKickoffReply",
                Mutation.AzureOauthConsentKickoff,
                Mutation.AzureOauthConsentKickoffFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // restoreAzureAdObjectsWithPasswords(input: RestoreAzureAdObjectsWithPasswordsInput!): RestoreAzureAdObjectsWithPasswordsReply!
        internal void InitMutationRestoreAzureAdObjectsWithPasswords()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreAzureAdObjectsWithPasswordsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreAzureAdObjectsWithPasswords",
                "($input: RestoreAzureAdObjectsWithPasswordsInput!)",
                "RestoreAzureAdObjectsWithPasswordsReply",
                Mutation.RestoreAzureAdObjectsWithPasswords,
                Mutation.RestoreAzureAdObjectsWithPasswordsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFid = $someString
	# REQUIRED
	snapshotFid = $someString
	# REQUIRED
	passwordByUserIdMap = @(
		@{
			# REQUIRED
			userId = $someString
			# REQUIRED
			password = $someString
		}
	)
	# REQUIRED
	objectTypeToIdMap = @(
		@{
			# REQUIRED
			objectId = $someString
			# REQUIRED
			azureAdObjectType = $someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
		}
	)
	# REQUIRED
	forceChangePasswordWithMfa = $someBoolean
	# REQUIRED
	relationshipRestoreMode = $someAzureAdRelationshipRestoreModeEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdRelationshipRestoreModeEnumType]) for enum values.
	# OPTIONAL
	objectRecoveryOptions = @{
		# OPTIONAL
		servicePrincipalRecoveryOption = @{
			# REQUIRED
			recoverLinkedApplication = $someBoolean
		}
		# OPTIONAL
		applicationRecoveryOption = @{
			# REQUIRED
			recoverLinkedServicePrincipal = $someBoolean
		}
		# OPTIONAL
		userRecoveryOption = @{
			# REQUIRED
			generatePasswords = $someBoolean
		}
		# OPTIONAL
		conditionalAccessPolicyRecoveryOption = @{
			# REQUIRED
			policyConfigs = @(
				@{
					# REQUIRED
					id = $someString
					# OPTIONAL
					exportedPolicyName = $someString
					# REQUIRED
					recoveryState = $someAzureAdConditionalAccessPolicyStateEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdConditionalAccessPolicyStateEnumType]) for enum values.
					# OPTIONAL
					recoveryMethod = $someAzureAdConditionalAccessPolicyRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdConditionalAccessPolicyRecoveryType]) for enum values.
				}
			)
		}
		# OPTIONAL
		administrativeUnitRecoveryOption = @{
			# REQUIRED
			skipRestrictedManagementAdministrativeUnits = $someBoolean
		}
	}
	# OPTIONAL
	attributeRecoveryMode = $someAttributeRecoveryMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeRecoveryMode]) for enum values.
	# OPTIONAL
	attributeRecoveryOptions = @{
		# REQUIRED
		attributeRecoveryConfigs = @(
			@{
				# REQUIRED
				id = $someString
				# REQUIRED
				attributes = @(
					$someString
				)
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // setAzureCloudAccountCustomerAppCredentials(input: SetAzureCloudAccountCustomerAppCredentialsInput!): Boolean!
        internal void InitMutationSetAzureCloudAccountCustomerAppCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetAzureCloudAccountCustomerAppCredentialsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetAzureCloudAccountCustomerAppCredentials",
                "($input: SetAzureCloudAccountCustomerAppCredentialsInput!)",
                "System.Boolean",
                Mutation.SetAzureCloudAccountCustomerAppCredentials,
                Mutation.SetAzureCloudAccountCustomerAppCredentialsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	appId = $someString
	# REQUIRED
	appSecretKey = $someString
	# OPTIONAL
	appTenantId = $someString
	# OPTIONAL
	appName = $someString
	# OPTIONAL
	tenantDomainName = $someString
	# REQUIRED
	shouldReplace = $someBoolean
	# REQUIRED
	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAzureAdAppSetup(input: StartAzureAdAppSetupInput!): StartAzureAdAppSetupReply!
        internal void InitMutationStartAzureAdAppSetup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureAdAppSetupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAzureAdAppSetup",
                "($input: StartAzureAdAppSetupInput!)",
                "StartAzureAdAppSetupReply",
                Mutation.StartAzureAdAppSetup,
                Mutation.StartAzureAdAppSetupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	domainName = $someString
	# REQUIRED
	region = $someAzureAdRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdRegion]) for enum values.
	# OPTIONAL
	azureAdApp = @{
		# OPTIONAL
		clientId = $someString
		# OPTIONAL
		clientSecret = $someString
	}
	# OPTIONAL
	permissionAccessMode = $somePermissionAccessMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionAccessMode]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAzureAdAppUpdate(input: StartAzureAdAppUpdateInput!): StartAzureAdAppUpdateReply!
        internal void InitMutationStartAzureAdAppUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureAdAppUpdateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAzureAdAppUpdate",
                "($input: StartAzureAdAppUpdateInput!)",
                "StartAzureAdAppUpdateReply",
                Mutation.StartAzureAdAppUpdate,
                Mutation.StartAzureAdAppUpdateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFid = $someString
	# OPTIONAL
	azureAdApp = @{
		# OPTIONAL
		clientId = $someString
		# OPTIONAL
		clientSecret = $someString
	}
	# OPTIONAL
	permissionAccessMode = $somePermissionAccessMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionAccessMode]) for enum values.
	# OPTIONAL
	missingObjectTypes = @(
		$someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAzureCloudAccountOauth(input: StartAzureCloudAccountOauthInput!): StartAzureCloudAccountOauthReply!
        internal void InitMutationStartAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureCloudAccountOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAzureCloudAccountOauth",
                "($input: StartAzureCloudAccountOauthInput!)",
                "StartAzureCloudAccountOauthReply",
                Mutation.StartAzureCloudAccountOauth,
                Mutation.StartAzureCloudAccountOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	tenantDomainName = $someString
	# OPTIONAL
	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
	# OPTIONAL
	azureRubrikAppUseCase = $someAzureRubrikAppUseCase # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRubrikAppUseCase]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startDisableAzureCloudAccountJob(input: StartDisableAzureCloudAccountJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartDisableAzureCloudAccountJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureCloudAccountJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartDisableAzureCloudAccountJob",
                "($input: StartDisableAzureCloudAccountJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartDisableAzureCloudAccountJob,
                Mutation.StartDisableAzureCloudAccountJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
	# OPTIONAL
	sessionId = $someString
	# OPTIONAL
	deleteSnapshots = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureSqlDatabaseDbJob(input: StartExportAzureSqlDatabaseDbJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureSqlDatabaseDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlDatabaseDbJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureSqlDatabaseDbJob",
                "($input: StartExportAzureSqlDatabaseDbJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureSqlDatabaseDbJob,
                Mutation.StartExportAzureSqlDatabaseDbJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sourceDatabaseRubrikId = $someString
	# REQUIRED
	destinationDatabaseName = $someString
	# OPTIONAL
	destinationServerRubrikId = $someString
	# OPTIONAL
	elasticPoolName = $someString
	# REQUIRED
	shouldExportTags = $someBoolean
	# OPTIONAL
	azureSqlDatabaseDbPitExportInput = @{
		# REQUIRED
		restorePointInTime = $someDateTime
		# OPTIONAL
		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	azureSqlDatabaseDbLtrExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = $someString
		# REQUIRED
		destinationResourceGroupName = $someString
		# REQUIRED
		destinationServerName = $someString
		# REQUIRED
		destinationRegionName = $someString
		# OPTIONAL
		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	persistentBackupExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = $someString
		# OPTIONAL
		destinationServerCredentials = @{
			# REQUIRED
			login = $someString
			# REQUIRED
			password = $someString
		}
		# OPTIONAL
		authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
		# OPTIONAL
		sessionId = $someString
		# OPTIONAL
		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	serviceTier = $someString
	# OPTIONAL
	serviceObjectiveName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureSqlManagedInstanceDbJob(input: StartExportAzureSqlManagedInstanceDbJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureSqlManagedInstanceDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlManagedInstanceDbJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureSqlManagedInstanceDbJob",
                "($input: StartExportAzureSqlManagedInstanceDbJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureSqlManagedInstanceDbJob,
                Mutation.StartExportAzureSqlManagedInstanceDbJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sourceManagedInstanceDatabaseRubrikId = $someString
	# OPTIONAL
	destinationManagedInstanceRubrikId = $someString
	# REQUIRED
	destinationDatabaseName = $someString
	# REQUIRED
	destinationManagedInstanceName = $someString
	# REQUIRED
	destinationResourceGroupName = $someString
	# OPTIONAL
	azureSqlManagedInstanceDbPitExportInput = @{
		# REQUIRED
		restorePointInTime = $someDateTime
	}
	# OPTIONAL
	azureSqlManagedInstanceDbLtrExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = $someString
		# REQUIRED
		destinationRegionName = $someString
	}
	# OPTIONAL
	persistentBackupExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = $someString
		# OPTIONAL
		destinationServerCredentials = @{
			# REQUIRED
			login = $someString
			# REQUIRED
			password = $someString
		}
		# OPTIONAL
		authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
		# OPTIONAL
		sessionId = $someString
		# OPTIONAL
		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	serviceTier = $someString
	# OPTIONAL
	serviceObjectiveName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // unmapAzureCloudAccountExocomputeSubscription(input: UnmapAzureCloudAccountExocomputeSubscriptionInput!): UnmapAzureCloudAccountExocomputeSubscriptionReply!
        internal void InitMutationUnmapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnmapAzureCloudAccountExocomputeSubscription",
                "($input: UnmapAzureCloudAccountExocomputeSubscriptionInput!)",
                "UnmapAzureCloudAccountExocomputeSubscriptionReply",
                Mutation.UnmapAzureCloudAccountExocomputeSubscription,
                Mutation.UnmapAzureCloudAccountExocomputeSubscriptionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // unmapAzurePersistentStorageSubscription(input: UnmapAzurePersistentStorageSubscriptionInput!): Void
        internal void InitMutationUnmapAzurePersistentStorageSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapAzurePersistentStorageSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnmapAzurePersistentStorageSubscription",
                "($input: UnmapAzurePersistentStorageSubscriptionInput!)",
                "System.String",
                Mutation.UnmapAzurePersistentStorageSubscription,
                Mutation.UnmapAzurePersistentStorageSubscriptionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	applicationCloudAccountIds = @(
		$someString
	)
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	unmappingValidationType = $someUnmappingValidationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAzureAccount(input: UpdateAzureAccountInput!): CloudAccount!
        internal void InitMutationUpdateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureAccount",
                "($input: UpdateAzureAccountInput!)",
                "CloudAccount",
                Mutation.UpdateAzureAccount,
                Mutation.UpdateAzureAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	subscriptionId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAutomaticAzureTargetMapping(input: UpdateAutomaticAzureTargetMappingInput!): TargetMapping!
        internal void InitMutationUpdateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutomaticAzureTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAutomaticAzureTargetMapping",
                "($input: UpdateAutomaticAzureTargetMappingInput!)",
                "TargetMapping",
                Mutation.UpdateAutomaticAzureTargetMapping,
                Mutation.UpdateAutomaticAzureTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	storageAccountName = $someString
	# OPTIONAL
	accessKey = $someString
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecretKey = $someString
		# OPTIONAL
		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = $someString
		# OPTIONAL
		generalPurposeStorageContainer = $someString
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		virtualNetworkId = $someString
		# OPTIONAL
		subnetId = $someString
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
		# OPTIONAL
		cloudAccountId = $someString
		# OPTIONAL
		subscriptionId = $someString
	}
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
	isConsolidationEnabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAzureCloudAccount(input: UpdateAzureCloudAccountInput!): UpdateAzureCloudAccountReply!
        internal void InitMutationUpdateAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureCloudAccount",
                "($input: UpdateAzureCloudAccountInput!)",
                "UpdateAzureCloudAccountReply",
                Mutation.UpdateAzureCloudAccount,
                Mutation.UpdateAzureCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	subscriptions = @(
		@{
			# OPTIONAL
			id = $someString
			# OPTIONAL
			name = $someString
		}
	)
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	regionsToAdd = @(
		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	regionsToRemove = @(
		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeRcvAzureStorageSetting(input: UpdateCloudNativeRcvAzureStorageSettingInput!): UpdateCloudNativeRcvAzureStorageSettingReply!
        internal void InitMutationUpdateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeRcvAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeRcvAzureStorageSetting",
                "($input: UpdateCloudNativeRcvAzureStorageSettingInput!)",
                "UpdateCloudNativeRcvAzureStorageSettingReply",
                Mutation.UpdateCloudNativeRcvAzureStorageSetting,
                Mutation.UpdateCloudNativeRcvAzureStorageSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	name = $someString
	# OPTIONAL
	redundancyOpt = $someRcvRedundancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcvRedundancy]) for enum values.
	# OPTIONAL
	updateChildVaultsOpt = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeAzureStorageSetting(input: UpdateCloudNativeAzureStorageSettingInput!): UpdateCloudNativeAzureStorageSettingReply!
        internal void InitMutationUpdateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeAzureStorageSetting",
                "($input: UpdateCloudNativeAzureStorageSettingInput!)",
                "UpdateCloudNativeAzureStorageSettingReply",
                Mutation.UpdateCloudNativeAzureStorageSetting,
                Mutation.UpdateCloudNativeAzureStorageSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	storageAccountTags = @{
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
	# REQUIRED
	storageTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# OPTIONAL
	cmkInfo = @(
		@{
			# OPTIONAL
			keyVaultName = $someString
			# OPTIONAL
			keyName = $someString
			# OPTIONAL
			region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		}
	)
	# OPTIONAL
	networkAccessType = $someAzureStorageAccountNetworkAccess # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageAccountNetworkAccess]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCustomerAppPermissionForAzureSql: Void
        internal void InitMutationUpdateCustomerAppPermissionForAzureSql()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCustomerAppPermissionForAzureSql",
                "",
                "System.String",
                Mutation.UpdateCustomerAppPermissionForAzureSql,
                Mutation.UpdateCustomerAppPermissionForAzureSqlFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // updateAzureTarget(input: UpdateAzureTargetInput!): Target!
        internal void InitMutationUpdateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureTarget",
                "($input: UpdateAzureTargetInput!)",
                "Target",
                Mutation.UpdateAzureTarget,
                Mutation.UpdateAzureTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	storageAccountName = $someString
	# OPTIONAL
	accessKey = $someString
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecretKey = $someString
		# OPTIONAL
		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = $someString
		# OPTIONAL
		generalPurposeStorageContainer = $someString
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		virtualNetworkId = $someString
		# OPTIONAL
		subnetId = $someString
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
		# OPTIONAL
		cloudAccountId = $someString
		# OPTIONAL
		subscriptionId = $someString
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
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = $someInt
	}
	# OPTIONAL
	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# OPTIONAL
	accessTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# REQUIRED
	bypassProxy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // azureUpdateTenantForSubscription(input: AzureUpdateTenantForSubscriptionInput!): Void
        internal void InitMutationAzureUpdateTenantForSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureUpdateTenantForSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAzureUpdateTenantForSubscription",
                "($input: AzureUpdateTenantForSubscriptionInput!)",
                "System.String",
                Mutation.AzureUpdateTenantForSubscription,
                Mutation.AzureUpdateTenantForSubscriptionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	customerSubscriptionId = $someString
	# REQUIRED
	tenantDomainName = $someString
	# REQUIRED
	cloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeAzureCloudAccount(input: UpgradeAzureCloudAccountInput!): UpgradeAzureCloudAccountReply!
        internal void InitMutationUpgradeAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeAzureCloudAccount",
                "($input: UpgradeAzureCloudAccountInput!)",
                "UpgradeAzureCloudAccountReply",
                Mutation.UpgradeAzureCloudAccount,
                Mutation.UpgradeAzureCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# OPTIONAL
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	featuresToUpgrade = @(
		@{
			# REQUIRED
			featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			# REQUIRED
			permissionsGroups = @(
				$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
			)
			# OPTIONAL
			resourceGroup = @{
				# REQUIRED
				name = $someString
				# OPTIONAL
				tags = @{
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
				# REQUIRED
				region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
			}
		}
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth(input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!): UpgradeAzureCloudAccountPermissionsWithoutOauthReply!
        internal void InitMutationUpgradeAzureCloudAccountPermissionsWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountPermissionsWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeAzureCloudAccountPermissionsWithoutOauth",
                "($input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!)",
                "UpgradeAzureCloudAccountPermissionsWithoutOauthReply",
                Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauth,
                Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# OPTIONAL
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	featureToUpgrade = @(
		@{
			# REQUIRED
			featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			# REQUIRED
			permissionsGroups = @(
				$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
			)
			# OPTIONAL
			resourceGroup = @{
				# REQUIRED
				name = $someString
				# OPTIONAL
				tags = @{
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
				# REQUIRED
				region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
			}
		}
	)
	# OPTIONAL
	entraIdGroupId = $someString
}"
            );
        }


    } // class New_RscMutationAzure
}