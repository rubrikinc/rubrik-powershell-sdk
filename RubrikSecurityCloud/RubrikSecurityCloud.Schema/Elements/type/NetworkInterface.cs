// NetworkInterface.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region NetworkInterface
    public class NetworkInterface: BaseType
    {
        #region members

        //      C# -> NetworkInterfaceType? InterfaceType
        // GraphQL -> interfaceType: NetworkInterfaceType! (enum)
        [JsonProperty("interfaceType")]
        public NetworkInterfaceType? InterfaceType { get; set; }

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


        #endregion

    #region methods

    public NetworkInterface Set(
        NetworkInterfaceType? InterfaceType = null,
        System.String? InterfaceName = null,
        List<System.String>? IpAddresses = null,
        System.String? Netmask = null,
        System.String? Node = null,
        System.String? NodeId = null,
        System.String? NodeName = null
    ) 
    {
        if ( InterfaceType != null ) {
            this.InterfaceType = InterfaceType;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> NetworkInterfaceType? InterfaceType
        // GraphQL -> interfaceType: NetworkInterfaceType! (enum)
        if (this.InterfaceType != null) {
            s += ind + "interfaceType\n" ;
        }
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        if (this.InterfaceName != null) {
            s += ind + "interfaceName\n" ;
        }
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (this.IpAddresses != null) {
            s += ind + "ipAddresses\n" ;
        }
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (this.Netmask != null) {
            s += ind + "netmask\n" ;
        }
        //      C# -> System.String? Node
        // GraphQL -> node: String (scalar)
        if (this.Node != null) {
            s += ind + "node\n" ;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        if (this.NodeId != null) {
            s += ind + "nodeId\n" ;
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        if (this.NodeName != null) {
            s += ind + "nodeName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> NetworkInterfaceType? InterfaceType
        // GraphQL -> interfaceType: NetworkInterfaceType! (enum)
        if (this.InterfaceType == null && Exploration.Includes(parent + ".interfaceType", true))
        {
            this.InterfaceType = new NetworkInterfaceType();
        }
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        if (this.InterfaceName == null && Exploration.Includes(parent + ".interfaceName", true))
        {
            this.InterfaceName = "FETCH";
        }
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (this.IpAddresses == null && Exploration.Includes(parent + ".ipAddresses", true))
        {
            this.IpAddresses = new List<System.String>();
        }
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (this.Netmask == null && Exploration.Includes(parent + ".netmask", true))
        {
            this.Netmask = "FETCH";
        }
        //      C# -> System.String? Node
        // GraphQL -> node: String (scalar)
        if (this.Node == null && Exploration.Includes(parent + ".node", true))
        {
            this.Node = "FETCH";
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        if (this.NodeId == null && Exploration.Includes(parent + ".nodeId", true))
        {
            this.NodeId = "FETCH";
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        if (this.NodeName == null && Exploration.Includes(parent + ".nodeName", true))
        {
            this.NodeName = "FETCH";
        }
    }


    #endregion

    } // class NetworkInterface
    
    #endregion

    public static class ListNetworkInterfaceExtensions
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
            this List<NetworkInterface> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NetworkInterface> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkInterface());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types