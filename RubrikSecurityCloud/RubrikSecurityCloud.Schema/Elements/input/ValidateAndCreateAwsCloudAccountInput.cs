// ValidateAndCreateAwsCloudAccountInput.cs
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
    #region ValidateAndCreateAwsCloudAccountInput

    public class ValidateAndCreateAwsCloudAccountInput: IInput
    {
        #region members

        //      C# -> CloudAccountAction? Action
        // GraphQL -> action: CloudAccountAction! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("action")]
        public CloudAccountAction? Action { get; set; }

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!] (enum)
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> AwsCloudAccountInput? AwsAdminAccount
        // GraphQL -> awsAdminAccount: AwsCloudAccountInput (input)
        [JsonProperty("awsAdminAccount")]
        public AwsCloudAccountInput? AwsAdminAccount { get; set; }

        //      C# -> List<AwsCloudAccountInput>? AwsChildAccounts
        // GraphQL -> awsChildAccounts: [AwsCloudAccountInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("awsChildAccounts")]
        public List<AwsCloudAccountInput>? AwsChildAccounts { get; set; }

        //      C# -> AwsRoleCustomization? AwsRoleCustomization
        // GraphQL -> awsRoleCustomization: AwsRoleCustomization (input)
        [JsonProperty("awsRoleCustomization")]
        public AwsRoleCustomization? AwsRoleCustomization { get; set; }

        //      C# -> List<FeatureWithPermissionsGroups>? FeaturesWithPermissionsGroups
        // GraphQL -> featuresWithPermissionsGroups: [FeatureWithPermissionsGroups!] (input)
        [JsonProperty("featuresWithPermissionsGroups")]
        public List<FeatureWithPermissionsGroups>? FeaturesWithPermissionsGroups { get; set; }

        //      C# -> AwsIamPairInput? AwsIamPair
        // GraphQL -> awsIamPair: AwsIamPairInput (input)
        [JsonProperty("awsIamPair")]
        public AwsIamPairInput? AwsIamPair { get; set; }

        //      C# -> System.String? OutpostAwsNativeId
        // GraphQL -> outpostAwsNativeId: String (scalar)
        [JsonProperty("outpostAwsNativeId")]
        public System.String? OutpostAwsNativeId { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }


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

    } // class ValidateAndCreateAwsCloudAccountInput
    #endregion

} // namespace RubrikSecurityCloud.Types