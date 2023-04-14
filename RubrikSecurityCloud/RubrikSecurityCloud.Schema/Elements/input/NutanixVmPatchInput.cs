// NutanixVmPatchInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region NutanixVmPatchInput

    public class NutanixVmPatchInput: IInput
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> List<System.String>? ExcludedDiskIds
        // GraphQL -> excludedDiskIds: [String!] (scalar)
        [JsonProperty("excludedDiskIds")]
        public List<System.String>? ExcludedDiskIds { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }

        //      C# -> NutanixVirtualMachineScriptDetailInput? PostBackupScript
        // GraphQL -> postBackupScript: NutanixVirtualMachineScriptDetailInput (input)
        [JsonProperty("postBackupScript")]
        public NutanixVirtualMachineScriptDetailInput? PostBackupScript { get; set; }

        //      C# -> NutanixVirtualMachineScriptDetailInput? PostSnapScript
        // GraphQL -> postSnapScript: NutanixVirtualMachineScriptDetailInput (input)
        [JsonProperty("postSnapScript")]
        public NutanixVirtualMachineScriptDetailInput? PostSnapScript { get; set; }

        //      C# -> NutanixVirtualMachineScriptDetailInput? PreBackupScript
        // GraphQL -> preBackupScript: NutanixVirtualMachineScriptDetailInput (input)
        [JsonProperty("preBackupScript")]
        public NutanixVirtualMachineScriptDetailInput? PreBackupScript { get; set; }

        //      C# -> CdmNutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate (enum)
        [JsonProperty("snapshotConsistencyMandate")]
        public CdmNutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate { get; set; }


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

    } // class NutanixVmPatchInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types