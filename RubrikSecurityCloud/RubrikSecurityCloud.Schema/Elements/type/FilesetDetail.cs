// FilesetDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:25.
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
    #region FilesetDetail
    public class FilesetDetail: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int64? ArchiveStorage
            // GraphQL -> archiveStorage: Long (scalar)
            if (this.ArchiveStorage != null)
            {
                 s += ind + "archiveStorage\n";

            }
            //      C# -> System.Int32? ArchivedSnapshotCount
            // GraphQL -> archivedSnapshotCount: Int (scalar)
            if (this.ArchivedSnapshotCount != null)
            {
                 s += ind + "archivedSnapshotCount\n";

            }
            //      C# -> System.String? BackupScriptErrorHandling
            // GraphQL -> backupScriptErrorHandling: String (scalar)
            if (this.BackupScriptErrorHandling != null)
            {
                 s += ind + "backupScriptErrorHandling\n";

            }
            //      C# -> System.Int64? BackupScriptTimeout
            // GraphQL -> backupScriptTimeout: Long (scalar)
            if (this.BackupScriptTimeout != null)
            {
                 s += ind + "backupScriptTimeout\n";

            }
            //      C# -> System.Int64? LocalStorage
            // GraphQL -> localStorage: Long (scalar)
            if (this.LocalStorage != null)
            {
                 s += ind + "localStorage\n";

            }
            //      C# -> System.String? PostBackupScript
            // GraphQL -> postBackupScript: String (scalar)
            if (this.PostBackupScript != null)
            {
                 s += ind + "postBackupScript\n";

            }
            //      C# -> System.String? PreBackupScript
            // GraphQL -> preBackupScript: String (scalar)
            if (this.PreBackupScript != null)
            {
                 s += ind + "preBackupScript\n";

            }
            //      C# -> DateTime? ProtectionDate
            // GraphQL -> protectionDate: DateTime (scalar)
            if (this.ProtectionDate != null)
            {
                 s += ind + "protectionDate\n";

            }
            //      C# -> System.Int32? SnapshotCount
            // GraphQL -> snapshotCount: Int! (scalar)
            if (this.SnapshotCount != null)
            {
                 s += ind + "snapshotCount\n";

            }
            //      C# -> FilesetSummary? FilesetSummary
            // GraphQL -> filesetSummary: FilesetSummary (type)
            if (this.FilesetSummary != null)
            {
                 s += ind + "filesetSummary\n";

                 s += ind + "{\n" + 
                 this.FilesetSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FilesetUpdate? FilesetUpdate
            // GraphQL -> filesetUpdate: FilesetUpdate (type)
            if (this.FilesetUpdate != null)
            {
                 s += ind + "filesetUpdate\n";

                 s += ind + "{\n" + 
                 this.FilesetUpdate.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<FilesetSnapshotSummary>? Snapshots
            // GraphQL -> snapshots: [FilesetSnapshotSummary!]! (type)
            if (this.Snapshots != null)
            {
                 s += ind + "snapshots\n";

                 s += ind + "{\n" + 
                 this.Snapshots.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? ArchiveStorage
            // GraphQL -> archiveStorage: Long (scalar)
            if (this.ArchiveStorage == null && Exploration.Includes(parent + ".archiveStorage$"))
            {
                this.ArchiveStorage = new System.Int64();
            }
            //      C# -> System.Int32? ArchivedSnapshotCount
            // GraphQL -> archivedSnapshotCount: Int (scalar)
            if (this.ArchivedSnapshotCount == null && Exploration.Includes(parent + ".archivedSnapshotCount$"))
            {
                this.ArchivedSnapshotCount = new System.Int32();
            }
            //      C# -> System.String? BackupScriptErrorHandling
            // GraphQL -> backupScriptErrorHandling: String (scalar)
            if (this.BackupScriptErrorHandling == null && Exploration.Includes(parent + ".backupScriptErrorHandling$"))
            {
                this.BackupScriptErrorHandling = new System.String("FETCH");
            }
            //      C# -> System.Int64? BackupScriptTimeout
            // GraphQL -> backupScriptTimeout: Long (scalar)
            if (this.BackupScriptTimeout == null && Exploration.Includes(parent + ".backupScriptTimeout$"))
            {
                this.BackupScriptTimeout = new System.Int64();
            }
            //      C# -> System.Int64? LocalStorage
            // GraphQL -> localStorage: Long (scalar)
            if (this.LocalStorage == null && Exploration.Includes(parent + ".localStorage$"))
            {
                this.LocalStorage = new System.Int64();
            }
            //      C# -> System.String? PostBackupScript
            // GraphQL -> postBackupScript: String (scalar)
            if (this.PostBackupScript == null && Exploration.Includes(parent + ".postBackupScript$"))
            {
                this.PostBackupScript = new System.String("FETCH");
            }
            //      C# -> System.String? PreBackupScript
            // GraphQL -> preBackupScript: String (scalar)
            if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript$"))
            {
                this.PreBackupScript = new System.String("FETCH");
            }
            //      C# -> DateTime? ProtectionDate
            // GraphQL -> protectionDate: DateTime (scalar)
            if (this.ProtectionDate == null && Exploration.Includes(parent + ".protectionDate$"))
            {
                this.ProtectionDate = new DateTime();
            }
            //      C# -> System.Int32? SnapshotCount
            // GraphQL -> snapshotCount: Int! (scalar)
            if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount$"))
            {
                this.SnapshotCount = new System.Int32();
            }
            //      C# -> FilesetSummary? FilesetSummary
            // GraphQL -> filesetSummary: FilesetSummary (type)
            if (this.FilesetSummary == null && Exploration.Includes(parent + ".filesetSummary"))
            {
                this.FilesetSummary = new FilesetSummary();
                this.FilesetSummary.ApplyExploratoryFragment(parent + ".filesetSummary");
            }
            //      C# -> FilesetUpdate? FilesetUpdate
            // GraphQL -> filesetUpdate: FilesetUpdate (type)
            if (this.FilesetUpdate == null && Exploration.Includes(parent + ".filesetUpdate"))
            {
                this.FilesetUpdate = new FilesetUpdate();
                this.FilesetUpdate.ApplyExploratoryFragment(parent + ".filesetUpdate");
            }
            //      C# -> List<FilesetSnapshotSummary>? Snapshots
            // GraphQL -> snapshots: [FilesetSnapshotSummary!]! (type)
            if (this.Snapshots == null && Exploration.Includes(parent + ".snapshots"))
            {
                this.Snapshots = new List<FilesetSnapshotSummary>();
                this.Snapshots.ApplyExploratoryFragment(parent + ".snapshots");
            }
        }


    #endregion

    } // class FilesetDetail
    #endregion

    public static class ListFilesetDetailExtensions
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
            this List<FilesetDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetDetail> list, 
            String parent = "")
        {
            var item = new FilesetDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types