// ManagedVolumeStats.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:42.
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
    #region ManagedVolumeStats
    public class ManagedVolumeStats: IFragment
    {
        #region members
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        [JsonProperty("provisionedSize")]
        public System.Int64? ProvisionedSize { get; set; }

        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        [JsonProperty("usedSize")]
        public System.Int64? UsedSize { get; set; }

        #endregion

    #region methods

    public ManagedVolumeStats Set(
        System.Int32? Count = null,
        System.Int64? ProvisionedSize = null,
        System.Int64? UsedSize = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( ProvisionedSize != null ) {
            this.ProvisionedSize = ProvisionedSize;
        }
        if ( UsedSize != null ) {
            this.UsedSize = UsedSize;
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
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> System.Int64? ProvisionedSize
            // GraphQL -> provisionedSize: Long! (scalar)
            if (this.ProvisionedSize != null)
            {
                 s += ind + "provisionedSize\n";

            }
            //      C# -> System.Int64? UsedSize
            // GraphQL -> usedSize: Long! (scalar)
            if (this.UsedSize != null)
            {
                 s += ind + "usedSize\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int32();
            }
            //      C# -> System.Int64? ProvisionedSize
            // GraphQL -> provisionedSize: Long! (scalar)
            if (this.ProvisionedSize == null && Exploration.Includes(parent + ".provisionedSize$"))
            {
                this.ProvisionedSize = new System.Int64();
            }
            //      C# -> System.Int64? UsedSize
            // GraphQL -> usedSize: Long! (scalar)
            if (this.UsedSize == null && Exploration.Includes(parent + ".usedSize$"))
            {
                this.UsedSize = new System.Int64();
            }
        }


    #endregion

    } // class ManagedVolumeStats
    #endregion

    public static class ListManagedVolumeStatsExtensions
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
            this List<ManagedVolumeStats> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeStats> list, 
            String parent = "")
        {
            var item = new ManagedVolumeStats();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types