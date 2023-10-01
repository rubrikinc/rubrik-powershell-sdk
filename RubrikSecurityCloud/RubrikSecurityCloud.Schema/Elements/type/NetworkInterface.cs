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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "NetworkInterface";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> NetworkInterfaceType? InterfaceType
        // GraphQL -> interfaceType: NetworkInterfaceType! (enum)
        if (this.InterfaceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "interfaceType\n" ;
            } else {
                s += ind + "interfaceType\n" ;
            }
        }
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        if (this.InterfaceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "interfaceName\n" ;
            } else {
                s += ind + "interfaceName\n" ;
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
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (this.Netmask != null) {
            if (conf.Flat) {
                s += conf.Prefix + "netmask\n" ;
            } else {
                s += ind + "netmask\n" ;
            }
        }
        //      C# -> System.String? Node
        // GraphQL -> node: String (scalar)
        if (this.Node != null) {
            if (conf.Flat) {
                s += conf.Prefix + "node\n" ;
            } else {
                s += ind + "node\n" ;
            }
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        if (this.NodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeId\n" ;
            } else {
                s += ind + "nodeId\n" ;
            }
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        if (this.NodeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeName\n" ;
            } else {
                s += ind + "nodeName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NetworkInterfaceType? InterfaceType
        // GraphQL -> interfaceType: NetworkInterfaceType! (enum)
        if (ec.Includes("interfaceType",true))
        {
            if(this.InterfaceType == null) {

                this.InterfaceType = new NetworkInterfaceType();

            } else {


            }
        }
        else if (this.InterfaceType != null && ec.Excludes("interfaceType",true))
        {
            this.InterfaceType = null;
        }
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        if (ec.Includes("interfaceName",true))
        {
            if(this.InterfaceName == null) {

                this.InterfaceName = "FETCH";

            } else {


            }
        }
        else if (this.InterfaceName != null && ec.Excludes("interfaceName",true))
        {
            this.InterfaceName = null;
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
        //      C# -> System.String? Node
        // GraphQL -> node: String (scalar)
        if (ec.Includes("node",true))
        {
            if(this.Node == null) {

                this.Node = "FETCH";

            } else {


            }
        }
        else if (this.Node != null && ec.Excludes("node",true))
        {
            this.Node = null;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        if (ec.Includes("nodeId",true))
        {
            if(this.NodeId == null) {

                this.NodeId = "FETCH";

            } else {


            }
        }
        else if (this.NodeId != null && ec.Excludes("nodeId",true))
        {
            this.NodeId = null;
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        if (ec.Includes("nodeName",true))
        {
            if(this.NodeName == null) {

                this.NodeName = "FETCH";

            } else {


            }
        }
        else if (this.NodeName != null && ec.Excludes("nodeName",true))
        {
            this.NodeName = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<NetworkInterface> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NetworkInterface> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkInterface());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NetworkInterface> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types