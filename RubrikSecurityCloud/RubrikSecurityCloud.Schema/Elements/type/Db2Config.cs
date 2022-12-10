// Db2Config.cs
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
    #region Db2Config
    public class Db2Config: IFragment
    {
        #region members
        //      C# -> Duration? DifferentialFrequency
        // GraphQL -> differentialFrequency: Duration (type)
        [JsonProperty("differentialFrequency")]
        public Duration? DifferentialFrequency { get; set; }

        //      C# -> Duration? IncrementalFrequency
        // GraphQL -> incrementalFrequency: Duration (type)
        [JsonProperty("incrementalFrequency")]
        public Duration? IncrementalFrequency { get; set; }

        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        [JsonProperty("logRetention")]
        public Duration? LogRetention { get; set; }

        #endregion

    #region methods

    public Db2Config Set(
        Duration? DifferentialFrequency = null,
        Duration? IncrementalFrequency = null,
        Duration? LogRetention = null
    ) 
    {
        if ( DifferentialFrequency != null ) {
            this.DifferentialFrequency = DifferentialFrequency;
        }
        if ( IncrementalFrequency != null ) {
            this.IncrementalFrequency = IncrementalFrequency;
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
            //      C# -> Duration? DifferentialFrequency
            // GraphQL -> differentialFrequency: Duration (type)
            if (this.DifferentialFrequency != null)
            {
                 s += ind + "differentialFrequency\n";

                 s += ind + "{\n" + 
                 this.DifferentialFrequency.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Duration? IncrementalFrequency
            // GraphQL -> incrementalFrequency: Duration (type)
            if (this.IncrementalFrequency != null)
            {
                 s += ind + "incrementalFrequency\n";

                 s += ind + "{\n" + 
                 this.IncrementalFrequency.AsFragment(indent+1) + 
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
            //      C# -> Duration? DifferentialFrequency
            // GraphQL -> differentialFrequency: Duration (type)
            if (this.DifferentialFrequency == null && Exploration.Includes(parent + ".differentialFrequency"))
            {
                this.DifferentialFrequency = new Duration();
                this.DifferentialFrequency.ApplyExploratoryFragment(parent + ".differentialFrequency");
            }
            //      C# -> Duration? IncrementalFrequency
            // GraphQL -> incrementalFrequency: Duration (type)
            if (this.IncrementalFrequency == null && Exploration.Includes(parent + ".incrementalFrequency"))
            {
                this.IncrementalFrequency = new Duration();
                this.IncrementalFrequency.ApplyExploratoryFragment(parent + ".incrementalFrequency");
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

    } // class Db2Config
    #endregion

    public static class ListDb2ConfigExtensions
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
            this List<Db2Config> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Db2Config> list, 
            String parent = "")
        {
            var item = new Db2Config();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types