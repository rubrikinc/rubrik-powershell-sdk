// RecoverCloudNativeApplicationInput.cs
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
    #region RecoverCloudNativeApplicationInput

    public class RecoverCloudNativeApplicationInput: IInput
    {
        #region members

        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("applicationId")]
        public System.String? ApplicationId { get; set; }

        //      C# -> System.String? TargetCloudNativeAccountId
        // GraphQL -> targetCloudNativeAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetCloudNativeAccountId")]
        public System.String? TargetCloudNativeAccountId { get; set; }

        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryName")]
        public System.String? RecoveryName { get; set; }

        //      C# -> RecoveryErrorHandling? ErrorHandling
        // GraphQL -> errorHandling: RecoveryErrorHandling! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("errorHandling")]
        public RecoveryErrorHandling? ErrorHandling { get; set; }

        //      C# -> List<WorkloadSnapshotInput>? WorkloadSnapshots
        // GraphQL -> workloadSnapshots: [WorkloadSnapshotInput!] (input)
        [JsonProperty("workloadSnapshots")]
        public List<WorkloadSnapshotInput>? WorkloadSnapshots { get; set; }

        //      C# -> RecoveryHookInput? PreRecoveryHook
        // GraphQL -> preRecoveryHook: RecoveryHookInput (input)
        [JsonProperty("preRecoveryHook")]
        public RecoveryHookInput? PreRecoveryHook { get; set; }

        //      C# -> RecoveryHookInput? PostRecoveryHook
        // GraphQL -> postRecoveryHook: RecoveryHookInput (input)
        [JsonProperty("postRecoveryHook")]
        public RecoveryHookInput? PostRecoveryHook { get; set; }

        //      C# -> System.Boolean? VmPostRecoveryScriptEnabled
        // GraphQL -> vmPostRecoveryScriptEnabled: Boolean (scalar)
        [JsonProperty("vmPostRecoveryScriptEnabled")]
        public System.Boolean? VmPostRecoveryScriptEnabled { get; set; }

        //      C# -> CloudSettingsInput? CloudSettings
        // GraphQL -> cloudSettings: CloudSettingsInput (input)
        [JsonProperty("cloudSettings")]
        public CloudSettingsInput? CloudSettings { get; set; }


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

    } // class RecoverCloudNativeApplicationInput
    #endregion

} // namespace RubrikSecurityCloud.Types