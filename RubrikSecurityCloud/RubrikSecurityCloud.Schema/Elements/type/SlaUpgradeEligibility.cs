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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region SlaUpgradeEligibility
    public class SlaUpgradeEligibility: BaseType
    {
        #region members

        //      C# -> SlaMigrationIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: SlaMigrationIneligibilityReason! (enum)
        [JsonProperty("ineligibilityReason")]
        public SlaMigrationIneligibilityReason? IneligibilityReason { get; set; }

        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        [JsonProperty("isEligible")]
        public System.Boolean? IsEligible { get; set; }


        #endregion

    #region methods

    public SlaUpgradeEligibility Set(
        SlaMigrationIneligibilityReason? IneligibilityReason = null,
        System.Boolean? IsEligible = null
    ) 
    {
        if ( IneligibilityReason != null ) {
            this.IneligibilityReason = IneligibilityReason;
        }
        if ( IsEligible != null ) {
            this.IsEligible = IsEligible;
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
        //      C# -> SlaMigrationIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: SlaMigrationIneligibilityReason! (enum)
        if (this.IneligibilityReason != null) {
            s += ind + "ineligibilityReason\n" ;
        }
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        if (this.IsEligible != null) {
            s += ind + "isEligible\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SlaMigrationIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: SlaMigrationIneligibilityReason! (enum)
        if (this.IneligibilityReason == null && Exploration.Includes(parent + ".ineligibilityReason", true))
        {
            this.IneligibilityReason = new SlaMigrationIneligibilityReason();
        }
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        if (this.IsEligible == null && Exploration.Includes(parent + ".isEligible", true))
        {
            this.IsEligible = true;
        }
    }


    #endregion

    } // class SlaUpgradeEligibility
    
    #endregion

    public static class ListSlaUpgradeEligibilityExtensions
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
            this List<SlaUpgradeEligibility> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaUpgradeEligibility> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaUpgradeEligibility());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types