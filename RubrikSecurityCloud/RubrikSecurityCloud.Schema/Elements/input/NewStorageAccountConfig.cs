// NewStorageAccountConfig.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region NewStorageAccountConfig

    public class NewStorageAccountConfig: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> StorageAccountTier? Tier
        // GraphQL -> tier: StorageAccountTier (enum)
        [JsonProperty("tier")]
        public StorageAccountTier? Tier { get; set; }

        //      C# -> StorageAccountSku? Sku
        // GraphQL -> sku: StorageAccountSku (enum)
        [JsonProperty("sku")]
        public StorageAccountSku? Sku { get; set; }

        //      C# -> List<StorageAccountConfigItem>? Storages
        // GraphQL -> storages: [StorageAccountConfigItem!] (input)
        [JsonProperty("storages")]
        public List<StorageAccountConfigItem>? Storages { get; set; }


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

    } // class NewStorageAccountConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types