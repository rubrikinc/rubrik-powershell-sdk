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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? CreateSnapshotNum
        // GraphQL -> createSnapshotNum: Int! (scalar)
        if (this.CreateSnapshotNum != null) {
            s += ind + "createSnapshotNum\n" ;
        }
        //      C# -> System.Int64? CreateTimeInMillis
        // GraphQL -> createTimeInMillis: Long! (scalar)
        if (this.CreateTimeInMillis != null) {
            s += ind + "createTimeInMillis\n" ;
        }
        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        if (this.ErrorMsg != null) {
            s += ind + "errorMsg\n" ;
        }
        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        if (this.ErrorType != null) {
            s += ind + "errorType\n" ;
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted != null) {
            s += ind + "isDeleted\n" ;
        }
        //      C# -> System.String? ItemId
        // GraphQL -> itemId: String! (scalar)
        if (this.ItemId != null) {
            s += ind + "itemId\n" ;
        }
        //      C# -> System.String? ItemMetadata
        // GraphQL -> itemMetadata: String! (scalar)
        if (this.ItemMetadata != null) {
            s += ind + "itemMetadata\n" ;
        }
        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        if (this.ItemName != null) {
            s += ind + "itemName\n" ;
        }
        //      C# -> System.String? ItemType
        // GraphQL -> itemType: String! (scalar)
        if (this.ItemType != null) {
            s += ind + "itemType\n" ;
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (this.SizeInBytes != null) {
            s += ind + "sizeInBytes\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? CreateSnapshotNum
        // GraphQL -> createSnapshotNum: Int! (scalar)
        if (this.CreateSnapshotNum == null && ec.Includes("createSnapshotNum",true))
        {
            this.CreateSnapshotNum = Int32.MinValue;
        }
        //      C# -> System.Int64? CreateTimeInMillis
        // GraphQL -> createTimeInMillis: Long! (scalar)
        if (this.CreateTimeInMillis == null && ec.Includes("createTimeInMillis",true))
        {
            this.CreateTimeInMillis = new System.Int64();
        }
        //      C# -> System.String? ErrorMsg
        // GraphQL -> errorMsg: String! (scalar)
        if (this.ErrorMsg == null && ec.Includes("errorMsg",true))
        {
            this.ErrorMsg = "FETCH";
        }
        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        if (this.ErrorType == null && ec.Includes("errorType",true))
        {
            this.ErrorType = "FETCH";
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted == null && ec.Includes("isDeleted",true))
        {
            this.IsDeleted = true;
        }
        //      C# -> System.String? ItemId
        // GraphQL -> itemId: String! (scalar)
        if (this.ItemId == null && ec.Includes("itemId",true))
        {
            this.ItemId = "FETCH";
        }
        //      C# -> System.String? ItemMetadata
        // GraphQL -> itemMetadata: String! (scalar)
        if (this.ItemMetadata == null && ec.Includes("itemMetadata",true))
        {
            this.ItemMetadata = "FETCH";
        }
        //      C# -> System.String? ItemName
        // GraphQL -> itemName: String! (scalar)
        if (this.ItemName == null && ec.Includes("itemName",true))
        {
            this.ItemName = "FETCH";
        }
        //      C# -> System.String? ItemType
        // GraphQL -> itemType: String! (scalar)
        if (this.ItemType == null && ec.Includes("itemType",true))
        {
            this.ItemType = "FETCH";
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (this.SizeInBytes == null && ec.Includes("sizeInBytes",true))
        {
            this.SizeInBytes = new System.Int64();
        }
    }


    #endregion

    } // class SkippedItemInfo
    
    #endregion

    public static class ListSkippedItemInfoExtensions
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
            this List<SkippedItemInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<SkippedItemInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types