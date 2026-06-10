// Recovery.cs
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
    #region Recovery
    public class Recovery: BaseType
    {
        #region members

        //      C# -> DataTransferType? DataTransferType
        // GraphQL -> dataTransferType: DataTransferType! (enum)
        [JsonProperty("dataTransferType")]
        public DataTransferType? DataTransferType { get; set; }

        //      C# -> RecoveryFailureAction? RecoveryFailureAction
        // GraphQL -> recoveryFailureAction: RecoveryFailureAction! (enum)
        [JsonProperty("recoveryFailureAction")]
        public RecoveryFailureAction? RecoveryFailureAction { get; set; }

        //      C# -> RecoveryOutcome? RecoveryOutcome
        // GraphQL -> recoveryOutcome: RecoveryOutcome! (enum)
        [JsonProperty("recoveryOutcome")]
        public RecoveryOutcome? RecoveryOutcome { get; set; }

        //      C# -> RecoveryType? RecoveryType
        // GraphQL -> recoveryType: RecoveryType! (enum)
        [JsonProperty("recoveryType")]
        public RecoveryType? RecoveryType { get; set; }

        //      C# -> RecoveryStatus? Status
        // GraphQL -> status: RecoveryStatus! (enum)
        [JsonProperty("status")]
        public RecoveryStatus? Status { get; set; }

        //      C# -> RecoveryTriggeredFrom? TriggeredFrom
        // GraphQL -> triggeredFrom: RecoveryTriggeredFrom! (enum)
        [JsonProperty("triggeredFrom")]
        public RecoveryTriggeredFrom? TriggeredFrom { get; set; }

        //      C# -> System.Boolean? CanSaveAsPlan
        // GraphQL -> canSaveAsPlan: Boolean! (scalar)
        [JsonProperty("canSaveAsPlan")]
        public System.Boolean? CanSaveAsPlan { get; set; }

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsAdhocRecovery
        // GraphQL -> isAdhocRecovery: Boolean! (scalar)
        [JsonProperty("isAdhocRecovery")]
        public System.Boolean? IsAdhocRecovery { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Int64? NumWorkloads
        // GraphQL -> numWorkloads: Long! (scalar)
        [JsonProperty("numWorkloads")]
        public System.Int64? NumWorkloads { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        [JsonProperty("recoveryName")]
        public System.String? RecoveryName { get; set; }

        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: String! (scalar)
        [JsonProperty("recoveryPlanId")]
        public System.String? RecoveryPlanId { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> RecoveryPlanBasicInfo? RecoveryPlanBasicInfo
        // GraphQL -> recoveryPlanBasicInfo: RecoveryPlanBasicInfo (type)
        [JsonProperty("recoveryPlanBasicInfo")]
        public RecoveryPlanBasicInfo? RecoveryPlanBasicInfo { get; set; }

        //      C# -> StepsOneof? Steps
        // GraphQL -> steps: StepsOneof (type)
        [JsonProperty("steps")]
        public StepsOneof? Steps { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Recovery";
    }

    public Recovery Set(
        DataTransferType? DataTransferType = null,
        RecoveryFailureAction? RecoveryFailureAction = null,
        RecoveryOutcome? RecoveryOutcome = null,
        RecoveryType? RecoveryType = null,
        RecoveryStatus? Status = null,
        RecoveryTriggeredFrom? TriggeredFrom = null,
        System.Boolean? CanSaveAsPlan = null,
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.String? Id = null,
        System.Boolean? IsAdhocRecovery = null,
        System.Boolean? IsArchived = null,
        System.Int64? NumWorkloads = null,
        System.Single? Progress = null,
        System.String? RecoveryName = null,
        System.String? RecoveryPlanId = null,
        System.Int64? StartTime = null,
        RecoveryPlanBasicInfo? RecoveryPlanBasicInfo = null,
        StepsOneof? Steps = null
    ) 
    {
        if ( DataTransferType != null ) {
            this.DataTransferType = DataTransferType;
        }
        if ( RecoveryFailureAction != null ) {
            this.RecoveryFailureAction = RecoveryFailureAction;
        }
        if ( RecoveryOutcome != null ) {
            this.RecoveryOutcome = RecoveryOutcome;
        }
        if ( RecoveryType != null ) {
            this.RecoveryType = RecoveryType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( TriggeredFrom != null ) {
            this.TriggeredFrom = TriggeredFrom;
        }
        if ( CanSaveAsPlan != null ) {
            this.CanSaveAsPlan = CanSaveAsPlan;
        }
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsAdhocRecovery != null ) {
            this.IsAdhocRecovery = IsAdhocRecovery;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( NumWorkloads != null ) {
            this.NumWorkloads = NumWorkloads;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( RecoveryName != null ) {
            this.RecoveryName = RecoveryName;
        }
        if ( RecoveryPlanId != null ) {
            this.RecoveryPlanId = RecoveryPlanId;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( RecoveryPlanBasicInfo != null ) {
            this.RecoveryPlanBasicInfo = RecoveryPlanBasicInfo;
        }
        if ( Steps != null ) {
            this.Steps = Steps;
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
        //      C# -> DataTransferType? DataTransferType
        // GraphQL -> dataTransferType: DataTransferType! (enum)
        if (this.DataTransferType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataTransferType\n" ;
            } else {
                s += ind + "dataTransferType\n" ;
            }
        }
        //      C# -> RecoveryFailureAction? RecoveryFailureAction
        // GraphQL -> recoveryFailureAction: RecoveryFailureAction! (enum)
        if (this.RecoveryFailureAction != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryFailureAction\n" ;
            } else {
                s += ind + "recoveryFailureAction\n" ;
            }
        }
        //      C# -> RecoveryOutcome? RecoveryOutcome
        // GraphQL -> recoveryOutcome: RecoveryOutcome! (enum)
        if (this.RecoveryOutcome != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryOutcome\n" ;
            } else {
                s += ind + "recoveryOutcome\n" ;
            }
        }
        //      C# -> RecoveryType? RecoveryType
        // GraphQL -> recoveryType: RecoveryType! (enum)
        if (this.RecoveryType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryType\n" ;
            } else {
                s += ind + "recoveryType\n" ;
            }
        }
        //      C# -> RecoveryStatus? Status
        // GraphQL -> status: RecoveryStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> RecoveryTriggeredFrom? TriggeredFrom
        // GraphQL -> triggeredFrom: RecoveryTriggeredFrom! (enum)
        if (this.TriggeredFrom != null) {
            if (conf.Flat) {
                s += conf.Prefix + "triggeredFrom\n" ;
            } else {
                s += ind + "triggeredFrom\n" ;
            }
        }
        //      C# -> System.Boolean? CanSaveAsPlan
        // GraphQL -> canSaveAsPlan: Boolean! (scalar)
        if (this.CanSaveAsPlan != null) {
            if (conf.Flat) {
                s += conf.Prefix + "canSaveAsPlan\n" ;
            } else {
                s += ind + "canSaveAsPlan\n" ;
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
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
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
        //      C# -> System.Boolean? IsAdhocRecovery
        // GraphQL -> isAdhocRecovery: Boolean! (scalar)
        if (this.IsAdhocRecovery != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAdhocRecovery\n" ;
            } else {
                s += ind + "isAdhocRecovery\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Int64? NumWorkloads
        // GraphQL -> numWorkloads: Long! (scalar)
        if (this.NumWorkloads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numWorkloads\n" ;
            } else {
                s += ind + "numWorkloads\n" ;
            }
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (this.RecoveryName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryName\n" ;
            } else {
                s += ind + "recoveryName\n" ;
            }
        }
        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: String! (scalar)
        if (this.RecoveryPlanId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanId\n" ;
            } else {
                s += ind + "recoveryPlanId\n" ;
            }
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> RecoveryPlanBasicInfo? RecoveryPlanBasicInfo
        // GraphQL -> recoveryPlanBasicInfo: RecoveryPlanBasicInfo (type)
        if (this.RecoveryPlanBasicInfo != null) {
            var fspec = this.RecoveryPlanBasicInfo.AsFieldSpec(conf.Child("recoveryPlanBasicInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryPlanBasicInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> StepsOneof? Steps
        // GraphQL -> steps: StepsOneof (type)
        if (this.Steps != null) {
            var fspec = this.Steps.AsFieldSpec(conf.Child("steps"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "steps" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DataTransferType? DataTransferType
        // GraphQL -> dataTransferType: DataTransferType! (enum)
        if (ec.Includes("dataTransferType",true))
        {
            if(this.DataTransferType == null) {

                this.DataTransferType = new DataTransferType();

            } else {


            }
        }
        else if (this.DataTransferType != null && ec.Excludes("dataTransferType",true))
        {
            this.DataTransferType = null;
        }
        //      C# -> RecoveryFailureAction? RecoveryFailureAction
        // GraphQL -> recoveryFailureAction: RecoveryFailureAction! (enum)
        if (ec.Includes("recoveryFailureAction",true))
        {
            if(this.RecoveryFailureAction == null) {

                this.RecoveryFailureAction = new RecoveryFailureAction();

            } else {


            }
        }
        else if (this.RecoveryFailureAction != null && ec.Excludes("recoveryFailureAction",true))
        {
            this.RecoveryFailureAction = null;
        }
        //      C# -> RecoveryOutcome? RecoveryOutcome
        // GraphQL -> recoveryOutcome: RecoveryOutcome! (enum)
        if (ec.Includes("recoveryOutcome",true))
        {
            if(this.RecoveryOutcome == null) {

                this.RecoveryOutcome = new RecoveryOutcome();

            } else {


            }
        }
        else if (this.RecoveryOutcome != null && ec.Excludes("recoveryOutcome",true))
        {
            this.RecoveryOutcome = null;
        }
        //      C# -> RecoveryType? RecoveryType
        // GraphQL -> recoveryType: RecoveryType! (enum)
        if (ec.Includes("recoveryType",true))
        {
            if(this.RecoveryType == null) {

                this.RecoveryType = new RecoveryType();

            } else {


            }
        }
        else if (this.RecoveryType != null && ec.Excludes("recoveryType",true))
        {
            this.RecoveryType = null;
        }
        //      C# -> RecoveryStatus? Status
        // GraphQL -> status: RecoveryStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new RecoveryStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> RecoveryTriggeredFrom? TriggeredFrom
        // GraphQL -> triggeredFrom: RecoveryTriggeredFrom! (enum)
        if (ec.Includes("triggeredFrom",true))
        {
            if(this.TriggeredFrom == null) {

                this.TriggeredFrom = new RecoveryTriggeredFrom();

            } else {


            }
        }
        else if (this.TriggeredFrom != null && ec.Excludes("triggeredFrom",true))
        {
            this.TriggeredFrom = null;
        }
        //      C# -> System.Boolean? CanSaveAsPlan
        // GraphQL -> canSaveAsPlan: Boolean! (scalar)
        if (ec.Includes("canSaveAsPlan",true))
        {
            if(this.CanSaveAsPlan == null) {

                this.CanSaveAsPlan = true;

            } else {


            }
        }
        else if (this.CanSaveAsPlan != null && ec.Excludes("canSaveAsPlan",true))
        {
            this.CanSaveAsPlan = null;
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
        // GraphQL -> endTime: Long! (scalar)
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
        //      C# -> System.Boolean? IsAdhocRecovery
        // GraphQL -> isAdhocRecovery: Boolean! (scalar)
        if (ec.Includes("isAdhocRecovery",true))
        {
            if(this.IsAdhocRecovery == null) {

                this.IsAdhocRecovery = true;

            } else {


            }
        }
        else if (this.IsAdhocRecovery != null && ec.Excludes("isAdhocRecovery",true))
        {
            this.IsAdhocRecovery = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Int64? NumWorkloads
        // GraphQL -> numWorkloads: Long! (scalar)
        if (ec.Includes("numWorkloads",true))
        {
            if(this.NumWorkloads == null) {

                this.NumWorkloads = new System.Int64();

            } else {


            }
        }
        else if (this.NumWorkloads != null && ec.Excludes("numWorkloads",true))
        {
            this.NumWorkloads = null;
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = new System.Single();

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (ec.Includes("recoveryName",true))
        {
            if(this.RecoveryName == null) {

                this.RecoveryName = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryName != null && ec.Excludes("recoveryName",true))
        {
            this.RecoveryName = null;
        }
        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: String! (scalar)
        if (ec.Includes("recoveryPlanId",true))
        {
            if(this.RecoveryPlanId == null) {

                this.RecoveryPlanId = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryPlanId != null && ec.Excludes("recoveryPlanId",true))
        {
            this.RecoveryPlanId = null;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
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
        //      C# -> RecoveryPlanBasicInfo? RecoveryPlanBasicInfo
        // GraphQL -> recoveryPlanBasicInfo: RecoveryPlanBasicInfo (type)
        if (ec.Includes("recoveryPlanBasicInfo",false))
        {
            if(this.RecoveryPlanBasicInfo == null) {

                this.RecoveryPlanBasicInfo = new RecoveryPlanBasicInfo();
                this.RecoveryPlanBasicInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlanBasicInfo"));

            } else {

                this.RecoveryPlanBasicInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlanBasicInfo"));

            }
        }
        else if (this.RecoveryPlanBasicInfo != null && ec.Excludes("recoveryPlanBasicInfo",false))
        {
            this.RecoveryPlanBasicInfo = null;
        }
        //      C# -> StepsOneof? Steps
        // GraphQL -> steps: StepsOneof (type)
        if (ec.Includes("steps",false))
        {
            if(this.Steps == null) {

                this.Steps = new StepsOneof();
                this.Steps.ApplyExploratoryFieldSpec(ec.NewChild("steps"));

            } else {

                this.Steps.ApplyExploratoryFieldSpec(ec.NewChild("steps"));

            }
        }
        else if (this.Steps != null && ec.Excludes("steps",false))
        {
            this.Steps = null;
        }
    }


    #endregion

    } // class Recovery
    
    #endregion

    public static class ListRecoveryExtensions
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
            this List<Recovery> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Recovery> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Recovery> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Recovery());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Recovery> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types