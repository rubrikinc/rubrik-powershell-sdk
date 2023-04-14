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

namespace Rubrik.SecurityCloud.Types
{
    #region UpgradeRecommendationInfo
    public class UpgradeRecommendationInfo: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? NextReleaseRecommendation
            // GraphQL -> nextReleaseRecommendation: String! (scalar)
            if (this.NextReleaseRecommendation != null)
            {
                 s += ind + "nextReleaseRecommendation\n";

            }
            //      C# -> System.String? Recommendation
            // GraphQL -> recommendation: String! (scalar)
            if (this.Recommendation != null)
            {
                 s += ind + "recommendation\n";

            }
            //      C# -> List<System.String>? Upgradability
            // GraphQL -> upgradability: [String!]! (scalar)
            if (this.Upgradability != null)
            {
                 s += ind + "upgradability\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? NextReleaseRecommendation
            // GraphQL -> nextReleaseRecommendation: String! (scalar)
            if (this.NextReleaseRecommendation == null && Exploration.Includes(parent + ".nextReleaseRecommendation$"))
            {
                this.NextReleaseRecommendation = new System.String("FETCH");
            }
            //      C# -> System.String? Recommendation
            // GraphQL -> recommendation: String! (scalar)
            if (this.Recommendation == null && Exploration.Includes(parent + ".recommendation$"))
            {
                this.Recommendation = new System.String("FETCH");
            }
            //      C# -> List<System.String>? Upgradability
            // GraphQL -> upgradability: [String!]! (scalar)
            if (this.Upgradability == null && Exploration.Includes(parent + ".upgradability$"))
            {
                this.Upgradability = new List<System.String>();
            }
        }


    #endregion

    } // class UpgradeRecommendationInfo
    #endregion

    public static class ListUpgradeRecommendationInfoExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<UpgradeRecommendationInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpgradeRecommendationInfo> list, 
            String parent = "")
        {
            var item = new UpgradeRecommendationInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types