// StartRestoreAwsNativeEc2InstanceSnapshotJobInput.cs
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
    #region StartRestoreAwsNativeEc2InstanceSnapshotJobInput

    public class StartRestoreAwsNativeEc2InstanceSnapshotJobInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
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

        //      C# -> SnapshotTypeToUseIfSourceExpired? SnapshotTypeToUseIfSourceExpired
        // GraphQL -> snapshotTypeToUseIfSourceExpired: SnapshotTypeToUseIfSourceExpired (enum)
        [JsonProperty("snapshotTypeToUseIfSourceExpired")]
        public SnapshotTypeToUseIfSourceExpired? SnapshotTypeToUseIfSourceExpired { get; set; }

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

    } // class StartRestoreAwsNativeEc2InstanceSnapshotJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types