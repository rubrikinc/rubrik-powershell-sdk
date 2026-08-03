// PolicyFilters.cs
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
    #region PolicyFilters

    public class PolicyFilters: IInput
    {
        #region members

        //      C# -> List<ViolationSeverity>? PolicySeverities
        // GraphQL -> policySeverities: [ViolationSeverity!] (enum)
        [JsonProperty("policySeverities")]
        public List<ViolationSeverity>? PolicySeverities { get; set; }

        //      C# -> List<Category>? PolicyCategories
        // GraphQL -> policyCategories: [Category!] (enum)
        [JsonProperty("policyCategories")]
        public List<Category>? PolicyCategories { get; set; }

        //      C# -> List<PolicyType>? PolicyTypes
        // GraphQL -> policyTypes: [PolicyType!] (enum)
        [JsonProperty("policyTypes")]
        public List<PolicyType>? PolicyTypes { get; set; }

        //      C# -> System.Boolean? IncludeDeletedPolicies
        // GraphQL -> includeDeletedPolicies: Boolean (scalar)
        [JsonProperty("includeDeletedPolicies")]
        public System.Boolean? IncludeDeletedPolicies { get; set; }

        //      C# -> List<System.String>? PolicyFrameworks
        // GraphQL -> policyFrameworks: [String!] (scalar)
        [JsonProperty("policyFrameworks")]
        public List<System.String>? PolicyFrameworks { get; set; }


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

    } // class PolicyFilters
    #endregion

} // namespace RubrikSecurityCloud.Types