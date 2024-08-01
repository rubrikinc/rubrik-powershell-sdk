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

    public override string GetGqlTypeName() {
        return "ConfigProtectionBackups";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType (enum)
        if (this.UploadLocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uploadLocationType\n" ;
            } else {
                s += ind + "uploadLocationType\n" ;
            }
        }
        //      C# -> System.String? BackupClusterVersion
        // GraphQL -> backupClusterVersion: String! (scalar)
        if (this.BackupClusterVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupClusterVersion\n" ;
            } else {
                s += ind + "backupClusterVersion\n" ;
            }
        }
        //      C# -> System.String? BackupFileName
        // GraphQL -> backupFileName: String! (scalar)
        if (this.BackupFileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupFileName\n" ;
            } else {
                s += ind + "backupFileName\n" ;
            }
        }
        //      C# -> System.Int64? BackupSizeInBytes
        // GraphQL -> backupSizeInBytes: Long! (scalar)
        if (this.BackupSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupSizeInBytes\n" ;
            } else {
                s += ind + "backupSizeInBytes\n" ;
            }
        }
        //      C# -> DateTime? BackupTimestamp
        // GraphQL -> backupTimestamp: DateTime! (scalar)
        if (this.BackupTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupTimestamp\n" ;
            } else {
                s += ind + "backupTimestamp\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        if (this.ReplicationTargetName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationTargetName\n" ;
            } else {
                s += ind + "replicationTargetName\n" ;
            }
        }
        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: String (scalar)
        if (this.ReplicationTargetUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationTargetUuid\n" ;
            } else {
                s += ind + "replicationTargetUuid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType (enum)
        if (ec.Includes("uploadLocationType",true))
        {
            if(this.UploadLocationType == null) {

                this.UploadLocationType = new UploadLocationType();

            } else {


            }
        }
        else if (this.UploadLocationType != null && ec.Excludes("uploadLocationType",true))
        {
            this.UploadLocationType = null;
        }
        //      C# -> System.String? BackupClusterVersion
        // GraphQL -> backupClusterVersion: String! (scalar)
        if (ec.Includes("backupClusterVersion",true))
        {
            if(this.BackupClusterVersion == null) {

                this.BackupClusterVersion = "FETCH";

            } else {


            }
        }
        else if (this.BackupClusterVersion != null && ec.Excludes("backupClusterVersion",true))
        {
            this.BackupClusterVersion = null;
        }
        //      C# -> System.String? BackupFileName
        // GraphQL -> backupFileName: String! (scalar)
        if (ec.Includes("backupFileName",true))
        {
            if(this.BackupFileName == null) {

                this.BackupFileName = "FETCH";

            } else {


            }
        }
        else if (this.BackupFileName != null && ec.Excludes("backupFileName",true))
        {
            this.BackupFileName = null;
        }
        //      C# -> System.Int64? BackupSizeInBytes
        // GraphQL -> backupSizeInBytes: Long! (scalar)
        if (ec.Includes("backupSizeInBytes",true))
        {
            if(this.BackupSizeInBytes == null) {

                this.BackupSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.BackupSizeInBytes != null && ec.Excludes("backupSizeInBytes",true))
        {
            this.BackupSizeInBytes = null;
        }
        //      C# -> DateTime? BackupTimestamp
        // GraphQL -> backupTimestamp: DateTime! (scalar)
        if (ec.Includes("backupTimestamp",true))
        {
            if(this.BackupTimestamp == null) {

                this.BackupTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.BackupTimestamp != null && ec.Excludes("backupTimestamp",true))
        {
            this.BackupTimestamp = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? ReplicationTargetName
        // GraphQL -> replicationTargetName: String (scalar)
        if (ec.Includes("replicationTargetName",true))
        {
            if(this.ReplicationTargetName == null) {

                this.ReplicationTargetName = "FETCH";

            } else {


            }
        }
        else if (this.ReplicationTargetName != null && ec.Excludes("replicationTargetName",true))
        {
            this.ReplicationTargetName = null;
        }
        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: String (scalar)
        if (ec.Includes("replicationTargetUuid",true))
        {
            if(this.ReplicationTargetUuid == null) {

                this.ReplicationTargetUuid = "FETCH";

            } else {


            }
        }
        else if (this.ReplicationTargetUuid != null && ec.Excludes("replicationTargetUuid",true))
        {
            this.ReplicationTargetUuid = null;
        }
    }


    #endregion

    } // class ConfigProtectionBackups
    
    #endregion

    public static class ListConfigProtectionBackupsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ConfigProtectionBackups> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigProtectionBackups> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigProtectionBackups> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigProtectionBackups());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigProtectionBackups> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types