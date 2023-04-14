// VolumeGroupSnapshotVolumeSummary.cs
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
    #region VolumeGroupSnapshotVolumeSummary
    public class VolumeGroupSnapshotVolumeSummary: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? MountPoints
        // GraphQL -> mountPoints: [String!]! (scalar)
        [JsonProperty("mountPoints")]
        public List<System.String>? MountPoints { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> FileSystemType? FileSystemType
        // GraphQL -> fileSystemType: FileSystemType! (enum)
        [JsonProperty("fileSystemType")]
        public FileSystemType? FileSystemType { get; set; }

        #endregion

    #region methods

    public VolumeGroupSnapshotVolumeSummary Set(
        System.String? Id = null,
        List<System.String>? MountPoints = null,
        System.Int64? Size = null,
        FileSystemType? FileSystemType = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( MountPoints != null ) {
            this.MountPoints = MountPoints;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( FileSystemType != null ) {
            this.FileSystemType = FileSystemType;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> List<System.String>? MountPoints
            // GraphQL -> mountPoints: [String!]! (scalar)
            if (this.MountPoints != null)
            {
                 s += ind + "mountPoints\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> FileSystemType? FileSystemType
            // GraphQL -> fileSystemType: FileSystemType! (enum)
            if (this.FileSystemType != null)
            {
                 s += ind + "fileSystemType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> List<System.String>? MountPoints
            // GraphQL -> mountPoints: [String!]! (scalar)
            if (this.MountPoints == null && Exploration.Includes(parent + ".mountPoints$"))
            {
                this.MountPoints = new List<System.String>();
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> FileSystemType? FileSystemType
            // GraphQL -> fileSystemType: FileSystemType! (enum)
            if (this.FileSystemType == null && Exploration.Includes(parent + ".fileSystemType$"))
            {
                this.FileSystemType = new FileSystemType();
            }
        }


    #endregion

    } // class VolumeGroupSnapshotVolumeSummary
    #endregion

    public static class ListVolumeGroupSnapshotVolumeSummaryExtensions
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
            this List<VolumeGroupSnapshotVolumeSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VolumeGroupSnapshotVolumeSummary> list, 
            String parent = "")
        {
            var item = new VolumeGroupSnapshotVolumeSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types