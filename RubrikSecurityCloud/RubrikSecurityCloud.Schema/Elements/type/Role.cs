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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsOrgAdmin
        // GraphQL -> isOrgAdmin: Boolean! (scalar)
        if (this.IsOrgAdmin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOrgAdmin\n" ;
            } else {
                s += ind + "isOrgAdmin\n" ;
            }
        }
        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        if (this.IsReadOnly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReadOnly\n" ;
            } else {
                s += ind + "isReadOnly\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> List<System.String>? ProtectableClusters
        // GraphQL -> protectableClusters: [String!]! (scalar)
        if (this.ProtectableClusters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectableClusters\n" ;
            } else {
                s += ind + "protectableClusters\n" ;
            }
        }
        //      C# -> List<Permission>? EffectivePermissions
        // GraphQL -> effectivePermissions: [Permission!]! (type)
        if (this.EffectivePermissions != null) {
            var fspec = this.EffectivePermissions.AsFieldSpec(conf.Child("effectivePermissions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectivePermissions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RbacPermission>? EffectiveRbacPermissions
        // GraphQL -> effectiveRbacPermissions: [RbacPermission!]! (type)
        if (this.EffectiveRbacPermissions != null) {
            var fspec = this.EffectiveRbacPermissions.AsFieldSpec(conf.Child("effectiveRbacPermissions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveRbacPermissions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Permission>? ExplicitlyAssignedPermissions
        // GraphQL -> explicitlyAssignedPermissions: [Permission!]! (type)
        if (this.ExplicitlyAssignedPermissions != null) {
            var fspec = this.ExplicitlyAssignedPermissions.AsFieldSpec(conf.Child("explicitlyAssignedPermissions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "explicitlyAssignedPermissions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        if (this.Permissions != null) {
            var fspec = this.Permissions.AsFieldSpec(conf.Child("permissions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "permissions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsOrgAdmin
        // GraphQL -> isOrgAdmin: Boolean! (scalar)
        if (ec.Includes("isOrgAdmin",true))
        {
            if(this.IsOrgAdmin == null) {

                this.IsOrgAdmin = true;

            } else {


            }
        }
        else if (this.IsOrgAdmin != null && ec.Excludes("isOrgAdmin",true))
        {
            this.IsOrgAdmin = null;
        }
        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        if (ec.Includes("isReadOnly",true))
        {
            if(this.IsReadOnly == null) {

                this.IsReadOnly = true;

            } else {


            }
        }
        else if (this.IsReadOnly != null && ec.Excludes("isReadOnly",true))
        {
            this.IsReadOnly = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> List<System.String>? ProtectableClusters
        // GraphQL -> protectableClusters: [String!]! (scalar)
        if (ec.Includes("protectableClusters",true))
        {
            if(this.ProtectableClusters == null) {

                this.ProtectableClusters = new List<System.String>();

            } else {


            }
        }
        else if (this.ProtectableClusters != null && ec.Excludes("protectableClusters",true))
        {
            this.ProtectableClusters = null;
        }
        //      C# -> List<Permission>? EffectivePermissions
        // GraphQL -> effectivePermissions: [Permission!]! (type)
        if (ec.Includes("effectivePermissions",false))
        {
            if(this.EffectivePermissions == null) {

                this.EffectivePermissions = new List<Permission>();
                this.EffectivePermissions.ApplyExploratoryFieldSpec(ec.NewChild("effectivePermissions"));

            } else {

                this.EffectivePermissions.ApplyExploratoryFieldSpec(ec.NewChild("effectivePermissions"));

            }
        }
        else if (this.EffectivePermissions != null && ec.Excludes("effectivePermissions",false))
        {
            this.EffectivePermissions = null;
        }
        //      C# -> List<RbacPermission>? EffectiveRbacPermissions
        // GraphQL -> effectiveRbacPermissions: [RbacPermission!]! (type)
        if (ec.Includes("effectiveRbacPermissions",false))
        {
            if(this.EffectiveRbacPermissions == null) {

                this.EffectiveRbacPermissions = new List<RbacPermission>();
                this.EffectiveRbacPermissions.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRbacPermissions"));

            } else {

                this.EffectiveRbacPermissions.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRbacPermissions"));

            }
        }
        else if (this.EffectiveRbacPermissions != null && ec.Excludes("effectiveRbacPermissions",false))
        {
            this.EffectiveRbacPermissions = null;
        }
        //      C# -> List<Permission>? ExplicitlyAssignedPermissions
        // GraphQL -> explicitlyAssignedPermissions: [Permission!]! (type)
        if (ec.Includes("explicitlyAssignedPermissions",false))
        {
            if(this.ExplicitlyAssignedPermissions == null) {

                this.ExplicitlyAssignedPermissions = new List<Permission>();
                this.ExplicitlyAssignedPermissions.ApplyExploratoryFieldSpec(ec.NewChild("explicitlyAssignedPermissions"));

            } else {

                this.ExplicitlyAssignedPermissions.ApplyExploratoryFieldSpec(ec.NewChild("explicitlyAssignedPermissions"));

            }
        }
        else if (this.ExplicitlyAssignedPermissions != null && ec.Excludes("explicitlyAssignedPermissions",false))
        {
            this.ExplicitlyAssignedPermissions = null;
        }
        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        if (ec.Includes("permissions",false))
        {
            if(this.Permissions == null) {

                this.Permissions = new List<Permission>();
                this.Permissions.ApplyExploratoryFieldSpec(ec.NewChild("permissions"));

            } else {

                this.Permissions.ApplyExploratoryFieldSpec(ec.NewChild("permissions"));

            }
        }
        else if (this.Permissions != null && ec.Excludes("permissions",false))
        {
            this.Permissions = null;
        }
    }


    #endregion

    } // class Role
    
    #endregion

    public static class ListRoleExtensions
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
            this List<Role> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Role> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<Role> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types