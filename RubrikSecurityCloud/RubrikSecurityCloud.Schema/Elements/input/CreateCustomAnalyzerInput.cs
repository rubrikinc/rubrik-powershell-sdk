// CreateCustomAnalyzerInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:23.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region CreateCustomAnalyzerInput

    public class CreateCustomAnalyzerInput
    {
        #region members
        //      C# -> AnalyzerTypeEnum? AnalyzerType
        // GraphQL -> analyzerType: AnalyzerTypeEnum (enum)
        [JsonProperty("analyzerType")]
        public AnalyzerTypeEnum? AnalyzerType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? DictionaryCsv
        // GraphQL -> dictionaryCsv: String (scalar)
        [JsonProperty("dictionaryCsv")]
        public System.String? DictionaryCsv { get; set; }

        //      C# -> List<System.String>? Dictionary
        // GraphQL -> dictionary: [String!] (scalar)
        [JsonProperty("dictionary")]
        public List<System.String>? Dictionary { get; set; }

        //      C# -> System.String? Regex
        // GraphQL -> regex: String (scalar)
        [JsonProperty("regex")]
        public System.String? Regex { get; set; }

        //      C# -> AnalyzerRiskInstanceInput? AnalyzerRiskInstance
        // GraphQL -> analyzerRiskInstance: AnalyzerRiskInstanceInput (input)
        [JsonProperty("analyzerRiskInstance")]
        public AnalyzerRiskInstanceInput? AnalyzerRiskInstance { get; set; }

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

    } // class CreateCustomAnalyzerInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types