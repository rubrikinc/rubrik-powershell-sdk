// ActiveDirectoryAppMetadata.cs
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
    #region ActiveDirectoryAppMetadata
    public class ActiveDirectoryAppMetadata: BaseType
    {
        #region members

        //      C# -> System.Int32? AttributeVersionNumberOpt
        // GraphQL -> attributeVersionNumberOpt: Int (scalar)
        [JsonProperty("attributeVersionNumberOpt")]
        public System.Int32? AttributeVersionNumberOpt { get; set; }

        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> System.String? ConfigDir
        // GraphQL -> configDir: String (scalar)
        [JsonProperty("configDir")]
        public System.String? ConfigDir { get; set; }

        //      C# -> System.String? FirmwareTypeOpt
        // GraphQL -> firmwareTypeOpt: String (scalar)
        [JsonProperty("firmwareTypeOpt")]
        public System.String? FirmwareTypeOpt { get; set; }

        //      C# -> System.Boolean? IsDataIntegrityPerformed
        // GraphQL -> isDataIntegrityPerformed: Boolean (scalar)
        [JsonProperty("isDataIntegrityPerformed")]
        public System.Boolean? IsDataIntegrityPerformed { get; set; }

        //      C# -> System.Boolean? IsHashRecalculatedOnCluster
        // GraphQL -> isHashRecalculatedOnCluster: Boolean (scalar)
        [JsonProperty("isHashRecalculatedOnCluster")]
        public System.Boolean? IsHashRecalculatedOnCluster { get; set; }

        //      C# -> System.Boolean? IsHashRecalculatedOnHost
        // GraphQL -> isHashRecalculatedOnHost: Boolean (scalar)
        [JsonProperty("isHashRecalculatedOnHost")]
        public System.Boolean? IsHashRecalculatedOnHost { get; set; }

        //      C# -> System.Boolean? IsUmdCreatedOpt
        // GraphQL -> isUmdCreatedOpt: Boolean! (scalar)
        [JsonProperty("isUmdCreatedOpt")]
        public System.Boolean? IsUmdCreatedOpt { get; set; }

        //      C# -> System.Boolean? IsUmdUploaded
        // GraphQL -> isUmdUploaded: Boolean (scalar)
        [JsonProperty("isUmdUploaded")]
        public System.Boolean? IsUmdUploaded { get; set; }

        //      C# -> System.String? NtdsDbDir
        // GraphQL -> ntdsDbDir: String (scalar)
        [JsonProperty("ntdsDbDir")]
        public System.String? NtdsDbDir { get; set; }

        //      C# -> System.String? NtdsLogDir
        // GraphQL -> ntdsLogDir: String (scalar)
        [JsonProperty("ntdsLogDir")]
        public System.String? NtdsLogDir { get; set; }

        //      C# -> System.Int64? NtdsPageSize
        // GraphQL -> ntdsPageSize: Long (scalar)
        [JsonProperty("ntdsPageSize")]
        public System.Int64? NtdsPageSize { get; set; }

        //      C# -> System.String? OsBuildVersionOpt
        // GraphQL -> osBuildVersionOpt: String (scalar)
        [JsonProperty("osBuildVersionOpt")]
        public System.String? OsBuildVersionOpt { get; set; }

        //      C# -> System.String? RubrikBackupServiceDataDirPath
        // GraphQL -> rubrikBackupServiceDataDirPath: String (scalar)
        [JsonProperty("rubrikBackupServiceDataDirPath")]
        public System.String? RubrikBackupServiceDataDirPath { get; set; }

        //      C# -> System.String? RubrikBackupServiceInstallPath
        // GraphQL -> rubrikBackupServiceInstallPath: String (scalar)
        [JsonProperty("rubrikBackupServiceInstallPath")]
        public System.String? RubrikBackupServiceInstallPath { get; set; }

        //      C# -> System.String? SysvolDir
        // GraphQL -> sysvolDir: String (scalar)
        [JsonProperty("sysvolDir")]
        public System.String? SysvolDir { get; set; }

        //      C# -> System.Boolean? TlsAtSnapshotOpt
        // GraphQL -> tlsAtSnapshotOpt: Boolean (scalar)
        [JsonProperty("tlsAtSnapshotOpt")]
        public System.Boolean? TlsAtSnapshotOpt { get; set; }

        //      C# -> System.String? UmdFilePath
        // GraphQL -> umdFilePath: String (scalar)
        [JsonProperty("umdFilePath")]
        public System.String? UmdFilePath { get; set; }

        //      C# -> System.String? VersionIdOpt
        // GraphQL -> versionIdOpt: String (scalar)
        [JsonProperty("versionIdOpt")]
        public System.String? VersionIdOpt { get; set; }

        //      C# -> DcMetadata? DcMetadataOpt
        // GraphQL -> dcMetadataOpt: DcMetadata (type)
        [JsonProperty("dcMetadataOpt")]
        public DcMetadata? DcMetadataOpt { get; set; }

        //      C# -> WindowsDiskLayoutDetails? DiskLayoutDetailsOpt
        // GraphQL -> diskLayoutDetailsOpt: WindowsDiskLayoutDetails (type)
        [JsonProperty("diskLayoutDetailsOpt")]
        public WindowsDiskLayoutDetails? DiskLayoutDetailsOpt { get; set; }

        //      C# -> NtdsDatabaseConsistency? NtdsDatabaseConsistencyOpt
        // GraphQL -> ntdsDatabaseConsistencyOpt: NtdsDatabaseConsistency (type)
        [JsonProperty("ntdsDatabaseConsistencyOpt")]
        public NtdsDatabaseConsistency? NtdsDatabaseConsistencyOpt { get; set; }

        //      C# -> ActiveDirectoryObjectsCount? ObjectsCount
        // GraphQL -> objectsCount: ActiveDirectoryObjectsCount (type)
        [JsonProperty("objectsCount")]
        public ActiveDirectoryObjectsCount? ObjectsCount { get; set; }

        //      C# -> OsDetails? OsDetailsOpt
        // GraphQL -> osDetailsOpt: OsDetails (type)
        [JsonProperty("osDetailsOpt")]
        public OsDetails? OsDetailsOpt { get; set; }

        //      C# -> ActiveDirectorySnapshotDebugInfo? SnapshotDebugInfo
        // GraphQL -> snapshotDebugInfo: ActiveDirectorySnapshotDebugInfo (type)
        [JsonProperty("snapshotDebugInfo")]
        public ActiveDirectorySnapshotDebugInfo? SnapshotDebugInfo { get; set; }

        //      C# -> ActiveDirectorySnapshotStats? Stats
        // GraphQL -> stats: ActiveDirectorySnapshotStats (type)
        [JsonProperty("stats")]
        public ActiveDirectorySnapshotStats? Stats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectoryAppMetadata";
    }

    public ActiveDirectoryAppMetadata Set(
        System.Int32? AttributeVersionNumberOpt = null,
        System.String? CdmVersion = null,
        System.String? ConfigDir = null,
        System.String? FirmwareTypeOpt = null,
        System.Boolean? IsDataIntegrityPerformed = null,
        System.Boolean? IsHashRecalculatedOnCluster = null,
        System.Boolean? IsHashRecalculatedOnHost = null,
        System.Boolean? IsUmdCreatedOpt = null,
        System.Boolean? IsUmdUploaded = null,
        System.String? NtdsDbDir = null,
        System.String? NtdsLogDir = null,
        System.Int64? NtdsPageSize = null,
        System.String? OsBuildVersionOpt = null,
        System.String? RubrikBackupServiceDataDirPath = null,
        System.String? RubrikBackupServiceInstallPath = null,
        System.String? SysvolDir = null,
        System.Boolean? TlsAtSnapshotOpt = null,
        System.String? UmdFilePath = null,
        System.String? VersionIdOpt = null,
        DcMetadata? DcMetadataOpt = null,
        WindowsDiskLayoutDetails? DiskLayoutDetailsOpt = null,
        NtdsDatabaseConsistency? NtdsDatabaseConsistencyOpt = null,
        ActiveDirectoryObjectsCount? ObjectsCount = null,
        OsDetails? OsDetailsOpt = null,
        ActiveDirectorySnapshotDebugInfo? SnapshotDebugInfo = null,
        ActiveDirectorySnapshotStats? Stats = null
    ) 
    {
        if ( AttributeVersionNumberOpt != null ) {
            this.AttributeVersionNumberOpt = AttributeVersionNumberOpt;
        }
        if ( CdmVersion != null ) {
            this.CdmVersion = CdmVersion;
        }
        if ( ConfigDir != null ) {
            this.ConfigDir = ConfigDir;
        }
        if ( FirmwareTypeOpt != null ) {
            this.FirmwareTypeOpt = FirmwareTypeOpt;
        }
        if ( IsDataIntegrityPerformed != null ) {
            this.IsDataIntegrityPerformed = IsDataIntegrityPerformed;
        }
        if ( IsHashRecalculatedOnCluster != null ) {
            this.IsHashRecalculatedOnCluster = IsHashRecalculatedOnCluster;
        }
        if ( IsHashRecalculatedOnHost != null ) {
            this.IsHashRecalculatedOnHost = IsHashRecalculatedOnHost;
        }
        if ( IsUmdCreatedOpt != null ) {
            this.IsUmdCreatedOpt = IsUmdCreatedOpt;
        }
        if ( IsUmdUploaded != null ) {
            this.IsUmdUploaded = IsUmdUploaded;
        }
        if ( NtdsDbDir != null ) {
            this.NtdsDbDir = NtdsDbDir;
        }
        if ( NtdsLogDir != null ) {
            this.NtdsLogDir = NtdsLogDir;
        }
        if ( NtdsPageSize != null ) {
            this.NtdsPageSize = NtdsPageSize;
        }
        if ( OsBuildVersionOpt != null ) {
            this.OsBuildVersionOpt = OsBuildVersionOpt;
        }
        if ( RubrikBackupServiceDataDirPath != null ) {
            this.RubrikBackupServiceDataDirPath = RubrikBackupServiceDataDirPath;
        }
        if ( RubrikBackupServiceInstallPath != null ) {
            this.RubrikBackupServiceInstallPath = RubrikBackupServiceInstallPath;
        }
        if ( SysvolDir != null ) {
            this.SysvolDir = SysvolDir;
        }
        if ( TlsAtSnapshotOpt != null ) {
            this.TlsAtSnapshotOpt = TlsAtSnapshotOpt;
        }
        if ( UmdFilePath != null ) {
            this.UmdFilePath = UmdFilePath;
        }
        if ( VersionIdOpt != null ) {
            this.VersionIdOpt = VersionIdOpt;
        }
        if ( DcMetadataOpt != null ) {
            this.DcMetadataOpt = DcMetadataOpt;
        }
        if ( DiskLayoutDetailsOpt != null ) {
            this.DiskLayoutDetailsOpt = DiskLayoutDetailsOpt;
        }
        if ( NtdsDatabaseConsistencyOpt != null ) {
            this.NtdsDatabaseConsistencyOpt = NtdsDatabaseConsistencyOpt;
        }
        if ( ObjectsCount != null ) {
            this.ObjectsCount = ObjectsCount;
        }
        if ( OsDetailsOpt != null ) {
            this.OsDetailsOpt = OsDetailsOpt;
        }
        if ( SnapshotDebugInfo != null ) {
            this.SnapshotDebugInfo = SnapshotDebugInfo;
        }
        if ( Stats != null ) {
            this.Stats = Stats;
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
        //      C# -> System.Int32? AttributeVersionNumberOpt
        // GraphQL -> attributeVersionNumberOpt: Int (scalar)
        if (this.AttributeVersionNumberOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attributeVersionNumberOpt\n" ;
            } else {
                s += ind + "attributeVersionNumberOpt\n" ;
            }
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmVersion\n" ;
            } else {
                s += ind + "cdmVersion\n" ;
            }
        }
        //      C# -> System.String? ConfigDir
        // GraphQL -> configDir: String (scalar)
        if (this.ConfigDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configDir\n" ;
            } else {
                s += ind + "configDir\n" ;
            }
        }
        //      C# -> System.String? FirmwareTypeOpt
        // GraphQL -> firmwareTypeOpt: String (scalar)
        if (this.FirmwareTypeOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firmwareTypeOpt\n" ;
            } else {
                s += ind + "firmwareTypeOpt\n" ;
            }
        }
        //      C# -> System.Boolean? IsDataIntegrityPerformed
        // GraphQL -> isDataIntegrityPerformed: Boolean (scalar)
        if (this.IsDataIntegrityPerformed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDataIntegrityPerformed\n" ;
            } else {
                s += ind + "isDataIntegrityPerformed\n" ;
            }
        }
        //      C# -> System.Boolean? IsHashRecalculatedOnCluster
        // GraphQL -> isHashRecalculatedOnCluster: Boolean (scalar)
        if (this.IsHashRecalculatedOnCluster != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHashRecalculatedOnCluster\n" ;
            } else {
                s += ind + "isHashRecalculatedOnCluster\n" ;
            }
        }
        //      C# -> System.Boolean? IsHashRecalculatedOnHost
        // GraphQL -> isHashRecalculatedOnHost: Boolean (scalar)
        if (this.IsHashRecalculatedOnHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHashRecalculatedOnHost\n" ;
            } else {
                s += ind + "isHashRecalculatedOnHost\n" ;
            }
        }
        //      C# -> System.Boolean? IsUmdCreatedOpt
        // GraphQL -> isUmdCreatedOpt: Boolean! (scalar)
        if (this.IsUmdCreatedOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUmdCreatedOpt\n" ;
            } else {
                s += ind + "isUmdCreatedOpt\n" ;
            }
        }
        //      C# -> System.Boolean? IsUmdUploaded
        // GraphQL -> isUmdUploaded: Boolean (scalar)
        if (this.IsUmdUploaded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUmdUploaded\n" ;
            } else {
                s += ind + "isUmdUploaded\n" ;
            }
        }
        //      C# -> System.String? NtdsDbDir
        // GraphQL -> ntdsDbDir: String (scalar)
        if (this.NtdsDbDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ntdsDbDir\n" ;
            } else {
                s += ind + "ntdsDbDir\n" ;
            }
        }
        //      C# -> System.String? NtdsLogDir
        // GraphQL -> ntdsLogDir: String (scalar)
        if (this.NtdsLogDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ntdsLogDir\n" ;
            } else {
                s += ind + "ntdsLogDir\n" ;
            }
        }
        //      C# -> System.Int64? NtdsPageSize
        // GraphQL -> ntdsPageSize: Long (scalar)
        if (this.NtdsPageSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ntdsPageSize\n" ;
            } else {
                s += ind + "ntdsPageSize\n" ;
            }
        }
        //      C# -> System.String? OsBuildVersionOpt
        // GraphQL -> osBuildVersionOpt: String (scalar)
        if (this.OsBuildVersionOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osBuildVersionOpt\n" ;
            } else {
                s += ind + "osBuildVersionOpt\n" ;
            }
        }
        //      C# -> System.String? RubrikBackupServiceDataDirPath
        // GraphQL -> rubrikBackupServiceDataDirPath: String (scalar)
        if (this.RubrikBackupServiceDataDirPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rubrikBackupServiceDataDirPath\n" ;
            } else {
                s += ind + "rubrikBackupServiceDataDirPath\n" ;
            }
        }
        //      C# -> System.String? RubrikBackupServiceInstallPath
        // GraphQL -> rubrikBackupServiceInstallPath: String (scalar)
        if (this.RubrikBackupServiceInstallPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rubrikBackupServiceInstallPath\n" ;
            } else {
                s += ind + "rubrikBackupServiceInstallPath\n" ;
            }
        }
        //      C# -> System.String? SysvolDir
        // GraphQL -> sysvolDir: String (scalar)
        if (this.SysvolDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sysvolDir\n" ;
            } else {
                s += ind + "sysvolDir\n" ;
            }
        }
        //      C# -> System.Boolean? TlsAtSnapshotOpt
        // GraphQL -> tlsAtSnapshotOpt: Boolean (scalar)
        if (this.TlsAtSnapshotOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tlsAtSnapshotOpt\n" ;
            } else {
                s += ind + "tlsAtSnapshotOpt\n" ;
            }
        }
        //      C# -> System.String? UmdFilePath
        // GraphQL -> umdFilePath: String (scalar)
        if (this.UmdFilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "umdFilePath\n" ;
            } else {
                s += ind + "umdFilePath\n" ;
            }
        }
        //      C# -> System.String? VersionIdOpt
        // GraphQL -> versionIdOpt: String (scalar)
        if (this.VersionIdOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versionIdOpt\n" ;
            } else {
                s += ind + "versionIdOpt\n" ;
            }
        }
        //      C# -> DcMetadata? DcMetadataOpt
        // GraphQL -> dcMetadataOpt: DcMetadata (type)
        if (this.DcMetadataOpt != null) {
            var fspec = this.DcMetadataOpt.AsFieldSpec(conf.Child("dcMetadataOpt"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dcMetadataOpt" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> WindowsDiskLayoutDetails? DiskLayoutDetailsOpt
        // GraphQL -> diskLayoutDetailsOpt: WindowsDiskLayoutDetails (type)
        if (this.DiskLayoutDetailsOpt != null) {
            var fspec = this.DiskLayoutDetailsOpt.AsFieldSpec(conf.Child("diskLayoutDetailsOpt"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "diskLayoutDetailsOpt" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NtdsDatabaseConsistency? NtdsDatabaseConsistencyOpt
        // GraphQL -> ntdsDatabaseConsistencyOpt: NtdsDatabaseConsistency (type)
        if (this.NtdsDatabaseConsistencyOpt != null) {
            var fspec = this.NtdsDatabaseConsistencyOpt.AsFieldSpec(conf.Child("ntdsDatabaseConsistencyOpt"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ntdsDatabaseConsistencyOpt" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActiveDirectoryObjectsCount? ObjectsCount
        // GraphQL -> objectsCount: ActiveDirectoryObjectsCount (type)
        if (this.ObjectsCount != null) {
            var fspec = this.ObjectsCount.AsFieldSpec(conf.Child("objectsCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectsCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OsDetails? OsDetailsOpt
        // GraphQL -> osDetailsOpt: OsDetails (type)
        if (this.OsDetailsOpt != null) {
            var fspec = this.OsDetailsOpt.AsFieldSpec(conf.Child("osDetailsOpt"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "osDetailsOpt" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActiveDirectorySnapshotDebugInfo? SnapshotDebugInfo
        // GraphQL -> snapshotDebugInfo: ActiveDirectorySnapshotDebugInfo (type)
        if (this.SnapshotDebugInfo != null) {
            var fspec = this.SnapshotDebugInfo.AsFieldSpec(conf.Child("snapshotDebugInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotDebugInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActiveDirectorySnapshotStats? Stats
        // GraphQL -> stats: ActiveDirectorySnapshotStats (type)
        if (this.Stats != null) {
            var fspec = this.Stats.AsFieldSpec(conf.Child("stats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "stats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? AttributeVersionNumberOpt
        // GraphQL -> attributeVersionNumberOpt: Int (scalar)
        if (ec.Includes("attributeVersionNumberOpt",true))
        {
            if(this.AttributeVersionNumberOpt == null) {

                this.AttributeVersionNumberOpt = Int32.MinValue;

            } else {


            }
        }
        else if (this.AttributeVersionNumberOpt != null && ec.Excludes("attributeVersionNumberOpt",true))
        {
            this.AttributeVersionNumberOpt = null;
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (ec.Includes("cdmVersion",true))
        {
            if(this.CdmVersion == null) {

                this.CdmVersion = "FETCH";

            } else {


            }
        }
        else if (this.CdmVersion != null && ec.Excludes("cdmVersion",true))
        {
            this.CdmVersion = null;
        }
        //      C# -> System.String? ConfigDir
        // GraphQL -> configDir: String (scalar)
        if (ec.Includes("configDir",true))
        {
            if(this.ConfigDir == null) {

                this.ConfigDir = "FETCH";

            } else {


            }
        }
        else if (this.ConfigDir != null && ec.Excludes("configDir",true))
        {
            this.ConfigDir = null;
        }
        //      C# -> System.String? FirmwareTypeOpt
        // GraphQL -> firmwareTypeOpt: String (scalar)
        if (ec.Includes("firmwareTypeOpt",true))
        {
            if(this.FirmwareTypeOpt == null) {

                this.FirmwareTypeOpt = "FETCH";

            } else {


            }
        }
        else if (this.FirmwareTypeOpt != null && ec.Excludes("firmwareTypeOpt",true))
        {
            this.FirmwareTypeOpt = null;
        }
        //      C# -> System.Boolean? IsDataIntegrityPerformed
        // GraphQL -> isDataIntegrityPerformed: Boolean (scalar)
        if (ec.Includes("isDataIntegrityPerformed",true))
        {
            if(this.IsDataIntegrityPerformed == null) {

                this.IsDataIntegrityPerformed = true;

            } else {


            }
        }
        else if (this.IsDataIntegrityPerformed != null && ec.Excludes("isDataIntegrityPerformed",true))
        {
            this.IsDataIntegrityPerformed = null;
        }
        //      C# -> System.Boolean? IsHashRecalculatedOnCluster
        // GraphQL -> isHashRecalculatedOnCluster: Boolean (scalar)
        if (ec.Includes("isHashRecalculatedOnCluster",true))
        {
            if(this.IsHashRecalculatedOnCluster == null) {

                this.IsHashRecalculatedOnCluster = true;

            } else {


            }
        }
        else if (this.IsHashRecalculatedOnCluster != null && ec.Excludes("isHashRecalculatedOnCluster",true))
        {
            this.IsHashRecalculatedOnCluster = null;
        }
        //      C# -> System.Boolean? IsHashRecalculatedOnHost
        // GraphQL -> isHashRecalculatedOnHost: Boolean (scalar)
        if (ec.Includes("isHashRecalculatedOnHost",true))
        {
            if(this.IsHashRecalculatedOnHost == null) {

                this.IsHashRecalculatedOnHost = true;

            } else {


            }
        }
        else if (this.IsHashRecalculatedOnHost != null && ec.Excludes("isHashRecalculatedOnHost",true))
        {
            this.IsHashRecalculatedOnHost = null;
        }
        //      C# -> System.Boolean? IsUmdCreatedOpt
        // GraphQL -> isUmdCreatedOpt: Boolean! (scalar)
        if (ec.Includes("isUmdCreatedOpt",true))
        {
            if(this.IsUmdCreatedOpt == null) {

                this.IsUmdCreatedOpt = true;

            } else {


            }
        }
        else if (this.IsUmdCreatedOpt != null && ec.Excludes("isUmdCreatedOpt",true))
        {
            this.IsUmdCreatedOpt = null;
        }
        //      C# -> System.Boolean? IsUmdUploaded
        // GraphQL -> isUmdUploaded: Boolean (scalar)
        if (ec.Includes("isUmdUploaded",true))
        {
            if(this.IsUmdUploaded == null) {

                this.IsUmdUploaded = true;

            } else {


            }
        }
        else if (this.IsUmdUploaded != null && ec.Excludes("isUmdUploaded",true))
        {
            this.IsUmdUploaded = null;
        }
        //      C# -> System.String? NtdsDbDir
        // GraphQL -> ntdsDbDir: String (scalar)
        if (ec.Includes("ntdsDbDir",true))
        {
            if(this.NtdsDbDir == null) {

                this.NtdsDbDir = "FETCH";

            } else {


            }
        }
        else if (this.NtdsDbDir != null && ec.Excludes("ntdsDbDir",true))
        {
            this.NtdsDbDir = null;
        }
        //      C# -> System.String? NtdsLogDir
        // GraphQL -> ntdsLogDir: String (scalar)
        if (ec.Includes("ntdsLogDir",true))
        {
            if(this.NtdsLogDir == null) {

                this.NtdsLogDir = "FETCH";

            } else {


            }
        }
        else if (this.NtdsLogDir != null && ec.Excludes("ntdsLogDir",true))
        {
            this.NtdsLogDir = null;
        }
        //      C# -> System.Int64? NtdsPageSize
        // GraphQL -> ntdsPageSize: Long (scalar)
        if (ec.Includes("ntdsPageSize",true))
        {
            if(this.NtdsPageSize == null) {

                this.NtdsPageSize = new System.Int64();

            } else {


            }
        }
        else if (this.NtdsPageSize != null && ec.Excludes("ntdsPageSize",true))
        {
            this.NtdsPageSize = null;
        }
        //      C# -> System.String? OsBuildVersionOpt
        // GraphQL -> osBuildVersionOpt: String (scalar)
        if (ec.Includes("osBuildVersionOpt",true))
        {
            if(this.OsBuildVersionOpt == null) {

                this.OsBuildVersionOpt = "FETCH";

            } else {


            }
        }
        else if (this.OsBuildVersionOpt != null && ec.Excludes("osBuildVersionOpt",true))
        {
            this.OsBuildVersionOpt = null;
        }
        //      C# -> System.String? RubrikBackupServiceDataDirPath
        // GraphQL -> rubrikBackupServiceDataDirPath: String (scalar)
        if (ec.Includes("rubrikBackupServiceDataDirPath",true))
        {
            if(this.RubrikBackupServiceDataDirPath == null) {

                this.RubrikBackupServiceDataDirPath = "FETCH";

            } else {


            }
        }
        else if (this.RubrikBackupServiceDataDirPath != null && ec.Excludes("rubrikBackupServiceDataDirPath",true))
        {
            this.RubrikBackupServiceDataDirPath = null;
        }
        //      C# -> System.String? RubrikBackupServiceInstallPath
        // GraphQL -> rubrikBackupServiceInstallPath: String (scalar)
        if (ec.Includes("rubrikBackupServiceInstallPath",true))
        {
            if(this.RubrikBackupServiceInstallPath == null) {

                this.RubrikBackupServiceInstallPath = "FETCH";

            } else {


            }
        }
        else if (this.RubrikBackupServiceInstallPath != null && ec.Excludes("rubrikBackupServiceInstallPath",true))
        {
            this.RubrikBackupServiceInstallPath = null;
        }
        //      C# -> System.String? SysvolDir
        // GraphQL -> sysvolDir: String (scalar)
        if (ec.Includes("sysvolDir",true))
        {
            if(this.SysvolDir == null) {

                this.SysvolDir = "FETCH";

            } else {


            }
        }
        else if (this.SysvolDir != null && ec.Excludes("sysvolDir",true))
        {
            this.SysvolDir = null;
        }
        //      C# -> System.Boolean? TlsAtSnapshotOpt
        // GraphQL -> tlsAtSnapshotOpt: Boolean (scalar)
        if (ec.Includes("tlsAtSnapshotOpt",true))
        {
            if(this.TlsAtSnapshotOpt == null) {

                this.TlsAtSnapshotOpt = true;

            } else {


            }
        }
        else if (this.TlsAtSnapshotOpt != null && ec.Excludes("tlsAtSnapshotOpt",true))
        {
            this.TlsAtSnapshotOpt = null;
        }
        //      C# -> System.String? UmdFilePath
        // GraphQL -> umdFilePath: String (scalar)
        if (ec.Includes("umdFilePath",true))
        {
            if(this.UmdFilePath == null) {

                this.UmdFilePath = "FETCH";

            } else {


            }
        }
        else if (this.UmdFilePath != null && ec.Excludes("umdFilePath",true))
        {
            this.UmdFilePath = null;
        }
        //      C# -> System.String? VersionIdOpt
        // GraphQL -> versionIdOpt: String (scalar)
        if (ec.Includes("versionIdOpt",true))
        {
            if(this.VersionIdOpt == null) {

                this.VersionIdOpt = "FETCH";

            } else {


            }
        }
        else if (this.VersionIdOpt != null && ec.Excludes("versionIdOpt",true))
        {
            this.VersionIdOpt = null;
        }
        //      C# -> DcMetadata? DcMetadataOpt
        // GraphQL -> dcMetadataOpt: DcMetadata (type)
        if (ec.Includes("dcMetadataOpt",false))
        {
            if(this.DcMetadataOpt == null) {

                this.DcMetadataOpt = new DcMetadata();
                this.DcMetadataOpt.ApplyExploratoryFieldSpec(ec.NewChild("dcMetadataOpt"));

            } else {

                this.DcMetadataOpt.ApplyExploratoryFieldSpec(ec.NewChild("dcMetadataOpt"));

            }
        }
        else if (this.DcMetadataOpt != null && ec.Excludes("dcMetadataOpt",false))
        {
            this.DcMetadataOpt = null;
        }
        //      C# -> WindowsDiskLayoutDetails? DiskLayoutDetailsOpt
        // GraphQL -> diskLayoutDetailsOpt: WindowsDiskLayoutDetails (type)
        if (ec.Includes("diskLayoutDetailsOpt",false))
        {
            if(this.DiskLayoutDetailsOpt == null) {

                this.DiskLayoutDetailsOpt = new WindowsDiskLayoutDetails();
                this.DiskLayoutDetailsOpt.ApplyExploratoryFieldSpec(ec.NewChild("diskLayoutDetailsOpt"));

            } else {

                this.DiskLayoutDetailsOpt.ApplyExploratoryFieldSpec(ec.NewChild("diskLayoutDetailsOpt"));

            }
        }
        else if (this.DiskLayoutDetailsOpt != null && ec.Excludes("diskLayoutDetailsOpt",false))
        {
            this.DiskLayoutDetailsOpt = null;
        }
        //      C# -> NtdsDatabaseConsistency? NtdsDatabaseConsistencyOpt
        // GraphQL -> ntdsDatabaseConsistencyOpt: NtdsDatabaseConsistency (type)
        if (ec.Includes("ntdsDatabaseConsistencyOpt",false))
        {
            if(this.NtdsDatabaseConsistencyOpt == null) {

                this.NtdsDatabaseConsistencyOpt = new NtdsDatabaseConsistency();
                this.NtdsDatabaseConsistencyOpt.ApplyExploratoryFieldSpec(ec.NewChild("ntdsDatabaseConsistencyOpt"));

            } else {

                this.NtdsDatabaseConsistencyOpt.ApplyExploratoryFieldSpec(ec.NewChild("ntdsDatabaseConsistencyOpt"));

            }
        }
        else if (this.NtdsDatabaseConsistencyOpt != null && ec.Excludes("ntdsDatabaseConsistencyOpt",false))
        {
            this.NtdsDatabaseConsistencyOpt = null;
        }
        //      C# -> ActiveDirectoryObjectsCount? ObjectsCount
        // GraphQL -> objectsCount: ActiveDirectoryObjectsCount (type)
        if (ec.Includes("objectsCount",false))
        {
            if(this.ObjectsCount == null) {

                this.ObjectsCount = new ActiveDirectoryObjectsCount();
                this.ObjectsCount.ApplyExploratoryFieldSpec(ec.NewChild("objectsCount"));

            } else {

                this.ObjectsCount.ApplyExploratoryFieldSpec(ec.NewChild("objectsCount"));

            }
        }
        else if (this.ObjectsCount != null && ec.Excludes("objectsCount",false))
        {
            this.ObjectsCount = null;
        }
        //      C# -> OsDetails? OsDetailsOpt
        // GraphQL -> osDetailsOpt: OsDetails (type)
        if (ec.Includes("osDetailsOpt",false))
        {
            if(this.OsDetailsOpt == null) {

                this.OsDetailsOpt = new OsDetails();
                this.OsDetailsOpt.ApplyExploratoryFieldSpec(ec.NewChild("osDetailsOpt"));

            } else {

                this.OsDetailsOpt.ApplyExploratoryFieldSpec(ec.NewChild("osDetailsOpt"));

            }
        }
        else if (this.OsDetailsOpt != null && ec.Excludes("osDetailsOpt",false))
        {
            this.OsDetailsOpt = null;
        }
        //      C# -> ActiveDirectorySnapshotDebugInfo? SnapshotDebugInfo
        // GraphQL -> snapshotDebugInfo: ActiveDirectorySnapshotDebugInfo (type)
        if (ec.Includes("snapshotDebugInfo",false))
        {
            if(this.SnapshotDebugInfo == null) {

                this.SnapshotDebugInfo = new ActiveDirectorySnapshotDebugInfo();
                this.SnapshotDebugInfo.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDebugInfo"));

            } else {

                this.SnapshotDebugInfo.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDebugInfo"));

            }
        }
        else if (this.SnapshotDebugInfo != null && ec.Excludes("snapshotDebugInfo",false))
        {
            this.SnapshotDebugInfo = null;
        }
        //      C# -> ActiveDirectorySnapshotStats? Stats
        // GraphQL -> stats: ActiveDirectorySnapshotStats (type)
        if (ec.Includes("stats",false))
        {
            if(this.Stats == null) {

                this.Stats = new ActiveDirectorySnapshotStats();
                this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));

            } else {

                this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));

            }
        }
        else if (this.Stats != null && ec.Excludes("stats",false))
        {
            this.Stats = null;
        }
    }


    #endregion

    } // class ActiveDirectoryAppMetadata
    
    #endregion

    public static class ListActiveDirectoryAppMetadataExtensions
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
            this List<ActiveDirectoryAppMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectoryAppMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryAppMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectoryAppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types