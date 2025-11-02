// CreateCloudNativeTagRuleInput.cs
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
    #region CreateCloudNativeTagRuleInput

    public class CreateCloudNativeTagRuleInput: IInput
    {
        #region members

        //      C# -> CloudNativeTagObjectType? ObjectType
        // GraphQL -> objectType: CloudNativeTagObjectType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectType")]
        public CloudNativeTagObjectType? ObjectType { get; set; }

        //      C# -> System.String? TagRuleName
        // GraphQL -> tagRuleName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tagRuleName")]
        public System.String? TagRuleName { get; set; }

        //      C# -> TagType? Tag
        // GraphQL -> tag: TagType (input)
        [JsonProperty("tag")]
        public TagType? Tag { get; set; }

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

        //      C# -> CloudNativeTagCondition? TagConditions
        // GraphQL -> tagConditions: CloudNativeTagCondition (input)
        [JsonProperty("tagConditions")]
        public CloudNativeTagCondition? TagConditions { get; set; }


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

    } // class CreateCloudNativeTagRuleInput
    #endregion

} // namespace RubrikSecurityCloud.Types