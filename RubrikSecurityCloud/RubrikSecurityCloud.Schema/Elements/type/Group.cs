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

        //      C# -> List<User>? ActiveUsers
        // GraphQL -> activeUsers: [User!]! (type)
        [JsonProperty("activeUsers")]
        public List<User>? ActiveUsers { get; set; }

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
        List<User>? ActiveUsers = null,
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
        if ( ActiveUsers != null ) {
            this.ActiveUsers = ActiveUsers;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        if (this.GroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupId\n" ;
            } else {
                s += ind + "groupId\n" ;
            }
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupName\n" ;
            } else {
                s += ind + "groupName\n" ;
            }
        }
        //      C# -> List<User>? ActiveUsers
        // GraphQL -> activeUsers: [User!]! (type)
        if (this.ActiveUsers != null) {
            var fspec = this.ActiveUsers.AsFieldSpec(conf.Child("activeUsers"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activeUsers" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(conf.Child("allOrgs"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(conf.Child("roles"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "roles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<User>? Users
        // GraphQL -> users: [User!]! (type)
        if (this.Users != null) {
            var fspec = this.Users.AsFieldSpec(conf.Child("users"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "users" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        if (ec.Includes("groupId",true))
        {
            if(this.GroupId == null) {

                this.GroupId = "FETCH";

            } else {


            }
        }
        else if (this.GroupId != null && ec.Excludes("groupId",true))
        {
            this.GroupId = null;
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (ec.Includes("groupName",true))
        {
            if(this.GroupName == null) {

                this.GroupName = "FETCH";

            } else {


            }
        }
        else if (this.GroupName != null && ec.Excludes("groupName",true))
        {
            this.GroupName = null;
        }
        //      C# -> List<User>? ActiveUsers
        // GraphQL -> activeUsers: [User!]! (type)
        if (ec.Includes("activeUsers",false))
        {
            if(this.ActiveUsers == null) {

                this.ActiveUsers = new List<User>();
                this.ActiveUsers.ApplyExploratoryFieldSpec(ec.NewChild("activeUsers"));

            } else {

                this.ActiveUsers.ApplyExploratoryFieldSpec(ec.NewChild("activeUsers"));

            }
        }
        else if (this.ActiveUsers != null && ec.Excludes("activeUsers",false))
        {
            this.ActiveUsers = null;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (ec.Includes("allOrgs",false))
        {
            if(this.AllOrgs == null) {

                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            } else {

                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            }
        }
        else if (this.AllOrgs != null && ec.Excludes("allOrgs",false))
        {
            this.AllOrgs = null;
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (ec.Includes("roles",false))
        {
            if(this.Roles == null) {

                this.Roles = new List<Role>();
                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            } else {

                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            }
        }
        else if (this.Roles != null && ec.Excludes("roles",false))
        {
            this.Roles = null;
        }
        //      C# -> List<User>? Users
        // GraphQL -> users: [User!]! (type)
        if (ec.Includes("users",false))
        {
            if(this.Users == null) {

                this.Users = new List<User>();
                this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));

            } else {

                this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));

            }
        }
        else if (this.Users != null && ec.Excludes("users",false))
        {
            this.Users = null;
        }
    }


    #endregion

    } // class Group
    
    #endregion

    public static class ListGroupExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<Group> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Group> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<Group> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types