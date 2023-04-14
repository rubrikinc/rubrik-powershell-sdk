// ExistingComputeConfig.cs
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
    #region ExistingComputeConfig

    public class ExistingComputeConfig: IInput
    {
        #region members

        //      C# -> System.String? VnetId
        // GraphQL -> vnetId: String (scalar)
        [JsonProperty("vnetId")]
        public System.String? VnetId { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }


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

    } // class ExistingComputeConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types