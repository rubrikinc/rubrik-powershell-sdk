// Taskchain.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:54.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region Taskchain
    public class Taskchain: IFragment
    {
        #region members
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

        //      C# -> TaskchainState? State
        // GraphQL -> state: TaskchainState! (enum)
        [JsonProperty("state")]
        public TaskchainState? State { get; set; }

        #endregion

    #region methods

    public Taskchain Set(
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
        System.String? WorkflowName = null,
        TaskchainState? State = null
    ) 
    {
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
        if ( State != null ) {
            this.State = State;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Account
            // GraphQL -> account: String! (scalar)
            if (this.Account != null)
            {
                 s += ind + "account\n";

            }
            //      C# -> System.String? Component
            // GraphQL -> component: String! (scalar)
            if (this.Component != null)
            {
                 s += ind + "component\n";

            }
            //      C# -> System.String? Config
            // GraphQL -> config: String! (scalar)
            if (this.Config != null)
            {
                 s += ind + "config\n";

            }
            //      C# -> System.Int32? CurrentTaskExecutionAttempts
            // GraphQL -> currentTaskExecutionAttempts: Int! (scalar)
            if (this.CurrentTaskExecutionAttempts != null)
            {
                 s += ind + "currentTaskExecutionAttempts\n";

            }
            //      C# -> System.Int32? CurrentTaskIndex
            // GraphQL -> currentTaskIndex: Int! (scalar)
            if (this.CurrentTaskIndex != null)
            {
                 s += ind + "currentTaskIndex\n";

            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error != null)
            {
                 s += ind + "error\n";

            }
            //      C# -> System.Int64? Id
            // GraphQL -> id: Long! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? JobId
            // GraphQL -> jobId: Long! (scalar)
            if (this.JobId != null)
            {
                 s += ind + "jobId\n";

            }
            //      C# -> System.String? JobType
            // GraphQL -> jobType: String! (scalar)
            if (this.JobType != null)
            {
                 s += ind + "jobType\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? ParentTaskchainId
            // GraphQL -> parentTaskchainId: String! (scalar)
            if (this.ParentTaskchainId != null)
            {
                 s += ind + "parentTaskchainId\n";

            }
            //      C# -> System.String? PodName
            // GraphQL -> podName: String! (scalar)
            if (this.PodName != null)
            {
                 s += ind + "podName\n";

            }
            //      C# -> System.Int32? Priority
            // GraphQL -> priority: Int! (scalar)
            if (this.Priority != null)
            {
                 s += ind + "priority\n";

            }
            //      C# -> System.Int64? Progress
            // GraphQL -> progress: Long! (scalar)
            if (this.Progress != null)
            {
                 s += ind + "progress\n";

            }
            //      C# -> DateTime? ProgressedAt
            // GraphQL -> progressedAt: DateTime (scalar)
            if (this.ProgressedAt != null)
            {
                 s += ind + "progressedAt\n";

            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            //      C# -> System.String? TaskchainUuid
            // GraphQL -> taskchainUuid: String! (scalar)
            if (this.TaskchainUuid != null)
            {
                 s += ind + "taskchainUuid\n";

            }
            //      C# -> System.String? WorkflowName
            // GraphQL -> workflowName: String! (scalar)
            if (this.WorkflowName != null)
            {
                 s += ind + "workflowName\n";

            }
            //      C# -> TaskchainState? State
            // GraphQL -> state: TaskchainState! (enum)
            if (this.State != null)
            {
                 s += ind + "state\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Account
            // GraphQL -> account: String! (scalar)
            if (this.Account == null && Exploration.Includes(parent + ".account$"))
            {
                this.Account = new System.String("FETCH");
            }
            //      C# -> System.String? Component
            // GraphQL -> component: String! (scalar)
            if (this.Component == null && Exploration.Includes(parent + ".component$"))
            {
                this.Component = new System.String("FETCH");
            }
            //      C# -> System.String? Config
            // GraphQL -> config: String! (scalar)
            if (this.Config == null && Exploration.Includes(parent + ".config$"))
            {
                this.Config = new System.String("FETCH");
            }
            //      C# -> System.Int32? CurrentTaskExecutionAttempts
            // GraphQL -> currentTaskExecutionAttempts: Int! (scalar)
            if (this.CurrentTaskExecutionAttempts == null && Exploration.Includes(parent + ".currentTaskExecutionAttempts$"))
            {
                this.CurrentTaskExecutionAttempts = new System.Int32();
            }
            //      C# -> System.Int32? CurrentTaskIndex
            // GraphQL -> currentTaskIndex: Int! (scalar)
            if (this.CurrentTaskIndex == null && Exploration.Includes(parent + ".currentTaskIndex$"))
            {
                this.CurrentTaskIndex = new System.Int32();
            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error == null && Exploration.Includes(parent + ".error$"))
            {
                this.Error = new System.String("FETCH");
            }
            //      C# -> System.Int64? Id
            // GraphQL -> id: Long! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.Int64();
            }
            //      C# -> System.Int64? JobId
            // GraphQL -> jobId: Long! (scalar)
            if (this.JobId == null && Exploration.Includes(parent + ".jobId$"))
            {
                this.JobId = new System.Int64();
            }
            //      C# -> System.String? JobType
            // GraphQL -> jobType: String! (scalar)
            if (this.JobType == null && Exploration.Includes(parent + ".jobType$"))
            {
                this.JobType = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? ParentTaskchainId
            // GraphQL -> parentTaskchainId: String! (scalar)
            if (this.ParentTaskchainId == null && Exploration.Includes(parent + ".parentTaskchainId$"))
            {
                this.ParentTaskchainId = new System.String("FETCH");
            }
            //      C# -> System.String? PodName
            // GraphQL -> podName: String! (scalar)
            if (this.PodName == null && Exploration.Includes(parent + ".podName$"))
            {
                this.PodName = new System.String("FETCH");
            }
            //      C# -> System.Int32? Priority
            // GraphQL -> priority: Int! (scalar)
            if (this.Priority == null && Exploration.Includes(parent + ".priority$"))
            {
                this.Priority = new System.Int32();
            }
            //      C# -> System.Int64? Progress
            // GraphQL -> progress: Long! (scalar)
            if (this.Progress == null && Exploration.Includes(parent + ".progress$"))
            {
                this.Progress = new System.Int64();
            }
            //      C# -> DateTime? ProgressedAt
            // GraphQL -> progressedAt: DateTime (scalar)
            if (this.ProgressedAt == null && Exploration.Includes(parent + ".progressedAt$"))
            {
                this.ProgressedAt = new DateTime();
            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new DateTime();
            }
            //      C# -> System.String? TaskchainUuid
            // GraphQL -> taskchainUuid: String! (scalar)
            if (this.TaskchainUuid == null && Exploration.Includes(parent + ".taskchainUuid$"))
            {
                this.TaskchainUuid = new System.String("FETCH");
            }
            //      C# -> System.String? WorkflowName
            // GraphQL -> workflowName: String! (scalar)
            if (this.WorkflowName == null && Exploration.Includes(parent + ".workflowName$"))
            {
                this.WorkflowName = new System.String("FETCH");
            }
            //      C# -> TaskchainState? State
            // GraphQL -> state: TaskchainState! (enum)
            if (this.State == null && Exploration.Includes(parent + ".state$"))
            {
                this.State = new TaskchainState();
            }
        }


    #endregion

    } // class Taskchain
    #endregion

    public static class ListTaskchainExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<Taskchain> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Taskchain> list, 
            String parent = "")
        {
            var item = new Taskchain();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types