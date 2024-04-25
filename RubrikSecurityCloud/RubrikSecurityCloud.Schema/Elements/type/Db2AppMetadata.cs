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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "Db2AppMetadata";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> Db2SnapshotType? BaseSnapshotType
        // GraphQL -> baseSnapshotType: Db2SnapshotType (enum)
        if (this.BaseSnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "baseSnapshotType\n" ;
            } else {
                s += ind + "baseSnapshotType\n" ;
            }
        }
        //      C# -> Db2SnapshotType? SnapshotType
        // GraphQL -> snapshotType: Db2SnapshotType (enum)
        if (this.SnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotType\n" ;
            } else {
                s += ind + "snapshotType\n" ;
            }
        }
        //      C# -> System.Int64? ApproximateDbSizeBytes
        // GraphQL -> approximateDbSizeBytes: Long (scalar)
        if (this.ApproximateDbSizeBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "approximateDbSizeBytes\n" ;
            } else {
                s += ind + "approximateDbSizeBytes\n" ;
            }
        }
        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        if (this.BackupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupId\n" ;
            } else {
                s += ind + "backupId\n" ;
            }
        }
        //      C# -> System.String? BaseBackupId
        // GraphQL -> baseBackupId: String (scalar)
        if (this.BaseBackupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "baseBackupId\n" ;
            } else {
                s += ind + "baseBackupId\n" ;
            }
        }
        //      C# -> System.String? BaseSnapshotId
        // GraphQL -> baseSnapshotId: String (scalar)
        if (this.BaseSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "baseSnapshotId\n" ;
            } else {
                s += ind + "baseSnapshotId\n" ;
            }
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean! (scalar)
        if (this.IsExternalBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExternalBackup\n" ;
            } else {
                s += ind + "isExternalBackup\n" ;
            }
        }
        //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean! (scalar)
        if (this.IsRubrikTriggeredOnDemandBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRubrikTriggeredOnDemandBackup\n" ;
            } else {
                s += ind + "isRubrikTriggeredOnDemandBackup\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> Db2WorkloadDataSnapshotMetadata? Db2SnapshotMetadata
        // GraphQL -> db2SnapshotMetadata: Db2WorkloadDataSnapshotMetadata (type)
        if (this.Db2SnapshotMetadata != null) {
            var fspec = this.Db2SnapshotMetadata.AsFieldSpec(conf.Child("db2SnapshotMetadata"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "db2SnapshotMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Db2DataBackupFile>? Files
        // GraphQL -> files: [Db2DataBackupFile!]! (type)
        if (this.Files != null) {
            var fspec = this.Files.AsFieldSpec(conf.Child("files"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "files" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Db2SnapshotType? BaseSnapshotType
        // GraphQL -> baseSnapshotType: Db2SnapshotType (enum)
        if (ec.Includes("baseSnapshotType",true))
        {
            if(this.BaseSnapshotType == null) {

                this.BaseSnapshotType = new Db2SnapshotType();

            } else {


            }
        }
        else if (this.BaseSnapshotType != null && ec.Excludes("baseSnapshotType",true))
        {
            this.BaseSnapshotType = null;
        }
        //      C# -> Db2SnapshotType? SnapshotType
        // GraphQL -> snapshotType: Db2SnapshotType (enum)
        if (ec.Includes("snapshotType",true))
        {
            if(this.SnapshotType == null) {

                this.SnapshotType = new Db2SnapshotType();

            } else {


            }
        }
        else if (this.SnapshotType != null && ec.Excludes("snapshotType",true))
        {
            this.SnapshotType = null;
        }
        //      C# -> System.Int64? ApproximateDbSizeBytes
        // GraphQL -> approximateDbSizeBytes: Long (scalar)
        if (ec.Includes("approximateDbSizeBytes",true))
        {
            if(this.ApproximateDbSizeBytes == null) {

                this.ApproximateDbSizeBytes = new System.Int64();

            } else {


            }
        }
        else if (this.ApproximateDbSizeBytes != null && ec.Excludes("approximateDbSizeBytes",true))
        {
            this.ApproximateDbSizeBytes = null;
        }
        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        if (ec.Includes("backupId",true))
        {
            if(this.BackupId == null) {

                this.BackupId = "FETCH";

            } else {


            }
        }
        else if (this.BackupId != null && ec.Excludes("backupId",true))
        {
            this.BackupId = null;
        }
        //      C# -> System.String? BaseBackupId
        // GraphQL -> baseBackupId: String (scalar)
        if (ec.Includes("baseBackupId",true))
        {
            if(this.BaseBackupId == null) {

                this.BaseBackupId = "FETCH";

            } else {


            }
        }
        else if (this.BaseBackupId != null && ec.Excludes("baseBackupId",true))
        {
            this.BaseBackupId = null;
        }
        //      C# -> System.String? BaseSnapshotId
        // GraphQL -> baseSnapshotId: String (scalar)
        if (ec.Includes("baseSnapshotId",true))
        {
            if(this.BaseSnapshotId == null) {

                this.BaseSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.BaseSnapshotId != null && ec.Excludes("baseSnapshotId",true))
        {
            this.BaseSnapshotId = null;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean! (scalar)
        if (ec.Includes("isExternalBackup",true))
        {
            if(this.IsExternalBackup == null) {

                this.IsExternalBackup = true;

            } else {


            }
        }
        else if (this.IsExternalBackup != null && ec.Excludes("isExternalBackup",true))
        {
            this.IsExternalBackup = null;
        }
        //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean! (scalar)
        if (ec.Includes("isRubrikTriggeredOnDemandBackup",true))
        {
            if(this.IsRubrikTriggeredOnDemandBackup == null) {

                this.IsRubrikTriggeredOnDemandBackup = true;

            } else {


            }
        }
        else if (this.IsRubrikTriggeredOnDemandBackup != null && ec.Excludes("isRubrikTriggeredOnDemandBackup",true))
        {
            this.IsRubrikTriggeredOnDemandBackup = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
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
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> Db2WorkloadDataSnapshotMetadata? Db2SnapshotMetadata
        // GraphQL -> db2SnapshotMetadata: Db2WorkloadDataSnapshotMetadata (type)
        if (ec.Includes("db2SnapshotMetadata",false))
        {
            if(this.Db2SnapshotMetadata == null) {

                this.Db2SnapshotMetadata = new Db2WorkloadDataSnapshotMetadata();
                this.Db2SnapshotMetadata.ApplyExploratoryFieldSpec(ec.NewChild("db2SnapshotMetadata"));

            } else {

                this.Db2SnapshotMetadata.ApplyExploratoryFieldSpec(ec.NewChild("db2SnapshotMetadata"));

            }
        }
        else if (this.Db2SnapshotMetadata != null && ec.Excludes("db2SnapshotMetadata",false))
        {
            this.Db2SnapshotMetadata = null;
        }
        //      C# -> List<Db2DataBackupFile>? Files
        // GraphQL -> files: [Db2DataBackupFile!]! (type)
        if (ec.Includes("files",false))
        {
            if(this.Files == null) {

                this.Files = new List<Db2DataBackupFile>();
                this.Files.ApplyExploratoryFieldSpec(ec.NewChild("files"));

            } else {

                this.Files.ApplyExploratoryFieldSpec(ec.NewChild("files"));

            }
        }
        else if (this.Files != null && ec.Excludes("files",false))
        {
            this.Files = null;
        }
    }


    #endregion

    } // class Db2AppMetadata
    
    #endregion

    public static class ListDb2AppMetadataExtensions
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
            this List<Db2AppMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Db2AppMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Db2AppMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2AppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Db2AppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types