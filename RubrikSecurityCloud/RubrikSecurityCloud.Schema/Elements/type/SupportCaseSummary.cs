// SupportCaseSummary.cs
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
    #region SupportCaseSummary
    public class SupportCaseSummary: BaseType
    {
        #region members

        //      C# -> NewCasePriority? Priority
        // GraphQL -> priority: NewCasePriority! (enum)
        [JsonProperty("priority")]
        public NewCasePriority? Priority { get; set; }

        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        [JsonProperty("caseId")]
        public System.String? CaseId { get; set; }

        //      C# -> System.String? CaseNumber
        // GraphQL -> caseNumber: String! (scalar)
        [JsonProperty("caseNumber")]
        public System.String? CaseNumber { get; set; }

        //      C# -> System.String? Component
        // GraphQL -> component: String! (scalar)
        [JsonProperty("component")]
        public System.String? Component { get; set; }

        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        [JsonProperty("createdDate")]
        public DateTime? CreatedDate { get; set; }

        //      C# -> System.String? FunctionalArea
        // GraphQL -> functionalArea: String! (scalar)
        [JsonProperty("functionalArea")]
        public System.String? FunctionalArea { get; set; }

        //      C# -> System.String? ProductLine
        // GraphQL -> productLine: String! (scalar)
        [JsonProperty("productLine")]
        public System.String? ProductLine { get; set; }

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
        return "SupportCaseSummary";
    }

    public SupportCaseSummary Set(
        NewCasePriority? Priority = null,
        System.String? CaseId = null,
        System.String? CaseNumber = null,
        System.String? Component = null,
        DateTime? CreatedDate = null,
        System.String? FunctionalArea = null,
        System.String? ProductLine = null,
        System.String? Status = null,
        System.String? Subject = null,
        System.String? Type = null
    ) 
    {
        if ( Priority != null ) {
            this.Priority = Priority;
        }
        if ( CaseId != null ) {
            this.CaseId = CaseId;
        }
        if ( CaseNumber != null ) {
            this.CaseNumber = CaseNumber;
        }
        if ( Component != null ) {
            this.Component = Component;
        }
        if ( CreatedDate != null ) {
            this.CreatedDate = CreatedDate;
        }
        if ( FunctionalArea != null ) {
            this.FunctionalArea = FunctionalArea;
        }
        if ( ProductLine != null ) {
            this.ProductLine = ProductLine;
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
        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        if (this.CaseId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caseId\n" ;
            } else {
                s += ind + "caseId\n" ;
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
        //      C# -> System.String? Component
        // GraphQL -> component: String! (scalar)
        if (this.Component != null) {
            if (conf.Flat) {
                s += conf.Prefix + "component\n" ;
            } else {
                s += ind + "component\n" ;
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
        //      C# -> System.String? FunctionalArea
        // GraphQL -> functionalArea: String! (scalar)
        if (this.FunctionalArea != null) {
            if (conf.Flat) {
                s += conf.Prefix + "functionalArea\n" ;
            } else {
                s += ind + "functionalArea\n" ;
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

    } // class SupportCaseSummary
    
    #endregion

    public static class ListSupportCaseSummaryExtensions
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
            this List<SupportCaseSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SupportCaseSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SupportCaseSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SupportCaseSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SupportCaseSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types