// RollingUpgradeNodeInfo.cs
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
    #region RollingUpgradeNodeInfo
    public class RollingUpgradeNodeInfo: IFragment
    {
        #region members
        //      C# -> System.String? RuEndTs
        // GraphQL -> ruEndTs: String! (scalar)
        [JsonProperty("ruEndTs")]
        public System.String? RuEndTs { get; set; }

        //      C# -> System.String? RuStartTs
        // GraphQL -> ruStartTs: String! (scalar)
        [JsonProperty("ruStartTs")]
        public System.String? RuStartTs { get; set; }

        //      C# -> CurrentStateInfo? CurrentStateInfo
        // GraphQL -> currentStateInfo: CurrentStateInfo (type)
        [JsonProperty("currentStateInfo")]
        public CurrentStateInfo? CurrentStateInfo { get; set; }

        #endregion

    #region methods

    public RollingUpgradeNodeInfo Set(
        System.String? RuEndTs = null,
        System.String? RuStartTs = null,
        CurrentStateInfo? CurrentStateInfo = null
    ) 
    {
        if ( RuEndTs != null ) {
            this.RuEndTs = RuEndTs;
        }
        if ( RuStartTs != null ) {
            this.RuStartTs = RuStartTs;
        }
        if ( CurrentStateInfo != null ) {
            this.CurrentStateInfo = CurrentStateInfo;
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
            //      C# -> System.String? RuEndTs
            // GraphQL -> ruEndTs: String! (scalar)
            if (this.RuEndTs != null)
            {
                 s += ind + "ruEndTs\n";

            }
            //      C# -> System.String? RuStartTs
            // GraphQL -> ruStartTs: String! (scalar)
            if (this.RuStartTs != null)
            {
                 s += ind + "ruStartTs\n";

            }
            //      C# -> CurrentStateInfo? CurrentStateInfo
            // GraphQL -> currentStateInfo: CurrentStateInfo (type)
            if (this.CurrentStateInfo != null)
            {
                 s += ind + "currentStateInfo\n";

                 s += ind + "{\n" + 
                 this.CurrentStateInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? RuEndTs
            // GraphQL -> ruEndTs: String! (scalar)
            if (this.RuEndTs == null && Exploration.Includes(parent + ".ruEndTs$"))
            {
                this.RuEndTs = new System.String("FETCH");
            }
            //      C# -> System.String? RuStartTs
            // GraphQL -> ruStartTs: String! (scalar)
            if (this.RuStartTs == null && Exploration.Includes(parent + ".ruStartTs$"))
            {
                this.RuStartTs = new System.String("FETCH");
            }
            //      C# -> CurrentStateInfo? CurrentStateInfo
            // GraphQL -> currentStateInfo: CurrentStateInfo (type)
            if (this.CurrentStateInfo == null && Exploration.Includes(parent + ".currentStateInfo"))
            {
                this.CurrentStateInfo = new CurrentStateInfo();
                this.CurrentStateInfo.ApplyExploratoryFragment(parent + ".currentStateInfo");
            }
        }


    #endregion

    } // class RollingUpgradeNodeInfo
    #endregion

    public static class ListRollingUpgradeNodeInfoExtensions
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
            this List<RollingUpgradeNodeInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RollingUpgradeNodeInfo> list, 
            String parent = "")
        {
            var item = new RollingUpgradeNodeInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types