// ExportK8sNamespaceInput.cs
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
    #region ExportK8sNamespaceInput

    public class ExportK8sNamespaceInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotUuid
        // GraphQL -> snapshotUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotUuid")]
        public System.String? SnapshotUuid { get; set; }

        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetClusterUuid")]
        public System.String? TargetClusterUuid { get; set; }

        //      C# -> System.String? TargetNamespaceName
        // GraphQL -> targetNamespaceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetNamespaceName")]
        public System.String? TargetNamespaceName { get; set; }

        //      C# -> LabelSelector? LabelSelector
        // GraphQL -> labelSelector: LabelSelector (input)
        [JsonProperty("labelSelector")]
        public LabelSelector? LabelSelector { get; set; }


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

    } // class ExportK8sNamespaceInput
    #endregion

} // namespace RubrikSecurityCloud.Types