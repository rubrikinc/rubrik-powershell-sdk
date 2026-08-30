// DataMaskingConfigInput.cs
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
    #region DataMaskingConfigInput

    public class DataMaskingConfigInput: IInput
    {
        #region members

        //      C# -> List<ClassificationDataTypeIdToMaskingTechnique>? DataTypeMappings
        // GraphQL -> dataTypeMappings: [ClassificationDataTypeIdToMaskingTechnique!] (input)
        [JsonProperty("dataTypeMappings")]
        public List<ClassificationDataTypeIdToMaskingTechnique>? DataTypeMappings { get; set; }

        //      C# -> List<MaskingExclusionInput>? Exclusions
        // GraphQL -> exclusions: [MaskingExclusionInput!] (input)
        [JsonProperty("exclusions")]
        public List<MaskingExclusionInput>? Exclusions { get; set; }

        //      C# -> List<MaskingOverrideInput>? Overrides
        // GraphQL -> overrides: [MaskingOverrideInput!] (input)
        [JsonProperty("overrides")]
        public List<MaskingOverrideInput>? Overrides { get; set; }


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

    } // class DataMaskingConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types