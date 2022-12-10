// GlobalSearchFile.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:34.
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
    #region GlobalSearchFile
    public class GlobalSearchFile: IFragment
    {
        #region members
        //      C# -> List<System.String>? Dirs
        // GraphQL -> dirs: [String!]! (scalar)
        [JsonProperty("dirs")]
        public List<System.String>? Dirs { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.Boolean? IsFile
        // GraphQL -> isFile: Boolean! (scalar)
        [JsonProperty("isFile")]
        public System.Boolean? IsFile { get; set; }

        //      C# -> System.Int64? ModifiedTime
        // GraphQL -> modifiedTime: Long (scalar)
        [JsonProperty("modifiedTime")]
        public System.Int64? ModifiedTime { get; set; }

        //      C# -> System.Int32? NumSnapshots
        // GraphQL -> numSnapshots: Int (scalar)
        [JsonProperty("numSnapshots")]
        public System.Int32? NumSnapshots { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        [JsonProperty("snappableName")]
        public System.String? SnappableName { get; set; }

        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long (scalar)
        [JsonProperty("snapshotTime")]
        public System.Int64? SnapshotTime { get; set; }

        #endregion

    #region methods

    public GlobalSearchFile Set(
        List<System.String>? Dirs = null,
        System.String? Filename = null,
        System.Boolean? IsFile = null,
        System.Int64? ModifiedTime = null,
        System.Int32? NumSnapshots = null,
        System.Int64? SizeInBytes = null,
        System.String? SnappableId = null,
        System.String? SnappableName = null,
        System.Int64? SnapshotTime = null
    ) 
    {
        if ( Dirs != null ) {
            this.Dirs = Dirs;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( IsFile != null ) {
            this.IsFile = IsFile;
        }
        if ( ModifiedTime != null ) {
            this.ModifiedTime = ModifiedTime;
        }
        if ( NumSnapshots != null ) {
            this.NumSnapshots = NumSnapshots;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( SnappableName != null ) {
            this.SnappableName = SnappableName;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
            //      C# -> List<System.String>? Dirs
            // GraphQL -> dirs: [String!]! (scalar)
            if (this.Dirs != null)
            {
                 s += ind + "dirs\n";

            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String! (scalar)
            if (this.Filename != null)
            {
                 s += ind + "filename\n";

            }
            //      C# -> System.Boolean? IsFile
            // GraphQL -> isFile: Boolean! (scalar)
            if (this.IsFile != null)
            {
                 s += ind + "isFile\n";

            }
            //      C# -> System.Int64? ModifiedTime
            // GraphQL -> modifiedTime: Long (scalar)
            if (this.ModifiedTime != null)
            {
                 s += ind + "modifiedTime\n";

            }
            //      C# -> System.Int32? NumSnapshots
            // GraphQL -> numSnapshots: Int (scalar)
            if (this.NumSnapshots != null)
            {
                 s += ind + "numSnapshots\n";

            }
            //      C# -> System.Int64? SizeInBytes
            // GraphQL -> sizeInBytes: Long (scalar)
            if (this.SizeInBytes != null)
            {
                 s += ind + "sizeInBytes\n";

            }
            //      C# -> System.String? SnappableId
            // GraphQL -> snappableId: String! (scalar)
            if (this.SnappableId != null)
            {
                 s += ind + "snappableId\n";

            }
            //      C# -> System.String? SnappableName
            // GraphQL -> snappableName: String! (scalar)
            if (this.SnappableName != null)
            {
                 s += ind + "snappableName\n";

            }
            //      C# -> System.Int64? SnapshotTime
            // GraphQL -> snapshotTime: Long (scalar)
            if (this.SnapshotTime != null)
            {
                 s += ind + "snapshotTime\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? Dirs
            // GraphQL -> dirs: [String!]! (scalar)
            if (this.Dirs == null && Exploration.Includes(parent + ".dirs$"))
            {
                this.Dirs = new List<System.String>();
            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String! (scalar)
            if (this.Filename == null && Exploration.Includes(parent + ".filename$"))
            {
                this.Filename = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsFile
            // GraphQL -> isFile: Boolean! (scalar)
            if (this.IsFile == null && Exploration.Includes(parent + ".isFile$"))
            {
                this.IsFile = new System.Boolean();
            }
            //      C# -> System.Int64? ModifiedTime
            // GraphQL -> modifiedTime: Long (scalar)
            if (this.ModifiedTime == null && Exploration.Includes(parent + ".modifiedTime$"))
            {
                this.ModifiedTime = new System.Int64();
            }
            //      C# -> System.Int32? NumSnapshots
            // GraphQL -> numSnapshots: Int (scalar)
            if (this.NumSnapshots == null && Exploration.Includes(parent + ".numSnapshots$"))
            {
                this.NumSnapshots = new System.Int32();
            }
            //      C# -> System.Int64? SizeInBytes
            // GraphQL -> sizeInBytes: Long (scalar)
            if (this.SizeInBytes == null && Exploration.Includes(parent + ".sizeInBytes$"))
            {
                this.SizeInBytes = new System.Int64();
            }
            //      C# -> System.String? SnappableId
            // GraphQL -> snappableId: String! (scalar)
            if (this.SnappableId == null && Exploration.Includes(parent + ".snappableId$"))
            {
                this.SnappableId = new System.String("FETCH");
            }
            //      C# -> System.String? SnappableName
            // GraphQL -> snappableName: String! (scalar)
            if (this.SnappableName == null && Exploration.Includes(parent + ".snappableName$"))
            {
                this.SnappableName = new System.String("FETCH");
            }
            //      C# -> System.Int64? SnapshotTime
            // GraphQL -> snapshotTime: Long (scalar)
            if (this.SnapshotTime == null && Exploration.Includes(parent + ".snapshotTime$"))
            {
                this.SnapshotTime = new System.Int64();
            }
        }


    #endregion

    } // class GlobalSearchFile
    #endregion

    public static class ListGlobalSearchFileExtensions
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
            this List<GlobalSearchFile> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GlobalSearchFile> list, 
            String parent = "")
        {
            var item = new GlobalSearchFile();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types