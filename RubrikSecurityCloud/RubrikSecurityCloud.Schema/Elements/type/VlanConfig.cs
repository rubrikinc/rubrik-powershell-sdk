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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region VlanConfig
    public class VlanConfig: BaseType
    {
        #region members

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

    public VlanConfig Set(
        System.String? Netmask = null,
        System.Int32? Vlan = null,
        List<NodeIp>? Interfaces = null
    ) 
    {
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (this.Netmask != null) {
            s += ind + "netmask\n" ;
        }
        //      C# -> System.Int32? Vlan
        // GraphQL -> vlan: Int! (scalar)
        if (this.Vlan != null) {
            s += ind + "vlan\n" ;
        }
        //      C# -> List<NodeIp>? Interfaces
        // GraphQL -> interfaces: [NodeIp!]! (type)
        if (this.Interfaces != null) {
            var fspec = this.Interfaces.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "interfaces {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        if (this.Netmask == null && Exploration.Includes(parent + ".netmask", true))
        {
            this.Netmask = "FETCH";
        }
        //      C# -> System.Int32? Vlan
        // GraphQL -> vlan: Int! (scalar)
        if (this.Vlan == null && Exploration.Includes(parent + ".vlan", true))
        {
            this.Vlan = Int32.MinValue;
        }
        //      C# -> List<NodeIp>? Interfaces
        // GraphQL -> interfaces: [NodeIp!]! (type)
        if (this.Interfaces == null && Exploration.Includes(parent + ".interfaces"))
        {
            this.Interfaces = new List<NodeIp>();
            this.Interfaces.ApplyExploratoryFieldSpec(parent + ".interfaces");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VlanConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VlanConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types