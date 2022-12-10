// StaticIpInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:09.
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
    #region StaticIpInfo
    public class StaticIpInfo: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? DnsServers
            // GraphQL -> dnsServers: [String!]! (scalar)
            if (this.DnsServers != null)
            {
                 s += ind + "dnsServers\n";

            }
            //      C# -> System.String? Gateway
            // GraphQL -> gateway: String (scalar)
            if (this.Gateway != null)
            {
                 s += ind + "gateway\n";

            }
            //      C# -> List<System.String>? IpAddresses
            // GraphQL -> ipAddresses: [String!]! (scalar)
            if (this.IpAddresses != null)
            {
                 s += ind + "ipAddresses\n";

            }
            //      C# -> System.String? SubnetMask
            // GraphQL -> subnetMask: String! (scalar)
            if (this.SubnetMask != null)
            {
                 s += ind + "subnetMask\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? DnsServers
            // GraphQL -> dnsServers: [String!]! (scalar)
            if (this.DnsServers == null && Exploration.Includes(parent + ".dnsServers$"))
            {
                this.DnsServers = new List<System.String>();
            }
            //      C# -> System.String? Gateway
            // GraphQL -> gateway: String (scalar)
            if (this.Gateway == null && Exploration.Includes(parent + ".gateway$"))
            {
                this.Gateway = new System.String("FETCH");
            }
            //      C# -> List<System.String>? IpAddresses
            // GraphQL -> ipAddresses: [String!]! (scalar)
            if (this.IpAddresses == null && Exploration.Includes(parent + ".ipAddresses$"))
            {
                this.IpAddresses = new List<System.String>();
            }
            //      C# -> System.String? SubnetMask
            // GraphQL -> subnetMask: String! (scalar)
            if (this.SubnetMask == null && Exploration.Includes(parent + ".subnetMask$"))
            {
                this.SubnetMask = new System.String("FETCH");
            }
        }


    #endregion

    } // class StaticIpInfo
    #endregion

    public static class ListStaticIpInfoExtensions
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
            this List<StaticIpInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<StaticIpInfo> list, 
            String parent = "")
        {
            var item = new StaticIpInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types