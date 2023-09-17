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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        if (this.BackupId != null) {
            s += ind + "backupId\n" ;
        }
        //      C# -> System.Int64? BytesTransferred
        // GraphQL -> bytesTransferred: Long (scalar)
        if (this.BytesTransferred != null) {
            s += ind + "bytesTransferred\n" ;
        }
        //      C# -> System.Boolean? DoesContainCatalogFile
        // GraphQL -> doesContainCatalogFile: Boolean (scalar)
        if (this.DoesContainCatalogFile != null) {
            s += ind + "doesContainCatalogFile\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> List<SapHanaLogBackupFiles>? Files
        // GraphQL -> files: [SapHanaLogBackupFiles!] (type)
        if (this.Files != null) {
            var fspec = this.Files.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "files {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        if (this.BackupId == null && ec.Includes("backupId",true))
        {
            this.BackupId = new System.Int64();
        }
        //      C# -> System.Int64? BytesTransferred
        // GraphQL -> bytesTransferred: Long (scalar)
        if (this.BytesTransferred == null && ec.Includes("bytesTransferred",true))
        {
            this.BytesTransferred = new System.Int64();
        }
        //      C# -> System.Boolean? DoesContainCatalogFile
        // GraphQL -> doesContainCatalogFile: Boolean (scalar)
        if (this.DoesContainCatalogFile == null && ec.Includes("doesContainCatalogFile",true))
        {
            this.DoesContainCatalogFile = true;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime == null && ec.Includes("endTime",true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime == null && ec.Includes("startTime",true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> List<SapHanaLogBackupFiles>? Files
        // GraphQL -> files: [SapHanaLogBackupFiles!] (type)
        if (this.Files == null && ec.Includes("files",false))
        {
            this.Files = new List<SapHanaLogBackupFiles>();
            this.Files.ApplyExploratoryFieldSpec(ec.NewChild("files"));
        }
    }


    #endregion

    } // class SapHanaLogBackup
    
    #endregion

    public static class ListSapHanaLogBackupExtensions
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
            this List<SapHanaLogBackup> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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