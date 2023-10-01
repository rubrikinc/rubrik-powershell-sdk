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
        List<AzureCloudAccountRolePermission>? RolePermissions = null
    ) 
    {
        if ( PermissionVersion != null ) {
            this.PermissionVersion = PermissionVersion;
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
            this List<AzureCloudAccountPermissionConfigResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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