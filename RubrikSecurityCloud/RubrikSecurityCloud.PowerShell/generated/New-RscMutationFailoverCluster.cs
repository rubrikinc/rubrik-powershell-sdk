// New-RscMutationFailoverCluster.cs
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
    /// Create a new RscQuery object for any of the 8
    /// operations in the 'Failover Cluster' API domain:
    /// BulkDelete, BulkDeleteApp, Create, CreateApp, Delete, DeleteApp, Update, or UpdateApp.
    /// </summary>
    /// <description>
    /// New-RscMutationFailoverCluster creates a new
    /// mutation object for operations
    /// in the 'Failover Cluster' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 8 operations
    /// in the 'Failover Cluster' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BulkDelete, BulkDeleteApp, Create, CreateApp, Delete, DeleteApp, Update, or UpdateApp.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationFailoverCluster -BulkDelete).Info().
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
    /// (New-RscMutationFailoverCluster -BulkDelete).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BulkDelete operation
    /// of the 'Failover Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    FailoverCluster
    /// # API Operation: BulkDelete
    /// 
    /// $query = New-RscMutationFailoverCluster -BulkDelete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someString
    /// 	)
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
    /// Runs the BulkDeleteApp operation
    /// of the 'Failover Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    FailoverCluster
    /// # API Operation: BulkDeleteApp
    /// 
    /// $query = New-RscMutationFailoverCluster -BulkDeleteApp
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someString
    /// 	)
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
    /// Runs the Create operation
    /// of the 'Failover Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    FailoverCluster
    /// # API Operation: Create
    /// 
    /// $query = New-RscMutationFailoverCluster -Create
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# REQUIRED
    /// 		hostIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateFailoverClusterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateApp operation
    /// of the 'Failover Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    FailoverCluster
    /// # API Operation: CreateApp
    /// 
    /// $query = New-RscMutationFailoverCluster -CreateApp
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# REQUIRED
    /// 		failoverClusterType = $someFailoverClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverClusterType]) for enum values.
    /// 		# REQUIRED
    /// 		failoverClusterAppSource = @{
    /// 			# OPTIONAL
    /// 			nodeOrders = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					nodeName = $someString
    /// 					# REQUIRED
    /// 					nodeId = $someString
    /// 					# REQUIRED
    /// 					order = $someInt
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			virtualIps = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			vips = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 		# REQUIRED
    /// 		failoverClusterId = $someString
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateFailoverClusterAppReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Delete operation
    /// of the 'Failover Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    FailoverCluster
    /// # API Operation: Delete
    /// 
    /// $query = New-RscMutationFailoverCluster -Delete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// Runs the DeleteApp operation
    /// of the 'Failover Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    FailoverCluster
    /// # API Operation: DeleteApp
    /// 
    /// $query = New-RscMutationFailoverCluster -DeleteApp
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// Runs the Update operation
    /// of the 'Failover Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    FailoverCluster
    /// # API Operation: Update
    /// 
    /// $query = New-RscMutationFailoverCluster -Update
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	updateProperties = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# REQUIRED
    /// 		hostIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateFailoverClusterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateApp operation
    /// of the 'Failover Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    FailoverCluster
    /// # API Operation: UpdateApp
    /// 
    /// $query = New-RscMutationFailoverCluster -UpdateApp
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	updateProperties = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# REQUIRED
    /// 		failoverClusterType = $someFailoverClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverClusterType]) for enum values.
    /// 		# REQUIRED
    /// 		failoverClusterAppSource = @{
    /// 			# OPTIONAL
    /// 			nodeOrders = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					nodeName = $someString
    /// 					# REQUIRED
    /// 					nodeId = $someString
    /// 					# REQUIRED
    /// 					order = $someInt
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			virtualIps = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			vips = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 		# REQUIRED
    /// 		failoverClusterId = $someString
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateFailoverClusterAppReply
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
        "RscMutationFailoverCluster",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationFailoverCluster : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BulkDelete",
                "BulkDeleteApp",
                "Create",
                "CreateApp",
                "Delete",
                "DeleteApp",
                "Update",
                "UpdateApp",
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
                    case "BulkDelete":
                        this.ProcessRecord_BulkDelete();
                        break;
                    case "BulkDeleteApp":
                        this.ProcessRecord_BulkDeleteApp();
                        break;
                    case "Create":
                        this.ProcessRecord_Create();
                        break;
                    case "CreateApp":
                        this.ProcessRecord_CreateApp();
                        break;
                    case "Delete":
                        this.ProcessRecord_Delete();
                        break;
                    case "DeleteApp":
                        this.ProcessRecord_DeleteApp();
                        break;
                    case "Update":
                        this.ProcessRecord_Update();
                        break;
                    case "UpdateApp":
                        this.ProcessRecord_UpdateApp();
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
        // bulkDeleteFailoverCluster.
        internal void ProcessRecord_BulkDelete()
        {
            this._logger.name += " -BulkDelete";
            // Create new graphql operation bulkDeleteFailoverCluster
            InitMutationBulkDeleteFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteFailoverClusterApp.
        internal void ProcessRecord_BulkDeleteApp()
        {
            this._logger.name += " -BulkDeleteApp";
            // Create new graphql operation bulkDeleteFailoverClusterApp
            InitMutationBulkDeleteFailoverClusterApp();
        }

        // This parameter set invokes a single graphql operation:
        // createFailoverCluster.
        internal void ProcessRecord_Create()
        {
            this._logger.name += " -Create";
            // Create new graphql operation createFailoverCluster
            InitMutationCreateFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createFailoverClusterApp.
        internal void ProcessRecord_CreateApp()
        {
            this._logger.name += " -CreateApp";
            // Create new graphql operation createFailoverClusterApp
            InitMutationCreateFailoverClusterApp();
        }

        // This parameter set invokes a single graphql operation:
        // deleteFailoverCluster.
        internal void ProcessRecord_Delete()
        {
            this._logger.name += " -Delete";
            // Create new graphql operation deleteFailoverCluster
            InitMutationDeleteFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteFailoverClusterApp.
        internal void ProcessRecord_DeleteApp()
        {
            this._logger.name += " -DeleteApp";
            // Create new graphql operation deleteFailoverClusterApp
            InitMutationDeleteFailoverClusterApp();
        }

        // This parameter set invokes a single graphql operation:
        // updateFailoverCluster.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Create new graphql operation updateFailoverCluster
            InitMutationUpdateFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateFailoverClusterApp.
        internal void ProcessRecord_UpdateApp()
        {
            this._logger.name += " -UpdateApp";
            // Create new graphql operation updateFailoverClusterApp
            InitMutationUpdateFailoverClusterApp();
        }


        // Create new GraphQL Mutation:
        // bulkDeleteFailoverCluster(input: BulkDeleteFailoverClusterInput!): ResponseSuccess!
        internal void InitMutationBulkDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteFailoverCluster",
                "($input: BulkDeleteFailoverClusterInput!)",
                "ResponseSuccess",
                Mutation.BulkDeleteFailoverCluster,
                Mutation.BulkDeleteFailoverClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	ids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteFailoverClusterApp(input: BulkDeleteFailoverClusterAppInput!): ResponseSuccess!
        internal void InitMutationBulkDeleteFailoverClusterApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFailoverClusterAppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteFailoverClusterApp",
                "($input: BulkDeleteFailoverClusterAppInput!)",
                "ResponseSuccess",
                Mutation.BulkDeleteFailoverClusterApp,
                Mutation.BulkDeleteFailoverClusterAppFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	ids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createFailoverCluster(input: CreateFailoverClusterInput!): CreateFailoverClusterReply!
        internal void InitMutationCreateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateFailoverCluster",
                "($input: CreateFailoverClusterInput!)",
                "CreateFailoverClusterReply",
                Mutation.CreateFailoverCluster,
                Mutation.CreateFailoverClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# REQUIRED
		hostIds = @(
			$someString
		)
		# REQUIRED
		name = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createFailoverClusterApp(input: CreateFailoverClusterAppInput!): CreateFailoverClusterAppReply!
        internal void InitMutationCreateFailoverClusterApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateFailoverClusterAppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateFailoverClusterApp",
                "($input: CreateFailoverClusterAppInput!)",
                "CreateFailoverClusterAppReply",
                Mutation.CreateFailoverClusterApp,
                Mutation.CreateFailoverClusterAppFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# REQUIRED
		failoverClusterType = $someFailoverClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverClusterType]) for enum values.
		# REQUIRED
		failoverClusterAppSource = @{
			# OPTIONAL
			nodeOrders = @(
				@{
					# OPTIONAL
					nodeName = $someString
					# REQUIRED
					nodeId = $someString
					# REQUIRED
					order = $someInt
				}
			)
			# OPTIONAL
			virtualIps = @(
				$someString
			)
			# OPTIONAL
			vips = @(
				$someString
			)
		}
		# REQUIRED
		failoverClusterId = $someString
		# REQUIRED
		name = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteFailoverCluster(input: DeleteFailoverClusterInput!): ResponseSuccess!
        internal void InitMutationDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteFailoverCluster",
                "($input: DeleteFailoverClusterInput!)",
                "ResponseSuccess",
                Mutation.DeleteFailoverCluster,
                Mutation.DeleteFailoverClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteFailoverClusterApp(input: DeleteFailoverClusterAppInput!): ResponseSuccess!
        internal void InitMutationDeleteFailoverClusterApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteFailoverClusterAppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteFailoverClusterApp",
                "($input: DeleteFailoverClusterAppInput!)",
                "ResponseSuccess",
                Mutation.DeleteFailoverClusterApp,
                Mutation.DeleteFailoverClusterAppFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateFailoverCluster(input: UpdateFailoverClusterInput!): UpdateFailoverClusterReply!
        internal void InitMutationUpdateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateFailoverCluster",
                "($input: UpdateFailoverClusterInput!)",
                "UpdateFailoverClusterReply",
                Mutation.UpdateFailoverCluster,
                Mutation.UpdateFailoverClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# REQUIRED
		hostIds = @(
			$someString
		)
		# REQUIRED
		name = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateFailoverClusterApp(input: UpdateFailoverClusterAppInput!): UpdateFailoverClusterAppReply!
        internal void InitMutationUpdateFailoverClusterApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateFailoverClusterAppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateFailoverClusterApp",
                "($input: UpdateFailoverClusterAppInput!)",
                "UpdateFailoverClusterAppReply",
                Mutation.UpdateFailoverClusterApp,
                Mutation.UpdateFailoverClusterAppFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# REQUIRED
		failoverClusterType = $someFailoverClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverClusterType]) for enum values.
		# REQUIRED
		failoverClusterAppSource = @{
			# OPTIONAL
			nodeOrders = @(
				@{
					# OPTIONAL
					nodeName = $someString
					# REQUIRED
					nodeId = $someString
					# REQUIRED
					order = $someInt
				}
			)
			# OPTIONAL
			virtualIps = @(
				$someString
			)
			# OPTIONAL
			vips = @(
				$someString
			)
		}
		# REQUIRED
		failoverClusterId = $someString
		# REQUIRED
		name = $someString
	}
}"
            );
        }


    } // class New_RscMutationFailoverCluster
}