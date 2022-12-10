// HyperVstatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:36.
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
    #region HyperVstatus
    public class HyperVstatus: IFragment
    {
        #region members
        //      C# -> System.String? Connectivity
        // GraphQL -> connectivity: String! (scalar)
        [JsonProperty("connectivity")]
        public System.String? Connectivity { get; set; }

        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        [JsonProperty("timestampMillis")]
        public DateTime? TimestampMillis { get; set; }

        #endregion

    #region methods

    public HyperVstatus Set(
        System.String? Connectivity = null,
        DateTime? TimestampMillis = null
    ) 
    {
        if ( Connectivity != null ) {
            this.Connectivity = Connectivity;
        }
        if ( TimestampMillis != null ) {
            this.TimestampMillis = TimestampMillis;
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
            //      C# -> System.String? Connectivity
            // GraphQL -> connectivity: String! (scalar)
            if (this.Connectivity != null)
            {
                 s += ind + "connectivity\n";

            }
            //      C# -> DateTime? TimestampMillis
            // GraphQL -> timestampMillis: DateTime (scalar)
            if (this.TimestampMillis != null)
            {
                 s += ind + "timestampMillis\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Connectivity
            // GraphQL -> connectivity: String! (scalar)
            if (this.Connectivity == null && Exploration.Includes(parent + ".connectivity$"))
            {
                this.Connectivity = new System.String("FETCH");
            }
            //      C# -> DateTime? TimestampMillis
            // GraphQL -> timestampMillis: DateTime (scalar)
            if (this.TimestampMillis == null && Exploration.Includes(parent + ".timestampMillis$"))
            {
                this.TimestampMillis = new DateTime();
            }
        }


    #endregion

    } // class HyperVstatus
    #endregion

    public static class ListHyperVstatusExtensions
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
            this List<HyperVstatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HyperVstatus> list, 
            String parent = "")
        {
            var item = new HyperVstatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types