// WorkloadAnomalyConnection.cs
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
    #region WorkloadAnomalyConnection
    public class WorkloadAnomalyConnection: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> AggregatedValues? Aggregation
        // GraphQL -> aggregation: AggregatedValues! (type)
        [JsonProperty("aggregation")]
        public AggregatedValues? Aggregation { get; set; }

        //      C# -> List<WorkloadAnomalyEdge>? Edges
        // GraphQL -> edges: [WorkloadAnomalyEdge!]! (type)
        [JsonProperty("edges")]
        public List<WorkloadAnomalyEdge>? Edges { get; set; }

        //      C# -> List<WorkloadAnomaly>? Nodes
        // GraphQL -> nodes: [WorkloadAnomaly!]! (type)
        [JsonProperty("nodes")]
        public List<WorkloadAnomaly>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadAnomalyConnection";
    }

    public WorkloadAnomalyConnection Set(
        System.Int32? Count = null,
        AggregatedValues? Aggregation = null,
        List<WorkloadAnomalyEdge>? Edges = null,
        List<WorkloadAnomaly>? Nodes = null,
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        //      C# -> AggregatedValues? Aggregation
        // GraphQL -> aggregation: AggregatedValues! (type)
        if (this.Aggregation != null) {
            var fspec = this.Aggregation.AsFieldSpec(conf.Child("aggregation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "aggregation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<WorkloadAnomalyEdge>? Edges
        // GraphQL -> edges: [WorkloadAnomalyEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(conf.Child("edges"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "edges" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<WorkloadAnomaly>? Nodes
        // GraphQL -> nodes: [WorkloadAnomaly!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(conf.Child("nodes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
        //      C# -> AggregatedValues? Aggregation
        // GraphQL -> aggregation: AggregatedValues! (type)
        if (ec.Includes("aggregation",false))
        {
            if(this.Aggregation == null) {

                this.Aggregation = new AggregatedValues();
                this.Aggregation.ApplyExploratoryFieldSpec(ec.NewChild("aggregation"));

            } else {

                this.Aggregation.ApplyExploratoryFieldSpec(ec.NewChild("aggregation"));

            }
        }
        else if (this.Aggregation != null && ec.Excludes("aggregation",false))
        {
            this.Aggregation = null;
        }
        //      C# -> List<WorkloadAnomalyEdge>? Edges
        // GraphQL -> edges: [WorkloadAnomalyEdge!]! (type)
        if (ec.Includes("edges",false))
        {
            if(this.Edges == null) {

                this.Edges = new List<WorkloadAnomalyEdge>();
                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            } else {

                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            }
        }
        else if (this.Edges != null && ec.Excludes("edges",false))
        {
            this.Edges = null;
        }
        //      C# -> List<WorkloadAnomaly>? Nodes
        // GraphQL -> nodes: [WorkloadAnomaly!]! (type)
        if (ec.Includes("nodes",false))
        {
            if(this.Nodes == null) {

                this.Nodes = new List<WorkloadAnomaly>();
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

    } // class WorkloadAnomalyConnection
    
    #endregion

    public static class ListWorkloadAnomalyConnectionExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<WorkloadAnomalyConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadAnomalyConnection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadAnomalyConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadAnomalyConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadAnomalyConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types