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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "SlaUpgradeInfo";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SlaUpgradeEligibility? Eligibility
        // GraphQL -> eligibility: SlaUpgradeEligibility (type)
        if (this.Eligibility != null) {
            var fspec = this.Eligibility.AsFieldSpec(conf.Child("eligibility"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "eligibility {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaUpgrade? LatestUpgrade
        // GraphQL -> latestUpgrade: SlaUpgrade (type)
        if (this.LatestUpgrade != null) {
            var fspec = this.LatestUpgrade.AsFieldSpec(conf.Child("latestUpgrade"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestUpgrade {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaUpgradeEligibility? Eligibility
        // GraphQL -> eligibility: SlaUpgradeEligibility (type)
        if (ec.Includes("eligibility",false))
        {
            if(this.Eligibility == null) {

                this.Eligibility = new SlaUpgradeEligibility();
                this.Eligibility.ApplyExploratoryFieldSpec(ec.NewChild("eligibility"));

            } else {

                this.Eligibility.ApplyExploratoryFieldSpec(ec.NewChild("eligibility"));

            }
        }
        else if (this.Eligibility != null && ec.Excludes("eligibility",false))
        {
            this.Eligibility = null;
        }
        //      C# -> SlaUpgrade? LatestUpgrade
        // GraphQL -> latestUpgrade: SlaUpgrade (type)
        if (ec.Includes("latestUpgrade",false))
        {
            if(this.LatestUpgrade == null) {

                this.LatestUpgrade = new SlaUpgrade();
                this.LatestUpgrade.ApplyExploratoryFieldSpec(ec.NewChild("latestUpgrade"));

            } else {

                this.LatestUpgrade.ApplyExploratoryFieldSpec(ec.NewChild("latestUpgrade"));

            }
        }
        else if (this.LatestUpgrade != null && ec.Excludes("latestUpgrade",false))
        {
            this.LatestUpgrade = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaUpgradeInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaUpgradeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaUpgradeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types