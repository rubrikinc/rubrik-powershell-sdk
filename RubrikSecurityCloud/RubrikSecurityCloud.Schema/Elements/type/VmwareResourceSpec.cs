// VmwareResourceSpec.cs
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
    #region VmwareResourceSpec
 
    public class VmwareResourceSpec: BaseType, ResourceSpec
    {
        #region members

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        [JsonProperty("memoryMbs")]
        public System.Int32? MemoryMbs { get; set; }

        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        [JsonProperty("osType")]
        public System.String? OsType { get; set; }

        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        [JsonProperty("recoveryPointOpt")]
        public System.Int64? RecoveryPointOpt { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        [JsonProperty("snappableName")]
        public System.String? SnappableName { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? Vcpus
        // GraphQL -> vCpus: Int! (scalar)
        [JsonProperty("vCpus")]
        public System.Int32? Vcpus { get; set; }

        //      C# -> List<VmwareVirtualMachineVolume>? VmWareVolumeSpecs
        // GraphQL -> vmWareVolumeSpecs: [VmwareVirtualMachineVolume!]! (type)
        [JsonProperty("vmWareVolumeSpecs")]
        public List<VmwareVirtualMachineVolume>? VmWareVolumeSpecs { get; set; }

        //      C# -> List<VmwareVirtualMachineNic>? VmwareNics
        // GraphQL -> vmwareNics: [VmwareVirtualMachineNic!]! (type)
        [JsonProperty("vmwareNics")]
        public List<VmwareVirtualMachineNic>? VmwareNics { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareResourceSpec";
    }

    public VmwareResourceSpec Set(
        System.Boolean? IsArchived = null,
        System.Int32? MemoryMbs = null,
        System.String? OsType = null,
        System.Int64? RecoveryPointOpt = null,
        System.String? SnappableId = null,
        System.String? SnappableName = null,
        System.String? SnapshotId = null,
        System.Int32? Vcpus = null,
        List<VmwareVirtualMachineVolume>? VmWareVolumeSpecs = null,
        List<VmwareVirtualMachineNic>? VmwareNics = null
    ) 
    {
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( MemoryMbs != null ) {
            this.MemoryMbs = MemoryMbs;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( RecoveryPointOpt != null ) {
            this.RecoveryPointOpt = RecoveryPointOpt;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( SnappableName != null ) {
            this.SnappableName = SnappableName;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( Vcpus != null ) {
            this.Vcpus = Vcpus;
        }
        if ( VmWareVolumeSpecs != null ) {
            this.VmWareVolumeSpecs = VmWareVolumeSpecs;
        }
        if ( VmwareNics != null ) {
            this.VmwareNics = VmwareNics;
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
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        if (this.MemoryMbs != null) {
            s += ind + "memoryMbs\n" ;
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (this.OsType != null) {
            s += ind + "osType\n" ;
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (this.RecoveryPointOpt != null) {
            s += ind + "recoveryPointOpt\n" ;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            s += ind + "snappableId\n" ;
        }
        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        if (this.SnappableName != null) {
            s += ind + "snappableName\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vCpus: Int! (scalar)
        if (this.Vcpus != null) {
            s += ind + "vCpus\n" ;
        }
        //      C# -> List<VmwareVirtualMachineVolume>? VmWareVolumeSpecs
        // GraphQL -> vmWareVolumeSpecs: [VmwareVirtualMachineVolume!]! (type)
        if (this.VmWareVolumeSpecs != null) {
            var fspec = this.VmWareVolumeSpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vmWareVolumeSpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VmwareVirtualMachineNic>? VmwareNics
        // GraphQL -> vmwareNics: [VmwareVirtualMachineNic!]! (type)
        if (this.VmwareNics != null) {
            var fspec = this.VmwareNics.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vmwareNics {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        if (this.MemoryMbs == null && Exploration.Includes(parent + ".memoryMbs", true))
        {
            this.MemoryMbs = Int32.MinValue;
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (this.OsType == null && Exploration.Includes(parent + ".osType", true))
        {
            this.OsType = "FETCH";
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (this.RecoveryPointOpt == null && Exploration.Includes(parent + ".recoveryPointOpt", true))
        {
            this.RecoveryPointOpt = new System.Int64();
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId == null && Exploration.Includes(parent + ".snappableId", true))
        {
            this.SnappableId = "FETCH";
        }
        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        if (this.SnappableName == null && Exploration.Includes(parent + ".snappableName", true))
        {
            this.SnappableName = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vCpus: Int! (scalar)
        if (this.Vcpus == null && Exploration.Includes(parent + ".vCpus", true))
        {
            this.Vcpus = Int32.MinValue;
        }
        //      C# -> List<VmwareVirtualMachineVolume>? VmWareVolumeSpecs
        // GraphQL -> vmWareVolumeSpecs: [VmwareVirtualMachineVolume!]! (type)
        if (this.VmWareVolumeSpecs == null && Exploration.Includes(parent + ".vmWareVolumeSpecs"))
        {
            this.VmWareVolumeSpecs = new List<VmwareVirtualMachineVolume>();
            this.VmWareVolumeSpecs.ApplyExploratoryFieldSpec(parent + ".vmWareVolumeSpecs");
        }
        //      C# -> List<VmwareVirtualMachineNic>? VmwareNics
        // GraphQL -> vmwareNics: [VmwareVirtualMachineNic!]! (type)
        if (this.VmwareNics == null && Exploration.Includes(parent + ".vmwareNics"))
        {
            this.VmwareNics = new List<VmwareVirtualMachineNic>();
            this.VmwareNics.ApplyExploratoryFieldSpec(parent + ".vmwareNics");
        }
    }


    #endregion

    } // class VmwareResourceSpec
    
    #endregion

    public static class ListVmwareResourceSpecExtensions
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
            this List<VmwareResourceSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareResourceSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareResourceSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types