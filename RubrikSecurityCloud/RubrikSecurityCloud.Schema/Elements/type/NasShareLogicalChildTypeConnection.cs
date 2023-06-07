// NasShareLogicalChildTypeConnection.cs
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
    #region NasShareLogicalChildTypeConnection
    public class NasShareLogicalChildTypeConnection: BaseType
    {
        #region members

        //      C# -> List<NasShareLogicalChildType>? Nodes
        // GraphQL -> nodes: [NasShareLogicalChildType!]! (interface)
        [JsonProperty("nodes")]
        public List<NasShareLogicalChildType>? Nodes { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<NasShareLogicalChildTypeEdge>? Edges
        // GraphQL -> edges: [NasShareLogicalChildTypeEdge!]! (type)
        [JsonProperty("edges")]
        public List<NasShareLogicalChildTypeEdge>? Edges { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public NasShareLogicalChildTypeConnection Set(
        List<NasShareLogicalChildType>? Nodes = null,
        System.Int32? Count = null,
        List<NasShareLogicalChildTypeEdge>? Edges = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( Nodes != null ) {
            this.Nodes = Nodes;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Edges != null ) {
            this.Edges = Edges;
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
        //      C# -> List<NasShareLogicalChildType>? Nodes
        // GraphQL -> nodes: [NasShareLogicalChildType!]! (interface)
        if (this.Nodes != null) {
            s += ind + "nodes {\n" +
                this.Nodes.AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> List<NasShareLogicalChildTypeEdge>? Edges
        // GraphQL -> edges: [NasShareLogicalChildTypeEdge!]! (type)
        if (this.Edges != null) {
            s += ind + "edges {\n" + this.Edges.AsFieldSpec(indent+1) + ind + "}\n" ;
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
        //      C# -> List<NasShareLogicalChildType>? Nodes
        // GraphQL -> nodes: [NasShareLogicalChildType!]! (interface)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<NasShareLogicalChildType>();
            this.Nodes.ApplyExploratoryFieldSpec(parent + ".nodes");
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> List<NasShareLogicalChildTypeEdge>? Edges
        // GraphQL -> edges: [NasShareLogicalChildTypeEdge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<NasShareLogicalChildTypeEdge>();
            this.Edges.ApplyExploratoryFieldSpec(parent + ".edges");
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

    } // class NasShareLogicalChildTypeConnection
    
    #endregion

    public static class ListNasShareLogicalChildTypeConnectionExtensions
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
            this List<NasShareLogicalChildTypeConnection> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NasShareLogicalChildTypeConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NasShareLogicalChildTypeConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types