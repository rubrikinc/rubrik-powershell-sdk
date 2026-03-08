// ActivityEntry.cs
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
    #region ActivityEntry
    public class ActivityEntry: BaseType
    {
        #region members

        //      C# -> LambdaEventActionType? ActionType
        // GraphQL -> actionType: LambdaEventActionType! (enum)
        [JsonProperty("actionType")]
        public LambdaEventActionType? ActionType { get; set; }

        //      C# -> EventProvider? ActivityProvider
        // GraphQL -> activityProvider: EventProvider! (enum)
        [JsonProperty("activityProvider")]
        public EventProvider? ActivityProvider { get; set; }

        //      C# -> LambdaEventType? ActivityType
        // GraphQL -> activityType: LambdaEventType! (enum)
        [JsonProperty("activityType")]
        public LambdaEventType? ActivityType { get; set; }

        //      C# -> ActorIdentificationState? ActorState
        // GraphQL -> actorState: ActorIdentificationState! (enum)
        [JsonProperty("actorState")]
        public ActorIdentificationState? ActorState { get; set; }

        //      C# -> ActivityCategory? Category
        // GraphQL -> category: ActivityCategory! (enum)
        [JsonProperty("category")]
        public ActivityCategory? Category { get; set; }

        //      C# -> ActivityOperation? Operation
        // GraphQL -> operation: ActivityOperation! (enum)
        [JsonProperty("operation")]
        public ActivityOperation? Operation { get; set; }

        //      C# -> LambdaEventStatus? Status
        // GraphQL -> status: LambdaEventStatus! (enum)
        [JsonProperty("status")]
        public LambdaEventStatus? Status { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? NativeCorrelationId
        // GraphQL -> nativeCorrelationId: String! (scalar)
        [JsonProperty("nativeCorrelationId")]
        public System.String? NativeCorrelationId { get; set; }

        //      C# -> System.String? SourceId
        // GraphQL -> sourceId: String! (scalar)
        [JsonProperty("sourceId")]
        public System.String? SourceId { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> ActivityAuditorEntity? ActorEntity
        // GraphQL -> actorEntity: ActivityAuditorEntity (type)
        [JsonProperty("actorEntity")]
        public ActivityAuditorEntity? ActorEntity { get; set; }

        //      C# -> List<ActivityAuditorEntity>? AdditionalTargetEntities
        // GraphQL -> additionalTargetEntities: [ActivityAuditorEntity!]! (type)
        [JsonProperty("additionalTargetEntities")]
        public List<ActivityAuditorEntity>? AdditionalTargetEntities { get; set; }

        //      C# -> ActivityAuditorChangeDetails? ChangeDetails
        // GraphQL -> changeDetails: ActivityAuditorChangeDetails (type)
        [JsonProperty("changeDetails")]
        public ActivityAuditorChangeDetails? ChangeDetails { get; set; }

        //      C# -> ActivityAuditorPrimaryTargetEntity? PrimaryTargetEntity
        // GraphQL -> primaryTargetEntity: ActivityAuditorPrimaryTargetEntity (type)
        [JsonProperty("primaryTargetEntity")]
        public ActivityAuditorPrimaryTargetEntity? PrimaryTargetEntity { get; set; }

        //      C# -> List<ActivityRemediationStatus>? RemediationStatuses
        // GraphQL -> remediationStatuses: [ActivityRemediationStatus!]! (type)
        [JsonProperty("remediationStatuses")]
        public List<ActivityRemediationStatus>? RemediationStatuses { get; set; }

        //      C# -> List<RemediationAvailability>? RemediationTypes
        // GraphQL -> remediationTypes: [RemediationAvailability!]! (type)
        [JsonProperty("remediationTypes")]
        public List<RemediationAvailability>? RemediationTypes { get; set; }

        //      C# -> EventSourceMetadata? SourceMetadata
        // GraphQL -> sourceMetadata: EventSourceMetadata (type)
        [JsonProperty("sourceMetadata")]
        public EventSourceMetadata? SourceMetadata { get; set; }

        //      C# -> ActivityAuditorEntity? TargetEntity
        // GraphQL -> targetEntity: ActivityAuditorEntity (type)
        [JsonProperty("targetEntity")]
        public ActivityAuditorEntity? TargetEntity { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActivityEntry";
    }

    public ActivityEntry Set(
        LambdaEventActionType? ActionType = null,
        EventProvider? ActivityProvider = null,
        LambdaEventType? ActivityType = null,
        ActorIdentificationState? ActorState = null,
        ActivityCategory? Category = null,
        ActivityOperation? Operation = null,
        LambdaEventStatus? Status = null,
        System.String? Id = null,
        System.String? NativeCorrelationId = null,
        System.String? SourceId = null,
        DateTime? Time = null,
        System.String? Title = null,
        ActivityAuditorEntity? ActorEntity = null,
        List<ActivityAuditorEntity>? AdditionalTargetEntities = null,
        ActivityAuditorChangeDetails? ChangeDetails = null,
        ActivityAuditorPrimaryTargetEntity? PrimaryTargetEntity = null,
        List<ActivityRemediationStatus>? RemediationStatuses = null,
        List<RemediationAvailability>? RemediationTypes = null,
        EventSourceMetadata? SourceMetadata = null,
        ActivityAuditorEntity? TargetEntity = null
    ) 
    {
        if ( ActionType != null ) {
            this.ActionType = ActionType;
        }
        if ( ActivityProvider != null ) {
            this.ActivityProvider = ActivityProvider;
        }
        if ( ActivityType != null ) {
            this.ActivityType = ActivityType;
        }
        if ( ActorState != null ) {
            this.ActorState = ActorState;
        }
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( Operation != null ) {
            this.Operation = Operation;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( NativeCorrelationId != null ) {
            this.NativeCorrelationId = NativeCorrelationId;
        }
        if ( SourceId != null ) {
            this.SourceId = SourceId;
        }
        if ( Time != null ) {
            this.Time = Time;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( ActorEntity != null ) {
            this.ActorEntity = ActorEntity;
        }
        if ( AdditionalTargetEntities != null ) {
            this.AdditionalTargetEntities = AdditionalTargetEntities;
        }
        if ( ChangeDetails != null ) {
            this.ChangeDetails = ChangeDetails;
        }
        if ( PrimaryTargetEntity != null ) {
            this.PrimaryTargetEntity = PrimaryTargetEntity;
        }
        if ( RemediationStatuses != null ) {
            this.RemediationStatuses = RemediationStatuses;
        }
        if ( RemediationTypes != null ) {
            this.RemediationTypes = RemediationTypes;
        }
        if ( SourceMetadata != null ) {
            this.SourceMetadata = SourceMetadata;
        }
        if ( TargetEntity != null ) {
            this.TargetEntity = TargetEntity;
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
        //      C# -> LambdaEventActionType? ActionType
        // GraphQL -> actionType: LambdaEventActionType! (enum)
        if (this.ActionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actionType\n" ;
            } else {
                s += ind + "actionType\n" ;
            }
        }
        //      C# -> EventProvider? ActivityProvider
        // GraphQL -> activityProvider: EventProvider! (enum)
        if (this.ActivityProvider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activityProvider\n" ;
            } else {
                s += ind + "activityProvider\n" ;
            }
        }
        //      C# -> LambdaEventType? ActivityType
        // GraphQL -> activityType: LambdaEventType! (enum)
        if (this.ActivityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activityType\n" ;
            } else {
                s += ind + "activityType\n" ;
            }
        }
        //      C# -> ActorIdentificationState? ActorState
        // GraphQL -> actorState: ActorIdentificationState! (enum)
        if (this.ActorState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorState\n" ;
            } else {
                s += ind + "actorState\n" ;
            }
        }
        //      C# -> ActivityCategory? Category
        // GraphQL -> category: ActivityCategory! (enum)
        if (this.Category != null) {
            if (conf.Flat) {
                s += conf.Prefix + "category\n" ;
            } else {
                s += ind + "category\n" ;
            }
        }
        //      C# -> ActivityOperation? Operation
        // GraphQL -> operation: ActivityOperation! (enum)
        if (this.Operation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operation\n" ;
            } else {
                s += ind + "operation\n" ;
            }
        }
        //      C# -> LambdaEventStatus? Status
        // GraphQL -> status: LambdaEventStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? NativeCorrelationId
        // GraphQL -> nativeCorrelationId: String! (scalar)
        if (this.NativeCorrelationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeCorrelationId\n" ;
            } else {
                s += ind + "nativeCorrelationId\n" ;
            }
        }
        //      C# -> System.String? SourceId
        // GraphQL -> sourceId: String! (scalar)
        if (this.SourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceId\n" ;
            } else {
                s += ind + "sourceId\n" ;
            }
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        if (this.Time != null) {
            if (conf.Flat) {
                s += conf.Prefix + "time\n" ;
            } else {
                s += ind + "time\n" ;
            }
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            if (conf.Flat) {
                s += conf.Prefix + "title\n" ;
            } else {
                s += ind + "title\n" ;
            }
        }
        //      C# -> ActivityAuditorEntity? ActorEntity
        // GraphQL -> actorEntity: ActivityAuditorEntity (type)
        if (this.ActorEntity != null) {
            var fspec = this.ActorEntity.AsFieldSpec(conf.Child("actorEntity"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "actorEntity" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ActivityAuditorEntity>? AdditionalTargetEntities
        // GraphQL -> additionalTargetEntities: [ActivityAuditorEntity!]! (type)
        if (this.AdditionalTargetEntities != null) {
            var fspec = this.AdditionalTargetEntities.AsFieldSpec(conf.Child("additionalTargetEntities"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "additionalTargetEntities" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActivityAuditorChangeDetails? ChangeDetails
        // GraphQL -> changeDetails: ActivityAuditorChangeDetails (type)
        if (this.ChangeDetails != null) {
            var fspec = this.ChangeDetails.AsFieldSpec(conf.Child("changeDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "changeDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActivityAuditorPrimaryTargetEntity? PrimaryTargetEntity
        // GraphQL -> primaryTargetEntity: ActivityAuditorPrimaryTargetEntity (type)
        if (this.PrimaryTargetEntity != null) {
            var fspec = this.PrimaryTargetEntity.AsFieldSpec(conf.Child("primaryTargetEntity"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "primaryTargetEntity" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ActivityRemediationStatus>? RemediationStatuses
        // GraphQL -> remediationStatuses: [ActivityRemediationStatus!]! (type)
        if (this.RemediationStatuses != null) {
            var fspec = this.RemediationStatuses.AsFieldSpec(conf.Child("remediationStatuses"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remediationStatuses" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RemediationAvailability>? RemediationTypes
        // GraphQL -> remediationTypes: [RemediationAvailability!]! (type)
        if (this.RemediationTypes != null) {
            var fspec = this.RemediationTypes.AsFieldSpec(conf.Child("remediationTypes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remediationTypes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> EventSourceMetadata? SourceMetadata
        // GraphQL -> sourceMetadata: EventSourceMetadata (type)
        if (this.SourceMetadata != null) {
            var fspec = this.SourceMetadata.AsFieldSpec(conf.Child("sourceMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActivityAuditorEntity? TargetEntity
        // GraphQL -> targetEntity: ActivityAuditorEntity (type)
        if (this.TargetEntity != null) {
            var fspec = this.TargetEntity.AsFieldSpec(conf.Child("targetEntity"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetEntity" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> LambdaEventActionType? ActionType
        // GraphQL -> actionType: LambdaEventActionType! (enum)
        if (ec.Includes("actionType",true))
        {
            if(this.ActionType == null) {

                this.ActionType = new LambdaEventActionType();

            } else {


            }
        }
        else if (this.ActionType != null && ec.Excludes("actionType",true))
        {
            this.ActionType = null;
        }
        //      C# -> EventProvider? ActivityProvider
        // GraphQL -> activityProvider: EventProvider! (enum)
        if (ec.Includes("activityProvider",true))
        {
            if(this.ActivityProvider == null) {

                this.ActivityProvider = new EventProvider();

            } else {


            }
        }
        else if (this.ActivityProvider != null && ec.Excludes("activityProvider",true))
        {
            this.ActivityProvider = null;
        }
        //      C# -> LambdaEventType? ActivityType
        // GraphQL -> activityType: LambdaEventType! (enum)
        if (ec.Includes("activityType",true))
        {
            if(this.ActivityType == null) {

                this.ActivityType = new LambdaEventType();

            } else {


            }
        }
        else if (this.ActivityType != null && ec.Excludes("activityType",true))
        {
            this.ActivityType = null;
        }
        //      C# -> ActorIdentificationState? ActorState
        // GraphQL -> actorState: ActorIdentificationState! (enum)
        if (ec.Includes("actorState",true))
        {
            if(this.ActorState == null) {

                this.ActorState = new ActorIdentificationState();

            } else {


            }
        }
        else if (this.ActorState != null && ec.Excludes("actorState",true))
        {
            this.ActorState = null;
        }
        //      C# -> ActivityCategory? Category
        // GraphQL -> category: ActivityCategory! (enum)
        if (ec.Includes("category",true))
        {
            if(this.Category == null) {

                this.Category = new ActivityCategory();

            } else {


            }
        }
        else if (this.Category != null && ec.Excludes("category",true))
        {
            this.Category = null;
        }
        //      C# -> ActivityOperation? Operation
        // GraphQL -> operation: ActivityOperation! (enum)
        if (ec.Includes("operation",true))
        {
            if(this.Operation == null) {

                this.Operation = new ActivityOperation();

            } else {


            }
        }
        else if (this.Operation != null && ec.Excludes("operation",true))
        {
            this.Operation = null;
        }
        //      C# -> LambdaEventStatus? Status
        // GraphQL -> status: LambdaEventStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new LambdaEventStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
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
        //      C# -> System.String? NativeCorrelationId
        // GraphQL -> nativeCorrelationId: String! (scalar)
        if (ec.Includes("nativeCorrelationId",true))
        {
            if(this.NativeCorrelationId == null) {

                this.NativeCorrelationId = "FETCH";

            } else {


            }
        }
        else if (this.NativeCorrelationId != null && ec.Excludes("nativeCorrelationId",true))
        {
            this.NativeCorrelationId = null;
        }
        //      C# -> System.String? SourceId
        // GraphQL -> sourceId: String! (scalar)
        if (ec.Includes("sourceId",true))
        {
            if(this.SourceId == null) {

                this.SourceId = "FETCH";

            } else {


            }
        }
        else if (this.SourceId != null && ec.Excludes("sourceId",true))
        {
            this.SourceId = null;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        if (ec.Includes("time",true))
        {
            if(this.Time == null) {

                this.Time = new DateTime();

            } else {


            }
        }
        else if (this.Time != null && ec.Excludes("time",true))
        {
            this.Time = null;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (ec.Includes("title",true))
        {
            if(this.Title == null) {

                this.Title = "FETCH";

            } else {


            }
        }
        else if (this.Title != null && ec.Excludes("title",true))
        {
            this.Title = null;
        }
        //      C# -> ActivityAuditorEntity? ActorEntity
        // GraphQL -> actorEntity: ActivityAuditorEntity (type)
        if (ec.Includes("actorEntity",false))
        {
            if(this.ActorEntity == null) {

                this.ActorEntity = new ActivityAuditorEntity();
                this.ActorEntity.ApplyExploratoryFieldSpec(ec.NewChild("actorEntity"));

            } else {

                this.ActorEntity.ApplyExploratoryFieldSpec(ec.NewChild("actorEntity"));

            }
        }
        else if (this.ActorEntity != null && ec.Excludes("actorEntity",false))
        {
            this.ActorEntity = null;
        }
        //      C# -> List<ActivityAuditorEntity>? AdditionalTargetEntities
        // GraphQL -> additionalTargetEntities: [ActivityAuditorEntity!]! (type)
        if (ec.Includes("additionalTargetEntities",false))
        {
            if(this.AdditionalTargetEntities == null) {

                this.AdditionalTargetEntities = new List<ActivityAuditorEntity>();
                this.AdditionalTargetEntities.ApplyExploratoryFieldSpec(ec.NewChild("additionalTargetEntities"));

            } else {

                this.AdditionalTargetEntities.ApplyExploratoryFieldSpec(ec.NewChild("additionalTargetEntities"));

            }
        }
        else if (this.AdditionalTargetEntities != null && ec.Excludes("additionalTargetEntities",false))
        {
            this.AdditionalTargetEntities = null;
        }
        //      C# -> ActivityAuditorChangeDetails? ChangeDetails
        // GraphQL -> changeDetails: ActivityAuditorChangeDetails (type)
        if (ec.Includes("changeDetails",false))
        {
            if(this.ChangeDetails == null) {

                this.ChangeDetails = new ActivityAuditorChangeDetails();
                this.ChangeDetails.ApplyExploratoryFieldSpec(ec.NewChild("changeDetails"));

            } else {

                this.ChangeDetails.ApplyExploratoryFieldSpec(ec.NewChild("changeDetails"));

            }
        }
        else if (this.ChangeDetails != null && ec.Excludes("changeDetails",false))
        {
            this.ChangeDetails = null;
        }
        //      C# -> ActivityAuditorPrimaryTargetEntity? PrimaryTargetEntity
        // GraphQL -> primaryTargetEntity: ActivityAuditorPrimaryTargetEntity (type)
        if (ec.Includes("primaryTargetEntity",false))
        {
            if(this.PrimaryTargetEntity == null) {

                this.PrimaryTargetEntity = new ActivityAuditorPrimaryTargetEntity();
                this.PrimaryTargetEntity.ApplyExploratoryFieldSpec(ec.NewChild("primaryTargetEntity"));

            } else {

                this.PrimaryTargetEntity.ApplyExploratoryFieldSpec(ec.NewChild("primaryTargetEntity"));

            }
        }
        else if (this.PrimaryTargetEntity != null && ec.Excludes("primaryTargetEntity",false))
        {
            this.PrimaryTargetEntity = null;
        }
        //      C# -> List<ActivityRemediationStatus>? RemediationStatuses
        // GraphQL -> remediationStatuses: [ActivityRemediationStatus!]! (type)
        if (ec.Includes("remediationStatuses",false))
        {
            if(this.RemediationStatuses == null) {

                this.RemediationStatuses = new List<ActivityRemediationStatus>();
                this.RemediationStatuses.ApplyExploratoryFieldSpec(ec.NewChild("remediationStatuses"));

            } else {

                this.RemediationStatuses.ApplyExploratoryFieldSpec(ec.NewChild("remediationStatuses"));

            }
        }
        else if (this.RemediationStatuses != null && ec.Excludes("remediationStatuses",false))
        {
            this.RemediationStatuses = null;
        }
        //      C# -> List<RemediationAvailability>? RemediationTypes
        // GraphQL -> remediationTypes: [RemediationAvailability!]! (type)
        if (ec.Includes("remediationTypes",false))
        {
            if(this.RemediationTypes == null) {

                this.RemediationTypes = new List<RemediationAvailability>();
                this.RemediationTypes.ApplyExploratoryFieldSpec(ec.NewChild("remediationTypes"));

            } else {

                this.RemediationTypes.ApplyExploratoryFieldSpec(ec.NewChild("remediationTypes"));

            }
        }
        else if (this.RemediationTypes != null && ec.Excludes("remediationTypes",false))
        {
            this.RemediationTypes = null;
        }
        //      C# -> EventSourceMetadata? SourceMetadata
        // GraphQL -> sourceMetadata: EventSourceMetadata (type)
        if (ec.Includes("sourceMetadata",false))
        {
            if(this.SourceMetadata == null) {

                this.SourceMetadata = new EventSourceMetadata();
                this.SourceMetadata.ApplyExploratoryFieldSpec(ec.NewChild("sourceMetadata"));

            } else {

                this.SourceMetadata.ApplyExploratoryFieldSpec(ec.NewChild("sourceMetadata"));

            }
        }
        else if (this.SourceMetadata != null && ec.Excludes("sourceMetadata",false))
        {
            this.SourceMetadata = null;
        }
        //      C# -> ActivityAuditorEntity? TargetEntity
        // GraphQL -> targetEntity: ActivityAuditorEntity (type)
        if (ec.Includes("targetEntity",false))
        {
            if(this.TargetEntity == null) {

                this.TargetEntity = new ActivityAuditorEntity();
                this.TargetEntity.ApplyExploratoryFieldSpec(ec.NewChild("targetEntity"));

            } else {

                this.TargetEntity.ApplyExploratoryFieldSpec(ec.NewChild("targetEntity"));

            }
        }
        else if (this.TargetEntity != null && ec.Excludes("targetEntity",false))
        {
            this.TargetEntity = null;
        }
    }


    #endregion

    } // class ActivityEntry
    
    #endregion

    public static class ListActivityEntryExtensions
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
            this List<ActivityEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActivityEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActivityEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivityEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActivityEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types