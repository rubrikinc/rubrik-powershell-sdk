// SnappableConnection.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region SnappableConnection
    public class SnappableConnection: IFragment
    {
        #region members
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> SnappableAggregation? Aggregation
        // GraphQL -> aggregation: SnappableAggregation! (type)
        [JsonProperty("aggregation")]
        public SnappableAggregation? Aggregation { get; set; }

        //      C# -> List<SnappableEdge>? Edges
        // GraphQL -> edges: [SnappableEdge!]! (type)
        [JsonProperty("edges")]
        public List<SnappableEdge>? Edges { get; set; }

        //      C# -> List<Snappable>? Nodes
        // GraphQL -> nodes: [Snappable!]! (type)
        [JsonProperty("nodes")]
        public List<Snappable>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        #endregion

    #region methods

    public SnappableConnection Set(
        System.Int32? Count = null,
        SnappableAggregation? Aggregation = null,
        List<SnappableEdge>? Edges = null,
        List<Snappable>? Nodes = null,
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
            //      C# -> SnappableAggregation? Aggregation
            // GraphQL -> aggregation: SnappableAggregation! (type)
            if (this.Aggregation != null)
            {
                 s += ind + "aggregation\n";

                 s += ind + "{\n" + 
                 this.Aggregation.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SnappableEdge>? Edges
            // GraphQL -> edges: [SnappableEdge!]! (type)
            if (this.Edges != null)
            {
                 s += ind + "edges\n";

                 s += ind + "{\n" + 
                 this.Edges.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Snappable>? Nodes
            // GraphQL -> nodes: [Snappable!]! (type)
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
            //      C# -> SnappableAggregation? Aggregation
            // GraphQL -> aggregation: SnappableAggregation! (type)
            if (this.Aggregation == null && Exploration.Includes(parent + ".aggregation"))
            {
                this.Aggregation = new SnappableAggregation();
                this.Aggregation.ApplyExploratoryFragment(parent + ".aggregation");
            }
            //      C# -> List<SnappableEdge>? Edges
            // GraphQL -> edges: [SnappableEdge!]! (type)
            if (this.Edges == null && Exploration.Includes(parent + ".edges"))
            {
                this.Edges = new List<SnappableEdge>();
                this.Edges.ApplyExploratoryFragment(parent + ".edges");
            }
            //      C# -> List<Snappable>? Nodes
            // GraphQL -> nodes: [Snappable!]! (type)
            if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
            {
                this.Nodes = new List<Snappable>();
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

    } // class SnappableConnection
    #endregion

    public static class ListSnappableConnectionExtensions
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
            this List<SnappableConnection> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnappableConnection> list, 
            String parent = "")
        {
            var item = new SnappableConnection();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types