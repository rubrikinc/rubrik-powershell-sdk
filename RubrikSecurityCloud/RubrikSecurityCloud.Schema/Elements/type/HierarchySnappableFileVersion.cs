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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region HierarchySnappableFileVersion
    public class HierarchySnappableFileVersion: BaseType
    {
        #region members

        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        [JsonProperty("fileMode")]
        public FileModeEnum? FileMode { get; set; }

        //      C# -> FileVersionSourceEnum? Source
        // GraphQL -> source: FileVersionSourceEnum! (enum)
        [JsonProperty("source")]
        public FileVersionSourceEnum? Source { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HierarchySnappableFileVersion";
    }

    public HierarchySnappableFileVersion Set(
        FileModeEnum? FileMode = null,
        FileVersionSourceEnum? Source = null,
        DateTime? LastModified = null,
        System.Int64? Size = null,
        System.String? SnapshotId = null,
        QuarantineInfo? QuarantineInfo = null,
        CdmSnapshot? Snapshot = null
    ) 
    {
        if ( FileMode != null ) {
            this.FileMode = FileMode;
        }
        if ( Source != null ) {
            this.Source = Source;
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
        if ( QuarantineInfo != null ) {
            this.QuarantineInfo = QuarantineInfo;
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
        //      C# -> FileVersionSourceEnum? Source
        // GraphQL -> source: FileVersionSourceEnum! (enum)
        if (this.Source != null) {
            s += ind + "source\n" ;
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (this.LastModified != null) {
            s += ind + "lastModified\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        if (this.QuarantineInfo != null) {
            var fspec = this.QuarantineInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "quarantineInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        if (this.Snapshot != null) {
            var fspec = this.Snapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (this.FileMode == null && ec.Includes("fileMode",true))
        {
            this.FileMode = new FileModeEnum();
        }
        //      C# -> FileVersionSourceEnum? Source
        // GraphQL -> source: FileVersionSourceEnum! (enum)
        if (this.Source == null && ec.Includes("source",true))
        {
            this.Source = new FileVersionSourceEnum();
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (this.LastModified == null && ec.Includes("lastModified",true))
        {
            this.LastModified = new DateTime();
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size == null && ec.Includes("size",true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && ec.Includes("snapshotId",true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        if (this.QuarantineInfo == null && ec.Includes("quarantineInfo",false))
        {
            this.QuarantineInfo = new QuarantineInfo();
            this.QuarantineInfo.ApplyExploratoryFieldSpec(ec.NewChild("quarantineInfo"));
        }
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        if (this.Snapshot == null && ec.Includes("snapshot",false))
        {
            this.Snapshot = new CdmSnapshot();
            this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));
        }
    }


    #endregion

    } // class HierarchySnappableFileVersion
    
    #endregion

    public static class ListHierarchySnappableFileVersionExtensions
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
            this List<HierarchySnappableFileVersion> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HierarchySnappableFileVersion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HierarchySnappableFileVersion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<HierarchySnappableFileVersion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types