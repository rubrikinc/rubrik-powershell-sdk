// GenerateClusterRegistrationTokenInput.cs
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
    #region GenerateClusterRegistrationTokenInput

    public class GenerateClusterRegistrationTokenInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ManagedByPolaris
        // GraphQL -> managedByPolaris: Boolean (scalar)
        [JsonProperty("managedByPolaris")]
        public System.Boolean? ManagedByPolaris { get; set; }

        //      C# -> List<NodeRegistrationConfigsInput>? NodeConfigs
        // GraphQL -> nodeConfigs: [NodeRegistrationConfigsInput!] (input)
        [JsonProperty("nodeConfigs")]
        public List<NodeRegistrationConfigsInput>? NodeConfigs { get; set; }

        //      C# -> System.Boolean? IsOfflineRegistration
        // GraphQL -> isOfflineRegistration: Boolean (scalar)
        [JsonProperty("isOfflineRegistration")]
        public System.Boolean? IsOfflineRegistration { get; set; }


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

    } // class GenerateClusterRegistrationTokenInput
    #endregion

} // namespace RubrikSecurityCloud.Types