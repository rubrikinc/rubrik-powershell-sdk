// GetDashboardSummaryReply.cs
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
    #region GetDashboardSummaryReply
    public class GetDashboardSummaryReply: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (this.AnalyzerResults != null) {
            var fspec = this.AnalyzerResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzerResults {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AnalyzerGroupResult>? PolicyResults
        // GraphQL -> policyResults: [AnalyzerGroupResult!]! (type)
        if (this.PolicyResults != null) {
            var fspec = this.PolicyResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policyResults {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (this.AnalyzerResults == null && Exploration.Includes(parent + ".analyzerResults"))
        {
            this.AnalyzerResults = new List<AnalyzerResult>();
            this.AnalyzerResults.ApplyExploratoryFieldSpec(parent + ".analyzerResults");
        }
        //      C# -> List<AnalyzerGroupResult>? PolicyResults
        // GraphQL -> policyResults: [AnalyzerGroupResult!]! (type)
        if (this.PolicyResults == null && Exploration.Includes(parent + ".policyResults"))
        {
            this.PolicyResults = new List<AnalyzerGroupResult>();
            this.PolicyResults.ApplyExploratoryFieldSpec(parent + ".policyResults");
        }
    }


    #endregion

    } // class GetDashboardSummaryReply
    
    #endregion

    public static class ListGetDashboardSummaryReplyExtensions
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
            this List<GetDashboardSummaryReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetDashboardSummaryReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetDashboardSummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types