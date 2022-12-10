// MssqlBackup.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:30.
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
    #region MssqlBackup
    public class MssqlBackup: IFragment
    {
        #region members
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

        //      C# -> MssqlBackupType? BackupType
        // GraphQL -> backupType: MssqlBackupType! (enum)
        [JsonProperty("backupType")]
        public MssqlBackupType? BackupType { get; set; }

        #endregion

    #region methods

    public MssqlBackup Set(
        System.String? BackupId = null,
        System.Int64? BackupSize = null,
        DateTime? Date = null,
        System.String? Lsn = null,
        System.String? Path = null,
        System.String? RecoveryForkGuid = null,
        MssqlBackupType? BackupType = null
    ) 
    {
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
        if ( BackupType != null ) {
            this.BackupType = BackupType;
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
            //      C# -> System.String? BackupId
            // GraphQL -> backupId: String! (scalar)
            if (this.BackupId != null)
            {
                 s += ind + "backupId\n";

            }
            //      C# -> System.Int64? BackupSize
            // GraphQL -> backupSize: Long! (scalar)
            if (this.BackupSize != null)
            {
                 s += ind + "backupSize\n";

            }
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime (scalar)
            if (this.Date != null)
            {
                 s += ind + "date\n";

            }
            //      C# -> System.String? Lsn
            // GraphQL -> lsn: String! (scalar)
            if (this.Lsn != null)
            {
                 s += ind + "lsn\n";

            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path != null)
            {
                 s += ind + "path\n";

            }
            //      C# -> System.String? RecoveryForkGuid
            // GraphQL -> recoveryForkGuid: String! (scalar)
            if (this.RecoveryForkGuid != null)
            {
                 s += ind + "recoveryForkGuid\n";

            }
            //      C# -> MssqlBackupType? BackupType
            // GraphQL -> backupType: MssqlBackupType! (enum)
            if (this.BackupType != null)
            {
                 s += ind + "backupType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? BackupId
            // GraphQL -> backupId: String! (scalar)
            if (this.BackupId == null && Exploration.Includes(parent + ".backupId$"))
            {
                this.BackupId = new System.String("FETCH");
            }
            //      C# -> System.Int64? BackupSize
            // GraphQL -> backupSize: Long! (scalar)
            if (this.BackupSize == null && Exploration.Includes(parent + ".backupSize$"))
            {
                this.BackupSize = new System.Int64();
            }
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime (scalar)
            if (this.Date == null && Exploration.Includes(parent + ".date$"))
            {
                this.Date = new DateTime();
            }
            //      C# -> System.String? Lsn
            // GraphQL -> lsn: String! (scalar)
            if (this.Lsn == null && Exploration.Includes(parent + ".lsn$"))
            {
                this.Lsn = new System.String("FETCH");
            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path == null && Exploration.Includes(parent + ".path$"))
            {
                this.Path = new System.String("FETCH");
            }
            //      C# -> System.String? RecoveryForkGuid
            // GraphQL -> recoveryForkGuid: String! (scalar)
            if (this.RecoveryForkGuid == null && Exploration.Includes(parent + ".recoveryForkGuid$"))
            {
                this.RecoveryForkGuid = new System.String("FETCH");
            }
            //      C# -> MssqlBackupType? BackupType
            // GraphQL -> backupType: MssqlBackupType! (enum)
            if (this.BackupType == null && Exploration.Includes(parent + ".backupType$"))
            {
                this.BackupType = new MssqlBackupType();
            }
        }


    #endregion

    } // class MssqlBackup
    #endregion

    public static class ListMssqlBackupExtensions
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
            this List<MssqlBackup> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlBackup> list, 
            String parent = "")
        {
            var item = new MssqlBackup();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types