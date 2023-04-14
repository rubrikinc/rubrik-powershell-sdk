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

namespace Rubrik.SecurityCloud.Types
{
    #region MetricTimeSeries
    public class MetricTimeSeries: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> ClusterMetric? Metric
            // GraphQL -> metric: ClusterMetric! (type)
            if (this.Metric != null)
            {
                 s += ind + "metric\n";

                 s += ind + "{\n" + 
                 this.Metric.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClusterMetricGroupByInfo? TimeInfo
            // GraphQL -> timeInfo: ClusterMetricGroupByInfo! (union)
            if (this.TimeInfo != null)
            {
                 s += ind + "timeInfo\n";

                 s += ind + "{\n" + 
                 this.TimeInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> ClusterMetric? Metric
            // GraphQL -> metric: ClusterMetric! (type)
            if (this.Metric == null && Exploration.Includes(parent + ".metric"))
            {
                this.Metric = new ClusterMetric();
                this.Metric.ApplyExploratoryFragment(parent + ".metric");
            }
            //      C# -> ClusterMetricGroupByInfo? TimeInfo
            // GraphQL -> timeInfo: ClusterMetricGroupByInfo! (union)
            if (this.TimeInfo == null && Exploration.Includes(parent + ".timeInfo"))
            {
                this.TimeInfo = (ClusterMetricGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(ClusterMetricGroupByInfo));
                this.TimeInfo.ApplyExploratoryFragment(parent + ".timeInfo");
            }
        }


    #endregion

    } // class MetricTimeSeries
    #endregion

    public static class ListMetricTimeSeriesExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<MetricTimeSeries> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MetricTimeSeries> list, 
            String parent = "")
        {
            var item = new MetricTimeSeries();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types