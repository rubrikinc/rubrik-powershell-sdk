// SnmpTrapReceiverConfig.cs
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
    #region SnmpTrapReceiverConfig
    public class SnmpTrapReceiverConfig: IFragment
    {
        #region members
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        [JsonProperty("address")]
        public System.String? Address { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.String? User
        // GraphQL -> user: String (scalar)
        [JsonProperty("user")]
        public System.String? User { get; set; }

        //      C# -> SnmpSecurityLevel? SecurityLevel
        // GraphQL -> securityLevel: SnmpSecurityLevel (enum)
        [JsonProperty("securityLevel")]
        public SnmpSecurityLevel? SecurityLevel { get; set; }

        #endregion

    #region methods

    public SnmpTrapReceiverConfig Set(
        System.String? Address = null,
        System.Int32? Port = null,
        System.String? User = null,
        SnmpSecurityLevel? SecurityLevel = null
    ) 
    {
        if ( Address != null ) {
            this.Address = Address;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( User != null ) {
            this.User = User;
        }
        if ( SecurityLevel != null ) {
            this.SecurityLevel = SecurityLevel;
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
            //      C# -> System.String? Address
            // GraphQL -> address: String! (scalar)
            if (this.Address != null)
            {
                 s += ind + "address\n";

            }
            //      C# -> System.Int32? Port
            // GraphQL -> port: Int! (scalar)
            if (this.Port != null)
            {
                 s += ind + "port\n";

            }
            //      C# -> System.String? User
            // GraphQL -> user: String (scalar)
            if (this.User != null)
            {
                 s += ind + "user\n";

            }
            //      C# -> SnmpSecurityLevel? SecurityLevel
            // GraphQL -> securityLevel: SnmpSecurityLevel (enum)
            if (this.SecurityLevel != null)
            {
                 s += ind + "securityLevel\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Address
            // GraphQL -> address: String! (scalar)
            if (this.Address == null && Exploration.Includes(parent + ".address$"))
            {
                this.Address = new System.String("FETCH");
            }
            //      C# -> System.Int32? Port
            // GraphQL -> port: Int! (scalar)
            if (this.Port == null && Exploration.Includes(parent + ".port$"))
            {
                this.Port = new System.Int32();
            }
            //      C# -> System.String? User
            // GraphQL -> user: String (scalar)
            if (this.User == null && Exploration.Includes(parent + ".user$"))
            {
                this.User = new System.String("FETCH");
            }
            //      C# -> SnmpSecurityLevel? SecurityLevel
            // GraphQL -> securityLevel: SnmpSecurityLevel (enum)
            if (this.SecurityLevel == null && Exploration.Includes(parent + ".securityLevel$"))
            {
                this.SecurityLevel = new SnmpSecurityLevel();
            }
        }


    #endregion

    } // class SnmpTrapReceiverConfig
    #endregion

    public static class ListSnmpTrapReceiverConfigExtensions
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
            this List<SnmpTrapReceiverConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnmpTrapReceiverConfig> list, 
            String parent = "")
        {
            var item = new SnmpTrapReceiverConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types