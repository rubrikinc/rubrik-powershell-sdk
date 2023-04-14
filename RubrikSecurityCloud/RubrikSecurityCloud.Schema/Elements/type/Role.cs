// Role.cs
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
    #region Role
    public class Role: IFragment
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

        //      C# -> System.Boolean? IsOrgAdmin
        // GraphQL -> isOrgAdmin: Boolean! (scalar)
        [JsonProperty("isOrgAdmin")]
        public System.Boolean? IsOrgAdmin { get; set; }

        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        [JsonProperty("isReadOnly")]
        public System.Boolean? IsReadOnly { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> List<System.String>? ProtectableClusters
        // GraphQL -> protectableClusters: [String!]! (scalar)
        [JsonProperty("protectableClusters")]
        public List<System.String>? ProtectableClusters { get; set; }

        //      C# -> List<Permission>? EffectivePermissions
        // GraphQL -> effectivePermissions: [Permission!]! (type)
        [JsonProperty("effectivePermissions")]
        public List<Permission>? EffectivePermissions { get; set; }

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

    public Role Set(
        System.String? Description = null,
        System.String? Id = null,
        System.Boolean? IsOrgAdmin = null,
        System.Boolean? IsReadOnly = null,
        System.String? Name = null,
        System.String? OrgId = null,
        List<System.String>? ProtectableClusters = null,
        List<Permission>? EffectivePermissions = null,
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
        if ( IsOrgAdmin != null ) {
            this.IsOrgAdmin = IsOrgAdmin;
        }
        if ( IsReadOnly != null ) {
            this.IsReadOnly = IsReadOnly;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( ProtectableClusters != null ) {
            this.ProtectableClusters = ProtectableClusters;
        }
        if ( EffectivePermissions != null ) {
            this.EffectivePermissions = EffectivePermissions;
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
            //      C# -> System.Boolean? IsOrgAdmin
            // GraphQL -> isOrgAdmin: Boolean! (scalar)
            if (this.IsOrgAdmin != null)
            {
                 s += ind + "isOrgAdmin\n";

            }
            //      C# -> System.Boolean? IsReadOnly
            // GraphQL -> isReadOnly: Boolean! (scalar)
            if (this.IsReadOnly != null)
            {
                 s += ind + "isReadOnly\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId != null)
            {
                 s += ind + "orgId\n";

            }
            //      C# -> List<System.String>? ProtectableClusters
            // GraphQL -> protectableClusters: [String!]! (scalar)
            if (this.ProtectableClusters != null)
            {
                 s += ind + "protectableClusters\n";

            }
            //      C# -> List<Permission>? EffectivePermissions
            // GraphQL -> effectivePermissions: [Permission!]! (type)
            if (this.EffectivePermissions != null)
            {
                 s += ind + "effectivePermissions\n";

                 s += ind + "{\n" + 
                 this.EffectivePermissions.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> System.Boolean? IsOrgAdmin
            // GraphQL -> isOrgAdmin: Boolean! (scalar)
            if (this.IsOrgAdmin == null && Exploration.Includes(parent + ".isOrgAdmin$"))
            {
                this.IsOrgAdmin = new System.Boolean();
            }
            //      C# -> System.Boolean? IsReadOnly
            // GraphQL -> isReadOnly: Boolean! (scalar)
            if (this.IsReadOnly == null && Exploration.Includes(parent + ".isReadOnly$"))
            {
                this.IsReadOnly = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId == null && Exploration.Includes(parent + ".orgId$"))
            {
                this.OrgId = new System.String("FETCH");
            }
            //      C# -> List<System.String>? ProtectableClusters
            // GraphQL -> protectableClusters: [String!]! (scalar)
            if (this.ProtectableClusters == null && Exploration.Includes(parent + ".protectableClusters$"))
            {
                this.ProtectableClusters = new List<System.String>();
            }
            //      C# -> List<Permission>? EffectivePermissions
            // GraphQL -> effectivePermissions: [Permission!]! (type)
            if (this.EffectivePermissions == null && Exploration.Includes(parent + ".effectivePermissions"))
            {
                this.EffectivePermissions = new List<Permission>();
                this.EffectivePermissions.ApplyExploratoryFragment(parent + ".effectivePermissions");
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

    } // class Role
    #endregion

    public static class ListRoleExtensions
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
            this List<Role> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Role> list, 
            String parent = "")
        {
            var item = new Role();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types