// SapHanaLogBackup.cs
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
    #region SapHanaLogBackup
    public class SapHanaLogBackup: BaseType
    {
        #region members

        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        [JsonProperty("backupId")]
        public System.Int64? BackupId { get; set; }

        //      C# -> System.Int64? BytesTransferred
        // GraphQL -> bytesTransferred: Long (scalar)
        [JsonProperty("bytesTransferred")]
        public System.Int64? BytesTransferred { get; set; }

        //      C# -> System.Boolean? DoesContainCatalogFile
        // GraphQL -> doesContainCatalogFile: Boolean (scalar)
        [JsonProperty("doesContainCatalogFile")]
        public System.Boolean? DoesContainCatalogFile { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> List<SapHanaLogBackupFiles>? Files
        // GraphQL -> files: [SapHanaLogBackupFiles!] (type)
        [JsonProperty("files")]
        public List<SapHanaLogBackupFiles>? Files { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaLogBackup";
    }

    public SapHanaLogBackup Set(
        System.Int64? BackupId = null,
        System.Int64? BytesTransferred = null,
        System.Boolean? DoesContainCatalogFile = null,
        DateTime? EndTime = null,
        DateTime? StartTime = null,
        List<SapHanaLogBackupFiles>? Files = null
    ) 
    {
        if ( BackupId != null ) {
            this.BackupId = BackupId;
        }
        if ( BytesTransferred != null ) {
            this.BytesTransferred = BytesTransferred;
        }
        if ( DoesContainCatalogFile != null ) {
            this.DoesContainCatalogFile = DoesContainCatalogFile;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
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
        //      C# -> System.Int64? BytesTransferred
        // GraphQL -> bytesTransferred: Long (scalar)
        if (this.BytesTransferred != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesTransferred\n" ;
            } else {
                s += ind + "bytesTransferred\n" ;
            }
        }
        //      C# -> System.Boolean? DoesContainCatalogFile
        // GraphQL -> doesContainCatalogFile: Boolean (scalar)
        if (this.DoesContainCatalogFile != null) {
            if (conf.Flat) {
                s += conf.Prefix + "doesContainCatalogFile\n" ;
            } else {
                s += ind + "doesContainCatalogFile\n" ;
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
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> List<SapHanaLogBackupFiles>? Files
        // GraphQL -> files: [SapHanaLogBackupFiles!] (type)
        if (this.Files != null) {
            var fspec = this.Files.AsFieldSpec(conf.Child("files"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
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
        //      C# -> System.Int64? BytesTransferred
        // GraphQL -> bytesTransferred: Long (scalar)
        if (ec.Includes("bytesTransferred",true))
        {
            if(this.BytesTransferred == null) {

                this.BytesTransferred = new System.Int64();

            } else {


            }
        }
        else if (this.BytesTransferred != null && ec.Excludes("bytesTransferred",true))
        {
            this.BytesTransferred = null;
        }
        //      C# -> System.Boolean? DoesContainCatalogFile
        // GraphQL -> doesContainCatalogFile: Boolean (scalar)
        if (ec.Includes("doesContainCatalogFile",true))
        {
            if(this.DoesContainCatalogFile == null) {

                this.DoesContainCatalogFile = true;

            } else {


            }
        }
        else if (this.DoesContainCatalogFile != null && ec.Excludes("doesContainCatalogFile",true))
        {
            this.DoesContainCatalogFile = null;
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
        //      C# -> List<SapHanaLogBackupFiles>? Files
        // GraphQL -> files: [SapHanaLogBackupFiles!] (type)
        if (ec.Includes("files",false))
        {
            if(this.Files == null) {

                this.Files = new List<SapHanaLogBackupFiles>();
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

    } // class SapHanaLogBackup
    
    #endregion

    public static class ListSapHanaLogBackupExtensions
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
            this List<SapHanaLogBackup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SapHanaLogBackup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaLogBackup> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaLogBackup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaLogBackup> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types