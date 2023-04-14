// ClusterGroupBy.cs
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
    #region ClusterGroupBy
    public class ClusterGroupBy: IFragment
    {
        #region members
        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        [JsonProperty("clusterConnection")]
        public ClusterConnection? ClusterConnection { get; set; }

        //      C# -> List<ClusterGroupBy>? ClusterGroupByField
        // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
        [JsonProperty("clusterGroupBy")]
        public List<ClusterGroupBy>? ClusterGroupByField { get; set; }

        //      C# -> ClusterGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public ClusterGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public ClusterGroupBy Set(
        ClusterConnection? ClusterConnection = null,
        List<ClusterGroupBy>? ClusterGroupByField = null,
        ClusterGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( ClusterConnection != null ) {
            this.ClusterConnection = ClusterConnection;
        }
        if ( ClusterGroupByField != null ) {
            this.ClusterGroupByField = ClusterGroupByField;
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
            //      C# -> ClusterConnection? ClusterConnection
            // GraphQL -> clusterConnection: ClusterConnection! (type)
            if (this.ClusterConnection != null)
            {
                 s += ind + "clusterConnection\n";

                 s += ind + "{\n" + 
                 this.ClusterConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClusterGroupBy>? ClusterGroupByField
            // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
            if (this.ClusterGroupByField != null)
            {
                 s += ind + "clusterGroupBy\n";

                 s += ind + "{\n" + 
                 this.ClusterGroupByField.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClusterGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
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
            //      C# -> ClusterConnection? ClusterConnection
            // GraphQL -> clusterConnection: ClusterConnection! (type)
            if (this.ClusterConnection == null && Exploration.Includes(parent + ".clusterConnection"))
            {
                this.ClusterConnection = new ClusterConnection();
                this.ClusterConnection.ApplyExploratoryFragment(parent + ".clusterConnection");
            }
            //      C# -> List<ClusterGroupBy>? ClusterGroupByField
            // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
            if (this.ClusterGroupByField == null && Exploration.Includes(parent + ".clusterGroupBy"))
            {
                this.ClusterGroupByField = new List<ClusterGroupBy>();
                this.ClusterGroupByField.ApplyExploratoryFragment(parent + ".clusterGroupBy");
            }
            //      C# -> ClusterGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (ClusterGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(ClusterGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class ClusterGroupBy
    #endregion

    public static class ListClusterGroupByExtensions
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
            this List<ClusterGroupBy> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterGroupBy> list, 
            String parent = "")
        {
            var item = new ClusterGroupBy();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types