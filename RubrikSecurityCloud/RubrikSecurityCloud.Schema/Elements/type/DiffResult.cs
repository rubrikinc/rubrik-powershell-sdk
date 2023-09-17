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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: Long! (scalar)
        if (this.PreviousSnapshotDate != null) {
            s += ind + "previousSnapshotDate\n" ;
        }
        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        if (this.PreviousSnapshotId != null) {
            s += ind + "previousSnapshotId\n" ;
        }
        //      C# -> List<DiffData>? Data
        // GraphQL -> data: [DiffData!]! (type)
        if (this.Data != null) {
            var fspec = this.Data.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "data {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: Long! (scalar)
        if (this.PreviousSnapshotDate == null && ec.Includes("previousSnapshotDate",true))
        {
            this.PreviousSnapshotDate = new System.Int64();
        }
        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        if (this.PreviousSnapshotId == null && ec.Includes("previousSnapshotId",true))
        {
            this.PreviousSnapshotId = "FETCH";
        }
        //      C# -> List<DiffData>? Data
        // GraphQL -> data: [DiffData!]! (type)
        if (this.Data == null && ec.Includes("data",false))
        {
            this.Data = new List<DiffData>();
            this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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