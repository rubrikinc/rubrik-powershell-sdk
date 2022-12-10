// UpgradeDurationReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
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
    #region UpgradeDurationReply
    public class UpgradeDurationReply: IFragment
    {
        #region members
        //      C# -> System.Int64? FastUpgradeDuration
        // GraphQL -> fastUpgradeDuration: Long! (scalar)
        [JsonProperty("fastUpgradeDuration")]
        public System.Int64? FastUpgradeDuration { get; set; }

        //      C# -> System.Int64? RollingUpgradeDuration
        // GraphQL -> rollingUpgradeDuration: Long! (scalar)
        [JsonProperty("rollingUpgradeDuration")]
        public System.Int64? RollingUpgradeDuration { get; set; }

        #endregion

    #region methods

    public UpgradeDurationReply Set(
        System.Int64? FastUpgradeDuration = null,
        System.Int64? RollingUpgradeDuration = null
    ) 
    {
        if ( FastUpgradeDuration != null ) {
            this.FastUpgradeDuration = FastUpgradeDuration;
        }
        if ( RollingUpgradeDuration != null ) {
            this.RollingUpgradeDuration = RollingUpgradeDuration;
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
            //      C# -> System.Int64? FastUpgradeDuration
            // GraphQL -> fastUpgradeDuration: Long! (scalar)
            if (this.FastUpgradeDuration != null)
            {
                 s += ind + "fastUpgradeDuration\n";

            }
            //      C# -> System.Int64? RollingUpgradeDuration
            // GraphQL -> rollingUpgradeDuration: Long! (scalar)
            if (this.RollingUpgradeDuration != null)
            {
                 s += ind + "rollingUpgradeDuration\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? FastUpgradeDuration
            // GraphQL -> fastUpgradeDuration: Long! (scalar)
            if (this.FastUpgradeDuration == null && Exploration.Includes(parent + ".fastUpgradeDuration$"))
            {
                this.FastUpgradeDuration = new System.Int64();
            }
            //      C# -> System.Int64? RollingUpgradeDuration
            // GraphQL -> rollingUpgradeDuration: Long! (scalar)
            if (this.RollingUpgradeDuration == null && Exploration.Includes(parent + ".rollingUpgradeDuration$"))
            {
                this.RollingUpgradeDuration = new System.Int64();
            }
        }


    #endregion

    } // class UpgradeDurationReply
    #endregion

    public static class ListUpgradeDurationReplyExtensions
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
            this List<UpgradeDurationReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpgradeDurationReply> list, 
            String parent = "")
        {
            var item = new UpgradeDurationReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types