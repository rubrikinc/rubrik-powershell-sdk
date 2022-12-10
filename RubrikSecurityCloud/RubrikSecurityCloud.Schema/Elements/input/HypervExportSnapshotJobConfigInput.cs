// HypervExportSnapshotJobConfigInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:26.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region HypervExportSnapshotJobConfigInput

    public class HypervExportSnapshotJobConfigInput
    {
        #region members
        //      C# -> System.Boolean? DisableNetwork
        // GraphQL -> disableNetwork: Boolean (scalar)
        [JsonProperty("disableNetwork")]
        public System.Boolean? DisableNetwork { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.Boolean? PowerOn
        // GraphQL -> powerOn: Boolean (scalar)
        [JsonProperty("powerOn")]
        public System.Boolean? PowerOn { get; set; }

        //      C# -> System.Boolean? RemoveNetworkDevices
        // GraphQL -> removeNetworkDevices: Boolean (scalar)
        [JsonProperty("removeNetworkDevices")]
        public System.Boolean? RemoveNetworkDevices { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("path")]
        public System.String? Path { get; set; }

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

    } // class HypervExportSnapshotJobConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types