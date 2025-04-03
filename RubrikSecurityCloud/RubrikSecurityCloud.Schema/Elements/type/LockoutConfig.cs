// LockoutConfig.cs
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
    #region LockoutConfig
    public class LockoutConfig: BaseType
    {
        #region members

        //      C# -> System.Int32? AccountAutoUnlockDurationInMins
        // GraphQL -> accountAutoUnlockDurationInMins: Int! (scalar)
        [JsonProperty("accountAutoUnlockDurationInMins")]
        public System.Int32? AccountAutoUnlockDurationInMins { get; set; }

        //      C# -> System.Boolean? IsAutoUnlockFeatureEnabled
        // GraphQL -> isAutoUnlockFeatureEnabled: Boolean! (scalar)
        [JsonProperty("isAutoUnlockFeatureEnabled")]
        public System.Boolean? IsAutoUnlockFeatureEnabled { get; set; }

        //      C# -> System.Boolean? IsBruteForceLockoutEnabled
        // GraphQL -> isBruteForceLockoutEnabled: Boolean! (scalar)
        [JsonProperty("isBruteForceLockoutEnabled")]
        public System.Boolean? IsBruteForceLockoutEnabled { get; set; }

        //      C# -> System.Boolean? IsSelfServiceEnabled
        // GraphQL -> isSelfServiceEnabled: Boolean! (scalar)
        [JsonProperty("isSelfServiceEnabled")]
        public System.Boolean? IsSelfServiceEnabled { get; set; }

        //      C# -> System.Int32? LoginAttemptsLimit
        // GraphQL -> loginAttemptsLimit: Int! (scalar)
        [JsonProperty("loginAttemptsLimit")]
        public System.Int32? LoginAttemptsLimit { get; set; }

        //      C# -> System.Int32? SelfServiceAttemptsLimit
        // GraphQL -> selfServiceAttemptsLimit: Int! (scalar)
        [JsonProperty("selfServiceAttemptsLimit")]
        public System.Int32? SelfServiceAttemptsLimit { get; set; }

        //      C# -> System.Int32? SelfServiceTokenValidityInMins
        // GraphQL -> selfServiceTokenValidityInMins: Int! (scalar)
        [JsonProperty("selfServiceTokenValidityInMins")]
        public System.Int32? SelfServiceTokenValidityInMins { get; set; }

        //      C# -> InactiveLockoutConfig? InactiveLockoutConfig
        // GraphQL -> inactiveLockoutConfig: InactiveLockoutConfig! (type)
        [JsonProperty("inactiveLockoutConfig")]
        public InactiveLockoutConfig? InactiveLockoutConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LockoutConfig";
    }

    public LockoutConfig Set(
        System.Int32? AccountAutoUnlockDurationInMins = null,
        System.Boolean? IsAutoUnlockFeatureEnabled = null,
        System.Boolean? IsBruteForceLockoutEnabled = null,
        System.Boolean? IsSelfServiceEnabled = null,
        System.Int32? LoginAttemptsLimit = null,
        System.Int32? SelfServiceAttemptsLimit = null,
        System.Int32? SelfServiceTokenValidityInMins = null,
        InactiveLockoutConfig? InactiveLockoutConfig = null
    ) 
    {
        if ( AccountAutoUnlockDurationInMins != null ) {
            this.AccountAutoUnlockDurationInMins = AccountAutoUnlockDurationInMins;
        }
        if ( IsAutoUnlockFeatureEnabled != null ) {
            this.IsAutoUnlockFeatureEnabled = IsAutoUnlockFeatureEnabled;
        }
        if ( IsBruteForceLockoutEnabled != null ) {
            this.IsBruteForceLockoutEnabled = IsBruteForceLockoutEnabled;
        }
        if ( IsSelfServiceEnabled != null ) {
            this.IsSelfServiceEnabled = IsSelfServiceEnabled;
        }
        if ( LoginAttemptsLimit != null ) {
            this.LoginAttemptsLimit = LoginAttemptsLimit;
        }
        if ( SelfServiceAttemptsLimit != null ) {
            this.SelfServiceAttemptsLimit = SelfServiceAttemptsLimit;
        }
        if ( SelfServiceTokenValidityInMins != null ) {
            this.SelfServiceTokenValidityInMins = SelfServiceTokenValidityInMins;
        }
        if ( InactiveLockoutConfig != null ) {
            this.InactiveLockoutConfig = InactiveLockoutConfig;
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
        //      C# -> System.Int32? AccountAutoUnlockDurationInMins
        // GraphQL -> accountAutoUnlockDurationInMins: Int! (scalar)
        if (this.AccountAutoUnlockDurationInMins != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountAutoUnlockDurationInMins\n" ;
            } else {
                s += ind + "accountAutoUnlockDurationInMins\n" ;
            }
        }
        //      C# -> System.Boolean? IsAutoUnlockFeatureEnabled
        // GraphQL -> isAutoUnlockFeatureEnabled: Boolean! (scalar)
        if (this.IsAutoUnlockFeatureEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAutoUnlockFeatureEnabled\n" ;
            } else {
                s += ind + "isAutoUnlockFeatureEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsBruteForceLockoutEnabled
        // GraphQL -> isBruteForceLockoutEnabled: Boolean! (scalar)
        if (this.IsBruteForceLockoutEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBruteForceLockoutEnabled\n" ;
            } else {
                s += ind + "isBruteForceLockoutEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsSelfServiceEnabled
        // GraphQL -> isSelfServiceEnabled: Boolean! (scalar)
        if (this.IsSelfServiceEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSelfServiceEnabled\n" ;
            } else {
                s += ind + "isSelfServiceEnabled\n" ;
            }
        }
        //      C# -> System.Int32? LoginAttemptsLimit
        // GraphQL -> loginAttemptsLimit: Int! (scalar)
        if (this.LoginAttemptsLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "loginAttemptsLimit\n" ;
            } else {
                s += ind + "loginAttemptsLimit\n" ;
            }
        }
        //      C# -> System.Int32? SelfServiceAttemptsLimit
        // GraphQL -> selfServiceAttemptsLimit: Int! (scalar)
        if (this.SelfServiceAttemptsLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "selfServiceAttemptsLimit\n" ;
            } else {
                s += ind + "selfServiceAttemptsLimit\n" ;
            }
        }
        //      C# -> System.Int32? SelfServiceTokenValidityInMins
        // GraphQL -> selfServiceTokenValidityInMins: Int! (scalar)
        if (this.SelfServiceTokenValidityInMins != null) {
            if (conf.Flat) {
                s += conf.Prefix + "selfServiceTokenValidityInMins\n" ;
            } else {
                s += ind + "selfServiceTokenValidityInMins\n" ;
            }
        }
        //      C# -> InactiveLockoutConfig? InactiveLockoutConfig
        // GraphQL -> inactiveLockoutConfig: InactiveLockoutConfig! (type)
        if (this.InactiveLockoutConfig != null) {
            var fspec = this.InactiveLockoutConfig.AsFieldSpec(conf.Child("inactiveLockoutConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "inactiveLockoutConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? AccountAutoUnlockDurationInMins
        // GraphQL -> accountAutoUnlockDurationInMins: Int! (scalar)
        if (ec.Includes("accountAutoUnlockDurationInMins",true))
        {
            if(this.AccountAutoUnlockDurationInMins == null) {

                this.AccountAutoUnlockDurationInMins = Int32.MinValue;

            } else {


            }
        }
        else if (this.AccountAutoUnlockDurationInMins != null && ec.Excludes("accountAutoUnlockDurationInMins",true))
        {
            this.AccountAutoUnlockDurationInMins = null;
        }
        //      C# -> System.Boolean? IsAutoUnlockFeatureEnabled
        // GraphQL -> isAutoUnlockFeatureEnabled: Boolean! (scalar)
        if (ec.Includes("isAutoUnlockFeatureEnabled",true))
        {
            if(this.IsAutoUnlockFeatureEnabled == null) {

                this.IsAutoUnlockFeatureEnabled = true;

            } else {


            }
        }
        else if (this.IsAutoUnlockFeatureEnabled != null && ec.Excludes("isAutoUnlockFeatureEnabled",true))
        {
            this.IsAutoUnlockFeatureEnabled = null;
        }
        //      C# -> System.Boolean? IsBruteForceLockoutEnabled
        // GraphQL -> isBruteForceLockoutEnabled: Boolean! (scalar)
        if (ec.Includes("isBruteForceLockoutEnabled",true))
        {
            if(this.IsBruteForceLockoutEnabled == null) {

                this.IsBruteForceLockoutEnabled = true;

            } else {


            }
        }
        else if (this.IsBruteForceLockoutEnabled != null && ec.Excludes("isBruteForceLockoutEnabled",true))
        {
            this.IsBruteForceLockoutEnabled = null;
        }
        //      C# -> System.Boolean? IsSelfServiceEnabled
        // GraphQL -> isSelfServiceEnabled: Boolean! (scalar)
        if (ec.Includes("isSelfServiceEnabled",true))
        {
            if(this.IsSelfServiceEnabled == null) {

                this.IsSelfServiceEnabled = true;

            } else {


            }
        }
        else if (this.IsSelfServiceEnabled != null && ec.Excludes("isSelfServiceEnabled",true))
        {
            this.IsSelfServiceEnabled = null;
        }
        //      C# -> System.Int32? LoginAttemptsLimit
        // GraphQL -> loginAttemptsLimit: Int! (scalar)
        if (ec.Includes("loginAttemptsLimit",true))
        {
            if(this.LoginAttemptsLimit == null) {

                this.LoginAttemptsLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.LoginAttemptsLimit != null && ec.Excludes("loginAttemptsLimit",true))
        {
            this.LoginAttemptsLimit = null;
        }
        //      C# -> System.Int32? SelfServiceAttemptsLimit
        // GraphQL -> selfServiceAttemptsLimit: Int! (scalar)
        if (ec.Includes("selfServiceAttemptsLimit",true))
        {
            if(this.SelfServiceAttemptsLimit == null) {

                this.SelfServiceAttemptsLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.SelfServiceAttemptsLimit != null && ec.Excludes("selfServiceAttemptsLimit",true))
        {
            this.SelfServiceAttemptsLimit = null;
        }
        //      C# -> System.Int32? SelfServiceTokenValidityInMins
        // GraphQL -> selfServiceTokenValidityInMins: Int! (scalar)
        if (ec.Includes("selfServiceTokenValidityInMins",true))
        {
            if(this.SelfServiceTokenValidityInMins == null) {

                this.SelfServiceTokenValidityInMins = Int32.MinValue;

            } else {


            }
        }
        else if (this.SelfServiceTokenValidityInMins != null && ec.Excludes("selfServiceTokenValidityInMins",true))
        {
            this.SelfServiceTokenValidityInMins = null;
        }
        //      C# -> InactiveLockoutConfig? InactiveLockoutConfig
        // GraphQL -> inactiveLockoutConfig: InactiveLockoutConfig! (type)
        if (ec.Includes("inactiveLockoutConfig",false))
        {
            if(this.InactiveLockoutConfig == null) {

                this.InactiveLockoutConfig = new InactiveLockoutConfig();
                this.InactiveLockoutConfig.ApplyExploratoryFieldSpec(ec.NewChild("inactiveLockoutConfig"));

            } else {

                this.InactiveLockoutConfig.ApplyExploratoryFieldSpec(ec.NewChild("inactiveLockoutConfig"));

            }
        }
        else if (this.InactiveLockoutConfig != null && ec.Excludes("inactiveLockoutConfig",false))
        {
            this.InactiveLockoutConfig = null;
        }
    }


    #endregion

    } // class LockoutConfig
    
    #endregion

    public static class ListLockoutConfigExtensions
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
            this List<LockoutConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LockoutConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LockoutConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LockoutConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LockoutConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types