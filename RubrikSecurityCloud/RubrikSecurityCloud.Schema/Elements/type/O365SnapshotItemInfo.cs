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
        if ( O365ReplyFields != null ) {
            this.O365ReplyFields = O365ReplyFields;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? FolderIdsTillRoot
        // GraphQL -> folderIdsTillRoot: [String!]! (scalar)
        if (this.FolderIdsTillRoot != null) {
            s += ind + "folderIdsTillRoot\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId != null) {
            s += ind + "parentFolderId\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (this.SnapshotNum != null) {
            s += ind + "snapshotNum\n" ;
        }
        //      C# -> O365ReplyFields? O365ReplyFields
        // GraphQL -> o365ReplyFields: O365ReplyFields! (type)
        if (this.O365ReplyFields != null) {
            var fspec = this.O365ReplyFields.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "o365ReplyFields {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? FolderIdsTillRoot
        // GraphQL -> folderIdsTillRoot: [String!]! (scalar)
        if (this.FolderIdsTillRoot == null && ec.Includes("folderIdsTillRoot",true))
        {
            this.FolderIdsTillRoot = new List<System.String>();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        if (this.ParentFolderId == null && ec.Includes("parentFolderId",true))
        {
            this.ParentFolderId = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId == null && ec.Includes("snapshotId",true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (this.SnapshotNum == null && ec.Includes("snapshotNum",true))
        {
            this.SnapshotNum = Int32.MinValue;
        }
        //      C# -> O365ReplyFields? O365ReplyFields
        // GraphQL -> o365ReplyFields: O365ReplyFields! (type)
        if (this.O365ReplyFields == null && ec.Includes("o365ReplyFields",false))
        {
            this.O365ReplyFields = new O365ReplyFields();
            this.O365ReplyFields.ApplyExploratoryFieldSpec(ec.NewChild("o365ReplyFields"));
        }
    }


    #endregion

    } // class O365SnapshotItemInfo
    
    #endregion

    public static class ListO365SnapshotItemInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<O365SnapshotItemInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365SnapshotItemInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365SnapshotItemInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<O365SnapshotItemInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types