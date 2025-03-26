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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ConfigProtectionStatus? ConfigProtectionStatus
        // GraphQL -> configProtectionStatus: ConfigProtectionStatus! (enum)
        if (this.ConfigProtectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configProtectionStatus\n" ;
            } else {
                s += ind + "configProtectionStatus\n" ;
            }
        }
        //      C# -> UploadLocationType? UploadLocation
        // GraphQL -> uploadLocation: UploadLocationType! (enum)
        if (this.UploadLocation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uploadLocation\n" ;
            } else {
                s += ind + "uploadLocation\n" ;
            }
        }
        //      C# -> System.String? CaCertUuid
        // GraphQL -> caCertUuid: UUID (scalar)
        if (this.CaCertUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caCertUuid\n" ;
            } else {
                s += ind + "caCertUuid\n" ;
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
        //      C# -> DateTime? LastSuccessfulBackupTime
        // GraphQL -> lastSuccessfulBackupTime: DateTime (scalar)
        if (this.LastSuccessfulBackupTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSuccessfulBackupTime\n" ;
            } else {
                s += ind + "lastSuccessfulBackupTime\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ConfigProtectionStatus? ConfigProtectionStatus
        // GraphQL -> configProtectionStatus: ConfigProtectionStatus! (enum)
        if (ec.Includes("configProtectionStatus",true))
        {
            if(this.ConfigProtectionStatus == null) {

                this.ConfigProtectionStatus = new ConfigProtectionStatus();

            } else {


            }
        }
        else if (this.ConfigProtectionStatus != null && ec.Excludes("configProtectionStatus",true))
        {
            this.ConfigProtectionStatus = null;
        }
        //      C# -> UploadLocationType? UploadLocation
        // GraphQL -> uploadLocation: UploadLocationType! (enum)
        if (ec.Includes("uploadLocation",true))
        {
            if(this.UploadLocation == null) {

                this.UploadLocation = new UploadLocationType();

            } else {


            }
        }
        else if (this.UploadLocation != null && ec.Excludes("uploadLocation",true))
        {
            this.UploadLocation = null;
        }
        //      C# -> System.String? CaCertUuid
        // GraphQL -> caCertUuid: UUID (scalar)
        if (ec.Includes("caCertUuid",true))
        {
            if(this.CaCertUuid == null) {

                this.CaCertUuid = "FETCH";

            } else {


            }
        }
        else if (this.CaCertUuid != null && ec.Excludes("caCertUuid",true))
        {
            this.CaCertUuid = null;
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
        //      C# -> DateTime? LastSuccessfulBackupTime
        // GraphQL -> lastSuccessfulBackupTime: DateTime (scalar)
        if (ec.Includes("lastSuccessfulBackupTime",true))
        {
            if(this.LastSuccessfulBackupTime == null) {

                this.LastSuccessfulBackupTime = new DateTime();

            } else {


            }
        }
        else if (this.LastSuccessfulBackupTime != null && ec.Excludes("lastSuccessfulBackupTime",true))
        {
            this.LastSuccessfulBackupTime = null;
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
    }


    #endregion

    } // class ConfigProtectionInfo
    
    #endregion

    public static class ListConfigProtectionInfoExtensions
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
            this List<ConfigProtectionInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigProtectionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigProtectionInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigProtectionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigProtectionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types