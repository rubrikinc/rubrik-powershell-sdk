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

    public override string GetGqlTypeName() {
        return "GetDashboardSummaryReply";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (this.AnalyzerResults != null) {
            var fspec = this.AnalyzerResults.AsFieldSpec(conf.Child("analyzerResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerResults {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AnalyzerGroupResult>? PolicyResults
        // GraphQL -> policyResults: [AnalyzerGroupResult!]! (type)
        if (this.PolicyResults != null) {
            var fspec = this.PolicyResults.AsFieldSpec(conf.Child("policyResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policyResults {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (ec.Includes("analyzerResults",false))
        {
            if(this.AnalyzerResults == null) {

                this.AnalyzerResults = new List<AnalyzerResult>();
                this.AnalyzerResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerResults"));

            } else {

                this.AnalyzerResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerResults"));

            }
        }
        else if (this.AnalyzerResults != null && ec.Excludes("analyzerResults",false))
        {
            this.AnalyzerResults = null;
        }
        //      C# -> List<AnalyzerGroupResult>? PolicyResults
        // GraphQL -> policyResults: [AnalyzerGroupResult!]! (type)
        if (ec.Includes("policyResults",false))
        {
            if(this.PolicyResults == null) {

                this.PolicyResults = new List<AnalyzerGroupResult>();
                this.PolicyResults.ApplyExploratoryFieldSpec(ec.NewChild("policyResults"));

            } else {

                this.PolicyResults.ApplyExploratoryFieldSpec(ec.NewChild("policyResults"));

            }
        }
        else if (this.PolicyResults != null && ec.Excludes("policyResults",false))
        {
            this.PolicyResults = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GetDashboardSummaryReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetDashboardSummaryReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetDashboardSummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetDashboardSummaryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types