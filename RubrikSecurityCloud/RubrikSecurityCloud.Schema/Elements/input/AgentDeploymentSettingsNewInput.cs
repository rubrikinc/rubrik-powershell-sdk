// AgentDeploymentSettingsNewInput.cs
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
    #region AgentDeploymentSettingsNewInput

    public class AgentDeploymentSettingsNewInput: IInput
    {
        #region members

        //      C# -> GuestCredentialDefinitionInput? GuestCredential
        // GraphQL -> guestCredential: GuestCredentialDefinitionInput (input)
        [JsonProperty("guestCredential")]
        public GuestCredentialDefinitionInput? GuestCredential { get; set; }

        //      C# -> System.String? GuestCredentialId
        // GraphQL -> guestCredentialId: String (scalar)
        [JsonProperty("guestCredentialId")]
        public System.String? GuestCredentialId { get; set; }

        //      C# -> System.Boolean? IsAutomatic
        // GraphQL -> isAutomatic: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isAutomatic")]
        public System.Boolean? IsAutomatic { get; set; }


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

    } // class AgentDeploymentSettingsNewInput
    #endregion

} // namespace RubrikSecurityCloud.Types