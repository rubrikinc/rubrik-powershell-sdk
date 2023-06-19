// TargetStorageAccountConfigInput.cs
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
    #region TargetStorageAccountConfigInput

    public class TargetStorageAccountConfigInput: IInput
    {
        #region members

        //      C# -> System.String? SubscriptionCloudAccountId
        // GraphQL -> subscriptionCloudAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subscriptionCloudAccountId")]
        public System.String? SubscriptionCloudAccountId { get; set; }

        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }

        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("storageAccountName")]
        public System.String? StorageAccountName { get; set; }

        //      C# -> TagsInput? Tags
        // GraphQL -> tags: TagsInput (input)
        [JsonProperty("tags")]
        public TagsInput? Tags { get; set; }


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

    } // class TargetStorageAccountConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types