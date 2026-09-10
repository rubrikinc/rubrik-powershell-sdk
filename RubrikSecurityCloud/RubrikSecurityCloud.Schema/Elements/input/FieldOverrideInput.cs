// FieldOverrideInput.cs
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
    #region FieldOverrideInput

    public class FieldOverrideInput: IInput
    {
        #region members

        //      C# -> System.String? FieldName
        // GraphQL -> fieldName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("fieldName")]
        public System.String? FieldName { get; set; }

        //      C# -> MaskingTechnique? MaskingTechnique
        // GraphQL -> maskingTechnique: MaskingTechnique! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("maskingTechnique")]
        public MaskingTechnique? MaskingTechnique { get; set; }

        //      C# -> System.Boolean? IsInclusion
        // GraphQL -> isInclusion: Boolean (scalar)
        [JsonProperty("isInclusion")]
        public System.Boolean? IsInclusion { get; set; }

        //      C# -> System.Int32? ClassificationDataTypeTagId
        // GraphQL -> classificationDataTypeTagId: Int (scalar)
        [JsonProperty("classificationDataTypeTagId")]
        public System.Int32? ClassificationDataTypeTagId { get; set; }


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

    } // class FieldOverrideInput
    #endregion

} // namespace RubrikSecurityCloud.Types