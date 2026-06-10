// HypervInstantRecoveryJobConfigInput.cs
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
    #region HypervInstantRecoveryJobConfigInput

    public class HypervInstantRecoveryJobConfigInput: IInput
    {
        #region members

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> System.Boolean? RemoveNetworkDevices
        // GraphQL -> removeNetworkDevices: Boolean (scalar)
        [JsonProperty("removeNetworkDevices")]
        public System.Boolean? RemoveNetworkDevices { get; set; }

        //      C# -> System.Boolean? ShouldMigrateDataStore
        // GraphQL -> shouldMigrateDataStore: Boolean (scalar)
        [JsonProperty("shouldMigrateDataStore")]
        public System.Boolean? ShouldMigrateDataStore { get; set; }

        //      C# -> System.Boolean? KeepMacAddress
        // GraphQL -> keepMacAddress: Boolean (scalar)
        [JsonProperty("keepMacAddress")]
        public System.Boolean? KeepMacAddress { get; set; }

        //      C# -> List<HypervVirtualSwitchMappingInput>? VirtualSwitchMappings
        // GraphQL -> virtualSwitchMappings: [HypervVirtualSwitchMappingInput!] (input)
        [JsonProperty("virtualSwitchMappings")]
        public List<HypervVirtualSwitchMappingInput>? VirtualSwitchMappings { get; set; }

        //      C# -> System.String? DestinationFolder
        // GraphQL -> destinationFolder: String (scalar)
        [JsonProperty("destinationFolder")]
        public System.String? DestinationFolder { get; set; }


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

    } // class HypervInstantRecoveryJobConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types