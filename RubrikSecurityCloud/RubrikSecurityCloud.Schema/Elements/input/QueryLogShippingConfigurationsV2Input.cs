// QueryLogShippingConfigurationsV2Input.cs
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
    #region QueryLogShippingConfigurationsV2Input

    public class QueryLogShippingConfigurationsV2Input: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Int32? Limit
        // GraphQL -> limit: Int (scalar)
        [JsonProperty("limit")]
        public System.Int32? Limit { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int32? Offset
        // GraphQL -> offset: Int (scalar)
        [JsonProperty("offset")]
        public System.Int32? Offset { get; set; }

        //      C# -> System.String? PrimaryDatabaseId
        // GraphQL -> primaryDatabaseId: String (scalar)
        [JsonProperty("primaryDatabaseId")]
        public System.String? PrimaryDatabaseId { get; set; }

        //      C# -> System.String? PrimaryDatabaseName
        // GraphQL -> primaryDatabaseName: String (scalar)
        [JsonProperty("primaryDatabaseName")]
        public System.String? PrimaryDatabaseName { get; set; }

        //      C# -> System.String? SecondaryDatabaseName
        // GraphQL -> secondaryDatabaseName: String (scalar)
        [JsonProperty("secondaryDatabaseName")]
        public System.String? SecondaryDatabaseName { get; set; }

        //      C# -> V2QueryLogShippingConfigurationsV2RequestSortBy? SortBy
        // GraphQL -> sortBy: V2QueryLogShippingConfigurationsV2RequestSortBy (enum)
        [JsonProperty("sortBy")]
        public V2QueryLogShippingConfigurationsV2RequestSortBy? SortBy { get; set; }

        //      C# -> V2QueryLogShippingConfigurationsV2RequestSortOrder? SortOrder
        // GraphQL -> sortOrder: V2QueryLogShippingConfigurationsV2RequestSortOrder (enum)
        [JsonProperty("sortOrder")]
        public V2QueryLogShippingConfigurationsV2RequestSortOrder? SortOrder { get; set; }

        //      C# -> V2QueryLogShippingConfigurationsV2RequestStatus? Status
        // GraphQL -> status: V2QueryLogShippingConfigurationsV2RequestStatus (enum)
        [JsonProperty("status")]
        public V2QueryLogShippingConfigurationsV2RequestStatus? Status { get; set; }


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

    } // class QueryLogShippingConfigurationsV2Input
    #endregion

} // namespace RubrikSecurityCloud.Types