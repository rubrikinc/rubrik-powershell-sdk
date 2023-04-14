// OracleNonSlaProperties.cs
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
    #region OracleNonSlaProperties
    public class OracleNonSlaProperties: IFragment
    {
        #region members
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        [JsonProperty("hostLogRetentionHours")]
        public System.Int32? HostLogRetentionHours { get; set; }

        //      C# -> System.String? HostMount
        // GraphQL -> hostMount: String! (scalar)
        [JsonProperty("hostMount")]
        public System.String? HostMount { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int! (scalar)
        [JsonProperty("logBackupFrequencyInMinutes")]
        public System.Int32? LogBackupFrequencyInMinutes { get; set; }

        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        [JsonProperty("logRetentionHours")]
        public System.Int32? LogRetentionHours { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        #endregion

    #region methods

    public OracleNonSlaProperties Set(
        System.Int32? HostLogRetentionHours = null,
        System.String? HostMount = null,
        System.Int32? LogBackupFrequencyInMinutes = null,
        System.Int32? LogRetentionHours = null,
        System.Int32? NumChannels = null
    ) 
    {
        if ( HostLogRetentionHours != null ) {
            this.HostLogRetentionHours = HostLogRetentionHours;
        }
        if ( HostMount != null ) {
            this.HostMount = HostMount;
        }
        if ( LogBackupFrequencyInMinutes != null ) {
            this.LogBackupFrequencyInMinutes = LogBackupFrequencyInMinutes;
        }
        if ( LogRetentionHours != null ) {
            this.LogRetentionHours = LogRetentionHours;
        }
        if ( NumChannels != null ) {
            this.NumChannels = NumChannels;
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
            // GraphQL -> hostLogRetentionHours: Int (scalar)
            if (this.HostLogRetentionHours != null)
            {
                 s += ind + "hostLogRetentionHours\n";

            }
            //      C# -> System.String? HostMount
            // GraphQL -> hostMount: String! (scalar)
            if (this.HostMount != null)
            {
                 s += ind + "hostMount\n";

            }
            //      C# -> System.Int32? LogBackupFrequencyInMinutes
            // GraphQL -> logBackupFrequencyInMinutes: Int! (scalar)
            if (this.LogBackupFrequencyInMinutes != null)
            {
                 s += ind + "logBackupFrequencyInMinutes\n";

            }
            //      C# -> System.Int32? LogRetentionHours
            // GraphQL -> logRetentionHours: Int! (scalar)
            if (this.LogRetentionHours != null)
            {
                 s += ind + "logRetentionHours\n";

            }
            //      C# -> System.Int32? NumChannels
            // GraphQL -> numChannels: Int! (scalar)
            if (this.NumChannels != null)
            {
                 s += ind + "numChannels\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? HostLogRetentionHours
            // GraphQL -> hostLogRetentionHours: Int (scalar)
            if (this.HostLogRetentionHours == null && Exploration.Includes(parent + ".hostLogRetentionHours$"))
            {
                this.HostLogRetentionHours = new System.Int32();
            }
            //      C# -> System.String? HostMount
            // GraphQL -> hostMount: String! (scalar)
            if (this.HostMount == null && Exploration.Includes(parent + ".hostMount$"))
            {
                this.HostMount = new System.String("FETCH");
            }
            //      C# -> System.Int32? LogBackupFrequencyInMinutes
            // GraphQL -> logBackupFrequencyInMinutes: Int! (scalar)
            if (this.LogBackupFrequencyInMinutes == null && Exploration.Includes(parent + ".logBackupFrequencyInMinutes$"))
            {
                this.LogBackupFrequencyInMinutes = new System.Int32();
            }
            //      C# -> System.Int32? LogRetentionHours
            // GraphQL -> logRetentionHours: Int! (scalar)
            if (this.LogRetentionHours == null && Exploration.Includes(parent + ".logRetentionHours$"))
            {
                this.LogRetentionHours = new System.Int32();
            }
            //      C# -> System.Int32? NumChannels
            // GraphQL -> numChannels: Int! (scalar)
            if (this.NumChannels == null && Exploration.Includes(parent + ".numChannels$"))
            {
                this.NumChannels = new System.Int32();
            }
        }


    #endregion

    } // class OracleNonSlaProperties
    #endregion

    public static class ListOracleNonSlaPropertiesExtensions
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
            this List<OracleNonSlaProperties> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleNonSlaProperties> list, 
            String parent = "")
        {
            var item = new OracleNonSlaProperties();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types