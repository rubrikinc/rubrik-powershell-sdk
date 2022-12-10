// TimeRange.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:37.
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
    #region TimeRange
    public class TimeRange: IFragment
    {
        #region members
        //      C# -> DateTime? End
        // GraphQL -> end: DateTime! (scalar)
        [JsonProperty("end")]
        public DateTime? End { get; set; }

        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime! (scalar)
        [JsonProperty("start")]
        public DateTime? Start { get; set; }

        #endregion

    #region methods

    public TimeRange Set(
        DateTime? End = null,
        DateTime? Start = null
    ) 
    {
        if ( End != null ) {
            this.End = End;
        }
        if ( Start != null ) {
            this.Start = Start;
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
            //      C# -> DateTime? End
            // GraphQL -> end: DateTime! (scalar)
            if (this.End != null)
            {
                 s += ind + "end\n";

            }
            //      C# -> DateTime? Start
            // GraphQL -> start: DateTime! (scalar)
            if (this.Start != null)
            {
                 s += ind + "start\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? End
            // GraphQL -> end: DateTime! (scalar)
            if (this.End == null && Exploration.Includes(parent + ".end$"))
            {
                this.End = new DateTime();
            }
            //      C# -> DateTime? Start
            // GraphQL -> start: DateTime! (scalar)
            if (this.Start == null && Exploration.Includes(parent + ".start$"))
            {
                this.Start = new DateTime();
            }
        }


    #endregion

    } // class TimeRange
    #endregion

    public static class ListTimeRangeExtensions
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
            this List<TimeRange> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TimeRange> list, 
            String parent = "")
        {
            var item = new TimeRange();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types