// AzureRole.cs
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
    #region AzureRole
    public class AzureRole: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsRubrikManaged
        // GraphQL -> isRubrikManaged: Boolean! (scalar)
        [JsonProperty("isRubrikManaged")]
        public System.Boolean? IsRubrikManaged { get; set; }

        //      C# -> System.String? RoleAssignmentName
        // GraphQL -> roleAssignmentName: String! (scalar)
        [JsonProperty("roleAssignmentName")]
        public System.String? RoleAssignmentName { get; set; }

        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: UUID! (scalar)
        [JsonProperty("roleDefinitionId")]
        public System.String? RoleDefinitionId { get; set; }

        //      C# -> System.String? RoleDisplayName
        // GraphQL -> roleDisplayName: String! (scalar)
        [JsonProperty("roleDisplayName")]
        public System.String? RoleDisplayName { get; set; }

        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        [JsonProperty("scope")]
        public System.String? Scope { get; set; }

        #endregion

    #region methods

    public AzureRole Set(
        System.Boolean? IsRubrikManaged = null,
        System.String? RoleAssignmentName = null,
        System.String? RoleDefinitionId = null,
        System.String? RoleDisplayName = null,
        System.String? Scope = null
    ) 
    {
        if ( IsRubrikManaged != null ) {
            this.IsRubrikManaged = IsRubrikManaged;
        }
        if ( RoleAssignmentName != null ) {
            this.RoleAssignmentName = RoleAssignmentName;
        }
        if ( RoleDefinitionId != null ) {
            this.RoleDefinitionId = RoleDefinitionId;
        }
        if ( RoleDisplayName != null ) {
            this.RoleDisplayName = RoleDisplayName;
        }
        if ( Scope != null ) {
            this.Scope = Scope;
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
            //      C# -> System.Boolean? IsRubrikManaged
            // GraphQL -> isRubrikManaged: Boolean! (scalar)
            if (this.IsRubrikManaged != null)
            {
                 s += ind + "isRubrikManaged\n";

            }
            //      C# -> System.String? RoleAssignmentName
            // GraphQL -> roleAssignmentName: String! (scalar)
            if (this.RoleAssignmentName != null)
            {
                 s += ind + "roleAssignmentName\n";

            }
            //      C# -> System.String? RoleDefinitionId
            // GraphQL -> roleDefinitionId: UUID! (scalar)
            if (this.RoleDefinitionId != null)
            {
                 s += ind + "roleDefinitionId\n";

            }
            //      C# -> System.String? RoleDisplayName
            // GraphQL -> roleDisplayName: String! (scalar)
            if (this.RoleDisplayName != null)
            {
                 s += ind + "roleDisplayName\n";

            }
            //      C# -> System.String? Scope
            // GraphQL -> scope: String! (scalar)
            if (this.Scope != null)
            {
                 s += ind + "scope\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsRubrikManaged
            // GraphQL -> isRubrikManaged: Boolean! (scalar)
            if (this.IsRubrikManaged == null && Exploration.Includes(parent + ".isRubrikManaged$"))
            {
                this.IsRubrikManaged = new System.Boolean();
            }
            //      C# -> System.String? RoleAssignmentName
            // GraphQL -> roleAssignmentName: String! (scalar)
            if (this.RoleAssignmentName == null && Exploration.Includes(parent + ".roleAssignmentName$"))
            {
                this.RoleAssignmentName = new System.String("FETCH");
            }
            //      C# -> System.String? RoleDefinitionId
            // GraphQL -> roleDefinitionId: UUID! (scalar)
            if (this.RoleDefinitionId == null && Exploration.Includes(parent + ".roleDefinitionId$"))
            {
                this.RoleDefinitionId = new System.String("FETCH");
            }
            //      C# -> System.String? RoleDisplayName
            // GraphQL -> roleDisplayName: String! (scalar)
            if (this.RoleDisplayName == null && Exploration.Includes(parent + ".roleDisplayName$"))
            {
                this.RoleDisplayName = new System.String("FETCH");
            }
            //      C# -> System.String? Scope
            // GraphQL -> scope: String! (scalar)
            if (this.Scope == null && Exploration.Includes(parent + ".scope$"))
            {
                this.Scope = new System.String("FETCH");
            }
        }


    #endregion

    } // class AzureRole
    #endregion

    public static class ListAzureRoleExtensions
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
            this List<AzureRole> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureRole> list, 
            String parent = "")
        {
            var item = new AzureRole();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types