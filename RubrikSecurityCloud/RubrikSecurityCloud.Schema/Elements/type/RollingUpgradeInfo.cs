// RollingUpgradeInfo.cs
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
    #region RollingUpgradeInfo
    public class RollingUpgradeInfo: IFragment
    {
        #region members
        //      C# -> List<System.String>? RuCurrentNodes
        // GraphQL -> ruCurrentNodes: [String!]! (scalar)
        [JsonProperty("ruCurrentNodes")]
        public List<System.String>? RuCurrentNodes { get; set; }

        //      C# -> List<RollingUpgradeNodeInfoEntry>? RuNodeInfoList
        // GraphQL -> ruNodeInfoList: [RollingUpgradeNodeInfoEntry!]! (type)
        [JsonProperty("ruNodeInfoList")]
        public List<RollingUpgradeNodeInfoEntry>? RuNodeInfoList { get; set; }

        #endregion

    #region methods

    public RollingUpgradeInfo Set(
        List<System.String>? RuCurrentNodes = null,
        List<RollingUpgradeNodeInfoEntry>? RuNodeInfoList = null
    ) 
    {
        if ( RuCurrentNodes != null ) {
            this.RuCurrentNodes = RuCurrentNodes;
        }
        if ( RuNodeInfoList != null ) {
            this.RuNodeInfoList = RuNodeInfoList;
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
            //      C# -> List<System.String>? RuCurrentNodes
            // GraphQL -> ruCurrentNodes: [String!]! (scalar)
            if (this.RuCurrentNodes != null)
            {
                 s += ind + "ruCurrentNodes\n";

            }
            //      C# -> List<RollingUpgradeNodeInfoEntry>? RuNodeInfoList
            // GraphQL -> ruNodeInfoList: [RollingUpgradeNodeInfoEntry!]! (type)
            if (this.RuNodeInfoList != null)
            {
                 s += ind + "ruNodeInfoList\n";

                 s += ind + "{\n" + 
                 this.RuNodeInfoList.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? RuCurrentNodes
            // GraphQL -> ruCurrentNodes: [String!]! (scalar)
            if (this.RuCurrentNodes == null && Exploration.Includes(parent + ".ruCurrentNodes$"))
            {
                this.RuCurrentNodes = new List<System.String>();
            }
            //      C# -> List<RollingUpgradeNodeInfoEntry>? RuNodeInfoList
            // GraphQL -> ruNodeInfoList: [RollingUpgradeNodeInfoEntry!]! (type)
            if (this.RuNodeInfoList == null && Exploration.Includes(parent + ".ruNodeInfoList"))
            {
                this.RuNodeInfoList = new List<RollingUpgradeNodeInfoEntry>();
                this.RuNodeInfoList.ApplyExploratoryFragment(parent + ".ruNodeInfoList");
            }
        }


    #endregion

    } // class RollingUpgradeInfo
    #endregion

    public static class ListRollingUpgradeInfoExtensions
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
            this List<RollingUpgradeInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RollingUpgradeInfo> list, 
            String parent = "")
        {
            var item = new RollingUpgradeInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types