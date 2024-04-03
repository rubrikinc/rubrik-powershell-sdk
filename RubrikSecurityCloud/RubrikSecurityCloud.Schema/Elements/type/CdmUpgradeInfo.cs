// CdmUpgradeInfo.cs
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
    #region CdmUpgradeInfo
    public class CdmUpgradeInfo: BaseType
    {
        #region members

        //      C# -> ClusterJobStatusTypeEnum? ClusterJobStatus
        // GraphQL -> clusterJobStatus: ClusterJobStatusTypeEnum (enum)
        [JsonProperty("clusterJobStatus")]
        public ClusterJobStatusTypeEnum? ClusterJobStatus { get; set; }

        //      C# -> VersionStatus? VersionStatus
        // GraphQL -> versionStatus: VersionStatus (enum)
        [JsonProperty("versionStatus")]
        public VersionStatus? VersionStatus { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Single? CurrentStateProgress
        // GraphQL -> currentStateProgress: Float (scalar)
        [JsonProperty("currentStateProgress")]
        public System.Single? CurrentStateProgress { get; set; }

        //      C# -> System.String? DownloadedVersion
        // GraphQL -> downloadedVersion: String (scalar)
        [JsonProperty("downloadedVersion")]
        public System.String? DownloadedVersion { get; set; }

        //      C# -> System.Boolean? FastUpgradePreferred
        // GraphQL -> fastUpgradePreferred: Boolean (scalar)
        [JsonProperty("fastUpgradePreferred")]
        public System.Boolean? FastUpgradePreferred { get; set; }

        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String (scalar)
        [JsonProperty("finishedStates")]
        public System.String? FinishedStates { get; set; }

        //      C# -> System.Single? OverallProgress
        // GraphQL -> overallProgress: Float (scalar)
        [JsonProperty("overallProgress")]
        public System.Single? OverallProgress { get; set; }

        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String (scalar)
        [JsonProperty("pendingStates")]
        public System.String? PendingStates { get; set; }

        //      C# -> System.String? PreviousVersion
        // GraphQL -> previousVersion: String (scalar)
        [JsonProperty("previousVersion")]
        public System.String? PreviousVersion { get; set; }

        //      C# -> System.String? ScheduleUpgradeAction
        // GraphQL -> scheduleUpgradeAction: String (scalar)
        [JsonProperty("scheduleUpgradeAction")]
        public System.String? ScheduleUpgradeAction { get; set; }

        //      C# -> DateTime? ScheduleUpgradeAt
        // GraphQL -> scheduleUpgradeAt: DateTime (scalar)
        [JsonProperty("scheduleUpgradeAt")]
        public DateTime? ScheduleUpgradeAt { get; set; }

        //      C# -> System.String? ScheduleUpgradeMode
        // GraphQL -> scheduleUpgradeMode: String (scalar)
        [JsonProperty("scheduleUpgradeMode")]
        public System.String? ScheduleUpgradeMode { get; set; }

        //      C# -> System.String? StateMachineStatus
        // GraphQL -> stateMachineStatus: String (scalar)
        [JsonProperty("stateMachineStatus")]
        public System.String? StateMachineStatus { get; set; }

        //      C# -> DateTime? StateMachineStatusAt
        // GraphQL -> stateMachineStatusAt: DateTime (scalar)
        [JsonProperty("stateMachineStatusAt")]
        public DateTime? StateMachineStatusAt { get; set; }

        //      C# -> DateTime? UpgradeEndAt
        // GraphQL -> upgradeEndAt: DateTime (scalar)
        [JsonProperty("upgradeEndAt")]
        public DateTime? UpgradeEndAt { get; set; }

        //      C# -> System.String? UpgradeEventSeriesId
        // GraphQL -> upgradeEventSeriesId: String (scalar)
        [JsonProperty("upgradeEventSeriesId")]
        public System.String? UpgradeEventSeriesId { get; set; }

        //      C# -> DateTime? UpgradeStartAt
        // GraphQL -> upgradeStartAt: DateTime (scalar)
        [JsonProperty("upgradeStartAt")]
        public DateTime? UpgradeStartAt { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        [JsonProperty("authorizedOperations")]
        public AuthorizedOperations? AuthorizedOperations { get; set; }

        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        [JsonProperty("cdmClusterNodeDetails")]
        public List<CdmNodeDetail>? CdmClusterNodeDetails { get; set; }

        //      C# -> CdmClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: CdmClusterStatus (type)
        [JsonProperty("clusterStatus")]
        public CdmClusterStatus? ClusterStatus { get; set; }

        //      C# -> UpgradeDurationReply? LastUpgradeDuration
        // GraphQL -> lastUpgradeDuration: UpgradeDurationReply (type)
        [JsonProperty("lastUpgradeDuration")]
        public UpgradeDurationReply? LastUpgradeDuration { get; set; }

        //      C# -> UpgradeRecommendationInfo? UpgradeRecommendationInfo
        // GraphQL -> upgradeRecommendationInfo: UpgradeRecommendationInfo (type)
        [JsonProperty("upgradeRecommendationInfo")]
        public UpgradeRecommendationInfo? UpgradeRecommendationInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmUpgradeInfo";
    }

    public CdmUpgradeInfo Set(
        ClusterJobStatusTypeEnum? ClusterJobStatus = null,
        VersionStatus? VersionStatus = null,
        System.String? ClusterUuid = null,
        System.Single? CurrentStateProgress = null,
        System.String? DownloadedVersion = null,
        System.Boolean? FastUpgradePreferred = null,
        System.String? FinishedStates = null,
        System.Single? OverallProgress = null,
        System.String? PendingStates = null,
        System.String? PreviousVersion = null,
        System.String? ScheduleUpgradeAction = null,
        DateTime? ScheduleUpgradeAt = null,
        System.String? ScheduleUpgradeMode = null,
        System.String? StateMachineStatus = null,
        DateTime? StateMachineStatusAt = null,
        DateTime? UpgradeEndAt = null,
        System.String? UpgradeEventSeriesId = null,
        DateTime? UpgradeStartAt = null,
        System.String? Version = null,
        AuthorizedOperations? AuthorizedOperations = null,
        List<CdmNodeDetail>? CdmClusterNodeDetails = null,
        CdmClusterStatus? ClusterStatus = null,
        UpgradeDurationReply? LastUpgradeDuration = null,
        UpgradeRecommendationInfo? UpgradeRecommendationInfo = null
    ) 
    {
        if ( ClusterJobStatus != null ) {
            this.ClusterJobStatus = ClusterJobStatus;
        }
        if ( VersionStatus != null ) {
            this.VersionStatus = VersionStatus;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( CurrentStateProgress != null ) {
            this.CurrentStateProgress = CurrentStateProgress;
        }
        if ( DownloadedVersion != null ) {
            this.DownloadedVersion = DownloadedVersion;
        }
        if ( FastUpgradePreferred != null ) {
            this.FastUpgradePreferred = FastUpgradePreferred;
        }
        if ( FinishedStates != null ) {
            this.FinishedStates = FinishedStates;
        }
        if ( OverallProgress != null ) {
            this.OverallProgress = OverallProgress;
        }
        if ( PendingStates != null ) {
            this.PendingStates = PendingStates;
        }
        if ( PreviousVersion != null ) {
            this.PreviousVersion = PreviousVersion;
        }
        if ( ScheduleUpgradeAction != null ) {
            this.ScheduleUpgradeAction = ScheduleUpgradeAction;
        }
        if ( ScheduleUpgradeAt != null ) {
            this.ScheduleUpgradeAt = ScheduleUpgradeAt;
        }
        if ( ScheduleUpgradeMode != null ) {
            this.ScheduleUpgradeMode = ScheduleUpgradeMode;
        }
        if ( StateMachineStatus != null ) {
            this.StateMachineStatus = StateMachineStatus;
        }
        if ( StateMachineStatusAt != null ) {
            this.StateMachineStatusAt = StateMachineStatusAt;
        }
        if ( UpgradeEndAt != null ) {
            this.UpgradeEndAt = UpgradeEndAt;
        }
        if ( UpgradeEventSeriesId != null ) {
            this.UpgradeEventSeriesId = UpgradeEventSeriesId;
        }
        if ( UpgradeStartAt != null ) {
            this.UpgradeStartAt = UpgradeStartAt;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( CdmClusterNodeDetails != null ) {
            this.CdmClusterNodeDetails = CdmClusterNodeDetails;
        }
        if ( ClusterStatus != null ) {
            this.ClusterStatus = ClusterStatus;
        }
        if ( LastUpgradeDuration != null ) {
            this.LastUpgradeDuration = LastUpgradeDuration;
        }
        if ( UpgradeRecommendationInfo != null ) {
            this.UpgradeRecommendationInfo = UpgradeRecommendationInfo;
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
        //      C# -> ClusterJobStatusTypeEnum? ClusterJobStatus
        // GraphQL -> clusterJobStatus: ClusterJobStatusTypeEnum (enum)
        if (this.ClusterJobStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterJobStatus\n" ;
            } else {
                s += ind + "clusterJobStatus\n" ;
            }
        }
        //      C# -> VersionStatus? VersionStatus
        // GraphQL -> versionStatus: VersionStatus (enum)
        if (this.VersionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versionStatus\n" ;
            } else {
                s += ind + "versionStatus\n" ;
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
        //      C# -> System.Single? CurrentStateProgress
        // GraphQL -> currentStateProgress: Float (scalar)
        if (this.CurrentStateProgress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentStateProgress\n" ;
            } else {
                s += ind + "currentStateProgress\n" ;
            }
        }
        //      C# -> System.String? DownloadedVersion
        // GraphQL -> downloadedVersion: String (scalar)
        if (this.DownloadedVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadedVersion\n" ;
            } else {
                s += ind + "downloadedVersion\n" ;
            }
        }
        //      C# -> System.Boolean? FastUpgradePreferred
        // GraphQL -> fastUpgradePreferred: Boolean (scalar)
        if (this.FastUpgradePreferred != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fastUpgradePreferred\n" ;
            } else {
                s += ind + "fastUpgradePreferred\n" ;
            }
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String (scalar)
        if (this.FinishedStates != null) {
            if (conf.Flat) {
                s += conf.Prefix + "finishedStates\n" ;
            } else {
                s += ind + "finishedStates\n" ;
            }
        }
        //      C# -> System.Single? OverallProgress
        // GraphQL -> overallProgress: Float (scalar)
        if (this.OverallProgress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "overallProgress\n" ;
            } else {
                s += ind + "overallProgress\n" ;
            }
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String (scalar)
        if (this.PendingStates != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingStates\n" ;
            } else {
                s += ind + "pendingStates\n" ;
            }
        }
        //      C# -> System.String? PreviousVersion
        // GraphQL -> previousVersion: String (scalar)
        if (this.PreviousVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "previousVersion\n" ;
            } else {
                s += ind + "previousVersion\n" ;
            }
        }
        //      C# -> System.String? ScheduleUpgradeAction
        // GraphQL -> scheduleUpgradeAction: String (scalar)
        if (this.ScheduleUpgradeAction != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scheduleUpgradeAction\n" ;
            } else {
                s += ind + "scheduleUpgradeAction\n" ;
            }
        }
        //      C# -> DateTime? ScheduleUpgradeAt
        // GraphQL -> scheduleUpgradeAt: DateTime (scalar)
        if (this.ScheduleUpgradeAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scheduleUpgradeAt\n" ;
            } else {
                s += ind + "scheduleUpgradeAt\n" ;
            }
        }
        //      C# -> System.String? ScheduleUpgradeMode
        // GraphQL -> scheduleUpgradeMode: String (scalar)
        if (this.ScheduleUpgradeMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scheduleUpgradeMode\n" ;
            } else {
                s += ind + "scheduleUpgradeMode\n" ;
            }
        }
        //      C# -> System.String? StateMachineStatus
        // GraphQL -> stateMachineStatus: String (scalar)
        if (this.StateMachineStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stateMachineStatus\n" ;
            } else {
                s += ind + "stateMachineStatus\n" ;
            }
        }
        //      C# -> DateTime? StateMachineStatusAt
        // GraphQL -> stateMachineStatusAt: DateTime (scalar)
        if (this.StateMachineStatusAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stateMachineStatusAt\n" ;
            } else {
                s += ind + "stateMachineStatusAt\n" ;
            }
        }
        //      C# -> DateTime? UpgradeEndAt
        // GraphQL -> upgradeEndAt: DateTime (scalar)
        if (this.UpgradeEndAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeEndAt\n" ;
            } else {
                s += ind + "upgradeEndAt\n" ;
            }
        }
        //      C# -> System.String? UpgradeEventSeriesId
        // GraphQL -> upgradeEventSeriesId: String (scalar)
        if (this.UpgradeEventSeriesId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeEventSeriesId\n" ;
            } else {
                s += ind + "upgradeEventSeriesId\n" ;
            }
        }
        //      C# -> DateTime? UpgradeStartAt
        // GraphQL -> upgradeStartAt: DateTime (scalar)
        if (this.UpgradeStartAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeStartAt\n" ;
            } else {
                s += ind + "upgradeStartAt\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations != null) {
            var fspec = this.AuthorizedOperations.AsFieldSpec(conf.Child("authorizedOperations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "authorizedOperations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (this.CdmClusterNodeDetails != null) {
            var fspec = this.CdmClusterNodeDetails.AsFieldSpec(conf.Child("cdmClusterNodeDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmClusterNodeDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: CdmClusterStatus (type)
        if (this.ClusterStatus != null) {
            var fspec = this.ClusterStatus.AsFieldSpec(conf.Child("clusterStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> UpgradeDurationReply? LastUpgradeDuration
        // GraphQL -> lastUpgradeDuration: UpgradeDurationReply (type)
        if (this.LastUpgradeDuration != null) {
            var fspec = this.LastUpgradeDuration.AsFieldSpec(conf.Child("lastUpgradeDuration"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastUpgradeDuration" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> UpgradeRecommendationInfo? UpgradeRecommendationInfo
        // GraphQL -> upgradeRecommendationInfo: UpgradeRecommendationInfo (type)
        if (this.UpgradeRecommendationInfo != null) {
            var fspec = this.UpgradeRecommendationInfo.AsFieldSpec(conf.Child("upgradeRecommendationInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "upgradeRecommendationInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterJobStatusTypeEnum? ClusterJobStatus
        // GraphQL -> clusterJobStatus: ClusterJobStatusTypeEnum (enum)
        if (ec.Includes("clusterJobStatus",true))
        {
            if(this.ClusterJobStatus == null) {

                this.ClusterJobStatus = new ClusterJobStatusTypeEnum();

            } else {


            }
        }
        else if (this.ClusterJobStatus != null && ec.Excludes("clusterJobStatus",true))
        {
            this.ClusterJobStatus = null;
        }
        //      C# -> VersionStatus? VersionStatus
        // GraphQL -> versionStatus: VersionStatus (enum)
        if (ec.Includes("versionStatus",true))
        {
            if(this.VersionStatus == null) {

                this.VersionStatus = new VersionStatus();

            } else {


            }
        }
        else if (this.VersionStatus != null && ec.Excludes("versionStatus",true))
        {
            this.VersionStatus = null;
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
        //      C# -> System.Single? CurrentStateProgress
        // GraphQL -> currentStateProgress: Float (scalar)
        if (ec.Includes("currentStateProgress",true))
        {
            if(this.CurrentStateProgress == null) {

                this.CurrentStateProgress = new System.Single();

            } else {


            }
        }
        else if (this.CurrentStateProgress != null && ec.Excludes("currentStateProgress",true))
        {
            this.CurrentStateProgress = null;
        }
        //      C# -> System.String? DownloadedVersion
        // GraphQL -> downloadedVersion: String (scalar)
        if (ec.Includes("downloadedVersion",true))
        {
            if(this.DownloadedVersion == null) {

                this.DownloadedVersion = "FETCH";

            } else {


            }
        }
        else if (this.DownloadedVersion != null && ec.Excludes("downloadedVersion",true))
        {
            this.DownloadedVersion = null;
        }
        //      C# -> System.Boolean? FastUpgradePreferred
        // GraphQL -> fastUpgradePreferred: Boolean (scalar)
        if (ec.Includes("fastUpgradePreferred",true))
        {
            if(this.FastUpgradePreferred == null) {

                this.FastUpgradePreferred = true;

            } else {


            }
        }
        else if (this.FastUpgradePreferred != null && ec.Excludes("fastUpgradePreferred",true))
        {
            this.FastUpgradePreferred = null;
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String (scalar)
        if (ec.Includes("finishedStates",true))
        {
            if(this.FinishedStates == null) {

                this.FinishedStates = "FETCH";

            } else {


            }
        }
        else if (this.FinishedStates != null && ec.Excludes("finishedStates",true))
        {
            this.FinishedStates = null;
        }
        //      C# -> System.Single? OverallProgress
        // GraphQL -> overallProgress: Float (scalar)
        if (ec.Includes("overallProgress",true))
        {
            if(this.OverallProgress == null) {

                this.OverallProgress = new System.Single();

            } else {


            }
        }
        else if (this.OverallProgress != null && ec.Excludes("overallProgress",true))
        {
            this.OverallProgress = null;
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String (scalar)
        if (ec.Includes("pendingStates",true))
        {
            if(this.PendingStates == null) {

                this.PendingStates = "FETCH";

            } else {


            }
        }
        else if (this.PendingStates != null && ec.Excludes("pendingStates",true))
        {
            this.PendingStates = null;
        }
        //      C# -> System.String? PreviousVersion
        // GraphQL -> previousVersion: String (scalar)
        if (ec.Includes("previousVersion",true))
        {
            if(this.PreviousVersion == null) {

                this.PreviousVersion = "FETCH";

            } else {


            }
        }
        else if (this.PreviousVersion != null && ec.Excludes("previousVersion",true))
        {
            this.PreviousVersion = null;
        }
        //      C# -> System.String? ScheduleUpgradeAction
        // GraphQL -> scheduleUpgradeAction: String (scalar)
        if (ec.Includes("scheduleUpgradeAction",true))
        {
            if(this.ScheduleUpgradeAction == null) {

                this.ScheduleUpgradeAction = "FETCH";

            } else {


            }
        }
        else if (this.ScheduleUpgradeAction != null && ec.Excludes("scheduleUpgradeAction",true))
        {
            this.ScheduleUpgradeAction = null;
        }
        //      C# -> DateTime? ScheduleUpgradeAt
        // GraphQL -> scheduleUpgradeAt: DateTime (scalar)
        if (ec.Includes("scheduleUpgradeAt",true))
        {
            if(this.ScheduleUpgradeAt == null) {

                this.ScheduleUpgradeAt = new DateTime();

            } else {


            }
        }
        else if (this.ScheduleUpgradeAt != null && ec.Excludes("scheduleUpgradeAt",true))
        {
            this.ScheduleUpgradeAt = null;
        }
        //      C# -> System.String? ScheduleUpgradeMode
        // GraphQL -> scheduleUpgradeMode: String (scalar)
        if (ec.Includes("scheduleUpgradeMode",true))
        {
            if(this.ScheduleUpgradeMode == null) {

                this.ScheduleUpgradeMode = "FETCH";

            } else {


            }
        }
        else if (this.ScheduleUpgradeMode != null && ec.Excludes("scheduleUpgradeMode",true))
        {
            this.ScheduleUpgradeMode = null;
        }
        //      C# -> System.String? StateMachineStatus
        // GraphQL -> stateMachineStatus: String (scalar)
        if (ec.Includes("stateMachineStatus",true))
        {
            if(this.StateMachineStatus == null) {

                this.StateMachineStatus = "FETCH";

            } else {


            }
        }
        else if (this.StateMachineStatus != null && ec.Excludes("stateMachineStatus",true))
        {
            this.StateMachineStatus = null;
        }
        //      C# -> DateTime? StateMachineStatusAt
        // GraphQL -> stateMachineStatusAt: DateTime (scalar)
        if (ec.Includes("stateMachineStatusAt",true))
        {
            if(this.StateMachineStatusAt == null) {

                this.StateMachineStatusAt = new DateTime();

            } else {


            }
        }
        else if (this.StateMachineStatusAt != null && ec.Excludes("stateMachineStatusAt",true))
        {
            this.StateMachineStatusAt = null;
        }
        //      C# -> DateTime? UpgradeEndAt
        // GraphQL -> upgradeEndAt: DateTime (scalar)
        if (ec.Includes("upgradeEndAt",true))
        {
            if(this.UpgradeEndAt == null) {

                this.UpgradeEndAt = new DateTime();

            } else {


            }
        }
        else if (this.UpgradeEndAt != null && ec.Excludes("upgradeEndAt",true))
        {
            this.UpgradeEndAt = null;
        }
        //      C# -> System.String? UpgradeEventSeriesId
        // GraphQL -> upgradeEventSeriesId: String (scalar)
        if (ec.Includes("upgradeEventSeriesId",true))
        {
            if(this.UpgradeEventSeriesId == null) {

                this.UpgradeEventSeriesId = "FETCH";

            } else {


            }
        }
        else if (this.UpgradeEventSeriesId != null && ec.Excludes("upgradeEventSeriesId",true))
        {
            this.UpgradeEventSeriesId = null;
        }
        //      C# -> DateTime? UpgradeStartAt
        // GraphQL -> upgradeStartAt: DateTime (scalar)
        if (ec.Includes("upgradeStartAt",true))
        {
            if(this.UpgradeStartAt == null) {

                this.UpgradeStartAt = new DateTime();

            } else {


            }
        }
        else if (this.UpgradeStartAt != null && ec.Excludes("upgradeStartAt",true))
        {
            this.UpgradeStartAt = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (ec.Includes("authorizedOperations",false))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new AuthorizedOperations();
                this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));

            } else {

                this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));

            }
        }
        else if (this.AuthorizedOperations != null && ec.Excludes("authorizedOperations",false))
        {
            this.AuthorizedOperations = null;
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (ec.Includes("cdmClusterNodeDetails",false))
        {
            if(this.CdmClusterNodeDetails == null) {

                this.CdmClusterNodeDetails = new List<CdmNodeDetail>();
                this.CdmClusterNodeDetails.ApplyExploratoryFieldSpec(ec.NewChild("cdmClusterNodeDetails"));

            } else {

                this.CdmClusterNodeDetails.ApplyExploratoryFieldSpec(ec.NewChild("cdmClusterNodeDetails"));

            }
        }
        else if (this.CdmClusterNodeDetails != null && ec.Excludes("cdmClusterNodeDetails",false))
        {
            this.CdmClusterNodeDetails = null;
        }
        //      C# -> CdmClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: CdmClusterStatus (type)
        if (ec.Includes("clusterStatus",false))
        {
            if(this.ClusterStatus == null) {

                this.ClusterStatus = new CdmClusterStatus();
                this.ClusterStatus.ApplyExploratoryFieldSpec(ec.NewChild("clusterStatus"));

            } else {

                this.ClusterStatus.ApplyExploratoryFieldSpec(ec.NewChild("clusterStatus"));

            }
        }
        else if (this.ClusterStatus != null && ec.Excludes("clusterStatus",false))
        {
            this.ClusterStatus = null;
        }
        //      C# -> UpgradeDurationReply? LastUpgradeDuration
        // GraphQL -> lastUpgradeDuration: UpgradeDurationReply (type)
        if (ec.Includes("lastUpgradeDuration",false))
        {
            if(this.LastUpgradeDuration == null) {

                this.LastUpgradeDuration = new UpgradeDurationReply();
                this.LastUpgradeDuration.ApplyExploratoryFieldSpec(ec.NewChild("lastUpgradeDuration"));

            } else {

                this.LastUpgradeDuration.ApplyExploratoryFieldSpec(ec.NewChild("lastUpgradeDuration"));

            }
        }
        else if (this.LastUpgradeDuration != null && ec.Excludes("lastUpgradeDuration",false))
        {
            this.LastUpgradeDuration = null;
        }
        //      C# -> UpgradeRecommendationInfo? UpgradeRecommendationInfo
        // GraphQL -> upgradeRecommendationInfo: UpgradeRecommendationInfo (type)
        if (ec.Includes("upgradeRecommendationInfo",false))
        {
            if(this.UpgradeRecommendationInfo == null) {

                this.UpgradeRecommendationInfo = new UpgradeRecommendationInfo();
                this.UpgradeRecommendationInfo.ApplyExploratoryFieldSpec(ec.NewChild("upgradeRecommendationInfo"));

            } else {

                this.UpgradeRecommendationInfo.ApplyExploratoryFieldSpec(ec.NewChild("upgradeRecommendationInfo"));

            }
        }
        else if (this.UpgradeRecommendationInfo != null && ec.Excludes("upgradeRecommendationInfo",false))
        {
            this.UpgradeRecommendationInfo = null;
        }
    }


    #endregion

    } // class CdmUpgradeInfo
    
    #endregion

    public static class ListCdmUpgradeInfoExtensions
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
            this List<CdmUpgradeInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmUpgradeInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmUpgradeInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmUpgradeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmUpgradeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types