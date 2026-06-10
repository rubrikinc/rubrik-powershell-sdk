// AzureAdGroupActiveAssignment.cs
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
    #region AzureAdGroupActiveAssignment
    public class AzureAdGroupActiveAssignment: BaseType
    {
        #region members

        //      C# -> AzureAdPimGroupAccessType? AccessId
        // GraphQL -> accessId: AzureAdPimGroupAccessType! (enum)
        [JsonProperty("accessId")]
        public AzureAdPimGroupAccessType? AccessId { get; set; }

        //      C# -> AzureAdPimAssignmentType? AssignmentType
        // GraphQL -> assignmentType: AzureAdPimAssignmentType! (enum)
        [JsonProperty("assignmentType")]
        public AzureAdPimAssignmentType? AssignmentType { get; set; }

        //      C# -> AzureAdPimEligibilityMemberType? MemberType
        // GraphQL -> memberType: AzureAdPimEligibilityMemberType! (enum)
        [JsonProperty("memberType")]
        public AzureAdPimEligibilityMemberType? MemberType { get; set; }

        //      C# -> AzureAdPimEligibilityStatus? Status
        // GraphQL -> status: AzureAdPimEligibilityStatus! (enum)
        [JsonProperty("status")]
        public AzureAdPimEligibilityStatus? Status { get; set; }

        //      C# -> DateTime? EndDateTime
        // GraphQL -> endDateTime: DateTime (scalar)
        [JsonProperty("endDateTime")]
        public DateTime? EndDateTime { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        [JsonProperty("groupName")]
        public System.String? GroupName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> DateTime? StartDateTime
        // GraphQL -> startDateTime: DateTime (scalar)
        [JsonProperty("startDateTime")]
        public DateTime? StartDateTime { get; set; }

        //      C# -> AzureAdPimActivePrincipalObject? PrincipalObject
        // GraphQL -> principalObject: AzureAdPimActivePrincipalObject (type)
        [JsonProperty("principalObject")]
        public AzureAdPimActivePrincipalObject? PrincipalObject { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdGroupActiveAssignment";
    }

    public AzureAdGroupActiveAssignment Set(
        AzureAdPimGroupAccessType? AccessId = null,
        AzureAdPimAssignmentType? AssignmentType = null,
        AzureAdPimEligibilityMemberType? MemberType = null,
        AzureAdPimEligibilityStatus? Status = null,
        DateTime? EndDateTime = null,
        System.String? GroupId = null,
        System.String? GroupName = null,
        System.String? Id = null,
        System.String? PrincipalId = null,
        DateTime? StartDateTime = null,
        AzureAdPimActivePrincipalObject? PrincipalObject = null
    ) 
    {
        if ( AccessId != null ) {
            this.AccessId = AccessId;
        }
        if ( AssignmentType != null ) {
            this.AssignmentType = AssignmentType;
        }
        if ( MemberType != null ) {
            this.MemberType = MemberType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( EndDateTime != null ) {
            this.EndDateTime = EndDateTime;
        }
        if ( GroupId != null ) {
            this.GroupId = GroupId;
        }
        if ( GroupName != null ) {
            this.GroupName = GroupName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
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
        //      C# -> AzureAdPimGroupAccessType? AccessId
        // GraphQL -> accessId: AzureAdPimGroupAccessType! (enum)
        if (this.AccessId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessId\n" ;
            } else {
                s += ind + "accessId\n" ;
            }
        }
        //      C# -> AzureAdPimAssignmentType? AssignmentType
        // GraphQL -> assignmentType: AzureAdPimAssignmentType! (enum)
        if (this.AssignmentType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "assignmentType\n" ;
            } else {
                s += ind + "assignmentType\n" ;
            }
        }
        //      C# -> AzureAdPimEligibilityMemberType? MemberType
        // GraphQL -> memberType: AzureAdPimEligibilityMemberType! (enum)
        if (this.MemberType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memberType\n" ;
            } else {
                s += ind + "memberType\n" ;
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
        //      C# -> DateTime? EndDateTime
        // GraphQL -> endDateTime: DateTime (scalar)
        if (this.EndDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endDateTime\n" ;
            } else {
                s += ind + "endDateTime\n" ;
            }
        }
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        if (this.GroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupId\n" ;
            } else {
                s += ind + "groupId\n" ;
            }
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupName\n" ;
            } else {
                s += ind + "groupName\n" ;
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
        //      C# -> DateTime? StartDateTime
        // GraphQL -> startDateTime: DateTime (scalar)
        if (this.StartDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startDateTime\n" ;
            } else {
                s += ind + "startDateTime\n" ;
            }
        }
        //      C# -> AzureAdPimActivePrincipalObject? PrincipalObject
        // GraphQL -> principalObject: AzureAdPimActivePrincipalObject (type)
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
        //      C# -> AzureAdPimGroupAccessType? AccessId
        // GraphQL -> accessId: AzureAdPimGroupAccessType! (enum)
        if (ec.Includes("accessId",true))
        {
            if(this.AccessId == null) {

                this.AccessId = new AzureAdPimGroupAccessType();

            } else {


            }
        }
        else if (this.AccessId != null && ec.Excludes("accessId",true))
        {
            this.AccessId = null;
        }
        //      C# -> AzureAdPimAssignmentType? AssignmentType
        // GraphQL -> assignmentType: AzureAdPimAssignmentType! (enum)
        if (ec.Includes("assignmentType",true))
        {
            if(this.AssignmentType == null) {

                this.AssignmentType = new AzureAdPimAssignmentType();

            } else {


            }
        }
        else if (this.AssignmentType != null && ec.Excludes("assignmentType",true))
        {
            this.AssignmentType = null;
        }
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
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        if (ec.Includes("groupId",true))
        {
            if(this.GroupId == null) {

                this.GroupId = "FETCH";

            } else {


            }
        }
        else if (this.GroupId != null && ec.Excludes("groupId",true))
        {
            this.GroupId = null;
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (ec.Includes("groupName",true))
        {
            if(this.GroupName == null) {

                this.GroupName = "FETCH";

            } else {


            }
        }
        else if (this.GroupName != null && ec.Excludes("groupName",true))
        {
            this.GroupName = null;
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
        //      C# -> AzureAdPimActivePrincipalObject? PrincipalObject
        // GraphQL -> principalObject: AzureAdPimActivePrincipalObject (type)
        if (ec.Includes("principalObject",false))
        {
            if(this.PrincipalObject == null) {

                this.PrincipalObject = new AzureAdPimActivePrincipalObject();
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

    } // class AzureAdGroupActiveAssignment
    
    #endregion

    public static class ListAzureAdGroupActiveAssignmentExtensions
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
            this List<AzureAdGroupActiveAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdGroupActiveAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdGroupActiveAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdGroupActiveAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdGroupActiveAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types