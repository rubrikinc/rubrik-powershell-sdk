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

        //      C# -> RecoveryTriggeredType? TriggeredFrom
        // GraphQL -> triggeredFrom: RecoveryTriggeredType! (enum)
        [JsonProperty("triggeredFrom")]
        public RecoveryTriggeredType? TriggeredFrom { get; set; }

        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: UUID! (scalar)
        [JsonProperty("blueprintId")]
        public System.String? BlueprintId { get; set; }

        //      C# -> System.String? BlueprintName
        // GraphQL -> blueprintName: String! (scalar)
        [JsonProperty("blueprintName")]
        public System.String? BlueprintName { get; set; }

        //      C# -> System.Boolean? CanSaveAsPlan
        // GraphQL -> canSaveAsPlan: Boolean! (scalar)
        [JsonProperty("canSaveAsPlan")]
        public System.Boolean? CanSaveAsPlan { get; set; }

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

    public override string GetGqlTypeName() {
        return "FailoverJobReport";
    }

    public FailoverJobReport Set(
        RecoveryTriggeredType? TriggeredFrom = null,
        System.String? BlueprintId = null,
        System.String? BlueprintName = null,
        System.Boolean? CanSaveAsPlan = null,
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
        if ( TriggeredFrom != null ) {
            this.TriggeredFrom = TriggeredFrom;
        }
        if ( BlueprintId != null ) {
            this.BlueprintId = BlueprintId;
        }
        if ( BlueprintName != null ) {
            this.BlueprintName = BlueprintName;
        }
        if ( CanSaveAsPlan != null ) {
            this.CanSaveAsPlan = CanSaveAsPlan;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RecoveryTriggeredType? TriggeredFrom
        // GraphQL -> triggeredFrom: RecoveryTriggeredType! (enum)
        if (this.TriggeredFrom != null) {
            if (conf.Flat) {
                s += conf.Prefix + "triggeredFrom\n" ;
            } else {
                s += ind + "triggeredFrom\n" ;
            }
        }
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: UUID! (scalar)
        if (this.BlueprintId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blueprintId\n" ;
            } else {
                s += ind + "blueprintId\n" ;
            }
        }
        //      C# -> System.String? BlueprintName
        // GraphQL -> blueprintName: String! (scalar)
        if (this.BlueprintName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blueprintName\n" ;
            } else {
                s += ind + "blueprintName\n" ;
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
        //      C# -> System.String? DataTransferType
        // GraphQL -> dataTransferType: String! (scalar)
        if (this.DataTransferType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataTransferType\n" ;
            } else {
                s += ind + "dataTransferType\n" ;
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
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean! (scalar)
        if (this.IsBlueprintVisible != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBlueprintVisible\n" ;
            } else {
                s += ind + "isBlueprintVisible\n" ;
            }
        }
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String! (scalar)
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
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (this.ObjectIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectIds\n" ;
            } else {
                s += ind + "objectIds\n" ;
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
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> List<FailoverStep>? Steps
        // GraphQL -> steps: [FailoverStep!]! (type)
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RecoveryTriggeredType? TriggeredFrom
        // GraphQL -> triggeredFrom: RecoveryTriggeredType! (enum)
        if (ec.Includes("triggeredFrom",true))
        {
            if(this.TriggeredFrom == null) {

                this.TriggeredFrom = new RecoveryTriggeredType();

            } else {


            }
        }
        else if (this.TriggeredFrom != null && ec.Excludes("triggeredFrom",true))
        {
            this.TriggeredFrom = null;
        }
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: UUID! (scalar)
        if (ec.Includes("blueprintId",true))
        {
            if(this.BlueprintId == null) {

                this.BlueprintId = "FETCH";

            } else {


            }
        }
        else if (this.BlueprintId != null && ec.Excludes("blueprintId",true))
        {
            this.BlueprintId = null;
        }
        //      C# -> System.String? BlueprintName
        // GraphQL -> blueprintName: String! (scalar)
        if (ec.Includes("blueprintName",true))
        {
            if(this.BlueprintName == null) {

                this.BlueprintName = "FETCH";

            } else {


            }
        }
        else if (this.BlueprintName != null && ec.Excludes("blueprintName",true))
        {
            this.BlueprintName = null;
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
        //      C# -> System.String? DataTransferType
        // GraphQL -> dataTransferType: String! (scalar)
        if (ec.Includes("dataTransferType",true))
        {
            if(this.DataTransferType == null) {

                this.DataTransferType = "FETCH";

            } else {


            }
        }
        else if (this.DataTransferType != null && ec.Excludes("dataTransferType",true))
        {
            this.DataTransferType = null;
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
        //      C# -> System.Boolean? IsBlueprintVisible
        // GraphQL -> isBlueprintVisible: Boolean! (scalar)
        if (ec.Includes("isBlueprintVisible",true))
        {
            if(this.IsBlueprintVisible == null) {

                this.IsBlueprintVisible = true;

            } else {


            }
        }
        else if (this.IsBlueprintVisible != null && ec.Excludes("isBlueprintVisible",true))
        {
            this.IsBlueprintVisible = null;
        }
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String! (scalar)
        if (ec.Includes("jobId",true))
        {
            if(this.JobId == null) {

                this.JobId = "FETCH";

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
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (ec.Includes("objectIds",true))
        {
            if(this.ObjectIds == null) {

                this.ObjectIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ObjectIds != null && ec.Excludes("objectIds",true))
        {
            this.ObjectIds = null;
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
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> List<FailoverStep>? Steps
        // GraphQL -> steps: [FailoverStep!]! (type)
        if (ec.Includes("steps",false))
        {
            if(this.Steps == null) {

                this.Steps = new List<FailoverStep>();
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

    } // class FailoverJobReport
    
    #endregion

    public static class ListFailoverJobReportExtensions
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
            this List<FailoverJobReport> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverJobReport> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverJobReport> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverJobReport());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverJobReport> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types