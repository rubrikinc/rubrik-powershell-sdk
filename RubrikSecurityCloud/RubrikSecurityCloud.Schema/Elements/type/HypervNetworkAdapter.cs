// HypervNetworkAdapter.cs
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
    #region HypervNetworkAdapter
    public class HypervNetworkAdapter: BaseType
    {
        #region members

        //      C# -> System.String? AdapterName
        // GraphQL -> adapterName: String (scalar)
        [JsonProperty("adapterName")]
        public System.String? AdapterName { get; set; }

        //      C# -> List<System.String>? Ipv4Addresses
        // GraphQL -> ipv4Addresses: [String!] (scalar)
        [JsonProperty("ipv4Addresses")]
        public List<System.String>? Ipv4Addresses { get; set; }

        //      C# -> List<System.String>? Ipv6Addresses
        // GraphQL -> ipv6Addresses: [String!] (scalar)
        [JsonProperty("ipv6Addresses")]
        public List<System.String>? Ipv6Addresses { get; set; }

        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        [JsonProperty("macAddress")]
        public System.String? MacAddress { get; set; }

        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        [JsonProperty("nicIndex")]
        public System.Int32? NicIndex { get; set; }

        //      C# -> System.String? VirtualSwitchName
        // GraphQL -> virtualSwitchName: String (scalar)
        [JsonProperty("virtualSwitchName")]
        public System.String? VirtualSwitchName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervNetworkAdapter";
    }

    public HypervNetworkAdapter Set(
        System.String? AdapterName = null,
        List<System.String>? Ipv4Addresses = null,
        List<System.String>? Ipv6Addresses = null,
        System.String? MacAddress = null,
        System.Int32? NicIndex = null,
        System.String? VirtualSwitchName = null
    ) 
    {
        if ( AdapterName != null ) {
            this.AdapterName = AdapterName;
        }
        if ( Ipv4Addresses != null ) {
            this.Ipv4Addresses = Ipv4Addresses;
        }
        if ( Ipv6Addresses != null ) {
            this.Ipv6Addresses = Ipv6Addresses;
        }
        if ( MacAddress != null ) {
            this.MacAddress = MacAddress;
        }
        if ( NicIndex != null ) {
            this.NicIndex = NicIndex;
        }
        if ( VirtualSwitchName != null ) {
            this.VirtualSwitchName = VirtualSwitchName;
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
        //      C# -> System.String? AdapterName
        // GraphQL -> adapterName: String (scalar)
        if (this.AdapterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "adapterName\n" ;
            } else {
                s += ind + "adapterName\n" ;
            }
        }
        //      C# -> List<System.String>? Ipv4Addresses
        // GraphQL -> ipv4Addresses: [String!] (scalar)
        if (this.Ipv4Addresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipv4Addresses\n" ;
            } else {
                s += ind + "ipv4Addresses\n" ;
            }
        }
        //      C# -> List<System.String>? Ipv6Addresses
        // GraphQL -> ipv6Addresses: [String!] (scalar)
        if (this.Ipv6Addresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipv6Addresses\n" ;
            } else {
                s += ind + "ipv6Addresses\n" ;
            }
        }
        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        if (this.MacAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "macAddress\n" ;
            } else {
                s += ind + "macAddress\n" ;
            }
        }
        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        if (this.NicIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nicIndex\n" ;
            } else {
                s += ind + "nicIndex\n" ;
            }
        }
        //      C# -> System.String? VirtualSwitchName
        // GraphQL -> virtualSwitchName: String (scalar)
        if (this.VirtualSwitchName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "virtualSwitchName\n" ;
            } else {
                s += ind + "virtualSwitchName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AdapterName
        // GraphQL -> adapterName: String (scalar)
        if (ec.Includes("adapterName",true))
        {
            if(this.AdapterName == null) {

                this.AdapterName = "FETCH";

            } else {


            }
        }
        else if (this.AdapterName != null && ec.Excludes("adapterName",true))
        {
            this.AdapterName = null;
        }
        //      C# -> List<System.String>? Ipv4Addresses
        // GraphQL -> ipv4Addresses: [String!] (scalar)
        if (ec.Includes("ipv4Addresses",true))
        {
            if(this.Ipv4Addresses == null) {

                this.Ipv4Addresses = new List<System.String>();

            } else {


            }
        }
        else if (this.Ipv4Addresses != null && ec.Excludes("ipv4Addresses",true))
        {
            this.Ipv4Addresses = null;
        }
        //      C# -> List<System.String>? Ipv6Addresses
        // GraphQL -> ipv6Addresses: [String!] (scalar)
        if (ec.Includes("ipv6Addresses",true))
        {
            if(this.Ipv6Addresses == null) {

                this.Ipv6Addresses = new List<System.String>();

            } else {


            }
        }
        else if (this.Ipv6Addresses != null && ec.Excludes("ipv6Addresses",true))
        {
            this.Ipv6Addresses = null;
        }
        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        if (ec.Includes("macAddress",true))
        {
            if(this.MacAddress == null) {

                this.MacAddress = "FETCH";

            } else {


            }
        }
        else if (this.MacAddress != null && ec.Excludes("macAddress",true))
        {
            this.MacAddress = null;
        }
        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        if (ec.Includes("nicIndex",true))
        {
            if(this.NicIndex == null) {

                this.NicIndex = Int32.MinValue;

            } else {


            }
        }
        else if (this.NicIndex != null && ec.Excludes("nicIndex",true))
        {
            this.NicIndex = null;
        }
        //      C# -> System.String? VirtualSwitchName
        // GraphQL -> virtualSwitchName: String (scalar)
        if (ec.Includes("virtualSwitchName",true))
        {
            if(this.VirtualSwitchName == null) {

                this.VirtualSwitchName = "FETCH";

            } else {


            }
        }
        else if (this.VirtualSwitchName != null && ec.Excludes("virtualSwitchName",true))
        {
            this.VirtualSwitchName = null;
        }
    }


    #endregion

    } // class HypervNetworkAdapter
    
    #endregion

    public static class ListHypervNetworkAdapterExtensions
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
            this List<HypervNetworkAdapter> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervNetworkAdapter> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervNetworkAdapter> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervNetworkAdapter());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervNetworkAdapter> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types