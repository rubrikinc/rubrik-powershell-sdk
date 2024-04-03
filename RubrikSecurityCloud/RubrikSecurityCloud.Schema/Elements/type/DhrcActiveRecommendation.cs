// DhrcActiveRecommendation.cs
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
    #region DhrcActiveRecommendation
    public class DhrcActiveRecommendation: BaseType
    {
        #region members

        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        [JsonProperty("category")]
        public DhrcCategory? Category { get; set; }

        //      C# -> DhrcRecommendationKey? Key
        // GraphQL -> key: DhrcRecommendationKey! (enum)
        [JsonProperty("key")]
        public DhrcRecommendationKey? Key { get; set; }

        //      C# -> DateTime? CompiledAt
        // GraphQL -> compiledAt: DateTime (scalar)
        [JsonProperty("compiledAt")]
        public DateTime? CompiledAt { get; set; }

        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        [JsonProperty("earliestMetric")]
        public DateTime? EarliestMetric { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        [JsonProperty("weight")]
        public System.Single? Weight { get; set; }

        //      C# -> List<DhrcKeyValue>? TranslationArgs
        // GraphQL -> translationArgs: [DhrcKeyValue!]! (type)
        [JsonProperty("translationArgs")]
        public List<DhrcKeyValue>? TranslationArgs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DhrcActiveRecommendation";
    }

    public DhrcActiveRecommendation Set(
        DhrcCategory? Category = null,
        DhrcRecommendationKey? Key = null,
        DateTime? CompiledAt = null,
        DateTime? EarliestMetric = null,
        System.String? Message = null,
        System.Single? Weight = null,
        List<DhrcKeyValue>? TranslationArgs = null
    ) 
    {
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( CompiledAt != null ) {
            this.CompiledAt = CompiledAt;
        }
        if ( EarliestMetric != null ) {
            this.EarliestMetric = EarliestMetric;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( Weight != null ) {
            this.Weight = Weight;
        }
        if ( TranslationArgs != null ) {
            this.TranslationArgs = TranslationArgs;
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
        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        if (this.Category != null) {
            if (conf.Flat) {
                s += conf.Prefix + "category\n" ;
            } else {
                s += ind + "category\n" ;
            }
        }
        //      C# -> DhrcRecommendationKey? Key
        // GraphQL -> key: DhrcRecommendationKey! (enum)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> DateTime? CompiledAt
        // GraphQL -> compiledAt: DateTime (scalar)
        if (this.CompiledAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "compiledAt\n" ;
            } else {
                s += ind + "compiledAt\n" ;
            }
        }
        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        if (this.EarliestMetric != null) {
            if (conf.Flat) {
                s += conf.Prefix + "earliestMetric\n" ;
            } else {
                s += ind + "earliestMetric\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        if (this.Weight != null) {
            if (conf.Flat) {
                s += conf.Prefix + "weight\n" ;
            } else {
                s += ind + "weight\n" ;
            }
        }
        //      C# -> List<DhrcKeyValue>? TranslationArgs
        // GraphQL -> translationArgs: [DhrcKeyValue!]! (type)
        if (this.TranslationArgs != null) {
            var fspec = this.TranslationArgs.AsFieldSpec(conf.Child("translationArgs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "translationArgs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        if (ec.Includes("category",true))
        {
            if(this.Category == null) {

                this.Category = new DhrcCategory();

            } else {


            }
        }
        else if (this.Category != null && ec.Excludes("category",true))
        {
            this.Category = null;
        }
        //      C# -> DhrcRecommendationKey? Key
        // GraphQL -> key: DhrcRecommendationKey! (enum)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = new DhrcRecommendationKey();

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> DateTime? CompiledAt
        // GraphQL -> compiledAt: DateTime (scalar)
        if (ec.Includes("compiledAt",true))
        {
            if(this.CompiledAt == null) {

                this.CompiledAt = new DateTime();

            } else {


            }
        }
        else if (this.CompiledAt != null && ec.Excludes("compiledAt",true))
        {
            this.CompiledAt = null;
        }
        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        if (ec.Includes("earliestMetric",true))
        {
            if(this.EarliestMetric == null) {

                this.EarliestMetric = new DateTime();

            } else {


            }
        }
        else if (this.EarliestMetric != null && ec.Excludes("earliestMetric",true))
        {
            this.EarliestMetric = null;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        if (ec.Includes("weight",true))
        {
            if(this.Weight == null) {

                this.Weight = new System.Single();

            } else {


            }
        }
        else if (this.Weight != null && ec.Excludes("weight",true))
        {
            this.Weight = null;
        }
        //      C# -> List<DhrcKeyValue>? TranslationArgs
        // GraphQL -> translationArgs: [DhrcKeyValue!]! (type)
        if (ec.Includes("translationArgs",false))
        {
            if(this.TranslationArgs == null) {

                this.TranslationArgs = new List<DhrcKeyValue>();
                this.TranslationArgs.ApplyExploratoryFieldSpec(ec.NewChild("translationArgs"));

            } else {

                this.TranslationArgs.ApplyExploratoryFieldSpec(ec.NewChild("translationArgs"));

            }
        }
        else if (this.TranslationArgs != null && ec.Excludes("translationArgs",false))
        {
            this.TranslationArgs = null;
        }
    }


    #endregion

    } // class DhrcActiveRecommendation
    
    #endregion

    public static class ListDhrcActiveRecommendationExtensions
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
            this List<DhrcActiveRecommendation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DhrcActiveRecommendation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DhrcActiveRecommendation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DhrcActiveRecommendation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DhrcActiveRecommendation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types