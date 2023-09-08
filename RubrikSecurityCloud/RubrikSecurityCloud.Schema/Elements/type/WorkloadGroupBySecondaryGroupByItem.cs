// WorkloadGroupBySecondaryGroupByItem.cs
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
    #region WorkloadGroupBySecondaryGroupByItem
    public class WorkloadGroupBySecondaryGroupByItem: BaseType
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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadGroupBySecondaryGroupByItem";
    }

    public WorkloadGroupBySecondaryGroupByItem Set(
        WorkloadGroupByAggregationData? AggregationData = null,
        WorkloadGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( AggregationData != null ) {
            this.AggregationData = AggregationData;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
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
        //      C# -> WorkloadGroupByAggregationData? AggregationData
        // GraphQL -> aggregationData: WorkloadGroupByAggregationData! (type)
        if (this.AggregationData != null) {
            var fspec = this.AggregationData.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "aggregationData {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> WorkloadGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: WorkloadGroupByInfo! (type)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadGroupByAggregationData? AggregationData
        // GraphQL -> aggregationData: WorkloadGroupByAggregationData! (type)
        if (this.AggregationData == null && ec.Includes("aggregationData",false))
        {
            this.AggregationData = new WorkloadGroupByAggregationData();
            this.AggregationData.ApplyExploratoryFieldSpec(ec.NewChild("aggregationData"));
        }
        //      C# -> WorkloadGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: WorkloadGroupByInfo! (type)
        if (this.GroupByInfo == null && ec.Includes("groupByInfo",false))
        {
            this.GroupByInfo = new WorkloadGroupByInfo();
            this.GroupByInfo.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
        }
    }


    #endregion

    } // class WorkloadGroupBySecondaryGroupByItem
    
    #endregion

    public static class ListWorkloadGroupBySecondaryGroupByItemExtensions
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
            this List<WorkloadGroupBySecondaryGroupByItem> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadGroupBySecondaryGroupByItem> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadGroupBySecondaryGroupByItem());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<WorkloadGroupBySecondaryGroupByItem> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types