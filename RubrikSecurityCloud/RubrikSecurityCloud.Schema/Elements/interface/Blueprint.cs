// Blueprint.cs
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
    #region Blueprint

    public interface Blueprint: IFieldSpec
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        Cluster? Cluster { get; set; }

        //      C# -> List<BlueprintChild>? Children
        // GraphQL -> children: [BlueprintChild!]! (interface)
        [JsonProperty("children")]
        List<BlueprintChild>? Children { get; set; }

        //      C# -> System.Int32? NumChildren
        // GraphQL -> numChildren: Int! (scalar)
        [JsonProperty("numChildren")]
        System.Int32? NumChildren { get; set; }

        //      C# -> AppBlueprintStatus? Status
        // GraphQL -> status: AppBlueprintStatus! (enum)
        [JsonProperty("status")]
        AppBlueprintStatus? Status { get; set; }

        //      C# -> AppBlueprintRmStatus? RmStatus
        // GraphQL -> rmStatus: AppBlueprintRmStatus! (enum)
        [JsonProperty("rmStatus")]
        AppBlueprintRmStatus? RmStatus { get; set; }

        //      C# -> AppBlueprintFailoverStatus? CurrentFailoverStatus
        // GraphQL -> currentFailoverStatus: AppBlueprintFailoverStatus! (enum)
        [JsonProperty("currentFailoverStatus")]
        AppBlueprintFailoverStatus? CurrentFailoverStatus { get; set; }

        //      C# -> Failover? LastFailover
        // GraphQL -> lastFailover: Failover (type)
        [JsonProperty("lastFailover")]
        Failover? LastFailover { get; set; }

        //      C# -> Failover? LastTestFailover
        // GraphQL -> lastTestFailover: Failover (type)
        [JsonProperty("lastTestFailover")]
        Failover? LastTestFailover { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        System.Boolean? IsRelic { get; set; }

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


        #endregion

    } // interface Blueprint

    #endregion



    public static class ListBlueprintExtensions
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
            this List<Blueprint> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            string fieldspecs = "";
            foreach (Blueprint item in list) 
            {
                var fspec = item.AsFieldSpec(indent+1);
                if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                    fieldspecs += ind + " ... on " + item.GetType().Name + " {\n" + fspec + ind + "}\n";
                }
            }
            return fieldspecs;
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Blueprint> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                InterfaceHelper
                    .AddInstancesOfImplementingTypes<Blueprint>(
                        ref list, 
                        instance => instance.ApplyExploratoryFieldSpec(parent));
            } else {
                foreach (Blueprint item in list) {
                    item.ApplyExploratoryFieldSpec(parent);
                }
            }

        }
    }


} // namespace RubrikSecurityCloud.Types