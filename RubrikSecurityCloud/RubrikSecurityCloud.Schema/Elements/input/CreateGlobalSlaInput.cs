// CreateGlobalSlaInput.cs
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
    #region CreateGlobalSlaInput

    public class CreateGlobalSlaInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> GlobalSnapshotScheduleInput? SnapshotSchedule
        // GraphQL -> snapshotSchedule: GlobalSnapshotScheduleInput (input)
        [JsonProperty("snapshotSchedule")]
        public GlobalSnapshotScheduleInput? SnapshotSchedule { get; set; }

        //      C# -> ReplicationSpecInput? ReplicationSpecInput
        // GraphQL -> replicationSpecInput: ReplicationSpecInput (input)
        [JsonProperty("replicationSpecInput")]
        public ReplicationSpecInput? ReplicationSpecInput { get; set; }

        //      C# -> SlaDurationInput? LocalRetentionLimit
        // GraphQL -> localRetentionLimit: SlaDurationInput (input)
        [JsonProperty("localRetentionLimit")]
        public SlaDurationInput? LocalRetentionLimit { get; set; }

        //      C# -> List<BackupWindowInput>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindowInput!] (input)
        [JsonProperty("firstFullBackupWindows")]
        public List<BackupWindowInput>? FirstFullBackupWindows { get; set; }

        //      C# -> List<BackupWindowInput>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindowInput!] (input)
        [JsonProperty("backupWindows")]
        public List<BackupWindowInput>? BackupWindows { get; set; }

        //      C# -> LogConfig? LogConfig
        // GraphQL -> logConfig: LogConfig (input)
        [JsonProperty("logConfig")]
        public LogConfig? LogConfig { get; set; }

        //      C# -> ObjectSpecificConfigsInput? ObjectSpecificConfigsInput
        // GraphQL -> objectSpecificConfigsInput: ObjectSpecificConfigsInput (input)
        [JsonProperty("objectSpecificConfigsInput")]
        public ObjectSpecificConfigsInput? ObjectSpecificConfigsInput { get; set; }

        //      C# -> List<ArchivalSpecInput>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ArchivalSpecInput!] (input)
        [JsonProperty("archivalSpecs")]
        public List<ArchivalSpecInput>? ArchivalSpecs { get; set; }

        //      C# -> List<ReplicationSpecV2Input>? ReplicationSpecsV2
        // GraphQL -> replicationSpecsV2: [ReplicationSpecV2Input!] (input)
        [JsonProperty("replicationSpecsV2")]
        public List<ReplicationSpecV2Input>? ReplicationSpecsV2 { get; set; }

        //      C# -> List<SlaObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [SlaObjectType!] (enum)
        [JsonProperty("objectTypes")]
        public List<SlaObjectType>? ObjectTypes { get; set; }

        //      C# -> System.Boolean? IsRetentionLockedSla
        // GraphQL -> isRetentionLockedSla: Boolean (scalar)
        [JsonProperty("isRetentionLockedSla")]
        public System.Boolean? IsRetentionLockedSla { get; set; }


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

    } // class CreateGlobalSlaInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types