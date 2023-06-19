// ConfigProtectionBackups.cs
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
    #region ConfigProtectionBackups
    public class ConfigProtectionBackups: BaseType
    {
        #region members

        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType (enum)
        [JsonProperty("uploadLocationType")]
        public UploadLocationType? UploadLocationType { get; set; }

        //      C# -> System.String? BackupClusterVersion
        // GraphQL -> backupClusterVersion: String! (scalar)
        [JsonProperty("backupClusterVersion")]
        public System.String? BackupClusterVersion { get; set; }

        //      C# -> System.String? BackupFileName
        // GraphQL -> backupFileName: String! (scalar)
        [JsonProperty("backupFileName")]
        public System.String? BackupFileName { get; set; }

        //      C# -> System.Int64? BackupSizeInBytes
        // GraphQL -> backupSizeInBytes: Long! (scalar)
        [JsonProperty("backupSizeInBytes")]
        public System.Int64? BackupSizeInBytes { get; set; }

        //      C# -> DateTime? BackupTimestamp
        // GraphQL -> backupTimestamp: DateTime! (scalar)
        [JsonProperty("backupTimestamp")]
        public DateTime? BackupTimestamp { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        [JsonProperty("replicationTargetName")]
        public System.String? ReplicationTargetName { get; set; }

        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: String (scalar)
        [JsonProperty("replicationTargetUuid")]
        public System.String? ReplicationTargetUuid { get; set; }


        #endregion

    #region methods

    public ConfigProtectionBackups Set(
        UploadLocationType? UploadLocationType = null,
        System.String? BackupClusterVersion = null,
        System.String? BackupFileName = null,
        System.Int64? BackupSizeInBytes = null,
        DateTime? BackupTimestamp = null,
        System.String? ClusterName = null,
        System.String? ClusterUuid = null,
        System.String? ReplicationTargetName = null,
        System.String? ReplicationTargetUuid = null
    ) 
    {
        if ( UploadLocationType != null ) {
            this.UploadLocationType = UploadLocationType;
        }
        if ( BackupClusterVersion != null ) {
            this.BackupClusterVersion = BackupClusterVersion;
        }
        if ( BackupFileName != null ) {
            this.BackupFileName = BackupFileName;
        }
        if ( BackupSizeInBytes != null ) {
            this.BackupSizeInBytes = BackupSizeInBytes;
        }
        if ( BackupTimestamp != null ) {
            this.BackupTimestamp = BackupTimestamp;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( ReplicationTargetName != null ) {
            this.ReplicationTargetName = ReplicationTargetName;
        }
        if ( ReplicationTargetUuid != null ) {
            this.ReplicationTargetUuid = ReplicationTargetUuid;
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
        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType (enum)
        if (this.UploadLocationType != null) {
            s += ind + "uploadLocationType\n" ;
        }
        //      C# -> System.String? BackupClusterVersion
        // GraphQL -> backupClusterVersion: String! (scalar)
        if (this.BackupClusterVersion != null) {
            s += ind + "backupClusterVersion\n" ;
        }
        //      C# -> System.String? BackupFileName
        // GraphQL -> backupFileName: String! (scalar)
        if (this.BackupFileName != null) {
            s += ind + "backupFileName\n" ;
        }
        //      C# -> System.Int64? BackupSizeInBytes
        // GraphQL -> backupSizeInBytes: Long! (scalar)
        if (this.BackupSizeInBytes != null) {
            s += ind + "backupSizeInBytes\n" ;
        }
        //      C# -> DateTime? BackupTimestamp
        // GraphQL -> backupTimestamp: DateTime! (scalar)
        if (this.BackupTimestamp != null) {
            s += ind + "backupTimestamp\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        if (this.ReplicationTargetName != null) {
            s += ind + "replicationTargetName\n" ;
        }
        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: String (scalar)
        if (this.ReplicationTargetUuid != null) {
            s += ind + "replicationTargetUuid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType (enum)
        if (this.UploadLocationType == null && Exploration.Includes(parent + ".uploadLocationType", true))
        {
            this.UploadLocationType = new UploadLocationType();
        }
        //      C# -> System.String? BackupClusterVersion
        // GraphQL -> backupClusterVersion: String! (scalar)
        if (this.BackupClusterVersion == null && Exploration.Includes(parent + ".backupClusterVersion", true))
        {
            this.BackupClusterVersion = "FETCH";
        }
        //      C# -> System.String? BackupFileName
        // GraphQL -> backupFileName: String! (scalar)
        if (this.BackupFileName == null && Exploration.Includes(parent + ".backupFileName", true))
        {
            this.BackupFileName = "FETCH";
        }
        //      C# -> System.Int64? BackupSizeInBytes
        // GraphQL -> backupSizeInBytes: Long! (scalar)
        if (this.BackupSizeInBytes == null && Exploration.Includes(parent + ".backupSizeInBytes", true))
        {
            this.BackupSizeInBytes = new System.Int64();
        }
        //      C# -> DateTime? BackupTimestamp
        // GraphQL -> backupTimestamp: DateTime! (scalar)
        if (this.BackupTimestamp == null && Exploration.Includes(parent + ".backupTimestamp", true))
        {
            this.BackupTimestamp = new DateTime();
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        if (this.ReplicationTargetName == null && Exploration.Includes(parent + ".replicationTargetName", true))
        {
            this.ReplicationTargetName = "FETCH";
        }
        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: String (scalar)
        if (this.ReplicationTargetUuid == null && Exploration.Includes(parent + ".replicationTargetUuid", true))
        {
            this.ReplicationTargetUuid = "FETCH";
        }
    }


    #endregion

    } // class ConfigProtectionBackups
    
    #endregion

    public static class ListConfigProtectionBackupsExtensions
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
            this List<ConfigProtectionBackups> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ConfigProtectionBackups> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigProtectionBackups());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types