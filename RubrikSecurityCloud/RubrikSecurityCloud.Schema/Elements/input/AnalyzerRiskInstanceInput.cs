// AnalyzerRiskInstanceInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AnalyzerRiskInstanceInput

    public class AnalyzerRiskInstanceInput: IInput
    {
        #region members

        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String (scalar)
        [JsonProperty("analyzerId")]
        public System.String? AnalyzerId { get; set; }

        //      C# -> System.Int32? RiskVersion
        // GraphQL -> riskVersion: Int (scalar)
        [JsonProperty("riskVersion")]
        public System.Int32? RiskVersion { get; set; }

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }


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

    } // class AnalyzerRiskInstanceInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types