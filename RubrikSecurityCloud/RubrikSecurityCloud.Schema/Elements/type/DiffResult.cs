// DiffResult.cs
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
    #region DiffResult
    public class DiffResult: BaseType
    {
        #region members

        //      C# -> System.Int64? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: Long! (scalar)
        [JsonProperty("previousSnapshotDate")]
        public System.Int64? PreviousSnapshotDate { get; set; }

        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        [JsonProperty("previousSnapshotId")]
        public System.String? PreviousSnapshotId { get; set; }

        //      C# -> List<DiffData>? Data
        // GraphQL -> data: [DiffData!]! (type)
        [JsonProperty("data")]
        public List<DiffData>? Data { get; set; }

        //      C# -> PaginationMarker? PaginationMarker
        // GraphQL -> paginationMarker: PaginationMarker (type)
        [JsonProperty("paginationMarker")]
        public PaginationMarker? PaginationMarker { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DiffResult";
    }

    public DiffResult Set(
        System.Int64? PreviousSnapshotDate = null,
        System.String? PreviousSnapshotId = null,
        List<DiffData>? Data = null,
        PaginationMarker? PaginationMarker = null
    ) 
    {
        if ( PreviousSnapshotDate != null ) {
            this.PreviousSnapshotDate = PreviousSnapshotDate;
        }
        if ( PreviousSnapshotId != null ) {
            this.PreviousSnapshotId = PreviousSnapshotId;
        }
        if ( Data != null ) {
            this.Data = Data;
        }
        if ( PaginationMarker != null ) {
            this.PaginationMarker = PaginationMarker;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: Long! (scalar)
        if (this.PreviousSnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "previousSnapshotDate\n" ;
            } else {
                s += ind + "previousSnapshotDate\n" ;
            }
        }
        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        if (this.PreviousSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "previousSnapshotId\n" ;
            } else {
                s += ind + "previousSnapshotId\n" ;
            }
        }
        //      C# -> List<DiffData>? Data
        // GraphQL -> data: [DiffData!]! (type)
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
        //      C# -> PaginationMarker? PaginationMarker
        // GraphQL -> paginationMarker: PaginationMarker (type)
        if (this.PaginationMarker != null) {
            var fspec = this.PaginationMarker.AsFieldSpec(conf.Child("paginationMarker"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "paginationMarker" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: Long! (scalar)
        if (ec.Includes("previousSnapshotDate",true))
        {
            if(this.PreviousSnapshotDate == null) {

                this.PreviousSnapshotDate = new System.Int64();

            } else {


            }
        }
        else if (this.PreviousSnapshotDate != null && ec.Excludes("previousSnapshotDate",true))
        {
            this.PreviousSnapshotDate = null;
        }
        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        if (ec.Includes("previousSnapshotId",true))
        {
            if(this.PreviousSnapshotId == null) {

                this.PreviousSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.PreviousSnapshotId != null && ec.Excludes("previousSnapshotId",true))
        {
            this.PreviousSnapshotId = null;
        }
        //      C# -> List<DiffData>? Data
        // GraphQL -> data: [DiffData!]! (type)
        if (ec.Includes("data",false))
        {
            if(this.Data == null) {

                this.Data = new List<DiffData>();
                this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));

            } else {

                this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));

            }
        }
        else if (this.Data != null && ec.Excludes("data",false))
        {
            this.Data = null;
        }
        //      C# -> PaginationMarker? PaginationMarker
        // GraphQL -> paginationMarker: PaginationMarker (type)
        if (ec.Includes("paginationMarker",false))
        {
            if(this.PaginationMarker == null) {

                this.PaginationMarker = new PaginationMarker();
                this.PaginationMarker.ApplyExploratoryFieldSpec(ec.NewChild("paginationMarker"));

            } else {

                this.PaginationMarker.ApplyExploratoryFieldSpec(ec.NewChild("paginationMarker"));

            }
        }
        else if (this.PaginationMarker != null && ec.Excludes("paginationMarker",false))
        {
            this.PaginationMarker = null;
        }
    }


    #endregion

    } // class DiffResult
    
    #endregion

    public static class ListDiffResultExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<DiffResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DiffResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DiffResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DiffResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DiffResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types