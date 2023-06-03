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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "authorizedOperations {\n" + this.AuthorizedOperations.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (this.CdmClusterNodeDetails != null) {
            s += ind + "cdmClusterNodeDetails {\n" + this.CdmClusterNodeDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: CdmClusterStatus (type)
        if (this.ClusterStatus != null) {
            s += ind + "clusterStatus {\n" + this.ClusterStatus.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> UpgradeDurationReply? LastUpgradeDuration
        // GraphQL -> lastUpgradeDuration: UpgradeDurationReply (type)
        if (this.LastUpgradeDuration != null) {
            s += ind + "lastUpgradeDuration {\n" + this.LastUpgradeDuration.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> UpgradeRecommendationInfo? UpgradeRecommendationInfo
        // GraphQL -> upgradeRecommendationInfo: UpgradeRecommendationInfo (type)
        if (this.UpgradeRecommendationInfo != null) {
            s += ind + "upgradeRecommendationInfo {\n" + this.UpgradeRecommendationInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ClusterJobStatusTypeEnum? ClusterJobStatus
        // GraphQL -> clusterJobStatus: ClusterJobStatusTypeEnum (enum)
        if (this.ClusterJobStatus == null && Exploration.Includes(parent + ".clusterJobStatus", true))
        {
            this.ClusterJobStatus = new ClusterJobStatusTypeEnum();
        }
        //      C# -> VersionStatus? VersionStatus
        // GraphQL -> versionStatus: VersionStatus (enum)
        if (this.VersionStatus == null && Exploration.Includes(parent + ".versionStatus", true))
        {
            this.VersionStatus = new VersionStatus();
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = new System.String("FETCH");
        }
        //      C# -> System.Single? CurrentStateProgress
        // GraphQL -> currentStateProgress: Float (scalar)
        if (this.CurrentStateProgress == null && Exploration.Includes(parent + ".currentStateProgress", true))
        {
            this.CurrentStateProgress = new System.Single();
        }
        //      C# -> System.String? DownloadedVersion
        // GraphQL -> downloadedVersion: String (scalar)
        if (this.DownloadedVersion == null && Exploration.Includes(parent + ".downloadedVersion", true))
        {
            this.DownloadedVersion = new System.String("FETCH");
        }
        //      C# -> System.Boolean? FastUpgradePreferred
        // GraphQL -> fastUpgradePreferred: Boolean (scalar)
        if (this.FastUpgradePreferred == null && Exploration.Includes(parent + ".fastUpgradePreferred", true))
        {
            this.FastUpgradePreferred = true;
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String (scalar)
        if (this.FinishedStates == null && Exploration.Includes(parent + ".finishedStates", true))
        {
            this.FinishedStates = new System.String("FETCH");
        }
        //      C# -> System.Single? OverallProgress
        // GraphQL -> overallProgress: Float (scalar)
        if (this.OverallProgress == null && Exploration.Includes(parent + ".overallProgress", true))
        {
            this.OverallProgress = new System.Single();
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String (scalar)
        if (this.PendingStates == null && Exploration.Includes(parent + ".pendingStates", true))
        {
            this.PendingStates = new System.String("FETCH");
        }
        //      C# -> System.String? PreviousVersion
        // GraphQL -> previousVersion: String (scalar)
        if (this.PreviousVersion == null && Exploration.Includes(parent + ".previousVersion", true))
        {
            this.PreviousVersion = new System.String("FETCH");
        }
        //      C# -> System.String? ScheduleUpgradeAction
        // GraphQL -> scheduleUpgradeAction: String (scalar)
        if (this.ScheduleUpgradeAction == null && Exploration.Includes(parent + ".scheduleUpgradeAction", true))
        {
            this.ScheduleUpgradeAction = new System.String("FETCH");
        }
        //      C# -> DateTime? ScheduleUpgradeAt
        // GraphQL -> scheduleUpgradeAt: DateTime (scalar)
        if (this.ScheduleUpgradeAt == null && Exploration.Includes(parent + ".scheduleUpgradeAt", true))
        {
            this.ScheduleUpgradeAt = new DateTime();
        }
        //      C# -> System.String? ScheduleUpgradeMode
        // GraphQL -> scheduleUpgradeMode: String (scalar)
        if (this.ScheduleUpgradeMode == null && Exploration.Includes(parent + ".scheduleUpgradeMode", true))
        {
            this.ScheduleUpgradeMode = new System.String("FETCH");
        }
        //      C# -> System.String? StateMachineStatus
        // GraphQL -> stateMachineStatus: String (scalar)
        if (this.StateMachineStatus == null && Exploration.Includes(parent + ".stateMachineStatus", true))
        {
            this.StateMachineStatus = new System.String("FETCH");
        }
        //      C# -> DateTime? StateMachineStatusAt
        // GraphQL -> stateMachineStatusAt: DateTime (scalar)
        if (this.StateMachineStatusAt == null && Exploration.Includes(parent + ".stateMachineStatusAt", true))
        {
            this.StateMachineStatusAt = new DateTime();
        }
        //      C# -> DateTime? UpgradeEndAt
        // GraphQL -> upgradeEndAt: DateTime (scalar)
        if (this.UpgradeEndAt == null && Exploration.Includes(parent + ".upgradeEndAt", true))
        {
            this.UpgradeEndAt = new DateTime();
        }
        //      C# -> System.String? UpgradeEventSeriesId
        // GraphQL -> upgradeEventSeriesId: String (scalar)
        if (this.UpgradeEventSeriesId == null && Exploration.Includes(parent + ".upgradeEventSeriesId", true))
        {
            this.UpgradeEventSeriesId = new System.String("FETCH");
        }
        //      C# -> DateTime? UpgradeStartAt
        // GraphQL -> upgradeStartAt: DateTime (scalar)
        if (this.UpgradeStartAt == null && Exploration.Includes(parent + ".upgradeStartAt", true))
        {
            this.UpgradeStartAt = new DateTime();
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = new System.String("FETCH");
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations"))
        {
            this.AuthorizedOperations = new AuthorizedOperations();
            this.AuthorizedOperations.ApplyExploratoryFieldSpec(parent + ".authorizedOperations");
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (this.CdmClusterNodeDetails == null && Exploration.Includes(parent + ".cdmClusterNodeDetails"))
        {
            this.CdmClusterNodeDetails = new List<CdmNodeDetail>();
            this.CdmClusterNodeDetails.ApplyExploratoryFieldSpec(parent + ".cdmClusterNodeDetails");
        }
        //      C# -> CdmClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: CdmClusterStatus (type)
        if (this.ClusterStatus == null && Exploration.Includes(parent + ".clusterStatus"))
        {
            this.ClusterStatus = new CdmClusterStatus();
            this.ClusterStatus.ApplyExploratoryFieldSpec(parent + ".clusterStatus");
        }
        //      C# -> UpgradeDurationReply? LastUpgradeDuration
        // GraphQL -> lastUpgradeDuration: UpgradeDurationReply (type)
        if (this.LastUpgradeDuration == null && Exploration.Includes(parent + ".lastUpgradeDuration"))
        {
            this.LastUpgradeDuration = new UpgradeDurationReply();
            this.LastUpgradeDuration.ApplyExploratoryFieldSpec(parent + ".lastUpgradeDuration");
        }
        //      C# -> UpgradeRecommendationInfo? UpgradeRecommendationInfo
        // GraphQL -> upgradeRecommendationInfo: UpgradeRecommendationInfo (type)
        if (this.UpgradeRecommendationInfo == null && Exploration.Includes(parent + ".upgradeRecommendationInfo"))
        {
            this.UpgradeRecommendationInfo = new UpgradeRecommendationInfo();
            this.UpgradeRecommendationInfo.ApplyExploratoryFieldSpec(parent + ".upgradeRecommendationInfo");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmUpgradeInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmUpgradeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types