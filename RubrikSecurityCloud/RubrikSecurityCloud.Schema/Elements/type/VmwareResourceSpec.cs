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
 
    public class VmwareResourceSpec: BaseType, RecoveryPlanChildResourceSpec, ResourceSpec
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
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
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (this.RecoveryPointOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPointOpt\n" ;
            } else {
                s += ind + "recoveryPointOpt\n" ;
            }
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableId\n" ;
            } else {
                s += ind + "snappableId\n" ;
            }
        }
        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        if (this.SnappableName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableName\n" ;
            } else {
                s += ind + "snappableName\n" ;
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
        // GraphQL -> vCpus: Int! (scalar)
        if (this.Vcpus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vCpus\n" ;
            } else {
                s += ind + "vCpus\n" ;
            }
        }
        //      C# -> List<VmwareVirtualMachineVolume>? VmWareVolumeSpecs
        // GraphQL -> vmWareVolumeSpecs: [VmwareVirtualMachineVolume!]! (type)
        if (this.VmWareVolumeSpecs != null) {
            var fspec = this.VmWareVolumeSpecs.AsFieldSpec(conf.Child("vmWareVolumeSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmWareVolumeSpecs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VmwareVirtualMachineNic>? VmwareNics
        // GraphQL -> vmwareNics: [VmwareVirtualMachineNic!]! (type)
        if (this.VmwareNics != null) {
            var fspec = this.VmwareNics.AsFieldSpec(conf.Child("vmwareNics"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareNics" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
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
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (ec.Includes("recoveryPointOpt",true))
        {
            if(this.RecoveryPointOpt == null) {

                this.RecoveryPointOpt = new System.Int64();

            } else {


            }
        }
        else if (this.RecoveryPointOpt != null && ec.Excludes("recoveryPointOpt",true))
        {
            this.RecoveryPointOpt = null;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (ec.Includes("snappableId",true))
        {
            if(this.SnappableId == null) {

                this.SnappableId = "FETCH";

            } else {


            }
        }
        else if (this.SnappableId != null && ec.Excludes("snappableId",true))
        {
            this.SnappableId = null;
        }
        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        if (ec.Includes("snappableName",true))
        {
            if(this.SnappableName == null) {

                this.SnappableName = "FETCH";

            } else {


            }
        }
        else if (this.SnappableName != null && ec.Excludes("snappableName",true))
        {
            this.SnappableName = null;
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
        // GraphQL -> vCpus: Int! (scalar)
        if (ec.Includes("vCpus",true))
        {
            if(this.Vcpus == null) {

                this.Vcpus = Int32.MinValue;

            } else {


            }
        }
        else if (this.Vcpus != null && ec.Excludes("vCpus",true))
        {
            this.Vcpus = null;
        }
        //      C# -> List<VmwareVirtualMachineVolume>? VmWareVolumeSpecs
        // GraphQL -> vmWareVolumeSpecs: [VmwareVirtualMachineVolume!]! (type)
        if (ec.Includes("vmWareVolumeSpecs",false))
        {
            if(this.VmWareVolumeSpecs == null) {

                this.VmWareVolumeSpecs = new List<VmwareVirtualMachineVolume>();
                this.VmWareVolumeSpecs.ApplyExploratoryFieldSpec(ec.NewChild("vmWareVolumeSpecs"));

            } else {

                this.VmWareVolumeSpecs.ApplyExploratoryFieldSpec(ec.NewChild("vmWareVolumeSpecs"));

            }
        }
        else if (this.VmWareVolumeSpecs != null && ec.Excludes("vmWareVolumeSpecs",false))
        {
            this.VmWareVolumeSpecs = null;
        }
        //      C# -> List<VmwareVirtualMachineNic>? VmwareNics
        // GraphQL -> vmwareNics: [VmwareVirtualMachineNic!]! (type)
        if (ec.Includes("vmwareNics",false))
        {
            if(this.VmwareNics == null) {

                this.VmwareNics = new List<VmwareVirtualMachineNic>();
                this.VmwareNics.ApplyExploratoryFieldSpec(ec.NewChild("vmwareNics"));

            } else {

                this.VmwareNics.ApplyExploratoryFieldSpec(ec.NewChild("vmwareNics"));

            }
        }
        else if (this.VmwareNics != null && ec.Excludes("vmwareNics",false))
        {
            this.VmwareNics = null;
        }
    }


    #endregion

    } // class VmwareResourceSpec
    
    #endregion

    public static class ListVmwareResourceSpecExtensions
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
            this List<VmwareResourceSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareResourceSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareResourceSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareResourceSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareResourceSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types