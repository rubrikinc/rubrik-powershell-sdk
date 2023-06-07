// MongoDatabasePhysicalChildTypeConnection.cs
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
    #region MongoDatabasePhysicalChildTypeConnection
    public class MongoDatabasePhysicalChildTypeConnection: BaseType
    {
        #region members

        //      C# -> List<MongoDatabasePhysicalChildType>? Nodes
        // GraphQL -> nodes: [MongoDatabasePhysicalChildType!]! (interface)
        [JsonProperty("nodes")]
        public List<MongoDatabasePhysicalChildType>? Nodes { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<MongoDatabasePhysicalChildTypeEdge>? Edges
        // GraphQL -> edges: [MongoDatabasePhysicalChildTypeEdge!]! (type)
        [JsonProperty("edges")]
        public List<MongoDatabasePhysicalChildTypeEdge>? Edges { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public MongoDatabasePhysicalChildTypeConnection Set(
        List<MongoDatabasePhysicalChildType>? Nodes = null,
        System.Int32? Count = null,
        List<MongoDatabasePhysicalChildTypeEdge>? Edges = null,
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
        //      C# -> List<MongoDatabasePhysicalChildType>? Nodes
        // GraphQL -> nodes: [MongoDatabasePhysicalChildType!]! (interface)
        if (this.Nodes != null) {
            s += ind + "nodes {\n" +
                this.Nodes.AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> List<MongoDatabasePhysicalChildTypeEdge>? Edges
        // GraphQL -> edges: [MongoDatabasePhysicalChildTypeEdge!]! (type)
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
        //      C# -> List<MongoDatabasePhysicalChildType>? Nodes
        // GraphQL -> nodes: [MongoDatabasePhysicalChildType!]! (interface)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<MongoDatabasePhysicalChildType>();
            this.Nodes.ApplyExploratoryFieldSpec(parent + ".nodes");
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> List<MongoDatabasePhysicalChildTypeEdge>? Edges
        // GraphQL -> edges: [MongoDatabasePhysicalChildTypeEdge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<MongoDatabasePhysicalChildTypeEdge>();
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

    } // class MongoDatabasePhysicalChildTypeConnection
    
    #endregion

    public static class ListMongoDatabasePhysicalChildTypeConnectionExtensions
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
            this List<MongoDatabasePhysicalChildTypeConnection> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MongoDatabasePhysicalChildTypeConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MongoDatabasePhysicalChildTypeConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types