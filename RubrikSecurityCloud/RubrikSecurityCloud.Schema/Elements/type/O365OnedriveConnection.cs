// O365OnedriveConnection.cs
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
    #region O365OnedriveConnection
    public class O365OnedriveConnection: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<O365OnedriveEdge>? Edges
        // GraphQL -> edges: [O365OnedriveEdge!]! (type)
        [JsonProperty("edges")]
        public List<O365OnedriveEdge>? Edges { get; set; }

        //      C# -> List<O365Onedrive>? Nodes
        // GraphQL -> nodes: [O365Onedrive!]! (type)
        [JsonProperty("nodes")]
        public List<O365Onedrive>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365OnedriveConnection";
    }

    public O365OnedriveConnection Set(
        System.Int32? Count = null,
        List<O365OnedriveEdge>? Edges = null,
        List<O365Onedrive>? Nodes = null,
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
        //      C# -> List<O365OnedriveEdge>? Edges
        // GraphQL -> edges: [O365OnedriveEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "edges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<O365Onedrive>? Nodes
        // GraphQL -> nodes: [O365Onedrive!]! (type)
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
        //      C# -> List<O365OnedriveEdge>? Edges
        // GraphQL -> edges: [O365OnedriveEdge!]! (type)
        if (this.Edges == null && ec.Includes("edges",false))
        {
            this.Edges = new List<O365OnedriveEdge>();
            this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));
        }
        //      C# -> List<O365Onedrive>? Nodes
        // GraphQL -> nodes: [O365Onedrive!]! (type)
        if (this.Nodes == null && ec.Includes("nodes",false))
        {
            this.Nodes = new List<O365Onedrive>();
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

    } // class O365OnedriveConnection
    
    #endregion

    public static class ListO365OnedriveConnectionExtensions
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
            this List<O365OnedriveConnection> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365OnedriveConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365OnedriveConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<O365OnedriveConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types