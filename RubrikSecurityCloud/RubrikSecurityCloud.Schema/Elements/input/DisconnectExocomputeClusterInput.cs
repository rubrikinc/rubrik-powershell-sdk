// DisconnectExocomputeClusterInput.cs
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
    #region DisconnectExocomputeClusterInput

    public class DisconnectExocomputeClusterInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> CloudType? CloudType
        // GraphQL -> cloudType: CloudType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudType")]
        public CloudType? CloudType { get; set; }


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

    } // class DisconnectExocomputeClusterInput
    #endregion

} // namespace RubrikSecurityCloud.Types