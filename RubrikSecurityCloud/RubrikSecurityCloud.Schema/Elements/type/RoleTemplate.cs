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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region RoleTemplate
    public class RoleTemplate: BaseType
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

    public override string GetGqlTypeName() {
        return "RoleTemplate";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<Permission>? ExplicitlyAssignedPermissions
        // GraphQL -> explicitlyAssignedPermissions: [Permission!]! (type)
        if (this.ExplicitlyAssignedPermissions != null) {
            var fspec = this.ExplicitlyAssignedPermissions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "explicitlyAssignedPermissions {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        if (this.Permissions != null) {
            var fspec = this.Permissions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "permissions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> List<Permission>? ExplicitlyAssignedPermissions
        // GraphQL -> explicitlyAssignedPermissions: [Permission!]! (type)
        if (this.ExplicitlyAssignedPermissions == null && Exploration.Includes(parent + ".explicitlyAssignedPermissions"))
        {
            this.ExplicitlyAssignedPermissions = new List<Permission>();
            this.ExplicitlyAssignedPermissions.ApplyExploratoryFieldSpec(parent + ".explicitlyAssignedPermissions");
        }
        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        if (this.Permissions == null && Exploration.Includes(parent + ".permissions"))
        {
            this.Permissions = new List<Permission>();
            this.Permissions.ApplyExploratoryFieldSpec(parent + ".permissions");
        }
    }


    #endregion

    } // class RoleTemplate
    
    #endregion

    public static class ListRoleTemplateExtensions
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
            this List<RoleTemplate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RoleTemplate> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RoleTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types