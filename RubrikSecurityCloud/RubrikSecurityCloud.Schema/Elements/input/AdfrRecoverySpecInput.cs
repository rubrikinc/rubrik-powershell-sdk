// AdfrRecoverySpecInput.cs
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
    #region AdfrRecoverySpecInput

    public class AdfrRecoverySpecInput: IInput
    {
        #region members

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> System.String? HostWorkloadFid
        // GraphQL -> hostWorkloadFid: UUID (scalar)
        [JsonProperty("hostWorkloadFid")]
        public System.String? HostWorkloadFid { get; set; }

        //      C# -> System.String? HostSnapshotFid
        // GraphQL -> hostSnapshotFid: UUID (scalar)
        [JsonProperty("hostSnapshotFid")]
        public System.String? HostSnapshotFid { get; set; }

        //      C# -> System.Int64? HostRecoveryPoint
        // GraphQL -> hostRecoveryPoint: Long (scalar)
        [JsonProperty("hostRecoveryPoint")]
        public System.Int64? HostRecoveryPoint { get; set; }

        //      C# -> AddcRecoverySpecInput? Addc
        // GraphQL -> addc: AddcRecoverySpecInput (input)
        [JsonProperty("addc")]
        public AddcRecoverySpecInput? Addc { get; set; }

        //      C# -> System.Int32? RecoveryVlanId
        // GraphQL -> recoveryVlanId: Int (scalar)
        [JsonProperty("recoveryVlanId")]
        public System.Int32? RecoveryVlanId { get; set; }

        //      C# -> AdfrHostSpecInput? HostSpec
        // GraphQL -> hostSpec: AdfrHostSpecInput (input)
        [JsonProperty("hostSpec")]
        public AdfrHostSpecInput? HostSpec { get; set; }


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

    } // class AdfrRecoverySpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types