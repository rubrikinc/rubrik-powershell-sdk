// CreateSecurityPolicyInput.cs
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
    #region CreateSecurityPolicyInput

    public class CreateSecurityPolicyInput: IInput
    {
        #region members

        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("policyName")]
        public System.String? PolicyName { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> PolicyType? PolicyType
        // GraphQL -> policyType: PolicyType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("policyType")]
        public PolicyType? PolicyType { get; set; }

        //      C# -> FilterGroupConfigInput? Filter
        // GraphQL -> filter: FilterGroupConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("filter")]
        public FilterGroupConfigInput? Filter { get; set; }

        //      C# -> Severity? PolicySeverity
        // GraphQL -> policySeverity: Severity (enum)
        [JsonProperty("policySeverity")]
        public Severity? PolicySeverity { get; set; }

        //      C# -> Category? PolicyCategory
        // GraphQL -> policyCategory: Category (enum)
        [JsonProperty("policyCategory")]
        public Category? PolicyCategory { get; set; }

        //      C# -> System.Boolean? IsAutomationEnabled
        // GraphQL -> isAutomationEnabled: Boolean (scalar)
        [JsonProperty("isAutomationEnabled")]
        public System.Boolean? IsAutomationEnabled { get; set; }

        //      C# -> List<AutomationRuleInput>? AutomationRules
        // GraphQL -> automationRules: [AutomationRuleInput!] (input)
        [JsonProperty("automationRules")]
        public List<AutomationRuleInput>? AutomationRules { get; set; }

        //      C# -> FilterGroupConfigInput? ThresholdFilter
        // GraphQL -> thresholdFilter: FilterGroupConfigInput (input)
        [JsonProperty("thresholdFilter")]
        public FilterGroupConfigInput? ThresholdFilter { get; set; }

        //      C# -> PolicyTypeInfoInput? PolicyTypeInfo
        // GraphQL -> policyTypeInfo: PolicyTypeInfoInput (input)
        [JsonProperty("policyTypeInfo")]
        public PolicyTypeInfoInput? PolicyTypeInfo { get; set; }

        //      C# -> List<System.String>? Frameworks
        // GraphQL -> frameworks: [String!] (scalar)
        [JsonProperty("frameworks")]
        public List<System.String>? Frameworks { get; set; }


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

    } // class CreateSecurityPolicyInput
    #endregion

} // namespace RubrikSecurityCloud.Types