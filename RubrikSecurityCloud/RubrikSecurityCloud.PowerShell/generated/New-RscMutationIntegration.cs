// New-RscMutationIntegration.cs
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
    /// Create a new RscQuery object for any of the 7
    /// operations in the 'Integration' API domain:
    /// CreateIntegration, CreateIntegrations, DeleteIntegration, DeleteIntegrations, EnableIntegration, UpdateIntegration, or UpdateIntegrations.
    /// </summary>
    /// <description>
    /// New-RscMutationIntegration creates a new
    /// mutation object for operations
    /// in the 'Integration' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 7 operations
    /// in the 'Integration' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CreateIntegration, CreateIntegrations, DeleteIntegration, DeleteIntegrations, EnableIntegration, UpdateIntegration, or UpdateIntegrations.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationIntegration -CreateIntegration).Info().
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
    /// (New-RscMutationIntegration -CreateIntegration).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CreateIntegration operation
    /// of the 'Integration' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Integration
    /// # API Operation: CreateIntegration
    /// 
    /// $query = New-RscMutationIntegration -Operation CreateIntegration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		dataLossPrevention = @{
    /// 			# OPTIONAL
    /// 			policies = @(
    /// 				$someString
    /// 			)
    /// 			# REQUIRED
    /// 			targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
    /// 			# OPTIONAL
    /// 			genericNas = @{
    /// 				# REQUIRED
    /// 				workloadId = $someString
    /// 				# REQUIRED
    /// 				shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
    /// 				# REQUIRED
    /// 				shareId = $someString
    /// 				# REQUIRED
    /// 				path = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			vmwareVm = @{
    /// 				# REQUIRED
    /// 				workloadId = $someString
    /// 				# REQUIRED
    /// 				osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
    /// 				# REQUIRED
    /// 				path = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			serviceAccountId = $someString
    /// 			# OPTIONAL
    /// 			serviceAccountName = $someString
    /// 			# OPTIONAL
    /// 			status = @{
    /// 				# OPTIONAL
    /// 				code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		serviceNowItsm = @{
    /// 			# REQUIRED
    /// 			serviceAccountId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		okta = @{
    /// 			# REQUIRED
    /// 			oktaTenantUrl = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		microsoftPurview = @{
    /// 			# REQUIRED
    /// 			tenantId = $someString
    /// 			# REQUIRED
    /// 			o365OrgId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		pam = @{
    /// 			# OPTIONAL
    /// 			ipAddresses = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateIntegrationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateIntegrations operation
    /// of the 'Integration' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Integration
    /// # API Operation: CreateIntegrations
    /// 
    /// $query = New-RscMutationIntegration -Operation CreateIntegrations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	integrations = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
    /// 			# REQUIRED
    /// 			config = @{
    /// 				# OPTIONAL
    /// 				dataLossPrevention = @{
    /// 					# OPTIONAL
    /// 					policies = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
    /// 					# OPTIONAL
    /// 					genericNas = @{
    /// 						# REQUIRED
    /// 						workloadId = $someString
    /// 						# REQUIRED
    /// 						shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
    /// 						# REQUIRED
    /// 						shareId = $someString
    /// 						# REQUIRED
    /// 						path = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					vmwareVm = @{
    /// 						# REQUIRED
    /// 						workloadId = $someString
    /// 						# REQUIRED
    /// 						osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
    /// 						# REQUIRED
    /// 						path = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					serviceAccountId = $someString
    /// 					# OPTIONAL
    /// 					serviceAccountName = $someString
    /// 					# OPTIONAL
    /// 					status = @{
    /// 						# OPTIONAL
    /// 						code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
    /// 					}
    /// 				}
    /// 				# OPTIONAL
    /// 				serviceNowItsm = @{
    /// 					# REQUIRED
    /// 					serviceAccountId = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				okta = @{
    /// 					# REQUIRED
    /// 					oktaTenantUrl = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				microsoftPurview = @{
    /// 					# REQUIRED
    /// 					tenantId = $someString
    /// 					# REQUIRED
    /// 					o365OrgId = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				pam = @{
    /// 					# OPTIONAL
    /// 					ipAddresses = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateIntegrationsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteIntegration operation
    /// of the 'Integration' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Integration
    /// # API Operation: DeleteIntegration
    /// 
    /// $query = New-RscMutationIntegration -Operation DeleteIntegration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt64
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
    /// Runs the DeleteIntegrations operation
    /// of the 'Integration' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Integration
    /// # API Operation: DeleteIntegrations
    /// 
    /// $query = New-RscMutationIntegration -Operation DeleteIntegrations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someInt64
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
    /// Runs the EnableIntegration operation
    /// of the 'Integration' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Integration
    /// # API Operation: EnableIntegration
    /// 
    /// $query = New-RscMutationIntegration -Operation EnableIntegration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someInt64
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
    /// Runs the UpdateIntegration operation
    /// of the 'Integration' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Integration
    /// # API Operation: UpdateIntegration
    /// 
    /// $query = New-RscMutationIntegration -Operation UpdateIntegration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt64
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		dataLossPrevention = @{
    /// 			# OPTIONAL
    /// 			policies = @(
    /// 				$someString
    /// 			)
    /// 			# REQUIRED
    /// 			targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
    /// 			# OPTIONAL
    /// 			genericNas = @{
    /// 				# REQUIRED
    /// 				workloadId = $someString
    /// 				# REQUIRED
    /// 				shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
    /// 				# REQUIRED
    /// 				shareId = $someString
    /// 				# REQUIRED
    /// 				path = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			vmwareVm = @{
    /// 				# REQUIRED
    /// 				workloadId = $someString
    /// 				# REQUIRED
    /// 				osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
    /// 				# REQUIRED
    /// 				path = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			serviceAccountId = $someString
    /// 			# OPTIONAL
    /// 			serviceAccountName = $someString
    /// 			# OPTIONAL
    /// 			status = @{
    /// 				# OPTIONAL
    /// 				code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		serviceNowItsm = @{
    /// 			# REQUIRED
    /// 			serviceAccountId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		okta = @{
    /// 			# REQUIRED
    /// 			oktaTenantUrl = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		microsoftPurview = @{
    /// 			# REQUIRED
    /// 			tenantId = $someString
    /// 			# REQUIRED
    /// 			o365OrgId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		pam = @{
    /// 			# OPTIONAL
    /// 			ipAddresses = @(
    /// 				$someString
    /// 			)
    /// 		}
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
    /// Runs the UpdateIntegrations operation
    /// of the 'Integration' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Integration
    /// # API Operation: UpdateIntegrations
    /// 
    /// $query = New-RscMutationIntegration -Operation UpdateIntegrations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	integrations = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someInt64
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
    /// 			# REQUIRED
    /// 			config = @{
    /// 				# OPTIONAL
    /// 				dataLossPrevention = @{
    /// 					# OPTIONAL
    /// 					policies = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
    /// 					# OPTIONAL
    /// 					genericNas = @{
    /// 						# REQUIRED
    /// 						workloadId = $someString
    /// 						# REQUIRED
    /// 						shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
    /// 						# REQUIRED
    /// 						shareId = $someString
    /// 						# REQUIRED
    /// 						path = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					vmwareVm = @{
    /// 						# REQUIRED
    /// 						workloadId = $someString
    /// 						# REQUIRED
    /// 						osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
    /// 						# REQUIRED
    /// 						path = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					serviceAccountId = $someString
    /// 					# OPTIONAL
    /// 					serviceAccountName = $someString
    /// 					# OPTIONAL
    /// 					status = @{
    /// 						# OPTIONAL
    /// 						code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
    /// 					}
    /// 				}
    /// 				# OPTIONAL
    /// 				serviceNowItsm = @{
    /// 					# REQUIRED
    /// 					serviceAccountId = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				okta = @{
    /// 					# REQUIRED
    /// 					oktaTenantUrl = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				microsoftPurview = @{
    /// 					# REQUIRED
    /// 					tenantId = $someString
    /// 					# REQUIRED
    /// 					o365OrgId = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				pam = @{
    /// 					# OPTIONAL
    /// 					ipAddresses = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 			}
    /// 		}
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationIntegration",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationIntegration : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CreateIntegration",
                "CreateIntegrations",
                "DeleteIntegration",
                "DeleteIntegrations",
                "EnableIntegration",
                "UpdateIntegration",
                "UpdateIntegrations",
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
                    case "CreateIntegration":
                        this.ProcessRecord_CreateIntegration();
                        break;
                    case "CreateIntegrations":
                        this.ProcessRecord_CreateIntegrations();
                        break;
                    case "DeleteIntegration":
                        this.ProcessRecord_DeleteIntegration();
                        break;
                    case "DeleteIntegrations":
                        this.ProcessRecord_DeleteIntegrations();
                        break;
                    case "EnableIntegration":
                        this.ProcessRecord_EnableIntegration();
                        break;
                    case "UpdateIntegration":
                        this.ProcessRecord_UpdateIntegration();
                        break;
                    case "UpdateIntegrations":
                        this.ProcessRecord_UpdateIntegrations();
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
        // createIntegration.
        internal void ProcessRecord_CreateIntegration()
        {
            this._logger.name += " -CreateIntegration";
            // Create new graphql operation createIntegration
            InitMutationCreateIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // createIntegrations.
        internal void ProcessRecord_CreateIntegrations()
        {
            this._logger.name += " -CreateIntegrations";
            // Create new graphql operation createIntegrations
            InitMutationCreateIntegrations();
        }

        // This parameter set invokes a single graphql operation:
        // deleteIntegration.
        internal void ProcessRecord_DeleteIntegration()
        {
            this._logger.name += " -DeleteIntegration";
            // Create new graphql operation deleteIntegration
            InitMutationDeleteIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // deleteIntegrations.
        internal void ProcessRecord_DeleteIntegrations()
        {
            this._logger.name += " -DeleteIntegrations";
            // Create new graphql operation deleteIntegrations
            InitMutationDeleteIntegrations();
        }

        // This parameter set invokes a single graphql operation:
        // enableIntegration.
        internal void ProcessRecord_EnableIntegration()
        {
            this._logger.name += " -EnableIntegration";
            // Create new graphql operation enableIntegration
            InitMutationEnableIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // updateIntegration.
        internal void ProcessRecord_UpdateIntegration()
        {
            this._logger.name += " -UpdateIntegration";
            // Create new graphql operation updateIntegration
            InitMutationUpdateIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // updateIntegrations.
        internal void ProcessRecord_UpdateIntegrations()
        {
            this._logger.name += " -UpdateIntegrations";
            // Create new graphql operation updateIntegrations
            InitMutationUpdateIntegrations();
        }


        // Create new GraphQL Mutation:
        // createIntegration(input: CreateIntegrationInput!): CreateIntegrationReply!
        internal void InitMutationCreateIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateIntegrationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateIntegration",
                "($input: CreateIntegrationInput!)",
                "CreateIntegrationReply",
                Mutation.CreateIntegration,
                Mutation.CreateIntegrationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
	# REQUIRED
	config = @{
		# OPTIONAL
		dataLossPrevention = @{
			# OPTIONAL
			policies = @(
				$someString
			)
			# REQUIRED
			targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
			# OPTIONAL
			genericNas = @{
				# REQUIRED
				workloadId = $someString
				# REQUIRED
				shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
				# REQUIRED
				shareId = $someString
				# REQUIRED
				path = $someString
			}
			# OPTIONAL
			vmwareVm = @{
				# REQUIRED
				workloadId = $someString
				# REQUIRED
				osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
				# REQUIRED
				path = $someString
			}
			# OPTIONAL
			serviceAccountId = $someString
			# OPTIONAL
			serviceAccountName = $someString
			# OPTIONAL
			status = @{
				# OPTIONAL
				code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
			}
		}
		# OPTIONAL
		serviceNowItsm = @{
			# REQUIRED
			serviceAccountId = $someString
		}
		# OPTIONAL
		okta = @{
			# REQUIRED
			oktaTenantUrl = $someString
		}
		# OPTIONAL
		microsoftPurview = @{
			# REQUIRED
			tenantId = $someString
			# REQUIRED
			o365OrgId = $someString
		}
		# OPTIONAL
		pam = @{
			# OPTIONAL
			ipAddresses = @(
				$someString
			)
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createIntegrations(input: CreateIntegrationsInput!): CreateIntegrationsReply!
        internal void InitMutationCreateIntegrations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateIntegrationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateIntegrations",
                "($input: CreateIntegrationsInput!)",
                "CreateIntegrationsReply",
                Mutation.CreateIntegrations,
                Mutation.CreateIntegrationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	integrations = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
			# REQUIRED
			config = @{
				# OPTIONAL
				dataLossPrevention = @{
					# OPTIONAL
					policies = @(
						$someString
					)
					# REQUIRED
					targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
					# OPTIONAL
					genericNas = @{
						# REQUIRED
						workloadId = $someString
						# REQUIRED
						shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
						# REQUIRED
						shareId = $someString
						# REQUIRED
						path = $someString
					}
					# OPTIONAL
					vmwareVm = @{
						# REQUIRED
						workloadId = $someString
						# REQUIRED
						osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
						# REQUIRED
						path = $someString
					}
					# OPTIONAL
					serviceAccountId = $someString
					# OPTIONAL
					serviceAccountName = $someString
					# OPTIONAL
					status = @{
						# OPTIONAL
						code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
					}
				}
				# OPTIONAL
				serviceNowItsm = @{
					# REQUIRED
					serviceAccountId = $someString
				}
				# OPTIONAL
				okta = @{
					# REQUIRED
					oktaTenantUrl = $someString
				}
				# OPTIONAL
				microsoftPurview = @{
					# REQUIRED
					tenantId = $someString
					# REQUIRED
					o365OrgId = $someString
				}
				# OPTIONAL
				pam = @{
					# OPTIONAL
					ipAddresses = @(
						$someString
					)
				}
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteIntegration(input: DeleteIntegrationInput!): Void
        internal void InitMutationDeleteIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteIntegrationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteIntegration",
                "($input: DeleteIntegrationInput!)",
                "System.String",
                Mutation.DeleteIntegration,
                Mutation.DeleteIntegrationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt64
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteIntegrations(input: DeleteIntegrationsInput!): Void
        internal void InitMutationDeleteIntegrations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteIntegrationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteIntegrations",
                "($input: DeleteIntegrationsInput!)",
                "System.String",
                Mutation.DeleteIntegrations,
                Mutation.DeleteIntegrationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ids = @(
		$someInt64
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // enableIntegration(input: EnableIntegrationInput!): Void
        internal void InitMutationEnableIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableIntegrationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableIntegration",
                "($input: EnableIntegrationInput!)",
                "System.String",
                Mutation.EnableIntegration,
                Mutation.EnableIntegrationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someInt64
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateIntegration(input: UpdateIntegrationInput!): Void
        internal void InitMutationUpdateIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateIntegrationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateIntegration",
                "($input: UpdateIntegrationInput!)",
                "System.String",
                Mutation.UpdateIntegration,
                Mutation.UpdateIntegrationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt64
	# REQUIRED
	name = $someString
	# REQUIRED
	integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
	# REQUIRED
	config = @{
		# OPTIONAL
		dataLossPrevention = @{
			# OPTIONAL
			policies = @(
				$someString
			)
			# REQUIRED
			targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
			# OPTIONAL
			genericNas = @{
				# REQUIRED
				workloadId = $someString
				# REQUIRED
				shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
				# REQUIRED
				shareId = $someString
				# REQUIRED
				path = $someString
			}
			# OPTIONAL
			vmwareVm = @{
				# REQUIRED
				workloadId = $someString
				# REQUIRED
				osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
				# REQUIRED
				path = $someString
			}
			# OPTIONAL
			serviceAccountId = $someString
			# OPTIONAL
			serviceAccountName = $someString
			# OPTIONAL
			status = @{
				# OPTIONAL
				code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
			}
		}
		# OPTIONAL
		serviceNowItsm = @{
			# REQUIRED
			serviceAccountId = $someString
		}
		# OPTIONAL
		okta = @{
			# REQUIRED
			oktaTenantUrl = $someString
		}
		# OPTIONAL
		microsoftPurview = @{
			# REQUIRED
			tenantId = $someString
			# REQUIRED
			o365OrgId = $someString
		}
		# OPTIONAL
		pam = @{
			# OPTIONAL
			ipAddresses = @(
				$someString
			)
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateIntegrations(input: UpdateIntegrationsInput!): Void
        internal void InitMutationUpdateIntegrations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateIntegrationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateIntegrations",
                "($input: UpdateIntegrationsInput!)",
                "System.String",
                Mutation.UpdateIntegrations,
                Mutation.UpdateIntegrationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	integrations = @(
		@{
			# REQUIRED
			id = $someInt64
			# REQUIRED
			name = $someString
			# REQUIRED
			integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
			# REQUIRED
			config = @{
				# OPTIONAL
				dataLossPrevention = @{
					# OPTIONAL
					policies = @(
						$someString
					)
					# REQUIRED
					targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
					# OPTIONAL
					genericNas = @{
						# REQUIRED
						workloadId = $someString
						# REQUIRED
						shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
						# REQUIRED
						shareId = $someString
						# REQUIRED
						path = $someString
					}
					# OPTIONAL
					vmwareVm = @{
						# REQUIRED
						workloadId = $someString
						# REQUIRED
						osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
						# REQUIRED
						path = $someString
					}
					# OPTIONAL
					serviceAccountId = $someString
					# OPTIONAL
					serviceAccountName = $someString
					# OPTIONAL
					status = @{
						# OPTIONAL
						code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
					}
				}
				# OPTIONAL
				serviceNowItsm = @{
					# REQUIRED
					serviceAccountId = $someString
				}
				# OPTIONAL
				okta = @{
					# REQUIRED
					oktaTenantUrl = $someString
				}
				# OPTIONAL
				microsoftPurview = @{
					# REQUIRED
					tenantId = $someString
					# REQUIRED
					o365OrgId = $someString
				}
				# OPTIONAL
				pam = @{
					# OPTIONAL
					ipAddresses = @(
						$someString
					)
				}
			}
		}
	)
}"
            );
        }


    } // class New_RscMutationIntegration
}