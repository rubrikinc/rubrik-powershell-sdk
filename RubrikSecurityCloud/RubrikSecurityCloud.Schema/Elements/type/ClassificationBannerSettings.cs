// ClassificationBannerSettings.cs
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
    #region ClassificationBannerSettings
    public class ClassificationBannerSettings: BaseType
    {
        #region members

        //      C# -> BannerColor? BannerColor
        // GraphQL -> bannerColor: BannerColor! (enum)
        [JsonProperty("bannerColor")]
        public BannerColor? BannerColor { get; set; }

        //      C# -> System.String? BannerText
        // GraphQL -> bannerText: String! (scalar)
        [JsonProperty("bannerText")]
        public System.String? BannerText { get; set; }

        //      C# -> System.Boolean? IsBannerEnabled
        // GraphQL -> isBannerEnabled: Boolean! (scalar)
        [JsonProperty("isBannerEnabled")]
        public System.Boolean? IsBannerEnabled { get; set; }


        #endregion

    #region methods

    public ClassificationBannerSettings Set(
        BannerColor? BannerColor = null,
        System.String? BannerText = null,
        System.Boolean? IsBannerEnabled = null
    ) 
    {
        if ( BannerColor != null ) {
            this.BannerColor = BannerColor;
        }
        if ( BannerText != null ) {
            this.BannerText = BannerText;
        }
        if ( IsBannerEnabled != null ) {
            this.IsBannerEnabled = IsBannerEnabled;
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
        //      C# -> BannerColor? BannerColor
        // GraphQL -> bannerColor: BannerColor! (enum)
        if (this.BannerColor != null) {
            s += ind + "bannerColor\n" ;
        }
        //      C# -> System.String? BannerText
        // GraphQL -> bannerText: String! (scalar)
        if (this.BannerText != null) {
            s += ind + "bannerText\n" ;
        }
        //      C# -> System.Boolean? IsBannerEnabled
        // GraphQL -> isBannerEnabled: Boolean! (scalar)
        if (this.IsBannerEnabled != null) {
            s += ind + "isBannerEnabled\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> BannerColor? BannerColor
        // GraphQL -> bannerColor: BannerColor! (enum)
        if (this.BannerColor == null && Exploration.Includes(parent + ".bannerColor", true))
        {
            this.BannerColor = new BannerColor();
        }
        //      C# -> System.String? BannerText
        // GraphQL -> bannerText: String! (scalar)
        if (this.BannerText == null && Exploration.Includes(parent + ".bannerText", true))
        {
            this.BannerText = "FETCH";
        }
        //      C# -> System.Boolean? IsBannerEnabled
        // GraphQL -> isBannerEnabled: Boolean! (scalar)
        if (this.IsBannerEnabled == null && Exploration.Includes(parent + ".isBannerEnabled", true))
        {
            this.IsBannerEnabled = true;
        }
    }


    #endregion

    } // class ClassificationBannerSettings
    
    #endregion

    public static class ListClassificationBannerSettingsExtensions
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
            this List<ClassificationBannerSettings> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClassificationBannerSettings> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClassificationBannerSettings());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types