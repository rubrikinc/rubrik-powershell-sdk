// GetSupportCaseReply.cs
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
    #region GetSupportCaseReply
    public class GetSupportCaseReply: BaseType
    {
        #region members

        //      C# -> NewCasePriority? Priority
        // GraphQL -> priority: NewCasePriority! (enum)
        [JsonProperty("priority")]
        public NewCasePriority? Priority { get; set; }

        //      C# -> System.String? AssignedTo
        // GraphQL -> assignedTo: String! (scalar)
        [JsonProperty("assignedTo")]
        public System.String? AssignedTo { get; set; }

        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        [JsonProperty("caseId")]
        public System.String? CaseId { get; set; }

        //      C# -> System.String? CaseLink
        // GraphQL -> caseLink: String! (scalar)
        [JsonProperty("caseLink")]
        public System.String? CaseLink { get; set; }

        //      C# -> System.String? CaseNumber
        // GraphQL -> caseNumber: String! (scalar)
        [JsonProperty("caseNumber")]
        public System.String? CaseNumber { get; set; }

        //      C# -> DateTime? ClosedDate
        // GraphQL -> closedDate: DateTime (scalar)
        [JsonProperty("closedDate")]
        public DateTime? ClosedDate { get; set; }

        //      C# -> System.String? Component
        // GraphQL -> component: String! (scalar)
        [JsonProperty("component")]
        public System.String? Component { get; set; }

        //      C# -> System.String? ContactEmail
        // GraphQL -> contactEmail: String! (scalar)
        [JsonProperty("contactEmail")]
        public System.String? ContactEmail { get; set; }

        //      C# -> System.String? ContactMethod
        // GraphQL -> contactMethod: String! (scalar)
        [JsonProperty("contactMethod")]
        public System.String? ContactMethod { get; set; }

        //      C# -> System.String? ContactName
        // GraphQL -> contactName: String! (scalar)
        [JsonProperty("contactName")]
        public System.String? ContactName { get; set; }

        //      C# -> System.String? ContactPhone
        // GraphQL -> contactPhone: String! (scalar)
        [JsonProperty("contactPhone")]
        public System.String? ContactPhone { get; set; }

        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        [JsonProperty("createdDate")]
        public DateTime? CreatedDate { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? FunctionalArea
        // GraphQL -> functionalArea: String! (scalar)
        [JsonProperty("functionalArea")]
        public System.String? FunctionalArea { get; set; }

        //      C# -> System.Boolean? IsClosed
        // GraphQL -> isClosed: Boolean! (scalar)
        [JsonProperty("isClosed")]
        public System.Boolean? IsClosed { get; set; }

        //      C# -> System.Boolean? IsEscalated
        // GraphQL -> isEscalated: Boolean! (scalar)
        [JsonProperty("isEscalated")]
        public System.Boolean? IsEscalated { get; set; }

        //      C# -> System.String? Origin
        // GraphQL -> origin: String! (scalar)
        [JsonProperty("origin")]
        public System.String? Origin { get; set; }

        //      C# -> System.String? ProductLine
        // GraphQL -> productLine: String! (scalar)
        [JsonProperty("productLine")]
        public System.String? ProductLine { get; set; }

        //      C# -> System.String? ResolutionDetails
        // GraphQL -> resolutionDetails: String! (scalar)
        [JsonProperty("resolutionDetails")]
        public System.String? ResolutionDetails { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> System.String? Subject
        // GraphQL -> subject: String! (scalar)
        [JsonProperty("subject")]
        public System.String? Subject { get; set; }

        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        [JsonProperty("type")]
        public System.String? Type { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetSupportCaseReply";
    }

    public GetSupportCaseReply Set(
        NewCasePriority? Priority = null,
        System.String? AssignedTo = null,
        System.String? CaseId = null,
        System.String? CaseLink = null,
        System.String? CaseNumber = null,
        DateTime? ClosedDate = null,
        System.String? Component = null,
        System.String? ContactEmail = null,
        System.String? ContactMethod = null,
        System.String? ContactName = null,
        System.String? ContactPhone = null,
        DateTime? CreatedDate = null,
        System.String? Description = null,
        System.String? FunctionalArea = null,
        System.Boolean? IsClosed = null,
        System.Boolean? IsEscalated = null,
        System.String? Origin = null,
        System.String? ProductLine = null,
        System.String? ResolutionDetails = null,
        System.String? Status = null,
        System.String? Subject = null,
        System.String? Type = null
    ) 
    {
        if ( Priority != null ) {
            this.Priority = Priority;
        }
        if ( AssignedTo != null ) {
            this.AssignedTo = AssignedTo;
        }
        if ( CaseId != null ) {
            this.CaseId = CaseId;
        }
        if ( CaseLink != null ) {
            this.CaseLink = CaseLink;
        }
        if ( CaseNumber != null ) {
            this.CaseNumber = CaseNumber;
        }
        if ( ClosedDate != null ) {
            this.ClosedDate = ClosedDate;
        }
        if ( Component != null ) {
            this.Component = Component;
        }
        if ( ContactEmail != null ) {
            this.ContactEmail = ContactEmail;
        }
        if ( ContactMethod != null ) {
            this.ContactMethod = ContactMethod;
        }
        if ( ContactName != null ) {
            this.ContactName = ContactName;
        }
        if ( ContactPhone != null ) {
            this.ContactPhone = ContactPhone;
        }
        if ( CreatedDate != null ) {
            this.CreatedDate = CreatedDate;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( FunctionalArea != null ) {
            this.FunctionalArea = FunctionalArea;
        }
        if ( IsClosed != null ) {
            this.IsClosed = IsClosed;
        }
        if ( IsEscalated != null ) {
            this.IsEscalated = IsEscalated;
        }
        if ( Origin != null ) {
            this.Origin = Origin;
        }
        if ( ProductLine != null ) {
            this.ProductLine = ProductLine;
        }
        if ( ResolutionDetails != null ) {
            this.ResolutionDetails = ResolutionDetails;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Subject != null ) {
            this.Subject = Subject;
        }
        if ( Type != null ) {
            this.Type = Type;
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
        //      C# -> NewCasePriority? Priority
        // GraphQL -> priority: NewCasePriority! (enum)
        if (this.Priority != null) {
            if (conf.Flat) {
                s += conf.Prefix + "priority\n" ;
            } else {
                s += ind + "priority\n" ;
            }
        }
        //      C# -> System.String? AssignedTo
        // GraphQL -> assignedTo: String! (scalar)
        if (this.AssignedTo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "assignedTo\n" ;
            } else {
                s += ind + "assignedTo\n" ;
            }
        }
        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        if (this.CaseId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caseId\n" ;
            } else {
                s += ind + "caseId\n" ;
            }
        }
        //      C# -> System.String? CaseLink
        // GraphQL -> caseLink: String! (scalar)
        if (this.CaseLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caseLink\n" ;
            } else {
                s += ind + "caseLink\n" ;
            }
        }
        //      C# -> System.String? CaseNumber
        // GraphQL -> caseNumber: String! (scalar)
        if (this.CaseNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caseNumber\n" ;
            } else {
                s += ind + "caseNumber\n" ;
            }
        }
        //      C# -> DateTime? ClosedDate
        // GraphQL -> closedDate: DateTime (scalar)
        if (this.ClosedDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "closedDate\n" ;
            } else {
                s += ind + "closedDate\n" ;
            }
        }
        //      C# -> System.String? Component
        // GraphQL -> component: String! (scalar)
        if (this.Component != null) {
            if (conf.Flat) {
                s += conf.Prefix + "component\n" ;
            } else {
                s += ind + "component\n" ;
            }
        }
        //      C# -> System.String? ContactEmail
        // GraphQL -> contactEmail: String! (scalar)
        if (this.ContactEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contactEmail\n" ;
            } else {
                s += ind + "contactEmail\n" ;
            }
        }
        //      C# -> System.String? ContactMethod
        // GraphQL -> contactMethod: String! (scalar)
        if (this.ContactMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contactMethod\n" ;
            } else {
                s += ind + "contactMethod\n" ;
            }
        }
        //      C# -> System.String? ContactName
        // GraphQL -> contactName: String! (scalar)
        if (this.ContactName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contactName\n" ;
            } else {
                s += ind + "contactName\n" ;
            }
        }
        //      C# -> System.String? ContactPhone
        // GraphQL -> contactPhone: String! (scalar)
        if (this.ContactPhone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contactPhone\n" ;
            } else {
                s += ind + "contactPhone\n" ;
            }
        }
        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        if (this.CreatedDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdDate\n" ;
            } else {
                s += ind + "createdDate\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.String? FunctionalArea
        // GraphQL -> functionalArea: String! (scalar)
        if (this.FunctionalArea != null) {
            if (conf.Flat) {
                s += conf.Prefix + "functionalArea\n" ;
            } else {
                s += ind + "functionalArea\n" ;
            }
        }
        //      C# -> System.Boolean? IsClosed
        // GraphQL -> isClosed: Boolean! (scalar)
        if (this.IsClosed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isClosed\n" ;
            } else {
                s += ind + "isClosed\n" ;
            }
        }
        //      C# -> System.Boolean? IsEscalated
        // GraphQL -> isEscalated: Boolean! (scalar)
        if (this.IsEscalated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEscalated\n" ;
            } else {
                s += ind + "isEscalated\n" ;
            }
        }
        //      C# -> System.String? Origin
        // GraphQL -> origin: String! (scalar)
        if (this.Origin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "origin\n" ;
            } else {
                s += ind + "origin\n" ;
            }
        }
        //      C# -> System.String? ProductLine
        // GraphQL -> productLine: String! (scalar)
        if (this.ProductLine != null) {
            if (conf.Flat) {
                s += conf.Prefix + "productLine\n" ;
            } else {
                s += ind + "productLine\n" ;
            }
        }
        //      C# -> System.String? ResolutionDetails
        // GraphQL -> resolutionDetails: String! (scalar)
        if (this.ResolutionDetails != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resolutionDetails\n" ;
            } else {
                s += ind + "resolutionDetails\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Subject
        // GraphQL -> subject: String! (scalar)
        if (this.Subject != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subject\n" ;
            } else {
                s += ind + "subject\n" ;
            }
        }
        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> NewCasePriority? Priority
        // GraphQL -> priority: NewCasePriority! (enum)
        if (ec.Includes("priority",true))
        {
            if(this.Priority == null) {

                this.Priority = new NewCasePriority();

            } else {


            }
        }
        else if (this.Priority != null && ec.Excludes("priority",true))
        {
            this.Priority = null;
        }
        //      C# -> System.String? AssignedTo
        // GraphQL -> assignedTo: String! (scalar)
        if (ec.Includes("assignedTo",true))
        {
            if(this.AssignedTo == null) {

                this.AssignedTo = "FETCH";

            } else {


            }
        }
        else if (this.AssignedTo != null && ec.Excludes("assignedTo",true))
        {
            this.AssignedTo = null;
        }
        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        if (ec.Includes("caseId",true))
        {
            if(this.CaseId == null) {

                this.CaseId = "FETCH";

            } else {


            }
        }
        else if (this.CaseId != null && ec.Excludes("caseId",true))
        {
            this.CaseId = null;
        }
        //      C# -> System.String? CaseLink
        // GraphQL -> caseLink: String! (scalar)
        if (ec.Includes("caseLink",true))
        {
            if(this.CaseLink == null) {

                this.CaseLink = "FETCH";

            } else {


            }
        }
        else if (this.CaseLink != null && ec.Excludes("caseLink",true))
        {
            this.CaseLink = null;
        }
        //      C# -> System.String? CaseNumber
        // GraphQL -> caseNumber: String! (scalar)
        if (ec.Includes("caseNumber",true))
        {
            if(this.CaseNumber == null) {

                this.CaseNumber = "FETCH";

            } else {


            }
        }
        else if (this.CaseNumber != null && ec.Excludes("caseNumber",true))
        {
            this.CaseNumber = null;
        }
        //      C# -> DateTime? ClosedDate
        // GraphQL -> closedDate: DateTime (scalar)
        if (ec.Includes("closedDate",true))
        {
            if(this.ClosedDate == null) {

                this.ClosedDate = new DateTime();

            } else {


            }
        }
        else if (this.ClosedDate != null && ec.Excludes("closedDate",true))
        {
            this.ClosedDate = null;
        }
        //      C# -> System.String? Component
        // GraphQL -> component: String! (scalar)
        if (ec.Includes("component",true))
        {
            if(this.Component == null) {

                this.Component = "FETCH";

            } else {


            }
        }
        else if (this.Component != null && ec.Excludes("component",true))
        {
            this.Component = null;
        }
        //      C# -> System.String? ContactEmail
        // GraphQL -> contactEmail: String! (scalar)
        if (ec.Includes("contactEmail",true))
        {
            if(this.ContactEmail == null) {

                this.ContactEmail = "FETCH";

            } else {


            }
        }
        else if (this.ContactEmail != null && ec.Excludes("contactEmail",true))
        {
            this.ContactEmail = null;
        }
        //      C# -> System.String? ContactMethod
        // GraphQL -> contactMethod: String! (scalar)
        if (ec.Includes("contactMethod",true))
        {
            if(this.ContactMethod == null) {

                this.ContactMethod = "FETCH";

            } else {


            }
        }
        else if (this.ContactMethod != null && ec.Excludes("contactMethod",true))
        {
            this.ContactMethod = null;
        }
        //      C# -> System.String? ContactName
        // GraphQL -> contactName: String! (scalar)
        if (ec.Includes("contactName",true))
        {
            if(this.ContactName == null) {

                this.ContactName = "FETCH";

            } else {


            }
        }
        else if (this.ContactName != null && ec.Excludes("contactName",true))
        {
            this.ContactName = null;
        }
        //      C# -> System.String? ContactPhone
        // GraphQL -> contactPhone: String! (scalar)
        if (ec.Includes("contactPhone",true))
        {
            if(this.ContactPhone == null) {

                this.ContactPhone = "FETCH";

            } else {


            }
        }
        else if (this.ContactPhone != null && ec.Excludes("contactPhone",true))
        {
            this.ContactPhone = null;
        }
        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        if (ec.Includes("createdDate",true))
        {
            if(this.CreatedDate == null) {

                this.CreatedDate = new DateTime();

            } else {


            }
        }
        else if (this.CreatedDate != null && ec.Excludes("createdDate",true))
        {
            this.CreatedDate = null;
        }
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
        //      C# -> System.String? FunctionalArea
        // GraphQL -> functionalArea: String! (scalar)
        if (ec.Includes("functionalArea",true))
        {
            if(this.FunctionalArea == null) {

                this.FunctionalArea = "FETCH";

            } else {


            }
        }
        else if (this.FunctionalArea != null && ec.Excludes("functionalArea",true))
        {
            this.FunctionalArea = null;
        }
        //      C# -> System.Boolean? IsClosed
        // GraphQL -> isClosed: Boolean! (scalar)
        if (ec.Includes("isClosed",true))
        {
            if(this.IsClosed == null) {

                this.IsClosed = true;

            } else {


            }
        }
        else if (this.IsClosed != null && ec.Excludes("isClosed",true))
        {
            this.IsClosed = null;
        }
        //      C# -> System.Boolean? IsEscalated
        // GraphQL -> isEscalated: Boolean! (scalar)
        if (ec.Includes("isEscalated",true))
        {
            if(this.IsEscalated == null) {

                this.IsEscalated = true;

            } else {


            }
        }
        else if (this.IsEscalated != null && ec.Excludes("isEscalated",true))
        {
            this.IsEscalated = null;
        }
        //      C# -> System.String? Origin
        // GraphQL -> origin: String! (scalar)
        if (ec.Includes("origin",true))
        {
            if(this.Origin == null) {

                this.Origin = "FETCH";

            } else {


            }
        }
        else if (this.Origin != null && ec.Excludes("origin",true))
        {
            this.Origin = null;
        }
        //      C# -> System.String? ProductLine
        // GraphQL -> productLine: String! (scalar)
        if (ec.Includes("productLine",true))
        {
            if(this.ProductLine == null) {

                this.ProductLine = "FETCH";

            } else {


            }
        }
        else if (this.ProductLine != null && ec.Excludes("productLine",true))
        {
            this.ProductLine = null;
        }
        //      C# -> System.String? ResolutionDetails
        // GraphQL -> resolutionDetails: String! (scalar)
        if (ec.Includes("resolutionDetails",true))
        {
            if(this.ResolutionDetails == null) {

                this.ResolutionDetails = "FETCH";

            } else {


            }
        }
        else if (this.ResolutionDetails != null && ec.Excludes("resolutionDetails",true))
        {
            this.ResolutionDetails = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Subject
        // GraphQL -> subject: String! (scalar)
        if (ec.Includes("subject",true))
        {
            if(this.Subject == null) {

                this.Subject = "FETCH";

            } else {


            }
        }
        else if (this.Subject != null && ec.Excludes("subject",true))
        {
            this.Subject = null;
        }
        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = "FETCH";

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
    }


    #endregion

    } // class GetSupportCaseReply
    
    #endregion

    public static class ListGetSupportCaseReplyExtensions
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
            this List<GetSupportCaseReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetSupportCaseReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetSupportCaseReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetSupportCaseReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetSupportCaseReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types