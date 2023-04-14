// TotpStatus.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region TotpStatus
    public class TotpStatus: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.Boolean? IsEnforced
        // GraphQL -> isEnforced: Boolean! (scalar)
        [JsonProperty("isEnforced")]
        public System.Boolean? IsEnforced { get; set; }

        //      C# -> System.Boolean? IsEnforcedUserLevel
        // GraphQL -> isEnforcedUserLevel: Boolean! (scalar)
        [JsonProperty("isEnforcedUserLevel")]
        public System.Boolean? IsEnforcedUserLevel { get; set; }

        //      C# -> System.Boolean? IsSupported
        // GraphQL -> isSupported: Boolean! (scalar)
        [JsonProperty("isSupported")]
        public System.Boolean? IsSupported { get; set; }

        //      C# -> DateTime? TotpConfigUpdateAt
        // GraphQL -> totpConfigUpdateAt: DateTime (scalar)
        [JsonProperty("totpConfigUpdateAt")]
        public DateTime? TotpConfigUpdateAt { get; set; }

        #endregion

    #region methods

    public TotpStatus Set(
        System.Boolean? IsEnabled = null,
        System.Boolean? IsEnforced = null,
        System.Boolean? IsEnforcedUserLevel = null,
        System.Boolean? IsSupported = null,
        DateTime? TotpConfigUpdateAt = null
    ) 
    {
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( IsEnforced != null ) {
            this.IsEnforced = IsEnforced;
        }
        if ( IsEnforcedUserLevel != null ) {
            this.IsEnforcedUserLevel = IsEnforcedUserLevel;
        }
        if ( IsSupported != null ) {
            this.IsSupported = IsSupported;
        }
        if ( TotpConfigUpdateAt != null ) {
            this.TotpConfigUpdateAt = TotpConfigUpdateAt;
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
            //      C# -> System.Boolean? IsEnabled
            // GraphQL -> isEnabled: Boolean! (scalar)
            if (this.IsEnabled != null)
            {
                 s += ind + "isEnabled\n";

            }
            //      C# -> System.Boolean? IsEnforced
            // GraphQL -> isEnforced: Boolean! (scalar)
            if (this.IsEnforced != null)
            {
                 s += ind + "isEnforced\n";

            }
            //      C# -> System.Boolean? IsEnforcedUserLevel
            // GraphQL -> isEnforcedUserLevel: Boolean! (scalar)
            if (this.IsEnforcedUserLevel != null)
            {
                 s += ind + "isEnforcedUserLevel\n";

            }
            //      C# -> System.Boolean? IsSupported
            // GraphQL -> isSupported: Boolean! (scalar)
            if (this.IsSupported != null)
            {
                 s += ind + "isSupported\n";

            }
            //      C# -> DateTime? TotpConfigUpdateAt
            // GraphQL -> totpConfigUpdateAt: DateTime (scalar)
            if (this.TotpConfigUpdateAt != null)
            {
                 s += ind + "totpConfigUpdateAt\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsEnabled
            // GraphQL -> isEnabled: Boolean! (scalar)
            if (this.IsEnabled == null && Exploration.Includes(parent + ".isEnabled$"))
            {
                this.IsEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsEnforced
            // GraphQL -> isEnforced: Boolean! (scalar)
            if (this.IsEnforced == null && Exploration.Includes(parent + ".isEnforced$"))
            {
                this.IsEnforced = new System.Boolean();
            }
            //      C# -> System.Boolean? IsEnforcedUserLevel
            // GraphQL -> isEnforcedUserLevel: Boolean! (scalar)
            if (this.IsEnforcedUserLevel == null && Exploration.Includes(parent + ".isEnforcedUserLevel$"))
            {
                this.IsEnforcedUserLevel = new System.Boolean();
            }
            //      C# -> System.Boolean? IsSupported
            // GraphQL -> isSupported: Boolean! (scalar)
            if (this.IsSupported == null && Exploration.Includes(parent + ".isSupported$"))
            {
                this.IsSupported = new System.Boolean();
            }
            //      C# -> DateTime? TotpConfigUpdateAt
            // GraphQL -> totpConfigUpdateAt: DateTime (scalar)
            if (this.TotpConfigUpdateAt == null && Exploration.Includes(parent + ".totpConfigUpdateAt$"))
            {
                this.TotpConfigUpdateAt = new DateTime();
            }
        }


    #endregion

    } // class TotpStatus
    #endregion

    public static class ListTotpStatusExtensions
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
            this List<TotpStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TotpStatus> list, 
            String parent = "")
        {
            var item = new TotpStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types