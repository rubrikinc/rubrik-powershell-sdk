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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureRole
    public class AzureRole: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? IsRubrikManaged
        // GraphQL -> isRubrikManaged: Boolean! (scalar)
        if (this.IsRubrikManaged != null) {
            s += ind + "isRubrikManaged\n" ;
        }
        //      C# -> System.String? RoleAssignmentName
        // GraphQL -> roleAssignmentName: String! (scalar)
        if (this.RoleAssignmentName != null) {
            s += ind + "roleAssignmentName\n" ;
        }
        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: UUID! (scalar)
        if (this.RoleDefinitionId != null) {
            s += ind + "roleDefinitionId\n" ;
        }
        //      C# -> System.String? RoleDisplayName
        // GraphQL -> roleDisplayName: String! (scalar)
        if (this.RoleDisplayName != null) {
            s += ind + "roleDisplayName\n" ;
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        if (this.Scope != null) {
            s += ind + "scope\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsRubrikManaged
        // GraphQL -> isRubrikManaged: Boolean! (scalar)
        if (this.IsRubrikManaged == null && Exploration.Includes(parent + ".isRubrikManaged", true))
        {
            this.IsRubrikManaged = true;
        }
        //      C# -> System.String? RoleAssignmentName
        // GraphQL -> roleAssignmentName: String! (scalar)
        if (this.RoleAssignmentName == null && Exploration.Includes(parent + ".roleAssignmentName", true))
        {
            this.RoleAssignmentName = new System.String("FETCH");
        }
        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: UUID! (scalar)
        if (this.RoleDefinitionId == null && Exploration.Includes(parent + ".roleDefinitionId", true))
        {
            this.RoleDefinitionId = new System.String("FETCH");
        }
        //      C# -> System.String? RoleDisplayName
        // GraphQL -> roleDisplayName: String! (scalar)
        if (this.RoleDisplayName == null && Exploration.Includes(parent + ".roleDisplayName", true))
        {
            this.RoleDisplayName = new System.String("FETCH");
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        if (this.Scope == null && Exploration.Includes(parent + ".scope", true))
        {
            this.Scope = new System.String("FETCH");
        }
    }


    #endregion

    } // class AzureRole
    
    #endregion

    public static class ListAzureRoleExtensions
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
            this List<AzureRole> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureRole> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureRole());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types