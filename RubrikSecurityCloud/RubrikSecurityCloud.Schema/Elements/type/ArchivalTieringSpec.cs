// ArchivalTieringSpec.cs
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
    #region ArchivalTieringSpec
    public class ArchivalTieringSpec: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsInstantTieringEnabled
        // GraphQL -> isInstantTieringEnabled: Boolean! (scalar)
        [JsonProperty("isInstantTieringEnabled")]
        public System.Boolean? IsInstantTieringEnabled { get; set; }

        //      C# -> System.Int64? MinAccessibleDurationInSeconds
        // GraphQL -> minAccessibleDurationInSeconds: Long! (scalar)
        [JsonProperty("minAccessibleDurationInSeconds")]
        public System.Int64? MinAccessibleDurationInSeconds { get; set; }

        //      C# -> System.Boolean? ShouldTierExistingSnapshots
        // GraphQL -> shouldTierExistingSnapshots: Boolean! (scalar)
        [JsonProperty("shouldTierExistingSnapshots")]
        public System.Boolean? ShouldTierExistingSnapshots { get; set; }

        //      C# -> ColdStorageClass? ColdStorageClass
        // GraphQL -> coldStorageClass: ColdStorageClass! (enum)
        [JsonProperty("coldStorageClass")]
        public ColdStorageClass? ColdStorageClass { get; set; }

        #endregion

    #region methods

    public ArchivalTieringSpec Set(
        System.Boolean? IsInstantTieringEnabled = null,
        System.Int64? MinAccessibleDurationInSeconds = null,
        System.Boolean? ShouldTierExistingSnapshots = null,
        ColdStorageClass? ColdStorageClass = null
    ) 
    {
        if ( IsInstantTieringEnabled != null ) {
            this.IsInstantTieringEnabled = IsInstantTieringEnabled;
        }
        if ( MinAccessibleDurationInSeconds != null ) {
            this.MinAccessibleDurationInSeconds = MinAccessibleDurationInSeconds;
        }
        if ( ShouldTierExistingSnapshots != null ) {
            this.ShouldTierExistingSnapshots = ShouldTierExistingSnapshots;
        }
        if ( ColdStorageClass != null ) {
            this.ColdStorageClass = ColdStorageClass;
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
            //      C# -> System.Boolean? IsInstantTieringEnabled
            // GraphQL -> isInstantTieringEnabled: Boolean! (scalar)
            if (this.IsInstantTieringEnabled != null)
            {
                 s += ind + "isInstantTieringEnabled\n";

            }
            //      C# -> System.Int64? MinAccessibleDurationInSeconds
            // GraphQL -> minAccessibleDurationInSeconds: Long! (scalar)
            if (this.MinAccessibleDurationInSeconds != null)
            {
                 s += ind + "minAccessibleDurationInSeconds\n";

            }
            //      C# -> System.Boolean? ShouldTierExistingSnapshots
            // GraphQL -> shouldTierExistingSnapshots: Boolean! (scalar)
            if (this.ShouldTierExistingSnapshots != null)
            {
                 s += ind + "shouldTierExistingSnapshots\n";

            }
            //      C# -> ColdStorageClass? ColdStorageClass
            // GraphQL -> coldStorageClass: ColdStorageClass! (enum)
            if (this.ColdStorageClass != null)
            {
                 s += ind + "coldStorageClass\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsInstantTieringEnabled
            // GraphQL -> isInstantTieringEnabled: Boolean! (scalar)
            if (this.IsInstantTieringEnabled == null && Exploration.Includes(parent + ".isInstantTieringEnabled$"))
            {
                this.IsInstantTieringEnabled = new System.Boolean();
            }
            //      C# -> System.Int64? MinAccessibleDurationInSeconds
            // GraphQL -> minAccessibleDurationInSeconds: Long! (scalar)
            if (this.MinAccessibleDurationInSeconds == null && Exploration.Includes(parent + ".minAccessibleDurationInSeconds$"))
            {
                this.MinAccessibleDurationInSeconds = new System.Int64();
            }
            //      C# -> System.Boolean? ShouldTierExistingSnapshots
            // GraphQL -> shouldTierExistingSnapshots: Boolean! (scalar)
            if (this.ShouldTierExistingSnapshots == null && Exploration.Includes(parent + ".shouldTierExistingSnapshots$"))
            {
                this.ShouldTierExistingSnapshots = new System.Boolean();
            }
            //      C# -> ColdStorageClass? ColdStorageClass
            // GraphQL -> coldStorageClass: ColdStorageClass! (enum)
            if (this.ColdStorageClass == null && Exploration.Includes(parent + ".coldStorageClass$"))
            {
                this.ColdStorageClass = new ColdStorageClass();
            }
        }


    #endregion

    } // class ArchivalTieringSpec
    #endregion

    public static class ListArchivalTieringSpecExtensions
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
            this List<ArchivalTieringSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ArchivalTieringSpec> list, 
            String parent = "")
        {
            var item = new ArchivalTieringSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types