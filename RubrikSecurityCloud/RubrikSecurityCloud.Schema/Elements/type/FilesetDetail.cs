// FilesetDetail.cs
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
    #region FilesetDetail
    public class FilesetDetail: BaseType
    {
        #region members

        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        [JsonProperty("archiveStorage")]
        public System.Int64? ArchiveStorage { get; set; }

        //      C# -> System.Int32? ArchivedSnapshotCount
        // GraphQL -> archivedSnapshotCount: Int (scalar)
        [JsonProperty("archivedSnapshotCount")]
        public System.Int32? ArchivedSnapshotCount { get; set; }

        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        [JsonProperty("backupScriptErrorHandling")]
        public System.String? BackupScriptErrorHandling { get; set; }

        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        [JsonProperty("backupScriptTimeout")]
        public System.Int64? BackupScriptTimeout { get; set; }

        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        [JsonProperty("localStorage")]
        public System.Int64? LocalStorage { get; set; }

        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        [JsonProperty("postBackupScript")]
        public System.String? PostBackupScript { get; set; }

        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        [JsonProperty("preBackupScript")]
        public System.String? PreBackupScript { get; set; }

        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        [JsonProperty("protectionDate")]
        public DateTime? ProtectionDate { get; set; }

        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int32? SnapshotCount { get; set; }

        //      C# -> FilesetSummary? FilesetSummary
        // GraphQL -> filesetSummary: FilesetSummary (type)
        [JsonProperty("filesetSummary")]
        public FilesetSummary? FilesetSummary { get; set; }

        //      C# -> FilesetUpdate? FilesetUpdate
        // GraphQL -> filesetUpdate: FilesetUpdate (type)
        [JsonProperty("filesetUpdate")]
        public FilesetUpdate? FilesetUpdate { get; set; }

        //      C# -> List<FilesetSnapshotSummary>? Snapshots
        // GraphQL -> snapshots: [FilesetSnapshotSummary!]! (type)
        [JsonProperty("snapshots")]
        public List<FilesetSnapshotSummary>? Snapshots { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilesetDetail";
    }

    public FilesetDetail Set(
        System.Int64? ArchiveStorage = null,
        System.Int32? ArchivedSnapshotCount = null,
        System.String? BackupScriptErrorHandling = null,
        System.Int64? BackupScriptTimeout = null,
        System.Int64? LocalStorage = null,
        System.String? PostBackupScript = null,
        System.String? PreBackupScript = null,
        DateTime? ProtectionDate = null,
        System.Int32? SnapshotCount = null,
        FilesetSummary? FilesetSummary = null,
        FilesetUpdate? FilesetUpdate = null,
        List<FilesetSnapshotSummary>? Snapshots = null
    ) 
    {
        if ( ArchiveStorage != null ) {
            this.ArchiveStorage = ArchiveStorage;
        }
        if ( ArchivedSnapshotCount != null ) {
            this.ArchivedSnapshotCount = ArchivedSnapshotCount;
        }
        if ( BackupScriptErrorHandling != null ) {
            this.BackupScriptErrorHandling = BackupScriptErrorHandling;
        }
        if ( BackupScriptTimeout != null ) {
            this.BackupScriptTimeout = BackupScriptTimeout;
        }
        if ( LocalStorage != null ) {
            this.LocalStorage = LocalStorage;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
        }
        if ( ProtectionDate != null ) {
            this.ProtectionDate = ProtectionDate;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( FilesetSummary != null ) {
            this.FilesetSummary = FilesetSummary;
        }
        if ( FilesetUpdate != null ) {
            this.FilesetUpdate = FilesetUpdate;
        }
        if ( Snapshots != null ) {
            this.Snapshots = Snapshots;
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
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archiveStorage\n" ;
            } else {
                s += ind + "archiveStorage\n" ;
            }
        }
        //      C# -> System.Int32? ArchivedSnapshotCount
        // GraphQL -> archivedSnapshotCount: Int (scalar)
        if (this.ArchivedSnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivedSnapshotCount\n" ;
            } else {
                s += ind + "archivedSnapshotCount\n" ;
            }
        }
        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        if (this.BackupScriptErrorHandling != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupScriptErrorHandling\n" ;
            } else {
                s += ind + "backupScriptErrorHandling\n" ;
            }
        }
        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        if (this.BackupScriptTimeout != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupScriptTimeout\n" ;
            } else {
                s += ind + "backupScriptTimeout\n" ;
            }
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localStorage\n" ;
            } else {
                s += ind + "localStorage\n" ;
            }
        }
        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        if (this.PostBackupScript != null) {
            if (conf.Flat) {
                s += conf.Prefix + "postBackupScript\n" ;
            } else {
                s += ind + "postBackupScript\n" ;
            }
        }
        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        if (this.PreBackupScript != null) {
            if (conf.Flat) {
                s += conf.Prefix + "preBackupScript\n" ;
            } else {
                s += ind + "preBackupScript\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDate\n" ;
            } else {
                s += ind + "protectionDate\n" ;
            }
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotCount\n" ;
            } else {
                s += ind + "snapshotCount\n" ;
            }
        }
        //      C# -> FilesetSummary? FilesetSummary
        // GraphQL -> filesetSummary: FilesetSummary (type)
        if (this.FilesetSummary != null) {
            var fspec = this.FilesetSummary.AsFieldSpec(conf.Child("filesetSummary"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filesetSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FilesetUpdate? FilesetUpdate
        // GraphQL -> filesetUpdate: FilesetUpdate (type)
        if (this.FilesetUpdate != null) {
            var fspec = this.FilesetUpdate.AsFieldSpec(conf.Child("filesetUpdate"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filesetUpdate" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FilesetSnapshotSummary>? Snapshots
        // GraphQL -> snapshots: [FilesetSnapshotSummary!]! (type)
        if (this.Snapshots != null) {
            var fspec = this.Snapshots.AsFieldSpec(conf.Child("snapshots"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshots" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (ec.Includes("archiveStorage",true))
        {
            if(this.ArchiveStorage == null) {

                this.ArchiveStorage = new System.Int64();

            } else {


            }
        }
        else if (this.ArchiveStorage != null && ec.Excludes("archiveStorage",true))
        {
            this.ArchiveStorage = null;
        }
        //      C# -> System.Int32? ArchivedSnapshotCount
        // GraphQL -> archivedSnapshotCount: Int (scalar)
        if (ec.Includes("archivedSnapshotCount",true))
        {
            if(this.ArchivedSnapshotCount == null) {

                this.ArchivedSnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ArchivedSnapshotCount != null && ec.Excludes("archivedSnapshotCount",true))
        {
            this.ArchivedSnapshotCount = null;
        }
        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        if (ec.Includes("backupScriptErrorHandling",true))
        {
            if(this.BackupScriptErrorHandling == null) {

                this.BackupScriptErrorHandling = "FETCH";

            } else {


            }
        }
        else if (this.BackupScriptErrorHandling != null && ec.Excludes("backupScriptErrorHandling",true))
        {
            this.BackupScriptErrorHandling = null;
        }
        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        if (ec.Includes("backupScriptTimeout",true))
        {
            if(this.BackupScriptTimeout == null) {

                this.BackupScriptTimeout = new System.Int64();

            } else {


            }
        }
        else if (this.BackupScriptTimeout != null && ec.Excludes("backupScriptTimeout",true))
        {
            this.BackupScriptTimeout = null;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (ec.Includes("localStorage",true))
        {
            if(this.LocalStorage == null) {

                this.LocalStorage = new System.Int64();

            } else {


            }
        }
        else if (this.LocalStorage != null && ec.Excludes("localStorage",true))
        {
            this.LocalStorage = null;
        }
        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        if (ec.Includes("postBackupScript",true))
        {
            if(this.PostBackupScript == null) {

                this.PostBackupScript = "FETCH";

            } else {


            }
        }
        else if (this.PostBackupScript != null && ec.Excludes("postBackupScript",true))
        {
            this.PostBackupScript = null;
        }
        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        if (ec.Includes("preBackupScript",true))
        {
            if(this.PreBackupScript == null) {

                this.PreBackupScript = "FETCH";

            } else {


            }
        }
        else if (this.PreBackupScript != null && ec.Excludes("preBackupScript",true))
        {
            this.PreBackupScript = null;
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (ec.Includes("protectionDate",true))
        {
            if(this.ProtectionDate == null) {

                this.ProtectionDate = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDate != null && ec.Excludes("protectionDate",true))
        {
            this.ProtectionDate = null;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (ec.Includes("snapshotCount",true))
        {
            if(this.SnapshotCount == null) {

                this.SnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.SnapshotCount != null && ec.Excludes("snapshotCount",true))
        {
            this.SnapshotCount = null;
        }
        //      C# -> FilesetSummary? FilesetSummary
        // GraphQL -> filesetSummary: FilesetSummary (type)
        if (ec.Includes("filesetSummary",false))
        {
            if(this.FilesetSummary == null) {

                this.FilesetSummary = new FilesetSummary();
                this.FilesetSummary.ApplyExploratoryFieldSpec(ec.NewChild("filesetSummary"));

            } else {

                this.FilesetSummary.ApplyExploratoryFieldSpec(ec.NewChild("filesetSummary"));

            }
        }
        else if (this.FilesetSummary != null && ec.Excludes("filesetSummary",false))
        {
            this.FilesetSummary = null;
        }
        //      C# -> FilesetUpdate? FilesetUpdate
        // GraphQL -> filesetUpdate: FilesetUpdate (type)
        if (ec.Includes("filesetUpdate",false))
        {
            if(this.FilesetUpdate == null) {

                this.FilesetUpdate = new FilesetUpdate();
                this.FilesetUpdate.ApplyExploratoryFieldSpec(ec.NewChild("filesetUpdate"));

            } else {

                this.FilesetUpdate.ApplyExploratoryFieldSpec(ec.NewChild("filesetUpdate"));

            }
        }
        else if (this.FilesetUpdate != null && ec.Excludes("filesetUpdate",false))
        {
            this.FilesetUpdate = null;
        }
        //      C# -> List<FilesetSnapshotSummary>? Snapshots
        // GraphQL -> snapshots: [FilesetSnapshotSummary!]! (type)
        if (ec.Includes("snapshots",false))
        {
            if(this.Snapshots == null) {

                this.Snapshots = new List<FilesetSnapshotSummary>();
                this.Snapshots.ApplyExploratoryFieldSpec(ec.NewChild("snapshots"));

            } else {

                this.Snapshots.ApplyExploratoryFieldSpec(ec.NewChild("snapshots"));

            }
        }
        else if (this.Snapshots != null && ec.Excludes("snapshots",false))
        {
            this.Snapshots = null;
        }
    }


    #endregion

    } // class FilesetDetail
    
    #endregion

    public static class ListFilesetDetailExtensions
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
            this List<FilesetDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FilesetDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilesetDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types