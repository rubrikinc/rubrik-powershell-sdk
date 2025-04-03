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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
            this List<SlaUpgradeEligibility> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaUpgradeEligibility> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaUpgradeEligibility> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaUpgradeEligibility());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaUpgradeEligibility> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types