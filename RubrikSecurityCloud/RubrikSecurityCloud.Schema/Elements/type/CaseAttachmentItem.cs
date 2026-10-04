// CaseAttachmentItem.cs
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
    #region CaseAttachmentItem
    public class CaseAttachmentItem: BaseType
    {
        #region members

        //      C# -> System.Int64? ContentSize
        // GraphQL -> contentSize: Long! (scalar)
        [JsonProperty("contentSize")]
        public System.Int64? ContentSize { get; set; }

        //      C# -> System.String? CreatedByName
        // GraphQL -> createdByName: String! (scalar)
        [JsonProperty("createdByName")]
        public System.String? CreatedByName { get; set; }

        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        [JsonProperty("createdDate")]
        public DateTime? CreatedDate { get; set; }

        //      C# -> System.String? FileExtension
        // GraphQL -> fileExtension: String! (scalar)
        [JsonProperty("fileExtension")]
        public System.String? FileExtension { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CaseAttachmentItem";
    }

    public CaseAttachmentItem Set(
        System.Int64? ContentSize = null,
        System.String? CreatedByName = null,
        DateTime? CreatedDate = null,
        System.String? FileExtension = null,
        System.String? Id = null,
        System.String? Title = null
    ) 
    {
        if ( ContentSize != null ) {
            this.ContentSize = ContentSize;
        }
        if ( CreatedByName != null ) {
            this.CreatedByName = CreatedByName;
        }
        if ( CreatedDate != null ) {
            this.CreatedDate = CreatedDate;
        }
        if ( FileExtension != null ) {
            this.FileExtension = FileExtension;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Title != null ) {
            this.Title = Title;
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
        //      C# -> System.Int64? ContentSize
        // GraphQL -> contentSize: Long! (scalar)
        if (this.ContentSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contentSize\n" ;
            } else {
                s += ind + "contentSize\n" ;
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
        //      C# -> System.String? FileExtension
        // GraphQL -> fileExtension: String! (scalar)
        if (this.FileExtension != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileExtension\n" ;
            } else {
                s += ind + "fileExtension\n" ;
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
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            if (conf.Flat) {
                s += conf.Prefix + "title\n" ;
            } else {
                s += ind + "title\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? ContentSize
        // GraphQL -> contentSize: Long! (scalar)
        if (ec.Includes("contentSize",true))
        {
            if(this.ContentSize == null) {

                this.ContentSize = new System.Int64();

            } else {


            }
        }
        else if (this.ContentSize != null && ec.Excludes("contentSize",true))
        {
            this.ContentSize = null;
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
        //      C# -> System.String? FileExtension
        // GraphQL -> fileExtension: String! (scalar)
        if (ec.Includes("fileExtension",true))
        {
            if(this.FileExtension == null) {

                this.FileExtension = "FETCH";

            } else {


            }
        }
        else if (this.FileExtension != null && ec.Excludes("fileExtension",true))
        {
            this.FileExtension = null;
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
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (ec.Includes("title",true))
        {
            if(this.Title == null) {

                this.Title = "FETCH";

            } else {


            }
        }
        else if (this.Title != null && ec.Excludes("title",true))
        {
            this.Title = null;
        }
    }


    #endregion

    } // class CaseAttachmentItem
    
    #endregion

    public static class ListCaseAttachmentItemExtensions
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
            this List<CaseAttachmentItem> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CaseAttachmentItem> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CaseAttachmentItem> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CaseAttachmentItem());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CaseAttachmentItem> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types