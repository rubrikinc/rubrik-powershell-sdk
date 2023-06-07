// BulkRecoveryGroupWorkloadProgress.cs
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
    #region BulkRecoveryGroupWorkloadProgress
    public class BulkRecoveryGroupWorkloadProgress: BaseType
    {
        #region members

        //      C# -> BulkRecoveryGroupWorkloadStatus? Status
        // GraphQL -> status: BulkRecoveryGroupWorkloadStatus! (enum)
        [JsonProperty("status")]
        public BulkRecoveryGroupWorkloadStatus? Status { get; set; }

        //      C# -> System.Int32? CanceledWorkloads
        // GraphQL -> canceledWorkloads: Int! (scalar)
        [JsonProperty("canceledWorkloads")]
        public System.Int32? CanceledWorkloads { get; set; }

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int32? FailedWorkloads
        // GraphQL -> failedWorkloads: Int! (scalar)
        [JsonProperty("failedWorkloads")]
        public System.Int32? FailedWorkloads { get; set; }

        //      C# -> System.Int32? InProgressWorkloads
        // GraphQL -> inProgressWorkloads: Int! (scalar)
        [JsonProperty("inProgressWorkloads")]
        public System.Int32? InProgressWorkloads { get; set; }

        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        [JsonProperty("seq")]
        public System.Int32? Seq { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.Int32? SucceededWorkloads
        // GraphQL -> succeededWorkloads: Int! (scalar)
        [JsonProperty("succeededWorkloads")]
        public System.Int32? SucceededWorkloads { get; set; }

        //      C# -> System.Int32? TotalWorkloads
        // GraphQL -> totalWorkloads: Int! (scalar)
        [JsonProperty("totalWorkloads")]
        public System.Int32? TotalWorkloads { get; set; }

        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        [JsonProperty("workloadType")]
        public System.String? WorkloadType { get; set; }

        //      C# -> System.Int32? WorkloadsWithoutSnapshot
        // GraphQL -> workloadsWithoutSnapshot: Int! (scalar)
        [JsonProperty("workloadsWithoutSnapshot")]
        public System.Int32? WorkloadsWithoutSnapshot { get; set; }

        //      C# -> List<BulkRecoverySelectorStep>? SelectorSteps
        // GraphQL -> selectorSteps: [BulkRecoverySelectorStep!]! (type)
        [JsonProperty("selectorSteps")]
        public List<BulkRecoverySelectorStep>? SelectorSteps { get; set; }


        #endregion

    #region methods

    public BulkRecoveryGroupWorkloadProgress Set(
        BulkRecoveryGroupWorkloadStatus? Status = null,
        System.Int32? CanceledWorkloads = null,
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.Int32? FailedWorkloads = null,
        System.Int32? InProgressWorkloads = null,
        System.Int32? Seq = null,
        System.Int64? StartTime = null,
        System.Int32? SucceededWorkloads = null,
        System.Int32? TotalWorkloads = null,
        System.String? WorkloadType = null,
        System.Int32? WorkloadsWithoutSnapshot = null,
        List<BulkRecoverySelectorStep>? SelectorSteps = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CanceledWorkloads != null ) {
            this.CanceledWorkloads = CanceledWorkloads;
        }
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( FailedWorkloads != null ) {
            this.FailedWorkloads = FailedWorkloads;
        }
        if ( InProgressWorkloads != null ) {
            this.InProgressWorkloads = InProgressWorkloads;
        }
        if ( Seq != null ) {
            this.Seq = Seq;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( SucceededWorkloads != null ) {
            this.SucceededWorkloads = SucceededWorkloads;
        }
        if ( TotalWorkloads != null ) {
            this.TotalWorkloads = TotalWorkloads;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( WorkloadsWithoutSnapshot != null ) {
            this.WorkloadsWithoutSnapshot = WorkloadsWithoutSnapshot;
        }
        if ( SelectorSteps != null ) {
            this.SelectorSteps = SelectorSteps;
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
        //      C# -> BulkRecoveryGroupWorkloadStatus? Status
        // GraphQL -> status: BulkRecoveryGroupWorkloadStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Int32? CanceledWorkloads
        // GraphQL -> canceledWorkloads: Int! (scalar)
        if (this.CanceledWorkloads != null) {
            s += ind + "canceledWorkloads\n" ;
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime != null) {
            s += ind + "elapsedTime\n" ;
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.Int32? FailedWorkloads
        // GraphQL -> failedWorkloads: Int! (scalar)
        if (this.FailedWorkloads != null) {
            s += ind + "failedWorkloads\n" ;
        }
        //      C# -> System.Int32? InProgressWorkloads
        // GraphQL -> inProgressWorkloads: Int! (scalar)
        if (this.InProgressWorkloads != null) {
            s += ind + "inProgressWorkloads\n" ;
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq != null) {
            s += ind + "seq\n" ;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> System.Int32? SucceededWorkloads
        // GraphQL -> succeededWorkloads: Int! (scalar)
        if (this.SucceededWorkloads != null) {
            s += ind + "succeededWorkloads\n" ;
        }
        //      C# -> System.Int32? TotalWorkloads
        // GraphQL -> totalWorkloads: Int! (scalar)
        if (this.TotalWorkloads != null) {
            s += ind + "totalWorkloads\n" ;
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (this.WorkloadType != null) {
            s += ind + "workloadType\n" ;
        }
        //      C# -> System.Int32? WorkloadsWithoutSnapshot
        // GraphQL -> workloadsWithoutSnapshot: Int! (scalar)
        if (this.WorkloadsWithoutSnapshot != null) {
            s += ind + "workloadsWithoutSnapshot\n" ;
        }
        //      C# -> List<BulkRecoverySelectorStep>? SelectorSteps
        // GraphQL -> selectorSteps: [BulkRecoverySelectorStep!]! (type)
        if (this.SelectorSteps != null) {
            s += ind + "selectorSteps {\n" + this.SelectorSteps.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> BulkRecoveryGroupWorkloadStatus? Status
        // GraphQL -> status: BulkRecoveryGroupWorkloadStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new BulkRecoveryGroupWorkloadStatus();
        }
        //      C# -> System.Int32? CanceledWorkloads
        // GraphQL -> canceledWorkloads: Int! (scalar)
        if (this.CanceledWorkloads == null && Exploration.Includes(parent + ".canceledWorkloads", true))
        {
            this.CanceledWorkloads = Int32.MinValue;
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime == null && Exploration.Includes(parent + ".elapsedTime", true))
        {
            this.ElapsedTime = new System.Int64();
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new System.Int64();
        }
        //      C# -> System.Int32? FailedWorkloads
        // GraphQL -> failedWorkloads: Int! (scalar)
        if (this.FailedWorkloads == null && Exploration.Includes(parent + ".failedWorkloads", true))
        {
            this.FailedWorkloads = Int32.MinValue;
        }
        //      C# -> System.Int32? InProgressWorkloads
        // GraphQL -> inProgressWorkloads: Int! (scalar)
        if (this.InProgressWorkloads == null && Exploration.Includes(parent + ".inProgressWorkloads", true))
        {
            this.InProgressWorkloads = Int32.MinValue;
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq == null && Exploration.Includes(parent + ".seq", true))
        {
            this.Seq = Int32.MinValue;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new System.Int64();
        }
        //      C# -> System.Int32? SucceededWorkloads
        // GraphQL -> succeededWorkloads: Int! (scalar)
        if (this.SucceededWorkloads == null && Exploration.Includes(parent + ".succeededWorkloads", true))
        {
            this.SucceededWorkloads = Int32.MinValue;
        }
        //      C# -> System.Int32? TotalWorkloads
        // GraphQL -> totalWorkloads: Int! (scalar)
        if (this.TotalWorkloads == null && Exploration.Includes(parent + ".totalWorkloads", true))
        {
            this.TotalWorkloads = Int32.MinValue;
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (this.WorkloadType == null && Exploration.Includes(parent + ".workloadType", true))
        {
            this.WorkloadType = "FETCH";
        }
        //      C# -> System.Int32? WorkloadsWithoutSnapshot
        // GraphQL -> workloadsWithoutSnapshot: Int! (scalar)
        if (this.WorkloadsWithoutSnapshot == null && Exploration.Includes(parent + ".workloadsWithoutSnapshot", true))
        {
            this.WorkloadsWithoutSnapshot = Int32.MinValue;
        }
        //      C# -> List<BulkRecoverySelectorStep>? SelectorSteps
        // GraphQL -> selectorSteps: [BulkRecoverySelectorStep!]! (type)
        if (this.SelectorSteps == null && Exploration.Includes(parent + ".selectorSteps"))
        {
            this.SelectorSteps = new List<BulkRecoverySelectorStep>();
            this.SelectorSteps.ApplyExploratoryFieldSpec(parent + ".selectorSteps");
        }
    }


    #endregion

    } // class BulkRecoveryGroupWorkloadProgress
    
    #endregion

    public static class ListBulkRecoveryGroupWorkloadProgressExtensions
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
            this List<BulkRecoveryGroupWorkloadProgress> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BulkRecoveryGroupWorkloadProgress> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkRecoveryGroupWorkloadProgress());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types