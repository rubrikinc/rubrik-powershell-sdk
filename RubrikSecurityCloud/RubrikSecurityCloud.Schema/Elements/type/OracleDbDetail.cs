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
        System.String? OracleHome = null,
        List<System.String>? PreferredDgMemberUniqueNames = null,
        System.Int32? SectionSizeInGb = null,
        System.Boolean? ShouldBackupFromPrimaryDgGroupMemberOnly = null,
        System.Int32? SnapshotCount = null,
        List<System.String>? Tablespaces = null,
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String (scalar)
        if (this.DbUniqueName != null) {
            s += ind + "dbUniqueName\n" ;
        }
        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean (scalar)
        if (this.IsLiveMount != null) {
            s += ind + "isLiveMount\n" ;
        }
        //      C# -> System.String? LatestRecoveryPointV50
        // GraphQL -> latestRecoveryPointV50: String (scalar)
        if (this.LatestRecoveryPointV50 != null) {
            s += ind + "latestRecoveryPointV50\n" ;
        }
        //      C# -> System.String? LatestRecoveryPointV51
        // GraphQL -> latestRecoveryPointV51: String (scalar)
        if (this.LatestRecoveryPointV51 != null) {
            s += ind + "latestRecoveryPointV51\n" ;
        }
        //      C# -> System.String? LatestRecoveryPointV52
        // GraphQL -> latestRecoveryPointV52: String (scalar)
        if (this.LatestRecoveryPointV52 != null) {
            s += ind + "latestRecoveryPointV52\n" ;
        }
        //      C# -> System.String? LatestRecoveryPointV53
        // GraphQL -> latestRecoveryPointV53: String (scalar)
        if (this.LatestRecoveryPointV53 != null) {
            s += ind + "latestRecoveryPointV53\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV60
        // GraphQL -> latestRecoveryPointV60: DateTime (scalar)
        if (this.LatestRecoveryPointV60 != null) {
            s += ind + "latestRecoveryPointV60\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV70
        // GraphQL -> latestRecoveryPointV70: DateTime (scalar)
        if (this.LatestRecoveryPointV70 != null) {
            s += ind + "latestRecoveryPointV70\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV80
        // GraphQL -> latestRecoveryPointV80: DateTime (scalar)
        if (this.LatestRecoveryPointV80 != null) {
            s += ind + "latestRecoveryPointV80\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV81
        // GraphQL -> latestRecoveryPointV81: DateTime (scalar)
        if (this.LatestRecoveryPointV81 != null) {
            s += ind + "latestRecoveryPointV81\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV90
        // GraphQL -> latestRecoveryPointV90: DateTime (scalar)
        if (this.LatestRecoveryPointV90 != null) {
            s += ind + "latestRecoveryPointV90\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV91
        // GraphQL -> latestRecoveryPointV91: DateTime (scalar)
        if (this.LatestRecoveryPointV91 != null) {
            s += ind + "latestRecoveryPointV91\n" ;
        }
        //      C# -> System.String? OldestRecoveryPointV50
        // GraphQL -> oldestRecoveryPointV50: String (scalar)
        if (this.OldestRecoveryPointV50 != null) {
            s += ind + "oldestRecoveryPointV50\n" ;
        }
        //      C# -> System.String? OldestRecoveryPointV51
        // GraphQL -> oldestRecoveryPointV51: String (scalar)
        if (this.OldestRecoveryPointV51 != null) {
            s += ind + "oldestRecoveryPointV51\n" ;
        }
        //      C# -> System.String? OldestRecoveryPointV52
        // GraphQL -> oldestRecoveryPointV52: String (scalar)
        if (this.OldestRecoveryPointV52 != null) {
            s += ind + "oldestRecoveryPointV52\n" ;
        }
        //      C# -> System.String? OldestRecoveryPointV53
        // GraphQL -> oldestRecoveryPointV53: String (scalar)
        if (this.OldestRecoveryPointV53 != null) {
            s += ind + "oldestRecoveryPointV53\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV60
        // GraphQL -> oldestRecoveryPointV60: DateTime (scalar)
        if (this.OldestRecoveryPointV60 != null) {
            s += ind + "oldestRecoveryPointV60\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV70
        // GraphQL -> oldestRecoveryPointV70: DateTime (scalar)
        if (this.OldestRecoveryPointV70 != null) {
            s += ind + "oldestRecoveryPointV70\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV80
        // GraphQL -> oldestRecoveryPointV80: DateTime (scalar)
        if (this.OldestRecoveryPointV80 != null) {
            s += ind + "oldestRecoveryPointV80\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV81
        // GraphQL -> oldestRecoveryPointV81: DateTime (scalar)
        if (this.OldestRecoveryPointV81 != null) {
            s += ind + "oldestRecoveryPointV81\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV90
        // GraphQL -> oldestRecoveryPointV90: DateTime (scalar)
        if (this.OldestRecoveryPointV90 != null) {
            s += ind + "oldestRecoveryPointV90\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV91
        // GraphQL -> oldestRecoveryPointV91: DateTime (scalar)
        if (this.OldestRecoveryPointV91 != null) {
            s += ind + "oldestRecoveryPointV91\n" ;
        }
        //      C# -> System.String? OracleHome
        // GraphQL -> oracleHome: String (scalar)
        if (this.OracleHome != null) {
            s += ind + "oracleHome\n" ;
        }
        //      C# -> List<System.String>? PreferredDgMemberUniqueNames
        // GraphQL -> preferredDgMemberUniqueNames: [String!]! (scalar)
        if (this.PreferredDgMemberUniqueNames != null) {
            s += ind + "preferredDgMemberUniqueNames\n" ;
        }
        //      C# -> System.Int32? SectionSizeInGb
        // GraphQL -> sectionSizeInGb: Int (scalar)
        if (this.SectionSizeInGb != null) {
            s += ind + "sectionSizeInGb\n" ;
        }
        //      C# -> System.Boolean? ShouldBackupFromPrimaryDgGroupMemberOnly
        // GraphQL -> shouldBackupFromPrimaryDgGroupMemberOnly: Boolean (scalar)
        if (this.ShouldBackupFromPrimaryDgGroupMemberOnly != null) {
            s += ind + "shouldBackupFromPrimaryDgGroupMemberOnly\n" ;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount != null) {
            s += ind + "snapshotCount\n" ;
        }
        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        if (this.Tablespaces != null) {
            s += ind + "tablespaces\n" ;
        }
        //      C# -> List<HostInfo>? HostsInfo
        // GraphQL -> hostsInfo: [HostInfo!]! (type)
        if (this.HostsInfo != null) {
            var fspec = this.HostsInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hostsInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OracleLastValidationResult? LastValidationResult
        // GraphQL -> lastValidationResult: OracleLastValidationResult (type)
        if (this.LastValidationResult != null) {
            var fspec = this.LastValidationResult.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lastValidationResult {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OracleDbSummary? OracleDbSummary
        // GraphQL -> oracleDbSummary: OracleDbSummary (type)
        if (this.OracleDbSummary != null) {
            var fspec = this.OracleDbSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oracleDbSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (this.OracleNonSlaProperties != null) {
            var fspec = this.OracleNonSlaProperties.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oracleNonSlaProperties {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OraclePdbDetails? PdbDetails
        // GraphQL -> pdbDetails: OraclePdbDetails (type)
        if (this.PdbDetails != null) {
            var fspec = this.PdbDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pdbDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            var fspec = this.PendingSlaDomain.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingSlaDomain {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String (scalar)
        if (this.DbUniqueName == null && ec.Includes("dbUniqueName",true))
        {
            this.DbUniqueName = "FETCH";
        }
        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean (scalar)
        if (this.IsLiveMount == null && ec.Includes("isLiveMount",true))
        {
            this.IsLiveMount = true;
        }
        //      C# -> System.String? LatestRecoveryPointV50
        // GraphQL -> latestRecoveryPointV50: String (scalar)
        if (this.LatestRecoveryPointV50 == null && ec.Includes("latestRecoveryPointV50",true))
        {
            this.LatestRecoveryPointV50 = "FETCH";
        }
        //      C# -> System.String? LatestRecoveryPointV51
        // GraphQL -> latestRecoveryPointV51: String (scalar)
        if (this.LatestRecoveryPointV51 == null && ec.Includes("latestRecoveryPointV51",true))
        {
            this.LatestRecoveryPointV51 = "FETCH";
        }
        //      C# -> System.String? LatestRecoveryPointV52
        // GraphQL -> latestRecoveryPointV52: String (scalar)
        if (this.LatestRecoveryPointV52 == null && ec.Includes("latestRecoveryPointV52",true))
        {
            this.LatestRecoveryPointV52 = "FETCH";
        }
        //      C# -> System.String? LatestRecoveryPointV53
        // GraphQL -> latestRecoveryPointV53: String (scalar)
        if (this.LatestRecoveryPointV53 == null && ec.Includes("latestRecoveryPointV53",true))
        {
            this.LatestRecoveryPointV53 = "FETCH";
        }
        //      C# -> DateTime? LatestRecoveryPointV60
        // GraphQL -> latestRecoveryPointV60: DateTime (scalar)
        if (this.LatestRecoveryPointV60 == null && ec.Includes("latestRecoveryPointV60",true))
        {
            this.LatestRecoveryPointV60 = new DateTime();
        }
        //      C# -> DateTime? LatestRecoveryPointV70
        // GraphQL -> latestRecoveryPointV70: DateTime (scalar)
        if (this.LatestRecoveryPointV70 == null && ec.Includes("latestRecoveryPointV70",true))
        {
            this.LatestRecoveryPointV70 = new DateTime();
        }
        //      C# -> DateTime? LatestRecoveryPointV80
        // GraphQL -> latestRecoveryPointV80: DateTime (scalar)
        if (this.LatestRecoveryPointV80 == null && ec.Includes("latestRecoveryPointV80",true))
        {
            this.LatestRecoveryPointV80 = new DateTime();
        }
        //      C# -> DateTime? LatestRecoveryPointV81
        // GraphQL -> latestRecoveryPointV81: DateTime (scalar)
        if (this.LatestRecoveryPointV81 == null && ec.Includes("latestRecoveryPointV81",true))
        {
            this.LatestRecoveryPointV81 = new DateTime();
        }
        //      C# -> DateTime? LatestRecoveryPointV90
        // GraphQL -> latestRecoveryPointV90: DateTime (scalar)
        if (this.LatestRecoveryPointV90 == null && ec.Includes("latestRecoveryPointV90",true))
        {
            this.LatestRecoveryPointV90 = new DateTime();
        }
        //      C# -> DateTime? LatestRecoveryPointV91
        // GraphQL -> latestRecoveryPointV91: DateTime (scalar)
        if (this.LatestRecoveryPointV91 == null && ec.Includes("latestRecoveryPointV91",true))
        {
            this.LatestRecoveryPointV91 = new DateTime();
        }
        //      C# -> System.String? OldestRecoveryPointV50
        // GraphQL -> oldestRecoveryPointV50: String (scalar)
        if (this.OldestRecoveryPointV50 == null && ec.Includes("oldestRecoveryPointV50",true))
        {
            this.OldestRecoveryPointV50 = "FETCH";
        }
        //      C# -> System.String? OldestRecoveryPointV51
        // GraphQL -> oldestRecoveryPointV51: String (scalar)
        if (this.OldestRecoveryPointV51 == null && ec.Includes("oldestRecoveryPointV51",true))
        {
            this.OldestRecoveryPointV51 = "FETCH";
        }
        //      C# -> System.String? OldestRecoveryPointV52
        // GraphQL -> oldestRecoveryPointV52: String (scalar)
        if (this.OldestRecoveryPointV52 == null && ec.Includes("oldestRecoveryPointV52",true))
        {
            this.OldestRecoveryPointV52 = "FETCH";
        }
        //      C# -> System.String? OldestRecoveryPointV53
        // GraphQL -> oldestRecoveryPointV53: String (scalar)
        if (this.OldestRecoveryPointV53 == null && ec.Includes("oldestRecoveryPointV53",true))
        {
            this.OldestRecoveryPointV53 = "FETCH";
        }
        //      C# -> DateTime? OldestRecoveryPointV60
        // GraphQL -> oldestRecoveryPointV60: DateTime (scalar)
        if (this.OldestRecoveryPointV60 == null && ec.Includes("oldestRecoveryPointV60",true))
        {
            this.OldestRecoveryPointV60 = new DateTime();
        }
        //      C# -> DateTime? OldestRecoveryPointV70
        // GraphQL -> oldestRecoveryPointV70: DateTime (scalar)
        if (this.OldestRecoveryPointV70 == null && ec.Includes("oldestRecoveryPointV70",true))
        {
            this.OldestRecoveryPointV70 = new DateTime();
        }
        //      C# -> DateTime? OldestRecoveryPointV80
        // GraphQL -> oldestRecoveryPointV80: DateTime (scalar)
        if (this.OldestRecoveryPointV80 == null && ec.Includes("oldestRecoveryPointV80",true))
        {
            this.OldestRecoveryPointV80 = new DateTime();
        }
        //      C# -> DateTime? OldestRecoveryPointV81
        // GraphQL -> oldestRecoveryPointV81: DateTime (scalar)
        if (this.OldestRecoveryPointV81 == null && ec.Includes("oldestRecoveryPointV81",true))
        {
            this.OldestRecoveryPointV81 = new DateTime();
        }
        //      C# -> DateTime? OldestRecoveryPointV90
        // GraphQL -> oldestRecoveryPointV90: DateTime (scalar)
        if (this.OldestRecoveryPointV90 == null && ec.Includes("oldestRecoveryPointV90",true))
        {
            this.OldestRecoveryPointV90 = new DateTime();
        }
        //      C# -> DateTime? OldestRecoveryPointV91
        // GraphQL -> oldestRecoveryPointV91: DateTime (scalar)
        if (this.OldestRecoveryPointV91 == null && ec.Includes("oldestRecoveryPointV91",true))
        {
            this.OldestRecoveryPointV91 = new DateTime();
        }
        //      C# -> System.String? OracleHome
        // GraphQL -> oracleHome: String (scalar)
        if (this.OracleHome == null && ec.Includes("oracleHome",true))
        {
            this.OracleHome = "FETCH";
        }
        //      C# -> List<System.String>? PreferredDgMemberUniqueNames
        // GraphQL -> preferredDgMemberUniqueNames: [String!]! (scalar)
        if (this.PreferredDgMemberUniqueNames == null && ec.Includes("preferredDgMemberUniqueNames",true))
        {
            this.PreferredDgMemberUniqueNames = new List<System.String>();
        }
        //      C# -> System.Int32? SectionSizeInGb
        // GraphQL -> sectionSizeInGb: Int (scalar)
        if (this.SectionSizeInGb == null && ec.Includes("sectionSizeInGb",true))
        {
            this.SectionSizeInGb = Int32.MinValue;
        }
        //      C# -> System.Boolean? ShouldBackupFromPrimaryDgGroupMemberOnly
        // GraphQL -> shouldBackupFromPrimaryDgGroupMemberOnly: Boolean (scalar)
        if (this.ShouldBackupFromPrimaryDgGroupMemberOnly == null && ec.Includes("shouldBackupFromPrimaryDgGroupMemberOnly",true))
        {
            this.ShouldBackupFromPrimaryDgGroupMemberOnly = true;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount == null && ec.Includes("snapshotCount",true))
        {
            this.SnapshotCount = Int32.MinValue;
        }
        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        if (this.Tablespaces == null && ec.Includes("tablespaces",true))
        {
            this.Tablespaces = new List<System.String>();
        }
        //      C# -> List<HostInfo>? HostsInfo
        // GraphQL -> hostsInfo: [HostInfo!]! (type)
        if (this.HostsInfo == null && ec.Includes("hostsInfo",false))
        {
            this.HostsInfo = new List<HostInfo>();
            this.HostsInfo.ApplyExploratoryFieldSpec(ec.NewChild("hostsInfo"));
        }
        //      C# -> OracleLastValidationResult? LastValidationResult
        // GraphQL -> lastValidationResult: OracleLastValidationResult (type)
        if (this.LastValidationResult == null && ec.Includes("lastValidationResult",false))
        {
            this.LastValidationResult = new OracleLastValidationResult();
            this.LastValidationResult.ApplyExploratoryFieldSpec(ec.NewChild("lastValidationResult"));
        }
        //      C# -> OracleDbSummary? OracleDbSummary
        // GraphQL -> oracleDbSummary: OracleDbSummary (type)
        if (this.OracleDbSummary == null && ec.Includes("oracleDbSummary",false))
        {
            this.OracleDbSummary = new OracleDbSummary();
            this.OracleDbSummary.ApplyExploratoryFieldSpec(ec.NewChild("oracleDbSummary"));
        }
        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        if (this.OracleNonSlaProperties == null && ec.Includes("oracleNonSlaProperties",false))
        {
            this.OracleNonSlaProperties = new OracleNonSlaProperties();
            this.OracleNonSlaProperties.ApplyExploratoryFieldSpec(ec.NewChild("oracleNonSlaProperties"));
        }
        //      C# -> OraclePdbDetails? PdbDetails
        // GraphQL -> pdbDetails: OraclePdbDetails (type)
        if (this.PdbDetails == null && ec.Includes("pdbDetails",false))
        {
            this.PdbDetails = new OraclePdbDetails();
            this.PdbDetails.ApplyExploratoryFieldSpec(ec.NewChild("pdbDetails"));
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain == null && ec.Includes("pendingSlaDomain",false))
        {
            this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
            this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<OracleDbDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types