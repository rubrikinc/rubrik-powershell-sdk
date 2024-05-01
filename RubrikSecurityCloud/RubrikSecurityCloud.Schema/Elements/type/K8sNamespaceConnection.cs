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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? AggregateK8sPvcs
        // GraphQL -> aggregateK8sPvcs: Int! (scalar)
        if (this.AggregateK8sPvcs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aggregateK8sPvcs\n" ;
            } else {
                s += ind + "aggregateK8sPvcs\n" ;
            }
        }
        //      C# -> System.Int32? AggregateK8sWorkloads
        // GraphQL -> aggregateK8sWorkloads: Int! (scalar)
        if (this.AggregateK8sWorkloads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aggregateK8sWorkloads\n" ;
            } else {
                s += ind + "aggregateK8sWorkloads\n" ;
            }
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> List<K8sNamespaceEdge>? Edges
        // GraphQL -> edges: [K8sNamespaceEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(conf.Child("edges"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "edges" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<K8sNamespace>? Nodes
        // GraphQL -> nodes: [K8sNamespace!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(conf.Child("nodes"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nodes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(conf.Child("pageInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pageInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? AggregateK8sPvcs
        // GraphQL -> aggregateK8sPvcs: Int! (scalar)
        if (ec.Includes("aggregateK8sPvcs",true))
        {
            if(this.AggregateK8sPvcs == null) {

                this.AggregateK8sPvcs = Int32.MinValue;

            } else {


            }
        }
        else if (this.AggregateK8sPvcs != null && ec.Excludes("aggregateK8sPvcs",true))
        {
            this.AggregateK8sPvcs = null;
        }
        //      C# -> System.Int32? AggregateK8sWorkloads
        // GraphQL -> aggregateK8sWorkloads: Int! (scalar)
        if (ec.Includes("aggregateK8sWorkloads",true))
        {
            if(this.AggregateK8sWorkloads == null) {

                this.AggregateK8sWorkloads = Int32.MinValue;

            } else {


            }
        }
        else if (this.AggregateK8sWorkloads != null && ec.Excludes("aggregateK8sWorkloads",true))
        {
            this.AggregateK8sWorkloads = null;
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> List<K8sNamespaceEdge>? Edges
        // GraphQL -> edges: [K8sNamespaceEdge!]! (type)
        if (ec.Includes("edges",false))
        {
            if(this.Edges == null) {

                this.Edges = new List<K8sNamespaceEdge>();
                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            } else {

                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            }
        }
        else if (this.Edges != null && ec.Excludes("edges",false))
        {
            this.Edges = null;
        }
        //      C# -> List<K8sNamespace>? Nodes
        // GraphQL -> nodes: [K8sNamespace!]! (type)
        if (ec.Includes("nodes",false))
        {
            if(this.Nodes == null) {

                this.Nodes = new List<K8sNamespace>();
                this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));

            } else {

                this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));

            }
        }
        else if (this.Nodes != null && ec.Excludes("nodes",false))
        {
            this.Nodes = null;
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (ec.Includes("pageInfo",false))
        {
            if(this.PageInfo == null) {

                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            } else {

                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            }
        }
        else if (this.PageInfo != null && ec.Excludes("pageInfo",false))
        {
            this.PageInfo = null;
        }
    }


    #endregion

    } // class K8sNamespaceConnection
    
    #endregion

    public static class ListK8sNamespaceConnectionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<K8sNamespaceConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sNamespaceConnection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<K8sNamespaceConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types