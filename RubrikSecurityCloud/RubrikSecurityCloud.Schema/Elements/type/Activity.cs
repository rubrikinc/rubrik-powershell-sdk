// Activity.cs
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
    #region Activity
    public class Activity: BaseType
    {
        #region members

        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public ActivityObjectTypeEnum? ObjectType { get; set; }

        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        [JsonProperty("severity")]
        public ActivitySeverityEnum? Severity { get; set; }

        //      C# -> ActivityStatusEnum? Status
        // GraphQL -> status: ActivityStatusEnum! (enum)
        [JsonProperty("status")]
        public ActivityStatusEnum? Status { get; set; }

        //      C# -> ActivityTypeEnum? Type
        // GraphQL -> type: ActivityTypeEnum! (enum)
        [JsonProperty("type")]
        public ActivityTypeEnum? Type { get; set; }

        //      C# -> System.String? ActivityInfo
        // GraphQL -> activityInfo: String (scalar)
        [JsonProperty("activityInfo")]
        public System.String? ActivityInfo { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: ID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
        [JsonProperty("progress")]
        public System.String? Progress { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        //      C# -> ActivitySeries? ActivitySeries
        // GraphQL -> activitySeries: ActivitySeries! (type)
        [JsonProperty("activitySeries")]
        public ActivitySeries? ActivitySeries { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Activity";
    }

    public Activity Set(
        ActivityObjectTypeEnum? ObjectType = null,
        ActivitySeverityEnum? Severity = null,
        ActivityStatusEnum? Status = null,
        ActivityTypeEnum? Type = null,
        System.String? ActivityInfo = null,
        System.String? ClusterId = null,
        System.String? Id = null,
        System.String? Message = null,
        System.String? ObjectId = null,
        System.String? Progress = null,
        DateTime? Time = null,
        ActivitySeries? ActivitySeries = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( ActivityInfo != null ) {
            this.ActivityInfo = ActivityInfo;
        }
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( Time != null ) {
            this.Time = Time;
        }
        if ( ActivitySeries != null ) {
            this.ActivitySeries = ActivitySeries;
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
        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> ActivityStatusEnum? Status
        // GraphQL -> status: ActivityStatusEnum! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> ActivityTypeEnum? Type
        // GraphQL -> type: ActivityTypeEnum! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.String? ActivityInfo
        // GraphQL -> activityInfo: String (scalar)
        if (this.ActivityInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activityInfo\n" ;
            } else {
                s += ind + "activityInfo\n" ;
            }
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterId\n" ;
            } else {
                s += ind + "clusterId\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: ID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time != null) {
            if (conf.Flat) {
                s += conf.Prefix + "time\n" ;
            } else {
                s += ind + "time\n" ;
            }
        }
        //      C# -> ActivitySeries? ActivitySeries
        // GraphQL -> activitySeries: ActivitySeries! (type)
        if (this.ActivitySeries != null) {
            var fspec = this.ActivitySeries.AsFieldSpec(conf.Child("activitySeries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activitySeries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new ActivityObjectTypeEnum();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new ActivitySeverityEnum();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> ActivityStatusEnum? Status
        // GraphQL -> status: ActivityStatusEnum! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ActivityStatusEnum();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> ActivityTypeEnum? Type
        // GraphQL -> type: ActivityTypeEnum! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new ActivityTypeEnum();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.String? ActivityInfo
        // GraphQL -> activityInfo: String (scalar)
        if (ec.Includes("activityInfo",true))
        {
            if(this.ActivityInfo == null) {

                this.ActivityInfo = "FETCH";

            } else {


            }
        }
        else if (this.ActivityInfo != null && ec.Excludes("activityInfo",true))
        {
            this.ActivityInfo = null;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (ec.Includes("clusterId",true))
        {
            if(this.ClusterId == null) {

                this.ClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterId != null && ec.Excludes("clusterId",true))
        {
            this.ClusterId = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: ID! (scalar)
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
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
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
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
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
        //      C# -> ActivitySeries? ActivitySeries
        // GraphQL -> activitySeries: ActivitySeries! (type)
        if (ec.Includes("activitySeries",false))
        {
            if(this.ActivitySeries == null) {

                this.ActivitySeries = new ActivitySeries();
                this.ActivitySeries.ApplyExploratoryFieldSpec(ec.NewChild("activitySeries"));

            } else {

                this.ActivitySeries.ApplyExploratoryFieldSpec(ec.NewChild("activitySeries"));

            }
        }
        else if (this.ActivitySeries != null && ec.Excludes("activitySeries",false))
        {
            this.ActivitySeries = null;
        }
    }


    #endregion

    } // class Activity
    
    #endregion

    public static class ListActivityExtensions
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
            this List<Activity> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Activity> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Activity> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Activity());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Activity> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types