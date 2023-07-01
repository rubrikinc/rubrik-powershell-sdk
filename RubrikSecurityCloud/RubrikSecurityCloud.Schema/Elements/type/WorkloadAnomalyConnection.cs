// WorkloadAnomalyConnection.cs
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
    #region WorkloadAnomalyConnection
    public class WorkloadAnomalyConnection: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> AggregatedValues? Aggregation
        // GraphQL -> aggregation: AggregatedValues! (type)
        [JsonProperty("aggregation")]
        public AggregatedValues? Aggregation { get; set; }

        //      C# -> List<WorkloadAnomalyEdge>? Edges
        // GraphQL -> edges: [WorkloadAnomalyEdge!]! (type)
        [JsonProperty("edges")]
        public List<WorkloadAnomalyEdge>? Edges { get; set; }

        //      C# -> List<WorkloadAnomaly>? Nodes
        // GraphQL -> nodes: [WorkloadAnomaly!]! (type)
        [JsonProperty("nodes")]
        public List<WorkloadAnomaly>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadAnomalyConnection";
    }

    public WorkloadAnomalyConnection Set(
        System.Int32? Count = null,
        AggregatedValues? Aggregation = null,
        List<WorkloadAnomalyEdge>? Edges = null,
        List<WorkloadAnomaly>? Nodes = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Aggregation != null ) {
            this.Aggregation = Aggregation;
        }
        if ( Edges != null ) {
            this.Edges = Edges;
        }
        if ( Nodes != null ) {
            this.Nodes = Nodes;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> AggregatedValues? Aggregation
        // GraphQL -> aggregation: AggregatedValues! (type)
        if (this.Aggregation != null) {
            var fspec = this.Aggregation.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "aggregation {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<WorkloadAnomalyEdge>? Edges
        // GraphQL -> edges: [WorkloadAnomalyEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "edges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<WorkloadAnomaly>? Nodes
        // GraphQL -> nodes: [WorkloadAnomaly!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nodes {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pageInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> AggregatedValues? Aggregation
        // GraphQL -> aggregation: AggregatedValues! (type)
        if (this.Aggregation == null && Exploration.Includes(parent + ".aggregation"))
        {
            this.Aggregation = new AggregatedValues();
            this.Aggregation.ApplyExploratoryFieldSpec(parent + ".aggregation");
        }
        //      C# -> List<WorkloadAnomalyEdge>? Edges
        // GraphQL -> edges: [WorkloadAnomalyEdge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<WorkloadAnomalyEdge>();
            this.Edges.ApplyExploratoryFieldSpec(parent + ".edges");
        }
        //      C# -> List<WorkloadAnomaly>? Nodes
        // GraphQL -> nodes: [WorkloadAnomaly!]! (type)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<WorkloadAnomaly>();
            this.Nodes.ApplyExploratoryFieldSpec(parent + ".nodes");
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
        {
            this.PageInfo = new PageInfo();
            this.PageInfo.ApplyExploratoryFieldSpec(parent + ".pageInfo");
        }
    }


    #endregion

    } // class WorkloadAnomalyConnection
    
    #endregion

    public static class ListWorkloadAnomalyConnectionExtensions
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
            this List<WorkloadAnomalyConnection> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadAnomalyConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadAnomalyConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types