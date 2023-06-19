// AwsCloudAccountsWithFeaturesInput.cs
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
    #region AwsCloudAccountsWithFeaturesInput

    public class AwsCloudAccountsWithFeaturesInput: IInput
    {
        #region members

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> List<CloudAccountStatus>? StatusFilters
        // GraphQL -> statusFilters: [CloudAccountStatus!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("statusFilters")]
        public List<CloudAccountStatus>? StatusFilters { get; set; }

        //      C# -> System.String? AwsAdminAccountFilter
        // GraphQL -> awsAdminAccountFilter: UUID (scalar)
        [JsonProperty("awsAdminAccountFilter")]
        public System.String? AwsAdminAccountFilter { get; set; }

        //      C# -> System.String? ColumnSearchFilter
        // GraphQL -> columnSearchFilter: String (scalar)
        [JsonProperty("columnSearchFilter")]
        public System.String? ColumnSearchFilter { get; set; }


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

    } // class AwsCloudAccountsWithFeaturesInput
    #endregion

} // namespace RubrikSecurityCloud.Types