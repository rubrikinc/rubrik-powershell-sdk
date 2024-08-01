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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> NetworkAdapterType? AdapterType
        // GraphQL -> adapterType: NetworkAdapterType! (enum)
        if (this.AdapterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "adapterType\n" ;
            } else {
                s += ind + "adapterType\n" ;
            }
        }
        //      C# -> NetworkType? NetworkType
        // GraphQL -> networkType: NetworkType! (enum)
        if (this.NetworkType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkType\n" ;
            } else {
                s += ind + "networkType\n" ;
            }
        }
        //      C# -> List<System.String>? DnsInfos
        // GraphQL -> dnsInfos: [String!]! (scalar)
        if (this.DnsInfos != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dnsInfos\n" ;
            } else {
                s += ind + "dnsInfos\n" ;
            }
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        if (this.Gateway != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gateway\n" ;
            } else {
                s += ind + "gateway\n" ;
            }
        }
        //      C# -> System.String? Ipv4Address
        // GraphQL -> ipv4Address: String! (scalar)
        if (this.Ipv4Address != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipv4Address\n" ;
            } else {
                s += ind + "ipv4Address\n" ;
            }
        }
        //      C# -> System.String? Ipv6Address
        // GraphQL -> ipv6Address: String! (scalar)
        if (this.Ipv6Address != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipv6Address\n" ;
            } else {
                s += ind + "ipv6Address\n" ;
            }
        }
        //      C# -> System.Boolean? IsPrimaryNic
        // GraphQL -> isPrimaryNic: Boolean! (scalar)
        if (this.IsPrimaryNic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPrimaryNic\n" ;
            } else {
                s += ind + "isPrimaryNic\n" ;
            }
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (this.Netmask != null) {
            if (conf.Flat) {
                s += conf.Prefix + "netmask\n" ;
            } else {
                s += ind + "netmask\n" ;
            }
        }
        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: String! (scalar)
        if (this.NetworkId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkId\n" ;
            } else {
                s += ind + "networkId\n" ;
            }
        }
        //      C# -> System.String? NetworkMoid
        // GraphQL -> networkMoid: String! (scalar)
        if (this.NetworkMoid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkMoid\n" ;
            } else {
                s += ind + "networkMoid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NetworkAdapterType? AdapterType
        // GraphQL -> adapterType: NetworkAdapterType! (enum)
        if (ec.Includes("adapterType",true))
        {
            if(this.AdapterType == null) {

                this.AdapterType = new NetworkAdapterType();

            } else {


            }
        }
        else if (this.AdapterType != null && ec.Excludes("adapterType",true))
        {
            this.AdapterType = null;
        }
        //      C# -> NetworkType? NetworkType
        // GraphQL -> networkType: NetworkType! (enum)
        if (ec.Includes("networkType",true))
        {
            if(this.NetworkType == null) {

                this.NetworkType = new NetworkType();

            } else {


            }
        }
        else if (this.NetworkType != null && ec.Excludes("networkType",true))
        {
            this.NetworkType = null;
        }
        //      C# -> List<System.String>? DnsInfos
        // GraphQL -> dnsInfos: [String!]! (scalar)
        if (ec.Includes("dnsInfos",true))
        {
            if(this.DnsInfos == null) {

                this.DnsInfos = new List<System.String>();

            } else {


            }
        }
        else if (this.DnsInfos != null && ec.Excludes("dnsInfos",true))
        {
            this.DnsInfos = null;
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        if (ec.Includes("gateway",true))
        {
            if(this.Gateway == null) {

                this.Gateway = "FETCH";

            } else {


            }
        }
        else if (this.Gateway != null && ec.Excludes("gateway",true))
        {
            this.Gateway = null;
        }
        //      C# -> System.String? Ipv4Address
        // GraphQL -> ipv4Address: String! (scalar)
        if (ec.Includes("ipv4Address",true))
        {
            if(this.Ipv4Address == null) {

                this.Ipv4Address = "FETCH";

            } else {


            }
        }
        else if (this.Ipv4Address != null && ec.Excludes("ipv4Address",true))
        {
            this.Ipv4Address = null;
        }
        //      C# -> System.String? Ipv6Address
        // GraphQL -> ipv6Address: String! (scalar)
        if (ec.Includes("ipv6Address",true))
        {
            if(this.Ipv6Address == null) {

                this.Ipv6Address = "FETCH";

            } else {


            }
        }
        else if (this.Ipv6Address != null && ec.Excludes("ipv6Address",true))
        {
            this.Ipv6Address = null;
        }
        //      C# -> System.Boolean? IsPrimaryNic
        // GraphQL -> isPrimaryNic: Boolean! (scalar)
        if (ec.Includes("isPrimaryNic",true))
        {
            if(this.IsPrimaryNic == null) {

                this.IsPrimaryNic = true;

            } else {


            }
        }
        else if (this.IsPrimaryNic != null && ec.Excludes("isPrimaryNic",true))
        {
            this.IsPrimaryNic = null;
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = "FETCH";

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (ec.Includes("netmask",true))
        {
            if(this.Netmask == null) {

                this.Netmask = "FETCH";

            } else {


            }
        }
        else if (this.Netmask != null && ec.Excludes("netmask",true))
        {
            this.Netmask = null;
        }
        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: String! (scalar)
        if (ec.Includes("networkId",true))
        {
            if(this.NetworkId == null) {

                this.NetworkId = "FETCH";

            } else {


            }
        }
        else if (this.NetworkId != null && ec.Excludes("networkId",true))
        {
            this.NetworkId = null;
        }
        //      C# -> System.String? NetworkMoid
        // GraphQL -> networkMoid: String! (scalar)
        if (ec.Includes("networkMoid",true))
        {
            if(this.NetworkMoid == null) {

                this.NetworkMoid = "FETCH";

            } else {


            }
        }
        else if (this.NetworkMoid != null && ec.Excludes("networkMoid",true))
        {
            this.NetworkMoid = null;
        }
    }


    #endregion

    } // class VsphereVmNicSpec
    
    #endregion

    public static class ListVsphereVmNicSpecExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VsphereVmNicSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereVmNicSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVmNicSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVmNicSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereVmNicSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types