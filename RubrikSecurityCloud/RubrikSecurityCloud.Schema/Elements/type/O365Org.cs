// O365Org.cs
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
    #region O365Org
 
    public class O365Org: BaseType, HierarchyObject, PolarisHierarchyObject
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

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> OrgStatus? Status
        // GraphQL -> status: OrgStatus! (enum)
        [JsonProperty("status")]
        public OrgStatus? Status { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public RscInterface<SlaDomain> ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public RscInterface<SlaDomain> EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public RscInterface<SlaDomain> EffectiveSlaDomain { get; set; }

        //      C# -> System.String? ExocomputeId
        // GraphQL -> exocomputeId: String! (scalar)
        [JsonProperty("exocomputeId")]
        public System.String? ExocomputeId { get; set; }

        //      C# -> System.Boolean? HasSharePointLegacySnapshots
        // GraphQL -> hasSharePointLegacySnapshots: Boolean! (scalar)
        [JsonProperty("hasSharePointLegacySnapshots")]
        public System.Boolean? HasSharePointLegacySnapshots { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? Past1DayMailboxComplianceCount
        // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
        [JsonProperty("past1DayMailboxComplianceCount")]
        public System.Int32? Past1DayMailboxComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
        // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayMailboxOutOfComplianceCount")]
        public System.Int32? Past1DayMailboxOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayOnedriveComplianceCount
        // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
        [JsonProperty("past1DayOnedriveComplianceCount")]
        public System.Int32? Past1DayOnedriveComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
        // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayOnedriveOutOfComplianceCount")]
        public System.Int32? Past1DayOnedriveOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySharepointComplianceCount
        // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySharepointComplianceCount")]
        public System.Int32? Past1DaySharepointComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
        // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySharepointOutOfComplianceCount")]
        public System.Int32? Past1DaySharepointOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpListComplianceCount
        // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpListComplianceCount")]
        public System.Int32? Past1DaySpListComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
        // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpListOutOfComplianceCount")]
        public System.Int32? Past1DaySpListOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
        // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpSiteCollectionComplianceCount")]
        public System.Int32? Past1DaySpSiteCollectionComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
        // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpSiteCollectionOutOfComplianceCount")]
        public System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayTeamsComplianceCount
        // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
        [JsonProperty("past1DayTeamsComplianceCount")]
        public System.Int32? Past1DayTeamsComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
        // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayTeamsOutOfComplianceCount")]
        public System.Int32? Past1DayTeamsOutOfComplianceCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.Int32? UnprotectedUsersCount
        // GraphQL -> unprotectedUsersCount: Int! (scalar)
        [JsonProperty("unprotectedUsersCount")]
        public System.Int32? UnprotectedUsersCount { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> O365UserConnection? ChildConnection
        // GraphQL -> childConnection: O365UserConnection! (type)
        [JsonProperty("childConnection")]
        public O365UserConnection? ChildConnection { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        [JsonProperty("rscNativeObjectPendingSla")]
        public CompactSlaDomain? RscNativeObjectPendingSla { get; set; }

        //      C# -> O365OrgDescendantConnection? SearchDescendantConnection
        // GraphQL -> searchDescendantConnection: O365OrgDescendantConnection! (type)
        [JsonProperty("searchDescendantConnection")]
        public O365OrgDescendantConnection? SearchDescendantConnection { get; set; }

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
        public RscGqlVars ChildConnection { get; set; }

        public RscGqlVars SearchDescendantConnection { get; set; }


        public InlineVars() {
            Tuple<string, string>[] childConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("filter", "[Filter!]"),
                };
            this.ChildConnection =
                new RscGqlVars(null, childConnectionArgs, null, true);
            Tuple<string, string>[] searchDescendantConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("filter", "[Filter!]"),
                };
            this.SearchDescendantConnection =
                new RscGqlVars(null, searchDescendantConnectionArgs, null, true);
        }
    }

    public O365Org()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "O365Org";
    }

    public O365Org Set(
        List<Operation>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        OrgStatus? Status = null,
        RscInterface<SlaDomain> ConfiguredSlaDomain = null,
        RscInterface<SlaDomain> EffectiveRetentionSlaDomain = null,
        RscInterface<SlaDomain> EffectiveSlaDomain = null,
        System.String? ExocomputeId = null,
        System.Boolean? HasSharePointLegacySnapshots = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? Past1DayMailboxComplianceCount = null,
        System.Int32? Past1DayMailboxOutOfComplianceCount = null,
        System.Int32? Past1DayOnedriveComplianceCount = null,
        System.Int32? Past1DayOnedriveOutOfComplianceCount = null,
        System.Int32? Past1DaySharepointComplianceCount = null,
        System.Int32? Past1DaySharepointOutOfComplianceCount = null,
        System.Int32? Past1DaySpListComplianceCount = null,
        System.Int32? Past1DaySpListOutOfComplianceCount = null,
        System.Int32? Past1DaySpSiteCollectionComplianceCount = null,
        System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount = null,
        System.Int32? Past1DayTeamsComplianceCount = null,
        System.Int32? Past1DayTeamsOutOfComplianceCount = null,
        System.Boolean? SlaPauseStatus = null,
        System.Int32? UnprotectedUsersCount = null,
        List<Org>? AllOrgs = null,
        O365UserConnection? ChildConnection = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        CompactSlaDomain? RscNativeObjectPendingSla = null,
        O365OrgDescendantConnection? SearchDescendantConnection = null,
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
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        if ( ExocomputeId != null ) {
            this.ExocomputeId = ExocomputeId;
        }
        if ( HasSharePointLegacySnapshots != null ) {
            this.HasSharePointLegacySnapshots = HasSharePointLegacySnapshots;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( Past1DayMailboxComplianceCount != null ) {
            this.Past1DayMailboxComplianceCount = Past1DayMailboxComplianceCount;
        }
        if ( Past1DayMailboxOutOfComplianceCount != null ) {
            this.Past1DayMailboxOutOfComplianceCount = Past1DayMailboxOutOfComplianceCount;
        }
        if ( Past1DayOnedriveComplianceCount != null ) {
            this.Past1DayOnedriveComplianceCount = Past1DayOnedriveComplianceCount;
        }
        if ( Past1DayOnedriveOutOfComplianceCount != null ) {
            this.Past1DayOnedriveOutOfComplianceCount = Past1DayOnedriveOutOfComplianceCount;
        }
        if ( Past1DaySharepointComplianceCount != null ) {
            this.Past1DaySharepointComplianceCount = Past1DaySharepointComplianceCount;
        }
        if ( Past1DaySharepointOutOfComplianceCount != null ) {
            this.Past1DaySharepointOutOfComplianceCount = Past1DaySharepointOutOfComplianceCount;
        }
        if ( Past1DaySpListComplianceCount != null ) {
            this.Past1DaySpListComplianceCount = Past1DaySpListComplianceCount;
        }
        if ( Past1DaySpListOutOfComplianceCount != null ) {
            this.Past1DaySpListOutOfComplianceCount = Past1DaySpListOutOfComplianceCount;
        }
        if ( Past1DaySpSiteCollectionComplianceCount != null ) {
            this.Past1DaySpSiteCollectionComplianceCount = Past1DaySpSiteCollectionComplianceCount;
        }
        if ( Past1DaySpSiteCollectionOutOfComplianceCount != null ) {
            this.Past1DaySpSiteCollectionOutOfComplianceCount = Past1DaySpSiteCollectionOutOfComplianceCount;
        }
        if ( Past1DayTeamsComplianceCount != null ) {
            this.Past1DayTeamsComplianceCount = Past1DayTeamsComplianceCount;
        }
        if ( Past1DayTeamsOutOfComplianceCount != null ) {
            this.Past1DayTeamsOutOfComplianceCount = Past1DayTeamsOutOfComplianceCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( UnprotectedUsersCount != null ) {
            this.UnprotectedUsersCount = UnprotectedUsersCount;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( ChildConnection != null ) {
            this.ChildConnection = ChildConnection;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( RscNativeObjectPendingSla != null ) {
            this.RscNativeObjectPendingSla = RscNativeObjectPendingSla;
        }
        if ( SearchDescendantConnection != null ) {
            this.SearchDescendantConnection = SearchDescendantConnection;
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
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaAssignment\n" ;
            } else {
                s += ind + "slaAssignment\n" ;
            }
        }
        //      C# -> OrgStatus? Status
        // GraphQL -> status: OrgStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
            var fspec = this.ConfiguredSlaDomain.AsFieldSpec(conf.Child("configuredSlaDomain"));
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
            var fspec = this.EffectiveRetentionSlaDomain.AsFieldSpec(conf.Child("effectiveRetentionSlaDomain"));
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
            var fspec = this.EffectiveSlaDomain.AsFieldSpec(conf.Child("effectiveSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? ExocomputeId
        // GraphQL -> exocomputeId: String! (scalar)
        if (this.ExocomputeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exocomputeId\n" ;
            } else {
                s += ind + "exocomputeId\n" ;
            }
        }
        //      C# -> System.Boolean? HasSharePointLegacySnapshots
        // GraphQL -> hasSharePointLegacySnapshots: Boolean! (scalar)
        if (this.HasSharePointLegacySnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasSharePointLegacySnapshots\n" ;
            } else {
                s += ind + "hasSharePointLegacySnapshots\n" ;
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
        //      C# -> System.Int32? Past1DayMailboxComplianceCount
        // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
        if (this.Past1DayMailboxComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayMailboxComplianceCount\n" ;
            } else {
                s += ind + "past1DayMailboxComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
        // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayMailboxOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayMailboxOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DayMailboxOutOfComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayOnedriveComplianceCount
        // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
        if (this.Past1DayOnedriveComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayOnedriveComplianceCount\n" ;
            } else {
                s += ind + "past1DayOnedriveComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
        // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayOnedriveOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayOnedriveOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DayOnedriveOutOfComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySharepointComplianceCount
        // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
        if (this.Past1DaySharepointComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySharepointComplianceCount\n" ;
            } else {
                s += ind + "past1DaySharepointComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
        // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySharepointOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySharepointOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DaySharepointOutOfComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySpListComplianceCount
        // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
        if (this.Past1DaySpListComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySpListComplianceCount\n" ;
            } else {
                s += ind + "past1DaySpListComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
        // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySpListOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySpListOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DaySpListOutOfComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
        // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
        if (this.Past1DaySpSiteCollectionComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySpSiteCollectionComplianceCount\n" ;
            } else {
                s += ind + "past1DaySpSiteCollectionComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
        // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySpSiteCollectionOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySpSiteCollectionOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DaySpSiteCollectionOutOfComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayTeamsComplianceCount
        // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
        if (this.Past1DayTeamsComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayTeamsComplianceCount\n" ;
            } else {
                s += ind + "past1DayTeamsComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
        // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayTeamsOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayTeamsOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DayTeamsOutOfComplianceCount\n" ;
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
        //      C# -> System.Int32? UnprotectedUsersCount
        // GraphQL -> unprotectedUsersCount: Int! (scalar)
        if (this.UnprotectedUsersCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectedUsersCount\n" ;
            } else {
                s += ind + "unprotectedUsersCount\n" ;
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(conf.Child("allOrgs"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> O365UserConnection? ChildConnection
        // GraphQL -> childConnection: O365UserConnection! (type)
        if (this.ChildConnection != null) {
            var fspec = this.ChildConnection.AsFieldSpec(conf.Child("childConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "childConnection" + "\n(" + this.Vars.ChildConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(conf.Child("effectiveSlaSourceObject"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaSourceObject" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(conf.Child("logicalPath"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(conf.Child("physicalPath"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
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
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rscNativeObjectPendingSla" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> O365OrgDescendantConnection? SearchDescendantConnection
        // GraphQL -> searchDescendantConnection: O365OrgDescendantConnection! (type)
        if (this.SearchDescendantConnection != null) {
            var fspec = this.SearchDescendantConnection.AsFieldSpec(conf.Child("searchDescendantConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "searchDescendantConnection" + "\n(" + this.Vars.SearchDescendantConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        if (this.SecurityMetadata != null) {
            var fspec = this.SecurityMetadata.AsFieldSpec(conf.Child("securityMetadata"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
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
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotDistribution" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
        //      C# -> OrgStatus? Status
        // GraphQL -> status: OrgStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new OrgStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (ec.Includes("configuredSlaDomain",false))
        {
            if(this.ConfiguredSlaDomain == null) {

                this.ConfiguredSlaDomain = new RscInterface<SlaDomain>();
                this.ConfiguredSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));

            } else {

                this.ConfiguredSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));

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

                this.EffectiveRetentionSlaDomain = new RscInterface<SlaDomain>();
                this.EffectiveRetentionSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));

            } else {

                this.EffectiveRetentionSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));

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

                this.EffectiveSlaDomain = new RscInterface<SlaDomain>();
                this.EffectiveSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));

            } else {

                this.EffectiveSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));

            }
        }
        else if (this.EffectiveSlaDomain != null && ec.Excludes("effectiveSlaDomain",false))
        {
            this.EffectiveSlaDomain = null;
        }
        //      C# -> System.String? ExocomputeId
        // GraphQL -> exocomputeId: String! (scalar)
        if (ec.Includes("exocomputeId",true))
        {
            if(this.ExocomputeId == null) {

                this.ExocomputeId = "FETCH";

            } else {


            }
        }
        else if (this.ExocomputeId != null && ec.Excludes("exocomputeId",true))
        {
            this.ExocomputeId = null;
        }
        //      C# -> System.Boolean? HasSharePointLegacySnapshots
        // GraphQL -> hasSharePointLegacySnapshots: Boolean! (scalar)
        if (ec.Includes("hasSharePointLegacySnapshots",true))
        {
            if(this.HasSharePointLegacySnapshots == null) {

                this.HasSharePointLegacySnapshots = true;

            } else {


            }
        }
        else if (this.HasSharePointLegacySnapshots != null && ec.Excludes("hasSharePointLegacySnapshots",true))
        {
            this.HasSharePointLegacySnapshots = null;
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
        //      C# -> System.Int32? Past1DayMailboxComplianceCount
        // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayMailboxComplianceCount",true))
        {
            if(this.Past1DayMailboxComplianceCount == null) {

                this.Past1DayMailboxComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayMailboxComplianceCount != null && ec.Excludes("past1DayMailboxComplianceCount",true))
        {
            this.Past1DayMailboxComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
        // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayMailboxOutOfComplianceCount",true))
        {
            if(this.Past1DayMailboxOutOfComplianceCount == null) {

                this.Past1DayMailboxOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayMailboxOutOfComplianceCount != null && ec.Excludes("past1DayMailboxOutOfComplianceCount",true))
        {
            this.Past1DayMailboxOutOfComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DayOnedriveComplianceCount
        // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayOnedriveComplianceCount",true))
        {
            if(this.Past1DayOnedriveComplianceCount == null) {

                this.Past1DayOnedriveComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayOnedriveComplianceCount != null && ec.Excludes("past1DayOnedriveComplianceCount",true))
        {
            this.Past1DayOnedriveComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
        // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayOnedriveOutOfComplianceCount",true))
        {
            if(this.Past1DayOnedriveOutOfComplianceCount == null) {

                this.Past1DayOnedriveOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayOnedriveOutOfComplianceCount != null && ec.Excludes("past1DayOnedriveOutOfComplianceCount",true))
        {
            this.Past1DayOnedriveOutOfComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySharepointComplianceCount
        // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySharepointComplianceCount",true))
        {
            if(this.Past1DaySharepointComplianceCount == null) {

                this.Past1DaySharepointComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySharepointComplianceCount != null && ec.Excludes("past1DaySharepointComplianceCount",true))
        {
            this.Past1DaySharepointComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
        // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySharepointOutOfComplianceCount",true))
        {
            if(this.Past1DaySharepointOutOfComplianceCount == null) {

                this.Past1DaySharepointOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySharepointOutOfComplianceCount != null && ec.Excludes("past1DaySharepointOutOfComplianceCount",true))
        {
            this.Past1DaySharepointOutOfComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySpListComplianceCount
        // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySpListComplianceCount",true))
        {
            if(this.Past1DaySpListComplianceCount == null) {

                this.Past1DaySpListComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySpListComplianceCount != null && ec.Excludes("past1DaySpListComplianceCount",true))
        {
            this.Past1DaySpListComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
        // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySpListOutOfComplianceCount",true))
        {
            if(this.Past1DaySpListOutOfComplianceCount == null) {

                this.Past1DaySpListOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySpListOutOfComplianceCount != null && ec.Excludes("past1DaySpListOutOfComplianceCount",true))
        {
            this.Past1DaySpListOutOfComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
        // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySpSiteCollectionComplianceCount",true))
        {
            if(this.Past1DaySpSiteCollectionComplianceCount == null) {

                this.Past1DaySpSiteCollectionComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySpSiteCollectionComplianceCount != null && ec.Excludes("past1DaySpSiteCollectionComplianceCount",true))
        {
            this.Past1DaySpSiteCollectionComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
        // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySpSiteCollectionOutOfComplianceCount",true))
        {
            if(this.Past1DaySpSiteCollectionOutOfComplianceCount == null) {

                this.Past1DaySpSiteCollectionOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySpSiteCollectionOutOfComplianceCount != null && ec.Excludes("past1DaySpSiteCollectionOutOfComplianceCount",true))
        {
            this.Past1DaySpSiteCollectionOutOfComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DayTeamsComplianceCount
        // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayTeamsComplianceCount",true))
        {
            if(this.Past1DayTeamsComplianceCount == null) {

                this.Past1DayTeamsComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayTeamsComplianceCount != null && ec.Excludes("past1DayTeamsComplianceCount",true))
        {
            this.Past1DayTeamsComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
        // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayTeamsOutOfComplianceCount",true))
        {
            if(this.Past1DayTeamsOutOfComplianceCount == null) {

                this.Past1DayTeamsOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayTeamsOutOfComplianceCount != null && ec.Excludes("past1DayTeamsOutOfComplianceCount",true))
        {
            this.Past1DayTeamsOutOfComplianceCount = null;
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
        //      C# -> System.Int32? UnprotectedUsersCount
        // GraphQL -> unprotectedUsersCount: Int! (scalar)
        if (ec.Includes("unprotectedUsersCount",true))
        {
            if(this.UnprotectedUsersCount == null) {

                this.UnprotectedUsersCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.UnprotectedUsersCount != null && ec.Excludes("unprotectedUsersCount",true))
        {
            this.UnprotectedUsersCount = null;
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
        //      C# -> O365UserConnection? ChildConnection
        // GraphQL -> childConnection: O365UserConnection! (type)
        if (ec.Includes("childConnection",false))
        {
            if(this.ChildConnection == null) {

                this.ChildConnection = new O365UserConnection();
                this.ChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("childConnection"));

            } else {

                this.ChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("childConnection"));

            }
        }
        else if (this.ChildConnection != null && ec.Excludes("childConnection",false))
        {
            this.ChildConnection = null;
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
        //      C# -> O365OrgDescendantConnection? SearchDescendantConnection
        // GraphQL -> searchDescendantConnection: O365OrgDescendantConnection! (type)
        if (ec.Includes("searchDescendantConnection",false))
        {
            if(this.SearchDescendantConnection == null) {

                this.SearchDescendantConnection = new O365OrgDescendantConnection();
                this.SearchDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("searchDescendantConnection"));

            } else {

                this.SearchDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("searchDescendantConnection"));

            }
        }
        else if (this.SearchDescendantConnection != null && ec.Excludes("searchDescendantConnection",false))
        {
            this.SearchDescendantConnection = null;
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

    } // class O365Org
    
    #endregion

    public static class ListO365OrgExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<O365Org> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365Org> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365Org> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365Org());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365Org> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types