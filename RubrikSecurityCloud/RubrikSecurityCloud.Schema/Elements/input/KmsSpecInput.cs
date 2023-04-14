// KmsSpecInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region KmsSpecInput

    public class KmsSpecInput: IInput
    {
        #region members

        //      C# -> O365AzureCloudType? CloudType
        // GraphQL -> cloudType: O365AzureCloudType (enum)
        [JsonProperty("cloudType")]
        public O365AzureCloudType? CloudType { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String (scalar)
        [JsonProperty("kmsId")]
        public System.String? KmsId { get; set; }

        //      C# -> System.String? AppId
        // GraphQL -> appId: String (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppSecret
        // GraphQL -> appSecret: String (scalar)
        [JsonProperty("appSecret")]
        public System.String? AppSecret { get; set; }

        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String (scalar)
        [JsonProperty("keyName")]
        public System.String? KeyName { get; set; }

        //      C# -> System.String? KekNameColossus
        // GraphQL -> kekNameColossus: String (scalar)
        [JsonProperty("kekNameColossus")]
        public System.String? KekNameColossus { get; set; }


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

    } // class KmsSpecInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types