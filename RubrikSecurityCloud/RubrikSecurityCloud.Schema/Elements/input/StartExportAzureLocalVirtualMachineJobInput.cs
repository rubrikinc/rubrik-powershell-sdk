// StartExportAzureLocalVirtualMachineJobInput.cs
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
    #region StartExportAzureLocalVirtualMachineJobInput

    public class StartExportAzureLocalVirtualMachineJobInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? HypervClusterId
        // GraphQL -> hypervClusterId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hypervClusterId")]
        public System.String? HypervClusterId { get; set; }

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> System.Int32? Processors
        // GraphQL -> processors: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("processors")]
        public System.Int32? Processors { get; set; }

        //      C# -> System.Int64? MemoryMb
        // GraphQL -> memoryMb: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("memoryMb")]
        public System.Int64? MemoryMb { get; set; }

        //      C# -> System.Boolean? ShouldRemoveAllNetworkDevices
        // GraphQL -> shouldRemoveAllNetworkDevices: Boolean (scalar)
        [JsonProperty("shouldRemoveAllNetworkDevices")]
        public System.Boolean? ShouldRemoveAllNetworkDevices { get; set; }

        //      C# -> List<AzureLocalNicConfigInput>? NicConfigs
        // GraphQL -> nicConfigs: [AzureLocalNicConfigInput!] (input)
        [JsonProperty("nicConfigs")]
        public List<AzureLocalNicConfigInput>? NicConfigs { get; set; }


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

    } // class StartExportAzureLocalVirtualMachineJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types