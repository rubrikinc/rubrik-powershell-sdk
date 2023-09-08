// CassandraColumnFamilyConnection.cs
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
    #region CassandraColumnFamilyConnection
    public class CassandraColumnFamilyConnection: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<CassandraColumnFamilyEdge>? Edges
        // GraphQL -> edges: [CassandraColumnFamilyEdge!]! (type)
        [JsonProperty("edges")]
        public List<CassandraColumnFamilyEdge>? Edges { get; set; }

        //      C# -> List<CassandraColumnFamily>? Nodes
        // GraphQL -> nodes: [CassandraColumnFamily!]! (type)
        [JsonProperty("nodes")]
        public List<CassandraColumnFamily>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CassandraColumnFamilyConnection";
    }

    public CassandraColumnFamilyConnection Set(
        System.Int32? Count = null,
        List<CassandraColumnFamilyEdge>? Edges = null,
        List<CassandraColumnFamily>? Nodes = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
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
        //      C# -> List<CassandraColumnFamilyEdge>? Edges
        // GraphQL -> edges: [CassandraColumnFamilyEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "edges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CassandraColumnFamily>? Nodes
        // GraphQL -> nodes: [CassandraColumnFamily!]! (type)
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && ec.Includes("count",true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> List<CassandraColumnFamilyEdge>? Edges
        // GraphQL -> edges: [CassandraColumnFamilyEdge!]! (type)
        if (this.Edges == null && ec.Includes("edges",false))
        {
            this.Edges = new List<CassandraColumnFamilyEdge>();
            this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));
        }
        //      C# -> List<CassandraColumnFamily>? Nodes
        // GraphQL -> nodes: [CassandraColumnFamily!]! (type)
        if (this.Nodes == null && ec.Includes("nodes",false))
        {
            this.Nodes = new List<CassandraColumnFamily>();
            this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo == null && ec.Includes("pageInfo",false))
        {
            this.PageInfo = new PageInfo();
            this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));
        }
    }


    #endregion

    } // class CassandraColumnFamilyConnection
    
    #endregion

    public static class ListCassandraColumnFamilyConnectionExtensions
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
            this List<CassandraColumnFamilyConnection> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CassandraColumnFamilyConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CassandraColumnFamilyConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CassandraColumnFamilyConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types