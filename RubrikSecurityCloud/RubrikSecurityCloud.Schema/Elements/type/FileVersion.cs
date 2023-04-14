// FileVersion.cs
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
    #region FileVersion
    public class FileVersion: IFragment
    {
        #region members
        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        [JsonProperty("fileMode")]
        public System.String? FileMode { get; set; }

        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
        [JsonProperty("lastModified")]
        public System.String? LastModified { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? Source
        // GraphQL -> source: String (scalar)
        [JsonProperty("source")]
        public System.String? Source { get; set; }

        #endregion

    #region methods

    public FileVersion Set(
        System.String? FileMode = null,
        System.String? LastModified = null,
        System.Int64? Size = null,
        System.String? SnapshotId = null,
        System.String? Source = null
    ) 
    {
        if ( FileMode != null ) {
            this.FileMode = FileMode;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( Source != null ) {
            this.Source = Source;
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
            //      C# -> System.String? FileMode
            // GraphQL -> fileMode: String (scalar)
            if (this.FileMode != null)
            {
                 s += ind + "fileMode\n";

            }
            //      C# -> System.String? LastModified
            // GraphQL -> lastModified: String (scalar)
            if (this.LastModified != null)
            {
                 s += ind + "lastModified\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> System.String? Source
            // GraphQL -> source: String (scalar)
            if (this.Source != null)
            {
                 s += ind + "source\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? FileMode
            // GraphQL -> fileMode: String (scalar)
            if (this.FileMode == null && Exploration.Includes(parent + ".fileMode$"))
            {
                this.FileMode = new System.String("FETCH");
            }
            //      C# -> System.String? LastModified
            // GraphQL -> lastModified: String (scalar)
            if (this.LastModified == null && Exploration.Includes(parent + ".lastModified$"))
            {
                this.LastModified = new System.String("FETCH");
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> System.String? Source
            // GraphQL -> source: String (scalar)
            if (this.Source == null && Exploration.Includes(parent + ".source$"))
            {
                this.Source = new System.String("FETCH");
            }
        }


    #endregion

    } // class FileVersion
    #endregion

    public static class ListFileVersionExtensions
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
            this List<FileVersion> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FileVersion> list, 
            String parent = "")
        {
            var item = new FileVersion();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types