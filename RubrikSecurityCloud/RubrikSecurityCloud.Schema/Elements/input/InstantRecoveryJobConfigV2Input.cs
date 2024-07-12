// InstantRecoveryJobConfigV2Input.cs
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
    #region InstantRecoveryJobConfigV2Input

    public class InstantRecoveryJobConfigV2Input: IInput
    {
        #region members

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.Boolean? PreserveMoid
        // GraphQL -> preserveMoid: Boolean (scalar)
        [JsonProperty("preserveMoid")]
        public System.Boolean? PreserveMoid { get; set; }

        //      C# -> System.Boolean? ShouldRecoverTags
        // GraphQL -> shouldRecoverTags: Boolean (scalar)
        [JsonProperty("shouldRecoverTags")]
        public System.Boolean? ShouldRecoverTags { get; set; }

        //      C# -> System.Int32? Vlan
        // GraphQL -> vlan: Int (scalar)
        [JsonProperty("vlan")]
        public System.Int32? Vlan { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? ResourcePoolId
        // GraphQL -> resourcePoolId: String (scalar)
        [JsonProperty("resourcePoolId")]
        public System.String? ResourcePoolId { get; set; }

        //      C# -> System.Boolean? ShouldMigrateImmediately
        // GraphQL -> shouldMigrateImmediately: Boolean (scalar)
        [JsonProperty("shouldMigrateImmediately")]
        public System.Boolean? ShouldMigrateImmediately { get; set; }

        //      C# -> RelocateMountConfigV2Input? MigrationConfig
        // GraphQL -> migrationConfig: RelocateMountConfigV2Input (input)
        [JsonProperty("migrationConfig")]
        public RelocateMountConfigV2Input? MigrationConfig { get; set; }

        //      C# -> MountExportSnapshotJobCommonOptionsV2Input? MountExportSnapshotJobCommonOptionsV2
        // GraphQL -> mountExportSnapshotJobCommonOptionsV2: MountExportSnapshotJobCommonOptionsV2Input (input)
        [JsonProperty("mountExportSnapshotJobCommonOptionsV2")]
        public MountExportSnapshotJobCommonOptionsV2Input? MountExportSnapshotJobCommonOptionsV2 { get; set; }

        //      C# -> RequiredRecoveryParametersInput? RequiredRecoveryParameters
        // GraphQL -> requiredRecoveryParameters: RequiredRecoveryParametersInput (input)
        [JsonProperty("requiredRecoveryParameters")]
        public RequiredRecoveryParametersInput? RequiredRecoveryParameters { get; set; }

        //      C# -> List<VmwareVnicBindingInfoV2Input>? VnicBindings
        // GraphQL -> vNicBindings: [VmwareVnicBindingInfoV2Input!] (input)
        [JsonProperty("vNicBindings")]
        public List<VmwareVnicBindingInfoV2Input>? VnicBindings { get; set; }


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

    } // class InstantRecoveryJobConfigV2Input
    #endregion

} // namespace RubrikSecurityCloud.Types