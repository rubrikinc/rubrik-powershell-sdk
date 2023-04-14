// SlaUpgradeEligibility.cs
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
    #region SlaUpgradeEligibility
    public class SlaUpgradeEligibility: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        [JsonProperty("isEligible")]
        public System.Boolean? IsEligible { get; set; }

        //      C# -> SlaMigrationIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: SlaMigrationIneligibilityReason! (enum)
        [JsonProperty("ineligibilityReason")]
        public SlaMigrationIneligibilityReason? IneligibilityReason { get; set; }

        #endregion

    #region methods

    public SlaUpgradeEligibility Set(
        System.Boolean? IsEligible = null,
        SlaMigrationIneligibilityReason? IneligibilityReason = null
    ) 
    {
        if ( IsEligible != null ) {
            this.IsEligible = IsEligible;
        }
        if ( IneligibilityReason != null ) {
            this.IneligibilityReason = IneligibilityReason;
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
            //      C# -> System.Boolean? IsEligible
            // GraphQL -> isEligible: Boolean! (scalar)
            if (this.IsEligible != null)
            {
                 s += ind + "isEligible\n";

            }
            //      C# -> SlaMigrationIneligibilityReason? IneligibilityReason
            // GraphQL -> ineligibilityReason: SlaMigrationIneligibilityReason! (enum)
            if (this.IneligibilityReason != null)
            {
                 s += ind + "ineligibilityReason\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsEligible
            // GraphQL -> isEligible: Boolean! (scalar)
            if (this.IsEligible == null && Exploration.Includes(parent + ".isEligible$"))
            {
                this.IsEligible = new System.Boolean();
            }
            //      C# -> SlaMigrationIneligibilityReason? IneligibilityReason
            // GraphQL -> ineligibilityReason: SlaMigrationIneligibilityReason! (enum)
            if (this.IneligibilityReason == null && Exploration.Includes(parent + ".ineligibilityReason$"))
            {
                this.IneligibilityReason = new SlaMigrationIneligibilityReason();
            }
        }


    #endregion

    } // class SlaUpgradeEligibility
    #endregion

    public static class ListSlaUpgradeEligibilityExtensions
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
            this List<SlaUpgradeEligibility> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SlaUpgradeEligibility> list, 
            String parent = "")
        {
            var item = new SlaUpgradeEligibility();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types