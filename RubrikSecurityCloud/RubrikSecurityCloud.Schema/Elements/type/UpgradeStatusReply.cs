// UpgradeStatusReply.cs
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
    #region UpgradeStatusReply
    public class UpgradeStatusReply: BaseType
    {
        #region members

        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String! (scalar)
        [JsonProperty("currentState")]
        public System.String? CurrentState { get; set; }

        //      C# -> System.String? CurrentStateName
        // GraphQL -> currentStateName: String! (scalar)
        [JsonProperty("currentStateName")]
        public System.String? CurrentStateName { get; set; }

        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String! (scalar)
        [JsonProperty("currentStateProgress")]
        public System.String? CurrentStateProgress { get; set; }

        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String! (scalar)
        [JsonProperty("finishedStates")]
        public System.String? FinishedStates { get; set; }

        //      C# -> System.String? Mode
        // GraphQL -> mode: String! (scalar)
        [JsonProperty("mode")]
        public System.String? Mode { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String! (scalar)
        [JsonProperty("pendingStates")]
        public System.String? PendingStates { get; set; }

        //      C# -> System.String? Progress
        // GraphQL -> progress: String! (scalar)
        [JsonProperty("progress")]
        public System.String? Progress { get; set; }

        //      C# -> System.String? TarballName
        // GraphQL -> tarballName: String! (scalar)
        [JsonProperty("tarballName")]
        public System.String? TarballName { get; set; }

        //      C# -> System.String? UpgradeProgressPercentage
        // GraphQL -> upgradeProgressPercentage: String! (scalar)
        [JsonProperty("upgradeProgressPercentage")]
        public System.String? UpgradeProgressPercentage { get; set; }

        //      C# -> System.String? UpgradeTimeLeftSecs
        // GraphQL -> upgradeTimeLeftSecs: String! (scalar)
        [JsonProperty("upgradeTimeLeftSecs")]
        public System.String? UpgradeTimeLeftSecs { get; set; }

        //      C# -> System.String? UpgradeTimestamp
        // GraphQL -> upgradeTimestamp: String! (scalar)
        [JsonProperty("upgradeTimestamp")]
        public System.String? UpgradeTimestamp { get; set; }

        //      C# -> System.String? UserSurfacedTaskName
        // GraphQL -> userSurfacedTaskName: String! (scalar)
        [JsonProperty("userSurfacedTaskName")]
        public System.String? UserSurfacedTaskName { get; set; }

        //      C# -> RollingUpgradeInfo? RuInfo
        // GraphQL -> ruInfo: RollingUpgradeInfo (type)
        [JsonProperty("ruInfo")]
        public RollingUpgradeInfo? RuInfo { get; set; }

        //      C# -> StatusResponse? UpgradeStatus
        // GraphQL -> upgradeStatus: StatusResponse (type)
        [JsonProperty("upgradeStatus")]
        public StatusResponse? UpgradeStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpgradeStatusReply";
    }

    public UpgradeStatusReply Set(
        System.String? CurrentState = null,
        System.String? CurrentStateName = null,
        System.String? CurrentStateProgress = null,
        System.String? FinishedStates = null,
        System.String? Mode = null,
        System.String? NodeName = null,
        System.String? PendingStates = null,
        System.String? Progress = null,
        System.String? TarballName = null,
        System.String? UpgradeProgressPercentage = null,
        System.String? UpgradeTimeLeftSecs = null,
        System.String? UpgradeTimestamp = null,
        System.String? UserSurfacedTaskName = null,
        RollingUpgradeInfo? RuInfo = null,
        StatusResponse? UpgradeStatus = null
    ) 
    {
        if ( CurrentState != null ) {
            this.CurrentState = CurrentState;
        }
        if ( CurrentStateName != null ) {
            this.CurrentStateName = CurrentStateName;
        }
        if ( CurrentStateProgress != null ) {
            this.CurrentStateProgress = CurrentStateProgress;
        }
        if ( FinishedStates != null ) {
            this.FinishedStates = FinishedStates;
        }
        if ( Mode != null ) {
            this.Mode = Mode;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
        }
        if ( PendingStates != null ) {
            this.PendingStates = PendingStates;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( TarballName != null ) {
            this.TarballName = TarballName;
        }
        if ( UpgradeProgressPercentage != null ) {
            this.UpgradeProgressPercentage = UpgradeProgressPercentage;
        }
        if ( UpgradeTimeLeftSecs != null ) {
            this.UpgradeTimeLeftSecs = UpgradeTimeLeftSecs;
        }
        if ( UpgradeTimestamp != null ) {
            this.UpgradeTimestamp = UpgradeTimestamp;
        }
        if ( UserSurfacedTaskName != null ) {
            this.UserSurfacedTaskName = UserSurfacedTaskName;
        }
        if ( RuInfo != null ) {
            this.RuInfo = RuInfo;
        }
        if ( UpgradeStatus != null ) {
            this.UpgradeStatus = UpgradeStatus;
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
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String! (scalar)
        if (this.CurrentState != null) {
            s += ind + "currentState\n" ;
        }
        //      C# -> System.String? CurrentStateName
        // GraphQL -> currentStateName: String! (scalar)
        if (this.CurrentStateName != null) {
            s += ind + "currentStateName\n" ;
        }
        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String! (scalar)
        if (this.CurrentStateProgress != null) {
            s += ind + "currentStateProgress\n" ;
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String! (scalar)
        if (this.FinishedStates != null) {
            s += ind + "finishedStates\n" ;
        }
        //      C# -> System.String? Mode
        // GraphQL -> mode: String! (scalar)
        if (this.Mode != null) {
            s += ind + "mode\n" ;
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName != null) {
            s += ind + "nodeName\n" ;
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String! (scalar)
        if (this.PendingStates != null) {
            s += ind + "pendingStates\n" ;
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String! (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        //      C# -> System.String? TarballName
        // GraphQL -> tarballName: String! (scalar)
        if (this.TarballName != null) {
            s += ind + "tarballName\n" ;
        }
        //      C# -> System.String? UpgradeProgressPercentage
        // GraphQL -> upgradeProgressPercentage: String! (scalar)
        if (this.UpgradeProgressPercentage != null) {
            s += ind + "upgradeProgressPercentage\n" ;
        }
        //      C# -> System.String? UpgradeTimeLeftSecs
        // GraphQL -> upgradeTimeLeftSecs: String! (scalar)
        if (this.UpgradeTimeLeftSecs != null) {
            s += ind + "upgradeTimeLeftSecs\n" ;
        }
        //      C# -> System.String? UpgradeTimestamp
        // GraphQL -> upgradeTimestamp: String! (scalar)
        if (this.UpgradeTimestamp != null) {
            s += ind + "upgradeTimestamp\n" ;
        }
        //      C# -> System.String? UserSurfacedTaskName
        // GraphQL -> userSurfacedTaskName: String! (scalar)
        if (this.UserSurfacedTaskName != null) {
            s += ind + "userSurfacedTaskName\n" ;
        }
        //      C# -> RollingUpgradeInfo? RuInfo
        // GraphQL -> ruInfo: RollingUpgradeInfo (type)
        if (this.RuInfo != null) {
            var fspec = this.RuInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ruInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> StatusResponse? UpgradeStatus
        // GraphQL -> upgradeStatus: StatusResponse (type)
        if (this.UpgradeStatus != null) {
            var fspec = this.UpgradeStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "upgradeStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String! (scalar)
        if (this.CurrentState == null && ec.Includes("currentState",true))
        {
            this.CurrentState = "FETCH";
        }
        //      C# -> System.String? CurrentStateName
        // GraphQL -> currentStateName: String! (scalar)
        if (this.CurrentStateName == null && ec.Includes("currentStateName",true))
        {
            this.CurrentStateName = "FETCH";
        }
        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String! (scalar)
        if (this.CurrentStateProgress == null && ec.Includes("currentStateProgress",true))
        {
            this.CurrentStateProgress = "FETCH";
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String! (scalar)
        if (this.FinishedStates == null && ec.Includes("finishedStates",true))
        {
            this.FinishedStates = "FETCH";
        }
        //      C# -> System.String? Mode
        // GraphQL -> mode: String! (scalar)
        if (this.Mode == null && ec.Includes("mode",true))
        {
            this.Mode = "FETCH";
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName == null && ec.Includes("nodeName",true))
        {
            this.NodeName = "FETCH";
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String! (scalar)
        if (this.PendingStates == null && ec.Includes("pendingStates",true))
        {
            this.PendingStates = "FETCH";
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String! (scalar)
        if (this.Progress == null && ec.Includes("progress",true))
        {
            this.Progress = "FETCH";
        }
        //      C# -> System.String? TarballName
        // GraphQL -> tarballName: String! (scalar)
        if (this.TarballName == null && ec.Includes("tarballName",true))
        {
            this.TarballName = "FETCH";
        }
        //      C# -> System.String? UpgradeProgressPercentage
        // GraphQL -> upgradeProgressPercentage: String! (scalar)
        if (this.UpgradeProgressPercentage == null && ec.Includes("upgradeProgressPercentage",true))
        {
            this.UpgradeProgressPercentage = "FETCH";
        }
        //      C# -> System.String? UpgradeTimeLeftSecs
        // GraphQL -> upgradeTimeLeftSecs: String! (scalar)
        if (this.UpgradeTimeLeftSecs == null && ec.Includes("upgradeTimeLeftSecs",true))
        {
            this.UpgradeTimeLeftSecs = "FETCH";
        }
        //      C# -> System.String? UpgradeTimestamp
        // GraphQL -> upgradeTimestamp: String! (scalar)
        if (this.UpgradeTimestamp == null && ec.Includes("upgradeTimestamp",true))
        {
            this.UpgradeTimestamp = "FETCH";
        }
        //      C# -> System.String? UserSurfacedTaskName
        // GraphQL -> userSurfacedTaskName: String! (scalar)
        if (this.UserSurfacedTaskName == null && ec.Includes("userSurfacedTaskName",true))
        {
            this.UserSurfacedTaskName = "FETCH";
        }
        //      C# -> RollingUpgradeInfo? RuInfo
        // GraphQL -> ruInfo: RollingUpgradeInfo (type)
        if (this.RuInfo == null && ec.Includes("ruInfo",false))
        {
            this.RuInfo = new RollingUpgradeInfo();
            this.RuInfo.ApplyExploratoryFieldSpec(ec.NewChild("ruInfo"));
        }
        //      C# -> StatusResponse? UpgradeStatus
        // GraphQL -> upgradeStatus: StatusResponse (type)
        if (this.UpgradeStatus == null && ec.Includes("upgradeStatus",false))
        {
            this.UpgradeStatus = new StatusResponse();
            this.UpgradeStatus.ApplyExploratoryFieldSpec(ec.NewChild("upgradeStatus"));
        }
    }


    #endregion

    } // class UpgradeStatusReply
    
    #endregion

    public static class ListUpgradeStatusReplyExtensions
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
            this List<UpgradeStatusReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeStatusReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UpgradeStatusReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types