// AzureCloudAccountPermissionConfigResponse.cs
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
    #region AzureCloudAccountPermissionConfigResponse
    public class AzureCloudAccountPermissionConfigResponse: BaseType
    {
        #region members

        //      C# -> System.Int32? PermissionVersion
        // GraphQL -> permissionVersion: Int! (scalar)
        [JsonProperty("permissionVersion")]
        public System.Int32? PermissionVersion { get; set; }

        //      C# -> List<PermissionsGroupWithVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [PermissionsGroupWithVersion!]! (type)
        [JsonProperty("permissionsGroupVersions")]
        public List<PermissionsGroupWithVersion>? PermissionsGroupVersions { get; set; }

        //      C# -> List<AzureCloudAccountRolePermission>? ResourceGroupRolePermissions
        // GraphQL -> resourceGroupRolePermissions: [AzureCloudAccountRolePermission!]! (type)
        [JsonProperty("resourceGroupRolePermissions")]
        public List<AzureCloudAccountRolePermission>? ResourceGroupRolePermissions { get; set; }

        //      C# -> List<AzureCloudAccountRolePermission>? RolePermissions
        // GraphQL -> rolePermissions: [AzureCloudAccountRolePermission!]! (type)
        [JsonProperty("rolePermissions")]
        public List<AzureCloudAccountRolePermission>? RolePermissions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCloudAccountPermissionConfigResponse";
    }

    public AzureCloudAccountPermissionConfigResponse Set(
        System.Int32? PermissionVersion = null,
        List<PermissionsGroupWithVersion>? PermissionsGroupVersions = null,
        List<AzureCloudAccountRolePermission>? ResourceGroupRolePermissions = null,
        List<AzureCloudAccountRolePermission>? RolePermissions = null
    ) 
    {
        if ( PermissionVersion != null ) {
            this.PermissionVersion = PermissionVersion;
        }
        if ( PermissionsGroupVersions != null ) {
            this.PermissionsGroupVersions = PermissionsGroupVersions;
        }
        if ( ResourceGroupRolePermissions != null ) {
            this.ResourceGroupRolePermissions = ResourceGroupRolePermissions;
        }
        if ( RolePermissions != null ) {
            this.RolePermissions = RolePermissions;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? PermissionVersion
        // GraphQL -> permissionVersion: Int! (scalar)
        if (this.PermissionVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionVersion\n" ;
            } else {
                s += ind + "permissionVersion\n" ;
            }
        }
        //      C# -> List<PermissionsGroupWithVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [PermissionsGroupWithVersion!]! (type)
        if (this.PermissionsGroupVersions != null) {
            var fspec = this.PermissionsGroupVersions.AsFieldSpec(conf.Child("permissionsGroupVersions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "permissionsGroupVersions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AzureCloudAccountRolePermission>? ResourceGroupRolePermissions
        // GraphQL -> resourceGroupRolePermissions: [AzureCloudAccountRolePermission!]! (type)
        if (this.ResourceGroupRolePermissions != null) {
            var fspec = this.ResourceGroupRolePermissions.AsFieldSpec(conf.Child("resourceGroupRolePermissions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resourceGroupRolePermissions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AzureCloudAccountRolePermission>? RolePermissions
        // GraphQL -> rolePermissions: [AzureCloudAccountRolePermission!]! (type)
        if (this.RolePermissions != null) {
            var fspec = this.RolePermissions.AsFieldSpec(conf.Child("rolePermissions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rolePermissions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? PermissionVersion
        // GraphQL -> permissionVersion: Int! (scalar)
        if (ec.Includes("permissionVersion",true))
        {
            if(this.PermissionVersion == null) {

                this.PermissionVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.PermissionVersion != null && ec.Excludes("permissionVersion",true))
        {
            this.PermissionVersion = null;
        }
        //      C# -> List<PermissionsGroupWithVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [PermissionsGroupWithVersion!]! (type)
        if (ec.Includes("permissionsGroupVersions",false))
        {
            if(this.PermissionsGroupVersions == null) {

                this.PermissionsGroupVersions = new List<PermissionsGroupWithVersion>();
                this.PermissionsGroupVersions.ApplyExploratoryFieldSpec(ec.NewChild("permissionsGroupVersions"));

            } else {

                this.PermissionsGroupVersions.ApplyExploratoryFieldSpec(ec.NewChild("permissionsGroupVersions"));

            }
        }
        else if (this.PermissionsGroupVersions != null && ec.Excludes("permissionsGroupVersions",false))
        {
            this.PermissionsGroupVersions = null;
        }
        //      C# -> List<AzureCloudAccountRolePermission>? ResourceGroupRolePermissions
        // GraphQL -> resourceGroupRolePermissions: [AzureCloudAccountRolePermission!]! (type)
        if (ec.Includes("resourceGroupRolePermissions",false))
        {
            if(this.ResourceGroupRolePermissions == null) {

                this.ResourceGroupRolePermissions = new List<AzureCloudAccountRolePermission>();
                this.ResourceGroupRolePermissions.ApplyExploratoryFieldSpec(ec.NewChild("resourceGroupRolePermissions"));

            } else {

                this.ResourceGroupRolePermissions.ApplyExploratoryFieldSpec(ec.NewChild("resourceGroupRolePermissions"));

            }
        }
        else if (this.ResourceGroupRolePermissions != null && ec.Excludes("resourceGroupRolePermissions",false))
        {
            this.ResourceGroupRolePermissions = null;
        }
        //      C# -> List<AzureCloudAccountRolePermission>? RolePermissions
        // GraphQL -> rolePermissions: [AzureCloudAccountRolePermission!]! (type)
        if (ec.Includes("rolePermissions",false))
        {
            if(this.RolePermissions == null) {

                this.RolePermissions = new List<AzureCloudAccountRolePermission>();
                this.RolePermissions.ApplyExploratoryFieldSpec(ec.NewChild("rolePermissions"));

            } else {

                this.RolePermissions.ApplyExploratoryFieldSpec(ec.NewChild("rolePermissions"));

            }
        }
        else if (this.RolePermissions != null && ec.Excludes("rolePermissions",false))
        {
            this.RolePermissions = null;
        }
    }


    #endregion

    } // class AzureCloudAccountPermissionConfigResponse
    
    #endregion

    public static class ListAzureCloudAccountPermissionConfigResponseExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureCloudAccountPermissionConfigResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureCloudAccountPermissionConfigResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountPermissionConfigResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountPermissionConfigResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCloudAccountPermissionConfigResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types