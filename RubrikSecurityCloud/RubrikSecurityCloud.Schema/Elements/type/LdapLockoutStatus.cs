// LdapLockoutStatus.cs
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
    #region LdapLockoutStatus
    public class LdapLockoutStatus: BaseType
    {
        #region members

        //      C# -> LdapLockReason? LockReason
        // GraphQL -> lockReason: LdapLockReason! (enum)
        [JsonProperty("lockReason")]
        public LdapLockReason? LockReason { get; set; }

        //      C# -> LdapUnlockReason? UnlockReason
        // GraphQL -> unlockReason: LdapUnlockReason! (enum)
        [JsonProperty("unlockReason")]
        public LdapUnlockReason? UnlockReason { get; set; }

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

    public override string GetGqlTypeName() {
        return "LdapLockoutStatus";
    }

    public LdapLockoutStatus Set(
        LdapLockReason? LockReason = null,
        LdapUnlockReason? UnlockReason = null,
        System.Boolean? IsLocked = null,
        DateTime? LockedAt = null,
        DateTime? UnlockedAt = null
    ) 
    {
        if ( LockReason != null ) {
            this.LockReason = LockReason;
        }
        if ( UnlockReason != null ) {
            this.UnlockReason = UnlockReason;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> LdapLockReason? LockReason
        // GraphQL -> lockReason: LdapLockReason! (enum)
        if (this.LockReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lockReason\n" ;
            } else {
                s += ind + "lockReason\n" ;
            }
        }
        //      C# -> LdapUnlockReason? UnlockReason
        // GraphQL -> unlockReason: LdapUnlockReason! (enum)
        if (this.UnlockReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unlockReason\n" ;
            } else {
                s += ind + "unlockReason\n" ;
            }
        }
        //      C# -> System.Boolean? IsLocked
        // GraphQL -> isLocked: Boolean! (scalar)
        if (this.IsLocked != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLocked\n" ;
            } else {
                s += ind + "isLocked\n" ;
            }
        }
        //      C# -> DateTime? LockedAt
        // GraphQL -> lockedAt: DateTime (scalar)
        if (this.LockedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lockedAt\n" ;
            } else {
                s += ind + "lockedAt\n" ;
            }
        }
        //      C# -> DateTime? UnlockedAt
        // GraphQL -> unlockedAt: DateTime (scalar)
        if (this.UnlockedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unlockedAt\n" ;
            } else {
                s += ind + "unlockedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> LdapLockReason? LockReason
        // GraphQL -> lockReason: LdapLockReason! (enum)
        if (ec.Includes("lockReason",true))
        {
            if(this.LockReason == null) {

                this.LockReason = new LdapLockReason();

            } else {


            }
        }
        else if (this.LockReason != null && ec.Excludes("lockReason",true))
        {
            this.LockReason = null;
        }
        //      C# -> LdapUnlockReason? UnlockReason
        // GraphQL -> unlockReason: LdapUnlockReason! (enum)
        if (ec.Includes("unlockReason",true))
        {
            if(this.UnlockReason == null) {

                this.UnlockReason = new LdapUnlockReason();

            } else {


            }
        }
        else if (this.UnlockReason != null && ec.Excludes("unlockReason",true))
        {
            this.UnlockReason = null;
        }
        //      C# -> System.Boolean? IsLocked
        // GraphQL -> isLocked: Boolean! (scalar)
        if (ec.Includes("isLocked",true))
        {
            if(this.IsLocked == null) {

                this.IsLocked = true;

            } else {


            }
        }
        else if (this.IsLocked != null && ec.Excludes("isLocked",true))
        {
            this.IsLocked = null;
        }
        //      C# -> DateTime? LockedAt
        // GraphQL -> lockedAt: DateTime (scalar)
        if (ec.Includes("lockedAt",true))
        {
            if(this.LockedAt == null) {

                this.LockedAt = new DateTime();

            } else {


            }
        }
        else if (this.LockedAt != null && ec.Excludes("lockedAt",true))
        {
            this.LockedAt = null;
        }
        //      C# -> DateTime? UnlockedAt
        // GraphQL -> unlockedAt: DateTime (scalar)
        if (ec.Includes("unlockedAt",true))
        {
            if(this.UnlockedAt == null) {

                this.UnlockedAt = new DateTime();

            } else {


            }
        }
        else if (this.UnlockedAt != null && ec.Excludes("unlockedAt",true))
        {
            this.UnlockedAt = null;
        }
    }


    #endregion

    } // class LdapLockoutStatus
    
    #endregion

    public static class ListLdapLockoutStatusExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<LdapLockoutStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LdapLockoutStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LdapLockoutStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LdapLockoutStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LdapLockoutStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types