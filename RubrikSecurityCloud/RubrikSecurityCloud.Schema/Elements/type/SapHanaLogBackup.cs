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

namespace Rubrik.SecurityCloud.Types
{
    #region SapHanaLogBackup
    public class SapHanaLogBackup: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int64? BackupId
            // GraphQL -> backupId: Long (scalar)
            if (this.BackupId != null)
            {
                 s += ind + "backupId\n";

            }
            //      C# -> System.Int64? BytesTransferred
            // GraphQL -> bytesTransferred: Long (scalar)
            if (this.BytesTransferred != null)
            {
                 s += ind + "bytesTransferred\n";

            }
            //      C# -> System.Boolean? DoesContainCatalogFile
            // GraphQL -> doesContainCatalogFile: Boolean (scalar)
            if (this.DoesContainCatalogFile != null)
            {
                 s += ind + "doesContainCatalogFile\n";

            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            //      C# -> List<SapHanaLogBackupFiles>? Files
            // GraphQL -> files: [SapHanaLogBackupFiles!] (type)
            if (this.Files != null)
            {
                 s += ind + "files\n";

                 s += ind + "{\n" + 
                 this.Files.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? BackupId
            // GraphQL -> backupId: Long (scalar)
            if (this.BackupId == null && Exploration.Includes(parent + ".backupId$"))
            {
                this.BackupId = new System.Int64();
            }
            //      C# -> System.Int64? BytesTransferred
            // GraphQL -> bytesTransferred: Long (scalar)
            if (this.BytesTransferred == null && Exploration.Includes(parent + ".bytesTransferred$"))
            {
                this.BytesTransferred = new System.Int64();
            }
            //      C# -> System.Boolean? DoesContainCatalogFile
            // GraphQL -> doesContainCatalogFile: Boolean (scalar)
            if (this.DoesContainCatalogFile == null && Exploration.Includes(parent + ".doesContainCatalogFile$"))
            {
                this.DoesContainCatalogFile = new System.Boolean();
            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new DateTime();
            }
            //      C# -> List<SapHanaLogBackupFiles>? Files
            // GraphQL -> files: [SapHanaLogBackupFiles!] (type)
            if (this.Files == null && Exploration.Includes(parent + ".files"))
            {
                this.Files = new List<SapHanaLogBackupFiles>();
                this.Files.ApplyExploratoryFragment(parent + ".files");
            }
        }


    #endregion

    } // class SapHanaLogBackup
    #endregion

    public static class ListSapHanaLogBackupExtensions
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
            this List<SapHanaLogBackup> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SapHanaLogBackup> list, 
            String parent = "")
        {
            var item = new SapHanaLogBackup();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types