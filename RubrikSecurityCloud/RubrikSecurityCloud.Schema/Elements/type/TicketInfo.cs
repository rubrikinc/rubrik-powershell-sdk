// TicketInfo.cs
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
    #region TicketInfo
    public class TicketInfo: BaseType
    {
        #region members

        //      C# -> List<InsightTicketAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [InsightTicketAttachmentType!]! (enum)
        [JsonProperty("attachmentTypes")]
        public List<InsightTicketAttachmentType>? AttachmentTypes { get; set; }

        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        [JsonProperty("comment")]
        public System.String? Comment { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TicketInfo";
    }

    public TicketInfo Set(
        List<InsightTicketAttachmentType>? AttachmentTypes = null,
        System.String? Comment = null,
        System.String? Name = null,
        System.String? Reason = null
    ) 
    {
        if ( AttachmentTypes != null ) {
            this.AttachmentTypes = AttachmentTypes;
        }
        if ( Comment != null ) {
            this.Comment = Comment;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Reason != null ) {
            this.Reason = Reason;
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
        //      C# -> List<InsightTicketAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [InsightTicketAttachmentType!]! (enum)
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<InsightTicketAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [InsightTicketAttachmentType!]! (enum)
        if (ec.Includes("attachmentTypes",true))
        {
            if(this.AttachmentTypes == null) {

                this.AttachmentTypes = new List<InsightTicketAttachmentType>();

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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
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
    }


    #endregion

    } // class TicketInfo
    
    #endregion

    public static class ListTicketInfoExtensions
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
            this List<TicketInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TicketInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TicketInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TicketInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TicketInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types