// AccessUser.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:30.
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
    #region AccessUser
    public class AccessUser: IFragment
    {
        #region members
        //      C# -> System.Int64? ActivityDelta
        // GraphQL -> activityDelta: Long! (scalar)
        [JsonProperty("activityDelta")]
        public System.Int64? ActivityDelta { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        [JsonProperty("lastAccessTime")]
        public System.Int64? LastAccessTime { get; set; }

        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        [JsonProperty("numActivities")]
        public System.Int64? NumActivities { get; set; }

        //      C# -> System.String? SubjectName
        // GraphQL -> subjectName: String! (scalar)
        [JsonProperty("subjectName")]
        public System.String? SubjectName { get; set; }

        //      C# -> System.String? UserSid
        // GraphQL -> userSid: String! (scalar)
        [JsonProperty("userSid")]
        public System.String? UserSid { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        #endregion

    #region methods

    public AccessUser Set(
        System.Int64? ActivityDelta = null,
        System.String? Email = null,
        System.Int64? LastAccessTime = null,
        System.Int64? NumActivities = null,
        System.String? SubjectName = null,
        System.String? UserSid = null,
        System.String? Username = null
    ) 
    {
        if ( ActivityDelta != null ) {
            this.ActivityDelta = ActivityDelta;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( LastAccessTime != null ) {
            this.LastAccessTime = LastAccessTime;
        }
        if ( NumActivities != null ) {
            this.NumActivities = NumActivities;
        }
        if ( SubjectName != null ) {
            this.SubjectName = SubjectName;
        }
        if ( UserSid != null ) {
            this.UserSid = UserSid;
        }
        if ( Username != null ) {
            this.Username = Username;
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
            //      C# -> System.Int64? ActivityDelta
            // GraphQL -> activityDelta: Long! (scalar)
            if (this.ActivityDelta != null)
            {
                 s += ind + "activityDelta\n";

            }
            //      C# -> System.String? Email
            // GraphQL -> email: String! (scalar)
            if (this.Email != null)
            {
                 s += ind + "email\n";

            }
            //      C# -> System.Int64? LastAccessTime
            // GraphQL -> lastAccessTime: Long! (scalar)
            if (this.LastAccessTime != null)
            {
                 s += ind + "lastAccessTime\n";

            }
            //      C# -> System.Int64? NumActivities
            // GraphQL -> numActivities: Long! (scalar)
            if (this.NumActivities != null)
            {
                 s += ind + "numActivities\n";

            }
            //      C# -> System.String? SubjectName
            // GraphQL -> subjectName: String! (scalar)
            if (this.SubjectName != null)
            {
                 s += ind + "subjectName\n";

            }
            //      C# -> System.String? UserSid
            // GraphQL -> userSid: String! (scalar)
            if (this.UserSid != null)
            {
                 s += ind + "userSid\n";

            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username != null)
            {
                 s += ind + "username\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? ActivityDelta
            // GraphQL -> activityDelta: Long! (scalar)
            if (this.ActivityDelta == null && Exploration.Includes(parent + ".activityDelta$"))
            {
                this.ActivityDelta = new System.Int64();
            }
            //      C# -> System.String? Email
            // GraphQL -> email: String! (scalar)
            if (this.Email == null && Exploration.Includes(parent + ".email$"))
            {
                this.Email = new System.String("FETCH");
            }
            //      C# -> System.Int64? LastAccessTime
            // GraphQL -> lastAccessTime: Long! (scalar)
            if (this.LastAccessTime == null && Exploration.Includes(parent + ".lastAccessTime$"))
            {
                this.LastAccessTime = new System.Int64();
            }
            //      C# -> System.Int64? NumActivities
            // GraphQL -> numActivities: Long! (scalar)
            if (this.NumActivities == null && Exploration.Includes(parent + ".numActivities$"))
            {
                this.NumActivities = new System.Int64();
            }
            //      C# -> System.String? SubjectName
            // GraphQL -> subjectName: String! (scalar)
            if (this.SubjectName == null && Exploration.Includes(parent + ".subjectName$"))
            {
                this.SubjectName = new System.String("FETCH");
            }
            //      C# -> System.String? UserSid
            // GraphQL -> userSid: String! (scalar)
            if (this.UserSid == null && Exploration.Includes(parent + ".userSid$"))
            {
                this.UserSid = new System.String("FETCH");
            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username == null && Exploration.Includes(parent + ".username$"))
            {
                this.Username = new System.String("FETCH");
            }
        }


    #endregion

    } // class AccessUser
    #endregion

    public static class ListAccessUserExtensions
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
            this List<AccessUser> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AccessUser> list, 
            String parent = "")
        {
            var item = new AccessUser();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types