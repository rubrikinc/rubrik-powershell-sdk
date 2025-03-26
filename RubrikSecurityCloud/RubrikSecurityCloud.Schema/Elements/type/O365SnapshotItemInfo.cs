// O365SnapshotItemInfo.cs
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
    #region O365SnapshotItemInfo
    public class O365SnapshotItemInfo: BaseType
    {
        #region members

        //      C# -> List<System.String>? FolderIdsTillRoot
        // GraphQL -> folderIdsTillRoot: [String!]! (scalar)
        [JsonProperty("folderIdsTillRoot")]
        public List<System.String>? FolderIdsTillRoot { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        [JsonProperty("parentFolderId")]
        public System.String? ParentFolderId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        [JsonProperty("snapshotNum")]
        public System.Int32? SnapshotNum { get; set; }

        //      C# -> MetadataFields? Metadata
        // GraphQL -> metadata: MetadataFields (type)
        [JsonProperty("metadata")]
        public MetadataFields? Metadata { get; set; }

        //      C# -> O365ReplyFields? O365ReplyFields
        // GraphQL -> o365ReplyFields: O365ReplyFields! (type)
        [JsonProperty("o365ReplyFields")]
        public O365ReplyFields? O365ReplyFields { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365SnapshotItemInfo";
    }

    public O365SnapshotItemInfo Set(
        List<System.String>? FolderIdsTillRoot = null,
        System.String? Id = null,
        System.String? ParentFolderId = null,
        System.String? SnapshotId = null,
        System.Int32? SnapshotNum = null,
        MetadataFields? Metadata = null,
        O365ReplyFields? O365ReplyFields = null
    ) 
    {
        if ( FolderIdsTillRoot != null ) {
            this.FolderIdsTillRoot = FolderIdsTillRoot;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ParentFolderId != null ) {
            this.ParentFolderId = ParentFolderId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SnapshotNum != null ) {
            this.SnapshotNum = SnapshotNum;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
        }
        if ( O365ReplyFields != null ) {
            this.O365ReplyFields = O365ReplyFields;
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
        //      C# -> List<System.String>? FolderIdsTillRoot
        // GraphQL -> folderIdsTillRoot: [String!]! (scalar)
        if (this.FolderIdsTillRoot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "folderIdsTillRoot\n" ;
            } else {
                s += ind + "folderIdsTillRoot\n" ;
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
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentFolderId\n" ;
            } else {
                s += ind + "parentFolderId\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (this.SnapshotNum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotNum\n" ;
            } else {
                s += ind + "snapshotNum\n" ;
            }
        }
        //      C# -> MetadataFields? Metadata
        // GraphQL -> metadata: MetadataFields (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(conf.Child("metadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> O365ReplyFields? O365ReplyFields
        // GraphQL -> o365ReplyFields: O365ReplyFields! (type)
        if (this.O365ReplyFields != null) {
            var fspec = this.O365ReplyFields.AsFieldSpec(conf.Child("o365ReplyFields"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "o365ReplyFields" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? FolderIdsTillRoot
        // GraphQL -> folderIdsTillRoot: [String!]! (scalar)
        if (ec.Includes("folderIdsTillRoot",true))
        {
            if(this.FolderIdsTillRoot == null) {

                this.FolderIdsTillRoot = new List<System.String>();

            } else {


            }
        }
        else if (this.FolderIdsTillRoot != null && ec.Excludes("folderIdsTillRoot",true))
        {
            this.FolderIdsTillRoot = null;
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
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (ec.Includes("parentFolderId",true))
        {
            if(this.ParentFolderId == null) {

                this.ParentFolderId = "FETCH";

            } else {


            }
        }
        else if (this.ParentFolderId != null && ec.Excludes("parentFolderId",true))
        {
            this.ParentFolderId = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (ec.Includes("snapshotNum",true))
        {
            if(this.SnapshotNum == null) {

                this.SnapshotNum = Int32.MinValue;

            } else {


            }
        }
        else if (this.SnapshotNum != null && ec.Excludes("snapshotNum",true))
        {
            this.SnapshotNum = null;
        }
        //      C# -> MetadataFields? Metadata
        // GraphQL -> metadata: MetadataFields (type)
        if (ec.Includes("metadata",false))
        {
            if(this.Metadata == null) {

                this.Metadata = new MetadataFields();
                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            } else {

                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",false))
        {
            this.Metadata = null;
        }
        //      C# -> O365ReplyFields? O365ReplyFields
        // GraphQL -> o365ReplyFields: O365ReplyFields! (type)
        if (ec.Includes("o365ReplyFields",false))
        {
            if(this.O365ReplyFields == null) {

                this.O365ReplyFields = new O365ReplyFields();
                this.O365ReplyFields.ApplyExploratoryFieldSpec(ec.NewChild("o365ReplyFields"));

            } else {

                this.O365ReplyFields.ApplyExploratoryFieldSpec(ec.NewChild("o365ReplyFields"));

            }
        }
        else if (this.O365ReplyFields != null && ec.Excludes("o365ReplyFields",false))
        {
            this.O365ReplyFields = null;
        }
    }


    #endregion

    } // class O365SnapshotItemInfo
    
    #endregion

    public static class ListO365SnapshotItemInfoExtensions
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
            this List<O365SnapshotItemInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365SnapshotItemInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365SnapshotItemInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365SnapshotItemInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365SnapshotItemInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types