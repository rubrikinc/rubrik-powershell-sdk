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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "VolumeGroupSnapshotVolumeSummary";
    }

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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FileSystemType? FileSystemType
        // GraphQL -> fileSystemType: FileSystemType! (enum)
        if (this.FileSystemType == null && ec.Includes("fileSystemType",true))
        {
            this.FileSystemType = new FileSystemType();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> List<System.String>? MountPoints
        // GraphQL -> mountPoints: [String!]! (scalar)
        if (this.MountPoints == null && ec.Includes("mountPoints",true))
        {
            this.MountPoints = new List<System.String>();
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size == null && ec.Includes("size",true))
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VolumeGroupSnapshotVolumeSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VolumeGroupSnapshotVolumeSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VolumeGroupSnapshotVolumeSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types