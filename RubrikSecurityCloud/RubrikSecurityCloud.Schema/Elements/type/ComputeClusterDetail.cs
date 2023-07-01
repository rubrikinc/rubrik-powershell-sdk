// ComputeClusterDetail.cs
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
    #region ComputeClusterDetail
    public class ComputeClusterDetail: BaseType
    {
        #region members

        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        [JsonProperty("moid")]
        public System.String? Moid { get; set; }

        //      C# -> ComputeClusterSummary? ComputeClusterSummary
        // GraphQL -> computeClusterSummary: ComputeClusterSummary (type)
        [JsonProperty("computeClusterSummary")]
        public ComputeClusterSummary? ComputeClusterSummary { get; set; }

        //      C# -> List<VmwareHostSummary>? Hosts
        // GraphQL -> hosts: [VmwareHostSummary!]! (type)
        [JsonProperty("hosts")]
        public List<VmwareHostSummary>? Hosts { get; set; }

        //      C# -> List<VirtualMachineSummary>? VirtualMachines
        // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
        [JsonProperty("virtualMachines")]
        public List<VirtualMachineSummary>? VirtualMachines { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ComputeClusterDetail";
    }

    public ComputeClusterDetail Set(
        System.String? Moid = null,
        ComputeClusterSummary? ComputeClusterSummary = null,
        List<VmwareHostSummary>? Hosts = null,
        List<VirtualMachineSummary>? VirtualMachines = null
    ) 
    {
        if ( Moid != null ) {
            this.Moid = Moid;
        }
        if ( ComputeClusterSummary != null ) {
            this.ComputeClusterSummary = ComputeClusterSummary;
        }
        if ( Hosts != null ) {
            this.Hosts = Hosts;
        }
        if ( VirtualMachines != null ) {
            this.VirtualMachines = VirtualMachines;
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
        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        if (this.Moid != null) {
            s += ind + "moid\n" ;
        }
        //      C# -> ComputeClusterSummary? ComputeClusterSummary
        // GraphQL -> computeClusterSummary: ComputeClusterSummary (type)
        if (this.ComputeClusterSummary != null) {
            var fspec = this.ComputeClusterSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "computeClusterSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VmwareHostSummary>? Hosts
        // GraphQL -> hosts: [VmwareHostSummary!]! (type)
        if (this.Hosts != null) {
            var fspec = this.Hosts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hosts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VirtualMachineSummary>? VirtualMachines
        // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
        if (this.VirtualMachines != null) {
            var fspec = this.VirtualMachines.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "virtualMachines {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        if (this.Moid == null && Exploration.Includes(parent + ".moid", true))
        {
            this.Moid = "FETCH";
        }
        //      C# -> ComputeClusterSummary? ComputeClusterSummary
        // GraphQL -> computeClusterSummary: ComputeClusterSummary (type)
        if (this.ComputeClusterSummary == null && Exploration.Includes(parent + ".computeClusterSummary"))
        {
            this.ComputeClusterSummary = new ComputeClusterSummary();
            this.ComputeClusterSummary.ApplyExploratoryFieldSpec(parent + ".computeClusterSummary");
        }
        //      C# -> List<VmwareHostSummary>? Hosts
        // GraphQL -> hosts: [VmwareHostSummary!]! (type)
        if (this.Hosts == null && Exploration.Includes(parent + ".hosts"))
        {
            this.Hosts = new List<VmwareHostSummary>();
            this.Hosts.ApplyExploratoryFieldSpec(parent + ".hosts");
        }
        //      C# -> List<VirtualMachineSummary>? VirtualMachines
        // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
        if (this.VirtualMachines == null && Exploration.Includes(parent + ".virtualMachines"))
        {
            this.VirtualMachines = new List<VirtualMachineSummary>();
            this.VirtualMachines.ApplyExploratoryFieldSpec(parent + ".virtualMachines");
        }
    }


    #endregion

    } // class ComputeClusterDetail
    
    #endregion

    public static class ListComputeClusterDetailExtensions
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
            this List<ComputeClusterDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ComputeClusterDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ComputeClusterDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types