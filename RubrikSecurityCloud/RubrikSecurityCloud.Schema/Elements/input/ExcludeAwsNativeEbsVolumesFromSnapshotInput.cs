// ExcludeAwsNativeEbsVolumesFromSnapshotInput.cs
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
    #region ExcludeAwsNativeEbsVolumesFromSnapshotInput

    public class ExcludeAwsNativeEbsVolumesFromSnapshotInput: IInput
    {
        #region members

        //      C# -> System.String? AwsNativeEc2InstanceId
        // GraphQL -> awsNativeEc2InstanceId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("awsNativeEc2InstanceId")]
        public System.String? AwsNativeEc2InstanceId { get; set; }

        //      C# -> List<VolumeIdExclusion>? VolumeIdExclusions
        // GraphQL -> volumeIdExclusions: [VolumeIdExclusion!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("volumeIdExclusions")]
        public List<VolumeIdExclusion>? VolumeIdExclusions { get; set; }


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

    } // class ExcludeAwsNativeEbsVolumesFromSnapshotInput
    #endregion

} // namespace RubrikSecurityCloud.Types