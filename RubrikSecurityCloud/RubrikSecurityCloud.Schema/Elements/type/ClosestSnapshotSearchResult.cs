// ClosestSnapshotSearchResult.cs
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
    #region ClosestSnapshotSearchResult
    public class ClosestSnapshotSearchResult: BaseType
    {
        #region members

        //      C# -> SnapshotSearchError? Error
        // GraphQL -> error: SnapshotSearchError (enum)
        [JsonProperty("error")]
        public SnapshotSearchError? Error { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> ClosestSnapshotDetail? Snapshot
        // GraphQL -> snapshot: ClosestSnapshotDetail (type)
        [JsonProperty("snapshot")]
        public ClosestSnapshotDetail? Snapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClosestSnapshotSearchResult";
    }

    public ClosestSnapshotSearchResult Set(
        SnapshotSearchError? Error = null,
        System.String? SnappableId = null,
        ClosestSnapshotDetail? Snapshot = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( Snapshot != null ) {
            this.Snapshot = Snapshot;
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
        //      C# -> SnapshotSearchError? Error
        // GraphQL -> error: SnapshotSearchError (enum)
        if (this.Error != null) {
            s += ind + "error\n" ;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            s += ind + "snappableId\n" ;
        }
        //      C# -> ClosestSnapshotDetail? Snapshot
        // GraphQL -> snapshot: ClosestSnapshotDetail (type)
        if (this.Snapshot != null) {
            var fspec = this.Snapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotSearchError? Error
        // GraphQL -> error: SnapshotSearchError (enum)
        if (this.Error == null && ec.Includes("error",true))
        {
            this.Error = new SnapshotSearchError();
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId == null && ec.Includes("snappableId",true))
        {
            this.SnappableId = "FETCH";
        }
        //      C# -> ClosestSnapshotDetail? Snapshot
        // GraphQL -> snapshot: ClosestSnapshotDetail (type)
        if (this.Snapshot == null && ec.Includes("snapshot",false))
        {
            this.Snapshot = new ClosestSnapshotDetail();
            this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));
        }
    }


    #endregion

    } // class ClosestSnapshotSearchResult
    
    #endregion

    public static class ListClosestSnapshotSearchResultExtensions
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
            this List<ClosestSnapshotSearchResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClosestSnapshotSearchResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClosestSnapshotSearchResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ClosestSnapshotSearchResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types