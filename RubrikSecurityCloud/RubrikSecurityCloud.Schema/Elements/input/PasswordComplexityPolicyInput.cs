// PasswordComplexityPolicyInput.cs
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
    #region PasswordComplexityPolicyInput

    public class PasswordComplexityPolicyInput: IInput
    {
        #region members

        //      C# -> PasswordComplexityPolicyTemplateInput? LengthPolicy
        // GraphQL -> lengthPolicy: PasswordComplexityPolicyTemplateInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("lengthPolicy")]
        public PasswordComplexityPolicyTemplateInput? LengthPolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplateInput? LowercasePolicy
        // GraphQL -> lowercasePolicy: PasswordComplexityPolicyTemplateInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("lowercasePolicy")]
        public PasswordComplexityPolicyTemplateInput? LowercasePolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplateInput? UppercasePolicy
        // GraphQL -> uppercasePolicy: PasswordComplexityPolicyTemplateInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("uppercasePolicy")]
        public PasswordComplexityPolicyTemplateInput? UppercasePolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplateInput? SpecialCharsPolicy
        // GraphQL -> specialCharsPolicy: PasswordComplexityPolicyTemplateInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("specialCharsPolicy")]
        public PasswordComplexityPolicyTemplateInput? SpecialCharsPolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplateInput? NumericPolicy
        // GraphQL -> numericPolicy: PasswordComplexityPolicyTemplateInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("numericPolicy")]
        public PasswordComplexityPolicyTemplateInput? NumericPolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplateInput? PasswordReusePolicy
        // GraphQL -> passwordReusePolicy: PasswordComplexityPolicyTemplateInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("passwordReusePolicy")]
        public PasswordComplexityPolicyTemplateInput? PasswordReusePolicy { get; set; }

        //      C# -> PasswordComplexityPolicyTemplateInput? PasswordExpirationPolicy
        // GraphQL -> passwordExpirationPolicy: PasswordComplexityPolicyTemplateInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("passwordExpirationPolicy")]
        public PasswordComplexityPolicyTemplateInput? PasswordExpirationPolicy { get; set; }


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

    } // class PasswordComplexityPolicyInput
    #endregion

} // namespace RubrikSecurityCloud.Types