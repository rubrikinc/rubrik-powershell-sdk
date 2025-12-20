// GetRecoveryAnalysisResultResp.cs
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
    #region GetRecoveryAnalysisResultResp
    public class GetRecoveryAnalysisResultResp: BaseType
    {
        #region members

        //      C# -> RecoveryAnalysisMetadata? Metadata
        // GraphQL -> metadata: RecoveryAnalysisMetadata (type)
        [JsonProperty("metadata")]
        public RecoveryAnalysisMetadata? Metadata { get; set; }

        //      C# -> RecoveryAnalysisSummary? Summary
        // GraphQL -> summary: RecoveryAnalysisSummary (type)
        [JsonProperty("summary")]
        public RecoveryAnalysisSummary? Summary { get; set; }

        //      C# -> List<UserRecoveryAnalysis>? UserAnalyses
        // GraphQL -> userAnalyses: [UserRecoveryAnalysis!]! (type)
        [JsonProperty("userAnalyses")]
        public List<UserRecoveryAnalysis>? UserAnalyses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetRecoveryAnalysisResultResp";
    }

    public GetRecoveryAnalysisResultResp Set(
        RecoveryAnalysisMetadata? Metadata = null,
        RecoveryAnalysisSummary? Summary = null,
        List<UserRecoveryAnalysis>? UserAnalyses = null
    ) 
    {
        if ( Metadata != null ) {
            this.Metadata = Metadata;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
        }
        if ( UserAnalyses != null ) {
            this.UserAnalyses = UserAnalyses;
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
        //      C# -> RecoveryAnalysisMetadata? Metadata
        // GraphQL -> metadata: RecoveryAnalysisMetadata (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(conf.Child("metadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryAnalysisSummary? Summary
        // GraphQL -> summary: RecoveryAnalysisSummary (type)
        if (this.Summary != null) {
            var fspec = this.Summary.AsFieldSpec(conf.Child("summary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "summary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<UserRecoveryAnalysis>? UserAnalyses
        // GraphQL -> userAnalyses: [UserRecoveryAnalysis!]! (type)
        if (this.UserAnalyses != null) {
            var fspec = this.UserAnalyses.AsFieldSpec(conf.Child("userAnalyses"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "userAnalyses" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryAnalysisMetadata? Metadata
        // GraphQL -> metadata: RecoveryAnalysisMetadata (type)
        if (ec.Includes("metadata",false))
        {
            if(this.Metadata == null) {

                this.Metadata = new RecoveryAnalysisMetadata();
                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            } else {

                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",false))
        {
            this.Metadata = null;
        }
        //      C# -> RecoveryAnalysisSummary? Summary
        // GraphQL -> summary: RecoveryAnalysisSummary (type)
        if (ec.Includes("summary",false))
        {
            if(this.Summary == null) {

                this.Summary = new RecoveryAnalysisSummary();
                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            } else {

                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            }
        }
        else if (this.Summary != null && ec.Excludes("summary",false))
        {
            this.Summary = null;
        }
        //      C# -> List<UserRecoveryAnalysis>? UserAnalyses
        // GraphQL -> userAnalyses: [UserRecoveryAnalysis!]! (type)
        if (ec.Includes("userAnalyses",false))
        {
            if(this.UserAnalyses == null) {

                this.UserAnalyses = new List<UserRecoveryAnalysis>();
                this.UserAnalyses.ApplyExploratoryFieldSpec(ec.NewChild("userAnalyses"));

            } else {

                this.UserAnalyses.ApplyExploratoryFieldSpec(ec.NewChild("userAnalyses"));

            }
        }
        else if (this.UserAnalyses != null && ec.Excludes("userAnalyses",false))
        {
            this.UserAnalyses = null;
        }
    }


    #endregion

    } // class GetRecoveryAnalysisResultResp
    
    #endregion

    public static class ListGetRecoveryAnalysisResultRespExtensions
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
            this List<GetRecoveryAnalysisResultResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetRecoveryAnalysisResultResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetRecoveryAnalysisResultResp> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetRecoveryAnalysisResultResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetRecoveryAnalysisResultResp> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types