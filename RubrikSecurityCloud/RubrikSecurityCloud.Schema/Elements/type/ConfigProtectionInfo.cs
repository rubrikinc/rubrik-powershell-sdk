// ConfigProtectionInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
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
    #region ConfigProtectionInfo
    public class ConfigProtectionInfo: IFragment
    {
        #region members
        //      C# -> System.String? CaCertUuid
        // GraphQL -> caCertUuid: UUID (scalar)
        [JsonProperty("caCertUuid")]
        public System.String? CaCertUuid { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? LastSuccessfulBackupTime
        // GraphQL -> lastSuccessfulBackupTime: DateTime (scalar)
        [JsonProperty("lastSuccessfulBackupTime")]
        public DateTime? LastSuccessfulBackupTime { get; set; }

        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        [JsonProperty("replicationTargetName")]
        public System.String? ReplicationTargetName { get; set; }

        //      C# -> ConfigProtectionStatus? ConfigProtectionStatus
        // GraphQL -> configProtectionStatus: ConfigProtectionStatus! (enum)
        [JsonProperty("configProtectionStatus")]
        public ConfigProtectionStatus? ConfigProtectionStatus { get; set; }

        //      C# -> UploadLocationType? UploadLocation
        // GraphQL -> uploadLocation: UploadLocationType! (enum)
        [JsonProperty("uploadLocation")]
        public UploadLocationType? UploadLocation { get; set; }

        #endregion

    #region methods

    public ConfigProtectionInfo Set(
        System.String? CaCertUuid = null,
        System.String? ClusterUuid = null,
        DateTime? LastSuccessfulBackupTime = null,
        System.String? ReplicationTargetName = null,
        ConfigProtectionStatus? ConfigProtectionStatus = null,
        UploadLocationType? UploadLocation = null
    ) 
    {
        if ( CaCertUuid != null ) {
            this.CaCertUuid = CaCertUuid;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( LastSuccessfulBackupTime != null ) {
            this.LastSuccessfulBackupTime = LastSuccessfulBackupTime;
        }
        if ( ReplicationTargetName != null ) {
            this.ReplicationTargetName = ReplicationTargetName;
        }
        if ( ConfigProtectionStatus != null ) {
            this.ConfigProtectionStatus = ConfigProtectionStatus;
        }
        if ( UploadLocation != null ) {
            this.UploadLocation = UploadLocation;
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
            //      C# -> System.String? CaCertUuid
            // GraphQL -> caCertUuid: UUID (scalar)
            if (this.CaCertUuid != null)
            {
                 s += ind + "caCertUuid\n";

            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> DateTime? LastSuccessfulBackupTime
            // GraphQL -> lastSuccessfulBackupTime: DateTime (scalar)
            if (this.LastSuccessfulBackupTime != null)
            {
                 s += ind + "lastSuccessfulBackupTime\n";

            }
            //      C# -> System.String? ReplicationTargetName
            // GraphQL -> replicationTargetName: String (scalar)
            if (this.ReplicationTargetName != null)
            {
                 s += ind + "replicationTargetName\n";

            }
            //      C# -> ConfigProtectionStatus? ConfigProtectionStatus
            // GraphQL -> configProtectionStatus: ConfigProtectionStatus! (enum)
            if (this.ConfigProtectionStatus != null)
            {
                 s += ind + "configProtectionStatus\n";

            }
            //      C# -> UploadLocationType? UploadLocation
            // GraphQL -> uploadLocation: UploadLocationType! (enum)
            if (this.UploadLocation != null)
            {
                 s += ind + "uploadLocation\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CaCertUuid
            // GraphQL -> caCertUuid: UUID (scalar)
            if (this.CaCertUuid == null && Exploration.Includes(parent + ".caCertUuid$"))
            {
                this.CaCertUuid = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> DateTime? LastSuccessfulBackupTime
            // GraphQL -> lastSuccessfulBackupTime: DateTime (scalar)
            if (this.LastSuccessfulBackupTime == null && Exploration.Includes(parent + ".lastSuccessfulBackupTime$"))
            {
                this.LastSuccessfulBackupTime = new DateTime();
            }
            //      C# -> System.String? ReplicationTargetName
            // GraphQL -> replicationTargetName: String (scalar)
            if (this.ReplicationTargetName == null && Exploration.Includes(parent + ".replicationTargetName$"))
            {
                this.ReplicationTargetName = new System.String("FETCH");
            }
            //      C# -> ConfigProtectionStatus? ConfigProtectionStatus
            // GraphQL -> configProtectionStatus: ConfigProtectionStatus! (enum)
            if (this.ConfigProtectionStatus == null && Exploration.Includes(parent + ".configProtectionStatus$"))
            {
                this.ConfigProtectionStatus = new ConfigProtectionStatus();
            }
            //      C# -> UploadLocationType? UploadLocation
            // GraphQL -> uploadLocation: UploadLocationType! (enum)
            if (this.UploadLocation == null && Exploration.Includes(parent + ".uploadLocation$"))
            {
                this.UploadLocation = new UploadLocationType();
            }
        }


    #endregion

    } // class ConfigProtectionInfo
    #endregion

    public static class ListConfigProtectionInfoExtensions
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
            this List<ConfigProtectionInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ConfigProtectionInfo> list, 
            String parent = "")
        {
            var item = new ConfigProtectionInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types