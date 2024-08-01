// BlueprintNew.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region BlueprintNew

    public interface BlueprintNew: IFieldSpec
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> BlueprintLocation? SourceLocation
        // GraphQL -> sourceLocation: BlueprintLocation (interface)
        [JsonProperty("sourceLocation")]
        BlueprintLocation? SourceLocation { get; set; }

        //      C# -> BlueprintLocation? TargetLocation
        // GraphQL -> targetLocation: BlueprintLocation (interface)
        [JsonProperty("targetLocation")]
        BlueprintLocation? TargetLocation { get; set; }

        //      C# -> List<BlueprintChild>? Children
        // GraphQL -> children: [BlueprintChild!]! (interface)
        [JsonProperty("children")]
        List<BlueprintChild>? Children { get; set; }

        //      C# -> System.Int32? NumChildren
        // GraphQL -> numChildren: Int! (scalar)
        [JsonProperty("numChildren")]
        System.Int32? NumChildren { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        System.Boolean? IsArchived { get; set; }

        //      C# -> BlueprintStatus? Status
        // GraphQL -> status: BlueprintStatus! (enum)
        [JsonProperty("status")]
        BlueprintStatus? Status { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        System.Int32? Version { get; set; }

        //      C# -> BlueprintFailoverStatus? LastFailoverStatus
        // GraphQL -> lastFailoverStatus: BlueprintFailoverStatus! (enum)
        [JsonProperty("lastFailoverStatus")]
        BlueprintFailoverStatus? LastFailoverStatus { get; set; }

        //      C# -> DateTime? LastFailoverTime
        // GraphQL -> lastFailoverTime: DateTime (scalar)
        [JsonProperty("lastFailoverTime")]
        DateTime? LastFailoverTime { get; set; }

        //      C# -> BlueprintFailoverStatus? LastTestFailoverStatus
        // GraphQL -> lastTestFailoverStatus: BlueprintFailoverStatus! (enum)
        [JsonProperty("lastTestFailoverStatus")]
        BlueprintFailoverStatus? LastTestFailoverStatus { get; set; }

        //      C# -> System.String? LastFailoverSource
        // GraphQL -> lastFailoverSource: String (scalar)
        [JsonProperty("lastFailoverSource")]
        System.String? LastFailoverSource { get; set; }

        //      C# -> DateTime? LastTestFailoverTime
        // GraphQL -> lastTestFailoverTime: DateTime (scalar)
        [JsonProperty("lastTestFailoverTime")]
        DateTime? LastTestFailoverTime { get; set; }

        //      C# -> DateTime? LastLocalRecoveryTime
        // GraphQL -> lastLocalRecoveryTime: DateTime (scalar)
        [JsonProperty("lastLocalRecoveryTime")]
        DateTime? LastLocalRecoveryTime { get; set; }

        //      C# -> BlueprintFailoverStatus? LastLocalRecoveryStatus
        // GraphQL -> lastLocalRecoveryStatus: BlueprintFailoverStatus! (enum)
        [JsonProperty("lastLocalRecoveryStatus")]
        BlueprintFailoverStatus? LastLocalRecoveryStatus { get; set; }

        //      C# -> DateTime? LastIsolatedRecoveryTime
        // GraphQL -> lastIsolatedRecoveryTime: DateTime (scalar)
        [JsonProperty("lastIsolatedRecoveryTime")]
        DateTime? LastIsolatedRecoveryTime { get; set; }

        //      C# -> BlueprintFailoverStatus? LastIsolatedRecoveryStatus
        // GraphQL -> lastIsolatedRecoveryStatus: BlueprintFailoverStatus! (enum)
        [JsonProperty("lastIsolatedRecoveryStatus")]
        BlueprintFailoverStatus? LastIsolatedRecoveryStatus { get; set; }

        //      C# -> BlueprintFailover? LatestFailover
        // GraphQL -> latestFailover: BlueprintFailover (type)
        [JsonProperty("latestFailover")]
        BlueprintFailover? LatestFailover { get; set; }

        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean (scalar)
        [JsonProperty("isHydrationEnabled")]
        System.Boolean? IsHydrationEnabled { get; set; }

        //      C# -> List<System.Int64>? TimeoutBetweenPriorityGroups
        // GraphQL -> timeoutBetweenPriorityGroups: [Long!] (scalar)
        [JsonProperty("timeoutBetweenPriorityGroups")]
        List<System.Int64>? TimeoutBetweenPriorityGroups { get; set; }

        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        [JsonProperty("localRpoLagInfo")]
        RpoLagInfo? LocalRpoLagInfo { get; set; }

        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        [JsonProperty("remoteRpoLagInfo")]
        RpoLagInfo? RemoteRpoLagInfo { get; set; }

        //      C# -> BlueprintRecoveryType? BlueprintRecoveryType
        // GraphQL -> blueprintRecoveryType: BlueprintRecoveryType (enum)
        [JsonProperty("blueprintRecoveryType")]
        BlueprintRecoveryType? BlueprintRecoveryType { get; set; }

        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean (scalar)
        [JsonProperty("isBlueprintVisible")]
        System.Boolean? IsBlueprintVisible { get; set; }

        //      C# -> BlueprintRecoveryCount? BlueprintRecoveryCount
        // GraphQL -> blueprintRecoveryCount: BlueprintRecoveryCount (type)
        [JsonProperty("blueprintRecoveryCount")]
        BlueprintRecoveryCount? BlueprintRecoveryCount { get; set; }

        //      C# -> Schedule? BlueprintSchedule
        // GraphQL -> blueprintSchedule: Schedule (type)
        [JsonProperty("blueprintSchedule")]
        Schedule? BlueprintSchedule { get; set; }

        //      C# -> System.Boolean? IsBlueprintTargetConsistent
        // GraphQL -> isBlueprintTargetConsistent: Boolean! (scalar)
        [JsonProperty("isBlueprintTargetConsistent")]
        System.Boolean? IsBlueprintTargetConsistent { get; set; }

        //      C# -> ObjectTypeEnum? BlueprintWorkloadType
        // GraphQL -> blueprintWorkloadType: ObjectTypeEnum! (enum)
        [JsonProperty("blueprintWorkloadType")]
        ObjectTypeEnum? BlueprintWorkloadType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        System.String? Name { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        SlaDomain? EffectiveSlaDomain { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        SlaDomain? EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        SlaDomain? ConfiguredSlaDomain { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        List<PathNode>? LogicalPath { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        List<PathNode>? PhysicalPath { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        List<Org>? AllOrgs { get; set; }

        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        [JsonProperty("securityMetadata")]
        SecurityMetadata? SecurityMetadata { get; set; }


        #endregion

    } // interface BlueprintNew

    #endregion



    public static class ListBlueprintNewExtensions
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
            this List<BlueprintNew> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            string ind = conf.IndentStr();
            string fieldspecs = "";
            foreach (BlueprintNew item in list) 
            {
                var fspec = item.AsFieldSpec(conf.Child(ignoreComposition: true));
                string typename;
                if (item is BaseType bt) {
                    typename = bt.GetGqlTypeName();
                } else {
                    typename = item.GetType().Name;
                }
                string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
                if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                    if ( conf.Flat ) {
                        fieldspecs += conf.Prefix + fspec;
                    } else {
                        fieldspecs += ind + " ... on " + typename + " {\n" + fspec + ind + "}\n";
                    }
                }
            }
            return fieldspecs; // L-II
        }

        public static List<string> SelectedFields(this List<BlueprintNew> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintNew> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                InterfaceHelper
                    .AddInstancesOfImplementingTypes<BlueprintNew>(
                        list, 
                        instance => instance.ApplyExploratoryFieldSpec(ec));
            } else {
                foreach (BlueprintNew item in list) {
                    item.ApplyExploratoryFieldSpec(ec);
                }
            }

        }

        public static void SelectForRetrieval(this List<BlueprintNew> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types