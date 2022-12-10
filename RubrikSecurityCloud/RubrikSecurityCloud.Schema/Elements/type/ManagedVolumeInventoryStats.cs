// ManagedVolumeInventoryStats.cs
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
    #region ManagedVolumeInventoryStats
    public class ManagedVolumeInventoryStats: IFragment
    {
        #region members
        //      C# -> ManagedVolumeStats? AlwaysMounted
        // GraphQL -> alwaysMounted: ManagedVolumeStats! (type)
        [JsonProperty("alwaysMounted")]
        public ManagedVolumeStats? AlwaysMounted { get; set; }

        //      C# -> ManagedVolumeStats? SlaBased
        // GraphQL -> slaBased: ManagedVolumeStats! (type)
        [JsonProperty("slaBased")]
        public ManagedVolumeStats? SlaBased { get; set; }

        #endregion

    #region methods

    public ManagedVolumeInventoryStats Set(
        ManagedVolumeStats? AlwaysMounted = null,
        ManagedVolumeStats? SlaBased = null
    ) 
    {
        if ( AlwaysMounted != null ) {
            this.AlwaysMounted = AlwaysMounted;
        }
        if ( SlaBased != null ) {
            this.SlaBased = SlaBased;
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
            //      C# -> ManagedVolumeStats? AlwaysMounted
            // GraphQL -> alwaysMounted: ManagedVolumeStats! (type)
            if (this.AlwaysMounted != null)
            {
                 s += ind + "alwaysMounted\n";

                 s += ind + "{\n" + 
                 this.AlwaysMounted.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeStats? SlaBased
            // GraphQL -> slaBased: ManagedVolumeStats! (type)
            if (this.SlaBased != null)
            {
                 s += ind + "slaBased\n";

                 s += ind + "{\n" + 
                 this.SlaBased.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> ManagedVolumeStats? AlwaysMounted
            // GraphQL -> alwaysMounted: ManagedVolumeStats! (type)
            if (this.AlwaysMounted == null && Exploration.Includes(parent + ".alwaysMounted"))
            {
                this.AlwaysMounted = new ManagedVolumeStats();
                this.AlwaysMounted.ApplyExploratoryFragment(parent + ".alwaysMounted");
            }
            //      C# -> ManagedVolumeStats? SlaBased
            // GraphQL -> slaBased: ManagedVolumeStats! (type)
            if (this.SlaBased == null && Exploration.Includes(parent + ".slaBased"))
            {
                this.SlaBased = new ManagedVolumeStats();
                this.SlaBased.ApplyExploratoryFragment(parent + ".slaBased");
            }
        }


    #endregion

    } // class ManagedVolumeInventoryStats
    #endregion

    public static class ListManagedVolumeInventoryStatsExtensions
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
            this List<ManagedVolumeInventoryStats> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeInventoryStats> list, 
            String parent = "")
        {
            var item = new ManagedVolumeInventoryStats();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types