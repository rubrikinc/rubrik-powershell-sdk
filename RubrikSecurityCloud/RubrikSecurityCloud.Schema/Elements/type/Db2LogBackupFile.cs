// Db2LogBackupFile.cs
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
    #region Db2LogBackupFile
    public class Db2LogBackupFile: BaseType
    {
        #region members

        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long (scalar)
        [JsonProperty("backupFileSizeInBytes")]
        public System.Int64? BackupFileSizeInBytes { get; set; }

        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        [JsonProperty("backupId")]
        public System.String? BackupId { get; set; }

        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        [JsonProperty("destinationPath")]
        public System.String? DestinationPath { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }


        #endregion

    #region methods

    public Db2LogBackupFile Set(
        System.Int64? BackupFileSizeInBytes = null,
        System.String? BackupId = null,
        System.String? DestinationPath = null,
        DateTime? EndTime = null
    ) 
    {
        if ( BackupFileSizeInBytes != null ) {
            this.BackupFileSizeInBytes = BackupFileSizeInBytes;
        }
        if ( BackupId != null ) {
            this.BackupId = BackupId;
        }
        if ( DestinationPath != null ) {
            this.DestinationPath = DestinationPath;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
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
        // GraphQL -> backupFileSizeInBytes: Long (scalar)
        if (this.BackupFileSizeInBytes != null) {
            s += ind + "backupFileSizeInBytes\n" ;
        }
        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        if (this.BackupId != null) {
            s += ind + "backupId\n" ;
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        if (this.DestinationPath != null) {
            s += ind + "destinationPath\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long (scalar)
        if (this.BackupFileSizeInBytes == null && Exploration.Includes(parent + ".backupFileSizeInBytes", true))
        {
            this.BackupFileSizeInBytes = new System.Int64();
        }
        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        if (this.BackupId == null && Exploration.Includes(parent + ".backupId", true))
        {
            this.BackupId = new System.String("FETCH");
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        if (this.DestinationPath == null && Exploration.Includes(parent + ".destinationPath", true))
        {
            this.DestinationPath = new System.String("FETCH");
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new DateTime();
        }
    }


    #endregion

    } // class Db2LogBackupFile
    
    #endregion

    public static class ListDb2LogBackupFileExtensions
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
            this List<Db2LogBackupFile> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2LogBackupFile> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2LogBackupFile());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types