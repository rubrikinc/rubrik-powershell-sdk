// Analyzer.cs
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
    #region Analyzer
    public class Analyzer: BaseType
    {
        #region members

        //      C# -> AnalyzerTypeEnum? AnalyzerType
        // GraphQL -> analyzerType: AnalyzerTypeEnum! (enum)
        [JsonProperty("analyzerType")]
        public AnalyzerTypeEnum? AnalyzerType { get; set; }

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        //      C# -> List<AnalyzerRuleType>? RuleTypes
        // GraphQL -> ruleTypes: [AnalyzerRuleType!]! (enum)
        [JsonProperty("ruleTypes")]
        public List<AnalyzerRuleType>? RuleTypes { get; set; }

        //      C# -> List<System.String>? Dictionary
        // GraphQL -> dictionary: [String!]! (scalar)
        [JsonProperty("dictionary")]
        public List<System.String>? Dictionary { get; set; }

        //      C# -> System.String? DictionaryCsv
        // GraphQL -> dictionaryCsv: String! (scalar)
        [JsonProperty("dictionaryCsv")]
        public System.String? DictionaryCsv { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? KeyRegex
        // GraphQL -> keyRegex: String! (scalar)
        [JsonProperty("keyRegex")]
        public System.String? KeyRegex { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Regex
        // GraphQL -> regex: String! (scalar)
        [JsonProperty("regex")]
        public System.String? Regex { get; set; }

        //      C# -> List<System.String>? StructuredDictionary
        // GraphQL -> structuredDictionary: [String!]! (scalar)
        [JsonProperty("structuredDictionary")]
        public List<System.String>? StructuredDictionary { get; set; }

        //      C# -> System.String? StructuredDictionaryCsv
        // GraphQL -> structuredDictionaryCsv: String! (scalar)
        [JsonProperty("structuredDictionaryCsv")]
        public System.String? StructuredDictionaryCsv { get; set; }

        //      C# -> List<System.String>? StructuredKeyDictionary
        // GraphQL -> structuredKeyDictionary: [String!]! (scalar)
        [JsonProperty("structuredKeyDictionary")]
        public List<System.String>? StructuredKeyDictionary { get; set; }

        //      C# -> System.String? StructuredKeyDictionaryCsv
        // GraphQL -> structuredKeyDictionaryCsv: String! (scalar)
        [JsonProperty("structuredKeyDictionaryCsv")]
        public System.String? StructuredKeyDictionaryCsv { get; set; }

        //      C# -> System.String? StructuredValueRegex
        // GraphQL -> structuredValueRegex: String! (scalar)
        [JsonProperty("structuredValueRegex")]
        public System.String? StructuredValueRegex { get; set; }

        //      C# -> System.Int32? TagId
        // GraphQL -> tagId: Int! (scalar)
        [JsonProperty("tagId")]
        public System.Int32? TagId { get; set; }

        //      C# -> AnalyzerRiskInstance? AnalyzerRiskInstance
        // GraphQL -> analyzerRiskInstance: AnalyzerRiskInstance (type)
        [JsonProperty("analyzerRiskInstance")]
        public AnalyzerRiskInstance? AnalyzerRiskInstance { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Analyzer";
    }

    public Analyzer Set(
        AnalyzerTypeEnum? AnalyzerType = null,
        RiskLevelType? Risk = null,
        List<AnalyzerRuleType>? RuleTypes = null,
        List<System.String>? Dictionary = null,
        System.String? DictionaryCsv = null,
        System.String? Id = null,
        System.String? KeyRegex = null,
        System.String? Name = null,
        System.String? Regex = null,
        List<System.String>? StructuredDictionary = null,
        System.String? StructuredDictionaryCsv = null,
        List<System.String>? StructuredKeyDictionary = null,
        System.String? StructuredKeyDictionaryCsv = null,
        System.String? StructuredValueRegex = null,
        System.Int32? TagId = null,
        AnalyzerRiskInstance? AnalyzerRiskInstance = null
    ) 
    {
        if ( AnalyzerType != null ) {
            this.AnalyzerType = AnalyzerType;
        }
        if ( Risk != null ) {
            this.Risk = Risk;
        }
        if ( RuleTypes != null ) {
            this.RuleTypes = RuleTypes;
        }
        if ( Dictionary != null ) {
            this.Dictionary = Dictionary;
        }
        if ( DictionaryCsv != null ) {
            this.DictionaryCsv = DictionaryCsv;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( KeyRegex != null ) {
            this.KeyRegex = KeyRegex;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Regex != null ) {
            this.Regex = Regex;
        }
        if ( StructuredDictionary != null ) {
            this.StructuredDictionary = StructuredDictionary;
        }
        if ( StructuredDictionaryCsv != null ) {
            this.StructuredDictionaryCsv = StructuredDictionaryCsv;
        }
        if ( StructuredKeyDictionary != null ) {
            this.StructuredKeyDictionary = StructuredKeyDictionary;
        }
        if ( StructuredKeyDictionaryCsv != null ) {
            this.StructuredKeyDictionaryCsv = StructuredKeyDictionaryCsv;
        }
        if ( StructuredValueRegex != null ) {
            this.StructuredValueRegex = StructuredValueRegex;
        }
        if ( TagId != null ) {
            this.TagId = TagId;
        }
        if ( AnalyzerRiskInstance != null ) {
            this.AnalyzerRiskInstance = AnalyzerRiskInstance;
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
        //      C# -> AnalyzerTypeEnum? AnalyzerType
        // GraphQL -> analyzerType: AnalyzerTypeEnum! (enum)
        if (this.AnalyzerType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analyzerType\n" ;
            } else {
                s += ind + "analyzerType\n" ;
            }
        }
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "risk\n" ;
            } else {
                s += ind + "risk\n" ;
            }
        }
        //      C# -> List<AnalyzerRuleType>? RuleTypes
        // GraphQL -> ruleTypes: [AnalyzerRuleType!]! (enum)
        if (this.RuleTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ruleTypes\n" ;
            } else {
                s += ind + "ruleTypes\n" ;
            }
        }
        //      C# -> List<System.String>? Dictionary
        // GraphQL -> dictionary: [String!]! (scalar)
        if (this.Dictionary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dictionary\n" ;
            } else {
                s += ind + "dictionary\n" ;
            }
        }
        //      C# -> System.String? DictionaryCsv
        // GraphQL -> dictionaryCsv: String! (scalar)
        if (this.DictionaryCsv != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dictionaryCsv\n" ;
            } else {
                s += ind + "dictionaryCsv\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? KeyRegex
        // GraphQL -> keyRegex: String! (scalar)
        if (this.KeyRegex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyRegex\n" ;
            } else {
                s += ind + "keyRegex\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? Regex
        // GraphQL -> regex: String! (scalar)
        if (this.Regex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "regex\n" ;
            } else {
                s += ind + "regex\n" ;
            }
        }
        //      C# -> List<System.String>? StructuredDictionary
        // GraphQL -> structuredDictionary: [String!]! (scalar)
        if (this.StructuredDictionary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "structuredDictionary\n" ;
            } else {
                s += ind + "structuredDictionary\n" ;
            }
        }
        //      C# -> System.String? StructuredDictionaryCsv
        // GraphQL -> structuredDictionaryCsv: String! (scalar)
        if (this.StructuredDictionaryCsv != null) {
            if (conf.Flat) {
                s += conf.Prefix + "structuredDictionaryCsv\n" ;
            } else {
                s += ind + "structuredDictionaryCsv\n" ;
            }
        }
        //      C# -> List<System.String>? StructuredKeyDictionary
        // GraphQL -> structuredKeyDictionary: [String!]! (scalar)
        if (this.StructuredKeyDictionary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "structuredKeyDictionary\n" ;
            } else {
                s += ind + "structuredKeyDictionary\n" ;
            }
        }
        //      C# -> System.String? StructuredKeyDictionaryCsv
        // GraphQL -> structuredKeyDictionaryCsv: String! (scalar)
        if (this.StructuredKeyDictionaryCsv != null) {
            if (conf.Flat) {
                s += conf.Prefix + "structuredKeyDictionaryCsv\n" ;
            } else {
                s += ind + "structuredKeyDictionaryCsv\n" ;
            }
        }
        //      C# -> System.String? StructuredValueRegex
        // GraphQL -> structuredValueRegex: String! (scalar)
        if (this.StructuredValueRegex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "structuredValueRegex\n" ;
            } else {
                s += ind + "structuredValueRegex\n" ;
            }
        }
        //      C# -> System.Int32? TagId
        // GraphQL -> tagId: Int! (scalar)
        if (this.TagId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tagId\n" ;
            } else {
                s += ind + "tagId\n" ;
            }
        }
        //      C# -> AnalyzerRiskInstance? AnalyzerRiskInstance
        // GraphQL -> analyzerRiskInstance: AnalyzerRiskInstance (type)
        if (this.AnalyzerRiskInstance != null) {
            var fspec = this.AnalyzerRiskInstance.AsFieldSpec(conf.Child("analyzerRiskInstance"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerRiskInstance" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AnalyzerTypeEnum? AnalyzerType
        // GraphQL -> analyzerType: AnalyzerTypeEnum! (enum)
        if (ec.Includes("analyzerType",true))
        {
            if(this.AnalyzerType == null) {

                this.AnalyzerType = new AnalyzerTypeEnum();

            } else {


            }
        }
        else if (this.AnalyzerType != null && ec.Excludes("analyzerType",true))
        {
            this.AnalyzerType = null;
        }
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (ec.Includes("risk",true))
        {
            if(this.Risk == null) {

                this.Risk = new RiskLevelType();

            } else {


            }
        }
        else if (this.Risk != null && ec.Excludes("risk",true))
        {
            this.Risk = null;
        }
        //      C# -> List<AnalyzerRuleType>? RuleTypes
        // GraphQL -> ruleTypes: [AnalyzerRuleType!]! (enum)
        if (ec.Includes("ruleTypes",true))
        {
            if(this.RuleTypes == null) {

                this.RuleTypes = new List<AnalyzerRuleType>();

            } else {


            }
        }
        else if (this.RuleTypes != null && ec.Excludes("ruleTypes",true))
        {
            this.RuleTypes = null;
        }
        //      C# -> List<System.String>? Dictionary
        // GraphQL -> dictionary: [String!]! (scalar)
        if (ec.Includes("dictionary",true))
        {
            if(this.Dictionary == null) {

                this.Dictionary = new List<System.String>();

            } else {


            }
        }
        else if (this.Dictionary != null && ec.Excludes("dictionary",true))
        {
            this.Dictionary = null;
        }
        //      C# -> System.String? DictionaryCsv
        // GraphQL -> dictionaryCsv: String! (scalar)
        if (ec.Includes("dictionaryCsv",true))
        {
            if(this.DictionaryCsv == null) {

                this.DictionaryCsv = "FETCH";

            } else {


            }
        }
        else if (this.DictionaryCsv != null && ec.Excludes("dictionaryCsv",true))
        {
            this.DictionaryCsv = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? KeyRegex
        // GraphQL -> keyRegex: String! (scalar)
        if (ec.Includes("keyRegex",true))
        {
            if(this.KeyRegex == null) {

                this.KeyRegex = "FETCH";

            } else {


            }
        }
        else if (this.KeyRegex != null && ec.Excludes("keyRegex",true))
        {
            this.KeyRegex = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? Regex
        // GraphQL -> regex: String! (scalar)
        if (ec.Includes("regex",true))
        {
            if(this.Regex == null) {

                this.Regex = "FETCH";

            } else {


            }
        }
        else if (this.Regex != null && ec.Excludes("regex",true))
        {
            this.Regex = null;
        }
        //      C# -> List<System.String>? StructuredDictionary
        // GraphQL -> structuredDictionary: [String!]! (scalar)
        if (ec.Includes("structuredDictionary",true))
        {
            if(this.StructuredDictionary == null) {

                this.StructuredDictionary = new List<System.String>();

            } else {


            }
        }
        else if (this.StructuredDictionary != null && ec.Excludes("structuredDictionary",true))
        {
            this.StructuredDictionary = null;
        }
        //      C# -> System.String? StructuredDictionaryCsv
        // GraphQL -> structuredDictionaryCsv: String! (scalar)
        if (ec.Includes("structuredDictionaryCsv",true))
        {
            if(this.StructuredDictionaryCsv == null) {

                this.StructuredDictionaryCsv = "FETCH";

            } else {


            }
        }
        else if (this.StructuredDictionaryCsv != null && ec.Excludes("structuredDictionaryCsv",true))
        {
            this.StructuredDictionaryCsv = null;
        }
        //      C# -> List<System.String>? StructuredKeyDictionary
        // GraphQL -> structuredKeyDictionary: [String!]! (scalar)
        if (ec.Includes("structuredKeyDictionary",true))
        {
            if(this.StructuredKeyDictionary == null) {

                this.StructuredKeyDictionary = new List<System.String>();

            } else {


            }
        }
        else if (this.StructuredKeyDictionary != null && ec.Excludes("structuredKeyDictionary",true))
        {
            this.StructuredKeyDictionary = null;
        }
        //      C# -> System.String? StructuredKeyDictionaryCsv
        // GraphQL -> structuredKeyDictionaryCsv: String! (scalar)
        if (ec.Includes("structuredKeyDictionaryCsv",true))
        {
            if(this.StructuredKeyDictionaryCsv == null) {

                this.StructuredKeyDictionaryCsv = "FETCH";

            } else {


            }
        }
        else if (this.StructuredKeyDictionaryCsv != null && ec.Excludes("structuredKeyDictionaryCsv",true))
        {
            this.StructuredKeyDictionaryCsv = null;
        }
        //      C# -> System.String? StructuredValueRegex
        // GraphQL -> structuredValueRegex: String! (scalar)
        if (ec.Includes("structuredValueRegex",true))
        {
            if(this.StructuredValueRegex == null) {

                this.StructuredValueRegex = "FETCH";

            } else {


            }
        }
        else if (this.StructuredValueRegex != null && ec.Excludes("structuredValueRegex",true))
        {
            this.StructuredValueRegex = null;
        }
        //      C# -> System.Int32? TagId
        // GraphQL -> tagId: Int! (scalar)
        if (ec.Includes("tagId",true))
        {
            if(this.TagId == null) {

                this.TagId = Int32.MinValue;

            } else {


            }
        }
        else if (this.TagId != null && ec.Excludes("tagId",true))
        {
            this.TagId = null;
        }
        //      C# -> AnalyzerRiskInstance? AnalyzerRiskInstance
        // GraphQL -> analyzerRiskInstance: AnalyzerRiskInstance (type)
        if (ec.Includes("analyzerRiskInstance",false))
        {
            if(this.AnalyzerRiskInstance == null) {

                this.AnalyzerRiskInstance = new AnalyzerRiskInstance();
                this.AnalyzerRiskInstance.ApplyExploratoryFieldSpec(ec.NewChild("analyzerRiskInstance"));

            } else {

                this.AnalyzerRiskInstance.ApplyExploratoryFieldSpec(ec.NewChild("analyzerRiskInstance"));

            }
        }
        else if (this.AnalyzerRiskInstance != null && ec.Excludes("analyzerRiskInstance",false))
        {
            this.AnalyzerRiskInstance = null;
        }
    }


    #endregion

    } // class Analyzer
    
    #endregion

    public static class ListAnalyzerExtensions
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
            this List<Analyzer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Analyzer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Analyzer> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Analyzer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Analyzer> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types