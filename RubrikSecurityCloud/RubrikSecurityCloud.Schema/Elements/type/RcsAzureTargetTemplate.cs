// RcsAzureTargetTemplate.cs
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
    #region RcsAzureTargetTemplate
 
    public class RcsAzureTargetTemplate: BaseType, TargetTemplate
    {
        #region members

        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        [JsonProperty("cloudNativeLocTemplateType")]
        public CloudNativeLocTemplateType? CloudNativeLocTemplateType { get; set; }

        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        [JsonProperty("redundancy")]
        public RcvRedundancy? Redundancy { get; set; }

        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        [JsonProperty("region")]
        public RcsRegionEnumType? Region { get; set; }

        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        [JsonProperty("targetType")]
        public TargetType? TargetType { get; set; }

        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        [JsonProperty("tier")]
        public RcsTierEnumType? Tier { get; set; }

        //      C# -> RcsImmutabilitySettings? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: RcsImmutabilitySettings! (type)
        [JsonProperty("immutabilitySettings")]
        public RcsImmutabilitySettings? ImmutabilitySettings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcsAzureTargetTemplate";
    }

    public RcsAzureTargetTemplate Set(
        CloudNativeLocTemplateType? CloudNativeLocTemplateType = null,
        RcvRedundancy? Redundancy = null,
        RcsRegionEnumType? Region = null,
        TargetType? TargetType = null,
        RcsTierEnumType? Tier = null,
        RcsImmutabilitySettings? ImmutabilitySettings = null
    ) 
    {
        if ( CloudNativeLocTemplateType != null ) {
            this.CloudNativeLocTemplateType = CloudNativeLocTemplateType;
        }
        if ( Redundancy != null ) {
            this.Redundancy = Redundancy;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
        }
        if ( ImmutabilitySettings != null ) {
            this.ImmutabilitySettings = ImmutabilitySettings;
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
        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        if (this.CloudNativeLocTemplateType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudNativeLocTemplateType\n" ;
            } else {
                s += ind + "cloudNativeLocTemplateType\n" ;
            }
        }
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (this.Redundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redundancy\n" ;
            } else {
                s += ind + "redundancy\n" ;
            }
        }
        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetType\n" ;
            } else {
                s += ind + "targetType\n" ;
            }
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        //      C# -> RcsImmutabilitySettings? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: RcsImmutabilitySettings! (type)
        if (this.ImmutabilitySettings != null) {
            var fspec = this.ImmutabilitySettings.AsFieldSpec(conf.Child("immutabilitySettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "immutabilitySettings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        if (ec.Includes("cloudNativeLocTemplateType",true))
        {
            if(this.CloudNativeLocTemplateType == null) {

                this.CloudNativeLocTemplateType = new CloudNativeLocTemplateType();

            } else {


            }
        }
        else if (this.CloudNativeLocTemplateType != null && ec.Excludes("cloudNativeLocTemplateType",true))
        {
            this.CloudNativeLocTemplateType = null;
        }
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (ec.Includes("redundancy",true))
        {
            if(this.Redundancy == null) {

                this.Redundancy = new RcvRedundancy();

            } else {


            }
        }
        else if (this.Redundancy != null && ec.Excludes("redundancy",true))
        {
            this.Redundancy = null;
        }
        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new RcsRegionEnumType();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (ec.Includes("targetType",true))
        {
            if(this.TargetType == null) {

                this.TargetType = new TargetType();

            } else {


            }
        }
        else if (this.TargetType != null && ec.Excludes("targetType",true))
        {
            this.TargetType = null;
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = new RcsTierEnumType();

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
        //      C# -> RcsImmutabilitySettings? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: RcsImmutabilitySettings! (type)
        if (ec.Includes("immutabilitySettings",false))
        {
            if(this.ImmutabilitySettings == null) {

                this.ImmutabilitySettings = new RcsImmutabilitySettings();
                this.ImmutabilitySettings.ApplyExploratoryFieldSpec(ec.NewChild("immutabilitySettings"));

            } else {

                this.ImmutabilitySettings.ApplyExploratoryFieldSpec(ec.NewChild("immutabilitySettings"));

            }
        }
        else if (this.ImmutabilitySettings != null && ec.Excludes("immutabilitySettings",false))
        {
            this.ImmutabilitySettings = null;
        }
    }


    #endregion

    } // class RcsAzureTargetTemplate
    
    #endregion

    public static class ListRcsAzureTargetTemplateExtensions
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
            this List<RcsAzureTargetTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcsAzureTargetTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcsAzureTargetTemplate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcsAzureTargetTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcsAzureTargetTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types