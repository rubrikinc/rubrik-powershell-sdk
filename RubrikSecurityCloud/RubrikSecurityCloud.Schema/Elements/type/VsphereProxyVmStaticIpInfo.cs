// VsphereProxyVmStaticIpInfo.cs
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
    #region VsphereProxyVmStaticIpInfo
    public class VsphereProxyVmStaticIpInfo: BaseType
    {
        #region members

        //      C# -> List<System.String>? DnsServers
        // GraphQL -> dnsServers: [String!]! (scalar)
        [JsonProperty("dnsServers")]
        public List<System.String>? DnsServers { get; set; }

        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
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
        return "VsphereProxyVmStaticIpInfo";
    }

    public VsphereProxyVmStaticIpInfo Set(
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? DnsServers
        // GraphQL -> dnsServers: [String!]! (scalar)
        if (this.DnsServers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dnsServers\n" ;
            } else {
                s += ind + "dnsServers\n" ;
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
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (this.IpAddresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddresses\n" ;
            } else {
                s += ind + "ipAddresses\n" ;
            }
        }
        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String! (scalar)
        if (this.SubnetMask != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetMask\n" ;
            } else {
                s += ind + "subnetMask\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? DnsServers
        // GraphQL -> dnsServers: [String!]! (scalar)
        if (ec.Includes("dnsServers",true))
        {
            if(this.DnsServers == null) {

                this.DnsServers = new List<System.String>();

            } else {


            }
        }
        else if (this.DnsServers != null && ec.Excludes("dnsServers",true))
        {
            this.DnsServers = null;
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
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (ec.Includes("ipAddresses",true))
        {
            if(this.IpAddresses == null) {

                this.IpAddresses = new List<System.String>();

            } else {


            }
        }
        else if (this.IpAddresses != null && ec.Excludes("ipAddresses",true))
        {
            this.IpAddresses = null;
        }
        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String! (scalar)
        if (ec.Includes("subnetMask",true))
        {
            if(this.SubnetMask == null) {

                this.SubnetMask = "FETCH";

            } else {


            }
        }
        else if (this.SubnetMask != null && ec.Excludes("subnetMask",true))
        {
            this.SubnetMask = null;
        }
    }


    #endregion

    } // class VsphereProxyVmStaticIpInfo
    
    #endregion

    public static class ListVsphereProxyVmStaticIpInfoExtensions
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
            this List<VsphereProxyVmStaticIpInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereProxyVmStaticIpInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereProxyVmStaticIpInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereProxyVmStaticIpInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereProxyVmStaticIpInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types