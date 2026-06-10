// K8sProtectionSetAddInput.cs
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
    #region K8sProtectionSetAddInput

    public class K8sProtectionSetAddInput: IInput
    {
        #region members

        //      C# -> System.String? CreationType
        // GraphQL -> creationType: String (scalar)
        [JsonProperty("creationType")]
        public System.String? CreationType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<CustomResourceDependencyInput>? CustomResourceDependencies
        // GraphQL -> customResourceDependencies: [CustomResourceDependencyInput!] (input)
        [JsonProperty("customResourceDependencies")]
        public List<CustomResourceDependencyInput>? CustomResourceDependencies { get; set; }

        //      C# -> CdmLabelSelectorInput? LabelSelector
        // GraphQL -> labelSelector: CdmLabelSelectorInput (input)
        [JsonProperty("labelSelector")]
        public CdmLabelSelectorInput? LabelSelector { get; set; }

        //      C# -> System.String? RsType
        // GraphQL -> rsType: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("rsType")]
        public System.String? RsType { get; set; }

        //      C# -> List<System.String>? NamespaceExcludePatterns
        // GraphQL -> namespaceExcludePatterns: [String!] (scalar)
        [JsonProperty("namespaceExcludePatterns")]
        public List<System.String>? NamespaceExcludePatterns { get; set; }

        //      C# -> System.String? Definition
        // GraphQL -> definition: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("definition")]
        public System.String? Definition { get; set; }

        //      C# -> List<System.String>? NamespaceIncludePatterns
        // GraphQL -> namespaceIncludePatterns: [String!] (scalar)
        [JsonProperty("namespaceIncludePatterns")]
        public List<System.String>? NamespaceIncludePatterns { get; set; }

        //      C# -> System.String? KubernetesNamespace
        // GraphQL -> kubernetesNamespace: String (scalar)
        [JsonProperty("kubernetesNamespace")]
        public System.String? KubernetesNamespace { get; set; }

        //      C# -> System.String? KubernetesClusterId
        // GraphQL -> kubernetesClusterId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("kubernetesClusterId")]
        public System.String? KubernetesClusterId { get; set; }

        //      C# -> List<System.String>? HookConfigs
        // GraphQL -> hookConfigs: [String!] (scalar)
        [JsonProperty("hookConfigs")]
        public List<System.String>? HookConfigs { get; set; }


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

    } // class K8sProtectionSetAddInput
    #endregion

} // namespace RubrikSecurityCloud.Types