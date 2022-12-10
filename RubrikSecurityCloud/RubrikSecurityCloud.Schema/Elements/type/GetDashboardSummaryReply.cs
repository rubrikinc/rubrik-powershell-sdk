// GetDashboardSummaryReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:30.
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
    #region GetDashboardSummaryReply
    public class GetDashboardSummaryReply: IFragment
    {
        #region members
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        [JsonProperty("analyzerResults")]
        public List<AnalyzerResult>? AnalyzerResults { get; set; }

        //      C# -> List<AnalyzerGroupResult>? PolicyResults
        // GraphQL -> policyResults: [AnalyzerGroupResult!]! (type)
        [JsonProperty("policyResults")]
        public List<AnalyzerGroupResult>? PolicyResults { get; set; }

        #endregion

    #region methods

    public GetDashboardSummaryReply Set(
        List<AnalyzerResult>? AnalyzerResults = null,
        List<AnalyzerGroupResult>? PolicyResults = null
    ) 
    {
        if ( AnalyzerResults != null ) {
            this.AnalyzerResults = AnalyzerResults;
        }
        if ( PolicyResults != null ) {
            this.PolicyResults = PolicyResults;
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
            //      C# -> List<AnalyzerResult>? AnalyzerResults
            // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
            if (this.AnalyzerResults != null)
            {
                 s += ind + "analyzerResults\n";

                 s += ind + "{\n" + 
                 this.AnalyzerResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AnalyzerGroupResult>? PolicyResults
            // GraphQL -> policyResults: [AnalyzerGroupResult!]! (type)
            if (this.PolicyResults != null)
            {
                 s += ind + "policyResults\n";

                 s += ind + "{\n" + 
                 this.PolicyResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<AnalyzerResult>? AnalyzerResults
            // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
            if (this.AnalyzerResults == null && Exploration.Includes(parent + ".analyzerResults"))
            {
                this.AnalyzerResults = new List<AnalyzerResult>();
                this.AnalyzerResults.ApplyExploratoryFragment(parent + ".analyzerResults");
            }
            //      C# -> List<AnalyzerGroupResult>? PolicyResults
            // GraphQL -> policyResults: [AnalyzerGroupResult!]! (type)
            if (this.PolicyResults == null && Exploration.Includes(parent + ".policyResults"))
            {
                this.PolicyResults = new List<AnalyzerGroupResult>();
                this.PolicyResults.ApplyExploratoryFragment(parent + ".policyResults");
            }
        }


    #endregion

    } // class GetDashboardSummaryReply
    #endregion

    public static class ListGetDashboardSummaryReplyExtensions
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
            this List<GetDashboardSummaryReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetDashboardSummaryReply> list, 
            String parent = "")
        {
            var item = new GetDashboardSummaryReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types