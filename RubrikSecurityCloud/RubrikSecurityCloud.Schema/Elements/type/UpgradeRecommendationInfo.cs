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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? NextReleaseRecommendation
        // GraphQL -> nextReleaseRecommendation: String! (scalar)
        if (this.NextReleaseRecommendation != null) {
            s += ind + "nextReleaseRecommendation\n" ;
        }
        //      C# -> System.String? Recommendation
        // GraphQL -> recommendation: String! (scalar)
        if (this.Recommendation != null) {
            s += ind + "recommendation\n" ;
        }
        //      C# -> List<System.String>? Upgradability
        // GraphQL -> upgradability: [String!]! (scalar)
        if (this.Upgradability != null) {
            s += ind + "upgradability\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? NextReleaseRecommendation
        // GraphQL -> nextReleaseRecommendation: String! (scalar)
        if (this.NextReleaseRecommendation == null && Exploration.Includes(parent + ".nextReleaseRecommendation", true))
        {
            this.NextReleaseRecommendation = "FETCH";
        }
        //      C# -> System.String? Recommendation
        // GraphQL -> recommendation: String! (scalar)
        if (this.Recommendation == null && Exploration.Includes(parent + ".recommendation", true))
        {
            this.Recommendation = "FETCH";
        }
        //      C# -> List<System.String>? Upgradability
        // GraphQL -> upgradability: [String!]! (scalar)
        if (this.Upgradability == null && Exploration.Includes(parent + ".upgradability", true))
        {
            this.Upgradability = new List<System.String>();
        }
    }


    #endregion

    } // class UpgradeRecommendationInfo
    
    #endregion

    public static class ListUpgradeRecommendationInfoExtensions
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
            this List<UpgradeRecommendationInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeRecommendationInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeRecommendationInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types