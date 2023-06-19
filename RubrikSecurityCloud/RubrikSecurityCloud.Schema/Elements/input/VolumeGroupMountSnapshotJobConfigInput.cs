// VolumeGroupMountSnapshotJobConfigInput.cs
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
    #region VolumeGroupMountSnapshotJobConfigInput

    public class VolumeGroupMountSnapshotJobConfigInput: IInput
    {
        #region members

        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        [JsonProperty("smbDomainName")]
        public System.String? SmbDomainName { get; set; }

        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!] (scalar)
        [JsonProperty("smbValidIps")]
        public List<System.String>? SmbValidIps { get; set; }

        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!] (scalar)
        [JsonProperty("smbValidUsers")]
        public List<System.String>? SmbValidUsers { get; set; }

        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: String (scalar)
        [JsonProperty("targetHostId")]
        public System.String? TargetHostId { get; set; }

        //      C# -> List<VolumeGroupVolumeMountConfigInput>? VolumeConfigs
        // GraphQL -> volumeConfigs: [VolumeGroupVolumeMountConfigInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("volumeConfigs")]
        public List<VolumeGroupVolumeMountConfigInput>? VolumeConfigs { get; set; }


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

    } // class VolumeGroupMountSnapshotJobConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types