// ObjectRecoveryOptionsType.cs
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
    #region ObjectRecoveryOptionsType

    public class ObjectRecoveryOptionsType: IInput
    {
        #region members

        //      C# -> ServicePrincipalRecoveryOptionType? ServicePrincipalRecoveryOption
        // GraphQL -> servicePrincipalRecoveryOption: ServicePrincipalRecoveryOptionType (input)
        [JsonProperty("servicePrincipalRecoveryOption")]
        public ServicePrincipalRecoveryOptionType? ServicePrincipalRecoveryOption { get; set; }

        //      C# -> ApplicationRecoveryOptionType? ApplicationRecoveryOption
        // GraphQL -> applicationRecoveryOption: ApplicationRecoveryOptionType (input)
        [JsonProperty("applicationRecoveryOption")]
        public ApplicationRecoveryOptionType? ApplicationRecoveryOption { get; set; }

        //      C# -> UserRecoveryOptionType? UserRecoveryOption
        // GraphQL -> userRecoveryOption: UserRecoveryOptionType (input)
        [JsonProperty("userRecoveryOption")]
        public UserRecoveryOptionType? UserRecoveryOption { get; set; }

        //      C# -> ConditionalAccessPolicyRecoveryOption? ConditionalAccessPolicyRecoveryOption
        // GraphQL -> conditionalAccessPolicyRecoveryOption: ConditionalAccessPolicyRecoveryOption (input)
        [JsonProperty("conditionalAccessPolicyRecoveryOption")]
        public ConditionalAccessPolicyRecoveryOption? ConditionalAccessPolicyRecoveryOption { get; set; }

        //      C# -> AdministrativeUnitRecoveryOption? AdministrativeUnitRecoveryOption
        // GraphQL -> administrativeUnitRecoveryOption: AdministrativeUnitRecoveryOption (input)
        [JsonProperty("administrativeUnitRecoveryOption")]
        public AdministrativeUnitRecoveryOption? AdministrativeUnitRecoveryOption { get; set; }


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

    } // class ObjectRecoveryOptionsType
    #endregion

} // namespace RubrikSecurityCloud.Types