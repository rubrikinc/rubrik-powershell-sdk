// StartAwsNativeEc2InstanceSnapshotsJobInput.cs
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
    #region StartAwsNativeEc2InstanceSnapshotsJobInput

    public class StartAwsNativeEc2InstanceSnapshotsJobInput: IInput
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

} // namespace RubrikSecurityCloud.Types