// Db2AppMetadata.cs
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
    #region Db2AppMetadata
    public class Db2AppMetadata: BaseType
    {
        #region members

        //      C# -> Db2SnapshotType? BaseSnapshotType
        // GraphQL -> baseSnapshotType: Db2SnapshotType (enum)
        [JsonProperty("baseSnapshotType")]
        public Db2SnapshotType? BaseSnapshotType { get; set; }

        //      C# -> Db2SnapshotType? SnapshotType
        // GraphQL -> snapshotType: Db2SnapshotType (enum)
        [JsonProperty("snapshotType")]
        public Db2SnapshotType? SnapshotType { get; set; }

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


        #endregion

    #region methods

    public Db2AppMetadata Set(
        Db2SnapshotType? BaseSnapshotType = null,
        Db2SnapshotType? SnapshotType = null,
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
        List<Db2DataBackupFile>? Files = null
    ) 
    {
        if ( BaseSnapshotType != null ) {
            this.BaseSnapshotType = BaseSnapshotType;
        }
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> Db2SnapshotType? BaseSnapshotType
        // GraphQL -> baseSnapshotType: Db2SnapshotType (enum)
        if (this.BaseSnapshotType != null) {
            s += ind + "baseSnapshotType\n" ;
        }
        //      C# -> Db2SnapshotType? SnapshotType
        // GraphQL -> snapshotType: Db2SnapshotType (enum)
        if (this.SnapshotType != null) {
            s += ind + "snapshotType\n" ;
        }
        //      C# -> System.Int64? ApproximateDbSizeBytes
        // GraphQL -> approximateDbSizeBytes: Long (scalar)
        if (this.ApproximateDbSizeBytes != null) {
            s += ind + "approximateDbSizeBytes\n" ;
        }
        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        if (this.BackupId != null) {
            s += ind + "backupId\n" ;
        }
        //      C# -> System.String? BaseBackupId
        // GraphQL -> baseBackupId: String (scalar)
        if (this.BaseBackupId != null) {
            s += ind + "baseBackupId\n" ;
        }
        //      C# -> System.String? BaseSnapshotId
        // GraphQL -> baseSnapshotId: String (scalar)
        if (this.BaseSnapshotId != null) {
            s += ind + "baseSnapshotId\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean! (scalar)
        if (this.IsExternalBackup != null) {
            s += ind + "isExternalBackup\n" ;
        }
        //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean! (scalar)
        if (this.IsRubrikTriggeredOnDemandBackup != null) {
            s += ind + "isRubrikTriggeredOnDemandBackup\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> Db2WorkloadDataSnapshotMetadata? Db2SnapshotMetadata
        // GraphQL -> db2SnapshotMetadata: Db2WorkloadDataSnapshotMetadata (type)
        if (this.Db2SnapshotMetadata != null) {
            var fspec = this.Db2SnapshotMetadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "db2SnapshotMetadata {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Db2DataBackupFile>? Files
        // GraphQL -> files: [Db2DataBackupFile!]! (type)
        if (this.Files != null) {
            var fspec = this.Files.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "files {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Db2SnapshotType? BaseSnapshotType
        // GraphQL -> baseSnapshotType: Db2SnapshotType (enum)
        if (this.BaseSnapshotType == null && Exploration.Includes(parent + ".baseSnapshotType", true))
        {
            this.BaseSnapshotType = new Db2SnapshotType();
        }
        //      C# -> Db2SnapshotType? SnapshotType
        // GraphQL -> snapshotType: Db2SnapshotType (enum)
        if (this.SnapshotType == null && Exploration.Includes(parent + ".snapshotType", true))
        {
            this.SnapshotType = new Db2SnapshotType();
        }
        //      C# -> System.Int64? ApproximateDbSizeBytes
        // GraphQL -> approximateDbSizeBytes: Long (scalar)
        if (this.ApproximateDbSizeBytes == null && Exploration.Includes(parent + ".approximateDbSizeBytes", true))
        {
            this.ApproximateDbSizeBytes = new System.Int64();
        }
        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        if (this.BackupId == null && Exploration.Includes(parent + ".backupId", true))
        {
            this.BackupId = "FETCH";
        }
        //      C# -> System.String? BaseBackupId
        // GraphQL -> baseBackupId: String (scalar)
        if (this.BaseBackupId == null && Exploration.Includes(parent + ".baseBackupId", true))
        {
            this.BaseBackupId = "FETCH";
        }
        //      C# -> System.String? BaseSnapshotId
        // GraphQL -> baseSnapshotId: String (scalar)
        if (this.BaseSnapshotId == null && Exploration.Includes(parent + ".baseSnapshotId", true))
        {
            this.BaseSnapshotId = "FETCH";
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean! (scalar)
        if (this.IsExternalBackup == null && Exploration.Includes(parent + ".isExternalBackup", true))
        {
            this.IsExternalBackup = true;
        }
        //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean! (scalar)
        if (this.IsRubrikTriggeredOnDemandBackup == null && Exploration.Includes(parent + ".isRubrikTriggeredOnDemandBackup", true))
        {
            this.IsRubrikTriggeredOnDemandBackup = true;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> Db2WorkloadDataSnapshotMetadata? Db2SnapshotMetadata
        // GraphQL -> db2SnapshotMetadata: Db2WorkloadDataSnapshotMetadata (type)
        if (this.Db2SnapshotMetadata == null && Exploration.Includes(parent + ".db2SnapshotMetadata"))
        {
            this.Db2SnapshotMetadata = new Db2WorkloadDataSnapshotMetadata();
            this.Db2SnapshotMetadata.ApplyExploratoryFieldSpec(parent + ".db2SnapshotMetadata");
        }
        //      C# -> List<Db2DataBackupFile>? Files
        // GraphQL -> files: [Db2DataBackupFile!]! (type)
        if (this.Files == null && Exploration.Includes(parent + ".files"))
        {
            this.Files = new List<Db2DataBackupFile>();
            this.Files.ApplyExploratoryFieldSpec(parent + ".files");
        }
    }


    #endregion

    } // class Db2AppMetadata
    
    #endregion

    public static class ListDb2AppMetadataExtensions
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
            this List<Db2AppMetadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2AppMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2AppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types