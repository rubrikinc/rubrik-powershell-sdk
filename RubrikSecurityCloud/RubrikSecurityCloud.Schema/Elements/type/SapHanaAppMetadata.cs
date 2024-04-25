// SapHanaAppMetadata.cs
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
    #region SapHanaAppMetadata
    public class SapHanaAppMetadata: BaseType
    {
        #region members

        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        [JsonProperty("backupId")]
        public System.Int64? BackupId { get; set; }

        //      C# -> System.String? BackupPrefix
        // GraphQL -> backupPrefix: String (scalar)
        [JsonProperty("backupPrefix")]
        public System.String? BackupPrefix { get; set; }

        //      C# -> System.Int64? BaseBackupId
        // GraphQL -> baseBackupId: Long (scalar)
        [JsonProperty("baseBackupId")]
        public System.Int64? BaseBackupId { get; set; }

        //      C# -> System.String? BaseFullSnapshotId
        // GraphQL -> baseFullSnapshotId: String (scalar)
        [JsonProperty("baseFullSnapshotId")]
        public System.String? BaseFullSnapshotId { get; set; }

        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean (scalar)
        [JsonProperty("isExternalBackup")]
        public System.Boolean? IsExternalBackup { get; set; }

        //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean (scalar)
        [JsonProperty("isRubrikTriggeredOnDemandBackup")]
        public System.Boolean? IsRubrikTriggeredOnDemandBackup { get; set; }

        //      C# -> DateTime? RubrikSnapshotEndTime
        // GraphQL -> rubrikSnapshotEndTime: DateTime (scalar)
        [JsonProperty("rubrikSnapshotEndTime")]
        public DateTime? RubrikSnapshotEndTime { get; set; }

        //      C# -> DateTime? RubrikSnapshotStartTime
        // GraphQL -> rubrikSnapshotStartTime: DateTime (scalar)
        [JsonProperty("rubrikSnapshotStartTime")]
        public DateTime? RubrikSnapshotStartTime { get; set; }

        //      C# -> DateTime? SapHanaEndTime
        // GraphQL -> sapHanaEndTime: DateTime (scalar)
        [JsonProperty("sapHanaEndTime")]
        public DateTime? SapHanaEndTime { get; set; }

        //      C# -> DateTime? SapHanaStartTime
        // GraphQL -> sapHanaStartTime: DateTime (scalar)
        [JsonProperty("sapHanaStartTime")]
        public DateTime? SapHanaStartTime { get; set; }

        //      C# -> System.String? SnapshotType
        // GraphQL -> snapshotType: String (scalar)
        [JsonProperty("snapshotType")]
        public System.String? SnapshotType { get; set; }

        //      C# -> List<SapHanaDataBackupFile>? Files
        // GraphQL -> files: [SapHanaDataBackupFile!] (type)
        [JsonProperty("files")]
        public List<SapHanaDataBackupFile>? Files { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaAppMetadata";
    }

    public SapHanaAppMetadata Set(
        System.Int64? BackupId = null,
        System.String? BackupPrefix = null,
        System.Int64? BaseBackupId = null,
        System.String? BaseFullSnapshotId = null,
        System.Boolean? IsExternalBackup = null,
        System.Boolean? IsRubrikTriggeredOnDemandBackup = null,
        DateTime? RubrikSnapshotEndTime = null,
        DateTime? RubrikSnapshotStartTime = null,
        DateTime? SapHanaEndTime = null,
        DateTime? SapHanaStartTime = null,
        System.String? SnapshotType = null,
        List<SapHanaDataBackupFile>? Files = null
    ) 
    {
        if ( BackupId != null ) {
            this.BackupId = BackupId;
        }
        if ( BackupPrefix != null ) {
            this.BackupPrefix = BackupPrefix;
        }
        if ( BaseBackupId != null ) {
            this.BaseBackupId = BaseBackupId;
        }
        if ( BaseFullSnapshotId != null ) {
            this.BaseFullSnapshotId = BaseFullSnapshotId;
        }
        if ( IsExternalBackup != null ) {
            this.IsExternalBackup = IsExternalBackup;
        }
        if ( IsRubrikTriggeredOnDemandBackup != null ) {
            this.IsRubrikTriggeredOnDemandBackup = IsRubrikTriggeredOnDemandBackup;
        }
        if ( RubrikSnapshotEndTime != null ) {
            this.RubrikSnapshotEndTime = RubrikSnapshotEndTime;
        }
        if ( RubrikSnapshotStartTime != null ) {
            this.RubrikSnapshotStartTime = RubrikSnapshotStartTime;
        }
        if ( SapHanaEndTime != null ) {
            this.SapHanaEndTime = SapHanaEndTime;
        }
        if ( SapHanaStartTime != null ) {
            this.SapHanaStartTime = SapHanaStartTime;
        }
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
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
        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        if (this.BackupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupId\n" ;
            } else {
                s += ind + "backupId\n" ;
            }
        }
        //      C# -> System.String? BackupPrefix
        // GraphQL -> backupPrefix: String (scalar)
        if (this.BackupPrefix != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupPrefix\n" ;
            } else {
                s += ind + "backupPrefix\n" ;
            }
        }
        //      C# -> System.Int64? BaseBackupId
        // GraphQL -> baseBackupId: Long (scalar)
        if (this.BaseBackupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "baseBackupId\n" ;
            } else {
                s += ind + "baseBackupId\n" ;
            }
        }
        //      C# -> System.String? BaseFullSnapshotId
        // GraphQL -> baseFullSnapshotId: String (scalar)
        if (this.BaseFullSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "baseFullSnapshotId\n" ;
            } else {
                s += ind + "baseFullSnapshotId\n" ;
            }
        }
        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean (scalar)
        if (this.IsExternalBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExternalBackup\n" ;
            } else {
                s += ind + "isExternalBackup\n" ;
            }
        }
        //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean (scalar)
        if (this.IsRubrikTriggeredOnDemandBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRubrikTriggeredOnDemandBackup\n" ;
            } else {
                s += ind + "isRubrikTriggeredOnDemandBackup\n" ;
            }
        }
        //      C# -> DateTime? RubrikSnapshotEndTime
        // GraphQL -> rubrikSnapshotEndTime: DateTime (scalar)
        if (this.RubrikSnapshotEndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rubrikSnapshotEndTime\n" ;
            } else {
                s += ind + "rubrikSnapshotEndTime\n" ;
            }
        }
        //      C# -> DateTime? RubrikSnapshotStartTime
        // GraphQL -> rubrikSnapshotStartTime: DateTime (scalar)
        if (this.RubrikSnapshotStartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rubrikSnapshotStartTime\n" ;
            } else {
                s += ind + "rubrikSnapshotStartTime\n" ;
            }
        }
        //      C# -> DateTime? SapHanaEndTime
        // GraphQL -> sapHanaEndTime: DateTime (scalar)
        if (this.SapHanaEndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sapHanaEndTime\n" ;
            } else {
                s += ind + "sapHanaEndTime\n" ;
            }
        }
        //      C# -> DateTime? SapHanaStartTime
        // GraphQL -> sapHanaStartTime: DateTime (scalar)
        if (this.SapHanaStartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sapHanaStartTime\n" ;
            } else {
                s += ind + "sapHanaStartTime\n" ;
            }
        }
        //      C# -> System.String? SnapshotType
        // GraphQL -> snapshotType: String (scalar)
        if (this.SnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotType\n" ;
            } else {
                s += ind + "snapshotType\n" ;
            }
        }
        //      C# -> List<SapHanaDataBackupFile>? Files
        // GraphQL -> files: [SapHanaDataBackupFile!] (type)
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
        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        if (ec.Includes("backupId",true))
        {
            if(this.BackupId == null) {

                this.BackupId = new System.Int64();

            } else {


            }
        }
        else if (this.BackupId != null && ec.Excludes("backupId",true))
        {
            this.BackupId = null;
        }
        //      C# -> System.String? BackupPrefix
        // GraphQL -> backupPrefix: String (scalar)
        if (ec.Includes("backupPrefix",true))
        {
            if(this.BackupPrefix == null) {

                this.BackupPrefix = "FETCH";

            } else {


            }
        }
        else if (this.BackupPrefix != null && ec.Excludes("backupPrefix",true))
        {
            this.BackupPrefix = null;
        }
        //      C# -> System.Int64? BaseBackupId
        // GraphQL -> baseBackupId: Long (scalar)
        if (ec.Includes("baseBackupId",true))
        {
            if(this.BaseBackupId == null) {

                this.BaseBackupId = new System.Int64();

            } else {


            }
        }
        else if (this.BaseBackupId != null && ec.Excludes("baseBackupId",true))
        {
            this.BaseBackupId = null;
        }
        //      C# -> System.String? BaseFullSnapshotId
        // GraphQL -> baseFullSnapshotId: String (scalar)
        if (ec.Includes("baseFullSnapshotId",true))
        {
            if(this.BaseFullSnapshotId == null) {

                this.BaseFullSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.BaseFullSnapshotId != null && ec.Excludes("baseFullSnapshotId",true))
        {
            this.BaseFullSnapshotId = null;
        }
        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean (scalar)
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
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean (scalar)
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
        //      C# -> DateTime? RubrikSnapshotEndTime
        // GraphQL -> rubrikSnapshotEndTime: DateTime (scalar)
        if (ec.Includes("rubrikSnapshotEndTime",true))
        {
            if(this.RubrikSnapshotEndTime == null) {

                this.RubrikSnapshotEndTime = new DateTime();

            } else {


            }
        }
        else if (this.RubrikSnapshotEndTime != null && ec.Excludes("rubrikSnapshotEndTime",true))
        {
            this.RubrikSnapshotEndTime = null;
        }
        //      C# -> DateTime? RubrikSnapshotStartTime
        // GraphQL -> rubrikSnapshotStartTime: DateTime (scalar)
        if (ec.Includes("rubrikSnapshotStartTime",true))
        {
            if(this.RubrikSnapshotStartTime == null) {

                this.RubrikSnapshotStartTime = new DateTime();

            } else {


            }
        }
        else if (this.RubrikSnapshotStartTime != null && ec.Excludes("rubrikSnapshotStartTime",true))
        {
            this.RubrikSnapshotStartTime = null;
        }
        //      C# -> DateTime? SapHanaEndTime
        // GraphQL -> sapHanaEndTime: DateTime (scalar)
        if (ec.Includes("sapHanaEndTime",true))
        {
            if(this.SapHanaEndTime == null) {

                this.SapHanaEndTime = new DateTime();

            } else {


            }
        }
        else if (this.SapHanaEndTime != null && ec.Excludes("sapHanaEndTime",true))
        {
            this.SapHanaEndTime = null;
        }
        //      C# -> DateTime? SapHanaStartTime
        // GraphQL -> sapHanaStartTime: DateTime (scalar)
        if (ec.Includes("sapHanaStartTime",true))
        {
            if(this.SapHanaStartTime == null) {

                this.SapHanaStartTime = new DateTime();

            } else {


            }
        }
        else if (this.SapHanaStartTime != null && ec.Excludes("sapHanaStartTime",true))
        {
            this.SapHanaStartTime = null;
        }
        //      C# -> System.String? SnapshotType
        // GraphQL -> snapshotType: String (scalar)
        if (ec.Includes("snapshotType",true))
        {
            if(this.SnapshotType == null) {

                this.SnapshotType = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotType != null && ec.Excludes("snapshotType",true))
        {
            this.SnapshotType = null;
        }
        //      C# -> List<SapHanaDataBackupFile>? Files
        // GraphQL -> files: [SapHanaDataBackupFile!] (type)
        if (ec.Includes("files",false))
        {
            if(this.Files == null) {

                this.Files = new List<SapHanaDataBackupFile>();
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

    } // class SapHanaAppMetadata
    
    #endregion

    public static class ListSapHanaAppMetadataExtensions
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
            this List<SapHanaAppMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SapHanaAppMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaAppMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaAppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types