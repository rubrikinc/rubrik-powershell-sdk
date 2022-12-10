// O365SnapshotItemInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:19.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region O365SnapshotItemInfo
    public class O365SnapshotItemInfo: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? FolderIdsTillRoot
            // GraphQL -> folderIdsTillRoot: [String!]! (scalar)
            if (this.FolderIdsTillRoot != null)
            {
                 s += ind + "folderIdsTillRoot\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? ParentFolderId
            // GraphQL -> parentFolderId: String (scalar)
            if (this.ParentFolderId != null)
            {
                 s += ind + "parentFolderId\n";

            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> System.Int32? SnapshotNum
            // GraphQL -> snapshotNum: Int (scalar)
            if (this.SnapshotNum != null)
            {
                 s += ind + "snapshotNum\n";

            }
            //      C# -> O365ReplyFields? O365ReplyFields
            // GraphQL -> o365ReplyFields: O365ReplyFields! (type)
            if (this.O365ReplyFields != null)
            {
                 s += ind + "o365ReplyFields\n";

                 s += ind + "{\n" + 
                 this.O365ReplyFields.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? FolderIdsTillRoot
            // GraphQL -> folderIdsTillRoot: [String!]! (scalar)
            if (this.FolderIdsTillRoot == null && Exploration.Includes(parent + ".folderIdsTillRoot$"))
            {
                this.FolderIdsTillRoot = new List<System.String>();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? ParentFolderId
            // GraphQL -> parentFolderId: String (scalar)
            if (this.ParentFolderId == null && Exploration.Includes(parent + ".parentFolderId$"))
            {
                this.ParentFolderId = new System.String("FETCH");
            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> System.Int32? SnapshotNum
            // GraphQL -> snapshotNum: Int (scalar)
            if (this.SnapshotNum == null && Exploration.Includes(parent + ".snapshotNum$"))
            {
                this.SnapshotNum = new System.Int32();
            }
            //      C# -> O365ReplyFields? O365ReplyFields
            // GraphQL -> o365ReplyFields: O365ReplyFields! (type)
            if (this.O365ReplyFields == null && Exploration.Includes(parent + ".o365ReplyFields"))
            {
                this.O365ReplyFields = new O365ReplyFields();
                this.O365ReplyFields.ApplyExploratoryFragment(parent + ".o365ReplyFields");
            }
        }


    #endregion

    } // class O365SnapshotItemInfo
    #endregion

    public static class ListO365SnapshotItemInfoExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<O365SnapshotItemInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365SnapshotItemInfo> list, 
            String parent = "")
        {
            var item = new O365SnapshotItemInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types