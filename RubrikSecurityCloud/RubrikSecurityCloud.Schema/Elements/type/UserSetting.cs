// UserSetting.cs
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
    #region UserSetting
    public class UserSetting: BaseType
    {
        #region members

        //      C# -> System.String? Setting
        // GraphQL -> setting: String! (scalar)
        [JsonProperty("setting")]
        public System.String? Setting { get; set; }

        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        [JsonProperty("value")]
        public System.String? Value { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserSetting";
    }

    public UserSetting Set(
        System.String? Setting = null,
        System.String? Value = null
    ) 
    {
        if ( Setting != null ) {
            this.Setting = Setting;
        }
        if ( Value != null ) {
            this.Value = Value;
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
        //      C# -> System.String? Setting
        // GraphQL -> setting: String! (scalar)
        if (this.Setting != null) {
            s += ind + "setting\n" ;
        }
        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        if (this.Value != null) {
            s += ind + "value\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Setting
        // GraphQL -> setting: String! (scalar)
        if (this.Setting == null && ec.Includes("setting",true))
        {
            this.Setting = "FETCH";
        }
        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        if (this.Value == null && ec.Includes("value",true))
        {
            this.Value = "FETCH";
        }
    }


    #endregion

    } // class UserSetting
    
    #endregion

    public static class ListUserSettingExtensions
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
            this List<UserSetting> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserSetting> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserSetting());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UserSetting> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types