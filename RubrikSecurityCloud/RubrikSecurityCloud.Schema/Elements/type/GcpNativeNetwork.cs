// GcpNativeNetwork.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:34.
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
    #region GcpNativeNetwork
    public class GcpNativeNetwork: IFragment
    {
        #region members
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeProjectId
        // GraphQL -> nativeProjectId: String! (scalar)
        [JsonProperty("nativeProjectId")]
        public System.String? NativeProjectId { get; set; }

        //      C# -> List<GcpNativeFirewallRule>? FirewallRules
        // GraphQL -> firewallRules: [GcpNativeFirewallRule!]! (type)
        [JsonProperty("firewallRules")]
        public List<GcpNativeFirewallRule>? FirewallRules { get; set; }

        //      C# -> List<GcpNativeSubnetwork>? Subnetworks
        // GraphQL -> subnetworks: [GcpNativeSubnetwork!]! (type)
        [JsonProperty("subnetworks")]
        public List<GcpNativeSubnetwork>? Subnetworks { get; set; }

        #endregion

    #region methods

    public GcpNativeNetwork Set(
        System.String? Name = null,
        System.String? NativeProjectId = null,
        List<GcpNativeFirewallRule>? FirewallRules = null,
        List<GcpNativeSubnetwork>? Subnetworks = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeProjectId != null ) {
            this.NativeProjectId = NativeProjectId;
        }
        if ( FirewallRules != null ) {
            this.FirewallRules = FirewallRules;
        }
        if ( Subnetworks != null ) {
            this.Subnetworks = Subnetworks;
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
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? NativeProjectId
            // GraphQL -> nativeProjectId: String! (scalar)
            if (this.NativeProjectId != null)
            {
                 s += ind + "nativeProjectId\n";

            }
            //      C# -> List<GcpNativeFirewallRule>? FirewallRules
            // GraphQL -> firewallRules: [GcpNativeFirewallRule!]! (type)
            if (this.FirewallRules != null)
            {
                 s += ind + "firewallRules\n";

                 s += ind + "{\n" + 
                 this.FirewallRules.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<GcpNativeSubnetwork>? Subnetworks
            // GraphQL -> subnetworks: [GcpNativeSubnetwork!]! (type)
            if (this.Subnetworks != null)
            {
                 s += ind + "subnetworks\n";

                 s += ind + "{\n" + 
                 this.Subnetworks.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? NativeProjectId
            // GraphQL -> nativeProjectId: String! (scalar)
            if (this.NativeProjectId == null && Exploration.Includes(parent + ".nativeProjectId$"))
            {
                this.NativeProjectId = new System.String("FETCH");
            }
            //      C# -> List<GcpNativeFirewallRule>? FirewallRules
            // GraphQL -> firewallRules: [GcpNativeFirewallRule!]! (type)
            if (this.FirewallRules == null && Exploration.Includes(parent + ".firewallRules"))
            {
                this.FirewallRules = new List<GcpNativeFirewallRule>();
                this.FirewallRules.ApplyExploratoryFragment(parent + ".firewallRules");
            }
            //      C# -> List<GcpNativeSubnetwork>? Subnetworks
            // GraphQL -> subnetworks: [GcpNativeSubnetwork!]! (type)
            if (this.Subnetworks == null && Exploration.Includes(parent + ".subnetworks"))
            {
                this.Subnetworks = new List<GcpNativeSubnetwork>();
                this.Subnetworks.ApplyExploratoryFragment(parent + ".subnetworks");
            }
        }


    #endregion

    } // class GcpNativeNetwork
    #endregion

    public static class ListGcpNativeNetworkExtensions
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
            this List<GcpNativeNetwork> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpNativeNetwork> list, 
            String parent = "")
        {
            var item = new GcpNativeNetwork();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types