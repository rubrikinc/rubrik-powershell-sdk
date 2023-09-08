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
        System.Int32? SelfServiceTokenValidityInMins = null
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? AccountAutoUnlockDurationInMins
        // GraphQL -> accountAutoUnlockDurationInMins: Int! (scalar)
        if (this.AccountAutoUnlockDurationInMins != null) {
            s += ind + "accountAutoUnlockDurationInMins\n" ;
        }
        //      C# -> System.Boolean? IsAutoUnlockFeatureEnabled
        // GraphQL -> isAutoUnlockFeatureEnabled: Boolean! (scalar)
        if (this.IsAutoUnlockFeatureEnabled != null) {
            s += ind + "isAutoUnlockFeatureEnabled\n" ;
        }
        //      C# -> System.Boolean? IsBruteForceLockoutEnabled
        // GraphQL -> isBruteForceLockoutEnabled: Boolean! (scalar)
        if (this.IsBruteForceLockoutEnabled != null) {
            s += ind + "isBruteForceLockoutEnabled\n" ;
        }
        //      C# -> System.Boolean? IsSelfServiceEnabled
        // GraphQL -> isSelfServiceEnabled: Boolean! (scalar)
        if (this.IsSelfServiceEnabled != null) {
            s += ind + "isSelfServiceEnabled\n" ;
        }
        //      C# -> System.Int32? LoginAttemptsLimit
        // GraphQL -> loginAttemptsLimit: Int! (scalar)
        if (this.LoginAttemptsLimit != null) {
            s += ind + "loginAttemptsLimit\n" ;
        }
        //      C# -> System.Int32? SelfServiceAttemptsLimit
        // GraphQL -> selfServiceAttemptsLimit: Int! (scalar)
        if (this.SelfServiceAttemptsLimit != null) {
            s += ind + "selfServiceAttemptsLimit\n" ;
        }
        //      C# -> System.Int32? SelfServiceTokenValidityInMins
        // GraphQL -> selfServiceTokenValidityInMins: Int! (scalar)
        if (this.SelfServiceTokenValidityInMins != null) {
            s += ind + "selfServiceTokenValidityInMins\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? AccountAutoUnlockDurationInMins
        // GraphQL -> accountAutoUnlockDurationInMins: Int! (scalar)
        if (this.AccountAutoUnlockDurationInMins == null && ec.Includes("accountAutoUnlockDurationInMins",true))
        {
            this.AccountAutoUnlockDurationInMins = Int32.MinValue;
        }
        //      C# -> System.Boolean? IsAutoUnlockFeatureEnabled
        // GraphQL -> isAutoUnlockFeatureEnabled: Boolean! (scalar)
        if (this.IsAutoUnlockFeatureEnabled == null && ec.Includes("isAutoUnlockFeatureEnabled",true))
        {
            this.IsAutoUnlockFeatureEnabled = true;
        }
        //      C# -> System.Boolean? IsBruteForceLockoutEnabled
        // GraphQL -> isBruteForceLockoutEnabled: Boolean! (scalar)
        if (this.IsBruteForceLockoutEnabled == null && ec.Includes("isBruteForceLockoutEnabled",true))
        {
            this.IsBruteForceLockoutEnabled = true;
        }
        //      C# -> System.Boolean? IsSelfServiceEnabled
        // GraphQL -> isSelfServiceEnabled: Boolean! (scalar)
        if (this.IsSelfServiceEnabled == null && ec.Includes("isSelfServiceEnabled",true))
        {
            this.IsSelfServiceEnabled = true;
        }
        //      C# -> System.Int32? LoginAttemptsLimit
        // GraphQL -> loginAttemptsLimit: Int! (scalar)
        if (this.LoginAttemptsLimit == null && ec.Includes("loginAttemptsLimit",true))
        {
            this.LoginAttemptsLimit = Int32.MinValue;
        }
        //      C# -> System.Int32? SelfServiceAttemptsLimit
        // GraphQL -> selfServiceAttemptsLimit: Int! (scalar)
        if (this.SelfServiceAttemptsLimit == null && ec.Includes("selfServiceAttemptsLimit",true))
        {
            this.SelfServiceAttemptsLimit = Int32.MinValue;
        }
        //      C# -> System.Int32? SelfServiceTokenValidityInMins
        // GraphQL -> selfServiceTokenValidityInMins: Int! (scalar)
        if (this.SelfServiceTokenValidityInMins == null && ec.Includes("selfServiceTokenValidityInMins",true))
        {
            this.SelfServiceTokenValidityInMins = Int32.MinValue;
        }
    }


    #endregion

    } // class LockoutConfig
    
    #endregion

    public static class ListLockoutConfigExtensions
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
            this List<LockoutConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LockoutConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LockoutConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<LockoutConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types