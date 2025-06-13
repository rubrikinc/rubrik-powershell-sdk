// ReplicationPairsQueryFilter.cs
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
    #region ReplicationPairsQueryFilter

    public class ReplicationPairsQueryFilter: IInput
    {
        #region members

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> List<System.String>? SourceClusterUuids
        // GraphQL -> sourceClusterUuids: [String!] (scalar)
        [JsonProperty("sourceClusterUuids")]
        public List<System.String>? SourceClusterUuids { get; set; }

        //      C# -> List<System.String>? TargetClusterUuids
        // GraphQL -> targetClusterUuids: [String!] (scalar)
        [JsonProperty("targetClusterUuids")]
        public List<System.String>? TargetClusterUuids { get; set; }

        //      C# -> List<ReplicationPairConnectionStatus>? Status
        // GraphQL -> status: [ReplicationPairConnectionStatus!] (enum)
        [JsonProperty("status")]
        public List<ReplicationPairConnectionStatus>? Status { get; set; }

        //      C# -> List<ReplicationBidirectionalConnectionStatus>? BidirectionalStatus
        // GraphQL -> bidirectionalStatus: [ReplicationBidirectionalConnectionStatus!] (enum)
        [JsonProperty("bidirectionalStatus")]
        public List<ReplicationBidirectionalConnectionStatus>? BidirectionalStatus { get; set; }

        //      C# -> List<ReplicationPairPauseStatus>? PauseStatus
        // GraphQL -> pauseStatus: [ReplicationPairPauseStatus!] (enum)
        [JsonProperty("pauseStatus")]
        public List<ReplicationPairPauseStatus>? PauseStatus { get; set; }

        //      C# -> List<ConnectionStatusType>? SourceAndTargetConnectionStatuses
        // GraphQL -> sourceAndTargetConnectionStatuses: [ConnectionStatusType!] (enum)
        [JsonProperty("sourceAndTargetConnectionStatuses")]
        public List<ConnectionStatusType>? SourceAndTargetConnectionStatuses { get; set; }

        //      C# -> List<ConnectionStatusType>? TargetAndSourceConnectionStatuses
        // GraphQL -> targetAndSourceConnectionStatuses: [ConnectionStatusType!] (enum)
        [JsonProperty("targetAndSourceConnectionStatuses")]
        public List<ConnectionStatusType>? TargetAndSourceConnectionStatuses { get; set; }


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

    } // class ReplicationPairsQueryFilter
    #endregion

} // namespace RubrikSecurityCloud.Types