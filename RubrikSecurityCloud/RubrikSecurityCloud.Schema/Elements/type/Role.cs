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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region Role
    public class Role: BaseType
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

        //      C# -> List<RbacPermission>? EffectiveRbacPermissions
        // GraphQL -> effectiveRbacPermissions: [RbacPermission!]! (type)
        [JsonProperty("effectiveRbacPermissions")]
        public List<RbacPermission>? EffectiveRbacPermissions { get; set; }

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
        return "Role";
    }

    public Role Set(
        System.String? Description = null,
        System.String? Id = null,
        System.Boolean? IsOrgAdmin = null,
        System.Boolean? IsReadOnly = null,
        System.String? Name = null,
        System.String? OrgId = null,
        List<System.String>? ProtectableClusters = null,
        List<Permission>? EffectivePermissions = null,
        List<RbacPermission>? EffectiveRbacPermissions = null,
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
        if ( EffectiveRbacPermissions != null ) {
            this.EffectiveRbacPermissions = EffectiveRbacPermissions;
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
        //      C# -> System.Boolean? IsOrgAdmin
        // GraphQL -> isOrgAdmin: Boolean! (scalar)
        if (this.IsOrgAdmin != null) {
            s += ind + "isOrgAdmin\n" ;
        }
        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        if (this.IsReadOnly != null) {
            s += ind + "isReadOnly\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> List<System.String>? ProtectableClusters
        // GraphQL -> protectableClusters: [String!]! (scalar)
        if (this.ProtectableClusters != null) {
            s += ind + "protectableClusters\n" ;
        }
        //      C# -> List<Permission>? EffectivePermissions
        // GraphQL -> effectivePermissions: [Permission!]! (type)
        if (this.EffectivePermissions != null) {
            var fspec = this.EffectivePermissions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectivePermissions {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<RbacPermission>? EffectiveRbacPermissions
        // GraphQL -> effectiveRbacPermissions: [RbacPermission!]! (type)
        if (this.EffectiveRbacPermissions != null) {
            var fspec = this.EffectiveRbacPermissions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveRbacPermissions {\n" + fspec + ind + "}\n" ;
            }
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsOrgAdmin
        // GraphQL -> isOrgAdmin: Boolean! (scalar)
        if (this.IsOrgAdmin == null && ec.Includes("isOrgAdmin",true))
        {
            this.IsOrgAdmin = true;
        }
        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        if (this.IsReadOnly == null && ec.Includes("isReadOnly",true))
        {
            this.IsReadOnly = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId == null && ec.Includes("orgId",true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> List<System.String>? ProtectableClusters
        // GraphQL -> protectableClusters: [String!]! (scalar)
        if (this.ProtectableClusters == null && ec.Includes("protectableClusters",true))
        {
            this.ProtectableClusters = new List<System.String>();
        }
        //      C# -> List<Permission>? EffectivePermissions
        // GraphQL -> effectivePermissions: [Permission!]! (type)
        if (this.EffectivePermissions == null && ec.Includes("effectivePermissions",false))
        {
            this.EffectivePermissions = new List<Permission>();
            this.EffectivePermissions.ApplyExploratoryFieldSpec(ec.NewChild("effectivePermissions"));
        }
        //      C# -> List<RbacPermission>? EffectiveRbacPermissions
        // GraphQL -> effectiveRbacPermissions: [RbacPermission!]! (type)
        if (this.EffectiveRbacPermissions == null && ec.Includes("effectiveRbacPermissions",false))
        {
            this.EffectiveRbacPermissions = new List<RbacPermission>();
            this.EffectiveRbacPermissions.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRbacPermissions"));
        }
        //      C# -> List<Permission>? ExplicitlyAssignedPermissions
        // GraphQL -> explicitlyAssignedPermissions: [Permission!]! (type)
        if (this.ExplicitlyAssignedPermissions == null && ec.Includes("explicitlyAssignedPermissions",false))
        {
            this.ExplicitlyAssignedPermissions = new List<Permission>();
            this.ExplicitlyAssignedPermissions.ApplyExploratoryFieldSpec(ec.NewChild("explicitlyAssignedPermissions"));
        }
        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        if (this.Permissions == null && ec.Includes("permissions",false))
        {
            this.Permissions = new List<Permission>();
            this.Permissions.ApplyExploratoryFieldSpec(ec.NewChild("permissions"));
        }
    }


    #endregion

    } // class Role
    
    #endregion

    public static class ListRoleExtensions
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
            this List<Role> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Role> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Role());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<Role> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types