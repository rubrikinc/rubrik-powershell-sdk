// Group.cs
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
    #region Group
    public class Group: BaseType
    {
        #region members

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        [JsonProperty("groupName")]
        public System.String? GroupName { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        [JsonProperty("roles")]
        public List<Role>? Roles { get; set; }

        //      C# -> List<User>? Users
        // GraphQL -> users: [User!]! (type)
        [JsonProperty("users")]
        public List<User>? Users { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Group";
    }

    public Group Set(
        System.String? GroupId = null,
        System.String? GroupName = null,
        List<Org>? AllOrgs = null,
        List<Role>? Roles = null,
        List<User>? Users = null
    ) 
    {
        if ( GroupId != null ) {
            this.GroupId = GroupId;
        }
        if ( GroupName != null ) {
            this.GroupName = GroupName;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( Roles != null ) {
            this.Roles = Roles;
        }
        if ( Users != null ) {
            this.Users = Users;
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
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        if (this.GroupId != null) {
            s += ind + "groupId\n" ;
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName != null) {
            s += ind + "groupName\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "roles {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<User>? Users
        // GraphQL -> users: [User!]! (type)
        if (this.Users != null) {
            var fspec = this.Users.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "users {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        if (this.GroupId == null && ec.Includes("groupId",true))
        {
            this.GroupId = "FETCH";
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName == null && ec.Includes("groupName",true))
        {
            this.GroupName = "FETCH";
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && ec.Includes("allOrgs",false))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles == null && ec.Includes("roles",false))
        {
            this.Roles = new List<Role>();
            this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));
        }
        //      C# -> List<User>? Users
        // GraphQL -> users: [User!]! (type)
        if (this.Users == null && ec.Includes("users",false))
        {
            this.Users = new List<User>();
            this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));
        }
    }


    #endregion

    } // class Group
    
    #endregion

    public static class ListGroupExtensions
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
            this List<Group> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Group> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Group());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<Group> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types