// VsphereVmNicSpec.cs
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
    #region VsphereVmNicSpec
    public class VsphereVmNicSpec: BaseType
    {
        #region members

        //      C# -> NetworkAdapterType? AdapterType
        // GraphQL -> adapterType: NetworkAdapterType! (enum)
        [JsonProperty("adapterType")]
        public NetworkAdapterType? AdapterType { get; set; }

        //      C# -> NetworkType? NetworkType
        // GraphQL -> networkType: NetworkType! (enum)
        [JsonProperty("networkType")]
        public NetworkType? NetworkType { get; set; }

        //      C# -> List<System.String>? DnsInfos
        // GraphQL -> dnsInfos: [String!]! (scalar)
        [JsonProperty("dnsInfos")]
        public List<System.String>? DnsInfos { get; set; }

        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        [JsonProperty("gateway")]
        public System.String? Gateway { get; set; }

        //      C# -> System.String? Ipv4Address
        // GraphQL -> ipv4Address: String! (scalar)
        [JsonProperty("ipv4Address")]
        public System.String? Ipv4Address { get; set; }

        //      C# -> System.String? Ipv6Address
        // GraphQL -> ipv6Address: String! (scalar)
        [JsonProperty("ipv6Address")]
        public System.String? Ipv6Address { get; set; }

        //      C# -> System.Boolean? IsPrimaryNic
        // GraphQL -> isPrimaryNic: Boolean! (scalar)
        [JsonProperty("isPrimaryNic")]
        public System.Boolean? IsPrimaryNic { get; set; }

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        [JsonProperty("netmask")]
        public System.String? Netmask { get; set; }

        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: String! (scalar)
        [JsonProperty("networkId")]
        public System.String? NetworkId { get; set; }

        //      C# -> System.String? NetworkMoid
        // GraphQL -> networkMoid: String! (scalar)
        [JsonProperty("networkMoid")]
        public System.String? NetworkMoid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VSphereVMNicSpec";
    }

    public VsphereVmNicSpec Set(
        NetworkAdapterType? AdapterType = null,
        NetworkType? NetworkType = null,
        List<System.String>? DnsInfos = null,
        System.String? Gateway = null,
        System.String? Ipv4Address = null,
        System.String? Ipv6Address = null,
        System.Boolean? IsPrimaryNic = null,
        System.String? Key = null,
        System.String? Netmask = null,
        System.String? NetworkId = null,
        System.String? NetworkMoid = null
    ) 
    {
        if ( AdapterType != null ) {
            this.AdapterType = AdapterType;
        }
        if ( NetworkType != null ) {
            this.NetworkType = NetworkType;
        }
        if ( DnsInfos != null ) {
            this.DnsInfos = DnsInfos;
        }
        if ( Gateway != null ) {
            this.Gateway = Gateway;
        }
        if ( Ipv4Address != null ) {
            this.Ipv4Address = Ipv4Address;
        }
        if ( Ipv6Address != null ) {
            this.Ipv6Address = Ipv6Address;
        }
        if ( IsPrimaryNic != null ) {
            this.IsPrimaryNic = IsPrimaryNic;
        }
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( Netmask != null ) {
            this.Netmask = Netmask;
        }
        if ( NetworkId != null ) {
            this.NetworkId = NetworkId;
        }
        if ( NetworkMoid != null ) {
            this.NetworkMoid = NetworkMoid;
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
        //      C# -> NetworkAdapterType? AdapterType
        // GraphQL -> adapterType: NetworkAdapterType! (enum)
        if (this.AdapterType != null) {
            s += ind + "adapterType\n" ;
        }
        //      C# -> NetworkType? NetworkType
        // GraphQL -> networkType: NetworkType! (enum)
        if (this.NetworkType != null) {
            s += ind + "networkType\n" ;
        }
        //      C# -> List<System.String>? DnsInfos
        // GraphQL -> dnsInfos: [String!]! (scalar)
        if (this.DnsInfos != null) {
            s += ind + "dnsInfos\n" ;
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        if (this.Gateway != null) {
            s += ind + "gateway\n" ;
        }
        //      C# -> System.String? Ipv4Address
        // GraphQL -> ipv4Address: String! (scalar)
        if (this.Ipv4Address != null) {
            s += ind + "ipv4Address\n" ;
        }
        //      C# -> System.String? Ipv6Address
        // GraphQL -> ipv6Address: String! (scalar)
        if (this.Ipv6Address != null) {
            s += ind + "ipv6Address\n" ;
        }
        //      C# -> System.Boolean? IsPrimaryNic
        // GraphQL -> isPrimaryNic: Boolean! (scalar)
        if (this.IsPrimaryNic != null) {
            s += ind + "isPrimaryNic\n" ;
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (this.Netmask != null) {
            s += ind + "netmask\n" ;
        }
        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: String! (scalar)
        if (this.NetworkId != null) {
            s += ind + "networkId\n" ;
        }
        //      C# -> System.String? NetworkMoid
        // GraphQL -> networkMoid: String! (scalar)
        if (this.NetworkMoid != null) {
            s += ind + "networkMoid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> NetworkAdapterType? AdapterType
        // GraphQL -> adapterType: NetworkAdapterType! (enum)
        if (this.AdapterType == null && Exploration.Includes(parent + ".adapterType", true))
        {
            this.AdapterType = new NetworkAdapterType();
        }
        //      C# -> NetworkType? NetworkType
        // GraphQL -> networkType: NetworkType! (enum)
        if (this.NetworkType == null && Exploration.Includes(parent + ".networkType", true))
        {
            this.NetworkType = new NetworkType();
        }
        //      C# -> List<System.String>? DnsInfos
        // GraphQL -> dnsInfos: [String!]! (scalar)
        if (this.DnsInfos == null && Exploration.Includes(parent + ".dnsInfos", true))
        {
            this.DnsInfos = new List<System.String>();
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        if (this.Gateway == null && Exploration.Includes(parent + ".gateway", true))
        {
            this.Gateway = "FETCH";
        }
        //      C# -> System.String? Ipv4Address
        // GraphQL -> ipv4Address: String! (scalar)
        if (this.Ipv4Address == null && Exploration.Includes(parent + ".ipv4Address", true))
        {
            this.Ipv4Address = "FETCH";
        }
        //      C# -> System.String? Ipv6Address
        // GraphQL -> ipv6Address: String! (scalar)
        if (this.Ipv6Address == null && Exploration.Includes(parent + ".ipv6Address", true))
        {
            this.Ipv6Address = "FETCH";
        }
        //      C# -> System.Boolean? IsPrimaryNic
        // GraphQL -> isPrimaryNic: Boolean! (scalar)
        if (this.IsPrimaryNic == null && Exploration.Includes(parent + ".isPrimaryNic", true))
        {
            this.IsPrimaryNic = true;
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key == null && Exploration.Includes(parent + ".key", true))
        {
            this.Key = "FETCH";
        }
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (this.Netmask == null && Exploration.Includes(parent + ".netmask", true))
        {
            this.Netmask = "FETCH";
        }
        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: String! (scalar)
        if (this.NetworkId == null && Exploration.Includes(parent + ".networkId", true))
        {
            this.NetworkId = "FETCH";
        }
        //      C# -> System.String? NetworkMoid
        // GraphQL -> networkMoid: String! (scalar)
        if (this.NetworkMoid == null && Exploration.Includes(parent + ".networkMoid", true))
        {
            this.NetworkMoid = "FETCH";
        }
    }


    #endregion

    } // class VsphereVmNicSpec
    
    #endregion

    public static class ListVsphereVmNicSpecExtensions
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
            this List<VsphereVmNicSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVmNicSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVmNicSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types