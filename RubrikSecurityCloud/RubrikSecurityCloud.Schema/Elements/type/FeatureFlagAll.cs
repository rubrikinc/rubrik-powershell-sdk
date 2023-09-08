// FeatureFlagAll.cs
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
    #region FeatureFlagAll
    public class FeatureFlagAll: BaseType
    {
        #region members

        //      C# -> List<FeatureFlag>? Flags
        // GraphQL -> flags: [FeatureFlag!]! (type)
        [JsonProperty("flags")]
        public List<FeatureFlag>? Flags { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FeatureFlagAll";
    }

    public FeatureFlagAll Set(
        List<FeatureFlag>? Flags = null
    ) 
    {
        if ( Flags != null ) {
            this.Flags = Flags;
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
        //      C# -> List<FeatureFlag>? Flags
        // GraphQL -> flags: [FeatureFlag!]! (type)
        if (this.Flags != null) {
            var fspec = this.Flags.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "flags {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<FeatureFlag>? Flags
        // GraphQL -> flags: [FeatureFlag!]! (type)
        if (this.Flags == null && ec.Includes("flags",false))
        {
            this.Flags = new List<FeatureFlag>();
            this.Flags.ApplyExploratoryFieldSpec(ec.NewChild("flags"));
        }
    }


    #endregion

    } // class FeatureFlagAll
    
    #endregion

    public static class ListFeatureFlagAllExtensions
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
            this List<FeatureFlagAll> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FeatureFlagAll> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FeatureFlagAll());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<FeatureFlagAll> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types