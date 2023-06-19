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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region LockoutState
    public class LockoutState: BaseType
    {
        #region members

        //      C# -> LockMethod? LockMethod
        // GraphQL -> lockMethod: LockMethod! (enum)
        [JsonProperty("lockMethod")]
        public LockMethod? LockMethod { get; set; }

        //      C# -> UnlockMethod? UnlockMethod
        // GraphQL -> unlockMethod: UnlockMethod! (enum)
        [JsonProperty("unlockMethod")]
        public UnlockMethod? UnlockMethod { get; set; }

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


        #endregion

    #region methods

    public LockoutState Set(
        LockMethod? LockMethod = null,
        UnlockMethod? UnlockMethod = null,
        System.Boolean? IsLocked = null,
        DateTime? LockedAt = null,
        DateTime? UnlockedAt = null
    ) 
    {
        if ( LockMethod != null ) {
            this.LockMethod = LockMethod;
        }
        if ( UnlockMethod != null ) {
            this.UnlockMethod = UnlockMethod;
        }
        if ( IsLocked != null ) {
            this.IsLocked = IsLocked;
        }
        if ( LockedAt != null ) {
            this.LockedAt = LockedAt;
        }
        if ( UnlockedAt != null ) {
            this.UnlockedAt = UnlockedAt;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> LockMethod? LockMethod
        // GraphQL -> lockMethod: LockMethod! (enum)
        if (this.LockMethod != null) {
            s += ind + "lockMethod\n" ;
        }
        //      C# -> UnlockMethod? UnlockMethod
        // GraphQL -> unlockMethod: UnlockMethod! (enum)
        if (this.UnlockMethod != null) {
            s += ind + "unlockMethod\n" ;
        }
        //      C# -> System.Boolean? IsLocked
        // GraphQL -> isLocked: Boolean! (scalar)
        if (this.IsLocked != null) {
            s += ind + "isLocked\n" ;
        }
        //      C# -> DateTime? LockedAt
        // GraphQL -> lockedAt: DateTime (scalar)
        if (this.LockedAt != null) {
            s += ind + "lockedAt\n" ;
        }
        //      C# -> DateTime? UnlockedAt
        // GraphQL -> unlockedAt: DateTime (scalar)
        if (this.UnlockedAt != null) {
            s += ind + "unlockedAt\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> LockMethod? LockMethod
        // GraphQL -> lockMethod: LockMethod! (enum)
        if (this.LockMethod == null && Exploration.Includes(parent + ".lockMethod", true))
        {
            this.LockMethod = new LockMethod();
        }
        //      C# -> UnlockMethod? UnlockMethod
        // GraphQL -> unlockMethod: UnlockMethod! (enum)
        if (this.UnlockMethod == null && Exploration.Includes(parent + ".unlockMethod", true))
        {
            this.UnlockMethod = new UnlockMethod();
        }
        //      C# -> System.Boolean? IsLocked
        // GraphQL -> isLocked: Boolean! (scalar)
        if (this.IsLocked == null && Exploration.Includes(parent + ".isLocked", true))
        {
            this.IsLocked = true;
        }
        //      C# -> DateTime? LockedAt
        // GraphQL -> lockedAt: DateTime (scalar)
        if (this.LockedAt == null && Exploration.Includes(parent + ".lockedAt", true))
        {
            this.LockedAt = new DateTime();
        }
        //      C# -> DateTime? UnlockedAt
        // GraphQL -> unlockedAt: DateTime (scalar)
        if (this.UnlockedAt == null && Exploration.Includes(parent + ".unlockedAt", true))
        {
            this.UnlockedAt = new DateTime();
        }
    }


    #endregion

    } // class LockoutState
    
    #endregion

    public static class ListLockoutStateExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<LockoutState> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LockoutState> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LockoutState());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types