// SupportTunnelInfo.cs
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
    #region SupportTunnelInfo
    public class SupportTunnelInfo: IFragment
    {
        #region members
        //      C# -> DateTime? EnabledTime
        // GraphQL -> enabledTime: DateTime (scalar)
        [JsonProperty("enabledTime")]
        public DateTime? EnabledTime { get; set; }

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long (scalar)
        [JsonProperty("inactivityTimeoutInSeconds")]
        public System.Int64? InactivityTimeoutInSeconds { get; set; }

        //      C# -> System.Boolean? IsTunnelEnabled
        // GraphQL -> isTunnelEnabled: Boolean! (scalar)
        [JsonProperty("isTunnelEnabled")]
        public System.Boolean? IsTunnelEnabled { get; set; }

        //      C# -> DateTime? LastActivityTime
        // GraphQL -> lastActivityTime: DateTime (scalar)
        [JsonProperty("lastActivityTime")]
        public DateTime? LastActivityTime { get; set; }

        //      C# -> System.Int64? Port
        // GraphQL -> port: Long (scalar)
        [JsonProperty("port")]
        public System.Int64? Port { get; set; }

        #endregion

    #region methods

    public SupportTunnelInfo Set(
        DateTime? EnabledTime = null,
        System.String? ErrorMessage = null,
        System.Int64? InactivityTimeoutInSeconds = null,
        System.Boolean? IsTunnelEnabled = null,
        DateTime? LastActivityTime = null,
        System.Int64? Port = null
    ) 
    {
        if ( EnabledTime != null ) {
            this.EnabledTime = EnabledTime;
        }
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( InactivityTimeoutInSeconds != null ) {
            this.InactivityTimeoutInSeconds = InactivityTimeoutInSeconds;
        }
        if ( IsTunnelEnabled != null ) {
            this.IsTunnelEnabled = IsTunnelEnabled;
        }
        if ( LastActivityTime != null ) {
            this.LastActivityTime = LastActivityTime;
        }
        if ( Port != null ) {
            this.Port = Port;
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
            //      C# -> DateTime? EnabledTime
            // GraphQL -> enabledTime: DateTime (scalar)
            if (this.EnabledTime != null)
            {
                 s += ind + "enabledTime\n";

            }
            //      C# -> System.String? ErrorMessage
            // GraphQL -> errorMessage: String (scalar)
            if (this.ErrorMessage != null)
            {
                 s += ind + "errorMessage\n";

            }
            //      C# -> System.Int64? InactivityTimeoutInSeconds
            // GraphQL -> inactivityTimeoutInSeconds: Long (scalar)
            if (this.InactivityTimeoutInSeconds != null)
            {
                 s += ind + "inactivityTimeoutInSeconds\n";

            }
            //      C# -> System.Boolean? IsTunnelEnabled
            // GraphQL -> isTunnelEnabled: Boolean! (scalar)
            if (this.IsTunnelEnabled != null)
            {
                 s += ind + "isTunnelEnabled\n";

            }
            //      C# -> DateTime? LastActivityTime
            // GraphQL -> lastActivityTime: DateTime (scalar)
            if (this.LastActivityTime != null)
            {
                 s += ind + "lastActivityTime\n";

            }
            //      C# -> System.Int64? Port
            // GraphQL -> port: Long (scalar)
            if (this.Port != null)
            {
                 s += ind + "port\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? EnabledTime
            // GraphQL -> enabledTime: DateTime (scalar)
            if (this.EnabledTime == null && Exploration.Includes(parent + ".enabledTime$"))
            {
                this.EnabledTime = new DateTime();
            }
            //      C# -> System.String? ErrorMessage
            // GraphQL -> errorMessage: String (scalar)
            if (this.ErrorMessage == null && Exploration.Includes(parent + ".errorMessage$"))
            {
                this.ErrorMessage = new System.String("FETCH");
            }
            //      C# -> System.Int64? InactivityTimeoutInSeconds
            // GraphQL -> inactivityTimeoutInSeconds: Long (scalar)
            if (this.InactivityTimeoutInSeconds == null && Exploration.Includes(parent + ".inactivityTimeoutInSeconds$"))
            {
                this.InactivityTimeoutInSeconds = new System.Int64();
            }
            //      C# -> System.Boolean? IsTunnelEnabled
            // GraphQL -> isTunnelEnabled: Boolean! (scalar)
            if (this.IsTunnelEnabled == null && Exploration.Includes(parent + ".isTunnelEnabled$"))
            {
                this.IsTunnelEnabled = new System.Boolean();
            }
            //      C# -> DateTime? LastActivityTime
            // GraphQL -> lastActivityTime: DateTime (scalar)
            if (this.LastActivityTime == null && Exploration.Includes(parent + ".lastActivityTime$"))
            {
                this.LastActivityTime = new DateTime();
            }
            //      C# -> System.Int64? Port
            // GraphQL -> port: Long (scalar)
            if (this.Port == null && Exploration.Includes(parent + ".port$"))
            {
                this.Port = new System.Int64();
            }
        }


    #endregion

    } // class SupportTunnelInfo
    #endregion

    public static class ListSupportTunnelInfoExtensions
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
            this List<SupportTunnelInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SupportTunnelInfo> list, 
            String parent = "")
        {
            var item = new SupportTunnelInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types