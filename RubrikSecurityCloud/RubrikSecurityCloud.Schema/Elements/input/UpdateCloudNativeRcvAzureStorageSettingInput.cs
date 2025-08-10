// UpdateCloudNativeRcvAzureStorageSettingInput.cs
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
    #region UpdateCloudNativeRcvAzureStorageSettingInput

    public class UpdateCloudNativeRcvAzureStorageSettingInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> RcvRedundancy? RedundancyOpt
        // GraphQL -> redundancyOpt: RcvRedundancy (enum)
        [JsonProperty("redundancyOpt")]
        public RcvRedundancy? RedundancyOpt { get; set; }

        //      C# -> System.Boolean? UpdateChildVaultsOpt
        // GraphQL -> updateChildVaultsOpt: Boolean (scalar)
        [JsonProperty("updateChildVaultsOpt")]
        public System.Boolean? UpdateChildVaultsOpt { get; set; }


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

    } // class UpdateCloudNativeRcvAzureStorageSettingInput
    #endregion

} // namespace RubrikSecurityCloud.Types