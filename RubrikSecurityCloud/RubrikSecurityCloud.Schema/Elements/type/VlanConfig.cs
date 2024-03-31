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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VlanConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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