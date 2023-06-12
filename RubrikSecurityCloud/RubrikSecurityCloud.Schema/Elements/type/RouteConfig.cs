// RouteConfig.cs
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
    #region RouteConfig
    public class RouteConfig: BaseType
    {
        #region members

        //      C# -> System.String? Device
        // GraphQL -> device: String! (scalar)
        [JsonProperty("device")]
        public System.String? Device { get; set; }

        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        [JsonProperty("gateway")]
        public System.String? Gateway { get; set; }

        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        [JsonProperty("netmask")]
        public System.String? Netmask { get; set; }

        //      C# -> System.String? Network
        // GraphQL -> network: String! (scalar)
        [JsonProperty("network")]
        public System.String? Network { get; set; }


        #endregion

    #region methods

    public RouteConfig Set(
        System.String? Device = null,
        System.String? Gateway = null,
        System.String? Netmask = null,
        System.String? Network = null
    ) 
    {
        if ( Device != null ) {
            this.Device = Device;
        }
        if ( Gateway != null ) {
            this.Gateway = Gateway;
        }
        if ( Netmask != null ) {
            this.Netmask = Netmask;
        }
        if ( Network != null ) {
            this.Network = Network;
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
        //      C# -> System.String? Device
        // GraphQL -> device: String! (scalar)
        if (this.Device != null) {
            s += ind + "device\n" ;
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        if (this.Gateway != null) {
            s += ind + "gateway\n" ;
        }
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (this.Netmask != null) {
            s += ind + "netmask\n" ;
        }
        //      C# -> System.String? Network
        // GraphQL -> network: String! (scalar)
        if (this.Network != null) {
            s += ind + "network\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Device
        // GraphQL -> device: String! (scalar)
        if (this.Device == null && Exploration.Includes(parent + ".device", true))
        {
            this.Device = "FETCH";
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        if (this.Gateway == null && Exploration.Includes(parent + ".gateway", true))
        {
            this.Gateway = "FETCH";
        }
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (this.Netmask == null && Exploration.Includes(parent + ".netmask", true))
        {
            this.Netmask = "FETCH";
        }
        //      C# -> System.String? Network
        // GraphQL -> network: String! (scalar)
        if (this.Network == null && Exploration.Includes(parent + ".network", true))
        {
            this.Network = "FETCH";
        }
    }


    #endregion

    } // class RouteConfig
    
    #endregion

    public static class ListRouteConfigExtensions
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
            this List<RouteConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RouteConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RouteConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types