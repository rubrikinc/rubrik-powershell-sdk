// MssqlNonSlaProperties.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:46.
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
    #region MssqlNonSlaProperties
    public class MssqlNonSlaProperties: IFragment
    {
        #region members
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean (scalar)
        [JsonProperty("copyOnly")]
        public System.Boolean? CopyOnly { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int (scalar)
        [JsonProperty("logBackupFrequencyInSeconds")]
        public System.Int32? LogBackupFrequencyInSeconds { get; set; }

        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int (scalar)
        [JsonProperty("logRetentionHours")]
        public System.Int32? LogRetentionHours { get; set; }

        #endregion

    #region methods

    public MssqlNonSlaProperties Set(
        System.Boolean? CopyOnly = null,
        System.Int32? LogBackupFrequencyInSeconds = null,
        System.Int32? LogRetentionHours = null
    ) 
    {
        if ( CopyOnly != null ) {
            this.CopyOnly = CopyOnly;
        }
        if ( LogBackupFrequencyInSeconds != null ) {
            this.LogBackupFrequencyInSeconds = LogBackupFrequencyInSeconds;
        }
        if ( LogRetentionHours != null ) {
            this.LogRetentionHours = LogRetentionHours;
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
            //      C# -> System.Boolean? CopyOnly
            // GraphQL -> copyOnly: Boolean (scalar)
            if (this.CopyOnly != null)
            {
                 s += ind + "copyOnly\n";

            }
            //      C# -> System.Int32? LogBackupFrequencyInSeconds
            // GraphQL -> logBackupFrequencyInSeconds: Int (scalar)
            if (this.LogBackupFrequencyInSeconds != null)
            {
                 s += ind + "logBackupFrequencyInSeconds\n";

            }
            //      C# -> System.Int32? LogRetentionHours
            // GraphQL -> logRetentionHours: Int (scalar)
            if (this.LogRetentionHours != null)
            {
                 s += ind + "logRetentionHours\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? CopyOnly
            // GraphQL -> copyOnly: Boolean (scalar)
            if (this.CopyOnly == null && Exploration.Includes(parent + ".copyOnly$"))
            {
                this.CopyOnly = new System.Boolean();
            }
            //      C# -> System.Int32? LogBackupFrequencyInSeconds
            // GraphQL -> logBackupFrequencyInSeconds: Int (scalar)
            if (this.LogBackupFrequencyInSeconds == null && Exploration.Includes(parent + ".logBackupFrequencyInSeconds$"))
            {
                this.LogBackupFrequencyInSeconds = new System.Int32();
            }
            //      C# -> System.Int32? LogRetentionHours
            // GraphQL -> logRetentionHours: Int (scalar)
            if (this.LogRetentionHours == null && Exploration.Includes(parent + ".logRetentionHours$"))
            {
                this.LogRetentionHours = new System.Int32();
            }
        }


    #endregion

    } // class MssqlNonSlaProperties
    #endregion

    public static class ListMssqlNonSlaPropertiesExtensions
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
            this List<MssqlNonSlaProperties> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlNonSlaProperties> list, 
            String parent = "")
        {
            var item = new MssqlNonSlaProperties();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types