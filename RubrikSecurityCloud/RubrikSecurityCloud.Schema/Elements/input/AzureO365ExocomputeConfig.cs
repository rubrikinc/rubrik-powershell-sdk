// AzureO365ExocomputeConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:33.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureO365ExocomputeConfig

    public class AzureO365ExocomputeConfig
    {
        #region members
        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("regionName")]
        public System.String? RegionName { get; set; }

        //      C# -> GroupConfig? NewGroupConfig
        // GraphQL -> newGroupConfig: GroupConfig (input)
        [JsonProperty("newGroupConfig")]
        public GroupConfig? NewGroupConfig { get; set; }

        //      C# -> GroupConfig? ExistingGroupConfig
        // GraphQL -> existingGroupConfig: GroupConfig (input)
        [JsonProperty("existingGroupConfig")]
        public GroupConfig? ExistingGroupConfig { get; set; }

        //      C# -> NewComputeConfig? NewComputeConfig
        // GraphQL -> newComputeConfig: NewComputeConfig (input)
        [JsonProperty("newComputeConfig")]
        public NewComputeConfig? NewComputeConfig { get; set; }

        //      C# -> ExistingComputeConfig? ExistingComputeConfig
        // GraphQL -> existingComputeConfig: ExistingComputeConfig (input)
        [JsonProperty("existingComputeConfig")]
        public ExistingComputeConfig? ExistingComputeConfig { get; set; }

        //      C# -> NewStorageAccountConfig? NewStorageAccountConfig
        // GraphQL -> newStorageAccountConfig: NewStorageAccountConfig (input)
        [JsonProperty("newStorageAccountConfig")]
        public NewStorageAccountConfig? NewStorageAccountConfig { get; set; }

        //      C# -> ExistingStorageAccountConfig? ExistingStorageAccountConfig
        // GraphQL -> existingStorageAccountConfig: ExistingStorageAccountConfig (input)
        [JsonProperty("existingStorageAccountConfig")]
        public ExistingStorageAccountConfig? ExistingStorageAccountConfig { get; set; }

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

    } // class AzureO365ExocomputeConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types