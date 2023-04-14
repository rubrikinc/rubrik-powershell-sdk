// SlaUpgradeInfo.cs
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
    #region SlaUpgradeInfo
    public class SlaUpgradeInfo: IFragment
    {
        #region members
        //      C# -> SlaUpgradeEligibility? Eligibility
        // GraphQL -> eligibility: SlaUpgradeEligibility (type)
        [JsonProperty("eligibility")]
        public SlaUpgradeEligibility? Eligibility { get; set; }

        //      C# -> SlaUpgrade? LatestUpgrade
        // GraphQL -> latestUpgrade: SlaUpgrade (type)
        [JsonProperty("latestUpgrade")]
        public SlaUpgrade? LatestUpgrade { get; set; }

        #endregion

    #region methods

    public SlaUpgradeInfo Set(
        SlaUpgradeEligibility? Eligibility = null,
        SlaUpgrade? LatestUpgrade = null
    ) 
    {
        if ( Eligibility != null ) {
            this.Eligibility = Eligibility;
        }
        if ( LatestUpgrade != null ) {
            this.LatestUpgrade = LatestUpgrade;
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
            //      C# -> SlaUpgradeEligibility? Eligibility
            // GraphQL -> eligibility: SlaUpgradeEligibility (type)
            if (this.Eligibility != null)
            {
                 s += ind + "eligibility\n";

                 s += ind + "{\n" + 
                 this.Eligibility.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaUpgrade? LatestUpgrade
            // GraphQL -> latestUpgrade: SlaUpgrade (type)
            if (this.LatestUpgrade != null)
            {
                 s += ind + "latestUpgrade\n";

                 s += ind + "{\n" + 
                 this.LatestUpgrade.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> SlaUpgradeEligibility? Eligibility
            // GraphQL -> eligibility: SlaUpgradeEligibility (type)
            if (this.Eligibility == null && Exploration.Includes(parent + ".eligibility"))
            {
                this.Eligibility = new SlaUpgradeEligibility();
                this.Eligibility.ApplyExploratoryFragment(parent + ".eligibility");
            }
            //      C# -> SlaUpgrade? LatestUpgrade
            // GraphQL -> latestUpgrade: SlaUpgrade (type)
            if (this.LatestUpgrade == null && Exploration.Includes(parent + ".latestUpgrade"))
            {
                this.LatestUpgrade = new SlaUpgrade();
                this.LatestUpgrade.ApplyExploratoryFragment(parent + ".latestUpgrade");
            }
        }


    #endregion

    } // class SlaUpgradeInfo
    #endregion

    public static class ListSlaUpgradeInfoExtensions
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
            this List<SlaUpgradeInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SlaUpgradeInfo> list, 
            String parent = "")
        {
            var item = new SlaUpgradeInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types