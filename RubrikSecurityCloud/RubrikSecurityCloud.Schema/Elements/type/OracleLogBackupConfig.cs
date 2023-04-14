// OracleLogBackupConfig.cs
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
    #region OracleLogBackupConfig
    public class OracleLogBackupConfig: IFragment
    {
        #region members
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int! (scalar)
        [JsonProperty("hostLogRetentionHours")]
        public System.Int32? HostLogRetentionHours { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyMin
        // GraphQL -> logBackupFrequencyMin: Int! (scalar)
        [JsonProperty("logBackupFrequencyMin")]
        public System.Int32? LogBackupFrequencyMin { get; set; }

        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        [JsonProperty("logRetentionHours")]
        public System.Int32? LogRetentionHours { get; set; }

        #endregion

    #region methods

    public OracleLogBackupConfig Set(
        System.Int32? HostLogRetentionHours = null,
        System.Int32? LogBackupFrequencyMin = null,
        System.Int32? LogRetentionHours = null
    ) 
    {
        if ( HostLogRetentionHours != null ) {
            this.HostLogRetentionHours = HostLogRetentionHours;
        }
        if ( LogBackupFrequencyMin != null ) {
            this.LogBackupFrequencyMin = LogBackupFrequencyMin;
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
            //      C# -> System.Int32? HostLogRetentionHours
            // GraphQL -> hostLogRetentionHours: Int! (scalar)
            if (this.HostLogRetentionHours != null)
            {
                 s += ind + "hostLogRetentionHours\n";

            }
            //      C# -> System.Int32? LogBackupFrequencyMin
            // GraphQL -> logBackupFrequencyMin: Int! (scalar)
            if (this.LogBackupFrequencyMin != null)
            {
                 s += ind + "logBackupFrequencyMin\n";

            }
            //      C# -> System.Int32? LogRetentionHours
            // GraphQL -> logRetentionHours: Int! (scalar)
            if (this.LogRetentionHours != null)
            {
                 s += ind + "logRetentionHours\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? HostLogRetentionHours
            // GraphQL -> hostLogRetentionHours: Int! (scalar)
            if (this.HostLogRetentionHours == null && Exploration.Includes(parent + ".hostLogRetentionHours$"))
            {
                this.HostLogRetentionHours = new System.Int32();
            }
            //      C# -> System.Int32? LogBackupFrequencyMin
            // GraphQL -> logBackupFrequencyMin: Int! (scalar)
            if (this.LogBackupFrequencyMin == null && Exploration.Includes(parent + ".logBackupFrequencyMin$"))
            {
                this.LogBackupFrequencyMin = new System.Int32();
            }
            //      C# -> System.Int32? LogRetentionHours
            // GraphQL -> logRetentionHours: Int! (scalar)
            if (this.LogRetentionHours == null && Exploration.Includes(parent + ".logRetentionHours$"))
            {
                this.LogRetentionHours = new System.Int32();
            }
        }


    #endregion

    } // class OracleLogBackupConfig
    #endregion

    public static class ListOracleLogBackupConfigExtensions
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
            this List<OracleLogBackupConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleLogBackupConfig> list, 
            String parent = "")
        {
            var item = new OracleLogBackupConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types