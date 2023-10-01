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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "SlaUpgradeEligibility";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SlaMigrationIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: SlaMigrationIneligibilityReason! (enum)
        if (this.IneligibilityReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ineligibilityReason\n" ;
            } else {
                s += ind + "ineligibilityReason\n" ;
            }
        }
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        if (this.IsEligible != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEligible\n" ;
            } else {
                s += ind + "isEligible\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaMigrationIneligibilityReason? IneligibilityReason
        // GraphQL -> ineligibilityReason: SlaMigrationIneligibilityReason! (enum)
        if (ec.Includes("ineligibilityReason",true))
        {
            if(this.IneligibilityReason == null) {

                this.IneligibilityReason = new SlaMigrationIneligibilityReason();

            } else {


            }
        }
        else if (this.IneligibilityReason != null && ec.Excludes("ineligibilityReason",true))
        {
            this.IneligibilityReason = null;
        }
        //      C# -> System.Boolean? IsEligible
        // GraphQL -> isEligible: Boolean! (scalar)
        if (ec.Includes("isEligible",true))
        {
            if(this.IsEligible == null) {

                this.IsEligible = true;

            } else {


            }
        }
        else if (this.IsEligible != null && ec.Excludes("isEligible",true))
        {
            this.IsEligible = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SlaUpgradeEligibility> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaUpgradeEligibility> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaUpgradeEligibility());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaUpgradeEligibility> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types