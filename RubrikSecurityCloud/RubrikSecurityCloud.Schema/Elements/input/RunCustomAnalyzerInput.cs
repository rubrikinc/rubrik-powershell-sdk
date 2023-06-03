// RunCustomAnalyzerInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region RunCustomAnalyzerInput

    public class RunCustomAnalyzerInput: IInput
    {
        #region members

        //      C# -> System.String? DictionaryCsv
        // GraphQL -> dictionaryCsv: String (scalar)
        [JsonProperty("dictionaryCsv")]
        public System.String? DictionaryCsv { get; set; }

        //      C# -> System.String? Regex
        // GraphQL -> regex: String (scalar)
        [JsonProperty("regex")]
        public System.String? Regex { get; set; }

        //      C# -> System.String? Content
        // GraphQL -> content: String (scalar)
        [JsonProperty("content")]
        public System.String? Content { get; set; }


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

    } // class RunCustomAnalyzerInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types