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
        RcsRegionEnumType? Region = null,
        TargetType? TargetType = null,
        RcsTierEnumType? Tier = null,
        RcsImmutabilitySettings? ImmutabilitySettings = null
    ) 
    {
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType != null) {
            s += ind + "targetType\n" ;
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (this.Tier != null) {
            s += ind + "tier\n" ;
        }
        //      C# -> RcsImmutabilitySettings? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: RcsImmutabilitySettings! (type)
        if (this.ImmutabilitySettings != null) {
            var fspec = this.ImmutabilitySettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "immutabilitySettings {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new RcsRegionEnumType();
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType == null && Exploration.Includes(parent + ".targetType", true))
        {
            this.TargetType = new TargetType();
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (this.Tier == null && Exploration.Includes(parent + ".tier", true))
        {
            this.Tier = new RcsTierEnumType();
        }
        //      C# -> RcsImmutabilitySettings? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: RcsImmutabilitySettings! (type)
        if (this.ImmutabilitySettings == null && Exploration.Includes(parent + ".immutabilitySettings"))
        {
            this.ImmutabilitySettings = new RcsImmutabilitySettings();
            this.ImmutabilitySettings.ApplyExploratoryFieldSpec(parent + ".immutabilitySettings");
        }
    }


    #endregion

    } // class RcsAzureTargetTemplate
    
    #endregion

    public static class ListRcsAzureTargetTemplateExtensions
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
            this List<RcsAzureTargetTemplate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RcsAzureTargetTemplate> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RcsAzureTargetTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types