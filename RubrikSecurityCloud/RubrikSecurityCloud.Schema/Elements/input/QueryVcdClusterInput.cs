// QueryVcdClusterInput.cs
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
    #region QueryVcdClusterInput

    public class QueryVcdClusterInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> QueryVcdClusterRequestSortBy? SortBy
        // GraphQL -> sortBy: QueryVcdClusterRequestSortBy (enum)
        [JsonProperty("sortBy")]
        public QueryVcdClusterRequestSortBy? SortBy { get; set; }

        //      C# -> QueryVcdClusterRequestSortOrder? SortOrder
        // GraphQL -> sortOrder: QueryVcdClusterRequestSortOrder (enum)
        [JsonProperty("sortOrder")]
        public QueryVcdClusterRequestSortOrder? SortOrder { get; set; }

        //      C# -> QueryVcdClusterRequestStatus? Status
        // GraphQL -> status: QueryVcdClusterRequestStatus (enum)
        [JsonProperty("status")]
        public QueryVcdClusterRequestStatus? Status { get; set; }

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

    } // class QueryVcdClusterInput
    #endregion

} // namespace RubrikSecurityCloud.Types