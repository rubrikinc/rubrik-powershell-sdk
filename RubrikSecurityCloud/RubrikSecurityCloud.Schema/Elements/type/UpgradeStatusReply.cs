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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String! (scalar)
        if (this.CurrentState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentState\n" ;
            } else {
                s += ind + "currentState\n" ;
            }
        }
        //      C# -> System.String? CurrentStateName
        // GraphQL -> currentStateName: String! (scalar)
        if (this.CurrentStateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentStateName\n" ;
            } else {
                s += ind + "currentStateName\n" ;
            }
        }
        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String! (scalar)
        if (this.CurrentStateProgress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentStateProgress\n" ;
            } else {
                s += ind + "currentStateProgress\n" ;
            }
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String! (scalar)
        if (this.FinishedStates != null) {
            if (conf.Flat) {
                s += conf.Prefix + "finishedStates\n" ;
            } else {
                s += ind + "finishedStates\n" ;
            }
        }
        //      C# -> System.String? Mode
        // GraphQL -> mode: String! (scalar)
        if (this.Mode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mode\n" ;
            } else {
                s += ind + "mode\n" ;
            }
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeName\n" ;
            } else {
                s += ind + "nodeName\n" ;
            }
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String! (scalar)
        if (this.PendingStates != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingStates\n" ;
            } else {
                s += ind + "pendingStates\n" ;
            }
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String! (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        //      C# -> System.String? TarballName
        // GraphQL -> tarballName: String! (scalar)
        if (this.TarballName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tarballName\n" ;
            } else {
                s += ind + "tarballName\n" ;
            }
        }
        //      C# -> System.String? UpgradeProgressPercentage
        // GraphQL -> upgradeProgressPercentage: String! (scalar)
        if (this.UpgradeProgressPercentage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeProgressPercentage\n" ;
            } else {
                s += ind + "upgradeProgressPercentage\n" ;
            }
        }
        //      C# -> System.String? UpgradeTimeLeftSecs
        // GraphQL -> upgradeTimeLeftSecs: String! (scalar)
        if (this.UpgradeTimeLeftSecs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeTimeLeftSecs\n" ;
            } else {
                s += ind + "upgradeTimeLeftSecs\n" ;
            }
        }
        //      C# -> System.String? UpgradeTimestamp
        // GraphQL -> upgradeTimestamp: String! (scalar)
        if (this.UpgradeTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeTimestamp\n" ;
            } else {
                s += ind + "upgradeTimestamp\n" ;
            }
        }
        //      C# -> System.String? UserSurfacedTaskName
        // GraphQL -> userSurfacedTaskName: String! (scalar)
        if (this.UserSurfacedTaskName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userSurfacedTaskName\n" ;
            } else {
                s += ind + "userSurfacedTaskName\n" ;
            }
        }
        //      C# -> RollingUpgradeInfo? RuInfo
        // GraphQL -> ruInfo: RollingUpgradeInfo (type)
        if (this.RuInfo != null) {
            var fspec = this.RuInfo.AsFieldSpec(conf.Child("ruInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ruInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> StatusResponse? UpgradeStatus
        // GraphQL -> upgradeStatus: StatusResponse (type)
        if (this.UpgradeStatus != null) {
            var fspec = this.UpgradeStatus.AsFieldSpec(conf.Child("upgradeStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "upgradeStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String! (scalar)
        if (ec.Includes("currentState",true))
        {
            if(this.CurrentState == null) {

                this.CurrentState = "FETCH";

            } else {


            }
        }
        else if (this.CurrentState != null && ec.Excludes("currentState",true))
        {
            this.CurrentState = null;
        }
        //      C# -> System.String? CurrentStateName
        // GraphQL -> currentStateName: String! (scalar)
        if (ec.Includes("currentStateName",true))
        {
            if(this.CurrentStateName == null) {

                this.CurrentStateName = "FETCH";

            } else {


            }
        }
        else if (this.CurrentStateName != null && ec.Excludes("currentStateName",true))
        {
            this.CurrentStateName = null;
        }
        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String! (scalar)
        if (ec.Includes("currentStateProgress",true))
        {
            if(this.CurrentStateProgress == null) {

                this.CurrentStateProgress = "FETCH";

            } else {


            }
        }
        else if (this.CurrentStateProgress != null && ec.Excludes("currentStateProgress",true))
        {
            this.CurrentStateProgress = null;
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String! (scalar)
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
        //      C# -> System.String? Mode
        // GraphQL -> mode: String! (scalar)
        if (ec.Includes("mode",true))
        {
            if(this.Mode == null) {

                this.Mode = "FETCH";

            } else {


            }
        }
        else if (this.Mode != null && ec.Excludes("mode",true))
        {
            this.Mode = null;
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (ec.Includes("nodeName",true))
        {
            if(this.NodeName == null) {

                this.NodeName = "FETCH";

            } else {


            }
        }
        else if (this.NodeName != null && ec.Excludes("nodeName",true))
        {
            this.NodeName = null;
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String! (scalar)
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
        //      C# -> System.String? Progress
        // GraphQL -> progress: String! (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = "FETCH";

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
        }
        //      C# -> System.String? TarballName
        // GraphQL -> tarballName: String! (scalar)
        if (ec.Includes("tarballName",true))
        {
            if(this.TarballName == null) {

                this.TarballName = "FETCH";

            } else {


            }
        }
        else if (this.TarballName != null && ec.Excludes("tarballName",true))
        {
            this.TarballName = null;
        }
        //      C# -> System.String? UpgradeProgressPercentage
        // GraphQL -> upgradeProgressPercentage: String! (scalar)
        if (ec.Includes("upgradeProgressPercentage",true))
        {
            if(this.UpgradeProgressPercentage == null) {

                this.UpgradeProgressPercentage = "FETCH";

            } else {


            }
        }
        else if (this.UpgradeProgressPercentage != null && ec.Excludes("upgradeProgressPercentage",true))
        {
            this.UpgradeProgressPercentage = null;
        }
        //      C# -> System.String? UpgradeTimeLeftSecs
        // GraphQL -> upgradeTimeLeftSecs: String! (scalar)
        if (ec.Includes("upgradeTimeLeftSecs",true))
        {
            if(this.UpgradeTimeLeftSecs == null) {

                this.UpgradeTimeLeftSecs = "FETCH";

            } else {


            }
        }
        else if (this.UpgradeTimeLeftSecs != null && ec.Excludes("upgradeTimeLeftSecs",true))
        {
            this.UpgradeTimeLeftSecs = null;
        }
        //      C# -> System.String? UpgradeTimestamp
        // GraphQL -> upgradeTimestamp: String! (scalar)
        if (ec.Includes("upgradeTimestamp",true))
        {
            if(this.UpgradeTimestamp == null) {

                this.UpgradeTimestamp = "FETCH";

            } else {


            }
        }
        else if (this.UpgradeTimestamp != null && ec.Excludes("upgradeTimestamp",true))
        {
            this.UpgradeTimestamp = null;
        }
        //      C# -> System.String? UserSurfacedTaskName
        // GraphQL -> userSurfacedTaskName: String! (scalar)
        if (ec.Includes("userSurfacedTaskName",true))
        {
            if(this.UserSurfacedTaskName == null) {

                this.UserSurfacedTaskName = "FETCH";

            } else {


            }
        }
        else if (this.UserSurfacedTaskName != null && ec.Excludes("userSurfacedTaskName",true))
        {
            this.UserSurfacedTaskName = null;
        }
        //      C# -> RollingUpgradeInfo? RuInfo
        // GraphQL -> ruInfo: RollingUpgradeInfo (type)
        if (ec.Includes("ruInfo",false))
        {
            if(this.RuInfo == null) {

                this.RuInfo = new RollingUpgradeInfo();
                this.RuInfo.ApplyExploratoryFieldSpec(ec.NewChild("ruInfo"));

            } else {

                this.RuInfo.ApplyExploratoryFieldSpec(ec.NewChild("ruInfo"));

            }
        }
        else if (this.RuInfo != null && ec.Excludes("ruInfo",false))
        {
            this.RuInfo = null;
        }
        //      C# -> StatusResponse? UpgradeStatus
        // GraphQL -> upgradeStatus: StatusResponse (type)
        if (ec.Includes("upgradeStatus",false))
        {
            if(this.UpgradeStatus == null) {

                this.UpgradeStatus = new StatusResponse();
                this.UpgradeStatus.ApplyExploratoryFieldSpec(ec.NewChild("upgradeStatus"));

            } else {

                this.UpgradeStatus.ApplyExploratoryFieldSpec(ec.NewChild("upgradeStatus"));

            }
        }
        else if (this.UpgradeStatus != null && ec.Excludes("upgradeStatus",false))
        {
            this.UpgradeStatus = null;
        }
    }


    #endregion

    } // class UpgradeStatusReply
    
    #endregion

    public static class ListUpgradeStatusReplyExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<UpgradeStatusReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpgradeStatusReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<UpgradeStatusReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types