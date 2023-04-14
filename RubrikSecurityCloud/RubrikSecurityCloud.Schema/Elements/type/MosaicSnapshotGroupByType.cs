// MosaicSnapshotGroupByType.cs
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
    #region MosaicSnapshotGroupByType
    public class MosaicSnapshotGroupByType: IFragment
    {
        #region members
        //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
        // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
        [JsonProperty("allSnapshotGroupBys")]
        public List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys { get; set; }

        //      C# -> MosaicSnapshotConnection? Snapshots
        // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
        [JsonProperty("snapshots")]
        public MosaicSnapshotConnection? Snapshots { get; set; }

        //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public MosaicSnapshotGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public MosaicSnapshotGroupByType Set(
        List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys = null,
        MosaicSnapshotConnection? Snapshots = null,
        MosaicSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( AllSnapshotGroupBys != null ) {
            this.AllSnapshotGroupBys = AllSnapshotGroupBys;
        }
        if ( Snapshots != null ) {
            this.Snapshots = Snapshots;
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
            //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
            // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
            if (this.AllSnapshotGroupBys != null)
            {
                 s += ind + "allSnapshotGroupBys\n";

                 s += ind + "{\n" + 
                 this.AllSnapshotGroupBys.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MosaicSnapshotConnection? Snapshots
            // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
            if (this.Snapshots != null)
            {
                 s += ind + "snapshots\n";

                 s += ind + "{\n" + 
                 this.Snapshots.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
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
            //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
            // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
            if (this.AllSnapshotGroupBys == null && Exploration.Includes(parent + ".allSnapshotGroupBys"))
            {
                this.AllSnapshotGroupBys = new List<MosaicSnapshotGroupByType>();
                this.AllSnapshotGroupBys.ApplyExploratoryFragment(parent + ".allSnapshotGroupBys");
            }
            //      C# -> MosaicSnapshotConnection? Snapshots
            // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
            if (this.Snapshots == null && Exploration.Includes(parent + ".snapshots"))
            {
                this.Snapshots = new MosaicSnapshotConnection();
                this.Snapshots.ApplyExploratoryFragment(parent + ".snapshots");
            }
            //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (MosaicSnapshotGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(MosaicSnapshotGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class MosaicSnapshotGroupByType
    #endregion

    public static class ListMosaicSnapshotGroupByTypeExtensions
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
            this List<MosaicSnapshotGroupByType> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MosaicSnapshotGroupByType> list, 
            String parent = "")
        {
            var item = new MosaicSnapshotGroupByType();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types