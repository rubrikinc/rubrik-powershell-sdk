// ManagedVolumeQueuedSnapshotGroupBy.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:41.
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
    #region ManagedVolumeQueuedSnapshotGroupBy
    public class ManagedVolumeQueuedSnapshotGroupBy: IFragment
    {
        #region members
        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        [JsonProperty("managedVolumeQueuedSnapshotConnection")]
        public ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection { get; set; }

        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        [JsonProperty("managedVolumeQueuedSnapshotGroupBy")]
        public List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField { get; set; }

        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public ManagedVolumeQueuedSnapshotGroupBy Set(
        ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection = null,
        List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField = null,
        ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( ManagedVolumeQueuedSnapshotConnection != null ) {
            this.ManagedVolumeQueuedSnapshotConnection = ManagedVolumeQueuedSnapshotConnection;
        }
        if ( ManagedVolumeQueuedSnapshotGroupByField != null ) {
            this.ManagedVolumeQueuedSnapshotGroupByField = ManagedVolumeQueuedSnapshotGroupByField;
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
            //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
            // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
            if (this.ManagedVolumeQueuedSnapshotConnection != null)
            {
                 s += ind + "managedVolumeQueuedSnapshotConnection\n";

                 s += ind + "{\n" + 
                 this.ManagedVolumeQueuedSnapshotConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
            // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
            if (this.ManagedVolumeQueuedSnapshotGroupByField != null)
            {
                 s += ind + "managedVolumeQueuedSnapshotGroupBy\n";

                 s += ind + "{\n" + 
                 this.ManagedVolumeQueuedSnapshotGroupByField.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
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
            //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
            // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
            if (this.ManagedVolumeQueuedSnapshotConnection == null && Exploration.Includes(parent + ".managedVolumeQueuedSnapshotConnection"))
            {
                this.ManagedVolumeQueuedSnapshotConnection = new ManagedVolumeQueuedSnapshotConnection();
                this.ManagedVolumeQueuedSnapshotConnection.ApplyExploratoryFragment(parent + ".managedVolumeQueuedSnapshotConnection");
            }
            //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
            // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
            if (this.ManagedVolumeQueuedSnapshotGroupByField == null && Exploration.Includes(parent + ".managedVolumeQueuedSnapshotGroupBy"))
            {
                this.ManagedVolumeQueuedSnapshotGroupByField = new List<ManagedVolumeQueuedSnapshotGroupBy>();
                this.ManagedVolumeQueuedSnapshotGroupByField.ApplyExploratoryFragment(parent + ".managedVolumeQueuedSnapshotGroupBy");
            }
            //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (ManagedVolumeQueuedSnapshotGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(ManagedVolumeQueuedSnapshotGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class ManagedVolumeQueuedSnapshotGroupBy
    #endregion

    public static class ListManagedVolumeQueuedSnapshotGroupByExtensions
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
            this List<ManagedVolumeQueuedSnapshotGroupBy> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeQueuedSnapshotGroupBy> list, 
            String parent = "")
        {
            var item = new ManagedVolumeQueuedSnapshotGroupBy();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types