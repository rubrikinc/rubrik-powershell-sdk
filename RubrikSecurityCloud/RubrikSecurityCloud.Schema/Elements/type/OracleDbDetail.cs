// OracleDbDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:33.
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
    #region OracleDbDetail
    public class OracleDbDetail: IFragment
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
        System.String? OldestRecoveryPointV50 = null,
        System.String? OldestRecoveryPointV51 = null,
        System.String? OldestRecoveryPointV52 = null,
        System.String? OldestRecoveryPointV53 = null,
        DateTime? OldestRecoveryPointV60 = null,
        DateTime? OldestRecoveryPointV70 = null,
        DateTime? OldestRecoveryPointV80 = null,
        DateTime? OldestRecoveryPointV81 = null,
        DateTime? OldestRecoveryPointV90 = null,
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? DbUniqueName
            // GraphQL -> dbUniqueName: String (scalar)
            if (this.DbUniqueName != null)
            {
                 s += ind + "dbUniqueName\n";

            }
            //      C# -> System.Boolean? IsLiveMount
            // GraphQL -> isLiveMount: Boolean (scalar)
            if (this.IsLiveMount != null)
            {
                 s += ind + "isLiveMount\n";

            }
            //      C# -> System.String? LatestRecoveryPointV50
            // GraphQL -> latestRecoveryPointV50: String (scalar)
            if (this.LatestRecoveryPointV50 != null)
            {
                 s += ind + "latestRecoveryPointV50\n";

            }
            //      C# -> System.String? LatestRecoveryPointV51
            // GraphQL -> latestRecoveryPointV51: String (scalar)
            if (this.LatestRecoveryPointV51 != null)
            {
                 s += ind + "latestRecoveryPointV51\n";

            }
            //      C# -> System.String? LatestRecoveryPointV52
            // GraphQL -> latestRecoveryPointV52: String (scalar)
            if (this.LatestRecoveryPointV52 != null)
            {
                 s += ind + "latestRecoveryPointV52\n";

            }
            //      C# -> System.String? LatestRecoveryPointV53
            // GraphQL -> latestRecoveryPointV53: String (scalar)
            if (this.LatestRecoveryPointV53 != null)
            {
                 s += ind + "latestRecoveryPointV53\n";

            }
            //      C# -> DateTime? LatestRecoveryPointV60
            // GraphQL -> latestRecoveryPointV60: DateTime (scalar)
            if (this.LatestRecoveryPointV60 != null)
            {
                 s += ind + "latestRecoveryPointV60\n";

            }
            //      C# -> DateTime? LatestRecoveryPointV70
            // GraphQL -> latestRecoveryPointV70: DateTime (scalar)
            if (this.LatestRecoveryPointV70 != null)
            {
                 s += ind + "latestRecoveryPointV70\n";

            }
            //      C# -> DateTime? LatestRecoveryPointV80
            // GraphQL -> latestRecoveryPointV80: DateTime (scalar)
            if (this.LatestRecoveryPointV80 != null)
            {
                 s += ind + "latestRecoveryPointV80\n";

            }
            //      C# -> DateTime? LatestRecoveryPointV81
            // GraphQL -> latestRecoveryPointV81: DateTime (scalar)
            if (this.LatestRecoveryPointV81 != null)
            {
                 s += ind + "latestRecoveryPointV81\n";

            }
            //      C# -> DateTime? LatestRecoveryPointV90
            // GraphQL -> latestRecoveryPointV90: DateTime (scalar)
            if (this.LatestRecoveryPointV90 != null)
            {
                 s += ind + "latestRecoveryPointV90\n";

            }
            //      C# -> System.String? OldestRecoveryPointV50
            // GraphQL -> oldestRecoveryPointV50: String (scalar)
            if (this.OldestRecoveryPointV50 != null)
            {
                 s += ind + "oldestRecoveryPointV50\n";

            }
            //      C# -> System.String? OldestRecoveryPointV51
            // GraphQL -> oldestRecoveryPointV51: String (scalar)
            if (this.OldestRecoveryPointV51 != null)
            {
                 s += ind + "oldestRecoveryPointV51\n";

            }
            //      C# -> System.String? OldestRecoveryPointV52
            // GraphQL -> oldestRecoveryPointV52: String (scalar)
            if (this.OldestRecoveryPointV52 != null)
            {
                 s += ind + "oldestRecoveryPointV52\n";

            }
            //      C# -> System.String? OldestRecoveryPointV53
            // GraphQL -> oldestRecoveryPointV53: String (scalar)
            if (this.OldestRecoveryPointV53 != null)
            {
                 s += ind + "oldestRecoveryPointV53\n";

            }
            //      C# -> DateTime? OldestRecoveryPointV60
            // GraphQL -> oldestRecoveryPointV60: DateTime (scalar)
            if (this.OldestRecoveryPointV60 != null)
            {
                 s += ind + "oldestRecoveryPointV60\n";

            }
            //      C# -> DateTime? OldestRecoveryPointV70
            // GraphQL -> oldestRecoveryPointV70: DateTime (scalar)
            if (this.OldestRecoveryPointV70 != null)
            {
                 s += ind + "oldestRecoveryPointV70\n";

            }
            //      C# -> DateTime? OldestRecoveryPointV80
            // GraphQL -> oldestRecoveryPointV80: DateTime (scalar)
            if (this.OldestRecoveryPointV80 != null)
            {
                 s += ind + "oldestRecoveryPointV80\n";

            }
            //      C# -> DateTime? OldestRecoveryPointV81
            // GraphQL -> oldestRecoveryPointV81: DateTime (scalar)
            if (this.OldestRecoveryPointV81 != null)
            {
                 s += ind + "oldestRecoveryPointV81\n";

            }
            //      C# -> DateTime? OldestRecoveryPointV90
            // GraphQL -> oldestRecoveryPointV90: DateTime (scalar)
            if (this.OldestRecoveryPointV90 != null)
            {
                 s += ind + "oldestRecoveryPointV90\n";

            }
            //      C# -> System.String? OracleHome
            // GraphQL -> oracleHome: String (scalar)
            if (this.OracleHome != null)
            {
                 s += ind + "oracleHome\n";

            }
            //      C# -> List<System.String>? PreferredDgMemberUniqueNames
            // GraphQL -> preferredDgMemberUniqueNames: [String!]! (scalar)
            if (this.PreferredDgMemberUniqueNames != null)
            {
                 s += ind + "preferredDgMemberUniqueNames\n";

            }
            //      C# -> System.Int32? SectionSizeInGb
            // GraphQL -> sectionSizeInGb: Int (scalar)
            if (this.SectionSizeInGb != null)
            {
                 s += ind + "sectionSizeInGb\n";

            }
            //      C# -> System.Boolean? ShouldBackupFromPrimaryDgGroupMemberOnly
            // GraphQL -> shouldBackupFromPrimaryDgGroupMemberOnly: Boolean (scalar)
            if (this.ShouldBackupFromPrimaryDgGroupMemberOnly != null)
            {
                 s += ind + "shouldBackupFromPrimaryDgGroupMemberOnly\n";

            }
            //      C# -> System.Int32? SnapshotCount
            // GraphQL -> snapshotCount: Int! (scalar)
            if (this.SnapshotCount != null)
            {
                 s += ind + "snapshotCount\n";

            }
            //      C# -> List<System.String>? Tablespaces
            // GraphQL -> tablespaces: [String!]! (scalar)
            if (this.Tablespaces != null)
            {
                 s += ind + "tablespaces\n";

            }
            //      C# -> List<HostInfo>? HostsInfo
            // GraphQL -> hostsInfo: [HostInfo!]! (type)
            if (this.HostsInfo != null)
            {
                 s += ind + "hostsInfo\n";

                 s += ind + "{\n" + 
                 this.HostsInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleLastValidationResult? LastValidationResult
            // GraphQL -> lastValidationResult: OracleLastValidationResult (type)
            if (this.LastValidationResult != null)
            {
                 s += ind + "lastValidationResult\n";

                 s += ind + "{\n" + 
                 this.LastValidationResult.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleDbSummary? OracleDbSummary
            // GraphQL -> oracleDbSummary: OracleDbSummary (type)
            if (this.OracleDbSummary != null)
            {
                 s += ind + "oracleDbSummary\n";

                 s += ind + "{\n" + 
                 this.OracleDbSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
            // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
            if (this.OracleNonSlaProperties != null)
            {
                 s += ind + "oracleNonSlaProperties\n";

                 s += ind + "{\n" + 
                 this.OracleNonSlaProperties.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OraclePdbDetails? PdbDetails
            // GraphQL -> pdbDetails: OraclePdbDetails (type)
            if (this.PdbDetails != null)
            {
                 s += ind + "pdbDetails\n";

                 s += ind + "{\n" + 
                 this.PdbDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain != null)
            {
                 s += ind + "pendingSlaDomain\n";

                 s += ind + "{\n" + 
                 this.PendingSlaDomain.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DbUniqueName
            // GraphQL -> dbUniqueName: String (scalar)
            if (this.DbUniqueName == null && Exploration.Includes(parent + ".dbUniqueName$"))
            {
                this.DbUniqueName = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsLiveMount
            // GraphQL -> isLiveMount: Boolean (scalar)
            if (this.IsLiveMount == null && Exploration.Includes(parent + ".isLiveMount$"))
            {
                this.IsLiveMount = new System.Boolean();
            }
            //      C# -> System.String? LatestRecoveryPointV50
            // GraphQL -> latestRecoveryPointV50: String (scalar)
            if (this.LatestRecoveryPointV50 == null && Exploration.Includes(parent + ".latestRecoveryPointV50$"))
            {
                this.LatestRecoveryPointV50 = new System.String("FETCH");
            }
            //      C# -> System.String? LatestRecoveryPointV51
            // GraphQL -> latestRecoveryPointV51: String (scalar)
            if (this.LatestRecoveryPointV51 == null && Exploration.Includes(parent + ".latestRecoveryPointV51$"))
            {
                this.LatestRecoveryPointV51 = new System.String("FETCH");
            }
            //      C# -> System.String? LatestRecoveryPointV52
            // GraphQL -> latestRecoveryPointV52: String (scalar)
            if (this.LatestRecoveryPointV52 == null && Exploration.Includes(parent + ".latestRecoveryPointV52$"))
            {
                this.LatestRecoveryPointV52 = new System.String("FETCH");
            }
            //      C# -> System.String? LatestRecoveryPointV53
            // GraphQL -> latestRecoveryPointV53: String (scalar)
            if (this.LatestRecoveryPointV53 == null && Exploration.Includes(parent + ".latestRecoveryPointV53$"))
            {
                this.LatestRecoveryPointV53 = new System.String("FETCH");
            }
            //      C# -> DateTime? LatestRecoveryPointV60
            // GraphQL -> latestRecoveryPointV60: DateTime (scalar)
            if (this.LatestRecoveryPointV60 == null && Exploration.Includes(parent + ".latestRecoveryPointV60$"))
            {
                this.LatestRecoveryPointV60 = new DateTime();
            }
            //      C# -> DateTime? LatestRecoveryPointV70
            // GraphQL -> latestRecoveryPointV70: DateTime (scalar)
            if (this.LatestRecoveryPointV70 == null && Exploration.Includes(parent + ".latestRecoveryPointV70$"))
            {
                this.LatestRecoveryPointV70 = new DateTime();
            }
            //      C# -> DateTime? LatestRecoveryPointV80
            // GraphQL -> latestRecoveryPointV80: DateTime (scalar)
            if (this.LatestRecoveryPointV80 == null && Exploration.Includes(parent + ".latestRecoveryPointV80$"))
            {
                this.LatestRecoveryPointV80 = new DateTime();
            }
            //      C# -> DateTime? LatestRecoveryPointV81
            // GraphQL -> latestRecoveryPointV81: DateTime (scalar)
            if (this.LatestRecoveryPointV81 == null && Exploration.Includes(parent + ".latestRecoveryPointV81$"))
            {
                this.LatestRecoveryPointV81 = new DateTime();
            }
            //      C# -> DateTime? LatestRecoveryPointV90
            // GraphQL -> latestRecoveryPointV90: DateTime (scalar)
            if (this.LatestRecoveryPointV90 == null && Exploration.Includes(parent + ".latestRecoveryPointV90$"))
            {
                this.LatestRecoveryPointV90 = new DateTime();
            }
            //      C# -> System.String? OldestRecoveryPointV50
            // GraphQL -> oldestRecoveryPointV50: String (scalar)
            if (this.OldestRecoveryPointV50 == null && Exploration.Includes(parent + ".oldestRecoveryPointV50$"))
            {
                this.OldestRecoveryPointV50 = new System.String("FETCH");
            }
            //      C# -> System.String? OldestRecoveryPointV51
            // GraphQL -> oldestRecoveryPointV51: String (scalar)
            if (this.OldestRecoveryPointV51 == null && Exploration.Includes(parent + ".oldestRecoveryPointV51$"))
            {
                this.OldestRecoveryPointV51 = new System.String("FETCH");
            }
            //      C# -> System.String? OldestRecoveryPointV52
            // GraphQL -> oldestRecoveryPointV52: String (scalar)
            if (this.OldestRecoveryPointV52 == null && Exploration.Includes(parent + ".oldestRecoveryPointV52$"))
            {
                this.OldestRecoveryPointV52 = new System.String("FETCH");
            }
            //      C# -> System.String? OldestRecoveryPointV53
            // GraphQL -> oldestRecoveryPointV53: String (scalar)
            if (this.OldestRecoveryPointV53 == null && Exploration.Includes(parent + ".oldestRecoveryPointV53$"))
            {
                this.OldestRecoveryPointV53 = new System.String("FETCH");
            }
            //      C# -> DateTime? OldestRecoveryPointV60
            // GraphQL -> oldestRecoveryPointV60: DateTime (scalar)
            if (this.OldestRecoveryPointV60 == null && Exploration.Includes(parent + ".oldestRecoveryPointV60$"))
            {
                this.OldestRecoveryPointV60 = new DateTime();
            }
            //      C# -> DateTime? OldestRecoveryPointV70
            // GraphQL -> oldestRecoveryPointV70: DateTime (scalar)
            if (this.OldestRecoveryPointV70 == null && Exploration.Includes(parent + ".oldestRecoveryPointV70$"))
            {
                this.OldestRecoveryPointV70 = new DateTime();
            }
            //      C# -> DateTime? OldestRecoveryPointV80
            // GraphQL -> oldestRecoveryPointV80: DateTime (scalar)
            if (this.OldestRecoveryPointV80 == null && Exploration.Includes(parent + ".oldestRecoveryPointV80$"))
            {
                this.OldestRecoveryPointV80 = new DateTime();
            }
            //      C# -> DateTime? OldestRecoveryPointV81
            // GraphQL -> oldestRecoveryPointV81: DateTime (scalar)
            if (this.OldestRecoveryPointV81 == null && Exploration.Includes(parent + ".oldestRecoveryPointV81$"))
            {
                this.OldestRecoveryPointV81 = new DateTime();
            }
            //      C# -> DateTime? OldestRecoveryPointV90
            // GraphQL -> oldestRecoveryPointV90: DateTime (scalar)
            if (this.OldestRecoveryPointV90 == null && Exploration.Includes(parent + ".oldestRecoveryPointV90$"))
            {
                this.OldestRecoveryPointV90 = new DateTime();
            }
            //      C# -> System.String? OracleHome
            // GraphQL -> oracleHome: String (scalar)
            if (this.OracleHome == null && Exploration.Includes(parent + ".oracleHome$"))
            {
                this.OracleHome = new System.String("FETCH");
            }
            //      C# -> List<System.String>? PreferredDgMemberUniqueNames
            // GraphQL -> preferredDgMemberUniqueNames: [String!]! (scalar)
            if (this.PreferredDgMemberUniqueNames == null && Exploration.Includes(parent + ".preferredDgMemberUniqueNames$"))
            {
                this.PreferredDgMemberUniqueNames = new List<System.String>();
            }
            //      C# -> System.Int32? SectionSizeInGb
            // GraphQL -> sectionSizeInGb: Int (scalar)
            if (this.SectionSizeInGb == null && Exploration.Includes(parent + ".sectionSizeInGb$"))
            {
                this.SectionSizeInGb = new System.Int32();
            }
            //      C# -> System.Boolean? ShouldBackupFromPrimaryDgGroupMemberOnly
            // GraphQL -> shouldBackupFromPrimaryDgGroupMemberOnly: Boolean (scalar)
            if (this.ShouldBackupFromPrimaryDgGroupMemberOnly == null && Exploration.Includes(parent + ".shouldBackupFromPrimaryDgGroupMemberOnly$"))
            {
                this.ShouldBackupFromPrimaryDgGroupMemberOnly = new System.Boolean();
            }
            //      C# -> System.Int32? SnapshotCount
            // GraphQL -> snapshotCount: Int! (scalar)
            if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount$"))
            {
                this.SnapshotCount = new System.Int32();
            }
            //      C# -> List<System.String>? Tablespaces
            // GraphQL -> tablespaces: [String!]! (scalar)
            if (this.Tablespaces == null && Exploration.Includes(parent + ".tablespaces$"))
            {
                this.Tablespaces = new List<System.String>();
            }
            //      C# -> List<HostInfo>? HostsInfo
            // GraphQL -> hostsInfo: [HostInfo!]! (type)
            if (this.HostsInfo == null && Exploration.Includes(parent + ".hostsInfo"))
            {
                this.HostsInfo = new List<HostInfo>();
                this.HostsInfo.ApplyExploratoryFragment(parent + ".hostsInfo");
            }
            //      C# -> OracleLastValidationResult? LastValidationResult
            // GraphQL -> lastValidationResult: OracleLastValidationResult (type)
            if (this.LastValidationResult == null && Exploration.Includes(parent + ".lastValidationResult"))
            {
                this.LastValidationResult = new OracleLastValidationResult();
                this.LastValidationResult.ApplyExploratoryFragment(parent + ".lastValidationResult");
            }
            //      C# -> OracleDbSummary? OracleDbSummary
            // GraphQL -> oracleDbSummary: OracleDbSummary (type)
            if (this.OracleDbSummary == null && Exploration.Includes(parent + ".oracleDbSummary"))
            {
                this.OracleDbSummary = new OracleDbSummary();
                this.OracleDbSummary.ApplyExploratoryFragment(parent + ".oracleDbSummary");
            }
            //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
            // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
            if (this.OracleNonSlaProperties == null && Exploration.Includes(parent + ".oracleNonSlaProperties"))
            {
                this.OracleNonSlaProperties = new OracleNonSlaProperties();
                this.OracleNonSlaProperties.ApplyExploratoryFragment(parent + ".oracleNonSlaProperties");
            }
            //      C# -> OraclePdbDetails? PdbDetails
            // GraphQL -> pdbDetails: OraclePdbDetails (type)
            if (this.PdbDetails == null && Exploration.Includes(parent + ".pdbDetails"))
            {
                this.PdbDetails = new OraclePdbDetails();
                this.PdbDetails.ApplyExploratoryFragment(parent + ".pdbDetails");
            }
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
            {
                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFragment(parent + ".pendingSlaDomain");
            }
        }


    #endregion

    } // class OracleDbDetail
    #endregion

    public static class ListOracleDbDetailExtensions
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
            this List<OracleDbDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleDbDetail> list, 
            String parent = "")
        {
            var item = new OracleDbDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types