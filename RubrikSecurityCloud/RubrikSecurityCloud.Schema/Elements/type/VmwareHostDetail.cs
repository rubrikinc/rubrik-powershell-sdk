// VmwareHostDetail.cs
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
    #region VmwareHostDetail
    public class VmwareHostDetail: IFragment
    {
        #region members
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        [JsonProperty("computeClusterId")]
        public System.String? ComputeClusterId { get; set; }

        //      C# -> System.String? Moid
        // GraphQL -> moid: String (scalar)
        [JsonProperty("moid")]
        public System.String? Moid { get; set; }

        //      C# -> DataCenterSummary? Datacenter
        // GraphQL -> datacenter: DataCenterSummary (type)
        [JsonProperty("datacenter")]
        public DataCenterSummary? Datacenter { get; set; }

        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        [JsonProperty("datastores")]
        public List<DataStoreSummary>? Datastores { get; set; }

        //      C# -> List<VirtualMachineSummary>? VirtualMachines
        // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
        [JsonProperty("virtualMachines")]
        public List<VirtualMachineSummary>? VirtualMachines { get; set; }

        //      C# -> VmwareHostSummary? VmwareHostSummary
        // GraphQL -> vmwareHostSummary: VmwareHostSummary (type)
        [JsonProperty("vmwareHostSummary")]
        public VmwareHostSummary? VmwareHostSummary { get; set; }

        //      C# -> VmwareHostUpdate? VmwareHostUpdate
        // GraphQL -> vmwareHostUpdate: VmwareHostUpdate (type)
        [JsonProperty("vmwareHostUpdate")]
        public VmwareHostUpdate? VmwareHostUpdate { get; set; }

        #endregion

    #region methods

    public VmwareHostDetail Set(
        System.String? ComputeClusterId = null,
        System.String? Moid = null,
        DataCenterSummary? Datacenter = null,
        List<DataStoreSummary>? Datastores = null,
        List<VirtualMachineSummary>? VirtualMachines = null,
        VmwareHostSummary? VmwareHostSummary = null,
        VmwareHostUpdate? VmwareHostUpdate = null
    ) 
    {
        if ( ComputeClusterId != null ) {
            this.ComputeClusterId = ComputeClusterId;
        }
        if ( Moid != null ) {
            this.Moid = Moid;
        }
        if ( Datacenter != null ) {
            this.Datacenter = Datacenter;
        }
        if ( Datastores != null ) {
            this.Datastores = Datastores;
        }
        if ( VirtualMachines != null ) {
            this.VirtualMachines = VirtualMachines;
        }
        if ( VmwareHostSummary != null ) {
            this.VmwareHostSummary = VmwareHostSummary;
        }
        if ( VmwareHostUpdate != null ) {
            this.VmwareHostUpdate = VmwareHostUpdate;
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
            //      C# -> System.String? ComputeClusterId
            // GraphQL -> computeClusterId: String (scalar)
            if (this.ComputeClusterId != null)
            {
                 s += ind + "computeClusterId\n";

            }
            //      C# -> System.String? Moid
            // GraphQL -> moid: String (scalar)
            if (this.Moid != null)
            {
                 s += ind + "moid\n";

            }
            //      C# -> DataCenterSummary? Datacenter
            // GraphQL -> datacenter: DataCenterSummary (type)
            if (this.Datacenter != null)
            {
                 s += ind + "datacenter\n";

                 s += ind + "{\n" + 
                 this.Datacenter.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<DataStoreSummary>? Datastores
            // GraphQL -> datastores: [DataStoreSummary!]! (type)
            if (this.Datastores != null)
            {
                 s += ind + "datastores\n";

                 s += ind + "{\n" + 
                 this.Datastores.AsFragment(indent+1) + 
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
            //      C# -> VmwareHostSummary? VmwareHostSummary
            // GraphQL -> vmwareHostSummary: VmwareHostSummary (type)
            if (this.VmwareHostSummary != null)
            {
                 s += ind + "vmwareHostSummary\n";

                 s += ind + "{\n" + 
                 this.VmwareHostSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VmwareHostUpdate? VmwareHostUpdate
            // GraphQL -> vmwareHostUpdate: VmwareHostUpdate (type)
            if (this.VmwareHostUpdate != null)
            {
                 s += ind + "vmwareHostUpdate\n";

                 s += ind + "{\n" + 
                 this.VmwareHostUpdate.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ComputeClusterId
            // GraphQL -> computeClusterId: String (scalar)
            if (this.ComputeClusterId == null && Exploration.Includes(parent + ".computeClusterId$"))
            {
                this.ComputeClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? Moid
            // GraphQL -> moid: String (scalar)
            if (this.Moid == null && Exploration.Includes(parent + ".moid$"))
            {
                this.Moid = new System.String("FETCH");
            }
            //      C# -> DataCenterSummary? Datacenter
            // GraphQL -> datacenter: DataCenterSummary (type)
            if (this.Datacenter == null && Exploration.Includes(parent + ".datacenter"))
            {
                this.Datacenter = new DataCenterSummary();
                this.Datacenter.ApplyExploratoryFragment(parent + ".datacenter");
            }
            //      C# -> List<DataStoreSummary>? Datastores
            // GraphQL -> datastores: [DataStoreSummary!]! (type)
            if (this.Datastores == null && Exploration.Includes(parent + ".datastores"))
            {
                this.Datastores = new List<DataStoreSummary>();
                this.Datastores.ApplyExploratoryFragment(parent + ".datastores");
            }
            //      C# -> List<VirtualMachineSummary>? VirtualMachines
            // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
            if (this.VirtualMachines == null && Exploration.Includes(parent + ".virtualMachines"))
            {
                this.VirtualMachines = new List<VirtualMachineSummary>();
                this.VirtualMachines.ApplyExploratoryFragment(parent + ".virtualMachines");
            }
            //      C# -> VmwareHostSummary? VmwareHostSummary
            // GraphQL -> vmwareHostSummary: VmwareHostSummary (type)
            if (this.VmwareHostSummary == null && Exploration.Includes(parent + ".vmwareHostSummary"))
            {
                this.VmwareHostSummary = new VmwareHostSummary();
                this.VmwareHostSummary.ApplyExploratoryFragment(parent + ".vmwareHostSummary");
            }
            //      C# -> VmwareHostUpdate? VmwareHostUpdate
            // GraphQL -> vmwareHostUpdate: VmwareHostUpdate (type)
            if (this.VmwareHostUpdate == null && Exploration.Includes(parent + ".vmwareHostUpdate"))
            {
                this.VmwareHostUpdate = new VmwareHostUpdate();
                this.VmwareHostUpdate.ApplyExploratoryFragment(parent + ".vmwareHostUpdate");
            }
        }


    #endregion

    } // class VmwareHostDetail
    #endregion

    public static class ListVmwareHostDetailExtensions
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
            this List<VmwareHostDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmwareHostDetail> list, 
            String parent = "")
        {
            var item = new VmwareHostDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types