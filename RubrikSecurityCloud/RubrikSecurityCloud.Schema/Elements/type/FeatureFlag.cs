// FeatureFlag.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region FeatureFlag
    public class FeatureFlag: BaseType
    {
        #region members

        //      C# -> FeatureFlagName? Name
        // GraphQL -> name: FeatureFlagName! (enum)
        [JsonProperty("name")]
        public FeatureFlagName? Name { get; set; }

        //      C# -> System.String? Variant
        // GraphQL -> variant: String (scalar)
        [JsonProperty("variant")]
        public System.String? Variant { get; set; }


        #endregion

    #region methods

    public FeatureFlag Set(
        FeatureFlagName? Name = null,
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
        //      C# -> FeatureFlagName? Name
        // GraphQL -> name: FeatureFlagName! (enum)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? Variant
        // GraphQL -> variant: String (scalar)
        if (this.Variant != null) {
            s += ind + "variant\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FeatureFlagName? Name
        // GraphQL -> name: FeatureFlagName! (enum)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new FeatureFlagName();
        }
        //      C# -> System.String? Variant
        // GraphQL -> variant: String (scalar)
        if (this.Variant == null && Exploration.Includes(parent + ".variant", true))
        {
            this.Variant = "FETCH";
        }
    }


    #endregion

    } // class FeatureFlag
    
    #endregion

    public static class ListFeatureFlagExtensions
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
            this List<FeatureFlag> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FeatureFlag> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FeatureFlag());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types