// BlackoutWindow.cs
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
    #region BlackoutWindow
    public class BlackoutWindow: IFragment
    {
        #region members
        //      C# -> System.String? EndTime
        // GraphQL -> endTime: String (scalar)
        [JsonProperty("endTime")]
        public System.String? EndTime { get; set; }

        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String! (scalar)
        [JsonProperty("startTime")]
        public System.String? StartTime { get; set; }

        #endregion

    #region methods

    public BlackoutWindow Set(
        System.String? EndTime = null,
        System.String? StartTime = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
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
            //      C# -> System.String? EndTime
            // GraphQL -> endTime: String (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.String? StartTime
            // GraphQL -> startTime: String! (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? EndTime
            // GraphQL -> endTime: String (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new System.String("FETCH");
            }
            //      C# -> System.String? StartTime
            // GraphQL -> startTime: String! (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new System.String("FETCH");
            }
        }


    #endregion

    } // class BlackoutWindow
    #endregion

    public static class ListBlackoutWindowExtensions
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
            this List<BlackoutWindow> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BlackoutWindow> list, 
            String parent = "")
        {
            var item = new BlackoutWindow();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types