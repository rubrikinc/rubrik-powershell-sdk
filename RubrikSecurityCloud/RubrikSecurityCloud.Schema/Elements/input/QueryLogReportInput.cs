// QueryLogReportInput.cs
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
    #region QueryLogReportInput

    public class QueryLogReportInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? LogBackupDelay
        // GraphQL -> logBackupDelay: Int (scalar)
        [JsonProperty("logBackupDelay")]
        public System.Int32? LogBackupDelay { get; set; }

        //      C# -> System.Int32? Limit
        // GraphQL -> limit: Int (scalar)
        [JsonProperty("limit")]
        public System.Int32? Limit { get; set; }

        //      C# -> System.Int32? Offset
        // GraphQL -> offset: Int (scalar)
        [JsonProperty("offset")]
        public System.Int32? Offset { get; set; }

        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.String? DatabaseType
        // GraphQL -> databaseType: String (scalar)
        [JsonProperty("databaseType")]
        public System.String? DatabaseType { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> V1QueryLogReportRequestSortBy? SortBy
        // GraphQL -> sortBy: V1QueryLogReportRequestSortBy (enum)
        [JsonProperty("sortBy")]
        public V1QueryLogReportRequestSortBy? SortBy { get; set; }

        //      C# -> V1QueryLogReportRequestSortOrder? SortOrder
        // GraphQL -> sortOrder: V1QueryLogReportRequestSortOrder (enum)
        [JsonProperty("sortOrder")]
        public V1QueryLogReportRequestSortOrder? SortOrder { get; set; }

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

    } // class QueryLogReportInput
    #endregion

} // namespace RubrikSecurityCloud.Types