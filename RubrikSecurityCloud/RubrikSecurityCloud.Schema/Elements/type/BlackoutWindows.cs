// BlackoutWindows.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:30.
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
    #region BlackoutWindows
    public class BlackoutWindows: IFragment
    {
        #region members
        //      C# -> List<BlackoutWindow>? GlobalBlackoutWindows
        // GraphQL -> globalBlackoutWindows: [BlackoutWindow!]! (type)
        [JsonProperty("globalBlackoutWindows")]
        public List<BlackoutWindow>? GlobalBlackoutWindows { get; set; }

        //      C# -> List<BlackoutWindow>? SnappableBlackoutWindows
        // GraphQL -> snappableBlackoutWindows: [BlackoutWindow!]! (type)
        [JsonProperty("snappableBlackoutWindows")]
        public List<BlackoutWindow>? SnappableBlackoutWindows { get; set; }

        #endregion

    #region methods

    public BlackoutWindows Set(
        List<BlackoutWindow>? GlobalBlackoutWindows = null,
        List<BlackoutWindow>? SnappableBlackoutWindows = null
    ) 
    {
        if ( GlobalBlackoutWindows != null ) {
            this.GlobalBlackoutWindows = GlobalBlackoutWindows;
        }
        if ( SnappableBlackoutWindows != null ) {
            this.SnappableBlackoutWindows = SnappableBlackoutWindows;
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
            //      C# -> List<BlackoutWindow>? GlobalBlackoutWindows
            // GraphQL -> globalBlackoutWindows: [BlackoutWindow!]! (type)
            if (this.GlobalBlackoutWindows != null)
            {
                 s += ind + "globalBlackoutWindows\n";

                 s += ind + "{\n" + 
                 this.GlobalBlackoutWindows.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<BlackoutWindow>? SnappableBlackoutWindows
            // GraphQL -> snappableBlackoutWindows: [BlackoutWindow!]! (type)
            if (this.SnappableBlackoutWindows != null)
            {
                 s += ind + "snappableBlackoutWindows\n";

                 s += ind + "{\n" + 
                 this.SnappableBlackoutWindows.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<BlackoutWindow>? GlobalBlackoutWindows
            // GraphQL -> globalBlackoutWindows: [BlackoutWindow!]! (type)
            if (this.GlobalBlackoutWindows == null && Exploration.Includes(parent + ".globalBlackoutWindows"))
            {
                this.GlobalBlackoutWindows = new List<BlackoutWindow>();
                this.GlobalBlackoutWindows.ApplyExploratoryFragment(parent + ".globalBlackoutWindows");
            }
            //      C# -> List<BlackoutWindow>? SnappableBlackoutWindows
            // GraphQL -> snappableBlackoutWindows: [BlackoutWindow!]! (type)
            if (this.SnappableBlackoutWindows == null && Exploration.Includes(parent + ".snappableBlackoutWindows"))
            {
                this.SnappableBlackoutWindows = new List<BlackoutWindow>();
                this.SnappableBlackoutWindows.ApplyExploratoryFragment(parent + ".snappableBlackoutWindows");
            }
        }


    #endregion

    } // class BlackoutWindows
    #endregion

    public static class ListBlackoutWindowsExtensions
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
            this List<BlackoutWindows> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BlackoutWindows> list, 
            String parent = "")
        {
            var item = new BlackoutWindows();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types