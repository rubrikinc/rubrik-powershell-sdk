// AddAzureCloudAccountFeatureInputWithoutOauth.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AddAzureCloudAccountFeatureInputWithoutOauth

    public class AddAzureCloudAccountFeatureInputWithoutOauth: IInput
    {
        #region members

        //      C# -> System.Int32? PolicyVersion
        // GraphQL -> policyVersion: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("policyVersion")]
        public System.Int32? PolicyVersion { get; set; }

        //      C# -> AddAzureCloudAccountResourceGroupInput? ResourceGroup
        // GraphQL -> resourceGroup: AddAzureCloudAccountResourceGroupInput (input)
        [JsonProperty("resourceGroup")]
        public AddAzureCloudAccountResourceGroupInput? ResourceGroup { get; set; }

        //      C# -> AddAzureCloudAccountSpecificFeatureInput? SpecificFeatureInput
        // GraphQL -> specificFeatureInput: AddAzureCloudAccountSpecificFeatureInput (input)
        [JsonProperty("specificFeatureInput")]
        public AddAzureCloudAccountSpecificFeatureInput? SpecificFeatureInput { get; set; }

        //      C# -> CloudAccountFeature? FeatureType
        // GraphQL -> featureType: CloudAccountFeature! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("featureType")]
        public CloudAccountFeature? FeatureType { get; set; }


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

    } // class AddAzureCloudAccountFeatureInputWithoutOauth
    #endregion

} // namespace Rubrik.SecurityCloud.Types