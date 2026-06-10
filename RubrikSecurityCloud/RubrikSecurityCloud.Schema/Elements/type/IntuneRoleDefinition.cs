// IntuneRoleDefinition.cs
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
    #region IntuneRoleDefinition
    public class IntuneRoleDefinition: BaseType
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

        //      C# -> List<System.String>? RoleScopeTagIds
        // GraphQL -> roleScopeTagIds: [String!]! (scalar)
        [JsonProperty("roleScopeTagIds")]
        public List<System.String>? RoleScopeTagIds { get; set; }

        //      C# -> List<System.String>? RoleScopeTagNames
        // GraphQL -> roleScopeTagNames: [String!]! (scalar)
        [JsonProperty("roleScopeTagNames")]
        public List<System.String>? RoleScopeTagNames { get; set; }

        //      C# -> System.String? RoleType
        // GraphQL -> roleType: String! (scalar)
        [JsonProperty("roleType")]
        public System.String? RoleType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntuneRoleDefinition";
    }

    public IntuneRoleDefinition Set(
        System.String? Description = null,
        System.String? DisplayName = null,
        List<System.String>? RoleScopeTagIds = null,
        List<System.String>? RoleScopeTagNames = null,
        System.String? RoleType = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( RoleScopeTagIds != null ) {
            this.RoleScopeTagIds = RoleScopeTagIds;
        }
        if ( RoleScopeTagNames != null ) {
            this.RoleScopeTagNames = RoleScopeTagNames;
        }
        if ( RoleType != null ) {
            this.RoleType = RoleType;
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
        //      C# -> System.String? RoleType
        // GraphQL -> roleType: String! (scalar)
        if (this.RoleType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleType\n" ;
            } else {
                s += ind + "roleType\n" ;
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
        //      C# -> System.String? RoleType
        // GraphQL -> roleType: String! (scalar)
        if (ec.Includes("roleType",true))
        {
            if(this.RoleType == null) {

                this.RoleType = "FETCH";

            } else {


            }
        }
        else if (this.RoleType != null && ec.Excludes("roleType",true))
        {
            this.RoleType = null;
        }
    }


    #endregion

    } // class IntuneRoleDefinition
    
    #endregion

    public static class ListIntuneRoleDefinitionExtensions
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
            this List<IntuneRoleDefinition> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntuneRoleDefinition> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntuneRoleDefinition> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntuneRoleDefinition());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntuneRoleDefinition> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types