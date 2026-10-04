// CloseSupportCaseReply.cs
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
    #region CloseSupportCaseReply
    public class CloseSupportCaseReply: BaseType
    {
        #region members

        //      C# -> SupportCaseStatus? Status
        // GraphQL -> status: SupportCaseStatus! (enum)
        [JsonProperty("status")]
        public SupportCaseStatus? Status { get; set; }

        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        [JsonProperty("caseId")]
        public System.String? CaseId { get; set; }

        //      C# -> System.String? CaseNumber
        // GraphQL -> caseNumber: String! (scalar)
        [JsonProperty("caseNumber")]
        public System.String? CaseNumber { get; set; }

        //      C# -> System.String? ContactEmail
        // GraphQL -> contactEmail: String! (scalar)
        [JsonProperty("contactEmail")]
        public System.String? ContactEmail { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloseSupportCaseReply";
    }

    public CloseSupportCaseReply Set(
        SupportCaseStatus? Status = null,
        System.String? CaseId = null,
        System.String? CaseNumber = null,
        System.String? ContactEmail = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CaseId != null ) {
            this.CaseId = CaseId;
        }
        if ( CaseNumber != null ) {
            this.CaseNumber = CaseNumber;
        }
        if ( ContactEmail != null ) {
            this.ContactEmail = ContactEmail;
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
        //      C# -> SupportCaseStatus? Status
        // GraphQL -> status: SupportCaseStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
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
        //      C# -> System.String? ContactEmail
        // GraphQL -> contactEmail: String! (scalar)
        if (this.ContactEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contactEmail\n" ;
            } else {
                s += ind + "contactEmail\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SupportCaseStatus? Status
        // GraphQL -> status: SupportCaseStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new SupportCaseStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
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
    }


    #endregion

    } // class CloseSupportCaseReply
    
    #endregion

    public static class ListCloseSupportCaseReplyExtensions
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
            this List<CloseSupportCaseReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloseSupportCaseReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloseSupportCaseReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloseSupportCaseReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloseSupportCaseReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types