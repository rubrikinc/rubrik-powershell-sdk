// UserActivityResult.cs
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
    #region UserActivityResult
    public class UserActivityResult: IFragment
    {
        #region members
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        [JsonProperty("numActivities")]
        public System.Int64? NumActivities { get; set; }

        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        [JsonProperty("paginationId")]
        public System.String? PaginationId { get; set; }

        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        [JsonProperty("numActivitiesBreakdown")]
        public List<ActivityResult>? NumActivitiesBreakdown { get; set; }

        //      C# -> AccessUser? User
        // GraphQL -> user: AccessUser (type)
        [JsonProperty("user")]
        public AccessUser? User { get; set; }

        #endregion

    #region methods

    public UserActivityResult Set(
        System.Int64? NumActivities = null,
        System.String? PaginationId = null,
        List<ActivityResult>? NumActivitiesBreakdown = null,
        AccessUser? User = null
    ) 
    {
        if ( NumActivities != null ) {
            this.NumActivities = NumActivities;
        }
        if ( PaginationId != null ) {
            this.PaginationId = PaginationId;
        }
        if ( NumActivitiesBreakdown != null ) {
            this.NumActivitiesBreakdown = NumActivitiesBreakdown;
        }
        if ( User != null ) {
            this.User = User;
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
            //      C# -> System.Int64? NumActivities
            // GraphQL -> numActivities: Long! (scalar)
            if (this.NumActivities != null)
            {
                 s += ind + "numActivities\n";

            }
            //      C# -> System.String? PaginationId
            // GraphQL -> paginationId: String! (scalar)
            if (this.PaginationId != null)
            {
                 s += ind + "paginationId\n";

            }
            //      C# -> List<ActivityResult>? NumActivitiesBreakdown
            // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
            if (this.NumActivitiesBreakdown != null)
            {
                 s += ind + "numActivitiesBreakdown\n";

                 s += ind + "{\n" + 
                 this.NumActivitiesBreakdown.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AccessUser? User
            // GraphQL -> user: AccessUser (type)
            if (this.User != null)
            {
                 s += ind + "user\n";

                 s += ind + "{\n" + 
                 this.User.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? NumActivities
            // GraphQL -> numActivities: Long! (scalar)
            if (this.NumActivities == null && Exploration.Includes(parent + ".numActivities$"))
            {
                this.NumActivities = new System.Int64();
            }
            //      C# -> System.String? PaginationId
            // GraphQL -> paginationId: String! (scalar)
            if (this.PaginationId == null && Exploration.Includes(parent + ".paginationId$"))
            {
                this.PaginationId = new System.String("FETCH");
            }
            //      C# -> List<ActivityResult>? NumActivitiesBreakdown
            // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
            if (this.NumActivitiesBreakdown == null && Exploration.Includes(parent + ".numActivitiesBreakdown"))
            {
                this.NumActivitiesBreakdown = new List<ActivityResult>();
                this.NumActivitiesBreakdown.ApplyExploratoryFragment(parent + ".numActivitiesBreakdown");
            }
            //      C# -> AccessUser? User
            // GraphQL -> user: AccessUser (type)
            if (this.User == null && Exploration.Includes(parent + ".user"))
            {
                this.User = new AccessUser();
                this.User.ApplyExploratoryFragment(parent + ".user");
            }
        }


    #endregion

    } // class UserActivityResult
    #endregion

    public static class ListUserActivityResultExtensions
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
            this List<UserActivityResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UserActivityResult> list, 
            String parent = "")
        {
            var item = new UserActivityResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types