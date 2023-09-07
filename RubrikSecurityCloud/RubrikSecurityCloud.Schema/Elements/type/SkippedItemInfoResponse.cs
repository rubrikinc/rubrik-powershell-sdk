// SkippedItemInfoResponse.cs
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
    #region SkippedItemInfoResponse
    public class SkippedItemInfoResponse: BaseType
    {
        #region members

        //      C# -> System.String? CsvDownloadLink
        // GraphQL -> csvDownloadLink: String! (scalar)
        [JsonProperty("csvDownloadLink")]
        public System.String? CsvDownloadLink { get; set; }

        //      C# -> List<SkippedItemInfo>? SkippedItems
        // GraphQL -> skippedItems: [SkippedItemInfo!]! (type)
        [JsonProperty("skippedItems")]
        public List<SkippedItemInfo>? SkippedItems { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SkippedItemInfoResponse";
    }

    public SkippedItemInfoResponse Set(
        System.String? CsvDownloadLink = null,
        List<SkippedItemInfo>? SkippedItems = null
    ) 
    {
        if ( CsvDownloadLink != null ) {
            this.CsvDownloadLink = CsvDownloadLink;
        }
        if ( SkippedItems != null ) {
            this.SkippedItems = SkippedItems;
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
        //      C# -> System.String? CsvDownloadLink
        // GraphQL -> csvDownloadLink: String! (scalar)
        if (this.CsvDownloadLink != null) {
            s += ind + "csvDownloadLink\n" ;
        }
        //      C# -> List<SkippedItemInfo>? SkippedItems
        // GraphQL -> skippedItems: [SkippedItemInfo!]! (type)
        if (this.SkippedItems != null) {
            var fspec = this.SkippedItems.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "skippedItems {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CsvDownloadLink
        // GraphQL -> csvDownloadLink: String! (scalar)
        if (this.CsvDownloadLink == null && ec.Includes("csvDownloadLink",true))
        {
            this.CsvDownloadLink = "FETCH";
        }
        //      C# -> List<SkippedItemInfo>? SkippedItems
        // GraphQL -> skippedItems: [SkippedItemInfo!]! (type)
        if (this.SkippedItems == null && ec.Includes("skippedItems",false))
        {
            this.SkippedItems = new List<SkippedItemInfo>();
            this.SkippedItems.ApplyExploratoryFieldSpec(ec.NewChild("skippedItems"));
        }
    }


    #endregion

    } // class SkippedItemInfoResponse
    
    #endregion

    public static class ListSkippedItemInfoResponseExtensions
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
            this List<SkippedItemInfoResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SkippedItemInfoResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SkippedItemInfoResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SkippedItemInfoResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types