// WorkloadGroupByPrimaryGroupByItem.cs
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
    #region WorkloadGroupByPrimaryGroupByItem
    public class WorkloadGroupByPrimaryGroupByItem: BaseType
    {
        #region members

        //      C# -> WorkloadGroupByAggregationData? AggregationData
        // GraphQL -> aggregationData: WorkloadGroupByAggregationData! (type)
        [JsonProperty("aggregationData")]
        public WorkloadGroupByAggregationData? AggregationData { get; set; }

        //      C# -> WorkloadGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: WorkloadGroupByInfo! (type)
        [JsonProperty("groupByInfo")]
        public WorkloadGroupByInfo? GroupByInfo { get; set; }

        //      C# -> List<WorkloadGroupBySecondaryGroupByItem>? SecondaryGroupBys
        // GraphQL -> secondaryGroupBys: [WorkloadGroupBySecondaryGroupByItem!]! (type)
        [JsonProperty("secondaryGroupBys")]
        public List<WorkloadGroupBySecondaryGroupByItem>? SecondaryGroupBys { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadGroupByPrimaryGroupByItem";
    }

    public WorkloadGroupByPrimaryGroupByItem Set(
        WorkloadGroupByAggregationData? AggregationData = null,
        WorkloadGroupByInfo? GroupByInfo = null,
        List<WorkloadGroupBySecondaryGroupByItem>? SecondaryGroupBys = null
    ) 
    {
        if ( AggregationData != null ) {
            this.AggregationData = AggregationData;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
        }
        if ( SecondaryGroupBys != null ) {
            this.SecondaryGroupBys = SecondaryGroupBys;
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
        //      C# -> WorkloadGroupByAggregationData? AggregationData
        // GraphQL -> aggregationData: WorkloadGroupByAggregationData! (type)
        if (this.AggregationData != null) {
            var fspec = this.AggregationData.AsFieldSpec(conf.Child("aggregationData"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "aggregationData" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> WorkloadGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: WorkloadGroupByInfo! (type)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(conf.Child("groupByInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupByInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<WorkloadGroupBySecondaryGroupByItem>? SecondaryGroupBys
        // GraphQL -> secondaryGroupBys: [WorkloadGroupBySecondaryGroupByItem!]! (type)
        if (this.SecondaryGroupBys != null) {
            var fspec = this.SecondaryGroupBys.AsFieldSpec(conf.Child("secondaryGroupBys"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secondaryGroupBys" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadGroupByAggregationData? AggregationData
        // GraphQL -> aggregationData: WorkloadGroupByAggregationData! (type)
        if (ec.Includes("aggregationData",false))
        {
            if(this.AggregationData == null) {

                this.AggregationData = new WorkloadGroupByAggregationData();
                this.AggregationData.ApplyExploratoryFieldSpec(ec.NewChild("aggregationData"));

            } else {

                this.AggregationData.ApplyExploratoryFieldSpec(ec.NewChild("aggregationData"));

            }
        }
        else if (this.AggregationData != null && ec.Excludes("aggregationData",false))
        {
            this.AggregationData = null;
        }
        //      C# -> WorkloadGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: WorkloadGroupByInfo! (type)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                this.GroupByInfo = new WorkloadGroupByInfo();
                this.GroupByInfo.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));

            } else {

                this.GroupByInfo.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
        //      C# -> List<WorkloadGroupBySecondaryGroupByItem>? SecondaryGroupBys
        // GraphQL -> secondaryGroupBys: [WorkloadGroupBySecondaryGroupByItem!]! (type)
        if (ec.Includes("secondaryGroupBys",false))
        {
            if(this.SecondaryGroupBys == null) {

                this.SecondaryGroupBys = new List<WorkloadGroupBySecondaryGroupByItem>();
                this.SecondaryGroupBys.ApplyExploratoryFieldSpec(ec.NewChild("secondaryGroupBys"));

            } else {

                this.SecondaryGroupBys.ApplyExploratoryFieldSpec(ec.NewChild("secondaryGroupBys"));

            }
        }
        else if (this.SecondaryGroupBys != null && ec.Excludes("secondaryGroupBys",false))
        {
            this.SecondaryGroupBys = null;
        }
    }


    #endregion

    } // class WorkloadGroupByPrimaryGroupByItem
    
    #endregion

    public static class ListWorkloadGroupByPrimaryGroupByItemExtensions
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
            this List<WorkloadGroupByPrimaryGroupByItem> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadGroupByPrimaryGroupByItem> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadGroupByPrimaryGroupByItem> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadGroupByPrimaryGroupByItem());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadGroupByPrimaryGroupByItem> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types