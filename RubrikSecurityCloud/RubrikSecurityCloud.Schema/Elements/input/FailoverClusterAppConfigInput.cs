// FailoverClusterAppConfigInput.cs
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
    #region FailoverClusterAppConfigInput

    public class FailoverClusterAppConfigInput: IInput
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> FailoverClusterAppSourceInput? FailoverClusterAppSource
        // GraphQL -> failoverClusterAppSource: FailoverClusterAppSourceInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("failoverClusterAppSource")]
        public FailoverClusterAppSourceInput? FailoverClusterAppSource { get; set; }

        //      C# -> System.String? FailoverClusterId
        // GraphQL -> failoverClusterId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("failoverClusterId")]
        public System.String? FailoverClusterId { get; set; }

        //      C# -> FailoverClusterType? FailoverClusterType
        // GraphQL -> failoverClusterType: FailoverClusterType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("failoverClusterType")]
        public FailoverClusterType? FailoverClusterType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }


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

    } // class FailoverClusterAppConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types