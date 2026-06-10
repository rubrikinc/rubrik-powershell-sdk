// SnapshotQualityFilter.cs
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
    #region SnapshotQualityFilter

    public class SnapshotQualityFilter: IInput
    {
        #region members

        //      C# -> System.Boolean? ExcludeQuarantined
        // GraphQL -> excludeQuarantined: Boolean (scalar)
        [JsonProperty("excludeQuarantined")]
        public System.Boolean? ExcludeQuarantined { get; set; }

        //      C# -> System.Boolean? ExcludeAnomalous
        // GraphQL -> excludeAnomalous: Boolean (scalar)
        [JsonProperty("excludeAnomalous")]
        public System.Boolean? ExcludeAnomalous { get; set; }

        //      C# -> System.Boolean? ExcludeNonIndexed
        // GraphQL -> excludeNonIndexed: Boolean (scalar)
        [JsonProperty("excludeNonIndexed")]
        public System.Boolean? ExcludeNonIndexed { get; set; }

        //      C# -> System.Boolean? QuarantinedOnly
        // GraphQL -> quarantinedOnly: Boolean (scalar)
        [JsonProperty("quarantinedOnly")]
        public System.Boolean? QuarantinedOnly { get; set; }

        //      C# -> System.Boolean? AnomalousOnly
        // GraphQL -> anomalousOnly: Boolean (scalar)
        [JsonProperty("anomalousOnly")]
        public System.Boolean? AnomalousOnly { get; set; }

        //      C# -> System.Boolean? ExcludeReplica
        // GraphQL -> excludeReplica: Boolean (scalar)
        [JsonProperty("excludeReplica")]
        public System.Boolean? ExcludeReplica { get; set; }

        //      C# -> List<System.String>? ExcludeArchivalLocationTypes
        // GraphQL -> excludeArchivalLocationTypes: [String!] (scalar)
        [JsonProperty("excludeArchivalLocationTypes")]
        public List<System.String>? ExcludeArchivalLocationTypes { get; set; }


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

    } // class SnapshotQualityFilter
    #endregion

} // namespace RubrikSecurityCloud.Types