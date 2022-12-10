// SonarContentReportFilter.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:30.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SonarContentReportFilter

    public class SonarContentReportFilter
    {
        #region members
        //      C# -> System.String? Search
        // GraphQL -> search: String (scalar)
        [JsonProperty("search")]
        public System.String? Search { get; set; }

        //      C# -> List<System.String>? PolicyIds
        // GraphQL -> policyIds: [String!] (scalar)
        [JsonProperty("policyIds")]
        public List<System.String>? PolicyIds { get; set; }

        //      C# -> List<System.String>? ClusterIds
        // GraphQL -> clusterIds: [String!] (scalar)
        [JsonProperty("clusterIds")]
        public List<System.String>? ClusterIds { get; set; }

        //      C# -> System.Boolean? ApplyWhitelists
        // GraphQL -> applyWhitelists: Boolean (scalar)
        [JsonProperty("applyWhitelists")]
        public System.Boolean? ApplyWhitelists { get; set; }

        //      C# -> List<System.String>? SubscriptionIds
        // GraphQL -> subscriptionIds: [String!] (scalar)
        [JsonProperty("subscriptionIds")]
        public List<System.String>? SubscriptionIds { get; set; }

        //      C# -> List<HierarchyObjectTypeEnum>? ObjectTypes
        // GraphQL -> objectTypes: [HierarchyObjectTypeEnum!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectTypes")]
        public List<HierarchyObjectTypeEnum>? ObjectTypes { get; set; }

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

    } // class SonarContentReportFilter
    #endregion

} // namespace Rubrik.SecurityCloud.Types