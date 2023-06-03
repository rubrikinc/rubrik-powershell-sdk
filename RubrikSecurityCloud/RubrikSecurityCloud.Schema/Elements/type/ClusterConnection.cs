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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ClusterConnection
    public class ClusterConnection: BaseType
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
        //      C# -> ClusterHealthAggregation? AggregateClusterHealth
        // GraphQL -> aggregateClusterHealth: ClusterHealthAggregation! (type)
        if (this.AggregateClusterHealth != null) {
            s += ind + "aggregateClusterHealth {\n" + this.AggregateClusterHealth.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ClusterStatsAggregation? AggregateClusterStatistics
        // GraphQL -> aggregateClusterStatistics: ClusterStatsAggregation! (type)
        if (this.AggregateClusterStatistics != null) {
            s += ind + "aggregateClusterStatistics {\n" + this.AggregateClusterStatistics.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ClusterEdge>? Edges
        // GraphQL -> edges: [ClusterEdge!]! (type)
        if (this.Edges != null) {
            s += ind + "edges {\n" + this.Edges.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<Cluster>? Nodes
        // GraphQL -> nodes: [Cluster!]! (type)
        if (this.Nodes != null) {
            s += ind + "nodes {\n" + this.Nodes.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            s += ind + "pageInfo {\n" + this.PageInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
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
            this.Count = new System.Int32();
        }
        //      C# -> ClusterHealthAggregation? AggregateClusterHealth
        // GraphQL -> aggregateClusterHealth: ClusterHealthAggregation! (type)
        if (this.AggregateClusterHealth == null && Exploration.Includes(parent + ".aggregateClusterHealth"))
        {
            this.AggregateClusterHealth = new ClusterHealthAggregation();
            this.AggregateClusterHealth.ApplyExploratoryFieldSpec(parent + ".aggregateClusterHealth");
        }
        //      C# -> ClusterStatsAggregation? AggregateClusterStatistics
        // GraphQL -> aggregateClusterStatistics: ClusterStatsAggregation! (type)
        if (this.AggregateClusterStatistics == null && Exploration.Includes(parent + ".aggregateClusterStatistics"))
        {
            this.AggregateClusterStatistics = new ClusterStatsAggregation();
            this.AggregateClusterStatistics.ApplyExploratoryFieldSpec(parent + ".aggregateClusterStatistics");
        }
        //      C# -> List<ClusterEdge>? Edges
        // GraphQL -> edges: [ClusterEdge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<ClusterEdge>();
            this.Edges.ApplyExploratoryFieldSpec(parent + ".edges");
        }
        //      C# -> List<Cluster>? Nodes
        // GraphQL -> nodes: [Cluster!]! (type)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<Cluster>();
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

    } // class ClusterConnection
    
    #endregion

    public static class ListClusterConnectionExtensions
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
            this List<ClusterConnection> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types