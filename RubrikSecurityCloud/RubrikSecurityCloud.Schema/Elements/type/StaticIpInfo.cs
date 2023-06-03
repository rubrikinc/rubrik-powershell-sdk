// StaticIpInfo.cs
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
    #region StaticIpInfo
    public class StaticIpInfo: BaseType
    {
        #region members

        //      C# -> List<System.String>? DnsServers
        // GraphQL -> dnsServers: [String!]! (scalar)
        [JsonProperty("dnsServers")]
        public List<System.String>? DnsServers { get; set; }

        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String (scalar)
        [JsonProperty("gateway")]
        public System.String? Gateway { get; set; }

        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        [JsonProperty("ipAddresses")]
        public List<System.String>? IpAddresses { get; set; }

        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String! (scalar)
        [JsonProperty("subnetMask")]
        public System.String? SubnetMask { get; set; }


        #endregion

    #region methods

    public StaticIpInfo Set(
        List<System.String>? DnsServers = null,
        System.String? Gateway = null,
        List<System.String>? IpAddresses = null,
        System.String? SubnetMask = null
    ) 
    {
        if ( DnsServers != null ) {
            this.DnsServers = DnsServers;
        }
        if ( Gateway != null ) {
            this.Gateway = Gateway;
        }
        if ( IpAddresses != null ) {
            this.IpAddresses = IpAddresses;
        }
        if ( SubnetMask != null ) {
            this.SubnetMask = SubnetMask;
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
        //      C# -> List<System.String>? DnsServers
        // GraphQL -> dnsServers: [String!]! (scalar)
        if (this.DnsServers != null) {
            s += ind + "dnsServers\n" ;
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String (scalar)
        if (this.Gateway != null) {
            s += ind + "gateway\n" ;
        }
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (this.IpAddresses != null) {
            s += ind + "ipAddresses\n" ;
        }
        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String! (scalar)
        if (this.SubnetMask != null) {
            s += ind + "subnetMask\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? DnsServers
        // GraphQL -> dnsServers: [String!]! (scalar)
        if (this.DnsServers == null && Exploration.Includes(parent + ".dnsServers", true))
        {
            this.DnsServers = new List<System.String>();
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String (scalar)
        if (this.Gateway == null && Exploration.Includes(parent + ".gateway", true))
        {
            this.Gateway = new System.String("FETCH");
        }
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (this.IpAddresses == null && Exploration.Includes(parent + ".ipAddresses", true))
        {
            this.IpAddresses = new List<System.String>();
        }
        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String! (scalar)
        if (this.SubnetMask == null && Exploration.Includes(parent + ".subnetMask", true))
        {
            this.SubnetMask = new System.String("FETCH");
        }
    }


    #endregion

    } // class StaticIpInfo
    
    #endregion

    public static class ListStaticIpInfoExtensions
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
            this List<StaticIpInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StaticIpInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new StaticIpInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types