// LicenseExpiryInsight.cs
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
    #region LicenseExpiryInsight
    public class LicenseExpiryInsight: BaseType
    {
        #region members

        //      C# -> LicenseInsightsSeverity? Severity
        // GraphQL -> severity: LicenseInsightsSeverity! (enum)
        [JsonProperty("severity")]
        public LicenseInsightsSeverity? Severity { get; set; }

        //      C# -> System.Int32? RemainingDays
        // GraphQL -> remainingDays: Int! (scalar)
        [JsonProperty("remainingDays")]
        public System.Int32? RemainingDays { get; set; }

        //      C# -> LicenseDetails? LicenseDetails
        // GraphQL -> licenseDetails: LicenseDetails (type)
        [JsonProperty("licenseDetails")]
        public LicenseDetails? LicenseDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LicenseExpiryInsight";
    }

    public LicenseExpiryInsight Set(
        LicenseInsightsSeverity? Severity = null,
        System.Int32? RemainingDays = null,
        LicenseDetails? LicenseDetails = null
    ) 
    {
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( RemainingDays != null ) {
            this.RemainingDays = RemainingDays;
        }
        if ( LicenseDetails != null ) {
            this.LicenseDetails = LicenseDetails;
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
        //      C# -> LicenseInsightsSeverity? Severity
        // GraphQL -> severity: LicenseInsightsSeverity! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.Int32? RemainingDays
        // GraphQL -> remainingDays: Int! (scalar)
        if (this.RemainingDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remainingDays\n" ;
            } else {
                s += ind + "remainingDays\n" ;
            }
        }
        //      C# -> LicenseDetails? LicenseDetails
        // GraphQL -> licenseDetails: LicenseDetails (type)
        if (this.LicenseDetails != null) {
            var fspec = this.LicenseDetails.AsFieldSpec(conf.Child("licenseDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "licenseDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> LicenseInsightsSeverity? Severity
        // GraphQL -> severity: LicenseInsightsSeverity! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new LicenseInsightsSeverity();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.Int32? RemainingDays
        // GraphQL -> remainingDays: Int! (scalar)
        if (ec.Includes("remainingDays",true))
        {
            if(this.RemainingDays == null) {

                this.RemainingDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.RemainingDays != null && ec.Excludes("remainingDays",true))
        {
            this.RemainingDays = null;
        }
        //      C# -> LicenseDetails? LicenseDetails
        // GraphQL -> licenseDetails: LicenseDetails (type)
        if (ec.Includes("licenseDetails",false))
        {
            if(this.LicenseDetails == null) {

                this.LicenseDetails = new LicenseDetails();
                this.LicenseDetails.ApplyExploratoryFieldSpec(ec.NewChild("licenseDetails"));

            } else {

                this.LicenseDetails.ApplyExploratoryFieldSpec(ec.NewChild("licenseDetails"));

            }
        }
        else if (this.LicenseDetails != null && ec.Excludes("licenseDetails",false))
        {
            this.LicenseDetails = null;
        }
    }


    #endregion

    } // class LicenseExpiryInsight
    
    #endregion

    public static class ListLicenseExpiryInsightExtensions
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
            this List<LicenseExpiryInsight> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LicenseExpiryInsight> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LicenseExpiryInsight> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LicenseExpiryInsight());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LicenseExpiryInsight> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types