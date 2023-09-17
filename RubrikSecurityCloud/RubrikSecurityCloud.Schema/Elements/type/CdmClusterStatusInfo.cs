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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CompletedNodes
        // GraphQL -> completedNodes: String (scalar)
        if (this.CompletedNodes != null) {
            s += ind + "completedNodes\n" ;
        }
        //      C# -> System.String? CurrentNode
        // GraphQL -> currentNode: String (scalar)
        if (this.CurrentNode != null) {
            s += ind + "currentNode\n" ;
        }
        //      C# -> System.String? CurrentNodeState
        // GraphQL -> currentNodeState: String (scalar)
        if (this.CurrentNodeState != null) {
            s += ind + "currentNodeState\n" ;
        }
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String (scalar)
        if (this.CurrentState != null) {
            s += ind + "currentState\n" ;
        }
        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String (scalar)
        if (this.CurrentStateProgress != null) {
            s += ind + "currentStateProgress\n" ;
        }
        //      C# -> System.String? CurrentTask
        // GraphQL -> currentTask: String (scalar)
        if (this.CurrentTask != null) {
            s += ind + "currentTask\n" ;
        }
        //      C# -> System.String? DownloadJobStatus
        // GraphQL -> downloadJobStatus: String (scalar)
        if (this.DownloadJobStatus != null) {
            s += ind + "downloadJobStatus\n" ;
        }
        //      C# -> System.String? DownloadProgress
        // GraphQL -> downloadProgress: String (scalar)
        if (this.DownloadProgress != null) {
            s += ind + "downloadProgress\n" ;
        }
        //      C# -> System.String? DownloadRemainingTimeEstimateInSeconds
        // GraphQL -> downloadRemainingTimeEstimateInSeconds: String (scalar)
        if (this.DownloadRemainingTimeEstimateInSeconds != null) {
            s += ind + "downloadRemainingTimeEstimateInSeconds\n" ;
        }
        //      C# -> System.String? DownloadVersion
        // GraphQL -> downloadVersion: String (scalar)
        if (this.DownloadVersion != null) {
            s += ind + "downloadVersion\n" ;
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String (scalar)
        if (this.FinishedStates != null) {
            s += ind + "finishedStates\n" ;
        }
        //      C# -> System.String? OverallProgress
        // GraphQL -> overallProgress: String (scalar)
        if (this.OverallProgress != null) {
            s += ind + "overallProgress\n" ;
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String (scalar)
        if (this.PendingStates != null) {
            s += ind + "pendingStates\n" ;
        }
        //      C# -> System.String? TotalNodes
        // GraphQL -> totalNodes: String (scalar)
        if (this.TotalNodes != null) {
            s += ind + "totalNodes\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CompletedNodes
        // GraphQL -> completedNodes: String (scalar)
        if (this.CompletedNodes == null && ec.Includes("completedNodes",true))
        {
            this.CompletedNodes = "FETCH";
        }
        //      C# -> System.String? CurrentNode
        // GraphQL -> currentNode: String (scalar)
        if (this.CurrentNode == null && ec.Includes("currentNode",true))
        {
            this.CurrentNode = "FETCH";
        }
        //      C# -> System.String? CurrentNodeState
        // GraphQL -> currentNodeState: String (scalar)
        if (this.CurrentNodeState == null && ec.Includes("currentNodeState",true))
        {
            this.CurrentNodeState = "FETCH";
        }
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String (scalar)
        if (this.CurrentState == null && ec.Includes("currentState",true))
        {
            this.CurrentState = "FETCH";
        }
        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String (scalar)
        if (this.CurrentStateProgress == null && ec.Includes("currentStateProgress",true))
        {
            this.CurrentStateProgress = "FETCH";
        }
        //      C# -> System.String? CurrentTask
        // GraphQL -> currentTask: String (scalar)
        if (this.CurrentTask == null && ec.Includes("currentTask",true))
        {
            this.CurrentTask = "FETCH";
        }
        //      C# -> System.String? DownloadJobStatus
        // GraphQL -> downloadJobStatus: String (scalar)
        if (this.DownloadJobStatus == null && ec.Includes("downloadJobStatus",true))
        {
            this.DownloadJobStatus = "FETCH";
        }
        //      C# -> System.String? DownloadProgress
        // GraphQL -> downloadProgress: String (scalar)
        if (this.DownloadProgress == null && ec.Includes("downloadProgress",true))
        {
            this.DownloadProgress = "FETCH";
        }
        //      C# -> System.String? DownloadRemainingTimeEstimateInSeconds
        // GraphQL -> downloadRemainingTimeEstimateInSeconds: String (scalar)
        if (this.DownloadRemainingTimeEstimateInSeconds == null && ec.Includes("downloadRemainingTimeEstimateInSeconds",true))
        {
            this.DownloadRemainingTimeEstimateInSeconds = "FETCH";
        }
        //      C# -> System.String? DownloadVersion
        // GraphQL -> downloadVersion: String (scalar)
        if (this.DownloadVersion == null && ec.Includes("downloadVersion",true))
        {
            this.DownloadVersion = "FETCH";
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String (scalar)
        if (this.FinishedStates == null && ec.Includes("finishedStates",true))
        {
            this.FinishedStates = "FETCH";
        }
        //      C# -> System.String? OverallProgress
        // GraphQL -> overallProgress: String (scalar)
        if (this.OverallProgress == null && ec.Includes("overallProgress",true))
        {
            this.OverallProgress = "FETCH";
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String (scalar)
        if (this.PendingStates == null && ec.Includes("pendingStates",true))
        {
            this.PendingStates = "FETCH";
        }
        //      C# -> System.String? TotalNodes
        // GraphQL -> totalNodes: String (scalar)
        if (this.TotalNodes == null && ec.Includes("totalNodes",true))
        {
            this.TotalNodes = "FETCH";
        }
    }


    #endregion

    } // class CdmClusterStatusInfo
    
    #endregion

    public static class ListCdmClusterStatusInfoExtensions
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
            this List<CdmClusterStatusInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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