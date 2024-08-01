// SkippedItemInfo.cs
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
    #region SkippedItemInfo
    public class SkippedItemInfo: BaseType
    {
        #region members

        //      C# -> System.Int32? CreateSnapshotNum
        // GraphQL -> createSnapshotNum: Int! (scalar)
        [JsonProperty("createSnapshotNum")]
        public System.Int32? CreateSnapshotNum { get; set; }

        //      C# -> System.Int64? CreateTimeInMillis
        // GraphQL -> createTimeInMillis: Long! (scalar)
        [JsonProperty("createTimeInMillis")]
        public System.Int64? CreateTimeInMillis { get; set; }

        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        [JsonProperty("errorMsg")]
        public System.String? ErrorMsg { get; set; }

        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        [JsonProperty("errorType")]
        public System.String? ErrorType { get; set; }

        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        [JsonProperty("isDeleted")]
        public System.Boolean? IsDeleted { get; set; }

        //      C# -> System.String? ItemId
        // GraphQL -> itemId: String! (scalar)
        [JsonProperty("itemId")]
        public System.String? ItemId { get; set; }

        //      C# -> System.String? ItemMetadata
        // GraphQL -> itemMetadata: String! (scalar)
        [JsonProperty("itemMetadata")]
        public System.String? ItemMetadata { get; set; }

        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        [JsonProperty("itemName")]
        public System.String? ItemName { get; set; }

        //      C# -> System.String? ItemType
        // GraphQL -> itemType: String! (scalar)
        [JsonProperty("itemType")]
        public System.String? ItemType { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SkippedItemInfo";
    }

    public SkippedItemInfo Set(
        System.Int32? CreateSnapshotNum = null,
        System.Int64? CreateTimeInMillis = null,
        System.String? ErrorMsg = null,
        System.String? ErrorType = null,
        System.Boolean? IsDeleted = null,
        System.String? ItemId = null,
        System.String? ItemMetadata = null,
        System.String? ItemName = null,
        System.String? ItemType = null,
        System.Int64? SizeInBytes = null
    ) 
    {
        if ( CreateSnapshotNum != null ) {
            this.CreateSnapshotNum = CreateSnapshotNum;
        }
        if ( CreateTimeInMillis != null ) {
            this.CreateTimeInMillis = CreateTimeInMillis;
        }
        if ( ErrorMsg != null ) {
            this.ErrorMsg = ErrorMsg;
        }
        if ( ErrorType != null ) {
            this.ErrorType = ErrorType;
        }
        if ( IsDeleted != null ) {
            this.IsDeleted = IsDeleted;
        }
        if ( ItemId != null ) {
            this.ItemId = ItemId;
        }
        if ( ItemMetadata != null ) {
            this.ItemMetadata = ItemMetadata;
        }
        if ( ItemName != null ) {
            this.ItemName = ItemName;
        }
        if ( ItemType != null ) {
            this.ItemType = ItemType;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
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
        //      C# -> System.Int32? CreateSnapshotNum
        // GraphQL -> createSnapshotNum: Int! (scalar)
        if (this.CreateSnapshotNum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createSnapshotNum\n" ;
            } else {
                s += ind + "createSnapshotNum\n" ;
            }
        }
        //      C# -> System.Int64? CreateTimeInMillis
        // GraphQL -> createTimeInMillis: Long! (scalar)
        if (this.CreateTimeInMillis != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createTimeInMillis\n" ;
            } else {
                s += ind + "createTimeInMillis\n" ;
            }
        }
        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        if (this.ErrorMsg != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMsg\n" ;
            } else {
                s += ind + "errorMsg\n" ;
            }
        }
        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        if (this.ErrorType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorType\n" ;
            } else {
                s += ind + "errorType\n" ;
            }
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDeleted\n" ;
            } else {
                s += ind + "isDeleted\n" ;
            }
        }
        //      C# -> System.String? ItemId
        // GraphQL -> itemId: String! (scalar)
        if (this.ItemId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemId\n" ;
            } else {
                s += ind + "itemId\n" ;
            }
        }
        //      C# -> System.String? ItemMetadata
        // GraphQL -> itemMetadata: String! (scalar)
        if (this.ItemMetadata != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemMetadata\n" ;
            } else {
                s += ind + "itemMetadata\n" ;
            }
        }
        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        if (this.ItemName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemName\n" ;
            } else {
                s += ind + "itemName\n" ;
            }
        }
        //      C# -> System.String? ItemType
        // GraphQL -> itemType: String! (scalar)
        if (this.ItemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemType\n" ;
            } else {
                s += ind + "itemType\n" ;
            }
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (this.SizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sizeInBytes\n" ;
            } else {
                s += ind + "sizeInBytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? CreateSnapshotNum
        // GraphQL -> createSnapshotNum: Int! (scalar)
        if (ec.Includes("createSnapshotNum",true))
        {
            if(this.CreateSnapshotNum == null) {

                this.CreateSnapshotNum = Int32.MinValue;

            } else {


            }
        }
        else if (this.CreateSnapshotNum != null && ec.Excludes("createSnapshotNum",true))
        {
            this.CreateSnapshotNum = null;
        }
        //      C# -> System.Int64? CreateTimeInMillis
        // GraphQL -> createTimeInMillis: Long! (scalar)
        if (ec.Includes("createTimeInMillis",true))
        {
            if(this.CreateTimeInMillis == null) {

                this.CreateTimeInMillis = new System.Int64();

            } else {


            }
        }
        else if (this.CreateTimeInMillis != null && ec.Excludes("createTimeInMillis",true))
        {
            this.CreateTimeInMillis = null;
        }
        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        if (ec.Includes("errorMsg",true))
        {
            if(this.ErrorMsg == null) {

                this.ErrorMsg = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMsg != null && ec.Excludes("errorMsg",true))
        {
            this.ErrorMsg = null;
        }
        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        if (ec.Includes("errorType",true))
        {
            if(this.ErrorType == null) {

                this.ErrorType = "FETCH";

            } else {


            }
        }
        else if (this.ErrorType != null && ec.Excludes("errorType",true))
        {
            this.ErrorType = null;
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (ec.Includes("isDeleted",true))
        {
            if(this.IsDeleted == null) {

                this.IsDeleted = true;

            } else {


            }
        }
        else if (this.IsDeleted != null && ec.Excludes("isDeleted",true))
        {
            this.IsDeleted = null;
        }
        //      C# -> System.String? ItemId
        // GraphQL -> itemId: String! (scalar)
        if (ec.Includes("itemId",true))
        {
            if(this.ItemId == null) {

                this.ItemId = "FETCH";

            } else {


            }
        }
        else if (this.ItemId != null && ec.Excludes("itemId",true))
        {
            this.ItemId = null;
        }
        //      C# -> System.String? ItemMetadata
        // GraphQL -> itemMetadata: String! (scalar)
        if (ec.Includes("itemMetadata",true))
        {
            if(this.ItemMetadata == null) {

                this.ItemMetadata = "FETCH";

            } else {


            }
        }
        else if (this.ItemMetadata != null && ec.Excludes("itemMetadata",true))
        {
            this.ItemMetadata = null;
        }
        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        if (ec.Includes("itemName",true))
        {
            if(this.ItemName == null) {

                this.ItemName = "FETCH";

            } else {


            }
        }
        else if (this.ItemName != null && ec.Excludes("itemName",true))
        {
            this.ItemName = null;
        }
        //      C# -> System.String? ItemType
        // GraphQL -> itemType: String! (scalar)
        if (ec.Includes("itemType",true))
        {
            if(this.ItemType == null) {

                this.ItemType = "FETCH";

            } else {


            }
        }
        else if (this.ItemType != null && ec.Excludes("itemType",true))
        {
            this.ItemType = null;
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (ec.Includes("sizeInBytes",true))
        {
            if(this.SizeInBytes == null) {

                this.SizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.SizeInBytes != null && ec.Excludes("sizeInBytes",true))
        {
            this.SizeInBytes = null;
        }
    }


    #endregion

    } // class SkippedItemInfo
    
    #endregion

    public static class ListSkippedItemInfoExtensions
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
            this List<SkippedItemInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SkippedItemInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SkippedItemInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SkippedItemInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SkippedItemInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types