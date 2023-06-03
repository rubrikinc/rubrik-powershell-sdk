// GcpNativeNetwork.cs
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
    #region GcpNativeNetwork
    public class GcpNativeNetwork: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NativeProjectId
        // GraphQL -> nativeProjectId: String! (scalar)
        if (this.NativeProjectId != null) {
            s += ind + "nativeProjectId\n" ;
        }
        //      C# -> List<GcpNativeFirewallRule>? FirewallRules
        // GraphQL -> firewallRules: [GcpNativeFirewallRule!]! (type)
        if (this.FirewallRules != null) {
            s += ind + "firewallRules {\n" + this.FirewallRules.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<GcpNativeSubnetwork>? Subnetworks
        // GraphQL -> subnetworks: [GcpNativeSubnetwork!]! (type)
        if (this.Subnetworks != null) {
            s += ind + "subnetworks {\n" + this.Subnetworks.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.String? NativeProjectId
        // GraphQL -> nativeProjectId: String! (scalar)
        if (this.NativeProjectId == null && Exploration.Includes(parent + ".nativeProjectId", true))
        {
            this.NativeProjectId = new System.String("FETCH");
        }
        //      C# -> List<GcpNativeFirewallRule>? FirewallRules
        // GraphQL -> firewallRules: [GcpNativeFirewallRule!]! (type)
        if (this.FirewallRules == null && Exploration.Includes(parent + ".firewallRules"))
        {
            this.FirewallRules = new List<GcpNativeFirewallRule>();
            this.FirewallRules.ApplyExploratoryFieldSpec(parent + ".firewallRules");
        }
        //      C# -> List<GcpNativeSubnetwork>? Subnetworks
        // GraphQL -> subnetworks: [GcpNativeSubnetwork!]! (type)
        if (this.Subnetworks == null && Exploration.Includes(parent + ".subnetworks"))
        {
            this.Subnetworks = new List<GcpNativeSubnetwork>();
            this.Subnetworks.ApplyExploratoryFieldSpec(parent + ".subnetworks");
        }
    }


    #endregion

    } // class GcpNativeNetwork
    
    #endregion

    public static class ListGcpNativeNetworkExtensions
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
            this List<GcpNativeNetwork> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeNetwork> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeNetwork());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types