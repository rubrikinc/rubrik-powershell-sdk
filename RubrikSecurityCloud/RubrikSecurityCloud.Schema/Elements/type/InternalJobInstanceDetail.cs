// InternalJobInstanceDetail.cs
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
    #region InternalJobInstanceDetail
    public class InternalJobInstanceDetail: BaseType
    {
        #region members

        //      C# -> System.Boolean? Archived
        // GraphQL -> archived: Boolean! (scalar)
        [JsonProperty("archived")]
        public System.Boolean? Archived { get; set; }

        //      C# -> System.String? ChildJobDebugInfo
        // GraphQL -> childJobDebugInfo: String (scalar)
        [JsonProperty("childJobDebugInfo")]
        public System.String? ChildJobDebugInfo { get; set; }

        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        [JsonProperty("endTime")]
        public System.String? EndTime { get; set; }

        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        [JsonProperty("errorInfo")]
        public System.String? ErrorInfo { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        [JsonProperty("isDisabled")]
        public System.Boolean? IsDisabled { get; set; }

        //      C# -> System.Single? JobProgress
        // GraphQL -> jobProgress: Float (scalar)
        [JsonProperty("jobProgress")]
        public System.Single? JobProgress { get; set; }

        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        [JsonProperty("jobType")]
        public System.String? JobType { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? OpentracingContext
        // GraphQL -> opentracingContext: String (scalar)
        [JsonProperty("opentracingContext")]
        public System.String? OpentracingContext { get; set; }

        //      C# -> System.String? Result
        // GraphQL -> result: String (scalar)
        [JsonProperty("result")]
        public System.String? Result { get; set; }

        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String (scalar)
        [JsonProperty("startTime")]
        public System.String? StartTime { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InternalJobInstanceDetail";
    }

    public InternalJobInstanceDetail Set(
        System.Boolean? Archived = null,
        System.String? ChildJobDebugInfo = null,
        System.String? EndTime = null,
        System.String? ErrorInfo = null,
        System.String? Id = null,
        System.Boolean? IsDisabled = null,
        System.Single? JobProgress = null,
        System.String? JobType = null,
        System.String? NodeId = null,
        System.String? OpentracingContext = null,
        System.String? Result = null,
        System.String? StartTime = null,
        System.String? Status = null
    ) 
    {
        if ( Archived != null ) {
            this.Archived = Archived;
        }
        if ( ChildJobDebugInfo != null ) {
            this.ChildJobDebugInfo = ChildJobDebugInfo;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( ErrorInfo != null ) {
            this.ErrorInfo = ErrorInfo;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsDisabled != null ) {
            this.IsDisabled = IsDisabled;
        }
        if ( JobProgress != null ) {
            this.JobProgress = JobProgress;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( OpentracingContext != null ) {
            this.OpentracingContext = OpentracingContext;
        }
        if ( Result != null ) {
            this.Result = Result;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.Boolean? Archived
        // GraphQL -> archived: Boolean! (scalar)
        if (this.Archived != null) {
            s += ind + "archived\n" ;
        }
        //      C# -> System.String? ChildJobDebugInfo
        // GraphQL -> childJobDebugInfo: String (scalar)
        if (this.ChildJobDebugInfo != null) {
            s += ind + "childJobDebugInfo\n" ;
        }
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        if (this.ErrorInfo != null) {
            s += ind + "errorInfo\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        if (this.IsDisabled != null) {
            s += ind + "isDisabled\n" ;
        }
        //      C# -> System.Single? JobProgress
        // GraphQL -> jobProgress: Float (scalar)
        if (this.JobProgress != null) {
            s += ind + "jobProgress\n" ;
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (this.JobType != null) {
            s += ind + "jobType\n" ;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            s += ind + "nodeId\n" ;
        }
        //      C# -> System.String? OpentracingContext
        // GraphQL -> opentracingContext: String (scalar)
        if (this.OpentracingContext != null) {
            s += ind + "opentracingContext\n" ;
        }
        //      C# -> System.String? Result
        // GraphQL -> result: String (scalar)
        if (this.Result != null) {
            s += ind + "result\n" ;
        }
        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? Archived
        // GraphQL -> archived: Boolean! (scalar)
        if (this.Archived == null && Exploration.Includes(parent + ".archived", true))
        {
            this.Archived = true;
        }
        //      C# -> System.String? ChildJobDebugInfo
        // GraphQL -> childJobDebugInfo: String (scalar)
        if (this.ChildJobDebugInfo == null && Exploration.Includes(parent + ".childJobDebugInfo", true))
        {
            this.ChildJobDebugInfo = "FETCH";
        }
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = "FETCH";
        }
        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        if (this.ErrorInfo == null && Exploration.Includes(parent + ".errorInfo", true))
        {
            this.ErrorInfo = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        if (this.IsDisabled == null && Exploration.Includes(parent + ".isDisabled", true))
        {
            this.IsDisabled = true;
        }
        //      C# -> System.Single? JobProgress
        // GraphQL -> jobProgress: Float (scalar)
        if (this.JobProgress == null && Exploration.Includes(parent + ".jobProgress", true))
        {
            this.JobProgress = new System.Single();
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (this.JobType == null && Exploration.Includes(parent + ".jobType", true))
        {
            this.JobType = "FETCH";
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId == null && Exploration.Includes(parent + ".nodeId", true))
        {
            this.NodeId = "FETCH";
        }
        //      C# -> System.String? OpentracingContext
        // GraphQL -> opentracingContext: String (scalar)
        if (this.OpentracingContext == null && Exploration.Includes(parent + ".opentracingContext", true))
        {
            this.OpentracingContext = "FETCH";
        }
        //      C# -> System.String? Result
        // GraphQL -> result: String (scalar)
        if (this.Result == null && Exploration.Includes(parent + ".result", true))
        {
            this.Result = "FETCH";
        }
        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = "FETCH";
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
    }


    #endregion

    } // class InternalJobInstanceDetail
    
    #endregion

    public static class ListInternalJobInstanceDetailExtensions
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
            this List<InternalJobInstanceDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<InternalJobInstanceDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new InternalJobInstanceDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types