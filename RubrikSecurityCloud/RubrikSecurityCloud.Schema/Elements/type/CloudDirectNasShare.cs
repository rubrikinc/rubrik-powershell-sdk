// CloudDirectNasShare.cs
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
    #region CloudDirectNasShare
 
    public class CloudDirectNasShare: BaseType, CloudDirectHierarchyObject, CloudDirectHierarchyWorkload, CloudDirectNasNamespaceDescendantType, CloudDirectNasNamespaceLogicalChildType, CloudDirectNasSystemDescendantType, CloudDirectNasSystemLogicalChildType, HierarchyObject
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> CloudDirectNasProtocolType? Protocol
        // GraphQL -> protocol: CloudDirectNasProtocolType! (enum)
        [JsonProperty("protocol")]
        public CloudDirectNasProtocolType? Protocol { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

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

        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: String! (scalar)
        [JsonProperty("cloudDirectId")]
        public System.String? CloudDirectId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? ExportPath
        // GraphQL -> exportPath: String! (scalar)
        [JsonProperty("exportPath")]
        public System.String? ExportPath { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        [JsonProperty("isHidden")]
        public System.Boolean? IsHidden { get; set; }

        //      C# -> System.Boolean? IsNasShareManuallyAdded
        // GraphQL -> isNasShareManuallyAdded: Boolean! (scalar)
        [JsonProperty("isNasShareManuallyAdded")]
        public System.Boolean? IsNasShareManuallyAdded { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Boolean? IsStale
        // GraphQL -> isStale: Boolean! (scalar)
        [JsonProperty("isStale")]
        public System.Boolean? IsStale { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NamespaceId
        // GraphQL -> namespaceId: String (scalar)
        [JsonProperty("namespaceId")]
        public System.String? NamespaceId { get; set; }

        //      C# -> System.String? NcdPolicyName
        // GraphQL -> ncdPolicyName: String! (scalar)
        [JsonProperty("ncdPolicyName")]
        public System.String? NcdPolicyName { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        [JsonProperty("policyName")]
        public System.String? PolicyName { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? SystemId
        // GraphQL -> systemId: UUID! (scalar)
        [JsonProperty("systemId")]
        public System.String? SystemId { get; set; }

        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int! (scalar)
        [JsonProperty("totalSnapshots")]
        public System.Int32? TotalSnapshots { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> CloudDirectNasShareConnection? ChildShares
        // GraphQL -> childShares: CloudDirectNasShareConnection (type)
        [JsonProperty("childShares")]
        public CloudDirectNasShareConnection? ChildShares { get; set; }

        //      C# -> CloudDirectNasNamespace? CloudDirectNasNamespace
        // GraphQL -> cloudDirectNasNamespace: CloudDirectNasNamespace (type)
        [JsonProperty("cloudDirectNasNamespace")]
        public CloudDirectNasNamespace? CloudDirectNasNamespace { get; set; }

        //      C# -> CloudDirectNasSystem? CloudDirectNasSystem
        // GraphQL -> cloudDirectNasSystem: CloudDirectNasSystem (type)
        [JsonProperty("cloudDirectNasSystem")]
        public CloudDirectNasSystem? CloudDirectNasSystem { get; set; }

        //      C# -> CloudDirectSnapshotsGroupBySummaryConnection? CloudDirectSnapshotGroupBySummary
        // GraphQL -> cloudDirectSnapshotGroupBySummary: CloudDirectSnapshotsGroupBySummaryConnection (type)
        [JsonProperty("cloudDirectSnapshotGroupBySummary")]
        public CloudDirectSnapshotsGroupBySummaryConnection? CloudDirectSnapshotGroupBySummary { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<Exclude>? Excludes
        // GraphQL -> excludes: [Exclude!]! (type)
        [JsonProperty("excludes")]
        public List<Exclude>? Excludes { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> CloudDirectSnapshotsGroupBySummaryConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: CloudDirectSnapshotsGroupBySummaryConnection (type)
        [JsonProperty("missedSnapshotGroupByConnection")]
        public CloudDirectSnapshotsGroupBySummaryConnection? MissedSnapshotGroupByConnection { get; set; }

        //      C# -> CloudDirectSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CloudDirectSnapshot (type)
        [JsonProperty("newestSnapshot")]
        public CloudDirectSnapshot? NewestSnapshot { get; set; }

        //      C# -> CloudDirectSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CloudDirectSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public CloudDirectSnapshot? OldestSnapshot { get; set; }

        //      C# -> CloudDirectNasShare? ParentShare
        // GraphQL -> parentShare: CloudDirectNasShare (type)
        [JsonProperty("parentShare")]
        public CloudDirectNasShare? ParentShare { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        [JsonProperty("securityMetadata")]
        public SecurityMetadata? SecurityMetadata { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars ChildShares { get; set; }

        public RscGqlVars CloudDirectSnapshotGroupBySummary { get; set; }

        public RscGqlVars MissedSnapshotGroupByConnection { get; set; }

        public RscGqlVars ParentShare { get; set; }


        public InlineVars() {
            Tuple<string, string>[] childSharesArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                };
            this.ChildShares =
                new RscGqlVars(null, childSharesArgs, null, true);
            Tuple<string, string>[] cloudDirectSnapshotGroupBySummaryArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("timezoneOffset", "Float"),
                    Tuple.Create("filter", "[CloudDirectSnapshotsFilterInput!]"),
                    Tuple.Create("groupBy", "SnapshotGroupByTime!"),
                    Tuple.Create("timeRange", "TimeRangeInput"),
                };
            this.CloudDirectSnapshotGroupBySummary =
                new RscGqlVars(null, cloudDirectSnapshotGroupBySummaryArgs, null, true);
            Tuple<string, string>[] missedSnapshotGroupByConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("timezoneOffset", "Float"),
                    Tuple.Create("filter", "[CloudDirectSnapshotsFilterInput!]"),
                    Tuple.Create("groupBy", "SnapshotGroupByTime!"),
                    Tuple.Create("timeRange", "TimeRangeInput"),
                };
            this.MissedSnapshotGroupByConnection =
                new RscGqlVars(null, missedSnapshotGroupByConnectionArgs, null, true);
            Tuple<string, string>[] parentShareArgs = {
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                };
            this.ParentShare =
                new RscGqlVars(null, parentShareArgs, null, true);
        }
    }

    public CloudDirectNasShare()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "CloudDirectNasShare";
    }

    public CloudDirectNasShare Set(
        List<Operation>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        CloudDirectNasProtocolType? Protocol = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? CloudDirectId = null,
        System.String? ClusterUuid = null,
        System.String? ExportPath = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsHidden = null,
        System.Boolean? IsNasShareManuallyAdded = null,
        System.Boolean? IsRelic = null,
        System.Boolean? IsStale = null,
        System.String? Name = null,
        System.String? NamespaceId = null,
        System.String? NcdPolicyName = null,
        System.Int32? NumWorkloadDescendants = null,
        System.String? PolicyName = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? SystemId = null,
        System.Int32? TotalSnapshots = null,
        List<Org>? AllOrgs = null,
        CloudDirectNasShareConnection? ChildShares = null,
        CloudDirectNasNamespace? CloudDirectNasNamespace = null,
        CloudDirectNasSystem? CloudDirectNasSystem = null,
        CloudDirectSnapshotsGroupBySummaryConnection? CloudDirectSnapshotGroupBySummary = null,
        Cluster? Cluster = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<Exclude>? Excludes = null,
        List<PathNode>? LogicalPath = null,
        CloudDirectSnapshotsGroupBySummaryConnection? MissedSnapshotGroupByConnection = null,
        CloudDirectSnapshot? NewestSnapshot = null,
        CloudDirectSnapshot? OldestSnapshot = null,
        CloudDirectNasShare? ParentShare = null,
        List<PathNode>? PhysicalPath = null,
        SecurityMetadata? SecurityMetadata = null,
        SnapshotDistribution? SnapshotDistribution = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Protocol != null ) {
            this.Protocol = Protocol;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
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
        if ( CloudDirectId != null ) {
            this.CloudDirectId = CloudDirectId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( ExportPath != null ) {
            this.ExportPath = ExportPath;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsHidden != null ) {
            this.IsHidden = IsHidden;
        }
        if ( IsNasShareManuallyAdded != null ) {
            this.IsNasShareManuallyAdded = IsNasShareManuallyAdded;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( IsStale != null ) {
            this.IsStale = IsStale;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NamespaceId != null ) {
            this.NamespaceId = NamespaceId;
        }
        if ( NcdPolicyName != null ) {
            this.NcdPolicyName = NcdPolicyName;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( PolicyName != null ) {
            this.PolicyName = PolicyName;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( SystemId != null ) {
            this.SystemId = SystemId;
        }
        if ( TotalSnapshots != null ) {
            this.TotalSnapshots = TotalSnapshots;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( ChildShares != null ) {
            this.ChildShares = ChildShares;
        }
        if ( CloudDirectNasNamespace != null ) {
            this.CloudDirectNasNamespace = CloudDirectNasNamespace;
        }
        if ( CloudDirectNasSystem != null ) {
            this.CloudDirectNasSystem = CloudDirectNasSystem;
        }
        if ( CloudDirectSnapshotGroupBySummary != null ) {
            this.CloudDirectSnapshotGroupBySummary = CloudDirectSnapshotGroupBySummary;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( Excludes != null ) {
            this.Excludes = Excludes;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( MissedSnapshotGroupByConnection != null ) {
            this.MissedSnapshotGroupByConnection = MissedSnapshotGroupByConnection;
        }
        if ( NewestSnapshot != null ) {
            this.NewestSnapshot = NewestSnapshot;
        }
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( ParentShare != null ) {
            this.ParentShare = ParentShare;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( SecurityMetadata != null ) {
            this.SecurityMetadata = SecurityMetadata;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
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
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> CloudDirectNasProtocolType? Protocol
        // GraphQL -> protocol: CloudDirectNasProtocolType! (enum)
        if (this.Protocol != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protocol\n" ;
            } else {
                s += ind + "protocol\n" ;
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
        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: String! (scalar)
        if (this.CloudDirectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudDirectId\n" ;
            } else {
                s += ind + "cloudDirectId\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? ExportPath
        // GraphQL -> exportPath: String! (scalar)
        if (this.ExportPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exportPath\n" ;
            } else {
                s += ind + "exportPath\n" ;
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
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (this.IsHidden != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHidden\n" ;
            } else {
                s += ind + "isHidden\n" ;
            }
        }
        //      C# -> System.Boolean? IsNasShareManuallyAdded
        // GraphQL -> isNasShareManuallyAdded: Boolean! (scalar)
        if (this.IsNasShareManuallyAdded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isNasShareManuallyAdded\n" ;
            } else {
                s += ind + "isNasShareManuallyAdded\n" ;
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
        //      C# -> System.Boolean? IsStale
        // GraphQL -> isStale: Boolean! (scalar)
        if (this.IsStale != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isStale\n" ;
            } else {
                s += ind + "isStale\n" ;
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
        //      C# -> System.String? NamespaceId
        // GraphQL -> namespaceId: String (scalar)
        if (this.NamespaceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "namespaceId\n" ;
            } else {
                s += ind + "namespaceId\n" ;
            }
        }
        //      C# -> System.String? NcdPolicyName
        // GraphQL -> ncdPolicyName: String! (scalar)
        if (this.NcdPolicyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ncdPolicyName\n" ;
            } else {
                s += ind + "ncdPolicyName\n" ;
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
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyName\n" ;
            } else {
                s += ind + "policyName\n" ;
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
        //      C# -> System.String? SystemId
        // GraphQL -> systemId: UUID! (scalar)
        if (this.SystemId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemId\n" ;
            } else {
                s += ind + "systemId\n" ;
            }
        }
        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int! (scalar)
        if (this.TotalSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSnapshots\n" ;
            } else {
                s += ind + "totalSnapshots\n" ;
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
        //      C# -> CloudDirectNasShareConnection? ChildShares
        // GraphQL -> childShares: CloudDirectNasShareConnection (type)
        if (this.ChildShares != null) {
            var fspec = this.ChildShares.AsFieldSpec(conf.Child("childShares"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "childShares" + "\n(" + this.Vars.ChildShares.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudDirectNasNamespace? CloudDirectNasNamespace
        // GraphQL -> cloudDirectNasNamespace: CloudDirectNasNamespace (type)
        if (this.CloudDirectNasNamespace != null) {
            var fspec = this.CloudDirectNasNamespace.AsFieldSpec(conf.Child("cloudDirectNasNamespace"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudDirectNasNamespace" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudDirectNasSystem? CloudDirectNasSystem
        // GraphQL -> cloudDirectNasSystem: CloudDirectNasSystem (type)
        if (this.CloudDirectNasSystem != null) {
            var fspec = this.CloudDirectNasSystem.AsFieldSpec(conf.Child("cloudDirectNasSystem"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudDirectNasSystem" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudDirectSnapshotsGroupBySummaryConnection? CloudDirectSnapshotGroupBySummary
        // GraphQL -> cloudDirectSnapshotGroupBySummary: CloudDirectSnapshotsGroupBySummaryConnection (type)
        if (this.CloudDirectSnapshotGroupBySummary != null) {
            var fspec = this.CloudDirectSnapshotGroupBySummary.AsFieldSpec(conf.Child("cloudDirectSnapshotGroupBySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudDirectSnapshotGroupBySummary" + "\n(" + this.Vars.CloudDirectSnapshotGroupBySummary.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<Exclude>? Excludes
        // GraphQL -> excludes: [Exclude!]! (type)
        if (this.Excludes != null) {
            var fspec = this.Excludes.AsFieldSpec(conf.Child("excludes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "excludes" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> CloudDirectSnapshotsGroupBySummaryConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: CloudDirectSnapshotsGroupBySummaryConnection (type)
        if (this.MissedSnapshotGroupByConnection != null) {
            var fspec = this.MissedSnapshotGroupByConnection.AsFieldSpec(conf.Child("missedSnapshotGroupByConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "missedSnapshotGroupByConnection" + "\n(" + this.Vars.MissedSnapshotGroupByConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudDirectSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CloudDirectSnapshot (type)
        if (this.NewestSnapshot != null) {
            var fspec = this.NewestSnapshot.AsFieldSpec(conf.Child("newestSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudDirectSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CloudDirectSnapshot (type)
        if (this.OldestSnapshot != null) {
            var fspec = this.OldestSnapshot.AsFieldSpec(conf.Child("oldestSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldestSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudDirectNasShare? ParentShare
        // GraphQL -> parentShare: CloudDirectNasShare (type)
        if (this.ParentShare != null) {
            var fspec = this.ParentShare.AsFieldSpec(conf.Child("parentShare"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "parentShare" + "\n(" + this.Vars.ParentShare.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> CloudDirectNasProtocolType? Protocol
        // GraphQL -> protocol: CloudDirectNasProtocolType! (enum)
        if (ec.Includes("protocol",true))
        {
            if(this.Protocol == null) {

                this.Protocol = new CloudDirectNasProtocolType();

            } else {


            }
        }
        else if (this.Protocol != null && ec.Excludes("protocol",true))
        {
            this.Protocol = null;
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
        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: String! (scalar)
        if (ec.Includes("cloudDirectId",true))
        {
            if(this.CloudDirectId == null) {

                this.CloudDirectId = "FETCH";

            } else {


            }
        }
        else if (this.CloudDirectId != null && ec.Excludes("cloudDirectId",true))
        {
            this.CloudDirectId = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? ExportPath
        // GraphQL -> exportPath: String! (scalar)
        if (ec.Includes("exportPath",true))
        {
            if(this.ExportPath == null) {

                this.ExportPath = "FETCH";

            } else {


            }
        }
        else if (this.ExportPath != null && ec.Excludes("exportPath",true))
        {
            this.ExportPath = null;
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
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (ec.Includes("isHidden",true))
        {
            if(this.IsHidden == null) {

                this.IsHidden = true;

            } else {


            }
        }
        else if (this.IsHidden != null && ec.Excludes("isHidden",true))
        {
            this.IsHidden = null;
        }
        //      C# -> System.Boolean? IsNasShareManuallyAdded
        // GraphQL -> isNasShareManuallyAdded: Boolean! (scalar)
        if (ec.Includes("isNasShareManuallyAdded",true))
        {
            if(this.IsNasShareManuallyAdded == null) {

                this.IsNasShareManuallyAdded = true;

            } else {


            }
        }
        else if (this.IsNasShareManuallyAdded != null && ec.Excludes("isNasShareManuallyAdded",true))
        {
            this.IsNasShareManuallyAdded = null;
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
        //      C# -> System.Boolean? IsStale
        // GraphQL -> isStale: Boolean! (scalar)
        if (ec.Includes("isStale",true))
        {
            if(this.IsStale == null) {

                this.IsStale = true;

            } else {


            }
        }
        else if (this.IsStale != null && ec.Excludes("isStale",true))
        {
            this.IsStale = null;
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
        //      C# -> System.String? NamespaceId
        // GraphQL -> namespaceId: String (scalar)
        if (ec.Includes("namespaceId",true))
        {
            if(this.NamespaceId == null) {

                this.NamespaceId = "FETCH";

            } else {


            }
        }
        else if (this.NamespaceId != null && ec.Excludes("namespaceId",true))
        {
            this.NamespaceId = null;
        }
        //      C# -> System.String? NcdPolicyName
        // GraphQL -> ncdPolicyName: String! (scalar)
        if (ec.Includes("ncdPolicyName",true))
        {
            if(this.NcdPolicyName == null) {

                this.NcdPolicyName = "FETCH";

            } else {


            }
        }
        else if (this.NcdPolicyName != null && ec.Excludes("ncdPolicyName",true))
        {
            this.NcdPolicyName = null;
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
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (ec.Includes("policyName",true))
        {
            if(this.PolicyName == null) {

                this.PolicyName = "FETCH";

            } else {


            }
        }
        else if (this.PolicyName != null && ec.Excludes("policyName",true))
        {
            this.PolicyName = null;
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
        //      C# -> System.String? SystemId
        // GraphQL -> systemId: UUID! (scalar)
        if (ec.Includes("systemId",true))
        {
            if(this.SystemId == null) {

                this.SystemId = "FETCH";

            } else {


            }
        }
        else if (this.SystemId != null && ec.Excludes("systemId",true))
        {
            this.SystemId = null;
        }
        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int! (scalar)
        if (ec.Includes("totalSnapshots",true))
        {
            if(this.TotalSnapshots == null) {

                this.TotalSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalSnapshots != null && ec.Excludes("totalSnapshots",true))
        {
            this.TotalSnapshots = null;
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
        //      C# -> CloudDirectNasShareConnection? ChildShares
        // GraphQL -> childShares: CloudDirectNasShareConnection (type)
        if (ec.Includes("childShares",false))
        {
            if(this.ChildShares == null) {

                this.ChildShares = new CloudDirectNasShareConnection();
                this.ChildShares.ApplyExploratoryFieldSpec(ec.NewChild("childShares"));

            } else {

                this.ChildShares.ApplyExploratoryFieldSpec(ec.NewChild("childShares"));

            }
        }
        else if (this.ChildShares != null && ec.Excludes("childShares",false))
        {
            this.ChildShares = null;
        }
        //      C# -> CloudDirectNasNamespace? CloudDirectNasNamespace
        // GraphQL -> cloudDirectNasNamespace: CloudDirectNasNamespace (type)
        if (ec.Includes("cloudDirectNasNamespace",false))
        {
            if(this.CloudDirectNasNamespace == null) {

                this.CloudDirectNasNamespace = new CloudDirectNasNamespace();
                this.CloudDirectNasNamespace.ApplyExploratoryFieldSpec(ec.NewChild("cloudDirectNasNamespace"));

            } else {

                this.CloudDirectNasNamespace.ApplyExploratoryFieldSpec(ec.NewChild("cloudDirectNasNamespace"));

            }
        }
        else if (this.CloudDirectNasNamespace != null && ec.Excludes("cloudDirectNasNamespace",false))
        {
            this.CloudDirectNasNamespace = null;
        }
        //      C# -> CloudDirectNasSystem? CloudDirectNasSystem
        // GraphQL -> cloudDirectNasSystem: CloudDirectNasSystem (type)
        if (ec.Includes("cloudDirectNasSystem",false))
        {
            if(this.CloudDirectNasSystem == null) {

                this.CloudDirectNasSystem = new CloudDirectNasSystem();
                this.CloudDirectNasSystem.ApplyExploratoryFieldSpec(ec.NewChild("cloudDirectNasSystem"));

            } else {

                this.CloudDirectNasSystem.ApplyExploratoryFieldSpec(ec.NewChild("cloudDirectNasSystem"));

            }
        }
        else if (this.CloudDirectNasSystem != null && ec.Excludes("cloudDirectNasSystem",false))
        {
            this.CloudDirectNasSystem = null;
        }
        //      C# -> CloudDirectSnapshotsGroupBySummaryConnection? CloudDirectSnapshotGroupBySummary
        // GraphQL -> cloudDirectSnapshotGroupBySummary: CloudDirectSnapshotsGroupBySummaryConnection (type)
        if (ec.Includes("cloudDirectSnapshotGroupBySummary",false))
        {
            if(this.CloudDirectSnapshotGroupBySummary == null) {

                this.CloudDirectSnapshotGroupBySummary = new CloudDirectSnapshotsGroupBySummaryConnection();
                this.CloudDirectSnapshotGroupBySummary.ApplyExploratoryFieldSpec(ec.NewChild("cloudDirectSnapshotGroupBySummary"));

            } else {

                this.CloudDirectSnapshotGroupBySummary.ApplyExploratoryFieldSpec(ec.NewChild("cloudDirectSnapshotGroupBySummary"));

            }
        }
        else if (this.CloudDirectSnapshotGroupBySummary != null && ec.Excludes("cloudDirectSnapshotGroupBySummary",false))
        {
            this.CloudDirectSnapshotGroupBySummary = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
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
        //      C# -> List<Exclude>? Excludes
        // GraphQL -> excludes: [Exclude!]! (type)
        if (ec.Includes("excludes",false))
        {
            if(this.Excludes == null) {

                this.Excludes = new List<Exclude>();
                this.Excludes.ApplyExploratoryFieldSpec(ec.NewChild("excludes"));

            } else {

                this.Excludes.ApplyExploratoryFieldSpec(ec.NewChild("excludes"));

            }
        }
        else if (this.Excludes != null && ec.Excludes("excludes",false))
        {
            this.Excludes = null;
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
        //      C# -> CloudDirectSnapshotsGroupBySummaryConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: CloudDirectSnapshotsGroupBySummaryConnection (type)
        if (ec.Includes("missedSnapshotGroupByConnection",false))
        {
            if(this.MissedSnapshotGroupByConnection == null) {

                this.MissedSnapshotGroupByConnection = new CloudDirectSnapshotsGroupBySummaryConnection();
                this.MissedSnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotGroupByConnection"));

            } else {

                this.MissedSnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotGroupByConnection"));

            }
        }
        else if (this.MissedSnapshotGroupByConnection != null && ec.Excludes("missedSnapshotGroupByConnection",false))
        {
            this.MissedSnapshotGroupByConnection = null;
        }
        //      C# -> CloudDirectSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CloudDirectSnapshot (type)
        if (ec.Includes("newestSnapshot",false))
        {
            if(this.NewestSnapshot == null) {

                this.NewestSnapshot = new CloudDirectSnapshot();
                this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));

            } else {

                this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));

            }
        }
        else if (this.NewestSnapshot != null && ec.Excludes("newestSnapshot",false))
        {
            this.NewestSnapshot = null;
        }
        //      C# -> CloudDirectSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CloudDirectSnapshot (type)
        if (ec.Includes("oldestSnapshot",false))
        {
            if(this.OldestSnapshot == null) {

                this.OldestSnapshot = new CloudDirectSnapshot();
                this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));

            } else {

                this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));

            }
        }
        else if (this.OldestSnapshot != null && ec.Excludes("oldestSnapshot",false))
        {
            this.OldestSnapshot = null;
        }
        //      C# -> CloudDirectNasShare? ParentShare
        // GraphQL -> parentShare: CloudDirectNasShare (type)
        if (ec.Includes("parentShare",false))
        {
            if(this.ParentShare == null) {

                this.ParentShare = new CloudDirectNasShare();
                this.ParentShare.ApplyExploratoryFieldSpec(ec.NewChild("parentShare"));

            } else {

                this.ParentShare.ApplyExploratoryFieldSpec(ec.NewChild("parentShare"));

            }
        }
        else if (this.ParentShare != null && ec.Excludes("parentShare",false))
        {
            this.ParentShare = null;
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
    }


    #endregion

    } // class CloudDirectNasShare
    
    #endregion

    public static class ListCloudDirectNasShareExtensions
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
            this List<CloudDirectNasShare> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectNasShare> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectNasShare> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectNasShare());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectNasShare> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types