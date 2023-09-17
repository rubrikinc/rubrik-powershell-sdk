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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> VappVmIpAddressingMode? AddressingMode
        // GraphQL -> addressingMode: VappVmIpAddressingMode! (enum)
        if (this.AddressingMode != null) {
            s += ind + "addressingMode\n" ;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (this.IpAddress != null) {
            s += ind + "ipAddress\n" ;
        }
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (this.IsConnected != null) {
            s += ind + "isConnected\n" ;
        }
        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        if (this.MacAddress != null) {
            s += ind + "macAddress\n" ;
        }
        //      C# -> System.String? NetworkAdapterType
        // GraphQL -> networkAdapterType: String (scalar)
        if (this.NetworkAdapterType != null) {
            s += ind + "networkAdapterType\n" ;
        }
        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        if (this.NicIndex != null) {
            s += ind + "nicIndex\n" ;
        }
        //      C# -> System.String? VappNetworkName
        // GraphQL -> vappNetworkName: String (scalar)
        if (this.VappNetworkName != null) {
            s += ind + "vappNetworkName\n" ;
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pageInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VappVmIpAddressingMode? AddressingMode
        // GraphQL -> addressingMode: VappVmIpAddressingMode! (enum)
        if (this.AddressingMode == null && ec.Includes("addressingMode",true))
        {
            this.AddressingMode = new VappVmIpAddressingMode();
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (this.IpAddress == null && ec.Includes("ipAddress",true))
        {
            this.IpAddress = "FETCH";
        }
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (this.IsConnected == null && ec.Includes("isConnected",true))
        {
            this.IsConnected = true;
        }
        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        if (this.MacAddress == null && ec.Includes("macAddress",true))
        {
            this.MacAddress = "FETCH";
        }
        //      C# -> System.String? NetworkAdapterType
        // GraphQL -> networkAdapterType: String (scalar)
        if (this.NetworkAdapterType == null && ec.Includes("networkAdapterType",true))
        {
            this.NetworkAdapterType = "FETCH";
        }
        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        if (this.NicIndex == null && ec.Includes("nicIndex",true))
        {
            this.NicIndex = Int32.MinValue;
        }
        //      C# -> System.String? VappNetworkName
        // GraphQL -> vappNetworkName: String (scalar)
        if (this.VappNetworkName == null && ec.Includes("vappNetworkName",true))
        {
            this.VappNetworkName = "FETCH";
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo == null && ec.Includes("pageInfo",false))
        {
            this.PageInfo = new PageInfo();
            this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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