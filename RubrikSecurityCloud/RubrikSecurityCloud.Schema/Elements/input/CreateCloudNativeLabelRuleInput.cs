// CreateCloudNativeLabelRuleInput.cs
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
    #region CreateCloudNativeLabelRuleInput

    public class CreateCloudNativeLabelRuleInput: IInput
    {
        #region members

        //      C# -> CloudNativeLabelObjectType? ObjectType
        // GraphQL -> objectType: CloudNativeLabelObjectType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectType")]
        public CloudNativeLabelObjectType? ObjectType { get; set; }

        //      C# -> System.String? LabelRuleName
        // GraphQL -> labelRuleName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("labelRuleName")]
        public System.String? LabelRuleName { get; set; }

        //      C# -> LabelType? Label
        // GraphQL -> label: LabelType (input)
        [JsonProperty("label")]
        public LabelType? Label { get; set; }

        //      C# -> TagRuleSlaAssignType? SlaAssignType
        // GraphQL -> slaAssignType: TagRuleSlaAssignType (enum)
        [JsonProperty("slaAssignType")]
        public TagRuleSlaAssignType? SlaAssignType { get; set; }

        //      C# -> System.String? SlaId
        // GraphQL -> slaId: UUID (scalar)
        [JsonProperty("slaId")]
        public System.String? SlaId { get; set; }

        //      C# -> CloudNativeIds? CloudNativeAccountIds
        // GraphQL -> cloudNativeAccountIds: CloudNativeIds (input)
        [JsonProperty("cloudNativeAccountIds")]
        public CloudNativeIds? CloudNativeAccountIds { get; set; }

        //      C# -> System.Boolean? ApplyToAllCloudAccounts
        // GraphQL -> applyToAllCloudAccounts: Boolean (scalar)
        [JsonProperty("applyToAllCloudAccounts")]
        public System.Boolean? ApplyToAllCloudAccounts { get; set; }

        //      C# -> CloudNativeTagCondition? LabelConditions
        // GraphQL -> labelConditions: CloudNativeTagCondition (input)
        [JsonProperty("labelConditions")]
        public CloudNativeTagCondition? LabelConditions { get; set; }


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

    } // class CreateCloudNativeLabelRuleInput
    #endregion

} // namespace RubrikSecurityCloud.Types