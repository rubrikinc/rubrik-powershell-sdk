// New-RscQuerySla.cs
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

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Queries for the 'SLA' API domain.
    /// </summary>
    /// <description>
    /// New-RscQuerySla is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscQuerySla -Domains [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQuerySla -GlobalFilterList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQuerySla -Domain [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQuerySla -CountOfObjectsProtected [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQuerySla -AuditDetail [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQuerySla -AllSummariesByIds [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQuerySla -GlobalStatuses [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQuerySla -ConflictObjects [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQuerySla -ManagedVolumes [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQuerySla -ManagedVolume [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQuerySla -AllNcdComplianceData [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQuerySla",
        DefaultParameterSetName = "Domain")
    ]
    public class New_RscQuerySla : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// Domains parameter set
        ///
        /// [GraphQL: slaDomains]
        /// </summary>
        [Parameter(
            ParameterSetName = "Domains",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of SLA Domains.
[GraphQL: slaDomains]",
            Position = 0
        )]
        public SwitchParameter Domains { get; set; }

        
        /// <summary>
        /// GlobalFilterList parameter set
        ///
        /// [GraphQL: globalSlaFilterConnection]
        /// </summary>
        [Parameter(
            ParameterSetName = "GlobalFilterList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of SLA Domains.
[GraphQL: globalSlaFilterConnection]",
            Position = 0
        )]
        public SwitchParameter GlobalFilterList { get; set; }

        
        /// <summary>
        /// Domain parameter set
        ///
        /// [GraphQL: slaDomain]
        /// </summary>
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Query that retrieves an SLA Domain.
[GraphQL: slaDomain]",
            Position = 0
        )]
        public SwitchParameter Domain { get; set; }

        
        /// <summary>
        /// CountOfObjectsProtected parameter set
        ///
        /// [GraphQL: countOfObjectsProtectedBySlas]
        /// </summary>
        [Parameter(
            ParameterSetName = "CountOfObjectsProtected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The number of objects protected by the SLA Domains.
[GraphQL: countOfObjectsProtectedBySlas]",
            Position = 0
        )]
        public SwitchParameter CountOfObjectsProtected { get; set; }

        
        /// <summary>
        /// AuditDetail parameter set
        ///
        /// [GraphQL: slaAuditDetail]
        /// </summary>
        [Parameter(
            ParameterSetName = "AuditDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of audit details for a given SLA Domain.
[GraphQL: slaAuditDetail]",
            Position = 0
        )]
        public SwitchParameter AuditDetail { get; set; }

        
        /// <summary>
        /// AllSummariesByIds parameter set
        ///
        /// [GraphQL: allSlaSummariesByIds]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllSummariesByIds",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of SLA Domain summaries for the given IDs.
[GraphQL: allSlaSummariesByIds]",
            Position = 0
        )]
        public SwitchParameter AllSummariesByIds { get; set; }

        
        /// <summary>
        /// GlobalStatuses parameter set
        ///
        /// [GraphQL: globalSlaStatuses]
        /// </summary>
        [Parameter(
            ParameterSetName = "GlobalStatuses",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Status on the clusters where global SLA is synced.
[GraphQL: globalSlaStatuses]",
            Position = 0
        )]
        public SwitchParameter GlobalStatuses { get; set; }

        
        /// <summary>
        /// ConflictObjects parameter set
        ///
        /// [GraphQL: slaConflictObjects]
        /// </summary>
        [Parameter(
            ParameterSetName = "ConflictObjects",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Conflicting objects for an SLA Domain assignment.
[GraphQL: slaConflictObjects]",
            Position = 0
        )]
        public SwitchParameter ConflictObjects { get; set; }

        
        /// <summary>
        /// ManagedVolumes parameter set
        ///
        /// [GraphQL: slaManagedVolumes]
        /// </summary>
        [Parameter(
            ParameterSetName = "ManagedVolumes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of SLA Managed Volumes.
[GraphQL: slaManagedVolumes]",
            Position = 0
        )]
        public SwitchParameter ManagedVolumes { get; set; }

        
        /// <summary>
        /// ManagedVolume parameter set
        ///
        /// [GraphQL: slaManagedVolume]
        /// </summary>
        [Parameter(
            ParameterSetName = "ManagedVolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of a SLA Managed Volume object.
[GraphQL: slaManagedVolume]",
            Position = 0
        )]
        public SwitchParameter ManagedVolume { get; set; }

        
        /// <summary>
        /// AllNcdComplianceData parameter set
        ///
        /// [GraphQL: allNcdSlaComplianceData]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNcdComplianceData",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"NAS Cloud Direct SLA Domain compliance data for the requested clusters.
[GraphQL: allNcdSlaComplianceData]",
            Position = 0
        )]
        public SwitchParameter AllNcdComplianceData { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "Domains":
                        this.ProcessRecord_Domains();
                        break;
                    case "GlobalFilterList":
                        this.ProcessRecord_GlobalFilterList();
                        break;
                    case "Domain":
                        this.ProcessRecord_Domain();
                        break;
                    case "CountOfObjectsProtected":
                        this.ProcessRecord_CountOfObjectsProtected();
                        break;
                    case "AuditDetail":
                        this.ProcessRecord_AuditDetail();
                        break;
                    case "AllSummariesByIds":
                        this.ProcessRecord_AllSummariesByIds();
                        break;
                    case "GlobalStatuses":
                        this.ProcessRecord_GlobalStatuses();
                        break;
                    case "ConflictObjects":
                        this.ProcessRecord_ConflictObjects();
                        break;
                    case "ManagedVolumes":
                        this.ProcessRecord_ManagedVolumes();
                        break;
                    case "ManagedVolume":
                        this.ProcessRecord_ManagedVolume();
                        break;
                    case "AllNcdComplianceData":
                        this.ProcessRecord_AllNcdComplianceData();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // slaDomains.
        internal void ProcessRecord_Domains()
        {
            this._logger.name += " -Domains";
            // Create new graphql operation slaDomains
            InitQuerySlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaFilterConnection.
        internal void ProcessRecord_GlobalFilterList()
        {
            this._logger.name += " -GlobalFilterList";
            // Create new graphql operation globalSlaFilterConnection
            InitQueryGlobalSlaFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomain.
        internal void ProcessRecord_Domain()
        {
            this._logger.name += " -Domain";
            // Create new graphql operation slaDomain
            InitQuerySlaDomain();
        }

        // This parameter set invokes a single graphql operation:
        // countOfObjectsProtectedBySlas.
        internal void ProcessRecord_CountOfObjectsProtected()
        {
            this._logger.name += " -CountOfObjectsProtected";
            // Create new graphql operation countOfObjectsProtectedBySlas
            InitQueryCountOfObjectsProtectedBySlas();
        }

        // This parameter set invokes a single graphql operation:
        // slaAuditDetail.
        internal void ProcessRecord_AuditDetail()
        {
            this._logger.name += " -AuditDetail";
            // Create new graphql operation slaAuditDetail
            InitQuerySlaAuditDetail();
        }

        // This parameter set invokes a single graphql operation:
        // allSlaSummariesByIds.
        internal void ProcessRecord_AllSummariesByIds()
        {
            this._logger.name += " -AllSummariesByIds";
            // Create new graphql operation allSlaSummariesByIds
            InitQueryAllSlaSummariesByIds();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaStatuses.
        internal void ProcessRecord_GlobalStatuses()
        {
            this._logger.name += " -GlobalStatuses";
            // Create new graphql operation globalSlaStatuses
            InitQueryGlobalSlaStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // slaConflictObjects.
        internal void ProcessRecord_ConflictObjects()
        {
            this._logger.name += " -ConflictObjects";
            // Create new graphql operation slaConflictObjects
            InitQuerySlaConflictObjects();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolumes.
        internal void ProcessRecord_ManagedVolumes()
        {
            this._logger.name += " -ManagedVolumes";
            // Create new graphql operation slaManagedVolumes
            InitQuerySlaManagedVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolume.
        internal void ProcessRecord_ManagedVolume()
        {
            this._logger.name += " -ManagedVolume";
            // Create new graphql operation slaManagedVolume
            InitQuerySlaManagedVolume();
        }

        // This parameter set invokes a single graphql operation:
        // allNcdSlaComplianceData.
        internal void ProcessRecord_AllNcdComplianceData()
        {
            this._logger.name += " -AllNcdComplianceData";
            // Create new graphql operation allNcdSlaComplianceData
            InitQueryAllNcdSlaComplianceData();
        }


        // Create new GraphQL Query:
        // slaDomains(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     contextFilterInput: [ContextFilterInputField!]
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowProtectedObjectCount: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     showRemoteSlas: Boolean
        //     shouldShowPausedClusters: Boolean = false
        //   ): SlaDomainConnection!
        internal void InitQuerySlaDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("contextFilterInput", "[ContextFilterInputField!]"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowProtectedObjectCount", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("showRemoteSlas", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomains",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)",
                "SlaDomainConnection",
                Query.SlaDomains_ObjectFieldSpec,
                Query.SlaDomainsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <SlaQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <GlobalSlaQueryFilterInputField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = <System.String>
		# OPTIONAL
		objectTypeList = @(
			<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$inputs.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = <System.String>
		# REQUIRED
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowProtectedObjectCount = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.showRemoteSlas = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>"
            );
        }

        // Create new GraphQL Query:
        // globalSlaFilterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     contextFilterInput: [ContextFilterInputField!]
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowProtectedObjectCount: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     showRemoteSlas: Boolean
        //     shouldShowPausedClusters: Boolean = false
        //   ): GlobalSlaForFilterConnection!
        internal void InitQueryGlobalSlaFilterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("contextFilterInput", "[ContextFilterInputField!]"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowProtectedObjectCount", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("showRemoteSlas", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSlaFilterConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)",
                "GlobalSlaForFilterConnection",
                Query.GlobalSlaFilterConnection_ObjectFieldSpec,
                Query.GlobalSlaFilterConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <SlaQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <GlobalSlaQueryFilterInputField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = <System.String>
		# OPTIONAL
		objectTypeList = @(
			<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$inputs.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = <System.String>
		# REQUIRED
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowProtectedObjectCount = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.showRemoteSlas = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>"
            );
        }

        // Create new GraphQL Query:
        // slaDomain(
        //     id: UUID!
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     shouldShowPausedClusters: Boolean = false
        //   ): SlaDomain!
        internal void InitQuerySlaDomain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomain",
                "($id: UUID!,$shouldShowSyncStatus: Boolean,$shouldShowUpgradeInfo: Boolean,$shouldShowPausedClusters: Boolean)",
                "SlaDomain",
                Query.SlaDomain_ObjectFieldSpec,
                Query.SlaDomainFieldSpec,
                @"# REQUIRED
$inputs.Var.id = <System.String>
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>"
            );
        }

        // Create new GraphQL Query:
        // countOfObjectsProtectedBySlas(
        //     rootOptionalFid: UUID
        //     slaIds: [UUID!]!
        //     filter: [Filter!]
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //   ): CountOfObjectsProtectedBySLAsResult!
        internal void InitQueryCountOfObjectsProtectedBySlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rootOptionalFid", "UUID"),
                Tuple.Create("slaIds", "[UUID!]!"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCountOfObjectsProtectedBySlas",
                "($rootOptionalFid: UUID,$slaIds: [UUID!]!,$filter: [Filter!],$typeFilter: [HierarchyObjectTypeEnum!])",
                "CountOfObjectsProtectedBySlAsResult",
                Query.CountOfObjectsProtectedBySlas_ObjectFieldSpec,
                Query.CountOfObjectsProtectedBySlasFieldSpec,
                @"# OPTIONAL
$inputs.Var.rootOptionalFid = <System.String>
# REQUIRED
$inputs.Var.slaIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // slaAuditDetail(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     SlaId: UUID!
        //     filter: [SLAAuditDetailFilterInput!]
        //     timezone: String
        //   ): [SlaAuditDetail!]!
        internal void InitQuerySlaAuditDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("SlaId", "UUID!"),
                Tuple.Create("filter", "[SLAAuditDetailFilterInput!]"),
                Tuple.Create("timezone", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaAuditDetail",
                "($first: Int,$after: String,$last: Int,$before: String,$SlaId: UUID!,$filter: [SLAAuditDetailFilterInput!],$timezone: String)",
                "List<SlaAuditDetail>",
                Query.SlaAuditDetail_ObjectFieldSpec,
                Query.SlaAuditDetailFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# REQUIRED
$inputs.Var.SlaId = <System.String>
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <SLAAuditDetailFilterFieldEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SLAAuditDetailFilterFieldEnum]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.timezone = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allSlaSummariesByIds(slaIds: [UUID!]!): [SlaDomain!]!
        internal void InitQueryAllSlaSummariesByIds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("slaIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSlaSummariesByIds",
                "($slaIds: [UUID!]!)",
                "List<SlaDomain>",
                Query.AllSlaSummariesByIds_ObjectFieldSpec,
                Query.AllSlaSummariesByIdsFieldSpec,
                @"# REQUIRED
$inputs.Var.slaIds = @(
	<System.String>
)"
            );
        }

        // Create new GraphQL Query:
        // globalSlaStatuses(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: [SlaStatusFilterInput!]
        //     SlaId: UUID!
        //   ): GlobalSlaStatusConnection!
        internal void InitQueryGlobalSlaStatuses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "[SlaStatusFilterInput!]"),
                Tuple.Create("SlaId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSlaStatuses",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: [SlaStatusFilterInput!],$SlaId: UUID!)",
                "GlobalSlaStatusConnection",
                Query.GlobalSlaStatuses_ObjectFieldSpec,
                Query.GlobalSlaStatusesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <SlaStatusFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaStatusFilterField]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# REQUIRED
$inputs.Var.SlaId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // slaConflictObjects(fids: [UUID!]!): [HierarchyObject!]!
        internal void InitQuerySlaConflictObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaConflictObjects",
                "($fids: [UUID!]!)",
                "List<HierarchyObject>",
                Query.SlaConflictObjects_ObjectFieldSpec,
                Query.SlaConflictObjectsFieldSpec,
                @"# REQUIRED
$inputs.Var.fids = @(
	<System.String>
)"
            );
        }

        // Create new GraphQL Query:
        // slaManagedVolumes(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): ManagedVolumeConnection!
        internal void InitQuerySlaManagedVolumes()
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
                "QuerySlaManagedVolumes",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "ManagedVolumeConnection",
                Query.SlaManagedVolumes_ObjectFieldSpec,
                Query.SlaManagedVolumesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // slaManagedVolume(fid: UUID!): ManagedVolume!
        internal void InitQuerySlaManagedVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaManagedVolume",
                "($fid: UUID!)",
                "ManagedVolume",
                Query.SlaManagedVolume_ObjectFieldSpec,
                Query.SlaManagedVolumeFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allNcdSlaComplianceData(clusters: [UUID!]!): [NcdSlaComplianceData!]!
        internal void InitQueryAllNcdSlaComplianceData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllNcdSlaComplianceData",
                "($clusters: [UUID!]!)",
                "List<NcdSlaComplianceData>",
                Query.AllNcdSlaComplianceData_ObjectFieldSpec,
                Query.AllNcdSlaComplianceDataFieldSpec,
                @"# REQUIRED
$inputs.Var.clusters = @(
	<System.String>
)"
            );
        }


    } // class New_RscQuerySla
}