// UserSettings.cs
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
    #region UserSettings
    public class UserSettings: BaseType
    {
        #region members

        //      C# -> List<UserSetting>? Settings
        // GraphQL -> settings: [UserSetting!]! (type)
        [JsonProperty("settings")]
        public List<UserSetting>? Settings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserSettings";
    }

    public UserSettings Set(
        List<UserSetting>? Settings = null
    ) 
    {
        if ( Settings != null ) {
            this.Settings = Settings;
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
        //      C# -> List<UserSetting>? Settings
        // GraphQL -> settings: [UserSetting!]! (type)
        if (this.Settings != null) {
            var fspec = this.Settings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "settings {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UserSetting>? Settings
        // GraphQL -> settings: [UserSetting!]! (type)
        if (this.Settings == null && ec.Includes("settings",false))
        {
            this.Settings = new List<UserSetting>();
            this.Settings.ApplyExploratoryFieldSpec(ec.NewChild("settings"));
        }
    }


    #endregion

    } // class UserSettings
    
    #endregion

    public static class ListUserSettingsExtensions
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
            this List<UserSettings> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserSettings> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types