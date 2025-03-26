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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
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
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
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
        //      C# -> System.String? ParentId
        // GraphQL -> parentId: String (scalar)
        if (this.ParentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentId\n" ;
            } else {
                s += ind + "parentId\n" ;
            }
        }
        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        if (this.SharepointId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sharepointId\n" ;
            } else {
                s += ind + "sharepointId\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
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
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
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
        //      C# -> System.String? ParentId
        // GraphQL -> parentId: String (scalar)
        if (ec.Includes("parentId",true))
        {
            if(this.ParentId == null) {

                this.ParentId = "FETCH";

            } else {


            }
        }
        else if (this.ParentId != null && ec.Excludes("parentId",true))
        {
            this.ParentId = null;
        }
        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        if (ec.Includes("sharepointId",true))
        {
            if(this.SharepointId == null) {

                this.SharepointId = "FETCH";

            } else {


            }
        }
        else if (this.SharepointId != null && ec.Excludes("sharepointId",true))
        {
            this.SharepointId = null;
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
    }


    #endregion

    } // class O365FullSpDescendant
    
    #endregion

    public static class ListO365FullSpDescendantExtensions
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
            this List<O365FullSpDescendant> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365FullSpDescendant> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365FullSpDescendant> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365FullSpDescendant());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365FullSpDescendant> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types