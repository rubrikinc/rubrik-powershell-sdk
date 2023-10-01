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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "GcpNativeNetwork";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? NativeProjectId
        // GraphQL -> nativeProjectId: String! (scalar)
        if (this.NativeProjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeProjectId\n" ;
            } else {
                s += ind + "nativeProjectId\n" ;
            }
        }
        //      C# -> List<GcpNativeFirewallRule>? FirewallRules
        // GraphQL -> firewallRules: [GcpNativeFirewallRule!]! (type)
        if (this.FirewallRules != null) {
            var fspec = this.FirewallRules.AsFieldSpec(conf.Child("firewallRules"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "firewallRules {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<GcpNativeSubnetwork>? Subnetworks
        // GraphQL -> subnetworks: [GcpNativeSubnetwork!]! (type)
        if (this.Subnetworks != null) {
            var fspec = this.Subnetworks.AsFieldSpec(conf.Child("subnetworks"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subnetworks {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? NativeProjectId
        // GraphQL -> nativeProjectId: String! (scalar)
        if (ec.Includes("nativeProjectId",true))
        {
            if(this.NativeProjectId == null) {

                this.NativeProjectId = "FETCH";

            } else {


            }
        }
        else if (this.NativeProjectId != null && ec.Excludes("nativeProjectId",true))
        {
            this.NativeProjectId = null;
        }
        //      C# -> List<GcpNativeFirewallRule>? FirewallRules
        // GraphQL -> firewallRules: [GcpNativeFirewallRule!]! (type)
        if (ec.Includes("firewallRules",false))
        {
            if(this.FirewallRules == null) {

                this.FirewallRules = new List<GcpNativeFirewallRule>();
                this.FirewallRules.ApplyExploratoryFieldSpec(ec.NewChild("firewallRules"));

            } else {

                this.FirewallRules.ApplyExploratoryFieldSpec(ec.NewChild("firewallRules"));

            }
        }
        else if (this.FirewallRules != null && ec.Excludes("firewallRules",false))
        {
            this.FirewallRules = null;
        }
        //      C# -> List<GcpNativeSubnetwork>? Subnetworks
        // GraphQL -> subnetworks: [GcpNativeSubnetwork!]! (type)
        if (ec.Includes("subnetworks",false))
        {
            if(this.Subnetworks == null) {

                this.Subnetworks = new List<GcpNativeSubnetwork>();
                this.Subnetworks.ApplyExploratoryFieldSpec(ec.NewChild("subnetworks"));

            } else {

                this.Subnetworks.ApplyExploratoryFieldSpec(ec.NewChild("subnetworks"));

            }
        }
        else if (this.Subnetworks != null && ec.Excludes("subnetworks",false))
        {
            this.Subnetworks = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GcpNativeNetwork> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeNetwork> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeNetwork());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeNetwork> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types