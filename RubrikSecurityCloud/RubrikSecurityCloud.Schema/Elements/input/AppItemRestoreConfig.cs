// AppItemRestoreConfig.cs
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
    #region AppItemRestoreConfig

    public class AppItemRestoreConfig: IInput
    {
        #region members

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appItemTypeToken")]
        public System.String? AppItemTypeToken { get; set; }

        //      C# -> List<RestoreItemInfo>? ItemsToRestore
        // GraphQL -> itemsToRestore: [RestoreItemInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("itemsToRestore")]
        public List<RestoreItemInfo>? ItemsToRestore { get; set; }


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

    } // class AppItemRestoreConfig
    #endregion

} // namespace RubrikSecurityCloud.Types