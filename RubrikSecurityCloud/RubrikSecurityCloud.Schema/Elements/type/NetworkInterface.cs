// NetworkInterface.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:21.
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
    #region NetworkInterface
    public class NetworkInterface: IFragment
    {
        #region members
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        [JsonProperty("interfaceName")]
        public System.String? InterfaceName { get; set; }

        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        [JsonProperty("ipAddresses")]
        public List<System.String>? IpAddresses { get; set; }

        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        [JsonProperty("netmask")]
        public System.String? Netmask { get; set; }

        //      C# -> System.String? Node
        // GraphQL -> node: String (scalar)
        [JsonProperty("node")]
        public System.String? Node { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> NetworkInterfaceType? InterfaceType
        // GraphQL -> interfaceType: NetworkInterfaceType! (enum)
        [JsonProperty("interfaceType")]
        public NetworkInterfaceType? InterfaceType { get; set; }

        #endregion

    #region methods

    public NetworkInterface Set(
        System.String? InterfaceName = null,
        List<System.String>? IpAddresses = null,
        System.String? Netmask = null,
        System.String? Node = null,
        System.String? NodeId = null,
        System.String? NodeName = null,
        NetworkInterfaceType? InterfaceType = null
    ) 
    {
        if ( InterfaceName != null ) {
            this.InterfaceName = InterfaceName;
        }
        if ( IpAddresses != null ) {
            this.IpAddresses = IpAddresses;
        }
        if ( Netmask != null ) {
            this.Netmask = Netmask;
        }
        if ( Node != null ) {
            this.Node = Node;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
        }
        if ( InterfaceType != null ) {
            this.InterfaceType = InterfaceType;
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
            //      C# -> System.String? InterfaceName
            // GraphQL -> interfaceName: String! (scalar)
            if (this.InterfaceName != null)
            {
                 s += ind + "interfaceName\n";

            }
            //      C# -> List<System.String>? IpAddresses
            // GraphQL -> ipAddresses: [String!]! (scalar)
            if (this.IpAddresses != null)
            {
                 s += ind + "ipAddresses\n";

            }
            //      C# -> System.String? Netmask
            // GraphQL -> netmask: String! (scalar)
            if (this.Netmask != null)
            {
                 s += ind + "netmask\n";

            }
            //      C# -> System.String? Node
            // GraphQL -> node: String (scalar)
            if (this.Node != null)
            {
                 s += ind + "node\n";

            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String (scalar)
            if (this.NodeId != null)
            {
                 s += ind + "nodeId\n";

            }
            //      C# -> System.String? NodeName
            // GraphQL -> nodeName: String (scalar)
            if (this.NodeName != null)
            {
                 s += ind + "nodeName\n";

            }
            //      C# -> NetworkInterfaceType? InterfaceType
            // GraphQL -> interfaceType: NetworkInterfaceType! (enum)
            if (this.InterfaceType != null)
            {
                 s += ind + "interfaceType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? InterfaceName
            // GraphQL -> interfaceName: String! (scalar)
            if (this.InterfaceName == null && Exploration.Includes(parent + ".interfaceName$"))
            {
                this.InterfaceName = new System.String("FETCH");
            }
            //      C# -> List<System.String>? IpAddresses
            // GraphQL -> ipAddresses: [String!]! (scalar)
            if (this.IpAddresses == null && Exploration.Includes(parent + ".ipAddresses$"))
            {
                this.IpAddresses = new List<System.String>();
            }
            //      C# -> System.String? Netmask
            // GraphQL -> netmask: String! (scalar)
            if (this.Netmask == null && Exploration.Includes(parent + ".netmask$"))
            {
                this.Netmask = new System.String("FETCH");
            }
            //      C# -> System.String? Node
            // GraphQL -> node: String (scalar)
            if (this.Node == null && Exploration.Includes(parent + ".node$"))
            {
                this.Node = new System.String("FETCH");
            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String (scalar)
            if (this.NodeId == null && Exploration.Includes(parent + ".nodeId$"))
            {
                this.NodeId = new System.String("FETCH");
            }
            //      C# -> System.String? NodeName
            // GraphQL -> nodeName: String (scalar)
            if (this.NodeName == null && Exploration.Includes(parent + ".nodeName$"))
            {
                this.NodeName = new System.String("FETCH");
            }
            //      C# -> NetworkInterfaceType? InterfaceType
            // GraphQL -> interfaceType: NetworkInterfaceType! (enum)
            if (this.InterfaceType == null && Exploration.Includes(parent + ".interfaceType$"))
            {
                this.InterfaceType = new NetworkInterfaceType();
            }
        }


    #endregion

    } // class NetworkInterface
    #endregion

    public static class ListNetworkInterfaceExtensions
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
            this List<NetworkInterface> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NetworkInterface> list, 
            String parent = "")
        {
            var item = new NetworkInterface();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types