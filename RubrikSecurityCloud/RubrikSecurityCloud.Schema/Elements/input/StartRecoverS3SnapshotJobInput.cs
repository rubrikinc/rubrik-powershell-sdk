// StartRecoverS3SnapshotJobInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:15.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region StartRecoverS3SnapshotJobInput

    public class StartRecoverS3SnapshotJobInput
    {
        #region members
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> DateTime? RestoreDate
        // GraphQL -> restoreDate: DateTime (scalar)
        [JsonProperty("restoreDate")]
        public DateTime? RestoreDate { get; set; }

        //      C# -> System.String? DestinationBucketArn
        // GraphQL -> destinationBucketArn: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationBucketArn")]
        public System.String? DestinationBucketArn { get; set; }

        //      C# -> System.Boolean? ShouldRecoverFullBucket
        // GraphQL -> shouldRecoverFullBucket: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldRecoverFullBucket")]
        public System.Boolean? ShouldRecoverFullBucket { get; set; }

        //      C# -> List<System.String>? ObjectKeys
        // GraphQL -> objectKeys: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectKeys")]
        public List<System.String>? ObjectKeys { get; set; }

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

    } // class StartRecoverS3SnapshotJobInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types