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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region UserActivityResult
    public class UserActivityResult: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (this.NumActivities != null) {
            s += ind + "numActivities\n" ;
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId != null) {
            s += ind + "paginationId\n" ;
        }
        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        if (this.NumActivitiesBreakdown != null) {
            s += ind + "numActivitiesBreakdown {\n" + this.NumActivitiesBreakdown.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AccessUser? User
        // GraphQL -> user: AccessUser (type)
        if (this.User != null) {
            s += ind + "user {\n" + this.User.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (this.NumActivities == null && Exploration.Includes(parent + ".numActivities", true))
        {
            this.NumActivities = new System.Int64();
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId == null && Exploration.Includes(parent + ".paginationId", true))
        {
            this.PaginationId = "FETCH";
        }
        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        if (this.NumActivitiesBreakdown == null && Exploration.Includes(parent + ".numActivitiesBreakdown"))
        {
            this.NumActivitiesBreakdown = new List<ActivityResult>();
            this.NumActivitiesBreakdown.ApplyExploratoryFieldSpec(parent + ".numActivitiesBreakdown");
        }
        //      C# -> AccessUser? User
        // GraphQL -> user: AccessUser (type)
        if (this.User == null && Exploration.Includes(parent + ".user"))
        {
            this.User = new AccessUser();
            this.User.ApplyExploratoryFieldSpec(parent + ".user");
        }
    }


    #endregion

    } // class UserActivityResult
    
    #endregion

    public static class ListUserActivityResultExtensions
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
            this List<UserActivityResult> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserActivityResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UserActivityResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types