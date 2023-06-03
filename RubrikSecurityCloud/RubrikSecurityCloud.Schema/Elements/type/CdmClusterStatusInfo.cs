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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CompletedNodes
        // GraphQL -> completedNodes: String (scalar)
        if (this.CompletedNodes == null && Exploration.Includes(parent + ".completedNodes", true))
        {
            this.CompletedNodes = new System.String("FETCH");
        }
        //      C# -> System.String? CurrentNode
        // GraphQL -> currentNode: String (scalar)
        if (this.CurrentNode == null && Exploration.Includes(parent + ".currentNode", true))
        {
            this.CurrentNode = new System.String("FETCH");
        }
        //      C# -> System.String? CurrentNodeState
        // GraphQL -> currentNodeState: String (scalar)
        if (this.CurrentNodeState == null && Exploration.Includes(parent + ".currentNodeState", true))
        {
            this.CurrentNodeState = new System.String("FETCH");
        }
        //      C# -> System.String? CurrentState
        // GraphQL -> currentState: String (scalar)
        if (this.CurrentState == null && Exploration.Includes(parent + ".currentState", true))
        {
            this.CurrentState = new System.String("FETCH");
        }
        //      C# -> System.String? CurrentStateProgress
        // GraphQL -> currentStateProgress: String (scalar)
        if (this.CurrentStateProgress == null && Exploration.Includes(parent + ".currentStateProgress", true))
        {
            this.CurrentStateProgress = new System.String("FETCH");
        }
        //      C# -> System.String? CurrentTask
        // GraphQL -> currentTask: String (scalar)
        if (this.CurrentTask == null && Exploration.Includes(parent + ".currentTask", true))
        {
            this.CurrentTask = new System.String("FETCH");
        }
        //      C# -> System.String? DownloadJobStatus
        // GraphQL -> downloadJobStatus: String (scalar)
        if (this.DownloadJobStatus == null && Exploration.Includes(parent + ".downloadJobStatus", true))
        {
            this.DownloadJobStatus = new System.String("FETCH");
        }
        //      C# -> System.String? DownloadProgress
        // GraphQL -> downloadProgress: String (scalar)
        if (this.DownloadProgress == null && Exploration.Includes(parent + ".downloadProgress", true))
        {
            this.DownloadProgress = new System.String("FETCH");
        }
        //      C# -> System.String? DownloadRemainingTimeEstimateInSeconds
        // GraphQL -> downloadRemainingTimeEstimateInSeconds: String (scalar)
        if (this.DownloadRemainingTimeEstimateInSeconds == null && Exploration.Includes(parent + ".downloadRemainingTimeEstimateInSeconds", true))
        {
            this.DownloadRemainingTimeEstimateInSeconds = new System.String("FETCH");
        }
        //      C# -> System.String? DownloadVersion
        // GraphQL -> downloadVersion: String (scalar)
        if (this.DownloadVersion == null && Exploration.Includes(parent + ".downloadVersion", true))
        {
            this.DownloadVersion = new System.String("FETCH");
        }
        //      C# -> System.String? FinishedStates
        // GraphQL -> finishedStates: String (scalar)
        if (this.FinishedStates == null && Exploration.Includes(parent + ".finishedStates", true))
        {
            this.FinishedStates = new System.String("FETCH");
        }
        //      C# -> System.String? OverallProgress
        // GraphQL -> overallProgress: String (scalar)
        if (this.OverallProgress == null && Exploration.Includes(parent + ".overallProgress", true))
        {
            this.OverallProgress = new System.String("FETCH");
        }
        //      C# -> System.String? PendingStates
        // GraphQL -> pendingStates: String (scalar)
        if (this.PendingStates == null && Exploration.Includes(parent + ".pendingStates", true))
        {
            this.PendingStates = new System.String("FETCH");
        }
        //      C# -> System.String? TotalNodes
        // GraphQL -> totalNodes: String (scalar)
        if (this.TotalNodes == null && Exploration.Includes(parent + ".totalNodes", true))
        {
            this.TotalNodes = new System.String("FETCH");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmClusterStatusInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmClusterStatusInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types