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

        //      C# -> LockMethod? CurrentLockMethod
        // GraphQL -> currentLockMethod: LockMethod! (enum)
        [JsonProperty("currentLockMethod")]
        public LockMethod? CurrentLockMethod { get; set; }

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

    public override string GetGqlTypeName() {
        return "LockoutState";
    }

    public LockoutState Set(
        LockMethod? CurrentLockMethod = null,
        LockMethod? LockMethod = null,
        UnlockMethod? UnlockMethod = null,
        System.Boolean? IsLocked = null,
        DateTime? LockedAt = null,
        DateTime? UnlockedAt = null
    ) 
    {
        if ( CurrentLockMethod != null ) {
            this.CurrentLockMethod = CurrentLockMethod;
        }
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> LockMethod? CurrentLockMethod
        // GraphQL -> currentLockMethod: LockMethod! (enum)
        if (this.CurrentLockMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentLockMethod\n" ;
            } else {
                s += ind + "currentLockMethod\n" ;
            }
        }
        //      C# -> LockMethod? LockMethod
        // GraphQL -> lockMethod: LockMethod! (enum)
        if (this.LockMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lockMethod\n" ;
            } else {
                s += ind + "lockMethod\n" ;
            }
        }
        //      C# -> UnlockMethod? UnlockMethod
        // GraphQL -> unlockMethod: UnlockMethod! (enum)
        if (this.UnlockMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unlockMethod\n" ;
            } else {
                s += ind + "unlockMethod\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> LockMethod? CurrentLockMethod
        // GraphQL -> currentLockMethod: LockMethod! (enum)
        if (ec.Includes("currentLockMethod",true))
        {
            if(this.CurrentLockMethod == null) {

                this.CurrentLockMethod = new LockMethod();

            } else {


            }
        }
        else if (this.CurrentLockMethod != null && ec.Excludes("currentLockMethod",true))
        {
            this.CurrentLockMethod = null;
        }
        //      C# -> LockMethod? LockMethod
        // GraphQL -> lockMethod: LockMethod! (enum)
        if (ec.Includes("lockMethod",true))
        {
            if(this.LockMethod == null) {

                this.LockMethod = new LockMethod();

            } else {


            }
        }
        else if (this.LockMethod != null && ec.Excludes("lockMethod",true))
        {
            this.LockMethod = null;
        }
        //      C# -> UnlockMethod? UnlockMethod
        // GraphQL -> unlockMethod: UnlockMethod! (enum)
        if (ec.Includes("unlockMethod",true))
        {
            if(this.UnlockMethod == null) {

                this.UnlockMethod = new UnlockMethod();

            } else {


            }
        }
        else if (this.UnlockMethod != null && ec.Excludes("unlockMethod",true))
        {
            this.UnlockMethod = null;
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

    } // class LockoutState
    
    #endregion

    public static class ListLockoutStateExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<LockoutState> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LockoutState> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LockoutState> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LockoutState());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LockoutState> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types