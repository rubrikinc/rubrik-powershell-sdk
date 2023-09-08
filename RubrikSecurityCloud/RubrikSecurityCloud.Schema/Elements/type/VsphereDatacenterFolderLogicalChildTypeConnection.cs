// VsphereDatacenterFolderLogicalChildTypeConnection.cs
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
    #region VsphereDatacenterFolderLogicalChildTypeConnection
    public class VsphereDatacenterFolderLogicalChildTypeConnection: BaseType
    {
        #region members

        //      C# -> List<VsphereDatacenterFolderLogicalChildType>? Nodes
        // GraphQL -> nodes: [VsphereDatacenterFolderLogicalChildType!]! (interface)
        [JsonProperty("nodes")]
        public List<VsphereDatacenterFolderLogicalChildType>? Nodes { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<VsphereDatacenterFolderLogicalChildTypeEdge>? Edges
        // GraphQL -> edges: [VsphereDatacenterFolderLogicalChildTypeEdge!]! (type)
        [JsonProperty("edges")]
        public List<VsphereDatacenterFolderLogicalChildTypeEdge>? Edges { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereDatacenterFolderLogicalChildTypeConnection";
    }

    public VsphereDatacenterFolderLogicalChildTypeConnection Set(
        List<VsphereDatacenterFolderLogicalChildType>? Nodes = null,
        System.Int32? Count = null,
        List<VsphereDatacenterFolderLogicalChildTypeEdge>? Edges = null,
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
        //      C# -> List<VsphereDatacenterFolderLogicalChildType>? Nodes
        // GraphQL -> nodes: [VsphereDatacenterFolderLogicalChildType!]! (interface)
        if (this.Nodes != null) {
                var fspec = this.Nodes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nodes {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> List<VsphereDatacenterFolderLogicalChildTypeEdge>? Edges
        // GraphQL -> edges: [VsphereDatacenterFolderLogicalChildTypeEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "edges {\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<VsphereDatacenterFolderLogicalChildType>? Nodes
        // GraphQL -> nodes: [VsphereDatacenterFolderLogicalChildType!]! (interface)
        if (this.Nodes == null && ec.Includes("nodes",false))
        {
            this.Nodes = new List<VsphereDatacenterFolderLogicalChildType>();
            this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && ec.Includes("count",true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> List<VsphereDatacenterFolderLogicalChildTypeEdge>? Edges
        // GraphQL -> edges: [VsphereDatacenterFolderLogicalChildTypeEdge!]! (type)
        if (this.Edges == null && ec.Includes("edges",false))
        {
            this.Edges = new List<VsphereDatacenterFolderLogicalChildTypeEdge>();
            this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));
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

    } // class VsphereDatacenterFolderLogicalChildTypeConnection
    
    #endregion

    public static class ListVsphereDatacenterFolderLogicalChildTypeConnectionExtensions
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
            this List<VsphereDatacenterFolderLogicalChildTypeConnection> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereDatacenterFolderLogicalChildTypeConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereDatacenterFolderLogicalChildTypeConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VsphereDatacenterFolderLogicalChildTypeConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types