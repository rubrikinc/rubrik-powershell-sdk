// SupportCaseComment.cs
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
    #region SupportCaseComment
    public class SupportCaseComment: BaseType
    {
        #region members

        //      C# -> System.String? CommentBody
        // GraphQL -> commentBody: String! (scalar)
        [JsonProperty("commentBody")]
        public System.String? CommentBody { get; set; }

        //      C# -> System.String? CreatedByEmail
        // GraphQL -> createdByEmail: String! (scalar)
        [JsonProperty("createdByEmail")]
        public System.String? CreatedByEmail { get; set; }

        //      C# -> System.String? CreatedByName
        // GraphQL -> createdByName: String! (scalar)
        [JsonProperty("createdByName")]
        public System.String? CreatedByName { get; set; }

        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        [JsonProperty("createdDate")]
        public DateTime? CreatedDate { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SupportCaseComment";
    }

    public SupportCaseComment Set(
        System.String? CommentBody = null,
        System.String? CreatedByEmail = null,
        System.String? CreatedByName = null,
        DateTime? CreatedDate = null,
        System.String? Id = null
    ) 
    {
        if ( CommentBody != null ) {
            this.CommentBody = CommentBody;
        }
        if ( CreatedByEmail != null ) {
            this.CreatedByEmail = CreatedByEmail;
        }
        if ( CreatedByName != null ) {
            this.CreatedByName = CreatedByName;
        }
        if ( CreatedDate != null ) {
            this.CreatedDate = CreatedDate;
        }
        if ( Id != null ) {
            this.Id = Id;
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
        //      C# -> System.String? CommentBody
        // GraphQL -> commentBody: String! (scalar)
        if (this.CommentBody != null) {
            if (conf.Flat) {
                s += conf.Prefix + "commentBody\n" ;
            } else {
                s += ind + "commentBody\n" ;
            }
        }
        //      C# -> System.String? CreatedByEmail
        // GraphQL -> createdByEmail: String! (scalar)
        if (this.CreatedByEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdByEmail\n" ;
            } else {
                s += ind + "createdByEmail\n" ;
            }
        }
        //      C# -> System.String? CreatedByName
        // GraphQL -> createdByName: String! (scalar)
        if (this.CreatedByName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdByName\n" ;
            } else {
                s += ind + "createdByName\n" ;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? CommentBody
        // GraphQL -> commentBody: String! (scalar)
        if (ec.Includes("commentBody",true))
        {
            if(this.CommentBody == null) {

                this.CommentBody = "FETCH";

            } else {


            }
        }
        else if (this.CommentBody != null && ec.Excludes("commentBody",true))
        {
            this.CommentBody = null;
        }
        //      C# -> System.String? CreatedByEmail
        // GraphQL -> createdByEmail: String! (scalar)
        if (ec.Includes("createdByEmail",true))
        {
            if(this.CreatedByEmail == null) {

                this.CreatedByEmail = "FETCH";

            } else {


            }
        }
        else if (this.CreatedByEmail != null && ec.Excludes("createdByEmail",true))
        {
            this.CreatedByEmail = null;
        }
        //      C# -> System.String? CreatedByName
        // GraphQL -> createdByName: String! (scalar)
        if (ec.Includes("createdByName",true))
        {
            if(this.CreatedByName == null) {

                this.CreatedByName = "FETCH";

            } else {


            }
        }
        else if (this.CreatedByName != null && ec.Excludes("createdByName",true))
        {
            this.CreatedByName = null;
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
    }


    #endregion

    } // class SupportCaseComment
    
    #endregion

    public static class ListSupportCaseCommentExtensions
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
            this List<SupportCaseComment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SupportCaseComment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SupportCaseComment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SupportCaseComment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SupportCaseComment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types