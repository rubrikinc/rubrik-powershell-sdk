// VappVmNetworkConnection.cs
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
    #region VappVmNetworkConnection
    public class VappVmNetworkConnection: BaseType
    {
        #region members

        //      C# -> VappVmIpAddressingMode? AddressingMode
        // GraphQL -> addressingMode: VappVmIpAddressingMode! (enum)
        [JsonProperty("addressingMode")]
        public VappVmIpAddressingMode? AddressingMode { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        [JsonProperty("isConnected")]
        public System.Boolean? IsConnected { get; set; }

        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        [JsonProperty("macAddress")]
        public System.String? MacAddress { get; set; }

        //      C# -> System.String? NetworkAdapterType
        // GraphQL -> networkAdapterType: String (scalar)
        [JsonProperty("networkAdapterType")]
        public System.String? NetworkAdapterType { get; set; }

        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        [JsonProperty("nicIndex")]
        public System.Int32? NicIndex { get; set; }

        //      C# -> System.String? VappNetworkName
        // GraphQL -> vappNetworkName: String (scalar)
        [JsonProperty("vappNetworkName")]
        public System.String? VappNetworkName { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappVmNetworkConnection";
    }

    public VappVmNetworkConnection Set(
        VappVmIpAddressingMode? AddressingMode = null,
        System.String? IpAddress = null,
        System.Boolean? IsConnected = null,
        System.String? MacAddress = null,
        System.String? NetworkAdapterType = null,
        System.Int32? NicIndex = null,
        System.String? VappNetworkName = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( AddressingMode != null ) {
            this.AddressingMode = AddressingMode;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( IsConnected != null ) {
            this.IsConnected = IsConnected;
        }
        if ( MacAddress != null ) {
            this.MacAddress = MacAddress;
        }
        if ( NetworkAdapterType != null ) {
            this.NetworkAdapterType = NetworkAdapterType;
        }
        if ( NicIndex != null ) {
            this.NicIndex = NicIndex;
        }
        if ( VappNetworkName != null ) {
            this.VappNetworkName = VappNetworkName;
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
        //      C# -> VappVmIpAddressingMode? AddressingMode
        // GraphQL -> addressingMode: VappVmIpAddressingMode! (enum)
        if (this.AddressingMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "addressingMode\n" ;
            } else {
                s += ind + "addressingMode\n" ;
            }
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (this.IpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddress\n" ;
            } else {
                s += ind + "ipAddress\n" ;
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
        //      C# -> System.String? NetworkAdapterType
        // GraphQL -> networkAdapterType: String (scalar)
        if (this.NetworkAdapterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkAdapterType\n" ;
            } else {
                s += ind + "networkAdapterType\n" ;
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
        //      C# -> System.String? VappNetworkName
        // GraphQL -> vappNetworkName: String (scalar)
        if (this.VappNetworkName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vappNetworkName\n" ;
            } else {
                s += ind + "vappNetworkName\n" ;
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
        //      C# -> VappVmIpAddressingMode? AddressingMode
        // GraphQL -> addressingMode: VappVmIpAddressingMode! (enum)
        if (ec.Includes("addressingMode",true))
        {
            if(this.AddressingMode == null) {

                this.AddressingMode = new VappVmIpAddressingMode();

            } else {


            }
        }
        else if (this.AddressingMode != null && ec.Excludes("addressingMode",true))
        {
            this.AddressingMode = null;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (ec.Includes("ipAddress",true))
        {
            if(this.IpAddress == null) {

                this.IpAddress = "FETCH";

            } else {


            }
        }
        else if (this.IpAddress != null && ec.Excludes("ipAddress",true))
        {
            this.IpAddress = null;
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
        //      C# -> System.String? NetworkAdapterType
        // GraphQL -> networkAdapterType: String (scalar)
        if (ec.Includes("networkAdapterType",true))
        {
            if(this.NetworkAdapterType == null) {

                this.NetworkAdapterType = "FETCH";

            } else {


            }
        }
        else if (this.NetworkAdapterType != null && ec.Excludes("networkAdapterType",true))
        {
            this.NetworkAdapterType = null;
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
        //      C# -> System.String? VappNetworkName
        // GraphQL -> vappNetworkName: String (scalar)
        if (ec.Includes("vappNetworkName",true))
        {
            if(this.VappNetworkName == null) {

                this.VappNetworkName = "FETCH";

            } else {


            }
        }
        else if (this.VappNetworkName != null && ec.Excludes("vappNetworkName",true))
        {
            this.VappNetworkName = null;
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

    } // class VappVmNetworkConnection
    
    #endregion

    public static class ListVappVmNetworkConnectionExtensions
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
            this List<VappVmNetworkConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VappVmNetworkConnection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VappVmNetworkConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappVmNetworkConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VappVmNetworkConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types