// RelativeTimeRange.cs
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
    #region RelativeTimeRange
    public class RelativeTimeRange: IFragment
    {
        #region members
        //      C# -> System.Int32? Magnitude
        // GraphQL -> magnitude: Int! (scalar)
        [JsonProperty("magnitude")]
        public System.Int32? Magnitude { get; set; }

        //      C# -> TimeUnitEnum? Unit
        // GraphQL -> unit: TimeUnitEnum! (enum)
        [JsonProperty("unit")]
        public TimeUnitEnum? Unit { get; set; }

        #endregion

    #region methods

    public RelativeTimeRange Set(
        System.Int32? Magnitude = null,
        TimeUnitEnum? Unit = null
    ) 
    {
        if ( Magnitude != null ) {
            this.Magnitude = Magnitude;
        }
        if ( Unit != null ) {
            this.Unit = Unit;
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
            //      C# -> System.Int32? Magnitude
            // GraphQL -> magnitude: Int! (scalar)
            if (this.Magnitude != null)
            {
                 s += ind + "magnitude\n";

            }
            //      C# -> TimeUnitEnum? Unit
            // GraphQL -> unit: TimeUnitEnum! (enum)
            if (this.Unit != null)
            {
                 s += ind + "unit\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Magnitude
            // GraphQL -> magnitude: Int! (scalar)
            if (this.Magnitude == null && Exploration.Includes(parent + ".magnitude$"))
            {
                this.Magnitude = new System.Int32();
            }
            //      C# -> TimeUnitEnum? Unit
            // GraphQL -> unit: TimeUnitEnum! (enum)
            if (this.Unit == null && Exploration.Includes(parent + ".unit$"))
            {
                this.Unit = new TimeUnitEnum();
            }
        }


    #endregion

    } // class RelativeTimeRange
    #endregion

    public static class ListRelativeTimeRangeExtensions
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
            this List<RelativeTimeRange> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RelativeTimeRange> list, 
            String parent = "")
        {
            var item = new RelativeTimeRange();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types