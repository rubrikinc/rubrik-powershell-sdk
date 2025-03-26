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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "analyzerResults" + " " + "{\n" + fspec + ind + "}\n" ;
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
                    s += ind + "policyResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<GetDashboardSummaryReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetDashboardSummaryReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetDashboardSummaryReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetDashboardSummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetDashboardSummaryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types