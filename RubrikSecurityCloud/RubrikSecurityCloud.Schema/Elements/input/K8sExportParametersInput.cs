// K8sExportParametersInput.cs
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
    #region K8sExportParametersInput

    public class K8sExportParametersInput: IInput
    {
        #region members

        //      C# -> System.String? Filter
        // GraphQL -> filter: String (scalar)
        [JsonProperty("filter")]
        public System.String? Filter { get; set; }

        //      C# -> System.Boolean? ShouldDeleteNamespaceIfExportFailed
        // GraphQL -> shouldDeleteNamespaceIfExportFailed: Boolean (scalar)
        [JsonProperty("shouldDeleteNamespaceIfExportFailed")]
        public System.Boolean? ShouldDeleteNamespaceIfExportFailed { get; set; }

        //      C# -> System.Boolean? IgnoreErrors
        // GraphQL -> ignoreErrors: Boolean (scalar)
        [JsonProperty("ignoreErrors")]
        public System.Boolean? IgnoreErrors { get; set; }

        //      C# -> System.String? TargetClusterId
        // GraphQL -> targetClusterId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetClusterId")]
        public System.String? TargetClusterId { get; set; }

        //      C# -> System.String? TargetNamespaceName
        // GraphQL -> targetNamespaceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetNamespaceName")]
        public System.String? TargetNamespaceName { get; set; }


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

    } // class K8sExportParametersInput
    #endregion

} // namespace RubrikSecurityCloud.Types