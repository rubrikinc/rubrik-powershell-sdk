// SapHanaLogPositionInterval.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:00.
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
    #region SapHanaLogPositionInterval
    public class SapHanaLogPositionInterval: IFragment
    {
        #region members
        //      C# -> System.Int64? NewestLogPosition
        // GraphQL -> newestLogPosition: Long (scalar)
        [JsonProperty("newestLogPosition")]
        public System.Int64? NewestLogPosition { get; set; }

        //      C# -> System.Int64? OldestLogPosition
        // GraphQL -> oldestLogPosition: Long (scalar)
        [JsonProperty("oldestLogPosition")]
        public System.Int64? OldestLogPosition { get; set; }

        #endregion

    #region methods

    public SapHanaLogPositionInterval Set(
        System.Int64? NewestLogPosition = null,
        System.Int64? OldestLogPosition = null
    ) 
    {
        if ( NewestLogPosition != null ) {
            this.NewestLogPosition = NewestLogPosition;
        }
        if ( OldestLogPosition != null ) {
            this.OldestLogPosition = OldestLogPosition;
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
            //      C# -> System.Int64? NewestLogPosition
            // GraphQL -> newestLogPosition: Long (scalar)
            if (this.NewestLogPosition != null)
            {
                 s += ind + "newestLogPosition\n";

            }
            //      C# -> System.Int64? OldestLogPosition
            // GraphQL -> oldestLogPosition: Long (scalar)
            if (this.OldestLogPosition != null)
            {
                 s += ind + "oldestLogPosition\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? NewestLogPosition
            // GraphQL -> newestLogPosition: Long (scalar)
            if (this.NewestLogPosition == null && Exploration.Includes(parent + ".newestLogPosition$"))
            {
                this.NewestLogPosition = new System.Int64();
            }
            //      C# -> System.Int64? OldestLogPosition
            // GraphQL -> oldestLogPosition: Long (scalar)
            if (this.OldestLogPosition == null && Exploration.Includes(parent + ".oldestLogPosition$"))
            {
                this.OldestLogPosition = new System.Int64();
            }
        }


    #endregion

    } // class SapHanaLogPositionInterval
    #endregion

    public static class ListSapHanaLogPositionIntervalExtensions
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
            this List<SapHanaLogPositionInterval> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SapHanaLogPositionInterval> list, 
            String parent = "")
        {
            var item = new SapHanaLogPositionInterval();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types