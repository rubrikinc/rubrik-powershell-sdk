// HierarchySnappableFileVersion.cs
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
    #region HierarchySnappableFileVersion
    public class HierarchySnappableFileVersion: IFragment
    {
        #region members
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        [JsonProperty("quarantineInfo")]
        public QuarantineInfo? QuarantineInfo { get; set; }

        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        [JsonProperty("snapshot")]
        public CdmSnapshot? Snapshot { get; set; }

        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        [JsonProperty("fileMode")]
        public FileModeEnum? FileMode { get; set; }

        //      C# -> FileVersionSourceEnum? Source
        // GraphQL -> source: FileVersionSourceEnum! (enum)
        [JsonProperty("source")]
        public FileVersionSourceEnum? Source { get; set; }

        #endregion

    #region methods

    public HierarchySnappableFileVersion Set(
        DateTime? LastModified = null,
        System.Int64? Size = null,
        System.String? SnapshotId = null,
        QuarantineInfo? QuarantineInfo = null,
        CdmSnapshot? Snapshot = null,
        FileModeEnum? FileMode = null,
        FileVersionSourceEnum? Source = null
    ) 
    {
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( QuarantineInfo != null ) {
            this.QuarantineInfo = QuarantineInfo;
        }
        if ( Snapshot != null ) {
            this.Snapshot = Snapshot;
        }
        if ( FileMode != null ) {
            this.FileMode = FileMode;
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
            //      C# -> DateTime? LastModified
            // GraphQL -> lastModified: DateTime! (scalar)
            if (this.LastModified != null)
            {
                 s += ind + "lastModified\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> QuarantineInfo? QuarantineInfo
            // GraphQL -> quarantineInfo: QuarantineInfo (type)
            if (this.QuarantineInfo != null)
            {
                 s += ind + "quarantineInfo\n";

                 s += ind + "{\n" + 
                 this.QuarantineInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? Snapshot
            // GraphQL -> snapshot: CdmSnapshot (type)
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
            //      C# -> FileVersionSourceEnum? Source
            // GraphQL -> source: FileVersionSourceEnum! (enum)
            if (this.Source != null)
            {
                 s += ind + "source\n";

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
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> QuarantineInfo? QuarantineInfo
            // GraphQL -> quarantineInfo: QuarantineInfo (type)
            if (this.QuarantineInfo == null && Exploration.Includes(parent + ".quarantineInfo"))
            {
                this.QuarantineInfo = new QuarantineInfo();
                this.QuarantineInfo.ApplyExploratoryFragment(parent + ".quarantineInfo");
            }
            //      C# -> CdmSnapshot? Snapshot
            // GraphQL -> snapshot: CdmSnapshot (type)
            if (this.Snapshot == null && Exploration.Includes(parent + ".snapshot"))
            {
                this.Snapshot = new CdmSnapshot();
                this.Snapshot.ApplyExploratoryFragment(parent + ".snapshot");
            }
            //      C# -> FileModeEnum? FileMode
            // GraphQL -> fileMode: FileModeEnum! (enum)
            if (this.FileMode == null && Exploration.Includes(parent + ".fileMode$"))
            {
                this.FileMode = new FileModeEnum();
            }
            //      C# -> FileVersionSourceEnum? Source
            // GraphQL -> source: FileVersionSourceEnum! (enum)
            if (this.Source == null && Exploration.Includes(parent + ".source$"))
            {
                this.Source = new FileVersionSourceEnum();
            }
        }


    #endregion

    } // class HierarchySnappableFileVersion
    #endregion

    public static class ListHierarchySnappableFileVersionExtensions
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
            this List<HierarchySnappableFileVersion> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HierarchySnappableFileVersion> list, 
            String parent = "")
        {
            var item = new HierarchySnappableFileVersion();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types