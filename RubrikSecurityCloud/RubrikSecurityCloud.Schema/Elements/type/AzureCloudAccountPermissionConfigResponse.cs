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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? PermissionVersion
        // GraphQL -> permissionVersion: Int! (scalar)
        if (this.PermissionVersion != null) {
            s += ind + "permissionVersion\n" ;
        }
        //      C# -> List<AzureCloudAccountRolePermission>? RolePermissions
        // GraphQL -> rolePermissions: [AzureCloudAccountRolePermission!]! (type)
        if (this.RolePermissions != null) {
            var fspec = this.RolePermissions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "rolePermissions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? PermissionVersion
        // GraphQL -> permissionVersion: Int! (scalar)
        if (this.PermissionVersion == null && Exploration.Includes(parent + ".permissionVersion", true))
        {
            this.PermissionVersion = Int32.MinValue;
        }
        //      C# -> List<AzureCloudAccountRolePermission>? RolePermissions
        // GraphQL -> rolePermissions: [AzureCloudAccountRolePermission!]! (type)
        if (this.RolePermissions == null && Exploration.Includes(parent + ".rolePermissions"))
        {
            this.RolePermissions = new List<AzureCloudAccountRolePermission>();
            this.RolePermissions.ApplyExploratoryFieldSpec(parent + ".rolePermissions");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountPermissionConfigResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountPermissionConfigResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types