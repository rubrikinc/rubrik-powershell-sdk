// MssqlDbDetail.cs
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
    #region MssqlDbDetail
    public class MssqlDbDetail: BaseType
    {
        #region members

        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        [JsonProperty("archiveStorage")]
        public System.Int64? ArchiveStorage { get; set; }

        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        [JsonProperty("isLocal")]
        public System.Boolean? IsLocal { get; set; }

        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean (scalar)
        [JsonProperty("isStandby")]
        public System.Boolean? IsStandby { get; set; }

        //      C# -> System.String? LatestRecoveryPointV50
        // GraphQL -> latestRecoveryPointV50: String (scalar)
        [JsonProperty("latestRecoveryPointV50")]
        public System.String? LatestRecoveryPointV50 { get; set; }

        //      C# -> System.String? LatestRecoveryPointV51
        // GraphQL -> latestRecoveryPointV51: String (scalar)
        [JsonProperty("latestRecoveryPointV51")]
        public System.String? LatestRecoveryPointV51 { get; set; }

        //      C# -> System.String? LatestRecoveryPointV52
        // GraphQL -> latestRecoveryPointV52: String (scalar)
        [JsonProperty("latestRecoveryPointV52")]
        public System.String? LatestRecoveryPointV52 { get; set; }

        //      C# -> System.String? LatestRecoveryPointV53
        // GraphQL -> latestRecoveryPointV53: String (scalar)
        [JsonProperty("latestRecoveryPointV53")]
        public System.String? LatestRecoveryPointV53 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV60
        // GraphQL -> latestRecoveryPointV60: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV60")]
        public DateTime? LatestRecoveryPointV60 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV70
        // GraphQL -> latestRecoveryPointV70: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV70")]
        public DateTime? LatestRecoveryPointV70 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV80
        // GraphQL -> latestRecoveryPointV80: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV80")]
        public DateTime? LatestRecoveryPointV80 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV81
        // GraphQL -> latestRecoveryPointV81: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV81")]
        public DateTime? LatestRecoveryPointV81 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV90
        // GraphQL -> latestRecoveryPointV90: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV90")]
        public DateTime? LatestRecoveryPointV90 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV91
        // GraphQL -> latestRecoveryPointV91: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV91")]
        public DateTime? LatestRecoveryPointV91 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV92
        // GraphQL -> latestRecoveryPointV92: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV92")]
        public DateTime? LatestRecoveryPointV92 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV93
        // GraphQL -> latestRecoveryPointV93: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV93")]
        public DateTime? LatestRecoveryPointV93 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV94
        // GraphQL -> latestRecoveryPointV94: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV94")]
        public DateTime? LatestRecoveryPointV94 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV95
        // GraphQL -> latestRecoveryPointV95: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV95")]
        public DateTime? LatestRecoveryPointV95 { get; set; }

        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        [JsonProperty("localStorage")]
        public System.Int64? LocalStorage { get; set; }

        //      C# -> System.Int32? MaxDataStreams
        // GraphQL -> maxDataStreams: Int (scalar)
        [JsonProperty("maxDataStreams")]
        public System.Int32? MaxDataStreams { get; set; }

        //      C# -> System.String? OldestRecoveryPointV50
        // GraphQL -> oldestRecoveryPointV50: String (scalar)
        [JsonProperty("oldestRecoveryPointV50")]
        public System.String? OldestRecoveryPointV50 { get; set; }

        //      C# -> System.String? OldestRecoveryPointV51
        // GraphQL -> oldestRecoveryPointV51: String (scalar)
        [JsonProperty("oldestRecoveryPointV51")]
        public System.String? OldestRecoveryPointV51 { get; set; }

        //      C# -> System.String? OldestRecoveryPointV52
        // GraphQL -> oldestRecoveryPointV52: String (scalar)
        [JsonProperty("oldestRecoveryPointV52")]
        public System.String? OldestRecoveryPointV52 { get; set; }

        //      C# -> System.String? OldestRecoveryPointV53
        // GraphQL -> oldestRecoveryPointV53: String (scalar)
        [JsonProperty("oldestRecoveryPointV53")]
        public System.String? OldestRecoveryPointV53 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV60
        // GraphQL -> oldestRecoveryPointV60: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV60")]
        public DateTime? OldestRecoveryPointV60 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV70
        // GraphQL -> oldestRecoveryPointV70: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV70")]
        public DateTime? OldestRecoveryPointV70 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV80
        // GraphQL -> oldestRecoveryPointV80: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV80")]
        public DateTime? OldestRecoveryPointV80 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV81
        // GraphQL -> oldestRecoveryPointV81: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV81")]
        public DateTime? OldestRecoveryPointV81 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV90
        // GraphQL -> oldestRecoveryPointV90: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV90")]
        public DateTime? OldestRecoveryPointV90 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV91
        // GraphQL -> oldestRecoveryPointV91: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV91")]
        public DateTime? OldestRecoveryPointV91 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV92
        // GraphQL -> oldestRecoveryPointV92: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV92")]
        public DateTime? OldestRecoveryPointV92 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV93
        // GraphQL -> oldestRecoveryPointV93: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV93")]
        public DateTime? OldestRecoveryPointV93 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV94
        // GraphQL -> oldestRecoveryPointV94: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV94")]
        public DateTime? OldestRecoveryPointV94 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV95
        // GraphQL -> oldestRecoveryPointV95: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV95")]
        public DateTime? OldestRecoveryPointV95 { get; set; }

        //      C# -> System.String? ProtectionDateV50
        // GraphQL -> protectionDateV50: String (scalar)
        [JsonProperty("protectionDateV50")]
        public System.String? ProtectionDateV50 { get; set; }

        //      C# -> System.String? ProtectionDateV51
        // GraphQL -> protectionDateV51: String (scalar)
        [JsonProperty("protectionDateV51")]
        public System.String? ProtectionDateV51 { get; set; }

        //      C# -> System.String? ProtectionDateV52
        // GraphQL -> protectionDateV52: String (scalar)
        [JsonProperty("protectionDateV52")]
        public System.String? ProtectionDateV52 { get; set; }

        //      C# -> System.String? ProtectionDateV53
        // GraphQL -> protectionDateV53: String (scalar)
        [JsonProperty("protectionDateV53")]
        public System.String? ProtectionDateV53 { get; set; }

        //      C# -> DateTime? ProtectionDateV60
        // GraphQL -> protectionDateV60: DateTime (scalar)
        [JsonProperty("protectionDateV60")]
        public DateTime? ProtectionDateV60 { get; set; }

        //      C# -> DateTime? ProtectionDateV70
        // GraphQL -> protectionDateV70: DateTime (scalar)
        [JsonProperty("protectionDateV70")]
        public DateTime? ProtectionDateV70 { get; set; }

        //      C# -> DateTime? ProtectionDateV80
        // GraphQL -> protectionDateV80: DateTime (scalar)
        [JsonProperty("protectionDateV80")]
        public DateTime? ProtectionDateV80 { get; set; }

        //      C# -> DateTime? ProtectionDateV81
        // GraphQL -> protectionDateV81: DateTime (scalar)
        [JsonProperty("protectionDateV81")]
        public DateTime? ProtectionDateV81 { get; set; }

        //      C# -> DateTime? ProtectionDateV90
        // GraphQL -> protectionDateV90: DateTime (scalar)
        [JsonProperty("protectionDateV90")]
        public DateTime? ProtectionDateV90 { get; set; }

        //      C# -> DateTime? ProtectionDateV91
        // GraphQL -> protectionDateV91: DateTime (scalar)
        [JsonProperty("protectionDateV91")]
        public DateTime? ProtectionDateV91 { get; set; }

        //      C# -> DateTime? ProtectionDateV92
        // GraphQL -> protectionDateV92: DateTime (scalar)
        [JsonProperty("protectionDateV92")]
        public DateTime? ProtectionDateV92 { get; set; }

        //      C# -> DateTime? ProtectionDateV93
        // GraphQL -> protectionDateV93: DateTime (scalar)
        [JsonProperty("protectionDateV93")]
        public DateTime? ProtectionDateV93 { get; set; }

        //      C# -> DateTime? ProtectionDateV94
        // GraphQL -> protectionDateV94: DateTime (scalar)
        [JsonProperty("protectionDateV94")]
        public DateTime? ProtectionDateV94 { get; set; }

        //      C# -> DateTime? ProtectionDateV95
        // GraphQL -> protectionDateV95: DateTime (scalar)
        [JsonProperty("protectionDateV95")]
        public DateTime? ProtectionDateV95 { get; set; }

        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        [JsonProperty("recoveryForkGuid")]
        public System.String? RecoveryForkGuid { get; set; }

        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int32? SnapshotCount { get; set; }

        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        [JsonProperty("blackoutWindowResponseInfo")]
        public BlackoutWindowResponseInfo? BlackoutWindowResponseInfo { get; set; }

        //      C# -> MssqlDbSummary? MssqlDbSummary
        // GraphQL -> mssqlDbSummary: MssqlDbSummary (type)
        [JsonProperty("mssqlDbSummary")]
        public MssqlDbSummary? MssqlDbSummary { get; set; }

        //      C# -> MssqlScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: MssqlScriptDetail (type)
        [JsonProperty("postBackupScript")]
        public MssqlScriptDetail? PostBackupScript { get; set; }

        //      C# -> MssqlScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: MssqlScriptDetail (type)
        [JsonProperty("preBackupScript")]
        public MssqlScriptDetail? PreBackupScript { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlDbDetail";
    }

    public MssqlDbDetail Set(
        System.Int64? ArchiveStorage = null,
        System.Boolean? IsLocal = null,
        System.Boolean? IsStandby = null,
        System.String? LatestRecoveryPointV50 = null,
        System.String? LatestRecoveryPointV51 = null,
        System.String? LatestRecoveryPointV52 = null,
        System.String? LatestRecoveryPointV53 = null,
        DateTime? LatestRecoveryPointV60 = null,
        DateTime? LatestRecoveryPointV70 = null,
        DateTime? LatestRecoveryPointV80 = null,
        DateTime? LatestRecoveryPointV81 = null,
        DateTime? LatestRecoveryPointV90 = null,
        DateTime? LatestRecoveryPointV91 = null,
        DateTime? LatestRecoveryPointV92 = null,
        DateTime? LatestRecoveryPointV93 = null,
        DateTime? LatestRecoveryPointV94 = null,
        DateTime? LatestRecoveryPointV95 = null,
        System.Int64? LocalStorage = null,
        System.Int32? MaxDataStreams = null,
        System.String? OldestRecoveryPointV50 = null,
        System.String? OldestRecoveryPointV51 = null,
        System.String? OldestRecoveryPointV52 = null,
        System.String? OldestRecoveryPointV53 = null,
        DateTime? OldestRecoveryPointV60 = null,
        DateTime? OldestRecoveryPointV70 = null,
        DateTime? OldestRecoveryPointV80 = null,
        DateTime? OldestRecoveryPointV81 = null,
        DateTime? OldestRecoveryPointV90 = null,
        DateTime? OldestRecoveryPointV91 = null,
        DateTime? OldestRecoveryPointV92 = null,
        DateTime? OldestRecoveryPointV93 = null,
        DateTime? OldestRecoveryPointV94 = null,
        DateTime? OldestRecoveryPointV95 = null,
        System.String? ProtectionDateV50 = null,
        System.String? ProtectionDateV51 = null,
        System.String? ProtectionDateV52 = null,
        System.String? ProtectionDateV53 = null,
        DateTime? ProtectionDateV60 = null,
        DateTime? ProtectionDateV70 = null,
        DateTime? ProtectionDateV80 = null,
        DateTime? ProtectionDateV81 = null,
        DateTime? ProtectionDateV90 = null,
        DateTime? ProtectionDateV91 = null,
        DateTime? ProtectionDateV92 = null,
        DateTime? ProtectionDateV93 = null,
        DateTime? ProtectionDateV94 = null,
        DateTime? ProtectionDateV95 = null,
        System.String? RecoveryForkGuid = null,
        System.Int32? SnapshotCount = null,
        BlackoutWindowResponseInfo? BlackoutWindowResponseInfo = null,
        MssqlDbSummary? MssqlDbSummary = null,
        MssqlScriptDetail? PostBackupScript = null,
        MssqlScriptDetail? PreBackupScript = null
    ) 
    {
        if ( ArchiveStorage != null ) {
            this.ArchiveStorage = ArchiveStorage;
        }
        if ( IsLocal != null ) {
            this.IsLocal = IsLocal;
        }
        if ( IsStandby != null ) {
            this.IsStandby = IsStandby;
        }
        if ( LatestRecoveryPointV50 != null ) {
            this.LatestRecoveryPointV50 = LatestRecoveryPointV50;
        }
        if ( LatestRecoveryPointV51 != null ) {
            this.LatestRecoveryPointV51 = LatestRecoveryPointV51;
        }
        if ( LatestRecoveryPointV52 != null ) {
            this.LatestRecoveryPointV52 = LatestRecoveryPointV52;
        }
        if ( LatestRecoveryPointV53 != null ) {
            this.LatestRecoveryPointV53 = LatestRecoveryPointV53;
        }
        if ( LatestRecoveryPointV60 != null ) {
            this.LatestRecoveryPointV60 = LatestRecoveryPointV60;
        }
        if ( LatestRecoveryPointV70 != null ) {
            this.LatestRecoveryPointV70 = LatestRecoveryPointV70;
        }
        if ( LatestRecoveryPointV80 != null ) {
            this.LatestRecoveryPointV80 = LatestRecoveryPointV80;
        }
        if ( LatestRecoveryPointV81 != null ) {
            this.LatestRecoveryPointV81 = LatestRecoveryPointV81;
        }
        if ( LatestRecoveryPointV90 != null ) {
            this.LatestRecoveryPointV90 = LatestRecoveryPointV90;
        }
        if ( LatestRecoveryPointV91 != null ) {
            this.LatestRecoveryPointV91 = LatestRecoveryPointV91;
        }
        if ( LatestRecoveryPointV92 != null ) {
            this.LatestRecoveryPointV92 = LatestRecoveryPointV92;
        }
        if ( LatestRecoveryPointV93 != null ) {
            this.LatestRecoveryPointV93 = LatestRecoveryPointV93;
        }
        if ( LatestRecoveryPointV94 != null ) {
            this.LatestRecoveryPointV94 = LatestRecoveryPointV94;
        }
        if ( LatestRecoveryPointV95 != null ) {
            this.LatestRecoveryPointV95 = LatestRecoveryPointV95;
        }
        if ( LocalStorage != null ) {
            this.LocalStorage = LocalStorage;
        }
        if ( MaxDataStreams != null ) {
            this.MaxDataStreams = MaxDataStreams;
        }
        if ( OldestRecoveryPointV50 != null ) {
            this.OldestRecoveryPointV50 = OldestRecoveryPointV50;
        }
        if ( OldestRecoveryPointV51 != null ) {
            this.OldestRecoveryPointV51 = OldestRecoveryPointV51;
        }
        if ( OldestRecoveryPointV52 != null ) {
            this.OldestRecoveryPointV52 = OldestRecoveryPointV52;
        }
        if ( OldestRecoveryPointV53 != null ) {
            this.OldestRecoveryPointV53 = OldestRecoveryPointV53;
        }
        if ( OldestRecoveryPointV60 != null ) {
            this.OldestRecoveryPointV60 = OldestRecoveryPointV60;
        }
        if ( OldestRecoveryPointV70 != null ) {
            this.OldestRecoveryPointV70 = OldestRecoveryPointV70;
        }
        if ( OldestRecoveryPointV80 != null ) {
            this.OldestRecoveryPointV80 = OldestRecoveryPointV80;
        }
        if ( OldestRecoveryPointV81 != null ) {
            this.OldestRecoveryPointV81 = OldestRecoveryPointV81;
        }
        if ( OldestRecoveryPointV90 != null ) {
            this.OldestRecoveryPointV90 = OldestRecoveryPointV90;
        }
        if ( OldestRecoveryPointV91 != null ) {
            this.OldestRecoveryPointV91 = OldestRecoveryPointV91;
        }
        if ( OldestRecoveryPointV92 != null ) {
            this.OldestRecoveryPointV92 = OldestRecoveryPointV92;
        }
        if ( OldestRecoveryPointV93 != null ) {
            this.OldestRecoveryPointV93 = OldestRecoveryPointV93;
        }
        if ( OldestRecoveryPointV94 != null ) {
            this.OldestRecoveryPointV94 = OldestRecoveryPointV94;
        }
        if ( OldestRecoveryPointV95 != null ) {
            this.OldestRecoveryPointV95 = OldestRecoveryPointV95;
        }
        if ( ProtectionDateV50 != null ) {
            this.ProtectionDateV50 = ProtectionDateV50;
        }
        if ( ProtectionDateV51 != null ) {
            this.ProtectionDateV51 = ProtectionDateV51;
        }
        if ( ProtectionDateV52 != null ) {
            this.ProtectionDateV52 = ProtectionDateV52;
        }
        if ( ProtectionDateV53 != null ) {
            this.ProtectionDateV53 = ProtectionDateV53;
        }
        if ( ProtectionDateV60 != null ) {
            this.ProtectionDateV60 = ProtectionDateV60;
        }
        if ( ProtectionDateV70 != null ) {
            this.ProtectionDateV70 = ProtectionDateV70;
        }
        if ( ProtectionDateV80 != null ) {
            this.ProtectionDateV80 = ProtectionDateV80;
        }
        if ( ProtectionDateV81 != null ) {
            this.ProtectionDateV81 = ProtectionDateV81;
        }
        if ( ProtectionDateV90 != null ) {
            this.ProtectionDateV90 = ProtectionDateV90;
        }
        if ( ProtectionDateV91 != null ) {
            this.ProtectionDateV91 = ProtectionDateV91;
        }
        if ( ProtectionDateV92 != null ) {
            this.ProtectionDateV92 = ProtectionDateV92;
        }
        if ( ProtectionDateV93 != null ) {
            this.ProtectionDateV93 = ProtectionDateV93;
        }
        if ( ProtectionDateV94 != null ) {
            this.ProtectionDateV94 = ProtectionDateV94;
        }
        if ( ProtectionDateV95 != null ) {
            this.ProtectionDateV95 = ProtectionDateV95;
        }
        if ( RecoveryForkGuid != null ) {
            this.RecoveryForkGuid = RecoveryForkGuid;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( BlackoutWindowResponseInfo != null ) {
            this.BlackoutWindowResponseInfo = BlackoutWindowResponseInfo;
        }
        if ( MssqlDbSummary != null ) {
            this.MssqlDbSummary = MssqlDbSummary;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
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
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archiveStorage\n" ;
            } else {
                s += ind + "archiveStorage\n" ;
            }
        }
        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        if (this.IsLocal != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLocal\n" ;
            } else {
                s += ind + "isLocal\n" ;
            }
        }
        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean (scalar)
        if (this.IsStandby != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isStandby\n" ;
            } else {
                s += ind + "isStandby\n" ;
            }
        }
        //      C# -> System.String? LatestRecoveryPointV50
        // GraphQL -> latestRecoveryPointV50: String (scalar)
        if (this.LatestRecoveryPointV50 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV50\n" ;
            } else {
                s += ind + "latestRecoveryPointV50\n" ;
            }
        }
        //      C# -> System.String? LatestRecoveryPointV51
        // GraphQL -> latestRecoveryPointV51: String (scalar)
        if (this.LatestRecoveryPointV51 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV51\n" ;
            } else {
                s += ind + "latestRecoveryPointV51\n" ;
            }
        }
        //      C# -> System.String? LatestRecoveryPointV52
        // GraphQL -> latestRecoveryPointV52: String (scalar)
        if (this.LatestRecoveryPointV52 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV52\n" ;
            } else {
                s += ind + "latestRecoveryPointV52\n" ;
            }
        }
        //      C# -> System.String? LatestRecoveryPointV53
        // GraphQL -> latestRecoveryPointV53: String (scalar)
        if (this.LatestRecoveryPointV53 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV53\n" ;
            } else {
                s += ind + "latestRecoveryPointV53\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryPointV60
        // GraphQL -> latestRecoveryPointV60: DateTime (scalar)
        if (this.LatestRecoveryPointV60 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV60\n" ;
            } else {
                s += ind + "latestRecoveryPointV60\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryPointV70
        // GraphQL -> latestRecoveryPointV70: DateTime (scalar)
        if (this.LatestRecoveryPointV70 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV70\n" ;
            } else {
                s += ind + "latestRecoveryPointV70\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryPointV80
        // GraphQL -> latestRecoveryPointV80: DateTime (scalar)
        if (this.LatestRecoveryPointV80 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV80\n" ;
            } else {
                s += ind + "latestRecoveryPointV80\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryPointV81
        // GraphQL -> latestRecoveryPointV81: DateTime (scalar)
        if (this.LatestRecoveryPointV81 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV81\n" ;
            } else {
                s += ind + "latestRecoveryPointV81\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryPointV90
        // GraphQL -> latestRecoveryPointV90: DateTime (scalar)
        if (this.LatestRecoveryPointV90 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV90\n" ;
            } else {
                s += ind + "latestRecoveryPointV90\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryPointV91
        // GraphQL -> latestRecoveryPointV91: DateTime (scalar)
        if (this.LatestRecoveryPointV91 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV91\n" ;
            } else {
                s += ind + "latestRecoveryPointV91\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryPointV92
        // GraphQL -> latestRecoveryPointV92: DateTime (scalar)
        if (this.LatestRecoveryPointV92 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV92\n" ;
            } else {
                s += ind + "latestRecoveryPointV92\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryPointV93
        // GraphQL -> latestRecoveryPointV93: DateTime (scalar)
        if (this.LatestRecoveryPointV93 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV93\n" ;
            } else {
                s += ind + "latestRecoveryPointV93\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryPointV94
        // GraphQL -> latestRecoveryPointV94: DateTime (scalar)
        if (this.LatestRecoveryPointV94 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV94\n" ;
            } else {
                s += ind + "latestRecoveryPointV94\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryPointV95
        // GraphQL -> latestRecoveryPointV95: DateTime (scalar)
        if (this.LatestRecoveryPointV95 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryPointV95\n" ;
            } else {
                s += ind + "latestRecoveryPointV95\n" ;
            }
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localStorage\n" ;
            } else {
                s += ind + "localStorage\n" ;
            }
        }
        //      C# -> System.Int32? MaxDataStreams
        // GraphQL -> maxDataStreams: Int (scalar)
        if (this.MaxDataStreams != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxDataStreams\n" ;
            } else {
                s += ind + "maxDataStreams\n" ;
            }
        }
        //      C# -> System.String? OldestRecoveryPointV50
        // GraphQL -> oldestRecoveryPointV50: String (scalar)
        if (this.OldestRecoveryPointV50 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV50\n" ;
            } else {
                s += ind + "oldestRecoveryPointV50\n" ;
            }
        }
        //      C# -> System.String? OldestRecoveryPointV51
        // GraphQL -> oldestRecoveryPointV51: String (scalar)
        if (this.OldestRecoveryPointV51 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV51\n" ;
            } else {
                s += ind + "oldestRecoveryPointV51\n" ;
            }
        }
        //      C# -> System.String? OldestRecoveryPointV52
        // GraphQL -> oldestRecoveryPointV52: String (scalar)
        if (this.OldestRecoveryPointV52 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV52\n" ;
            } else {
                s += ind + "oldestRecoveryPointV52\n" ;
            }
        }
        //      C# -> System.String? OldestRecoveryPointV53
        // GraphQL -> oldestRecoveryPointV53: String (scalar)
        if (this.OldestRecoveryPointV53 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV53\n" ;
            } else {
                s += ind + "oldestRecoveryPointV53\n" ;
            }
        }
        //      C# -> DateTime? OldestRecoveryPointV60
        // GraphQL -> oldestRecoveryPointV60: DateTime (scalar)
        if (this.OldestRecoveryPointV60 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV60\n" ;
            } else {
                s += ind + "oldestRecoveryPointV60\n" ;
            }
        }
        //      C# -> DateTime? OldestRecoveryPointV70
        // GraphQL -> oldestRecoveryPointV70: DateTime (scalar)
        if (this.OldestRecoveryPointV70 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV70\n" ;
            } else {
                s += ind + "oldestRecoveryPointV70\n" ;
            }
        }
        //      C# -> DateTime? OldestRecoveryPointV80
        // GraphQL -> oldestRecoveryPointV80: DateTime (scalar)
        if (this.OldestRecoveryPointV80 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV80\n" ;
            } else {
                s += ind + "oldestRecoveryPointV80\n" ;
            }
        }
        //      C# -> DateTime? OldestRecoveryPointV81
        // GraphQL -> oldestRecoveryPointV81: DateTime (scalar)
        if (this.OldestRecoveryPointV81 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV81\n" ;
            } else {
                s += ind + "oldestRecoveryPointV81\n" ;
            }
        }
        //      C# -> DateTime? OldestRecoveryPointV90
        // GraphQL -> oldestRecoveryPointV90: DateTime (scalar)
        if (this.OldestRecoveryPointV90 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV90\n" ;
            } else {
                s += ind + "oldestRecoveryPointV90\n" ;
            }
        }
        //      C# -> DateTime? OldestRecoveryPointV91
        // GraphQL -> oldestRecoveryPointV91: DateTime (scalar)
        if (this.OldestRecoveryPointV91 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV91\n" ;
            } else {
                s += ind + "oldestRecoveryPointV91\n" ;
            }
        }
        //      C# -> DateTime? OldestRecoveryPointV92
        // GraphQL -> oldestRecoveryPointV92: DateTime (scalar)
        if (this.OldestRecoveryPointV92 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV92\n" ;
            } else {
                s += ind + "oldestRecoveryPointV92\n" ;
            }
        }
        //      C# -> DateTime? OldestRecoveryPointV93
        // GraphQL -> oldestRecoveryPointV93: DateTime (scalar)
        if (this.OldestRecoveryPointV93 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV93\n" ;
            } else {
                s += ind + "oldestRecoveryPointV93\n" ;
            }
        }
        //      C# -> DateTime? OldestRecoveryPointV94
        // GraphQL -> oldestRecoveryPointV94: DateTime (scalar)
        if (this.OldestRecoveryPointV94 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV94\n" ;
            } else {
                s += ind + "oldestRecoveryPointV94\n" ;
            }
        }
        //      C# -> DateTime? OldestRecoveryPointV95
        // GraphQL -> oldestRecoveryPointV95: DateTime (scalar)
        if (this.OldestRecoveryPointV95 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestRecoveryPointV95\n" ;
            } else {
                s += ind + "oldestRecoveryPointV95\n" ;
            }
        }
        //      C# -> System.String? ProtectionDateV50
        // GraphQL -> protectionDateV50: String (scalar)
        if (this.ProtectionDateV50 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV50\n" ;
            } else {
                s += ind + "protectionDateV50\n" ;
            }
        }
        //      C# -> System.String? ProtectionDateV51
        // GraphQL -> protectionDateV51: String (scalar)
        if (this.ProtectionDateV51 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV51\n" ;
            } else {
                s += ind + "protectionDateV51\n" ;
            }
        }
        //      C# -> System.String? ProtectionDateV52
        // GraphQL -> protectionDateV52: String (scalar)
        if (this.ProtectionDateV52 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV52\n" ;
            } else {
                s += ind + "protectionDateV52\n" ;
            }
        }
        //      C# -> System.String? ProtectionDateV53
        // GraphQL -> protectionDateV53: String (scalar)
        if (this.ProtectionDateV53 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV53\n" ;
            } else {
                s += ind + "protectionDateV53\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV60
        // GraphQL -> protectionDateV60: DateTime (scalar)
        if (this.ProtectionDateV60 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV60\n" ;
            } else {
                s += ind + "protectionDateV60\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV70
        // GraphQL -> protectionDateV70: DateTime (scalar)
        if (this.ProtectionDateV70 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV70\n" ;
            } else {
                s += ind + "protectionDateV70\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV80
        // GraphQL -> protectionDateV80: DateTime (scalar)
        if (this.ProtectionDateV80 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV80\n" ;
            } else {
                s += ind + "protectionDateV80\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV81
        // GraphQL -> protectionDateV81: DateTime (scalar)
        if (this.ProtectionDateV81 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV81\n" ;
            } else {
                s += ind + "protectionDateV81\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV90
        // GraphQL -> protectionDateV90: DateTime (scalar)
        if (this.ProtectionDateV90 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV90\n" ;
            } else {
                s += ind + "protectionDateV90\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV91
        // GraphQL -> protectionDateV91: DateTime (scalar)
        if (this.ProtectionDateV91 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV91\n" ;
            } else {
                s += ind + "protectionDateV91\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV92
        // GraphQL -> protectionDateV92: DateTime (scalar)
        if (this.ProtectionDateV92 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV92\n" ;
            } else {
                s += ind + "protectionDateV92\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV93
        // GraphQL -> protectionDateV93: DateTime (scalar)
        if (this.ProtectionDateV93 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV93\n" ;
            } else {
                s += ind + "protectionDateV93\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV94
        // GraphQL -> protectionDateV94: DateTime (scalar)
        if (this.ProtectionDateV94 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV94\n" ;
            } else {
                s += ind + "protectionDateV94\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDateV95
        // GraphQL -> protectionDateV95: DateTime (scalar)
        if (this.ProtectionDateV95 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDateV95\n" ;
            } else {
                s += ind + "protectionDateV95\n" ;
            }
        }
        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        if (this.RecoveryForkGuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryForkGuid\n" ;
            } else {
                s += ind + "recoveryForkGuid\n" ;
            }
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotCount\n" ;
            } else {
                s += ind + "snapshotCount\n" ;
            }
        }
        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        if (this.BlackoutWindowResponseInfo != null) {
            var fspec = this.BlackoutWindowResponseInfo.AsFieldSpec(conf.Child("blackoutWindowResponseInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blackoutWindowResponseInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlDbSummary? MssqlDbSummary
        // GraphQL -> mssqlDbSummary: MssqlDbSummary (type)
        if (this.MssqlDbSummary != null) {
            var fspec = this.MssqlDbSummary.AsFieldSpec(conf.Child("mssqlDbSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlDbSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: MssqlScriptDetail (type)
        if (this.PostBackupScript != null) {
            var fspec = this.PostBackupScript.AsFieldSpec(conf.Child("postBackupScript"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "postBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: MssqlScriptDetail (type)
        if (this.PreBackupScript != null) {
            var fspec = this.PreBackupScript.AsFieldSpec(conf.Child("preBackupScript"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "preBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (ec.Includes("archiveStorage",true))
        {
            if(this.ArchiveStorage == null) {

                this.ArchiveStorage = new System.Int64();

            } else {


            }
        }
        else if (this.ArchiveStorage != null && ec.Excludes("archiveStorage",true))
        {
            this.ArchiveStorage = null;
        }
        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        if (ec.Includes("isLocal",true))
        {
            if(this.IsLocal == null) {

                this.IsLocal = true;

            } else {


            }
        }
        else if (this.IsLocal != null && ec.Excludes("isLocal",true))
        {
            this.IsLocal = null;
        }
        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean (scalar)
        if (ec.Includes("isStandby",true))
        {
            if(this.IsStandby == null) {

                this.IsStandby = true;

            } else {


            }
        }
        else if (this.IsStandby != null && ec.Excludes("isStandby",true))
        {
            this.IsStandby = null;
        }
        //      C# -> System.String? LatestRecoveryPointV50
        // GraphQL -> latestRecoveryPointV50: String (scalar)
        if (ec.Includes("latestRecoveryPointV50",true))
        {
            if(this.LatestRecoveryPointV50 == null) {

                this.LatestRecoveryPointV50 = "FETCH";

            } else {


            }
        }
        else if (this.LatestRecoveryPointV50 != null && ec.Excludes("latestRecoveryPointV50",true))
        {
            this.LatestRecoveryPointV50 = null;
        }
        //      C# -> System.String? LatestRecoveryPointV51
        // GraphQL -> latestRecoveryPointV51: String (scalar)
        if (ec.Includes("latestRecoveryPointV51",true))
        {
            if(this.LatestRecoveryPointV51 == null) {

                this.LatestRecoveryPointV51 = "FETCH";

            } else {


            }
        }
        else if (this.LatestRecoveryPointV51 != null && ec.Excludes("latestRecoveryPointV51",true))
        {
            this.LatestRecoveryPointV51 = null;
        }
        //      C# -> System.String? LatestRecoveryPointV52
        // GraphQL -> latestRecoveryPointV52: String (scalar)
        if (ec.Includes("latestRecoveryPointV52",true))
        {
            if(this.LatestRecoveryPointV52 == null) {

                this.LatestRecoveryPointV52 = "FETCH";

            } else {


            }
        }
        else if (this.LatestRecoveryPointV52 != null && ec.Excludes("latestRecoveryPointV52",true))
        {
            this.LatestRecoveryPointV52 = null;
        }
        //      C# -> System.String? LatestRecoveryPointV53
        // GraphQL -> latestRecoveryPointV53: String (scalar)
        if (ec.Includes("latestRecoveryPointV53",true))
        {
            if(this.LatestRecoveryPointV53 == null) {

                this.LatestRecoveryPointV53 = "FETCH";

            } else {


            }
        }
        else if (this.LatestRecoveryPointV53 != null && ec.Excludes("latestRecoveryPointV53",true))
        {
            this.LatestRecoveryPointV53 = null;
        }
        //      C# -> DateTime? LatestRecoveryPointV60
        // GraphQL -> latestRecoveryPointV60: DateTime (scalar)
        if (ec.Includes("latestRecoveryPointV60",true))
        {
            if(this.LatestRecoveryPointV60 == null) {

                this.LatestRecoveryPointV60 = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryPointV60 != null && ec.Excludes("latestRecoveryPointV60",true))
        {
            this.LatestRecoveryPointV60 = null;
        }
        //      C# -> DateTime? LatestRecoveryPointV70
        // GraphQL -> latestRecoveryPointV70: DateTime (scalar)
        if (ec.Includes("latestRecoveryPointV70",true))
        {
            if(this.LatestRecoveryPointV70 == null) {

                this.LatestRecoveryPointV70 = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryPointV70 != null && ec.Excludes("latestRecoveryPointV70",true))
        {
            this.LatestRecoveryPointV70 = null;
        }
        //      C# -> DateTime? LatestRecoveryPointV80
        // GraphQL -> latestRecoveryPointV80: DateTime (scalar)
        if (ec.Includes("latestRecoveryPointV80",true))
        {
            if(this.LatestRecoveryPointV80 == null) {

                this.LatestRecoveryPointV80 = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryPointV80 != null && ec.Excludes("latestRecoveryPointV80",true))
        {
            this.LatestRecoveryPointV80 = null;
        }
        //      C# -> DateTime? LatestRecoveryPointV81
        // GraphQL -> latestRecoveryPointV81: DateTime (scalar)
        if (ec.Includes("latestRecoveryPointV81",true))
        {
            if(this.LatestRecoveryPointV81 == null) {

                this.LatestRecoveryPointV81 = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryPointV81 != null && ec.Excludes("latestRecoveryPointV81",true))
        {
            this.LatestRecoveryPointV81 = null;
        }
        //      C# -> DateTime? LatestRecoveryPointV90
        // GraphQL -> latestRecoveryPointV90: DateTime (scalar)
        if (ec.Includes("latestRecoveryPointV90",true))
        {
            if(this.LatestRecoveryPointV90 == null) {

                this.LatestRecoveryPointV90 = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryPointV90 != null && ec.Excludes("latestRecoveryPointV90",true))
        {
            this.LatestRecoveryPointV90 = null;
        }
        //      C# -> DateTime? LatestRecoveryPointV91
        // GraphQL -> latestRecoveryPointV91: DateTime (scalar)
        if (ec.Includes("latestRecoveryPointV91",true))
        {
            if(this.LatestRecoveryPointV91 == null) {

                this.LatestRecoveryPointV91 = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryPointV91 != null && ec.Excludes("latestRecoveryPointV91",true))
        {
            this.LatestRecoveryPointV91 = null;
        }
        //      C# -> DateTime? LatestRecoveryPointV92
        // GraphQL -> latestRecoveryPointV92: DateTime (scalar)
        if (ec.Includes("latestRecoveryPointV92",true))
        {
            if(this.LatestRecoveryPointV92 == null) {

                this.LatestRecoveryPointV92 = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryPointV92 != null && ec.Excludes("latestRecoveryPointV92",true))
        {
            this.LatestRecoveryPointV92 = null;
        }
        //      C# -> DateTime? LatestRecoveryPointV93
        // GraphQL -> latestRecoveryPointV93: DateTime (scalar)
        if (ec.Includes("latestRecoveryPointV93",true))
        {
            if(this.LatestRecoveryPointV93 == null) {

                this.LatestRecoveryPointV93 = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryPointV93 != null && ec.Excludes("latestRecoveryPointV93",true))
        {
            this.LatestRecoveryPointV93 = null;
        }
        //      C# -> DateTime? LatestRecoveryPointV94
        // GraphQL -> latestRecoveryPointV94: DateTime (scalar)
        if (ec.Includes("latestRecoveryPointV94",true))
        {
            if(this.LatestRecoveryPointV94 == null) {

                this.LatestRecoveryPointV94 = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryPointV94 != null && ec.Excludes("latestRecoveryPointV94",true))
        {
            this.LatestRecoveryPointV94 = null;
        }
        //      C# -> DateTime? LatestRecoveryPointV95
        // GraphQL -> latestRecoveryPointV95: DateTime (scalar)
        if (ec.Includes("latestRecoveryPointV95",true))
        {
            if(this.LatestRecoveryPointV95 == null) {

                this.LatestRecoveryPointV95 = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryPointV95 != null && ec.Excludes("latestRecoveryPointV95",true))
        {
            this.LatestRecoveryPointV95 = null;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (ec.Includes("localStorage",true))
        {
            if(this.LocalStorage == null) {

                this.LocalStorage = new System.Int64();

            } else {


            }
        }
        else if (this.LocalStorage != null && ec.Excludes("localStorage",true))
        {
            this.LocalStorage = null;
        }
        //      C# -> System.Int32? MaxDataStreams
        // GraphQL -> maxDataStreams: Int (scalar)
        if (ec.Includes("maxDataStreams",true))
        {
            if(this.MaxDataStreams == null) {

                this.MaxDataStreams = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxDataStreams != null && ec.Excludes("maxDataStreams",true))
        {
            this.MaxDataStreams = null;
        }
        //      C# -> System.String? OldestRecoveryPointV50
        // GraphQL -> oldestRecoveryPointV50: String (scalar)
        if (ec.Includes("oldestRecoveryPointV50",true))
        {
            if(this.OldestRecoveryPointV50 == null) {

                this.OldestRecoveryPointV50 = "FETCH";

            } else {


            }
        }
        else if (this.OldestRecoveryPointV50 != null && ec.Excludes("oldestRecoveryPointV50",true))
        {
            this.OldestRecoveryPointV50 = null;
        }
        //      C# -> System.String? OldestRecoveryPointV51
        // GraphQL -> oldestRecoveryPointV51: String (scalar)
        if (ec.Includes("oldestRecoveryPointV51",true))
        {
            if(this.OldestRecoveryPointV51 == null) {

                this.OldestRecoveryPointV51 = "FETCH";

            } else {


            }
        }
        else if (this.OldestRecoveryPointV51 != null && ec.Excludes("oldestRecoveryPointV51",true))
        {
            this.OldestRecoveryPointV51 = null;
        }
        //      C# -> System.String? OldestRecoveryPointV52
        // GraphQL -> oldestRecoveryPointV52: String (scalar)
        if (ec.Includes("oldestRecoveryPointV52",true))
        {
            if(this.OldestRecoveryPointV52 == null) {

                this.OldestRecoveryPointV52 = "FETCH";

            } else {


            }
        }
        else if (this.OldestRecoveryPointV52 != null && ec.Excludes("oldestRecoveryPointV52",true))
        {
            this.OldestRecoveryPointV52 = null;
        }
        //      C# -> System.String? OldestRecoveryPointV53
        // GraphQL -> oldestRecoveryPointV53: String (scalar)
        if (ec.Includes("oldestRecoveryPointV53",true))
        {
            if(this.OldestRecoveryPointV53 == null) {

                this.OldestRecoveryPointV53 = "FETCH";

            } else {


            }
        }
        else if (this.OldestRecoveryPointV53 != null && ec.Excludes("oldestRecoveryPointV53",true))
        {
            this.OldestRecoveryPointV53 = null;
        }
        //      C# -> DateTime? OldestRecoveryPointV60
        // GraphQL -> oldestRecoveryPointV60: DateTime (scalar)
        if (ec.Includes("oldestRecoveryPointV60",true))
        {
            if(this.OldestRecoveryPointV60 == null) {

                this.OldestRecoveryPointV60 = new DateTime();

            } else {


            }
        }
        else if (this.OldestRecoveryPointV60 != null && ec.Excludes("oldestRecoveryPointV60",true))
        {
            this.OldestRecoveryPointV60 = null;
        }
        //      C# -> DateTime? OldestRecoveryPointV70
        // GraphQL -> oldestRecoveryPointV70: DateTime (scalar)
        if (ec.Includes("oldestRecoveryPointV70",true))
        {
            if(this.OldestRecoveryPointV70 == null) {

                this.OldestRecoveryPointV70 = new DateTime();

            } else {


            }
        }
        else if (this.OldestRecoveryPointV70 != null && ec.Excludes("oldestRecoveryPointV70",true))
        {
            this.OldestRecoveryPointV70 = null;
        }
        //      C# -> DateTime? OldestRecoveryPointV80
        // GraphQL -> oldestRecoveryPointV80: DateTime (scalar)
        if (ec.Includes("oldestRecoveryPointV80",true))
        {
            if(this.OldestRecoveryPointV80 == null) {

                this.OldestRecoveryPointV80 = new DateTime();

            } else {


            }
        }
        else if (this.OldestRecoveryPointV80 != null && ec.Excludes("oldestRecoveryPointV80",true))
        {
            this.OldestRecoveryPointV80 = null;
        }
        //      C# -> DateTime? OldestRecoveryPointV81
        // GraphQL -> oldestRecoveryPointV81: DateTime (scalar)
        if (ec.Includes("oldestRecoveryPointV81",true))
        {
            if(this.OldestRecoveryPointV81 == null) {

                this.OldestRecoveryPointV81 = new DateTime();

            } else {


            }
        }
        else if (this.OldestRecoveryPointV81 != null && ec.Excludes("oldestRecoveryPointV81",true))
        {
            this.OldestRecoveryPointV81 = null;
        }
        //      C# -> DateTime? OldestRecoveryPointV90
        // GraphQL -> oldestRecoveryPointV90: DateTime (scalar)
        if (ec.Includes("oldestRecoveryPointV90",true))
        {
            if(this.OldestRecoveryPointV90 == null) {

                this.OldestRecoveryPointV90 = new DateTime();

            } else {


            }
        }
        else if (this.OldestRecoveryPointV90 != null && ec.Excludes("oldestRecoveryPointV90",true))
        {
            this.OldestRecoveryPointV90 = null;
        }
        //      C# -> DateTime? OldestRecoveryPointV91
        // GraphQL -> oldestRecoveryPointV91: DateTime (scalar)
        if (ec.Includes("oldestRecoveryPointV91",true))
        {
            if(this.OldestRecoveryPointV91 == null) {

                this.OldestRecoveryPointV91 = new DateTime();

            } else {


            }
        }
        else if (this.OldestRecoveryPointV91 != null && ec.Excludes("oldestRecoveryPointV91",true))
        {
            this.OldestRecoveryPointV91 = null;
        }
        //      C# -> DateTime? OldestRecoveryPointV92
        // GraphQL -> oldestRecoveryPointV92: DateTime (scalar)
        if (ec.Includes("oldestRecoveryPointV92",true))
        {
            if(this.OldestRecoveryPointV92 == null) {

                this.OldestRecoveryPointV92 = new DateTime();

            } else {


            }
        }
        else if (this.OldestRecoveryPointV92 != null && ec.Excludes("oldestRecoveryPointV92",true))
        {
            this.OldestRecoveryPointV92 = null;
        }
        //      C# -> DateTime? OldestRecoveryPointV93
        // GraphQL -> oldestRecoveryPointV93: DateTime (scalar)
        if (ec.Includes("oldestRecoveryPointV93",true))
        {
            if(this.OldestRecoveryPointV93 == null) {

                this.OldestRecoveryPointV93 = new DateTime();

            } else {


            }
        }
        else if (this.OldestRecoveryPointV93 != null && ec.Excludes("oldestRecoveryPointV93",true))
        {
            this.OldestRecoveryPointV93 = null;
        }
        //      C# -> DateTime? OldestRecoveryPointV94
        // GraphQL -> oldestRecoveryPointV94: DateTime (scalar)
        if (ec.Includes("oldestRecoveryPointV94",true))
        {
            if(this.OldestRecoveryPointV94 == null) {

                this.OldestRecoveryPointV94 = new DateTime();

            } else {


            }
        }
        else if (this.OldestRecoveryPointV94 != null && ec.Excludes("oldestRecoveryPointV94",true))
        {
            this.OldestRecoveryPointV94 = null;
        }
        //      C# -> DateTime? OldestRecoveryPointV95
        // GraphQL -> oldestRecoveryPointV95: DateTime (scalar)
        if (ec.Includes("oldestRecoveryPointV95",true))
        {
            if(this.OldestRecoveryPointV95 == null) {

                this.OldestRecoveryPointV95 = new DateTime();

            } else {


            }
        }
        else if (this.OldestRecoveryPointV95 != null && ec.Excludes("oldestRecoveryPointV95",true))
        {
            this.OldestRecoveryPointV95 = null;
        }
        //      C# -> System.String? ProtectionDateV50
        // GraphQL -> protectionDateV50: String (scalar)
        if (ec.Includes("protectionDateV50",true))
        {
            if(this.ProtectionDateV50 == null) {

                this.ProtectionDateV50 = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionDateV50 != null && ec.Excludes("protectionDateV50",true))
        {
            this.ProtectionDateV50 = null;
        }
        //      C# -> System.String? ProtectionDateV51
        // GraphQL -> protectionDateV51: String (scalar)
        if (ec.Includes("protectionDateV51",true))
        {
            if(this.ProtectionDateV51 == null) {

                this.ProtectionDateV51 = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionDateV51 != null && ec.Excludes("protectionDateV51",true))
        {
            this.ProtectionDateV51 = null;
        }
        //      C# -> System.String? ProtectionDateV52
        // GraphQL -> protectionDateV52: String (scalar)
        if (ec.Includes("protectionDateV52",true))
        {
            if(this.ProtectionDateV52 == null) {

                this.ProtectionDateV52 = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionDateV52 != null && ec.Excludes("protectionDateV52",true))
        {
            this.ProtectionDateV52 = null;
        }
        //      C# -> System.String? ProtectionDateV53
        // GraphQL -> protectionDateV53: String (scalar)
        if (ec.Includes("protectionDateV53",true))
        {
            if(this.ProtectionDateV53 == null) {

                this.ProtectionDateV53 = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionDateV53 != null && ec.Excludes("protectionDateV53",true))
        {
            this.ProtectionDateV53 = null;
        }
        //      C# -> DateTime? ProtectionDateV60
        // GraphQL -> protectionDateV60: DateTime (scalar)
        if (ec.Includes("protectionDateV60",true))
        {
            if(this.ProtectionDateV60 == null) {

                this.ProtectionDateV60 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV60 != null && ec.Excludes("protectionDateV60",true))
        {
            this.ProtectionDateV60 = null;
        }
        //      C# -> DateTime? ProtectionDateV70
        // GraphQL -> protectionDateV70: DateTime (scalar)
        if (ec.Includes("protectionDateV70",true))
        {
            if(this.ProtectionDateV70 == null) {

                this.ProtectionDateV70 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV70 != null && ec.Excludes("protectionDateV70",true))
        {
            this.ProtectionDateV70 = null;
        }
        //      C# -> DateTime? ProtectionDateV80
        // GraphQL -> protectionDateV80: DateTime (scalar)
        if (ec.Includes("protectionDateV80",true))
        {
            if(this.ProtectionDateV80 == null) {

                this.ProtectionDateV80 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV80 != null && ec.Excludes("protectionDateV80",true))
        {
            this.ProtectionDateV80 = null;
        }
        //      C# -> DateTime? ProtectionDateV81
        // GraphQL -> protectionDateV81: DateTime (scalar)
        if (ec.Includes("protectionDateV81",true))
        {
            if(this.ProtectionDateV81 == null) {

                this.ProtectionDateV81 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV81 != null && ec.Excludes("protectionDateV81",true))
        {
            this.ProtectionDateV81 = null;
        }
        //      C# -> DateTime? ProtectionDateV90
        // GraphQL -> protectionDateV90: DateTime (scalar)
        if (ec.Includes("protectionDateV90",true))
        {
            if(this.ProtectionDateV90 == null) {

                this.ProtectionDateV90 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV90 != null && ec.Excludes("protectionDateV90",true))
        {
            this.ProtectionDateV90 = null;
        }
        //      C# -> DateTime? ProtectionDateV91
        // GraphQL -> protectionDateV91: DateTime (scalar)
        if (ec.Includes("protectionDateV91",true))
        {
            if(this.ProtectionDateV91 == null) {

                this.ProtectionDateV91 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV91 != null && ec.Excludes("protectionDateV91",true))
        {
            this.ProtectionDateV91 = null;
        }
        //      C# -> DateTime? ProtectionDateV92
        // GraphQL -> protectionDateV92: DateTime (scalar)
        if (ec.Includes("protectionDateV92",true))
        {
            if(this.ProtectionDateV92 == null) {

                this.ProtectionDateV92 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV92 != null && ec.Excludes("protectionDateV92",true))
        {
            this.ProtectionDateV92 = null;
        }
        //      C# -> DateTime? ProtectionDateV93
        // GraphQL -> protectionDateV93: DateTime (scalar)
        if (ec.Includes("protectionDateV93",true))
        {
            if(this.ProtectionDateV93 == null) {

                this.ProtectionDateV93 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV93 != null && ec.Excludes("protectionDateV93",true))
        {
            this.ProtectionDateV93 = null;
        }
        //      C# -> DateTime? ProtectionDateV94
        // GraphQL -> protectionDateV94: DateTime (scalar)
        if (ec.Includes("protectionDateV94",true))
        {
            if(this.ProtectionDateV94 == null) {

                this.ProtectionDateV94 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV94 != null && ec.Excludes("protectionDateV94",true))
        {
            this.ProtectionDateV94 = null;
        }
        //      C# -> DateTime? ProtectionDateV95
        // GraphQL -> protectionDateV95: DateTime (scalar)
        if (ec.Includes("protectionDateV95",true))
        {
            if(this.ProtectionDateV95 == null) {

                this.ProtectionDateV95 = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDateV95 != null && ec.Excludes("protectionDateV95",true))
        {
            this.ProtectionDateV95 = null;
        }
        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        if (ec.Includes("recoveryForkGuid",true))
        {
            if(this.RecoveryForkGuid == null) {

                this.RecoveryForkGuid = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryForkGuid != null && ec.Excludes("recoveryForkGuid",true))
        {
            this.RecoveryForkGuid = null;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (ec.Includes("snapshotCount",true))
        {
            if(this.SnapshotCount == null) {

                this.SnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.SnapshotCount != null && ec.Excludes("snapshotCount",true))
        {
            this.SnapshotCount = null;
        }
        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        if (ec.Includes("blackoutWindowResponseInfo",false))
        {
            if(this.BlackoutWindowResponseInfo == null) {

                this.BlackoutWindowResponseInfo = new BlackoutWindowResponseInfo();
                this.BlackoutWindowResponseInfo.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowResponseInfo"));

            } else {

                this.BlackoutWindowResponseInfo.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowResponseInfo"));

            }
        }
        else if (this.BlackoutWindowResponseInfo != null && ec.Excludes("blackoutWindowResponseInfo",false))
        {
            this.BlackoutWindowResponseInfo = null;
        }
        //      C# -> MssqlDbSummary? MssqlDbSummary
        // GraphQL -> mssqlDbSummary: MssqlDbSummary (type)
        if (ec.Includes("mssqlDbSummary",false))
        {
            if(this.MssqlDbSummary == null) {

                this.MssqlDbSummary = new MssqlDbSummary();
                this.MssqlDbSummary.ApplyExploratoryFieldSpec(ec.NewChild("mssqlDbSummary"));

            } else {

                this.MssqlDbSummary.ApplyExploratoryFieldSpec(ec.NewChild("mssqlDbSummary"));

            }
        }
        else if (this.MssqlDbSummary != null && ec.Excludes("mssqlDbSummary",false))
        {
            this.MssqlDbSummary = null;
        }
        //      C# -> MssqlScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: MssqlScriptDetail (type)
        if (ec.Includes("postBackupScript",false))
        {
            if(this.PostBackupScript == null) {

                this.PostBackupScript = new MssqlScriptDetail();
                this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));

            } else {

                this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));

            }
        }
        else if (this.PostBackupScript != null && ec.Excludes("postBackupScript",false))
        {
            this.PostBackupScript = null;
        }
        //      C# -> MssqlScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: MssqlScriptDetail (type)
        if (ec.Includes("preBackupScript",false))
        {
            if(this.PreBackupScript == null) {

                this.PreBackupScript = new MssqlScriptDetail();
                this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));

            } else {

                this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));

            }
        }
        else if (this.PreBackupScript != null && ec.Excludes("preBackupScript",false))
        {
            this.PreBackupScript = null;
        }
    }


    #endregion

    } // class MssqlDbDetail
    
    #endregion

    public static class ListMssqlDbDetailExtensions
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
            this List<MssqlDbDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlDbDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDbDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDbDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDbDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types