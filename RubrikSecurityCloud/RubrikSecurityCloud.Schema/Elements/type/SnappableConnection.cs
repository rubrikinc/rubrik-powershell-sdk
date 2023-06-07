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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region SnappableConnection
    public class SnappableConnection: BaseType
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
        //      C# -> SnappableAggregation? Aggregation
        // GraphQL -> aggregation: SnappableAggregation! (type)
        if (this.Aggregation != null) {
            s += ind + "aggregation {\n" + this.Aggregation.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<SnappableEdge>? Edges
        // GraphQL -> edges: [SnappableEdge!]! (type)
        if (this.Edges != null) {
            s += ind + "edges {\n" + this.Edges.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<Snappable>? Nodes
        // GraphQL -> nodes: [Snappable!]! (type)
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
            this.Count = Int32.MinValue;
        }
        //      C# -> SnappableAggregation? Aggregation
        // GraphQL -> aggregation: SnappableAggregation! (type)
        if (this.Aggregation == null && Exploration.Includes(parent + ".aggregation"))
        {
            this.Aggregation = new SnappableAggregation();
            this.Aggregation.ApplyExploratoryFieldSpec(parent + ".aggregation");
        }
        //      C# -> List<SnappableEdge>? Edges
        // GraphQL -> edges: [SnappableEdge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<SnappableEdge>();
            this.Edges.ApplyExploratoryFieldSpec(parent + ".edges");
        }
        //      C# -> List<Snappable>? Nodes
        // GraphQL -> nodes: [Snappable!]! (type)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<Snappable>();
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

    } // class SnappableConnection
    
    #endregion

    public static class ListSnappableConnectionExtensions
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
            this List<SnappableConnection> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnappableConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnappableConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types