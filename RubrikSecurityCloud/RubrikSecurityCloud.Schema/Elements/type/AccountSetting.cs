// AccountSetting.cs
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
    #region AccountSetting
    public class AccountSetting: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsEmailNotificationEnabled
        // GraphQL -> isEmailNotificationEnabled: Boolean (scalar)
        [JsonProperty("isEmailNotificationEnabled")]
        public System.Boolean? IsEmailNotificationEnabled { get; set; }

        //      C# -> System.Boolean? IsEulaAccepted
        // GraphQL -> isEulaAccepted: Boolean (scalar)
        [JsonProperty("isEulaAccepted")]
        public System.Boolean? IsEulaAccepted { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AccountSetting";
    }

    public AccountSetting Set(
        System.Boolean? IsEmailNotificationEnabled = null,
        System.Boolean? IsEulaAccepted = null
    ) 
    {
        if ( IsEmailNotificationEnabled != null ) {
            this.IsEmailNotificationEnabled = IsEmailNotificationEnabled;
        }
        if ( IsEulaAccepted != null ) {
            this.IsEulaAccepted = IsEulaAccepted;
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
        //      C# -> System.Boolean? IsEmailNotificationEnabled
        // GraphQL -> isEmailNotificationEnabled: Boolean (scalar)
        if (this.IsEmailNotificationEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEmailNotificationEnabled\n" ;
            } else {
                s += ind + "isEmailNotificationEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsEulaAccepted
        // GraphQL -> isEulaAccepted: Boolean (scalar)
        if (this.IsEulaAccepted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEulaAccepted\n" ;
            } else {
                s += ind + "isEulaAccepted\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsEmailNotificationEnabled
        // GraphQL -> isEmailNotificationEnabled: Boolean (scalar)
        if (ec.Includes("isEmailNotificationEnabled",true))
        {
            if(this.IsEmailNotificationEnabled == null) {

                this.IsEmailNotificationEnabled = true;

            } else {


            }
        }
        else if (this.IsEmailNotificationEnabled != null && ec.Excludes("isEmailNotificationEnabled",true))
        {
            this.IsEmailNotificationEnabled = null;
        }
        //      C# -> System.Boolean? IsEulaAccepted
        // GraphQL -> isEulaAccepted: Boolean (scalar)
        if (ec.Includes("isEulaAccepted",true))
        {
            if(this.IsEulaAccepted == null) {

                this.IsEulaAccepted = true;

            } else {


            }
        }
        else if (this.IsEulaAccepted != null && ec.Excludes("isEulaAccepted",true))
        {
            this.IsEulaAccepted = null;
        }
    }


    #endregion

    } // class AccountSetting
    
    #endregion

    public static class ListAccountSettingExtensions
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
            this List<AccountSetting> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AccountSetting> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AccountSetting> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AccountSetting());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AccountSetting> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types