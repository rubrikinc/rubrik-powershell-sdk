// IntuneRoleAssignment.cs
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
    #region IntuneRoleAssignment
    public class IntuneRoleAssignment: BaseType
    {
        #region members

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: String! (scalar)
        [JsonProperty("roleDefinitionId")]
        public System.String? RoleDefinitionId { get; set; }

        //      C# -> List<System.String>? RoleScopeTagIds
        // GraphQL -> roleScopeTagIds: [String!]! (scalar)
        [JsonProperty("roleScopeTagIds")]
        public List<System.String>? RoleScopeTagIds { get; set; }

        //      C# -> List<System.String>? RoleScopeTagNames
        // GraphQL -> roleScopeTagNames: [String!]! (scalar)
        [JsonProperty("roleScopeTagNames")]
        public List<System.String>? RoleScopeTagNames { get; set; }

        //      C# -> System.String? ScopeType
        // GraphQL -> scopeType: String! (scalar)
        [JsonProperty("scopeType")]
        public System.String? ScopeType { get; set; }

        //      C# -> List<IntuneRoleAssignmentObjectIdentifier>? Members
        // GraphQL -> members: [IntuneRoleAssignmentObjectIdentifier!]! (type)
        [JsonProperty("members")]
        public List<IntuneRoleAssignmentObjectIdentifier>? Members { get; set; }

        //      C# -> List<IntuneRoleAssignmentObjectIdentifier>? ResourceScopes
        // GraphQL -> resourceScopes: [IntuneRoleAssignmentObjectIdentifier!]! (type)
        [JsonProperty("resourceScopes")]
        public List<IntuneRoleAssignmentObjectIdentifier>? ResourceScopes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntuneRoleAssignment";
    }

    public IntuneRoleAssignment Set(
        System.String? Description = null,
        System.String? DisplayName = null,
        System.String? RoleDefinitionId = null,
        List<System.String>? RoleScopeTagIds = null,
        List<System.String>? RoleScopeTagNames = null,
        System.String? ScopeType = null,
        List<IntuneRoleAssignmentObjectIdentifier>? Members = null,
        List<IntuneRoleAssignmentObjectIdentifier>? ResourceScopes = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( RoleDefinitionId != null ) {
            this.RoleDefinitionId = RoleDefinitionId;
        }
        if ( RoleScopeTagIds != null ) {
            this.RoleScopeTagIds = RoleScopeTagIds;
        }
        if ( RoleScopeTagNames != null ) {
            this.RoleScopeTagNames = RoleScopeTagNames;
        }
        if ( ScopeType != null ) {
            this.ScopeType = ScopeType;
        }
        if ( Members != null ) {
            this.Members = Members;
        }
        if ( ResourceScopes != null ) {
            this.ResourceScopes = ResourceScopes;
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
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
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
        //      C# -> List<System.String>? RoleScopeTagIds
        // GraphQL -> roleScopeTagIds: [String!]! (scalar)
        if (this.RoleScopeTagIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleScopeTagIds\n" ;
            } else {
                s += ind + "roleScopeTagIds\n" ;
            }
        }
        //      C# -> List<System.String>? RoleScopeTagNames
        // GraphQL -> roleScopeTagNames: [String!]! (scalar)
        if (this.RoleScopeTagNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleScopeTagNames\n" ;
            } else {
                s += ind + "roleScopeTagNames\n" ;
            }
        }
        //      C# -> System.String? ScopeType
        // GraphQL -> scopeType: String! (scalar)
        if (this.ScopeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scopeType\n" ;
            } else {
                s += ind + "scopeType\n" ;
            }
        }
        //      C# -> List<IntuneRoleAssignmentObjectIdentifier>? Members
        // GraphQL -> members: [IntuneRoleAssignmentObjectIdentifier!]! (type)
        if (this.Members != null) {
            var fspec = this.Members.AsFieldSpec(conf.Child("members"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "members" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<IntuneRoleAssignmentObjectIdentifier>? ResourceScopes
        // GraphQL -> resourceScopes: [IntuneRoleAssignmentObjectIdentifier!]! (type)
        if (this.ResourceScopes != null) {
            var fspec = this.ResourceScopes.AsFieldSpec(conf.Child("resourceScopes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resourceScopes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
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
        //      C# -> List<System.String>? RoleScopeTagIds
        // GraphQL -> roleScopeTagIds: [String!]! (scalar)
        if (ec.Includes("roleScopeTagIds",true))
        {
            if(this.RoleScopeTagIds == null) {

                this.RoleScopeTagIds = new List<System.String>();

            } else {


            }
        }
        else if (this.RoleScopeTagIds != null && ec.Excludes("roleScopeTagIds",true))
        {
            this.RoleScopeTagIds = null;
        }
        //      C# -> List<System.String>? RoleScopeTagNames
        // GraphQL -> roleScopeTagNames: [String!]! (scalar)
        if (ec.Includes("roleScopeTagNames",true))
        {
            if(this.RoleScopeTagNames == null) {

                this.RoleScopeTagNames = new List<System.String>();

            } else {


            }
        }
        else if (this.RoleScopeTagNames != null && ec.Excludes("roleScopeTagNames",true))
        {
            this.RoleScopeTagNames = null;
        }
        //      C# -> System.String? ScopeType
        // GraphQL -> scopeType: String! (scalar)
        if (ec.Includes("scopeType",true))
        {
            if(this.ScopeType == null) {

                this.ScopeType = "FETCH";

            } else {


            }
        }
        else if (this.ScopeType != null && ec.Excludes("scopeType",true))
        {
            this.ScopeType = null;
        }
        //      C# -> List<IntuneRoleAssignmentObjectIdentifier>? Members
        // GraphQL -> members: [IntuneRoleAssignmentObjectIdentifier!]! (type)
        if (ec.Includes("members",false))
        {
            if(this.Members == null) {

                this.Members = new List<IntuneRoleAssignmentObjectIdentifier>();
                this.Members.ApplyExploratoryFieldSpec(ec.NewChild("members"));

            } else {

                this.Members.ApplyExploratoryFieldSpec(ec.NewChild("members"));

            }
        }
        else if (this.Members != null && ec.Excludes("members",false))
        {
            this.Members = null;
        }
        //      C# -> List<IntuneRoleAssignmentObjectIdentifier>? ResourceScopes
        // GraphQL -> resourceScopes: [IntuneRoleAssignmentObjectIdentifier!]! (type)
        if (ec.Includes("resourceScopes",false))
        {
            if(this.ResourceScopes == null) {

                this.ResourceScopes = new List<IntuneRoleAssignmentObjectIdentifier>();
                this.ResourceScopes.ApplyExploratoryFieldSpec(ec.NewChild("resourceScopes"));

            } else {

                this.ResourceScopes.ApplyExploratoryFieldSpec(ec.NewChild("resourceScopes"));

            }
        }
        else if (this.ResourceScopes != null && ec.Excludes("resourceScopes",false))
        {
            this.ResourceScopes = null;
        }
    }


    #endregion

    } // class IntuneRoleAssignment
    
    #endregion

    public static class ListIntuneRoleAssignmentExtensions
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
            this List<IntuneRoleAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntuneRoleAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntuneRoleAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntuneRoleAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntuneRoleAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types