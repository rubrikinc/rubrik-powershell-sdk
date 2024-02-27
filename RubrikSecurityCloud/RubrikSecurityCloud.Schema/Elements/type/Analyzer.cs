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

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Regex
        // GraphQL -> regex: String! (scalar)
        [JsonProperty("regex")]
        public System.String? Regex { get; set; }

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
        List<System.String>? Dictionary = null,
        System.String? DictionaryCsv = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? Regex = null,
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
        if ( Dictionary != null ) {
            this.Dictionary = Dictionary;
        }
        if ( DictionaryCsv != null ) {
            this.DictionaryCsv = DictionaryCsv;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Regex != null ) {
            this.Regex = Regex;
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
                    s += ind + "analyzerRiskInstance {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
            this List<Analyzer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<Analyzer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Analyzer> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Analyzer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Analyzer> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types