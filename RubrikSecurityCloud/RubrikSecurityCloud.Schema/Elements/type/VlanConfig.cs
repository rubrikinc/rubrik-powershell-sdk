// VlanConfig.cs
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
    #region VlanConfig
    public class VlanConfig: BaseType
    {
        #region members

        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        [JsonProperty("alias")]
        public System.String? Alias { get; set; }

        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        [JsonProperty("netmask")]
        public System.String? Netmask { get; set; }

        //      C# -> System.Int32? Vlan
        // GraphQL -> vlan: Int! (scalar)
        [JsonProperty("vlan")]
        public System.Int32? Vlan { get; set; }

        //      C# -> List<NodeIp>? Interfaces
        // GraphQL -> interfaces: [NodeIp!]! (type)
        [JsonProperty("interfaces")]
        public List<NodeIp>? Interfaces { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VlanConfig";
    }

    public VlanConfig Set(
        System.String? Alias = null,
        System.String? Netmask = null,
        System.Int32? Vlan = null,
        List<NodeIp>? Interfaces = null
    ) 
    {
        if ( Alias != null ) {
            this.Alias = Alias;
        }
        if ( Netmask != null ) {
            this.Netmask = Netmask;
        }
        if ( Vlan != null ) {
            this.Vlan = Vlan;
        }
        if ( Interfaces != null ) {
            this.Interfaces = Interfaces;
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
        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        if (this.Alias != null) {
            if (conf.Flat) {
                s += conf.Prefix + "alias\n" ;
            } else {
                s += ind + "alias\n" ;
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
        //      C# -> System.Int32? Vlan
        // GraphQL -> vlan: Int! (scalar)
        if (this.Vlan != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vlan\n" ;
            } else {
                s += ind + "vlan\n" ;
            }
        }
        //      C# -> List<NodeIp>? Interfaces
        // GraphQL -> interfaces: [NodeIp!]! (type)
        if (this.Interfaces != null) {
            var fspec = this.Interfaces.AsFieldSpec(conf.Child("interfaces"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "interfaces {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        if (ec.Includes("alias",true))
        {
            if(this.Alias == null) {

                this.Alias = "FETCH";

            } else {


            }
        }
        else if (this.Alias != null && ec.Excludes("alias",true))
        {
            this.Alias = null;
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
        //      C# -> System.Int32? Vlan
        // GraphQL -> vlan: Int! (scalar)
        if (ec.Includes("vlan",true))
        {
            if(this.Vlan == null) {

                this.Vlan = Int32.MinValue;

            } else {


            }
        }
        else if (this.Vlan != null && ec.Excludes("vlan",true))
        {
            this.Vlan = null;
        }
        //      C# -> List<NodeIp>? Interfaces
        // GraphQL -> interfaces: [NodeIp!]! (type)
        if (ec.Includes("interfaces",false))
        {
            if(this.Interfaces == null) {

                this.Interfaces = new List<NodeIp>();
                this.Interfaces.ApplyExploratoryFieldSpec(ec.NewChild("interfaces"));

            } else {

                this.Interfaces.ApplyExploratoryFieldSpec(ec.NewChild("interfaces"));

            }
        }
        else if (this.Interfaces != null && ec.Excludes("interfaces",false))
        {
            this.Interfaces = null;
        }
    }


    #endregion

    } // class VlanConfig
    
    #endregion

    public static class ListVlanConfigExtensions
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
            this List<VlanConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VlanConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VlanConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VlanConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VlanConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types