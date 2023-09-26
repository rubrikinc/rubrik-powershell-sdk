// MssqlBackup.cs
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
    #region MssqlBackup
    public class MssqlBackup: BaseType
    {
        #region members

        //      C# -> MssqlBackupType? BackupType
        // GraphQL -> backupType: MssqlBackupType! (enum)
        [JsonProperty("backupType")]
        public MssqlBackupType? BackupType { get; set; }

        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String! (scalar)
        [JsonProperty("backupId")]
        public System.String? BackupId { get; set; }

        //      C# -> System.Int64? BackupSize
        // GraphQL -> backupSize: Long! (scalar)
        [JsonProperty("backupSize")]
        public System.Int64? BackupSize { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.String? Lsn
        // GraphQL -> lsn: String! (scalar)
        [JsonProperty("lsn")]
        public System.String? Lsn { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String! (scalar)
        [JsonProperty("recoveryForkGuid")]
        public System.String? RecoveryForkGuid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlBackup";
    }

    public MssqlBackup Set(
        MssqlBackupType? BackupType = null,
        System.String? BackupId = null,
        System.Int64? BackupSize = null,
        DateTime? Date = null,
        System.String? Lsn = null,
        System.String? Path = null,
        System.String? RecoveryForkGuid = null
    ) 
    {
        if ( BackupType != null ) {
            this.BackupType = BackupType;
        }
        if ( BackupId != null ) {
            this.BackupId = BackupId;
        }
        if ( BackupSize != null ) {
            this.BackupSize = BackupSize;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Lsn != null ) {
            this.Lsn = Lsn;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( RecoveryForkGuid != null ) {
            this.RecoveryForkGuid = RecoveryForkGuid;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> MssqlBackupType? BackupType
        // GraphQL -> backupType: MssqlBackupType! (enum)
        if (this.BackupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupType\n" ;
            } else {
                s += ind + "backupType\n" ;
            }
        }
        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String! (scalar)
        if (this.BackupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupId\n" ;
            } else {
                s += ind + "backupId\n" ;
            }
        }
        //      C# -> System.Int64? BackupSize
        // GraphQL -> backupSize: Long! (scalar)
        if (this.BackupSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupSize\n" ;
            } else {
                s += ind + "backupSize\n" ;
            }
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
            }
        }
        //      C# -> System.String? Lsn
        // GraphQL -> lsn: String! (scalar)
        if (this.Lsn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lsn\n" ;
            } else {
                s += ind + "lsn\n" ;
            }
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String! (scalar)
        if (this.RecoveryForkGuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryForkGuid\n" ;
            } else {
                s += ind + "recoveryForkGuid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MssqlBackupType? BackupType
        // GraphQL -> backupType: MssqlBackupType! (enum)
        if (ec.Includes("backupType",true))
        {
            if(this.BackupType == null) {

                this.BackupType = new MssqlBackupType();

            } else {


            }
        }
        else if (this.BackupType != null && ec.Excludes("backupType",true))
        {
            this.BackupType = null;
        }
        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String! (scalar)
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
        //      C# -> System.Int64? BackupSize
        // GraphQL -> backupSize: Long! (scalar)
        if (ec.Includes("backupSize",true))
        {
            if(this.BackupSize == null) {

                this.BackupSize = new System.Int64();

            } else {


            }
        }
        else if (this.BackupSize != null && ec.Excludes("backupSize",true))
        {
            this.BackupSize = null;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (ec.Includes("date",true))
        {
            if(this.Date == null) {

                this.Date = new DateTime();

            } else {


            }
        }
        else if (this.Date != null && ec.Excludes("date",true))
        {
            this.Date = null;
        }
        //      C# -> System.String? Lsn
        // GraphQL -> lsn: String! (scalar)
        if (ec.Includes("lsn",true))
        {
            if(this.Lsn == null) {

                this.Lsn = "FETCH";

            } else {


            }
        }
        else if (this.Lsn != null && ec.Excludes("lsn",true))
        {
            this.Lsn = null;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String! (scalar)
        if (ec.Includes("recoveryForkGuid",true))
        {
            if(this.RecoveryForkGuid == null) {

                this.RecoveryForkGuid = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryForkGuid != null && ec.Excludes("recoveryForkGuid",true))
        {
            this.RecoveryForkGuid = null;
        }
    }


    #endregion

    } // class MssqlBackup
    
    #endregion

    public static class ListMssqlBackupExtensions
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
            this List<MssqlBackup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlBackup> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlBackup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlBackup> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types