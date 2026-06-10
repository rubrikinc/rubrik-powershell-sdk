// FusionComputeMountVmConfigInput.cs
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
    #region FusionComputeMountVmConfigInput

    public class FusionComputeMountVmConfigInput: IInput
    {
        #region members

        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: UUID (scalar)
        [JsonProperty("targetHostId")]
        public System.String? TargetHostId { get; set; }

        //      C# -> System.Boolean? ShouldRecoverTags
        // GraphQL -> shouldRecoverTags: Boolean (scalar)
        [JsonProperty("shouldRecoverTags")]
        public System.Boolean? ShouldRecoverTags { get; set; }

        //      C# -> System.Boolean? ShouldRemoveNetworkDevices
        // GraphQL -> shouldRemoveNetworkDevices: Boolean (scalar)
        [JsonProperty("shouldRemoveNetworkDevices")]
        public System.Boolean? ShouldRemoveNetworkDevices { get; set; }

        //      C# -> FusionComputeDatastoreMigrationConfigInput? MigrationConfig
        // GraphQL -> migrationConfig: FusionComputeDatastoreMigrationConfigInput (input)
        [JsonProperty("migrationConfig")]
        public FusionComputeDatastoreMigrationConfigInput? MigrationConfig { get; set; }

        //      C# -> System.String? NewVmName
        // GraphQL -> newVmName: String (scalar)
        [JsonProperty("newVmName")]
        public System.String? NewVmName { get; set; }

        //      C# -> System.String? TargetClusterId
        // GraphQL -> targetClusterId: UUID (scalar)
        [JsonProperty("targetClusterId")]
        public System.String? TargetClusterId { get; set; }

        //      C# -> System.Boolean? ShouldMigrateImmediately
        // GraphQL -> shouldMigrateImmediately: Boolean (scalar)
        [JsonProperty("shouldMigrateImmediately")]
        public System.Boolean? ShouldMigrateImmediately { get; set; }

        //      C# -> System.Boolean? ShouldPowerOn
        // GraphQL -> shouldPowerOn: Boolean (scalar)
        [JsonProperty("shouldPowerOn")]
        public System.Boolean? ShouldPowerOn { get; set; }

        //      C# -> System.Boolean? ShouldKeepMacAddresses
        // GraphQL -> shouldKeepMacAddresses: Boolean (scalar)
        [JsonProperty("shouldKeepMacAddresses")]
        public System.Boolean? ShouldKeepMacAddresses { get; set; }

        //      C# -> System.Int64? UnmountTimeOpt
        // GraphQL -> unmountTimeOpt: Long (scalar)
        [JsonProperty("unmountTimeOpt")]
        public System.Int64? UnmountTimeOpt { get; set; }

        //      C# -> System.Boolean? ShouldDisableNetwork
        // GraphQL -> shouldDisableNetwork: Boolean (scalar)
        [JsonProperty("shouldDisableNetwork")]
        public System.Boolean? ShouldDisableNetwork { get; set; }

        //      C# -> List<FusionComputeNetworkToNicInput>? NetworkToNicMap
        // GraphQL -> networkToNicMap: [FusionComputeNetworkToNicInput!] (input)
        [JsonProperty("networkToNicMap")]
        public List<FusionComputeNetworkToNicInput>? NetworkToNicMap { get; set; }


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

    } // class FusionComputeMountVmConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types