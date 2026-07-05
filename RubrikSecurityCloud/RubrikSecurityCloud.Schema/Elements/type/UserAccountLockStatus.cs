// UserAccountLockStatus.cs
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
    #region UserAccountLockStatus
    public class UserAccountLockStatus: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsLocked
        // GraphQL -> isLocked: Boolean! (scalar)
        [JsonProperty("isLocked")]
        public System.Boolean? IsLocked { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String (scalar)
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserAccountLockStatus";
    }

    public UserAccountLockStatus Set(
        System.Boolean? IsLocked = null,
        System.String? Reason = null
    ) 
    {
        if ( IsLocked != null ) {
            this.IsLocked = IsLocked;
        }
        if ( Reason != null ) {
            this.Reason = Reason;
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
        //      C# -> System.Boolean? IsLocked
        // GraphQL -> isLocked: Boolean! (scalar)
        if (this.IsLocked != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLocked\n" ;
            } else {
                s += ind + "isLocked\n" ;
            }
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String (scalar)
        if (this.Reason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reason\n" ;
            } else {
                s += ind + "reason\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? Reason
        // GraphQL -> reason: String (scalar)
        if (ec.Includes("reason",true))
        {
            if(this.Reason == null) {

                this.Reason = "FETCH";

            } else {


            }
        }
        else if (this.Reason != null && ec.Excludes("reason",true))
        {
            this.Reason = null;
        }
    }


    #endregion

    } // class UserAccountLockStatus
    
    #endregion

    public static class ListUserAccountLockStatusExtensions
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
            this List<UserAccountLockStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserAccountLockStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UserAccountLockStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserAccountLockStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserAccountLockStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types