// TagRuleTag.cs
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
    #region TagRuleTag
    public class TagRuleTag: BaseType
    {
        #region members

        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        [JsonProperty("matchAllValues")]
        public System.Boolean? MatchAllValues { get; set; }

        //      C# -> System.String? TagKey
        // GraphQL -> tagKey: String! (scalar)
        [JsonProperty("tagKey")]
        public System.String? TagKey { get; set; }

        //      C# -> System.String? TagValue
        // GraphQL -> tagValue: String! (scalar)
        [JsonProperty("tagValue")]
        public System.String? TagValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TagRuleTag";
    }

    public TagRuleTag Set(
        System.Boolean? MatchAllValues = null,
        System.String? TagKey = null,
        System.String? TagValue = null
    ) 
    {
        if ( MatchAllValues != null ) {
            this.MatchAllValues = MatchAllValues;
        }
        if ( TagKey != null ) {
            this.TagKey = TagKey;
        }
        if ( TagValue != null ) {
            this.TagValue = TagValue;
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
        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        if (this.MatchAllValues != null) {
            s += ind + "matchAllValues\n" ;
        }
        //      C# -> System.String? TagKey
        // GraphQL -> tagKey: String! (scalar)
        if (this.TagKey != null) {
            s += ind + "tagKey\n" ;
        }
        //      C# -> System.String? TagValue
        // GraphQL -> tagValue: String! (scalar)
        if (this.TagValue != null) {
            s += ind + "tagValue\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        if (this.MatchAllValues == null && ec.Includes("matchAllValues",true))
        {
            this.MatchAllValues = true;
        }
        //      C# -> System.String? TagKey
        // GraphQL -> tagKey: String! (scalar)
        if (this.TagKey == null && ec.Includes("tagKey",true))
        {
            this.TagKey = "FETCH";
        }
        //      C# -> System.String? TagValue
        // GraphQL -> tagValue: String! (scalar)
        if (this.TagValue == null && ec.Includes("tagValue",true))
        {
            this.TagValue = "FETCH";
        }
    }


    #endregion

    } // class TagRuleTag
    
    #endregion

    public static class ListTagRuleTagExtensions
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
            this List<TagRuleTag> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TagRuleTag> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TagRuleTag());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TagRuleTag> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types