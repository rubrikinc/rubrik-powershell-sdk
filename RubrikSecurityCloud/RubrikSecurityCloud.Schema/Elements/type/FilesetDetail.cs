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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage != null) {
            s += ind + "archiveStorage\n" ;
        }
        //      C# -> System.Int32? ArchivedSnapshotCount
        // GraphQL -> archivedSnapshotCount: Int (scalar)
        if (this.ArchivedSnapshotCount != null) {
            s += ind + "archivedSnapshotCount\n" ;
        }
        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        if (this.BackupScriptErrorHandling != null) {
            s += ind + "backupScriptErrorHandling\n" ;
        }
        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        if (this.BackupScriptTimeout != null) {
            s += ind + "backupScriptTimeout\n" ;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage != null) {
            s += ind + "localStorage\n" ;
        }
        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        if (this.PostBackupScript != null) {
            s += ind + "postBackupScript\n" ;
        }
        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        if (this.PreBackupScript != null) {
            s += ind + "preBackupScript\n" ;
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate != null) {
            s += ind + "protectionDate\n" ;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount != null) {
            s += ind + "snapshotCount\n" ;
        }
        //      C# -> FilesetSummary? FilesetSummary
        // GraphQL -> filesetSummary: FilesetSummary (type)
        if (this.FilesetSummary != null) {
            s += ind + "filesetSummary {\n" + this.FilesetSummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> FilesetUpdate? FilesetUpdate
        // GraphQL -> filesetUpdate: FilesetUpdate (type)
        if (this.FilesetUpdate != null) {
            s += ind + "filesetUpdate {\n" + this.FilesetUpdate.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<FilesetSnapshotSummary>? Snapshots
        // GraphQL -> snapshots: [FilesetSnapshotSummary!]! (type)
        if (this.Snapshots != null) {
            s += ind + "snapshots {\n" + this.Snapshots.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage == null && Exploration.Includes(parent + ".archiveStorage", true))
        {
            this.ArchiveStorage = new System.Int64();
        }
        //      C# -> System.Int32? ArchivedSnapshotCount
        // GraphQL -> archivedSnapshotCount: Int (scalar)
        if (this.ArchivedSnapshotCount == null && Exploration.Includes(parent + ".archivedSnapshotCount", true))
        {
            this.ArchivedSnapshotCount = Int32.MinValue;
        }
        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        if (this.BackupScriptErrorHandling == null && Exploration.Includes(parent + ".backupScriptErrorHandling", true))
        {
            this.BackupScriptErrorHandling = "FETCH";
        }
        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        if (this.BackupScriptTimeout == null && Exploration.Includes(parent + ".backupScriptTimeout", true))
        {
            this.BackupScriptTimeout = new System.Int64();
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage == null && Exploration.Includes(parent + ".localStorage", true))
        {
            this.LocalStorage = new System.Int64();
        }
        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        if (this.PostBackupScript == null && Exploration.Includes(parent + ".postBackupScript", true))
        {
            this.PostBackupScript = "FETCH";
        }
        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript", true))
        {
            this.PreBackupScript = "FETCH";
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate == null && Exploration.Includes(parent + ".protectionDate", true))
        {
            this.ProtectionDate = new DateTime();
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount", true))
        {
            this.SnapshotCount = Int32.MinValue;
        }
        //      C# -> FilesetSummary? FilesetSummary
        // GraphQL -> filesetSummary: FilesetSummary (type)
        if (this.FilesetSummary == null && Exploration.Includes(parent + ".filesetSummary"))
        {
            this.FilesetSummary = new FilesetSummary();
            this.FilesetSummary.ApplyExploratoryFieldSpec(parent + ".filesetSummary");
        }
        //      C# -> FilesetUpdate? FilesetUpdate
        // GraphQL -> filesetUpdate: FilesetUpdate (type)
        if (this.FilesetUpdate == null && Exploration.Includes(parent + ".filesetUpdate"))
        {
            this.FilesetUpdate = new FilesetUpdate();
            this.FilesetUpdate.ApplyExploratoryFieldSpec(parent + ".filesetUpdate");
        }
        //      C# -> List<FilesetSnapshotSummary>? Snapshots
        // GraphQL -> snapshots: [FilesetSnapshotSummary!]! (type)
        if (this.Snapshots == null && Exploration.Includes(parent + ".snapshots"))
        {
            this.Snapshots = new List<FilesetSnapshotSummary>();
            this.Snapshots.ApplyExploratoryFieldSpec(parent + ".snapshots");
        }
    }


    #endregion

    } // class FilesetDetail
    
    #endregion

    public static class ListFilesetDetailExtensions
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
            this List<FilesetDetail> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilesetDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types