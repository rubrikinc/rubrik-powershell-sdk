// New-RscQueryHost.cs
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
    /// Create a new RscQuery object for any of the 6
    /// operations in the 'Host' API domain:
    /// Diagnosis, PhysicalHost, PhysicalHosts, Search, Share, or Shares.
    /// </summary>
    /// <description>
    /// New-RscQueryHost creates a new
    /// query object for operations
    /// in the 'Host' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'Host' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -Diagnosis, -PhysicalHost, -PhysicalHosts, -Search, -Share, -Shares.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op Diagnosis,
    /// which is equivalent to specifying -Diagnosis.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryHost -Diagnosis).Info().
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
    /// (New-RscQueryHost -Diagnosis).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Diagnosis operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: Diagnosis
    /// 
    /// $query = New-RscQueryHost -Diagnosis
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HostDiagnosisSummary
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PhysicalHost operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: PhysicalHost
    /// 
    /// $query = New-RscQueryHost -PhysicalHost
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PhysicalHost
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PhysicalHosts operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: PhysicalHosts
    /// 
    /// $query = New-RscQueryHost -PhysicalHosts
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
    /// # REQUIRED
    /// $query.Var.hostRoot = $someHostRoot # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HostRoot]) for enum values.
    /// # OPTIONAL
    /// $query.Var.isBulkPolicyAssignmentFlow = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PhysicalHostConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Search operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: Search
    /// 
    /// $query = New-RscQueryHost -Search
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// # REQUIRED
    /// $query.Var.path = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SearchResponseListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Share operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: Share
    /// 
    /// $query = New-RscQueryHost -Share
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HostShare
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Shares operation
    /// of the 'Host' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Host
    /// # API Operation: Shares
    /// 
    /// $query = New-RscQueryHost -Shares
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
    /// Write-Host $result.GetType().Name # prints: HostShareConnection
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
        "RscQueryHost",
        DefaultParameterSetName = "Share")
    ]
    public class New_RscQueryHost : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "Diagnosis",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Diagnosis' operation
in the 'Host' API domain.
Description of the operation:
Get host availability statuses

Supported in v5.0+
Retrieve the availability status for each host registered with a specified Rubrik CDM instance.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/hostdiagnosis.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Diagnosis { get; set; }

        
        [Parameter(
            ParameterSetName = "PhysicalHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'PhysicalHost' operation
in the 'Host' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/physicalhost.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PhysicalHost { get; set; }

        
        [Parameter(
            ParameterSetName = "PhysicalHosts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'PhysicalHosts' operation
in the 'Host' API domain.
Description of the operation:
Get list of physical hosts.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/physicalhosts.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PhysicalHosts { get; set; }

        
        [Parameter(
            ParameterSetName = "Search",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Search' operation
in the 'Host' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/searchhost.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Search { get; set; }

        
        [Parameter(
            ParameterSetName = "Share",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Share' operation
in the 'Host' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/hostshare.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Share { get; set; }

        
        [Parameter(
            ParameterSetName = "Shares",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Shares' operation
in the 'Host' API domain.
Description of the operation:
Get all host shares.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/hostshares.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Shares { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "Diagnosis":
                        this.ProcessRecord_Diagnosis();
                        break;
                    case "PhysicalHost":
                        this.ProcessRecord_PhysicalHost();
                        break;
                    case "PhysicalHosts":
                        this.ProcessRecord_PhysicalHosts();
                        break;
                    case "Search":
                        this.ProcessRecord_Search();
                        break;
                    case "Share":
                        this.ProcessRecord_Share();
                        break;
                    case "Shares":
                        this.ProcessRecord_Shares();
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
        // hostDiagnosis.
        internal void ProcessRecord_Diagnosis()
        {
            this._logger.name += " -Diagnosis";
            // Create new graphql operation hostDiagnosis
            InitQueryHostDiagnosis();
        }

        // This parameter set invokes a single graphql operation:
        // physicalHost.
        internal void ProcessRecord_PhysicalHost()
        {
            this._logger.name += " -PhysicalHost";
            // Create new graphql operation physicalHost
            InitQueryPhysicalHost();
        }

        // This parameter set invokes a single graphql operation:
        // physicalHosts.
        internal void ProcessRecord_PhysicalHosts()
        {
            this._logger.name += " -PhysicalHosts";
            // Create new graphql operation physicalHosts
            InitQueryPhysicalHosts();
        }

        // This parameter set invokes a single graphql operation:
        // searchHost.
        internal void ProcessRecord_Search()
        {
            this._logger.name += " -Search";
            // Create new graphql operation searchHost
            InitQuerySearchHost();
        }

        // This parameter set invokes a single graphql operation:
        // hostShare.
        internal void ProcessRecord_Share()
        {
            this._logger.name += " -Share";
            // Create new graphql operation hostShare
            InitQueryHostShare();
        }

        // This parameter set invokes a single graphql operation:
        // hostShares.
        internal void ProcessRecord_Shares()
        {
            this._logger.name += " -Shares";
            // Create new graphql operation hostShares
            InitQueryHostShares();
        }


        // Create new GraphQL Query:
        // hostDiagnosis(id: String!): HostDiagnosisSummary!
        internal void InitQueryHostDiagnosis()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHostDiagnosis",
                "($id: String!)",
                "HostDiagnosisSummary",
                Query.HostDiagnosis_ObjectFieldSpec,
                Query.HostDiagnosisFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString"
            );
        }

        // Create new GraphQL Query:
        // physicalHost(fid: UUID!): PhysicalHost!
        internal void InitQueryPhysicalHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPhysicalHost",
                "($fid: UUID!)",
                "PhysicalHost",
                Query.PhysicalHost_ObjectFieldSpec,
                Query.PhysicalHostFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // physicalHosts(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     hostRoot: HostRoot!
        //     isBulkPolicyAssignmentFlow: Boolean
        //   ): PhysicalHostConnection!
        internal void InitQueryPhysicalHosts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("hostRoot", "HostRoot!"),
                Tuple.Create("isBulkPolicyAssignmentFlow", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPhysicalHosts",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$hostRoot: HostRoot!,$isBulkPolicyAssignmentFlow: Boolean)",
                "PhysicalHostConnection",
                Query.PhysicalHosts_ObjectFieldSpec,
                Query.PhysicalHostsFieldSpec,
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
# REQUIRED
$query.Var.hostRoot = $someHostRoot # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HostRoot]) for enum values.
# OPTIONAL
$query.Var.isBulkPolicyAssignmentFlow = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // searchHost(id: String!, path: String!): SearchResponseListResponse!
        internal void InitQuerySearchHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "String!"),
                Tuple.Create("path", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySearchHost",
                "($id: String!,$path: String!)",
                "SearchResponseListResponse",
                Query.SearchHost_ObjectFieldSpec,
                Query.SearchHostFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString
# REQUIRED
$query.Var.path = $someString"
            );
        }

        // Create new GraphQL Query:
        // hostShare(fid: UUID!): HostShare!
        internal void InitQueryHostShare()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHostShare",
                "($fid: UUID!)",
                "HostShare",
                Query.HostShare_ObjectFieldSpec,
                Query.HostShareFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // hostShares(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HostShareConnection!
        internal void InitQueryHostShares()
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
                "QueryHostShares",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "HostShareConnection",
                Query.HostShares_ObjectFieldSpec,
                Query.HostSharesFieldSpec,
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


    } // class New_RscQueryHost
}