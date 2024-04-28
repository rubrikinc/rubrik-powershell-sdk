// K8sSnapshotSummaryListResponse.cs
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
    #region K8sSnapshotSummaryListResponse
    public class K8sSnapshotSummaryListResponse: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        [JsonProperty("hasMore")]
        public System.Boolean? HasMore { get; set; }

        //      C# -> System.String? NextCursor
        // GraphQL -> nextCursor: String (scalar)
        [JsonProperty("nextCursor")]
        public System.String? NextCursor { get; set; }

        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        [JsonProperty("total")]
        public System.Int32? Total { get; set; }

        //      C# -> List<K8sSnapshotSummary>? Data
        // GraphQL -> data: [K8sSnapshotSummary!]! (type)
        [JsonProperty("data")]
        public List<K8sSnapshotSummary>? Data { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sSnapshotSummaryListResponse";
    }

    public K8sSnapshotSummaryListResponse Set(
        System.Boolean? HasMore = null,
        System.String? NextCursor = null,
        System.Int32? Total = null,
        List<K8sSnapshotSummary>? Data = null
    ) 
    {
        if ( HasMore != null ) {
            this.HasMore = HasMore;
        }
        if ( NextCursor != null ) {
            this.NextCursor = NextCursor;
        }
        if ( Total != null ) {
            this.Total = Total;
        }
        if ( Data != null ) {
            this.Data = Data;
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
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (this.HasMore != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasMore\n" ;
            } else {
                s += ind + "hasMore\n" ;
            }
        }
        //      C# -> System.String? NextCursor
        // GraphQL -> nextCursor: String (scalar)
        if (this.NextCursor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextCursor\n" ;
            } else {
                s += ind + "nextCursor\n" ;
            }
        }
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        if (this.Total != null) {
            if (conf.Flat) {
                s += conf.Prefix + "total\n" ;
            } else {
                s += ind + "total\n" ;
            }
        }
        //      C# -> List<K8sSnapshotSummary>? Data
        // GraphQL -> data: [K8sSnapshotSummary!]! (type)
        if (this.Data != null) {
            var fspec = this.Data.AsFieldSpec(conf.Child("data"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "data" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (ec.Includes("hasMore",true))
        {
            if(this.HasMore == null) {

                this.HasMore = true;

            } else {


            }
        }
        else if (this.HasMore != null && ec.Excludes("hasMore",true))
        {
            this.HasMore = null;
        }
        //      C# -> System.String? NextCursor
        // GraphQL -> nextCursor: String (scalar)
        if (ec.Includes("nextCursor",true))
        {
            if(this.NextCursor == null) {

                this.NextCursor = "FETCH";

            } else {


            }
        }
        else if (this.NextCursor != null && ec.Excludes("nextCursor",true))
        {
            this.NextCursor = null;
        }
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        if (ec.Includes("total",true))
        {
            if(this.Total == null) {

                this.Total = Int32.MinValue;

            } else {


            }
        }
        else if (this.Total != null && ec.Excludes("total",true))
        {
            this.Total = null;
        }
        //      C# -> List<K8sSnapshotSummary>? Data
        // GraphQL -> data: [K8sSnapshotSummary!]! (type)
        if (ec.Includes("data",false))
        {
            if(this.Data == null) {

                this.Data = new List<K8sSnapshotSummary>();
                this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));

            } else {

                this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));

            }
        }
        else if (this.Data != null && ec.Excludes("data",false))
        {
            this.Data = null;
        }
    }


    #endregion

    } // class K8sSnapshotSummaryListResponse
    
    #endregion

    public static class ListK8sSnapshotSummaryListResponseExtensions
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
            this List<K8sSnapshotSummaryListResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sSnapshotSummaryListResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sSnapshotSummaryListResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sSnapshotSummaryListResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sSnapshotSummaryListResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types