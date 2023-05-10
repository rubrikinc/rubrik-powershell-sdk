// UserSessionManagementConfig.cs
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
    #region UserSessionManagementConfig
    public class UserSessionManagementConfig: IFragment
    {
        #region members
        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long! (scalar)
        [JsonProperty("inactivityTimeoutInSeconds")]
        public System.Int64? InactivityTimeoutInSeconds { get; set; }

        //      C# -> System.Int64? InactivityTimeoutInSecondsMaxLimit
        // GraphQL -> inactivityTimeoutInSecondsMaxLimit: Long! (scalar)
        [JsonProperty("inactivityTimeoutInSecondsMaxLimit")]
        public System.Int64? InactivityTimeoutInSecondsMaxLimit { get; set; }

        //      C# -> System.Int64? InactivityTimeoutInSecondsMinLimit
        // GraphQL -> inactivityTimeoutInSecondsMinLimit: Long! (scalar)
        [JsonProperty("inactivityTimeoutInSecondsMinLimit")]
        public System.Int64? InactivityTimeoutInSecondsMinLimit { get; set; }

        //      C# -> System.Boolean? IsConcurrentSessionLimitationEnabled
        // GraphQL -> isConcurrentSessionLimitationEnabled: Boolean! (scalar)
        [JsonProperty("isConcurrentSessionLimitationEnabled")]
        public System.Boolean? IsConcurrentSessionLimitationEnabled { get; set; }

        //      C# -> System.Boolean? IsInactivityTimeoutEnabled
        // GraphQL -> isInactivityTimeoutEnabled: Boolean! (scalar)
        [JsonProperty("isInactivityTimeoutEnabled")]
        public System.Boolean? IsInactivityTimeoutEnabled { get; set; }

        //      C# -> System.Int32? MaxConcurrentSessions
        // GraphQL -> maxConcurrentSessions: Int! (scalar)
        [JsonProperty("maxConcurrentSessions")]
        public System.Int32? MaxConcurrentSessions { get; set; }

        //      C# -> System.Int32? MaxConcurrentSessionsMaxLimit
        // GraphQL -> maxConcurrentSessionsMaxLimit: Int! (scalar)
        [JsonProperty("maxConcurrentSessionsMaxLimit")]
        public System.Int32? MaxConcurrentSessionsMaxLimit { get; set; }

        //      C# -> System.Int64? SessionTimeoutInSeconds
        // GraphQL -> sessionTimeoutInSeconds: Long! (scalar)
        [JsonProperty("sessionTimeoutInSeconds")]
        public System.Int64? SessionTimeoutInSeconds { get; set; }

        #endregion

    #region methods

    public UserSessionManagementConfig Set(
        System.Int64? InactivityTimeoutInSeconds = null,
        System.Int64? InactivityTimeoutInSecondsMaxLimit = null,
        System.Int64? InactivityTimeoutInSecondsMinLimit = null,
        System.Boolean? IsConcurrentSessionLimitationEnabled = null,
        System.Boolean? IsInactivityTimeoutEnabled = null,
        System.Int32? MaxConcurrentSessions = null,
        System.Int32? MaxConcurrentSessionsMaxLimit = null,
        System.Int64? SessionTimeoutInSeconds = null
    ) 
    {
        if ( InactivityTimeoutInSeconds != null ) {
            this.InactivityTimeoutInSeconds = InactivityTimeoutInSeconds;
        }
        if ( InactivityTimeoutInSecondsMaxLimit != null ) {
            this.InactivityTimeoutInSecondsMaxLimit = InactivityTimeoutInSecondsMaxLimit;
        }
        if ( InactivityTimeoutInSecondsMinLimit != null ) {
            this.InactivityTimeoutInSecondsMinLimit = InactivityTimeoutInSecondsMinLimit;
        }
        if ( IsConcurrentSessionLimitationEnabled != null ) {
            this.IsConcurrentSessionLimitationEnabled = IsConcurrentSessionLimitationEnabled;
        }
        if ( IsInactivityTimeoutEnabled != null ) {
            this.IsInactivityTimeoutEnabled = IsInactivityTimeoutEnabled;
        }
        if ( MaxConcurrentSessions != null ) {
            this.MaxConcurrentSessions = MaxConcurrentSessions;
        }
        if ( MaxConcurrentSessionsMaxLimit != null ) {
            this.MaxConcurrentSessionsMaxLimit = MaxConcurrentSessionsMaxLimit;
        }
        if ( SessionTimeoutInSeconds != null ) {
            this.SessionTimeoutInSeconds = SessionTimeoutInSeconds;
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
            //      C# -> System.Int64? InactivityTimeoutInSeconds
            // GraphQL -> inactivityTimeoutInSeconds: Long! (scalar)
            if (this.InactivityTimeoutInSeconds != null)
            {
                 s += ind + "inactivityTimeoutInSeconds\n";

            }
            //      C# -> System.Int64? InactivityTimeoutInSecondsMaxLimit
            // GraphQL -> inactivityTimeoutInSecondsMaxLimit: Long! (scalar)
            if (this.InactivityTimeoutInSecondsMaxLimit != null)
            {
                 s += ind + "inactivityTimeoutInSecondsMaxLimit\n";

            }
            //      C# -> System.Int64? InactivityTimeoutInSecondsMinLimit
            // GraphQL -> inactivityTimeoutInSecondsMinLimit: Long! (scalar)
            if (this.InactivityTimeoutInSecondsMinLimit != null)
            {
                 s += ind + "inactivityTimeoutInSecondsMinLimit\n";

            }
            //      C# -> System.Boolean? IsConcurrentSessionLimitationEnabled
            // GraphQL -> isConcurrentSessionLimitationEnabled: Boolean! (scalar)
            if (this.IsConcurrentSessionLimitationEnabled != null)
            {
                 s += ind + "isConcurrentSessionLimitationEnabled\n";

            }
            //      C# -> System.Boolean? IsInactivityTimeoutEnabled
            // GraphQL -> isInactivityTimeoutEnabled: Boolean! (scalar)
            if (this.IsInactivityTimeoutEnabled != null)
            {
                 s += ind + "isInactivityTimeoutEnabled\n";

            }
            //      C# -> System.Int32? MaxConcurrentSessions
            // GraphQL -> maxConcurrentSessions: Int! (scalar)
            if (this.MaxConcurrentSessions != null)
            {
                 s += ind + "maxConcurrentSessions\n";

            }
            //      C# -> System.Int32? MaxConcurrentSessionsMaxLimit
            // GraphQL -> maxConcurrentSessionsMaxLimit: Int! (scalar)
            if (this.MaxConcurrentSessionsMaxLimit != null)
            {
                 s += ind + "maxConcurrentSessionsMaxLimit\n";

            }
            //      C# -> System.Int64? SessionTimeoutInSeconds
            // GraphQL -> sessionTimeoutInSeconds: Long! (scalar)
            if (this.SessionTimeoutInSeconds != null)
            {
                 s += ind + "sessionTimeoutInSeconds\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? InactivityTimeoutInSeconds
            // GraphQL -> inactivityTimeoutInSeconds: Long! (scalar)
            if (this.InactivityTimeoutInSeconds == null && Exploration.Includes(parent + ".inactivityTimeoutInSeconds$"))
            {
                this.InactivityTimeoutInSeconds = new System.Int64();
            }
            //      C# -> System.Int64? InactivityTimeoutInSecondsMaxLimit
            // GraphQL -> inactivityTimeoutInSecondsMaxLimit: Long! (scalar)
            if (this.InactivityTimeoutInSecondsMaxLimit == null && Exploration.Includes(parent + ".inactivityTimeoutInSecondsMaxLimit$"))
            {
                this.InactivityTimeoutInSecondsMaxLimit = new System.Int64();
            }
            //      C# -> System.Int64? InactivityTimeoutInSecondsMinLimit
            // GraphQL -> inactivityTimeoutInSecondsMinLimit: Long! (scalar)
            if (this.InactivityTimeoutInSecondsMinLimit == null && Exploration.Includes(parent + ".inactivityTimeoutInSecondsMinLimit$"))
            {
                this.InactivityTimeoutInSecondsMinLimit = new System.Int64();
            }
            //      C# -> System.Boolean? IsConcurrentSessionLimitationEnabled
            // GraphQL -> isConcurrentSessionLimitationEnabled: Boolean! (scalar)
            if (this.IsConcurrentSessionLimitationEnabled == null && Exploration.Includes(parent + ".isConcurrentSessionLimitationEnabled$"))
            {
                this.IsConcurrentSessionLimitationEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsInactivityTimeoutEnabled
            // GraphQL -> isInactivityTimeoutEnabled: Boolean! (scalar)
            if (this.IsInactivityTimeoutEnabled == null && Exploration.Includes(parent + ".isInactivityTimeoutEnabled$"))
            {
                this.IsInactivityTimeoutEnabled = new System.Boolean();
            }
            //      C# -> System.Int32? MaxConcurrentSessions
            // GraphQL -> maxConcurrentSessions: Int! (scalar)
            if (this.MaxConcurrentSessions == null && Exploration.Includes(parent + ".maxConcurrentSessions$"))
            {
                this.MaxConcurrentSessions = new System.Int32();
            }
            //      C# -> System.Int32? MaxConcurrentSessionsMaxLimit
            // GraphQL -> maxConcurrentSessionsMaxLimit: Int! (scalar)
            if (this.MaxConcurrentSessionsMaxLimit == null && Exploration.Includes(parent + ".maxConcurrentSessionsMaxLimit$"))
            {
                this.MaxConcurrentSessionsMaxLimit = new System.Int32();
            }
            //      C# -> System.Int64? SessionTimeoutInSeconds
            // GraphQL -> sessionTimeoutInSeconds: Long! (scalar)
            if (this.SessionTimeoutInSeconds == null && Exploration.Includes(parent + ".sessionTimeoutInSeconds$"))
            {
                this.SessionTimeoutInSeconds = new System.Int64();
            }
        }


    #endregion

    } // class UserSessionManagementConfig
    #endregion

    public static class ListUserSessionManagementConfigExtensions
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
            this List<UserSessionManagementConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UserSessionManagementConfig> list, 
            String parent = "")
        {
            var item = new UserSessionManagementConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types