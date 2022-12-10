// Duration.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:03.
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
    #region Duration
    public class Duration: IFragment
    {
        #region members
        //      C# -> System.Int32? DurationField
        // GraphQL -> duration: Int! (scalar)
        [JsonProperty("duration")]
        public System.Int32? DurationField { get; set; }

        //      C# -> RetentionUnit? Unit
        // GraphQL -> unit: RetentionUnit! (enum)
        [JsonProperty("unit")]
        public RetentionUnit? Unit { get; set; }

        #endregion

    #region methods

    public Duration Set(
        System.Int32? DurationField = null,
        RetentionUnit? Unit = null
    ) 
    {
        if ( DurationField != null ) {
            this.DurationField = DurationField;
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
            //      C# -> System.Int32? DurationField
            // GraphQL -> duration: Int! (scalar)
            if (this.DurationField != null)
            {
                 s += ind + "duration\n";

            }
            //      C# -> RetentionUnit? Unit
            // GraphQL -> unit: RetentionUnit! (enum)
            if (this.Unit != null)
            {
                 s += ind + "unit\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? DurationField
            // GraphQL -> duration: Int! (scalar)
            if (this.DurationField == null && Exploration.Includes(parent + ".duration$"))
            {
                this.DurationField = new System.Int32();
            }
            //      C# -> RetentionUnit? Unit
            // GraphQL -> unit: RetentionUnit! (enum)
            if (this.Unit == null && Exploration.Includes(parent + ".unit$"))
            {
                this.Unit = new RetentionUnit();
            }
        }


    #endregion

    } // class Duration
    #endregion

    public static class ListDurationExtensions
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
            this List<Duration> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Duration> list, 
            String parent = "")
        {
            var item = new Duration();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types