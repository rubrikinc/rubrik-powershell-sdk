// PasswordComplexityPolicyTemplateInput.cs
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
    #region PasswordComplexityPolicyTemplateInput

    public class PasswordComplexityPolicyTemplateInput: IInput
    {
        #region members

        //      C# -> System.Int32? MinValue
        // GraphQL -> minValue: Int (scalar)
        [JsonProperty("minValue")]
        public System.Int32? MinValue { get; set; }

        //      C# -> System.Int32? MaxValue
        // GraphQL -> maxValue: Int (scalar)
        [JsonProperty("maxValue")]
        public System.Int32? MaxValue { get; set; }

        //      C# -> System.Int32? DefaultValue
        // GraphQL -> defaultValue: Int (scalar)
        [JsonProperty("defaultValue")]
        public System.Int32? DefaultValue { get; set; }

        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }


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

    } // class PasswordComplexityPolicyTemplateInput
    #endregion

} // namespace RubrikSecurityCloud.Types