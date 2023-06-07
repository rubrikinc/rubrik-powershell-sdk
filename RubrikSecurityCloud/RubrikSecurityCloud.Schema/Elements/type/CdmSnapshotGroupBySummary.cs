// CdmSnapshotGroupBySummary.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CdmSnapshotGroupBySummary
    public class CdmSnapshotGroupBySummary: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> CdmSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmSnapshotConnection! (type)
        [JsonProperty("cdmSnapshots")]
        public CdmSnapshotConnection? CdmSnapshots { get; set; }

        //      C# -> TimeRangeWithUnit? GroupByInfo
        // GraphQL -> groupByInfo: TimeRangeWithUnit! (type)
        [JsonProperty("groupByInfo")]
        public TimeRangeWithUnit? GroupByInfo { get; set; }


        #endregion

    #region methods

    public CdmSnapshotGroupBySummary Set(
        System.Int32? Count = null,
        CdmSnapshotConnection? CdmSnapshots = null,
        TimeRangeWithUnit? GroupByInfo = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( CdmSnapshots != null ) {
            this.CdmSnapshots = CdmSnapshots;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> CdmSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmSnapshotConnection! (type)
        if (this.CdmSnapshots != null) {
            s += ind + "cdmSnapshots {\n" + this.CdmSnapshots.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> TimeRangeWithUnit? GroupByInfo
        // GraphQL -> groupByInfo: TimeRangeWithUnit! (type)
        if (this.GroupByInfo != null) {
            s += ind + "groupByInfo {\n" + this.GroupByInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> CdmSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmSnapshotConnection! (type)
        if (this.CdmSnapshots == null && Exploration.Includes(parent + ".cdmSnapshots"))
        {
            this.CdmSnapshots = new CdmSnapshotConnection();
            this.CdmSnapshots.ApplyExploratoryFieldSpec(parent + ".cdmSnapshots");
        }
        //      C# -> TimeRangeWithUnit? GroupByInfo
        // GraphQL -> groupByInfo: TimeRangeWithUnit! (type)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            this.GroupByInfo = new TimeRangeWithUnit();
            this.GroupByInfo.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
        }
    }


    #endregion

    } // class CdmSnapshotGroupBySummary
    
    #endregion

    public static class ListCdmSnapshotGroupBySummaryExtensions
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
            this List<CdmSnapshotGroupBySummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmSnapshotGroupBySummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmSnapshotGroupBySummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types