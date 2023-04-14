// MissedSnapshotGroupBy.cs
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
    #region MissedSnapshotGroupBy
    public class MissedSnapshotGroupBy: IFragment
    {
        #region members
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection! (type)
        [JsonProperty("missedSnapshotConnection")]
        public MissedSnapshotCommonConnection? MissedSnapshotConnection { get; set; }

        //      C# -> List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField
        // GraphQL -> missedSnapshotGroupBy: [MissedSnapshotGroupBy!]! (type)
        [JsonProperty("missedSnapshotGroupBy")]
        public List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField { get; set; }

        //      C# -> MissedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MissedSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public MissedSnapshotGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public MissedSnapshotGroupBy Set(
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField = null,
        MissedSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( MissedSnapshotConnection != null ) {
            this.MissedSnapshotConnection = MissedSnapshotConnection;
        }
        if ( MissedSnapshotGroupByField != null ) {
            this.MissedSnapshotGroupByField = MissedSnapshotGroupByField;
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
            //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
            // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection! (type)
            if (this.MissedSnapshotConnection != null)
            {
                 s += ind + "missedSnapshotConnection\n";

                 s += ind + "{\n" + 
                 this.MissedSnapshotConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField
            // GraphQL -> missedSnapshotGroupBy: [MissedSnapshotGroupBy!]! (type)
            if (this.MissedSnapshotGroupByField != null)
            {
                 s += ind + "missedSnapshotGroupBy\n";

                 s += ind + "{\n" + 
                 this.MissedSnapshotGroupByField.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MissedSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: MissedSnapshotGroupByInfo! (union)
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
            //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
            // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection! (type)
            if (this.MissedSnapshotConnection == null && Exploration.Includes(parent + ".missedSnapshotConnection"))
            {
                this.MissedSnapshotConnection = new MissedSnapshotCommonConnection();
                this.MissedSnapshotConnection.ApplyExploratoryFragment(parent + ".missedSnapshotConnection");
            }
            //      C# -> List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField
            // GraphQL -> missedSnapshotGroupBy: [MissedSnapshotGroupBy!]! (type)
            if (this.MissedSnapshotGroupByField == null && Exploration.Includes(parent + ".missedSnapshotGroupBy"))
            {
                this.MissedSnapshotGroupByField = new List<MissedSnapshotGroupBy>();
                this.MissedSnapshotGroupByField.ApplyExploratoryFragment(parent + ".missedSnapshotGroupBy");
            }
            //      C# -> MissedSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: MissedSnapshotGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (MissedSnapshotGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(MissedSnapshotGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class MissedSnapshotGroupBy
    #endregion

    public static class ListMissedSnapshotGroupByExtensions
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
            this List<MissedSnapshotGroupBy> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MissedSnapshotGroupBy> list, 
            String parent = "")
        {
            var item = new MissedSnapshotGroupBy();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types