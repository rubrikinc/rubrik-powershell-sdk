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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> ActivityStatusEnum? Status
        // GraphQL -> status: ActivityStatusEnum! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> ActivityTypeEnum? Type
        // GraphQL -> type: ActivityTypeEnum! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? ActivityInfo
        // GraphQL -> activityInfo: String (scalar)
        if (this.ActivityInfo != null) {
            s += ind + "activityInfo\n" ;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: ID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time != null) {
            s += ind + "time\n" ;
        }
        //      C# -> ActivitySeries? ActivitySeries
        // GraphQL -> activitySeries: ActivitySeries! (type)
        if (this.ActivitySeries != null) {
            var fspec = this.ActivitySeries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "activitySeries {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new ActivityObjectTypeEnum();
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity == null && Exploration.Includes(parent + ".severity", true))
        {
            this.Severity = new ActivitySeverityEnum();
        }
        //      C# -> ActivityStatusEnum? Status
        // GraphQL -> status: ActivityStatusEnum! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new ActivityStatusEnum();
        }
        //      C# -> ActivityTypeEnum? Type
        // GraphQL -> type: ActivityTypeEnum! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new ActivityTypeEnum();
        }
        //      C# -> System.String? ActivityInfo
        // GraphQL -> activityInfo: String (scalar)
        if (this.ActivityInfo == null && Exploration.Includes(parent + ".activityInfo", true))
        {
            this.ActivityInfo = "FETCH";
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId", true))
        {
            this.ClusterId = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: ID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && Exploration.Includes(parent + ".objectId", true))
        {
            this.ObjectId = "FETCH";
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
        if (this.Progress == null && Exploration.Includes(parent + ".progress", true))
        {
            this.Progress = "FETCH";
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time == null && Exploration.Includes(parent + ".time", true))
        {
            this.Time = new DateTime();
        }
        //      C# -> ActivitySeries? ActivitySeries
        // GraphQL -> activitySeries: ActivitySeries! (type)
        if (this.ActivitySeries == null && Exploration.Includes(parent + ".activitySeries"))
        {
            this.ActivitySeries = new ActivitySeries();
            this.ActivitySeries.ApplyExploratoryFieldSpec(parent + ".activitySeries");
        }
    }


    #endregion

    } // class Activity
    
    #endregion

    public static class ListActivityExtensions
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
            this List<Activity> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Activity> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Activity());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types