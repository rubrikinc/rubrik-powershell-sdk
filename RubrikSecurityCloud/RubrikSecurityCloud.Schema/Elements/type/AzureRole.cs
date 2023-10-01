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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "AzureRole";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsRubrikManaged
        // GraphQL -> isRubrikManaged: Boolean! (scalar)
        if (this.IsRubrikManaged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRubrikManaged\n" ;
            } else {
                s += ind + "isRubrikManaged\n" ;
            }
        }
        //      C# -> System.String? RoleAssignmentName
        // GraphQL -> roleAssignmentName: String! (scalar)
        if (this.RoleAssignmentName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleAssignmentName\n" ;
            } else {
                s += ind + "roleAssignmentName\n" ;
            }
        }
        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: UUID! (scalar)
        if (this.RoleDefinitionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleDefinitionId\n" ;
            } else {
                s += ind + "roleDefinitionId\n" ;
            }
        }
        //      C# -> System.String? RoleDisplayName
        // GraphQL -> roleDisplayName: String! (scalar)
        if (this.RoleDisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleDisplayName\n" ;
            } else {
                s += ind + "roleDisplayName\n" ;
            }
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        if (this.Scope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scope\n" ;
            } else {
                s += ind + "scope\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsRubrikManaged
        // GraphQL -> isRubrikManaged: Boolean! (scalar)
        if (ec.Includes("isRubrikManaged",true))
        {
            if(this.IsRubrikManaged == null) {

                this.IsRubrikManaged = true;

            } else {


            }
        }
        else if (this.IsRubrikManaged != null && ec.Excludes("isRubrikManaged",true))
        {
            this.IsRubrikManaged = null;
        }
        //      C# -> System.String? RoleAssignmentName
        // GraphQL -> roleAssignmentName: String! (scalar)
        if (ec.Includes("roleAssignmentName",true))
        {
            if(this.RoleAssignmentName == null) {

                this.RoleAssignmentName = "FETCH";

            } else {


            }
        }
        else if (this.RoleAssignmentName != null && ec.Excludes("roleAssignmentName",true))
        {
            this.RoleAssignmentName = null;
        }
        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: UUID! (scalar)
        if (ec.Includes("roleDefinitionId",true))
        {
            if(this.RoleDefinitionId == null) {

                this.RoleDefinitionId = "FETCH";

            } else {


            }
        }
        else if (this.RoleDefinitionId != null && ec.Excludes("roleDefinitionId",true))
        {
            this.RoleDefinitionId = null;
        }
        //      C# -> System.String? RoleDisplayName
        // GraphQL -> roleDisplayName: String! (scalar)
        if (ec.Includes("roleDisplayName",true))
        {
            if(this.RoleDisplayName == null) {

                this.RoleDisplayName = "FETCH";

            } else {


            }
        }
        else if (this.RoleDisplayName != null && ec.Excludes("roleDisplayName",true))
        {
            this.RoleDisplayName = null;
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        if (ec.Includes("scope",true))
        {
            if(this.Scope == null) {

                this.Scope = "FETCH";

            } else {


            }
        }
        else if (this.Scope != null && ec.Excludes("scope",true))
        {
            this.Scope = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureRole> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureRole> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureRole());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureRole> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types