// FusionComputeNetworkToNicInput.cs
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
    #region FusionComputeNetworkToNicInput

    public class FusionComputeNetworkToNicInput: IInput
    {
        #region members

        //      C# -> System.String? NicId
        // GraphQL -> nicId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nicId")]
        public System.String? NicId { get; set; }

        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("networkId")]
        public System.String? NetworkId { get; set; }


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

    } // class FusionComputeNetworkToNicInput
    #endregion

} // namespace RubrikSecurityCloud.Types