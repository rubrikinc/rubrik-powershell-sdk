// New-RscMutationPolicy.cs
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
    /// operations in the 'Policy' API domain:
    /// AddPolicyObjects, BulkUpdatePolicyViolations, CreatePolicy, CreateSecurityPolicy, CreateTprPolicy, DeactivatePolicy, DeleteSecurityPolicy, DeleteTprPolicy, ExportPolicyViolationsCsv, FailoverHaPolicy, GetHealthMonitorPolicyStatus, RemovePolicyObjects, SeedEnabledPolicies, SeedInitialPolicies, SetPasswordComplexityPolicy, UpdateAutoEnablePolicyClusterConfig, UpdateHealthMonitorPolicyStatus, UpdateOrgSecurityPolicy, UpdatePolicy, UpdateSecurityPolicy, or UpdateTprPolicy.
    /// </summary>
    /// <description>
    /// New-RscMutationPolicy creates a new
    /// mutation object for operations
    /// in the 'Policy' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 21 operations
    /// in the 'Policy' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddPolicyObjects, BulkUpdatePolicyViolations, CreatePolicy, CreateSecurityPolicy, CreateTprPolicy, DeactivatePolicy, DeleteSecurityPolicy, DeleteTprPolicy, ExportPolicyViolationsCsv, FailoverHaPolicy, GetHealthMonitorPolicyStatus, RemovePolicyObjects, SeedEnabledPolicies, SeedInitialPolicies, SetPasswordComplexityPolicy, UpdateAutoEnablePolicyClusterConfig, UpdateHealthMonitorPolicyStatus, UpdateOrgSecurityPolicy, UpdatePolicy, UpdateSecurityPolicy, or UpdateTprPolicy.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationPolicy -AddPolicyObjects).Info().
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
    /// (New-RscMutationPolicy -AddPolicyObjects).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddPolicyObjects operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: AddPolicyObjects
    /// 
    /// $query = New-RscMutationPolicy -Operation AddPolicyObjects
    /// 
    /// # REQUIRED
    /// $query.Var.policyIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.objectIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.objectRootIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.clusterIds = @(
    /// 	$someString
    /// )
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
    /// Runs the BulkUpdatePolicyViolations operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: BulkUpdatePolicyViolations
    /// 
    /// $query = New-RscMutationPolicy -Operation BulkUpdatePolicyViolations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	policyViolationIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	newPolicyViolationStatus = $somePolicyViolationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationStatus]) for enum values.
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
    /// Runs the CreatePolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: CreatePolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation CreatePolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	colorEnum = $someClassificationPolicyColor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyColor]) for enum values.
    /// 	# OPTIONAL
    /// 	mode = $someClassificationPolicyMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyMode]) for enum values.
    /// 	# OPTIONAL
    /// 	analyzerIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	documentTypeIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	updateName = $someBoolean
    /// 	# OPTIONAL
    /// 	updateDescription = $someBoolean
    /// 	# OPTIONAL
    /// 	updateMode = $someBoolean
    /// 	# OPTIONAL
    /// 	updateAnalyzerIds = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClassificationPolicyDetail
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateSecurityPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: CreateSecurityPolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation CreateSecurityPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	policyName = $someString
    /// 	# REQUIRED
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// 	# REQUIRED
    /// 	filter = @{
    /// 		# REQUIRED
    /// 		filterList = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterConfig = @{
    /// 					# REQUIRED
    /// 					filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
    /// 					# REQUIRED
    /// 					values = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				filterGroupConfig = @{
    /// 					# REQUIRED
    /// 					filterList = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							filterConfig = @{
    /// 								# REQUIRED
    /// 								filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
    /// 								# REQUIRED
    /// 								values = @(
    /// 									$someString
    /// 								)
    /// 								# REQUIRED
    /// 								relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
    /// 							}
    /// 							# OPTIONAL
    /// 							filterGroupConfig = @{<FilterGroupConfigInput>}
    /// 						}
    /// 					)
    /// 					# REQUIRED
    /// 					logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
    /// 				}
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	policySeverity = $someSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Severity]) for enum values.
    /// 	# OPTIONAL
    /// 	policyCategory = $someCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Category]) for enum values.
    /// 	# OPTIONAL
    /// 	isAutomationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	automationRules = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			action = @{
    /// 				# REQUIRED
    /// 				remediationType = $someRemediationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationType]) for enum values.
    /// 				# OPTIONAL
    /// 				remediationDetails = @{
    /// 					# OPTIONAL
    /// 					ticketInfo = @{
    /// 						# OPTIONAL
    /// 						title = $someString
    /// 						# OPTIONAL
    /// 						reason = $someString
    /// 						# OPTIONAL
    /// 						attachmentTypes = @(
    /// 							$someRemediationTicketAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationTicketAttachmentType]) for enum values.
    /// 						)
    /// 						# OPTIONAL
    /// 						comment = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					mipLabelInfo = @{
    /// 						# OPTIONAL
    /// 						labelId = $someString
    /// 						# OPTIONAL
    /// 						allowDowngrade = $someBoolean
    /// 						# OPTIONAL
    /// 						labelName = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					adIrInfo = @{
    /// 						# OPTIONAL
    /// 						domainControllerFid = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					ticketDetails = @{
    /// 						# REQUIRED
    /// 						ticketContents = @{
    /// 							# OPTIONAL
    /// 							title = $someString
    /// 							# OPTIONAL
    /// 							description = $someString
    /// 							# OPTIONAL
    /// 							comment = $someString
    /// 							# OPTIONAL
    /// 							projectKey = $someString
    /// 							# OPTIONAL
    /// 							ticketTypeId = $someString
    /// 							# OPTIONAL
    /// 							requiredFields = @(
    /// 								@{
    /// 									# OPTIONAL
    /// 									fieldKey = $someString
    /// 									# REQUIRED
    /// 									fieldValue = @{
    /// 										# REQUIRED
    /// 										fieldType = $someTicketFieldType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketFieldType]) for enum values.
    /// 										# OPTIONAL
    /// 										stringValue = $someString
    /// 										# OPTIONAL
    /// 										numberValue = $someInt64
    /// 										# OPTIONAL
    /// 										optionValue = $someString
    /// 										# OPTIONAL
    /// 										multiOptionValues = @{
    /// 											# REQUIRED
    /// 											values = @(
    /// 												$someString
    /// 											)
    /// 										}
    /// 										# OPTIONAL
    /// 										arrayValues = @{
    /// 											# REQUIRED
    /// 											values = @(
    /// 												$someString
    /// 											)
    /// 										}
    /// 										# OPTIONAL
    /// 										userValue = $someString
    /// 										# OPTIONAL
    /// 										dateValue = $someString
    /// 										# OPTIONAL
    /// 										datetimeValue = $someString
    /// 										# OPTIONAL
    /// 										booleanValue = $someBoolean
    /// 										# OPTIONAL
    /// 										textAreaValue = $someString
    /// 									}
    /// 								}
    /// 							)
    /// 						}
    /// 						# OPTIONAL
    /// 						attachmentTypes = @(
    /// 							$someRemediationTicketAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationTicketAttachmentType]) for enum values.
    /// 						)
    /// 					}
    /// 				}
    /// 			}
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	thresholdFilter = @{
    /// 		# REQUIRED
    /// 		filterList = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterConfig = @{
    /// 					# REQUIRED
    /// 					filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
    /// 					# REQUIRED
    /// 					values = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				filterGroupConfig = @{
    /// 					# REQUIRED
    /// 					filterList = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							filterConfig = @{
    /// 								# REQUIRED
    /// 								filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
    /// 								# REQUIRED
    /// 								values = @(
    /// 									$someString
    /// 								)
    /// 								# REQUIRED
    /// 								relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
    /// 							}
    /// 							# OPTIONAL
    /// 							filterGroupConfig = @{<FilterGroupConfigInput>}
    /// 						}
    /// 					)
    /// 					# REQUIRED
    /// 					logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
    /// 				}
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	policyTypeInfo = @{
    /// 		# OPTIONAL
    /// 		identityEventPolicyInfo = @{
    /// 			# OPTIONAL
    /// 			eventProviders = @(
    /// 				$someEventProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventProvider]) for enum values.
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		identityPolicyInfo = @{
    /// 			# OPTIONAL
    /// 			idpType = @(
    /// 				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		idpPolicyInfo = @{
    /// 			# OPTIONAL
    /// 			idpType = @(
    /// 				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		signinAnomalyPolicyInfo = @{
    /// 			# OPTIONAL
    /// 			idpType = @(
    /// 				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
    /// 			)
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	frameworks = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateSecurityPolicyReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateTprPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: CreateTprPolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation CreateTprPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	policyScope = $someTprPolicyScope # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprPolicyScope]) for enum values.
    /// 	# REQUIRED
    /// 	policyRules = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			tprPolicyObject = @{
    /// 				# REQUIRED
    /// 				objectId = $someString
    /// 				# REQUIRED
    /// 				managedObjectType = $someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 				# REQUIRED
    /// 				workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 				# REQUIRED
    /// 				clusterId = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			tprRules = @(
    /// 				$someTprRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprRule]) for enum values.
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	exemptServiceAccounts = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	quorumRequirement = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateTprPolicyReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeactivatePolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: DeactivatePolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation DeactivatePolicy
    /// 
    /// # REQUIRED
    /// $query.Var.policyId = $someString
    /// # REQUIRED
    /// $query.Var.runAsync = $someBoolean
    /// # OPTIONAL
    /// $query.Var.disableDataCategory = $someBoolean
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
    /// Runs the DeleteSecurityPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: DeleteSecurityPolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation DeleteSecurityPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.policyId = $someString
    /// # REQUIRED
    /// $query.Var.policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.keepViolationsOpenArg = $someBoolean
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
    /// Runs the DeleteTprPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: DeleteTprPolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation DeleteTprPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	policyId = $someString
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
    /// Runs the ExportPolicyViolationsCsv operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: ExportPolicyViolationsCsv
    /// 
    /// $query = New-RscMutationPolicy -Operation ExportPolicyViolationsCsv
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	filter = @{
    /// 		# OPTIONAL
    /// 		policyIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		resourceIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		statuses = @(
    /// 			$somePolicyViolationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationStatus]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		policyViolationIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		resourceTypes = @(
    /// 			$somePolicyResourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyResourceType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		sensitivityLevels = @(
    /// 			$someSensitivityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SensitivityLevel]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		detectionDateRange = @{
    /// 			# OPTIONAL
    /// 			start = $someDateTime
    /// 			# OPTIONAL
    /// 			end = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		updateDateRange = @{
    /// 			# OPTIONAL
    /// 			start = $someDateTime
    /// 			# OPTIONAL
    /// 			end = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		resourceType = $somePolicyResourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyResourceType]) for enum values.
    /// 		# OPTIONAL
    /// 		parentViolationId = $someString
    /// 		# OPTIONAL
    /// 		dataCategoryIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		dataTypeIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		documentTypeIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		originId = $someString
    /// 		# OPTIONAL
    /// 		originIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		policyViolationNameSearch = $someString
    /// 		# OPTIONAL
    /// 		statusReasons = @(
    /// 			$somePolicyViolationStatusReason # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationStatusReason]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		ticketNumbers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		violationNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	policyFilters = @{
    /// 		# OPTIONAL
    /// 		policySeverities = @(
    /// 			$someViolationSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ViolationSeverity]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		policyCategories = @(
    /// 			$someCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Category]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		policyTypes = @(
    /// 			$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		includeDeletedPolicies = $someBoolean
    /// 		# OPTIONAL
    /// 		policyFrameworks = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	resourceMetadataFilters = @{
    /// 		# OPTIONAL
    /// 		objectTypes = @(
    /// 			$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		cloudAccountIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		managedObjectTypes = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		principalTypes = @(
    /// 			$someViolationPrincipalType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ViolationPrincipalType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		resolutionTypes = @(
    /// 			$someIdentityResolutionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdentityResolutionType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		domainFids = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		identityNameSearch = $someString
    /// 		# OPTIONAL
    /// 		accessTypes = @(
    /// 			$someAccessVia # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessVia]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		sources = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		idpTypes = @(
    /// 			$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		originEventDateRange = @{
    /// 			# REQUIRED
    /// 			start = $someDateTime
    /// 			# REQUIRED
    /// 			end = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		identityTags = @(
    /// 			$someIdentityTag # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdentityTag]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		actorIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		identityOrigins = @(
    /// 			$somePrincipalOrigin # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrincipalOrigin]) for enum values.
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	columns = @(
    /// 		$somePolicyViolationCsvColumn # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationCsvColumn]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	groupBy = $somePolicyViolationGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationGroupBy]) for enum values.
    /// 	# REQUIRED
    /// 	policyTypes = @(
    /// 		$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	sortField = $somePolicyViolationSortField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationSortField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ExportPolicyViolationsCsvReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FailoverHaPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: FailoverHaPolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation FailoverHaPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	failoverType = $someFlexmotionFailoverType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FlexmotionFailoverType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetHealthMonitorPolicyStatus operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: GetHealthMonitorPolicyStatus
    /// 
    /// $query = New-RscMutationPolicy -Operation GetHealthMonitorPolicyStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	hasDetailedStatus = $someBoolean
    /// 	# OPTIONAL
    /// 	nodeIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	policyIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetHealthMonitorPolicyStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemovePolicyObjects operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: RemovePolicyObjects
    /// 
    /// $query = New-RscMutationPolicy -Operation RemovePolicyObjects
    /// 
    /// # REQUIRED
    /// $query.Var.policyIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.objectIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.objectRootIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.clusterIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.runAsync = $someBoolean
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
    /// Runs the SeedEnabledPolicies operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: SeedEnabledPolicies
    /// 
    /// $query = New-RscMutationPolicy -Operation SeedEnabledPolicies
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SeedEnabledPoliciesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SeedInitialPolicies operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: SeedInitialPolicies
    /// 
    /// $query = New-RscMutationPolicy -Operation SeedInitialPolicies
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SeedInitialPoliciesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetPasswordComplexityPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: SetPasswordComplexityPolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation SetPasswordComplexityPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	policy = @{
    /// 		# REQUIRED
    /// 		lengthPolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 		}
    /// 		# REQUIRED
    /// 		lowercasePolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 		}
    /// 		# REQUIRED
    /// 		uppercasePolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 		}
    /// 		# REQUIRED
    /// 		specialCharsPolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 		}
    /// 		# REQUIRED
    /// 		numericPolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 		}
    /// 		# REQUIRED
    /// 		passwordReusePolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 		}
    /// 		# REQUIRED
    /// 		passwordExpirationPolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 		}
    /// 		# OPTIONAL
    /// 		leakedDetectionPolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	shouldResetAllOrgUsersPasswords = $someBoolean
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
    /// Runs the UpdateAutoEnablePolicyClusterConfig operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: UpdateAutoEnablePolicyClusterConfig
    /// 
    /// $query = New-RscMutationPolicy -Operation UpdateAutoEnablePolicyClusterConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterId = $someString
    /// 	# OPTIONAL
    /// 	enabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateAutoEnablePolicyClusterConfigReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateHealthMonitorPolicyStatus operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: UpdateHealthMonitorPolicyStatus
    /// 
    /// $query = New-RscMutationPolicy -Operation UpdateHealthMonitorPolicyStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	runRequest = @{
    /// 		# OPTIONAL
    /// 		nodeIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		policyIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateHealthMonitorPolicyStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateOrgSecurityPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: UpdateOrgSecurityPolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation UpdateOrgSecurityPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	disallowWeakerPolicy = $someBoolean
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
    /// Runs the UpdatePolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: UpdatePolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation UpdatePolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	colorEnum = $someClassificationPolicyColor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyColor]) for enum values.
    /// 	# OPTIONAL
    /// 	mode = $someClassificationPolicyMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyMode]) for enum values.
    /// 	# OPTIONAL
    /// 	analyzerIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	documentTypeIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	updateName = $someBoolean
    /// 	# OPTIONAL
    /// 	updateDescription = $someBoolean
    /// 	# OPTIONAL
    /// 	updateMode = $someBoolean
    /// 	# OPTIONAL
    /// 	updateAnalyzerIds = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClassificationPolicyDetail
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateSecurityPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: UpdateSecurityPolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation UpdateSecurityPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	policyId = $someString
    /// 	# REQUIRED
    /// 	policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// 	# OPTIONAL
    /// 	filter = @{
    /// 		# REQUIRED
    /// 		filterList = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterConfig = @{
    /// 					# REQUIRED
    /// 					filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
    /// 					# REQUIRED
    /// 					values = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				filterGroupConfig = @{
    /// 					# REQUIRED
    /// 					filterList = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							filterConfig = @{
    /// 								# REQUIRED
    /// 								filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
    /// 								# REQUIRED
    /// 								values = @(
    /// 									$someString
    /// 								)
    /// 								# REQUIRED
    /// 								relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
    /// 							}
    /// 							# OPTIONAL
    /// 							filterGroupConfig = @{<FilterGroupConfigInput>}
    /// 						}
    /// 					)
    /// 					# REQUIRED
    /// 					logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
    /// 				}
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	isEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	policyName = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	policySeverity = $someSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Severity]) for enum values.
    /// 	# OPTIONAL
    /// 	policyCategory = $someCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Category]) for enum values.
    /// 	# OPTIONAL
    /// 	isAutomationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	automationRules = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			action = @{
    /// 				# REQUIRED
    /// 				remediationType = $someRemediationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationType]) for enum values.
    /// 				# OPTIONAL
    /// 				remediationDetails = @{
    /// 					# OPTIONAL
    /// 					ticketInfo = @{
    /// 						# OPTIONAL
    /// 						title = $someString
    /// 						# OPTIONAL
    /// 						reason = $someString
    /// 						# OPTIONAL
    /// 						attachmentTypes = @(
    /// 							$someRemediationTicketAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationTicketAttachmentType]) for enum values.
    /// 						)
    /// 						# OPTIONAL
    /// 						comment = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					mipLabelInfo = @{
    /// 						# OPTIONAL
    /// 						labelId = $someString
    /// 						# OPTIONAL
    /// 						allowDowngrade = $someBoolean
    /// 						# OPTIONAL
    /// 						labelName = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					adIrInfo = @{
    /// 						# OPTIONAL
    /// 						domainControllerFid = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					ticketDetails = @{
    /// 						# REQUIRED
    /// 						ticketContents = @{
    /// 							# OPTIONAL
    /// 							title = $someString
    /// 							# OPTIONAL
    /// 							description = $someString
    /// 							# OPTIONAL
    /// 							comment = $someString
    /// 							# OPTIONAL
    /// 							projectKey = $someString
    /// 							# OPTIONAL
    /// 							ticketTypeId = $someString
    /// 							# OPTIONAL
    /// 							requiredFields = @(
    /// 								@{
    /// 									# OPTIONAL
    /// 									fieldKey = $someString
    /// 									# REQUIRED
    /// 									fieldValue = @{
    /// 										# REQUIRED
    /// 										fieldType = $someTicketFieldType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketFieldType]) for enum values.
    /// 										# OPTIONAL
    /// 										stringValue = $someString
    /// 										# OPTIONAL
    /// 										numberValue = $someInt64
    /// 										# OPTIONAL
    /// 										optionValue = $someString
    /// 										# OPTIONAL
    /// 										multiOptionValues = @{
    /// 											# REQUIRED
    /// 											values = @(
    /// 												$someString
    /// 											)
    /// 										}
    /// 										# OPTIONAL
    /// 										arrayValues = @{
    /// 											# REQUIRED
    /// 											values = @(
    /// 												$someString
    /// 											)
    /// 										}
    /// 										# OPTIONAL
    /// 										userValue = $someString
    /// 										# OPTIONAL
    /// 										dateValue = $someString
    /// 										# OPTIONAL
    /// 										datetimeValue = $someString
    /// 										# OPTIONAL
    /// 										booleanValue = $someBoolean
    /// 										# OPTIONAL
    /// 										textAreaValue = $someString
    /// 									}
    /// 								}
    /// 							)
    /// 						}
    /// 						# OPTIONAL
    /// 						attachmentTypes = @(
    /// 							$someRemediationTicketAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationTicketAttachmentType]) for enum values.
    /// 						)
    /// 					}
    /// 				}
    /// 			}
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	thresholdFilter = @{
    /// 		# REQUIRED
    /// 		filterList = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterConfig = @{
    /// 					# REQUIRED
    /// 					filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
    /// 					# REQUIRED
    /// 					values = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				filterGroupConfig = @{
    /// 					# REQUIRED
    /// 					filterList = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							filterConfig = @{
    /// 								# REQUIRED
    /// 								filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
    /// 								# REQUIRED
    /// 								values = @(
    /// 									$someString
    /// 								)
    /// 								# REQUIRED
    /// 								relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
    /// 							}
    /// 							# OPTIONAL
    /// 							filterGroupConfig = @{<FilterGroupConfigInput>}
    /// 						}
    /// 					)
    /// 					# REQUIRED
    /// 					logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
    /// 				}
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	keepViolationsOpen = $someBoolean
    /// 	# OPTIONAL
    /// 	frameworks = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	policyTypeInfo = @{
    /// 		# OPTIONAL
    /// 		identityEventPolicyInfo = @{
    /// 			# OPTIONAL
    /// 			eventProviders = @(
    /// 				$someEventProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventProvider]) for enum values.
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		identityPolicyInfo = @{
    /// 			# OPTIONAL
    /// 			idpType = @(
    /// 				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		idpPolicyInfo = @{
    /// 			# OPTIONAL
    /// 			idpType = @(
    /// 				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		signinAnomalyPolicyInfo = @{
    /// 			# OPTIONAL
    /// 			idpType = @(
    /// 				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
    /// 			)
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	forceUpdateThresholdFilter = $someBoolean
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
    /// Runs the UpdateTprPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: UpdateTprPolicy
    /// 
    /// $query = New-RscMutationPolicy -Operation UpdateTprPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	policyId = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	policyRules = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			tprPolicyObject = @{
    /// 				# REQUIRED
    /// 				objectId = $someString
    /// 				# REQUIRED
    /// 				managedObjectType = $someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 				# REQUIRED
    /// 				workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 				# REQUIRED
    /// 				clusterId = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			tprRules = @(
    /// 				$someTprRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprRule]) for enum values.
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	exemptServiceAccounts = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	quorumRequirement = $someInt
    /// 	# OPTIONAL
    /// 	clearSuspensionServiceAccounts = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	isCdmEnforcementDisabled = $someBoolean
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
        "RscMutationPolicy",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationPolicy : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddPolicyObjects",
                "BulkUpdatePolicyViolations",
                "CreatePolicy",
                "CreateSecurityPolicy",
                "CreateTprPolicy",
                "DeactivatePolicy",
                "DeleteSecurityPolicy",
                "DeleteTprPolicy",
                "ExportPolicyViolationsCsv",
                "FailoverHaPolicy",
                "GetHealthMonitorPolicyStatus",
                "RemovePolicyObjects",
                "SeedEnabledPolicies",
                "SeedInitialPolicies",
                "SetPasswordComplexityPolicy",
                "UpdateAutoEnablePolicyClusterConfig",
                "UpdateHealthMonitorPolicyStatus",
                "UpdateOrgSecurityPolicy",
                "UpdatePolicy",
                "UpdateSecurityPolicy",
                "UpdateTprPolicy",
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
                    case "AddPolicyObjects":
                        this.ProcessRecord_AddPolicyObjects();
                        break;
                    case "BulkUpdatePolicyViolations":
                        this.ProcessRecord_BulkUpdatePolicyViolations();
                        break;
                    case "CreatePolicy":
                        this.ProcessRecord_CreatePolicy();
                        break;
                    case "CreateSecurityPolicy":
                        this.ProcessRecord_CreateSecurityPolicy();
                        break;
                    case "CreateTprPolicy":
                        this.ProcessRecord_CreateTprPolicy();
                        break;
                    case "DeactivatePolicy":
                        this.ProcessRecord_DeactivatePolicy();
                        break;
                    case "DeleteSecurityPolicy":
                        this.ProcessRecord_DeleteSecurityPolicy();
                        break;
                    case "DeleteTprPolicy":
                        this.ProcessRecord_DeleteTprPolicy();
                        break;
                    case "ExportPolicyViolationsCsv":
                        this.ProcessRecord_ExportPolicyViolationsCsv();
                        break;
                    case "FailoverHaPolicy":
                        this.ProcessRecord_FailoverHaPolicy();
                        break;
                    case "GetHealthMonitorPolicyStatus":
                        this.ProcessRecord_GetHealthMonitorPolicyStatus();
                        break;
                    case "RemovePolicyObjects":
                        this.ProcessRecord_RemovePolicyObjects();
                        break;
                    case "SeedEnabledPolicies":
                        this.ProcessRecord_SeedEnabledPolicies();
                        break;
                    case "SeedInitialPolicies":
                        this.ProcessRecord_SeedInitialPolicies();
                        break;
                    case "SetPasswordComplexityPolicy":
                        this.ProcessRecord_SetPasswordComplexityPolicy();
                        break;
                    case "UpdateAutoEnablePolicyClusterConfig":
                        this.ProcessRecord_UpdateAutoEnablePolicyClusterConfig();
                        break;
                    case "UpdateHealthMonitorPolicyStatus":
                        this.ProcessRecord_UpdateHealthMonitorPolicyStatus();
                        break;
                    case "UpdateOrgSecurityPolicy":
                        this.ProcessRecord_UpdateOrgSecurityPolicy();
                        break;
                    case "UpdatePolicy":
                        this.ProcessRecord_UpdatePolicy();
                        break;
                    case "UpdateSecurityPolicy":
                        this.ProcessRecord_UpdateSecurityPolicy();
                        break;
                    case "UpdateTprPolicy":
                        this.ProcessRecord_UpdateTprPolicy();
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
        // addPolicyObjects.
        internal void ProcessRecord_AddPolicyObjects()
        {
            this._logger.name += " -AddPolicyObjects";
            // Create new graphql operation addPolicyObjects
            InitMutationAddPolicyObjects();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdatePolicyViolations.
        internal void ProcessRecord_BulkUpdatePolicyViolations()
        {
            this._logger.name += " -BulkUpdatePolicyViolations";
            // Create new graphql operation bulkUpdatePolicyViolations
            InitMutationBulkUpdatePolicyViolations();
        }

        // This parameter set invokes a single graphql operation:
        // createPolicy.
        internal void ProcessRecord_CreatePolicy()
        {
            this._logger.name += " -CreatePolicy";
            // Create new graphql operation createPolicy
            InitMutationCreatePolicy();
        }

        // This parameter set invokes a single graphql operation:
        // createSecurityPolicy.
        internal void ProcessRecord_CreateSecurityPolicy()
        {
            this._logger.name += " -CreateSecurityPolicy";
            // Create new graphql operation createSecurityPolicy
            InitMutationCreateSecurityPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // createTprPolicy.
        internal void ProcessRecord_CreateTprPolicy()
        {
            this._logger.name += " -CreateTprPolicy";
            // Create new graphql operation createTprPolicy
            InitMutationCreateTprPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // deactivatePolicy.
        internal void ProcessRecord_DeactivatePolicy()
        {
            this._logger.name += " -DeactivatePolicy";
            // Create new graphql operation deactivatePolicy
            InitMutationDeactivatePolicy();
        }

        // This parameter set invokes a single graphql operation:
        // deleteSecurityPolicy.
        internal void ProcessRecord_DeleteSecurityPolicy()
        {
            this._logger.name += " -DeleteSecurityPolicy";
            // Create new graphql operation deleteSecurityPolicy
            InitMutationDeleteSecurityPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // deleteTprPolicy.
        internal void ProcessRecord_DeleteTprPolicy()
        {
            this._logger.name += " -DeleteTprPolicy";
            // Create new graphql operation deleteTprPolicy
            InitMutationDeleteTprPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // exportPolicyViolationsCsv.
        internal void ProcessRecord_ExportPolicyViolationsCsv()
        {
            this._logger.name += " -ExportPolicyViolationsCsv";
            // Create new graphql operation exportPolicyViolationsCsv
            InitMutationExportPolicyViolationsCsv();
        }

        // This parameter set invokes a single graphql operation:
        // failoverHaPolicy.
        internal void ProcessRecord_FailoverHaPolicy()
        {
            this._logger.name += " -FailoverHaPolicy";
            // Create new graphql operation failoverHaPolicy
            InitMutationFailoverHaPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // getHealthMonitorPolicyStatus.
        internal void ProcessRecord_GetHealthMonitorPolicyStatus()
        {
            this._logger.name += " -GetHealthMonitorPolicyStatus";
            // Create new graphql operation getHealthMonitorPolicyStatus
            InitMutationGetHealthMonitorPolicyStatus();
        }

        // This parameter set invokes a single graphql operation:
        // removePolicyObjects.
        internal void ProcessRecord_RemovePolicyObjects()
        {
            this._logger.name += " -RemovePolicyObjects";
            // Create new graphql operation removePolicyObjects
            InitMutationRemovePolicyObjects();
        }

        // This parameter set invokes a single graphql operation:
        // seedEnabledPolicies.
        internal void ProcessRecord_SeedEnabledPolicies()
        {
            this._logger.name += " -SeedEnabledPolicies";
            // Create new graphql operation seedEnabledPolicies
            InitMutationSeedEnabledPolicies();
        }

        // This parameter set invokes a single graphql operation:
        // seedInitialPolicies.
        internal void ProcessRecord_SeedInitialPolicies()
        {
            this._logger.name += " -SeedInitialPolicies";
            // Create new graphql operation seedInitialPolicies
            InitMutationSeedInitialPolicies();
        }

        // This parameter set invokes a single graphql operation:
        // setPasswordComplexityPolicy.
        internal void ProcessRecord_SetPasswordComplexityPolicy()
        {
            this._logger.name += " -SetPasswordComplexityPolicy";
            // Create new graphql operation setPasswordComplexityPolicy
            InitMutationSetPasswordComplexityPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutoEnablePolicyClusterConfig.
        internal void ProcessRecord_UpdateAutoEnablePolicyClusterConfig()
        {
            this._logger.name += " -UpdateAutoEnablePolicyClusterConfig";
            // Create new graphql operation updateAutoEnablePolicyClusterConfig
            InitMutationUpdateAutoEnablePolicyClusterConfig();
        }

        // This parameter set invokes a single graphql operation:
        // updateHealthMonitorPolicyStatus.
        internal void ProcessRecord_UpdateHealthMonitorPolicyStatus()
        {
            this._logger.name += " -UpdateHealthMonitorPolicyStatus";
            // Create new graphql operation updateHealthMonitorPolicyStatus
            InitMutationUpdateHealthMonitorPolicyStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateOrgSecurityPolicy.
        internal void ProcessRecord_UpdateOrgSecurityPolicy()
        {
            this._logger.name += " -UpdateOrgSecurityPolicy";
            // Create new graphql operation updateOrgSecurityPolicy
            InitMutationUpdateOrgSecurityPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // updatePolicy.
        internal void ProcessRecord_UpdatePolicy()
        {
            this._logger.name += " -UpdatePolicy";
            // Create new graphql operation updatePolicy
            InitMutationUpdatePolicy();
        }

        // This parameter set invokes a single graphql operation:
        // updateSecurityPolicy.
        internal void ProcessRecord_UpdateSecurityPolicy()
        {
            this._logger.name += " -UpdateSecurityPolicy";
            // Create new graphql operation updateSecurityPolicy
            InitMutationUpdateSecurityPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // updateTprPolicy.
        internal void ProcessRecord_UpdateTprPolicy()
        {
            this._logger.name += " -UpdateTprPolicy";
            // Create new graphql operation updateTprPolicy
            InitMutationUpdateTprPolicy();
        }


        // Create new GraphQL Mutation:
        // addPolicyObjects(
        //     policyIds: [String!]!
        //     objectIds: [String!]! = []
        //     objectRootIds: [String!]! = []
        //     clusterIds: [String!]! = []
        //   ): String!
        internal void InitMutationAddPolicyObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyIds", "[String!]!"),
                Tuple.Create("objectIds", "[String!]!"),
                Tuple.Create("objectRootIds", "[String!]!"),
                Tuple.Create("clusterIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddPolicyObjects",
                "($policyIds: [String!]!,$objectIds: [String!]!,$objectRootIds: [String!]!,$clusterIds: [String!]!)",
                "System.String",
                Mutation.AddPolicyObjects,
                Mutation.AddPolicyObjectsFieldSpec,
                @"# REQUIRED
$query.Var.policyIds = @(
	$someString
)
# REQUIRED
$query.Var.objectIds = @(
	$someString
)
# REQUIRED
$query.Var.objectRootIds = @(
	$someString
)
# REQUIRED
$query.Var.clusterIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdatePolicyViolations(input: BulkUpdatePolicyViolationsInput!): Void
        internal void InitMutationBulkUpdatePolicyViolations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdatePolicyViolationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdatePolicyViolations",
                "($input: BulkUpdatePolicyViolationsInput!)",
                "System.String",
                Mutation.BulkUpdatePolicyViolations,
                Mutation.BulkUpdatePolicyViolationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	policyViolationIds = @(
		$someString
	)
	# REQUIRED
	newPolicyViolationStatus = $somePolicyViolationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationStatus]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createPolicy(input: CreatePolicyInput!): ClassificationPolicyDetail!
        internal void InitMutationCreatePolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreatePolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreatePolicy",
                "($input: CreatePolicyInput!)",
                "ClassificationPolicyDetail",
                Mutation.CreatePolicy,
                Mutation.CreatePolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	colorEnum = $someClassificationPolicyColor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyColor]) for enum values.
	# OPTIONAL
	mode = $someClassificationPolicyMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyMode]) for enum values.
	# OPTIONAL
	analyzerIds = @(
		$someString
	)
	# OPTIONAL
	documentTypeIds = @(
		$someString
	)
	# OPTIONAL
	updateName = $someBoolean
	# OPTIONAL
	updateDescription = $someBoolean
	# OPTIONAL
	updateMode = $someBoolean
	# OPTIONAL
	updateAnalyzerIds = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createSecurityPolicy(input: CreateSecurityPolicyInput!): CreateSecurityPolicyReply!
        internal void InitMutationCreateSecurityPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateSecurityPolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateSecurityPolicy",
                "($input: CreateSecurityPolicyInput!)",
                "CreateSecurityPolicyReply",
                Mutation.CreateSecurityPolicy,
                Mutation.CreateSecurityPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	policyName = $someString
	# REQUIRED
	description = $someString
	# REQUIRED
	policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
	# REQUIRED
	filter = @{
		# REQUIRED
		filterList = @(
			@{
				# OPTIONAL
				filterConfig = @{
					# REQUIRED
					filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
					# REQUIRED
					values = @(
						$someString
					)
					# REQUIRED
					relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
				}
				# OPTIONAL
				filterGroupConfig = @{
					# REQUIRED
					filterList = @(
						@{
							# OPTIONAL
							filterConfig = @{
								# REQUIRED
								filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
								# REQUIRED
								values = @(
									$someString
								)
								# REQUIRED
								relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
							}
							# OPTIONAL
							filterGroupConfig = @{<FilterGroupConfigInput>}
						}
					)
					# REQUIRED
					logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
				}
			}
		)
		# REQUIRED
		logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
	}
	# OPTIONAL
	policySeverity = $someSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Severity]) for enum values.
	# OPTIONAL
	policyCategory = $someCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Category]) for enum values.
	# OPTIONAL
	isAutomationEnabled = $someBoolean
	# OPTIONAL
	automationRules = @(
		@{
			# OPTIONAL
			action = @{
				# REQUIRED
				remediationType = $someRemediationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationType]) for enum values.
				# OPTIONAL
				remediationDetails = @{
					# OPTIONAL
					ticketInfo = @{
						# OPTIONAL
						title = $someString
						# OPTIONAL
						reason = $someString
						# OPTIONAL
						attachmentTypes = @(
							$someRemediationTicketAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationTicketAttachmentType]) for enum values.
						)
						# OPTIONAL
						comment = $someString
					}
					# OPTIONAL
					mipLabelInfo = @{
						# OPTIONAL
						labelId = $someString
						# OPTIONAL
						allowDowngrade = $someBoolean
						# OPTIONAL
						labelName = $someString
					}
					# OPTIONAL
					adIrInfo = @{
						# OPTIONAL
						domainControllerFid = $someString
					}
					# OPTIONAL
					ticketDetails = @{
						# REQUIRED
						ticketContents = @{
							# OPTIONAL
							title = $someString
							# OPTIONAL
							description = $someString
							# OPTIONAL
							comment = $someString
							# OPTIONAL
							projectKey = $someString
							# OPTIONAL
							ticketTypeId = $someString
							# OPTIONAL
							requiredFields = @(
								@{
									# OPTIONAL
									fieldKey = $someString
									# REQUIRED
									fieldValue = @{
										# REQUIRED
										fieldType = $someTicketFieldType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketFieldType]) for enum values.
										# OPTIONAL
										stringValue = $someString
										# OPTIONAL
										numberValue = $someInt64
										# OPTIONAL
										optionValue = $someString
										# OPTIONAL
										multiOptionValues = @{
											# REQUIRED
											values = @(
												$someString
											)
										}
										# OPTIONAL
										arrayValues = @{
											# REQUIRED
											values = @(
												$someString
											)
										}
										# OPTIONAL
										userValue = $someString
										# OPTIONAL
										dateValue = $someString
										# OPTIONAL
										datetimeValue = $someString
										# OPTIONAL
										booleanValue = $someBoolean
										# OPTIONAL
										textAreaValue = $someString
									}
								}
							)
						}
						# OPTIONAL
						attachmentTypes = @(
							$someRemediationTicketAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationTicketAttachmentType]) for enum values.
						)
					}
				}
			}
		}
	)
	# OPTIONAL
	thresholdFilter = @{
		# REQUIRED
		filterList = @(
			@{
				# OPTIONAL
				filterConfig = @{
					# REQUIRED
					filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
					# REQUIRED
					values = @(
						$someString
					)
					# REQUIRED
					relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
				}
				# OPTIONAL
				filterGroupConfig = @{
					# REQUIRED
					filterList = @(
						@{
							# OPTIONAL
							filterConfig = @{
								# REQUIRED
								filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
								# REQUIRED
								values = @(
									$someString
								)
								# REQUIRED
								relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
							}
							# OPTIONAL
							filterGroupConfig = @{<FilterGroupConfigInput>}
						}
					)
					# REQUIRED
					logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
				}
			}
		)
		# REQUIRED
		logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
	}
	# OPTIONAL
	policyTypeInfo = @{
		# OPTIONAL
		identityEventPolicyInfo = @{
			# OPTIONAL
			eventProviders = @(
				$someEventProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventProvider]) for enum values.
			)
		}
		# OPTIONAL
		identityPolicyInfo = @{
			# OPTIONAL
			idpType = @(
				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
			)
		}
		# OPTIONAL
		idpPolicyInfo = @{
			# OPTIONAL
			idpType = @(
				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
			)
		}
		# OPTIONAL
		signinAnomalyPolicyInfo = @{
			# OPTIONAL
			idpType = @(
				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
			)
		}
	}
	# OPTIONAL
	frameworks = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createTprPolicy(input: CreateTprPolicyInput!): CreateTprPolicyReply!
        internal void InitMutationCreateTprPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateTprPolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateTprPolicy",
                "($input: CreateTprPolicyInput!)",
                "CreateTprPolicyReply",
                Mutation.CreateTprPolicy,
                Mutation.CreateTprPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	description = $someString
	# REQUIRED
	policyScope = $someTprPolicyScope # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprPolicyScope]) for enum values.
	# REQUIRED
	policyRules = @(
		@{
			# REQUIRED
			tprPolicyObject = @{
				# REQUIRED
				objectId = $someString
				# REQUIRED
				managedObjectType = $someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
				# REQUIRED
				workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
				# REQUIRED
				clusterId = $someString
			}
			# REQUIRED
			tprRules = @(
				$someTprRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprRule]) for enum values.
			)
		}
	)
	# REQUIRED
	exemptServiceAccounts = @(
		$someString
	)
	# OPTIONAL
	quorumRequirement = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // deactivatePolicy(policyId: String!, runAsync: Boolean!, disableDataCategory: Boolean = false): [String!]!
        internal void InitMutationDeactivatePolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyId", "String!"),
                Tuple.Create("runAsync", "Boolean!"),
                Tuple.Create("disableDataCategory", "Boolean"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeactivatePolicy",
                "($policyId: String!,$runAsync: Boolean!,$disableDataCategory: Boolean)",
                "List<System.String>",
                Mutation.DeactivatePolicy,
                Mutation.DeactivatePolicyFieldSpec,
                @"# REQUIRED
$query.Var.policyId = $someString
# REQUIRED
$query.Var.runAsync = $someBoolean
# OPTIONAL
$query.Var.disableDataCategory = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // deleteSecurityPolicy(policyId: UUID!, policyType: PolicyType!, keepViolationsOpenArg: Boolean = false): Void
        internal void InitMutationDeleteSecurityPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyId", "UUID!"),
                Tuple.Create("policyType", "PolicyType!"),
                Tuple.Create("keepViolationsOpenArg", "Boolean"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteSecurityPolicy",
                "($policyId: UUID!,$policyType: PolicyType!,$keepViolationsOpenArg: Boolean)",
                "System.String",
                Mutation.DeleteSecurityPolicy,
                Mutation.DeleteSecurityPolicyFieldSpec,
                @"# REQUIRED
$query.Var.policyId = $someString
# REQUIRED
$query.Var.policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
# OPTIONAL
$query.Var.keepViolationsOpenArg = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // deleteTprPolicy(input: DeleteTprPolicyInput!): Void
        internal void InitMutationDeleteTprPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteTprPolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteTprPolicy",
                "($input: DeleteTprPolicyInput!)",
                "System.String",
                Mutation.DeleteTprPolicy,
                Mutation.DeleteTprPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	policyId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportPolicyViolationsCsv(input: ExportPolicyViolationsCsvInput!): ExportPolicyViolationsCsvReply!
        internal void InitMutationExportPolicyViolationsCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportPolicyViolationsCsvInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportPolicyViolationsCsv",
                "($input: ExportPolicyViolationsCsvInput!)",
                "ExportPolicyViolationsCsvReply",
                Mutation.ExportPolicyViolationsCsv,
                Mutation.ExportPolicyViolationsCsvFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	filter = @{
		# OPTIONAL
		policyIds = @(
			$someString
		)
		# OPTIONAL
		resourceIds = @(
			$someString
		)
		# OPTIONAL
		statuses = @(
			$somePolicyViolationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationStatus]) for enum values.
		)
		# OPTIONAL
		policyViolationIds = @(
			$someString
		)
		# OPTIONAL
		resourceTypes = @(
			$somePolicyResourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyResourceType]) for enum values.
		)
		# OPTIONAL
		sensitivityLevels = @(
			$someSensitivityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SensitivityLevel]) for enum values.
		)
		# OPTIONAL
		detectionDateRange = @{
			# OPTIONAL
			start = $someDateTime
			# OPTIONAL
			end = $someDateTime
		}
		# OPTIONAL
		updateDateRange = @{
			# OPTIONAL
			start = $someDateTime
			# OPTIONAL
			end = $someDateTime
		}
		# OPTIONAL
		resourceType = $somePolicyResourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyResourceType]) for enum values.
		# OPTIONAL
		parentViolationId = $someString
		# OPTIONAL
		dataCategoryIds = @(
			$someString
		)
		# OPTIONAL
		dataTypeIds = @(
			$someString
		)
		# OPTIONAL
		documentTypeIds = @(
			$someString
		)
		# OPTIONAL
		originId = $someString
		# OPTIONAL
		originIds = @(
			$someString
		)
		# OPTIONAL
		policyViolationNameSearch = $someString
		# OPTIONAL
		statusReasons = @(
			$somePolicyViolationStatusReason # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationStatusReason]) for enum values.
		)
		# OPTIONAL
		ticketNumbers = @(
			$someString
		)
		# OPTIONAL
		violationNames = @(
			$someString
		)
	}
	# OPTIONAL
	policyFilters = @{
		# OPTIONAL
		policySeverities = @(
			$someViolationSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ViolationSeverity]) for enum values.
		)
		# OPTIONAL
		policyCategories = @(
			$someCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Category]) for enum values.
		)
		# OPTIONAL
		policyTypes = @(
			$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
		)
		# OPTIONAL
		includeDeletedPolicies = $someBoolean
		# OPTIONAL
		policyFrameworks = @(
			$someString
		)
	}
	# OPTIONAL
	resourceMetadataFilters = @{
		# OPTIONAL
		objectTypes = @(
			$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
		)
		# OPTIONAL
		cloudAccountIds = @(
			$someString
		)
		# OPTIONAL
		managedObjectTypes = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		principalTypes = @(
			$someViolationPrincipalType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ViolationPrincipalType]) for enum values.
		)
		# OPTIONAL
		resolutionTypes = @(
			$someIdentityResolutionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdentityResolutionType]) for enum values.
		)
		# OPTIONAL
		domainFids = @(
			$someString
		)
		# OPTIONAL
		identityNameSearch = $someString
		# OPTIONAL
		accessTypes = @(
			$someAccessVia # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessVia]) for enum values.
		)
		# OPTIONAL
		sources = @(
			$someString
		)
		# OPTIONAL
		idpTypes = @(
			$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
		)
		# OPTIONAL
		originEventDateRange = @{
			# REQUIRED
			start = $someDateTime
			# REQUIRED
			end = $someDateTime
		}
		# OPTIONAL
		identityTags = @(
			$someIdentityTag # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdentityTag]) for enum values.
		)
		# OPTIONAL
		actorIds = @(
			$someString
		)
		# OPTIONAL
		identityOrigins = @(
			$somePrincipalOrigin # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrincipalOrigin]) for enum values.
		)
	}
	# OPTIONAL
	columns = @(
		$somePolicyViolationCsvColumn # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationCsvColumn]) for enum values.
	)
	# OPTIONAL
	groupBy = $somePolicyViolationGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationGroupBy]) for enum values.
	# REQUIRED
	policyTypes = @(
		$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
	)
	# OPTIONAL
	sortField = $somePolicyViolationSortField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationSortField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // failoverHaPolicy(input: FailoverHaPolicyInput!): AsyncRequestStatus!
        internal void InitMutationFailoverHaPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FailoverHaPolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationFailoverHaPolicy",
                "($input: FailoverHaPolicyInput!)",
                "AsyncRequestStatus",
                Mutation.FailoverHaPolicy,
                Mutation.FailoverHaPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	failoverType = $someFlexmotionFailoverType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FlexmotionFailoverType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // getHealthMonitorPolicyStatus(input: GetHealthMonitorPolicyStatusInput!): GetHealthMonitorPolicyStatusReply!
        internal void InitMutationGetHealthMonitorPolicyStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHealthMonitorPolicyStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGetHealthMonitorPolicyStatus",
                "($input: GetHealthMonitorPolicyStatusInput!)",
                "GetHealthMonitorPolicyStatusReply",
                Mutation.GetHealthMonitorPolicyStatus,
                Mutation.GetHealthMonitorPolicyStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	hasDetailedStatus = $someBoolean
	# OPTIONAL
	nodeIds = @(
		$someString
	)
	# OPTIONAL
	policyIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // removePolicyObjects(
        //     policyIds: [String!]!
        //     objectIds: [String!]! = []
        //     objectRootIds: [String!]! = []
        //     clusterIds: [String!]! = []
        //     runAsync: Boolean!
        //   ): [String!]!
        internal void InitMutationRemovePolicyObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyIds", "[String!]!"),
                Tuple.Create("objectIds", "[String!]!"),
                Tuple.Create("objectRootIds", "[String!]!"),
                Tuple.Create("clusterIds", "[String!]!"),
                Tuple.Create("runAsync", "Boolean!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemovePolicyObjects",
                "($policyIds: [String!]!,$objectIds: [String!]!,$objectRootIds: [String!]!,$clusterIds: [String!]!,$runAsync: Boolean!)",
                "List<System.String>",
                Mutation.RemovePolicyObjects,
                Mutation.RemovePolicyObjectsFieldSpec,
                @"# REQUIRED
$query.Var.policyIds = @(
	$someString
)
# REQUIRED
$query.Var.objectIds = @(
	$someString
)
# REQUIRED
$query.Var.objectRootIds = @(
	$someString
)
# REQUIRED
$query.Var.clusterIds = @(
	$someString
)
# REQUIRED
$query.Var.runAsync = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // seedEnabledPolicies: SeedEnabledPoliciesReply!
        internal void InitMutationSeedEnabledPolicies()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSeedEnabledPolicies",
                "",
                "SeedEnabledPoliciesReply",
                Mutation.SeedEnabledPolicies,
                Mutation.SeedEnabledPoliciesFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // seedInitialPolicies: SeedInitialPoliciesReply!
        internal void InitMutationSeedInitialPolicies()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSeedInitialPolicies",
                "",
                "SeedInitialPoliciesReply",
                Mutation.SeedInitialPolicies,
                Mutation.SeedInitialPoliciesFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // setPasswordComplexityPolicy(input: SetPasswordComplexityPolicyInput!): Void
        internal void InitMutationSetPasswordComplexityPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetPasswordComplexityPolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetPasswordComplexityPolicy",
                "($input: SetPasswordComplexityPolicyInput!)",
                "System.String",
                Mutation.SetPasswordComplexityPolicy,
                Mutation.SetPasswordComplexityPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	policy = @{
		# REQUIRED
		lengthPolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# REQUIRED
			isActive = $someBoolean
			# OPTIONAL
			defaultValue = $someInt
		}
		# REQUIRED
		lowercasePolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# REQUIRED
			isActive = $someBoolean
			# OPTIONAL
			defaultValue = $someInt
		}
		# REQUIRED
		uppercasePolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# REQUIRED
			isActive = $someBoolean
			# OPTIONAL
			defaultValue = $someInt
		}
		# REQUIRED
		specialCharsPolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# REQUIRED
			isActive = $someBoolean
			# OPTIONAL
			defaultValue = $someInt
		}
		# REQUIRED
		numericPolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# REQUIRED
			isActive = $someBoolean
			# OPTIONAL
			defaultValue = $someInt
		}
		# REQUIRED
		passwordReusePolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# REQUIRED
			isActive = $someBoolean
			# OPTIONAL
			defaultValue = $someInt
		}
		# REQUIRED
		passwordExpirationPolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# REQUIRED
			isActive = $someBoolean
			# OPTIONAL
			defaultValue = $someInt
		}
		# OPTIONAL
		leakedDetectionPolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# REQUIRED
			isActive = $someBoolean
			# OPTIONAL
			defaultValue = $someInt
		}
	}
	# OPTIONAL
	shouldResetAllOrgUsersPasswords = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAutoEnablePolicyClusterConfig(input: UpdateAutoEnablePolicyClusterConfigInput!): UpdateAutoEnablePolicyClusterConfigReply!
        internal void InitMutationUpdateAutoEnablePolicyClusterConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutoEnablePolicyClusterConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAutoEnablePolicyClusterConfig",
                "($input: UpdateAutoEnablePolicyClusterConfigInput!)",
                "UpdateAutoEnablePolicyClusterConfigReply",
                Mutation.UpdateAutoEnablePolicyClusterConfig,
                Mutation.UpdateAutoEnablePolicyClusterConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterId = $someString
	# OPTIONAL
	enabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateHealthMonitorPolicyStatus(input: UpdateHealthMonitorPolicyStatusInput!): UpdateHealthMonitorPolicyStatusReply!
        internal void InitMutationUpdateHealthMonitorPolicyStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHealthMonitorPolicyStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateHealthMonitorPolicyStatus",
                "($input: UpdateHealthMonitorPolicyStatusInput!)",
                "UpdateHealthMonitorPolicyStatusReply",
                Mutation.UpdateHealthMonitorPolicyStatus,
                Mutation.UpdateHealthMonitorPolicyStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	runRequest = @{
		# OPTIONAL
		nodeIds = @(
			$someString
		)
		# REQUIRED
		policyIds = @(
			$someString
		)
	}
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateOrgSecurityPolicy(input: UpdateOrgSecurityPolicyInput!): Void
        internal void InitMutationUpdateOrgSecurityPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOrgSecurityPolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateOrgSecurityPolicy",
                "($input: UpdateOrgSecurityPolicyInput!)",
                "System.String",
                Mutation.UpdateOrgSecurityPolicy,
                Mutation.UpdateOrgSecurityPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	disallowWeakerPolicy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updatePolicy(input: UpdatePolicyInput!): ClassificationPolicyDetail!
        internal void InitMutationUpdatePolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdatePolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdatePolicy",
                "($input: UpdatePolicyInput!)",
                "ClassificationPolicyDetail",
                Mutation.UpdatePolicy,
                Mutation.UpdatePolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	colorEnum = $someClassificationPolicyColor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyColor]) for enum values.
	# OPTIONAL
	mode = $someClassificationPolicyMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyMode]) for enum values.
	# OPTIONAL
	analyzerIds = @(
		$someString
	)
	# OPTIONAL
	documentTypeIds = @(
		$someString
	)
	# OPTIONAL
	updateName = $someBoolean
	# OPTIONAL
	updateDescription = $someBoolean
	# OPTIONAL
	updateMode = $someBoolean
	# OPTIONAL
	updateAnalyzerIds = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateSecurityPolicy(input: UpdateDSPMPolicyInput!): Void
        internal void InitMutationUpdateSecurityPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateDSPMPolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateSecurityPolicy",
                "($input: UpdateDSPMPolicyInput!)",
                "System.String",
                Mutation.UpdateSecurityPolicy,
                Mutation.UpdateSecurityPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	policyId = $someString
	# REQUIRED
	policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
	# OPTIONAL
	filter = @{
		# REQUIRED
		filterList = @(
			@{
				# OPTIONAL
				filterConfig = @{
					# REQUIRED
					filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
					# REQUIRED
					values = @(
						$someString
					)
					# REQUIRED
					relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
				}
				# OPTIONAL
				filterGroupConfig = @{
					# REQUIRED
					filterList = @(
						@{
							# OPTIONAL
							filterConfig = @{
								# REQUIRED
								filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
								# REQUIRED
								values = @(
									$someString
								)
								# REQUIRED
								relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
							}
							# OPTIONAL
							filterGroupConfig = @{<FilterGroupConfigInput>}
						}
					)
					# REQUIRED
					logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
				}
			}
		)
		# REQUIRED
		logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
	}
	# OPTIONAL
	isEnabled = $someBoolean
	# OPTIONAL
	policyName = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	policySeverity = $someSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Severity]) for enum values.
	# OPTIONAL
	policyCategory = $someCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Category]) for enum values.
	# OPTIONAL
	isAutomationEnabled = $someBoolean
	# OPTIONAL
	automationRules = @(
		@{
			# OPTIONAL
			action = @{
				# REQUIRED
				remediationType = $someRemediationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationType]) for enum values.
				# OPTIONAL
				remediationDetails = @{
					# OPTIONAL
					ticketInfo = @{
						# OPTIONAL
						title = $someString
						# OPTIONAL
						reason = $someString
						# OPTIONAL
						attachmentTypes = @(
							$someRemediationTicketAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationTicketAttachmentType]) for enum values.
						)
						# OPTIONAL
						comment = $someString
					}
					# OPTIONAL
					mipLabelInfo = @{
						# OPTIONAL
						labelId = $someString
						# OPTIONAL
						allowDowngrade = $someBoolean
						# OPTIONAL
						labelName = $someString
					}
					# OPTIONAL
					adIrInfo = @{
						# OPTIONAL
						domainControllerFid = $someString
					}
					# OPTIONAL
					ticketDetails = @{
						# REQUIRED
						ticketContents = @{
							# OPTIONAL
							title = $someString
							# OPTIONAL
							description = $someString
							# OPTIONAL
							comment = $someString
							# OPTIONAL
							projectKey = $someString
							# OPTIONAL
							ticketTypeId = $someString
							# OPTIONAL
							requiredFields = @(
								@{
									# OPTIONAL
									fieldKey = $someString
									# REQUIRED
									fieldValue = @{
										# REQUIRED
										fieldType = $someTicketFieldType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketFieldType]) for enum values.
										# OPTIONAL
										stringValue = $someString
										# OPTIONAL
										numberValue = $someInt64
										# OPTIONAL
										optionValue = $someString
										# OPTIONAL
										multiOptionValues = @{
											# REQUIRED
											values = @(
												$someString
											)
										}
										# OPTIONAL
										arrayValues = @{
											# REQUIRED
											values = @(
												$someString
											)
										}
										# OPTIONAL
										userValue = $someString
										# OPTIONAL
										dateValue = $someString
										# OPTIONAL
										datetimeValue = $someString
										# OPTIONAL
										booleanValue = $someBoolean
										# OPTIONAL
										textAreaValue = $someString
									}
								}
							)
						}
						# OPTIONAL
						attachmentTypes = @(
							$someRemediationTicketAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RemediationTicketAttachmentType]) for enum values.
						)
					}
				}
			}
		}
	)
	# OPTIONAL
	thresholdFilter = @{
		# REQUIRED
		filterList = @(
			@{
				# OPTIONAL
				filterConfig = @{
					# REQUIRED
					filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
					# REQUIRED
					values = @(
						$someString
					)
					# REQUIRED
					relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
				}
				# OPTIONAL
				filterGroupConfig = @{
					# REQUIRED
					filterList = @(
						@{
							# OPTIONAL
							filterConfig = @{
								# REQUIRED
								filterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
								# REQUIRED
								values = @(
									$someString
								)
								# REQUIRED
								relationship = $someRelationship # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Relationship]) for enum values.
							}
							# OPTIONAL
							filterGroupConfig = @{<FilterGroupConfigInput>}
						}
					)
					# REQUIRED
					logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
				}
			}
		)
		# REQUIRED
		logicalOp = $someLogicalOperator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LogicalOperator]) for enum values.
	}
	# OPTIONAL
	keepViolationsOpen = $someBoolean
	# OPTIONAL
	frameworks = @(
		$someString
	)
	# OPTIONAL
	policyTypeInfo = @{
		# OPTIONAL
		identityEventPolicyInfo = @{
			# OPTIONAL
			eventProviders = @(
				$someEventProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventProvider]) for enum values.
			)
		}
		# OPTIONAL
		identityPolicyInfo = @{
			# OPTIONAL
			idpType = @(
				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
			)
		}
		# OPTIONAL
		idpPolicyInfo = @{
			# OPTIONAL
			idpType = @(
				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
			)
		}
		# OPTIONAL
		signinAnomalyPolicyInfo = @{
			# OPTIONAL
			idpType = @(
				$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
			)
		}
	}
	# OPTIONAL
	forceUpdateThresholdFilter = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateTprPolicy(input: UpdateTprPolicyInput!): Void
        internal void InitMutationUpdateTprPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateTprPolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateTprPolicy",
                "($input: UpdateTprPolicyInput!)",
                "System.String",
                Mutation.UpdateTprPolicy,
                Mutation.UpdateTprPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	policyId = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	description = $someString
	# REQUIRED
	policyRules = @(
		@{
			# REQUIRED
			tprPolicyObject = @{
				# REQUIRED
				objectId = $someString
				# REQUIRED
				managedObjectType = $someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
				# REQUIRED
				workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
				# REQUIRED
				clusterId = $someString
			}
			# REQUIRED
			tprRules = @(
				$someTprRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprRule]) for enum values.
			)
		}
	)
	# REQUIRED
	exemptServiceAccounts = @(
		$someString
	)
	# OPTIONAL
	quorumRequirement = $someInt
	# OPTIONAL
	clearSuspensionServiceAccounts = @(
		$someString
	)
	# OPTIONAL
	isCdmEnforcementDisabled = $someBoolean
}"
            );
        }


    } // class New_RscMutationPolicy
}