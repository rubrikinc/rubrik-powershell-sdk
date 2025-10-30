// RcvBliMigrationFilter.cs
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
    #region RcvBliMigrationFilter

    public class RcvBliMigrationFilter: IInput
    {
        #region members

        //      C# -> List<BliMigrationStatus>? MigrationStatuses
        // GraphQL -> migrationStatuses: [BliMigrationStatus!] (enum)
        [JsonProperty("migrationStatuses")]
        public List<BliMigrationStatus>? MigrationStatuses { get; set; }

        //      C# -> List<System.String>? ClusterIds
        // GraphQL -> clusterIds: [String!] (scalar)
        [JsonProperty("clusterIds")]
        public List<System.String>? ClusterIds { get; set; }

        //      C# -> List<RcvTier>? Tiers
        // GraphQL -> tiers: [RcvTier!] (enum)
        [JsonProperty("tiers")]
        public List<RcvTier>? Tiers { get; set; }

        //      C# -> List<RcvRegionInput>? Regions
        // GraphQL -> regions: [RcvRegionInput!] (input)
        [JsonProperty("regions")]
        public List<RcvRegionInput>? Regions { get; set; }

        //      C# -> List<ArchivalLocationStatus>? LocationStatuses
        // GraphQL -> locationStatuses: [ArchivalLocationStatus!] (enum)
        [JsonProperty("locationStatuses")]
        public List<ArchivalLocationStatus>? LocationStatuses { get; set; }

        //      C# -> List<MigrationUnavailabilityReason>? UnavailabilityReasons
        // GraphQL -> unavailabilityReasons: [MigrationUnavailabilityReason!] (enum)
        [JsonProperty("unavailabilityReasons")]
        public List<MigrationUnavailabilityReason>? UnavailabilityReasons { get; set; }


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

    } // class RcvBliMigrationFilter
    #endregion

} // namespace RubrikSecurityCloud.Types