// VappExportSnapshotJobConfigInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region VappExportSnapshotJobConfigInput

    public class VappExportSnapshotJobConfigInput: IInput
    {
        #region members

        //      C# -> CreateNewVappParamsInput? NewVappParams
        // GraphQL -> newVappParams: CreateNewVappParamsInput (input)
        [JsonProperty("newVappParams")]
        public CreateNewVappParamsInput? NewVappParams { get; set; }

        //      C# -> System.Boolean? ShouldPowerOnVappAfterExport
        // GraphQL -> shouldPowerOnVappAfterExport: Boolean (scalar)
        [JsonProperty("shouldPowerOnVappAfterExport")]
        public System.Boolean? ShouldPowerOnVappAfterExport { get; set; }

        //      C# -> System.String? TargetVappId
        // GraphQL -> targetVappId: String (scalar)
        [JsonProperty("targetVappId")]
        public System.String? TargetVappId { get; set; }

        //      C# -> VappExportMode? ExportMode
        // GraphQL -> exportMode: VappExportMode! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("exportMode")]
        public VappExportMode? ExportMode { get; set; }

        //      C# -> List<CreateVappNetworkParamsInput>? NetworksToRestore
        // GraphQL -> networksToRestore: [CreateVappNetworkParamsInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("networksToRestore")]
        public List<CreateVappNetworkParamsInput>? NetworksToRestore { get; set; }

        //      C# -> List<VappVmRestoreSpecInput>? VmsToExport
        // GraphQL -> vmsToExport: [VappVmRestoreSpecInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("vmsToExport")]
        public List<VappVmRestoreSpecInput>? VmsToExport { get; set; }


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

    } // class VappExportSnapshotJobConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types