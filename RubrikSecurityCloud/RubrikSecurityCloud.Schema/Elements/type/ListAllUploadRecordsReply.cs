// ListAllUploadRecordsReply.cs
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
    #region ListAllUploadRecordsReply
    public class ListAllUploadRecordsReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? ShowList
        // GraphQL -> showList: Boolean! (scalar)
        [JsonProperty("showList")]
        public System.Boolean? ShowList { get; set; }

        //      C# -> List<ActiveUpload>? ActiveUploads
        // GraphQL -> activeUploads: [ActiveUpload!]! (type)
        [JsonProperty("activeUploads")]
        public List<ActiveUpload>? ActiveUploads { get; set; }

        //      C# -> List<CompletedUpload>? CompletedUploads
        // GraphQL -> completedUploads: [CompletedUpload!]! (type)
        [JsonProperty("completedUploads")]
        public List<CompletedUpload>? CompletedUploads { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ListAllUploadRecordsReply";
    }

    public ListAllUploadRecordsReply Set(
        System.Boolean? ShowList = null,
        List<ActiveUpload>? ActiveUploads = null,
        List<CompletedUpload>? CompletedUploads = null
    ) 
    {
        if ( ShowList != null ) {
            this.ShowList = ShowList;
        }
        if ( ActiveUploads != null ) {
            this.ActiveUploads = ActiveUploads;
        }
        if ( CompletedUploads != null ) {
            this.CompletedUploads = CompletedUploads;
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
        //      C# -> System.Boolean? ShowList
        // GraphQL -> showList: Boolean! (scalar)
        if (this.ShowList != null) {
            if (conf.Flat) {
                s += conf.Prefix + "showList\n" ;
            } else {
                s += ind + "showList\n" ;
            }
        }
        //      C# -> List<ActiveUpload>? ActiveUploads
        // GraphQL -> activeUploads: [ActiveUpload!]! (type)
        if (this.ActiveUploads != null) {
            var fspec = this.ActiveUploads.AsFieldSpec(conf.Child("activeUploads"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activeUploads" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CompletedUpload>? CompletedUploads
        // GraphQL -> completedUploads: [CompletedUpload!]! (type)
        if (this.CompletedUploads != null) {
            var fspec = this.CompletedUploads.AsFieldSpec(conf.Child("completedUploads"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "completedUploads" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? ShowList
        // GraphQL -> showList: Boolean! (scalar)
        if (ec.Includes("showList",true))
        {
            if(this.ShowList == null) {

                this.ShowList = true;

            } else {


            }
        }
        else if (this.ShowList != null && ec.Excludes("showList",true))
        {
            this.ShowList = null;
        }
        //      C# -> List<ActiveUpload>? ActiveUploads
        // GraphQL -> activeUploads: [ActiveUpload!]! (type)
        if (ec.Includes("activeUploads",false))
        {
            if(this.ActiveUploads == null) {

                this.ActiveUploads = new List<ActiveUpload>();
                this.ActiveUploads.ApplyExploratoryFieldSpec(ec.NewChild("activeUploads"));

            } else {

                this.ActiveUploads.ApplyExploratoryFieldSpec(ec.NewChild("activeUploads"));

            }
        }
        else if (this.ActiveUploads != null && ec.Excludes("activeUploads",false))
        {
            this.ActiveUploads = null;
        }
        //      C# -> List<CompletedUpload>? CompletedUploads
        // GraphQL -> completedUploads: [CompletedUpload!]! (type)
        if (ec.Includes("completedUploads",false))
        {
            if(this.CompletedUploads == null) {

                this.CompletedUploads = new List<CompletedUpload>();
                this.CompletedUploads.ApplyExploratoryFieldSpec(ec.NewChild("completedUploads"));

            } else {

                this.CompletedUploads.ApplyExploratoryFieldSpec(ec.NewChild("completedUploads"));

            }
        }
        else if (this.CompletedUploads != null && ec.Excludes("completedUploads",false))
        {
            this.CompletedUploads = null;
        }
    }


    #endregion

    } // class ListAllUploadRecordsReply
    
    #endregion

    public static class ListListAllUploadRecordsReplyExtensions
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
            this List<ListAllUploadRecordsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ListAllUploadRecordsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ListAllUploadRecordsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ListAllUploadRecordsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ListAllUploadRecordsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types