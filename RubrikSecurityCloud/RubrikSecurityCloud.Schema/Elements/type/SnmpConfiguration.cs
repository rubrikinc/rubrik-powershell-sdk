// SnmpConfiguration.cs
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
    #region SnmpConfiguration
    public class SnmpConfiguration: IFragment
    {
        #region members
        //      C# -> System.String? CommunityString
        // GraphQL -> communityString: String (scalar)
        [JsonProperty("communityString")]
        public System.String? CommunityString { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.Int32? SnmpAgentPort
        // GraphQL -> snmpAgentPort: Int! (scalar)
        [JsonProperty("snmpAgentPort")]
        public System.Int32? SnmpAgentPort { get; set; }

        //      C# -> List<System.String>? Users
        // GraphQL -> users: [String!]! (scalar)
        [JsonProperty("users")]
        public List<System.String>? Users { get; set; }

        //      C# -> List<SnmpTrapReceiverConfig>? TrapReceiverConfigs
        // GraphQL -> trapReceiverConfigs: [SnmpTrapReceiverConfig!]! (type)
        [JsonProperty("trapReceiverConfigs")]
        public List<SnmpTrapReceiverConfig>? TrapReceiverConfigs { get; set; }

        #endregion

    #region methods

    public SnmpConfiguration Set(
        System.String? CommunityString = null,
        System.Boolean? IsEnabled = null,
        System.Int32? SnmpAgentPort = null,
        List<System.String>? Users = null,
        List<SnmpTrapReceiverConfig>? TrapReceiverConfigs = null
    ) 
    {
        if ( CommunityString != null ) {
            this.CommunityString = CommunityString;
        }
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( SnmpAgentPort != null ) {
            this.SnmpAgentPort = SnmpAgentPort;
        }
        if ( Users != null ) {
            this.Users = Users;
        }
        if ( TrapReceiverConfigs != null ) {
            this.TrapReceiverConfigs = TrapReceiverConfigs;
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
            //      C# -> System.String? CommunityString
            // GraphQL -> communityString: String (scalar)
            if (this.CommunityString != null)
            {
                 s += ind + "communityString\n";

            }
            //      C# -> System.Boolean? IsEnabled
            // GraphQL -> isEnabled: Boolean! (scalar)
            if (this.IsEnabled != null)
            {
                 s += ind + "isEnabled\n";

            }
            //      C# -> System.Int32? SnmpAgentPort
            // GraphQL -> snmpAgentPort: Int! (scalar)
            if (this.SnmpAgentPort != null)
            {
                 s += ind + "snmpAgentPort\n";

            }
            //      C# -> List<System.String>? Users
            // GraphQL -> users: [String!]! (scalar)
            if (this.Users != null)
            {
                 s += ind + "users\n";

            }
            //      C# -> List<SnmpTrapReceiverConfig>? TrapReceiverConfigs
            // GraphQL -> trapReceiverConfigs: [SnmpTrapReceiverConfig!]! (type)
            if (this.TrapReceiverConfigs != null)
            {
                 s += ind + "trapReceiverConfigs\n";

                 s += ind + "{\n" + 
                 this.TrapReceiverConfigs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CommunityString
            // GraphQL -> communityString: String (scalar)
            if (this.CommunityString == null && Exploration.Includes(parent + ".communityString$"))
            {
                this.CommunityString = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsEnabled
            // GraphQL -> isEnabled: Boolean! (scalar)
            if (this.IsEnabled == null && Exploration.Includes(parent + ".isEnabled$"))
            {
                this.IsEnabled = new System.Boolean();
            }
            //      C# -> System.Int32? SnmpAgentPort
            // GraphQL -> snmpAgentPort: Int! (scalar)
            if (this.SnmpAgentPort == null && Exploration.Includes(parent + ".snmpAgentPort$"))
            {
                this.SnmpAgentPort = new System.Int32();
            }
            //      C# -> List<System.String>? Users
            // GraphQL -> users: [String!]! (scalar)
            if (this.Users == null && Exploration.Includes(parent + ".users$"))
            {
                this.Users = new List<System.String>();
            }
            //      C# -> List<SnmpTrapReceiverConfig>? TrapReceiverConfigs
            // GraphQL -> trapReceiverConfigs: [SnmpTrapReceiverConfig!]! (type)
            if (this.TrapReceiverConfigs == null && Exploration.Includes(parent + ".trapReceiverConfigs"))
            {
                this.TrapReceiverConfigs = new List<SnmpTrapReceiverConfig>();
                this.TrapReceiverConfigs.ApplyExploratoryFragment(parent + ".trapReceiverConfigs");
            }
        }


    #endregion

    } // class SnmpConfiguration
    #endregion

    public static class ListSnmpConfigurationExtensions
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
            this List<SnmpConfiguration> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnmpConfiguration> list, 
            String parent = "")
        {
            var item = new SnmpConfiguration();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types