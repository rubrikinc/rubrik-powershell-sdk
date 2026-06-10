// DevOpsCloudAccountListCurrentPermissionsReq.cs
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
    #region DevOpsCloudAccountListCurrentPermissionsReq

    public class DevOpsCloudAccountListCurrentPermissionsReq: IInput
    {
        #region members

        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("organizationId")]
        public System.String? OrganizationId { get; set; }

        //      C# -> List<FeatureWithPermissionsGroups>? FeaturesWithPermissionsGroups
        // GraphQL -> featuresWithPermissionsGroups: [FeatureWithPermissionsGroups!] (input)
        [JsonProperty("featuresWithPermissionsGroups")]
        public List<FeatureWithPermissionsGroups>? FeaturesWithPermissionsGroups { get; set; }


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

    } // class DevOpsCloudAccountListCurrentPermissionsReq
    #endregion

} // namespace RubrikSecurityCloud.Types