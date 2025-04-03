// UserLockoutEvent.cs
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
    #region UserLockoutEvent
    public class UserLockoutEvent: BaseType
    {
        #region members

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime! (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        //      C# -> LockoutEvent? LockoutEvent
        // GraphQL -> lockoutEvent: LockoutEvent! (union)
        [JsonProperty("lockoutEvent")]
        public LockoutEvent? LockoutEvent { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserLockoutEvent";
    }

    public UserLockoutEvent Set(
        DateTime? Timestamp = null,
        LockoutEvent? LockoutEvent = null
    ) 
    {
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( LockoutEvent != null ) {
            this.LockoutEvent = LockoutEvent;
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
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime! (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        //      C# -> LockoutEvent? LockoutEvent
        // GraphQL -> lockoutEvent: LockoutEvent! (union)
        if (this.LockoutEvent != null) {
            var fspec = this.LockoutEvent.AsFieldSpec(conf.Child("lockoutEvent"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lockoutEvent" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime! (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = new DateTime();

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
        //      C# -> LockoutEvent? LockoutEvent
        // GraphQL -> lockoutEvent: LockoutEvent! (union)
        if (ec.Includes("lockoutEvent",false))
        {
            if(this.LockoutEvent == null) {

                var impls = new List<LockoutEvent>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("lockoutEvent"));
                this.LockoutEvent = (LockoutEvent)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<LockoutEvent>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("lockoutEvent"));
                this.LockoutEvent = (LockoutEvent)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.LockoutEvent != null && ec.Excludes("lockoutEvent",false))
        {
            this.LockoutEvent = null;
        }
    }


    #endregion

    } // class UserLockoutEvent
    
    #endregion

    public static class ListUserLockoutEventExtensions
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
            this List<UserLockoutEvent> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserLockoutEvent> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UserLockoutEvent> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserLockoutEvent());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserLockoutEvent> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types