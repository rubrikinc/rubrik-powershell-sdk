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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long! (scalar)
        if (this.BackupFileSizeInBytes != null) {
            s += ind + "backupFileSizeInBytes\n" ;
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String! (scalar)
        if (this.DestinationPath != null) {
            s += ind + "destinationPath\n" ;
        }
        //      C# -> Db2WorkloadDataBackupFile? Db2BackupFile
        // GraphQL -> db2BackupFile: Db2WorkloadDataBackupFile! (type)
        if (this.Db2BackupFile != null) {
            var fspec = this.Db2BackupFile.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "db2BackupFile {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long! (scalar)
        if (this.BackupFileSizeInBytes == null && Exploration.Includes(parent + ".backupFileSizeInBytes", true))
        {
            this.BackupFileSizeInBytes = new System.Int64();
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String! (scalar)
        if (this.DestinationPath == null && Exploration.Includes(parent + ".destinationPath", true))
        {
            this.DestinationPath = "FETCH";
        }
        //      C# -> Db2WorkloadDataBackupFile? Db2BackupFile
        // GraphQL -> db2BackupFile: Db2WorkloadDataBackupFile! (type)
        if (this.Db2BackupFile == null && Exploration.Includes(parent + ".db2BackupFile"))
        {
            this.Db2BackupFile = new Db2WorkloadDataBackupFile();
            this.Db2BackupFile.ApplyExploratoryFieldSpec(parent + ".db2BackupFile");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2DataBackupFile> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2DataBackupFile());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types