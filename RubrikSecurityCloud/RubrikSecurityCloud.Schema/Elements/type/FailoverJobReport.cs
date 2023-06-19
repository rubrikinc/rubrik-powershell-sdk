// FailoverJobReport.cs
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
    #region FailoverJobReport
    public class FailoverJobReport: BaseType
    {
        #region members

        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: UUID! (scalar)
        [JsonProperty("blueprintId")]
        public System.String? BlueprintId { get; set; }

        //      C# -> System.String? BlueprintName
        // GraphQL -> blueprintName: String! (scalar)
        [JsonProperty("blueprintName")]
        public System.String? BlueprintName { get; set; }

        //      C# -> System.String? DataTransferType
        // GraphQL -> dataTransferType: String! (scalar)
        [JsonProperty("dataTransferType")]
        public System.String? DataTransferType { get; set; }

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean! (scalar)
        [JsonProperty("isBlueprintVisible")]
        public System.Boolean? IsBlueprintVisible { get; set; }

        //      C# -> System.String? JobId
        // GraphQL -> jobId: String! (scalar)
        [JsonProperty("jobId")]
        public System.String? JobId { get; set; }

        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        [JsonProperty("jobType")]
        public System.String? JobType { get; set; }

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        [JsonProperty("recoveryName")]
        public System.String? RecoveryName { get; set; }

        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        [JsonProperty("recoveryPlanName")]
        public System.String? RecoveryPlanName { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> List<FailoverStep>? Steps
        // GraphQL -> steps: [FailoverStep!]! (type)
        [JsonProperty("steps")]
        public List<FailoverStep>? Steps { get; set; }


        #endregion

    #region methods

    public FailoverJobReport Set(
        System.String? BlueprintId = null,
        System.String? BlueprintName = null,
        System.String? DataTransferType = null,
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsBlueprintVisible = null,
        System.String? JobId = null,
        System.String? JobType = null,
        List<System.String>? ObjectIds = null,
        System.Single? Progress = null,
        System.String? RecoveryName = null,
        System.String? RecoveryPlanName = null,
        System.Int64? StartTime = null,
        System.String? Status = null,
        List<FailoverStep>? Steps = null
    ) 
    {
        if ( BlueprintId != null ) {
            this.BlueprintId = BlueprintId;
        }
        if ( BlueprintName != null ) {
            this.BlueprintName = BlueprintName;
        }
        if ( DataTransferType != null ) {
            this.DataTransferType = DataTransferType;
        }
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsBlueprintVisible != null ) {
            this.IsBlueprintVisible = IsBlueprintVisible;
        }
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( ObjectIds != null ) {
            this.ObjectIds = ObjectIds;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( RecoveryName != null ) {
            this.RecoveryName = RecoveryName;
        }
        if ( RecoveryPlanName != null ) {
            this.RecoveryPlanName = RecoveryPlanName;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Steps != null ) {
            this.Steps = Steps;
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
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: UUID! (scalar)
        if (this.BlueprintId != null) {
            s += ind + "blueprintId\n" ;
        }
        //      C# -> System.String? BlueprintName
        // GraphQL -> blueprintName: String! (scalar)
        if (this.BlueprintName != null) {
            s += ind + "blueprintName\n" ;
        }
        //      C# -> System.String? DataTransferType
        // GraphQL -> dataTransferType: String! (scalar)
        if (this.DataTransferType != null) {
            s += ind + "dataTransferType\n" ;
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime != null) {
            s += ind + "elapsedTime\n" ;
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean! (scalar)
        if (this.IsBlueprintVisible != null) {
            s += ind + "isBlueprintVisible\n" ;
        }
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String! (scalar)
        if (this.JobId != null) {
            s += ind + "jobId\n" ;
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (this.JobType != null) {
            s += ind + "jobType\n" ;
        }
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (this.ObjectIds != null) {
            s += ind + "objectIds\n" ;
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (this.RecoveryName != null) {
            s += ind + "recoveryName\n" ;
        }
        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        if (this.RecoveryPlanName != null) {
            s += ind + "recoveryPlanName\n" ;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> List<FailoverStep>? Steps
        // GraphQL -> steps: [FailoverStep!]! (type)
        if (this.Steps != null) {
            var fspec = this.Steps.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "steps {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: UUID! (scalar)
        if (this.BlueprintId == null && Exploration.Includes(parent + ".blueprintId", true))
        {
            this.BlueprintId = "FETCH";
        }
        //      C# -> System.String? BlueprintName
        // GraphQL -> blueprintName: String! (scalar)
        if (this.BlueprintName == null && Exploration.Includes(parent + ".blueprintName", true))
        {
            this.BlueprintName = "FETCH";
        }
        //      C# -> System.String? DataTransferType
        // GraphQL -> dataTransferType: String! (scalar)
        if (this.DataTransferType == null && Exploration.Includes(parent + ".dataTransferType", true))
        {
            this.DataTransferType = "FETCH";
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime == null && Exploration.Includes(parent + ".elapsedTime", true))
        {
            this.ElapsedTime = new System.Int64();
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new System.Int64();
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean! (scalar)
        if (this.IsBlueprintVisible == null && Exploration.Includes(parent + ".isBlueprintVisible", true))
        {
            this.IsBlueprintVisible = true;
        }
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String! (scalar)
        if (this.JobId == null && Exploration.Includes(parent + ".jobId", true))
        {
            this.JobId = "FETCH";
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (this.JobType == null && Exploration.Includes(parent + ".jobType", true))
        {
            this.JobType = "FETCH";
        }
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (this.ObjectIds == null && Exploration.Includes(parent + ".objectIds", true))
        {
            this.ObjectIds = new List<System.String>();
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress == null && Exploration.Includes(parent + ".progress", true))
        {
            this.Progress = new System.Single();
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (this.RecoveryName == null && Exploration.Includes(parent + ".recoveryName", true))
        {
            this.RecoveryName = "FETCH";
        }
        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        if (this.RecoveryPlanName == null && Exploration.Includes(parent + ".recoveryPlanName", true))
        {
            this.RecoveryPlanName = "FETCH";
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new System.Int64();
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
        //      C# -> List<FailoverStep>? Steps
        // GraphQL -> steps: [FailoverStep!]! (type)
        if (this.Steps == null && Exploration.Includes(parent + ".steps"))
        {
            this.Steps = new List<FailoverStep>();
            this.Steps.ApplyExploratoryFieldSpec(parent + ".steps");
        }
    }


    #endregion

    } // class FailoverJobReport
    
    #endregion

    public static class ListFailoverJobReportExtensions
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
            this List<FailoverJobReport> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverJobReport> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverJobReport());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types