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

    public override string GetGqlTypeName() {
        return "ClassificationBannerSettings";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> BannerColor? BannerColor
        // GraphQL -> bannerColor: BannerColor! (enum)
        if (this.BannerColor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bannerColor\n" ;
            } else {
                s += ind + "bannerColor\n" ;
            }
        }
        //      C# -> System.String? BannerText
        // GraphQL -> bannerText: String! (scalar)
        if (this.BannerText != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bannerText\n" ;
            } else {
                s += ind + "bannerText\n" ;
            }
        }
        //      C# -> System.Boolean? IsBannerEnabled
        // GraphQL -> isBannerEnabled: Boolean! (scalar)
        if (this.IsBannerEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBannerEnabled\n" ;
            } else {
                s += ind + "isBannerEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> BannerColor? BannerColor
        // GraphQL -> bannerColor: BannerColor! (enum)
        if (ec.Includes("bannerColor",true))
        {
            if(this.BannerColor == null) {

                this.BannerColor = new BannerColor();

            } else {


            }
        }
        else if (this.BannerColor != null && ec.Excludes("bannerColor",true))
        {
            this.BannerColor = null;
        }
        //      C# -> System.String? BannerText
        // GraphQL -> bannerText: String! (scalar)
        if (ec.Includes("bannerText",true))
        {
            if(this.BannerText == null) {

                this.BannerText = "FETCH";

            } else {


            }
        }
        else if (this.BannerText != null && ec.Excludes("bannerText",true))
        {
            this.BannerText = null;
        }
        //      C# -> System.Boolean? IsBannerEnabled
        // GraphQL -> isBannerEnabled: Boolean! (scalar)
        if (ec.Includes("isBannerEnabled",true))
        {
            if(this.IsBannerEnabled == null) {

                this.IsBannerEnabled = true;

            } else {


            }
        }
        else if (this.IsBannerEnabled != null && ec.Excludes("isBannerEnabled",true))
        {
            this.IsBannerEnabled = null;
        }
    }


    #endregion

    } // class ClassificationBannerSettings
    
    #endregion

    public static class ListClassificationBannerSettingsExtensions
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
            this List<ClassificationBannerSettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClassificationBannerSettings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClassificationBannerSettings> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClassificationBannerSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClassificationBannerSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types