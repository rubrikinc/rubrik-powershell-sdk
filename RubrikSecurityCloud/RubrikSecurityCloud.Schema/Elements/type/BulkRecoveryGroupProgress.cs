// BulkRecoveryGroupProgress.cs
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
    #region BulkRecoveryGroupProgress
    public class BulkRecoveryGroupProgress: BaseType
    {
        #region members

        //      C# -> BulkRecoveryGroupStatus? Status
        // GraphQL -> status: BulkRecoveryGroupStatus! (enum)
        [JsonProperty("status")]
        public BulkRecoveryGroupStatus? Status { get; set; }

        //      C# -> System.Int64? CreateTime
        // GraphQL -> createTime: Long (scalar)
        [JsonProperty("createTime")]
        public System.Int64? CreateTime { get; set; }

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        [JsonProperty("groupName")]
        public System.String? GroupName { get; set; }

        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        [JsonProperty("groupType")]
        public System.String? GroupType { get; set; }

        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        [JsonProperty("seq")]
        public System.Int32? Seq { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> List<BulkRecoveryGroupWorkloadProgress>? WorkloadProgresses
        // GraphQL -> workloadProgresses: [BulkRecoveryGroupWorkloadProgress!]! (type)
        [JsonProperty("workloadProgresses")]
        public List<BulkRecoveryGroupWorkloadProgress>? WorkloadProgresses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkRecoveryGroupProgress";
    }

    public BulkRecoveryGroupProgress Set(
        BulkRecoveryGroupStatus? Status = null,
        System.Int64? CreateTime = null,
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.String? GroupId = null,
        System.String? GroupName = null,
        System.String? GroupType = null,
        System.Int32? Seq = null,
        System.Int64? StartTime = null,
        List<BulkRecoveryGroupWorkloadProgress>? WorkloadProgresses = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CreateTime != null ) {
            this.CreateTime = CreateTime;
        }
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( GroupId != null ) {
            this.GroupId = GroupId;
        }
        if ( GroupName != null ) {
            this.GroupName = GroupName;
        }
        if ( GroupType != null ) {
            this.GroupType = GroupType;
        }
        if ( Seq != null ) {
            this.Seq = Seq;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( WorkloadProgresses != null ) {
            this.WorkloadProgresses = WorkloadProgresses;
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
        //      C# -> BulkRecoveryGroupStatus? Status
        // GraphQL -> status: BulkRecoveryGroupStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Int64? CreateTime
        // GraphQL -> createTime: Long (scalar)
        if (this.CreateTime != null) {
            s += ind + "createTime\n" ;
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
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID (scalar)
        if (this.GroupId != null) {
            s += ind + "groupId\n" ;
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName != null) {
            s += ind + "groupName\n" ;
        }
        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        if (this.GroupType != null) {
            s += ind + "groupType\n" ;
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq != null) {
            s += ind + "seq\n" ;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> List<BulkRecoveryGroupWorkloadProgress>? WorkloadProgresses
        // GraphQL -> workloadProgresses: [BulkRecoveryGroupWorkloadProgress!]! (type)
        if (this.WorkloadProgresses != null) {
            var fspec = this.WorkloadProgresses.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "workloadProgresses {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> BulkRecoveryGroupStatus? Status
        // GraphQL -> status: BulkRecoveryGroupStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new BulkRecoveryGroupStatus();
        }
        //      C# -> System.Int64? CreateTime
        // GraphQL -> createTime: Long (scalar)
        if (this.CreateTime == null && ec.Includes("createTime",true))
        {
            this.CreateTime = new System.Int64();
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime == null && ec.Includes("elapsedTime",true))
        {
            this.ElapsedTime = new System.Int64();
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        if (this.EndTime == null && ec.Includes("endTime",true))
        {
            this.EndTime = new System.Int64();
        }
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID (scalar)
        if (this.GroupId == null && ec.Includes("groupId",true))
        {
            this.GroupId = "FETCH";
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName == null && ec.Includes("groupName",true))
        {
            this.GroupName = "FETCH";
        }
        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        if (this.GroupType == null && ec.Includes("groupType",true))
        {
            this.GroupType = "FETCH";
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq == null && ec.Includes("seq",true))
        {
            this.Seq = Int32.MinValue;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        if (this.StartTime == null && ec.Includes("startTime",true))
        {
            this.StartTime = new System.Int64();
        }
        //      C# -> List<BulkRecoveryGroupWorkloadProgress>? WorkloadProgresses
        // GraphQL -> workloadProgresses: [BulkRecoveryGroupWorkloadProgress!]! (type)
        if (this.WorkloadProgresses == null && ec.Includes("workloadProgresses",false))
        {
            this.WorkloadProgresses = new List<BulkRecoveryGroupWorkloadProgress>();
            this.WorkloadProgresses.ApplyExploratoryFieldSpec(ec.NewChild("workloadProgresses"));
        }
    }


    #endregion

    } // class BulkRecoveryGroupProgress
    
    #endregion

    public static class ListBulkRecoveryGroupProgressExtensions
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
            this List<BulkRecoveryGroupProgress> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BulkRecoveryGroupProgress> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkRecoveryGroupProgress());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<BulkRecoveryGroupProgress> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types