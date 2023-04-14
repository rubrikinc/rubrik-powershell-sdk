// ClusterConnection.cs
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
    #region ClusterConnection
    public class ClusterConnection: IFragment
    {
        #region members
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> ClusterHealthAggregation? AggregateClusterHealth
        // GraphQL -> aggregateClusterHealth: ClusterHealthAggregation! (type)
        [JsonProperty("aggregateClusterHealth")]
        public ClusterHealthAggregation? AggregateClusterHealth { get; set; }

        //      C# -> ClusterStatsAggregation? AggregateClusterStatistics
        // GraphQL -> aggregateClusterStatistics: ClusterStatsAggregation! (type)
        [JsonProperty("aggregateClusterStatistics")]
        public ClusterStatsAggregation? AggregateClusterStatistics { get; set; }

        //      C# -> List<ClusterEdge>? Edges
        // GraphQL -> edges: [ClusterEdge!]! (type)
        [JsonProperty("edges")]
        public List<ClusterEdge>? Edges { get; set; }

        //      C# -> List<Cluster>? Nodes
        // GraphQL -> nodes: [Cluster!]! (type)
        [JsonProperty("nodes")]
        public List<Cluster>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        #endregion

    #region methods

    public ClusterConnection Set(
        System.Int32? Count = null,
        ClusterHealthAggregation? AggregateClusterHealth = null,
        ClusterStatsAggregation? AggregateClusterStatistics = null,
        List<ClusterEdge>? Edges = null,
        List<Cluster>? Nodes = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( AggregateClusterHealth != null ) {
            this.AggregateClusterHealth = AggregateClusterHealth;
        }
        if ( AggregateClusterStatistics != null ) {
            this.AggregateClusterStatistics = AggregateClusterStatistics;
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
            //      C# -> ClusterHealthAggregation? AggregateClusterHealth
            // GraphQL -> aggregateClusterHealth: ClusterHealthAggregation! (type)
            if (this.AggregateClusterHealth != null)
            {
                 s += ind + "aggregateClusterHealth\n";

                 s += ind + "{\n" + 
                 this.AggregateClusterHealth.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClusterStatsAggregation? AggregateClusterStatistics
            // GraphQL -> aggregateClusterStatistics: ClusterStatsAggregation! (type)
            if (this.AggregateClusterStatistics != null)
            {
                 s += ind + "aggregateClusterStatistics\n";

                 s += ind + "{\n" + 
                 this.AggregateClusterStatistics.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClusterEdge>? Edges
            // GraphQL -> edges: [ClusterEdge!]! (type)
            if (this.Edges != null)
            {
                 s += ind + "edges\n";

                 s += ind + "{\n" + 
                 this.Edges.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Cluster>? Nodes
            // GraphQL -> nodes: [Cluster!]! (type)
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
            //      C# -> ClusterHealthAggregation? AggregateClusterHealth
            // GraphQL -> aggregateClusterHealth: ClusterHealthAggregation! (type)
            if (this.AggregateClusterHealth == null && Exploration.Includes(parent + ".aggregateClusterHealth"))
            {
                this.AggregateClusterHealth = new ClusterHealthAggregation();
                this.AggregateClusterHealth.ApplyExploratoryFragment(parent + ".aggregateClusterHealth");
            }
            //      C# -> ClusterStatsAggregation? AggregateClusterStatistics
            // GraphQL -> aggregateClusterStatistics: ClusterStatsAggregation! (type)
            if (this.AggregateClusterStatistics == null && Exploration.Includes(parent + ".aggregateClusterStatistics"))
            {
                this.AggregateClusterStatistics = new ClusterStatsAggregation();
                this.AggregateClusterStatistics.ApplyExploratoryFragment(parent + ".aggregateClusterStatistics");
            }
            //      C# -> List<ClusterEdge>? Edges
            // GraphQL -> edges: [ClusterEdge!]! (type)
            if (this.Edges == null && Exploration.Includes(parent + ".edges"))
            {
                this.Edges = new List<ClusterEdge>();
                this.Edges.ApplyExploratoryFragment(parent + ".edges");
            }
            //      C# -> List<Cluster>? Nodes
            // GraphQL -> nodes: [Cluster!]! (type)
            if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
            {
                this.Nodes = new List<Cluster>();
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

    } // class ClusterConnection
    #endregion

    public static class ListClusterConnectionExtensions
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
            this List<ClusterConnection> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterConnection> list, 
            String parent = "")
        {
            var item = new ClusterConnection();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types