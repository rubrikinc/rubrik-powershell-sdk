// SnappableGroupBy.cs
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
    #region SnappableGroupBy
    public class SnappableGroupBy: IFragment
    {
        #region members
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        [JsonProperty("snappableConnection")]
        public SnappableConnection? SnappableConnection { get; set; }

        //      C# -> List<SnappableGroupBy>? SnappableGroupByField
        // GraphQL -> snappableGroupBy: [SnappableGroupBy!]! (type)
        [JsonProperty("snappableGroupBy")]
        public List<SnappableGroupBy>? SnappableGroupByField { get; set; }

        //      C# -> SnappableGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: SnappableGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public SnappableGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public SnappableGroupBy Set(
        SnappableConnection? SnappableConnection = null,
        List<SnappableGroupBy>? SnappableGroupByField = null,
        SnappableGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( SnappableConnection != null ) {
            this.SnappableConnection = SnappableConnection;
        }
        if ( SnappableGroupByField != null ) {
            this.SnappableGroupByField = SnappableGroupByField;
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
            //      C# -> SnappableConnection? SnappableConnection
            // GraphQL -> snappableConnection: SnappableConnection! (type)
            if (this.SnappableConnection != null)
            {
                 s += ind + "snappableConnection\n";

                 s += ind + "{\n" + 
                 this.SnappableConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SnappableGroupBy>? SnappableGroupByField
            // GraphQL -> snappableGroupBy: [SnappableGroupBy!]! (type)
            if (this.SnappableGroupByField != null)
            {
                 s += ind + "snappableGroupBy\n";

                 s += ind + "{\n" + 
                 this.SnappableGroupByField.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnappableGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: SnappableGroupByInfo! (union)
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
            //      C# -> SnappableConnection? SnappableConnection
            // GraphQL -> snappableConnection: SnappableConnection! (type)
            if (this.SnappableConnection == null && Exploration.Includes(parent + ".snappableConnection"))
            {
                this.SnappableConnection = new SnappableConnection();
                this.SnappableConnection.ApplyExploratoryFragment(parent + ".snappableConnection");
            }
            //      C# -> List<SnappableGroupBy>? SnappableGroupByField
            // GraphQL -> snappableGroupBy: [SnappableGroupBy!]! (type)
            if (this.SnappableGroupByField == null && Exploration.Includes(parent + ".snappableGroupBy"))
            {
                this.SnappableGroupByField = new List<SnappableGroupBy>();
                this.SnappableGroupByField.ApplyExploratoryFragment(parent + ".snappableGroupBy");
            }
            //      C# -> SnappableGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: SnappableGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (SnappableGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(SnappableGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class SnappableGroupBy
    #endregion

    public static class ListSnappableGroupByExtensions
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
            this List<SnappableGroupBy> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnappableGroupBy> list, 
            String parent = "")
        {
            var item = new SnappableGroupBy();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types