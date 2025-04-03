// InactiveLockoutConfig.cs
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
    #region InactiveLockoutConfig
    public class InactiveLockoutConfig: BaseType
    {
        #region members

        //      C# -> System.Int32? InactivityDaysLimit
        // GraphQL -> inactivityDaysLimit: Int! (scalar)
        [JsonProperty("inactivityDaysLimit")]
        public System.Int32? InactivityDaysLimit { get; set; }

        //      C# -> System.Boolean? IsInactiveLockoutEnabled
        // GraphQL -> isInactiveLockoutEnabled: Boolean! (scalar)
        [JsonProperty("isInactiveLockoutEnabled")]
        public System.Boolean? IsInactiveLockoutEnabled { get; set; }

        //      C# -> System.Boolean? IsSelfServiceUnlockEnabled
        // GraphQL -> isSelfServiceUnlockEnabled: Boolean! (scalar)
        [JsonProperty("isSelfServiceUnlockEnabled")]
        public System.Boolean? IsSelfServiceUnlockEnabled { get; set; }

        //      C# -> System.Boolean? IsWarningEmailEnabled
        // GraphQL -> isWarningEmailEnabled: Boolean! (scalar)
        [JsonProperty("isWarningEmailEnabled")]
        public System.Boolean? IsWarningEmailEnabled { get; set; }

        //      C# -> System.Int32? NumDaysBeforeWarningEmail
        // GraphQL -> numDaysBeforeWarningEmail: Int! (scalar)
        [JsonProperty("numDaysBeforeWarningEmail")]
        public System.Int32? NumDaysBeforeWarningEmail { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InactiveLockoutConfig";
    }

    public InactiveLockoutConfig Set(
        System.Int32? InactivityDaysLimit = null,
        System.Boolean? IsInactiveLockoutEnabled = null,
        System.Boolean? IsSelfServiceUnlockEnabled = null,
        System.Boolean? IsWarningEmailEnabled = null,
        System.Int32? NumDaysBeforeWarningEmail = null
    ) 
    {
        if ( InactivityDaysLimit != null ) {
            this.InactivityDaysLimit = InactivityDaysLimit;
        }
        if ( IsInactiveLockoutEnabled != null ) {
            this.IsInactiveLockoutEnabled = IsInactiveLockoutEnabled;
        }
        if ( IsSelfServiceUnlockEnabled != null ) {
            this.IsSelfServiceUnlockEnabled = IsSelfServiceUnlockEnabled;
        }
        if ( IsWarningEmailEnabled != null ) {
            this.IsWarningEmailEnabled = IsWarningEmailEnabled;
        }
        if ( NumDaysBeforeWarningEmail != null ) {
            this.NumDaysBeforeWarningEmail = NumDaysBeforeWarningEmail;
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
        //      C# -> System.Int32? InactivityDaysLimit
        // GraphQL -> inactivityDaysLimit: Int! (scalar)
        if (this.InactivityDaysLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inactivityDaysLimit\n" ;
            } else {
                s += ind + "inactivityDaysLimit\n" ;
            }
        }
        //      C# -> System.Boolean? IsInactiveLockoutEnabled
        // GraphQL -> isInactiveLockoutEnabled: Boolean! (scalar)
        if (this.IsInactiveLockoutEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isInactiveLockoutEnabled\n" ;
            } else {
                s += ind + "isInactiveLockoutEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsSelfServiceUnlockEnabled
        // GraphQL -> isSelfServiceUnlockEnabled: Boolean! (scalar)
        if (this.IsSelfServiceUnlockEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSelfServiceUnlockEnabled\n" ;
            } else {
                s += ind + "isSelfServiceUnlockEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsWarningEmailEnabled
        // GraphQL -> isWarningEmailEnabled: Boolean! (scalar)
        if (this.IsWarningEmailEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isWarningEmailEnabled\n" ;
            } else {
                s += ind + "isWarningEmailEnabled\n" ;
            }
        }
        //      C# -> System.Int32? NumDaysBeforeWarningEmail
        // GraphQL -> numDaysBeforeWarningEmail: Int! (scalar)
        if (this.NumDaysBeforeWarningEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDaysBeforeWarningEmail\n" ;
            } else {
                s += ind + "numDaysBeforeWarningEmail\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? InactivityDaysLimit
        // GraphQL -> inactivityDaysLimit: Int! (scalar)
        if (ec.Includes("inactivityDaysLimit",true))
        {
            if(this.InactivityDaysLimit == null) {

                this.InactivityDaysLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.InactivityDaysLimit != null && ec.Excludes("inactivityDaysLimit",true))
        {
            this.InactivityDaysLimit = null;
        }
        //      C# -> System.Boolean? IsInactiveLockoutEnabled
        // GraphQL -> isInactiveLockoutEnabled: Boolean! (scalar)
        if (ec.Includes("isInactiveLockoutEnabled",true))
        {
            if(this.IsInactiveLockoutEnabled == null) {

                this.IsInactiveLockoutEnabled = true;

            } else {


            }
        }
        else if (this.IsInactiveLockoutEnabled != null && ec.Excludes("isInactiveLockoutEnabled",true))
        {
            this.IsInactiveLockoutEnabled = null;
        }
        //      C# -> System.Boolean? IsSelfServiceUnlockEnabled
        // GraphQL -> isSelfServiceUnlockEnabled: Boolean! (scalar)
        if (ec.Includes("isSelfServiceUnlockEnabled",true))
        {
            if(this.IsSelfServiceUnlockEnabled == null) {

                this.IsSelfServiceUnlockEnabled = true;

            } else {


            }
        }
        else if (this.IsSelfServiceUnlockEnabled != null && ec.Excludes("isSelfServiceUnlockEnabled",true))
        {
            this.IsSelfServiceUnlockEnabled = null;
        }
        //      C# -> System.Boolean? IsWarningEmailEnabled
        // GraphQL -> isWarningEmailEnabled: Boolean! (scalar)
        if (ec.Includes("isWarningEmailEnabled",true))
        {
            if(this.IsWarningEmailEnabled == null) {

                this.IsWarningEmailEnabled = true;

            } else {


            }
        }
        else if (this.IsWarningEmailEnabled != null && ec.Excludes("isWarningEmailEnabled",true))
        {
            this.IsWarningEmailEnabled = null;
        }
        //      C# -> System.Int32? NumDaysBeforeWarningEmail
        // GraphQL -> numDaysBeforeWarningEmail: Int! (scalar)
        if (ec.Includes("numDaysBeforeWarningEmail",true))
        {
            if(this.NumDaysBeforeWarningEmail == null) {

                this.NumDaysBeforeWarningEmail = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDaysBeforeWarningEmail != null && ec.Excludes("numDaysBeforeWarningEmail",true))
        {
            this.NumDaysBeforeWarningEmail = null;
        }
    }


    #endregion

    } // class InactiveLockoutConfig
    
    #endregion

    public static class ListInactiveLockoutConfigExtensions
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
            this List<InactiveLockoutConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<InactiveLockoutConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<InactiveLockoutConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InactiveLockoutConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<InactiveLockoutConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types