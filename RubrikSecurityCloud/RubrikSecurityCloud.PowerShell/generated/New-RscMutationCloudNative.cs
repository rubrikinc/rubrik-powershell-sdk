// New-RscMutationCloudNative.cs
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
    /// Create a new RscQuery object for any of the 21
    /// operations in the 'Cloud Native' API domain:
    /// AddSqlServerBackupCredentials, CheckRbaConnectivity, ClearSqlServerBackupCredentials, CreateApplication, CreateLabelRule, CreateTagRule, DeleteApplication, DeleteLabelRule, DeleteTagRule, DownloadFiles, RecoverApplication, RefreshApplication, SetGatewayKmsKeys, SetupSqlServerBackup, StartSnapshotsIndexJob, UpdateApplication, UpdateCustomerSettings, UpdateIndexingStatus, UpdateLabelRule, UpdateRootThreatMonitoringEnablement, or UpdateTagRule.
    /// </summary>
    /// <description>
    /// New-RscMutationCloudNative creates a new
    /// mutation object for operations
    /// in the 'Cloud Native' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 21 operations
    /// in the 'Cloud Native' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddSqlServerBackupCredentials, CheckRbaConnectivity, ClearSqlServerBackupCredentials, CreateApplication, CreateLabelRule, CreateTagRule, DeleteApplication, DeleteLabelRule, DeleteTagRule, DownloadFiles, RecoverApplication, RefreshApplication, SetGatewayKmsKeys, SetupSqlServerBackup, StartSnapshotsIndexJob, UpdateApplication, UpdateCustomerSettings, UpdateIndexingStatus, UpdateLabelRule, UpdateRootThreatMonitoringEnablement, or UpdateTagRule.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationCloudNative -AddSqlServerBackupCredentials).Info().
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
    /// (New-RscMutationCloudNative -AddSqlServerBackupCredentials).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddSqlServerBackupCredentials operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: AddSqlServerBackupCredentials
    /// 
    /// $query = New-RscMutationCloudNative -Operation AddSqlServerBackupCredentials
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	workloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 	# OPTIONAL
    /// 	backupCredentials = @{
    /// 		# REQUIRED
    /// 		login = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	logicAppName = $someString
    /// 	# OPTIONAL
    /// 	logicAppApiKey = $someString
    /// 	# OPTIONAL
    /// 	shouldUseAad = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddCloudNativeSqlServerBackupCredentialsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckRbaConnectivity operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CheckRbaConnectivity
    /// 
    /// $query = New-RscMutationCloudNative -Operation CheckRbaConnectivity
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudNativeCheckRbaConnectivityReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClearSqlServerBackupCredentials operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: ClearSqlServerBackupCredentials
    /// 
    /// $query = New-RscMutationCloudNative -Operation ClearSqlServerBackupCredentials
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	workloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClearCloudNativeSqlServerBackupCredentialsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateApplication operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CreateApplication
    /// 
    /// $query = New-RscMutationCloudNative -Operation CreateApplication
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	cloudNativeAccountId = $someString
    /// 	# REQUIRED
    /// 	targetCloudNativeAccountId = $someString
    /// 	# REQUIRED
    /// 	region = @{
    /// 		# OPTIONAL
    /// 		region = @{
    /// 			# OPTIONAL
    /// 			awsRegion = $someAwsCommonRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCommonRegion]) for enum values.
    /// 			# OPTIONAL
    /// 			azureRegion = $someAzureCommonRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCommonRegion]) for enum values.
    /// 			# OPTIONAL
    /// 			gcpRegion = $someGcpCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpCloudAccountRegion]) for enum values.
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	serviceConfigured = @{
    /// 		# OPTIONAL
    /// 		configurationEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		applicationCloudConfig = @{
    /// 			# OPTIONAL
    /// 			awsConfig = @{
    /// 				# OPTIONAL
    /// 				ec2Enabled = $someBoolean
    /// 				# OPTIONAL
    /// 				rdsEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				ebsEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				elbEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				s3Enabled = $someBoolean
    /// 				# OPTIONAL
    /// 				secretsEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				elasticacheEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				eksEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				ecrEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				lambdaEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isEcsEnabled = $someBoolean
    /// 			}
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	cloudType = $someCloudServiceProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudServiceProvider]) for enum values.
    /// 	# OPTIONAL
    /// 	resourceInclusionList = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	resourceExclusionList = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	matchingTags = @{
    /// 		# REQUIRED
    /// 		matchingTagsList = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				key = $someString
    /// 				# OPTIONAL
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
    /// Write-Host $result.GetType().Name # prints: CreateCloudNativeApplicationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateLabelRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CreateLabelRule
    /// 
    /// $query = New-RscMutationCloudNative -Operation CreateLabelRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values.
    /// 	# REQUIRED
    /// 	labelRuleName = $someString
    /// 	# OPTIONAL
    /// 	label = @{
    /// 		# REQUIRED
    /// 		labelKey = $someString
    /// 		# REQUIRED
    /// 		labelValue = $someString
    /// 		# REQUIRED
    /// 		matchAllValues = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
    /// 	# OPTIONAL
    /// 	slaId = $someString
    /// 	# OPTIONAL
    /// 	cloudNativeAccountIds = @{
    /// 		# OPTIONAL
    /// 		awsNativeAccountIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureNativeSubscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		gcpNativeProjectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	applyToAllCloudAccounts = $someBoolean
    /// 	# OPTIONAL
    /// 	labelConditions = @{
    /// 		# REQUIRED
    /// 		tagPairs = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				key = $someString
    /// 				# REQUIRED
    /// 				values = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				matchAllTagValues = $someBoolean
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCloudNativeLabelRuleReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateTagRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CreateTagRule
    /// 
    /// $query = New-RscMutationCloudNative -Operation CreateTagRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values.
    /// 	# REQUIRED
    /// 	tagRuleName = $someString
    /// 	# OPTIONAL
    /// 	tag = @{
    /// 		# REQUIRED
    /// 		tagKey = $someString
    /// 		# REQUIRED
    /// 		tagValue = $someString
    /// 		# REQUIRED
    /// 		matchAllValues = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
    /// 	# OPTIONAL
    /// 	slaId = $someString
    /// 	# OPTIONAL
    /// 	cloudNativeAccountIds = @{
    /// 		# OPTIONAL
    /// 		awsNativeAccountIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureNativeSubscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		gcpNativeProjectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	applyToAllCloudAccounts = $someBoolean
    /// 	# OPTIONAL
    /// 	tagConditions = @{
    /// 		# REQUIRED
    /// 		tagPairs = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				key = $someString
    /// 				# REQUIRED
    /// 				values = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				matchAllTagValues = $someBoolean
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCloudNativeTagRuleReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteApplication operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: DeleteApplication
    /// 
    /// $query = New-RscMutationCloudNative -Operation DeleteApplication
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
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
    /// Runs the DeleteLabelRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: DeleteLabelRule
    /// 
    /// $query = New-RscMutationCloudNative -Operation DeleteLabelRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ruleId = $someString
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
    /// Runs the DeleteTagRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: DeleteTagRule
    /// 
    /// $query = New-RscMutationCloudNative -Operation DeleteTagRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ruleId = $someString
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
    /// Runs the DownloadFiles operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: DownloadFiles
    /// 
    /// $query = New-RscMutationCloudNative -Operation DownloadFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	filePaths = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
    /// 	# REQUIRED
    /// 	fileRecoveryLocationDetails = @{
    /// 		# OPTIONAL
    /// 		cloudDownloadLocationDetails = @{
    /// 			# REQUIRED
    /// 			downloadLocation = $someString
    /// 			# REQUIRED
    /// 			createDownloadLocation = $someBoolean
    /// 			# OPTIONAL
    /// 			tags = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					tagKey = $someString
    /// 					# REQUIRED
    /// 					tagValue = $someString
    /// 					# REQUIRED
    /// 					matchAllValues = $someBoolean
    /// 				}
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		vmDownloadLocationDetails = @{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# OPTIONAL
    /// 			pathToRecover = $someString
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	downloadType = $someFileDownloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileDownloadType]) for enum values.
    /// 	# OPTIONAL
    /// 	exocomputeCloudNativeAccountId = $someString
    /// 	# OPTIONAL
    /// 	exocomputeRegion = $someString
    /// 	# OPTIONAL
    /// 	archivedSnapshotId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadFilesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverApplication operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: RecoverApplication
    /// 
    /// $query = New-RscMutationCloudNative -Operation RecoverApplication
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	applicationId = $someString
    /// 	# REQUIRED
    /// 	targetCloudNativeAccountId = $someString
    /// 	# REQUIRED
    /// 	recoveryName = $someString
    /// 	# REQUIRED
    /// 	errorHandling = $someRecoveryErrorHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoveryErrorHandling]) for enum values.
    /// 	# OPTIONAL
    /// 	workloadSnapshots = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			workloadId = $someString
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	preRecoveryHook = @{
    /// 		# REQUIRED
    /// 		hookInfo = @{
    /// 			# OPTIONAL
    /// 			hook = @{
    /// 				# OPTIONAL
    /// 				awsLambda = @{
    /// 					# REQUIRED
    /// 					lambdaId = $someString
    /// 				}
    /// 			}
    /// 		}
    /// 		# REQUIRED
    /// 		failureHandling = $someHookFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HookFailureHandling]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	postRecoveryHook = @{
    /// 		# REQUIRED
    /// 		hookInfo = @{
    /// 			# OPTIONAL
    /// 			hook = @{
    /// 				# OPTIONAL
    /// 				awsLambda = @{
    /// 					# REQUIRED
    /// 					lambdaId = $someString
    /// 				}
    /// 			}
    /// 		}
    /// 		# REQUIRED
    /// 		failureHandling = $someHookFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HookFailureHandling]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	vmPostRecoveryScriptEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	cloudSettings = @{
    /// 		# OPTIONAL
    /// 		awsSettings = @{
    /// 			# OPTIONAL
    /// 			networking = @{
    /// 				# OPTIONAL
    /// 				vpcOption = @{
    /// 					# OPTIONAL
    /// 					cloneVpcSameCidr = @{
    /// 						# OPTIONAL
    /// 						preserveCidr = $someBoolean
    /// 					}
    /// 					# OPTIONAL
    /// 					cloneVpcAlternateCidr = @{
    /// 						# REQUIRED
    /// 						vpcCidrMappings = @(
    /// 							@{
    /// 								# REQUIRED
    /// 								sourceVpcId = $someString
    /// 								# REQUIRED
    /// 								cidrMappings = @(
    /// 									@{
    /// 										# REQUIRED
    /// 										sourceCidr = $someString
    /// 										# REQUIRED
    /// 										targetCidr = $someString
    /// 									}
    /// 								)
    /// 							}
    /// 						)
    /// 					}
    /// 					# OPTIONAL
    /// 					useExistingVpc = @{
    /// 						# REQUIRED
    /// 						vpcIdMappings = @(
    /// 							@{
    /// 								# REQUIRED
    /// 								sourceVpcId = $someString
    /// 								# REQUIRED
    /// 								targetVpcId = $someString
    /// 							}
    /// 						)
    /// 					}
    /// 				}
    /// 			}
    /// 			# OPTIONAL
    /// 			kms = @{
    /// 				# REQUIRED
    /// 				kmsKeyId = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			dns = @{
    /// 				# OPTIONAL
    /// 				shouldUpdateDns = $someBoolean
    /// 			}
    /// 			# OPTIONAL
    /// 			s3 = @{
    /// 				# OPTIONAL
    /// 				buckets = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						workloadId = $someString
    /// 						# OPTIONAL
    /// 						shouldRecoverFullBucket = $someBoolean
    /// 						# OPTIONAL
    /// 						regexPatterns = @(
    /// 							$someString
    /// 						)
    /// 						# OPTIONAL
    /// 						destination = @{
    /// 							# OPTIONAL
    /// 							existingBucket = @{
    /// 								# REQUIRED
    /// 								destinationBucketArn = $someString
    /// 							}
    /// 							# OPTIONAL
    /// 							newBucket = @{
    /// 								# REQUIRED
    /// 								destinationBucketName = $someString
    /// 							}
    /// 						}
    /// 					}
    /// 				)
    /// 			}
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RecoverCloudNativeApplicationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshApplication operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: RefreshApplication
    /// 
    /// $query = New-RscMutationCloudNative -Operation RefreshApplication
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	cloud = $someCloudServiceProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudServiceProvider]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RefreshCloudNativeApplicationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetGatewayKmsKeys operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: SetGatewayKmsKeys
    /// 
    /// $query = New-RscMutationCloudNative -Operation SetGatewayKmsKeys
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	gatewayKmsKeyMap = @{
    /// 		# REQUIRED
    /// 		gatewayKmsKeyMapList = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				region = $someString
    /// 				# OPTIONAL
    /// 				kmsKeyArn = $someString
    /// 			}
    /// 		)
    /// 	}
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
    /// Runs the SetupSqlServerBackup operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: SetupSqlServerBackup
    /// 
    /// $query = New-RscMutationCloudNative -Operation SetupSqlServerBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	databaseIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	adminCredentials = @{
    /// 		# REQUIRED
    /// 		login = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
    /// 	# OPTIONAL
    /// 	sessionId = $someString
    /// 	# OPTIONAL
    /// 	serverIds = @(
    /// 		$someString
    /// 	)
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
    /// Runs the StartSnapshotsIndexJob operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: StartSnapshotsIndexJob
    /// 
    /// $query = New-RscMutationCloudNative -Operation StartSnapshotsIndexJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotIds = @(
    /// 		$someString
    /// 	)
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
    /// Runs the UpdateApplication operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: UpdateApplication
    /// 
    /// $query = New-RscMutationCloudNative -Operation UpdateApplication
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	targetCloudNativeAccountId = $someString
    /// 	# OPTIONAL
    /// 	serviceConfigured = @{
    /// 		# OPTIONAL
    /// 		configurationEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		applicationCloudConfig = @{
    /// 			# OPTIONAL
    /// 			awsConfig = @{
    /// 				# OPTIONAL
    /// 				ec2Enabled = $someBoolean
    /// 				# OPTIONAL
    /// 				rdsEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				ebsEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				elbEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				s3Enabled = $someBoolean
    /// 				# OPTIONAL
    /// 				secretsEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				elasticacheEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				eksEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				ecrEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				lambdaEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				isEcsEnabled = $someBoolean
    /// 			}
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	postRecoveryScriptConfigured = $someBoolean
    /// 	# OPTIONAL
    /// 	resourceInclusionList = @{
    /// 		# OPTIONAL
    /// 		uris = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	resourceExclusionList = @{
    /// 		# OPTIONAL
    /// 		uris = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	matchingTags = @{
    /// 		# REQUIRED
    /// 		matchingTagsList = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				key = $someString
    /// 				# OPTIONAL
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
    /// Write-Host $result.GetType().Name # prints: UpdateCloudNativeApplicationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCustomerSettings operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: UpdateCustomerSettings
    /// 
    /// $query = New-RscMutationCloudNative -Operation UpdateCustomerSettings
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	settings = @{
    /// 		# OPTIONAL
    /// 		isS3GlacierIrTierEnabled = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCloudNativeCustomerSettingsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateIndexingStatus operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: UpdateIndexingStatus
    /// 
    /// $query = New-RscMutationCloudNative -Operation UpdateIndexingStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	isIndexingEnabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCloudNativeIndexingStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateLabelRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: UpdateLabelRule
    /// 
    /// $query = New-RscMutationCloudNative -Operation UpdateLabelRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	labelRuleId = $someString
    /// 	# REQUIRED
    /// 	labelRuleName = $someString
    /// 	# OPTIONAL
    /// 	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
    /// 	# OPTIONAL
    /// 	slaId = $someString
    /// 	# OPTIONAL
    /// 	cloudNativeAccountIds = @{
    /// 		# OPTIONAL
    /// 		awsNativeAccountIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureNativeSubscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		gcpNativeProjectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	applyToAllCloudAccounts = $someBoolean
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
    /// Runs the UpdateRootThreatMonitoringEnablement operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: UpdateRootThreatMonitoringEnablement
    /// 
    /// $query = New-RscMutationCloudNative -Operation UpdateRootThreatMonitoringEnablement
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	isEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	rootIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	shouldScanAllFiles = $someBoolean
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
    /// Runs the UpdateTagRule operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: UpdateTagRule
    /// 
    /// $query = New-RscMutationCloudNative -Operation UpdateTagRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	tagRuleId = $someString
    /// 	# REQUIRED
    /// 	tagRuleName = $someString
    /// 	# OPTIONAL
    /// 	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
    /// 	# OPTIONAL
    /// 	slaId = $someString
    /// 	# OPTIONAL
    /// 	cloudNativeAccountIds = @{
    /// 		# OPTIONAL
    /// 		awsNativeAccountIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureNativeSubscriptionIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		gcpNativeProjectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	applyToAllCloudAccounts = $someBoolean
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationCloudNative",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationCloudNative : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddSqlServerBackupCredentials",
                "CheckRbaConnectivity",
                "ClearSqlServerBackupCredentials",
                "CreateApplication",
                "CreateLabelRule",
                "CreateTagRule",
                "DeleteApplication",
                "DeleteLabelRule",
                "DeleteTagRule",
                "DownloadFiles",
                "RecoverApplication",
                "RefreshApplication",
                "SetGatewayKmsKeys",
                "SetupSqlServerBackup",
                "StartSnapshotsIndexJob",
                "UpdateApplication",
                "UpdateCustomerSettings",
                "UpdateIndexingStatus",
                "UpdateLabelRule",
                "UpdateRootThreatMonitoringEnablement",
                "UpdateTagRule",
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
                    case "AddSqlServerBackupCredentials":
                        this.ProcessRecord_AddSqlServerBackupCredentials();
                        break;
                    case "CheckRbaConnectivity":
                        this.ProcessRecord_CheckRbaConnectivity();
                        break;
                    case "ClearSqlServerBackupCredentials":
                        this.ProcessRecord_ClearSqlServerBackupCredentials();
                        break;
                    case "CreateApplication":
                        this.ProcessRecord_CreateApplication();
                        break;
                    case "CreateLabelRule":
                        this.ProcessRecord_CreateLabelRule();
                        break;
                    case "CreateTagRule":
                        this.ProcessRecord_CreateTagRule();
                        break;
                    case "DeleteApplication":
                        this.ProcessRecord_DeleteApplication();
                        break;
                    case "DeleteLabelRule":
                        this.ProcessRecord_DeleteLabelRule();
                        break;
                    case "DeleteTagRule":
                        this.ProcessRecord_DeleteTagRule();
                        break;
                    case "DownloadFiles":
                        this.ProcessRecord_DownloadFiles();
                        break;
                    case "RecoverApplication":
                        this.ProcessRecord_RecoverApplication();
                        break;
                    case "RefreshApplication":
                        this.ProcessRecord_RefreshApplication();
                        break;
                    case "SetGatewayKmsKeys":
                        this.ProcessRecord_SetGatewayKmsKeys();
                        break;
                    case "SetupSqlServerBackup":
                        this.ProcessRecord_SetupSqlServerBackup();
                        break;
                    case "StartSnapshotsIndexJob":
                        this.ProcessRecord_StartSnapshotsIndexJob();
                        break;
                    case "UpdateApplication":
                        this.ProcessRecord_UpdateApplication();
                        break;
                    case "UpdateCustomerSettings":
                        this.ProcessRecord_UpdateCustomerSettings();
                        break;
                    case "UpdateIndexingStatus":
                        this.ProcessRecord_UpdateIndexingStatus();
                        break;
                    case "UpdateLabelRule":
                        this.ProcessRecord_UpdateLabelRule();
                        break;
                    case "UpdateRootThreatMonitoringEnablement":
                        this.ProcessRecord_UpdateRootThreatMonitoringEnablement();
                        break;
                    case "UpdateTagRule":
                        this.ProcessRecord_UpdateTagRule();
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
        // addCloudNativeSqlServerBackupCredentials.
        internal void ProcessRecord_AddSqlServerBackupCredentials()
        {
            this._logger.name += " -AddSqlServerBackupCredentials";
            // Create new graphql operation addCloudNativeSqlServerBackupCredentials
            InitMutationAddCloudNativeSqlServerBackupCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeCheckRbaConnectivity.
        internal void ProcessRecord_CheckRbaConnectivity()
        {
            this._logger.name += " -CheckRbaConnectivity";
            // Create new graphql operation cloudNativeCheckRbaConnectivity
            InitMutationCloudNativeCheckRbaConnectivity();
        }

        // This parameter set invokes a single graphql operation:
        // clearCloudNativeSqlServerBackupCredentials.
        internal void ProcessRecord_ClearSqlServerBackupCredentials()
        {
            this._logger.name += " -ClearSqlServerBackupCredentials";
            // Create new graphql operation clearCloudNativeSqlServerBackupCredentials
            InitMutationClearCloudNativeSqlServerBackupCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeApplication.
        internal void ProcessRecord_CreateApplication()
        {
            this._logger.name += " -CreateApplication";
            // Create new graphql operation createCloudNativeApplication
            InitMutationCreateCloudNativeApplication();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeLabelRule.
        internal void ProcessRecord_CreateLabelRule()
        {
            this._logger.name += " -CreateLabelRule";
            // Create new graphql operation createCloudNativeLabelRule
            InitMutationCreateCloudNativeLabelRule();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeTagRule.
        internal void ProcessRecord_CreateTagRule()
        {
            this._logger.name += " -CreateTagRule";
            // Create new graphql operation createCloudNativeTagRule
            InitMutationCreateCloudNativeTagRule();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCloudNativeApplication.
        internal void ProcessRecord_DeleteApplication()
        {
            this._logger.name += " -DeleteApplication";
            // Create new graphql operation deleteCloudNativeApplication
            InitMutationDeleteCloudNativeApplication();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCloudNativeLabelRule.
        internal void ProcessRecord_DeleteLabelRule()
        {
            this._logger.name += " -DeleteLabelRule";
            // Create new graphql operation deleteCloudNativeLabelRule
            InitMutationDeleteCloudNativeLabelRule();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCloudNativeTagRule.
        internal void ProcessRecord_DeleteTagRule()
        {
            this._logger.name += " -DeleteTagRule";
            // Create new graphql operation deleteCloudNativeTagRule
            InitMutationDeleteCloudNativeTagRule();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeDownloadFiles.
        internal void ProcessRecord_DownloadFiles()
        {
            this._logger.name += " -DownloadFiles";
            // Create new graphql operation cloudNativeDownloadFiles
            InitMutationCloudNativeDownloadFiles();
        }

        // This parameter set invokes a single graphql operation:
        // recoverCloudNativeApplication.
        internal void ProcessRecord_RecoverApplication()
        {
            this._logger.name += " -RecoverApplication";
            // Create new graphql operation recoverCloudNativeApplication
            InitMutationRecoverCloudNativeApplication();
        }

        // This parameter set invokes a single graphql operation:
        // refreshCloudNativeApplication.
        internal void ProcessRecord_RefreshApplication()
        {
            this._logger.name += " -RefreshApplication";
            // Create new graphql operation refreshCloudNativeApplication
            InitMutationRefreshCloudNativeApplication();
        }

        // This parameter set invokes a single graphql operation:
        // setCloudNativeGatewayKmsKeys.
        internal void ProcessRecord_SetGatewayKmsKeys()
        {
            this._logger.name += " -SetGatewayKmsKeys";
            // Create new graphql operation setCloudNativeGatewayKmsKeys
            InitMutationSetCloudNativeGatewayKmsKeys();
        }

        // This parameter set invokes a single graphql operation:
        // setupCloudNativeSqlServerBackup.
        internal void ProcessRecord_SetupSqlServerBackup()
        {
            this._logger.name += " -SetupSqlServerBackup";
            // Create new graphql operation setupCloudNativeSqlServerBackup
            InitMutationSetupCloudNativeSqlServerBackup();
        }

        // This parameter set invokes a single graphql operation:
        // startCloudNativeSnapshotsIndexJob.
        internal void ProcessRecord_StartSnapshotsIndexJob()
        {
            this._logger.name += " -StartSnapshotsIndexJob";
            // Create new graphql operation startCloudNativeSnapshotsIndexJob
            InitMutationStartCloudNativeSnapshotsIndexJob();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeApplication.
        internal void ProcessRecord_UpdateApplication()
        {
            this._logger.name += " -UpdateApplication";
            // Create new graphql operation updateCloudNativeApplication
            InitMutationUpdateCloudNativeApplication();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeCustomerSettings.
        internal void ProcessRecord_UpdateCustomerSettings()
        {
            this._logger.name += " -UpdateCustomerSettings";
            // Create new graphql operation updateCloudNativeCustomerSettings
            InitMutationUpdateCloudNativeCustomerSettings();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeIndexingStatus.
        internal void ProcessRecord_UpdateIndexingStatus()
        {
            this._logger.name += " -UpdateIndexingStatus";
            // Create new graphql operation updateCloudNativeIndexingStatus
            InitMutationUpdateCloudNativeIndexingStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeLabelRule.
        internal void ProcessRecord_UpdateLabelRule()
        {
            this._logger.name += " -UpdateLabelRule";
            // Create new graphql operation updateCloudNativeLabelRule
            InitMutationUpdateCloudNativeLabelRule();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeRootThreatMonitoringEnablement.
        internal void ProcessRecord_UpdateRootThreatMonitoringEnablement()
        {
            this._logger.name += " -UpdateRootThreatMonitoringEnablement";
            // Create new graphql operation updateCloudNativeRootThreatMonitoringEnablement
            InitMutationUpdateCloudNativeRootThreatMonitoringEnablement();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeTagRule.
        internal void ProcessRecord_UpdateTagRule()
        {
            this._logger.name += " -UpdateTagRule";
            // Create new graphql operation updateCloudNativeTagRule
            InitMutationUpdateCloudNativeTagRule();
        }


        // Create new GraphQL Mutation:
        // addCloudNativeSqlServerBackupCredentials(input: AddCloudNativeSqlServerBackupCredentialsInput!): AddCloudNativeSqlServerBackupCredentialsReply!
        internal void InitMutationAddCloudNativeSqlServerBackupCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddCloudNativeSqlServerBackupCredentialsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddCloudNativeSqlServerBackupCredentials",
                "($input: AddCloudNativeSqlServerBackupCredentialsInput!)",
                "AddCloudNativeSqlServerBackupCredentialsReply",
                Mutation.AddCloudNativeSqlServerBackupCredentials,
                Mutation.AddCloudNativeSqlServerBackupCredentialsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	objectIds = @(
		$someString
	)
	# REQUIRED
	workloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
	# OPTIONAL
	backupCredentials = @{
		# REQUIRED
		login = $someString
		# REQUIRED
		password = $someString
	}
	# OPTIONAL
	logicAppName = $someString
	# OPTIONAL
	logicAppApiKey = $someString
	# OPTIONAL
	shouldUseAad = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // cloudNativeCheckRbaConnectivity(input: CloudNativeCheckRbaConnectivityInput!): CloudNativeCheckRbaConnectivityReply!
        internal void InitMutationCloudNativeCheckRbaConnectivity()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CloudNativeCheckRbaConnectivityInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCloudNativeCheckRbaConnectivity",
                "($input: CloudNativeCheckRbaConnectivityInput!)",
                "CloudNativeCheckRbaConnectivityReply",
                Mutation.CloudNativeCheckRbaConnectivity,
                Mutation.CloudNativeCheckRbaConnectivityFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // clearCloudNativeSqlServerBackupCredentials(input: ClearCloudNativeSqlServerBackupCredentialsInput!): ClearCloudNativeSqlServerBackupCredentialsReply!
        internal void InitMutationClearCloudNativeSqlServerBackupCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClearCloudNativeSqlServerBackupCredentialsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationClearCloudNativeSqlServerBackupCredentials",
                "($input: ClearCloudNativeSqlServerBackupCredentialsInput!)",
                "ClearCloudNativeSqlServerBackupCredentialsReply",
                Mutation.ClearCloudNativeSqlServerBackupCredentials,
                Mutation.ClearCloudNativeSqlServerBackupCredentialsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	objectIds = @(
		$someString
	)
	# REQUIRED
	workloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeApplication(input: CreateCloudNativeApplicationInput!): CreateCloudNativeApplicationReply!
        internal void InitMutationCreateCloudNativeApplication()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeApplicationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeApplication",
                "($input: CreateCloudNativeApplicationInput!)",
                "CreateCloudNativeApplicationReply",
                Mutation.CreateCloudNativeApplication,
                Mutation.CreateCloudNativeApplicationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	cloudNativeAccountId = $someString
	# REQUIRED
	targetCloudNativeAccountId = $someString
	# REQUIRED
	region = @{
		# OPTIONAL
		region = @{
			# OPTIONAL
			awsRegion = $someAwsCommonRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCommonRegion]) for enum values.
			# OPTIONAL
			azureRegion = $someAzureCommonRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCommonRegion]) for enum values.
			# OPTIONAL
			gcpRegion = $someGcpCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpCloudAccountRegion]) for enum values.
		}
	}
	# REQUIRED
	serviceConfigured = @{
		# OPTIONAL
		configurationEnabled = $someBoolean
		# OPTIONAL
		applicationCloudConfig = @{
			# OPTIONAL
			awsConfig = @{
				# OPTIONAL
				ec2Enabled = $someBoolean
				# OPTIONAL
				rdsEnabled = $someBoolean
				# OPTIONAL
				ebsEnabled = $someBoolean
				# OPTIONAL
				elbEnabled = $someBoolean
				# OPTIONAL
				s3Enabled = $someBoolean
				# OPTIONAL
				secretsEnabled = $someBoolean
				# OPTIONAL
				elasticacheEnabled = $someBoolean
				# OPTIONAL
				eksEnabled = $someBoolean
				# OPTIONAL
				ecrEnabled = $someBoolean
				# OPTIONAL
				lambdaEnabled = $someBoolean
				# OPTIONAL
				isEcsEnabled = $someBoolean
			}
		}
	}
	# REQUIRED
	cloudType = $someCloudServiceProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudServiceProvider]) for enum values.
	# OPTIONAL
	resourceInclusionList = @(
		$someString
	)
	# OPTIONAL
	resourceExclusionList = @(
		$someString
	)
	# OPTIONAL
	matchingTags = @{
		# REQUIRED
		matchingTagsList = @(
			@{
				# OPTIONAL
				key = $someString
				# OPTIONAL
				value = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeLabelRule(input: CreateCloudNativeLabelRuleInput!): CreateCloudNativeLabelRuleReply!
        internal void InitMutationCreateCloudNativeLabelRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeLabelRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeLabelRule",
                "($input: CreateCloudNativeLabelRuleInput!)",
                "CreateCloudNativeLabelRuleReply",
                Mutation.CreateCloudNativeLabelRule,
                Mutation.CreateCloudNativeLabelRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values.
	# REQUIRED
	labelRuleName = $someString
	# OPTIONAL
	label = @{
		# REQUIRED
		labelKey = $someString
		# REQUIRED
		labelValue = $someString
		# REQUIRED
		matchAllValues = $someBoolean
	}
	# OPTIONAL
	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
	# OPTIONAL
	slaId = $someString
	# OPTIONAL
	cloudNativeAccountIds = @{
		# OPTIONAL
		awsNativeAccountIds = @(
			$someString
		)
		# OPTIONAL
		azureNativeSubscriptionIds = @(
			$someString
		)
		# OPTIONAL
		gcpNativeProjectIds = @(
			$someString
		)
	}
	# OPTIONAL
	applyToAllCloudAccounts = $someBoolean
	# OPTIONAL
	labelConditions = @{
		# REQUIRED
		tagPairs = @(
			@{
				# REQUIRED
				key = $someString
				# REQUIRED
				values = @(
					$someString
				)
				# REQUIRED
				matchAllTagValues = $someBoolean
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeTagRule(input: CreateCloudNativeTagRuleInput!): CreateCloudNativeTagRuleReply!
        internal void InitMutationCreateCloudNativeTagRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeTagRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeTagRule",
                "($input: CreateCloudNativeTagRuleInput!)",
                "CreateCloudNativeTagRuleReply",
                Mutation.CreateCloudNativeTagRule,
                Mutation.CreateCloudNativeTagRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values.
	# REQUIRED
	tagRuleName = $someString
	# OPTIONAL
	tag = @{
		# REQUIRED
		tagKey = $someString
		# REQUIRED
		tagValue = $someString
		# REQUIRED
		matchAllValues = $someBoolean
	}
	# OPTIONAL
	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
	# OPTIONAL
	slaId = $someString
	# OPTIONAL
	cloudNativeAccountIds = @{
		# OPTIONAL
		awsNativeAccountIds = @(
			$someString
		)
		# OPTIONAL
		azureNativeSubscriptionIds = @(
			$someString
		)
		# OPTIONAL
		gcpNativeProjectIds = @(
			$someString
		)
	}
	# OPTIONAL
	applyToAllCloudAccounts = $someBoolean
	# OPTIONAL
	tagConditions = @{
		# REQUIRED
		tagPairs = @(
			@{
				# REQUIRED
				key = $someString
				# REQUIRED
				values = @(
					$someString
				)
				# REQUIRED
				matchAllTagValues = $someBoolean
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteCloudNativeApplication(input: DeleteCloudNativeApplicationInput!): Void
        internal void InitMutationDeleteCloudNativeApplication()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteCloudNativeApplicationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCloudNativeApplication",
                "($input: DeleteCloudNativeApplicationInput!)",
                "System.String",
                Mutation.DeleteCloudNativeApplication,
                Mutation.DeleteCloudNativeApplicationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteCloudNativeLabelRule(input: DeleteCloudNativeLabelRuleInput!): Void
        internal void InitMutationDeleteCloudNativeLabelRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteCloudNativeLabelRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCloudNativeLabelRule",
                "($input: DeleteCloudNativeLabelRuleInput!)",
                "System.String",
                Mutation.DeleteCloudNativeLabelRule,
                Mutation.DeleteCloudNativeLabelRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ruleId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteCloudNativeTagRule(input: DeleteCloudNativeTagRuleInput!): Void
        internal void InitMutationDeleteCloudNativeTagRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteCloudNativeTagRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCloudNativeTagRule",
                "($input: DeleteCloudNativeTagRuleInput!)",
                "System.String",
                Mutation.DeleteCloudNativeTagRule,
                Mutation.DeleteCloudNativeTagRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ruleId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // cloudNativeDownloadFiles(input: CloudNativeDownloadFilesInput!): DownloadFilesReply!
        internal void InitMutationCloudNativeDownloadFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CloudNativeDownloadFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCloudNativeDownloadFiles",
                "($input: CloudNativeDownloadFilesInput!)",
                "DownloadFilesReply",
                Mutation.CloudNativeDownloadFiles,
                Mutation.CloudNativeDownloadFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	filePaths = @(
		$someString
	)
	# OPTIONAL
	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
	# REQUIRED
	fileRecoveryLocationDetails = @{
		# OPTIONAL
		cloudDownloadLocationDetails = @{
			# REQUIRED
			downloadLocation = $someString
			# REQUIRED
			createDownloadLocation = $someBoolean
			# OPTIONAL
			tags = @(
				@{
					# REQUIRED
					tagKey = $someString
					# REQUIRED
					tagValue = $someString
					# REQUIRED
					matchAllValues = $someBoolean
				}
			)
		}
		# OPTIONAL
		vmDownloadLocationDetails = @{
			# REQUIRED
			id = $someString
			# OPTIONAL
			pathToRecover = $someString
		}
	}
	# REQUIRED
	downloadType = $someFileDownloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileDownloadType]) for enum values.
	# OPTIONAL
	exocomputeCloudNativeAccountId = $someString
	# OPTIONAL
	exocomputeRegion = $someString
	# OPTIONAL
	archivedSnapshotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // recoverCloudNativeApplication(input: RecoverCloudNativeApplicationInput!): RecoverCloudNativeApplicationReply!
        internal void InitMutationRecoverCloudNativeApplication()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverCloudNativeApplicationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverCloudNativeApplication",
                "($input: RecoverCloudNativeApplicationInput!)",
                "RecoverCloudNativeApplicationReply",
                Mutation.RecoverCloudNativeApplication,
                Mutation.RecoverCloudNativeApplicationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	applicationId = $someString
	# REQUIRED
	targetCloudNativeAccountId = $someString
	# REQUIRED
	recoveryName = $someString
	# REQUIRED
	errorHandling = $someRecoveryErrorHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoveryErrorHandling]) for enum values.
	# OPTIONAL
	workloadSnapshots = @(
		@{
			# REQUIRED
			workloadId = $someString
			# OPTIONAL
			snapshotId = $someString
		}
	)
	# OPTIONAL
	preRecoveryHook = @{
		# REQUIRED
		hookInfo = @{
			# OPTIONAL
			hook = @{
				# OPTIONAL
				awsLambda = @{
					# REQUIRED
					lambdaId = $someString
				}
			}
		}
		# REQUIRED
		failureHandling = $someHookFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HookFailureHandling]) for enum values.
	}
	# OPTIONAL
	postRecoveryHook = @{
		# REQUIRED
		hookInfo = @{
			# OPTIONAL
			hook = @{
				# OPTIONAL
				awsLambda = @{
					# REQUIRED
					lambdaId = $someString
				}
			}
		}
		# REQUIRED
		failureHandling = $someHookFailureHandling # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HookFailureHandling]) for enum values.
	}
	# OPTIONAL
	vmPostRecoveryScriptEnabled = $someBoolean
	# OPTIONAL
	cloudSettings = @{
		# OPTIONAL
		awsSettings = @{
			# OPTIONAL
			networking = @{
				# OPTIONAL
				vpcOption = @{
					# OPTIONAL
					cloneVpcSameCidr = @{
						# OPTIONAL
						preserveCidr = $someBoolean
					}
					# OPTIONAL
					cloneVpcAlternateCidr = @{
						# REQUIRED
						vpcCidrMappings = @(
							@{
								# REQUIRED
								sourceVpcId = $someString
								# REQUIRED
								cidrMappings = @(
									@{
										# REQUIRED
										sourceCidr = $someString
										# REQUIRED
										targetCidr = $someString
									}
								)
							}
						)
					}
					# OPTIONAL
					useExistingVpc = @{
						# REQUIRED
						vpcIdMappings = @(
							@{
								# REQUIRED
								sourceVpcId = $someString
								# REQUIRED
								targetVpcId = $someString
							}
						)
					}
				}
			}
			# OPTIONAL
			kms = @{
				# REQUIRED
				kmsKeyId = $someString
			}
			# OPTIONAL
			dns = @{
				# OPTIONAL
				shouldUpdateDns = $someBoolean
			}
			# OPTIONAL
			s3 = @{
				# OPTIONAL
				buckets = @(
					@{
						# REQUIRED
						workloadId = $someString
						# OPTIONAL
						shouldRecoverFullBucket = $someBoolean
						# OPTIONAL
						regexPatterns = @(
							$someString
						)
						# OPTIONAL
						destination = @{
							# OPTIONAL
							existingBucket = @{
								# REQUIRED
								destinationBucketArn = $someString
							}
							# OPTIONAL
							newBucket = @{
								# REQUIRED
								destinationBucketName = $someString
							}
						}
					}
				)
			}
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshCloudNativeApplication(input: RefreshCloudNativeApplicationInput!): RefreshCloudNativeApplicationReply!
        internal void InitMutationRefreshCloudNativeApplication()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshCloudNativeApplicationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshCloudNativeApplication",
                "($input: RefreshCloudNativeApplicationInput!)",
                "RefreshCloudNativeApplicationReply",
                Mutation.RefreshCloudNativeApplication,
                Mutation.RefreshCloudNativeApplicationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	cloud = $someCloudServiceProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudServiceProvider]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // setCloudNativeGatewayKmsKeys(input: SetCloudNativeGatewayKmsKeysInput!): Void
        internal void InitMutationSetCloudNativeGatewayKmsKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetCloudNativeGatewayKmsKeysInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetCloudNativeGatewayKmsKeys",
                "($input: SetCloudNativeGatewayKmsKeysInput!)",
                "System.String",
                Mutation.SetCloudNativeGatewayKmsKeys,
                Mutation.SetCloudNativeGatewayKmsKeysFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	gatewayKmsKeyMap = @{
		# REQUIRED
		gatewayKmsKeyMapList = @(
			@{
				# OPTIONAL
				region = $someString
				# OPTIONAL
				kmsKeyArn = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // setupCloudNativeSqlServerBackup(input: SetupCloudNativeSqlServerBackupInput!): BatchAsyncJobStatus!
        internal void InitMutationSetupCloudNativeSqlServerBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetupCloudNativeSqlServerBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetupCloudNativeSqlServerBackup",
                "($input: SetupCloudNativeSqlServerBackupInput!)",
                "BatchAsyncJobStatus",
                Mutation.SetupCloudNativeSqlServerBackup,
                Mutation.SetupCloudNativeSqlServerBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	databaseIds = @(
		$someString
	)
	# OPTIONAL
	adminCredentials = @{
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
	serverIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startCloudNativeSnapshotsIndexJob(input: StartCloudNativeSnapshotsIndexJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartCloudNativeSnapshotsIndexJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCloudNativeSnapshotsIndexJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCloudNativeSnapshotsIndexJob",
                "($input: StartCloudNativeSnapshotsIndexJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCloudNativeSnapshotsIndexJob,
                Mutation.StartCloudNativeSnapshotsIndexJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeApplication(input: UpdateCloudNativeApplicationInput!): UpdateCloudNativeApplicationReply!
        internal void InitMutationUpdateCloudNativeApplication()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeApplicationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeApplication",
                "($input: UpdateCloudNativeApplicationInput!)",
                "UpdateCloudNativeApplicationReply",
                Mutation.UpdateCloudNativeApplication,
                Mutation.UpdateCloudNativeApplicationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	targetCloudNativeAccountId = $someString
	# OPTIONAL
	serviceConfigured = @{
		# OPTIONAL
		configurationEnabled = $someBoolean
		# OPTIONAL
		applicationCloudConfig = @{
			# OPTIONAL
			awsConfig = @{
				# OPTIONAL
				ec2Enabled = $someBoolean
				# OPTIONAL
				rdsEnabled = $someBoolean
				# OPTIONAL
				ebsEnabled = $someBoolean
				# OPTIONAL
				elbEnabled = $someBoolean
				# OPTIONAL
				s3Enabled = $someBoolean
				# OPTIONAL
				secretsEnabled = $someBoolean
				# OPTIONAL
				elasticacheEnabled = $someBoolean
				# OPTIONAL
				eksEnabled = $someBoolean
				# OPTIONAL
				ecrEnabled = $someBoolean
				# OPTIONAL
				lambdaEnabled = $someBoolean
				# OPTIONAL
				isEcsEnabled = $someBoolean
			}
		}
	}
	# OPTIONAL
	postRecoveryScriptConfigured = $someBoolean
	# OPTIONAL
	resourceInclusionList = @{
		# OPTIONAL
		uris = @(
			$someString
		)
	}
	# OPTIONAL
	resourceExclusionList = @{
		# OPTIONAL
		uris = @(
			$someString
		)
	}
	# OPTIONAL
	matchingTags = @{
		# REQUIRED
		matchingTagsList = @(
			@{
				# OPTIONAL
				key = $someString
				# OPTIONAL
				value = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeCustomerSettings(input: UpdateCloudNativeCustomerSettingsInput!): UpdateCloudNativeCustomerSettingsReply!
        internal void InitMutationUpdateCloudNativeCustomerSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeCustomerSettingsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeCustomerSettings",
                "($input: UpdateCloudNativeCustomerSettingsInput!)",
                "UpdateCloudNativeCustomerSettingsReply",
                Mutation.UpdateCloudNativeCustomerSettings,
                Mutation.UpdateCloudNativeCustomerSettingsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	settings = @{
		# OPTIONAL
		isS3GlacierIrTierEnabled = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeIndexingStatus(input: UpdateCloudNativeIndexingStatusInput!): UpdateCloudNativeIndexingStatusReply!
        internal void InitMutationUpdateCloudNativeIndexingStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeIndexingStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeIndexingStatus",
                "($input: UpdateCloudNativeIndexingStatusInput!)",
                "UpdateCloudNativeIndexingStatusReply",
                Mutation.UpdateCloudNativeIndexingStatus,
                Mutation.UpdateCloudNativeIndexingStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadIds = @(
		$someString
	)
	# REQUIRED
	isIndexingEnabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeLabelRule(input: UpdateCloudNativeLabelRuleInput!): Void
        internal void InitMutationUpdateCloudNativeLabelRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeLabelRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeLabelRule",
                "($input: UpdateCloudNativeLabelRuleInput!)",
                "System.String",
                Mutation.UpdateCloudNativeLabelRule,
                Mutation.UpdateCloudNativeLabelRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	labelRuleId = $someString
	# REQUIRED
	labelRuleName = $someString
	# OPTIONAL
	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
	# OPTIONAL
	slaId = $someString
	# OPTIONAL
	cloudNativeAccountIds = @{
		# OPTIONAL
		awsNativeAccountIds = @(
			$someString
		)
		# OPTIONAL
		azureNativeSubscriptionIds = @(
			$someString
		)
		# OPTIONAL
		gcpNativeProjectIds = @(
			$someString
		)
	}
	# OPTIONAL
	applyToAllCloudAccounts = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeRootThreatMonitoringEnablement(input: UpdateCloudNativeRootThreatMonitoringEnablementInput!): Void
        internal void InitMutationUpdateCloudNativeRootThreatMonitoringEnablement()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeRootThreatMonitoringEnablementInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeRootThreatMonitoringEnablement",
                "($input: UpdateCloudNativeRootThreatMonitoringEnablementInput!)",
                "System.String",
                Mutation.UpdateCloudNativeRootThreatMonitoringEnablement,
                Mutation.UpdateCloudNativeRootThreatMonitoringEnablementFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	isEnabled = $someBoolean
	# REQUIRED
	rootIds = @(
		$someString
	)
	# OPTIONAL
	shouldScanAllFiles = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeTagRule(input: UpdateCloudNativeTagRuleInput!): Void
        internal void InitMutationUpdateCloudNativeTagRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeTagRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeTagRule",
                "($input: UpdateCloudNativeTagRuleInput!)",
                "System.String",
                Mutation.UpdateCloudNativeTagRule,
                Mutation.UpdateCloudNativeTagRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	tagRuleId = $someString
	# REQUIRED
	tagRuleName = $someString
	# OPTIONAL
	slaAssignType = $someTagRuleSlaAssignType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagRuleSlaAssignType]) for enum values.
	# OPTIONAL
	slaId = $someString
	# OPTIONAL
	cloudNativeAccountIds = @{
		# OPTIONAL
		awsNativeAccountIds = @(
			$someString
		)
		# OPTIONAL
		azureNativeSubscriptionIds = @(
			$someString
		)
		# OPTIONAL
		gcpNativeProjectIds = @(
			$someString
		)
	}
	# OPTIONAL
	applyToAllCloudAccounts = $someBoolean
}"
            );
        }


    } // class New_RscMutationCloudNative
}