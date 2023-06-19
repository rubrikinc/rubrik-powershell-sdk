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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? CapacityInBytes
        // GraphQL -> capacityInBytes: Long! (scalar)
        if (this.CapacityInBytes != null) {
            s += ind + "capacityInBytes\n" ;
        }
        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        if (this.FileSizeInBytes != null) {
            s += ind + "fileSizeInBytes\n" ;
        }
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        if (this.FileSystemType != null) {
            s += ind + "fileSystemType\n" ;
        }
        //      C# -> List<System.String>? MountPointsOpt
        // GraphQL -> mountPointsOpt: [String!]! (scalar)
        if (this.MountPointsOpt != null) {
            s += ind + "mountPointsOpt\n" ;
        }
        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        if (this.VolumeId != null) {
            s += ind + "volumeId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? CapacityInBytes
        // GraphQL -> capacityInBytes: Long! (scalar)
        if (this.CapacityInBytes == null && Exploration.Includes(parent + ".capacityInBytes", true))
        {
            this.CapacityInBytes = new System.Int64();
        }
        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        if (this.FileSizeInBytes == null && Exploration.Includes(parent + ".fileSizeInBytes", true))
        {
            this.FileSizeInBytes = new System.Int64();
        }
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        if (this.FileSystemType == null && Exploration.Includes(parent + ".fileSystemType", true))
        {
            this.FileSystemType = "FETCH";
        }
        //      C# -> List<System.String>? MountPointsOpt
        // GraphQL -> mountPointsOpt: [String!]! (scalar)
        if (this.MountPointsOpt == null && Exploration.Includes(parent + ".mountPointsOpt", true))
        {
            this.MountPointsOpt = new List<System.String>();
        }
        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        if (this.VolumeId == null && Exploration.Includes(parent + ".volumeId", true))
        {
            this.VolumeId = "FETCH";
        }
    }


    #endregion

    } // class VolumeGroupSubObject
    
    #endregion

    public static class ListVolumeGroupSubObjectExtensions
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
            this List<VolumeGroupSubObject> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VolumeGroupSubObject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VolumeGroupSubObject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types