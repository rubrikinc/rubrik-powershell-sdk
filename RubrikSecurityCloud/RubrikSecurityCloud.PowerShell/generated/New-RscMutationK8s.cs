// New-RscMutationK8s.cs
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
    /// Create a new RscQuery object for any of the 7
    /// operations in the 'Kubernetes' API domain:
    /// ArchiveCluster, CreateAgentManifest, CreateCluster, CreateNamespaceSnapshots, ExportNamespace, RefreshCluster, or RestoreNamespace.
    /// </summary>
    /// <description>
    /// New-RscMutationK8s creates a new
    /// mutation object for operations
    /// in the 'Kubernetes' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 7 operations
    /// in the 'Kubernetes' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -ArchiveCluster, -CreateAgentManifest, -CreateCluster, -CreateNamespaceSnapshots, -ExportNamespace, -RefreshCluster, -RestoreNamespace.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op ArchiveCluster,
    /// which is equivalent to specifying -ArchiveCluster.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationK8s -ArchiveCluster).Info().
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
    /// (New-RscMutationK8s -ArchiveCluster).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ArchiveCluster operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: ArchiveCluster
    /// 
    /// $query = New-RscMutationK8s -ArchiveCluster
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
    /// Write-Host $result.GetType().Name # prints: ArchiveK8sClusterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateAgentManifest operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: CreateAgentManifest
    /// 
    /// $query = New-RscMutationK8s -CreateAgentManifest
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterId = $someString
    /// 	# REQUIRED
    /// 	timeoutMinutes = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateK8sAgentManifestReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCluster operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: CreateCluster
    /// 
    /// $query = New-RscMutationK8s -CreateCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cdmClusterId = $someString
    /// 	# REQUIRED
    /// 	hostList = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	port = $someInt
    /// 	# REQUIRED
    /// 	rbsPortRanges = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			portMin = $someInt
    /// 			# OPTIONAL
    /// 			portMax = $someInt
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	userDrivenPortRanges = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			portMin = $someInt
    /// 			# OPTIONAL
    /// 			portMax = $someInt
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	type = $someK8sClusterProtoType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.K8sClusterProtoType]) for enum values.
    /// 	# OPTIONAL
    /// 	proxyUrl = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateK8sClusterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateNamespaceSnapshots operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: CreateNamespaceSnapshots
    /// 
    /// $query = New-RscMutationK8s -CreateNamespaceSnapshots
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotInput = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			namespaceId = $someString
    /// 			# OPTIONAL
    /// 			onDemandSnapshotSlaId = $someString
    /// 		}
    /// 	)
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
    /// Runs the ExportNamespace operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: ExportNamespace
    /// 
    /// $query = New-RscMutationK8s -ExportNamespace
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotUuid = $someString
    /// 	# REQUIRED
    /// 	targetClusterUuid = $someString
    /// 	# REQUIRED
    /// 	targetNamespaceName = $someString
    /// 	# OPTIONAL
    /// 	labelSelector = @{
    /// 		# OPTIONAL
    /// 		matchExpressions = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				key = $someString
    /// 				# OPTIONAL
    /// 				operator = $someString
    /// 				# OPTIONAL
    /// 				values = @(
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
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshCluster operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: RefreshCluster
    /// 
    /// $query = New-RscMutationK8s -RefreshCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	k8sClusterId = $someString
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
    /// Runs the RestoreNamespace operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: RestoreNamespace
    /// 
    /// $query = New-RscMutationK8s -RestoreNamespace
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotUuid = $someString
    /// 	# REQUIRED
    /// 	targetClusterUuid = $someString
    /// 	# REQUIRED
    /// 	targetNamespaceName = $someString
    /// 	# OPTIONAL
    /// 	labelSelector = @{
    /// 		# OPTIONAL
    /// 		matchExpressions = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				key = $someString
    /// 				# OPTIONAL
    /// 				operator = $someString
    /// 				# OPTIONAL
    /// 				values = @(
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
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
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
        "RscMutationK8s",
        DefaultParameterSetName = "CreateCluster")
    ]
    public class New_RscMutationK8s : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "ArchiveCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ArchiveCluster' operation
in the 'Kubernetes' API domain.
Description of the operation:
Archive a Kubernetes cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/archivek8scluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ArchiveCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateAgentManifest",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateAgentManifest' operation
in the 'Kubernetes' API domain.
Description of the operation:
Create a Rubrik Kubernetes agent manifest.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createk8sagentmanifest.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateAgentManifest { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateCluster' operation
in the 'Kubernetes' API domain.
Description of the operation:
Add a Kubernetes cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createk8scluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateNamespaceSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateNamespaceSnapshots' operation
in the 'Kubernetes' API domain.
Description of the operation:
Snapshot Kubernetes Namespace.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createk8snamespacesnapshots.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateNamespaceSnapshots { get; set; }

        
        [Parameter(
            ParameterSetName = "ExportNamespace",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ExportNamespace' operation
in the 'Kubernetes' API domain.
Description of the operation:
Export Kubernetes Namespace snapshot.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/exportk8snamespace.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ExportNamespace { get; set; }

        
        [Parameter(
            ParameterSetName = "RefreshCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RefreshCluster' operation
in the 'Kubernetes' API domain.
Description of the operation:
Refresh resources of a Kubernetes cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/refreshk8scluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RefreshCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "RestoreNamespace",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RestoreNamespace' operation
in the 'Kubernetes' API domain.
Description of the operation:
Restores Kubernetes namespace snapshot.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/restorek8snamespace.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RestoreNamespace { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "ArchiveCluster":
                        this.ProcessRecord_ArchiveCluster();
                        break;
                    case "CreateAgentManifest":
                        this.ProcessRecord_CreateAgentManifest();
                        break;
                    case "CreateCluster":
                        this.ProcessRecord_CreateCluster();
                        break;
                    case "CreateNamespaceSnapshots":
                        this.ProcessRecord_CreateNamespaceSnapshots();
                        break;
                    case "ExportNamespace":
                        this.ProcessRecord_ExportNamespace();
                        break;
                    case "RefreshCluster":
                        this.ProcessRecord_RefreshCluster();
                        break;
                    case "RestoreNamespace":
                        this.ProcessRecord_RestoreNamespace();
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
        // archiveK8sCluster.
        internal void ProcessRecord_ArchiveCluster()
        {
            this._logger.name += " -ArchiveCluster";
            // Create new graphql operation archiveK8sCluster
            InitMutationArchiveK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createK8sAgentManifest.
        internal void ProcessRecord_CreateAgentManifest()
        {
            this._logger.name += " -CreateAgentManifest";
            // Create new graphql operation createK8sAgentManifest
            InitMutationCreateK8sAgentManifest();
        }

        // This parameter set invokes a single graphql operation:
        // createK8sCluster.
        internal void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Create new graphql operation createK8sCluster
            InitMutationCreateK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createK8sNamespaceSnapshots.
        internal void ProcessRecord_CreateNamespaceSnapshots()
        {
            this._logger.name += " -CreateNamespaceSnapshots";
            // Create new graphql operation createK8sNamespaceSnapshots
            InitMutationCreateK8sNamespaceSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // exportK8sNamespace.
        internal void ProcessRecord_ExportNamespace()
        {
            this._logger.name += " -ExportNamespace";
            // Create new graphql operation exportK8sNamespace
            InitMutationExportK8sNamespace();
        }

        // This parameter set invokes a single graphql operation:
        // refreshK8sCluster.
        internal void ProcessRecord_RefreshCluster()
        {
            this._logger.name += " -RefreshCluster";
            // Create new graphql operation refreshK8sCluster
            InitMutationRefreshK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // restoreK8sNamespace.
        internal void ProcessRecord_RestoreNamespace()
        {
            this._logger.name += " -RestoreNamespace";
            // Create new graphql operation restoreK8sNamespace
            InitMutationRestoreK8sNamespace();
        }


        // Create new GraphQL Mutation:
        // archiveK8sCluster(input: ArchiveK8sClusterInput!): ArchiveK8sClusterReply!
        internal void InitMutationArchiveK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ArchiveK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationArchiveK8sCluster",
                "($input: ArchiveK8sClusterInput!)",
                "ArchiveK8sClusterReply",
                Mutation.ArchiveK8sCluster_ObjectFieldSpec,
                Mutation.ArchiveK8sClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createK8sAgentManifest(input: CreateK8sAgentManifestInput!): CreateK8sAgentManifestReply!
        internal void InitMutationCreateK8sAgentManifest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateK8sAgentManifestInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateK8sAgentManifest",
                "($input: CreateK8sAgentManifestInput!)",
                "CreateK8sAgentManifestReply",
                Mutation.CreateK8sAgentManifest_ObjectFieldSpec,
                Mutation.CreateK8sAgentManifestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterId = $someString
	# REQUIRED
	timeoutMinutes = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // createK8sCluster(input: CreateK8sClusterInput!): CreateK8sClusterReply!
        internal void InitMutationCreateK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateK8sCluster",
                "($input: CreateK8sClusterInput!)",
                "CreateK8sClusterReply",
                Mutation.CreateK8sCluster_ObjectFieldSpec,
                Mutation.CreateK8sClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cdmClusterId = $someString
	# REQUIRED
	hostList = @(
		$someString
	)
	# REQUIRED
	name = $someString
	# REQUIRED
	port = $someInt
	# REQUIRED
	rbsPortRanges = @(
		@{
			# OPTIONAL
			portMin = $someInt
			# OPTIONAL
			portMax = $someInt
		}
	)
	# OPTIONAL
	userDrivenPortRanges = @(
		@{
			# OPTIONAL
			portMin = $someInt
			# OPTIONAL
			portMax = $someInt
		}
	)
	# REQUIRED
	type = $someK8sClusterProtoType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.K8sClusterProtoType]) for enum values.
	# OPTIONAL
	proxyUrl = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createK8sNamespaceSnapshots(input: CreateK8sNamespaceSnapshotsInput!): [CreateOnDemandJobReply!]!
        internal void InitMutationCreateK8sNamespaceSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateK8sNamespaceSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateK8sNamespaceSnapshots",
                "($input: CreateK8sNamespaceSnapshotsInput!)",
                "List<CreateOnDemandJobReply>",
                Mutation.CreateK8sNamespaceSnapshots_ObjectFieldSpec,
                Mutation.CreateK8sNamespaceSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotInput = @(
		@{
			# REQUIRED
			namespaceId = $someString
			# OPTIONAL
			onDemandSnapshotSlaId = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportK8sNamespace(input: ExportK8sNamespaceInput!): CreateOnDemandJobReply!
        internal void InitMutationExportK8sNamespace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportK8sNamespaceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportK8sNamespace",
                "($input: ExportK8sNamespaceInput!)",
                "CreateOnDemandJobReply",
                Mutation.ExportK8sNamespace_ObjectFieldSpec,
                Mutation.ExportK8sNamespaceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotUuid = $someString
	# REQUIRED
	targetClusterUuid = $someString
	# REQUIRED
	targetNamespaceName = $someString
	# OPTIONAL
	labelSelector = @{
		# OPTIONAL
		matchExpressions = @(
			@{
				# OPTIONAL
				key = $someString
				# OPTIONAL
				operator = $someString
				# OPTIONAL
				values = @(
					$someString
				)
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshK8sCluster(input: RefreshK8sClusterInput!): CreateOnDemandJobReply!
        internal void InitMutationRefreshK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshK8sCluster",
                "($input: RefreshK8sClusterInput!)",
                "CreateOnDemandJobReply",
                Mutation.RefreshK8sCluster_ObjectFieldSpec,
                Mutation.RefreshK8sClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	k8sClusterId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreK8sNamespace(input: RestoreK8sNamespaceInput!): CreateOnDemandJobReply!
        internal void InitMutationRestoreK8sNamespace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreK8sNamespaceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreK8sNamespace",
                "($input: RestoreK8sNamespaceInput!)",
                "CreateOnDemandJobReply",
                Mutation.RestoreK8sNamespace_ObjectFieldSpec,
                Mutation.RestoreK8sNamespaceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotUuid = $someString
	# REQUIRED
	targetClusterUuid = $someString
	# REQUIRED
	targetNamespaceName = $someString
	# OPTIONAL
	labelSelector = @{
		# OPTIONAL
		matchExpressions = @(
			@{
				# OPTIONAL
				key = $someString
				# OPTIONAL
				operator = $someString
				# OPTIONAL
				values = @(
					$someString
				)
			}
		)
	}
}"
            );
        }


    } // class New_RscMutationK8s
}