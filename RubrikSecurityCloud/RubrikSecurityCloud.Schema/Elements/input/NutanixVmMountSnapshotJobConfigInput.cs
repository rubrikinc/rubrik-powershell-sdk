// NutanixVmMountSnapshotJobConfigInput.cs
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
    #region NutanixVmMountSnapshotJobConfigInput

    public class NutanixVmMountSnapshotJobConfigInput: IInput
    {
        #region members

        //      C# -> System.String? ContainerNaturalId
        // GraphQL -> containerNaturalId: String (scalar)
        [JsonProperty("containerNaturalId")]
        public System.String? ContainerNaturalId { get; set; }

        //      C# -> System.String? NutanixClusterId
        // GraphQL -> nutanixClusterId: String (scalar)
        [JsonProperty("nutanixClusterId")]
        public System.String? NutanixClusterId { get; set; }

        //      C# -> System.Boolean? ShouldDisableMigration
        // GraphQL -> shouldDisableMigration: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldDisableMigration")]
        public System.Boolean? ShouldDisableMigration { get; set; }

        //      C# -> System.Boolean? ShouldMigrateImmediately
        // GraphQL -> shouldMigrateImmediately: Boolean (scalar)
        [JsonProperty("shouldMigrateImmediately")]
        public System.Boolean? ShouldMigrateImmediately { get; set; }

        //      C# -> System.Boolean? ShouldPowerOn
        // GraphQL -> shouldPowerOn: Boolean (scalar)
        [JsonProperty("shouldPowerOn")]
        public System.Boolean? ShouldPowerOn { get; set; }

        //      C# -> System.Boolean? ShouldRemoveNetwork
        // GraphQL -> shouldRemoveNetwork: Boolean (scalar)
        [JsonProperty("shouldRemoveNetwork")]
        public System.Boolean? ShouldRemoveNetwork { get; set; }

        //      C# -> System.String? TargetNetwork
        // GraphQL -> targetNetwork: String (scalar)
        [JsonProperty("targetNetwork")]
        public System.String? TargetNetwork { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> System.Boolean? KeepMacAddresses
        // GraphQL -> keepMacAddresses: Boolean (scalar)
        [JsonProperty("keepMacAddresses")]
        public System.Boolean? KeepMacAddresses { get; set; }

        //      C# -> List<System.String>? NicNetworkUuids
        // GraphQL -> nicNetworkUuids: [String!] (scalar)
        [JsonProperty("nicNetworkUuids")]
        public List<System.String>? NicNetworkUuids { get; set; }


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

    } // class NutanixVmMountSnapshotJobConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types