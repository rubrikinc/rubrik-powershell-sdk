// DownloadCaseAttachmentReply.cs
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
    #region DownloadCaseAttachmentReply
    public class DownloadCaseAttachmentReply: BaseType
    {
        #region members

        //      C# -> System.String? ContentType
        // GraphQL -> contentType: String! (scalar)
        [JsonProperty("contentType")]
        public System.String? ContentType { get; set; }

        //      C# -> System.String? Data
        // GraphQL -> data: String! (scalar)
        [JsonProperty("data")]
        public System.String? Data { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DownloadCaseAttachmentReply";
    }

    public DownloadCaseAttachmentReply Set(
        System.String? ContentType = null,
        System.String? Data = null,
        System.String? FileName = null
    ) 
    {
        if ( ContentType != null ) {
            this.ContentType = ContentType;
        }
        if ( Data != null ) {
            this.Data = Data;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
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
        //      C# -> System.String? ContentType
        // GraphQL -> contentType: String! (scalar)
        if (this.ContentType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contentType\n" ;
            } else {
                s += ind + "contentType\n" ;
            }
        }
        //      C# -> System.String? Data
        // GraphQL -> data: String! (scalar)
        if (this.Data != null) {
            if (conf.Flat) {
                s += conf.Prefix + "data\n" ;
            } else {
                s += ind + "data\n" ;
            }
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileName\n" ;
            } else {
                s += ind + "fileName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ContentType
        // GraphQL -> contentType: String! (scalar)
        if (ec.Includes("contentType",true))
        {
            if(this.ContentType == null) {

                this.ContentType = "FETCH";

            } else {


            }
        }
        else if (this.ContentType != null && ec.Excludes("contentType",true))
        {
            this.ContentType = null;
        }
        //      C# -> System.String? Data
        // GraphQL -> data: String! (scalar)
        if (ec.Includes("data",true))
        {
            if(this.Data == null) {

                this.Data = "FETCH";

            } else {


            }
        }
        else if (this.Data != null && ec.Excludes("data",true))
        {
            this.Data = null;
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (ec.Includes("fileName",true))
        {
            if(this.FileName == null) {

                this.FileName = "FETCH";

            } else {


            }
        }
        else if (this.FileName != null && ec.Excludes("fileName",true))
        {
            this.FileName = null;
        }
    }


    #endregion

    } // class DownloadCaseAttachmentReply
    
    #endregion

    public static class ListDownloadCaseAttachmentReplyExtensions
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
            this List<DownloadCaseAttachmentReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DownloadCaseAttachmentReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DownloadCaseAttachmentReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DownloadCaseAttachmentReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DownloadCaseAttachmentReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types