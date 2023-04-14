// LockoutState.cs
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
    #region LockoutState
    public class LockoutState: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsLocked
        // GraphQL -> isLocked: Boolean! (scalar)
        [JsonProperty("isLocked")]
        public System.Boolean? IsLocked { get; set; }

        //      C# -> DateTime? LockedAt
        // GraphQL -> lockedAt: DateTime (scalar)
        [JsonProperty("lockedAt")]
        public DateTime? LockedAt { get; set; }

        //      C# -> DateTime? UnlockedAt
        // GraphQL -> unlockedAt: DateTime (scalar)
        [JsonProperty("unlockedAt")]
        public DateTime? UnlockedAt { get; set; }

        //      C# -> LockMethod? LockMethod
        // GraphQL -> lockMethod: LockMethod! (enum)
        [JsonProperty("lockMethod")]
        public LockMethod? LockMethod { get; set; }

        //      C# -> UnlockMethod? UnlockMethod
        // GraphQL -> unlockMethod: UnlockMethod! (enum)
        [JsonProperty("unlockMethod")]
        public UnlockMethod? UnlockMethod { get; set; }

        #endregion

    #region methods

    public LockoutState Set(
        System.Boolean? IsLocked = null,
        DateTime? LockedAt = null,
        DateTime? UnlockedAt = null,
        LockMethod? LockMethod = null,
        UnlockMethod? UnlockMethod = null
    ) 
    {
        if ( IsLocked != null ) {
            this.IsLocked = IsLocked;
        }
        if ( LockedAt != null ) {
            this.LockedAt = LockedAt;
        }
        if ( UnlockedAt != null ) {
            this.UnlockedAt = UnlockedAt;
        }
        if ( LockMethod != null ) {
            this.LockMethod = LockMethod;
        }
        if ( UnlockMethod != null ) {
            this.UnlockMethod = UnlockMethod;
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
            //      C# -> System.Boolean? IsLocked
            // GraphQL -> isLocked: Boolean! (scalar)
            if (this.IsLocked != null)
            {
                 s += ind + "isLocked\n";

            }
            //      C# -> DateTime? LockedAt
            // GraphQL -> lockedAt: DateTime (scalar)
            if (this.LockedAt != null)
            {
                 s += ind + "lockedAt\n";

            }
            //      C# -> DateTime? UnlockedAt
            // GraphQL -> unlockedAt: DateTime (scalar)
            if (this.UnlockedAt != null)
            {
                 s += ind + "unlockedAt\n";

            }
            //      C# -> LockMethod? LockMethod
            // GraphQL -> lockMethod: LockMethod! (enum)
            if (this.LockMethod != null)
            {
                 s += ind + "lockMethod\n";

            }
            //      C# -> UnlockMethod? UnlockMethod
            // GraphQL -> unlockMethod: UnlockMethod! (enum)
            if (this.UnlockMethod != null)
            {
                 s += ind + "unlockMethod\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsLocked
            // GraphQL -> isLocked: Boolean! (scalar)
            if (this.IsLocked == null && Exploration.Includes(parent + ".isLocked$"))
            {
                this.IsLocked = new System.Boolean();
            }
            //      C# -> DateTime? LockedAt
            // GraphQL -> lockedAt: DateTime (scalar)
            if (this.LockedAt == null && Exploration.Includes(parent + ".lockedAt$"))
            {
                this.LockedAt = new DateTime();
            }
            //      C# -> DateTime? UnlockedAt
            // GraphQL -> unlockedAt: DateTime (scalar)
            if (this.UnlockedAt == null && Exploration.Includes(parent + ".unlockedAt$"))
            {
                this.UnlockedAt = new DateTime();
            }
            //      C# -> LockMethod? LockMethod
            // GraphQL -> lockMethod: LockMethod! (enum)
            if (this.LockMethod == null && Exploration.Includes(parent + ".lockMethod$"))
            {
                this.LockMethod = new LockMethod();
            }
            //      C# -> UnlockMethod? UnlockMethod
            // GraphQL -> unlockMethod: UnlockMethod! (enum)
            if (this.UnlockMethod == null && Exploration.Includes(parent + ".unlockMethod$"))
            {
                this.UnlockMethod = new UnlockMethod();
            }
        }


    #endregion

    } // class LockoutState
    #endregion

    public static class ListLockoutStateExtensions
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
            this List<LockoutState> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LockoutState> list, 
            String parent = "")
        {
            var item = new LockoutState();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types