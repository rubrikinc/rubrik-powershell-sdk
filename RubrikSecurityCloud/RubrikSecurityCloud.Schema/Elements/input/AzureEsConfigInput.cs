// AzureEsConfigInput.cs
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
    #region AzureEsConfigInput

    public class AzureEsConfigInput: IInput
    {
        #region members

        //      C# -> System.String? StorageAccount
        // GraphQL -> storageAccount: String (scalar)
        [JsonProperty("storageAccount")]
        public System.String? StorageAccount { get; set; }

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String (scalar)
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

        //      C# -> System.String? StorageSecret
        // GraphQL -> storageSecret: String (scalar)
        [JsonProperty("storageSecret")]
        public System.String? StorageSecret { get; set; }

        //      C# -> System.String? ContainerName
        // GraphQL -> containerName: String (scalar)
        [JsonProperty("containerName")]
        public System.String? ContainerName { get; set; }

        //      C# -> System.Boolean? ShouldCreateContainer
        // GraphQL -> shouldCreateContainer: Boolean (scalar)
        [JsonProperty("shouldCreateContainer")]
        public System.Boolean? ShouldCreateContainer { get; set; }

        //      C# -> System.Boolean? EnableImmutability
        // GraphQL -> enableImmutability: Boolean (scalar)
        [JsonProperty("enableImmutability")]
        public System.Boolean? EnableImmutability { get; set; }


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

    } // class AzureEsConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types