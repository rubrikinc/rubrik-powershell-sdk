// O365FullSpDescendant.cs
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
    #region O365FullSpDescendant
 
    public class O365FullSpDescendant: BaseType, O365FullSpObject
    {
        #region members

        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
        [JsonProperty("objectType")]
        public SharePointDescendantType? ObjectType { get; set; }

        //      C# -> DateTime? CreateTime
        // GraphQL -> createTime: DateTime (scalar)
        [JsonProperty("createTime")]
        public DateTime? CreateTime { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        [JsonProperty("modifiedTime")]
        public DateTime? ModifiedTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ParentId
        // GraphQL -> parentId: String (scalar)
        [JsonProperty("parentId")]
        public System.String? ParentId { get; set; }

        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        [JsonProperty("sharepointId")]
        public System.String? SharepointId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        [JsonProperty("snapshotNum")]
        public System.Int32? SnapshotNum { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365FullSpDescendant";
    }

    public O365FullSpDescendant Set(
        SharePointDescendantType? ObjectType = null,
        DateTime? CreateTime = null,
        System.String? Fid = null,
        DateTime? ModifiedTime = null,
        System.String? Name = null,
        System.String? ParentId = null,
        System.String? SharepointId = null,
        System.String? SnapshotId = null,
        System.Int32? SnapshotNum = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( CreateTime != null ) {
            this.CreateTime = CreateTime;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( ModifiedTime != null ) {
            this.ModifiedTime = ModifiedTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ParentId != null ) {
            this.ParentId = ParentId;
        }
        if ( SharepointId != null ) {
            this.SharepointId = SharepointId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SnapshotNum != null ) {
            this.SnapshotNum = SnapshotNum;
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
        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> DateTime? CreateTime
        // GraphQL -> createTime: DateTime (scalar)
        if (this.CreateTime != null) {
            s += ind + "createTime\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        if (this.ModifiedTime != null) {
            s += ind + "modifiedTime\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? ParentId
        // GraphQL -> parentId: String (scalar)
        if (this.ParentId != null) {
            s += ind + "parentId\n" ;
        }
        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        if (this.SharepointId != null) {
            s += ind + "sharepointId\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (this.SnapshotNum != null) {
            s += ind + "snapshotNum\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new SharePointDescendantType();
        }
        //      C# -> DateTime? CreateTime
        // GraphQL -> createTime: DateTime (scalar)
        if (this.CreateTime == null && Exploration.Includes(parent + ".createTime", true))
        {
            this.CreateTime = new DateTime();
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid == null && Exploration.Includes(parent + ".fid", true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        if (this.ModifiedTime == null && Exploration.Includes(parent + ".modifiedTime", true))
        {
            this.ModifiedTime = new DateTime();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? ParentId
        // GraphQL -> parentId: String (scalar)
        if (this.ParentId == null && Exploration.Includes(parent + ".parentId", true))
        {
            this.ParentId = "FETCH";
        }
        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        if (this.SharepointId == null && Exploration.Includes(parent + ".sharepointId", true))
        {
            this.SharepointId = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        if (this.SnapshotNum == null && Exploration.Includes(parent + ".snapshotNum", true))
        {
            this.SnapshotNum = Int32.MinValue;
        }
    }


    #endregion

    } // class O365FullSpDescendant
    
    #endregion

    public static class ListO365FullSpDescendantExtensions
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
            this List<O365FullSpDescendant> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365FullSpDescendant> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365FullSpDescendant());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types