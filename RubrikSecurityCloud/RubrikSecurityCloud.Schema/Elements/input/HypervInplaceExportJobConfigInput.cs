// HypervInplaceExportJobConfigInput.cs
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
    #region HypervInplaceExportJobConfigInput

    public class HypervInplaceExportJobConfigInput: IInput
    {
        #region members

        //      C# -> System.String? ExportVmPath
        // GraphQL -> exportVmPath: String (scalar)
        [JsonProperty("exportVmPath")]
        public System.String? ExportVmPath { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.Boolean? ShouldKeepHypervSnapshotAfterRecovery
        // GraphQL -> shouldKeepHypervSnapshotAfterRecovery: Boolean (scalar)
        [JsonProperty("shouldKeepHypervSnapshotAfterRecovery")]
        public System.Boolean? ShouldKeepHypervSnapshotAfterRecovery { get; set; }

        //      C# -> System.Boolean? ShouldKeepHypervVmCopyAfterRecovery
        // GraphQL -> shouldKeepHypervVmCopyAfterRecovery: Boolean (scalar)
        [JsonProperty("shouldKeepHypervVmCopyAfterRecovery")]
        public System.Boolean? ShouldKeepHypervVmCopyAfterRecovery { get; set; }


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

    } // class HypervInplaceExportJobConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types