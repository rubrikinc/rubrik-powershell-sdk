// VmwareVnicBindingInfoV2Input.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:41.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region VmwareVnicBindingInfoV2Input

    public class VmwareVnicBindingInfoV2Input
    {
        #region members
        //      C# -> VmwareNetworkInfoV2Input? BackingNetworkInfo
        // GraphQL -> backingNetworkInfo: VmwareNetworkInfoV2Input! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("backingNetworkInfo")]
        public VmwareNetworkInfoV2Input? BackingNetworkInfo { get; set; }

        //      C# -> VmwareNetworkDeviceInfoV2Input? NetworkDeviceInfo
        // GraphQL -> networkDeviceInfo: VmwareNetworkDeviceInfoV2Input! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("networkDeviceInfo")]
        public VmwareNetworkDeviceInfoV2Input? NetworkDeviceInfo { get; set; }

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

    } // class VmwareVnicBindingInfoV2Input
    #endregion

} // namespace Rubrik.SecurityCloud.Types