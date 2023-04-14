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

namespace Rubrik.SecurityCloud.Types
{
    #region VolumeGroupSubObject
    public class VolumeGroupSubObject: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int64? CapacityInBytes
            // GraphQL -> capacityInBytes: Long! (scalar)
            if (this.CapacityInBytes != null)
            {
                 s += ind + "capacityInBytes\n";

            }
            //      C# -> System.Int64? FileSizeInBytes
            // GraphQL -> fileSizeInBytes: Long! (scalar)
            if (this.FileSizeInBytes != null)
            {
                 s += ind + "fileSizeInBytes\n";

            }
            //      C# -> System.String? FileSystemType
            // GraphQL -> fileSystemType: String! (scalar)
            if (this.FileSystemType != null)
            {
                 s += ind + "fileSystemType\n";

            }
            //      C# -> List<System.String>? MountPointsOpt
            // GraphQL -> mountPointsOpt: [String!]! (scalar)
            if (this.MountPointsOpt != null)
            {
                 s += ind + "mountPointsOpt\n";

            }
            //      C# -> System.String? VolumeId
            // GraphQL -> volumeId: String! (scalar)
            if (this.VolumeId != null)
            {
                 s += ind + "volumeId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? CapacityInBytes
            // GraphQL -> capacityInBytes: Long! (scalar)
            if (this.CapacityInBytes == null && Exploration.Includes(parent + ".capacityInBytes$"))
            {
                this.CapacityInBytes = new System.Int64();
            }
            //      C# -> System.Int64? FileSizeInBytes
            // GraphQL -> fileSizeInBytes: Long! (scalar)
            if (this.FileSizeInBytes == null && Exploration.Includes(parent + ".fileSizeInBytes$"))
            {
                this.FileSizeInBytes = new System.Int64();
            }
            //      C# -> System.String? FileSystemType
            // GraphQL -> fileSystemType: String! (scalar)
            if (this.FileSystemType == null && Exploration.Includes(parent + ".fileSystemType$"))
            {
                this.FileSystemType = new System.String("FETCH");
            }
            //      C# -> List<System.String>? MountPointsOpt
            // GraphQL -> mountPointsOpt: [String!]! (scalar)
            if (this.MountPointsOpt == null && Exploration.Includes(parent + ".mountPointsOpt$"))
            {
                this.MountPointsOpt = new List<System.String>();
            }
            //      C# -> System.String? VolumeId
            // GraphQL -> volumeId: String! (scalar)
            if (this.VolumeId == null && Exploration.Includes(parent + ".volumeId$"))
            {
                this.VolumeId = new System.String("FETCH");
            }
        }


    #endregion

    } // class VolumeGroupSubObject
    #endregion

    public static class ListVolumeGroupSubObjectExtensions
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
            this List<VolumeGroupSubObject> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VolumeGroupSubObject> list, 
            String parent = "")
        {
            var item = new VolumeGroupSubObject();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types