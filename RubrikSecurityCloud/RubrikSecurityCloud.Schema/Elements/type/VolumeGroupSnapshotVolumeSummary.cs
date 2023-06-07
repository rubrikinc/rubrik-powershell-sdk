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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region VolumeGroupSnapshotVolumeSummary
    public class VolumeGroupSnapshotVolumeSummary: BaseType
    {
        #region members

        //      C# -> FileSystemType? FileSystemType
        // GraphQL -> fileSystemType: FileSystemType! (enum)
        [JsonProperty("fileSystemType")]
        public FileSystemType? FileSystemType { get; set; }

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


        #endregion

    #region methods

    public VolumeGroupSnapshotVolumeSummary Set(
        FileSystemType? FileSystemType = null,
        System.String? Id = null,
        List<System.String>? MountPoints = null,
        System.Int64? Size = null
    ) 
    {
        if ( FileSystemType != null ) {
            this.FileSystemType = FileSystemType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( MountPoints != null ) {
            this.MountPoints = MountPoints;
        }
        if ( Size != null ) {
            this.Size = Size;
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
        //      C# -> FileSystemType? FileSystemType
        // GraphQL -> fileSystemType: FileSystemType! (enum)
        if (this.FileSystemType != null) {
            s += ind + "fileSystemType\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> List<System.String>? MountPoints
        // GraphQL -> mountPoints: [String!]! (scalar)
        if (this.MountPoints != null) {
            s += ind + "mountPoints\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FileSystemType? FileSystemType
        // GraphQL -> fileSystemType: FileSystemType! (enum)
        if (this.FileSystemType == null && Exploration.Includes(parent + ".fileSystemType", true))
        {
            this.FileSystemType = new FileSystemType();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> List<System.String>? MountPoints
        // GraphQL -> mountPoints: [String!]! (scalar)
        if (this.MountPoints == null && Exploration.Includes(parent + ".mountPoints", true))
        {
            this.MountPoints = new List<System.String>();
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
    }


    #endregion

    } // class VolumeGroupSnapshotVolumeSummary
    
    #endregion

    public static class ListVolumeGroupSnapshotVolumeSummaryExtensions
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
            this List<VolumeGroupSnapshotVolumeSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VolumeGroupSnapshotVolumeSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VolumeGroupSnapshotVolumeSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types