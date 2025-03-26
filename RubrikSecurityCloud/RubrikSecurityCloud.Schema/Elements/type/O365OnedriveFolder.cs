// O365OnedriveFolder.cs
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
    #region O365OnedriveFolder
 
    public class O365OnedriveFolder: BaseType, O365OnedriveObject
    {
        #region members

        //      C# -> ChannelMembershipType? ChannelMembershipType
        // GraphQL -> channelMembershipType: ChannelMembershipType (enum)
        [JsonProperty("channelMembershipType")]
        public ChannelMembershipType? ChannelMembershipType { get; set; }

        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType (enum)
        [JsonProperty("objectType")]
        public SharePointDescendantType? ObjectType { get; set; }

        //      C# -> System.String? ChannelFolderName
        // GraphQL -> channelFolderName: String (scalar)
        [JsonProperty("channelFolderName")]
        public System.String? ChannelFolderName { get; set; }

        //      C# -> System.String? ChannelId
        // GraphQL -> channelId: String (scalar)
        [JsonProperty("channelId")]
        public System.String? ChannelId { get; set; }

        //      C# -> System.String? ChannelName
        // GraphQL -> channelName: String (scalar)
        [JsonProperty("channelName")]
        public System.String? ChannelName { get; set; }

        //      C# -> DateTime? CreateTime
        // GraphQL -> createTime: DateTime (scalar)
        [JsonProperty("createTime")]
        public DateTime? CreateTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int32? ItemCount
        // GraphQL -> itemCount: Int (scalar)
        [JsonProperty("itemCount")]
        public System.Int32? ItemCount { get; set; }

        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        [JsonProperty("modifiedTime")]
        public DateTime? ModifiedTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ParentFolderId
        // GraphQL -> parentFolderId: String (scalar)
        [JsonProperty("parentFolderId")]
        public System.String? ParentFolderId { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        [JsonProperty("snapshotNum")]
        public System.Int32? SnapshotNum { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365OnedriveFolder";
    }

    public O365OnedriveFolder Set(
        ChannelMembershipType? ChannelMembershipType = null,
        SharePointDescendantType? ObjectType = null,
        System.String? ChannelFolderName = null,
        System.String? ChannelId = null,
        System.String? ChannelName = null,
        DateTime? CreateTime = null,
        System.String? Id = null,
        System.Int32? ItemCount = null,
        DateTime? ModifiedTime = null,
        System.String? Name = null,
        System.String? ParentFolderId = null,
        System.Int64? Size = null,
        System.String? SnapshotId = null,
        System.Int32? SnapshotNum = null,
        DateTime? SnapshotTime = null
    ) 
    {
        if ( ChannelMembershipType != null ) {
            this.ChannelMembershipType = ChannelMembershipType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ChannelFolderName != null ) {
            this.ChannelFolderName = ChannelFolderName;
        }
        if ( ChannelId != null ) {
            this.ChannelId = ChannelId;
        }
        if ( ChannelName != null ) {
            this.ChannelName = ChannelName;
        }
        if ( CreateTime != null ) {
            this.CreateTime = CreateTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ItemCount != null ) {
            this.ItemCount = ItemCount;
        }
        if ( ModifiedTime != null ) {
            this.ModifiedTime = ModifiedTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ParentFolderId != null ) {
            this.ParentFolderId = ParentFolderId;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SnapshotNum != null ) {
            this.SnapshotNum = SnapshotNum;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
        //      C# -> ChannelMembershipType? ChannelMembershipType
        // GraphQL -> channelMembershipType: ChannelMembershipType (enum)
        if (this.ChannelMembershipType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "channelMembershipType\n" ;
            } else {
                s += ind + "channelMembershipType\n" ;
            }
        }
        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.String? ChannelFolderName
        // GraphQL -> channelFolderName: String (scalar)
        if (this.ChannelFolderName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "channelFolderName\n" ;
            } else {
                s += ind + "channelFolderName\n" ;
            }
        }
        //      C# -> System.String? ChannelId
        // GraphQL -> channelId: String (scalar)
        if (this.ChannelId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "channelId\n" ;
            } else {
                s += ind + "channelId\n" ;
            }
        }
        //      C# -> System.String? ChannelName
        // GraphQL -> channelName: String (scalar)
        if (this.ChannelName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "channelName\n" ;
            } else {
                s += ind + "channelName\n" ;
            }
        }
        //      C# -> DateTime? CreateTime
        // GraphQL -> createTime: DateTime (scalar)
        if (this.CreateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createTime\n" ;
            } else {
                s += ind + "createTime\n" ;
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
        //      C# -> System.Int32? ItemCount
        // GraphQL -> itemCount: Int (scalar)
        if (this.ItemCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemCount\n" ;
            } else {
                s += ind + "itemCount\n" ;
            }
        }
        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        if (this.ModifiedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modifiedTime\n" ;
            } else {
                s += ind + "modifiedTime\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
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
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
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
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ChannelMembershipType? ChannelMembershipType
        // GraphQL -> channelMembershipType: ChannelMembershipType (enum)
        if (ec.Includes("channelMembershipType",true))
        {
            if(this.ChannelMembershipType == null) {

                this.ChannelMembershipType = new ChannelMembershipType();

            } else {


            }
        }
        else if (this.ChannelMembershipType != null && ec.Excludes("channelMembershipType",true))
        {
            this.ChannelMembershipType = null;
        }
        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new SharePointDescendantType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.String? ChannelFolderName
        // GraphQL -> channelFolderName: String (scalar)
        if (ec.Includes("channelFolderName",true))
        {
            if(this.ChannelFolderName == null) {

                this.ChannelFolderName = "FETCH";

            } else {


            }
        }
        else if (this.ChannelFolderName != null && ec.Excludes("channelFolderName",true))
        {
            this.ChannelFolderName = null;
        }
        //      C# -> System.String? ChannelId
        // GraphQL -> channelId: String (scalar)
        if (ec.Includes("channelId",true))
        {
            if(this.ChannelId == null) {

                this.ChannelId = "FETCH";

            } else {


            }
        }
        else if (this.ChannelId != null && ec.Excludes("channelId",true))
        {
            this.ChannelId = null;
        }
        //      C# -> System.String? ChannelName
        // GraphQL -> channelName: String (scalar)
        if (ec.Includes("channelName",true))
        {
            if(this.ChannelName == null) {

                this.ChannelName = "FETCH";

            } else {


            }
        }
        else if (this.ChannelName != null && ec.Excludes("channelName",true))
        {
            this.ChannelName = null;
        }
        //      C# -> DateTime? CreateTime
        // GraphQL -> createTime: DateTime (scalar)
        if (ec.Includes("createTime",true))
        {
            if(this.CreateTime == null) {

                this.CreateTime = new DateTime();

            } else {


            }
        }
        else if (this.CreateTime != null && ec.Excludes("createTime",true))
        {
            this.CreateTime = null;
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
        //      C# -> System.Int32? ItemCount
        // GraphQL -> itemCount: Int (scalar)
        if (ec.Includes("itemCount",true))
        {
            if(this.ItemCount == null) {

                this.ItemCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ItemCount != null && ec.Excludes("itemCount",true))
        {
            this.ItemCount = null;
        }
        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        if (ec.Includes("modifiedTime",true))
        {
            if(this.ModifiedTime == null) {

                this.ModifiedTime = new DateTime();

            } else {


            }
        }
        else if (this.ModifiedTime != null && ec.Excludes("modifiedTime",true))
        {
            this.ModifiedTime = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
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
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
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
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
    }


    #endregion

    } // class O365OnedriveFolder
    
    #endregion

    public static class ListO365OnedriveFolderExtensions
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
            this List<O365OnedriveFolder> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365OnedriveFolder> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365OnedriveFolder> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365OnedriveFolder());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365OnedriveFolder> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types