// LockoutConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region LockoutConfig
    public class LockoutConfig: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? AccountAutoUnlockDurationInMins
            // GraphQL -> accountAutoUnlockDurationInMins: Int! (scalar)
            if (this.AccountAutoUnlockDurationInMins != null)
            {
                 s += ind + "accountAutoUnlockDurationInMins\n";

            }
            //      C# -> System.Boolean? IsAutoUnlockFeatureEnabled
            // GraphQL -> isAutoUnlockFeatureEnabled: Boolean! (scalar)
            if (this.IsAutoUnlockFeatureEnabled != null)
            {
                 s += ind + "isAutoUnlockFeatureEnabled\n";

            }
            //      C# -> System.Boolean? IsBruteForceLockoutEnabled
            // GraphQL -> isBruteForceLockoutEnabled: Boolean! (scalar)
            if (this.IsBruteForceLockoutEnabled != null)
            {
                 s += ind + "isBruteForceLockoutEnabled\n";

            }
            //      C# -> System.Boolean? IsSelfServiceEnabled
            // GraphQL -> isSelfServiceEnabled: Boolean! (scalar)
            if (this.IsSelfServiceEnabled != null)
            {
                 s += ind + "isSelfServiceEnabled\n";

            }
            //      C# -> System.Int32? LoginAttemptsLimit
            // GraphQL -> loginAttemptsLimit: Int! (scalar)
            if (this.LoginAttemptsLimit != null)
            {
                 s += ind + "loginAttemptsLimit\n";

            }
            //      C# -> System.Int32? SelfServiceAttemptsLimit
            // GraphQL -> selfServiceAttemptsLimit: Int! (scalar)
            if (this.SelfServiceAttemptsLimit != null)
            {
                 s += ind + "selfServiceAttemptsLimit\n";

            }
            //      C# -> System.Int32? SelfServiceTokenValidityInMins
            // GraphQL -> selfServiceTokenValidityInMins: Int! (scalar)
            if (this.SelfServiceTokenValidityInMins != null)
            {
                 s += ind + "selfServiceTokenValidityInMins\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? AccountAutoUnlockDurationInMins
            // GraphQL -> accountAutoUnlockDurationInMins: Int! (scalar)
            if (this.AccountAutoUnlockDurationInMins == null && Exploration.Includes(parent + ".accountAutoUnlockDurationInMins$"))
            {
                this.AccountAutoUnlockDurationInMins = new System.Int32();
            }
            //      C# -> System.Boolean? IsAutoUnlockFeatureEnabled
            // GraphQL -> isAutoUnlockFeatureEnabled: Boolean! (scalar)
            if (this.IsAutoUnlockFeatureEnabled == null && Exploration.Includes(parent + ".isAutoUnlockFeatureEnabled$"))
            {
                this.IsAutoUnlockFeatureEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsBruteForceLockoutEnabled
            // GraphQL -> isBruteForceLockoutEnabled: Boolean! (scalar)
            if (this.IsBruteForceLockoutEnabled == null && Exploration.Includes(parent + ".isBruteForceLockoutEnabled$"))
            {
                this.IsBruteForceLockoutEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsSelfServiceEnabled
            // GraphQL -> isSelfServiceEnabled: Boolean! (scalar)
            if (this.IsSelfServiceEnabled == null && Exploration.Includes(parent + ".isSelfServiceEnabled$"))
            {
                this.IsSelfServiceEnabled = new System.Boolean();
            }
            //      C# -> System.Int32? LoginAttemptsLimit
            // GraphQL -> loginAttemptsLimit: Int! (scalar)
            if (this.LoginAttemptsLimit == null && Exploration.Includes(parent + ".loginAttemptsLimit$"))
            {
                this.LoginAttemptsLimit = new System.Int32();
            }
            //      C# -> System.Int32? SelfServiceAttemptsLimit
            // GraphQL -> selfServiceAttemptsLimit: Int! (scalar)
            if (this.SelfServiceAttemptsLimit == null && Exploration.Includes(parent + ".selfServiceAttemptsLimit$"))
            {
                this.SelfServiceAttemptsLimit = new System.Int32();
            }
            //      C# -> System.Int32? SelfServiceTokenValidityInMins
            // GraphQL -> selfServiceTokenValidityInMins: Int! (scalar)
            if (this.SelfServiceTokenValidityInMins == null && Exploration.Includes(parent + ".selfServiceTokenValidityInMins$"))
            {
                this.SelfServiceTokenValidityInMins = new System.Int32();
            }
        }


    #endregion

    } // class LockoutConfig
    #endregion

    public static class ListLockoutConfigExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<LockoutConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LockoutConfig> list, 
            String parent = "")
        {
            var item = new LockoutConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types