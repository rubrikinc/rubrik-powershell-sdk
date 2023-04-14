// RcsArchivalLocationStatsRecord.cs
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
    #region RcsArchivalLocationStatsRecord
    public class RcsArchivalLocationStatsRecord: IFragment
    {
        #region members
        //      C# -> System.Single? MetricValue
        // GraphQL -> metricValue: Float! (scalar)
        [JsonProperty("metricValue")]
        public System.Single? MetricValue { get; set; }

        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        [JsonProperty("timestamp")]
        public System.String? Timestamp { get; set; }

        //      C# -> RcsConsumptionMetricOutputNameType? MetricName
        // GraphQL -> metricName: RcsConsumptionMetricOutputNameType! (enum)
        [JsonProperty("metricName")]
        public RcsConsumptionMetricOutputNameType? MetricName { get; set; }

        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        [JsonProperty("tier")]
        public RcsTierEnumType? Tier { get; set; }

        #endregion

    #region methods

    public RcsArchivalLocationStatsRecord Set(
        System.Single? MetricValue = null,
        System.String? Timestamp = null,
        RcsConsumptionMetricOutputNameType? MetricName = null,
        RcsTierEnumType? Tier = null
    ) 
    {
        if ( MetricValue != null ) {
            this.MetricValue = MetricValue;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( MetricName != null ) {
            this.MetricName = MetricName;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
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
            //      C# -> System.Single? MetricValue
            // GraphQL -> metricValue: Float! (scalar)
            if (this.MetricValue != null)
            {
                 s += ind + "metricValue\n";

            }
            //      C# -> System.String? Timestamp
            // GraphQL -> timestamp: String! (scalar)
            if (this.Timestamp != null)
            {
                 s += ind + "timestamp\n";

            }
            //      C# -> RcsConsumptionMetricOutputNameType? MetricName
            // GraphQL -> metricName: RcsConsumptionMetricOutputNameType! (enum)
            if (this.MetricName != null)
            {
                 s += ind + "metricName\n";

            }
            //      C# -> RcsTierEnumType? Tier
            // GraphQL -> tier: RcsTierEnumType! (enum)
            if (this.Tier != null)
            {
                 s += ind + "tier\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Single? MetricValue
            // GraphQL -> metricValue: Float! (scalar)
            if (this.MetricValue == null && Exploration.Includes(parent + ".metricValue$"))
            {
                this.MetricValue = new System.Single();
            }
            //      C# -> System.String? Timestamp
            // GraphQL -> timestamp: String! (scalar)
            if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp$"))
            {
                this.Timestamp = new System.String("FETCH");
            }
            //      C# -> RcsConsumptionMetricOutputNameType? MetricName
            // GraphQL -> metricName: RcsConsumptionMetricOutputNameType! (enum)
            if (this.MetricName == null && Exploration.Includes(parent + ".metricName$"))
            {
                this.MetricName = new RcsConsumptionMetricOutputNameType();
            }
            //      C# -> RcsTierEnumType? Tier
            // GraphQL -> tier: RcsTierEnumType! (enum)
            if (this.Tier == null && Exploration.Includes(parent + ".tier$"))
            {
                this.Tier = new RcsTierEnumType();
            }
        }


    #endregion

    } // class RcsArchivalLocationStatsRecord
    #endregion

    public static class ListRcsArchivalLocationStatsRecordExtensions
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
            this List<RcsArchivalLocationStatsRecord> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RcsArchivalLocationStatsRecord> list, 
            String parent = "")
        {
            var item = new RcsArchivalLocationStatsRecord();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types