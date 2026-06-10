// AzureAdRoleEligibleAssignment.cs
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
    #region AzureAdRoleEligibleAssignment
    public class AzureAdRoleEligibleAssignment: BaseType
    {
        #region members

        //      C# -> AzureAdPimEligibilityMemberType? MemberType
        // GraphQL -> memberType: AzureAdPimEligibilityMemberType! (enum)
        [JsonProperty("memberType")]
        public AzureAdPimEligibilityMemberType? MemberType { get; set; }

        //      C# -> AzureAdRoleAssignmentScopeType? ScopeObjType
        // GraphQL -> scopeObjType: AzureAdRoleAssignmentScopeType (enum)
        [JsonProperty("scopeObjType")]
        public AzureAdRoleAssignmentScopeType? ScopeObjType { get; set; }

        //      C# -> AzureAdPimEligibilityStatus? Status
        // GraphQL -> status: AzureAdPimEligibilityStatus! (enum)
        [JsonProperty("status")]
        public AzureAdPimEligibilityStatus? Status { get; set; }

        //      C# -> System.String? DirectoryScopeId
        // GraphQL -> directoryScopeId: String! (scalar)
        [JsonProperty("directoryScopeId")]
        public System.String? DirectoryScopeId { get; set; }

        //      C# -> DateTime? EndDateTime
        // GraphQL -> endDateTime: DateTime (scalar)
        [JsonProperty("endDateTime")]
        public DateTime? EndDateTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: String! (scalar)
        [JsonProperty("roleDefinitionId")]
        public System.String? RoleDefinitionId { get; set; }

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }

        //      C# -> System.String? ScopeObjId
        // GraphQL -> scopeObjId: UUID (scalar)
        [JsonProperty("scopeObjId")]
        public System.String? ScopeObjId { get; set; }

        //      C# -> System.String? ScopeObjName
        // GraphQL -> scopeObjName: String (scalar)
        [JsonProperty("scopeObjName")]
        public System.String? ScopeObjName { get; set; }

        //      C# -> DateTime? StartDateTime
        // GraphQL -> startDateTime: DateTime (scalar)
        [JsonProperty("startDateTime")]
        public DateTime? StartDateTime { get; set; }

        //      C# -> AzureAdPimEligibilityPrincipalObject? PrincipalObject
        // GraphQL -> principalObject: AzureAdPimEligibilityPrincipalObject (type)
        [JsonProperty("principalObject")]
        public AzureAdPimEligibilityPrincipalObject? PrincipalObject { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdRoleEligibleAssignment";
    }

    public AzureAdRoleEligibleAssignment Set(
        AzureAdPimEligibilityMemberType? MemberType = null,
        AzureAdRoleAssignmentScopeType? ScopeObjType = null,
        AzureAdPimEligibilityStatus? Status = null,
        System.String? DirectoryScopeId = null,
        DateTime? EndDateTime = null,
        System.String? Id = null,
        System.String? PrincipalId = null,
        System.String? RoleDefinitionId = null,
        System.String? RoleName = null,
        System.String? ScopeObjId = null,
        System.String? ScopeObjName = null,
        DateTime? StartDateTime = null,
        AzureAdPimEligibilityPrincipalObject? PrincipalObject = null
    ) 
    {
        if ( MemberType != null ) {
            this.MemberType = MemberType;
        }
        if ( ScopeObjType != null ) {
            this.ScopeObjType = ScopeObjType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( DirectoryScopeId != null ) {
            this.DirectoryScopeId = DirectoryScopeId;
        }
        if ( EndDateTime != null ) {
            this.EndDateTime = EndDateTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
        }
        if ( RoleDefinitionId != null ) {
            this.RoleDefinitionId = RoleDefinitionId;
        }
        if ( RoleName != null ) {
            this.RoleName = RoleName;
        }
        if ( ScopeObjId != null ) {
            this.ScopeObjId = ScopeObjId;
        }
        if ( ScopeObjName != null ) {
            this.ScopeObjName = ScopeObjName;
        }
        if ( StartDateTime != null ) {
            this.StartDateTime = StartDateTime;
        }
        if ( PrincipalObject != null ) {
            this.PrincipalObject = PrincipalObject;
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
        //      C# -> AzureAdPimEligibilityMemberType? MemberType
        // GraphQL -> memberType: AzureAdPimEligibilityMemberType! (enum)
        if (this.MemberType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memberType\n" ;
            } else {
                s += ind + "memberType\n" ;
            }
        }
        //      C# -> AzureAdRoleAssignmentScopeType? ScopeObjType
        // GraphQL -> scopeObjType: AzureAdRoleAssignmentScopeType (enum)
        if (this.ScopeObjType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scopeObjType\n" ;
            } else {
                s += ind + "scopeObjType\n" ;
            }
        }
        //      C# -> AzureAdPimEligibilityStatus? Status
        // GraphQL -> status: AzureAdPimEligibilityStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? DirectoryScopeId
        // GraphQL -> directoryScopeId: String! (scalar)
        if (this.DirectoryScopeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "directoryScopeId\n" ;
            } else {
                s += ind + "directoryScopeId\n" ;
            }
        }
        //      C# -> DateTime? EndDateTime
        // GraphQL -> endDateTime: DateTime (scalar)
        if (this.EndDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endDateTime\n" ;
            } else {
                s += ind + "endDateTime\n" ;
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
        //      C# -> System.String? RoleDefinitionId
        // GraphQL -> roleDefinitionId: String! (scalar)
        if (this.RoleDefinitionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleDefinitionId\n" ;
            } else {
                s += ind + "roleDefinitionId\n" ;
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
        //      C# -> System.String? ScopeObjId
        // GraphQL -> scopeObjId: UUID (scalar)
        if (this.ScopeObjId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scopeObjId\n" ;
            } else {
                s += ind + "scopeObjId\n" ;
            }
        }
        //      C# -> System.String? ScopeObjName
        // GraphQL -> scopeObjName: String (scalar)
        if (this.ScopeObjName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scopeObjName\n" ;
            } else {
                s += ind + "scopeObjName\n" ;
            }
        }
        //      C# -> DateTime? StartDateTime
        // GraphQL -> startDateTime: DateTime (scalar)
        if (this.StartDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startDateTime\n" ;
            } else {
                s += ind + "startDateTime\n" ;
            }
        }
        //      C# -> AzureAdPimEligibilityPrincipalObject? PrincipalObject
        // GraphQL -> principalObject: AzureAdPimEligibilityPrincipalObject (type)
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdPimEligibilityMemberType? MemberType
        // GraphQL -> memberType: AzureAdPimEligibilityMemberType! (enum)
        if (ec.Includes("memberType",true))
        {
            if(this.MemberType == null) {

                this.MemberType = new AzureAdPimEligibilityMemberType();

            } else {


            }
        }
        else if (this.MemberType != null && ec.Excludes("memberType",true))
        {
            this.MemberType = null;
        }
        //      C# -> AzureAdRoleAssignmentScopeType? ScopeObjType
        // GraphQL -> scopeObjType: AzureAdRoleAssignmentScopeType (enum)
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
        //      C# -> AzureAdPimEligibilityStatus? Status
        // GraphQL -> status: AzureAdPimEligibilityStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new AzureAdPimEligibilityStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? DirectoryScopeId
        // GraphQL -> directoryScopeId: String! (scalar)
        if (ec.Includes("directoryScopeId",true))
        {
            if(this.DirectoryScopeId == null) {

                this.DirectoryScopeId = "FETCH";

            } else {


            }
        }
        else if (this.DirectoryScopeId != null && ec.Excludes("directoryScopeId",true))
        {
            this.DirectoryScopeId = null;
        }
        //      C# -> DateTime? EndDateTime
        // GraphQL -> endDateTime: DateTime (scalar)
        if (ec.Includes("endDateTime",true))
        {
            if(this.EndDateTime == null) {

                this.EndDateTime = new DateTime();

            } else {


            }
        }
        else if (this.EndDateTime != null && ec.Excludes("endDateTime",true))
        {
            this.EndDateTime = null;
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
        //      C# -> System.String? ScopeObjId
        // GraphQL -> scopeObjId: UUID (scalar)
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
        // GraphQL -> scopeObjName: String (scalar)
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
        //      C# -> DateTime? StartDateTime
        // GraphQL -> startDateTime: DateTime (scalar)
        if (ec.Includes("startDateTime",true))
        {
            if(this.StartDateTime == null) {

                this.StartDateTime = new DateTime();

            } else {


            }
        }
        else if (this.StartDateTime != null && ec.Excludes("startDateTime",true))
        {
            this.StartDateTime = null;
        }
        //      C# -> AzureAdPimEligibilityPrincipalObject? PrincipalObject
        // GraphQL -> principalObject: AzureAdPimEligibilityPrincipalObject (type)
        if (ec.Includes("principalObject",false))
        {
            if(this.PrincipalObject == null) {

                this.PrincipalObject = new AzureAdPimEligibilityPrincipalObject();
                this.PrincipalObject.ApplyExploratoryFieldSpec(ec.NewChild("principalObject"));

            } else {

                this.PrincipalObject.ApplyExploratoryFieldSpec(ec.NewChild("principalObject"));

            }
        }
        else if (this.PrincipalObject != null && ec.Excludes("principalObject",false))
        {
            this.PrincipalObject = null;
        }
    }


    #endregion

    } // class AzureAdRoleEligibleAssignment
    
    #endregion

    public static class ListAzureAdRoleEligibleAssignmentExtensions
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
            this List<AzureAdRoleEligibleAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdRoleEligibleAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdRoleEligibleAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdRoleEligibleAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdRoleEligibleAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types