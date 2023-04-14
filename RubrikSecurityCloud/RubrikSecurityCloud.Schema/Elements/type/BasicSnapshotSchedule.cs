// BasicSnapshotSchedule.cs
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
    #region BasicSnapshotSchedule
    public class BasicSnapshotSchedule: IFragment
    {
        #region members
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        [JsonProperty("frequency")]
        public System.Int32? Frequency { get; set; }

        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        [JsonProperty("retention")]
        public System.Int32? Retention { get; set; }

        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        [JsonProperty("retentionUnit")]
        public RetentionUnit? RetentionUnit { get; set; }

        #endregion

    #region methods

    public BasicSnapshotSchedule Set(
        System.Int32? Frequency = null,
        System.Int32? Retention = null,
        RetentionUnit? RetentionUnit = null
    ) 
    {
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( Retention != null ) {
            this.Retention = Retention;
        }
        if ( RetentionUnit != null ) {
            this.RetentionUnit = RetentionUnit;
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
            //      C# -> System.Int32? Frequency
            // GraphQL -> frequency: Int! (scalar)
            if (this.Frequency != null)
            {
                 s += ind + "frequency\n";

            }
            //      C# -> System.Int32? Retention
            // GraphQL -> retention: Int! (scalar)
            if (this.Retention != null)
            {
                 s += ind + "retention\n";

            }
            //      C# -> RetentionUnit? RetentionUnit
            // GraphQL -> retentionUnit: RetentionUnit! (enum)
            if (this.RetentionUnit != null)
            {
                 s += ind + "retentionUnit\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Frequency
            // GraphQL -> frequency: Int! (scalar)
            if (this.Frequency == null && Exploration.Includes(parent + ".frequency$"))
            {
                this.Frequency = new System.Int32();
            }
            //      C# -> System.Int32? Retention
            // GraphQL -> retention: Int! (scalar)
            if (this.Retention == null && Exploration.Includes(parent + ".retention$"))
            {
                this.Retention = new System.Int32();
            }
            //      C# -> RetentionUnit? RetentionUnit
            // GraphQL -> retentionUnit: RetentionUnit! (enum)
            if (this.RetentionUnit == null && Exploration.Includes(parent + ".retentionUnit$"))
            {
                this.RetentionUnit = new RetentionUnit();
            }
        }


    #endregion

    } // class BasicSnapshotSchedule
    #endregion

    public static class ListBasicSnapshotScheduleExtensions
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
            this List<BasicSnapshotSchedule> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BasicSnapshotSchedule> list, 
            String parent = "")
        {
            var item = new BasicSnapshotSchedule();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types