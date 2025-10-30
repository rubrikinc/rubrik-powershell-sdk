// MigrateVmDataStoreInput.cs
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
    #region MigrateVmDataStoreInput

    public class MigrateVmDataStoreInput: IInput
    {
        #region members

        //      C# -> HypervMigrateVmDataStoreConfigInput? Config
        // GraphQL -> config: HypervMigrateVmDataStoreConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("config")]
        public HypervMigrateVmDataStoreConfigInput? Config { get; set; }

        //      C# -> System.String? MountId
        // GraphQL -> mountId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("mountId")]
        public System.String? MountId { get; set; }


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

    } // class MigrateVmDataStoreInput
    #endregion

} // namespace RubrikSecurityCloud.Types