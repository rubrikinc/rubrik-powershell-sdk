// TaskchainInfoReply.cs
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
    #region TaskchainInfoReply
    public class TaskchainInfoReply: BaseType
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

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        [JsonProperty("jobId")]
        public System.Int64? JobId { get; set; }

        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        [JsonProperty("jobType")]
        public System.String? JobType { get; set; }

        //      C# -> System.String? PlatformConfig
        // GraphQL -> platformConfig: String (scalar)
        [JsonProperty("platformConfig")]
        public System.String? PlatformConfig { get; set; }

        //      C# -> System.Int64? Progress
        // GraphQL -> progress: Long! (scalar)
        [JsonProperty("progress")]
        public System.Int64? Progress { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TaskchainInfoReply";
    }

    public TaskchainInfoReply Set(
        TaskchainState? State = null,
        System.String? Account = null,
        DateTime? EndTime = null,
        System.String? Error = null,
        System.Int64? JobId = null,
        System.String? JobType = null,
        System.String? PlatformConfig = null,
        System.Int64? Progress = null,
        DateTime? StartTime = null,
        System.String? TaskchainId = null
    ) 
    {
        if ( State != null ) {
            this.State = State;
        }
        if ( Account != null ) {
            this.Account = Account;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( PlatformConfig != null ) {
            this.PlatformConfig = PlatformConfig;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
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
        //      C# -> TaskchainState? State
        // GraphQL -> state: TaskchainState! (enum)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account != null) {
            s += ind + "account\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            s += ind + "error\n" ;
        }
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        if (this.JobId != null) {
            s += ind + "jobId\n" ;
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (this.JobType != null) {
            s += ind + "jobType\n" ;
        }
        //      C# -> System.String? PlatformConfig
        // GraphQL -> platformConfig: String (scalar)
        if (this.PlatformConfig != null) {
            s += ind + "platformConfig\n" ;
        }
        //      C# -> System.Int64? Progress
        // GraphQL -> progress: Long! (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (this.TaskchainId != null) {
            s += ind + "taskchainId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TaskchainState? State
        // GraphQL -> state: TaskchainState! (enum)
        if (this.State == null && Exploration.Includes(parent + ".state", true))
        {
            this.State = new TaskchainState();
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account == null && Exploration.Includes(parent + ".account", true))
        {
            this.Account = "FETCH";
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error == null && Exploration.Includes(parent + ".error", true))
        {
            this.Error = "FETCH";
        }
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        if (this.JobId == null && Exploration.Includes(parent + ".jobId", true))
        {
            this.JobId = new System.Int64();
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (this.JobType == null && Exploration.Includes(parent + ".jobType", true))
        {
            this.JobType = "FETCH";
        }
        //      C# -> System.String? PlatformConfig
        // GraphQL -> platformConfig: String (scalar)
        if (this.PlatformConfig == null && Exploration.Includes(parent + ".platformConfig", true))
        {
            this.PlatformConfig = "FETCH";
        }
        //      C# -> System.Int64? Progress
        // GraphQL -> progress: Long! (scalar)
        if (this.Progress == null && Exploration.Includes(parent + ".progress", true))
        {
            this.Progress = new System.Int64();
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (this.TaskchainId == null && Exploration.Includes(parent + ".taskchainId", true))
        {
            this.TaskchainId = "FETCH";
        }
    }


    #endregion

    } // class TaskchainInfoReply
    
    #endregion

    public static class ListTaskchainInfoReplyExtensions
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
            this List<TaskchainInfoReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TaskchainInfoReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskchainInfoReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types