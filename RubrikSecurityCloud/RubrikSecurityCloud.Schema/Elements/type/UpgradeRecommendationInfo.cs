// UpgradeRecommendationInfo.cs
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
    #region UpgradeRecommendationInfo
    public class UpgradeRecommendationInfo: BaseType
    {
        #region members

        //      C# -> System.String? NextReleaseRecommendation
        // GraphQL -> nextReleaseRecommendation: String! (scalar)
        [JsonProperty("nextReleaseRecommendation")]
        public System.String? NextReleaseRecommendation { get; set; }

        //      C# -> System.String? Recommendation
        // GraphQL -> recommendation: String! (scalar)
        [JsonProperty("recommendation")]
        public System.String? Recommendation { get; set; }

        //      C# -> List<System.String>? Upgradability
        // GraphQL -> upgradability: [String!]! (scalar)
        [JsonProperty("upgradability")]
        public List<System.String>? Upgradability { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpgradeRecommendationInfo";
    }

    public UpgradeRecommendationInfo Set(
        System.String? NextReleaseRecommendation = null,
        System.String? Recommendation = null,
        List<System.String>? Upgradability = null
    ) 
    {
        if ( NextReleaseRecommendation != null ) {
            this.NextReleaseRecommendation = NextReleaseRecommendation;
        }
        if ( Recommendation != null ) {
            this.Recommendation = Recommendation;
        }
        if ( Upgradability != null ) {
            this.Upgradability = Upgradability;
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
        //      C# -> System.String? NextReleaseRecommendation
        // GraphQL -> nextReleaseRecommendation: String! (scalar)
        if (this.NextReleaseRecommendation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextReleaseRecommendation\n" ;
            } else {
                s += ind + "nextReleaseRecommendation\n" ;
            }
        }
        //      C# -> System.String? Recommendation
        // GraphQL -> recommendation: String! (scalar)
        if (this.Recommendation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recommendation\n" ;
            } else {
                s += ind + "recommendation\n" ;
            }
        }
        //      C# -> List<System.String>? Upgradability
        // GraphQL -> upgradability: [String!]! (scalar)
        if (this.Upgradability != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradability\n" ;
            } else {
                s += ind + "upgradability\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? NextReleaseRecommendation
        // GraphQL -> nextReleaseRecommendation: String! (scalar)
        if (ec.Includes("nextReleaseRecommendation",true))
        {
            if(this.NextReleaseRecommendation == null) {

                this.NextReleaseRecommendation = "FETCH";

            } else {


            }
        }
        else if (this.NextReleaseRecommendation != null && ec.Excludes("nextReleaseRecommendation",true))
        {
            this.NextReleaseRecommendation = null;
        }
        //      C# -> System.String? Recommendation
        // GraphQL -> recommendation: String! (scalar)
        if (ec.Includes("recommendation",true))
        {
            if(this.Recommendation == null) {

                this.Recommendation = "FETCH";

            } else {


            }
        }
        else if (this.Recommendation != null && ec.Excludes("recommendation",true))
        {
            this.Recommendation = null;
        }
        //      C# -> List<System.String>? Upgradability
        // GraphQL -> upgradability: [String!]! (scalar)
        if (ec.Includes("upgradability",true))
        {
            if(this.Upgradability == null) {

                this.Upgradability = new List<System.String>();

            } else {


            }
        }
        else if (this.Upgradability != null && ec.Excludes("upgradability",true))
        {
            this.Upgradability = null;
        }
    }


    #endregion

    } // class UpgradeRecommendationInfo
    
    #endregion

    public static class ListUpgradeRecommendationInfoExtensions
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
            this List<UpgradeRecommendationInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpgradeRecommendationInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeRecommendationInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeRecommendationInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpgradeRecommendationInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types