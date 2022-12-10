// GetHealthMonitorPolicyStatusInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:17.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region GetHealthMonitorPolicyStatusInput

    public class GetHealthMonitorPolicyStatusInput
    {
        #region members
        //      C# -> System.Boolean? HasDetailedStatus
        // GraphQL -> hasDetailedStatus: Boolean (scalar)
        [JsonProperty("hasDetailedStatus")]
        public System.Boolean? HasDetailedStatus { get; set; }

        //      C# -> List<System.String>? NodeIds
        // GraphQL -> nodeIds: [String!] (scalar)
        [JsonProperty("nodeIds")]
        public List<System.String>? NodeIds { get; set; }

        //      C# -> List<System.String>? PolicyIds
        // GraphQL -> policyIds: [String!] (scalar)
        [JsonProperty("policyIds")]
        public List<System.String>? PolicyIds { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

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

    } // class GetHealthMonitorPolicyStatusInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types