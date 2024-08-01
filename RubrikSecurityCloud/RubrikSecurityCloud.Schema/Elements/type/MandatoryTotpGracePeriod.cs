// MandatoryTotpGracePeriod.cs
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
    #region MandatoryTotpGracePeriod
    public class MandatoryTotpGracePeriod: BaseType
    {
        #region members

        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        [JsonProperty("mandatoryTotpEnforcementDate")]
        public DateTime? MandatoryTotpEnforcementDate { get; set; }

        //      C# -> System.Boolean? ShouldHideMandatoryTotpGracePeriodWarning
        // GraphQL -> shouldHideMandatoryTotpGracePeriodWarning: Boolean! (scalar)
        [JsonProperty("shouldHideMandatoryTotpGracePeriodWarning")]
        public System.Boolean? ShouldHideMandatoryTotpGracePeriodWarning { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "mandatoryTotpGracePeriod";
    }

    public MandatoryTotpGracePeriod Set(
        DateTime? MandatoryTotpEnforcementDate = null,
        System.Boolean? ShouldHideMandatoryTotpGracePeriodWarning = null
    ) 
    {
        if ( MandatoryTotpEnforcementDate != null ) {
            this.MandatoryTotpEnforcementDate = MandatoryTotpEnforcementDate;
        }
        if ( ShouldHideMandatoryTotpGracePeriodWarning != null ) {
            this.ShouldHideMandatoryTotpGracePeriodWarning = ShouldHideMandatoryTotpGracePeriodWarning;
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
        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        if (this.MandatoryTotpEnforcementDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mandatoryTotpEnforcementDate\n" ;
            } else {
                s += ind + "mandatoryTotpEnforcementDate\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldHideMandatoryTotpGracePeriodWarning
        // GraphQL -> shouldHideMandatoryTotpGracePeriodWarning: Boolean! (scalar)
        if (this.ShouldHideMandatoryTotpGracePeriodWarning != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldHideMandatoryTotpGracePeriodWarning\n" ;
            } else {
                s += ind + "shouldHideMandatoryTotpGracePeriodWarning\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        if (ec.Includes("mandatoryTotpEnforcementDate",true))
        {
            if(this.MandatoryTotpEnforcementDate == null) {

                this.MandatoryTotpEnforcementDate = new DateTime();

            } else {


            }
        }
        else if (this.MandatoryTotpEnforcementDate != null && ec.Excludes("mandatoryTotpEnforcementDate",true))
        {
            this.MandatoryTotpEnforcementDate = null;
        }
        //      C# -> System.Boolean? ShouldHideMandatoryTotpGracePeriodWarning
        // GraphQL -> shouldHideMandatoryTotpGracePeriodWarning: Boolean! (scalar)
        if (ec.Includes("shouldHideMandatoryTotpGracePeriodWarning",true))
        {
            if(this.ShouldHideMandatoryTotpGracePeriodWarning == null) {

                this.ShouldHideMandatoryTotpGracePeriodWarning = true;

            } else {


            }
        }
        else if (this.ShouldHideMandatoryTotpGracePeriodWarning != null && ec.Excludes("shouldHideMandatoryTotpGracePeriodWarning",true))
        {
            this.ShouldHideMandatoryTotpGracePeriodWarning = null;
        }
    }


    #endregion

    } // class MandatoryTotpGracePeriod
    
    #endregion

    public static class ListMandatoryTotpGracePeriodExtensions
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
            this List<MandatoryTotpGracePeriod> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MandatoryTotpGracePeriod> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MandatoryTotpGracePeriod> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MandatoryTotpGracePeriod());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MandatoryTotpGracePeriod> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types