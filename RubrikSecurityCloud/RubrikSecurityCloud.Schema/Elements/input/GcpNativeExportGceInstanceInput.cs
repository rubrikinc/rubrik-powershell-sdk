// GcpNativeExportGceInstanceInput.cs
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
    #region GcpNativeExportGceInstanceInput

    public class GcpNativeExportGceInstanceInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? TargetZone
        // GraphQL -> targetZone: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetZone")]
        public System.String? TargetZone { get; set; }

        //      C# -> System.String? TargetInstanceName
        // GraphQL -> targetInstanceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetInstanceName")]
        public System.String? TargetInstanceName { get; set; }

        //      C# -> System.String? TargetMachineType
        // GraphQL -> targetMachineType: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetMachineType")]
        public System.String? TargetMachineType { get; set; }

        //      C# -> System.String? TargetSubnetName
        // GraphQL -> targetSubnetName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetSubnetName")]
        public System.String? TargetSubnetName { get; set; }

        //      C# -> List<System.String>? TargetNetworkTags
        // GraphQL -> targetNetworkTags: [String!] (scalar)
        [JsonProperty("targetNetworkTags")]
        public List<System.String>? TargetNetworkTags { get; set; }

        //      C# -> System.Boolean? ShouldPowerOff
        // GraphQL -> shouldPowerOff: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldPowerOff")]
        public System.Boolean? ShouldPowerOff { get; set; }

        //      C# -> System.Boolean? ShouldCopyLabels
        // GraphQL -> shouldCopyLabels: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldCopyLabels")]
        public System.Boolean? ShouldCopyLabels { get; set; }

        //      C# -> System.Boolean? ShouldAddRubrikLabels
        // GraphQL -> shouldAddRubrikLabels: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldAddRubrikLabels")]
        public System.Boolean? ShouldAddRubrikLabels { get; set; }

        //      C# -> System.String? SharedVpcHostProjectNativeId
        // GraphQL -> sharedVpcHostProjectNativeId: String (scalar)
        [JsonProperty("sharedVpcHostProjectNativeId")]
        public System.String? SharedVpcHostProjectNativeId { get; set; }

        //      C# -> DiskEncryptionType? DiskEncryptionType
        // GraphQL -> diskEncryptionType: DiskEncryptionType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("diskEncryptionType")]
        public DiskEncryptionType? DiskEncryptionType { get; set; }

        //      C# -> KmsCryptoKey? KmsCryptoKey
        // GraphQL -> kmsCryptoKey: KmsCryptoKey (input)
        [JsonProperty("kmsCryptoKey")]
        public KmsCryptoKey? KmsCryptoKey { get; set; }

        //      C# -> System.String? KmsCryptoKeyResourceId
        // GraphQL -> kmsCryptoKeyResourceId: String (scalar)
        [JsonProperty("kmsCryptoKeyResourceId")]
        public System.String? KmsCryptoKeyResourceId { get; set; }


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

    } // class GcpNativeExportGceInstanceInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types