// ActivitySeriesFilter.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ActivitySeriesFilter

    public class ActivitySeriesFilter: IInput
    {
        #region members

        //      C# -> List<EventStatus>? LastActivityStatus
        // GraphQL -> lastActivityStatus: [EventStatus!] (enum)
        [JsonProperty("lastActivityStatus")]
        public List<EventStatus>? LastActivityStatus { get; set; }

        //      C# -> List<EventType>? LastActivityType
        // GraphQL -> lastActivityType: [EventType!] (enum)
        [JsonProperty("lastActivityType")]
        public List<EventType>? LastActivityType { get; set; }

        //      C# -> List<EventSeverity>? Severity
        // GraphQL -> severity: [EventSeverity!] (enum)
        [JsonProperty("severity")]
        public List<EventSeverity>? Severity { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> List<EventObjectType>? ObjectType
        // GraphQL -> objectType: [EventObjectType!] (enum)
        [JsonProperty("objectType")]
        public List<EventObjectType>? ObjectType { get; set; }

        //      C# -> DateTime? StartTimeGt
        // GraphQL -> startTimeGt: DateTime (scalar)
        [JsonProperty("startTimeGt")]
        public DateTime? StartTimeGt { get; set; }

        //      C# -> DateTime? StartTimeLt
        // GraphQL -> startTimeLt: DateTime (scalar)
        [JsonProperty("startTimeLt")]
        public DateTime? StartTimeLt { get; set; }

        //      C# -> DateTime? LastUpdatedTimeGt
        // GraphQL -> lastUpdatedTimeGt: DateTime (scalar)
        [JsonProperty("lastUpdatedTimeGt")]
        public DateTime? LastUpdatedTimeGt { get; set; }

        //      C# -> DateTime? LastUpdatedTimeLt
        // GraphQL -> lastUpdatedTimeLt: DateTime (scalar)
        [JsonProperty("lastUpdatedTimeLt")]
        public DateTime? LastUpdatedTimeLt { get; set; }

        //      C# -> List<System.String>? ClusterId
        // GraphQL -> clusterId: [UUID!] (scalar)
        [JsonProperty("clusterId")]
        public List<System.String>? ClusterId { get; set; }

        //      C# -> List<EventClusterType>? ClusterType
        // GraphQL -> clusterType: [EventClusterType!] (enum)
        [JsonProperty("clusterType")]
        public List<EventClusterType>? ClusterType { get; set; }

        //      C# -> List<System.String>? ObjectFid
        // GraphQL -> objectFid: [UUID!] (scalar)
        [JsonProperty("objectFid")]
        public List<System.String>? ObjectFid { get; set; }

        //      C# -> System.String? AncestorId
        // GraphQL -> ancestorId: UUID (scalar)
        [JsonProperty("ancestorId")]
        public System.String? AncestorId { get; set; }

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }

        //      C# -> List<System.String>? OrgIds
        // GraphQL -> orgIds: [String!] (scalar)
        [JsonProperty("orgIds")]
        public List<System.String>? OrgIds { get; set; }


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

    } // class ActivitySeriesFilter
    #endregion

} // namespace Rubrik.SecurityCloud.Types