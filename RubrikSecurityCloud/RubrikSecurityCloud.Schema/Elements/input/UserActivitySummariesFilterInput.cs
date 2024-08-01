// UserActivitySummariesFilterInput.cs
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
    #region UserActivitySummariesFilterInput

    public class UserActivitySummariesFilterInput: IInput
    {
        #region members

        //      C# -> System.String? UserNamePrefix
        // GraphQL -> userNamePrefix: String (scalar)
        [JsonProperty("userNamePrefix")]
        public System.String? UserNamePrefix { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> RiskLevelType? UserRisk
        // GraphQL -> userRisk: RiskLevelType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("userRisk")]
        public RiskLevelType? UserRisk { get; set; }

        //      C# -> PrincipalSummaryCategory? PrincipalSummaryCategory
        // GraphQL -> principalSummaryCategory: PrincipalSummaryCategory! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("principalSummaryCategory")]
        public PrincipalSummaryCategory? PrincipalSummaryCategory { get; set; }

        //      C# -> UserActivityType? UserActivityType
        // GraphQL -> userActivityType: UserActivityType (enum)
        [JsonProperty("userActivityType")]
        public UserActivityType? UserActivityType { get; set; }


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

    } // class UserActivitySummariesFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types