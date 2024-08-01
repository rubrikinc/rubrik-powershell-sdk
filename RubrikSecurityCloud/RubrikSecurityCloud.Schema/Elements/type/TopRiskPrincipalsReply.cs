// TopRiskPrincipalsReply.cs
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
    #region TopRiskPrincipalsReply
    public class TopRiskPrincipalsReply: BaseType
    {
        #region members

        //      C# -> System.Int64? LatestTimelineDate
        // GraphQL -> latestTimelineDate: Long! (scalar)
        [JsonProperty("latestTimelineDate")]
        public System.Int64? LatestTimelineDate { get; set; }

        //      C# -> List<TopRiskPrincipalSummary>? TopRiskPrincipalSummaries
        // GraphQL -> topRiskPrincipalSummaries: [TopRiskPrincipalSummary!]! (type)
        [JsonProperty("topRiskPrincipalSummaries")]
        public List<TopRiskPrincipalSummary>? TopRiskPrincipalSummaries { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TopRiskPrincipalsReply";
    }

    public TopRiskPrincipalsReply Set(
        System.Int64? LatestTimelineDate = null,
        List<TopRiskPrincipalSummary>? TopRiskPrincipalSummaries = null
    ) 
    {
        if ( LatestTimelineDate != null ) {
            this.LatestTimelineDate = LatestTimelineDate;
        }
        if ( TopRiskPrincipalSummaries != null ) {
            this.TopRiskPrincipalSummaries = TopRiskPrincipalSummaries;
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
        //      C# -> System.Int64? LatestTimelineDate
        // GraphQL -> latestTimelineDate: Long! (scalar)
        if (this.LatestTimelineDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestTimelineDate\n" ;
            } else {
                s += ind + "latestTimelineDate\n" ;
            }
        }
        //      C# -> List<TopRiskPrincipalSummary>? TopRiskPrincipalSummaries
        // GraphQL -> topRiskPrincipalSummaries: [TopRiskPrincipalSummary!]! (type)
        if (this.TopRiskPrincipalSummaries != null) {
            var fspec = this.TopRiskPrincipalSummaries.AsFieldSpec(conf.Child("topRiskPrincipalSummaries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "topRiskPrincipalSummaries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? LatestTimelineDate
        // GraphQL -> latestTimelineDate: Long! (scalar)
        if (ec.Includes("latestTimelineDate",true))
        {
            if(this.LatestTimelineDate == null) {

                this.LatestTimelineDate = new System.Int64();

            } else {


            }
        }
        else if (this.LatestTimelineDate != null && ec.Excludes("latestTimelineDate",true))
        {
            this.LatestTimelineDate = null;
        }
        //      C# -> List<TopRiskPrincipalSummary>? TopRiskPrincipalSummaries
        // GraphQL -> topRiskPrincipalSummaries: [TopRiskPrincipalSummary!]! (type)
        if (ec.Includes("topRiskPrincipalSummaries",false))
        {
            if(this.TopRiskPrincipalSummaries == null) {

                this.TopRiskPrincipalSummaries = new List<TopRiskPrincipalSummary>();
                this.TopRiskPrincipalSummaries.ApplyExploratoryFieldSpec(ec.NewChild("topRiskPrincipalSummaries"));

            } else {

                this.TopRiskPrincipalSummaries.ApplyExploratoryFieldSpec(ec.NewChild("topRiskPrincipalSummaries"));

            }
        }
        else if (this.TopRiskPrincipalSummaries != null && ec.Excludes("topRiskPrincipalSummaries",false))
        {
            this.TopRiskPrincipalSummaries = null;
        }
    }


    #endregion

    } // class TopRiskPrincipalsReply
    
    #endregion

    public static class ListTopRiskPrincipalsReplyExtensions
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
            this List<TopRiskPrincipalsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TopRiskPrincipalsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TopRiskPrincipalsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TopRiskPrincipalsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TopRiskPrincipalsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types