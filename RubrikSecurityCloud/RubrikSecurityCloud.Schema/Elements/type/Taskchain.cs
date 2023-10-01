// Taskchain.cs
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
    #region Taskchain
    public class Taskchain: BaseType
    {
        #region members

        //      C# -> TaskchainState? State
        // GraphQL -> state: TaskchainState! (enum)
        [JsonProperty("state")]
        public TaskchainState? State { get; set; }

        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        [JsonProperty("account")]
        public System.String? Account { get; set; }

        //      C# -> System.String? Component
        // GraphQL -> component: String! (scalar)
        [JsonProperty("component")]
        public System.String? Component { get; set; }

        //      C# -> System.String? Config
        // GraphQL -> config: String! (scalar)
        [JsonProperty("config")]
        public System.String? Config { get; set; }

        //      C# -> System.Int32? CurrentTaskExecutionAttempts
        // GraphQL -> currentTaskExecutionAttempts: Int! (scalar)
        [JsonProperty("currentTaskExecutionAttempts")]
        public System.Int32? CurrentTaskExecutionAttempts { get; set; }

        //      C# -> System.Int32? CurrentTaskIndex
        // GraphQL -> currentTaskIndex: Int! (scalar)
        [JsonProperty("currentTaskIndex")]
        public System.Int32? CurrentTaskIndex { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        [JsonProperty("jobId")]
        public System.Int64? JobId { get; set; }

        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        [JsonProperty("jobType")]
        public System.String? JobType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ParentTaskchainId
        // GraphQL -> parentTaskchainId: String! (scalar)
        [JsonProperty("parentTaskchainId")]
        public System.String? ParentTaskchainId { get; set; }

        //      C# -> System.String? PodName
        // GraphQL -> podName: String! (scalar)
        [JsonProperty("podName")]
        public System.String? PodName { get; set; }

        //      C# -> System.Int32? Priority
        // GraphQL -> priority: Int! (scalar)
        [JsonProperty("priority")]
        public System.Int32? Priority { get; set; }

        //      C# -> System.Int64? Progress
        // GraphQL -> progress: Long! (scalar)
        [JsonProperty("progress")]
        public System.Int64? Progress { get; set; }

        //      C# -> DateTime? ProgressedAt
        // GraphQL -> progressedAt: DateTime (scalar)
        [JsonProperty("progressedAt")]
        public DateTime? ProgressedAt { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: String! (scalar)
        [JsonProperty("taskchainUuid")]
        public System.String? TaskchainUuid { get; set; }

        //      C# -> System.String? WorkflowName
        // GraphQL -> workflowName: String! (scalar)
        [JsonProperty("workflowName")]
        public System.String? WorkflowName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Taskchain";
    }

    public Taskchain Set(
        TaskchainState? State = null,
        System.String? Account = null,
        System.String? Component = null,
        System.String? Config = null,
        System.Int32? CurrentTaskExecutionAttempts = null,
        System.Int32? CurrentTaskIndex = null,
        DateTime? EndTime = null,
        System.String? Error = null,
        System.Int64? Id = null,
        System.Int64? JobId = null,
        System.String? JobType = null,
        System.String? Name = null,
        System.String? ParentTaskchainId = null,
        System.String? PodName = null,
        System.Int32? Priority = null,
        System.Int64? Progress = null,
        DateTime? ProgressedAt = null,
        DateTime? StartTime = null,
        System.String? TaskchainUuid = null,
        System.String? WorkflowName = null
    ) 
    {
        if ( State != null ) {
            this.State = State;
        }
        if ( Account != null ) {
            this.Account = Account;
        }
        if ( Component != null ) {
            this.Component = Component;
        }
        if ( Config != null ) {
            this.Config = Config;
        }
        if ( CurrentTaskExecutionAttempts != null ) {
            this.CurrentTaskExecutionAttempts = CurrentTaskExecutionAttempts;
        }
        if ( CurrentTaskIndex != null ) {
            this.CurrentTaskIndex = CurrentTaskIndex;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ParentTaskchainId != null ) {
            this.ParentTaskchainId = ParentTaskchainId;
        }
        if ( PodName != null ) {
            this.PodName = PodName;
        }
        if ( Priority != null ) {
            this.Priority = Priority;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( ProgressedAt != null ) {
            this.ProgressedAt = ProgressedAt;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( TaskchainUuid != null ) {
            this.TaskchainUuid = TaskchainUuid;
        }
        if ( WorkflowName != null ) {
            this.WorkflowName = WorkflowName;
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
        //      C# -> TaskchainState? State
        // GraphQL -> state: TaskchainState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account != null) {
            if (conf.Flat) {
                s += conf.Prefix + "account\n" ;
            } else {
                s += ind + "account\n" ;
            }
        }
        //      C# -> System.String? Component
        // GraphQL -> component: String! (scalar)
        if (this.Component != null) {
            if (conf.Flat) {
                s += conf.Prefix + "component\n" ;
            } else {
                s += ind + "component\n" ;
            }
        }
        //      C# -> System.String? Config
        // GraphQL -> config: String! (scalar)
        if (this.Config != null) {
            if (conf.Flat) {
                s += conf.Prefix + "config\n" ;
            } else {
                s += ind + "config\n" ;
            }
        }
        //      C# -> System.Int32? CurrentTaskExecutionAttempts
        // GraphQL -> currentTaskExecutionAttempts: Int! (scalar)
        if (this.CurrentTaskExecutionAttempts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentTaskExecutionAttempts\n" ;
            } else {
                s += ind + "currentTaskExecutionAttempts\n" ;
            }
        }
        //      C# -> System.Int32? CurrentTaskIndex
        // GraphQL -> currentTaskIndex: Int! (scalar)
        if (this.CurrentTaskIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentTaskIndex\n" ;
            } else {
                s += ind + "currentTaskIndex\n" ;
            }
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        if (this.JobId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobId\n" ;
            } else {
                s += ind + "jobId\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? ParentTaskchainId
        // GraphQL -> parentTaskchainId: String! (scalar)
        if (this.ParentTaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentTaskchainId\n" ;
            } else {
                s += ind + "parentTaskchainId\n" ;
            }
        }
        //      C# -> System.String? PodName
        // GraphQL -> podName: String! (scalar)
        if (this.PodName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "podName\n" ;
            } else {
                s += ind + "podName\n" ;
            }
        }
        //      C# -> System.Int32? Priority
        // GraphQL -> priority: Int! (scalar)
        if (this.Priority != null) {
            if (conf.Flat) {
                s += conf.Prefix + "priority\n" ;
            } else {
                s += ind + "priority\n" ;
            }
        }
        //      C# -> System.Int64? Progress
        // GraphQL -> progress: Long! (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        //      C# -> DateTime? ProgressedAt
        // GraphQL -> progressedAt: DateTime (scalar)
        if (this.ProgressedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progressedAt\n" ;
            } else {
                s += ind + "progressedAt\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: String! (scalar)
        if (this.TaskchainUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskchainUuid\n" ;
            } else {
                s += ind + "taskchainUuid\n" ;
            }
        }
        //      C# -> System.String? WorkflowName
        // GraphQL -> workflowName: String! (scalar)
        if (this.WorkflowName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workflowName\n" ;
            } else {
                s += ind + "workflowName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TaskchainState? State
        // GraphQL -> state: TaskchainState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new TaskchainState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (ec.Includes("account",true))
        {
            if(this.Account == null) {

                this.Account = "FETCH";

            } else {


            }
        }
        else if (this.Account != null && ec.Excludes("account",true))
        {
            this.Account = null;
        }
        //      C# -> System.String? Component
        // GraphQL -> component: String! (scalar)
        if (ec.Includes("component",true))
        {
            if(this.Component == null) {

                this.Component = "FETCH";

            } else {


            }
        }
        else if (this.Component != null && ec.Excludes("component",true))
        {
            this.Component = null;
        }
        //      C# -> System.String? Config
        // GraphQL -> config: String! (scalar)
        if (ec.Includes("config",true))
        {
            if(this.Config == null) {

                this.Config = "FETCH";

            } else {


            }
        }
        else if (this.Config != null && ec.Excludes("config",true))
        {
            this.Config = null;
        }
        //      C# -> System.Int32? CurrentTaskExecutionAttempts
        // GraphQL -> currentTaskExecutionAttempts: Int! (scalar)
        if (ec.Includes("currentTaskExecutionAttempts",true))
        {
            if(this.CurrentTaskExecutionAttempts == null) {

                this.CurrentTaskExecutionAttempts = Int32.MinValue;

            } else {


            }
        }
        else if (this.CurrentTaskExecutionAttempts != null && ec.Excludes("currentTaskExecutionAttempts",true))
        {
            this.CurrentTaskExecutionAttempts = null;
        }
        //      C# -> System.Int32? CurrentTaskIndex
        // GraphQL -> currentTaskIndex: Int! (scalar)
        if (ec.Includes("currentTaskIndex",true))
        {
            if(this.CurrentTaskIndex == null) {

                this.CurrentTaskIndex = Int32.MinValue;

            } else {


            }
        }
        else if (this.CurrentTaskIndex != null && ec.Excludes("currentTaskIndex",true))
        {
            this.CurrentTaskIndex = null;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        if (ec.Includes("jobId",true))
        {
            if(this.JobId == null) {

                this.JobId = new System.Int64();

            } else {


            }
        }
        else if (this.JobId != null && ec.Excludes("jobId",true))
        {
            this.JobId = null;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? ParentTaskchainId
        // GraphQL -> parentTaskchainId: String! (scalar)
        if (ec.Includes("parentTaskchainId",true))
        {
            if(this.ParentTaskchainId == null) {

                this.ParentTaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.ParentTaskchainId != null && ec.Excludes("parentTaskchainId",true))
        {
            this.ParentTaskchainId = null;
        }
        //      C# -> System.String? PodName
        // GraphQL -> podName: String! (scalar)
        if (ec.Includes("podName",true))
        {
            if(this.PodName == null) {

                this.PodName = "FETCH";

            } else {


            }
        }
        else if (this.PodName != null && ec.Excludes("podName",true))
        {
            this.PodName = null;
        }
        //      C# -> System.Int32? Priority
        // GraphQL -> priority: Int! (scalar)
        if (ec.Includes("priority",true))
        {
            if(this.Priority == null) {

                this.Priority = Int32.MinValue;

            } else {


            }
        }
        else if (this.Priority != null && ec.Excludes("priority",true))
        {
            this.Priority = null;
        }
        //      C# -> System.Int64? Progress
        // GraphQL -> progress: Long! (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = new System.Int64();

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
        }
        //      C# -> DateTime? ProgressedAt
        // GraphQL -> progressedAt: DateTime (scalar)
        if (ec.Includes("progressedAt",true))
        {
            if(this.ProgressedAt == null) {

                this.ProgressedAt = new DateTime();

            } else {


            }
        }
        else if (this.ProgressedAt != null && ec.Excludes("progressedAt",true))
        {
            this.ProgressedAt = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: String! (scalar)
        if (ec.Includes("taskchainUuid",true))
        {
            if(this.TaskchainUuid == null) {

                this.TaskchainUuid = "FETCH";

            } else {


            }
        }
        else if (this.TaskchainUuid != null && ec.Excludes("taskchainUuid",true))
        {
            this.TaskchainUuid = null;
        }
        //      C# -> System.String? WorkflowName
        // GraphQL -> workflowName: String! (scalar)
        if (ec.Includes("workflowName",true))
        {
            if(this.WorkflowName == null) {

                this.WorkflowName = "FETCH";

            } else {


            }
        }
        else if (this.WorkflowName != null && ec.Excludes("workflowName",true))
        {
            this.WorkflowName = null;
        }
    }


    #endregion

    } // class Taskchain
    
    #endregion

    public static class ListTaskchainExtensions
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
            this List<Taskchain> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<Taskchain> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Taskchain> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Taskchain());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Taskchain> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types