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

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereBlueprintNew";
    }

    public VsphereBlueprintNew Set(
        List<Operation>? AuthorizedOperations = null,
        BlueprintRecoveryType? BlueprintRecoveryType = null,
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
        SnapshotDistribution? SnapshotDistribution = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( BlueprintRecoveryType != null ) {
            this.BlueprintRecoveryType = BlueprintRecoveryType;
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
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations\n" ;
        }
        //      C# -> BlueprintRecoveryType? BlueprintRecoveryType
        // GraphQL -> blueprintRecoveryType: BlueprintRecoveryType (enum)
        if (this.BlueprintRecoveryType != null) {
            s += ind + "blueprintRecoveryType\n" ;
        }
        //      C# -> BlueprintFailoverStatus? LastFailoverStatus
        // GraphQL -> lastFailoverStatus: BlueprintFailoverStatus! (enum)
        if (this.LastFailoverStatus != null) {
            s += ind + "lastFailoverStatus\n" ;
        }
        //      C# -> BlueprintFailoverStatus? LastIsolatedRecoveryStatus
        // GraphQL -> lastIsolatedRecoveryStatus: BlueprintFailoverStatus! (enum)
        if (this.LastIsolatedRecoveryStatus != null) {
            s += ind + "lastIsolatedRecoveryStatus\n" ;
        }
        //      C# -> BlueprintFailoverStatus? LastLocalRecoveryStatus
        // GraphQL -> lastLocalRecoveryStatus: BlueprintFailoverStatus! (enum)
        if (this.LastLocalRecoveryStatus != null) {
            s += ind + "lastLocalRecoveryStatus\n" ;
        }
        //      C# -> BlueprintFailoverStatus? LastTestFailoverStatus
        // GraphQL -> lastTestFailoverStatus: BlueprintFailoverStatus! (enum)
        if (this.LastTestFailoverStatus != null) {
            s += ind + "lastTestFailoverStatus\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> BlueprintPlatform? Platform
        // GraphQL -> platform: BlueprintPlatform! (enum)
        if (this.Platform != null) {
            s += ind + "platform\n" ;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> BlueprintStatus? Status
        // GraphQL -> status: BlueprintStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> List<BlueprintChild>? Children
        // GraphQL -> children: [BlueprintChild!]! (interface)
        if (this.Children != null) {
                var fspec = this.Children.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "children {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configuredSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveRetentionSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> BlueprintLocation? SourceLocation
        // GraphQL -> sourceLocation: BlueprintLocation (interface)
        if (this.SourceLocation != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.SourceLocation).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceLocation {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> BlueprintLocation? TargetLocation
        // GraphQL -> targetLocation: BlueprintLocation (interface)
        if (this.TargetLocation != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.TargetLocation).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetLocation {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Boolean? EnableHydrationOpt
        // GraphQL -> enableHydrationOpt: Boolean (scalar)
        if (this.EnableHydrationOpt != null) {
            s += ind + "enableHydrationOpt\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean (scalar)
        if (this.IsBlueprintVisible != null) {
            s += ind + "isBlueprintVisible\n" ;
        }
        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean (scalar)
        if (this.IsHydrationEnabled != null) {
            s += ind + "isHydrationEnabled\n" ;
        }
        //      C# -> System.String? LastFailoverSource
        // GraphQL -> lastFailoverSource: String (scalar)
        if (this.LastFailoverSource != null) {
            s += ind + "lastFailoverSource\n" ;
        }
        //      C# -> DateTime? LastFailoverTime
        // GraphQL -> lastFailoverTime: DateTime (scalar)
        if (this.LastFailoverTime != null) {
            s += ind + "lastFailoverTime\n" ;
        }
        //      C# -> DateTime? LastFailoverTimeOpt
        // GraphQL -> lastFailoverTimeOpt: DateTime (scalar)
        if (this.LastFailoverTimeOpt != null) {
            s += ind + "lastFailoverTimeOpt\n" ;
        }
        //      C# -> DateTime? LastIsolatedRecoveryTime
        // GraphQL -> lastIsolatedRecoveryTime: DateTime (scalar)
        if (this.LastIsolatedRecoveryTime != null) {
            s += ind + "lastIsolatedRecoveryTime\n" ;
        }
        //      C# -> DateTime? LastIsolatedRecoveryTimeOpt
        // GraphQL -> lastIsolatedRecoveryTimeOpt: DateTime (scalar)
        if (this.LastIsolatedRecoveryTimeOpt != null) {
            s += ind + "lastIsolatedRecoveryTimeOpt\n" ;
        }
        //      C# -> DateTime? LastLocalRecoveryTime
        // GraphQL -> lastLocalRecoveryTime: DateTime (scalar)
        if (this.LastLocalRecoveryTime != null) {
            s += ind + "lastLocalRecoveryTime\n" ;
        }
        //      C# -> DateTime? LastLocalRecoveryTimeOpt
        // GraphQL -> lastLocalRecoveryTimeOpt: DateTime (scalar)
        if (this.LastLocalRecoveryTimeOpt != null) {
            s += ind + "lastLocalRecoveryTimeOpt\n" ;
        }
        //      C# -> DateTime? LastTestFailoverTime
        // GraphQL -> lastTestFailoverTime: DateTime (scalar)
        if (this.LastTestFailoverTime != null) {
            s += ind + "lastTestFailoverTime\n" ;
        }
        //      C# -> DateTime? LastTestFailoverTimeOpt
        // GraphQL -> lastTestFailoverTimeOpt: DateTime (scalar)
        if (this.LastTestFailoverTimeOpt != null) {
            s += ind + "lastTestFailoverTimeOpt\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumChildren
        // GraphQL -> numChildren: Int! (scalar)
        if (this.NumChildren != null) {
            s += ind + "numChildren\n" ;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            s += ind + "numWorkloadDescendants\n" ;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            s += ind + "slaPauseStatus\n" ;
        }
        //      C# -> List<System.Int64>? TimeoutBetweenPriorityGroups
        // GraphQL -> timeoutBetweenPriorityGroups: [Long!] (scalar)
        if (this.TimeoutBetweenPriorityGroups != null) {
            s += ind + "timeoutBetweenPriorityGroups\n" ;
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> BlueprintRecoveryCount? BlueprintRecoveryCount
        // GraphQL -> blueprintRecoveryCount: BlueprintRecoveryCount (type)
        if (this.BlueprintRecoveryCount != null) {
            var fspec = this.BlueprintRecoveryCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "blueprintRecoveryCount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Schedule? BlueprintSchedule
        // GraphQL -> blueprintSchedule: Schedule (type)
        if (this.BlueprintSchedule != null) {
            var fspec = this.BlueprintSchedule.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "blueprintSchedule {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> BlueprintChildConnection? ChildConnection
        // GraphQL -> childConnection: BlueprintChildConnection! (type)
        if (this.ChildConnection != null) {
            var fspec = this.ChildConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "childConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaSourceObject {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> BlueprintFailover? LatestFailover
        // GraphQL -> latestFailover: BlueprintFailover (type)
        if (this.LatestFailover != null) {
            var fspec = this.LatestFailover.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "latestFailover {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        if (this.LocalRpoLagInfo != null) {
            var fspec = this.LocalRpoLagInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "localRpoLagInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logicalPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "physicalPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> BlueprintRecoveryRanges? RecoveryInfo
        // GraphQL -> recoveryInfo: BlueprintRecoveryRanges (type)
        if (this.RecoveryInfo != null) {
            var fspec = this.RecoveryInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoveryInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        if (this.RemoteRpoLagInfo != null) {
            var fspec = this.RemoteRpoLagInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "remoteRpoLagInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotDistribution {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations == null && ec.Includes("authorizedOperations",true))
        {
            this.AuthorizedOperations = new List<Operation>();
        }
        //      C# -> BlueprintRecoveryType? BlueprintRecoveryType
        // GraphQL -> blueprintRecoveryType: BlueprintRecoveryType (enum)
        if (this.BlueprintRecoveryType == null && ec.Includes("blueprintRecoveryType",true))
        {
            this.BlueprintRecoveryType = new BlueprintRecoveryType();
        }
        //      C# -> BlueprintFailoverStatus? LastFailoverStatus
        // GraphQL -> lastFailoverStatus: BlueprintFailoverStatus! (enum)
        if (this.LastFailoverStatus == null && ec.Includes("lastFailoverStatus",true))
        {
            this.LastFailoverStatus = new BlueprintFailoverStatus();
        }
        //      C# -> BlueprintFailoverStatus? LastIsolatedRecoveryStatus
        // GraphQL -> lastIsolatedRecoveryStatus: BlueprintFailoverStatus! (enum)
        if (this.LastIsolatedRecoveryStatus == null && ec.Includes("lastIsolatedRecoveryStatus",true))
        {
            this.LastIsolatedRecoveryStatus = new BlueprintFailoverStatus();
        }
        //      C# -> BlueprintFailoverStatus? LastLocalRecoveryStatus
        // GraphQL -> lastLocalRecoveryStatus: BlueprintFailoverStatus! (enum)
        if (this.LastLocalRecoveryStatus == null && ec.Includes("lastLocalRecoveryStatus",true))
        {
            this.LastLocalRecoveryStatus = new BlueprintFailoverStatus();
        }
        //      C# -> BlueprintFailoverStatus? LastTestFailoverStatus
        // GraphQL -> lastTestFailoverStatus: BlueprintFailoverStatus! (enum)
        if (this.LastTestFailoverStatus == null && ec.Includes("lastTestFailoverStatus",true))
        {
            this.LastTestFailoverStatus = new BlueprintFailoverStatus();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> BlueprintPlatform? Platform
        // GraphQL -> platform: BlueprintPlatform! (enum)
        if (this.Platform == null && ec.Includes("platform",true))
        {
            this.Platform = new BlueprintPlatform();
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment == null && ec.Includes("slaAssignment",true))
        {
            this.SlaAssignment = new SlaAssignmentTypeEnum();
        }
        //      C# -> BlueprintStatus? Status
        // GraphQL -> status: BlueprintStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new BlueprintStatus();
        }
        //      C# -> List<BlueprintChild>? Children
        // GraphQL -> children: [BlueprintChild!]! (interface)
        if (this.Children == null && ec.Includes("children",false))
        {
            this.Children = new List<BlueprintChild>();
            this.Children.ApplyExploratoryFieldSpec(ec.NewChild("children"));
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain == null && ec.Includes("configuredSlaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
            this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain == null && ec.Includes("effectiveRetentionSlaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
            this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain == null && ec.Includes("effectiveSlaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
            this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> BlueprintLocation? SourceLocation
        // GraphQL -> sourceLocation: BlueprintLocation (interface)
        if (this.SourceLocation == null && ec.Includes("sourceLocation",false))
        {
            var impls = new List<BlueprintLocation>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("sourceLocation"));
            this.SourceLocation = (BlueprintLocation)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> BlueprintLocation? TargetLocation
        // GraphQL -> targetLocation: BlueprintLocation (interface)
        if (this.TargetLocation == null && ec.Includes("targetLocation",false))
        {
            var impls = new List<BlueprintLocation>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("targetLocation"));
            this.TargetLocation = (BlueprintLocation)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.Boolean? EnableHydrationOpt
        // GraphQL -> enableHydrationOpt: Boolean (scalar)
        if (this.EnableHydrationOpt == null && ec.Includes("enableHydrationOpt",true))
        {
            this.EnableHydrationOpt = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && ec.Includes("isArchived",true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean (scalar)
        if (this.IsBlueprintVisible == null && ec.Includes("isBlueprintVisible",true))
        {
            this.IsBlueprintVisible = true;
        }
        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean (scalar)
        if (this.IsHydrationEnabled == null && ec.Includes("isHydrationEnabled",true))
        {
            this.IsHydrationEnabled = true;
        }
        //      C# -> System.String? LastFailoverSource
        // GraphQL -> lastFailoverSource: String (scalar)
        if (this.LastFailoverSource == null && ec.Includes("lastFailoverSource",true))
        {
            this.LastFailoverSource = "FETCH";
        }
        //      C# -> DateTime? LastFailoverTime
        // GraphQL -> lastFailoverTime: DateTime (scalar)
        if (this.LastFailoverTime == null && ec.Includes("lastFailoverTime",true))
        {
            this.LastFailoverTime = new DateTime();
        }
        //      C# -> DateTime? LastFailoverTimeOpt
        // GraphQL -> lastFailoverTimeOpt: DateTime (scalar)
        if (this.LastFailoverTimeOpt == null && ec.Includes("lastFailoverTimeOpt",true))
        {
            this.LastFailoverTimeOpt = new DateTime();
        }
        //      C# -> DateTime? LastIsolatedRecoveryTime
        // GraphQL -> lastIsolatedRecoveryTime: DateTime (scalar)
        if (this.LastIsolatedRecoveryTime == null && ec.Includes("lastIsolatedRecoveryTime",true))
        {
            this.LastIsolatedRecoveryTime = new DateTime();
        }
        //      C# -> DateTime? LastIsolatedRecoveryTimeOpt
        // GraphQL -> lastIsolatedRecoveryTimeOpt: DateTime (scalar)
        if (this.LastIsolatedRecoveryTimeOpt == null && ec.Includes("lastIsolatedRecoveryTimeOpt",true))
        {
            this.LastIsolatedRecoveryTimeOpt = new DateTime();
        }
        //      C# -> DateTime? LastLocalRecoveryTime
        // GraphQL -> lastLocalRecoveryTime: DateTime (scalar)
        if (this.LastLocalRecoveryTime == null && ec.Includes("lastLocalRecoveryTime",true))
        {
            this.LastLocalRecoveryTime = new DateTime();
        }
        //      C# -> DateTime? LastLocalRecoveryTimeOpt
        // GraphQL -> lastLocalRecoveryTimeOpt: DateTime (scalar)
        if (this.LastLocalRecoveryTimeOpt == null && ec.Includes("lastLocalRecoveryTimeOpt",true))
        {
            this.LastLocalRecoveryTimeOpt = new DateTime();
        }
        //      C# -> DateTime? LastTestFailoverTime
        // GraphQL -> lastTestFailoverTime: DateTime (scalar)
        if (this.LastTestFailoverTime == null && ec.Includes("lastTestFailoverTime",true))
        {
            this.LastTestFailoverTime = new DateTime();
        }
        //      C# -> DateTime? LastTestFailoverTimeOpt
        // GraphQL -> lastTestFailoverTimeOpt: DateTime (scalar)
        if (this.LastTestFailoverTimeOpt == null && ec.Includes("lastTestFailoverTimeOpt",true))
        {
            this.LastTestFailoverTimeOpt = new DateTime();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumChildren
        // GraphQL -> numChildren: Int! (scalar)
        if (this.NumChildren == null && ec.Includes("numChildren",true))
        {
            this.NumChildren = Int32.MinValue;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants == null && ec.Includes("numWorkloadDescendants",true))
        {
            this.NumWorkloadDescendants = Int32.MinValue;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && ec.Includes("slaPauseStatus",true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> List<System.Int64>? TimeoutBetweenPriorityGroups
        // GraphQL -> timeoutBetweenPriorityGroups: [Long!] (scalar)
        if (this.TimeoutBetweenPriorityGroups == null && ec.Includes("timeoutBetweenPriorityGroups",true))
        {
            this.TimeoutBetweenPriorityGroups = new List<System.Int64>();
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version == null && ec.Includes("version",true))
        {
            this.Version = Int32.MinValue;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && ec.Includes("allOrgs",false))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));
        }
        //      C# -> BlueprintRecoveryCount? BlueprintRecoveryCount
        // GraphQL -> blueprintRecoveryCount: BlueprintRecoveryCount (type)
        if (this.BlueprintRecoveryCount == null && ec.Includes("blueprintRecoveryCount",false))
        {
            this.BlueprintRecoveryCount = new BlueprintRecoveryCount();
            this.BlueprintRecoveryCount.ApplyExploratoryFieldSpec(ec.NewChild("blueprintRecoveryCount"));
        }
        //      C# -> Schedule? BlueprintSchedule
        // GraphQL -> blueprintSchedule: Schedule (type)
        if (this.BlueprintSchedule == null && ec.Includes("blueprintSchedule",false))
        {
            this.BlueprintSchedule = new Schedule();
            this.BlueprintSchedule.ApplyExploratoryFieldSpec(ec.NewChild("blueprintSchedule"));
        }
        //      C# -> BlueprintChildConnection? ChildConnection
        // GraphQL -> childConnection: BlueprintChildConnection! (type)
        if (this.ChildConnection == null && ec.Includes("childConnection",false))
        {
            this.ChildConnection = new BlueprintChildConnection();
            this.ChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("childConnection"));
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && ec.Includes("effectiveSlaSourceObject",false))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));
        }
        //      C# -> BlueprintFailover? LatestFailover
        // GraphQL -> latestFailover: BlueprintFailover (type)
        if (this.LatestFailover == null && ec.Includes("latestFailover",false))
        {
            this.LatestFailover = new BlueprintFailover();
            this.LatestFailover.ApplyExploratoryFieldSpec(ec.NewChild("latestFailover"));
        }
        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        if (this.LocalRpoLagInfo == null && ec.Includes("localRpoLagInfo",false))
        {
            this.LocalRpoLagInfo = new RpoLagInfo();
            this.LocalRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("localRpoLagInfo"));
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && ec.Includes("logicalPath",false))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && ec.Includes("physicalPath",false))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));
        }
        //      C# -> BlueprintRecoveryRanges? RecoveryInfo
        // GraphQL -> recoveryInfo: BlueprintRecoveryRanges (type)
        if (this.RecoveryInfo == null && ec.Includes("recoveryInfo",false))
        {
            this.RecoveryInfo = new BlueprintRecoveryRanges();
            this.RecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfo"));
        }
        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        if (this.RemoteRpoLagInfo == null && ec.Includes("remoteRpoLagInfo",false))
        {
            this.RemoteRpoLagInfo = new RpoLagInfo();
            this.RemoteRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("remoteRpoLagInfo"));
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && ec.Includes("snapshotDistribution",false))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));
        }
    }


    #endregion

    } // class VsphereBlueprintNew
    
    #endregion

    public static class ListVsphereBlueprintNewExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<VsphereBlueprintNew> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<VsphereBlueprintNew> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types