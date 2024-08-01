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

        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String (scalar)
        [JsonProperty("eventSeriesId")]
        public System.String? EventSeriesId { get; set; }

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
        System.String? EventSeriesId = null,
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
        if ( EventSeriesId != null ) {
            this.EventSeriesId = EventSeriesId;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? Archived
        // GraphQL -> archived: Boolean! (scalar)
        if (this.Archived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archived\n" ;
            } else {
                s += ind + "archived\n" ;
            }
        }
        //      C# -> System.String? ChildJobDebugInfo
        // GraphQL -> childJobDebugInfo: String (scalar)
        if (this.ChildJobDebugInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "childJobDebugInfo\n" ;
            } else {
                s += ind + "childJobDebugInfo\n" ;
            }
        }
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        if (this.ErrorInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorInfo\n" ;
            } else {
                s += ind + "errorInfo\n" ;
            }
        }
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String (scalar)
        if (this.EventSeriesId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventSeriesId\n" ;
            } else {
                s += ind + "eventSeriesId\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        if (this.IsDisabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDisabled\n" ;
            } else {
                s += ind + "isDisabled\n" ;
            }
        }
        //      C# -> System.Single? JobProgress
        // GraphQL -> jobProgress: Float (scalar)
        if (this.JobProgress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobProgress\n" ;
            } else {
                s += ind + "jobProgress\n" ;
            }
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (this.JobType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobType\n" ;
            } else {
                s += ind + "jobType\n" ;
            }
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeId\n" ;
            } else {
                s += ind + "nodeId\n" ;
            }
        }
        //      C# -> System.String? OpentracingContext
        // GraphQL -> opentracingContext: String (scalar)
        if (this.OpentracingContext != null) {
            if (conf.Flat) {
                s += conf.Prefix + "opentracingContext\n" ;
            } else {
                s += ind + "opentracingContext\n" ;
            }
        }
        //      C# -> System.String? Result
        // GraphQL -> result: String (scalar)
        if (this.Result != null) {
            if (conf.Flat) {
                s += conf.Prefix + "result\n" ;
            } else {
                s += ind + "result\n" ;
            }
        }
        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? Archived
        // GraphQL -> archived: Boolean! (scalar)
        if (ec.Includes("archived",true))
        {
            if(this.Archived == null) {

                this.Archived = true;

            } else {


            }
        }
        else if (this.Archived != null && ec.Excludes("archived",true))
        {
            this.Archived = null;
        }
        //      C# -> System.String? ChildJobDebugInfo
        // GraphQL -> childJobDebugInfo: String (scalar)
        if (ec.Includes("childJobDebugInfo",true))
        {
            if(this.ChildJobDebugInfo == null) {

                this.ChildJobDebugInfo = "FETCH";

            } else {


            }
        }
        else if (this.ChildJobDebugInfo != null && ec.Excludes("childJobDebugInfo",true))
        {
            this.ChildJobDebugInfo = null;
        }
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = "FETCH";

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        if (ec.Includes("errorInfo",true))
        {
            if(this.ErrorInfo == null) {

                this.ErrorInfo = "FETCH";

            } else {


            }
        }
        else if (this.ErrorInfo != null && ec.Excludes("errorInfo",true))
        {
            this.ErrorInfo = null;
        }
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String (scalar)
        if (ec.Includes("eventSeriesId",true))
        {
            if(this.EventSeriesId == null) {

                this.EventSeriesId = "FETCH";

            } else {


            }
        }
        else if (this.EventSeriesId != null && ec.Excludes("eventSeriesId",true))
        {
            this.EventSeriesId = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsDisabled
        // GraphQL -> isDisabled: Boolean! (scalar)
        if (ec.Includes("isDisabled",true))
        {
            if(this.IsDisabled == null) {

                this.IsDisabled = true;

            } else {


            }
        }
        else if (this.IsDisabled != null && ec.Excludes("isDisabled",true))
        {
            this.IsDisabled = null;
        }
        //      C# -> System.Single? JobProgress
        // GraphQL -> jobProgress: Float (scalar)
        if (ec.Includes("jobProgress",true))
        {
            if(this.JobProgress == null) {

                this.JobProgress = new System.Single();

            } else {


            }
        }
        else if (this.JobProgress != null && ec.Excludes("jobProgress",true))
        {
            this.JobProgress = null;
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (ec.Includes("jobType",true))
        {
            if(this.JobType == null) {

                this.JobType = "FETCH";

            } else {


            }
        }
        else if (this.JobType != null && ec.Excludes("jobType",true))
        {
            this.JobType = null;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (ec.Includes("nodeId",true))
        {
            if(this.NodeId == null) {

                this.NodeId = "FETCH";

            } else {


            }
        }
        else if (this.NodeId != null && ec.Excludes("nodeId",true))
        {
            this.NodeId = null;
        }
        //      C# -> System.String? OpentracingContext
        // GraphQL -> opentracingContext: String (scalar)
        if (ec.Includes("opentracingContext",true))
        {
            if(this.OpentracingContext == null) {

                this.OpentracingContext = "FETCH";

            } else {


            }
        }
        else if (this.OpentracingContext != null && ec.Excludes("opentracingContext",true))
        {
            this.OpentracingContext = null;
        }
        //      C# -> System.String? Result
        // GraphQL -> result: String (scalar)
        if (ec.Includes("result",true))
        {
            if(this.Result == null) {

                this.Result = "FETCH";

            } else {


            }
        }
        else if (this.Result != null && ec.Excludes("result",true))
        {
            this.Result = null;
        }
        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = "FETCH";

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class InternalJobInstanceDetail
    
    #endregion

    public static class ListInternalJobInstanceDetailExtensions
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
            this List<InternalJobInstanceDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<InternalJobInstanceDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<InternalJobInstanceDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InternalJobInstanceDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<InternalJobInstanceDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types