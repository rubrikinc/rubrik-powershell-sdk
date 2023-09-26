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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DiffResult";
    }

    public DiffResult Set(
        System.Int64? PreviousSnapshotDate = null,
        System.String? PreviousSnapshotId = null,
        List<DiffData>? Data = null
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "data {\n" + fspec + ind + "}\n" ;
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
    }


    #endregion

    } // class DiffResult
    
    #endregion

    public static class ListDiffResultExtensions
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
            this List<DiffResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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