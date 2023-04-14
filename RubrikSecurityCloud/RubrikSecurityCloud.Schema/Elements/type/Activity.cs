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

namespace Rubrik.SecurityCloud.Types
{
    #region Activity
    public class Activity: IFragment
    {
        #region members
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

        #endregion

    #region methods

    public Activity Set(
        System.String? ActivityInfo = null,
        System.String? ClusterId = null,
        System.String? Id = null,
        System.String? Message = null,
        System.String? ObjectId = null,
        System.String? Progress = null,
        DateTime? Time = null,
        ActivitySeries? ActivitySeries = null,
        ActivityObjectTypeEnum? ObjectType = null,
        ActivitySeverityEnum? Severity = null,
        ActivityStatusEnum? Status = null,
        ActivityTypeEnum? Type = null
    ) 
    {
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? ActivityInfo
            // GraphQL -> activityInfo: String (scalar)
            if (this.ActivityInfo != null)
            {
                 s += ind + "activityInfo\n";

            }
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId != null)
            {
                 s += ind + "clusterId\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: ID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> System.String? ObjectId
            // GraphQL -> objectId: String! (scalar)
            if (this.ObjectId != null)
            {
                 s += ind + "objectId\n";

            }
            //      C# -> System.String? Progress
            // GraphQL -> progress: String (scalar)
            if (this.Progress != null)
            {
                 s += ind + "progress\n";

            }
            //      C# -> DateTime? Time
            // GraphQL -> time: DateTime! (scalar)
            if (this.Time != null)
            {
                 s += ind + "time\n";

            }
            //      C# -> ActivitySeries? ActivitySeries
            // GraphQL -> activitySeries: ActivitySeries! (type)
            if (this.ActivitySeries != null)
            {
                 s += ind + "activitySeries\n";

                 s += ind + "{\n" + 
                 this.ActivitySeries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ActivityObjectTypeEnum? ObjectType
            // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> ActivitySeverityEnum? Severity
            // GraphQL -> severity: ActivitySeverityEnum! (enum)
            if (this.Severity != null)
            {
                 s += ind + "severity\n";

            }
            //      C# -> ActivityStatusEnum? Status
            // GraphQL -> status: ActivityStatusEnum! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            //      C# -> ActivityTypeEnum? Type
            // GraphQL -> type: ActivityTypeEnum! (enum)
            if (this.Type != null)
            {
                 s += ind + "type\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ActivityInfo
            // GraphQL -> activityInfo: String (scalar)
            if (this.ActivityInfo == null && Exploration.Includes(parent + ".activityInfo$"))
            {
                this.ActivityInfo = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId$"))
            {
                this.ClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: ID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> System.String? ObjectId
            // GraphQL -> objectId: String! (scalar)
            if (this.ObjectId == null && Exploration.Includes(parent + ".objectId$"))
            {
                this.ObjectId = new System.String("FETCH");
            }
            //      C# -> System.String? Progress
            // GraphQL -> progress: String (scalar)
            if (this.Progress == null && Exploration.Includes(parent + ".progress$"))
            {
                this.Progress = new System.String("FETCH");
            }
            //      C# -> DateTime? Time
            // GraphQL -> time: DateTime! (scalar)
            if (this.Time == null && Exploration.Includes(parent + ".time$"))
            {
                this.Time = new DateTime();
            }
            //      C# -> ActivitySeries? ActivitySeries
            // GraphQL -> activitySeries: ActivitySeries! (type)
            if (this.ActivitySeries == null && Exploration.Includes(parent + ".activitySeries"))
            {
                this.ActivitySeries = new ActivitySeries();
                this.ActivitySeries.ApplyExploratoryFragment(parent + ".activitySeries");
            }
            //      C# -> ActivityObjectTypeEnum? ObjectType
            // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new ActivityObjectTypeEnum();
            }
            //      C# -> ActivitySeverityEnum? Severity
            // GraphQL -> severity: ActivitySeverityEnum! (enum)
            if (this.Severity == null && Exploration.Includes(parent + ".severity$"))
            {
                this.Severity = new ActivitySeverityEnum();
            }
            //      C# -> ActivityStatusEnum? Status
            // GraphQL -> status: ActivityStatusEnum! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new ActivityStatusEnum();
            }
            //      C# -> ActivityTypeEnum? Type
            // GraphQL -> type: ActivityTypeEnum! (enum)
            if (this.Type == null && Exploration.Includes(parent + ".type$"))
            {
                this.Type = new ActivityTypeEnum();
            }
        }


    #endregion

    } // class Activity
    #endregion

    public static class ListActivityExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<Activity> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Activity> list, 
            String parent = "")
        {
            var item = new Activity();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types