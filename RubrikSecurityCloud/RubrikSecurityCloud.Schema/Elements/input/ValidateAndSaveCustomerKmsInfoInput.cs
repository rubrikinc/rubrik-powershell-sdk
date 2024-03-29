// ValidateAndSaveCustomerKmsInfoInput.cs
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
    #region ValidateAndSaveCustomerKmsInfoInput

    public class ValidateAndSaveCustomerKmsInfoInput: IInput
    {
        #region members

        //      C# -> KmsSpecInput? KmsSpec
        // GraphQL -> kmsSpec: KmsSpecInput (input)
        [JsonProperty("kmsSpec")]
        public KmsSpecInput? KmsSpec { get; set; }

        //      C# -> System.String? AppSecret
        // GraphQL -> appSecret: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appSecret")]
        public System.String? AppSecret { get; set; }


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

    } // class ValidateAndSaveCustomerKmsInfoInput
    #endregion

} // namespace RubrikSecurityCloud.Types