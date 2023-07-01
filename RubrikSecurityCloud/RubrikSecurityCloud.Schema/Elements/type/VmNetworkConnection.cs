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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> VmNetworkAddressingMode? IpAddressingMode
        // GraphQL -> ipAddressingMode: VmNetworkAddressingMode! (enum)
        if (this.IpAddressingMode != null) {
            s += ind + "ipAddressingMode\n" ;
        }
        //      C# -> System.String? AdapterType
        // GraphQL -> adapterType: String (scalar)
        if (this.AdapterType != null) {
            s += ind + "adapterType\n" ;
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
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        if (this.NetworkName != null) {
            s += ind + "networkName\n" ;
        }
        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        if (this.NicIndex != null) {
            s += ind + "nicIndex\n" ;
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> VmNetworkAddressingMode? IpAddressingMode
        // GraphQL -> ipAddressingMode: VmNetworkAddressingMode! (enum)
        if (this.IpAddressingMode == null && Exploration.Includes(parent + ".ipAddressingMode", true))
        {
            this.IpAddressingMode = new VmNetworkAddressingMode();
        }
        //      C# -> System.String? AdapterType
        // GraphQL -> adapterType: String (scalar)
        if (this.AdapterType == null && Exploration.Includes(parent + ".adapterType", true))
        {
            this.AdapterType = "FETCH";
        }
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (this.IsConnected == null && Exploration.Includes(parent + ".isConnected", true))
        {
            this.IsConnected = true;
        }
        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        if (this.MacAddress == null && Exploration.Includes(parent + ".macAddress", true))
        {
            this.MacAddress = "FETCH";
        }
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        if (this.NetworkName == null && Exploration.Includes(parent + ".networkName", true))
        {
            this.NetworkName = "FETCH";
        }
        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        if (this.NicIndex == null && Exploration.Includes(parent + ".nicIndex", true))
        {
            this.NicIndex = Int32.MinValue;
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
        {
            this.PageInfo = new PageInfo();
            this.PageInfo.ApplyExploratoryFieldSpec(parent + ".pageInfo");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmNetworkConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmNetworkConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types