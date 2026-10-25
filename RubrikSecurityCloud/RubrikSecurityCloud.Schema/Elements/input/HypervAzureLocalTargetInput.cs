// HypervAzureLocalTargetInput.cs
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
    #region HypervAzureLocalTargetInput

    public class HypervAzureLocalTargetInput: IInput
    {
        #region members

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

        //      C# -> System.String? HypervClusterId
        // GraphQL -> hypervClusterId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hypervClusterId")]
        public System.String? HypervClusterId { get; set; }

        //      C# -> List<HypervAzureLocalNicSpecInput>? Nics
        // GraphQL -> nics: [HypervAzureLocalNicSpecInput!] (input)
        [JsonProperty("nics")]
        public List<HypervAzureLocalNicSpecInput>? Nics { get; set; }


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

    } // class HypervAzureLocalTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types