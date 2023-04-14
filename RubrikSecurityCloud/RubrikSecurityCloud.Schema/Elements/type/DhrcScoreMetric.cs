// DhrcScoreMetric.cs
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
    #region DhrcScoreMetric
    public class DhrcScoreMetric: IFragment
    {
        #region members
        //      C# -> System.Single? Impact
        // GraphQL -> impact: Float! (scalar)
        [JsonProperty("impact")]
        public System.Single? Impact { get; set; }

        //      C# -> System.Single? MaxValue
        // GraphQL -> maxValue: Float! (scalar)
        [JsonProperty("maxValue")]
        public System.Single? MaxValue { get; set; }

        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        [JsonProperty("value")]
        public System.Single? Value { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }

        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        [JsonProperty("weight")]
        public System.Single? Weight { get; set; }

        //      C# -> DhrcMetric? Metric
        // GraphQL -> metric: DhrcMetric! (enum)
        [JsonProperty("metric")]
        public DhrcMetric? Metric { get; set; }

        #endregion

    #region methods

    public DhrcScoreMetric Set(
        System.Single? Impact = null,
        System.Single? MaxValue = null,
        System.Single? Value = null,
        System.Int32? Version = null,
        System.Single? Weight = null,
        DhrcMetric? Metric = null
    ) 
    {
        if ( Impact != null ) {
            this.Impact = Impact;
        }
        if ( MaxValue != null ) {
            this.MaxValue = MaxValue;
        }
        if ( Value != null ) {
            this.Value = Value;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Weight != null ) {
            this.Weight = Weight;
        }
        if ( Metric != null ) {
            this.Metric = Metric;
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
            //      C# -> System.Single? Impact
            // GraphQL -> impact: Float! (scalar)
            if (this.Impact != null)
            {
                 s += ind + "impact\n";

            }
            //      C# -> System.Single? MaxValue
            // GraphQL -> maxValue: Float! (scalar)
            if (this.MaxValue != null)
            {
                 s += ind + "maxValue\n";

            }
            //      C# -> System.Single? Value
            // GraphQL -> value: Float! (scalar)
            if (this.Value != null)
            {
                 s += ind + "value\n";

            }
            //      C# -> System.Int32? Version
            // GraphQL -> version: Int! (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> System.Single? Weight
            // GraphQL -> weight: Float! (scalar)
            if (this.Weight != null)
            {
                 s += ind + "weight\n";

            }
            //      C# -> DhrcMetric? Metric
            // GraphQL -> metric: DhrcMetric! (enum)
            if (this.Metric != null)
            {
                 s += ind + "metric\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Single? Impact
            // GraphQL -> impact: Float! (scalar)
            if (this.Impact == null && Exploration.Includes(parent + ".impact$"))
            {
                this.Impact = new System.Single();
            }
            //      C# -> System.Single? MaxValue
            // GraphQL -> maxValue: Float! (scalar)
            if (this.MaxValue == null && Exploration.Includes(parent + ".maxValue$"))
            {
                this.MaxValue = new System.Single();
            }
            //      C# -> System.Single? Value
            // GraphQL -> value: Float! (scalar)
            if (this.Value == null && Exploration.Includes(parent + ".value$"))
            {
                this.Value = new System.Single();
            }
            //      C# -> System.Int32? Version
            // GraphQL -> version: Int! (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.Int32();
            }
            //      C# -> System.Single? Weight
            // GraphQL -> weight: Float! (scalar)
            if (this.Weight == null && Exploration.Includes(parent + ".weight$"))
            {
                this.Weight = new System.Single();
            }
            //      C# -> DhrcMetric? Metric
            // GraphQL -> metric: DhrcMetric! (enum)
            if (this.Metric == null && Exploration.Includes(parent + ".metric$"))
            {
                this.Metric = new DhrcMetric();
            }
        }


    #endregion

    } // class DhrcScoreMetric
    #endregion

    public static class ListDhrcScoreMetricExtensions
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
            this List<DhrcScoreMetric> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DhrcScoreMetric> list, 
            String parent = "")
        {
            var item = new DhrcScoreMetric();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types