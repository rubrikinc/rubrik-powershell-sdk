// RecoveryPlan.cs
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
    #region RecoveryPlan
 
    public class RecoveryPlan: BaseType, HierarchyObject
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> BlueprintFailoverStatus? LastFailoverStatus
        // GraphQL -> lastFailoverStatus: BlueprintFailoverStatus! (enum)
        [JsonProperty("lastFailoverStatus")]
        public BlueprintFailoverStatus? LastFailoverStatus { get; set; }

        //      C# -> BlueprintFailoverStatus? LastIsolatedRecoveryStatus
        // GraphQL -> lastIsolatedRecoveryStatus: BlueprintFailoverStatus! (enum)
        [JsonProperty("lastIsolatedRecoveryStatus")]
        public BlueprintFailoverStatus? LastIsolatedRecoveryStatus { get; set; }

        //      C# -> BlueprintFailoverStatus? LastLocalRecoveryStatus
        // GraphQL -> lastLocalRecoveryStatus: BlueprintFailoverStatus! (enum)
        [JsonProperty("lastLocalRecoveryStatus")]
        public BlueprintFailoverStatus? LastLocalRecoveryStatus { get; set; }

        //      C# -> BlueprintFailoverStatus? LastTestFailoverStatus
        // GraphQL -> lastTestFailoverStatus: BlueprintFailoverStatus! (enum)
        [JsonProperty("lastTestFailoverStatus")]
        public BlueprintFailoverStatus? LastTestFailoverStatus { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> BlueprintPlatform? Platform
        // GraphQL -> platform: BlueprintPlatform! (enum)
        [JsonProperty("platform")]
        public BlueprintPlatform? Platform { get; set; }

        //      C# -> BlueprintRecoveryType? RecoveryType
        // GraphQL -> recoveryType: BlueprintRecoveryType (enum)
        [JsonProperty("recoveryType")]
        public BlueprintRecoveryType? RecoveryType { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> BlueprintStatus? Status
        // GraphQL -> status: BlueprintStatus! (enum)
        [JsonProperty("status")]
        public BlueprintStatus? Status { get; set; }

        //      C# -> ObjectTypeEnum? WorkloadType
        // GraphQL -> workloadType: ObjectTypeEnum! (enum)
        [JsonProperty("workloadType")]
        public ObjectTypeEnum? WorkloadType { get; set; }

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

        //      C# -> BlueprintLocation? SourceLocation
        // GraphQL -> sourceLocation: BlueprintLocation (interface)
        [JsonProperty("sourceLocation")]
        public BlueprintLocation? SourceLocation { get; set; }

        //      C# -> BlueprintLocation? TargetLocation
        // GraphQL -> targetLocation: BlueprintLocation (interface)
        [JsonProperty("targetLocation")]
        public BlueprintLocation? TargetLocation { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean (scalar)
        [JsonProperty("isHydrationEnabled")]
        public System.Boolean? IsHydrationEnabled { get; set; }

        //      C# -> System.Boolean? IsTargetConsistent
        // GraphQL -> isTargetConsistent: Boolean! (scalar)
        [JsonProperty("isTargetConsistent")]
        public System.Boolean? IsTargetConsistent { get; set; }

        //      C# -> System.Boolean? IsVisible
        // GraphQL -> isVisible: Boolean! (scalar)
        [JsonProperty("isVisible")]
        public System.Boolean? IsVisible { get; set; }

        //      C# -> System.String? LastFailoverSource
        // GraphQL -> lastFailoverSource: String (scalar)
        [JsonProperty("lastFailoverSource")]
        public System.String? LastFailoverSource { get; set; }

        //      C# -> DateTime? LastFailoverTime
        // GraphQL -> lastFailoverTime: DateTime (scalar)
        [JsonProperty("lastFailoverTime")]
        public DateTime? LastFailoverTime { get; set; }

        //      C# -> DateTime? LastIsolatedRecoveryTime
        // GraphQL -> lastIsolatedRecoveryTime: DateTime (scalar)
        [JsonProperty("lastIsolatedRecoveryTime")]
        public DateTime? LastIsolatedRecoveryTime { get; set; }

        //      C# -> DateTime? LastLocalRecoveryTime
        // GraphQL -> lastLocalRecoveryTime: DateTime (scalar)
        [JsonProperty("lastLocalRecoveryTime")]
        public DateTime? LastLocalRecoveryTime { get; set; }

        //      C# -> DateTime? LastTestFailoverTime
        // GraphQL -> lastTestFailoverTime: DateTime (scalar)
        [JsonProperty("lastTestFailoverTime")]
        public DateTime? LastTestFailoverTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumChildren
        // GraphQL -> numChildren: Int! (scalar)
        [JsonProperty("numChildren")]
        public System.Int32? NumChildren { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> List<System.Int64>? PauseBetweenPriorityGroups
        // GraphQL -> pauseBetweenPriorityGroups: [Long!] (scalar)
        [JsonProperty("pauseBetweenPriorityGroups")]
        public List<System.Int64>? PauseBetweenPriorityGroups { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<RecoveryPlanChild>? Children
        // GraphQL -> children: [RecoveryPlanChild!]! (type)
        [JsonProperty("children")]
        public List<RecoveryPlanChild>? Children { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> BlueprintFailover? LatestFailover
        // GraphQL -> latestFailover: BlueprintFailover (type)
        [JsonProperty("latestFailover")]
        public BlueprintFailover? LatestFailover { get; set; }

        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        [JsonProperty("localRpoLagInfo")]
        public RpoLagInfo? LocalRpoLagInfo { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> BlueprintRecoveryCount? RecoveryCount
        // GraphQL -> recoveryCount: BlueprintRecoveryCount (type)
        [JsonProperty("recoveryCount")]
        public BlueprintRecoveryCount? RecoveryCount { get; set; }

        //      C# -> BlueprintRecoveryRanges? RecoveryRange
        // GraphQL -> recoveryRange: BlueprintRecoveryRanges (type)
        [JsonProperty("recoveryRange")]
        public BlueprintRecoveryRanges? RecoveryRange { get; set; }

        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        [JsonProperty("remoteRpoLagInfo")]
        public RpoLagInfo? RemoteRpoLagInfo { get; set; }

        //      C# -> Schedule? Schedule
        // GraphQL -> schedule: Schedule (type)
        [JsonProperty("schedule")]
        public Schedule? Schedule { get; set; }

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
        public RscGqlVars RecoveryRange { get; set; }


        public InlineVars() {
            Tuple<string, string>[] recoveryRangeArgs = {
                    Tuple.Create("clusterUuid", "UUID"),
                };
            this.RecoveryRange =
                new RscGqlVars(null, recoveryRangeArgs, null, true);
        }
    }

    public RecoveryPlan()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "RecoveryPlan";
    }

    public RecoveryPlan Set(
        List<Operation>? AuthorizedOperations = null,
        BlueprintFailoverStatus? LastFailoverStatus = null,
        BlueprintFailoverStatus? LastIsolatedRecoveryStatus = null,
        BlueprintFailoverStatus? LastLocalRecoveryStatus = null,
        BlueprintFailoverStatus? LastTestFailoverStatus = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        BlueprintPlatform? Platform = null,
        BlueprintRecoveryType? RecoveryType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        BlueprintStatus? Status = null,
        ObjectTypeEnum? WorkloadType = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        BlueprintLocation? SourceLocation = null,
        BlueprintLocation? TargetLocation = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsHydrationEnabled = null,
        System.Boolean? IsTargetConsistent = null,
        System.Boolean? IsVisible = null,
        System.String? LastFailoverSource = null,
        DateTime? LastFailoverTime = null,
        DateTime? LastIsolatedRecoveryTime = null,
        DateTime? LastLocalRecoveryTime = null,
        DateTime? LastTestFailoverTime = null,
        System.String? Name = null,
        System.Int32? NumChildren = null,
        System.Int32? NumWorkloadDescendants = null,
        List<System.Int64>? PauseBetweenPriorityGroups = null,
        System.Boolean? SlaPauseStatus = null,
        System.Int32? Version = null,
        List<Org>? AllOrgs = null,
        List<RecoveryPlanChild>? Children = null,
        PathNode? EffectiveSlaSourceObject = null,
        BlueprintFailover? LatestFailover = null,
        RpoLagInfo? LocalRpoLagInfo = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        BlueprintRecoveryCount? RecoveryCount = null,
        BlueprintRecoveryRanges? RecoveryRange = null,
        RpoLagInfo? RemoteRpoLagInfo = null,
        Schedule? Schedule = null,
        SecurityMetadata? SecurityMetadata = null,
        SnapshotDistribution? SnapshotDistribution = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( LastFailoverStatus != null ) {
            this.LastFailoverStatus = LastFailoverStatus;
        }
        if ( LastIsolatedRecoveryStatus != null ) {
            this.LastIsolatedRecoveryStatus = LastIsolatedRecoveryStatus;
        }
        if ( LastLocalRecoveryStatus != null ) {
            this.LastLocalRecoveryStatus = LastLocalRecoveryStatus;
        }
        if ( LastTestFailoverStatus != null ) {
            this.LastTestFailoverStatus = LastTestFailoverStatus;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Platform != null ) {
            this.Platform = Platform;
        }
        if ( RecoveryType != null ) {
            this.RecoveryType = RecoveryType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
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
        if ( SourceLocation != null ) {
            this.SourceLocation = SourceLocation;
        }
        if ( TargetLocation != null ) {
            this.TargetLocation = TargetLocation;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsHydrationEnabled != null ) {
            this.IsHydrationEnabled = IsHydrationEnabled;
        }
        if ( IsTargetConsistent != null ) {
            this.IsTargetConsistent = IsTargetConsistent;
        }
        if ( IsVisible != null ) {
            this.IsVisible = IsVisible;
        }
        if ( LastFailoverSource != null ) {
            this.LastFailoverSource = LastFailoverSource;
        }
        if ( LastFailoverTime != null ) {
            this.LastFailoverTime = LastFailoverTime;
        }
        if ( LastIsolatedRecoveryTime != null ) {
            this.LastIsolatedRecoveryTime = LastIsolatedRecoveryTime;
        }
        if ( LastLocalRecoveryTime != null ) {
            this.LastLocalRecoveryTime = LastLocalRecoveryTime;
        }
        if ( LastTestFailoverTime != null ) {
            this.LastTestFailoverTime = LastTestFailoverTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumChildren != null ) {
            this.NumChildren = NumChildren;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( PauseBetweenPriorityGroups != null ) {
            this.PauseBetweenPriorityGroups = PauseBetweenPriorityGroups;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( Children != null ) {
            this.Children = Children;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LatestFailover != null ) {
            this.LatestFailover = LatestFailover;
        }
        if ( LocalRpoLagInfo != null ) {
            this.LocalRpoLagInfo = LocalRpoLagInfo;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( RecoveryCount != null ) {
            this.RecoveryCount = RecoveryCount;
        }
        if ( RecoveryRange != null ) {
            this.RecoveryRange = RecoveryRange;
        }
        if ( RemoteRpoLagInfo != null ) {
            this.RemoteRpoLagInfo = RemoteRpoLagInfo;
        }
        if ( Schedule != null ) {
            this.Schedule = Schedule;
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
        //      C# -> BlueprintFailoverStatus? LastFailoverStatus
        // GraphQL -> lastFailoverStatus: BlueprintFailoverStatus! (enum)
        if (this.LastFailoverStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastFailoverStatus\n" ;
            } else {
                s += ind + "lastFailoverStatus\n" ;
            }
        }
        //      C# -> BlueprintFailoverStatus? LastIsolatedRecoveryStatus
        // GraphQL -> lastIsolatedRecoveryStatus: BlueprintFailoverStatus! (enum)
        if (this.LastIsolatedRecoveryStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastIsolatedRecoveryStatus\n" ;
            } else {
                s += ind + "lastIsolatedRecoveryStatus\n" ;
            }
        }
        //      C# -> BlueprintFailoverStatus? LastLocalRecoveryStatus
        // GraphQL -> lastLocalRecoveryStatus: BlueprintFailoverStatus! (enum)
        if (this.LastLocalRecoveryStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastLocalRecoveryStatus\n" ;
            } else {
                s += ind + "lastLocalRecoveryStatus\n" ;
            }
        }
        //      C# -> BlueprintFailoverStatus? LastTestFailoverStatus
        // GraphQL -> lastTestFailoverStatus: BlueprintFailoverStatus! (enum)
        if (this.LastTestFailoverStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastTestFailoverStatus\n" ;
            } else {
                s += ind + "lastTestFailoverStatus\n" ;
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
        //      C# -> BlueprintPlatform? Platform
        // GraphQL -> platform: BlueprintPlatform! (enum)
        if (this.Platform != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platform\n" ;
            } else {
                s += ind + "platform\n" ;
            }
        }
        //      C# -> BlueprintRecoveryType? RecoveryType
        // GraphQL -> recoveryType: BlueprintRecoveryType (enum)
        if (this.RecoveryType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryType\n" ;
            } else {
                s += ind + "recoveryType\n" ;
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
        //      C# -> BlueprintStatus? Status
        // GraphQL -> status: BlueprintStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> ObjectTypeEnum? WorkloadType
        // GraphQL -> workloadType: ObjectTypeEnum! (enum)
        if (this.WorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadType\n" ;
            } else {
                s += ind + "workloadType\n" ;
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
        //      C# -> BlueprintLocation? SourceLocation
        // GraphQL -> sourceLocation: BlueprintLocation (interface)
        if (this.SourceLocation != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.SourceLocation, conf.Child("sourceLocation"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceLocation" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> BlueprintLocation? TargetLocation
        // GraphQL -> targetLocation: BlueprintLocation (interface)
        if (this.TargetLocation != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.TargetLocation, conf.Child("targetLocation"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetLocation" + " " + "{\n" + fspec + ind + "}\n";
                }
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
        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean (scalar)
        if (this.IsHydrationEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHydrationEnabled\n" ;
            } else {
                s += ind + "isHydrationEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsTargetConsistent
        // GraphQL -> isTargetConsistent: Boolean! (scalar)
        if (this.IsTargetConsistent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTargetConsistent\n" ;
            } else {
                s += ind + "isTargetConsistent\n" ;
            }
        }
        //      C# -> System.Boolean? IsVisible
        // GraphQL -> isVisible: Boolean! (scalar)
        if (this.IsVisible != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isVisible\n" ;
            } else {
                s += ind + "isVisible\n" ;
            }
        }
        //      C# -> System.String? LastFailoverSource
        // GraphQL -> lastFailoverSource: String (scalar)
        if (this.LastFailoverSource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastFailoverSource\n" ;
            } else {
                s += ind + "lastFailoverSource\n" ;
            }
        }
        //      C# -> DateTime? LastFailoverTime
        // GraphQL -> lastFailoverTime: DateTime (scalar)
        if (this.LastFailoverTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastFailoverTime\n" ;
            } else {
                s += ind + "lastFailoverTime\n" ;
            }
        }
        //      C# -> DateTime? LastIsolatedRecoveryTime
        // GraphQL -> lastIsolatedRecoveryTime: DateTime (scalar)
        if (this.LastIsolatedRecoveryTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastIsolatedRecoveryTime\n" ;
            } else {
                s += ind + "lastIsolatedRecoveryTime\n" ;
            }
        }
        //      C# -> DateTime? LastLocalRecoveryTime
        // GraphQL -> lastLocalRecoveryTime: DateTime (scalar)
        if (this.LastLocalRecoveryTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastLocalRecoveryTime\n" ;
            } else {
                s += ind + "lastLocalRecoveryTime\n" ;
            }
        }
        //      C# -> DateTime? LastTestFailoverTime
        // GraphQL -> lastTestFailoverTime: DateTime (scalar)
        if (this.LastTestFailoverTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastTestFailoverTime\n" ;
            } else {
                s += ind + "lastTestFailoverTime\n" ;
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
        //      C# -> System.Int32? NumChildren
        // GraphQL -> numChildren: Int! (scalar)
        if (this.NumChildren != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numChildren\n" ;
            } else {
                s += ind + "numChildren\n" ;
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
        //      C# -> List<System.Int64>? PauseBetweenPriorityGroups
        // GraphQL -> pauseBetweenPriorityGroups: [Long!] (scalar)
        if (this.PauseBetweenPriorityGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pauseBetweenPriorityGroups\n" ;
            } else {
                s += ind + "pauseBetweenPriorityGroups\n" ;
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
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
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
        //      C# -> List<RecoveryPlanChild>? Children
        // GraphQL -> children: [RecoveryPlanChild!]! (type)
        if (this.Children != null) {
            var fspec = this.Children.AsFieldSpec(conf.Child("children"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "children" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> BlueprintFailover? LatestFailover
        // GraphQL -> latestFailover: BlueprintFailover (type)
        if (this.LatestFailover != null) {
            var fspec = this.LatestFailover.AsFieldSpec(conf.Child("latestFailover"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestFailover" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        if (this.LocalRpoLagInfo != null) {
            var fspec = this.LocalRpoLagInfo.AsFieldSpec(conf.Child("localRpoLagInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "localRpoLagInfo" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> BlueprintRecoveryCount? RecoveryCount
        // GraphQL -> recoveryCount: BlueprintRecoveryCount (type)
        if (this.RecoveryCount != null) {
            var fspec = this.RecoveryCount.AsFieldSpec(conf.Child("recoveryCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> BlueprintRecoveryRanges? RecoveryRange
        // GraphQL -> recoveryRange: BlueprintRecoveryRanges (type)
        if (this.RecoveryRange != null) {
            var fspec = this.RecoveryRange.AsFieldSpec(conf.Child("recoveryRange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryRange" + "\n(" + this.Vars.RecoveryRange.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        if (this.RemoteRpoLagInfo != null) {
            var fspec = this.RemoteRpoLagInfo.AsFieldSpec(conf.Child("remoteRpoLagInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remoteRpoLagInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Schedule? Schedule
        // GraphQL -> schedule: Schedule (type)
        if (this.Schedule != null) {
            var fspec = this.Schedule.AsFieldSpec(conf.Child("schedule"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "schedule" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> BlueprintFailoverStatus? LastFailoverStatus
        // GraphQL -> lastFailoverStatus: BlueprintFailoverStatus! (enum)
        if (ec.Includes("lastFailoverStatus",true))
        {
            if(this.LastFailoverStatus == null) {

                this.LastFailoverStatus = new BlueprintFailoverStatus();

            } else {


            }
        }
        else if (this.LastFailoverStatus != null && ec.Excludes("lastFailoverStatus",true))
        {
            this.LastFailoverStatus = null;
        }
        //      C# -> BlueprintFailoverStatus? LastIsolatedRecoveryStatus
        // GraphQL -> lastIsolatedRecoveryStatus: BlueprintFailoverStatus! (enum)
        if (ec.Includes("lastIsolatedRecoveryStatus",true))
        {
            if(this.LastIsolatedRecoveryStatus == null) {

                this.LastIsolatedRecoveryStatus = new BlueprintFailoverStatus();

            } else {


            }
        }
        else if (this.LastIsolatedRecoveryStatus != null && ec.Excludes("lastIsolatedRecoveryStatus",true))
        {
            this.LastIsolatedRecoveryStatus = null;
        }
        //      C# -> BlueprintFailoverStatus? LastLocalRecoveryStatus
        // GraphQL -> lastLocalRecoveryStatus: BlueprintFailoverStatus! (enum)
        if (ec.Includes("lastLocalRecoveryStatus",true))
        {
            if(this.LastLocalRecoveryStatus == null) {

                this.LastLocalRecoveryStatus = new BlueprintFailoverStatus();

            } else {


            }
        }
        else if (this.LastLocalRecoveryStatus != null && ec.Excludes("lastLocalRecoveryStatus",true))
        {
            this.LastLocalRecoveryStatus = null;
        }
        //      C# -> BlueprintFailoverStatus? LastTestFailoverStatus
        // GraphQL -> lastTestFailoverStatus: BlueprintFailoverStatus! (enum)
        if (ec.Includes("lastTestFailoverStatus",true))
        {
            if(this.LastTestFailoverStatus == null) {

                this.LastTestFailoverStatus = new BlueprintFailoverStatus();

            } else {


            }
        }
        else if (this.LastTestFailoverStatus != null && ec.Excludes("lastTestFailoverStatus",true))
        {
            this.LastTestFailoverStatus = null;
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
        //      C# -> BlueprintPlatform? Platform
        // GraphQL -> platform: BlueprintPlatform! (enum)
        if (ec.Includes("platform",true))
        {
            if(this.Platform == null) {

                this.Platform = new BlueprintPlatform();

            } else {


            }
        }
        else if (this.Platform != null && ec.Excludes("platform",true))
        {
            this.Platform = null;
        }
        //      C# -> BlueprintRecoveryType? RecoveryType
        // GraphQL -> recoveryType: BlueprintRecoveryType (enum)
        if (ec.Includes("recoveryType",true))
        {
            if(this.RecoveryType == null) {

                this.RecoveryType = new BlueprintRecoveryType();

            } else {


            }
        }
        else if (this.RecoveryType != null && ec.Excludes("recoveryType",true))
        {
            this.RecoveryType = null;
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
        //      C# -> BlueprintStatus? Status
        // GraphQL -> status: BlueprintStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new BlueprintStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> ObjectTypeEnum? WorkloadType
        // GraphQL -> workloadType: ObjectTypeEnum! (enum)
        if (ec.Includes("workloadType",true))
        {
            if(this.WorkloadType == null) {

                this.WorkloadType = new ObjectTypeEnum();

            } else {


            }
        }
        else if (this.WorkloadType != null && ec.Excludes("workloadType",true))
        {
            this.WorkloadType = null;
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
        //      C# -> BlueprintLocation? SourceLocation
        // GraphQL -> sourceLocation: BlueprintLocation (interface)
        if (ec.Includes("sourceLocation",false))
        {
            if(this.SourceLocation == null) {

                var impls = new List<BlueprintLocation>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("sourceLocation"));
                this.SourceLocation = (BlueprintLocation)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<BlueprintLocation>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("sourceLocation"));
                this.SourceLocation = (BlueprintLocation)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.SourceLocation != null && ec.Excludes("sourceLocation",false))
        {
            this.SourceLocation = null;
        }
        //      C# -> BlueprintLocation? TargetLocation
        // GraphQL -> targetLocation: BlueprintLocation (interface)
        if (ec.Includes("targetLocation",false))
        {
            if(this.TargetLocation == null) {

                var impls = new List<BlueprintLocation>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("targetLocation"));
                this.TargetLocation = (BlueprintLocation)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<BlueprintLocation>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("targetLocation"));
                this.TargetLocation = (BlueprintLocation)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.TargetLocation != null && ec.Excludes("targetLocation",false))
        {
            this.TargetLocation = null;
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
        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean (scalar)
        if (ec.Includes("isHydrationEnabled",true))
        {
            if(this.IsHydrationEnabled == null) {

                this.IsHydrationEnabled = true;

            } else {


            }
        }
        else if (this.IsHydrationEnabled != null && ec.Excludes("isHydrationEnabled",true))
        {
            this.IsHydrationEnabled = null;
        }
        //      C# -> System.Boolean? IsTargetConsistent
        // GraphQL -> isTargetConsistent: Boolean! (scalar)
        if (ec.Includes("isTargetConsistent",true))
        {
            if(this.IsTargetConsistent == null) {

                this.IsTargetConsistent = true;

            } else {


            }
        }
        else if (this.IsTargetConsistent != null && ec.Excludes("isTargetConsistent",true))
        {
            this.IsTargetConsistent = null;
        }
        //      C# -> System.Boolean? IsVisible
        // GraphQL -> isVisible: Boolean! (scalar)
        if (ec.Includes("isVisible",true))
        {
            if(this.IsVisible == null) {

                this.IsVisible = true;

            } else {


            }
        }
        else if (this.IsVisible != null && ec.Excludes("isVisible",true))
        {
            this.IsVisible = null;
        }
        //      C# -> System.String? LastFailoverSource
        // GraphQL -> lastFailoverSource: String (scalar)
        if (ec.Includes("lastFailoverSource",true))
        {
            if(this.LastFailoverSource == null) {

                this.LastFailoverSource = "FETCH";

            } else {


            }
        }
        else if (this.LastFailoverSource != null && ec.Excludes("lastFailoverSource",true))
        {
            this.LastFailoverSource = null;
        }
        //      C# -> DateTime? LastFailoverTime
        // GraphQL -> lastFailoverTime: DateTime (scalar)
        if (ec.Includes("lastFailoverTime",true))
        {
            if(this.LastFailoverTime == null) {

                this.LastFailoverTime = new DateTime();

            } else {


            }
        }
        else if (this.LastFailoverTime != null && ec.Excludes("lastFailoverTime",true))
        {
            this.LastFailoverTime = null;
        }
        //      C# -> DateTime? LastIsolatedRecoveryTime
        // GraphQL -> lastIsolatedRecoveryTime: DateTime (scalar)
        if (ec.Includes("lastIsolatedRecoveryTime",true))
        {
            if(this.LastIsolatedRecoveryTime == null) {

                this.LastIsolatedRecoveryTime = new DateTime();

            } else {


            }
        }
        else if (this.LastIsolatedRecoveryTime != null && ec.Excludes("lastIsolatedRecoveryTime",true))
        {
            this.LastIsolatedRecoveryTime = null;
        }
        //      C# -> DateTime? LastLocalRecoveryTime
        // GraphQL -> lastLocalRecoveryTime: DateTime (scalar)
        if (ec.Includes("lastLocalRecoveryTime",true))
        {
            if(this.LastLocalRecoveryTime == null) {

                this.LastLocalRecoveryTime = new DateTime();

            } else {


            }
        }
        else if (this.LastLocalRecoveryTime != null && ec.Excludes("lastLocalRecoveryTime",true))
        {
            this.LastLocalRecoveryTime = null;
        }
        //      C# -> DateTime? LastTestFailoverTime
        // GraphQL -> lastTestFailoverTime: DateTime (scalar)
        if (ec.Includes("lastTestFailoverTime",true))
        {
            if(this.LastTestFailoverTime == null) {

                this.LastTestFailoverTime = new DateTime();

            } else {


            }
        }
        else if (this.LastTestFailoverTime != null && ec.Excludes("lastTestFailoverTime",true))
        {
            this.LastTestFailoverTime = null;
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
        //      C# -> System.Int32? NumChildren
        // GraphQL -> numChildren: Int! (scalar)
        if (ec.Includes("numChildren",true))
        {
            if(this.NumChildren == null) {

                this.NumChildren = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumChildren != null && ec.Excludes("numChildren",true))
        {
            this.NumChildren = null;
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
        //      C# -> List<System.Int64>? PauseBetweenPriorityGroups
        // GraphQL -> pauseBetweenPriorityGroups: [Long!] (scalar)
        if (ec.Includes("pauseBetweenPriorityGroups",true))
        {
            if(this.PauseBetweenPriorityGroups == null) {

                this.PauseBetweenPriorityGroups = new List<System.Int64>();

            } else {


            }
        }
        else if (this.PauseBetweenPriorityGroups != null && ec.Excludes("pauseBetweenPriorityGroups",true))
        {
            this.PauseBetweenPriorityGroups = null;
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
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = Int32.MinValue;

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
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
        //      C# -> List<RecoveryPlanChild>? Children
        // GraphQL -> children: [RecoveryPlanChild!]! (type)
        if (ec.Includes("children",false))
        {
            if(this.Children == null) {

                this.Children = new List<RecoveryPlanChild>();
                this.Children.ApplyExploratoryFieldSpec(ec.NewChild("children"));

            } else {

                this.Children.ApplyExploratoryFieldSpec(ec.NewChild("children"));

            }
        }
        else if (this.Children != null && ec.Excludes("children",false))
        {
            this.Children = null;
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
        //      C# -> BlueprintFailover? LatestFailover
        // GraphQL -> latestFailover: BlueprintFailover (type)
        if (ec.Includes("latestFailover",false))
        {
            if(this.LatestFailover == null) {

                this.LatestFailover = new BlueprintFailover();
                this.LatestFailover.ApplyExploratoryFieldSpec(ec.NewChild("latestFailover"));

            } else {

                this.LatestFailover.ApplyExploratoryFieldSpec(ec.NewChild("latestFailover"));

            }
        }
        else if (this.LatestFailover != null && ec.Excludes("latestFailover",false))
        {
            this.LatestFailover = null;
        }
        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        if (ec.Includes("localRpoLagInfo",false))
        {
            if(this.LocalRpoLagInfo == null) {

                this.LocalRpoLagInfo = new RpoLagInfo();
                this.LocalRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("localRpoLagInfo"));

            } else {

                this.LocalRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("localRpoLagInfo"));

            }
        }
        else if (this.LocalRpoLagInfo != null && ec.Excludes("localRpoLagInfo",false))
        {
            this.LocalRpoLagInfo = null;
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
        //      C# -> BlueprintRecoveryCount? RecoveryCount
        // GraphQL -> recoveryCount: BlueprintRecoveryCount (type)
        if (ec.Includes("recoveryCount",false))
        {
            if(this.RecoveryCount == null) {

                this.RecoveryCount = new BlueprintRecoveryCount();
                this.RecoveryCount.ApplyExploratoryFieldSpec(ec.NewChild("recoveryCount"));

            } else {

                this.RecoveryCount.ApplyExploratoryFieldSpec(ec.NewChild("recoveryCount"));

            }
        }
        else if (this.RecoveryCount != null && ec.Excludes("recoveryCount",false))
        {
            this.RecoveryCount = null;
        }
        //      C# -> BlueprintRecoveryRanges? RecoveryRange
        // GraphQL -> recoveryRange: BlueprintRecoveryRanges (type)
        if (ec.Includes("recoveryRange",false))
        {
            if(this.RecoveryRange == null) {

                this.RecoveryRange = new BlueprintRecoveryRanges();
                this.RecoveryRange.ApplyExploratoryFieldSpec(ec.NewChild("recoveryRange"));

            } else {

                this.RecoveryRange.ApplyExploratoryFieldSpec(ec.NewChild("recoveryRange"));

            }
        }
        else if (this.RecoveryRange != null && ec.Excludes("recoveryRange",false))
        {
            this.RecoveryRange = null;
        }
        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        if (ec.Includes("remoteRpoLagInfo",false))
        {
            if(this.RemoteRpoLagInfo == null) {

                this.RemoteRpoLagInfo = new RpoLagInfo();
                this.RemoteRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("remoteRpoLagInfo"));

            } else {

                this.RemoteRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("remoteRpoLagInfo"));

            }
        }
        else if (this.RemoteRpoLagInfo != null && ec.Excludes("remoteRpoLagInfo",false))
        {
            this.RemoteRpoLagInfo = null;
        }
        //      C# -> Schedule? Schedule
        // GraphQL -> schedule: Schedule (type)
        if (ec.Includes("schedule",false))
        {
            if(this.Schedule == null) {

                this.Schedule = new Schedule();
                this.Schedule.ApplyExploratoryFieldSpec(ec.NewChild("schedule"));

            } else {

                this.Schedule.ApplyExploratoryFieldSpec(ec.NewChild("schedule"));

            }
        }
        else if (this.Schedule != null && ec.Excludes("schedule",false))
        {
            this.Schedule = null;
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

    } // class RecoveryPlan
    
    #endregion

    public static class ListRecoveryPlanExtensions
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
            this List<RecoveryPlan> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryPlan> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlan> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlan());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryPlan> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types