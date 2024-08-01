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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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
        // GraphQL -> canceledObjects: Int (scalar)
        [JsonProperty("canceledObjects")]
        public System.Int32? CanceledObjects { get; set; }

        //      C# -> System.Int64? CreateTime
        // GraphQL -> createTime: Long (scalar)
        [JsonProperty("createTime")]
        public System.Int64? CreateTime { get; set; }

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
        // GraphQL -> failedObjects: Int (scalar)
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
        // GraphQL -> inProgressObjects: Int (scalar)
        [JsonProperty("inProgressObjects")]
        public System.Int32? InProgressObjects { get; set; }

        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int (scalar)
        [JsonProperty("objectsWithoutSnapshot")]
        public System.Int32? ObjectsWithoutSnapshot { get; set; }

        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        [JsonProperty("recoveryPlanName")]
        public System.String? RecoveryPlanName { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.Int32? SucceededObjects
        // GraphQL -> succeededObjects: Int (scalar)
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
        // GraphQL -> totalObjects: Int (scalar)
        [JsonProperty("totalObjects")]
        public System.Int32? TotalObjects { get; set; }

        //      C# -> List<BulkRecoveryGroupProgress>? GroupProgresses
        // GraphQL -> groupProgresses: [BulkRecoveryGroupProgress!]! (type)
        [JsonProperty("groupProgresses")]
        public List<BulkRecoveryGroupProgress>? GroupProgresses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkRecoveryProgressReply";
    }

    public BulkRecoveryProgressReply Set(
        RecoveryDomainType? BulkRecoveryDomain = null,
        FailureActionType? FailureActionType = null,
        BulkRecoveryStatus? Status = null,
        System.String? BulkRecoveryInstanceId = null,
        System.Int32? CanceledObjects = null,
        System.Int64? CreateTime = null,
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
        if ( CreateTime != null ) {
            this.CreateTime = CreateTime;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RecoveryDomainType? BulkRecoveryDomain
        // GraphQL -> bulkRecoveryDomain: RecoveryDomainType! (enum)
        if (this.BulkRecoveryDomain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bulkRecoveryDomain\n" ;
            } else {
                s += ind + "bulkRecoveryDomain\n" ;
            }
        }
        //      C# -> FailureActionType? FailureActionType
        // GraphQL -> failureActionType: FailureActionType! (enum)
        if (this.FailureActionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failureActionType\n" ;
            } else {
                s += ind + "failureActionType\n" ;
            }
        }
        //      C# -> BulkRecoveryStatus? Status
        // GraphQL -> status: BulkRecoveryStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID! (scalar)
        if (this.BulkRecoveryInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bulkRecoveryInstanceId\n" ;
            } else {
                s += ind + "bulkRecoveryInstanceId\n" ;
            }
        }
        //      C# -> System.Int32? CanceledObjects
        // GraphQL -> canceledObjects: Int (scalar)
        if (this.CanceledObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "canceledObjects\n" ;
            } else {
                s += ind + "canceledObjects\n" ;
            }
        }
        //      C# -> System.Int64? CreateTime
        // GraphQL -> createTime: Long (scalar)
        if (this.CreateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createTime\n" ;
            } else {
                s += ind + "createTime\n" ;
            }
        }
        //      C# -> System.String? CurrentStep
        // GraphQL -> currentStep: String! (scalar)
        if (this.CurrentStep != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentStep\n" ;
            } else {
                s += ind + "currentStep\n" ;
            }
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "elapsedTime\n" ;
            } else {
                s += ind + "elapsedTime\n" ;
            }
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Int32? FailedObjects
        // GraphQL -> failedObjects: Int (scalar)
        if (this.FailedObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedObjects\n" ;
            } else {
                s += ind + "failedObjects\n" ;
            }
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failureReason\n" ;
            } else {
                s += ind + "failureReason\n" ;
            }
        }
        //      C# -> System.Int32? GroupsProcessed
        // GraphQL -> groupsProcessed: Int! (scalar)
        if (this.GroupsProcessed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupsProcessed\n" ;
            } else {
                s += ind + "groupsProcessed\n" ;
            }
        }
        //      C# -> System.Int32? InProgressObjects
        // GraphQL -> inProgressObjects: Int (scalar)
        if (this.InProgressObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inProgressObjects\n" ;
            } else {
                s += ind + "inProgressObjects\n" ;
            }
        }
        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int (scalar)
        if (this.ObjectsWithoutSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithoutSnapshot\n" ;
            } else {
                s += ind + "objectsWithoutSnapshot\n" ;
            }
        }
        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        if (this.RecoveryPlanName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanName\n" ;
            } else {
                s += ind + "recoveryPlanName\n" ;
            }
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.Int32? SucceededObjects
        // GraphQL -> succeededObjects: Int (scalar)
        if (this.SucceededObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "succeededObjects\n" ;
            } else {
                s += ind + "succeededObjects\n" ;
            }
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        if (this.TaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskchainId\n" ;
            } else {
                s += ind + "taskchainId\n" ;
            }
        }
        //      C# -> System.Int32? TotalGroups
        // GraphQL -> totalGroups: Int! (scalar)
        if (this.TotalGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalGroups\n" ;
            } else {
                s += ind + "totalGroups\n" ;
            }
        }
        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int (scalar)
        if (this.TotalObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalObjects\n" ;
            } else {
                s += ind + "totalObjects\n" ;
            }
        }
        //      C# -> List<BulkRecoveryGroupProgress>? GroupProgresses
        // GraphQL -> groupProgresses: [BulkRecoveryGroupProgress!]! (type)
        if (this.GroupProgresses != null) {
            var fspec = this.GroupProgresses.AsFieldSpec(conf.Child("groupProgresses"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupProgresses" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RecoveryDomainType? BulkRecoveryDomain
        // GraphQL -> bulkRecoveryDomain: RecoveryDomainType! (enum)
        if (ec.Includes("bulkRecoveryDomain",true))
        {
            if(this.BulkRecoveryDomain == null) {

                this.BulkRecoveryDomain = new RecoveryDomainType();

            } else {


            }
        }
        else if (this.BulkRecoveryDomain != null && ec.Excludes("bulkRecoveryDomain",true))
        {
            this.BulkRecoveryDomain = null;
        }
        //      C# -> FailureActionType? FailureActionType
        // GraphQL -> failureActionType: FailureActionType! (enum)
        if (ec.Includes("failureActionType",true))
        {
            if(this.FailureActionType == null) {

                this.FailureActionType = new FailureActionType();

            } else {


            }
        }
        else if (this.FailureActionType != null && ec.Excludes("failureActionType",true))
        {
            this.FailureActionType = null;
        }
        //      C# -> BulkRecoveryStatus? Status
        // GraphQL -> status: BulkRecoveryStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new BulkRecoveryStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID! (scalar)
        if (ec.Includes("bulkRecoveryInstanceId",true))
        {
            if(this.BulkRecoveryInstanceId == null) {

                this.BulkRecoveryInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.BulkRecoveryInstanceId != null && ec.Excludes("bulkRecoveryInstanceId",true))
        {
            this.BulkRecoveryInstanceId = null;
        }
        //      C# -> System.Int32? CanceledObjects
        // GraphQL -> canceledObjects: Int (scalar)
        if (ec.Includes("canceledObjects",true))
        {
            if(this.CanceledObjects == null) {

                this.CanceledObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.CanceledObjects != null && ec.Excludes("canceledObjects",true))
        {
            this.CanceledObjects = null;
        }
        //      C# -> System.Int64? CreateTime
        // GraphQL -> createTime: Long (scalar)
        if (ec.Includes("createTime",true))
        {
            if(this.CreateTime == null) {

                this.CreateTime = new System.Int64();

            } else {


            }
        }
        else if (this.CreateTime != null && ec.Excludes("createTime",true))
        {
            this.CreateTime = null;
        }
        //      C# -> System.String? CurrentStep
        // GraphQL -> currentStep: String! (scalar)
        if (ec.Includes("currentStep",true))
        {
            if(this.CurrentStep == null) {

                this.CurrentStep = "FETCH";

            } else {


            }
        }
        else if (this.CurrentStep != null && ec.Excludes("currentStep",true))
        {
            this.CurrentStep = null;
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (ec.Includes("elapsedTime",true))
        {
            if(this.ElapsedTime == null) {

                this.ElapsedTime = new System.Int64();

            } else {


            }
        }
        else if (this.ElapsedTime != null && ec.Excludes("elapsedTime",true))
        {
            this.ElapsedTime = null;
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new System.Int64();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Int32? FailedObjects
        // GraphQL -> failedObjects: Int (scalar)
        if (ec.Includes("failedObjects",true))
        {
            if(this.FailedObjects == null) {

                this.FailedObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.FailedObjects != null && ec.Excludes("failedObjects",true))
        {
            this.FailedObjects = null;
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (ec.Includes("failureReason",true))
        {
            if(this.FailureReason == null) {

                this.FailureReason = "FETCH";

            } else {


            }
        }
        else if (this.FailureReason != null && ec.Excludes("failureReason",true))
        {
            this.FailureReason = null;
        }
        //      C# -> System.Int32? GroupsProcessed
        // GraphQL -> groupsProcessed: Int! (scalar)
        if (ec.Includes("groupsProcessed",true))
        {
            if(this.GroupsProcessed == null) {

                this.GroupsProcessed = Int32.MinValue;

            } else {


            }
        }
        else if (this.GroupsProcessed != null && ec.Excludes("groupsProcessed",true))
        {
            this.GroupsProcessed = null;
        }
        //      C# -> System.Int32? InProgressObjects
        // GraphQL -> inProgressObjects: Int (scalar)
        if (ec.Includes("inProgressObjects",true))
        {
            if(this.InProgressObjects == null) {

                this.InProgressObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.InProgressObjects != null && ec.Excludes("inProgressObjects",true))
        {
            this.InProgressObjects = null;
        }
        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int (scalar)
        if (ec.Includes("objectsWithoutSnapshot",true))
        {
            if(this.ObjectsWithoutSnapshot == null) {

                this.ObjectsWithoutSnapshot = Int32.MinValue;

            } else {


            }
        }
        else if (this.ObjectsWithoutSnapshot != null && ec.Excludes("objectsWithoutSnapshot",true))
        {
            this.ObjectsWithoutSnapshot = null;
        }
        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        if (ec.Includes("recoveryPlanName",true))
        {
            if(this.RecoveryPlanName == null) {

                this.RecoveryPlanName = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryPlanName != null && ec.Excludes("recoveryPlanName",true))
        {
            this.RecoveryPlanName = null;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new System.Int64();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.Int32? SucceededObjects
        // GraphQL -> succeededObjects: Int (scalar)
        if (ec.Includes("succeededObjects",true))
        {
            if(this.SucceededObjects == null) {

                this.SucceededObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.SucceededObjects != null && ec.Excludes("succeededObjects",true))
        {
            this.SucceededObjects = null;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        if (ec.Includes("taskchainId",true))
        {
            if(this.TaskchainId == null) {

                this.TaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.TaskchainId != null && ec.Excludes("taskchainId",true))
        {
            this.TaskchainId = null;
        }
        //      C# -> System.Int32? TotalGroups
        // GraphQL -> totalGroups: Int! (scalar)
        if (ec.Includes("totalGroups",true))
        {
            if(this.TotalGroups == null) {

                this.TotalGroups = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalGroups != null && ec.Excludes("totalGroups",true))
        {
            this.TotalGroups = null;
        }
        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int (scalar)
        if (ec.Includes("totalObjects",true))
        {
            if(this.TotalObjects == null) {

                this.TotalObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalObjects != null && ec.Excludes("totalObjects",true))
        {
            this.TotalObjects = null;
        }
        //      C# -> List<BulkRecoveryGroupProgress>? GroupProgresses
        // GraphQL -> groupProgresses: [BulkRecoveryGroupProgress!]! (type)
        if (ec.Includes("groupProgresses",false))
        {
            if(this.GroupProgresses == null) {

                this.GroupProgresses = new List<BulkRecoveryGroupProgress>();
                this.GroupProgresses.ApplyExploratoryFieldSpec(ec.NewChild("groupProgresses"));

            } else {

                this.GroupProgresses.ApplyExploratoryFieldSpec(ec.NewChild("groupProgresses"));

            }
        }
        else if (this.GroupProgresses != null && ec.Excludes("groupProgresses",false))
        {
            this.GroupProgresses = null;
        }
    }


    #endregion

    } // class BulkRecoveryProgressReply
    
    #endregion

    public static class ListBulkRecoveryProgressReplyExtensions
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
            this List<BulkRecoveryProgressReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BulkRecoveryProgressReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BulkRecoveryProgressReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkRecoveryProgressReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BulkRecoveryProgressReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types