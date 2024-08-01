// NonCompliantArchivalRetentionForTierWarningDetails.cs
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
    #region NonCompliantArchivalRetentionForTierWarningDetails
 
    public class NonCompliantArchivalRetentionForTierWarningDetails: BaseType, SlaArchivalWarningsDetails
    {
        #region members

        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        [JsonProperty("severity")]
        public WarningSeverityEnum? Severity { get; set; }

        //      C# -> System.Int32? MinArchivalRetentionDaysExpected
        // GraphQL -> minArchivalRetentionDaysExpected: Int! (scalar)
        [JsonProperty("minArchivalRetentionDaysExpected")]
        public System.Int32? MinArchivalRetentionDaysExpected { get; set; }

        //      C# -> System.Int32? MinArchivalRetentionDaysFound
        // GraphQL -> minArchivalRetentionDaysFound: Int! (scalar)
        [JsonProperty("minArchivalRetentionDaysFound")]
        public System.Int32? MinArchivalRetentionDaysFound { get; set; }

        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        [JsonProperty("tier")]
        public System.String? Tier { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NonCompliantArchivalRetentionForTierWarningDetails";
    }

    public NonCompliantArchivalRetentionForTierWarningDetails Set(
        WarningSeverityEnum? Severity = null,
        System.Int32? MinArchivalRetentionDaysExpected = null,
        System.Int32? MinArchivalRetentionDaysFound = null,
        System.String? Tier = null
    ) 
    {
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( MinArchivalRetentionDaysExpected != null ) {
            this.MinArchivalRetentionDaysExpected = MinArchivalRetentionDaysExpected;
        }
        if ( MinArchivalRetentionDaysFound != null ) {
            this.MinArchivalRetentionDaysFound = MinArchivalRetentionDaysFound;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
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
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.Int32? MinArchivalRetentionDaysExpected
        // GraphQL -> minArchivalRetentionDaysExpected: Int! (scalar)
        if (this.MinArchivalRetentionDaysExpected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "minArchivalRetentionDaysExpected\n" ;
            } else {
                s += ind + "minArchivalRetentionDaysExpected\n" ;
            }
        }
        //      C# -> System.Int32? MinArchivalRetentionDaysFound
        // GraphQL -> minArchivalRetentionDaysFound: Int! (scalar)
        if (this.MinArchivalRetentionDaysFound != null) {
            if (conf.Flat) {
                s += conf.Prefix + "minArchivalRetentionDaysFound\n" ;
            } else {
                s += ind + "minArchivalRetentionDaysFound\n" ;
            }
        }
        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new WarningSeverityEnum();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.Int32? MinArchivalRetentionDaysExpected
        // GraphQL -> minArchivalRetentionDaysExpected: Int! (scalar)
        if (ec.Includes("minArchivalRetentionDaysExpected",true))
        {
            if(this.MinArchivalRetentionDaysExpected == null) {

                this.MinArchivalRetentionDaysExpected = Int32.MinValue;

            } else {


            }
        }
        else if (this.MinArchivalRetentionDaysExpected != null && ec.Excludes("minArchivalRetentionDaysExpected",true))
        {
            this.MinArchivalRetentionDaysExpected = null;
        }
        //      C# -> System.Int32? MinArchivalRetentionDaysFound
        // GraphQL -> minArchivalRetentionDaysFound: Int! (scalar)
        if (ec.Includes("minArchivalRetentionDaysFound",true))
        {
            if(this.MinArchivalRetentionDaysFound == null) {

                this.MinArchivalRetentionDaysFound = Int32.MinValue;

            } else {


            }
        }
        else if (this.MinArchivalRetentionDaysFound != null && ec.Excludes("minArchivalRetentionDaysFound",true))
        {
            this.MinArchivalRetentionDaysFound = null;
        }
        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = "FETCH";

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
    }


    #endregion

    } // class NonCompliantArchivalRetentionForTierWarningDetails
    
    #endregion

    public static class ListNonCompliantArchivalRetentionForTierWarningDetailsExtensions
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
            this List<NonCompliantArchivalRetentionForTierWarningDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NonCompliantArchivalRetentionForTierWarningDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NonCompliantArchivalRetentionForTierWarningDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NonCompliantArchivalRetentionForTierWarningDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NonCompliantArchivalRetentionForTierWarningDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types