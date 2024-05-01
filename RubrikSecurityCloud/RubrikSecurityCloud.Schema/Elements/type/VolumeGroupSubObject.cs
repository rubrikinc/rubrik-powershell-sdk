// VolumeGroupSubObject.cs
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
    #region VolumeGroupSubObject
    public class VolumeGroupSubObject: BaseType
    {
        #region members

        //      C# -> System.Int64? CapacityInBytes
        // GraphQL -> capacityInBytes: Long! (scalar)
        [JsonProperty("capacityInBytes")]
        public System.Int64? CapacityInBytes { get; set; }

        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        [JsonProperty("fileSizeInBytes")]
        public System.Int64? FileSizeInBytes { get; set; }

        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        [JsonProperty("fileSystemType")]
        public System.String? FileSystemType { get; set; }

        //      C# -> List<System.String>? MountPointsOpt
        // GraphQL -> mountPointsOpt: [String!]! (scalar)
        [JsonProperty("mountPointsOpt")]
        public List<System.String>? MountPointsOpt { get; set; }

        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        [JsonProperty("volumeId")]
        public System.String? VolumeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VolumeGroupSubObject";
    }

    public VolumeGroupSubObject Set(
        System.Int64? CapacityInBytes = null,
        System.Int64? FileSizeInBytes = null,
        System.String? FileSystemType = null,
        List<System.String>? MountPointsOpt = null,
        System.String? VolumeId = null
    ) 
    {
        if ( CapacityInBytes != null ) {
            this.CapacityInBytes = CapacityInBytes;
        }
        if ( FileSizeInBytes != null ) {
            this.FileSizeInBytes = FileSizeInBytes;
        }
        if ( FileSystemType != null ) {
            this.FileSystemType = FileSystemType;
        }
        if ( MountPointsOpt != null ) {
            this.MountPointsOpt = MountPointsOpt;
        }
        if ( VolumeId != null ) {
            this.VolumeId = VolumeId;
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
        //      C# -> System.Int64? CapacityInBytes
        // GraphQL -> capacityInBytes: Long! (scalar)
        if (this.CapacityInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capacityInBytes\n" ;
            } else {
                s += ind + "capacityInBytes\n" ;
            }
        }
        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        if (this.FileSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSizeInBytes\n" ;
            } else {
                s += ind + "fileSizeInBytes\n" ;
            }
        }
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        if (this.FileSystemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSystemType\n" ;
            } else {
                s += ind + "fileSystemType\n" ;
            }
        }
        //      C# -> List<System.String>? MountPointsOpt
        // GraphQL -> mountPointsOpt: [String!]! (scalar)
        if (this.MountPointsOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountPointsOpt\n" ;
            } else {
                s += ind + "mountPointsOpt\n" ;
            }
        }
        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        if (this.VolumeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeId\n" ;
            } else {
                s += ind + "volumeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? CapacityInBytes
        // GraphQL -> capacityInBytes: Long! (scalar)
        if (ec.Includes("capacityInBytes",true))
        {
            if(this.CapacityInBytes == null) {

                this.CapacityInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.CapacityInBytes != null && ec.Excludes("capacityInBytes",true))
        {
            this.CapacityInBytes = null;
        }
        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        if (ec.Includes("fileSizeInBytes",true))
        {
            if(this.FileSizeInBytes == null) {

                this.FileSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.FileSizeInBytes != null && ec.Excludes("fileSizeInBytes",true))
        {
            this.FileSizeInBytes = null;
        }
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        if (ec.Includes("fileSystemType",true))
        {
            if(this.FileSystemType == null) {

                this.FileSystemType = "FETCH";

            } else {


            }
        }
        else if (this.FileSystemType != null && ec.Excludes("fileSystemType",true))
        {
            this.FileSystemType = null;
        }
        //      C# -> List<System.String>? MountPointsOpt
        // GraphQL -> mountPointsOpt: [String!]! (scalar)
        if (ec.Includes("mountPointsOpt",true))
        {
            if(this.MountPointsOpt == null) {

                this.MountPointsOpt = new List<System.String>();

            } else {


            }
        }
        else if (this.MountPointsOpt != null && ec.Excludes("mountPointsOpt",true))
        {
            this.MountPointsOpt = null;
        }
        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        if (ec.Includes("volumeId",true))
        {
            if(this.VolumeId == null) {

                this.VolumeId = "FETCH";

            } else {


            }
        }
        else if (this.VolumeId != null && ec.Excludes("volumeId",true))
        {
            this.VolumeId = null;
        }
    }


    #endregion

    } // class VolumeGroupSubObject
    
    #endregion

    public static class ListVolumeGroupSubObjectExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VolumeGroupSubObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VolumeGroupSubObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VolumeGroupSubObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VolumeGroupSubObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VolumeGroupSubObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types