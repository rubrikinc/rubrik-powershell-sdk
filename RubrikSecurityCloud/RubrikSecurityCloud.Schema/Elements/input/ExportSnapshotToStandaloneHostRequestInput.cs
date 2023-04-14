// ExportSnapshotToStandaloneHostRequestInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ExportSnapshotToStandaloneHostRequestInput

    public class ExportSnapshotToStandaloneHostRequestInput: IInput
    {
        #region members

        //      C# -> MountExportSnapshotJobCommonOptionsInput? MountExportSnapshotJobCommonOptions
        // GraphQL -> mountExportSnapshotJobCommonOptions: MountExportSnapshotJobCommonOptionsInput (input)
        [JsonProperty("mountExportSnapshotJobCommonOptions")]
        public MountExportSnapshotJobCommonOptionsInput? MountExportSnapshotJobCommonOptions { get; set; }

        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("datastoreName")]
        public System.String? DatastoreName { get; set; }

        //      C# -> System.String? HostIpAddress
        // GraphQL -> hostIpAddress: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostIpAddress")]
        public System.String? HostIpAddress { get; set; }

        //      C# -> System.String? HostPassword
        // GraphQL -> hostPassword: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostPassword")]
        public System.String? HostPassword { get; set; }

        //      C# -> System.String? HostUsername
        // GraphQL -> hostUsername: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostUsername")]
        public System.String? HostUsername { get; set; }


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

    } // class ExportSnapshotToStandaloneHostRequestInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types