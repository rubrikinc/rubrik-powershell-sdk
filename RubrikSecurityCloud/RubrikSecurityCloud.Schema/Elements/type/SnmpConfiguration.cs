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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region SnmpConfiguration
    public class SnmpConfiguration: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CommunityString
        // GraphQL -> communityString: String (scalar)
        if (this.CommunityString != null) {
            s += ind + "communityString\n" ;
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            s += ind + "isEnabled\n" ;
        }
        //      C# -> System.Int32? SnmpAgentPort
        // GraphQL -> snmpAgentPort: Int! (scalar)
        if (this.SnmpAgentPort != null) {
            s += ind + "snmpAgentPort\n" ;
        }
        //      C# -> List<System.String>? Users
        // GraphQL -> users: [String!]! (scalar)
        if (this.Users != null) {
            s += ind + "users\n" ;
        }
        //      C# -> List<SnmpTrapReceiverConfig>? TrapReceiverConfigs
        // GraphQL -> trapReceiverConfigs: [SnmpTrapReceiverConfig!]! (type)
        if (this.TrapReceiverConfigs != null) {
            var fspec = this.TrapReceiverConfigs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "trapReceiverConfigs {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CommunityString
        // GraphQL -> communityString: String (scalar)
        if (this.CommunityString == null && Exploration.Includes(parent + ".communityString", true))
        {
            this.CommunityString = "FETCH";
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled == null && Exploration.Includes(parent + ".isEnabled", true))
        {
            this.IsEnabled = true;
        }
        //      C# -> System.Int32? SnmpAgentPort
        // GraphQL -> snmpAgentPort: Int! (scalar)
        if (this.SnmpAgentPort == null && Exploration.Includes(parent + ".snmpAgentPort", true))
        {
            this.SnmpAgentPort = Int32.MinValue;
        }
        //      C# -> List<System.String>? Users
        // GraphQL -> users: [String!]! (scalar)
        if (this.Users == null && Exploration.Includes(parent + ".users", true))
        {
            this.Users = new List<System.String>();
        }
        //      C# -> List<SnmpTrapReceiverConfig>? TrapReceiverConfigs
        // GraphQL -> trapReceiverConfigs: [SnmpTrapReceiverConfig!]! (type)
        if (this.TrapReceiverConfigs == null && Exploration.Includes(parent + ".trapReceiverConfigs"))
        {
            this.TrapReceiverConfigs = new List<SnmpTrapReceiverConfig>();
            this.TrapReceiverConfigs.ApplyExploratoryFieldSpec(parent + ".trapReceiverConfigs");
        }
    }


    #endregion

    } // class SnmpConfiguration
    
    #endregion

    public static class ListSnmpConfigurationExtensions
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
            this List<SnmpConfiguration> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnmpConfiguration> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnmpConfiguration());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types