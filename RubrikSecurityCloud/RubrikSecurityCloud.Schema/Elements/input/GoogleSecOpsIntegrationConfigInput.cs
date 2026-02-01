// GoogleSecOpsIntegrationConfigInput.cs
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
    #region GoogleSecOpsIntegrationConfigInput

    public class GoogleSecOpsIntegrationConfigInput: IInput
    {
        #region members

        //      C# -> GoogleSecOpsIntegrationConfigType? ConfigType
        // GraphQL -> configType: GoogleSecOpsIntegrationConfigType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("configType")]
        public GoogleSecOpsIntegrationConfigType? ConfigType { get; set; }

        //      C# -> System.Int32? WebhookId
        // GraphQL -> webhookId: Int (scalar)
        [JsonProperty("webhookId")]
        public System.Int32? WebhookId { get; set; }

        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("serviceAccountId")]
        public System.String? ServiceAccountId { get; set; }


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

    } // class GoogleSecOpsIntegrationConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types