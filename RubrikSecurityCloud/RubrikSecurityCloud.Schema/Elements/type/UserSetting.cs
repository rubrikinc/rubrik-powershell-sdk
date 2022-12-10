// UserSetting.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    #region UserSetting
    public class UserSetting: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Setting
            // GraphQL -> setting: String! (scalar)
            if (this.Setting != null)
            {
                 s += ind + "setting\n";

            }
            //      C# -> System.String? Value
            // GraphQL -> value: String! (scalar)
            if (this.Value != null)
            {
                 s += ind + "value\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Setting
            // GraphQL -> setting: String! (scalar)
            if (this.Setting == null && Exploration.Includes(parent + ".setting$"))
            {
                this.Setting = new System.String("FETCH");
            }
            //      C# -> System.String? Value
            // GraphQL -> value: String! (scalar)
            if (this.Value == null && Exploration.Includes(parent + ".value$"))
            {
                this.Value = new System.String("FETCH");
            }
        }


    #endregion

    } // class UserSetting
    #endregion

    public static class ListUserSettingExtensions
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
            this List<UserSetting> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UserSetting> list, 
            String parent = "")
        {
            var item = new UserSetting();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types