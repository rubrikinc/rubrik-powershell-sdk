// VappFileVersion.cs
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
    #region VappFileVersion
    public class VappFileVersion: BaseType
    {
        #region members

        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        [JsonProperty("fileMode")]
        public FileModeEnum? FileMode { get; set; }

        //      C# -> VappFileVersionSource? Source
        // GraphQL -> source: VappFileVersionSource! (enum)
        [JsonProperty("source")]
        public VappFileVersionSource? Source { get; set; }

        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
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
        return "VappFileVersion";
    }

    public VappFileVersion Set(
        FileModeEnum? FileMode = null,
        VappFileVersionSource? Source = null,
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
        //      C# -> VappFileVersionSource? Source
        // GraphQL -> source: VappFileVersionSource! (enum)
        if (this.Source != null) {
            s += ind + "source\n" ;
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        if (this.LastModified != null) {
            s += ind + "lastModified\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (this.FileMode == null && Exploration.Includes(parent + ".fileMode", true))
        {
            this.FileMode = new FileModeEnum();
        }
        //      C# -> VappFileVersionSource? Source
        // GraphQL -> source: VappFileVersionSource! (enum)
        if (this.Source == null && Exploration.Includes(parent + ".source", true))
        {
            this.Source = new VappFileVersionSource();
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        if (this.LastModified == null && Exploration.Includes(parent + ".lastModified", true))
        {
            this.LastModified = new DateTime();
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        if (this.QuarantineInfo == null && Exploration.Includes(parent + ".quarantineInfo"))
        {
            this.QuarantineInfo = new QuarantineInfo();
            this.QuarantineInfo.ApplyExploratoryFieldSpec(parent + ".quarantineInfo");
        }
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        if (this.Snapshot == null && Exploration.Includes(parent + ".snapshot"))
        {
            this.Snapshot = new CdmSnapshot();
            this.Snapshot.ApplyExploratoryFieldSpec(parent + ".snapshot");
        }
    }


    #endregion

    } // class VappFileVersion
    
    #endregion

    public static class ListVappFileVersionExtensions
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
            this List<VappFileVersion> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VappFileVersion> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VappFileVersion());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types