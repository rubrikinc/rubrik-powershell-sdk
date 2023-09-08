// AttributedFeatureFlag.cs
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
    #region AttributedFeatureFlag
    public class AttributedFeatureFlag: BaseType
    {
        #region members

        //      C# -> AttributedFeatureFlagName? Name
        // GraphQL -> name: AttributedFeatureFlagName! (enum)
        [JsonProperty("name")]
        public AttributedFeatureFlagName? Name { get; set; }

        //      C# -> System.String? Variant
        // GraphQL -> variant: String! (scalar)
        [JsonProperty("variant")]
        public System.String? Variant { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AttributedFeatureFlag";
    }

    public AttributedFeatureFlag Set(
        AttributedFeatureFlagName? Name = null,
        System.String? Variant = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Variant != null ) {
            this.Variant = Variant;
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
        //      C# -> AttributedFeatureFlagName? Name
        // GraphQL -> name: AttributedFeatureFlagName! (enum)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? Variant
        // GraphQL -> variant: String! (scalar)
        if (this.Variant != null) {
            s += ind + "variant\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AttributedFeatureFlagName? Name
        // GraphQL -> name: AttributedFeatureFlagName! (enum)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = new AttributedFeatureFlagName();
        }
        //      C# -> System.String? Variant
        // GraphQL -> variant: String! (scalar)
        if (this.Variant == null && ec.Includes("variant",true))
        {
            this.Variant = "FETCH";
        }
    }


    #endregion

    } // class AttributedFeatureFlag
    
    #endregion

    public static class ListAttributedFeatureFlagExtensions
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
            this List<AttributedFeatureFlag> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AttributedFeatureFlag> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AttributedFeatureFlag());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AttributedFeatureFlag> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types