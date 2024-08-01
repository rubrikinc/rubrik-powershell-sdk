// VsphereBlueprintNew.cs
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
    #region VsphereBlueprintNew
 
    public class VsphereBlueprintNew: BaseType, HierarchyObject
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> BlueprintRecoveryType? BlueprintRecoveryType
        // GraphQL -> blueprintRecoveryType: BlueprintRecoveryType (enum)
        [JsonProperty("blueprintRecoveryType")]
        public BlueprintRecoveryType? BlueprintRecoveryType { get; set; }

        //      C# -> ObjectTypeEnum? BlueprintWorkloadType
        // GraphQL -> blueprintWorkloadType: ObjectTypeEnum! (enum)
        [JsonProperty("blueprintWorkloadType")]
        public ObjectTypeEnum? BlueprintWorkloadType { get; set; }

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

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> BlueprintStatus? Status
        // GraphQL -> status: BlueprintStatus! (enum)
        [JsonProperty("status")]
        public BlueprintStatus? Status { get; set; }

        //      C# -> List<BlueprintChild>? Children
        // GraphQL -> children: [BlueprintChild!]! (interface)
        [JsonProperty("children")]
        public List<BlueprintChild>? Children { get; set; }

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

        //      C# -> System.Boolean? EnableHydrationOpt
        // GraphQL -> enableHydrationOpt: Boolean (scalar)
        [JsonProperty("enableHydrationOpt")]
        public System.Boolean? EnableHydrationOpt { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsBlueprintTargetConsistent
        // GraphQL -> isBlueprintTargetConsistent: Boolean! (scalar)
        [JsonProperty("isBlueprintTargetConsistent")]
        public System.Boolean? IsBlueprintTargetConsistent { get; set; }

        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean (scalar)
        [JsonProperty("isBlueprintVisible")]
        public System.Boolean? IsBlueprintVisible { get; set; }

        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean (scalar)
        [JsonProperty("isHydrationEnabled")]
        public System.Boolean? IsHydrationEnabled { get; set; }

        //      C# -> System.String? LastFailoverSource
        // GraphQL -> lastFailoverSource: String (scalar)
        [JsonProperty("lastFailoverSource")]
        public System.String? LastFailoverSource { get; set; }

        //      C# -> DateTime? LastFailoverTime
        // GraphQL -> lastFailoverTime: DateTime (scalar)
        [JsonProperty("lastFailoverTime")]
        public DateTime? LastFailoverTime { get; set; }

        //      C# -> DateTime? LastFailoverTimeOpt
        // GraphQL -> lastFailoverTimeOpt: DateTime (scalar)
        [JsonProperty("lastFailoverTimeOpt")]
        public DateTime? LastFailoverTimeOpt { get; set; }

        //      C# -> DateTime? LastIsolatedRecoveryTime
        // GraphQL -> lastIsolatedRecoveryTime: DateTime (scalar)
        [JsonProperty("lastIsolatedRecoveryTime")]
        public DateTime? LastIsolatedRecoveryTime { get; set; }

        //      C# -> DateTime? LastIsolatedRecoveryTimeOpt
        // GraphQL -> lastIsolatedRecoveryTimeOpt: DateTime (scalar)
        [JsonProperty("lastIsolatedRecoveryTimeOpt")]
        public DateTime? LastIsolatedRecoveryTimeOpt { get; set; }

        //      C# -> DateTime? LastLocalRecoveryTime
        // GraphQL -> lastLocalRecoveryTime: DateTime (scalar)
        [JsonProperty("lastLocalRecoveryTime")]
        public DateTime? LastLocalRecoveryTime { get; set; }

        //      C# -> DateTime? LastLocalRecoveryTimeOpt
        // GraphQL -> lastLocalRecoveryTimeOpt: DateTime (scalar)
        [JsonProperty("lastLocalRecoveryTimeOpt")]
        public DateTime? LastLocalRecoveryTimeOpt { get; set; }

        //      C# -> DateTime? LastTestFailoverTime
        // GraphQL -> lastTestFailoverTime: DateTime (scalar)
        [JsonProperty("lastTestFailoverTime")]
        public DateTime? LastTestFailoverTime { get; set; }

        //      C# -> DateTime? LastTestFailoverTimeOpt
        // GraphQL -> lastTestFailoverTimeOpt: DateTime (scalar)
        [JsonProperty("lastTestFailoverTimeOpt")]
        public DateTime? LastTestFailoverTimeOpt { get; set; }

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

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> List<System.Int64>? TimeoutBetweenPriorityGroups
        // GraphQL -> timeoutBetweenPriorityGroups: [Long!] (scalar)
        [JsonProperty("timeoutBetweenPriorityGroups")]
        public List<System.Int64>? TimeoutBetweenPriorityGroups { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> BlueprintRecoveryCount? BlueprintRecoveryCount
        // GraphQL -> blueprintRecoveryCount: BlueprintRecoveryCount (type)
        [JsonProperty("blueprintRecoveryCount")]
        public BlueprintRecoveryCount? BlueprintRecoveryCount { get; set; }

        //      C# -> Schedule? BlueprintSchedule
        // GraphQL -> blueprintSchedule: Schedule (type)
        [JsonProperty("blueprintSchedule")]
        public Schedule? BlueprintSchedule { get; set; }

        //      C# -> BlueprintChildConnection? ChildConnection
        // GraphQL -> childConnection: BlueprintChildConnection! (type)
        [JsonProperty("childConnection")]
        public BlueprintChildConnection? ChildConnection { get; set; }

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

        //      C# -> BlueprintRecoveryRanges? RecoveryInfo
        // GraphQL -> recoveryInfo: BlueprintRecoveryRanges (type)
        [JsonProperty("recoveryInfo")]
        public BlueprintRecoveryRanges? RecoveryInfo { get; set; }

        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        [JsonProperty("remoteRpoLagInfo")]
        public RpoLagInfo? RemoteRpoLagInfo { get; set; }

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
        public RscGqlVars RecoveryInfo { get; set; }


        public InlineVars() {
            Tuple<string, string>[] recoveryInfoArgs = {
                    Tuple.Create("clusterUuid", "UUID"),
                };
            this.RecoveryInfo =
                new RscGqlVars(null, recoveryInfoArgs, null, true);
        }
    }

    public VsphereBlueprintNew()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "VsphereBlueprintNew";
    }

    public VsphereBlueprintNew Set(
        List<Operation>? AuthorizedOperations = null,
        BlueprintRecoveryType? BlueprintRecoveryType = null,
        ObjectTypeEnum? BlueprintWorkloadType = null,
        BlueprintFailoverStatus? LastFailoverStatus = null,
        BlueprintFailoverStatus? LastIsolatedRecoveryStatus = null,
        BlueprintFailoverStatus? LastLocalRecoveryStatus = null,
        BlueprintFailoverStatus? LastTestFailoverStatus = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        BlueprintPlatform? Platform = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        BlueprintStatus? Status = null,
        List<BlueprintChild>? Children = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        BlueprintLocation? SourceLocation = null,
        BlueprintLocation? TargetLocation = null,
        System.Boolean? EnableHydrationOpt = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsBlueprintTargetConsistent = null,
        System.Boolean? IsBlueprintVisible = null,
        System.Boolean? IsHydrationEnabled = null,
        System.String? LastFailoverSource = null,
        DateTime? LastFailoverTime = null,
        DateTime? LastFailoverTimeOpt = null,
        DateTime? LastIsolatedRecoveryTime = null,
        DateTime? LastIsolatedRecoveryTimeOpt = null,
        DateTime? LastLocalRecoveryTime = null,
        DateTime? LastLocalRecoveryTimeOpt = null,
        DateTime? LastTestFailoverTime = null,
        DateTime? LastTestFailoverTimeOpt = null,
        System.String? Name = null,
        System.Int32? NumChildren = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Boolean? SlaPauseStatus = null,
        List<System.Int64>? TimeoutBetweenPriorityGroups = null,
        System.Int32? Version = null,
        List<Org>? AllOrgs = null,
        BlueprintRecoveryCount? BlueprintRecoveryCount = null,
        Schedule? BlueprintSchedule = null,
        BlueprintChildConnection? ChildConnection = null,
        PathNode? EffectiveSlaSourceObject = null,
        BlueprintFailover? LatestFailover = null,
        RpoLagInfo? LocalRpoLagInfo = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        BlueprintRecoveryRanges? RecoveryInfo = null,
        RpoLagInfo? RemoteRpoLagInfo = null,
        SecurityMetadata? SecurityMetadata = null,
        SnapshotDistribution? SnapshotDistribution = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( BlueprintRecoveryType != null ) {
            this.BlueprintRecoveryType = BlueprintRecoveryType;
        }
        if ( BlueprintWorkloadType != null ) {
            this.BlueprintWorkloadType = BlueprintWorkloadType;
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
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Children != null ) {
            this.Children = Children;
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
        if ( EnableHydrationOpt != null ) {
            this.EnableHydrationOpt = EnableHydrationOpt;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsBlueprintTargetConsistent != null ) {
            this.IsBlueprintTargetConsistent = IsBlueprintTargetConsistent;
        }
        if ( IsBlueprintVisible != null ) {
            this.IsBlueprintVisible = IsBlueprintVisible;
        }
        if ( IsHydrationEnabled != null ) {
            this.IsHydrationEnabled = IsHydrationEnabled;
        }
        if ( LastFailoverSource != null ) {
            this.LastFailoverSource = LastFailoverSource;
        }
        if ( LastFailoverTime != null ) {
            this.LastFailoverTime = LastFailoverTime;
        }
        if ( LastFailoverTimeOpt != null ) {
            this.LastFailoverTimeOpt = LastFailoverTimeOpt;
        }
        if ( LastIsolatedRecoveryTime != null ) {
            this.LastIsolatedRecoveryTime = LastIsolatedRecoveryTime;
        }
        if ( LastIsolatedRecoveryTimeOpt != null ) {
            this.LastIsolatedRecoveryTimeOpt = LastIsolatedRecoveryTimeOpt;
        }
        if ( LastLocalRecoveryTime != null ) {
            this.LastLocalRecoveryTime = LastLocalRecoveryTime;
        }
        if ( LastLocalRecoveryTimeOpt != null ) {
            this.LastLocalRecoveryTimeOpt = LastLocalRecoveryTimeOpt;
        }
        if ( LastTestFailoverTime != null ) {
            this.LastTestFailoverTime = LastTestFailoverTime;
        }
        if ( LastTestFailoverTimeOpt != null ) {
            this.LastTestFailoverTimeOpt = LastTestFailoverTimeOpt;
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
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( TimeoutBetweenPriorityGroups != null ) {
            this.TimeoutBetweenPriorityGroups = TimeoutBetweenPriorityGroups;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( BlueprintRecoveryCount != null ) {
            this.BlueprintRecoveryCount = BlueprintRecoveryCount;
        }
        if ( BlueprintSchedule != null ) {
            this.BlueprintSchedule = BlueprintSchedule;
        }
        if ( ChildConnection != null ) {
            this.ChildConnection = ChildConnection;
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
        if ( RecoveryInfo != null ) {
            this.RecoveryInfo = RecoveryInfo;
        }
        if ( RemoteRpoLagInfo != null ) {
            this.RemoteRpoLagInfo = RemoteRpoLagInfo;
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
        //      C# -> BlueprintRecoveryType? BlueprintRecoveryType
        // GraphQL -> blueprintRecoveryType: BlueprintRecoveryType (enum)
        if (this.BlueprintRecoveryType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blueprintRecoveryType\n" ;
            } else {
                s += ind + "blueprintRecoveryType\n" ;
            }
        }
        //      C# -> ObjectTypeEnum? BlueprintWorkloadType
        // GraphQL -> blueprintWorkloadType: ObjectTypeEnum! (enum)
        if (this.BlueprintWorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blueprintWorkloadType\n" ;
            } else {
                s += ind + "blueprintWorkloadType\n" ;
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
        //      C# -> List<BlueprintChild>? Children
        // GraphQL -> children: [BlueprintChild!]! (interface)
        if (this.Children != null) {
                var fspec = this.Children.AsFieldSpec(conf.Child("children"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "children" + " " + "{\n" + fspec + ind + "}\n";
                }
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
        //      C# -> System.Boolean? EnableHydrationOpt
        // GraphQL -> enableHydrationOpt: Boolean (scalar)
        if (this.EnableHydrationOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableHydrationOpt\n" ;
            } else {
                s += ind + "enableHydrationOpt\n" ;
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
        //      C# -> System.Boolean? IsBlueprintTargetConsistent
        // GraphQL -> isBlueprintTargetConsistent: Boolean! (scalar)
        if (this.IsBlueprintTargetConsistent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBlueprintTargetConsistent\n" ;
            } else {
                s += ind + "isBlueprintTargetConsistent\n" ;
            }
        }
        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean (scalar)
        if (this.IsBlueprintVisible != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBlueprintVisible\n" ;
            } else {
                s += ind + "isBlueprintVisible\n" ;
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
        //      C# -> DateTime? LastFailoverTimeOpt
        // GraphQL -> lastFailoverTimeOpt: DateTime (scalar)
        if (this.LastFailoverTimeOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastFailoverTimeOpt\n" ;
            } else {
                s += ind + "lastFailoverTimeOpt\n" ;
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
        //      C# -> DateTime? LastIsolatedRecoveryTimeOpt
        // GraphQL -> lastIsolatedRecoveryTimeOpt: DateTime (scalar)
        if (this.LastIsolatedRecoveryTimeOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastIsolatedRecoveryTimeOpt\n" ;
            } else {
                s += ind + "lastIsolatedRecoveryTimeOpt\n" ;
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
        //      C# -> DateTime? LastLocalRecoveryTimeOpt
        // GraphQL -> lastLocalRecoveryTimeOpt: DateTime (scalar)
        if (this.LastLocalRecoveryTimeOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastLocalRecoveryTimeOpt\n" ;
            } else {
                s += ind + "lastLocalRecoveryTimeOpt\n" ;
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
        //      C# -> DateTime? LastTestFailoverTimeOpt
        // GraphQL -> lastTestFailoverTimeOpt: DateTime (scalar)
        if (this.LastTestFailoverTimeOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastTestFailoverTimeOpt\n" ;
            } else {
                s += ind + "lastTestFailoverTimeOpt\n" ;
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
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaPauseStatus\n" ;
            } else {
                s += ind + "slaPauseStatus\n" ;
            }
        }
        //      C# -> List<System.Int64>? TimeoutBetweenPriorityGroups
        // GraphQL -> timeoutBetweenPriorityGroups: [Long!] (scalar)
        if (this.TimeoutBetweenPriorityGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timeoutBetweenPriorityGroups\n" ;
            } else {
                s += ind + "timeoutBetweenPriorityGroups\n" ;
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
        //      C# -> BlueprintRecoveryCount? BlueprintRecoveryCount
        // GraphQL -> blueprintRecoveryCount: BlueprintRecoveryCount (type)
        if (this.BlueprintRecoveryCount != null) {
            var fspec = this.BlueprintRecoveryCount.AsFieldSpec(conf.Child("blueprintRecoveryCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blueprintRecoveryCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Schedule? BlueprintSchedule
        // GraphQL -> blueprintSchedule: Schedule (type)
        if (this.BlueprintSchedule != null) {
            var fspec = this.BlueprintSchedule.AsFieldSpec(conf.Child("blueprintSchedule"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blueprintSchedule" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> BlueprintChildConnection? ChildConnection
        // GraphQL -> childConnection: BlueprintChildConnection! (type)
        if (this.ChildConnection != null) {
            var fspec = this.ChildConnection.AsFieldSpec(conf.Child("childConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "childConnection" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> BlueprintRecoveryRanges? RecoveryInfo
        // GraphQL -> recoveryInfo: BlueprintRecoveryRanges (type)
        if (this.RecoveryInfo != null) {
            var fspec = this.RecoveryInfo.AsFieldSpec(conf.Child("recoveryInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryInfo" + "\n(" + this.Vars.RecoveryInfo.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> BlueprintRecoveryType? BlueprintRecoveryType
        // GraphQL -> blueprintRecoveryType: BlueprintRecoveryType (enum)
        if (ec.Includes("blueprintRecoveryType",true))
        {
            if(this.BlueprintRecoveryType == null) {

                this.BlueprintRecoveryType = new BlueprintRecoveryType();

            } else {


            }
        }
        else if (this.BlueprintRecoveryType != null && ec.Excludes("blueprintRecoveryType",true))
        {
            this.BlueprintRecoveryType = null;
        }
        //      C# -> ObjectTypeEnum? BlueprintWorkloadType
        // GraphQL -> blueprintWorkloadType: ObjectTypeEnum! (enum)
        if (ec.Includes("blueprintWorkloadType",true))
        {
            if(this.BlueprintWorkloadType == null) {

                this.BlueprintWorkloadType = new ObjectTypeEnum();

            } else {


            }
        }
        else if (this.BlueprintWorkloadType != null && ec.Excludes("blueprintWorkloadType",true))
        {
            this.BlueprintWorkloadType = null;
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
        //      C# -> List<BlueprintChild>? Children
        // GraphQL -> children: [BlueprintChild!]! (interface)
        if (ec.Includes("children",false))
        {
            if(this.Children == null) {

                this.Children = new List<BlueprintChild>();
                this.Children.ApplyExploratoryFieldSpec(ec.NewChild("children"));

            } else {

                this.Children.ApplyExploratoryFieldSpec(ec.NewChild("children"));

            }
        }
        else if (this.Children != null && ec.Excludes("children",false))
        {
            this.Children = null;
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
        //      C# -> System.Boolean? EnableHydrationOpt
        // GraphQL -> enableHydrationOpt: Boolean (scalar)
        if (ec.Includes("enableHydrationOpt",true))
        {
            if(this.EnableHydrationOpt == null) {

                this.EnableHydrationOpt = true;

            } else {


            }
        }
        else if (this.EnableHydrationOpt != null && ec.Excludes("enableHydrationOpt",true))
        {
            this.EnableHydrationOpt = null;
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
        //      C# -> System.Boolean? IsBlueprintTargetConsistent
        // GraphQL -> isBlueprintTargetConsistent: Boolean! (scalar)
        if (ec.Includes("isBlueprintTargetConsistent",true))
        {
            if(this.IsBlueprintTargetConsistent == null) {

                this.IsBlueprintTargetConsistent = true;

            } else {


            }
        }
        else if (this.IsBlueprintTargetConsistent != null && ec.Excludes("isBlueprintTargetConsistent",true))
        {
            this.IsBlueprintTargetConsistent = null;
        }
        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean (scalar)
        if (ec.Includes("isBlueprintVisible",true))
        {
            if(this.IsBlueprintVisible == null) {

                this.IsBlueprintVisible = true;

            } else {


            }
        }
        else if (this.IsBlueprintVisible != null && ec.Excludes("isBlueprintVisible",true))
        {
            this.IsBlueprintVisible = null;
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
        //      C# -> DateTime? LastFailoverTimeOpt
        // GraphQL -> lastFailoverTimeOpt: DateTime (scalar)
        if (ec.Includes("lastFailoverTimeOpt",true))
        {
            if(this.LastFailoverTimeOpt == null) {

                this.LastFailoverTimeOpt = new DateTime();

            } else {


            }
        }
        else if (this.LastFailoverTimeOpt != null && ec.Excludes("lastFailoverTimeOpt",true))
        {
            this.LastFailoverTimeOpt = null;
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
        //      C# -> DateTime? LastIsolatedRecoveryTimeOpt
        // GraphQL -> lastIsolatedRecoveryTimeOpt: DateTime (scalar)
        if (ec.Includes("lastIsolatedRecoveryTimeOpt",true))
        {
            if(this.LastIsolatedRecoveryTimeOpt == null) {

                this.LastIsolatedRecoveryTimeOpt = new DateTime();

            } else {


            }
        }
        else if (this.LastIsolatedRecoveryTimeOpt != null && ec.Excludes("lastIsolatedRecoveryTimeOpt",true))
        {
            this.LastIsolatedRecoveryTimeOpt = null;
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
        //      C# -> DateTime? LastLocalRecoveryTimeOpt
        // GraphQL -> lastLocalRecoveryTimeOpt: DateTime (scalar)
        if (ec.Includes("lastLocalRecoveryTimeOpt",true))
        {
            if(this.LastLocalRecoveryTimeOpt == null) {

                this.LastLocalRecoveryTimeOpt = new DateTime();

            } else {


            }
        }
        else if (this.LastLocalRecoveryTimeOpt != null && ec.Excludes("lastLocalRecoveryTimeOpt",true))
        {
            this.LastLocalRecoveryTimeOpt = null;
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
        //      C# -> DateTime? LastTestFailoverTimeOpt
        // GraphQL -> lastTestFailoverTimeOpt: DateTime (scalar)
        if (ec.Includes("lastTestFailoverTimeOpt",true))
        {
            if(this.LastTestFailoverTimeOpt == null) {

                this.LastTestFailoverTimeOpt = new DateTime();

            } else {


            }
        }
        else if (this.LastTestFailoverTimeOpt != null && ec.Excludes("lastTestFailoverTimeOpt",true))
        {
            this.LastTestFailoverTimeOpt = null;
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
        //      C# -> List<System.Int64>? TimeoutBetweenPriorityGroups
        // GraphQL -> timeoutBetweenPriorityGroups: [Long!] (scalar)
        if (ec.Includes("timeoutBetweenPriorityGroups",true))
        {
            if(this.TimeoutBetweenPriorityGroups == null) {

                this.TimeoutBetweenPriorityGroups = new List<System.Int64>();

            } else {


            }
        }
        else if (this.TimeoutBetweenPriorityGroups != null && ec.Excludes("timeoutBetweenPriorityGroups",true))
        {
            this.TimeoutBetweenPriorityGroups = null;
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
        //      C# -> BlueprintRecoveryCount? BlueprintRecoveryCount
        // GraphQL -> blueprintRecoveryCount: BlueprintRecoveryCount (type)
        if (ec.Includes("blueprintRecoveryCount",false))
        {
            if(this.BlueprintRecoveryCount == null) {

                this.BlueprintRecoveryCount = new BlueprintRecoveryCount();
                this.BlueprintRecoveryCount.ApplyExploratoryFieldSpec(ec.NewChild("blueprintRecoveryCount"));

            } else {

                this.BlueprintRecoveryCount.ApplyExploratoryFieldSpec(ec.NewChild("blueprintRecoveryCount"));

            }
        }
        else if (this.BlueprintRecoveryCount != null && ec.Excludes("blueprintRecoveryCount",false))
        {
            this.BlueprintRecoveryCount = null;
        }
        //      C# -> Schedule? BlueprintSchedule
        // GraphQL -> blueprintSchedule: Schedule (type)
        if (ec.Includes("blueprintSchedule",false))
        {
            if(this.BlueprintSchedule == null) {

                this.BlueprintSchedule = new Schedule();
                this.BlueprintSchedule.ApplyExploratoryFieldSpec(ec.NewChild("blueprintSchedule"));

            } else {

                this.BlueprintSchedule.ApplyExploratoryFieldSpec(ec.NewChild("blueprintSchedule"));

            }
        }
        else if (this.BlueprintSchedule != null && ec.Excludes("blueprintSchedule",false))
        {
            this.BlueprintSchedule = null;
        }
        //      C# -> BlueprintChildConnection? ChildConnection
        // GraphQL -> childConnection: BlueprintChildConnection! (type)
        if (ec.Includes("childConnection",false))
        {
            if(this.ChildConnection == null) {

                this.ChildConnection = new BlueprintChildConnection();
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
        //      C# -> BlueprintRecoveryRanges? RecoveryInfo
        // GraphQL -> recoveryInfo: BlueprintRecoveryRanges (type)
        if (ec.Includes("recoveryInfo",false))
        {
            if(this.RecoveryInfo == null) {

                this.RecoveryInfo = new BlueprintRecoveryRanges();
                this.RecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfo"));

            } else {

                this.RecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfo"));

            }
        }
        else if (this.RecoveryInfo != null && ec.Excludes("recoveryInfo",false))
        {
            this.RecoveryInfo = null;
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

    } // class VsphereBlueprintNew
    
    #endregion

    public static class ListVsphereBlueprintNewExtensions
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
            this List<VsphereBlueprintNew> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereBlueprintNew> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereBlueprintNew> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereBlueprintNew());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereBlueprintNew> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types