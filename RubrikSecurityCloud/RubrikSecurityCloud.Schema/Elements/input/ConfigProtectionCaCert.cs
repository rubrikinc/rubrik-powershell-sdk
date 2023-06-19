// ConfigProtectionCaCert.cs
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
    #region ConfigProtectionCaCert

    public class ConfigProtectionCaCert: IInput
    {
        #region members

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Certificate
        // GraphQL -> certificate: String (scalar)
        [JsonProperty("certificate")]
        public System.String? Certificate { get; set; }

        //      C# -> CaCertProviderType? CaProvider
        // GraphQL -> caProvider: CaCertProviderType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("caProvider")]
        public CaCertProviderType? CaProvider { get; set; }


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

    } // class ConfigProtectionCaCert
    #endregion

} // namespace RubrikSecurityCloud.Types