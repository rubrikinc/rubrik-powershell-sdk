// WorkloadAnomalyConnection.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:39.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region WorkloadAnomalyConnection
    public class WorkloadAnomalyConnection: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> AggregatedValues? Aggregation
            // GraphQL -> aggregation: AggregatedValues! (type)
            if (this.Aggregation != null)
            {
                 s += ind + "aggregation\n";

                 s += ind + "{\n" + 
                 this.Aggregation.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<WorkloadAnomalyEdge>? Edges
            // GraphQL -> edges: [WorkloadAnomalyEdge!]! (type)
            if (this.Edges != null)
            {
                 s += ind + "edges\n";

                 s += ind + "{\n" + 
                 this.Edges.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<WorkloadAnomaly>? Nodes
            // GraphQL -> nodes: [WorkloadAnomaly!]! (type)
            if (this.Nodes != null)
            {
                 s += ind + "nodes\n";

                 s += ind + "{\n" + 
                 this.Nodes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo != null)
            {
                 s += ind + "pageInfo\n";

                 s += ind + "{\n" + 
                 this.PageInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int32();
            }
            //      C# -> AggregatedValues? Aggregation
            // GraphQL -> aggregation: AggregatedValues! (type)
            if (this.Aggregation == null && Exploration.Includes(parent + ".aggregation"))
            {
                this.Aggregation = new AggregatedValues();
                this.Aggregation.ApplyExploratoryFragment(parent + ".aggregation");
            }
            //      C# -> List<WorkloadAnomalyEdge>? Edges
            // GraphQL -> edges: [WorkloadAnomalyEdge!]! (type)
            if (this.Edges == null && Exploration.Includes(parent + ".edges"))
            {
                this.Edges = new List<WorkloadAnomalyEdge>();
                this.Edges.ApplyExploratoryFragment(parent + ".edges");
            }
            //      C# -> List<WorkloadAnomaly>? Nodes
            // GraphQL -> nodes: [WorkloadAnomaly!]! (type)
            if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
            {
                this.Nodes = new List<WorkloadAnomaly>();
                this.Nodes.ApplyExploratoryFragment(parent + ".nodes");
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
            {
                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFragment(parent + ".pageInfo");
            }
        }


    #endregion

    } // class WorkloadAnomalyConnection
    #endregion

    public static class ListWorkloadAnomalyConnectionExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<WorkloadAnomalyConnection> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<WorkloadAnomalyConnection> list, 
            String parent = "")
        {
            var item = new WorkloadAnomalyConnection();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types