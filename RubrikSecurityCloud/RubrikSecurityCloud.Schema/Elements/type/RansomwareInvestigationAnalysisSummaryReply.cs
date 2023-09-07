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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<DailyAnalysisDetails>? AnalysisDetails
        // GraphQL -> analysisDetails: [DailyAnalysisDetails!]! (type)
        if (this.AnalysisDetails != null) {
            var fspec = this.AnalysisDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analysisDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<DailyAnalysisDetails>? AnalysisDetails
        // GraphQL -> analysisDetails: [DailyAnalysisDetails!]! (type)
        if (this.AnalysisDetails == null && ec.Includes("analysisDetails",false))
        {
            this.AnalysisDetails = new List<DailyAnalysisDetails>();
            this.AnalysisDetails.ApplyExploratoryFieldSpec(ec.NewChild("analysisDetails"));
        }
    }


    #endregion

    } // class RansomwareInvestigationAnalysisSummaryReply
    
    #endregion

    public static class ListRansomwareInvestigationAnalysisSummaryReplyExtensions
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
            this List<RansomwareInvestigationAnalysisSummaryReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<RansomwareInvestigationAnalysisSummaryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types