// K8sClusterAddInput.cs
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
    #region K8sClusterAddInput

    public class K8sClusterAddInput: IInput
    {
        #region members

        //      C# -> System.String? Registry
        // GraphQL -> registry: String (scalar)
        [JsonProperty("registry")]
        public System.String? Registry { get; set; }

        //      C# -> System.String? Distribution
        // GraphQL -> distribution: String (scalar)
        [JsonProperty("distribution")]
        public System.String? Distribution { get; set; }

        //      C# -> K8sAwsConfigInput? K8SawsConfig
        // GraphQL -> k8SAwsConfig: K8sAwsConfigInput (input)
        [JsonProperty("k8SAwsConfig")]
        public K8sAwsConfigInput? K8SawsConfig { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.String? Kubeconfig
        // GraphQL -> kubeconfig: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("kubeconfig")]
        public System.String? Kubeconfig { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }


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

    } // class K8sClusterAddInput
    #endregion

} // namespace RubrikSecurityCloud.Types