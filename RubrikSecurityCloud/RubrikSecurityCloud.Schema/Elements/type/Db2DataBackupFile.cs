// Db2DataBackupFile.cs
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
    #region Db2DataBackupFile
    public class Db2DataBackupFile: BaseType
    {
        #region members

        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long! (scalar)
        [JsonProperty("backupFileSizeInBytes")]
        public System.Int64? BackupFileSizeInBytes { get; set; }

        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String! (scalar)
        [JsonProperty("destinationPath")]
        public System.String? DestinationPath { get; set; }

        //      C# -> Db2WorkloadDataBackupFile? Db2BackupFile
        // GraphQL -> db2BackupFile: Db2WorkloadDataBackupFile! (type)
        [JsonProperty("db2BackupFile")]
        public Db2WorkloadDataBackupFile? Db2BackupFile { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Db2DataBackupFile";
    }

    public Db2DataBackupFile Set(
        System.Int64? BackupFileSizeInBytes = null,
        System.String? DestinationPath = null,
        Db2WorkloadDataBackupFile? Db2BackupFile = null
    ) 
    {
        if ( BackupFileSizeInBytes != null ) {
            this.BackupFileSizeInBytes = BackupFileSizeInBytes;
        }
        if ( DestinationPath != null ) {
            this.DestinationPath = DestinationPath;
        }
        if ( Db2BackupFile != null ) {
            this.Db2BackupFile = Db2BackupFile;
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
        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long! (scalar)
        if (this.BackupFileSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupFileSizeInBytes\n" ;
            } else {
                s += ind + "backupFileSizeInBytes\n" ;
            }
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String! (scalar)
        if (this.DestinationPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "destinationPath\n" ;
            } else {
                s += ind + "destinationPath\n" ;
            }
        }
        //      C# -> Db2WorkloadDataBackupFile? Db2BackupFile
        // GraphQL -> db2BackupFile: Db2WorkloadDataBackupFile! (type)
        if (this.Db2BackupFile != null) {
            var fspec = this.Db2BackupFile.AsFieldSpec(conf.Child("db2BackupFile"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "db2BackupFile {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long! (scalar)
        if (ec.Includes("backupFileSizeInBytes",true))
        {
            if(this.BackupFileSizeInBytes == null) {

                this.BackupFileSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.BackupFileSizeInBytes != null && ec.Excludes("backupFileSizeInBytes",true))
        {
            this.BackupFileSizeInBytes = null;
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String! (scalar)
        if (ec.Includes("destinationPath",true))
        {
            if(this.DestinationPath == null) {

                this.DestinationPath = "FETCH";

            } else {


            }
        }
        else if (this.DestinationPath != null && ec.Excludes("destinationPath",true))
        {
            this.DestinationPath = null;
        }
        //      C# -> Db2WorkloadDataBackupFile? Db2BackupFile
        // GraphQL -> db2BackupFile: Db2WorkloadDataBackupFile! (type)
        if (ec.Includes("db2BackupFile",false))
        {
            if(this.Db2BackupFile == null) {

                this.Db2BackupFile = new Db2WorkloadDataBackupFile();
                this.Db2BackupFile.ApplyExploratoryFieldSpec(ec.NewChild("db2BackupFile"));

            } else {

                this.Db2BackupFile.ApplyExploratoryFieldSpec(ec.NewChild("db2BackupFile"));

            }
        }
        else if (this.Db2BackupFile != null && ec.Excludes("db2BackupFile",false))
        {
            this.Db2BackupFile = null;
        }
    }


    #endregion

    } // class Db2DataBackupFile
    
    #endregion

    public static class ListDb2DataBackupFileExtensions
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
            this List<Db2DataBackupFile> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<Db2DataBackupFile> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Db2DataBackupFile> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2DataBackupFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Db2DataBackupFile> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types