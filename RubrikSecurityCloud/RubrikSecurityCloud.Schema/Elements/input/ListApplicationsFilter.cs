// ListApplicationsFilter.cs
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
    #region ListApplicationsFilter

    public class ListApplicationsFilter: IInput
    {
        #region members

        //      C# -> List<System.String>? CloudNativeAccountIds
        // GraphQL -> cloudNativeAccountIds: [String!] (scalar)
        [JsonProperty("cloudNativeAccountIds")]
        public List<System.String>? CloudNativeAccountIds { get; set; }

        //      C# -> List<CloudNativeApplicationRefreshStatus>? RefreshStatus
        // GraphQL -> refreshStatus: [CloudNativeApplicationRefreshStatus!] (enum)
        [JsonProperty("refreshStatus")]
        public List<CloudNativeApplicationRefreshStatus>? RefreshStatus { get; set; }

        //      C# -> List<CloudRegionInput>? RegionIds
        // GraphQL -> regionIds: [CloudRegionInput!] (input)
        [JsonProperty("regionIds")]
        public List<CloudRegionInput>? RegionIds { get; set; }

        //      C# -> List<CloudNativeProtectionStatus>? ProtectionStatus
        // GraphQL -> protectionStatus: [CloudNativeProtectionStatus!] (enum)
        [JsonProperty("protectionStatus")]
        public List<CloudNativeProtectionStatus>? ProtectionStatus { get; set; }

        //      C# -> List<CloudServiceProvider>? CloudTypes
        // GraphQL -> cloudTypes: [CloudServiceProvider!] (enum)
        [JsonProperty("cloudTypes")]
        public List<CloudServiceProvider>? CloudTypes { get; set; }

        //      C# -> System.String? ApplicationName
        // GraphQL -> applicationName: String (scalar)
        [JsonProperty("applicationName")]
        public System.String? ApplicationName { get; set; }


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

    } // class ListApplicationsFilter
    #endregion

} // namespace RubrikSecurityCloud.Types