// RemediationTicketInfo.cs
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
    #region RemediationTicketInfo
 
    public class RemediationTicketInfo: BaseType, RemediationDetailsUnion
    {
        #region members

        //      C# -> List<RemediationTicketAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [RemediationTicketAttachmentType!]! (enum)
        [JsonProperty("attachmentTypes")]
        public List<RemediationTicketAttachmentType>? AttachmentTypes { get; set; }

        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        [JsonProperty("comment")]
        public System.String? Comment { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RemediationTicketInfo";
    }

    public RemediationTicketInfo Set(
        List<RemediationTicketAttachmentType>? AttachmentTypes = null,
        System.String? Comment = null,
        System.String? Reason = null,
        System.String? Title = null
    ) 
    {
        if ( AttachmentTypes != null ) {
            this.AttachmentTypes = AttachmentTypes;
        }
        if ( Comment != null ) {
            this.Comment = Comment;
        }
        if ( Reason != null ) {
            this.Reason = Reason;
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
        //      C# -> List<RemediationTicketAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [RemediationTicketAttachmentType!]! (enum)
        if (this.AttachmentTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachmentTypes\n" ;
            } else {
                s += ind + "attachmentTypes\n" ;
            }
        }
        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        if (this.Comment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "comment\n" ;
            } else {
                s += ind + "comment\n" ;
            }
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        if (this.Reason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reason\n" ;
            } else {
                s += ind + "reason\n" ;
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
        //      C# -> List<RemediationTicketAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [RemediationTicketAttachmentType!]! (enum)
        if (ec.Includes("attachmentTypes",true))
        {
            if(this.AttachmentTypes == null) {

                this.AttachmentTypes = new List<RemediationTicketAttachmentType>();

            } else {


            }
        }
        else if (this.AttachmentTypes != null && ec.Excludes("attachmentTypes",true))
        {
            this.AttachmentTypes = null;
        }
        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        if (ec.Includes("comment",true))
        {
            if(this.Comment == null) {

                this.Comment = "FETCH";

            } else {


            }
        }
        else if (this.Comment != null && ec.Excludes("comment",true))
        {
            this.Comment = null;
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        if (ec.Includes("reason",true))
        {
            if(this.Reason == null) {

                this.Reason = "FETCH";

            } else {


            }
        }
        else if (this.Reason != null && ec.Excludes("reason",true))
        {
            this.Reason = null;
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

    } // class RemediationTicketInfo
    
    #endregion

    public static class ListRemediationTicketInfoExtensions
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
            this List<RemediationTicketInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RemediationTicketInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RemediationTicketInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RemediationTicketInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RemediationTicketInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types