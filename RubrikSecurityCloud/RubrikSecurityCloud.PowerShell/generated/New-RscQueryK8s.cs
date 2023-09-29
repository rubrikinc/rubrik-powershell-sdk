// New-RscQueryK8s.cs
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
    /// AppManifest, Cluster, Clusters, Namespace, Namespaces, ReplicaSnapshotInfos, or SnapshotInfo.
    /// </summary>
    /// <description>
    /// New-RscQueryK8s creates a new
    /// query object for operations
    /// in the 'Kubernetes' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 7 operations
    /// in the 'Kubernetes' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -AppManifest, -Cluster, -Clusters, -Namespace, -Namespaces, -ReplicaSnapshotInfos, -SnapshotInfo.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op AppManifest,
    /// which is equivalent to specifying -AppManifest.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryK8s -AppManifest).Info().
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
    /// (New-RscQueryK8s -AppManifest).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AppManifest operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: AppManifest
    /// 
    /// $query = New-RscQueryK8s -AppManifest
    /// 
    /// # REQUIRED
    /// $query.Var.app = $someString
    /// # REQUIRED
    /// $query.Var.version = $someString
    /// # REQUIRED
    /// $query.Var.retrieveLatestVersion = $someBoolean
    /// # OPTIONAL
    /// $query.Var.targetVersion = $someString
    /// # OPTIONAL
    /// $query.Var.k8sClusterId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: K8sAppManifest
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Cluster operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: Cluster
    /// 
    /// $query = New-RscQueryK8s -Cluster
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: K8sCluster
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Clusters operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: Clusters
    /// 
    /// $query = New-RscQueryK8s -Clusters
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: K8sClusterConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Namespace operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: Namespace
    /// 
    /// $query = New-RscQueryK8s -Namespace
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: K8sNamespace
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Namespaces operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: Namespaces
    /// 
    /// $query = New-RscQueryK8s -Namespaces
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.k8sClusterId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: K8sNamespaceConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ReplicaSnapshotInfos operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: ReplicaSnapshotInfos
    /// 
    /// $query = New-RscQueryK8s -ReplicaSnapshotInfos
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// # REQUIRED
    /// $query.Var.snappableId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ReplicatedSnapshotInfo&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnapshotInfo operation
    /// of the 'Kubernetes' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    K8s
    /// # API Operation: SnapshotInfo
    /// 
    /// $query = New-RscQueryK8s -SnapshotInfo
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// # REQUIRED
    /// $query.Var.namespaceId = $someString
    /// # REQUIRED
    /// $query.Var.isReplica = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: K8sSnapshotInfo
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
        "RscQueryK8s",
        DefaultParameterSetName = "Cluster")
    ]
    public class New_RscQueryK8s : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "AppManifest",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'AppManifest' operation
in the 'Kubernetes' API domain.
Description of the operation:
Kubernetes Rubrik Backup Service manifest.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/k8sappmanifest.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AppManifest { get; set; }

        
        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Cluster' operation
in the 'Kubernetes' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/k8scluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Cluster { get; set; }

        
        [Parameter(
            ParameterSetName = "Clusters",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Clusters' operation
in the 'Kubernetes' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/k8sclusters.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Clusters { get; set; }

        
        [Parameter(
            ParameterSetName = "Namespace",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Namespace' operation
in the 'Kubernetes' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/k8snamespace.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Namespace { get; set; }

        
        [Parameter(
            ParameterSetName = "Namespaces",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Namespaces' operation
in the 'Kubernetes' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/k8snamespaces.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Namespaces { get; set; }

        
        [Parameter(
            ParameterSetName = "ReplicaSnapshotInfos",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'ReplicaSnapshotInfos' operation
in the 'Kubernetes' API domain.
Description of the operation:
Information of all replicas for a Kubernetes snapshot.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allk8sreplicasnapshotinfos.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ReplicaSnapshotInfos { get; set; }

        
        [Parameter(
            ParameterSetName = "SnapshotInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'SnapshotInfo' operation
in the 'Kubernetes' API domain.
Description of the operation:
Kubernetes snapshot information.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/k8ssnapshotinfo.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter SnapshotInfo { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AppManifest":
                        this.ProcessRecord_AppManifest();
                        break;
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "Clusters":
                        this.ProcessRecord_Clusters();
                        break;
                    case "Namespace":
                        this.ProcessRecord_Namespace();
                        break;
                    case "Namespaces":
                        this.ProcessRecord_Namespaces();
                        break;
                    case "ReplicaSnapshotInfos":
                        this.ProcessRecord_ReplicaSnapshotInfos();
                        break;
                    case "SnapshotInfo":
                        this.ProcessRecord_SnapshotInfo();
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
        // k8sAppManifest.
        internal void ProcessRecord_AppManifest()
        {
            this._logger.name += " -AppManifest";
            // Create new graphql operation k8sAppManifest
            InitQueryK8sAppManifest();
        }

        // This parameter set invokes a single graphql operation:
        // k8sCluster.
        internal void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Create new graphql operation k8sCluster
            InitQueryK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // k8sClusters.
        internal void ProcessRecord_Clusters()
        {
            this._logger.name += " -Clusters";
            // Create new graphql operation k8sClusters
            InitQueryK8sClusters();
        }

        // This parameter set invokes a single graphql operation:
        // k8sNamespace.
        internal void ProcessRecord_Namespace()
        {
            this._logger.name += " -Namespace";
            // Create new graphql operation k8sNamespace
            InitQueryK8sNamespace();
        }

        // This parameter set invokes a single graphql operation:
        // k8sNamespaces.
        internal void ProcessRecord_Namespaces()
        {
            this._logger.name += " -Namespaces";
            // Create new graphql operation k8sNamespaces
            InitQueryK8sNamespaces();
        }

        // This parameter set invokes a single graphql operation:
        // allK8sReplicaSnapshotInfos.
        internal void ProcessRecord_ReplicaSnapshotInfos()
        {
            this._logger.name += " -ReplicaSnapshotInfos";
            // Create new graphql operation allK8sReplicaSnapshotInfos
            InitQueryAllK8sReplicaSnapshotInfos();
        }

        // This parameter set invokes a single graphql operation:
        // k8sSnapshotInfo.
        internal void ProcessRecord_SnapshotInfo()
        {
            this._logger.name += " -SnapshotInfo";
            // Create new graphql operation k8sSnapshotInfo
            InitQueryK8sSnapshotInfo();
        }


        // Create new GraphQL Query:
        // k8sAppManifest(
        //     app: String!
        //     version: String!
        //     retrieveLatestVersion: Boolean!
        //     targetVersion: String
        //     k8sClusterId: UUID
        //   ): K8sAppManifest!
        internal void InitQueryK8sAppManifest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("app", "String!"),
                Tuple.Create("version", "String!"),
                Tuple.Create("retrieveLatestVersion", "Boolean!"),
                Tuple.Create("targetVersion", "String"),
                Tuple.Create("k8sClusterId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryK8sAppManifest",
                "($app: String!,$version: String!,$retrieveLatestVersion: Boolean!,$targetVersion: String,$k8sClusterId: UUID)",
                "K8sAppManifest",
                Query.K8sAppManifest_ObjectFieldSpec,
                Query.K8sAppManifestFieldSpec,
                @"# REQUIRED
$query.Var.app = $someString
# REQUIRED
$query.Var.version = $someString
# REQUIRED
$query.Var.retrieveLatestVersion = $someBoolean
# OPTIONAL
$query.Var.targetVersion = $someString
# OPTIONAL
$query.Var.k8sClusterId = $someString"
            );
        }

        // Create new GraphQL Query:
        // k8sCluster(fid: UUID!): K8sCluster!
        internal void InitQueryK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryK8sCluster",
                "($fid: UUID!)",
                "K8sCluster",
                Query.K8sCluster_ObjectFieldSpec,
                Query.K8sClusterFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // k8sClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): K8sClusterConnection!
        internal void InitQueryK8sClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryK8sClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "K8sClusterConnection",
                Query.K8sClusters_ObjectFieldSpec,
                Query.K8sClustersFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // k8sNamespace(fid: UUID!): K8sNamespace!
        internal void InitQueryK8sNamespace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryK8sNamespace",
                "($fid: UUID!)",
                "K8sNamespace",
                Query.K8sNamespace_ObjectFieldSpec,
                Query.K8sNamespaceFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // k8sNamespaces(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     k8sClusterId: UUID
        //   ): K8sNamespaceConnection!
        internal void InitQueryK8sNamespaces()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("k8sClusterId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryK8sNamespaces",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$k8sClusterId: UUID)",
                "K8sNamespaceConnection",
                Query.K8sNamespaces_ObjectFieldSpec,
                Query.K8sNamespacesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# OPTIONAL
$query.Var.k8sClusterId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allK8sReplicaSnapshotInfos(snapshotId: String!, snappableId: UUID!): [ReplicatedSnapshotInfo!]!
        internal void InitQueryAllK8sReplicaSnapshotInfos()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "String!"),
                Tuple.Create("snappableId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllK8sReplicaSnapshotInfos",
                "($snapshotId: String!,$snappableId: UUID!)",
                "List<ReplicatedSnapshotInfo>",
                Query.AllK8sReplicaSnapshotInfos_ObjectFieldSpec,
                Query.AllK8sReplicaSnapshotInfosFieldSpec,
                @"# REQUIRED
$query.Var.snapshotId = $someString
# REQUIRED
$query.Var.snappableId = $someString"
            );
        }

        // Create new GraphQL Query:
        // k8sSnapshotInfo(snapshotId: UUID!, namespaceId: UUID!, isReplica: Boolean! = false): K8sSnapshotInfo!
        internal void InitQueryK8sSnapshotInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "UUID!"),
                Tuple.Create("namespaceId", "UUID!"),
                Tuple.Create("isReplica", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryK8sSnapshotInfo",
                "($snapshotId: UUID!,$namespaceId: UUID!,$isReplica: Boolean!)",
                "K8sSnapshotInfo",
                Query.K8sSnapshotInfo_ObjectFieldSpec,
                Query.K8sSnapshotInfoFieldSpec,
                @"# REQUIRED
$query.Var.snapshotId = $someString
# REQUIRED
$query.Var.namespaceId = $someString
# REQUIRED
$query.Var.isReplica = $someBoolean"
            );
        }


    } // class New_RscQueryK8s
}