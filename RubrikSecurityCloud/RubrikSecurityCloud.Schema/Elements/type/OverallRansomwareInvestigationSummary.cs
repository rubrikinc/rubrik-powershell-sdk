// OverallRansomwareInvestigationSummary.cs
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
    #region OverallRansomwareInvestigationSummary
    public class OverallRansomwareInvestigationSummary: IFragment
    {
        #region members
        //      C# -> System.Int64? AnalysisFailureCount
        // GraphQL -> analysisFailureCount: Long! (scalar)
        [JsonProperty("analysisFailureCount")]
        public System.Int64? AnalysisFailureCount { get; set; }

        //      C# -> System.Int64? AnalysisSuccessCount
        // GraphQL -> analysisSuccessCount: Long! (scalar)
        [JsonProperty("analysisSuccessCount")]
        public System.Int64? AnalysisSuccessCount { get; set; }

        //      C# -> System.Int64? AnomaliesCount
        // GraphQL -> anomaliesCount: Long! (scalar)
        [JsonProperty("anomaliesCount")]
        public System.Int64? AnomaliesCount { get; set; }

        #endregion

    #region methods

    public OverallRansomwareInvestigationSummary Set(
        System.Int64? AnalysisFailureCount = null,
        System.Int64? AnalysisSuccessCount = null,
        System.Int64? AnomaliesCount = null
    ) 
    {
        if ( AnalysisFailureCount != null ) {
            this.AnalysisFailureCount = AnalysisFailureCount;
        }
        if ( AnalysisSuccessCount != null ) {
            this.AnalysisSuccessCount = AnalysisSuccessCount;
        }
        if ( AnomaliesCount != null ) {
            this.AnomaliesCount = AnomaliesCount;
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
            //      C# -> System.Int64? AnalysisFailureCount
            // GraphQL -> analysisFailureCount: Long! (scalar)
            if (this.AnalysisFailureCount != null)
            {
                 s += ind + "analysisFailureCount\n";

            }
            //      C# -> System.Int64? AnalysisSuccessCount
            // GraphQL -> analysisSuccessCount: Long! (scalar)
            if (this.AnalysisSuccessCount != null)
            {
                 s += ind + "analysisSuccessCount\n";

            }
            //      C# -> System.Int64? AnomaliesCount
            // GraphQL -> anomaliesCount: Long! (scalar)
            if (this.AnomaliesCount != null)
            {
                 s += ind + "anomaliesCount\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? AnalysisFailureCount
            // GraphQL -> analysisFailureCount: Long! (scalar)
            if (this.AnalysisFailureCount == null && Exploration.Includes(parent + ".analysisFailureCount$"))
            {
                this.AnalysisFailureCount = new System.Int64();
            }
            //      C# -> System.Int64? AnalysisSuccessCount
            // GraphQL -> analysisSuccessCount: Long! (scalar)
            if (this.AnalysisSuccessCount == null && Exploration.Includes(parent + ".analysisSuccessCount$"))
            {
                this.AnalysisSuccessCount = new System.Int64();
            }
            //      C# -> System.Int64? AnomaliesCount
            // GraphQL -> anomaliesCount: Long! (scalar)
            if (this.AnomaliesCount == null && Exploration.Includes(parent + ".anomaliesCount$"))
            {
                this.AnomaliesCount = new System.Int64();
            }
        }


    #endregion

    } // class OverallRansomwareInvestigationSummary
    #endregion

    public static class ListOverallRansomwareInvestigationSummaryExtensions
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
            this List<OverallRansomwareInvestigationSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OverallRansomwareInvestigationSummary> list, 
            String parent = "")
        {
            var item = new OverallRansomwareInvestigationSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types