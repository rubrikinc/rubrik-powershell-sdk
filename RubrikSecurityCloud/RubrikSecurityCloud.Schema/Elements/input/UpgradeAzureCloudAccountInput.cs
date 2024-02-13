// UpgradeAzureCloudAccountInput.cs
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
    #region UpgradeAzureCloudAccountInput

    public class UpgradeAzureCloudAccountInput: IInput
    {
        #region members

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!] (enum)
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> List<UpgradeAzureCloudAccountFeatureInput>? FeaturesToUpgrade
        // GraphQL -> featuresToUpgrade: [UpgradeAzureCloudAccountFeatureInput!] (input)
        [JsonProperty("featuresToUpgrade")]
        public List<UpgradeAzureCloudAccountFeatureInput>? FeaturesToUpgrade { get; set; }

        //      C# -> List<System.String>? AzureSubscriptionRubrikIds
        // GraphQL -> azureSubscriptionRubrikIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("azureSubscriptionRubrikIds")]
        public List<System.String>? AzureSubscriptionRubrikIds { get; set; }


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

    } // class UpgradeAzureCloudAccountInput
    #endregion

} // namespace RubrikSecurityCloud.Types