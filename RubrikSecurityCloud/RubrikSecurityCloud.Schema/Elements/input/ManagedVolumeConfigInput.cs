// ManagedVolumeConfigInput.cs
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
    #region ManagedVolumeConfigInput

    public class ManagedVolumeConfigInput: IInput
    {
        #region members

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        [JsonProperty("subnet")]
        public System.String? Subnet { get; set; }

        //      C# -> SlaManagedVolumeClientConfigInput? SlaClientConfig
        // GraphQL -> slaClientConfig: SlaManagedVolumeClientConfigInput (input)
        [JsonProperty("slaClientConfig")]
        public SlaManagedVolumeClientConfigInput? SlaClientConfig { get; set; }

        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        [JsonProperty("applicationTag")]
        public ManagedVolumeApplicationTag? ApplicationTag { get; set; }

        //      C# -> CdmManagedVolumeType? MvType
        // GraphQL -> mvType: CdmManagedVolumeType (enum)
        [JsonProperty("mvType")]
        public CdmManagedVolumeType? MvType { get; set; }

        //      C# -> ManagedVolumeExportConfigInput? ExportConfig
        // GraphQL -> exportConfig: ManagedVolumeExportConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("exportConfig")]
        public ManagedVolumeExportConfigInput? ExportConfig { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int64? VolumeSize
        // GraphQL -> volumeSize: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("volumeSize")]
        public System.Int64? VolumeSize { get; set; }


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

    } // class ManagedVolumeConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types