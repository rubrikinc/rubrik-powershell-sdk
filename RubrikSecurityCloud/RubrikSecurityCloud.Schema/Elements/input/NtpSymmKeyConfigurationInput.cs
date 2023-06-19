// NtpSymmKeyConfigurationInput.cs
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
    #region NtpSymmKeyConfigurationInput

    public class NtpSymmKeyConfigurationInput: IInput
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.Int32? KeyId
        // GraphQL -> keyId: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("keyId")]
        public System.Int32? KeyId { get; set; }

        //      C# -> System.String? KeyType
        // GraphQL -> keyType: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("keyType")]
        public System.String? KeyType { get; set; }


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

    } // class NtpSymmKeyConfigurationInput
    #endregion

} // namespace RubrikSecurityCloud.Types