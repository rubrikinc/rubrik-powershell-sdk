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

namespace Rubrik.SecurityCloud.Types
{
    #region CloudNativeFileVersion
    public class CloudNativeFileVersion: IFragment
    {
        #region members
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

        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        [JsonProperty("fileMode")]
        public FileModeEnum? FileMode { get; set; }

        #endregion

    #region methods

    public CloudNativeFileVersion Set(
        DateTime? LastModified = null,
        System.Int64? SizeInBytes = null,
        CloudNativeSnapshotInfo? Snapshot = null,
        FileModeEnum? FileMode = null
    ) 
    {
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
        }
        if ( Snapshot != null ) {
            this.Snapshot = Snapshot;
        }
        if ( FileMode != null ) {
            this.FileMode = FileMode;
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
            //      C# -> DateTime? LastModified
            // GraphQL -> lastModified: DateTime! (scalar)
            if (this.LastModified != null)
            {
                 s += ind + "lastModified\n";

            }
            //      C# -> System.Int64? SizeInBytes
            // GraphQL -> sizeInBytes: Long! (scalar)
            if (this.SizeInBytes != null)
            {
                 s += ind + "sizeInBytes\n";

            }
            //      C# -> CloudNativeSnapshotInfo? Snapshot
            // GraphQL -> snapshot: CloudNativeSnapshotInfo! (type)
            if (this.Snapshot != null)
            {
                 s += ind + "snapshot\n";

                 s += ind + "{\n" + 
                 this.Snapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FileModeEnum? FileMode
            // GraphQL -> fileMode: FileModeEnum! (enum)
            if (this.FileMode != null)
            {
                 s += ind + "fileMode\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? LastModified
            // GraphQL -> lastModified: DateTime! (scalar)
            if (this.LastModified == null && Exploration.Includes(parent + ".lastModified$"))
            {
                this.LastModified = new DateTime();
            }
            //      C# -> System.Int64? SizeInBytes
            // GraphQL -> sizeInBytes: Long! (scalar)
            if (this.SizeInBytes == null && Exploration.Includes(parent + ".sizeInBytes$"))
            {
                this.SizeInBytes = new System.Int64();
            }
            //      C# -> CloudNativeSnapshotInfo? Snapshot
            // GraphQL -> snapshot: CloudNativeSnapshotInfo! (type)
            if (this.Snapshot == null && Exploration.Includes(parent + ".snapshot"))
            {
                this.Snapshot = new CloudNativeSnapshotInfo();
                this.Snapshot.ApplyExploratoryFragment(parent + ".snapshot");
            }
            //      C# -> FileModeEnum? FileMode
            // GraphQL -> fileMode: FileModeEnum! (enum)
            if (this.FileMode == null && Exploration.Includes(parent + ".fileMode$"))
            {
                this.FileMode = new FileModeEnum();
            }
        }


    #endregion

    } // class CloudNativeFileVersion
    #endregion

    public static class ListCloudNativeFileVersionExtensions
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
            this List<CloudNativeFileVersion> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CloudNativeFileVersion> list, 
            String parent = "")
        {
            var item = new CloudNativeFileVersion();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types