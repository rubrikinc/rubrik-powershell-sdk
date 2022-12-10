// ComputeClusterDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:10.
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
    #region ComputeClusterDetail
    public class ComputeClusterDetail: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Moid
            // GraphQL -> moid: String! (scalar)
            if (this.Moid != null)
            {
                 s += ind + "moid\n";

            }
            //      C# -> ComputeClusterSummary? ComputeClusterSummary
            // GraphQL -> computeClusterSummary: ComputeClusterSummary (type)
            if (this.ComputeClusterSummary != null)
            {
                 s += ind + "computeClusterSummary\n";

                 s += ind + "{\n" + 
                 this.ComputeClusterSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<VmwareHostSummary>? Hosts
            // GraphQL -> hosts: [VmwareHostSummary!]! (type)
            if (this.Hosts != null)
            {
                 s += ind + "hosts\n";

                 s += ind + "{\n" + 
                 this.Hosts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<VirtualMachineSummary>? VirtualMachines
            // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
            if (this.VirtualMachines != null)
            {
                 s += ind + "virtualMachines\n";

                 s += ind + "{\n" + 
                 this.VirtualMachines.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Moid
            // GraphQL -> moid: String! (scalar)
            if (this.Moid == null && Exploration.Includes(parent + ".moid$"))
            {
                this.Moid = new System.String("FETCH");
            }
            //      C# -> ComputeClusterSummary? ComputeClusterSummary
            // GraphQL -> computeClusterSummary: ComputeClusterSummary (type)
            if (this.ComputeClusterSummary == null && Exploration.Includes(parent + ".computeClusterSummary"))
            {
                this.ComputeClusterSummary = new ComputeClusterSummary();
                this.ComputeClusterSummary.ApplyExploratoryFragment(parent + ".computeClusterSummary");
            }
            //      C# -> List<VmwareHostSummary>? Hosts
            // GraphQL -> hosts: [VmwareHostSummary!]! (type)
            if (this.Hosts == null && Exploration.Includes(parent + ".hosts"))
            {
                this.Hosts = new List<VmwareHostSummary>();
                this.Hosts.ApplyExploratoryFragment(parent + ".hosts");
            }
            //      C# -> List<VirtualMachineSummary>? VirtualMachines
            // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
            if (this.VirtualMachines == null && Exploration.Includes(parent + ".virtualMachines"))
            {
                this.VirtualMachines = new List<VirtualMachineSummary>();
                this.VirtualMachines.ApplyExploratoryFragment(parent + ".virtualMachines");
            }
        }


    #endregion

    } // class ComputeClusterDetail
    #endregion

    public static class ListComputeClusterDetailExtensions
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
            this List<ComputeClusterDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ComputeClusterDetail> list, 
            String parent = "")
        {
            var item = new ComputeClusterDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types