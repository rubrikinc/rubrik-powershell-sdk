// Group.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:59.
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
    #region Group
    public class Group: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? GroupId
            // GraphQL -> groupId: String! (scalar)
            if (this.GroupId != null)
            {
                 s += ind + "groupId\n";

            }
            //      C# -> System.String? GroupName
            // GraphQL -> groupName: String! (scalar)
            if (this.GroupName != null)
            {
                 s += ind + "groupName\n";

            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs != null)
            {
                 s += ind + "allOrgs\n";

                 s += ind + "{\n" + 
                 this.AllOrgs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Role>? Roles
            // GraphQL -> roles: [Role!]! (type)
            if (this.Roles != null)
            {
                 s += ind + "roles\n";

                 s += ind + "{\n" + 
                 this.Roles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<User>? Users
            // GraphQL -> users: [User!]! (type)
            if (this.Users != null)
            {
                 s += ind + "users\n";

                 s += ind + "{\n" + 
                 this.Users.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? GroupId
            // GraphQL -> groupId: String! (scalar)
            if (this.GroupId == null && Exploration.Includes(parent + ".groupId$"))
            {
                this.GroupId = new System.String("FETCH");
            }
            //      C# -> System.String? GroupName
            // GraphQL -> groupName: String! (scalar)
            if (this.GroupName == null && Exploration.Includes(parent + ".groupName$"))
            {
                this.GroupName = new System.String("FETCH");
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> List<Role>? Roles
            // GraphQL -> roles: [Role!]! (type)
            if (this.Roles == null && Exploration.Includes(parent + ".roles"))
            {
                this.Roles = new List<Role>();
                this.Roles.ApplyExploratoryFragment(parent + ".roles");
            }
            //      C# -> List<User>? Users
            // GraphQL -> users: [User!]! (type)
            if (this.Users == null && Exploration.Includes(parent + ".users"))
            {
                this.Users = new List<User>();
                this.Users.ApplyExploratoryFragment(parent + ".users");
            }
        }


    #endregion

    } // class Group
    #endregion

    public static class ListGroupExtensions
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
            this List<Group> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Group> list, 
            String parent = "")
        {
            var item = new Group();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types