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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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