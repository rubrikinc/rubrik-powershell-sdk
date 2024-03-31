// CdmClusterStatusInfo.cs
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
    #region CdmClusterStatusInfo
    public class CdmClusterStatusInfo: BaseType
    {
        #region members

        //      C# -> System.String? CompletedNodes
        // GraphQL -> completedNodes: String (scalar)
        [JsonProperty("completedNodes")]
        public System.String? CompletedNodes { get; set; }

        //      C# -> System.String? CurrentNode
        // GraphQL -> currentNode: String (scalar)
        [JsonProperty("currentNode")]
        public System.String? CurrentNode { get; set; }

        //      C# -> System.String? CurrentNodeState
        // GraphQL -> currentNodeState: String (scalar)
        [JsonProperty("currentNodeState")]
        public System.String? CurrentNodeState { get; set; }

        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String (scalar)
        [JsonProperty("currentState")]
        public System.String? CurrentState { get; set; }

        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String (scalar)
        [JsonProperty("currentStateProgress")]
        public System.String? CurrentStateProgress { get; set; }

        //      C# -> System.String? CurrentTask
        // GraphQL -> currentTask: String (scalar)
        [JsonProperty("currentTask")]
        public System.String? CurrentTask { get; set; }

        //      C# -> System.String? DownloadJobStatus
        // GraphQL -> downloadJobStatus: String (scalar)
        [JsonProperty("downloadJobStatus")]
        public System.String? DownloadJobStatus { get; set; }

        //      C# -> System.String? DownloadProgress
        // GraphQL -> downloadProgress: String (scalar)
        [JsonProperty("downloadProgress")]
        public System.String? DownloadProgress { get; set; }

        //      C# -> System.String? DownloadRemainingTimeEstimateInSeconds
        // GraphQL -> downloadRemainingTimeEstimateInSeconds: String (scalar)
        [JsonProperty("downloadRemainingTimeEstimateInSeconds")]
        public System.String? DownloadRemainingTimeEstimateInSeconds { get; set; }

        //      C# -> System.String? DownloadVersion
        // GraphQL -> downloadVersion: String (scalar)
        [JsonProperty("downloadVersion")]
        public System.String? DownloadVersion { get; set; }

        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String (scalar)
        [JsonProperty("finishedStates")]
        public System.String? FinishedStates { get; set; }

        //      C# -> System.String? OverallProgress
        // GraphQL -> overallProgress: String (scalar)
        [JsonProperty("overallProgress")]
        public System.String? OverallProgress { get; set; }

        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String (scalar)
        [JsonProperty("pendingStates")]
        public System.String? PendingStates { get; set; }

        //      C# -> System.String? TotalNodes
        // GraphQL -> totalNodes: String (scalar)
        [JsonProperty("totalNodes")]
        public System.String? TotalNodes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmClusterStatusInfo";
    }

    public CdmClusterStatusInfo Set(
        System.String? CompletedNodes = null,
        System.String? CurrentNode = null,
        System.String? CurrentNodeState = null,
        System.String? CurrentState = null,
        System.String? CurrentStateProgress = null,
        System.String? CurrentTask = null,
        System.String? DownloadJobStatus = null,
        System.String? DownloadProgress = null,
        System.String? DownloadRemainingTimeEstimateInSeconds = null,
        System.String? DownloadVersion = null,
        System.String? FinishedStates = null,
        System.String? OverallProgress = null,
        System.String? PendingStates = null,
        System.String? TotalNodes = null
    ) 
    {
        if ( CompletedNodes != null ) {
            this.CompletedNodes = CompletedNodes;
        }
        if ( CurrentNode != null ) {
            this.CurrentNode = CurrentNode;
        }
        if ( CurrentNodeState != null ) {
            this.CurrentNodeState = CurrentNodeState;
        }
        if ( CurrentState != null ) {
            this.CurrentState = CurrentState;
        }
        if ( CurrentStateProgress != null ) {
            this.CurrentStateProgress = CurrentStateProgress;
        }
        if ( CurrentTask != null ) {
            this.CurrentTask = CurrentTask;
        }
        if ( DownloadJobStatus != null ) {
            this.DownloadJobStatus = DownloadJobStatus;
        }
        if ( DownloadProgress != null ) {
            this.DownloadProgress = DownloadProgress;
        }
        if ( DownloadRemainingTimeEstimateInSeconds != null ) {
            this.DownloadRemainingTimeEstimateInSeconds = DownloadRemainingTimeEstimateInSeconds;
        }
        if ( DownloadVersion != null ) {
            this.DownloadVersion = DownloadVersion;
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
        if ( TotalNodes != null ) {
            this.TotalNodes = TotalNodes;
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
        //      C# -> System.String? CompletedNodes
        // GraphQL -> completedNodes: String (scalar)
        if (this.CompletedNodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "completedNodes\n" ;
            } else {
                s += ind + "completedNodes\n" ;
            }
        }
        //      C# -> System.String? CurrentNode
        // GraphQL -> currentNode: String (scalar)
        if (this.CurrentNode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentNode\n" ;
            } else {
                s += ind + "currentNode\n" ;
            }
        }
        //      C# -> System.String? CurrentNodeState
        // GraphQL -> currentNodeState: String (scalar)
        if (this.CurrentNodeState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentNodeState\n" ;
            } else {
                s += ind + "currentNodeState\n" ;
            }
        }
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String (scalar)
        if (this.CurrentState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentState\n" ;
            } else {
                s += ind + "currentState\n" ;
            }
        }
        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String (scalar)
        if (this.CurrentStateProgress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentStateProgress\n" ;
            } else {
                s += ind + "currentStateProgress\n" ;
            }
        }
        //      C# -> System.String? CurrentTask
        // GraphQL -> currentTask: String (scalar)
        if (this.CurrentTask != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentTask\n" ;
            } else {
                s += ind + "currentTask\n" ;
            }
        }
        //      C# -> System.String? DownloadJobStatus
        // GraphQL -> downloadJobStatus: String (scalar)
        if (this.DownloadJobStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadJobStatus\n" ;
            } else {
                s += ind + "downloadJobStatus\n" ;
            }
        }
        //      C# -> System.String? DownloadProgress
        // GraphQL -> downloadProgress: String (scalar)
        if (this.DownloadProgress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadProgress\n" ;
            } else {
                s += ind + "downloadProgress\n" ;
            }
        }
        //      C# -> System.String? DownloadRemainingTimeEstimateInSeconds
        // GraphQL -> downloadRemainingTimeEstimateInSeconds: String (scalar)
        if (this.DownloadRemainingTimeEstimateInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadRemainingTimeEstimateInSeconds\n" ;
            } else {
                s += ind + "downloadRemainingTimeEstimateInSeconds\n" ;
            }
        }
        //      C# -> System.String? DownloadVersion
        // GraphQL -> downloadVersion: String (scalar)
        if (this.DownloadVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadVersion\n" ;
            } else {
                s += ind + "downloadVersion\n" ;
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
        //      C# -> System.String? OverallProgress
        // GraphQL -> overallProgress: String (scalar)
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
        //      C# -> System.String? TotalNodes
        // GraphQL -> totalNodes: String (scalar)
        if (this.TotalNodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalNodes\n" ;
            } else {
                s += ind + "totalNodes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CompletedNodes
        // GraphQL -> completedNodes: String (scalar)
        if (ec.Includes("completedNodes",true))
        {
            if(this.CompletedNodes == null) {

                this.CompletedNodes = "FETCH";

            } else {


            }
        }
        else if (this.CompletedNodes != null && ec.Excludes("completedNodes",true))
        {
            this.CompletedNodes = null;
        }
        //      C# -> System.String? CurrentNode
        // GraphQL -> currentNode: String (scalar)
        if (ec.Includes("currentNode",true))
        {
            if(this.CurrentNode == null) {

                this.CurrentNode = "FETCH";

            } else {


            }
        }
        else if (this.CurrentNode != null && ec.Excludes("currentNode",true))
        {
            this.CurrentNode = null;
        }
        //      C# -> System.String? CurrentNodeState
        // GraphQL -> currentNodeState: String (scalar)
        if (ec.Includes("currentNodeState",true))
        {
            if(this.CurrentNodeState == null) {

                this.CurrentNodeState = "FETCH";

            } else {


            }
        }
        else if (this.CurrentNodeState != null && ec.Excludes("currentNodeState",true))
        {
            this.CurrentNodeState = null;
        }
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String (scalar)
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
        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String (scalar)
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
        //      C# -> System.String? CurrentTask
        // GraphQL -> currentTask: String (scalar)
        if (ec.Includes("currentTask",true))
        {
            if(this.CurrentTask == null) {

                this.CurrentTask = "FETCH";

            } else {


            }
        }
        else if (this.CurrentTask != null && ec.Excludes("currentTask",true))
        {
            this.CurrentTask = null;
        }
        //      C# -> System.String? DownloadJobStatus
        // GraphQL -> downloadJobStatus: String (scalar)
        if (ec.Includes("downloadJobStatus",true))
        {
            if(this.DownloadJobStatus == null) {

                this.DownloadJobStatus = "FETCH";

            } else {


            }
        }
        else if (this.DownloadJobStatus != null && ec.Excludes("downloadJobStatus",true))
        {
            this.DownloadJobStatus = null;
        }
        //      C# -> System.String? DownloadProgress
        // GraphQL -> downloadProgress: String (scalar)
        if (ec.Includes("downloadProgress",true))
        {
            if(this.DownloadProgress == null) {

                this.DownloadProgress = "FETCH";

            } else {


            }
        }
        else if (this.DownloadProgress != null && ec.Excludes("downloadProgress",true))
        {
            this.DownloadProgress = null;
        }
        //      C# -> System.String? DownloadRemainingTimeEstimateInSeconds
        // GraphQL -> downloadRemainingTimeEstimateInSeconds: String (scalar)
        if (ec.Includes("downloadRemainingTimeEstimateInSeconds",true))
        {
            if(this.DownloadRemainingTimeEstimateInSeconds == null) {

                this.DownloadRemainingTimeEstimateInSeconds = "FETCH";

            } else {


            }
        }
        else if (this.DownloadRemainingTimeEstimateInSeconds != null && ec.Excludes("downloadRemainingTimeEstimateInSeconds",true))
        {
            this.DownloadRemainingTimeEstimateInSeconds = null;
        }
        //      C# -> System.String? DownloadVersion
        // GraphQL -> downloadVersion: String (scalar)
        if (ec.Includes("downloadVersion",true))
        {
            if(this.DownloadVersion == null) {

                this.DownloadVersion = "FETCH";

            } else {


            }
        }
        else if (this.DownloadVersion != null && ec.Excludes("downloadVersion",true))
        {
            this.DownloadVersion = null;
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
        //      C# -> System.String? OverallProgress
        // GraphQL -> overallProgress: String (scalar)
        if (ec.Includes("overallProgress",true))
        {
            if(this.OverallProgress == null) {

                this.OverallProgress = "FETCH";

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
        //      C# -> System.String? TotalNodes
        // GraphQL -> totalNodes: String (scalar)
        if (ec.Includes("totalNodes",true))
        {
            if(this.TotalNodes == null) {

                this.TotalNodes = "FETCH";

            } else {


            }
        }
        else if (this.TotalNodes != null && ec.Excludes("totalNodes",true))
        {
            this.TotalNodes = null;
        }
    }


    #endregion

    } // class CdmClusterStatusInfo
    
    #endregion

    public static class ListCdmClusterStatusInfoExtensions
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
            this List<CdmClusterStatusInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmClusterStatusInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmClusterStatusInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmClusterStatusInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmClusterStatusInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types