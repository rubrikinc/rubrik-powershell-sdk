// VmNetworkConnection.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:07.
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
    #region VmNetworkConnection
    public class VmNetworkConnection: IFragment
    {
        #region members
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

        //      C# -> VmNetworkAddressingMode? IpAddressingMode
        // GraphQL -> ipAddressingMode: VmNetworkAddressingMode! (enum)
        [JsonProperty("ipAddressingMode")]
        public VmNetworkAddressingMode? IpAddressingMode { get; set; }

        #endregion

    #region methods

    public VmNetworkConnection Set(
        System.String? AdapterType = null,
        System.Boolean? IsConnected = null,
        System.String? MacAddress = null,
        System.String? NetworkName = null,
        System.Int32? NicIndex = null,
        PageInfo? PageInfo = null,
        VmNetworkAddressingMode? IpAddressingMode = null
    ) 
    {
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
        if ( IpAddressingMode != null ) {
            this.IpAddressingMode = IpAddressingMode;
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
            //      C# -> System.String? AdapterType
            // GraphQL -> adapterType: String (scalar)
            if (this.AdapterType != null)
            {
                 s += ind + "adapterType\n";

            }
            //      C# -> System.Boolean? IsConnected
            // GraphQL -> isConnected: Boolean! (scalar)
            if (this.IsConnected != null)
            {
                 s += ind + "isConnected\n";

            }
            //      C# -> System.String? MacAddress
            // GraphQL -> macAddress: String (scalar)
            if (this.MacAddress != null)
            {
                 s += ind + "macAddress\n";

            }
            //      C# -> System.String? NetworkName
            // GraphQL -> networkName: String (scalar)
            if (this.NetworkName != null)
            {
                 s += ind + "networkName\n";

            }
            //      C# -> System.Int32? NicIndex
            // GraphQL -> nicIndex: Int! (scalar)
            if (this.NicIndex != null)
            {
                 s += ind + "nicIndex\n";

            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo != null)
            {
                 s += ind + "pageInfo\n";

                 s += ind + "{\n" + 
                 this.PageInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VmNetworkAddressingMode? IpAddressingMode
            // GraphQL -> ipAddressingMode: VmNetworkAddressingMode! (enum)
            if (this.IpAddressingMode != null)
            {
                 s += ind + "ipAddressingMode\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AdapterType
            // GraphQL -> adapterType: String (scalar)
            if (this.AdapterType == null && Exploration.Includes(parent + ".adapterType$"))
            {
                this.AdapterType = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsConnected
            // GraphQL -> isConnected: Boolean! (scalar)
            if (this.IsConnected == null && Exploration.Includes(parent + ".isConnected$"))
            {
                this.IsConnected = new System.Boolean();
            }
            //      C# -> System.String? MacAddress
            // GraphQL -> macAddress: String (scalar)
            if (this.MacAddress == null && Exploration.Includes(parent + ".macAddress$"))
            {
                this.MacAddress = new System.String("FETCH");
            }
            //      C# -> System.String? NetworkName
            // GraphQL -> networkName: String (scalar)
            if (this.NetworkName == null && Exploration.Includes(parent + ".networkName$"))
            {
                this.NetworkName = new System.String("FETCH");
            }
            //      C# -> System.Int32? NicIndex
            // GraphQL -> nicIndex: Int! (scalar)
            if (this.NicIndex == null && Exploration.Includes(parent + ".nicIndex$"))
            {
                this.NicIndex = new System.Int32();
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
            {
                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFragment(parent + ".pageInfo");
            }
            //      C# -> VmNetworkAddressingMode? IpAddressingMode
            // GraphQL -> ipAddressingMode: VmNetworkAddressingMode! (enum)
            if (this.IpAddressingMode == null && Exploration.Includes(parent + ".ipAddressingMode$"))
            {
                this.IpAddressingMode = new VmNetworkAddressingMode();
            }
        }


    #endregion

    } // class VmNetworkConnection
    #endregion

    public static class ListVmNetworkConnectionExtensions
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
            this List<VmNetworkConnection> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmNetworkConnection> list, 
            String parent = "")
        {
            var item = new VmNetworkConnection();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types