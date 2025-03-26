// AzureAdRole.cs
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
    #region AzureAdRole
    public class AzureAdRole: BaseType
    {
        #region members

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }

        //      C# -> System.Boolean? IsBuiltIn
        // GraphQL -> isBuiltIn: Boolean! (scalar)
        [JsonProperty("isBuiltIn")]
        public System.Boolean? IsBuiltIn { get; set; }

        //      C# -> System.Boolean? IsPrivileged
        // GraphQL -> isPrivileged: Boolean! (scalar)
        [JsonProperty("isPrivileged")]
        public System.Boolean? IsPrivileged { get; set; }

        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: String! (scalar)
        [JsonProperty("roleDefinitionId")]
        public System.String? RoleDefinitionId { get; set; }

        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        [JsonProperty("roleId")]
        public System.String? RoleId { get; set; }

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdRole";
    }

    public AzureAdRole Set(
        System.String? Description = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsBuiltIn = null,
        System.Boolean? IsPrivileged = null,
        System.String? RoleDefinitionId = null,
        System.String? RoleId = null,
        System.String? RoleName = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( IsActive != null ) {
            this.IsActive = IsActive;
        }
        if ( IsBuiltIn != null ) {
            this.IsBuiltIn = IsBuiltIn;
        }
        if ( IsPrivileged != null ) {
            this.IsPrivileged = IsPrivileged;
        }
        if ( RoleDefinitionId != null ) {
            this.RoleDefinitionId = RoleDefinitionId;
        }
        if ( RoleId != null ) {
            this.RoleId = RoleId;
        }
        if ( RoleName != null ) {
            this.RoleName = RoleName;
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
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isActive\n" ;
            } else {
                s += ind + "isActive\n" ;
            }
        }
        //      C# -> System.Boolean? IsBuiltIn
        // GraphQL -> isBuiltIn: Boolean! (scalar)
        if (this.IsBuiltIn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBuiltIn\n" ;
            } else {
                s += ind + "isBuiltIn\n" ;
            }
        }
        //      C# -> System.Boolean? IsPrivileged
        // GraphQL -> isPrivileged: Boolean! (scalar)
        if (this.IsPrivileged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPrivileged\n" ;
            } else {
                s += ind + "isPrivileged\n" ;
            }
        }
        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: String! (scalar)
        if (this.RoleDefinitionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleDefinitionId\n" ;
            } else {
                s += ind + "roleDefinitionId\n" ;
            }
        }
        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        if (this.RoleId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleId\n" ;
            } else {
                s += ind + "roleId\n" ;
            }
        }
        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        if (this.RoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleName\n" ;
            } else {
                s += ind + "roleName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (ec.Includes("isActive",true))
        {
            if(this.IsActive == null) {

                this.IsActive = true;

            } else {


            }
        }
        else if (this.IsActive != null && ec.Excludes("isActive",true))
        {
            this.IsActive = null;
        }
        //      C# -> System.Boolean? IsBuiltIn
        // GraphQL -> isBuiltIn: Boolean! (scalar)
        if (ec.Includes("isBuiltIn",true))
        {
            if(this.IsBuiltIn == null) {

                this.IsBuiltIn = true;

            } else {


            }
        }
        else if (this.IsBuiltIn != null && ec.Excludes("isBuiltIn",true))
        {
            this.IsBuiltIn = null;
        }
        //      C# -> System.Boolean? IsPrivileged
        // GraphQL -> isPrivileged: Boolean! (scalar)
        if (ec.Includes("isPrivileged",true))
        {
            if(this.IsPrivileged == null) {

                this.IsPrivileged = true;

            } else {


            }
        }
        else if (this.IsPrivileged != null && ec.Excludes("isPrivileged",true))
        {
            this.IsPrivileged = null;
        }
        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: String! (scalar)
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
        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        if (ec.Includes("roleId",true))
        {
            if(this.RoleId == null) {

                this.RoleId = "FETCH";

            } else {


            }
        }
        else if (this.RoleId != null && ec.Excludes("roleId",true))
        {
            this.RoleId = null;
        }
        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        if (ec.Includes("roleName",true))
        {
            if(this.RoleName == null) {

                this.RoleName = "FETCH";

            } else {


            }
        }
        else if (this.RoleName != null && ec.Excludes("roleName",true))
        {
            this.RoleName = null;
        }
    }


    #endregion

    } // class AzureAdRole
    
    #endregion

    public static class ListAzureAdRoleExtensions
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
            this List<AzureAdRole> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdRole> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdRole> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdRole());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdRole> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types