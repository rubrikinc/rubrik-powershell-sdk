// K8sVmMountParametersInput.cs
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
    #region K8sVmMountParametersInput

    public class K8sVmMountParametersInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldRemoveNetwork
        // GraphQL -> shouldRemoveNetwork: Boolean (scalar)
        [JsonProperty("shouldRemoveNetwork")]
        public System.Boolean? ShouldRemoveNetwork { get; set; }

        //      C# -> System.String? NewVmName
        // GraphQL -> newVmName: String (scalar)
        [JsonProperty("newVmName")]
        public System.String? NewVmName { get; set; }

        //      C# -> System.String? TargetClusterId
        // GraphQL -> targetClusterId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetClusterId")]
        public System.String? TargetClusterId { get; set; }

        //      C# -> System.String? TargetNamespaceId
        // GraphQL -> targetNamespaceId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetNamespaceId")]
        public System.String? TargetNamespaceId { get; set; }

        //      C# -> System.String? NewRunStrategy
        // GraphQL -> newRunStrategy: String (scalar)
        [JsonProperty("newRunStrategy")]
        public System.String? NewRunStrategy { get; set; }

        //      C# -> System.Boolean? ShouldKeepMacAddresses
        // GraphQL -> shouldKeepMacAddresses: Boolean (scalar)
        [JsonProperty("shouldKeepMacAddresses")]
        public System.Boolean? ShouldKeepMacAddresses { get; set; }


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

    } // class K8sVmMountParametersInput
    #endregion

} // namespace RubrikSecurityCloud.Types