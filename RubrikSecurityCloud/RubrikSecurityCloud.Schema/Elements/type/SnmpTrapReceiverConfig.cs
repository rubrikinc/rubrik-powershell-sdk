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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region SnmpTrapReceiverConfig
    public class SnmpTrapReceiverConfig: BaseType
    {
        #region members

        //      C# -> SnmpSecurityLevel? SecurityLevel
        // GraphQL -> securityLevel: SnmpSecurityLevel (enum)
        [JsonProperty("securityLevel")]
        public SnmpSecurityLevel? SecurityLevel { get; set; }

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


        #endregion

    #region methods

    public SnmpTrapReceiverConfig Set(
        SnmpSecurityLevel? SecurityLevel = null,
        System.String? Address = null,
        System.Int32? Port = null,
        System.String? User = null
    ) 
    {
        if ( SecurityLevel != null ) {
            this.SecurityLevel = SecurityLevel;
        }
        if ( Address != null ) {
            this.Address = Address;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( User != null ) {
            this.User = User;
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
        //      C# -> SnmpSecurityLevel? SecurityLevel
        // GraphQL -> securityLevel: SnmpSecurityLevel (enum)
        if (this.SecurityLevel != null) {
            s += ind + "securityLevel\n" ;
        }
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address != null) {
            s += ind + "address\n" ;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        //      C# -> System.String? User
        // GraphQL -> user: String (scalar)
        if (this.User != null) {
            s += ind + "user\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SnmpSecurityLevel? SecurityLevel
        // GraphQL -> securityLevel: SnmpSecurityLevel (enum)
        if (this.SecurityLevel == null && Exploration.Includes(parent + ".securityLevel", true))
        {
            this.SecurityLevel = new SnmpSecurityLevel();
        }
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address == null && Exploration.Includes(parent + ".address", true))
        {
            this.Address = "FETCH";
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port == null && Exploration.Includes(parent + ".port", true))
        {
            this.Port = Int32.MinValue;
        }
        //      C# -> System.String? User
        // GraphQL -> user: String (scalar)
        if (this.User == null && Exploration.Includes(parent + ".user", true))
        {
            this.User = "FETCH";
        }
    }


    #endregion

    } // class SnmpTrapReceiverConfig
    
    #endregion

    public static class ListSnmpTrapReceiverConfigExtensions
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
            this List<SnmpTrapReceiverConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnmpTrapReceiverConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnmpTrapReceiverConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types