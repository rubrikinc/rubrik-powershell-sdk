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

    public override string GetGqlTypeName() {
        return "OverallRansomwareInvestigationSummary";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? AnalysisFailureCount
        // GraphQL -> analysisFailureCount: Long! (scalar)
        if (this.AnalysisFailureCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analysisFailureCount\n" ;
            } else {
                s += ind + "analysisFailureCount\n" ;
            }
        }
        //      C# -> System.Int64? AnalysisSuccessCount
        // GraphQL -> analysisSuccessCount: Long! (scalar)
        if (this.AnalysisSuccessCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analysisSuccessCount\n" ;
            } else {
                s += ind + "analysisSuccessCount\n" ;
            }
        }
        //      C# -> System.Int64? AnomaliesCount
        // GraphQL -> anomaliesCount: Long! (scalar)
        if (this.AnomaliesCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomaliesCount\n" ;
            } else {
                s += ind + "anomaliesCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? AnalysisFailureCount
        // GraphQL -> analysisFailureCount: Long! (scalar)
        if (ec.Includes("analysisFailureCount",true))
        {
            if(this.AnalysisFailureCount == null) {

                this.AnalysisFailureCount = new System.Int64();

            } else {


            }
        }
        else if (this.AnalysisFailureCount != null && ec.Excludes("analysisFailureCount",true))
        {
            this.AnalysisFailureCount = null;
        }
        //      C# -> System.Int64? AnalysisSuccessCount
        // GraphQL -> analysisSuccessCount: Long! (scalar)
        if (ec.Includes("analysisSuccessCount",true))
        {
            if(this.AnalysisSuccessCount == null) {

                this.AnalysisSuccessCount = new System.Int64();

            } else {


            }
        }
        else if (this.AnalysisSuccessCount != null && ec.Excludes("analysisSuccessCount",true))
        {
            this.AnalysisSuccessCount = null;
        }
        //      C# -> System.Int64? AnomaliesCount
        // GraphQL -> anomaliesCount: Long! (scalar)
        if (ec.Includes("anomaliesCount",true))
        {
            if(this.AnomaliesCount == null) {

                this.AnomaliesCount = new System.Int64();

            } else {


            }
        }
        else if (this.AnomaliesCount != null && ec.Excludes("anomaliesCount",true))
        {
            this.AnomaliesCount = null;
        }
    }


    #endregion

    } // class OverallRansomwareInvestigationSummary
    
    #endregion

    public static class ListOverallRansomwareInvestigationSummaryExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<OverallRansomwareInvestigationSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OverallRansomwareInvestigationSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OverallRansomwareInvestigationSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OverallRansomwareInvestigationSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OverallRansomwareInvestigationSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types