// ReopenSupportCaseReply.cs
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
    #region ReopenSupportCaseReply
    public class ReopenSupportCaseReply: BaseType
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

        //      C# -> System.String? CommentId
        // GraphQL -> commentId: String! (scalar)
        [JsonProperty("commentId")]
        public System.String? CommentId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReopenSupportCaseReply";
    }

    public ReopenSupportCaseReply Set(
        SupportCaseStatus? Status = null,
        System.String? CaseId = null,
        System.String? CommentId = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CaseId != null ) {
            this.CaseId = CaseId;
        }
        if ( CommentId != null ) {
            this.CommentId = CommentId;
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
        //      C# -> System.String? CommentId
        // GraphQL -> commentId: String! (scalar)
        if (this.CommentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "commentId\n" ;
            } else {
                s += ind + "commentId\n" ;
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
        //      C# -> System.String? CommentId
        // GraphQL -> commentId: String! (scalar)
        if (ec.Includes("commentId",true))
        {
            if(this.CommentId == null) {

                this.CommentId = "FETCH";

            } else {


            }
        }
        else if (this.CommentId != null && ec.Excludes("commentId",true))
        {
            this.CommentId = null;
        }
    }


    #endregion

    } // class ReopenSupportCaseReply
    
    #endregion

    public static class ListReopenSupportCaseReplyExtensions
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
            this List<ReopenSupportCaseReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReopenSupportCaseReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReopenSupportCaseReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReopenSupportCaseReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReopenSupportCaseReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types