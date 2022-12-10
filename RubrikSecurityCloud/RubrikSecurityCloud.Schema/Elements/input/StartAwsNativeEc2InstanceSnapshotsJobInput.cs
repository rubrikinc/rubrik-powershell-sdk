// StartAwsNativeEc2InstanceSnapshotsJobInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:14.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region StartAwsNativeEc2InstanceSnapshotsJobInput

    public class StartAwsNativeEc2InstanceSnapshotsJobInput
    {
        #region members
        //      C# -> List<System.String>? Ec2InstanceIds
        // GraphQL -> ec2InstanceIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("ec2InstanceIds")]
        public List<System.String>? Ec2InstanceIds { get; set; }

        //      C# -> System.String? RetentionSlaId
        // GraphQL -> retentionSlaId: String (scalar)
        [JsonProperty("retentionSlaId")]
        public System.String? RetentionSlaId { get; set; }

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

    } // class StartAwsNativeEc2InstanceSnapshotsJobInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types