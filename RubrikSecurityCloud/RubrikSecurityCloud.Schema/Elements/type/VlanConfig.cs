// VlanConfig.cs
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
    #region VlanConfig
    public class VlanConfig: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Netmask
            // GraphQL -> netmask: String! (scalar)
            if (this.Netmask != null)
            {
                 s += ind + "netmask\n";

            }
            //      C# -> System.Int32? Vlan
            // GraphQL -> vlan: Int! (scalar)
            if (this.Vlan != null)
            {
                 s += ind + "vlan\n";

            }
            //      C# -> List<NodeIp>? Interfaces
            // GraphQL -> interfaces: [NodeIp!]! (type)
            if (this.Interfaces != null)
            {
                 s += ind + "interfaces\n";

                 s += ind + "{\n" + 
                 this.Interfaces.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Netmask
            // GraphQL -> netmask: String! (scalar)
            if (this.Netmask == null && Exploration.Includes(parent + ".netmask$"))
            {
                this.Netmask = new System.String("FETCH");
            }
            //      C# -> System.Int32? Vlan
            // GraphQL -> vlan: Int! (scalar)
            if (this.Vlan == null && Exploration.Includes(parent + ".vlan$"))
            {
                this.Vlan = new System.Int32();
            }
            //      C# -> List<NodeIp>? Interfaces
            // GraphQL -> interfaces: [NodeIp!]! (type)
            if (this.Interfaces == null && Exploration.Includes(parent + ".interfaces"))
            {
                this.Interfaces = new List<NodeIp>();
                this.Interfaces.ApplyExploratoryFragment(parent + ".interfaces");
            }
        }


    #endregion

    } // class VlanConfig
    #endregion

    public static class ListVlanConfigExtensions
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
            this List<VlanConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VlanConfig> list, 
            String parent = "")
        {
            var item = new VlanConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types