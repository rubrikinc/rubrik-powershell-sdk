// WorkdayIntegrationConfigInput.cs
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
    #region WorkdayIntegrationConfigInput

    public class WorkdayIntegrationConfigInput: IInput
    {
        #region members

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clientSecret")]
        public System.String? ClientSecret { get; set; }

        //      C# -> System.String? RefreshToken
        // GraphQL -> refreshToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("refreshToken")]
        public System.String? RefreshToken { get; set; }

        //      C# -> System.String? TokenEndpoint
        // GraphQL -> tokenEndpoint: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tokenEndpoint")]
        public System.String? TokenEndpoint { get; set; }

        //      C# -> WorkdayStatusInput? Status
        // GraphQL -> status: WorkdayStatusInput (input)
        [JsonProperty("status")]
        public WorkdayStatusInput? Status { get; set; }


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

    } // class WorkdayIntegrationConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types