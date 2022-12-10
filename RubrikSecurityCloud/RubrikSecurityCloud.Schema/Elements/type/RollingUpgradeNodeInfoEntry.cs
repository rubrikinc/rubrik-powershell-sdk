// RollingUpgradeNodeInfoEntry.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:10.
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
    #region RollingUpgradeNodeInfoEntry
    public class RollingUpgradeNodeInfoEntry: IFragment
    {
        #region members
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> RollingUpgradeNodeInfo? RuNodeInfo
        // GraphQL -> ruNodeInfo: RollingUpgradeNodeInfo (type)
        [JsonProperty("ruNodeInfo")]
        public RollingUpgradeNodeInfo? RuNodeInfo { get; set; }

        #endregion

    #region methods

    public RollingUpgradeNodeInfoEntry Set(
        System.String? NodeName = null,
        RollingUpgradeNodeInfo? RuNodeInfo = null
    ) 
    {
        if ( NodeName != null ) {
            this.NodeName = NodeName;
        }
        if ( RuNodeInfo != null ) {
            this.RuNodeInfo = RuNodeInfo;
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
            //      C# -> System.String? NodeName
            // GraphQL -> nodeName: String! (scalar)
            if (this.NodeName != null)
            {
                 s += ind + "nodeName\n";

            }
            //      C# -> RollingUpgradeNodeInfo? RuNodeInfo
            // GraphQL -> ruNodeInfo: RollingUpgradeNodeInfo (type)
            if (this.RuNodeInfo != null)
            {
                 s += ind + "ruNodeInfo\n";

                 s += ind + "{\n" + 
                 this.RuNodeInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? NodeName
            // GraphQL -> nodeName: String! (scalar)
            if (this.NodeName == null && Exploration.Includes(parent + ".nodeName$"))
            {
                this.NodeName = new System.String("FETCH");
            }
            //      C# -> RollingUpgradeNodeInfo? RuNodeInfo
            // GraphQL -> ruNodeInfo: RollingUpgradeNodeInfo (type)
            if (this.RuNodeInfo == null && Exploration.Includes(parent + ".ruNodeInfo"))
            {
                this.RuNodeInfo = new RollingUpgradeNodeInfo();
                this.RuNodeInfo.ApplyExploratoryFragment(parent + ".ruNodeInfo");
            }
        }


    #endregion

    } // class RollingUpgradeNodeInfoEntry
    #endregion

    public static class ListRollingUpgradeNodeInfoEntryExtensions
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
            this List<RollingUpgradeNodeInfoEntry> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RollingUpgradeNodeInfoEntry> list, 
            String parent = "")
        {
            var item = new RollingUpgradeNodeInfoEntry();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types