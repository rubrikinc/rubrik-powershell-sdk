// ReplicationPairsQueryFilter.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:23.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ReplicationPairsQueryFilter

    public class ReplicationPairsQueryFilter
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

} // namespace Rubrik.SecurityCloud.Types