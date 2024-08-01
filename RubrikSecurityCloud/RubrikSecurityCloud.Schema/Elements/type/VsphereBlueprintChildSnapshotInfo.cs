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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        if (this.MemoryMbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memoryMbs\n" ;
            } else {
                s += ind + "memoryMbs\n" ;
            }
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (this.OsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osType\n" ;
            } else {
                s += ind + "osType\n" ;
            }
        }
        //      C# -> System.String? SnapshotAppMetadata
        // GraphQL -> snapshotAppMetadata: String! (scalar)
        if (this.SnapshotAppMetadata != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotAppMetadata\n" ;
            } else {
                s += ind + "snapshotAppMetadata\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vcpus: Int! (scalar)
        if (this.Vcpus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcpus\n" ;
            } else {
                s += ind + "vcpus\n" ;
            }
        }
        //      C# -> VmHost? Host
        // GraphQL -> host: VmHost (type)
        if (this.Host != null) {
            var fspec = this.Host.AsFieldSpec(conf.Child("host"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "host" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VmNicMapEntry>? NicMap
        // GraphQL -> nicMap: [VmNicMapEntry!]! (type)
        if (this.NicMap != null) {
            var fspec = this.NicMap.AsFieldSpec(conf.Child("nicMap"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nicMap" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VmDiskMapEntry>? VolumeMap
        // GraphQL -> volumeMap: [VmDiskMapEntry!]! (type)
        if (this.VolumeMap != null) {
            var fspec = this.VolumeMap.AsFieldSpec(conf.Child("volumeMap"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumeMap" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        if (ec.Includes("memoryMbs",true))
        {
            if(this.MemoryMbs == null) {

                this.MemoryMbs = Int32.MinValue;

            } else {


            }
        }
        else if (this.MemoryMbs != null && ec.Excludes("memoryMbs",true))
        {
            this.MemoryMbs = null;
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (ec.Includes("osType",true))
        {
            if(this.OsType == null) {

                this.OsType = "FETCH";

            } else {


            }
        }
        else if (this.OsType != null && ec.Excludes("osType",true))
        {
            this.OsType = null;
        }
        //      C# -> System.String? SnapshotAppMetadata
        // GraphQL -> snapshotAppMetadata: String! (scalar)
        if (ec.Includes("snapshotAppMetadata",true))
        {
            if(this.SnapshotAppMetadata == null) {

                this.SnapshotAppMetadata = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotAppMetadata != null && ec.Excludes("snapshotAppMetadata",true))
        {
            this.SnapshotAppMetadata = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vcpus: Int! (scalar)
        if (ec.Includes("vcpus",true))
        {
            if(this.Vcpus == null) {

                this.Vcpus = Int32.MinValue;

            } else {


            }
        }
        else if (this.Vcpus != null && ec.Excludes("vcpus",true))
        {
            this.Vcpus = null;
        }
        //      C# -> VmHost? Host
        // GraphQL -> host: VmHost (type)
        if (ec.Includes("host",false))
        {
            if(this.Host == null) {

                this.Host = new VmHost();
                this.Host.ApplyExploratoryFieldSpec(ec.NewChild("host"));

            } else {

                this.Host.ApplyExploratoryFieldSpec(ec.NewChild("host"));

            }
        }
        else if (this.Host != null && ec.Excludes("host",false))
        {
            this.Host = null;
        }
        //      C# -> List<VmNicMapEntry>? NicMap
        // GraphQL -> nicMap: [VmNicMapEntry!]! (type)
        if (ec.Includes("nicMap",false))
        {
            if(this.NicMap == null) {

                this.NicMap = new List<VmNicMapEntry>();
                this.NicMap.ApplyExploratoryFieldSpec(ec.NewChild("nicMap"));

            } else {

                this.NicMap.ApplyExploratoryFieldSpec(ec.NewChild("nicMap"));

            }
        }
        else if (this.NicMap != null && ec.Excludes("nicMap",false))
        {
            this.NicMap = null;
        }
        //      C# -> List<VmDiskMapEntry>? VolumeMap
        // GraphQL -> volumeMap: [VmDiskMapEntry!]! (type)
        if (ec.Includes("volumeMap",false))
        {
            if(this.VolumeMap == null) {

                this.VolumeMap = new List<VmDiskMapEntry>();
                this.VolumeMap.ApplyExploratoryFieldSpec(ec.NewChild("volumeMap"));

            } else {

                this.VolumeMap.ApplyExploratoryFieldSpec(ec.NewChild("volumeMap"));

            }
        }
        else if (this.VolumeMap != null && ec.Excludes("volumeMap",false))
        {
            this.VolumeMap = null;
        }
    }


    #endregion

    } // class VsphereBlueprintChildSnapshotInfo
    
    #endregion

    public static class ListVsphereBlueprintChildSnapshotInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VsphereBlueprintChildSnapshotInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereBlueprintChildSnapshotInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<VsphereBlueprintChildSnapshotInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types