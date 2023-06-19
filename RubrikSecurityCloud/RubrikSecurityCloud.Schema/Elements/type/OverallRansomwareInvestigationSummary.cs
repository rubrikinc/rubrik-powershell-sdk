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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region OverallRansomwareInvestigationSummary
    public class OverallRansomwareInvestigationSummary: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? AnalysisFailureCount
        // GraphQL -> analysisFailureCount: Long! (scalar)
        if (this.AnalysisFailureCount != null) {
            s += ind + "analysisFailureCount\n" ;
        }
        //      C# -> System.Int64? AnalysisSuccessCount
        // GraphQL -> analysisSuccessCount: Long! (scalar)
        if (this.AnalysisSuccessCount != null) {
            s += ind + "analysisSuccessCount\n" ;
        }
        //      C# -> System.Int64? AnomaliesCount
        // GraphQL -> anomaliesCount: Long! (scalar)
        if (this.AnomaliesCount != null) {
            s += ind + "anomaliesCount\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? AnalysisFailureCount
        // GraphQL -> analysisFailureCount: Long! (scalar)
        if (this.AnalysisFailureCount == null && Exploration.Includes(parent + ".analysisFailureCount", true))
        {
            this.AnalysisFailureCount = new System.Int64();
        }
        //      C# -> System.Int64? AnalysisSuccessCount
        // GraphQL -> analysisSuccessCount: Long! (scalar)
        if (this.AnalysisSuccessCount == null && Exploration.Includes(parent + ".analysisSuccessCount", true))
        {
            this.AnalysisSuccessCount = new System.Int64();
        }
        //      C# -> System.Int64? AnomaliesCount
        // GraphQL -> anomaliesCount: Long! (scalar)
        if (this.AnomaliesCount == null && Exploration.Includes(parent + ".anomaliesCount", true))
        {
            this.AnomaliesCount = new System.Int64();
        }
    }


    #endregion

    } // class OverallRansomwareInvestigationSummary
    
    #endregion

    public static class ListOverallRansomwareInvestigationSummaryExtensions
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
            this List<OverallRansomwareInvestigationSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OverallRansomwareInvestigationSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OverallRansomwareInvestigationSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types