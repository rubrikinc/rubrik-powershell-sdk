// TaskDetailFilterInput.cs
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
    #region TaskDetailFilterInput

    public class TaskDetailFilterInput: IInput
    {
        #region members

        //      C# -> List<System.String>? ClusterUuid
        // GraphQL -> clusterUuid: [UUID!] (scalar)
        [JsonProperty("clusterUuid")]
        public List<System.String>? ClusterUuid { get; set; }

        //      C# -> List<System.String>? ClusterType
        // GraphQL -> clusterType: [String!] (scalar)
        [JsonProperty("clusterType")]
        public List<System.String>? ClusterType { get; set; }

        //      C# -> List<System.String>? ClusterLocation
        // GraphQL -> clusterLocation: [String!] (scalar)
        [JsonProperty("clusterLocation")]
        public List<System.String>? ClusterLocation { get; set; }

        //      C# -> List<System.String>? ObjectType
        // GraphQL -> objectType: [String!] (scalar)
        [JsonProperty("objectType")]
        public List<System.String>? ObjectType { get; set; }

        //      C# -> SnappableSlaDomainFilterInput? SlaDomain
        // GraphQL -> slaDomain: SnappableSlaDomainFilterInput (input)
        [JsonProperty("slaDomain")]
        public SnappableSlaDomainFilterInput? SlaDomain { get; set; }

        //      C# -> List<System.String>? ReplicationSource
        // GraphQL -> replicationSource: [String!] (scalar)
        [JsonProperty("replicationSource")]
        public List<System.String>? ReplicationSource { get; set; }

        //      C# -> List<System.String>? TaskCategory
        // GraphQL -> taskCategory: [String!] (scalar)
        [JsonProperty("taskCategory")]
        public List<System.String>? TaskCategory { get; set; }

        //      C# -> List<System.String>? TaskStatus
        // GraphQL -> taskStatus: [String!] (scalar)
        [JsonProperty("taskStatus")]
        public List<System.String>? TaskStatus { get; set; }

        //      C# -> List<System.String>? TaskType
        // GraphQL -> taskType: [String!] (scalar)
        [JsonProperty("taskType")]
        public List<System.String>? TaskType { get; set; }

        //      C# -> DateTime? TimeGt
        // GraphQL -> time_gt: DateTime (scalar)
        [JsonProperty("time_gt")]
        public DateTime? TimeGt { get; set; }

        //      C# -> DateTime? TimeLt
        // GraphQL -> time_lt: DateTime (scalar)
        [JsonProperty("time_lt")]
        public DateTime? TimeLt { get; set; }

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }

        //      C# -> List<System.String>? OrgId
        // GraphQL -> orgId: [String!] (scalar)
        [JsonProperty("orgId")]
        public List<System.String>? OrgId { get; set; }


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

    } // class TaskDetailFilterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types