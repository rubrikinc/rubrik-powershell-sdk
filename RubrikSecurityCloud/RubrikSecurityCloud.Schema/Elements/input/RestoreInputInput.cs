// RestoreInputInput.cs
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
    #region RestoreInputInput

    public class RestoreInputInput: IInput
    {
        #region members

        //      C# -> List<SnapshotPreferredLocationInput>? LocationMap
        // GraphQL -> locationMap: [SnapshotPreferredLocationInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("locationMap")]
        public List<SnapshotPreferredLocationInput>? LocationMap { get; set; }

        //      C# -> RestoreSettingsInput? RestoreSettings
        // GraphQL -> restoreSettings: RestoreSettingsInput (input)
        [JsonProperty("restoreSettings")]
        public RestoreSettingsInput? RestoreSettings { get; set; }

        //      C# -> System.String? RestoreName
        // GraphQL -> restoreName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreName")]
        public System.String? RestoreName { get; set; }

        //      C# -> DateTime? RestoreTime
        // GraphQL -> restoreTime: DateTime (scalar)
        [JsonProperty("restoreTime")]
        public DateTime? RestoreTime { get; set; }

        //      C# -> List<System.String>? RestoreEntities
        // GraphQL -> restoreEntities: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreEntities")]
        public List<System.String>? RestoreEntities { get; set; }

        //      C# -> List<HostDiscoveryInfoInput>? HostRestoreTargets
        // GraphQL -> hostRestoreTargets: [HostDiscoveryInfoInput!] (input)
        [JsonProperty("hostRestoreTargets")]
        public List<HostDiscoveryInfoInput>? HostRestoreTargets { get; set; }


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

    } // class RestoreInputInput
    #endregion

} // namespace RubrikSecurityCloud.Types