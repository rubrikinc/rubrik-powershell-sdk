// OracleDbDetail.cs
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
    #region OracleDbDetail
    public class OracleDbDetail: BaseType
    {
        #region members

        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String (scalar)
        [JsonProperty("dbUniqueName")]
        public System.String? DbUniqueName { get; set; }

        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean (scalar)
        [JsonProperty("isLiveMount")]
        public System.Boolean? IsLiveMount { get; set; }

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

        //      C# -> System.String? OracleHome
        // GraphQL -> oracleHome: String (scalar)
        [JsonProperty("oracleHome")]
        public System.String? OracleHome { get; set; }

        //      C# -> List<System.String>? PreferredDgMemberUniqueNames
        // GraphQL -> preferredDgMemberUniqueNames: [String!]! (scalar)
        [JsonProperty("preferredDgMemberUniqueNames")]
        public List<System.String>? PreferredDgMemberUniqueNames { get; set; }

        //      C# -> System.Int32? SectionSizeInGb
        // GraphQL -> sectionSizeInGb: Int (scalar)
        [JsonProperty("sectionSizeInGb")]
        public System.Int32? SectionSizeInGb { get; set; }

        //      C# -> System.Boolean? ShouldBackupFromPrimaryDgGroupMemberOnly
        // GraphQL -> shouldBackupFromPrimaryDgGroupMemberOnly: Boolean (scalar)
        [JsonProperty("shouldBackupFromPrimaryDgGroupMemberOnly")]
        public System.Boolean? ShouldBackupFromPrimaryDgGroupMemberOnly { get; set; }

        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int32? SnapshotCount { get; set; }

        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        [JsonProperty("tablespaces")]
        public List<System.String>? Tablespaces { get; set; }

        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        [JsonProperty("blackoutWindowResponseInfo")]
        public BlackoutWindowResponseInfo? BlackoutWindowResponseInfo { get; set; }

        //      C# -> List<HostInfo>? HostsInfo
        // GraphQL -> hostsInfo: [HostInfo!]! (type)
        [JsonProperty("hostsInfo")]
        public List<HostInfo>? HostsInfo { get; set; }

        //      C# -> OracleLastValidationResult? LastValidationResult
        // GraphQL -> lastValidationResult: OracleLastValidationResult (type)
        [JsonProperty("lastValidationResult")]
        public OracleLastValidationResult? LastValidationResult { get; set; }

        //      C# -> OracleDbSummary? OracleDbSummary
        // GraphQL -> oracleDbSummary: OracleDbSummary (type)
        [JsonProperty("oracleDbSummary")]
        public OracleDbSummary? OracleDbSummary { get; set; }

        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        [JsonProperty("oracleNonSlaProperties")]
        public OracleNonSlaProperties? OracleNonSlaProperties { get; set; }

        //      C# -> OraclePdbDetails? PdbDetails
        // GraphQL -> pdbDetails: OraclePdbDetails (type)
        [JsonProperty("pdbDetails")]
        public OraclePdbDetails? PdbDetails { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleDbDetail";
    }

    public OracleDbDetail Set(
        System.String? DbUniqueName = null,
        System.Boolean? IsLiveMount = null,
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
        System.String? OracleHome = null,
        List<System.String>? PreferredDgMemberUniqueNames = null,
        System.Int32? SectionSizeInGb = null,
        System.Boolean? ShouldBackupFromPrimaryDgGroupMemberOnly = null,
        System.Int32? SnapshotCount = null,
        List<System.String>? Tablespaces = null,
        BlackoutWindowResponseInfo? BlackoutWindowResponseInfo = null,
        List<HostInfo>? HostsInfo = null,
        OracleLastValidationResult? LastValidationResult = null,
        OracleDbSummary? OracleDbSummary = null,
        OracleNonSlaProperties? OracleNonSlaProperties = null,
        OraclePdbDetails? PdbDetails = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null
    ) 
    {
        if ( DbUniqueName != null ) {
            this.DbUniqueName = DbUniqueName;
        }
        if ( IsLiveMount != null ) {
            this.IsLiveMount = IsLiveMount;
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
        if ( OracleHome != null ) {
            this.OracleHome = OracleHome;
        }
        if ( PreferredDgMemberUniqueNames != null ) {
            this.PreferredDgMemberUniqueNames = PreferredDgMemberUniqueNames;
        }
        if ( SectionSizeInGb != null ) {
            this.SectionSizeInGb = SectionSizeInGb;
        }
        if ( ShouldBackupFromPrimaryDgGroupMemberOnly != null ) {
            this.ShouldBackupFromPrimaryDgGroupMemberOnly = ShouldBackupFromPrimaryDgGroupMemberOnly;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( Tablespaces != null ) {
            this.Tablespaces = Tablespaces;
        }
        if ( BlackoutWindowResponseInfo != null ) {
            this.BlackoutWindowResponseInfo = BlackoutWindowResponseInfo;
        }
        if ( HostsInfo != null ) {
            this.HostsInfo = HostsInfo;
        }
        if ( LastValidationResult != null ) {
            this.LastValidationResult = LastValidationResult;
        }
        if ( OracleDbSummary != null ) {
            this.OracleDbSummary = OracleDbSummary;
        }
        if ( OracleNonSlaProperties != null ) {
            this.OracleNonSlaProperties = OracleNonSlaProperties;
        }
        if ( PdbDetails != null ) {
            this.PdbDetails = PdbDetails;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String (scalar)
        if (this.DbUniqueName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbUniqueName\n" ;
            } else {
                s += ind + "dbUniqueName\n" ;
            }
        }
        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean (scalar)
        if (this.IsLiveMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLiveMount\n" ;
            } else {
                s += ind + "isLiveMount\n" ;
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
        //      C# -> System.String? OracleHome
        // GraphQL -> oracleHome: String (scalar)
        if (this.OracleHome != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oracleHome\n" ;
            } else {
                s += ind + "oracleHome\n" ;
            }
        }
        //      C# -> List<System.String>? PreferredDgMemberUniqueNames
        // GraphQL -> preferredDgMemberUniqueNames: [String!]! (scalar)
        if (this.PreferredDgMemberUniqueNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "preferredDgMemberUniqueNames\n" ;
            } else {
                s += ind + "preferredDgMemberUniqueNames\n" ;
            }
        }
        //      C# -> System.Int32? SectionSizeInGb
        // GraphQL -> sectionSizeInGb: Int (scalar)
        if (this.SectionSizeInGb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sectionSizeInGb\n" ;
            } else {
                s += ind + "sectionSizeInGb\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldBackupFromPrimaryDgGroupMemberOnly
        // GraphQL -> shouldBackupFromPrimaryDgGroupMemberOnly: Boolean (scalar)
        if (this.ShouldBackupFromPrimaryDgGroupMemberOnly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldBackupFromPrimaryDgGroupMemberOnly\n" ;
            } else {
                s += ind + "shouldBackupFromPrimaryDgGroupMemberOnly\n" ;
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
        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        if (this.Tablespaces != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tablespaces\n" ;
            } else {
                s += ind + "tablespaces\n" ;
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
                    s += ind + "blackoutWindowResponseInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<HostInfo>? HostsInfo
        // GraphQL -> hostsInfo: [HostInfo!]! (type)
        if (this.HostsInfo != null) {
            var fspec = this.HostsInfo.AsFieldSpec(conf.Child("hostsInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hostsInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleLastValidationResult? LastValidationResult
        // GraphQL -> lastValidationResult: OracleLastValidationResult (type)
        if (this.LastValidationResult != null) {
            var fspec = this.LastValidationResult.AsFieldSpec(conf.Child("lastValidationResult"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastValidationResult {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleDbSummary? OracleDbSummary
        // GraphQL -> oracleDbSummary: OracleDbSummary (type)
        if (this.OracleDbSummary != null) {
            var fspec = this.OracleDbSummary.AsFieldSpec(conf.Child("oracleDbSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleDbSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (this.OracleNonSlaProperties != null) {
            var fspec = this.OracleNonSlaProperties.AsFieldSpec(conf.Child("oracleNonSlaProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleNonSlaProperties {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OraclePdbDetails? PdbDetails
        // GraphQL -> pdbDetails: OraclePdbDetails (type)
        if (this.PdbDetails != null) {
            var fspec = this.PdbDetails.AsFieldSpec(conf.Child("pdbDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pdbDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            var fspec = this.PendingSlaDomain.AsFieldSpec(conf.Child("pendingSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingSlaDomain {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String (scalar)
        if (ec.Includes("dbUniqueName",true))
        {
            if(this.DbUniqueName == null) {

                this.DbUniqueName = "FETCH";

            } else {


            }
        }
        else if (this.DbUniqueName != null && ec.Excludes("dbUniqueName",true))
        {
            this.DbUniqueName = null;
        }
        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean (scalar)
        if (ec.Includes("isLiveMount",true))
        {
            if(this.IsLiveMount == null) {

                this.IsLiveMount = true;

            } else {


            }
        }
        else if (this.IsLiveMount != null && ec.Excludes("isLiveMount",true))
        {
            this.IsLiveMount = null;
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
        //      C# -> System.String? OracleHome
        // GraphQL -> oracleHome: String (scalar)
        if (ec.Includes("oracleHome",true))
        {
            if(this.OracleHome == null) {

                this.OracleHome = "FETCH";

            } else {


            }
        }
        else if (this.OracleHome != null && ec.Excludes("oracleHome",true))
        {
            this.OracleHome = null;
        }
        //      C# -> List<System.String>? PreferredDgMemberUniqueNames
        // GraphQL -> preferredDgMemberUniqueNames: [String!]! (scalar)
        if (ec.Includes("preferredDgMemberUniqueNames",true))
        {
            if(this.PreferredDgMemberUniqueNames == null) {

                this.PreferredDgMemberUniqueNames = new List<System.String>();

            } else {


            }
        }
        else if (this.PreferredDgMemberUniqueNames != null && ec.Excludes("preferredDgMemberUniqueNames",true))
        {
            this.PreferredDgMemberUniqueNames = null;
        }
        //      C# -> System.Int32? SectionSizeInGb
        // GraphQL -> sectionSizeInGb: Int (scalar)
        if (ec.Includes("sectionSizeInGb",true))
        {
            if(this.SectionSizeInGb == null) {

                this.SectionSizeInGb = Int32.MinValue;

            } else {


            }
        }
        else if (this.SectionSizeInGb != null && ec.Excludes("sectionSizeInGb",true))
        {
            this.SectionSizeInGb = null;
        }
        //      C# -> System.Boolean? ShouldBackupFromPrimaryDgGroupMemberOnly
        // GraphQL -> shouldBackupFromPrimaryDgGroupMemberOnly: Boolean (scalar)
        if (ec.Includes("shouldBackupFromPrimaryDgGroupMemberOnly",true))
        {
            if(this.ShouldBackupFromPrimaryDgGroupMemberOnly == null) {

                this.ShouldBackupFromPrimaryDgGroupMemberOnly = true;

            } else {


            }
        }
        else if (this.ShouldBackupFromPrimaryDgGroupMemberOnly != null && ec.Excludes("shouldBackupFromPrimaryDgGroupMemberOnly",true))
        {
            this.ShouldBackupFromPrimaryDgGroupMemberOnly = null;
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
        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        if (ec.Includes("tablespaces",true))
        {
            if(this.Tablespaces == null) {

                this.Tablespaces = new List<System.String>();

            } else {


            }
        }
        else if (this.Tablespaces != null && ec.Excludes("tablespaces",true))
        {
            this.Tablespaces = null;
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
        //      C# -> List<HostInfo>? HostsInfo
        // GraphQL -> hostsInfo: [HostInfo!]! (type)
        if (ec.Includes("hostsInfo",false))
        {
            if(this.HostsInfo == null) {

                this.HostsInfo = new List<HostInfo>();
                this.HostsInfo.ApplyExploratoryFieldSpec(ec.NewChild("hostsInfo"));

            } else {

                this.HostsInfo.ApplyExploratoryFieldSpec(ec.NewChild("hostsInfo"));

            }
        }
        else if (this.HostsInfo != null && ec.Excludes("hostsInfo",false))
        {
            this.HostsInfo = null;
        }
        //      C# -> OracleLastValidationResult? LastValidationResult
        // GraphQL -> lastValidationResult: OracleLastValidationResult (type)
        if (ec.Includes("lastValidationResult",false))
        {
            if(this.LastValidationResult == null) {

                this.LastValidationResult = new OracleLastValidationResult();
                this.LastValidationResult.ApplyExploratoryFieldSpec(ec.NewChild("lastValidationResult"));

            } else {

                this.LastValidationResult.ApplyExploratoryFieldSpec(ec.NewChild("lastValidationResult"));

            }
        }
        else if (this.LastValidationResult != null && ec.Excludes("lastValidationResult",false))
        {
            this.LastValidationResult = null;
        }
        //      C# -> OracleDbSummary? OracleDbSummary
        // GraphQL -> oracleDbSummary: OracleDbSummary (type)
        if (ec.Includes("oracleDbSummary",false))
        {
            if(this.OracleDbSummary == null) {

                this.OracleDbSummary = new OracleDbSummary();
                this.OracleDbSummary.ApplyExploratoryFieldSpec(ec.NewChild("oracleDbSummary"));

            } else {

                this.OracleDbSummary.ApplyExploratoryFieldSpec(ec.NewChild("oracleDbSummary"));

            }
        }
        else if (this.OracleDbSummary != null && ec.Excludes("oracleDbSummary",false))
        {
            this.OracleDbSummary = null;
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (ec.Includes("oracleNonSlaProperties",false))
        {
            if(this.OracleNonSlaProperties == null) {

                this.OracleNonSlaProperties = new OracleNonSlaProperties();
                this.OracleNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("oracleNonSlaProperties"));

            } else {

                this.OracleNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("oracleNonSlaProperties"));

            }
        }
        else if (this.OracleNonSlaProperties != null && ec.Excludes("oracleNonSlaProperties",false))
        {
            this.OracleNonSlaProperties = null;
        }
        //      C# -> OraclePdbDetails? PdbDetails
        // GraphQL -> pdbDetails: OraclePdbDetails (type)
        if (ec.Includes("pdbDetails",false))
        {
            if(this.PdbDetails == null) {

                this.PdbDetails = new OraclePdbDetails();
                this.PdbDetails.ApplyExploratoryFieldSpec(ec.NewChild("pdbDetails"));

            } else {

                this.PdbDetails.ApplyExploratoryFieldSpec(ec.NewChild("pdbDetails"));

            }
        }
        else if (this.PdbDetails != null && ec.Excludes("pdbDetails",false))
        {
            this.PdbDetails = null;
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (ec.Includes("pendingSlaDomain",false))
        {
            if(this.PendingSlaDomain == null) {

                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));

            } else {

                this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));

            }
        }
        else if (this.PendingSlaDomain != null && ec.Excludes("pendingSlaDomain",false))
        {
            this.PendingSlaDomain = null;
        }
    }


    #endregion

    } // class OracleDbDetail
    
    #endregion

    public static class ListOracleDbDetailExtensions
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
            this List<OracleDbDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<OracleDbDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleDbDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleDbDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleDbDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types