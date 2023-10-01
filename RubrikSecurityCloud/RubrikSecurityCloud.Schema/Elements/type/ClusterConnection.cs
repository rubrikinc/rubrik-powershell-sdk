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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "ClusterConnection";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> ClusterHealthAggregation? AggregateClusterHealth
        // GraphQL -> aggregateClusterHealth: ClusterHealthAggregation! (type)
        if (this.AggregateClusterHealth != null) {
            var fspec = this.AggregateClusterHealth.AsFieldSpec(conf.Child("aggregateClusterHealth"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "aggregateClusterHealth {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterStatsAggregation? AggregateClusterStatistics
        // GraphQL -> aggregateClusterStatistics: ClusterStatsAggregation! (type)
        if (this.AggregateClusterStatistics != null) {
            var fspec = this.AggregateClusterStatistics.AsFieldSpec(conf.Child("aggregateClusterStatistics"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "aggregateClusterStatistics {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ClusterEdge>? Edges
        // GraphQL -> edges: [ClusterEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(conf.Child("edges"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "edges {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Cluster>? Nodes
        // GraphQL -> nodes: [Cluster!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(conf.Child("nodes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nodes {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(conf.Child("pageInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pageInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> ClusterHealthAggregation? AggregateClusterHealth
        // GraphQL -> aggregateClusterHealth: ClusterHealthAggregation! (type)
        if (ec.Includes("aggregateClusterHealth",false))
        {
            if(this.AggregateClusterHealth == null) {

                this.AggregateClusterHealth = new ClusterHealthAggregation();
                this.AggregateClusterHealth.ApplyExploratoryFieldSpec(ec.NewChild("aggregateClusterHealth"));

            } else {

                this.AggregateClusterHealth.ApplyExploratoryFieldSpec(ec.NewChild("aggregateClusterHealth"));

            }
        }
        else if (this.AggregateClusterHealth != null && ec.Excludes("aggregateClusterHealth",false))
        {
            this.AggregateClusterHealth = null;
        }
        //      C# -> ClusterStatsAggregation? AggregateClusterStatistics
        // GraphQL -> aggregateClusterStatistics: ClusterStatsAggregation! (type)
        if (ec.Includes("aggregateClusterStatistics",false))
        {
            if(this.AggregateClusterStatistics == null) {

                this.AggregateClusterStatistics = new ClusterStatsAggregation();
                this.AggregateClusterStatistics.ApplyExploratoryFieldSpec(ec.NewChild("aggregateClusterStatistics"));

            } else {

                this.AggregateClusterStatistics.ApplyExploratoryFieldSpec(ec.NewChild("aggregateClusterStatistics"));

            }
        }
        else if (this.AggregateClusterStatistics != null && ec.Excludes("aggregateClusterStatistics",false))
        {
            this.AggregateClusterStatistics = null;
        }
        //      C# -> List<ClusterEdge>? Edges
        // GraphQL -> edges: [ClusterEdge!]! (type)
        if (ec.Includes("edges",false))
        {
            if(this.Edges == null) {

                this.Edges = new List<ClusterEdge>();
                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            } else {

                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            }
        }
        else if (this.Edges != null && ec.Excludes("edges",false))
        {
            this.Edges = null;
        }
        //      C# -> List<Cluster>? Nodes
        // GraphQL -> nodes: [Cluster!]! (type)
        if (ec.Includes("nodes",false))
        {
            if(this.Nodes == null) {

                this.Nodes = new List<Cluster>();
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterConnection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types