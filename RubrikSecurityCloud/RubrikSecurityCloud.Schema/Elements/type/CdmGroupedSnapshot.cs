// CdmGroupedSnapshot.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:45.
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
    #region CdmGroupedSnapshot
    public class CdmGroupedSnapshot: IFragment
    {
        #region members
        //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
        [JsonProperty("cdmSnapshots")]
        public CdmWorkloadSnapshotConnection? CdmSnapshots { get; set; }

        //      C# -> CdmGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmGroupByInfo (type)
        [JsonProperty("groupByInfo")]
        public CdmGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public CdmGroupedSnapshot Set(
        CdmWorkloadSnapshotConnection? CdmSnapshots = null,
        CdmGroupByInfo? GroupByInfo = null
    ) 
    {
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
            //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
            // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
            if (this.CdmSnapshots != null)
            {
                 s += ind + "cdmSnapshots\n";

                 s += ind + "{\n" + 
                 this.CdmSnapshots.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: CdmGroupByInfo (type)
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
            //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
            // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
            if (this.CdmSnapshots == null && Exploration.Includes(parent + ".cdmSnapshots"))
            {
                this.CdmSnapshots = new CdmWorkloadSnapshotConnection();
                this.CdmSnapshots.ApplyExploratoryFragment(parent + ".cdmSnapshots");
            }
            //      C# -> CdmGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: CdmGroupByInfo (type)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = new CdmGroupByInfo();
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class CdmGroupedSnapshot
    #endregion

    public static class ListCdmGroupedSnapshotExtensions
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
            this List<CdmGroupedSnapshot> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmGroupedSnapshot> list, 
            String parent = "")
        {
            var item = new CdmGroupedSnapshot();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types