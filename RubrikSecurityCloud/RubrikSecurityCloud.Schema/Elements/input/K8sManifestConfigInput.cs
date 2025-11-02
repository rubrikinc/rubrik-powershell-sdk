// K8sManifestConfigInput.cs
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
    #region K8sManifestConfigInput

    public class K8sManifestConfigInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Registry
        // GraphQL -> registry: String (scalar)
        [JsonProperty("registry")]
        public System.String? Registry { get; set; }

        //      C# -> System.String? K8sNodeIp
        // GraphQL -> k8sNodeIp: String (scalar)
        [JsonProperty("k8sNodeIp")]
        public System.String? K8sNodeIp { get; set; }

        //      C# -> System.String? Distribution
        // GraphQL -> distribution: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("distribution")]
        public System.String? Distribution { get; set; }

        //      C# -> System.String? PullSecret
        // GraphQL -> pullSecret: String (scalar)
        [JsonProperty("pullSecret")]
        public System.String? PullSecret { get; set; }

        //      C# -> System.String? NadName
        // GraphQL -> nadName: String (scalar)
        [JsonProperty("nadName")]
        public System.String? NadName { get; set; }

        //      C# -> System.String? Transport
        // GraphQL -> transport: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("transport")]
        public System.String? Transport { get; set; }

        //      C# -> System.Boolean? IsAutoPsCreationEnabled
        // GraphQL -> isAutoPsCreationEnabled: Boolean (scalar)
        [JsonProperty("isAutoPsCreationEnabled")]
        public System.Boolean? IsAutoPsCreationEnabled { get; set; }

        //      C# -> System.String? NadNamespace
        // GraphQL -> nadNamespace: String (scalar)
        [JsonProperty("nadNamespace")]
        public System.String? NadNamespace { get; set; }

        //      C# -> ServiceAccountInputInput? ServiceAccount
        // GraphQL -> serviceAccount: ServiceAccountInputInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("serviceAccount")]
        public ServiceAccountInputInput? ServiceAccount { get; set; }


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

    } // class K8sManifestConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types