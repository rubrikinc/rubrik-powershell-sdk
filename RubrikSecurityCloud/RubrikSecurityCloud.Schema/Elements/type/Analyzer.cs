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
        if ( AnalyzerRiskInstance != null ) {
            this.AnalyzerRiskInstance = AnalyzerRiskInstance;
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
        //      C# -> AnalyzerTypeEnum? AnalyzerType
        // GraphQL -> analyzerType: AnalyzerTypeEnum! (enum)
        if (this.AnalyzerType != null) {
            s += ind + "analyzerType\n" ;
        }
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk != null) {
            s += ind + "risk\n" ;
        }
        //      C# -> List<System.String>? Dictionary
        // GraphQL -> dictionary: [String!]! (scalar)
        if (this.Dictionary != null) {
            s += ind + "dictionary\n" ;
        }
        //      C# -> System.String? DictionaryCsv
        // GraphQL -> dictionaryCsv: String! (scalar)
        if (this.DictionaryCsv != null) {
            s += ind + "dictionaryCsv\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? Regex
        // GraphQL -> regex: String! (scalar)
        if (this.Regex != null) {
            s += ind + "regex\n" ;
        }
        //      C# -> AnalyzerRiskInstance? AnalyzerRiskInstance
        // GraphQL -> analyzerRiskInstance: AnalyzerRiskInstance (type)
        if (this.AnalyzerRiskInstance != null) {
            var fspec = this.AnalyzerRiskInstance.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzerRiskInstance {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AnalyzerTypeEnum? AnalyzerType
        // GraphQL -> analyzerType: AnalyzerTypeEnum! (enum)
        if (this.AnalyzerType == null && Exploration.Includes(parent + ".analyzerType", true))
        {
            this.AnalyzerType = new AnalyzerTypeEnum();
        }
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk == null && Exploration.Includes(parent + ".risk", true))
        {
            this.Risk = new RiskLevelType();
        }
        //      C# -> List<System.String>? Dictionary
        // GraphQL -> dictionary: [String!]! (scalar)
        if (this.Dictionary == null && Exploration.Includes(parent + ".dictionary", true))
        {
            this.Dictionary = new List<System.String>();
        }
        //      C# -> System.String? DictionaryCsv
        // GraphQL -> dictionaryCsv: String! (scalar)
        if (this.DictionaryCsv == null && Exploration.Includes(parent + ".dictionaryCsv", true))
        {
            this.DictionaryCsv = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? Regex
        // GraphQL -> regex: String! (scalar)
        if (this.Regex == null && Exploration.Includes(parent + ".regex", true))
        {
            this.Regex = "FETCH";
        }
        //      C# -> AnalyzerRiskInstance? AnalyzerRiskInstance
        // GraphQL -> analyzerRiskInstance: AnalyzerRiskInstance (type)
        if (this.AnalyzerRiskInstance == null && Exploration.Includes(parent + ".analyzerRiskInstance"))
        {
            this.AnalyzerRiskInstance = new AnalyzerRiskInstance();
            this.AnalyzerRiskInstance.ApplyExploratoryFieldSpec(parent + ".analyzerRiskInstance");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Analyzer> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Analyzer());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types