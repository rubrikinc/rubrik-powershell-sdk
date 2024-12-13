// StartRestoreAzureNativeVirtualMachineJobInput.cs
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
    #region StartRestoreAzureNativeVirtualMachineJobInput

    public class StartRestoreAzureNativeVirtualMachineJobInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Boolean? ShouldPowerOn
        // GraphQL -> shouldPowerOn: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldPowerOn")]
        public System.Boolean? ShouldPowerOn { get; set; }

        //      C# -> System.Boolean? ShouldRestoreTags
        // GraphQL -> shouldRestoreTags: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldRestoreTags")]
        public System.Boolean? ShouldRestoreTags { get; set; }

        //      C# -> SnapshotTypeForRestoreIfSourceExpired? SnapshotTypeToUseIfSourceExpired
        // GraphQL -> snapshotTypeToUseIfSourceExpired: SnapshotTypeForRestoreIfSourceExpired (enum)
        [JsonProperty("snapshotTypeToUseIfSourceExpired")]
        public SnapshotTypeForRestoreIfSourceExpired? SnapshotTypeToUseIfSourceExpired { get; set; }

        //      C# -> List<System.String>? RecoveryDiskIds
        // GraphQL -> recoveryDiskIds: [UUID!] (scalar)
        [JsonProperty("recoveryDiskIds")]
        public List<System.String>? RecoveryDiskIds { get; set; }

        //      C# -> System.String? ArchivedSnapshotId
        // GraphQL -> archivedSnapshotId: UUID (scalar)
        [JsonProperty("archivedSnapshotId")]
        public System.String? ArchivedSnapshotId { get; set; }


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

    } // class StartRestoreAzureNativeVirtualMachineJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types