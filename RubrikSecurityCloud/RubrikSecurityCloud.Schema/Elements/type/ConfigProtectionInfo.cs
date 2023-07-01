// ConfigProtectionInfo.cs
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
    #region ConfigProtectionInfo
    public class ConfigProtectionInfo: BaseType
    {
        #region members

        //      C# -> ConfigProtectionStatus? ConfigProtectionStatus
        // GraphQL -> configProtectionStatus: ConfigProtectionStatus! (enum)
        [JsonProperty("configProtectionStatus")]
        public ConfigProtectionStatus? ConfigProtectionStatus { get; set; }

        //      C# -> UploadLocationType? UploadLocation
        // GraphQL -> uploadLocation: UploadLocationType! (enum)
        [JsonProperty("uploadLocation")]
        public UploadLocationType? UploadLocation { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfigProtectionInfo";
    }

    public ConfigProtectionInfo Set(
        ConfigProtectionStatus? ConfigProtectionStatus = null,
        UploadLocationType? UploadLocation = null,
        System.String? CaCertUuid = null,
        System.String? ClusterUuid = null,
        DateTime? LastSuccessfulBackupTime = null,
        System.String? ReplicationTargetName = null
    ) 
    {
        if ( ConfigProtectionStatus != null ) {
            this.ConfigProtectionStatus = ConfigProtectionStatus;
        }
        if ( UploadLocation != null ) {
            this.UploadLocation = UploadLocation;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ConfigProtectionStatus? ConfigProtectionStatus
        // GraphQL -> configProtectionStatus: ConfigProtectionStatus! (enum)
        if (this.ConfigProtectionStatus != null) {
            s += ind + "configProtectionStatus\n" ;
        }
        //      C# -> UploadLocationType? UploadLocation
        // GraphQL -> uploadLocation: UploadLocationType! (enum)
        if (this.UploadLocation != null) {
            s += ind + "uploadLocation\n" ;
        }
        //      C# -> System.String? CaCertUuid
        // GraphQL -> caCertUuid: UUID (scalar)
        if (this.CaCertUuid != null) {
            s += ind + "caCertUuid\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> DateTime? LastSuccessfulBackupTime
        // GraphQL -> lastSuccessfulBackupTime: DateTime (scalar)
        if (this.LastSuccessfulBackupTime != null) {
            s += ind + "lastSuccessfulBackupTime\n" ;
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        if (this.ReplicationTargetName != null) {
            s += ind + "replicationTargetName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ConfigProtectionStatus? ConfigProtectionStatus
        // GraphQL -> configProtectionStatus: ConfigProtectionStatus! (enum)
        if (this.ConfigProtectionStatus == null && Exploration.Includes(parent + ".configProtectionStatus", true))
        {
            this.ConfigProtectionStatus = new ConfigProtectionStatus();
        }
        //      C# -> UploadLocationType? UploadLocation
        // GraphQL -> uploadLocation: UploadLocationType! (enum)
        if (this.UploadLocation == null && Exploration.Includes(parent + ".uploadLocation", true))
        {
            this.UploadLocation = new UploadLocationType();
        }
        //      C# -> System.String? CaCertUuid
        // GraphQL -> caCertUuid: UUID (scalar)
        if (this.CaCertUuid == null && Exploration.Includes(parent + ".caCertUuid", true))
        {
            this.CaCertUuid = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> DateTime? LastSuccessfulBackupTime
        // GraphQL -> lastSuccessfulBackupTime: DateTime (scalar)
        if (this.LastSuccessfulBackupTime == null && Exploration.Includes(parent + ".lastSuccessfulBackupTime", true))
        {
            this.LastSuccessfulBackupTime = new DateTime();
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        if (this.ReplicationTargetName == null && Exploration.Includes(parent + ".replicationTargetName", true))
        {
            this.ReplicationTargetName = "FETCH";
        }
    }


    #endregion

    } // class ConfigProtectionInfo
    
    #endregion

    public static class ListConfigProtectionInfoExtensions
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
            this List<ConfigProtectionInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ConfigProtectionInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigProtectionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types