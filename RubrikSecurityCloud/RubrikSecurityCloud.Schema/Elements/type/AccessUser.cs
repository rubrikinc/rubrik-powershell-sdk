// AccessUser.cs
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
    #region AccessUser
    public class AccessUser: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? ActivityDelta
        // GraphQL -> activityDelta: Long! (scalar)
        if (this.ActivityDelta != null) {
            s += ind + "activityDelta\n" ;
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email != null) {
            s += ind + "email\n" ;
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (this.LastAccessTime != null) {
            s += ind + "lastAccessTime\n" ;
        }
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (this.NumActivities != null) {
            s += ind + "numActivities\n" ;
        }
        //      C# -> System.String? SubjectName
        // GraphQL -> subjectName: String! (scalar)
        if (this.SubjectName != null) {
            s += ind + "subjectName\n" ;
        }
        //      C# -> System.String? UserSid
        // GraphQL -> userSid: String! (scalar)
        if (this.UserSid != null) {
            s += ind + "userSid\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ActivityDelta
        // GraphQL -> activityDelta: Long! (scalar)
        if (this.ActivityDelta == null && Exploration.Includes(parent + ".activityDelta", true))
        {
            this.ActivityDelta = new System.Int64();
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email == null && Exploration.Includes(parent + ".email", true))
        {
            this.Email = new System.String("FETCH");
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (this.LastAccessTime == null && Exploration.Includes(parent + ".lastAccessTime", true))
        {
            this.LastAccessTime = new System.Int64();
        }
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (this.NumActivities == null && Exploration.Includes(parent + ".numActivities", true))
        {
            this.NumActivities = new System.Int64();
        }
        //      C# -> System.String? SubjectName
        // GraphQL -> subjectName: String! (scalar)
        if (this.SubjectName == null && Exploration.Includes(parent + ".subjectName", true))
        {
            this.SubjectName = new System.String("FETCH");
        }
        //      C# -> System.String? UserSid
        // GraphQL -> userSid: String! (scalar)
        if (this.UserSid == null && Exploration.Includes(parent + ".userSid", true))
        {
            this.UserSid = new System.String("FETCH");
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = new System.String("FETCH");
        }
    }


    #endregion

    } // class AccessUser
    
    #endregion

    public static class ListAccessUserExtensions
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
            this List<AccessUser> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AccessUser> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AccessUser());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types