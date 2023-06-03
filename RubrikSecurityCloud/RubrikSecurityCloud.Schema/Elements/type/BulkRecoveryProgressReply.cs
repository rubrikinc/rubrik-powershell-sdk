// BulkRecoveryProgressReply.cs
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
    #region BulkRecoveryProgressReply
    public class BulkRecoveryProgressReply: BaseType
    {
        #region members

        //      C# -> RecoveryDomainType? BulkRecoveryDomain
        // GraphQL -> bulkRecoveryDomain: RecoveryDomainType! (enum)
        [JsonProperty("bulkRecoveryDomain")]
        public RecoveryDomainType? BulkRecoveryDomain { get; set; }

        //      C# -> FailureActionType? FailureActionType
        // GraphQL -> failureActionType: FailureActionType! (enum)
        [JsonProperty("failureActionType")]
        public FailureActionType? FailureActionType { get; set; }

        //      C# -> BulkRecoveryStatus? Status
        // GraphQL -> status: BulkRecoveryStatus! (enum)
        [JsonProperty("status")]
        public BulkRecoveryStatus? Status { get; set; }

        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID! (scalar)
        [JsonProperty("bulkRecoveryInstanceId")]
        public System.String? BulkRecoveryInstanceId { get; set; }

        //      C# -> System.Int32? CanceledObjects
        // GraphQL -> canceledObjects: Int! (scalar)
        [JsonProperty("canceledObjects")]
        public System.Int32? CanceledObjects { get; set; }

        //      C# -> System.String? CurrentStep
        // GraphQL -> currentStep: String! (scalar)
        [JsonProperty("currentStep")]
        public System.String? CurrentStep { get; set; }

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int32? FailedObjects
        // GraphQL -> failedObjects: Int! (scalar)
        [JsonProperty("failedObjects")]
        public System.Int32? FailedObjects { get; set; }

        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        [JsonProperty("failureReason")]
        public System.String? FailureReason { get; set; }

        //      C# -> System.Int32? GroupsProcessed
        // GraphQL -> groupsProcessed: Int! (scalar)
        [JsonProperty("groupsProcessed")]
        public System.Int32? GroupsProcessed { get; set; }

        //      C# -> System.Int32? InProgressObjects
        // GraphQL -> inProgressObjects: Int! (scalar)
        [JsonProperty("inProgressObjects")]
        public System.Int32? InProgressObjects { get; set; }

        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int! (scalar)
        [JsonProperty("objectsWithoutSnapshot")]
        public System.Int32? ObjectsWithoutSnapshot { get; set; }

        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        [JsonProperty("recoveryPlanName")]
        public System.String? RecoveryPlanName { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.Int32? SucceededObjects
        // GraphQL -> succeededObjects: Int! (scalar)
        [JsonProperty("succeededObjects")]
        public System.Int32? SucceededObjects { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }

        //      C# -> System.Int32? TotalGroups
        // GraphQL -> totalGroups: Int! (scalar)
        [JsonProperty("totalGroups")]
        public System.Int32? TotalGroups { get; set; }

        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        [JsonProperty("totalObjects")]
        public System.Int32? TotalObjects { get; set; }

        //      C# -> List<BulkRecoveryGroupProgress>? GroupProgresses
        // GraphQL -> groupProgresses: [BulkRecoveryGroupProgress!]! (type)
        [JsonProperty("groupProgresses")]
        public List<BulkRecoveryGroupProgress>? GroupProgresses { get; set; }


        #endregion

    #region methods

    public BulkRecoveryProgressReply Set(
        RecoveryDomainType? BulkRecoveryDomain = null,
        FailureActionType? FailureActionType = null,
        BulkRecoveryStatus? Status = null,
        System.String? BulkRecoveryInstanceId = null,
        System.Int32? CanceledObjects = null,
        System.String? CurrentStep = null,
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.Int32? FailedObjects = null,
        System.String? FailureReason = null,
        System.Int32? GroupsProcessed = null,
        System.Int32? InProgressObjects = null,
        System.Int32? ObjectsWithoutSnapshot = null,
        System.String? RecoveryPlanName = null,
        System.Int64? StartTime = null,
        System.Int32? SucceededObjects = null,
        System.String? TaskchainId = null,
        System.Int32? TotalGroups = null,
        System.Int32? TotalObjects = null,
        List<BulkRecoveryGroupProgress>? GroupProgresses = null
    ) 
    {
        if ( BulkRecoveryDomain != null ) {
            this.BulkRecoveryDomain = BulkRecoveryDomain;
        }
        if ( FailureActionType != null ) {
            this.FailureActionType = FailureActionType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( BulkRecoveryInstanceId != null ) {
            this.BulkRecoveryInstanceId = BulkRecoveryInstanceId;
        }
        if ( CanceledObjects != null ) {
            this.CanceledObjects = CanceledObjects;
        }
        if ( CurrentStep != null ) {
            this.CurrentStep = CurrentStep;
        }
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( FailedObjects != null ) {
            this.FailedObjects = FailedObjects;
        }
        if ( FailureReason != null ) {
            this.FailureReason = FailureReason;
        }
        if ( GroupsProcessed != null ) {
            this.GroupsProcessed = GroupsProcessed;
        }
        if ( InProgressObjects != null ) {
            this.InProgressObjects = InProgressObjects;
        }
        if ( ObjectsWithoutSnapshot != null ) {
            this.ObjectsWithoutSnapshot = ObjectsWithoutSnapshot;
        }
        if ( RecoveryPlanName != null ) {
            this.RecoveryPlanName = RecoveryPlanName;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( SucceededObjects != null ) {
            this.SucceededObjects = SucceededObjects;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
        }
        if ( TotalGroups != null ) {
            this.TotalGroups = TotalGroups;
        }
        if ( TotalObjects != null ) {
            this.TotalObjects = TotalObjects;
        }
        if ( GroupProgresses != null ) {
            this.GroupProgresses = GroupProgresses;
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
        //      C# -> RecoveryDomainType? BulkRecoveryDomain
        // GraphQL -> bulkRecoveryDomain: RecoveryDomainType! (enum)
        if (this.BulkRecoveryDomain != null) {
            s += ind + "bulkRecoveryDomain\n" ;
        }
        //      C# -> FailureActionType? FailureActionType
        // GraphQL -> failureActionType: FailureActionType! (enum)
        if (this.FailureActionType != null) {
            s += ind + "failureActionType\n" ;
        }
        //      C# -> BulkRecoveryStatus? Status
        // GraphQL -> status: BulkRecoveryStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID! (scalar)
        if (this.BulkRecoveryInstanceId != null) {
            s += ind + "bulkRecoveryInstanceId\n" ;
        }
        //      C# -> System.Int32? CanceledObjects
        // GraphQL -> canceledObjects: Int! (scalar)
        if (this.CanceledObjects != null) {
            s += ind + "canceledObjects\n" ;
        }
        //      C# -> System.String? CurrentStep
        // GraphQL -> currentStep: String! (scalar)
        if (this.CurrentStep != null) {
            s += ind + "currentStep\n" ;
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
        //      C# -> System.Int32? FailedObjects
        // GraphQL -> failedObjects: Int! (scalar)
        if (this.FailedObjects != null) {
            s += ind + "failedObjects\n" ;
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason != null) {
            s += ind + "failureReason\n" ;
        }
        //      C# -> System.Int32? GroupsProcessed
        // GraphQL -> groupsProcessed: Int! (scalar)
        if (this.GroupsProcessed != null) {
            s += ind + "groupsProcessed\n" ;
        }
        //      C# -> System.Int32? InProgressObjects
        // GraphQL -> inProgressObjects: Int! (scalar)
        if (this.InProgressObjects != null) {
            s += ind + "inProgressObjects\n" ;
        }
        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int! (scalar)
        if (this.ObjectsWithoutSnapshot != null) {
            s += ind + "objectsWithoutSnapshot\n" ;
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
        //      C# -> System.Int32? SucceededObjects
        // GraphQL -> succeededObjects: Int! (scalar)
        if (this.SucceededObjects != null) {
            s += ind + "succeededObjects\n" ;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        if (this.TaskchainId != null) {
            s += ind + "taskchainId\n" ;
        }
        //      C# -> System.Int32? TotalGroups
        // GraphQL -> totalGroups: Int! (scalar)
        if (this.TotalGroups != null) {
            s += ind + "totalGroups\n" ;
        }
        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        if (this.TotalObjects != null) {
            s += ind + "totalObjects\n" ;
        }
        //      C# -> List<BulkRecoveryGroupProgress>? GroupProgresses
        // GraphQL -> groupProgresses: [BulkRecoveryGroupProgress!]! (type)
        if (this.GroupProgresses != null) {
            s += ind + "groupProgresses {\n" + this.GroupProgresses.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RecoveryDomainType? BulkRecoveryDomain
        // GraphQL -> bulkRecoveryDomain: RecoveryDomainType! (enum)
        if (this.BulkRecoveryDomain == null && Exploration.Includes(parent + ".bulkRecoveryDomain", true))
        {
            this.BulkRecoveryDomain = new RecoveryDomainType();
        }
        //      C# -> FailureActionType? FailureActionType
        // GraphQL -> failureActionType: FailureActionType! (enum)
        if (this.FailureActionType == null && Exploration.Includes(parent + ".failureActionType", true))
        {
            this.FailureActionType = new FailureActionType();
        }
        //      C# -> BulkRecoveryStatus? Status
        // GraphQL -> status: BulkRecoveryStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new BulkRecoveryStatus();
        }
        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID! (scalar)
        if (this.BulkRecoveryInstanceId == null && Exploration.Includes(parent + ".bulkRecoveryInstanceId", true))
        {
            this.BulkRecoveryInstanceId = new System.String("FETCH");
        }
        //      C# -> System.Int32? CanceledObjects
        // GraphQL -> canceledObjects: Int! (scalar)
        if (this.CanceledObjects == null && Exploration.Includes(parent + ".canceledObjects", true))
        {
            this.CanceledObjects = new System.Int32();
        }
        //      C# -> System.String? CurrentStep
        // GraphQL -> currentStep: String! (scalar)
        if (this.CurrentStep == null && Exploration.Includes(parent + ".currentStep", true))
        {
            this.CurrentStep = new System.String("FETCH");
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
        //      C# -> System.Int32? FailedObjects
        // GraphQL -> failedObjects: Int! (scalar)
        if (this.FailedObjects == null && Exploration.Includes(parent + ".failedObjects", true))
        {
            this.FailedObjects = new System.Int32();
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason == null && Exploration.Includes(parent + ".failureReason", true))
        {
            this.FailureReason = new System.String("FETCH");
        }
        //      C# -> System.Int32? GroupsProcessed
        // GraphQL -> groupsProcessed: Int! (scalar)
        if (this.GroupsProcessed == null && Exploration.Includes(parent + ".groupsProcessed", true))
        {
            this.GroupsProcessed = new System.Int32();
        }
        //      C# -> System.Int32? InProgressObjects
        // GraphQL -> inProgressObjects: Int! (scalar)
        if (this.InProgressObjects == null && Exploration.Includes(parent + ".inProgressObjects", true))
        {
            this.InProgressObjects = new System.Int32();
        }
        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int! (scalar)
        if (this.ObjectsWithoutSnapshot == null && Exploration.Includes(parent + ".objectsWithoutSnapshot", true))
        {
            this.ObjectsWithoutSnapshot = new System.Int32();
        }
        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        if (this.RecoveryPlanName == null && Exploration.Includes(parent + ".recoveryPlanName", true))
        {
            this.RecoveryPlanName = new System.String("FETCH");
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new System.Int64();
        }
        //      C# -> System.Int32? SucceededObjects
        // GraphQL -> succeededObjects: Int! (scalar)
        if (this.SucceededObjects == null && Exploration.Includes(parent + ".succeededObjects", true))
        {
            this.SucceededObjects = new System.Int32();
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        if (this.TaskchainId == null && Exploration.Includes(parent + ".taskchainId", true))
        {
            this.TaskchainId = new System.String("FETCH");
        }
        //      C# -> System.Int32? TotalGroups
        // GraphQL -> totalGroups: Int! (scalar)
        if (this.TotalGroups == null && Exploration.Includes(parent + ".totalGroups", true))
        {
            this.TotalGroups = new System.Int32();
        }
        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        if (this.TotalObjects == null && Exploration.Includes(parent + ".totalObjects", true))
        {
            this.TotalObjects = new System.Int32();
        }
        //      C# -> List<BulkRecoveryGroupProgress>? GroupProgresses
        // GraphQL -> groupProgresses: [BulkRecoveryGroupProgress!]! (type)
        if (this.GroupProgresses == null && Exploration.Includes(parent + ".groupProgresses"))
        {
            this.GroupProgresses = new List<BulkRecoveryGroupProgress>();
            this.GroupProgresses.ApplyExploratoryFieldSpec(parent + ".groupProgresses");
        }
    }


    #endregion

    } // class BulkRecoveryProgressReply
    
    #endregion

    public static class ListBulkRecoveryProgressReplyExtensions
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
            this List<BulkRecoveryProgressReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BulkRecoveryProgressReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkRecoveryProgressReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types