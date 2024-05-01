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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<UserSetting>? Settings
        // GraphQL -> settings: [UserSetting!]! (type)
        if (this.Settings != null) {
            var fspec = this.Settings.AsFieldSpec(conf.Child("settings"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "settings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UserSetting>? Settings
        // GraphQL -> settings: [UserSetting!]! (type)
        if (ec.Includes("settings",false))
        {
            if(this.Settings == null) {

                this.Settings = new List<UserSetting>();
                this.Settings.ApplyExploratoryFieldSpec(ec.NewChild("settings"));

            } else {

                this.Settings.ApplyExploratoryFieldSpec(ec.NewChild("settings"));

            }
        }
        else if (this.Settings != null && ec.Excludes("settings",false))
        {
            this.Settings = null;
        }
    }


    #endregion

    } // class UserSettings
    
    #endregion

    public static class ListUserSettingsExtensions
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
            this List<UserSettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserSettings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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