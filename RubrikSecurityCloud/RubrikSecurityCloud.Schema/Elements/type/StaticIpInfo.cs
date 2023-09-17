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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "StaticIpInfo";
    }

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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? DnsServers
        // GraphQL -> dnsServers: [String!]! (scalar)
        if (this.DnsServers == null && ec.Includes("dnsServers",true))
        {
            this.DnsServers = new List<System.String>();
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String (scalar)
        if (this.Gateway == null && ec.Includes("gateway",true))
        {
            this.Gateway = "FETCH";
        }
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (this.IpAddresses == null && ec.Includes("ipAddresses",true))
        {
            this.IpAddresses = new List<System.String>();
        }
        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String! (scalar)
        if (this.SubnetMask == null && ec.Includes("subnetMask",true))
        {
            this.SubnetMask = "FETCH";
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StaticIpInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StaticIpInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StaticIpInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types