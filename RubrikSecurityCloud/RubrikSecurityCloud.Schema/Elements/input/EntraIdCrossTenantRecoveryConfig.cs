// EntraIdCrossTenantRecoveryConfig.cs
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
    #region EntraIdCrossTenantRecoveryConfig

    public class EntraIdCrossTenantRecoveryConfig: IInput
    {
        #region members

        //      C# -> System.String? TargetWorkloadFid
        // GraphQL -> targetWorkloadFid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetWorkloadFid")]
        public System.String? TargetWorkloadFid { get; set; }

        //      C# -> System.String? DefaultTargetDomainName
        // GraphQL -> defaultTargetDomainName: String (scalar)
        [JsonProperty("defaultTargetDomainName")]
        public System.String? DefaultTargetDomainName { get; set; }

        //      C# -> DomainMapping? DomainMapping
        // GraphQL -> domainMapping: DomainMapping (input)
        [JsonProperty("domainMapping")]
        public DomainMapping? DomainMapping { get; set; }


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

    } // class EntraIdCrossTenantRecoveryConfig
    #endregion

} // namespace RubrikSecurityCloud.Types