// MongodbSourcePhysicalChildTypeConnection.cs
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
    #region MongodbSourcePhysicalChildTypeConnection
    public class MongodbSourcePhysicalChildTypeConnection: BaseType
    {
        #region members

        //      C# -> List<MongodbSourcePhysicalChildType>? Nodes
        // GraphQL -> nodes: [MongodbSourcePhysicalChildType!]! (interface)
        [JsonProperty("nodes")]
        public List<MongodbSourcePhysicalChildType>? Nodes { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<MongodbSourcePhysicalChildTypeEdge>? Edges
        // GraphQL -> edges: [MongodbSourcePhysicalChildTypeEdge!]! (type)
        [JsonProperty("edges")]
        public List<MongodbSourcePhysicalChildTypeEdge>? Edges { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public MongodbSourcePhysicalChildTypeConnection Set(
        List<MongodbSourcePhysicalChildType>? Nodes = null,
        System.Int32? Count = null,
        List<MongodbSourcePhysicalChildTypeEdge>? Edges = null,
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
        //      C# -> List<MongodbSourcePhysicalChildType>? Nodes
        // GraphQL -> nodes: [MongodbSourcePhysicalChildType!]! (interface)
        if (this.Nodes != null) {
            s += ind + "nodes {\n" +
                this.Nodes.AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> List<MongodbSourcePhysicalChildTypeEdge>? Edges
        // GraphQL -> edges: [MongodbSourcePhysicalChildTypeEdge!]! (type)
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
        //      C# -> List<MongodbSourcePhysicalChildType>? Nodes
        // GraphQL -> nodes: [MongodbSourcePhysicalChildType!]! (interface)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<MongodbSourcePhysicalChildType>();
            this.Nodes.ApplyExploratoryFieldSpec(parent + ".nodes");
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> List<MongodbSourcePhysicalChildTypeEdge>? Edges
        // GraphQL -> edges: [MongodbSourcePhysicalChildTypeEdge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<MongodbSourcePhysicalChildTypeEdge>();
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

    } // class MongodbSourcePhysicalChildTypeConnection
    
    #endregion

    public static class ListMongodbSourcePhysicalChildTypeConnectionExtensions
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
            this List<MongodbSourcePhysicalChildTypeConnection> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MongodbSourcePhysicalChildTypeConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MongodbSourcePhysicalChildTypeConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types