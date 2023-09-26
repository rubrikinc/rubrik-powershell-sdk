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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "AccessUser";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? ActivityDelta
        // GraphQL -> activityDelta: Long! (scalar)
        if (this.ActivityDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activityDelta\n" ;
            } else {
                s += ind + "activityDelta\n" ;
            }
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email != null) {
            if (conf.Flat) {
                s += conf.Prefix + "email\n" ;
            } else {
                s += ind + "email\n" ;
            }
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (this.LastAccessTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastAccessTime\n" ;
            } else {
                s += ind + "lastAccessTime\n" ;
            }
        }
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (this.NumActivities != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numActivities\n" ;
            } else {
                s += ind + "numActivities\n" ;
            }
        }
        //      C# -> System.String? SubjectName
        // GraphQL -> subjectName: String! (scalar)
        if (this.SubjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subjectName\n" ;
            } else {
                s += ind + "subjectName\n" ;
            }
        }
        //      C# -> System.String? UserSid
        // GraphQL -> userSid: String! (scalar)
        if (this.UserSid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userSid\n" ;
            } else {
                s += ind + "userSid\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ActivityDelta
        // GraphQL -> activityDelta: Long! (scalar)
        if (ec.Includes("activityDelta",true))
        {
            if(this.ActivityDelta == null) {

                this.ActivityDelta = new System.Int64();

            } else {


            }
        }
        else if (this.ActivityDelta != null && ec.Excludes("activityDelta",true))
        {
            this.ActivityDelta = null;
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (ec.Includes("email",true))
        {
            if(this.Email == null) {

                this.Email = "FETCH";

            } else {


            }
        }
        else if (this.Email != null && ec.Excludes("email",true))
        {
            this.Email = null;
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (ec.Includes("lastAccessTime",true))
        {
            if(this.LastAccessTime == null) {

                this.LastAccessTime = new System.Int64();

            } else {


            }
        }
        else if (this.LastAccessTime != null && ec.Excludes("lastAccessTime",true))
        {
            this.LastAccessTime = null;
        }
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (ec.Includes("numActivities",true))
        {
            if(this.NumActivities == null) {

                this.NumActivities = new System.Int64();

            } else {


            }
        }
        else if (this.NumActivities != null && ec.Excludes("numActivities",true))
        {
            this.NumActivities = null;
        }
        //      C# -> System.String? SubjectName
        // GraphQL -> subjectName: String! (scalar)
        if (ec.Includes("subjectName",true))
        {
            if(this.SubjectName == null) {

                this.SubjectName = "FETCH";

            } else {


            }
        }
        else if (this.SubjectName != null && ec.Excludes("subjectName",true))
        {
            this.SubjectName = null;
        }
        //      C# -> System.String? UserSid
        // GraphQL -> userSid: String! (scalar)
        if (ec.Includes("userSid",true))
        {
            if(this.UserSid == null) {

                this.UserSid = "FETCH";

            } else {


            }
        }
        else if (this.UserSid != null && ec.Excludes("userSid",true))
        {
            this.UserSid = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AccessUser> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AccessUser());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AccessUser> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types