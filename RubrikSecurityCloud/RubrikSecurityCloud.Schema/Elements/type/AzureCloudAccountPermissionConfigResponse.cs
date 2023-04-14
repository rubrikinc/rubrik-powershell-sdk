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

namespace Rubrik.SecurityCloud.Types
{
    #region AzureCloudAccountPermissionConfigResponse
    public class AzureCloudAccountPermissionConfigResponse: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? PermissionVersion
            // GraphQL -> permissionVersion: Int! (scalar)
            if (this.PermissionVersion != null)
            {
                 s += ind + "permissionVersion\n";

            }
            //      C# -> List<AzureCloudAccountRolePermission>? RolePermissions
            // GraphQL -> rolePermissions: [AzureCloudAccountRolePermission!]! (type)
            if (this.RolePermissions != null)
            {
                 s += ind + "rolePermissions\n";

                 s += ind + "{\n" + 
                 this.RolePermissions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? PermissionVersion
            // GraphQL -> permissionVersion: Int! (scalar)
            if (this.PermissionVersion == null && Exploration.Includes(parent + ".permissionVersion$"))
            {
                this.PermissionVersion = new System.Int32();
            }
            //      C# -> List<AzureCloudAccountRolePermission>? RolePermissions
            // GraphQL -> rolePermissions: [AzureCloudAccountRolePermission!]! (type)
            if (this.RolePermissions == null && Exploration.Includes(parent + ".rolePermissions"))
            {
                this.RolePermissions = new List<AzureCloudAccountRolePermission>();
                this.RolePermissions.ApplyExploratoryFragment(parent + ".rolePermissions");
            }
        }


    #endregion

    } // class AzureCloudAccountPermissionConfigResponse
    #endregion

    public static class ListAzureCloudAccountPermissionConfigResponseExtensions
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
            this List<AzureCloudAccountPermissionConfigResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureCloudAccountPermissionConfigResponse> list, 
            String parent = "")
        {
            var item = new AzureCloudAccountPermissionConfigResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types