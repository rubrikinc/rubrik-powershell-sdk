// FailedRestoreItemsInfoReply.cs
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
    #region FailedRestoreItemsInfoReply
    public class FailedRestoreItemsInfoReply: BaseType
    {
        #region members

        //      C# -> System.String? CsvDownloadLink
        // GraphQL -> csvDownloadLink: URL! (scalar)
        [JsonProperty("csvDownloadLink")]
        public System.String? CsvDownloadLink { get; set; }

        //      C# -> System.Int32? TotalFailedItemCount
        // GraphQL -> totalFailedItemCount: Int! (scalar)
        [JsonProperty("totalFailedItemCount")]
        public System.Int32? TotalFailedItemCount { get; set; }

        //      C# -> List<FailedRestoreItemInfo>? FailedItems
        // GraphQL -> failedItems: [FailedRestoreItemInfo!]! (type)
        [JsonProperty("failedItems")]
        public List<FailedRestoreItemInfo>? FailedItems { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailedRestoreItemsInfoReply";
    }

    public FailedRestoreItemsInfoReply Set(
        System.String? CsvDownloadLink = null,
        System.Int32? TotalFailedItemCount = null,
        List<FailedRestoreItemInfo>? FailedItems = null
    ) 
    {
        if ( CsvDownloadLink != null ) {
            this.CsvDownloadLink = CsvDownloadLink;
        }
        if ( TotalFailedItemCount != null ) {
            this.TotalFailedItemCount = TotalFailedItemCount;
        }
        if ( FailedItems != null ) {
            this.FailedItems = FailedItems;
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
        //      C# -> System.String? CsvDownloadLink
        // GraphQL -> csvDownloadLink: URL! (scalar)
        if (this.CsvDownloadLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "csvDownloadLink\n" ;
            } else {
                s += ind + "csvDownloadLink\n" ;
            }
        }
        //      C# -> System.Int32? TotalFailedItemCount
        // GraphQL -> totalFailedItemCount: Int! (scalar)
        if (this.TotalFailedItemCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalFailedItemCount\n" ;
            } else {
                s += ind + "totalFailedItemCount\n" ;
            }
        }
        //      C# -> List<FailedRestoreItemInfo>? FailedItems
        // GraphQL -> failedItems: [FailedRestoreItemInfo!]! (type)
        if (this.FailedItems != null) {
            var fspec = this.FailedItems.AsFieldSpec(conf.Child("failedItems"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failedItems" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CsvDownloadLink
        // GraphQL -> csvDownloadLink: URL! (scalar)
        if (ec.Includes("csvDownloadLink",true))
        {
            if(this.CsvDownloadLink == null) {

                this.CsvDownloadLink = "FETCH";

            } else {


            }
        }
        else if (this.CsvDownloadLink != null && ec.Excludes("csvDownloadLink",true))
        {
            this.CsvDownloadLink = null;
        }
        //      C# -> System.Int32? TotalFailedItemCount
        // GraphQL -> totalFailedItemCount: Int! (scalar)
        if (ec.Includes("totalFailedItemCount",true))
        {
            if(this.TotalFailedItemCount == null) {

                this.TotalFailedItemCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalFailedItemCount != null && ec.Excludes("totalFailedItemCount",true))
        {
            this.TotalFailedItemCount = null;
        }
        //      C# -> List<FailedRestoreItemInfo>? FailedItems
        // GraphQL -> failedItems: [FailedRestoreItemInfo!]! (type)
        if (ec.Includes("failedItems",false))
        {
            if(this.FailedItems == null) {

                this.FailedItems = new List<FailedRestoreItemInfo>();
                this.FailedItems.ApplyExploratoryFieldSpec(ec.NewChild("failedItems"));

            } else {

                this.FailedItems.ApplyExploratoryFieldSpec(ec.NewChild("failedItems"));

            }
        }
        else if (this.FailedItems != null && ec.Excludes("failedItems",false))
        {
            this.FailedItems = null;
        }
    }


    #endregion

    } // class FailedRestoreItemsInfoReply
    
    #endregion

    public static class ListFailedRestoreItemsInfoReplyExtensions
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
            this List<FailedRestoreItemsInfoReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailedRestoreItemsInfoReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailedRestoreItemsInfoReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailedRestoreItemsInfoReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailedRestoreItemsInfoReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types