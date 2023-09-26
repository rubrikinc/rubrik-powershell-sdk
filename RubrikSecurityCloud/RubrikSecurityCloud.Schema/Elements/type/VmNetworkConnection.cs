// VmNetworkConnection.cs
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
    #region VmNetworkConnection
    public class VmNetworkConnection: BaseType
    {
        #region members

        //      C# -> VmNetworkAddressingMode? IpAddressingMode
        // GraphQL -> ipAddressingMode: VmNetworkAddressingMode! (enum)
        [JsonProperty("ipAddressingMode")]
        public VmNetworkAddressingMode? IpAddressingMode { get; set; }

        //      C# -> System.String? AdapterType
        // GraphQL -> adapterType: String (scalar)
        [JsonProperty("adapterType")]
        public System.String? AdapterType { get; set; }

        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        [JsonProperty("isConnected")]
        public System.Boolean? IsConnected { get; set; }

        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        [JsonProperty("macAddress")]
        public System.String? MacAddress { get; set; }

        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        [JsonProperty("networkName")]
        public System.String? NetworkName { get; set; }

        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        [JsonProperty("nicIndex")]
        public System.Int32? NicIndex { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmNetworkConnection";
    }

    public VmNetworkConnection Set(
        VmNetworkAddressingMode? IpAddressingMode = null,
        System.String? AdapterType = null,
        System.Boolean? IsConnected = null,
        System.String? MacAddress = null,
        System.String? NetworkName = null,
        System.Int32? NicIndex = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( IpAddressingMode != null ) {
            this.IpAddressingMode = IpAddressingMode;
        }
        if ( AdapterType != null ) {
            this.AdapterType = AdapterType;
        }
        if ( IsConnected != null ) {
            this.IsConnected = IsConnected;
        }
        if ( MacAddress != null ) {
            this.MacAddress = MacAddress;
        }
        if ( NetworkName != null ) {
            this.NetworkName = NetworkName;
        }
        if ( NicIndex != null ) {
            this.NicIndex = NicIndex;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> VmNetworkAddressingMode? IpAddressingMode
        // GraphQL -> ipAddressingMode: VmNetworkAddressingMode! (enum)
        if (this.IpAddressingMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddressingMode\n" ;
            } else {
                s += ind + "ipAddressingMode\n" ;
            }
        }
        //      C# -> System.String? AdapterType
        // GraphQL -> adapterType: String (scalar)
        if (this.AdapterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "adapterType\n" ;
            } else {
                s += ind + "adapterType\n" ;
            }
        }
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (this.IsConnected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isConnected\n" ;
            } else {
                s += ind + "isConnected\n" ;
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
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        if (this.NetworkName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkName\n" ;
            } else {
                s += ind + "networkName\n" ;
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
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(conf.Child("pageInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pageInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VmNetworkAddressingMode? IpAddressingMode
        // GraphQL -> ipAddressingMode: VmNetworkAddressingMode! (enum)
        if (ec.Includes("ipAddressingMode",true))
        {
            if(this.IpAddressingMode == null) {

                this.IpAddressingMode = new VmNetworkAddressingMode();

            } else {


            }
        }
        else if (this.IpAddressingMode != null && ec.Excludes("ipAddressingMode",true))
        {
            this.IpAddressingMode = null;
        }
        //      C# -> System.String? AdapterType
        // GraphQL -> adapterType: String (scalar)
        if (ec.Includes("adapterType",true))
        {
            if(this.AdapterType == null) {

                this.AdapterType = "FETCH";

            } else {


            }
        }
        else if (this.AdapterType != null && ec.Excludes("adapterType",true))
        {
            this.AdapterType = null;
        }
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (ec.Includes("isConnected",true))
        {
            if(this.IsConnected == null) {

                this.IsConnected = true;

            } else {


            }
        }
        else if (this.IsConnected != null && ec.Excludes("isConnected",true))
        {
            this.IsConnected = null;
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
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        if (ec.Includes("networkName",true))
        {
            if(this.NetworkName == null) {

                this.NetworkName = "FETCH";

            } else {


            }
        }
        else if (this.NetworkName != null && ec.Excludes("networkName",true))
        {
            this.NetworkName = null;
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
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (ec.Includes("pageInfo",false))
        {
            if(this.PageInfo == null) {

                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            } else {

                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            }
        }
        else if (this.PageInfo != null && ec.Excludes("pageInfo",false))
        {
            this.PageInfo = null;
        }
    }


    #endregion

    } // class VmNetworkConnection
    
    #endregion

    public static class ListVmNetworkConnectionExtensions
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
            this List<VmNetworkConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmNetworkConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmNetworkConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmNetworkConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types