// HostConnectionStatus.cs
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
    #region HostConnectionStatus
    public class HostConnectionStatus: IFragment
    {
        #region members
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        [JsonProperty("timestampMillis")]
        public DateTime? TimestampMillis { get; set; }

        //      C# -> HostConnectivityStatusEnum? Connectivity
        // GraphQL -> connectivity: HostConnectivityStatusEnum! (enum)
        [JsonProperty("connectivity")]
        public HostConnectivityStatusEnum? Connectivity { get; set; }

        #endregion

    #region methods

    public HostConnectionStatus Set(
        DateTime? TimestampMillis = null,
        HostConnectivityStatusEnum? Connectivity = null
    ) 
    {
        if ( TimestampMillis != null ) {
            this.TimestampMillis = TimestampMillis;
        }
        if ( Connectivity != null ) {
            this.Connectivity = Connectivity;
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
            //      C# -> DateTime? TimestampMillis
            // GraphQL -> timestampMillis: DateTime (scalar)
            if (this.TimestampMillis != null)
            {
                 s += ind + "timestampMillis\n";

            }
            //      C# -> HostConnectivityStatusEnum? Connectivity
            // GraphQL -> connectivity: HostConnectivityStatusEnum! (enum)
            if (this.Connectivity != null)
            {
                 s += ind + "connectivity\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? TimestampMillis
            // GraphQL -> timestampMillis: DateTime (scalar)
            if (this.TimestampMillis == null && Exploration.Includes(parent + ".timestampMillis$"))
            {
                this.TimestampMillis = new DateTime();
            }
            //      C# -> HostConnectivityStatusEnum? Connectivity
            // GraphQL -> connectivity: HostConnectivityStatusEnum! (enum)
            if (this.Connectivity == null && Exploration.Includes(parent + ".connectivity$"))
            {
                this.Connectivity = new HostConnectivityStatusEnum();
            }
        }


    #endregion

    } // class HostConnectionStatus
    #endregion

    public static class ListHostConnectionStatusExtensions
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
            this List<HostConnectionStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HostConnectionStatus> list, 
            String parent = "")
        {
            var item = new HostConnectionStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types