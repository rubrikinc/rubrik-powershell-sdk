// OpenstackCephSettingInput.cs
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
    #region OpenstackCephSettingInput

    public class OpenstackCephSettingInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Fsid
        // GraphQL -> fsid: String (scalar)
        [JsonProperty("fsid")]
        public System.String? Fsid { get; set; }

        //      C# -> System.String? OpenstackAvailabilityZoneId
        // GraphQL -> openstackAvailabilityZoneId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("openstackAvailabilityZoneId")]
        public System.String? OpenstackAvailabilityZoneId { get; set; }

        //      C# -> System.String? VolumeTypeId
        // GraphQL -> volumeTypeId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("volumeTypeId")]
        public System.String? VolumeTypeId { get; set; }

        //      C# -> System.String? Keyring
        // GraphQL -> keyring: String (scalar)
        [JsonProperty("keyring")]
        public System.String? Keyring { get; set; }

        //      C# -> System.String? VolumePoolName
        // GraphQL -> volumePoolName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("volumePoolName")]
        public System.String? VolumePoolName { get; set; }

        //      C# -> List<OpenstackMonHostInput>? MonHosts
        // GraphQL -> monHosts: [OpenstackMonHostInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("monHosts")]
        public List<OpenstackMonHostInput>? MonHosts { get; set; }


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

    } // class OpenstackCephSettingInput
    #endregion

} // namespace RubrikSecurityCloud.Types