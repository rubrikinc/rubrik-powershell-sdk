// QueryHypervHostInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region QueryHypervHostInput

    public class QueryHypervHostInput
    {
        #region members
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.Int32? Limit
        // GraphQL -> limit: Int (scalar)
        [JsonProperty("limit")]
        public System.Int32? Limit { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? Offset
        // GraphQL -> offset: Int (scalar)
        [JsonProperty("offset")]
        public System.Int32? Offset { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> InternalQueryHypervHostRequestSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: InternalQueryHypervHostRequestSlaAssignment (enum)
        [JsonProperty("slaAssignment")]
        public InternalQueryHypervHostRequestSlaAssignment? SlaAssignment { get; set; }

        //      C# -> InternalQueryHypervHostRequestSortBy? SortBy
        // GraphQL -> sortBy: InternalQueryHypervHostRequestSortBy (enum)
        [JsonProperty("sortBy")]
        public InternalQueryHypervHostRequestSortBy? SortBy { get; set; }

        //      C# -> InternalQueryHypervHostRequestSortOrder? SortOrder
        // GraphQL -> sortOrder: InternalQueryHypervHostRequestSortOrder (enum)
        [JsonProperty("sortOrder")]
        public InternalQueryHypervHostRequestSortOrder? SortOrder { get; set; }

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

    } // class QueryHypervHostInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types