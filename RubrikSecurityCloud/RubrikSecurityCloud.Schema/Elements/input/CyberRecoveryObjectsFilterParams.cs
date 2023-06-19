// CyberRecoveryObjectsFilterParams.cs
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
    #region CyberRecoveryObjectsFilterParams

    public class CyberRecoveryObjectsFilterParams: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<ManagedObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [ManagedObjectType!] (enum)
        [JsonProperty("objectTypes")]
        public List<ManagedObjectType>? ObjectTypes { get; set; }

        //      C# -> List<System.String>? RecoveryPlanNames
        // GraphQL -> recoveryPlanNames: [String!] (scalar)
        [JsonProperty("recoveryPlanNames")]
        public List<System.String>? RecoveryPlanNames { get; set; }

        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [String!] (scalar)
        [JsonProperty("clusterUuids")]
        public List<System.String>? ClusterUuids { get; set; }

        //      C# -> List<System.String>? RetentionSlaDomainIds
        // GraphQL -> retentionSlaDomainIds: [String!] (scalar)
        [JsonProperty("retentionSlaDomainIds")]
        public List<System.String>? RetentionSlaDomainIds { get; set; }

        //      C# -> List<WorkloadLastFailoverStatus>? Statuses
        // GraphQL -> statuses: [WorkloadLastFailoverStatus!] (enum)
        [JsonProperty("statuses")]
        public List<WorkloadLastFailoverStatus>? Statuses { get; set; }


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

    } // class CyberRecoveryObjectsFilterParams
    #endregion

} // namespace RubrikSecurityCloud.Types