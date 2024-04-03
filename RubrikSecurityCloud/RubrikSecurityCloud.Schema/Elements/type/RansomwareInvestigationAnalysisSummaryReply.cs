// RansomwareInvestigationAnalysisSummaryReply.cs
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
    #region RansomwareInvestigationAnalysisSummaryReply
    public class RansomwareInvestigationAnalysisSummaryReply: BaseType
    {
        #region members

        //      C# -> List<DailyAnalysisDetails>? AnalysisDetails
        // GraphQL -> analysisDetails: [DailyAnalysisDetails!]! (type)
        [JsonProperty("analysisDetails")]
        public List<DailyAnalysisDetails>? AnalysisDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RansomwareInvestigationAnalysisSummaryReply";
    }

    public RansomwareInvestigationAnalysisSummaryReply Set(
        List<DailyAnalysisDetails>? AnalysisDetails = null
    ) 
    {
        if ( AnalysisDetails != null ) {
            this.AnalysisDetails = AnalysisDetails;
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
        //      C# -> List<DailyAnalysisDetails>? AnalysisDetails
        // GraphQL -> analysisDetails: [DailyAnalysisDetails!]! (type)
        if (this.AnalysisDetails != null) {
            var fspec = this.AnalysisDetails.AsFieldSpec(conf.Child("analysisDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analysisDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<DailyAnalysisDetails>? AnalysisDetails
        // GraphQL -> analysisDetails: [DailyAnalysisDetails!]! (type)
        if (ec.Includes("analysisDetails",false))
        {
            if(this.AnalysisDetails == null) {

                this.AnalysisDetails = new List<DailyAnalysisDetails>();
                this.AnalysisDetails.ApplyExploratoryFieldSpec(ec.NewChild("analysisDetails"));

            } else {

                this.AnalysisDetails.ApplyExploratoryFieldSpec(ec.NewChild("analysisDetails"));

            }
        }
        else if (this.AnalysisDetails != null && ec.Excludes("analysisDetails",false))
        {
            this.AnalysisDetails = null;
        }
    }


    #endregion

    } // class RansomwareInvestigationAnalysisSummaryReply
    
    #endregion

    public static class ListRansomwareInvestigationAnalysisSummaryReplyExtensions
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
            this List<RansomwareInvestigationAnalysisSummaryReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RansomwareInvestigationAnalysisSummaryReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareInvestigationAnalysisSummaryReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareInvestigationAnalysisSummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RansomwareInvestigationAnalysisSummaryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types