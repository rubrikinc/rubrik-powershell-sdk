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

namespace Rubrik.SecurityCloud.Types
{
    #region CdmSnapshotGroupBySummary
    public class CdmSnapshotGroupBySummary: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> CdmSnapshotConnection? CdmSnapshots
            // GraphQL -> cdmSnapshots: CdmSnapshotConnection! (type)
            if (this.CdmSnapshots != null)
            {
                 s += ind + "cdmSnapshots\n";

                 s += ind + "{\n" + 
                 this.CdmSnapshots.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> TimeRangeWithUnit? GroupByInfo
            // GraphQL -> groupByInfo: TimeRangeWithUnit! (type)
            if (this.GroupByInfo != null)
            {
                 s += ind + "groupByInfo\n";

                 s += ind + "{\n" + 
                 this.GroupByInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int32();
            }
            //      C# -> CdmSnapshotConnection? CdmSnapshots
            // GraphQL -> cdmSnapshots: CdmSnapshotConnection! (type)
            if (this.CdmSnapshots == null && Exploration.Includes(parent + ".cdmSnapshots"))
            {
                this.CdmSnapshots = new CdmSnapshotConnection();
                this.CdmSnapshots.ApplyExploratoryFragment(parent + ".cdmSnapshots");
            }
            //      C# -> TimeRangeWithUnit? GroupByInfo
            // GraphQL -> groupByInfo: TimeRangeWithUnit! (type)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = new TimeRangeWithUnit();
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class CdmSnapshotGroupBySummary
    #endregion

    public static class ListCdmSnapshotGroupBySummaryExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<CdmSnapshotGroupBySummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmSnapshotGroupBySummary> list, 
            String parent = "")
        {
            var item = new CdmSnapshotGroupBySummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types