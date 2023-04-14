// O365SaasSetupCompleteInput.cs
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
    #region O365SaasSetupCompleteInput

    public class O365SaasSetupCompleteInput: IInput
    {
        #region members

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("regionName")]
        public System.String? RegionName { get; set; }

        //      C# -> System.String? StateToken
        // GraphQL -> stateToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("stateToken")]
        public System.String? StateToken { get; set; }

        //      C# -> List<System.String>? AppTypes
        // GraphQL -> appTypes: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appTypes")]
        public List<System.String>? AppTypes { get; set; }

        //      C# -> KmsSpecInput? KmsSpec
        // GraphQL -> kmsSpec: KmsSpecInput (input)
        [JsonProperty("kmsSpec")]
        public KmsSpecInput? KmsSpec { get; set; }

        //      C# -> System.Boolean? StoreBackupInSameRegionAsData
        // GraphQL -> storeBackupInSameRegionAsData: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("storeBackupInSameRegionAsData")]
        public System.Boolean? StoreBackupInSameRegionAsData { get; set; }


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

    } // class O365SaasSetupCompleteInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types