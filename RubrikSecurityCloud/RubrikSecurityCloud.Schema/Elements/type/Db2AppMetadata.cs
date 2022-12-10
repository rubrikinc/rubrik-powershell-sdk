// Db2AppMetadata.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:05.
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
    #region Db2AppMetadata
    public class Db2AppMetadata: IFragment
    {
        #region members
        //      C# -> System.Int64? ApproximateDbSizeBytes
        // GraphQL -> approximateDbSizeBytes: Long (scalar)
        [JsonProperty("approximateDbSizeBytes")]
        public System.Int64? ApproximateDbSizeBytes { get; set; }

        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        [JsonProperty("backupId")]
        public System.String? BackupId { get; set; }

        //      C# -> System.String? BaseBackupId
        // GraphQL -> baseBackupId: String (scalar)
        [JsonProperty("baseBackupId")]
        public System.String? BaseBackupId { get; set; }

        //      C# -> System.String? BaseSnapshotId
        // GraphQL -> baseSnapshotId: String (scalar)
        [JsonProperty("baseSnapshotId")]
        public System.String? BaseSnapshotId { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean! (scalar)
        [JsonProperty("isExternalBackup")]
        public System.Boolean? IsExternalBackup { get; set; }

        //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean! (scalar)
        [JsonProperty("isRubrikTriggeredOnDemandBackup")]
        public System.Boolean? IsRubrikTriggeredOnDemandBackup { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> Db2WorkloadDataSnapshotMetadata? Db2SnapshotMetadata
        // GraphQL -> db2SnapshotMetadata: Db2WorkloadDataSnapshotMetadata (type)
        [JsonProperty("db2SnapshotMetadata")]
        public Db2WorkloadDataSnapshotMetadata? Db2SnapshotMetadata { get; set; }

        //      C# -> List<Db2DataBackupFile>? Files
        // GraphQL -> files: [Db2DataBackupFile!]! (type)
        [JsonProperty("files")]
        public List<Db2DataBackupFile>? Files { get; set; }

        //      C# -> Db2SnapshotType? BaseSnapshotType
        // GraphQL -> baseSnapshotType: Db2SnapshotType (enum)
        [JsonProperty("baseSnapshotType")]
        public Db2SnapshotType? BaseSnapshotType { get; set; }

        //      C# -> Db2SnapshotType? SnapshotType
        // GraphQL -> snapshotType: Db2SnapshotType (enum)
        [JsonProperty("snapshotType")]
        public Db2SnapshotType? SnapshotType { get; set; }

        #endregion

    #region methods

    public Db2AppMetadata Set(
        System.Int64? ApproximateDbSizeBytes = null,
        System.String? BackupId = null,
        System.String? BaseBackupId = null,
        System.String? BaseSnapshotId = null,
        DateTime? EndTime = null,
        System.Boolean? IsExternalBackup = null,
        System.Boolean? IsRubrikTriggeredOnDemandBackup = null,
        System.String? SnapshotId = null,
        DateTime? StartTime = null,
        Db2WorkloadDataSnapshotMetadata? Db2SnapshotMetadata = null,
        List<Db2DataBackupFile>? Files = null,
        Db2SnapshotType? BaseSnapshotType = null,
        Db2SnapshotType? SnapshotType = null
    ) 
    {
        if ( ApproximateDbSizeBytes != null ) {
            this.ApproximateDbSizeBytes = ApproximateDbSizeBytes;
        }
        if ( BackupId != null ) {
            this.BackupId = BackupId;
        }
        if ( BaseBackupId != null ) {
            this.BaseBackupId = BaseBackupId;
        }
        if ( BaseSnapshotId != null ) {
            this.BaseSnapshotId = BaseSnapshotId;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( IsExternalBackup != null ) {
            this.IsExternalBackup = IsExternalBackup;
        }
        if ( IsRubrikTriggeredOnDemandBackup != null ) {
            this.IsRubrikTriggeredOnDemandBackup = IsRubrikTriggeredOnDemandBackup;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Db2SnapshotMetadata != null ) {
            this.Db2SnapshotMetadata = Db2SnapshotMetadata;
        }
        if ( Files != null ) {
            this.Files = Files;
        }
        if ( BaseSnapshotType != null ) {
            this.BaseSnapshotType = BaseSnapshotType;
        }
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
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
            //      C# -> System.Int64? ApproximateDbSizeBytes
            // GraphQL -> approximateDbSizeBytes: Long (scalar)
            if (this.ApproximateDbSizeBytes != null)
            {
                 s += ind + "approximateDbSizeBytes\n";

            }
            //      C# -> System.String? BackupId
            // GraphQL -> backupId: String (scalar)
            if (this.BackupId != null)
            {
                 s += ind + "backupId\n";

            }
            //      C# -> System.String? BaseBackupId
            // GraphQL -> baseBackupId: String (scalar)
            if (this.BaseBackupId != null)
            {
                 s += ind + "baseBackupId\n";

            }
            //      C# -> System.String? BaseSnapshotId
            // GraphQL -> baseSnapshotId: String (scalar)
            if (this.BaseSnapshotId != null)
            {
                 s += ind + "baseSnapshotId\n";

            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.Boolean? IsExternalBackup
            // GraphQL -> isExternalBackup: Boolean! (scalar)
            if (this.IsExternalBackup != null)
            {
                 s += ind + "isExternalBackup\n";

            }
            //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
            // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean! (scalar)
            if (this.IsRubrikTriggeredOnDemandBackup != null)
            {
                 s += ind + "isRubrikTriggeredOnDemandBackup\n";

            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            //      C# -> Db2WorkloadDataSnapshotMetadata? Db2SnapshotMetadata
            // GraphQL -> db2SnapshotMetadata: Db2WorkloadDataSnapshotMetadata (type)
            if (this.Db2SnapshotMetadata != null)
            {
                 s += ind + "db2SnapshotMetadata\n";

                 s += ind + "{\n" + 
                 this.Db2SnapshotMetadata.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Db2DataBackupFile>? Files
            // GraphQL -> files: [Db2DataBackupFile!]! (type)
            if (this.Files != null)
            {
                 s += ind + "files\n";

                 s += ind + "{\n" + 
                 this.Files.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Db2SnapshotType? BaseSnapshotType
            // GraphQL -> baseSnapshotType: Db2SnapshotType (enum)
            if (this.BaseSnapshotType != null)
            {
                 s += ind + "baseSnapshotType\n";

            }
            //      C# -> Db2SnapshotType? SnapshotType
            // GraphQL -> snapshotType: Db2SnapshotType (enum)
            if (this.SnapshotType != null)
            {
                 s += ind + "snapshotType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? ApproximateDbSizeBytes
            // GraphQL -> approximateDbSizeBytes: Long (scalar)
            if (this.ApproximateDbSizeBytes == null && Exploration.Includes(parent + ".approximateDbSizeBytes$"))
            {
                this.ApproximateDbSizeBytes = new System.Int64();
            }
            //      C# -> System.String? BackupId
            // GraphQL -> backupId: String (scalar)
            if (this.BackupId == null && Exploration.Includes(parent + ".backupId$"))
            {
                this.BackupId = new System.String("FETCH");
            }
            //      C# -> System.String? BaseBackupId
            // GraphQL -> baseBackupId: String (scalar)
            if (this.BaseBackupId == null && Exploration.Includes(parent + ".baseBackupId$"))
            {
                this.BaseBackupId = new System.String("FETCH");
            }
            //      C# -> System.String? BaseSnapshotId
            // GraphQL -> baseSnapshotId: String (scalar)
            if (this.BaseSnapshotId == null && Exploration.Includes(parent + ".baseSnapshotId$"))
            {
                this.BaseSnapshotId = new System.String("FETCH");
            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
            //      C# -> System.Boolean? IsExternalBackup
            // GraphQL -> isExternalBackup: Boolean! (scalar)
            if (this.IsExternalBackup == null && Exploration.Includes(parent + ".isExternalBackup$"))
            {
                this.IsExternalBackup = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
            // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean! (scalar)
            if (this.IsRubrikTriggeredOnDemandBackup == null && Exploration.Includes(parent + ".isRubrikTriggeredOnDemandBackup$"))
            {
                this.IsRubrikTriggeredOnDemandBackup = new System.Boolean();
            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new DateTime();
            }
            //      C# -> Db2WorkloadDataSnapshotMetadata? Db2SnapshotMetadata
            // GraphQL -> db2SnapshotMetadata: Db2WorkloadDataSnapshotMetadata (type)
            if (this.Db2SnapshotMetadata == null && Exploration.Includes(parent + ".db2SnapshotMetadata"))
            {
                this.Db2SnapshotMetadata = new Db2WorkloadDataSnapshotMetadata();
                this.Db2SnapshotMetadata.ApplyExploratoryFragment(parent + ".db2SnapshotMetadata");
            }
            //      C# -> List<Db2DataBackupFile>? Files
            // GraphQL -> files: [Db2DataBackupFile!]! (type)
            if (this.Files == null && Exploration.Includes(parent + ".files"))
            {
                this.Files = new List<Db2DataBackupFile>();
                this.Files.ApplyExploratoryFragment(parent + ".files");
            }
            //      C# -> Db2SnapshotType? BaseSnapshotType
            // GraphQL -> baseSnapshotType: Db2SnapshotType (enum)
            if (this.BaseSnapshotType == null && Exploration.Includes(parent + ".baseSnapshotType$"))
            {
                this.BaseSnapshotType = new Db2SnapshotType();
            }
            //      C# -> Db2SnapshotType? SnapshotType
            // GraphQL -> snapshotType: Db2SnapshotType (enum)
            if (this.SnapshotType == null && Exploration.Includes(parent + ".snapshotType$"))
            {
                this.SnapshotType = new Db2SnapshotType();
            }
        }


    #endregion

    } // class Db2AppMetadata
    #endregion

    public static class ListDb2AppMetadataExtensions
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
            this List<Db2AppMetadata> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Db2AppMetadata> list, 
            String parent = "")
        {
            var item = new Db2AppMetadata();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types