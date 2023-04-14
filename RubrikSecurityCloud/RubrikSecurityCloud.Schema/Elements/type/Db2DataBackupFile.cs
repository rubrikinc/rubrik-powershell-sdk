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

namespace Rubrik.SecurityCloud.Types
{
    #region Db2DataBackupFile
    public class Db2DataBackupFile: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int64? BackupFileSizeInBytes
            // GraphQL -> backupFileSizeInBytes: Long! (scalar)
            if (this.BackupFileSizeInBytes != null)
            {
                 s += ind + "backupFileSizeInBytes\n";

            }
            //      C# -> System.String? DestinationPath
            // GraphQL -> destinationPath: String! (scalar)
            if (this.DestinationPath != null)
            {
                 s += ind + "destinationPath\n";

            }
            //      C# -> Db2WorkloadDataBackupFile? Db2BackupFile
            // GraphQL -> db2BackupFile: Db2WorkloadDataBackupFile! (type)
            if (this.Db2BackupFile != null)
            {
                 s += ind + "db2BackupFile\n";

                 s += ind + "{\n" + 
                 this.Db2BackupFile.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? BackupFileSizeInBytes
            // GraphQL -> backupFileSizeInBytes: Long! (scalar)
            if (this.BackupFileSizeInBytes == null && Exploration.Includes(parent + ".backupFileSizeInBytes$"))
            {
                this.BackupFileSizeInBytes = new System.Int64();
            }
            //      C# -> System.String? DestinationPath
            // GraphQL -> destinationPath: String! (scalar)
            if (this.DestinationPath == null && Exploration.Includes(parent + ".destinationPath$"))
            {
                this.DestinationPath = new System.String("FETCH");
            }
            //      C# -> Db2WorkloadDataBackupFile? Db2BackupFile
            // GraphQL -> db2BackupFile: Db2WorkloadDataBackupFile! (type)
            if (this.Db2BackupFile == null && Exploration.Includes(parent + ".db2BackupFile"))
            {
                this.Db2BackupFile = new Db2WorkloadDataBackupFile();
                this.Db2BackupFile.ApplyExploratoryFragment(parent + ".db2BackupFile");
            }
        }


    #endregion

    } // class Db2DataBackupFile
    #endregion

    public static class ListDb2DataBackupFileExtensions
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
            this List<Db2DataBackupFile> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Db2DataBackupFile> list, 
            String parent = "")
        {
            var item = new Db2DataBackupFile();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types