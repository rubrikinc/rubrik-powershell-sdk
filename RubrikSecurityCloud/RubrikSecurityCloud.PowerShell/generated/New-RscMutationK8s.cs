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
    /// Create a new RscQuery object for any of the 17
    /// operations in the 'Kubernetes' API domain:
    /// AddCluster, AddProtectionSet, ArchiveCluster, CreateAgentManifest, CreateCluster, CreateNamespaceSnapshots, CreateProtectionSetSnapshot, DeleteCluster, DeleteProtectionSet, ExportNamespace, ExportProtectionSetSnapshot, RefreshCluster, RefreshV2Cluster, RestoreNamespace, RestoreProtectionSetSnapshot, UpdateCluster, or UpdateProtectionSet.
    /// </summary>
    /// <description>
    /// New-RscMutationK8s creates a new
    /// mutation object for operations
    /// in the 'Kubernetes' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 17 operations
    /// in the 'Kubernetes' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddCluster, AddProtectionSet, ArchiveCluster, CreateAgentManifest, CreateCluster, CreateNamespaceSnapshots, CreateProtectionSetSnapshot, DeleteCluster, DeleteProtectionSet, ExportNamespace, ExportProtectionSetSnapshot, RefreshCluster, RefreshV2Cluster, RestoreNamespace, RestoreProtectionSetSnapshot, UpdateCluster, or UpdateProtectionSet.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationK8s -AddCluster).Info().
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
    /// (New-RscMutationK8s -AddCluster).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddCluster operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: AddCluster
    /// 
    /// $query = New-RscMutationK8s -AddCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		id = $someString
    /// 		# OPTIONAL
    /// 		kubeconfig = $someString
    /// 		# OPTIONAL
    /// 		registry = $someString
    /// 		# OPTIONAL
    /// 		serviceAccountName = $someString
    /// 		# OPTIONAL
    /// 		eksConfig = @{
    /// 			# REQUIRED
    /// 			cloudAccountId = $someString
    /// 			# REQUIRED
    /// 			eksClusterArn = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		distribution = $someString
    /// 		# OPTIONAL
    /// 		clientSecret = $someString
    /// 		# OPTIONAL
    /// 		accessToken = $someString
    /// 		# OPTIONAL
    /// 		region = $someString
    /// 		# OPTIONAL
    /// 		clientId = $someString
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: K8sClusterSummary
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddProtectionSet operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: AddProtectionSet
    /// 
    /// $query = New-RscMutationK8s -AddProtectionSet
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		kubernetesNamespace = $someString
    /// 		# OPTIONAL
    /// 		hookConfigs = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		definition = $someString
    /// 		# REQUIRED
    /// 		kubernetesClusterId = $someString
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		rsType = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: K8sProtectionSetSummary
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
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
    /// Runs the CreateProtectionSetSnapshot operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: CreateProtectionSetSnapshot
    /// 
    /// $query = New-RscMutationK8s -CreateProtectionSetSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
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
    /// Runs the DeleteCluster operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: DeleteCluster
    /// 
    /// $query = New-RscMutationK8s -DeleteCluster
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
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteProtectionSet operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: DeleteProtectionSet
    /// 
    /// $query = New-RscMutationK8s -DeleteProtectionSet
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
    /// Runs the ExportProtectionSetSnapshot operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: ExportProtectionSetSnapshot
    /// 
    /// $query = New-RscMutationK8s -ExportProtectionSetSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	jobConfig = @{
    /// 		# OPTIONAL
    /// 		filter = $someString
    /// 		# OPTIONAL
    /// 		pvcNames = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		shouldDeleteNamespaceIfExportFailed = $someBoolean
    /// 		# OPTIONAL
    /// 		ignoreErrors = $someBoolean
    /// 		# REQUIRED
    /// 		targetClusterId = $someString
    /// 		# REQUIRED
    /// 		targetNamespaceName = $someString
    /// 	}
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
    /// Runs the RefreshV2Cluster operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: RefreshV2Cluster
    /// 
    /// $query = New-RscMutationK8s -RefreshV2Cluster
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
    /// <example>
    /// Runs the RestoreProtectionSetSnapshot operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: RestoreProtectionSetSnapshot
    /// 
    /// $query = New-RscMutationK8s -RestoreProtectionSetSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	jobConfig = @{
    /// 		# OPTIONAL
    /// 		filter = $someString
    /// 		# OPTIONAL
    /// 		pvcNames = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		ignoreErrors = $someBoolean
    /// 	}
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
    /// Runs the UpdateCluster operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: UpdateCluster
    /// 
    /// $query = New-RscMutationK8s -UpdateCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		kubeconfig = $someString
    /// 		# OPTIONAL
    /// 		registry = $someString
    /// 		# OPTIONAL
    /// 		serviceAccountName = $someString
    /// 		# OPTIONAL
    /// 		clientSecret = $someString
    /// 		# OPTIONAL
    /// 		accessToken = $someString
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 		# OPTIONAL
    /// 		clientId = $someString
    /// 	}
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
    /// Runs the UpdateProtectionSet operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: UpdateProtectionSet
    /// 
    /// $query = New-RscMutationK8s -UpdateProtectionSet
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		definition = $someString
    /// 		# OPTIONAL
    /// 		hookConfigs = @(
    /// 			$someString
    /// 		)
    /// 	}
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationK8s",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationK8s : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddCluster",
                "AddProtectionSet",
                "ArchiveCluster",
                "CreateAgentManifest",
                "CreateCluster",
                "CreateNamespaceSnapshots",
                "CreateProtectionSetSnapshot",
                "DeleteCluster",
                "DeleteProtectionSet",
                "ExportNamespace",
                "ExportProtectionSetSnapshot",
                "RefreshCluster",
                "RefreshV2Cluster",
                "RestoreNamespace",
                "RestoreProtectionSetSnapshot",
                "UpdateCluster",
                "UpdateProtectionSet",
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
                    case "AddCluster":
                        this.ProcessRecord_AddCluster();
                        break;
                    case "AddProtectionSet":
                        this.ProcessRecord_AddProtectionSet();
                        break;
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
                    case "CreateProtectionSetSnapshot":
                        this.ProcessRecord_CreateProtectionSetSnapshot();
                        break;
                    case "DeleteCluster":
                        this.ProcessRecord_DeleteCluster();
                        break;
                    case "DeleteProtectionSet":
                        this.ProcessRecord_DeleteProtectionSet();
                        break;
                    case "ExportNamespace":
                        this.ProcessRecord_ExportNamespace();
                        break;
                    case "ExportProtectionSetSnapshot":
                        this.ProcessRecord_ExportProtectionSetSnapshot();
                        break;
                    case "RefreshCluster":
                        this.ProcessRecord_RefreshCluster();
                        break;
                    case "RefreshV2Cluster":
                        this.ProcessRecord_RefreshV2Cluster();
                        break;
                    case "RestoreNamespace":
                        this.ProcessRecord_RestoreNamespace();
                        break;
                    case "RestoreProtectionSetSnapshot":
                        this.ProcessRecord_RestoreProtectionSetSnapshot();
                        break;
                    case "UpdateCluster":
                        this.ProcessRecord_UpdateCluster();
                        break;
                    case "UpdateProtectionSet":
                        this.ProcessRecord_UpdateProtectionSet();
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
        // addK8sCluster.
        internal void ProcessRecord_AddCluster()
        {
            this._logger.name += " -AddCluster";
            // Create new graphql operation addK8sCluster
            InitMutationAddK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // addK8sProtectionSet.
        internal void ProcessRecord_AddProtectionSet()
        {
            this._logger.name += " -AddProtectionSet";
            // Create new graphql operation addK8sProtectionSet
            InitMutationAddK8sProtectionSet();
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
        // createK8sProtectionSetSnapshot.
        internal void ProcessRecord_CreateProtectionSetSnapshot()
        {
            this._logger.name += " -CreateProtectionSetSnapshot";
            // Create new graphql operation createK8sProtectionSetSnapshot
            InitMutationCreateK8sProtectionSetSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteK8sCluster.
        internal void ProcessRecord_DeleteCluster()
        {
            this._logger.name += " -DeleteCluster";
            // Create new graphql operation deleteK8sCluster
            InitMutationDeleteK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteK8sProtectionSet.
        internal void ProcessRecord_DeleteProtectionSet()
        {
            this._logger.name += " -DeleteProtectionSet";
            // Create new graphql operation deleteK8sProtectionSet
            InitMutationDeleteK8sProtectionSet();
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
        // exportK8sProtectionSetSnapshot.
        internal void ProcessRecord_ExportProtectionSetSnapshot()
        {
            this._logger.name += " -ExportProtectionSetSnapshot";
            // Create new graphql operation exportK8sProtectionSetSnapshot
            InitMutationExportK8sProtectionSetSnapshot();
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
        // refreshK8sV2Cluster.
        internal void ProcessRecord_RefreshV2Cluster()
        {
            this._logger.name += " -RefreshV2Cluster";
            // Create new graphql operation refreshK8sV2Cluster
            InitMutationRefreshK8sV2Cluster();
        }

        // This parameter set invokes a single graphql operation:
        // restoreK8sNamespace.
        internal void ProcessRecord_RestoreNamespace()
        {
            this._logger.name += " -RestoreNamespace";
            // Create new graphql operation restoreK8sNamespace
            InitMutationRestoreK8sNamespace();
        }

        // This parameter set invokes a single graphql operation:
        // restoreK8sProtectionSetSnapshot.
        internal void ProcessRecord_RestoreProtectionSetSnapshot()
        {
            this._logger.name += " -RestoreProtectionSetSnapshot";
            // Create new graphql operation restoreK8sProtectionSetSnapshot
            InitMutationRestoreK8sProtectionSetSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // updateK8sCluster.
        internal void ProcessRecord_UpdateCluster()
        {
            this._logger.name += " -UpdateCluster";
            // Create new graphql operation updateK8sCluster
            InitMutationUpdateK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateK8sProtectionSet.
        internal void ProcessRecord_UpdateProtectionSet()
        {
            this._logger.name += " -UpdateProtectionSet";
            // Create new graphql operation updateK8sProtectionSet
            InitMutationUpdateK8sProtectionSet();
        }


        // Create new GraphQL Mutation:
        // addK8sCluster(input: AddK8sClusterInput!): K8sClusterSummary!
        internal void InitMutationAddK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddK8sCluster",
                "($input: AddK8sClusterInput!)",
                "K8sClusterSummary",
                Mutation.AddK8sCluster,
                Mutation.AddK8sClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		id = $someString
		# OPTIONAL
		kubeconfig = $someString
		# OPTIONAL
		registry = $someString
		# OPTIONAL
		serviceAccountName = $someString
		# OPTIONAL
		eksConfig = @{
			# REQUIRED
			cloudAccountId = $someString
			# REQUIRED
			eksClusterArn = $someString
		}
		# OPTIONAL
		distribution = $someString
		# OPTIONAL
		clientSecret = $someString
		# OPTIONAL
		accessToken = $someString
		# OPTIONAL
		region = $someString
		# OPTIONAL
		clientId = $someString
		# REQUIRED
		name = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // addK8sProtectionSet(input: AddK8sProtectionSetInput!): K8sProtectionSetSummary!
        internal void InitMutationAddK8sProtectionSet()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddK8sProtectionSetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddK8sProtectionSet",
                "($input: AddK8sProtectionSetInput!)",
                "K8sProtectionSetSummary",
                Mutation.AddK8sProtectionSet,
                Mutation.AddK8sProtectionSetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		kubernetesNamespace = $someString
		# OPTIONAL
		hookConfigs = @(
			$someString
		)
		# REQUIRED
		definition = $someString
		# REQUIRED
		kubernetesClusterId = $someString
		# REQUIRED
		name = $someString
		# REQUIRED
		rsType = $someString
	}
}"
            );
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
                Mutation.ArchiveK8sCluster,
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
                Mutation.CreateK8sAgentManifest,
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
                Mutation.CreateK8sCluster,
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
                Mutation.CreateK8sNamespaceSnapshots,
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
        // createK8sProtectionSetSnapshot(input: CreateK8sProtectionSetSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationCreateK8sProtectionSetSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateK8sProtectionSetSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateK8sProtectionSetSnapshot",
                "($input: CreateK8sProtectionSetSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.CreateK8sProtectionSetSnapshot,
                Mutation.CreateK8sProtectionSetSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteK8sCluster(input: DeleteK8sClusterInput!): AsyncRequestStatus!
        internal void InitMutationDeleteK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteK8sCluster",
                "($input: DeleteK8sClusterInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteK8sCluster,
                Mutation.DeleteK8sClusterFieldSpec,
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
        // deleteK8sProtectionSet(input: DeleteK8sProtectionSetInput!): ResponseSuccess!
        internal void InitMutationDeleteK8sProtectionSet()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteK8sProtectionSetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteK8sProtectionSet",
                "($input: DeleteK8sProtectionSetInput!)",
                "ResponseSuccess",
                Mutation.DeleteK8sProtectionSet,
                Mutation.DeleteK8sProtectionSetFieldSpec,
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
                Mutation.ExportK8sNamespace,
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
        // exportK8sProtectionSetSnapshot(input: ExportK8sProtectionSetSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationExportK8sProtectionSetSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportK8sProtectionSetSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportK8sProtectionSetSnapshot",
                "($input: ExportK8sProtectionSetSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.ExportK8sProtectionSetSnapshot,
                Mutation.ExportK8sProtectionSetSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	jobConfig = @{
		# OPTIONAL
		filter = $someString
		# OPTIONAL
		pvcNames = @(
			$someString
		)
		# OPTIONAL
		shouldDeleteNamespaceIfExportFailed = $someBoolean
		# OPTIONAL
		ignoreErrors = $someBoolean
		# REQUIRED
		targetClusterId = $someString
		# REQUIRED
		targetNamespaceName = $someString
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
                Mutation.RefreshK8sCluster,
                Mutation.RefreshK8sClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	k8sClusterId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshK8sV2Cluster(input: RefreshK8sV2ClusterInput!): AsyncRequestStatus!
        internal void InitMutationRefreshK8sV2Cluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshK8sV2ClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshK8sV2Cluster",
                "($input: RefreshK8sV2ClusterInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshK8sV2Cluster,
                Mutation.RefreshK8sV2ClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.RestoreK8sNamespace,
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

        // Create new GraphQL Mutation:
        // restoreK8sProtectionSetSnapshot(input: CreateK8sRestoreJobInput!): AsyncRequestStatus!
        internal void InitMutationRestoreK8sProtectionSetSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateK8sRestoreJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreK8sProtectionSetSnapshot",
                "($input: CreateK8sRestoreJobInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreK8sProtectionSetSnapshot,
                Mutation.RestoreK8sProtectionSetSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	jobConfig = @{
		# OPTIONAL
		filter = $someString
		# OPTIONAL
		pvcNames = @(
			$someString
		)
		# OPTIONAL
		ignoreErrors = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateK8sCluster(input: UpdateK8sClusterInput!): ResponseSuccess!
        internal void InitMutationUpdateK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateK8sCluster",
                "($input: UpdateK8sClusterInput!)",
                "ResponseSuccess",
                Mutation.UpdateK8sCluster,
                Mutation.UpdateK8sClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		kubeconfig = $someString
		# OPTIONAL
		registry = $someString
		# OPTIONAL
		serviceAccountName = $someString
		# OPTIONAL
		clientSecret = $someString
		# OPTIONAL
		accessToken = $someString
		# OPTIONAL
		cloudAccountId = $someString
		# OPTIONAL
		clientId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateK8sProtectionSet(input: UpdateK8sProtectionSetInput!): ResponseSuccess!
        internal void InitMutationUpdateK8sProtectionSet()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateK8sProtectionSetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateK8sProtectionSet",
                "($input: UpdateK8sProtectionSetInput!)",
                "ResponseSuccess",
                Mutation.UpdateK8sProtectionSet,
                Mutation.UpdateK8sProtectionSetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		definition = $someString
		# OPTIONAL
		hookConfigs = @(
			$someString
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationK8s
}