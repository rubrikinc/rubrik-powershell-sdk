// K8sResourceSetAddInput.cs
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
    #region K8sResourceSetAddInput

    public class K8sResourceSetAddInput: IInput
    {
        #region members

        //      C# -> System.String? K8SclusterUuid
        // GraphQL -> k8SClusterUuid: String (scalar)
        [JsonProperty("k8SClusterUuid")]
        public System.String? K8SclusterUuid { get; set; }

        //      C# -> System.String? K8Snamespace
        // GraphQL -> k8SNamespace: String (scalar)
        [JsonProperty("k8SNamespace")]
        public System.String? K8Snamespace { get; set; }

        //      C# -> System.String? KubernetesNamespace
        // GraphQL -> kubernetesNamespace: String (scalar)
        [JsonProperty("kubernetesNamespace")]
        public System.String? KubernetesNamespace { get; set; }

        //      C# -> System.String? KubernetesClusterUuid
        // GraphQL -> kubernetesClusterUuid: String (scalar)
        [JsonProperty("kubernetesClusterUuid")]
        public System.String? KubernetesClusterUuid { get; set; }

        //      C# -> List<System.String>? HookConfigs
        // GraphQL -> hookConfigs: [String!] (scalar)
        [JsonProperty("hookConfigs")]
        public List<System.String>? HookConfigs { get; set; }

        //      C# -> System.String? Definition
        // GraphQL -> definition: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("definition")]
        public System.String? Definition { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RsType
        // GraphQL -> rsType: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("rsType")]
        public System.String? RsType { get; set; }


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

    } // class K8sResourceSetAddInput
    #endregion

} // namespace RubrikSecurityCloud.Types