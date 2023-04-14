// RoleTemplate.cs
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
    #region RoleTemplate
    public class RoleTemplate: IFragment
    {
        #region members
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<Permission>? ExplicitlyAssignedPermissions
        // GraphQL -> explicitlyAssignedPermissions: [Permission!]! (type)
        [JsonProperty("explicitlyAssignedPermissions")]
        public List<Permission>? ExplicitlyAssignedPermissions { get; set; }

        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        [JsonProperty("permissions")]
        public List<Permission>? Permissions { get; set; }

        #endregion

    #region methods

    public RoleTemplate Set(
        System.String? Description = null,
        System.String? Id = null,
        System.String? Name = null,
        List<Permission>? ExplicitlyAssignedPermissions = null,
        List<Permission>? Permissions = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ExplicitlyAssignedPermissions != null ) {
            this.ExplicitlyAssignedPermissions = ExplicitlyAssignedPermissions;
        }
        if ( Permissions != null ) {
            this.Permissions = Permissions;
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
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> List<Permission>? ExplicitlyAssignedPermissions
            // GraphQL -> explicitlyAssignedPermissions: [Permission!]! (type)
            if (this.ExplicitlyAssignedPermissions != null)
            {
                 s += ind + "explicitlyAssignedPermissions\n";

                 s += ind + "{\n" + 
                 this.ExplicitlyAssignedPermissions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Permission>? Permissions
            // GraphQL -> permissions: [Permission!]! (type)
            if (this.Permissions != null)
            {
                 s += ind + "permissions\n";

                 s += ind + "{\n" + 
                 this.Permissions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> List<Permission>? ExplicitlyAssignedPermissions
            // GraphQL -> explicitlyAssignedPermissions: [Permission!]! (type)
            if (this.ExplicitlyAssignedPermissions == null && Exploration.Includes(parent + ".explicitlyAssignedPermissions"))
            {
                this.ExplicitlyAssignedPermissions = new List<Permission>();
                this.ExplicitlyAssignedPermissions.ApplyExploratoryFragment(parent + ".explicitlyAssignedPermissions");
            }
            //      C# -> List<Permission>? Permissions
            // GraphQL -> permissions: [Permission!]! (type)
            if (this.Permissions == null && Exploration.Includes(parent + ".permissions"))
            {
                this.Permissions = new List<Permission>();
                this.Permissions.ApplyExploratoryFragment(parent + ".permissions");
            }
        }


    #endregion

    } // class RoleTemplate
    #endregion

    public static class ListRoleTemplateExtensions
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
            this List<RoleTemplate> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RoleTemplate> list, 
            String parent = "")
        {
            var item = new RoleTemplate();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types