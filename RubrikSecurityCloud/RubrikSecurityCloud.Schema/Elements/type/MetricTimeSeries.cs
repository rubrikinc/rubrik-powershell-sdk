// MetricTimeSeries.cs
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
    #region MetricTimeSeries
    public class MetricTimeSeries: BaseType
    {
        #region members

        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric! (type)
        [JsonProperty("metric")]
        public ClusterMetric? Metric { get; set; }

        //      C# -> ClusterMetricGroupByInfo? TimeInfo
        // GraphQL -> timeInfo: ClusterMetricGroupByInfo! (union)
        [JsonProperty("timeInfo")]
        public ClusterMetricGroupByInfo? TimeInfo { get; set; }


        #endregion

    #region methods

    public MetricTimeSeries Set(
        ClusterMetric? Metric = null,
        ClusterMetricGroupByInfo? TimeInfo = null
    ) 
    {
        if ( Metric != null ) {
            this.Metric = Metric;
        }
        if ( TimeInfo != null ) {
            this.TimeInfo = TimeInfo;
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
        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric! (type)
        if (this.Metric != null) {
            s += ind + "metric {\n" + this.Metric.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ClusterMetricGroupByInfo? TimeInfo
        // GraphQL -> timeInfo: ClusterMetricGroupByInfo! (union)
        if (this.TimeInfo != null) {
            s += ind + "timeInfo {\n" + this.TimeInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric! (type)
        if (this.Metric == null && Exploration.Includes(parent + ".metric"))
        {
            this.Metric = new ClusterMetric();
            this.Metric.ApplyExploratoryFieldSpec(parent + ".metric");
        }
        //      C# -> ClusterMetricGroupByInfo? TimeInfo
        // GraphQL -> timeInfo: ClusterMetricGroupByInfo! (union)
        if (this.TimeInfo == null && Exploration.Includes(parent + ".timeInfo"))
        {
            var impls = new List<ClusterMetricGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".timeInfo");
            this.TimeInfo = (ClusterMetricGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class MetricTimeSeries
    
    #endregion

    public static class ListMetricTimeSeriesExtensions
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
            this List<MetricTimeSeries> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MetricTimeSeries> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MetricTimeSeries());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types