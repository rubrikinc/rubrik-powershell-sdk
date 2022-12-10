// SapHanaDataBackupFile.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:05.
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
    #region SapHanaDataBackupFile
    public class SapHanaDataBackupFile: IFragment
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

        //      C# -> System.String? ExternalBackupId
        // GraphQL -> externalBackupId: String! (scalar)
        [JsonProperty("externalBackupId")]
        public System.String? ExternalBackupId { get; set; }

        //      C# -> System.Int64? RedoLogPositionOpt
        // GraphQL -> redoLogPositionOpt: Long (scalar)
        [JsonProperty("redoLogPositionOpt")]
        public System.Int64? RedoLogPositionOpt { get; set; }

        //      C# -> System.String? ServiceType
        // GraphQL -> serviceType: String! (scalar)
        [JsonProperty("serviceType")]
        public System.String? ServiceType { get; set; }

        //      C# -> System.Int64? SourceId
        // GraphQL -> sourceId: Long! (scalar)
        [JsonProperty("sourceId")]
        public System.Int64? SourceId { get; set; }

        //      C# -> System.String? SourceType
        // GraphQL -> sourceType: String! (scalar)
        [JsonProperty("sourceType")]
        public System.String? SourceType { get; set; }

        #endregion

    #region methods

    public SapHanaDataBackupFile Set(
        System.Int64? BackupFileSizeInBytes = null,
        System.String? DestinationPath = null,
        System.String? ExternalBackupId = null,
        System.Int64? RedoLogPositionOpt = null,
        System.String? ServiceType = null,
        System.Int64? SourceId = null,
        System.String? SourceType = null
    ) 
    {
        if ( BackupFileSizeInBytes != null ) {
            this.BackupFileSizeInBytes = BackupFileSizeInBytes;
        }
        if ( DestinationPath != null ) {
            this.DestinationPath = DestinationPath;
        }
        if ( ExternalBackupId != null ) {
            this.ExternalBackupId = ExternalBackupId;
        }
        if ( RedoLogPositionOpt != null ) {
            this.RedoLogPositionOpt = RedoLogPositionOpt;
        }
        if ( ServiceType != null ) {
            this.ServiceType = ServiceType;
        }
        if ( SourceId != null ) {
            this.SourceId = SourceId;
        }
        if ( SourceType != null ) {
            this.SourceType = SourceType;
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
            //      C# -> System.String? ExternalBackupId
            // GraphQL -> externalBackupId: String! (scalar)
            if (this.ExternalBackupId != null)
            {
                 s += ind + "externalBackupId\n";

            }
            //      C# -> System.Int64? RedoLogPositionOpt
            // GraphQL -> redoLogPositionOpt: Long (scalar)
            if (this.RedoLogPositionOpt != null)
            {
                 s += ind + "redoLogPositionOpt\n";

            }
            //      C# -> System.String? ServiceType
            // GraphQL -> serviceType: String! (scalar)
            if (this.ServiceType != null)
            {
                 s += ind + "serviceType\n";

            }
            //      C# -> System.Int64? SourceId
            // GraphQL -> sourceId: Long! (scalar)
            if (this.SourceId != null)
            {
                 s += ind + "sourceId\n";

            }
            //      C# -> System.String? SourceType
            // GraphQL -> sourceType: String! (scalar)
            if (this.SourceType != null)
            {
                 s += ind + "sourceType\n";

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
            //      C# -> System.String? ExternalBackupId
            // GraphQL -> externalBackupId: String! (scalar)
            if (this.ExternalBackupId == null && Exploration.Includes(parent + ".externalBackupId$"))
            {
                this.ExternalBackupId = new System.String("FETCH");
            }
            //      C# -> System.Int64? RedoLogPositionOpt
            // GraphQL -> redoLogPositionOpt: Long (scalar)
            if (this.RedoLogPositionOpt == null && Exploration.Includes(parent + ".redoLogPositionOpt$"))
            {
                this.RedoLogPositionOpt = new System.Int64();
            }
            //      C# -> System.String? ServiceType
            // GraphQL -> serviceType: String! (scalar)
            if (this.ServiceType == null && Exploration.Includes(parent + ".serviceType$"))
            {
                this.ServiceType = new System.String("FETCH");
            }
            //      C# -> System.Int64? SourceId
            // GraphQL -> sourceId: Long! (scalar)
            if (this.SourceId == null && Exploration.Includes(parent + ".sourceId$"))
            {
                this.SourceId = new System.Int64();
            }
            //      C# -> System.String? SourceType
            // GraphQL -> sourceType: String! (scalar)
            if (this.SourceType == null && Exploration.Includes(parent + ".sourceType$"))
            {
                this.SourceType = new System.String("FETCH");
            }
        }


    #endregion

    } // class SapHanaDataBackupFile
    #endregion

    public static class ListSapHanaDataBackupFileExtensions
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
            this List<SapHanaDataBackupFile> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SapHanaDataBackupFile> list, 
            String parent = "")
        {
            var item = new SapHanaDataBackupFile();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types