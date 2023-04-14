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

namespace Rubrik.SecurityCloud.Types
{
    #region Db2LogBackupFile
    public class Db2LogBackupFile: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int64? BackupFileSizeInBytes
            // GraphQL -> backupFileSizeInBytes: Long (scalar)
            if (this.BackupFileSizeInBytes != null)
            {
                 s += ind + "backupFileSizeInBytes\n";

            }
            //      C# -> System.String? BackupId
            // GraphQL -> backupId: String (scalar)
            if (this.BackupId != null)
            {
                 s += ind + "backupId\n";

            }
            //      C# -> System.String? DestinationPath
            // GraphQL -> destinationPath: String (scalar)
            if (this.DestinationPath != null)
            {
                 s += ind + "destinationPath\n";

            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? BackupFileSizeInBytes
            // GraphQL -> backupFileSizeInBytes: Long (scalar)
            if (this.BackupFileSizeInBytes == null && Exploration.Includes(parent + ".backupFileSizeInBytes$"))
            {
                this.BackupFileSizeInBytes = new System.Int64();
            }
            //      C# -> System.String? BackupId
            // GraphQL -> backupId: String (scalar)
            if (this.BackupId == null && Exploration.Includes(parent + ".backupId$"))
            {
                this.BackupId = new System.String("FETCH");
            }
            //      C# -> System.String? DestinationPath
            // GraphQL -> destinationPath: String (scalar)
            if (this.DestinationPath == null && Exploration.Includes(parent + ".destinationPath$"))
            {
                this.DestinationPath = new System.String("FETCH");
            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
        }


    #endregion

    } // class Db2LogBackupFile
    #endregion

    public static class ListDb2LogBackupFileExtensions
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
            this List<Db2LogBackupFile> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Db2LogBackupFile> list, 
            String parent = "")
        {
            var item = new Db2LogBackupFile();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types