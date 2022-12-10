// NcdSlaComplianceData.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:12.
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
    #region NcdSlaComplianceData
    public class NcdSlaComplianceData: IFragment
    {
        #region members
        //      C# -> System.Int32? JobsFailing
        // GraphQL -> jobsFailing: Int! (scalar)
        [JsonProperty("jobsFailing")]
        public System.Int32? JobsFailing { get; set; }

        //      C# -> System.Int32? JobsPassing
        // GraphQL -> jobsPassing: Int! (scalar)
        [JsonProperty("jobsPassing")]
        public System.Int32? JobsPassing { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        #endregion

    #region methods

    public NcdSlaComplianceData Set(
        System.Int32? JobsFailing = null,
        System.Int32? JobsPassing = null,
        DateTime? Timestamp = null
    ) 
    {
        if ( JobsFailing != null ) {
            this.JobsFailing = JobsFailing;
        }
        if ( JobsPassing != null ) {
            this.JobsPassing = JobsPassing;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
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
            //      C# -> System.Int32? JobsFailing
            // GraphQL -> jobsFailing: Int! (scalar)
            if (this.JobsFailing != null)
            {
                 s += ind + "jobsFailing\n";

            }
            //      C# -> System.Int32? JobsPassing
            // GraphQL -> jobsPassing: Int! (scalar)
            if (this.JobsPassing != null)
            {
                 s += ind + "jobsPassing\n";

            }
            //      C# -> DateTime? Timestamp
            // GraphQL -> timestamp: DateTime (scalar)
            if (this.Timestamp != null)
            {
                 s += ind + "timestamp\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? JobsFailing
            // GraphQL -> jobsFailing: Int! (scalar)
            if (this.JobsFailing == null && Exploration.Includes(parent + ".jobsFailing$"))
            {
                this.JobsFailing = new System.Int32();
            }
            //      C# -> System.Int32? JobsPassing
            // GraphQL -> jobsPassing: Int! (scalar)
            if (this.JobsPassing == null && Exploration.Includes(parent + ".jobsPassing$"))
            {
                this.JobsPassing = new System.Int32();
            }
            //      C# -> DateTime? Timestamp
            // GraphQL -> timestamp: DateTime (scalar)
            if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp$"))
            {
                this.Timestamp = new DateTime();
            }
        }


    #endregion

    } // class NcdSlaComplianceData
    #endregion

    public static class ListNcdSlaComplianceDataExtensions
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
            this List<NcdSlaComplianceData> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NcdSlaComplianceData> list, 
            String parent = "")
        {
            var item = new NcdSlaComplianceData();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types