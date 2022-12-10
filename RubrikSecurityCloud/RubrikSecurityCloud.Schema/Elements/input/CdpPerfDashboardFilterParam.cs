// CdpPerfDashboardFilterParam.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:08.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region CdpPerfDashboardFilterParam

    public class CdpPerfDashboardFilterParam
    {
        #region members
        //      C# -> CdpPerfDashboardFilterField? FilterField
        // GraphQL -> filterField: CdpPerfDashboardFilterField (enum)
        [JsonProperty("filterField")]
        public CdpPerfDashboardFilterField? FilterField { get; set; }

        //      C# -> List<System.String>? SourceClusterUuids
        // GraphQL -> sourceClusterUuids: [String!] (scalar)
        [JsonProperty("sourceClusterUuids")]
        public List<System.String>? SourceClusterUuids { get; set; }

        //      C# -> List<System.String>? SlaDomainIds
        // GraphQL -> slaDomainIds: [String!] (scalar)
        [JsonProperty("slaDomainIds")]
        public List<System.String>? SlaDomainIds { get; set; }

        //      C# -> List<CdpLocalStatus>? LocalStatus
        // GraphQL -> localStatus: [CdpLocalStatus!] (enum)
        [JsonProperty("localStatus")]
        public List<CdpLocalStatus>? LocalStatus { get; set; }

        //      C# -> List<CdpReplicationStatus>? ReplicationStatus
        // GraphQL -> replicationStatus: [CdpReplicationStatus!] (enum)
        [JsonProperty("replicationStatus")]
        public List<CdpReplicationStatus>? ReplicationStatus { get; set; }

        //      C# -> List<IoFilterStatus>? CdpIoFilterStatus
        // GraphQL -> cdpIoFilterStatus: [IoFilterStatus!] (enum)
        [JsonProperty("cdpIoFilterStatus")]
        public List<IoFilterStatus>? CdpIoFilterStatus { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

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

    } // class CdpPerfDashboardFilterParam
    #endregion

} // namespace Rubrik.SecurityCloud.Types