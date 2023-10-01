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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "RouteConfig";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Device
        // GraphQL -> device: String! (scalar)
        if (this.Device != null) {
            if (conf.Flat) {
                s += conf.Prefix + "device\n" ;
            } else {
                s += ind + "device\n" ;
            }
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        if (this.Gateway != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gateway\n" ;
            } else {
                s += ind + "gateway\n" ;
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
        //      C# -> System.String? Network
        // GraphQL -> network: String! (scalar)
        if (this.Network != null) {
            if (conf.Flat) {
                s += conf.Prefix + "network\n" ;
            } else {
                s += ind + "network\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Device
        // GraphQL -> device: String! (scalar)
        if (ec.Includes("device",true))
        {
            if(this.Device == null) {

                this.Device = "FETCH";

            } else {


            }
        }
        else if (this.Device != null && ec.Excludes("device",true))
        {
            this.Device = null;
        }
        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        if (ec.Includes("gateway",true))
        {
            if(this.Gateway == null) {

                this.Gateway = "FETCH";

            } else {


            }
        }
        else if (this.Gateway != null && ec.Excludes("gateway",true))
        {
            this.Gateway = null;
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
        //      C# -> System.String? Network
        // GraphQL -> network: String! (scalar)
        if (ec.Includes("network",true))
        {
            if(this.Network == null) {

                this.Network = "FETCH";

            } else {


            }
        }
        else if (this.Network != null && ec.Excludes("network",true))
        {
            this.Network = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RouteConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RouteConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RouteConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RouteConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types