// SonarReport.cs
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
    #region SonarReport
    public class SonarReport: IFragment
    {
        #region members
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        [JsonProperty("groupByValue")]
        public System.String? GroupByValue { get; set; }

        //      C# -> List<TimeSeriesResult>? TimeSeriesResults
        // GraphQL -> timeSeriesResults: [TimeSeriesResult!]! (type)
        [JsonProperty("timeSeriesResults")]
        public List<TimeSeriesResult>? TimeSeriesResults { get; set; }

        #endregion

    #region methods

    public SonarReport Set(
        System.Int64? Count = null,
        System.String? GroupByValue = null,
        List<TimeSeriesResult>? TimeSeriesResults = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( GroupByValue != null ) {
            this.GroupByValue = GroupByValue;
        }
        if ( TimeSeriesResults != null ) {
            this.TimeSeriesResults = TimeSeriesResults;
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
            //      C# -> System.Int64? Count
            // GraphQL -> count: Long! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> System.String? GroupByValue
            // GraphQL -> groupByValue: String! (scalar)
            if (this.GroupByValue != null)
            {
                 s += ind + "groupByValue\n";

            }
            //      C# -> List<TimeSeriesResult>? TimeSeriesResults
            // GraphQL -> timeSeriesResults: [TimeSeriesResult!]! (type)
            if (this.TimeSeriesResults != null)
            {
                 s += ind + "timeSeriesResults\n";

                 s += ind + "{\n" + 
                 this.TimeSeriesResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? Count
            // GraphQL -> count: Long! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int64();
            }
            //      C# -> System.String? GroupByValue
            // GraphQL -> groupByValue: String! (scalar)
            if (this.GroupByValue == null && Exploration.Includes(parent + ".groupByValue$"))
            {
                this.GroupByValue = new System.String("FETCH");
            }
            //      C# -> List<TimeSeriesResult>? TimeSeriesResults
            // GraphQL -> timeSeriesResults: [TimeSeriesResult!]! (type)
            if (this.TimeSeriesResults == null && Exploration.Includes(parent + ".timeSeriesResults"))
            {
                this.TimeSeriesResults = new List<TimeSeriesResult>();
                this.TimeSeriesResults.ApplyExploratoryFragment(parent + ".timeSeriesResults");
            }
        }


    #endregion

    } // class SonarReport
    #endregion

    public static class ListSonarReportExtensions
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
            this List<SonarReport> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SonarReport> list, 
            String parent = "")
        {
            var item = new SonarReport();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types