// DataTypeDefinition.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region DataTypeDefinition

    public class DataTypeDefinition: IInput
    {
        #region members

        //      C# -> AnalyzerTypeEnum? AnalyzerType
        // GraphQL -> analyzerType: AnalyzerTypeEnum (enum)
        [JsonProperty("analyzerType")]
        public AnalyzerTypeEnum? AnalyzerType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? DictionaryCsv
        // GraphQL -> dictionaryCsv: String (scalar)
        [JsonProperty("dictionaryCsv")]
        public System.String? DictionaryCsv { get; set; }

        //      C# -> System.String? Regex
        // GraphQL -> regex: String (scalar)
        [JsonProperty("regex")]
        public System.String? Regex { get; set; }

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        //      C# -> List<AnalyzerRuleType>? RuleTypes
        // GraphQL -> ruleTypes: [AnalyzerRuleType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("ruleTypes")]
        public List<AnalyzerRuleType>? RuleTypes { get; set; }

        //      C# -> System.String? KeyRegex
        // GraphQL -> keyRegex: String (scalar)
        [JsonProperty("keyRegex")]
        public System.String? KeyRegex { get; set; }

        //      C# -> System.String? StructuredValueRegex
        // GraphQL -> structuredValueRegex: String (scalar)
        [JsonProperty("structuredValueRegex")]
        public System.String? StructuredValueRegex { get; set; }

        //      C# -> System.String? StructuredDictionaryCsv
        // GraphQL -> structuredDictionaryCsv: String (scalar)
        [JsonProperty("structuredDictionaryCsv")]
        public System.String? StructuredDictionaryCsv { get; set; }

        //      C# -> System.String? StructuredKeyDictionaryCsv
        // GraphQL -> structuredKeyDictionaryCsv: String (scalar)
        [JsonProperty("structuredKeyDictionaryCsv")]
        public System.String? StructuredKeyDictionaryCsv { get; set; }

        //      C# -> System.String? ProximityKeywordsRegex
        // GraphQL -> proximityKeywordsRegex: String (scalar)
        [JsonProperty("proximityKeywordsRegex")]
        public System.String? ProximityKeywordsRegex { get; set; }

        //      C# -> System.Int32? ProximityDistance
        // GraphQL -> proximityDistance: Int (scalar)
        [JsonProperty("proximityDistance")]
        public System.Int32? ProximityDistance { get; set; }

        //      C# -> System.String? ExcludeValueRegex
        // GraphQL -> excludeValueRegex: String (scalar)
        [JsonProperty("excludeValueRegex")]
        public System.String? ExcludeValueRegex { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class DataTypeDefinition
    #endregion

} // namespace RubrikSecurityCloud.Types