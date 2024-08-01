// SetCorsSettingInput.cs
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
    #region SetCorsSettingInput

    public class SetCorsSettingInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> List<System.String>? AllowedOrigins
        // GraphQL -> allowedOrigins: [String!] (scalar)
        [JsonProperty("allowedOrigins")]
        public List<System.String>? AllowedOrigins { get; set; }

        //      C# -> List<System.String>? AllowedHeaders
        // GraphQL -> allowedHeaders: [String!] (scalar)
        [JsonProperty("allowedHeaders")]
        public List<System.String>? AllowedHeaders { get; set; }

        //      C# -> List<HttpMethod>? AllowedMethods
        // GraphQL -> allowedMethods: [HttpMethod!] (enum)
        [JsonProperty("allowedMethods")]
        public List<HttpMethod>? AllowedMethods { get; set; }

        //      C# -> List<System.String>? AllowedPaths
        // GraphQL -> allowedPaths: [String!] (scalar)
        [JsonProperty("allowedPaths")]
        public List<System.String>? AllowedPaths { get; set; }


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

    } // class SetCorsSettingInput
    #endregion

} // namespace RubrikSecurityCloud.Types