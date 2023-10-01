// JobMetadata.cs
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
    #region JobMetadata
    public class JobMetadata: BaseType
    {
        #region members

        //      C# -> LogLevel? LogLevel
        // GraphQL -> logLevel: LogLevel! (enum)
        [JsonProperty("logLevel")]
        public LogLevel? LogLevel { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.Int32? CurrentInstance
        // GraphQL -> currentInstance: Int! (scalar)
        [JsonProperty("currentInstance")]
        public System.Int32? CurrentInstance { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        [JsonProperty("info")]
        public System.String? Info { get; set; }

        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        [JsonProperty("jobType")]
        public System.String? JobType { get; set; }

        //      C# -> DateTime? LastFailure
        // GraphQL -> lastFailure: DateTime (scalar)
        [JsonProperty("lastFailure")]
        public DateTime? LastFailure { get; set; }

        //      C# -> System.String? LastOwner
        // GraphQL -> lastOwner: String! (scalar)
        [JsonProperty("lastOwner")]
        public System.String? LastOwner { get; set; }

        //      C# -> DateTime? LastSkipped
        // GraphQL -> lastSkipped: DateTime (scalar)
        [JsonProperty("lastSkipped")]
        public DateTime? LastSkipped { get; set; }

        //      C# -> DateTime? LastSuccess
        // GraphQL -> lastSuccess: DateTime (scalar)
        [JsonProperty("lastSuccess")]
        public DateTime? LastSuccess { get; set; }

        //      C# -> System.Int32? NumScheduledRuns
        // GraphQL -> numScheduledRuns: Int! (scalar)
        [JsonProperty("numScheduledRuns")]
        public System.Int32? NumScheduledRuns { get; set; }

        //      C# -> System.Int32? NumSuccessfulRuns
        // GraphQL -> numSuccessfulRuns: Int! (scalar)
        [JsonProperty("numSuccessfulRuns")]
        public System.Int32? NumSuccessfulRuns { get; set; }

        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        [JsonProperty("owner")]
        public System.String? Owner { get; set; }

        //      C# -> System.String? Progress
        // GraphQL -> progress: String! (scalar)
        [JsonProperty("progress")]
        public System.String? Progress { get; set; }

        //      C# -> DateTime? ProgressedAt
        // GraphQL -> progressedAt: DateTime (scalar)
        [JsonProperty("progressedAt")]
        public DateTime? ProgressedAt { get; set; }

        //      C# -> System.Int32? RetryAttempts
        // GraphQL -> retryAttempts: Int! (scalar)
        [JsonProperty("retryAttempts")]
        public System.Int32? RetryAttempts { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> DateTime? StartedAt
        // GraphQL -> startedAt: DateTime (scalar)
        [JsonProperty("startedAt")]
        public DateTime? StartedAt { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "JobMetadata";
    }

    public JobMetadata Set(
        LogLevel? LogLevel = null,
        DateTime? CreatedAt = null,
        System.Int32? CurrentInstance = null,
        System.Int64? Id = null,
        System.String? Info = null,
        System.String? JobType = null,
        DateTime? LastFailure = null,
        System.String? LastOwner = null,
        DateTime? LastSkipped = null,
        DateTime? LastSuccess = null,
        System.Int32? NumScheduledRuns = null,
        System.Int32? NumSuccessfulRuns = null,
        System.String? Owner = null,
        System.String? Progress = null,
        DateTime? ProgressedAt = null,
        System.Int32? RetryAttempts = null,
        DateTime? StartTime = null,
        DateTime? StartedAt = null,
        System.String? State = null,
        DateTime? UpdatedAt = null
    ) 
    {
        if ( LogLevel != null ) {
            this.LogLevel = LogLevel;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( CurrentInstance != null ) {
            this.CurrentInstance = CurrentInstance;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Info != null ) {
            this.Info = Info;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( LastFailure != null ) {
            this.LastFailure = LastFailure;
        }
        if ( LastOwner != null ) {
            this.LastOwner = LastOwner;
        }
        if ( LastSkipped != null ) {
            this.LastSkipped = LastSkipped;
        }
        if ( LastSuccess != null ) {
            this.LastSuccess = LastSuccess;
        }
        if ( NumScheduledRuns != null ) {
            this.NumScheduledRuns = NumScheduledRuns;
        }
        if ( NumSuccessfulRuns != null ) {
            this.NumSuccessfulRuns = NumSuccessfulRuns;
        }
        if ( Owner != null ) {
            this.Owner = Owner;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( ProgressedAt != null ) {
            this.ProgressedAt = ProgressedAt;
        }
        if ( RetryAttempts != null ) {
            this.RetryAttempts = RetryAttempts;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( StartedAt != null ) {
            this.StartedAt = StartedAt;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
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
        //      C# -> LogLevel? LogLevel
        // GraphQL -> logLevel: LogLevel! (enum)
        if (this.LogLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logLevel\n" ;
            } else {
                s += ind + "logLevel\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.Int32? CurrentInstance
        // GraphQL -> currentInstance: Int! (scalar)
        if (this.CurrentInstance != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentInstance\n" ;
            } else {
                s += ind + "currentInstance\n" ;
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
        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        if (this.Info != null) {
            if (conf.Flat) {
                s += conf.Prefix + "info\n" ;
            } else {
                s += ind + "info\n" ;
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
        //      C# -> DateTime? LastFailure
        // GraphQL -> lastFailure: DateTime (scalar)
        if (this.LastFailure != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastFailure\n" ;
            } else {
                s += ind + "lastFailure\n" ;
            }
        }
        //      C# -> System.String? LastOwner
        // GraphQL -> lastOwner: String! (scalar)
        if (this.LastOwner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastOwner\n" ;
            } else {
                s += ind + "lastOwner\n" ;
            }
        }
        //      C# -> DateTime? LastSkipped
        // GraphQL -> lastSkipped: DateTime (scalar)
        if (this.LastSkipped != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSkipped\n" ;
            } else {
                s += ind + "lastSkipped\n" ;
            }
        }
        //      C# -> DateTime? LastSuccess
        // GraphQL -> lastSuccess: DateTime (scalar)
        if (this.LastSuccess != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSuccess\n" ;
            } else {
                s += ind + "lastSuccess\n" ;
            }
        }
        //      C# -> System.Int32? NumScheduledRuns
        // GraphQL -> numScheduledRuns: Int! (scalar)
        if (this.NumScheduledRuns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numScheduledRuns\n" ;
            } else {
                s += ind + "numScheduledRuns\n" ;
            }
        }
        //      C# -> System.Int32? NumSuccessfulRuns
        // GraphQL -> numSuccessfulRuns: Int! (scalar)
        if (this.NumSuccessfulRuns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numSuccessfulRuns\n" ;
            } else {
                s += ind + "numSuccessfulRuns\n" ;
            }
        }
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (this.Owner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "owner\n" ;
            } else {
                s += ind + "owner\n" ;
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
        //      C# -> DateTime? ProgressedAt
        // GraphQL -> progressedAt: DateTime (scalar)
        if (this.ProgressedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progressedAt\n" ;
            } else {
                s += ind + "progressedAt\n" ;
            }
        }
        //      C# -> System.Int32? RetryAttempts
        // GraphQL -> retryAttempts: Int! (scalar)
        if (this.RetryAttempts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retryAttempts\n" ;
            } else {
                s += ind + "retryAttempts\n" ;
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
        //      C# -> DateTime? StartedAt
        // GraphQL -> startedAt: DateTime (scalar)
        if (this.StartedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startedAt\n" ;
            } else {
                s += ind + "startedAt\n" ;
            }
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> LogLevel? LogLevel
        // GraphQL -> logLevel: LogLevel! (enum)
        if (ec.Includes("logLevel",true))
        {
            if(this.LogLevel == null) {

                this.LogLevel = new LogLevel();

            } else {


            }
        }
        else if (this.LogLevel != null && ec.Excludes("logLevel",true))
        {
            this.LogLevel = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.Int32? CurrentInstance
        // GraphQL -> currentInstance: Int! (scalar)
        if (ec.Includes("currentInstance",true))
        {
            if(this.CurrentInstance == null) {

                this.CurrentInstance = Int32.MinValue;

            } else {


            }
        }
        else if (this.CurrentInstance != null && ec.Excludes("currentInstance",true))
        {
            this.CurrentInstance = null;
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
        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        if (ec.Includes("info",true))
        {
            if(this.Info == null) {

                this.Info = "FETCH";

            } else {


            }
        }
        else if (this.Info != null && ec.Excludes("info",true))
        {
            this.Info = null;
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
        //      C# -> DateTime? LastFailure
        // GraphQL -> lastFailure: DateTime (scalar)
        if (ec.Includes("lastFailure",true))
        {
            if(this.LastFailure == null) {

                this.LastFailure = new DateTime();

            } else {


            }
        }
        else if (this.LastFailure != null && ec.Excludes("lastFailure",true))
        {
            this.LastFailure = null;
        }
        //      C# -> System.String? LastOwner
        // GraphQL -> lastOwner: String! (scalar)
        if (ec.Includes("lastOwner",true))
        {
            if(this.LastOwner == null) {

                this.LastOwner = "FETCH";

            } else {


            }
        }
        else if (this.LastOwner != null && ec.Excludes("lastOwner",true))
        {
            this.LastOwner = null;
        }
        //      C# -> DateTime? LastSkipped
        // GraphQL -> lastSkipped: DateTime (scalar)
        if (ec.Includes("lastSkipped",true))
        {
            if(this.LastSkipped == null) {

                this.LastSkipped = new DateTime();

            } else {


            }
        }
        else if (this.LastSkipped != null && ec.Excludes("lastSkipped",true))
        {
            this.LastSkipped = null;
        }
        //      C# -> DateTime? LastSuccess
        // GraphQL -> lastSuccess: DateTime (scalar)
        if (ec.Includes("lastSuccess",true))
        {
            if(this.LastSuccess == null) {

                this.LastSuccess = new DateTime();

            } else {


            }
        }
        else if (this.LastSuccess != null && ec.Excludes("lastSuccess",true))
        {
            this.LastSuccess = null;
        }
        //      C# -> System.Int32? NumScheduledRuns
        // GraphQL -> numScheduledRuns: Int! (scalar)
        if (ec.Includes("numScheduledRuns",true))
        {
            if(this.NumScheduledRuns == null) {

                this.NumScheduledRuns = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumScheduledRuns != null && ec.Excludes("numScheduledRuns",true))
        {
            this.NumScheduledRuns = null;
        }
        //      C# -> System.Int32? NumSuccessfulRuns
        // GraphQL -> numSuccessfulRuns: Int! (scalar)
        if (ec.Includes("numSuccessfulRuns",true))
        {
            if(this.NumSuccessfulRuns == null) {

                this.NumSuccessfulRuns = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumSuccessfulRuns != null && ec.Excludes("numSuccessfulRuns",true))
        {
            this.NumSuccessfulRuns = null;
        }
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (ec.Includes("owner",true))
        {
            if(this.Owner == null) {

                this.Owner = "FETCH";

            } else {


            }
        }
        else if (this.Owner != null && ec.Excludes("owner",true))
        {
            this.Owner = null;
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
        //      C# -> System.Int32? RetryAttempts
        // GraphQL -> retryAttempts: Int! (scalar)
        if (ec.Includes("retryAttempts",true))
        {
            if(this.RetryAttempts == null) {

                this.RetryAttempts = Int32.MinValue;

            } else {


            }
        }
        else if (this.RetryAttempts != null && ec.Excludes("retryAttempts",true))
        {
            this.RetryAttempts = null;
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
        //      C# -> DateTime? StartedAt
        // GraphQL -> startedAt: DateTime (scalar)
        if (ec.Includes("startedAt",true))
        {
            if(this.StartedAt == null) {

                this.StartedAt = new DateTime();

            } else {


            }
        }
        else if (this.StartedAt != null && ec.Excludes("startedAt",true))
        {
            this.StartedAt = null;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = "FETCH";

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
    }


    #endregion

    } // class JobMetadata
    
    #endregion

    public static class ListJobMetadataExtensions
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
            this List<JobMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<JobMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<JobMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new JobMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<JobMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types