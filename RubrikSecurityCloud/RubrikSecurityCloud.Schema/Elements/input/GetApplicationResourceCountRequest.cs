// GetApplicationResourceCountRequest.cs
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
    #region GetApplicationResourceCountRequest

    public class GetApplicationResourceCountRequest: IInput
    {
        #region members

        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("applicationId")]
        public System.String? ApplicationId { get; set; }

        //      C# -> List<ApplicationResourceTypeFilterInput>? ResourceTypes
        // GraphQL -> resourceTypes: [ApplicationResourceTypeFilterInput!] (input)
        [JsonProperty("resourceTypes")]
        public List<ApplicationResourceTypeFilterInput>? ResourceTypes { get; set; }

        //      C# -> System.Boolean? ShouldIncludeGranularWorkloadProtectionStatus
        // GraphQL -> shouldIncludeGranularWorkloadProtectionStatus: Boolean (scalar)
        [JsonProperty("shouldIncludeGranularWorkloadProtectionStatus")]
        public System.Boolean? ShouldIncludeGranularWorkloadProtectionStatus { get; set; }


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

    } // class GetApplicationResourceCountRequest
    #endregion

} // namespace RubrikSecurityCloud.Types