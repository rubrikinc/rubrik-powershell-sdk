// MountSnapshotJobConfigV2Input.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:41.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region MountSnapshotJobConfigV2Input

    public class MountSnapshotJobConfigV2Input
    {
        #region members
        //      C# -> System.Boolean? CreateDatastoreOnly
        // GraphQL -> createDatastoreOnly: Boolean (scalar)
        [JsonProperty("createDatastoreOnly")]
        public System.Boolean? CreateDatastoreOnly { get; set; }

        //      C# -> System.String? DataStoreName
        // GraphQL -> dataStoreName: String (scalar)
        [JsonProperty("dataStoreName")]
        public System.String? DataStoreName { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

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

        //      C# -> List<VmwareVnicBindingInfoV2Input>? VnicBindings
        // GraphQL -> vNicBindings: [VmwareVnicBindingInfoV2Input!] (input)
        [JsonProperty("vNicBindings")]
        public List<VmwareVnicBindingInfoV2Input>? VnicBindings { get; set; }

        //      C# -> RelocateMountConfigV2Input? MigrationConfig
        // GraphQL -> migrationConfig: RelocateMountConfigV2Input (input)
        [JsonProperty("migrationConfig")]
        public RelocateMountConfigV2Input? MigrationConfig { get; set; }

        //      C# -> System.Boolean? ShouldMigrateImmediately
        // GraphQL -> shouldMigrateImmediately: Boolean (scalar)
        [JsonProperty("shouldMigrateImmediately")]
        public System.Boolean? ShouldMigrateImmediately { get; set; }

        //      C# -> MountExportSnapshotJobCommonOptionsV2Input? MountExportSnapshotJobCommonOptionsV2
        // GraphQL -> mountExportSnapshotJobCommonOptionsV2: MountExportSnapshotJobCommonOptionsV2Input (input)
        [JsonProperty("mountExportSnapshotJobCommonOptionsV2")]
        public MountExportSnapshotJobCommonOptionsV2Input? MountExportSnapshotJobCommonOptionsV2 { get; set; }

        //      C# -> RequiredRecoveryParametersInput? RequiredRecoveryParameters
        // GraphQL -> requiredRecoveryParameters: RequiredRecoveryParametersInput (input)
        [JsonProperty("requiredRecoveryParameters")]
        public RequiredRecoveryParametersInput? RequiredRecoveryParameters { get; set; }

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

    } // class MountSnapshotJobConfigV2Input
    #endregion

} // namespace Rubrik.SecurityCloud.Types