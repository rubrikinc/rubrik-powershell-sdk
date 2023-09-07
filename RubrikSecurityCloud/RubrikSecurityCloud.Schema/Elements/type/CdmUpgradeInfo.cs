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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ClusterJobStatusTypeEnum? ClusterJobStatus
        // GraphQL -> clusterJobStatus: ClusterJobStatusTypeEnum (enum)
        if (this.ClusterJobStatus != null) {
            s += ind + "clusterJobStatus\n" ;
        }
        //      C# -> VersionStatus? VersionStatus
        // GraphQL -> versionStatus: VersionStatus (enum)
        if (this.VersionStatus != null) {
            s += ind + "versionStatus\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.Single? CurrentStateProgress
        // GraphQL -> currentStateProgress: Float (scalar)
        if (this.CurrentStateProgress != null) {
            s += ind + "currentStateProgress\n" ;
        }
        //      C# -> System.String? DownloadedVersion
        // GraphQL -> downloadedVersion: String (scalar)
        if (this.DownloadedVersion != null) {
            s += ind + "downloadedVersion\n" ;
        }
        //      C# -> System.Boolean? FastUpgradePreferred
        // GraphQL -> fastUpgradePreferred: Boolean (scalar)
        if (this.FastUpgradePreferred != null) {
            s += ind + "fastUpgradePreferred\n" ;
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String (scalar)
        if (this.FinishedStates != null) {
            s += ind + "finishedStates\n" ;
        }
        //      C# -> System.Single? OverallProgress
        // GraphQL -> overallProgress: Float (scalar)
        if (this.OverallProgress != null) {
            s += ind + "overallProgress\n" ;
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String (scalar)
        if (this.PendingStates != null) {
            s += ind + "pendingStates\n" ;
        }
        //      C# -> System.String? PreviousVersion
        // GraphQL -> previousVersion: String (scalar)
        if (this.PreviousVersion != null) {
            s += ind + "previousVersion\n" ;
        }
        //      C# -> System.String? ScheduleUpgradeAction
        // GraphQL -> scheduleUpgradeAction: String (scalar)
        if (this.ScheduleUpgradeAction != null) {
            s += ind + "scheduleUpgradeAction\n" ;
        }
        //      C# -> DateTime? ScheduleUpgradeAt
        // GraphQL -> scheduleUpgradeAt: DateTime (scalar)
        if (this.ScheduleUpgradeAt != null) {
            s += ind + "scheduleUpgradeAt\n" ;
        }
        //      C# -> System.String? ScheduleUpgradeMode
        // GraphQL -> scheduleUpgradeMode: String (scalar)
        if (this.ScheduleUpgradeMode != null) {
            s += ind + "scheduleUpgradeMode\n" ;
        }
        //      C# -> System.String? StateMachineStatus
        // GraphQL -> stateMachineStatus: String (scalar)
        if (this.StateMachineStatus != null) {
            s += ind + "stateMachineStatus\n" ;
        }
        //      C# -> DateTime? StateMachineStatusAt
        // GraphQL -> stateMachineStatusAt: DateTime (scalar)
        if (this.StateMachineStatusAt != null) {
            s += ind + "stateMachineStatusAt\n" ;
        }
        //      C# -> DateTime? UpgradeEndAt
        // GraphQL -> upgradeEndAt: DateTime (scalar)
        if (this.UpgradeEndAt != null) {
            s += ind + "upgradeEndAt\n" ;
        }
        //      C# -> System.String? UpgradeEventSeriesId
        // GraphQL -> upgradeEventSeriesId: String (scalar)
        if (this.UpgradeEventSeriesId != null) {
            s += ind + "upgradeEventSeriesId\n" ;
        }
        //      C# -> DateTime? UpgradeStartAt
        // GraphQL -> upgradeStartAt: DateTime (scalar)
        if (this.UpgradeStartAt != null) {
            s += ind + "upgradeStartAt\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations != null) {
            var fspec = this.AuthorizedOperations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "authorizedOperations {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (this.CdmClusterNodeDetails != null) {
            var fspec = this.CdmClusterNodeDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cdmClusterNodeDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: CdmClusterStatus (type)
        if (this.ClusterStatus != null) {
            var fspec = this.ClusterStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> UpgradeDurationReply? LastUpgradeDuration
        // GraphQL -> lastUpgradeDuration: UpgradeDurationReply (type)
        if (this.LastUpgradeDuration != null) {
            var fspec = this.LastUpgradeDuration.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lastUpgradeDuration {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> UpgradeRecommendationInfo? UpgradeRecommendationInfo
        // GraphQL -> upgradeRecommendationInfo: UpgradeRecommendationInfo (type)
        if (this.UpgradeRecommendationInfo != null) {
            var fspec = this.UpgradeRecommendationInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "upgradeRecommendationInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterJobStatusTypeEnum? ClusterJobStatus
        // GraphQL -> clusterJobStatus: ClusterJobStatusTypeEnum (enum)
        if (this.ClusterJobStatus == null && ec.Includes("clusterJobStatus",true))
        {
            this.ClusterJobStatus = new ClusterJobStatusTypeEnum();
        }
        //      C# -> VersionStatus? VersionStatus
        // GraphQL -> versionStatus: VersionStatus (enum)
        if (this.VersionStatus == null && ec.Includes("versionStatus",true))
        {
            this.VersionStatus = new VersionStatus();
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && ec.Includes("clusterUuid",true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.Single? CurrentStateProgress
        // GraphQL -> currentStateProgress: Float (scalar)
        if (this.CurrentStateProgress == null && ec.Includes("currentStateProgress",true))
        {
            this.CurrentStateProgress = new System.Single();
        }
        //      C# -> System.String? DownloadedVersion
        // GraphQL -> downloadedVersion: String (scalar)
        if (this.DownloadedVersion == null && ec.Includes("downloadedVersion",true))
        {
            this.DownloadedVersion = "FETCH";
        }
        //      C# -> System.Boolean? FastUpgradePreferred
        // GraphQL -> fastUpgradePreferred: Boolean (scalar)
        if (this.FastUpgradePreferred == null && ec.Includes("fastUpgradePreferred",true))
        {
            this.FastUpgradePreferred = true;
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String (scalar)
        if (this.FinishedStates == null && ec.Includes("finishedStates",true))
        {
            this.FinishedStates = "FETCH";
        }
        //      C# -> System.Single? OverallProgress
        // GraphQL -> overallProgress: Float (scalar)
        if (this.OverallProgress == null && ec.Includes("overallProgress",true))
        {
            this.OverallProgress = new System.Single();
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String (scalar)
        if (this.PendingStates == null && ec.Includes("pendingStates",true))
        {
            this.PendingStates = "FETCH";
        }
        //      C# -> System.String? PreviousVersion
        // GraphQL -> previousVersion: String (scalar)
        if (this.PreviousVersion == null && ec.Includes("previousVersion",true))
        {
            this.PreviousVersion = "FETCH";
        }
        //      C# -> System.String? ScheduleUpgradeAction
        // GraphQL -> scheduleUpgradeAction: String (scalar)
        if (this.ScheduleUpgradeAction == null && ec.Includes("scheduleUpgradeAction",true))
        {
            this.ScheduleUpgradeAction = "FETCH";
        }
        //      C# -> DateTime? ScheduleUpgradeAt
        // GraphQL -> scheduleUpgradeAt: DateTime (scalar)
        if (this.ScheduleUpgradeAt == null && ec.Includes("scheduleUpgradeAt",true))
        {
            this.ScheduleUpgradeAt = new DateTime();
        }
        //      C# -> System.String? ScheduleUpgradeMode
        // GraphQL -> scheduleUpgradeMode: String (scalar)
        if (this.ScheduleUpgradeMode == null && ec.Includes("scheduleUpgradeMode",true))
        {
            this.ScheduleUpgradeMode = "FETCH";
        }
        //      C# -> System.String? StateMachineStatus
        // GraphQL -> stateMachineStatus: String (scalar)
        if (this.StateMachineStatus == null && ec.Includes("stateMachineStatus",true))
        {
            this.StateMachineStatus = "FETCH";
        }
        //      C# -> DateTime? StateMachineStatusAt
        // GraphQL -> stateMachineStatusAt: DateTime (scalar)
        if (this.StateMachineStatusAt == null && ec.Includes("stateMachineStatusAt",true))
        {
            this.StateMachineStatusAt = new DateTime();
        }
        //      C# -> DateTime? UpgradeEndAt
        // GraphQL -> upgradeEndAt: DateTime (scalar)
        if (this.UpgradeEndAt == null && ec.Includes("upgradeEndAt",true))
        {
            this.UpgradeEndAt = new DateTime();
        }
        //      C# -> System.String? UpgradeEventSeriesId
        // GraphQL -> upgradeEventSeriesId: String (scalar)
        if (this.UpgradeEventSeriesId == null && ec.Includes("upgradeEventSeriesId",true))
        {
            this.UpgradeEventSeriesId = "FETCH";
        }
        //      C# -> DateTime? UpgradeStartAt
        // GraphQL -> upgradeStartAt: DateTime (scalar)
        if (this.UpgradeStartAt == null && ec.Includes("upgradeStartAt",true))
        {
            this.UpgradeStartAt = new DateTime();
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && ec.Includes("version",true))
        {
            this.Version = "FETCH";
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations == null && ec.Includes("authorizedOperations",false))
        {
            this.AuthorizedOperations = new AuthorizedOperations();
            this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (this.CdmClusterNodeDetails == null && ec.Includes("cdmClusterNodeDetails",false))
        {
            this.CdmClusterNodeDetails = new List<CdmNodeDetail>();
            this.CdmClusterNodeDetails.ApplyExploratoryFieldSpec(ec.NewChild("cdmClusterNodeDetails"));
        }
        //      C# -> CdmClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: CdmClusterStatus (type)
        if (this.ClusterStatus == null && ec.Includes("clusterStatus",false))
        {
            this.ClusterStatus = new CdmClusterStatus();
            this.ClusterStatus.ApplyExploratoryFieldSpec(ec.NewChild("clusterStatus"));
        }
        //      C# -> UpgradeDurationReply? LastUpgradeDuration
        // GraphQL -> lastUpgradeDuration: UpgradeDurationReply (type)
        if (this.LastUpgradeDuration == null && ec.Includes("lastUpgradeDuration",false))
        {
            this.LastUpgradeDuration = new UpgradeDurationReply();
            this.LastUpgradeDuration.ApplyExploratoryFieldSpec(ec.NewChild("lastUpgradeDuration"));
        }
        //      C# -> UpgradeRecommendationInfo? UpgradeRecommendationInfo
        // GraphQL -> upgradeRecommendationInfo: UpgradeRecommendationInfo (type)
        if (this.UpgradeRecommendationInfo == null && ec.Includes("upgradeRecommendationInfo",false))
        {
            this.UpgradeRecommendationInfo = new UpgradeRecommendationInfo();
            this.UpgradeRecommendationInfo.ApplyExploratoryFieldSpec(ec.NewChild("upgradeRecommendationInfo"));
        }
    }


    #endregion

    } // class CdmUpgradeInfo
    
    #endregion

    public static class ListCdmUpgradeInfoExtensions
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
            this List<CdmUpgradeInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<CdmUpgradeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types