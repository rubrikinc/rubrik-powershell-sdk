// AzureAdRoleAssignment.cs
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
    #region AzureAdRoleAssignment
    public class AzureAdRoleAssignment: BaseType
    {
        #region members

        //      C# -> AzureAdRoleAssignmentPrincipalType? PrincipalType
        // GraphQL -> principalType: AzureAdRoleAssignmentPrincipalType! (enum)
        [JsonProperty("principalType")]
        public AzureAdRoleAssignmentPrincipalType? PrincipalType { get; set; }

        //      C# -> AzureAdRoleAssignmentScopeType? ScopeObjType
        // GraphQL -> scopeObjType: AzureAdRoleAssignmentScopeType! (enum)
        [JsonProperty("scopeObjType")]
        public AzureAdRoleAssignmentScopeType? ScopeObjType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        [JsonProperty("roleId")]
        public System.String? RoleId { get; set; }

        //      C# -> System.String? ScopeObjId
        // GraphQL -> scopeObjId: String! (scalar)
        [JsonProperty("scopeObjId")]
        public System.String? ScopeObjId { get; set; }

        //      C# -> System.String? ScopeObjName
        // GraphQL -> scopeObjName: String! (scalar)
        [JsonProperty("scopeObjName")]
        public System.String? ScopeObjName { get; set; }

        //      C# -> PrincipalObject? PrincipalObject
        // GraphQL -> principalObject: PrincipalObject! (type)
        [JsonProperty("principalObject")]
        public PrincipalObject? PrincipalObject { get; set; }

        //      C# -> AzureAdRole? RoleObject
        // GraphQL -> roleObject: AzureAdRole! (type)
        [JsonProperty("roleObject")]
        public AzureAdRole? RoleObject { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdRoleAssignment";
    }

    public AzureAdRoleAssignment Set(
        AzureAdRoleAssignmentPrincipalType? PrincipalType = null,
        AzureAdRoleAssignmentScopeType? ScopeObjType = null,
        System.String? Id = null,
        System.String? PrincipalId = null,
        System.String? RoleId = null,
        System.String? ScopeObjId = null,
        System.String? ScopeObjName = null,
        PrincipalObject? PrincipalObject = null,
        AzureAdRole? RoleObject = null
    ) 
    {
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( ScopeObjType != null ) {
            this.ScopeObjType = ScopeObjType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
        }
        if ( RoleId != null ) {
            this.RoleId = RoleId;
        }
        if ( ScopeObjId != null ) {
            this.ScopeObjId = ScopeObjId;
        }
        if ( ScopeObjName != null ) {
            this.ScopeObjName = ScopeObjName;
        }
        if ( PrincipalObject != null ) {
            this.PrincipalObject = PrincipalObject;
        }
        if ( RoleObject != null ) {
            this.RoleObject = RoleObject;
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
        //      C# -> AzureAdRoleAssignmentPrincipalType? PrincipalType
        // GraphQL -> principalType: AzureAdRoleAssignmentPrincipalType! (enum)
        if (this.PrincipalType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalType\n" ;
            } else {
                s += ind + "principalType\n" ;
            }
        }
        //      C# -> AzureAdRoleAssignmentScopeType? ScopeObjType
        // GraphQL -> scopeObjType: AzureAdRoleAssignmentScopeType! (enum)
        if (this.ScopeObjType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scopeObjType\n" ;
            } else {
                s += ind + "scopeObjType\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalId\n" ;
            } else {
                s += ind + "principalId\n" ;
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
        //      C# -> System.String? ScopeObjId
        // GraphQL -> scopeObjId: String! (scalar)
        if (this.ScopeObjId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scopeObjId\n" ;
            } else {
                s += ind + "scopeObjId\n" ;
            }
        }
        //      C# -> System.String? ScopeObjName
        // GraphQL -> scopeObjName: String! (scalar)
        if (this.ScopeObjName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scopeObjName\n" ;
            } else {
                s += ind + "scopeObjName\n" ;
            }
        }
        //      C# -> PrincipalObject? PrincipalObject
        // GraphQL -> principalObject: PrincipalObject! (type)
        if (this.PrincipalObject != null) {
            var fspec = this.PrincipalObject.AsFieldSpec(conf.Child("principalObject"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "principalObject" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdRole? RoleObject
        // GraphQL -> roleObject: AzureAdRole! (type)
        if (this.RoleObject != null) {
            var fspec = this.RoleObject.AsFieldSpec(conf.Child("roleObject"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "roleObject" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdRoleAssignmentPrincipalType? PrincipalType
        // GraphQL -> principalType: AzureAdRoleAssignmentPrincipalType! (enum)
        if (ec.Includes("principalType",true))
        {
            if(this.PrincipalType == null) {

                this.PrincipalType = new AzureAdRoleAssignmentPrincipalType();

            } else {


            }
        }
        else if (this.PrincipalType != null && ec.Excludes("principalType",true))
        {
            this.PrincipalType = null;
        }
        //      C# -> AzureAdRoleAssignmentScopeType? ScopeObjType
        // GraphQL -> scopeObjType: AzureAdRoleAssignmentScopeType! (enum)
        if (ec.Includes("scopeObjType",true))
        {
            if(this.ScopeObjType == null) {

                this.ScopeObjType = new AzureAdRoleAssignmentScopeType();

            } else {


            }
        }
        else if (this.ScopeObjType != null && ec.Excludes("scopeObjType",true))
        {
            this.ScopeObjType = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (ec.Includes("principalId",true))
        {
            if(this.PrincipalId == null) {

                this.PrincipalId = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalId != null && ec.Excludes("principalId",true))
        {
            this.PrincipalId = null;
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
        //      C# -> System.String? ScopeObjId
        // GraphQL -> scopeObjId: String! (scalar)
        if (ec.Includes("scopeObjId",true))
        {
            if(this.ScopeObjId == null) {

                this.ScopeObjId = "FETCH";

            } else {


            }
        }
        else if (this.ScopeObjId != null && ec.Excludes("scopeObjId",true))
        {
            this.ScopeObjId = null;
        }
        //      C# -> System.String? ScopeObjName
        // GraphQL -> scopeObjName: String! (scalar)
        if (ec.Includes("scopeObjName",true))
        {
            if(this.ScopeObjName == null) {

                this.ScopeObjName = "FETCH";

            } else {


            }
        }
        else if (this.ScopeObjName != null && ec.Excludes("scopeObjName",true))
        {
            this.ScopeObjName = null;
        }
        //      C# -> PrincipalObject? PrincipalObject
        // GraphQL -> principalObject: PrincipalObject! (type)
        if (ec.Includes("principalObject",false))
        {
            if(this.PrincipalObject == null) {

                this.PrincipalObject = new PrincipalObject();
                this.PrincipalObject.ApplyExploratoryFieldSpec(ec.NewChild("principalObject"));

            } else {

                this.PrincipalObject.ApplyExploratoryFieldSpec(ec.NewChild("principalObject"));

            }
        }
        else if (this.PrincipalObject != null && ec.Excludes("principalObject",false))
        {
            this.PrincipalObject = null;
        }
        //      C# -> AzureAdRole? RoleObject
        // GraphQL -> roleObject: AzureAdRole! (type)
        if (ec.Includes("roleObject",false))
        {
            if(this.RoleObject == null) {

                this.RoleObject = new AzureAdRole();
                this.RoleObject.ApplyExploratoryFieldSpec(ec.NewChild("roleObject"));

            } else {

                this.RoleObject.ApplyExploratoryFieldSpec(ec.NewChild("roleObject"));

            }
        }
        else if (this.RoleObject != null && ec.Excludes("roleObject",false))
        {
            this.RoleObject = null;
        }
    }


    #endregion

    } // class AzureAdRoleAssignment
    
    #endregion

    public static class ListAzureAdRoleAssignmentExtensions
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
            this List<AzureAdRoleAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdRoleAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdRoleAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdRoleAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdRoleAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types