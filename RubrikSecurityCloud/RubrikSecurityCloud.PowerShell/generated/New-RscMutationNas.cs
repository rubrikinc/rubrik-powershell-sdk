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
    /// Create a new RscQuery object for any of the 5
    /// operations in the 'NAS' API domain:
    /// BulkDeleteNasSystems, DeleteNasSystem, RefreshNasSystems, RegisterNasSystem, or UpdateNasSystem.
    /// </summary>
    /// <description>
    /// New-RscMutationNas creates a new
    /// mutation object for operations
    /// in the 'NAS' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 5 operations
    /// in the 'NAS' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BulkDeleteNasSystems, DeleteNasSystem, RefreshNasSystems, RegisterNasSystem, or UpdateNasSystem.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationNas -BulkDeleteNasSystems).Info().
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
    /// (New-RscMutationNas -BulkDeleteNasSystems).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
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
    /// 		genericNasSystemParameters = @{
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			hasNfsSupport = $someBoolean
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		isIsilonChangelistEnabled = $someBoolean
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
    /// 		nasFlashBladeApiCredentials = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			apiToken = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		smbCredentials = @{
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		nutanixFileServerParameters = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			apiPassword = $someString
    /// 			# OPTIONAL
    /// 			apiUsername = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		nasVendorType = $someNasVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NasVendorType]) for enum values.
    /// 		# REQUIRED
    /// 		hostname = $someString
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
    /// 		genericNasSystemParameters = @{
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			hasNfsSupport = $someBoolean
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		isIsilonChangelistEnabled = $someBoolean
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
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			apiToken = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		smbCredentials = @{
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		nutanixFileServerParameters = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			apiPassword = $someString
    /// 			# OPTIONAL
    /// 			apiUsername = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
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
                "BulkDeleteNasSystems",
                "DeleteNasSystem",
                "RefreshNasSystems",
                "RegisterNasSystem",
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
                    case "BulkDeleteNasSystems":
                        this.ProcessRecord_BulkDeleteNasSystems();
                        break;
                    case "DeleteNasSystem":
                        this.ProcessRecord_DeleteNasSystem();
                        break;
                    case "RefreshNasSystems":
                        this.ProcessRecord_RefreshNasSystems();
                        break;
                    case "RegisterNasSystem":
                        this.ProcessRecord_RegisterNasSystem();
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
        // bulkDeleteNasSystems.
        internal void ProcessRecord_BulkDeleteNasSystems()
        {
            this._logger.name += " -BulkDeleteNasSystems";
            // Create new graphql operation bulkDeleteNasSystems
            InitMutationBulkDeleteNasSystems();
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
        // updateNasSystem.
        internal void ProcessRecord_UpdateNasSystem()
        {
            this._logger.name += " -UpdateNasSystem";
            // Create new graphql operation updateNasSystem
            InitMutationUpdateNasSystem();
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
                Mutation.BulkDeleteNasSystems_ObjectFieldSpec,
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
                Mutation.DeleteNasSystem_ObjectFieldSpec,
                Mutation.DeleteNasSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.RefreshNasSystems_ObjectFieldSpec,
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
                Mutation.RegisterNasSystem_ObjectFieldSpec,
                Mutation.RegisterNasSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	nasSystem = @{
		# OPTIONAL
		genericNasSystemParameters = @{
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# REQUIRED
			hasNfsSupport = $someBoolean
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
		# OPTIONAL
		isIsilonChangelistEnabled = $someBoolean
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
		nasFlashBladeApiCredentials = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# REQUIRED
			apiToken = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
		# OPTIONAL
		smbCredentials = @{
			# OPTIONAL
			password = $someString
			# REQUIRED
			username = $someString
		}
		# OPTIONAL
		nutanixFileServerParameters = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# OPTIONAL
			apiPassword = $someString
			# OPTIONAL
			apiUsername = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
		# REQUIRED
		nasVendorType = $someNasVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NasVendorType]) for enum values.
		# REQUIRED
		hostname = $someString
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
                Mutation.UpdateNasSystem_ObjectFieldSpec,
                Mutation.UpdateNasSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	nasSystemUpdateProperties = @{
		# OPTIONAL
		genericNasSystemParameters = @{
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# REQUIRED
			hasNfsSupport = $someBoolean
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		isIsilonChangelistEnabled = $someBoolean
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
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# REQUIRED
			apiToken = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
		# OPTIONAL
		smbCredentials = @{
			# OPTIONAL
			password = $someString
			# REQUIRED
			username = $someString
		}
		# OPTIONAL
		nutanixFileServerParameters = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# OPTIONAL
			apiPassword = $someString
			# OPTIONAL
			apiUsername = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
	}
}"
            );
        }


    } // class New_RscMutationNas
}