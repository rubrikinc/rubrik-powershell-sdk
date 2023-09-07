// VsphereBlueprintChildSnapshotInfo.cs
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
    #region VsphereBlueprintChildSnapshotInfo
    public class VsphereBlueprintChildSnapshotInfo: BaseType
    {
        #region members

        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        [JsonProperty("memoryMbs")]
        public System.Int32? MemoryMbs { get; set; }

        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        [JsonProperty("osType")]
        public System.String? OsType { get; set; }

        //      C# -> System.String? SnapshotAppMetadata
        // GraphQL -> snapshotAppMetadata: String! (scalar)
        [JsonProperty("snapshotAppMetadata")]
        public System.String? SnapshotAppMetadata { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? Vcpus
        // GraphQL -> vcpus: Int! (scalar)
        [JsonProperty("vcpus")]
        public System.Int32? Vcpus { get; set; }

        //      C# -> VmHost? Host
        // GraphQL -> host: VmHost (type)
        [JsonProperty("host")]
        public VmHost? Host { get; set; }

        //      C# -> List<VmNicMapEntry>? NicMap
        // GraphQL -> nicMap: [VmNicMapEntry!]! (type)
        [JsonProperty("nicMap")]
        public List<VmNicMapEntry>? NicMap { get; set; }

        //      C# -> List<VmDiskMapEntry>? VolumeMap
        // GraphQL -> volumeMap: [VmDiskMapEntry!]! (type)
        [JsonProperty("volumeMap")]
        public List<VmDiskMapEntry>? VolumeMap { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereBlueprintChildSnapshotInfo";
    }

    public VsphereBlueprintChildSnapshotInfo Set(
        System.Int32? MemoryMbs = null,
        System.String? OsType = null,
        System.String? SnapshotAppMetadata = null,
        System.String? SnapshotId = null,
        System.Int32? Vcpus = null,
        VmHost? Host = null,
        List<VmNicMapEntry>? NicMap = null,
        List<VmDiskMapEntry>? VolumeMap = null
    ) 
    {
        if ( MemoryMbs != null ) {
            this.MemoryMbs = MemoryMbs;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( SnapshotAppMetadata != null ) {
            this.SnapshotAppMetadata = SnapshotAppMetadata;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( Vcpus != null ) {
            this.Vcpus = Vcpus;
        }
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( NicMap != null ) {
            this.NicMap = NicMap;
        }
        if ( VolumeMap != null ) {
            this.VolumeMap = VolumeMap;
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
        //      C# -> System.String? SnapshotAppMetadata
        // GraphQL -> snapshotAppMetadata: String! (scalar)
        if (this.SnapshotAppMetadata != null) {
            s += ind + "snapshotAppMetadata\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vcpus: Int! (scalar)
        if (this.Vcpus != null) {
            s += ind + "vcpus\n" ;
        }
        //      C# -> VmHost? Host
        // GraphQL -> host: VmHost (type)
        if (this.Host != null) {
            var fspec = this.Host.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "host {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VmNicMapEntry>? NicMap
        // GraphQL -> nicMap: [VmNicMapEntry!]! (type)
        if (this.NicMap != null) {
            var fspec = this.NicMap.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nicMap {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VmDiskMapEntry>? VolumeMap
        // GraphQL -> volumeMap: [VmDiskMapEntry!]! (type)
        if (this.VolumeMap != null) {
            var fspec = this.VolumeMap.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "volumeMap {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        if (this.MemoryMbs == null && ec.Includes("memoryMbs",true))
        {
            this.MemoryMbs = Int32.MinValue;
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (this.OsType == null && ec.Includes("osType",true))
        {
            this.OsType = "FETCH";
        }
        //      C# -> System.String? SnapshotAppMetadata
        // GraphQL -> snapshotAppMetadata: String! (scalar)
        if (this.SnapshotAppMetadata == null && ec.Includes("snapshotAppMetadata",true))
        {
            this.SnapshotAppMetadata = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && ec.Includes("snapshotId",true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vcpus: Int! (scalar)
        if (this.Vcpus == null && ec.Includes("vcpus",true))
        {
            this.Vcpus = Int32.MinValue;
        }
        //      C# -> VmHost? Host
        // GraphQL -> host: VmHost (type)
        if (this.Host == null && ec.Includes("host",false))
        {
            this.Host = new VmHost();
            this.Host.ApplyExploratoryFieldSpec(ec.NewChild("host"));
        }
        //      C# -> List<VmNicMapEntry>? NicMap
        // GraphQL -> nicMap: [VmNicMapEntry!]! (type)
        if (this.NicMap == null && ec.Includes("nicMap",false))
        {
            this.NicMap = new List<VmNicMapEntry>();
            this.NicMap.ApplyExploratoryFieldSpec(ec.NewChild("nicMap"));
        }
        //      C# -> List<VmDiskMapEntry>? VolumeMap
        // GraphQL -> volumeMap: [VmDiskMapEntry!]! (type)
        if (this.VolumeMap == null && ec.Includes("volumeMap",false))
        {
            this.VolumeMap = new List<VmDiskMapEntry>();
            this.VolumeMap.ApplyExploratoryFieldSpec(ec.NewChild("volumeMap"));
        }
    }


    #endregion

    } // class VsphereBlueprintChildSnapshotInfo
    
    #endregion

    public static class ListVsphereBlueprintChildSnapshotInfoExtensions
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
            this List<VsphereBlueprintChildSnapshotInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereBlueprintChildSnapshotInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereBlueprintChildSnapshotInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VsphereBlueprintChildSnapshotInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types