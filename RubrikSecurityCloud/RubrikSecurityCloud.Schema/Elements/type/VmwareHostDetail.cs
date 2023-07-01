// VmwareHostDetail.cs
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
    #region VmwareHostDetail
    public class VmwareHostDetail: BaseType
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

    public override string GetGqlTypeName() {
        return "VmwareHostDetail";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        if (this.ComputeClusterId != null) {
            s += ind + "computeClusterId\n" ;
        }
        //      C# -> System.String? Moid
        // GraphQL -> moid: String (scalar)
        if (this.Moid != null) {
            s += ind + "moid\n" ;
        }
        //      C# -> DataCenterSummary? Datacenter
        // GraphQL -> datacenter: DataCenterSummary (type)
        if (this.Datacenter != null) {
            var fspec = this.Datacenter.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "datacenter {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        if (this.Datastores != null) {
            var fspec = this.Datastores.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "datastores {\n" + fspec + ind + "}\n" ;
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
        //      C# -> VmwareHostSummary? VmwareHostSummary
        // GraphQL -> vmwareHostSummary: VmwareHostSummary (type)
        if (this.VmwareHostSummary != null) {
            var fspec = this.VmwareHostSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vmwareHostSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VmwareHostUpdate? VmwareHostUpdate
        // GraphQL -> vmwareHostUpdate: VmwareHostUpdate (type)
        if (this.VmwareHostUpdate != null) {
            var fspec = this.VmwareHostUpdate.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vmwareHostUpdate {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        if (this.ComputeClusterId == null && Exploration.Includes(parent + ".computeClusterId", true))
        {
            this.ComputeClusterId = "FETCH";
        }
        //      C# -> System.String? Moid
        // GraphQL -> moid: String (scalar)
        if (this.Moid == null && Exploration.Includes(parent + ".moid", true))
        {
            this.Moid = "FETCH";
        }
        //      C# -> DataCenterSummary? Datacenter
        // GraphQL -> datacenter: DataCenterSummary (type)
        if (this.Datacenter == null && Exploration.Includes(parent + ".datacenter"))
        {
            this.Datacenter = new DataCenterSummary();
            this.Datacenter.ApplyExploratoryFieldSpec(parent + ".datacenter");
        }
        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        if (this.Datastores == null && Exploration.Includes(parent + ".datastores"))
        {
            this.Datastores = new List<DataStoreSummary>();
            this.Datastores.ApplyExploratoryFieldSpec(parent + ".datastores");
        }
        //      C# -> List<VirtualMachineSummary>? VirtualMachines
        // GraphQL -> virtualMachines: [VirtualMachineSummary!]! (type)
        if (this.VirtualMachines == null && Exploration.Includes(parent + ".virtualMachines"))
        {
            this.VirtualMachines = new List<VirtualMachineSummary>();
            this.VirtualMachines.ApplyExploratoryFieldSpec(parent + ".virtualMachines");
        }
        //      C# -> VmwareHostSummary? VmwareHostSummary
        // GraphQL -> vmwareHostSummary: VmwareHostSummary (type)
        if (this.VmwareHostSummary == null && Exploration.Includes(parent + ".vmwareHostSummary"))
        {
            this.VmwareHostSummary = new VmwareHostSummary();
            this.VmwareHostSummary.ApplyExploratoryFieldSpec(parent + ".vmwareHostSummary");
        }
        //      C# -> VmwareHostUpdate? VmwareHostUpdate
        // GraphQL -> vmwareHostUpdate: VmwareHostUpdate (type)
        if (this.VmwareHostUpdate == null && Exploration.Includes(parent + ".vmwareHostUpdate"))
        {
            this.VmwareHostUpdate = new VmwareHostUpdate();
            this.VmwareHostUpdate.ApplyExploratoryFieldSpec(parent + ".vmwareHostUpdate");
        }
    }


    #endregion

    } // class VmwareHostDetail
    
    #endregion

    public static class ListVmwareHostDetailExtensions
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
            this List<VmwareHostDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareHostDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareHostDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types