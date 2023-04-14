// OracleConfig.cs
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
    #region OracleConfig
    public class OracleConfig: IFragment
    {
        #region members
        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        [JsonProperty("frequency")]
        public Duration? Frequency { get; set; }

        //      C# -> Duration? HostLogRetention
        // GraphQL -> hostLogRetention: Duration (type)
        [JsonProperty("hostLogRetention")]
        public Duration? HostLogRetention { get; set; }

        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        [JsonProperty("logRetention")]
        public Duration? LogRetention { get; set; }

        #endregion

    #region methods

    public OracleConfig Set(
        Duration? Frequency = null,
        Duration? HostLogRetention = null,
        Duration? LogRetention = null
    ) 
    {
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( HostLogRetention != null ) {
            this.HostLogRetention = HostLogRetention;
        }
        if ( LogRetention != null ) {
            this.LogRetention = LogRetention;
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
            //      C# -> Duration? Frequency
            // GraphQL -> frequency: Duration (type)
            if (this.Frequency != null)
            {
                 s += ind + "frequency\n";

                 s += ind + "{\n" + 
                 this.Frequency.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Duration? HostLogRetention
            // GraphQL -> hostLogRetention: Duration (type)
            if (this.HostLogRetention != null)
            {
                 s += ind + "hostLogRetention\n";

                 s += ind + "{\n" + 
                 this.HostLogRetention.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Duration? LogRetention
            // GraphQL -> logRetention: Duration (type)
            if (this.LogRetention != null)
            {
                 s += ind + "logRetention\n";

                 s += ind + "{\n" + 
                 this.LogRetention.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> Duration? Frequency
            // GraphQL -> frequency: Duration (type)
            if (this.Frequency == null && Exploration.Includes(parent + ".frequency"))
            {
                this.Frequency = new Duration();
                this.Frequency.ApplyExploratoryFragment(parent + ".frequency");
            }
            //      C# -> Duration? HostLogRetention
            // GraphQL -> hostLogRetention: Duration (type)
            if (this.HostLogRetention == null && Exploration.Includes(parent + ".hostLogRetention"))
            {
                this.HostLogRetention = new Duration();
                this.HostLogRetention.ApplyExploratoryFragment(parent + ".hostLogRetention");
            }
            //      C# -> Duration? LogRetention
            // GraphQL -> logRetention: Duration (type)
            if (this.LogRetention == null && Exploration.Includes(parent + ".logRetention"))
            {
                this.LogRetention = new Duration();
                this.LogRetention.ApplyExploratoryFragment(parent + ".logRetention");
            }
        }


    #endregion

    } // class OracleConfig
    #endregion

    public static class ListOracleConfigExtensions
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
            this List<OracleConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleConfig> list, 
            String parent = "")
        {
            var item = new OracleConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types