// AnalyzerGroupInput.cs
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
    #region AnalyzerGroupInput

    public class AnalyzerGroupInput: IInput
    {
        #region members

        //      C# -> AnalyzerGroupTypeEnum? GroupType
        // GraphQL -> groupType: AnalyzerGroupTypeEnum (enum)
        [JsonProperty("groupType")]
        public AnalyzerGroupTypeEnum? GroupType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<CreateCustomAnalyzerInput>? Analyzers
        // GraphQL -> analyzers: [CreateCustomAnalyzerInput!] (input)
        [JsonProperty("analyzers")]
        public List<CreateCustomAnalyzerInput>? Analyzers { get; set; }

        //      C# -> List<System.String>? DocumentTypeIds
        // GraphQL -> documentTypeIds: [String!] (scalar)
        [JsonProperty("documentTypeIds")]
        public List<System.String>? DocumentTypeIds { get; set; }


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

    } // class AnalyzerGroupInput
    #endregion

} // namespace RubrikSecurityCloud.Types