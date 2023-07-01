// CloudNativeFileVersion.cs
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
    #region CloudNativeFileVersion
    public class CloudNativeFileVersion: BaseType
    {
        #region members

        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        [JsonProperty("fileMode")]
        public FileModeEnum? FileMode { get; set; }

        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }

        //      C# -> CloudNativeSnapshotInfo? Snapshot
        // GraphQL -> snapshot: CloudNativeSnapshotInfo! (type)
        [JsonProperty("snapshot")]
        public CloudNativeSnapshotInfo? Snapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeFileVersion";
    }

    public CloudNativeFileVersion Set(
        FileModeEnum? FileMode = null,
        DateTime? LastModified = null,
        System.Int64? SizeInBytes = null,
        CloudNativeSnapshotInfo? Snapshot = null
    ) 
    {
        if ( FileMode != null ) {
            this.FileMode = FileMode;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
        }
        if ( Snapshot != null ) {
            this.Snapshot = Snapshot;
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
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (this.FileMode != null) {
            s += ind + "fileMode\n" ;
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (this.LastModified != null) {
            s += ind + "lastModified\n" ;
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (this.SizeInBytes != null) {
            s += ind + "sizeInBytes\n" ;
        }
        //      C# -> CloudNativeSnapshotInfo? Snapshot
        // GraphQL -> snapshot: CloudNativeSnapshotInfo! (type)
        if (this.Snapshot != null) {
            var fspec = this.Snapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (this.FileMode == null && Exploration.Includes(parent + ".fileMode", true))
        {
            this.FileMode = new FileModeEnum();
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (this.LastModified == null && Exploration.Includes(parent + ".lastModified", true))
        {
            this.LastModified = new DateTime();
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (this.SizeInBytes == null && Exploration.Includes(parent + ".sizeInBytes", true))
        {
            this.SizeInBytes = new System.Int64();
        }
        //      C# -> CloudNativeSnapshotInfo? Snapshot
        // GraphQL -> snapshot: CloudNativeSnapshotInfo! (type)
        if (this.Snapshot == null && Exploration.Includes(parent + ".snapshot"))
        {
            this.Snapshot = new CloudNativeSnapshotInfo();
            this.Snapshot.ApplyExploratoryFieldSpec(parent + ".snapshot");
        }
    }


    #endregion

    } // class CloudNativeFileVersion
    
    #endregion

    public static class ListCloudNativeFileVersionExtensions
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
            this List<CloudNativeFileVersion> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeFileVersion> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeFileVersion());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types