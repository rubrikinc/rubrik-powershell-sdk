// ValidateRdsExportExocomputePortReq.cs
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
    #region ValidateRdsExportExocomputePortReq

    public class ValidateRdsExportExocomputePortReq: IInput
    {
        #region members

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.String? SourceSnapshotId
        // GraphQL -> sourceSnapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceSnapshotId")]
        public System.String? SourceSnapshotId { get; set; }

        //      C# -> System.String? ArchivedSnapshotId
        // GraphQL -> archivedSnapshotId: UUID (scalar)
        [JsonProperty("archivedSnapshotId")]
        public System.String? ArchivedSnapshotId { get; set; }

        //      C# -> System.String? DestinationRegion
        // GraphQL -> destinationRegion: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationRegion")]
        public System.String? DestinationRegion { get; set; }

        //      C# -> System.String? TargetAwsNativeAccountId
        // GraphQL -> targetAwsNativeAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetAwsNativeAccountId")]
        public System.String? TargetAwsNativeAccountId { get; set; }

        //      C# -> System.Int64? Port
        // GraphQL -> port: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("port")]
        public System.Int64? Port { get; set; }


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

    } // class ValidateRdsExportExocomputePortReq
    #endregion

} // namespace RubrikSecurityCloud.Types