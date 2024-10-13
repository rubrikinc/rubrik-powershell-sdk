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

        //      C# -> DateTime? FileCreationTime
        // GraphQL -> fileCreationTime: DateTime (scalar)
        [JsonProperty("fileCreationTime")]
        public DateTime? FileCreationTime { get; set; }

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

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }

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
        DateTime? FileCreationTime = null,
        DateTime? LastModified = null,
        System.Int64? Size = null,
        System.String? SnapshotId = null,
        DateTime? SnapshotTime = null,
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
        if ( FileCreationTime != null ) {
            this.FileCreationTime = FileCreationTime;
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
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (this.FileMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileMode\n" ;
            } else {
                s += ind + "fileMode\n" ;
            }
        }
        //      C# -> FileVersionSourceEnum? Source
        // GraphQL -> source: FileVersionSourceEnum! (enum)
        if (this.Source != null) {
            if (conf.Flat) {
                s += conf.Prefix + "source\n" ;
            } else {
                s += ind + "source\n" ;
            }
        }
        //      C# -> DateTime? FileCreationTime
        // GraphQL -> fileCreationTime: DateTime (scalar)
        if (this.FileCreationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileCreationTime\n" ;
            } else {
                s += ind + "fileCreationTime\n" ;
            }
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (this.LastModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModified\n" ;
            } else {
                s += ind + "lastModified\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        if (this.QuarantineInfo != null) {
            var fspec = this.QuarantineInfo.AsFieldSpec(conf.Child("quarantineInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "quarantineInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        if (this.Snapshot != null) {
            var fspec = this.Snapshot.AsFieldSpec(conf.Child("snapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (ec.Includes("fileMode",true))
        {
            if(this.FileMode == null) {

                this.FileMode = new FileModeEnum();

            } else {


            }
        }
        else if (this.FileMode != null && ec.Excludes("fileMode",true))
        {
            this.FileMode = null;
        }
        //      C# -> FileVersionSourceEnum? Source
        // GraphQL -> source: FileVersionSourceEnum! (enum)
        if (ec.Includes("source",true))
        {
            if(this.Source == null) {

                this.Source = new FileVersionSourceEnum();

            } else {


            }
        }
        else if (this.Source != null && ec.Excludes("source",true))
        {
            this.Source = null;
        }
        //      C# -> DateTime? FileCreationTime
        // GraphQL -> fileCreationTime: DateTime (scalar)
        if (ec.Includes("fileCreationTime",true))
        {
            if(this.FileCreationTime == null) {

                this.FileCreationTime = new DateTime();

            } else {


            }
        }
        else if (this.FileCreationTime != null && ec.Excludes("fileCreationTime",true))
        {
            this.FileCreationTime = null;
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (ec.Includes("lastModified",true))
        {
            if(this.LastModified == null) {

                this.LastModified = new DateTime();

            } else {


            }
        }
        else if (this.LastModified != null && ec.Excludes("lastModified",true))
        {
            this.LastModified = null;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        if (ec.Includes("quarantineInfo",false))
        {
            if(this.QuarantineInfo == null) {

                this.QuarantineInfo = new QuarantineInfo();
                this.QuarantineInfo.ApplyExploratoryFieldSpec(ec.NewChild("quarantineInfo"));

            } else {

                this.QuarantineInfo.ApplyExploratoryFieldSpec(ec.NewChild("quarantineInfo"));

            }
        }
        else if (this.QuarantineInfo != null && ec.Excludes("quarantineInfo",false))
        {
            this.QuarantineInfo = null;
        }
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        if (ec.Includes("snapshot",false))
        {
            if(this.Snapshot == null) {

                this.Snapshot = new CdmSnapshot();
                this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));

            } else {

                this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));

            }
        }
        else if (this.Snapshot != null && ec.Excludes("snapshot",false))
        {
            this.Snapshot = null;
        }
    }


    #endregion

    } // class HierarchySnappableFileVersion
    
    #endregion

    public static class ListHierarchySnappableFileVersionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<HierarchySnappableFileVersion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HierarchySnappableFileVersion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<HierarchySnappableFileVersion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types