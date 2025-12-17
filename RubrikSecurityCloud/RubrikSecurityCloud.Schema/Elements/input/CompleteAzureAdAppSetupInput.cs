// CompleteAzureAdAppSetupInput.cs
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
    #region CompleteAzureAdAppSetupInput

    public class CompleteAzureAdAppSetupInput: IInput
    {
        #region members

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.String? StateToken
        // GraphQL -> stateToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("stateToken")]
        public System.String? StateToken { get; set; }

        //      C# -> KmsSpecInput? KmsSpec
        // GraphQL -> kmsSpec: KmsSpecInput (input)
        [JsonProperty("kmsSpec")]
        public KmsSpecInput? KmsSpec { get; set; }

        //      C# -> UemKmsSpecInput? UemKmsSpec
        // GraphQL -> uemKmsSpec: UemKmsSpecInput (input)
        [JsonProperty("uemKmsSpec")]
        public UemKmsSpecInput? UemKmsSpec { get; set; }


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

    } // class CompleteAzureAdAppSetupInput
    #endregion

} // namespace RubrikSecurityCloud.Types