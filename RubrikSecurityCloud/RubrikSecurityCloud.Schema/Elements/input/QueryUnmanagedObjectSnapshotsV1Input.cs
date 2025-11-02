// QueryUnmanagedObjectSnapshotsV1Input.cs
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
    #region QueryUnmanagedObjectSnapshotsV1Input

    public class QueryUnmanagedObjectSnapshotsV1Input: IInput
    {
        #region members

        //      C# -> DateTime? AfterDate
        // GraphQL -> afterDate: DateTime (scalar)
        [JsonProperty("afterDate")]
        public DateTime? AfterDate { get; set; }

        //      C# -> DateTime? BeforeDate
        // GraphQL -> beforeDate: DateTime (scalar)
        [JsonProperty("beforeDate")]
        public DateTime? BeforeDate { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int32? Limit
        // GraphQL -> limit: Int (scalar)
        [JsonProperty("limit")]
        public System.Int32? Limit { get; set; }

        //      C# -> System.Int32? Offset
        // GraphQL -> offset: Int (scalar)
        [JsonProperty("offset")]
        public System.Int32? Offset { get; set; }

        //      C# -> System.String? SearchValue
        // GraphQL -> searchValue: String (scalar)
        [JsonProperty("searchValue")]
        public System.String? SearchValue { get; set; }

        //      C# -> V1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType? SnapshotType
        // GraphQL -> snapshotType: V1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType (enum)
        [JsonProperty("snapshotType")]
        public V1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType? SnapshotType { get; set; }

        //      C# -> V1QueryUnmanagedObjectSnapshotsV1RequestSortBy? SortBy
        // GraphQL -> sortBy: V1QueryUnmanagedObjectSnapshotsV1RequestSortBy (enum)
        [JsonProperty("sortBy")]
        public V1QueryUnmanagedObjectSnapshotsV1RequestSortBy? SortBy { get; set; }

        //      C# -> V1QueryUnmanagedObjectSnapshotsV1RequestSortOrder? SortOrder
        // GraphQL -> sortOrder: V1QueryUnmanagedObjectSnapshotsV1RequestSortOrder (enum)
        [JsonProperty("sortOrder")]
        public V1QueryUnmanagedObjectSnapshotsV1RequestSortOrder? SortOrder { get; set; }


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

    } // class QueryUnmanagedObjectSnapshotsV1Input
    #endregion

} // namespace RubrikSecurityCloud.Types