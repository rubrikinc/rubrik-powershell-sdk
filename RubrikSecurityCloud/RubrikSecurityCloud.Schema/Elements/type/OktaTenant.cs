// OktaTenant.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region OktaTenant
 
    public class OktaTenant: BaseType, HierarchyObject, HierarchySnappable, PolarisHierarchyObject, PolarisHierarchySnappable
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> List<OktaGeneralSecuritySettingType>? LatestGeneralSecuritySettingTypes
        // GraphQL -> latestGeneralSecuritySettingTypes: [OktaGeneralSecuritySettingType!]! (enum)
        [JsonProperty("latestGeneralSecuritySettingTypes")]
        public List<OktaGeneralSecuritySettingType>? LatestGeneralSecuritySettingTypes { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment
        // GraphQL -> rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus (enum)
        [JsonProperty("rscPendingObjectPauseAssignment")]
        public PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> ExoClusterStatus? Status
        // GraphQL -> status: ExoClusterStatus! (enum)
        [JsonProperty("status")]
        public ExoClusterStatus? Status { get; set; }

        //      C# -> WorkflowProtectionStatus? WorkflowProtectionStatus
        // GraphQL -> workflowProtectionStatus: WorkflowProtectionStatus! (enum)
        [JsonProperty("workflowProtectionStatus")]
        public WorkflowProtectionStatus? WorkflowProtectionStatus { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public SlaDomain? ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public SlaDomain? EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        //      C# -> System.String? BackupRegion
        // GraphQL -> backupRegion: String! (scalar)
        [JsonProperty("backupRegion")]
        public System.String? BackupRegion { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? Domain
        // GraphQL -> domain: String! (scalar)
        [JsonProperty("domain")]
        public System.String? Domain { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Boolean? IsWorkflowSetUp
        // GraphQL -> isWorkflowSetUp: Boolean! (scalar)
        [JsonProperty("isWorkflowSetUp")]
        public System.Boolean? IsWorkflowSetUp { get; set; }

        //      C# -> System.Int64? LatestAdminRoleCount
        // GraphQL -> latestAdminRoleCount: Long (scalar)
        [JsonProperty("latestAdminRoleCount")]
        public System.Int64? LatestAdminRoleCount { get; set; }

        //      C# -> System.Int64? LatestApplicationCount
        // GraphQL -> latestApplicationCount: Long (scalar)
        [JsonProperty("latestApplicationCount")]
        public System.Int64? LatestApplicationCount { get; set; }

        //      C# -> System.Int64? LatestAuthServerCount
        // GraphQL -> latestAuthServerCount: Long (scalar)
        [JsonProperty("latestAuthServerCount")]
        public System.Int64? LatestAuthServerCount { get; set; }

        //      C# -> System.Int64? LatestAuthenticatorCount
        // GraphQL -> latestAuthenticatorCount: Long (scalar)
        [JsonProperty("latestAuthenticatorCount")]
        public System.Int64? LatestAuthenticatorCount { get; set; }

        //      C# -> System.Int64? LatestBehaviorDetectionRuleCount
        // GraphQL -> latestBehaviorDetectionRuleCount: Long (scalar)
        [JsonProperty("latestBehaviorDetectionRuleCount")]
        public System.Int64? LatestBehaviorDetectionRuleCount { get; set; }

        //      C# -> System.Int64? LatestEventHookCount
        // GraphQL -> latestEventHookCount: Long (scalar)
        [JsonProperty("latestEventHookCount")]
        public System.Int64? LatestEventHookCount { get; set; }

        //      C# -> System.Int64? LatestGroupCount
        // GraphQL -> latestGroupCount: Long (scalar)
        [JsonProperty("latestGroupCount")]
        public System.Int64? LatestGroupCount { get; set; }

        //      C# -> System.Int64? LatestGroupRuleCount
        // GraphQL -> latestGroupRuleCount: Long (scalar)
        [JsonProperty("latestGroupRuleCount")]
        public System.Int64? LatestGroupRuleCount { get; set; }

        //      C# -> System.Int64? LatestIdentityProviderCount
        // GraphQL -> latestIdentityProviderCount: Long (scalar)
        [JsonProperty("latestIdentityProviderCount")]
        public System.Int64? LatestIdentityProviderCount { get; set; }

        //      C# -> System.Int64? LatestInlineHookCount
        // GraphQL -> latestInlineHookCount: Long (scalar)
        [JsonProperty("latestInlineHookCount")]
        public System.Int64? LatestInlineHookCount { get; set; }

        //      C# -> System.Int64? LatestNetworkZoneCount
        // GraphQL -> latestNetworkZoneCount: Long (scalar)
        [JsonProperty("latestNetworkZoneCount")]
        public System.Int64? LatestNetworkZoneCount { get; set; }

        //      C# -> System.Int64? LatestPolicyCount
        // GraphQL -> latestPolicyCount: Long (scalar)
        [JsonProperty("latestPolicyCount")]
        public System.Int64? LatestPolicyCount { get; set; }

        //      C# -> System.Int64? LatestPolicyRuleCount
        // GraphQL -> latestPolicyRuleCount: Long (scalar)
        [JsonProperty("latestPolicyRuleCount")]
        public System.Int64? LatestPolicyRuleCount { get; set; }

        //      C# -> System.Int64? LatestResourceSetCount
        // GraphQL -> latestResourceSetCount: Long (scalar)
        [JsonProperty("latestResourceSetCount")]
        public System.Int64? LatestResourceSetCount { get; set; }

        //      C# -> System.Int64? LatestUniversalDirectorySchemaCount
        // GraphQL -> latestUniversalDirectorySchemaCount: Long (scalar)
        [JsonProperty("latestUniversalDirectorySchemaCount")]
        public System.Int64? LatestUniversalDirectorySchemaCount { get; set; }

        //      C# -> System.Int64? LatestUserCount
        // GraphQL -> latestUserCount: Long (scalar)
        [JsonProperty("latestUserCount")]
        public System.Int64? LatestUserCount { get; set; }

        //      C# -> System.Int64? LatestWorkflowCount
        // GraphQL -> latestWorkflowCount: Long (scalar)
        [JsonProperty("latestWorkflowCount")]
        public System.Int64? LatestWorkflowCount { get; set; }

        //      C# -> System.Int32? LegallyHeldSnapshotCount
        // GraphQL -> legallyHeldSnapshotCount: Int (scalar)
        [JsonProperty("legallyHeldSnapshotCount")]
        public System.Int32? LegallyHeldSnapshotCount { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? WorkflowProtectionFailureReason
        // GraphQL -> workflowProtectionFailureReason: String (scalar)
        [JsonProperty("workflowProtectionFailureReason")]
        public System.String? WorkflowProtectionFailureReason { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        [JsonProperty("allTags")]
        public List<AssignedRscTag>? AllTags { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> FutureLegalHoldInfo? FutureLegalHoldInfo
        // GraphQL -> futureLegalHoldInfo: FutureLegalHoldInfo (type)
        [JsonProperty("futureLegalHoldInfo")]
        public FutureLegalHoldInfo? FutureLegalHoldInfo { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        [JsonProperty("newestIndexedSnapshot")]
        public PolarisSnapshot? NewestIndexedSnapshot { get; set; }

        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        [JsonProperty("newestSnapshot")]
        public PolarisSnapshot? NewestSnapshot { get; set; }

        //      C# -> ObjectBackupWindowStatus? ObjectBackupWindow
        // GraphQL -> objectBackupWindow: ObjectBackupWindowStatus (type)
        [JsonProperty("objectBackupWindow")]
        public ObjectBackupWindowStatus? ObjectBackupWindow { get; set; }

        //      C# -> ObjectPauseStatus? ObjectPauseStatus
        // GraphQL -> objectPauseStatus: ObjectPauseStatus (type)
        [JsonProperty("objectPauseStatus")]
        public ObjectPauseStatus? ObjectPauseStatus { get; set; }

        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public PolarisSnapshot? OldestSnapshot { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        [JsonProperty("rscNativeObjectPendingSla")]
        public CompactSlaDomain? RscNativeObjectPendingSla { get; set; }

        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        [JsonProperty("securityMetadata")]
        public SecurityMetadata? SecurityMetadata { get; set; }

        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        [JsonProperty("snapshotConnection")]
        public PolarisSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        [JsonProperty("snapshotGroupByConnection")]
        public PolarisSnapshotGroupByConnection? SnapshotGroupByConnection { get; set; }

        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        [JsonProperty("snapshotGroupByNewConnection")]
        public PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection { get; set; }

        //      C# -> WorkflowConfig? WorkflowConfig
        // GraphQL -> workflowConfig: WorkflowConfig (type)
        [JsonProperty("workflowConfig")]
        public WorkflowConfig? WorkflowConfig { get; set; }

        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        [JsonProperty("workloadSnapshotConnection")]
        public GenericSnapshotConnection? WorkloadSnapshotConnection { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars NumWorkloadDescendants { get; set; }

        public RscGqlVars OnDemandSnapshotCount { get; set; }

        public RscGqlVars NewestSnapshot { get; set; }

        public RscGqlVars OldestSnapshot { get; set; }

        public RscGqlVars SnapshotConnection { get; set; }

        public RscGqlVars SnapshotGroupByConnection { get; set; }

        public RscGqlVars SnapshotGroupByNewConnection { get; set; }

        public RscGqlVars WorkloadSnapshotConnection { get; set; }


        public InlineVars() {
            Tuple<string, string>[] numWorkloadDescendantsArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("objectTypes", "[ManagedObjectType!]"),
                };
            this.NumWorkloadDescendants =
                new RscGqlVars(null, numWorkloadDescendantsArgs, null, true);
            Tuple<string, string>[] onDemandSnapshotCountArgs = {
                    Tuple.Create("backupLocationId", "String"),
                };
            this.OnDemandSnapshotCount =
                new RscGqlVars(null, onDemandSnapshotCountArgs, null, true);
            Tuple<string, string>[] newestSnapshotArgs = {
                    Tuple.Create("backupLocationId", "String"),
                };
            this.NewestSnapshot =
                new RscGqlVars(null, newestSnapshotArgs, null, true);
            Tuple<string, string>[] oldestSnapshotArgs = {
                    Tuple.Create("backupLocationId", "String"),
                };
            this.OldestSnapshot =
                new RscGqlVars(null, oldestSnapshotArgs, null, true);
            Tuple<string, string>[] snapshotConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("filter", "PolarisSnapshotFilterInput"),
                    Tuple.Create("sortBy", "PolarisSnapshotSortByEnum"),
                    Tuple.Create("sortOrder", "SortOrder"),
                };
            this.SnapshotConnection =
                new RscGqlVars(null, snapshotConnectionArgs, null, true);
            Tuple<string, string>[] snapshotGroupByConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("timezoneOffset", "Float"),
                    Tuple.Create("filter", "PolarisSnapshotFilterInput"),
                    Tuple.Create("groupBy", "PolarisSnapshotGroupByEnum!"),
                    Tuple.Create("timezone", "Timezone"),
                };
            this.SnapshotGroupByConnection =
                new RscGqlVars(null, snapshotGroupByConnectionArgs, null, true);
            Tuple<string, string>[] snapshotGroupByNewConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("timezoneOffset", "Float"),
                    Tuple.Create("snapshotFilter", "[PolarisSnapshotFilterNewInput!]!"),
                    Tuple.Create("snapshotGroupBy", "SnapshotGroupByTime!"),
                };
            this.SnapshotGroupByNewConnection =
                new RscGqlVars(null, snapshotGroupByNewConnectionArgs, null, true);
            Tuple<string, string>[] workloadSnapshotConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("workloadId", "String!"),
                    Tuple.Create("snapshotFilter", "[SnapshotQueryFilterInput!]"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("sortBy", "SnapshotQuerySortByField"),
                    Tuple.Create("timeRange", "TimeRangeInput"),
                    Tuple.Create("ignoreActiveWorkloadCheck", "Boolean"),
                };
            this.WorkloadSnapshotConnection =
                new RscGqlVars(null, workloadSnapshotConnectionArgs, null, true);
        }
    }

    public OktaTenant()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "OktaTenant";
    }

    public OktaTenant Set(
        List<Operation>? AuthorizedOperations = null,
        List<OktaGeneralSecuritySettingType>? LatestGeneralSecuritySettingTypes = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        ExoClusterStatus? Status = null,
        WorkflowProtectionStatus? WorkflowProtectionStatus = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? BackupRegion = null,
        System.String? ClientId = null,
        System.String? Domain = null,
        System.String? Id = null,
        System.Boolean? IsRelic = null,
        System.Boolean? IsWorkflowSetUp = null,
        System.Int64? LatestAdminRoleCount = null,
        System.Int64? LatestApplicationCount = null,
        System.Int64? LatestAuthServerCount = null,
        System.Int64? LatestAuthenticatorCount = null,
        System.Int64? LatestBehaviorDetectionRuleCount = null,
        System.Int64? LatestEventHookCount = null,
        System.Int64? LatestGroupCount = null,
        System.Int64? LatestGroupRuleCount = null,
        System.Int64? LatestIdentityProviderCount = null,
        System.Int64? LatestInlineHookCount = null,
        System.Int64? LatestNetworkZoneCount = null,
        System.Int64? LatestPolicyCount = null,
        System.Int64? LatestPolicyRuleCount = null,
        System.Int64? LatestResourceSetCount = null,
        System.Int64? LatestUniversalDirectorySchemaCount = null,
        System.Int64? LatestUserCount = null,
        System.Int64? LatestWorkflowCount = null,
        System.Int32? LegallyHeldSnapshotCount = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? OrgId = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? WorkflowProtectionFailureReason = null,
        List<Org>? AllOrgs = null,
        List<AssignedRscTag>? AllTags = null,
        PathNode? EffectiveSlaSourceObject = null,
        FutureLegalHoldInfo? FutureLegalHoldInfo = null,
        List<PathNode>? LogicalPath = null,
        PolarisSnapshot? NewestIndexedSnapshot = null,
        PolarisSnapshot? NewestSnapshot = null,
        ObjectBackupWindowStatus? ObjectBackupWindow = null,
        ObjectPauseStatus? ObjectPauseStatus = null,
        PolarisSnapshot? OldestSnapshot = null,
        List<PathNode>? PhysicalPath = null,
        CompactSlaDomain? RscNativeObjectPendingSla = null,
        SecurityMetadata? SecurityMetadata = null,
        PolarisSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        PolarisSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection = null,
        WorkflowConfig? WorkflowConfig = null,
        GenericSnapshotConnection? WorkloadSnapshotConnection = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( LatestGeneralSecuritySettingTypes != null ) {
            this.LatestGeneralSecuritySettingTypes = LatestGeneralSecuritySettingTypes;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( RscPendingObjectPauseAssignment != null ) {
            this.RscPendingObjectPauseAssignment = RscPendingObjectPauseAssignment;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( WorkflowProtectionStatus != null ) {
            this.WorkflowProtectionStatus = WorkflowProtectionStatus;
        }
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveRetentionSlaDomain != null ) {
            this.EffectiveRetentionSlaDomain = EffectiveRetentionSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( BackupRegion != null ) {
            this.BackupRegion = BackupRegion;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( Domain != null ) {
            this.Domain = Domain;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( IsWorkflowSetUp != null ) {
            this.IsWorkflowSetUp = IsWorkflowSetUp;
        }
        if ( LatestAdminRoleCount != null ) {
            this.LatestAdminRoleCount = LatestAdminRoleCount;
        }
        if ( LatestApplicationCount != null ) {
            this.LatestApplicationCount = LatestApplicationCount;
        }
        if ( LatestAuthServerCount != null ) {
            this.LatestAuthServerCount = LatestAuthServerCount;
        }
        if ( LatestAuthenticatorCount != null ) {
            this.LatestAuthenticatorCount = LatestAuthenticatorCount;
        }
        if ( LatestBehaviorDetectionRuleCount != null ) {
            this.LatestBehaviorDetectionRuleCount = LatestBehaviorDetectionRuleCount;
        }
        if ( LatestEventHookCount != null ) {
            this.LatestEventHookCount = LatestEventHookCount;
        }
        if ( LatestGroupCount != null ) {
            this.LatestGroupCount = LatestGroupCount;
        }
        if ( LatestGroupRuleCount != null ) {
            this.LatestGroupRuleCount = LatestGroupRuleCount;
        }
        if ( LatestIdentityProviderCount != null ) {
            this.LatestIdentityProviderCount = LatestIdentityProviderCount;
        }
        if ( LatestInlineHookCount != null ) {
            this.LatestInlineHookCount = LatestInlineHookCount;
        }
        if ( LatestNetworkZoneCount != null ) {
            this.LatestNetworkZoneCount = LatestNetworkZoneCount;
        }
        if ( LatestPolicyCount != null ) {
            this.LatestPolicyCount = LatestPolicyCount;
        }
        if ( LatestPolicyRuleCount != null ) {
            this.LatestPolicyRuleCount = LatestPolicyRuleCount;
        }
        if ( LatestResourceSetCount != null ) {
            this.LatestResourceSetCount = LatestResourceSetCount;
        }
        if ( LatestUniversalDirectorySchemaCount != null ) {
            this.LatestUniversalDirectorySchemaCount = LatestUniversalDirectorySchemaCount;
        }
        if ( LatestUserCount != null ) {
            this.LatestUserCount = LatestUserCount;
        }
        if ( LatestWorkflowCount != null ) {
            this.LatestWorkflowCount = LatestWorkflowCount;
        }
        if ( LegallyHeldSnapshotCount != null ) {
            this.LegallyHeldSnapshotCount = LegallyHeldSnapshotCount;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( WorkflowProtectionFailureReason != null ) {
            this.WorkflowProtectionFailureReason = WorkflowProtectionFailureReason;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AllTags != null ) {
            this.AllTags = AllTags;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( FutureLegalHoldInfo != null ) {
            this.FutureLegalHoldInfo = FutureLegalHoldInfo;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( NewestIndexedSnapshot != null ) {
            this.NewestIndexedSnapshot = NewestIndexedSnapshot;
        }
        if ( NewestSnapshot != null ) {
            this.NewestSnapshot = NewestSnapshot;
        }
        if ( ObjectBackupWindow != null ) {
            this.ObjectBackupWindow = ObjectBackupWindow;
        }
        if ( ObjectPauseStatus != null ) {
            this.ObjectPauseStatus = ObjectPauseStatus;
        }
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( RscNativeObjectPendingSla != null ) {
            this.RscNativeObjectPendingSla = RscNativeObjectPendingSla;
        }
        if ( SecurityMetadata != null ) {
            this.SecurityMetadata = SecurityMetadata;
        }
        if ( SnapshotConnection != null ) {
            this.SnapshotConnection = SnapshotConnection;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( SnapshotGroupByConnection != null ) {
            this.SnapshotGroupByConnection = SnapshotGroupByConnection;
        }
        if ( SnapshotGroupByNewConnection != null ) {
            this.SnapshotGroupByNewConnection = SnapshotGroupByNewConnection;
        }
        if ( WorkflowConfig != null ) {
            this.WorkflowConfig = WorkflowConfig;
        }
        if ( WorkloadSnapshotConnection != null ) {
            this.WorkloadSnapshotConnection = WorkloadSnapshotConnection;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorizedOperations\n" ;
            } else {
                s += ind + "authorizedOperations\n" ;
            }
        }
        //      C# -> List<OktaGeneralSecuritySettingType>? LatestGeneralSecuritySettingTypes
        // GraphQL -> latestGeneralSecuritySettingTypes: [OktaGeneralSecuritySettingType!]! (enum)
        if (this.LatestGeneralSecuritySettingTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestGeneralSecuritySettingTypes\n" ;
            } else {
                s += ind + "latestGeneralSecuritySettingTypes\n" ;
            }
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment
        // GraphQL -> rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus (enum)
        if (this.RscPendingObjectPauseAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rscPendingObjectPauseAssignment\n" ;
            } else {
                s += ind + "rscPendingObjectPauseAssignment\n" ;
            }
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaAssignment\n" ;
            } else {
                s += ind + "slaAssignment\n" ;
            }
        }
        //      C# -> ExoClusterStatus? Status
        // GraphQL -> status: ExoClusterStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> WorkflowProtectionStatus? WorkflowProtectionStatus
        // GraphQL -> workflowProtectionStatus: WorkflowProtectionStatus! (enum)
        if (this.WorkflowProtectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workflowProtectionStatus\n" ;
            } else {
                s += ind + "workflowProtectionStatus\n" ;
            }
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.ConfiguredSlaDomain, conf.Child("configuredSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configuredSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.EffectiveRetentionSlaDomain, conf.Child("effectiveRetentionSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveRetentionSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.EffectiveSlaDomain, conf.Child("effectiveSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? BackupRegion
        // GraphQL -> backupRegion: String! (scalar)
        if (this.BackupRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupRegion\n" ;
            } else {
                s += ind + "backupRegion\n" ;
            }
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String (scalar)
        if (this.ClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientId\n" ;
            } else {
                s += ind + "clientId\n" ;
            }
        }
        //      C# -> System.String? Domain
        // GraphQL -> domain: String! (scalar)
        if (this.Domain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domain\n" ;
            } else {
                s += ind + "domain\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> System.Boolean? IsWorkflowSetUp
        // GraphQL -> isWorkflowSetUp: Boolean! (scalar)
        if (this.IsWorkflowSetUp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isWorkflowSetUp\n" ;
            } else {
                s += ind + "isWorkflowSetUp\n" ;
            }
        }
        //      C# -> System.Int64? LatestAdminRoleCount
        // GraphQL -> latestAdminRoleCount: Long (scalar)
        if (this.LatestAdminRoleCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestAdminRoleCount\n" ;
            } else {
                s += ind + "latestAdminRoleCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestApplicationCount
        // GraphQL -> latestApplicationCount: Long (scalar)
        if (this.LatestApplicationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestApplicationCount\n" ;
            } else {
                s += ind + "latestApplicationCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestAuthServerCount
        // GraphQL -> latestAuthServerCount: Long (scalar)
        if (this.LatestAuthServerCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestAuthServerCount\n" ;
            } else {
                s += ind + "latestAuthServerCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestAuthenticatorCount
        // GraphQL -> latestAuthenticatorCount: Long (scalar)
        if (this.LatestAuthenticatorCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestAuthenticatorCount\n" ;
            } else {
                s += ind + "latestAuthenticatorCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestBehaviorDetectionRuleCount
        // GraphQL -> latestBehaviorDetectionRuleCount: Long (scalar)
        if (this.LatestBehaviorDetectionRuleCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestBehaviorDetectionRuleCount\n" ;
            } else {
                s += ind + "latestBehaviorDetectionRuleCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestEventHookCount
        // GraphQL -> latestEventHookCount: Long (scalar)
        if (this.LatestEventHookCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestEventHookCount\n" ;
            } else {
                s += ind + "latestEventHookCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestGroupCount
        // GraphQL -> latestGroupCount: Long (scalar)
        if (this.LatestGroupCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestGroupCount\n" ;
            } else {
                s += ind + "latestGroupCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestGroupRuleCount
        // GraphQL -> latestGroupRuleCount: Long (scalar)
        if (this.LatestGroupRuleCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestGroupRuleCount\n" ;
            } else {
                s += ind + "latestGroupRuleCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestIdentityProviderCount
        // GraphQL -> latestIdentityProviderCount: Long (scalar)
        if (this.LatestIdentityProviderCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestIdentityProviderCount\n" ;
            } else {
                s += ind + "latestIdentityProviderCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestInlineHookCount
        // GraphQL -> latestInlineHookCount: Long (scalar)
        if (this.LatestInlineHookCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestInlineHookCount\n" ;
            } else {
                s += ind + "latestInlineHookCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestNetworkZoneCount
        // GraphQL -> latestNetworkZoneCount: Long (scalar)
        if (this.LatestNetworkZoneCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestNetworkZoneCount\n" ;
            } else {
                s += ind + "latestNetworkZoneCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestPolicyCount
        // GraphQL -> latestPolicyCount: Long (scalar)
        if (this.LatestPolicyCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestPolicyCount\n" ;
            } else {
                s += ind + "latestPolicyCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestPolicyRuleCount
        // GraphQL -> latestPolicyRuleCount: Long (scalar)
        if (this.LatestPolicyRuleCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestPolicyRuleCount\n" ;
            } else {
                s += ind + "latestPolicyRuleCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestResourceSetCount
        // GraphQL -> latestResourceSetCount: Long (scalar)
        if (this.LatestResourceSetCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestResourceSetCount\n" ;
            } else {
                s += ind + "latestResourceSetCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestUniversalDirectorySchemaCount
        // GraphQL -> latestUniversalDirectorySchemaCount: Long (scalar)
        if (this.LatestUniversalDirectorySchemaCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestUniversalDirectorySchemaCount\n" ;
            } else {
                s += ind + "latestUniversalDirectorySchemaCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestUserCount
        // GraphQL -> latestUserCount: Long (scalar)
        if (this.LatestUserCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestUserCount\n" ;
            } else {
                s += ind + "latestUserCount\n" ;
            }
        }
        //      C# -> System.Int64? LatestWorkflowCount
        // GraphQL -> latestWorkflowCount: Long (scalar)
        if (this.LatestWorkflowCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestWorkflowCount\n" ;
            } else {
                s += ind + "latestWorkflowCount\n" ;
            }
        }
        //      C# -> System.Int32? LegallyHeldSnapshotCount
        // GraphQL -> legallyHeldSnapshotCount: Int (scalar)
        if (this.LegallyHeldSnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "legallyHeldSnapshotCount\n" ;
            } else {
                s += ind + "legallyHeldSnapshotCount\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numWorkloadDescendants\n" ;
            } else {
                s += ind + "numWorkloadDescendants\n" ;
            }
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onDemandSnapshotCount\n" ;
            } else {
                s += ind + "onDemandSnapshotCount\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaPauseStatus\n" ;
            } else {
                s += ind + "slaPauseStatus\n" ;
            }
        }
        //      C# -> System.String? WorkflowProtectionFailureReason
        // GraphQL -> workflowProtectionFailureReason: String (scalar)
        if (this.WorkflowProtectionFailureReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workflowProtectionFailureReason\n" ;
            } else {
                s += ind + "workflowProtectionFailureReason\n" ;
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(conf.Child("allOrgs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        if (this.AllTags != null) {
            var fspec = this.AllTags.AsFieldSpec(conf.Child("allTags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allTags" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(conf.Child("effectiveSlaSourceObject"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaSourceObject" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FutureLegalHoldInfo? FutureLegalHoldInfo
        // GraphQL -> futureLegalHoldInfo: FutureLegalHoldInfo (type)
        if (this.FutureLegalHoldInfo != null) {
            var fspec = this.FutureLegalHoldInfo.AsFieldSpec(conf.Child("futureLegalHoldInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "futureLegalHoldInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(conf.Child("logicalPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (this.NewestIndexedSnapshot != null) {
            var fspec = this.NewestIndexedSnapshot.AsFieldSpec(conf.Child("newestIndexedSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestIndexedSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (this.NewestSnapshot != null) {
            var fspec = this.NewestSnapshot.AsFieldSpec(conf.Child("newestSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestSnapshot" + "\n(" + this.Vars.NewestSnapshot.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ObjectBackupWindowStatus? ObjectBackupWindow
        // GraphQL -> objectBackupWindow: ObjectBackupWindowStatus (type)
        if (this.ObjectBackupWindow != null) {
            var fspec = this.ObjectBackupWindow.AsFieldSpec(conf.Child("objectBackupWindow"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectBackupWindow" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ObjectPauseStatus? ObjectPauseStatus
        // GraphQL -> objectPauseStatus: ObjectPauseStatus (type)
        if (this.ObjectPauseStatus != null) {
            var fspec = this.ObjectPauseStatus.AsFieldSpec(conf.Child("objectPauseStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectPauseStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (this.OldestSnapshot != null) {
            var fspec = this.OldestSnapshot.AsFieldSpec(conf.Child("oldestSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldestSnapshot" + "\n(" + this.Vars.OldestSnapshot.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(conf.Child("physicalPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        if (this.RscNativeObjectPendingSla != null) {
            var fspec = this.RscNativeObjectPendingSla.AsFieldSpec(conf.Child("rscNativeObjectPendingSla"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rscNativeObjectPendingSla" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        if (this.SecurityMetadata != null) {
            var fspec = this.SecurityMetadata.AsFieldSpec(conf.Child("securityMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "securityMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            var fspec = this.SnapshotConnection.AsFieldSpec(conf.Child("snapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotConnection" + "\n(" + this.Vars.SnapshotConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(conf.Child("snapshotDistribution"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotDistribution" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            var fspec = this.SnapshotGroupByConnection.AsFieldSpec(conf.Child("snapshotGroupByConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotGroupByConnection" + "\n(" + this.Vars.SnapshotGroupByConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (this.SnapshotGroupByNewConnection != null) {
            var fspec = this.SnapshotGroupByNewConnection.AsFieldSpec(conf.Child("snapshotGroupByNewConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotGroupByNewConnection" + "\n(" + this.Vars.SnapshotGroupByNewConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> WorkflowConfig? WorkflowConfig
        // GraphQL -> workflowConfig: WorkflowConfig (type)
        if (this.WorkflowConfig != null) {
            var fspec = this.WorkflowConfig.AsFieldSpec(conf.Child("workflowConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workflowConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (this.WorkloadSnapshotConnection != null) {
            var fspec = this.WorkloadSnapshotConnection.AsFieldSpec(conf.Child("workloadSnapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadSnapshotConnection" + "\n(" + this.Vars.WorkloadSnapshotConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (ec.Includes("authorizedOperations",true))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new List<Operation>();

            } else {


            }
        }
        else if (this.AuthorizedOperations != null && ec.Excludes("authorizedOperations",true))
        {
            this.AuthorizedOperations = null;
        }
        //      C# -> List<OktaGeneralSecuritySettingType>? LatestGeneralSecuritySettingTypes
        // GraphQL -> latestGeneralSecuritySettingTypes: [OktaGeneralSecuritySettingType!]! (enum)
        if (ec.Includes("latestGeneralSecuritySettingTypes",true))
        {
            if(this.LatestGeneralSecuritySettingTypes == null) {

                this.LatestGeneralSecuritySettingTypes = new List<OktaGeneralSecuritySettingType>();

            } else {


            }
        }
        else if (this.LatestGeneralSecuritySettingTypes != null && ec.Excludes("latestGeneralSecuritySettingTypes",true))
        {
            this.LatestGeneralSecuritySettingTypes = null;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new HierarchyObjectTypeEnum();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment
        // GraphQL -> rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus (enum)
        if (ec.Includes("rscPendingObjectPauseAssignment",true))
        {
            if(this.RscPendingObjectPauseAssignment == null) {

                this.RscPendingObjectPauseAssignment = new PendingObjectPauseAssignmentStatus();

            } else {


            }
        }
        else if (this.RscPendingObjectPauseAssignment != null && ec.Excludes("rscPendingObjectPauseAssignment",true))
        {
            this.RscPendingObjectPauseAssignment = null;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (ec.Includes("slaAssignment",true))
        {
            if(this.SlaAssignment == null) {

                this.SlaAssignment = new SlaAssignmentTypeEnum();

            } else {


            }
        }
        else if (this.SlaAssignment != null && ec.Excludes("slaAssignment",true))
        {
            this.SlaAssignment = null;
        }
        //      C# -> ExoClusterStatus? Status
        // GraphQL -> status: ExoClusterStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ExoClusterStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> WorkflowProtectionStatus? WorkflowProtectionStatus
        // GraphQL -> workflowProtectionStatus: WorkflowProtectionStatus! (enum)
        if (ec.Includes("workflowProtectionStatus",true))
        {
            if(this.WorkflowProtectionStatus == null) {

                this.WorkflowProtectionStatus = new WorkflowProtectionStatus();

            } else {


            }
        }
        else if (this.WorkflowProtectionStatus != null && ec.Excludes("workflowProtectionStatus",true))
        {
            this.WorkflowProtectionStatus = null;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (ec.Includes("configuredSlaDomain",false))
        {
            if(this.ConfiguredSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.ConfiguredSlaDomain != null && ec.Excludes("configuredSlaDomain",false))
        {
            this.ConfiguredSlaDomain = null;
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (ec.Includes("effectiveRetentionSlaDomain",false))
        {
            if(this.EffectiveRetentionSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.EffectiveRetentionSlaDomain != null && ec.Excludes("effectiveRetentionSlaDomain",false))
        {
            this.EffectiveRetentionSlaDomain = null;
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (ec.Includes("effectiveSlaDomain",false))
        {
            if(this.EffectiveSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.EffectiveSlaDomain != null && ec.Excludes("effectiveSlaDomain",false))
        {
            this.EffectiveSlaDomain = null;
        }
        //      C# -> System.String? BackupRegion
        // GraphQL -> backupRegion: String! (scalar)
        if (ec.Includes("backupRegion",true))
        {
            if(this.BackupRegion == null) {

                this.BackupRegion = "FETCH";

            } else {


            }
        }
        else if (this.BackupRegion != null && ec.Excludes("backupRegion",true))
        {
            this.BackupRegion = null;
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String (scalar)
        if (ec.Includes("clientId",true))
        {
            if(this.ClientId == null) {

                this.ClientId = "FETCH";

            } else {


            }
        }
        else if (this.ClientId != null && ec.Excludes("clientId",true))
        {
            this.ClientId = null;
        }
        //      C# -> System.String? Domain
        // GraphQL -> domain: String! (scalar)
        if (ec.Includes("domain",true))
        {
            if(this.Domain == null) {

                this.Domain = "FETCH";

            } else {


            }
        }
        else if (this.Domain != null && ec.Excludes("domain",true))
        {
            this.Domain = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> System.Boolean? IsWorkflowSetUp
        // GraphQL -> isWorkflowSetUp: Boolean! (scalar)
        if (ec.Includes("isWorkflowSetUp",true))
        {
            if(this.IsWorkflowSetUp == null) {

                this.IsWorkflowSetUp = true;

            } else {


            }
        }
        else if (this.IsWorkflowSetUp != null && ec.Excludes("isWorkflowSetUp",true))
        {
            this.IsWorkflowSetUp = null;
        }
        //      C# -> System.Int64? LatestAdminRoleCount
        // GraphQL -> latestAdminRoleCount: Long (scalar)
        if (ec.Includes("latestAdminRoleCount",true))
        {
            if(this.LatestAdminRoleCount == null) {

                this.LatestAdminRoleCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestAdminRoleCount != null && ec.Excludes("latestAdminRoleCount",true))
        {
            this.LatestAdminRoleCount = null;
        }
        //      C# -> System.Int64? LatestApplicationCount
        // GraphQL -> latestApplicationCount: Long (scalar)
        if (ec.Includes("latestApplicationCount",true))
        {
            if(this.LatestApplicationCount == null) {

                this.LatestApplicationCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestApplicationCount != null && ec.Excludes("latestApplicationCount",true))
        {
            this.LatestApplicationCount = null;
        }
        //      C# -> System.Int64? LatestAuthServerCount
        // GraphQL -> latestAuthServerCount: Long (scalar)
        if (ec.Includes("latestAuthServerCount",true))
        {
            if(this.LatestAuthServerCount == null) {

                this.LatestAuthServerCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestAuthServerCount != null && ec.Excludes("latestAuthServerCount",true))
        {
            this.LatestAuthServerCount = null;
        }
        //      C# -> System.Int64? LatestAuthenticatorCount
        // GraphQL -> latestAuthenticatorCount: Long (scalar)
        if (ec.Includes("latestAuthenticatorCount",true))
        {
            if(this.LatestAuthenticatorCount == null) {

                this.LatestAuthenticatorCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestAuthenticatorCount != null && ec.Excludes("latestAuthenticatorCount",true))
        {
            this.LatestAuthenticatorCount = null;
        }
        //      C# -> System.Int64? LatestBehaviorDetectionRuleCount
        // GraphQL -> latestBehaviorDetectionRuleCount: Long (scalar)
        if (ec.Includes("latestBehaviorDetectionRuleCount",true))
        {
            if(this.LatestBehaviorDetectionRuleCount == null) {

                this.LatestBehaviorDetectionRuleCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestBehaviorDetectionRuleCount != null && ec.Excludes("latestBehaviorDetectionRuleCount",true))
        {
            this.LatestBehaviorDetectionRuleCount = null;
        }
        //      C# -> System.Int64? LatestEventHookCount
        // GraphQL -> latestEventHookCount: Long (scalar)
        if (ec.Includes("latestEventHookCount",true))
        {
            if(this.LatestEventHookCount == null) {

                this.LatestEventHookCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestEventHookCount != null && ec.Excludes("latestEventHookCount",true))
        {
            this.LatestEventHookCount = null;
        }
        //      C# -> System.Int64? LatestGroupCount
        // GraphQL -> latestGroupCount: Long (scalar)
        if (ec.Includes("latestGroupCount",true))
        {
            if(this.LatestGroupCount == null) {

                this.LatestGroupCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestGroupCount != null && ec.Excludes("latestGroupCount",true))
        {
            this.LatestGroupCount = null;
        }
        //      C# -> System.Int64? LatestGroupRuleCount
        // GraphQL -> latestGroupRuleCount: Long (scalar)
        if (ec.Includes("latestGroupRuleCount",true))
        {
            if(this.LatestGroupRuleCount == null) {

                this.LatestGroupRuleCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestGroupRuleCount != null && ec.Excludes("latestGroupRuleCount",true))
        {
            this.LatestGroupRuleCount = null;
        }
        //      C# -> System.Int64? LatestIdentityProviderCount
        // GraphQL -> latestIdentityProviderCount: Long (scalar)
        if (ec.Includes("latestIdentityProviderCount",true))
        {
            if(this.LatestIdentityProviderCount == null) {

                this.LatestIdentityProviderCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestIdentityProviderCount != null && ec.Excludes("latestIdentityProviderCount",true))
        {
            this.LatestIdentityProviderCount = null;
        }
        //      C# -> System.Int64? LatestInlineHookCount
        // GraphQL -> latestInlineHookCount: Long (scalar)
        if (ec.Includes("latestInlineHookCount",true))
        {
            if(this.LatestInlineHookCount == null) {

                this.LatestInlineHookCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestInlineHookCount != null && ec.Excludes("latestInlineHookCount",true))
        {
            this.LatestInlineHookCount = null;
        }
        //      C# -> System.Int64? LatestNetworkZoneCount
        // GraphQL -> latestNetworkZoneCount: Long (scalar)
        if (ec.Includes("latestNetworkZoneCount",true))
        {
            if(this.LatestNetworkZoneCount == null) {

                this.LatestNetworkZoneCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestNetworkZoneCount != null && ec.Excludes("latestNetworkZoneCount",true))
        {
            this.LatestNetworkZoneCount = null;
        }
        //      C# -> System.Int64? LatestPolicyCount
        // GraphQL -> latestPolicyCount: Long (scalar)
        if (ec.Includes("latestPolicyCount",true))
        {
            if(this.LatestPolicyCount == null) {

                this.LatestPolicyCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestPolicyCount != null && ec.Excludes("latestPolicyCount",true))
        {
            this.LatestPolicyCount = null;
        }
        //      C# -> System.Int64? LatestPolicyRuleCount
        // GraphQL -> latestPolicyRuleCount: Long (scalar)
        if (ec.Includes("latestPolicyRuleCount",true))
        {
            if(this.LatestPolicyRuleCount == null) {

                this.LatestPolicyRuleCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestPolicyRuleCount != null && ec.Excludes("latestPolicyRuleCount",true))
        {
            this.LatestPolicyRuleCount = null;
        }
        //      C# -> System.Int64? LatestResourceSetCount
        // GraphQL -> latestResourceSetCount: Long (scalar)
        if (ec.Includes("latestResourceSetCount",true))
        {
            if(this.LatestResourceSetCount == null) {

                this.LatestResourceSetCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestResourceSetCount != null && ec.Excludes("latestResourceSetCount",true))
        {
            this.LatestResourceSetCount = null;
        }
        //      C# -> System.Int64? LatestUniversalDirectorySchemaCount
        // GraphQL -> latestUniversalDirectorySchemaCount: Long (scalar)
        if (ec.Includes("latestUniversalDirectorySchemaCount",true))
        {
            if(this.LatestUniversalDirectorySchemaCount == null) {

                this.LatestUniversalDirectorySchemaCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestUniversalDirectorySchemaCount != null && ec.Excludes("latestUniversalDirectorySchemaCount",true))
        {
            this.LatestUniversalDirectorySchemaCount = null;
        }
        //      C# -> System.Int64? LatestUserCount
        // GraphQL -> latestUserCount: Long (scalar)
        if (ec.Includes("latestUserCount",true))
        {
            if(this.LatestUserCount == null) {

                this.LatestUserCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestUserCount != null && ec.Excludes("latestUserCount",true))
        {
            this.LatestUserCount = null;
        }
        //      C# -> System.Int64? LatestWorkflowCount
        // GraphQL -> latestWorkflowCount: Long (scalar)
        if (ec.Includes("latestWorkflowCount",true))
        {
            if(this.LatestWorkflowCount == null) {

                this.LatestWorkflowCount = new System.Int64();

            } else {


            }
        }
        else if (this.LatestWorkflowCount != null && ec.Excludes("latestWorkflowCount",true))
        {
            this.LatestWorkflowCount = null;
        }
        //      C# -> System.Int32? LegallyHeldSnapshotCount
        // GraphQL -> legallyHeldSnapshotCount: Int (scalar)
        if (ec.Includes("legallyHeldSnapshotCount",true))
        {
            if(this.LegallyHeldSnapshotCount == null) {

                this.LegallyHeldSnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.LegallyHeldSnapshotCount != null && ec.Excludes("legallyHeldSnapshotCount",true))
        {
            this.LegallyHeldSnapshotCount = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (ec.Includes("numWorkloadDescendants",true))
        {
            if(this.NumWorkloadDescendants == null) {

                this.NumWorkloadDescendants = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumWorkloadDescendants != null && ec.Excludes("numWorkloadDescendants",true))
        {
            this.NumWorkloadDescendants = null;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (ec.Includes("onDemandSnapshotCount",true))
        {
            if(this.OnDemandSnapshotCount == null) {

                this.OnDemandSnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.OnDemandSnapshotCount != null && ec.Excludes("onDemandSnapshotCount",true))
        {
            this.OnDemandSnapshotCount = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (ec.Includes("slaPauseStatus",true))
        {
            if(this.SlaPauseStatus == null) {

                this.SlaPauseStatus = true;

            } else {


            }
        }
        else if (this.SlaPauseStatus != null && ec.Excludes("slaPauseStatus",true))
        {
            this.SlaPauseStatus = null;
        }
        //      C# -> System.String? WorkflowProtectionFailureReason
        // GraphQL -> workflowProtectionFailureReason: String (scalar)
        if (ec.Includes("workflowProtectionFailureReason",true))
        {
            if(this.WorkflowProtectionFailureReason == null) {

                this.WorkflowProtectionFailureReason = "FETCH";

            } else {


            }
        }
        else if (this.WorkflowProtectionFailureReason != null && ec.Excludes("workflowProtectionFailureReason",true))
        {
            this.WorkflowProtectionFailureReason = null;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (ec.Includes("allOrgs",false))
        {
            if(this.AllOrgs == null) {

                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            } else {

                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            }
        }
        else if (this.AllOrgs != null && ec.Excludes("allOrgs",false))
        {
            this.AllOrgs = null;
        }
        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        if (ec.Includes("allTags",false))
        {
            if(this.AllTags == null) {

                this.AllTags = new List<AssignedRscTag>();
                this.AllTags.ApplyExploratoryFieldSpec(ec.NewChild("allTags"));

            } else {

                this.AllTags.ApplyExploratoryFieldSpec(ec.NewChild("allTags"));

            }
        }
        else if (this.AllTags != null && ec.Excludes("allTags",false))
        {
            this.AllTags = null;
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (ec.Includes("effectiveSlaSourceObject",false))
        {
            if(this.EffectiveSlaSourceObject == null) {

                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));

            } else {

                this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));

            }
        }
        else if (this.EffectiveSlaSourceObject != null && ec.Excludes("effectiveSlaSourceObject",false))
        {
            this.EffectiveSlaSourceObject = null;
        }
        //      C# -> FutureLegalHoldInfo? FutureLegalHoldInfo
        // GraphQL -> futureLegalHoldInfo: FutureLegalHoldInfo (type)
        if (ec.Includes("futureLegalHoldInfo",false))
        {
            if(this.FutureLegalHoldInfo == null) {

                this.FutureLegalHoldInfo = new FutureLegalHoldInfo();
                this.FutureLegalHoldInfo.ApplyExploratoryFieldSpec(ec.NewChild("futureLegalHoldInfo"));

            } else {

                this.FutureLegalHoldInfo.ApplyExploratoryFieldSpec(ec.NewChild("futureLegalHoldInfo"));

            }
        }
        else if (this.FutureLegalHoldInfo != null && ec.Excludes("futureLegalHoldInfo",false))
        {
            this.FutureLegalHoldInfo = null;
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (ec.Includes("logicalPath",false))
        {
            if(this.LogicalPath == null) {

                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));

            } else {

                this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));

            }
        }
        else if (this.LogicalPath != null && ec.Excludes("logicalPath",false))
        {
            this.LogicalPath = null;
        }
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (ec.Includes("newestIndexedSnapshot",false))
        {
            if(this.NewestIndexedSnapshot == null) {

                this.NewestIndexedSnapshot = new PolarisSnapshot();
                this.NewestIndexedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestIndexedSnapshot"));

            } else {

                this.NewestIndexedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestIndexedSnapshot"));

            }
        }
        else if (this.NewestIndexedSnapshot != null && ec.Excludes("newestIndexedSnapshot",false))
        {
            this.NewestIndexedSnapshot = null;
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (ec.Includes("newestSnapshot",false))
        {
            if(this.NewestSnapshot == null) {

                this.NewestSnapshot = new PolarisSnapshot();
                this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));

            } else {

                this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));

            }
        }
        else if (this.NewestSnapshot != null && ec.Excludes("newestSnapshot",false))
        {
            this.NewestSnapshot = null;
        }
        //      C# -> ObjectBackupWindowStatus? ObjectBackupWindow
        // GraphQL -> objectBackupWindow: ObjectBackupWindowStatus (type)
        if (ec.Includes("objectBackupWindow",false))
        {
            if(this.ObjectBackupWindow == null) {

                this.ObjectBackupWindow = new ObjectBackupWindowStatus();
                this.ObjectBackupWindow.ApplyExploratoryFieldSpec(ec.NewChild("objectBackupWindow"));

            } else {

                this.ObjectBackupWindow.ApplyExploratoryFieldSpec(ec.NewChild("objectBackupWindow"));

            }
        }
        else if (this.ObjectBackupWindow != null && ec.Excludes("objectBackupWindow",false))
        {
            this.ObjectBackupWindow = null;
        }
        //      C# -> ObjectPauseStatus? ObjectPauseStatus
        // GraphQL -> objectPauseStatus: ObjectPauseStatus (type)
        if (ec.Includes("objectPauseStatus",false))
        {
            if(this.ObjectPauseStatus == null) {

                this.ObjectPauseStatus = new ObjectPauseStatus();
                this.ObjectPauseStatus.ApplyExploratoryFieldSpec(ec.NewChild("objectPauseStatus"));

            } else {

                this.ObjectPauseStatus.ApplyExploratoryFieldSpec(ec.NewChild("objectPauseStatus"));

            }
        }
        else if (this.ObjectPauseStatus != null && ec.Excludes("objectPauseStatus",false))
        {
            this.ObjectPauseStatus = null;
        }
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (ec.Includes("oldestSnapshot",false))
        {
            if(this.OldestSnapshot == null) {

                this.OldestSnapshot = new PolarisSnapshot();
                this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));

            } else {

                this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));

            }
        }
        else if (this.OldestSnapshot != null && ec.Excludes("oldestSnapshot",false))
        {
            this.OldestSnapshot = null;
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (ec.Includes("physicalPath",false))
        {
            if(this.PhysicalPath == null) {

                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));

            } else {

                this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));

            }
        }
        else if (this.PhysicalPath != null && ec.Excludes("physicalPath",false))
        {
            this.PhysicalPath = null;
        }
        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        if (ec.Includes("rscNativeObjectPendingSla",false))
        {
            if(this.RscNativeObjectPendingSla == null) {

                this.RscNativeObjectPendingSla = new CompactSlaDomain();
                this.RscNativeObjectPendingSla.ApplyExploratoryFieldSpec(ec.NewChild("rscNativeObjectPendingSla"));

            } else {

                this.RscNativeObjectPendingSla.ApplyExploratoryFieldSpec(ec.NewChild("rscNativeObjectPendingSla"));

            }
        }
        else if (this.RscNativeObjectPendingSla != null && ec.Excludes("rscNativeObjectPendingSla",false))
        {
            this.RscNativeObjectPendingSla = null;
        }
        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        if (ec.Includes("securityMetadata",false))
        {
            if(this.SecurityMetadata == null) {

                this.SecurityMetadata = new SecurityMetadata();
                this.SecurityMetadata.ApplyExploratoryFieldSpec(ec.NewChild("securityMetadata"));

            } else {

                this.SecurityMetadata.ApplyExploratoryFieldSpec(ec.NewChild("securityMetadata"));

            }
        }
        else if (this.SecurityMetadata != null && ec.Excludes("securityMetadata",false))
        {
            this.SecurityMetadata = null;
        }
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (ec.Includes("snapshotConnection",false))
        {
            if(this.SnapshotConnection == null) {

                this.SnapshotConnection = new PolarisSnapshotConnection();
                this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));

            } else {

                this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));

            }
        }
        else if (this.SnapshotConnection != null && ec.Excludes("snapshotConnection",false))
        {
            this.SnapshotConnection = null;
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (ec.Includes("snapshotDistribution",false))
        {
            if(this.SnapshotDistribution == null) {

                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));

            } else {

                this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));

            }
        }
        else if (this.SnapshotDistribution != null && ec.Excludes("snapshotDistribution",false))
        {
            this.SnapshotDistribution = null;
        }
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (ec.Includes("snapshotGroupByConnection",false))
        {
            if(this.SnapshotGroupByConnection == null) {

                this.SnapshotGroupByConnection = new PolarisSnapshotGroupByConnection();
                this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByConnection"));

            } else {

                this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByConnection"));

            }
        }
        else if (this.SnapshotGroupByConnection != null && ec.Excludes("snapshotGroupByConnection",false))
        {
            this.SnapshotGroupByConnection = null;
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (ec.Includes("snapshotGroupByNewConnection",false))
        {
            if(this.SnapshotGroupByNewConnection == null) {

                this.SnapshotGroupByNewConnection = new PolarisSnapshotGroupByNewConnection();
                this.SnapshotGroupByNewConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByNewConnection"));

            } else {

                this.SnapshotGroupByNewConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByNewConnection"));

            }
        }
        else if (this.SnapshotGroupByNewConnection != null && ec.Excludes("snapshotGroupByNewConnection",false))
        {
            this.SnapshotGroupByNewConnection = null;
        }
        //      C# -> WorkflowConfig? WorkflowConfig
        // GraphQL -> workflowConfig: WorkflowConfig (type)
        if (ec.Includes("workflowConfig",false))
        {
            if(this.WorkflowConfig == null) {

                this.WorkflowConfig = new WorkflowConfig();
                this.WorkflowConfig.ApplyExploratoryFieldSpec(ec.NewChild("workflowConfig"));

            } else {

                this.WorkflowConfig.ApplyExploratoryFieldSpec(ec.NewChild("workflowConfig"));

            }
        }
        else if (this.WorkflowConfig != null && ec.Excludes("workflowConfig",false))
        {
            this.WorkflowConfig = null;
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (ec.Includes("workloadSnapshotConnection",false))
        {
            if(this.WorkloadSnapshotConnection == null) {

                this.WorkloadSnapshotConnection = new GenericSnapshotConnection();
                this.WorkloadSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("workloadSnapshotConnection"));

            } else {

                this.WorkloadSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("workloadSnapshotConnection"));

            }
        }
        else if (this.WorkloadSnapshotConnection != null && ec.Excludes("workloadSnapshotConnection",false))
        {
            this.WorkloadSnapshotConnection = null;
        }
    }


    #endregion

    } // class OktaTenant
    
    #endregion

    public static class ListOktaTenantExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<OktaTenant> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OktaTenant> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OktaTenant> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OktaTenant());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OktaTenant> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types