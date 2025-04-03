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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        if (this.MatchAllValues != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchAllValues\n" ;
            } else {
                s += ind + "matchAllValues\n" ;
            }
        }
        //      C# -> System.String? TagKey
        // GraphQL -> tagKey: String! (scalar)
        if (this.TagKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tagKey\n" ;
            } else {
                s += ind + "tagKey\n" ;
            }
        }
        //      C# -> System.String? TagValue
        // GraphQL -> tagValue: String! (scalar)
        if (this.TagValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tagValue\n" ;
            } else {
                s += ind + "tagValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        if (ec.Includes("matchAllValues",true))
        {
            if(this.MatchAllValues == null) {

                this.MatchAllValues = true;

            } else {


            }
        }
        else if (this.MatchAllValues != null && ec.Excludes("matchAllValues",true))
        {
            this.MatchAllValues = null;
        }
        //      C# -> System.String? TagKey
        // GraphQL -> tagKey: String! (scalar)
        if (ec.Includes("tagKey",true))
        {
            if(this.TagKey == null) {

                this.TagKey = "FETCH";

            } else {


            }
        }
        else if (this.TagKey != null && ec.Excludes("tagKey",true))
        {
            this.TagKey = null;
        }
        //      C# -> System.String? TagValue
        // GraphQL -> tagValue: String! (scalar)
        if (ec.Includes("tagValue",true))
        {
            if(this.TagValue == null) {

                this.TagValue = "FETCH";

            } else {


            }
        }
        else if (this.TagValue != null && ec.Excludes("tagValue",true))
        {
            this.TagValue = null;
        }
    }


    #endregion

    } // class TagRuleTag
    
    #endregion

    public static class ListTagRuleTagExtensions
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
            this List<TagRuleTag> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TagRuleTag> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TagRuleTag> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TagRuleTag());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TagRuleTag> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types