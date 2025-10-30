// GcpCloudAccountDeleteProjectsV2FeatureInput.cs
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
    #region GcpCloudAccountDeleteProjectsV2FeatureInput

    public class GcpCloudAccountDeleteProjectsV2FeatureInput: IInput
    {
        #region members

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> System.Boolean? DeleteSnapshots
        // GraphQL -> deleteSnapshots: Boolean (scalar)
        [JsonProperty("deleteSnapshots")]
        public System.Boolean? DeleteSnapshots { get; set; }

        //      C# -> List<System.String>? CloudAccountIds
        // GraphQL -> cloudAccountIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudAccountIds")]
        public List<System.String>? CloudAccountIds { get; set; }


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

    } // class GcpCloudAccountDeleteProjectsV2FeatureInput
    #endregion

} // namespace RubrikSecurityCloud.Types