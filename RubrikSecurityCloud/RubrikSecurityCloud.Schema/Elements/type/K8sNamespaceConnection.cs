// K8sNamespaceConnection.cs
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
    #region K8sNamespaceConnection
    public class K8sNamespaceConnection: BaseType
    {
        #region members

        //      C# -> System.Int32? AggregateK8sPvcs
        // GraphQL -> aggregateK8sPvcs: Int! (scalar)
        [JsonProperty("aggregateK8sPvcs")]
        public System.Int32? AggregateK8sPvcs { get; set; }

        //      C# -> System.Int32? AggregateK8sWorkloads
        // GraphQL -> aggregateK8sWorkloads: Int! (scalar)
        [JsonProperty("aggregateK8sWorkloads")]
        public System.Int32? AggregateK8sWorkloads { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<K8sNamespaceEdge>? Edges
        // GraphQL -> edges: [K8sNamespaceEdge!]! (type)
        [JsonProperty("edges")]
        public List<K8sNamespaceEdge>? Edges { get; set; }

        //      C# -> List<K8sNamespace>? Nodes
        // GraphQL -> nodes: [K8sNamespace!]! (type)
        [JsonProperty("nodes")]
        public List<K8sNamespace>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sNamespaceConnection";
    }

    public K8sNamespaceConnection Set(
        System.Int32? AggregateK8sPvcs = null,
        System.Int32? AggregateK8sWorkloads = null,
        System.Int32? Count = null,
        List<K8sNamespaceEdge>? Edges = null,
        List<K8sNamespace>? Nodes = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( AggregateK8sPvcs != null ) {
            this.AggregateK8sPvcs = AggregateK8sPvcs;
        }
        if ( AggregateK8sWorkloads != null ) {
            this.AggregateK8sWorkloads = AggregateK8sWorkloads;
        }
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
        //      C# -> System.Int32? AggregateK8sPvcs
        // GraphQL -> aggregateK8sPvcs: Int! (scalar)
        if (this.AggregateK8sPvcs != null) {
            s += ind + "aggregateK8sPvcs\n" ;
        }
        //      C# -> System.Int32? AggregateK8sWorkloads
        // GraphQL -> aggregateK8sWorkloads: Int! (scalar)
        if (this.AggregateK8sWorkloads != null) {
            s += ind + "aggregateK8sWorkloads\n" ;
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> List<K8sNamespaceEdge>? Edges
        // GraphQL -> edges: [K8sNamespaceEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "edges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<K8sNamespace>? Nodes
        // GraphQL -> nodes: [K8sNamespace!]! (type)
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
        //      C# -> System.Int32? AggregateK8sPvcs
        // GraphQL -> aggregateK8sPvcs: Int! (scalar)
        if (this.AggregateK8sPvcs == null && ec.Includes("aggregateK8sPvcs",true))
        {
            this.AggregateK8sPvcs = Int32.MinValue;
        }
        //      C# -> System.Int32? AggregateK8sWorkloads
        // GraphQL -> aggregateK8sWorkloads: Int! (scalar)
        if (this.AggregateK8sWorkloads == null && ec.Includes("aggregateK8sWorkloads",true))
        {
            this.AggregateK8sWorkloads = Int32.MinValue;
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && ec.Includes("count",true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> List<K8sNamespaceEdge>? Edges
        // GraphQL -> edges: [K8sNamespaceEdge!]! (type)
        if (this.Edges == null && ec.Includes("edges",false))
        {
            this.Edges = new List<K8sNamespaceEdge>();
            this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));
        }
        //      C# -> List<K8sNamespace>? Nodes
        // GraphQL -> nodes: [K8sNamespace!]! (type)
        if (this.Nodes == null && ec.Includes("nodes",false))
        {
            this.Nodes = new List<K8sNamespace>();
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

    } // class K8sNamespaceConnection
    
    #endregion

    public static class ListK8sNamespaceConnectionExtensions
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
            this List<K8sNamespaceConnection> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sNamespaceConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sNamespaceConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<K8sNamespaceConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types