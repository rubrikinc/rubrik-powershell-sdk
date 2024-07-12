// VirtualMachineUpdateInput.cs
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
    #region VirtualMachineUpdateInput

    public class VirtualMachineUpdateInput: IInput
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.Boolean? IsArrayIntegrationEnabled
        // GraphQL -> isArrayIntegrationEnabled: Boolean (scalar)
        [JsonProperty("isArrayIntegrationEnabled")]
        public System.Boolean? IsArrayIntegrationEnabled { get; set; }

        //      C# -> System.Boolean? IsVmPaused
        // GraphQL -> isVmPaused: Boolean (scalar)
        [JsonProperty("isVmPaused")]
        public System.Boolean? IsVmPaused { get; set; }

        //      C# -> System.Int32? MaxNestedVsphereSnapshots
        // GraphQL -> maxNestedVsphereSnapshots: Int (scalar)
        [JsonProperty("maxNestedVsphereSnapshots")]
        public System.Int32? MaxNestedVsphereSnapshots { get; set; }

        //      C# -> VirtualMachineUpdateSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: VirtualMachineUpdateSnapshotConsistencyMandate (enum)
        [JsonProperty("snapshotConsistencyMandate")]
        public VirtualMachineUpdateSnapshotConsistencyMandate? SnapshotConsistencyMandate { get; set; }

        //      C# -> CloudInstantiationSpecInput? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpecInput (input)
        [JsonProperty("cloudInstantiationSpec")]
        public CloudInstantiationSpecInput? CloudInstantiationSpec { get; set; }

        //      C# -> VirtualMachineScriptDetailInput? PostBackupScript
        // GraphQL -> postBackupScript: VirtualMachineScriptDetailInput (input)
        [JsonProperty("postBackupScript")]
        public VirtualMachineScriptDetailInput? PostBackupScript { get; set; }

        //      C# -> VirtualMachineScriptDetailInput? PostSnapScript
        // GraphQL -> postSnapScript: VirtualMachineScriptDetailInput (input)
        [JsonProperty("postSnapScript")]
        public VirtualMachineScriptDetailInput? PostSnapScript { get; set; }

        //      C# -> VirtualMachineScriptDetailInput? PreBackupScript
        // GraphQL -> preBackupScript: VirtualMachineScriptDetailInput (input)
        [JsonProperty("preBackupScript")]
        public VirtualMachineScriptDetailInput? PreBackupScript { get; set; }

        //      C# -> VmwareAdaptiveThrottlingSettingsInput? ThrottlingSettings
        // GraphQL -> throttlingSettings: VmwareAdaptiveThrottlingSettingsInput (input)
        [JsonProperty("throttlingSettings")]
        public VmwareAdaptiveThrottlingSettingsInput? ThrottlingSettings { get; set; }


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

    } // class VirtualMachineUpdateInput
    #endregion

} // namespace RubrikSecurityCloud.Types