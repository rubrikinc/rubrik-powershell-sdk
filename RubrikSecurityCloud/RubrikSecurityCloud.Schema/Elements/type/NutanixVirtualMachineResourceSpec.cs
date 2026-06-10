// NutanixVirtualMachineResourceSpec.cs
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
    #region NutanixVirtualMachineResourceSpec
    public class NutanixVirtualMachineResourceSpec: BaseType
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

        //      C# -> System.Int32? NumCpus
        // GraphQL -> numCpus: Int! (scalar)
        [JsonProperty("numCpus")]
        public System.Int32? NumCpus { get; set; }

        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        [JsonProperty("osType")]
        public System.String? OsType { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        [JsonProperty("workloadName")]
        public System.String? WorkloadName { get; set; }

        //      C# -> List<NutanixVirtualMachineNic>? NetworkInterfaces
        // GraphQL -> networkInterfaces: [NutanixVirtualMachineNic!]! (type)
        [JsonProperty("networkInterfaces")]
        public List<NutanixVirtualMachineNic>? NetworkInterfaces { get; set; }

        //      C# -> List<NutanixVirtualMachineVolume>? StorageVolumes
        // GraphQL -> storageVolumes: [NutanixVirtualMachineVolume!]! (type)
        [JsonProperty("storageVolumes")]
        public List<NutanixVirtualMachineVolume>? StorageVolumes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVirtualMachineResourceSpec";
    }

    public NutanixVirtualMachineResourceSpec Set(
        System.Boolean? IsArchived = null,
        System.Int32? MemoryMbs = null,
        System.Int32? NumCpus = null,
        System.String? OsType = null,
        System.String? SnapshotId = null,
        System.String? WorkloadId = null,
        System.String? WorkloadName = null,
        List<NutanixVirtualMachineNic>? NetworkInterfaces = null,
        List<NutanixVirtualMachineVolume>? StorageVolumes = null
    ) 
    {
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( MemoryMbs != null ) {
            this.MemoryMbs = MemoryMbs;
        }
        if ( NumCpus != null ) {
            this.NumCpus = NumCpus;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadName != null ) {
            this.WorkloadName = WorkloadName;
        }
        if ( NetworkInterfaces != null ) {
            this.NetworkInterfaces = NetworkInterfaces;
        }
        if ( StorageVolumes != null ) {
            this.StorageVolumes = StorageVolumes;
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
        //      C# -> System.Int32? NumCpus
        // GraphQL -> numCpus: Int! (scalar)
        if (this.NumCpus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numCpus\n" ;
            } else {
                s += ind + "numCpus\n" ;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (this.WorkloadName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadName\n" ;
            } else {
                s += ind + "workloadName\n" ;
            }
        }
        //      C# -> List<NutanixVirtualMachineNic>? NetworkInterfaces
        // GraphQL -> networkInterfaces: [NutanixVirtualMachineNic!]! (type)
        if (this.NetworkInterfaces != null) {
            var fspec = this.NetworkInterfaces.AsFieldSpec(conf.Child("networkInterfaces"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkInterfaces" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<NutanixVirtualMachineVolume>? StorageVolumes
        // GraphQL -> storageVolumes: [NutanixVirtualMachineVolume!]! (type)
        if (this.StorageVolumes != null) {
            var fspec = this.StorageVolumes.AsFieldSpec(conf.Child("storageVolumes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "storageVolumes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> System.Int32? NumCpus
        // GraphQL -> numCpus: Int! (scalar)
        if (ec.Includes("numCpus",true))
        {
            if(this.NumCpus == null) {

                this.NumCpus = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumCpus != null && ec.Excludes("numCpus",true))
        {
            this.NumCpus = null;
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
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (ec.Includes("workloadName",true))
        {
            if(this.WorkloadName == null) {

                this.WorkloadName = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadName != null && ec.Excludes("workloadName",true))
        {
            this.WorkloadName = null;
        }
        //      C# -> List<NutanixVirtualMachineNic>? NetworkInterfaces
        // GraphQL -> networkInterfaces: [NutanixVirtualMachineNic!]! (type)
        if (ec.Includes("networkInterfaces",false))
        {
            if(this.NetworkInterfaces == null) {

                this.NetworkInterfaces = new List<NutanixVirtualMachineNic>();
                this.NetworkInterfaces.ApplyExploratoryFieldSpec(ec.NewChild("networkInterfaces"));

            } else {

                this.NetworkInterfaces.ApplyExploratoryFieldSpec(ec.NewChild("networkInterfaces"));

            }
        }
        else if (this.NetworkInterfaces != null && ec.Excludes("networkInterfaces",false))
        {
            this.NetworkInterfaces = null;
        }
        //      C# -> List<NutanixVirtualMachineVolume>? StorageVolumes
        // GraphQL -> storageVolumes: [NutanixVirtualMachineVolume!]! (type)
        if (ec.Includes("storageVolumes",false))
        {
            if(this.StorageVolumes == null) {

                this.StorageVolumes = new List<NutanixVirtualMachineVolume>();
                this.StorageVolumes.ApplyExploratoryFieldSpec(ec.NewChild("storageVolumes"));

            } else {

                this.StorageVolumes.ApplyExploratoryFieldSpec(ec.NewChild("storageVolumes"));

            }
        }
        else if (this.StorageVolumes != null && ec.Excludes("storageVolumes",false))
        {
            this.StorageVolumes = null;
        }
    }


    #endregion

    } // class NutanixVirtualMachineResourceSpec
    
    #endregion

    public static class ListNutanixVirtualMachineResourceSpecExtensions
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
            this List<NutanixVirtualMachineResourceSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixVirtualMachineResourceSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVirtualMachineResourceSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVirtualMachineResourceSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVirtualMachineResourceSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types