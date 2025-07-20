// SetCloudDirectNamespaceOverrideInput.cs
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
    #region SetCloudDirectNamespaceOverrideInput

    public class SetCloudDirectNamespaceOverrideInput: IInput
    {
        #region members

        //      C# -> System.String? NamespaceFid
        // GraphQL -> namespaceFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("namespaceFid")]
        public System.String? NamespaceFid { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> CloudDirectNetworkOverrideConfig? NetworkConfig
        // GraphQL -> networkConfig: CloudDirectNetworkOverrideConfig (input)
        [JsonProperty("networkConfig")]
        public CloudDirectNetworkOverrideConfig? NetworkConfig { get; set; }


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

    } // class SetCloudDirectNamespaceOverrideInput
    #endregion

} // namespace RubrikSecurityCloud.Types