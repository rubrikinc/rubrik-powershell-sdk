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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region SlaUpgradeInfo
    public class SlaUpgradeInfo: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> SlaUpgradeEligibility? Eligibility
        // GraphQL -> eligibility: SlaUpgradeEligibility (type)
        if (this.Eligibility != null) {
            s += ind + "eligibility {\n" + this.Eligibility.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaUpgrade? LatestUpgrade
        // GraphQL -> latestUpgrade: SlaUpgrade (type)
        if (this.LatestUpgrade != null) {
            s += ind + "latestUpgrade {\n" + this.LatestUpgrade.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SlaUpgradeEligibility? Eligibility
        // GraphQL -> eligibility: SlaUpgradeEligibility (type)
        if (this.Eligibility == null && Exploration.Includes(parent + ".eligibility"))
        {
            this.Eligibility = new SlaUpgradeEligibility();
            this.Eligibility.ApplyExploratoryFieldSpec(parent + ".eligibility");
        }
        //      C# -> SlaUpgrade? LatestUpgrade
        // GraphQL -> latestUpgrade: SlaUpgrade (type)
        if (this.LatestUpgrade == null && Exploration.Includes(parent + ".latestUpgrade"))
        {
            this.LatestUpgrade = new SlaUpgrade();
            this.LatestUpgrade.ApplyExploratoryFieldSpec(parent + ".latestUpgrade");
        }
    }


    #endregion

    } // class SlaUpgradeInfo
    
    #endregion

    public static class ListSlaUpgradeInfoExtensions
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
            this List<SlaUpgradeInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaUpgradeInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaUpgradeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types