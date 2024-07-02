// New-RscMutationNas.cs
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
    /// Create a new RscQuery object for any of the 10
    /// operations in the 'NAS' API domain:
    /// BulkAddNasShares, BulkDeleteNasShares, BulkDeleteNasSystems, BulkUpdateNasShares, DeleteNasSystem, HideRevealNasShares, RefreshNasSystems, RegisterNasSystem, UpdateNasShares, or UpdateNasSystem.
    /// </summary>
    /// <description>
    /// New-RscMutationNas creates a new
    /// mutation object for operations
    /// in the 'NAS' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 10 operations
    /// in the 'NAS' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BulkAddNasShares, BulkDeleteNasShares, BulkDeleteNasSystems, BulkUpdateNasShares, DeleteNasSystem, HideRevealNasShares, RefreshNasSystems, RegisterNasSystem, UpdateNasShares, or UpdateNasSystem.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationNas -BulkAddNasShares).Info().
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
    /// (New-RscMutationNas -BulkAddNasShares).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BulkAddNasShares operation
    /// of the 'NAS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nas
    /// # API Operation: BulkAddNasShares
    /// 
    /// $query = New-RscMutationNas -BulkAddNasShares
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bulkAddNasShareInput = @{
    /// 		# REQUIRED
    /// 		nasShares = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				shareType = $someCreateNasShareInputShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CreateNasShareInputShareType]) for enum values.
    /// 				# OPTIONAL
    /// 				credentials = @{
    /// 					# OPTIONAL
    /// 					password = $someString
    /// 					# REQUIRED
    /// 					username = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				exportPoint = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		nasSourceId = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkAddNasSharesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkDeleteNasShares operation
    /// of the 'NAS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nas
    /// # API Operation: BulkDeleteNasShares
    /// 
    /// $query = New-RscMutationNas -BulkDeleteNasShares
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bulkDeleteNasShareRequest = @{
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
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
    /// Runs the BulkDeleteNasSystems operation
    /// of the 'NAS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nas
    /// # API Operation: BulkDeleteNasSystems
    /// 
    /// $query = New-RscMutationNas -BulkDeleteNasSystems
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bulkDeleteNasSystemRequest = @{
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkUpdateNasShares operation
    /// of the 'NAS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nas
    /// # API Operation: BulkUpdateNasShares
    /// 
    /// $query = New-RscMutationNas -BulkUpdateNasShares
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bulkUpdateNasShareInput = @{
    /// 		# REQUIRED
    /// 		nasShares = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				isIsilonChangelistEnabled = $someBoolean
    /// 				# OPTIONAL
    /// 				exportPoint = $someString
    /// 				# OPTIONAL
    /// 				nasSourceId = $someString
    /// 				# OPTIONAL
    /// 				credentials = @{
    /// 					# OPTIONAL
    /// 					password = $someString
    /// 					# REQUIRED
    /// 					username = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				id = $someString
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkUpdateNasSharesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteNasSystem operation
    /// of the 'NAS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nas
    /// # API Operation: DeleteNasSystem
    /// 
    /// $query = New-RscMutationNas -DeleteNasSystem
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
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HideRevealNasShares operation
    /// of the 'NAS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nas
    /// # API Operation: HideRevealNasShares
    /// 
    /// $query = New-RscMutationNas -HideRevealNasShares
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	hideNasSharesRequest = @{
    /// 		# REQUIRED
    /// 		action = $someHideRevealAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HideRevealAction]) for enum values.
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshNasSystems operation
    /// of the 'NAS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nas
    /// # API Operation: RefreshNasSystems
    /// 
    /// $query = New-RscMutationNas -RefreshNasSystems
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	discoverNasSystemRequest = @{
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RefreshNasSystemsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RegisterNasSystem operation
    /// of the 'NAS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nas
    /// # API Operation: RegisterNasSystem
    /// 
    /// $query = New-RscMutationNas -RegisterNasSystem
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	nasSystem = @{
    /// 		# OPTIONAL
    /// 		isIsilonChangelistEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldGrantSmbShareRootAccess = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldGrantNfsShareRootAccess = $someBoolean
    /// 		# REQUIRED
    /// 		nasVendorType = $someNasVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NasVendorType]) for enum values.
    /// 		# OPTIONAL
    /// 		genericNasSystemParameters = @{
    /// 			# REQUIRED
    /// 			hasNfsSupport = $someBoolean
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		}
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		nasFlashBladeApiCredentials = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# REQUIRED
    /// 			apiToken = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		nasTmpApiCredentials = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			apiPassword = $someString
    /// 			# OPTIONAL
    /// 			apiUsername = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		nutanixFileServerParameters = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			apiPassword = $someString
    /// 			# OPTIONAL
    /// 			apiUsername = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		smbCredentials = @{
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RegisterNasSystemReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateNasShares operation
    /// of the 'NAS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nas
    /// # API Operation: UpdateNasShares
    /// 
    /// $query = New-RscMutationNas -UpdateNasShares
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	updateNasSharesRequest = @{
    /// 		# REQUIRED
    /// 		nasShareProperties = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				isIsilonChangelistEnabled = $someBoolean
    /// 				# REQUIRED
    /// 				id = $someString
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
    /// Runs the UpdateNasSystem operation
    /// of the 'NAS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Nas
    /// # API Operation: UpdateNasSystem
    /// 
    /// $query = New-RscMutationNas -UpdateNasSystem
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	nasSystemUpdateProperties = @{
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		isIsilonChangelistEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldResetGeneratedNamespaceSmbCredentials = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldGrantSmbShareRootAccess = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldGrantNfsShareRootAccess = $someBoolean
    /// 		# OPTIONAL
    /// 		genericNasSystemParameters = @{
    /// 			# REQUIRED
    /// 			hasNfsSupport = $someBoolean
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		nasApiCredentials = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			apiPassword = $someString
    /// 			# OPTIONAL
    /// 			apiUsername = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		nasFlashBladeApiCredentials = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# REQUIRED
    /// 			apiToken = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		nutanixFileServerParameters = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			apiPassword = $someString
    /// 			# OPTIONAL
    /// 			apiUsername = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		smbCredentials = @{
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateNasSystemReply
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
        "RscMutationNas",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationNas : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BulkAddNasShares",
                "BulkDeleteNasShares",
                "BulkDeleteNasSystems",
                "BulkUpdateNasShares",
                "DeleteNasSystem",
                "HideRevealNasShares",
                "RefreshNasSystems",
                "RegisterNasSystem",
                "UpdateNasShares",
                "UpdateNasSystem",
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
                    case "BulkAddNasShares":
                        this.ProcessRecord_BulkAddNasShares();
                        break;
                    case "BulkDeleteNasShares":
                        this.ProcessRecord_BulkDeleteNasShares();
                        break;
                    case "BulkDeleteNasSystems":
                        this.ProcessRecord_BulkDeleteNasSystems();
                        break;
                    case "BulkUpdateNasShares":
                        this.ProcessRecord_BulkUpdateNasShares();
                        break;
                    case "DeleteNasSystem":
                        this.ProcessRecord_DeleteNasSystem();
                        break;
                    case "HideRevealNasShares":
                        this.ProcessRecord_HideRevealNasShares();
                        break;
                    case "RefreshNasSystems":
                        this.ProcessRecord_RefreshNasSystems();
                        break;
                    case "RegisterNasSystem":
                        this.ProcessRecord_RegisterNasSystem();
                        break;
                    case "UpdateNasShares":
                        this.ProcessRecord_UpdateNasShares();
                        break;
                    case "UpdateNasSystem":
                        this.ProcessRecord_UpdateNasSystem();
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
        // bulkAddNasShares.
        internal void ProcessRecord_BulkAddNasShares()
        {
            this._logger.name += " -BulkAddNasShares";
            // Create new graphql operation bulkAddNasShares
            InitMutationBulkAddNasShares();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteNasShares.
        internal void ProcessRecord_BulkDeleteNasShares()
        {
            this._logger.name += " -BulkDeleteNasShares";
            // Create new graphql operation bulkDeleteNasShares
            InitMutationBulkDeleteNasShares();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteNasSystems.
        internal void ProcessRecord_BulkDeleteNasSystems()
        {
            this._logger.name += " -BulkDeleteNasSystems";
            // Create new graphql operation bulkDeleteNasSystems
            InitMutationBulkDeleteNasSystems();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateNasShares.
        internal void ProcessRecord_BulkUpdateNasShares()
        {
            this._logger.name += " -BulkUpdateNasShares";
            // Create new graphql operation bulkUpdateNasShares
            InitMutationBulkUpdateNasShares();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNasSystem.
        internal void ProcessRecord_DeleteNasSystem()
        {
            this._logger.name += " -DeleteNasSystem";
            // Create new graphql operation deleteNasSystem
            InitMutationDeleteNasSystem();
        }

        // This parameter set invokes a single graphql operation:
        // hideRevealNasShares.
        internal void ProcessRecord_HideRevealNasShares()
        {
            this._logger.name += " -HideRevealNasShares";
            // Create new graphql operation hideRevealNasShares
            InitMutationHideRevealNasShares();
        }

        // This parameter set invokes a single graphql operation:
        // refreshNasSystems.
        internal void ProcessRecord_RefreshNasSystems()
        {
            this._logger.name += " -RefreshNasSystems";
            // Create new graphql operation refreshNasSystems
            InitMutationRefreshNasSystems();
        }

        // This parameter set invokes a single graphql operation:
        // registerNasSystem.
        internal void ProcessRecord_RegisterNasSystem()
        {
            this._logger.name += " -RegisterNasSystem";
            // Create new graphql operation registerNasSystem
            InitMutationRegisterNasSystem();
        }

        // This parameter set invokes a single graphql operation:
        // updateNasShares.
        internal void ProcessRecord_UpdateNasShares()
        {
            this._logger.name += " -UpdateNasShares";
            // Create new graphql operation updateNasShares
            InitMutationUpdateNasShares();
        }

        // This parameter set invokes a single graphql operation:
        // updateNasSystem.
        internal void ProcessRecord_UpdateNasSystem()
        {
            this._logger.name += " -UpdateNasSystem";
            // Create new graphql operation updateNasSystem
            InitMutationUpdateNasSystem();
        }


        // Create new GraphQL Mutation:
        // bulkAddNasShares(input: BulkAddNasSharesInput!): BulkAddNasSharesReply!
        internal void InitMutationBulkAddNasShares()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkAddNasSharesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkAddNasShares",
                "($input: BulkAddNasSharesInput!)",
                "BulkAddNasSharesReply",
                Mutation.BulkAddNasShares,
                Mutation.BulkAddNasSharesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bulkAddNasShareInput = @{
		# REQUIRED
		nasShares = @(
			@{
				# REQUIRED
				shareType = $someCreateNasShareInputShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CreateNasShareInputShareType]) for enum values.
				# OPTIONAL
				credentials = @{
					# OPTIONAL
					password = $someString
					# REQUIRED
					username = $someString
				}
				# REQUIRED
				exportPoint = $someString
			}
		)
		# REQUIRED
		nasSourceId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteNasShares(input: BulkDeleteNasSharesInput!): Void
        internal void InitMutationBulkDeleteNasShares()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteNasSharesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteNasShares",
                "($input: BulkDeleteNasSharesInput!)",
                "System.String",
                Mutation.BulkDeleteNasShares,
                Mutation.BulkDeleteNasSharesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bulkDeleteNasShareRequest = @{
		# REQUIRED
		ids = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteNasSystems(input: BulkDeleteNasSystemsInput!): BatchAsyncRequestStatus!
        internal void InitMutationBulkDeleteNasSystems()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteNasSystemsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteNasSystems",
                "($input: BulkDeleteNasSystemsInput!)",
                "BatchAsyncRequestStatus",
                Mutation.BulkDeleteNasSystems,
                Mutation.BulkDeleteNasSystemsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bulkDeleteNasSystemRequest = @{
		# REQUIRED
		ids = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdateNasShares(input: BulkUpdateNasSharesInput!): BulkUpdateNasSharesReply!
        internal void InitMutationBulkUpdateNasShares()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateNasSharesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateNasShares",
                "($input: BulkUpdateNasSharesInput!)",
                "BulkUpdateNasSharesReply",
                Mutation.BulkUpdateNasShares,
                Mutation.BulkUpdateNasSharesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bulkUpdateNasShareInput = @{
		# REQUIRED
		nasShares = @(
			@{
				# OPTIONAL
				isIsilonChangelistEnabled = $someBoolean
				# OPTIONAL
				exportPoint = $someString
				# OPTIONAL
				nasSourceId = $someString
				# OPTIONAL
				credentials = @{
					# OPTIONAL
					password = $someString
					# REQUIRED
					username = $someString
				}
				# REQUIRED
				id = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteNasSystem(input: DeleteNasSystemInput!): AsyncRequestStatus!
        internal void InitMutationDeleteNasSystem()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNasSystemInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNasSystem",
                "($input: DeleteNasSystemInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteNasSystem,
                Mutation.DeleteNasSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // hideRevealNasShares(input: HideRevealNasSharesInput!): ResponseSuccess!
        internal void InitMutationHideRevealNasShares()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HideRevealNasSharesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHideRevealNasShares",
                "($input: HideRevealNasSharesInput!)",
                "ResponseSuccess",
                Mutation.HideRevealNasShares,
                Mutation.HideRevealNasSharesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	hideNasSharesRequest = @{
		# REQUIRED
		action = $someHideRevealAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HideRevealAction]) for enum values.
		# REQUIRED
		ids = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshNasSystems(input: RefreshNasSystemsInput!): RefreshNasSystemsReply!
        internal void InitMutationRefreshNasSystems()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshNasSystemsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshNasSystems",
                "($input: RefreshNasSystemsInput!)",
                "RefreshNasSystemsReply",
                Mutation.RefreshNasSystems,
                Mutation.RefreshNasSystemsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	discoverNasSystemRequest = @{
		# REQUIRED
		ids = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // registerNasSystem(input: RegisterNasSystemInput!): RegisterNasSystemReply!
        internal void InitMutationRegisterNasSystem()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterNasSystemInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterNasSystem",
                "($input: RegisterNasSystemInput!)",
                "RegisterNasSystemReply",
                Mutation.RegisterNasSystem,
                Mutation.RegisterNasSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	nasSystem = @{
		# OPTIONAL
		isIsilonChangelistEnabled = $someBoolean
		# OPTIONAL
		shouldGrantSmbShareRootAccess = $someBoolean
		# OPTIONAL
		shouldGrantNfsShareRootAccess = $someBoolean
		# REQUIRED
		nasVendorType = $someNasVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NasVendorType]) for enum values.
		# OPTIONAL
		genericNasSystemParameters = @{
			# REQUIRED
			hasNfsSupport = $someBoolean
			# REQUIRED
			hasSmbSupport = $someBoolean
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
		}
		# REQUIRED
		hostname = $someString
		# OPTIONAL
		nasFlashBladeApiCredentials = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# REQUIRED
			apiToken = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
		}
		# OPTIONAL
		nasTmpApiCredentials = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			apiPassword = $someString
			# OPTIONAL
			apiUsername = $someString
			# OPTIONAL
			certificateId = $someString
		}
		# OPTIONAL
		nutanixFileServerParameters = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			apiPassword = $someString
			# OPTIONAL
			apiUsername = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
		}
		# OPTIONAL
		smbCredentials = @{
			# OPTIONAL
			password = $someString
			# REQUIRED
			username = $someString
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNasShares(input: UpdateNasSharesInput!): Void
        internal void InitMutationUpdateNasShares()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNasSharesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNasShares",
                "($input: UpdateNasSharesInput!)",
                "System.String",
                Mutation.UpdateNasShares,
                Mutation.UpdateNasSharesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	updateNasSharesRequest = @{
		# REQUIRED
		nasShareProperties = @(
			@{
				# OPTIONAL
				isIsilonChangelistEnabled = $someBoolean
				# REQUIRED
				id = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNasSystem(input: UpdateNasSystemInput!): UpdateNasSystemReply!
        internal void InitMutationUpdateNasSystem()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNasSystemInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNasSystem",
                "($input: UpdateNasSystemInput!)",
                "UpdateNasSystemReply",
                Mutation.UpdateNasSystem,
                Mutation.UpdateNasSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	nasSystemUpdateProperties = @{
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		isIsilonChangelistEnabled = $someBoolean
		# OPTIONAL
		shouldResetGeneratedNamespaceSmbCredentials = $someBoolean
		# OPTIONAL
		shouldGrantSmbShareRootAccess = $someBoolean
		# OPTIONAL
		shouldGrantNfsShareRootAccess = $someBoolean
		# OPTIONAL
		genericNasSystemParameters = @{
			# REQUIRED
			hasNfsSupport = $someBoolean
			# REQUIRED
			hasSmbSupport = $someBoolean
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
		}
		# OPTIONAL
		nasApiCredentials = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			apiPassword = $someString
			# OPTIONAL
			apiUsername = $someString
			# OPTIONAL
			certificateId = $someString
		}
		# OPTIONAL
		nasFlashBladeApiCredentials = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# REQUIRED
			apiToken = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
		}
		# OPTIONAL
		nutanixFileServerParameters = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			apiPassword = $someString
			# OPTIONAL
			apiUsername = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
		}
		# OPTIONAL
		smbCredentials = @{
			# OPTIONAL
			password = $someString
			# REQUIRED
			username = $someString
		}
	}
}"
            );
        }


    } // class New_RscMutationNas
}