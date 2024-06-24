// VmwareThrottlingSettingsInput.cs
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
    #region VmwareThrottlingSettingsInput

    public class VmwareThrottlingSettingsInput: IInput
    {
        #region members

        //      C# -> System.Int32? IoLatencyThreshold
        // GraphQL -> ioLatencyThreshold: Int (scalar)
        [JsonProperty("ioLatencyThreshold")]
        public System.Int32? IoLatencyThreshold { get; set; }

        //      C# -> System.Int32? DatastoreIoLatencyThreshold
        // GraphQL -> datastoreIoLatencyThreshold: Int (scalar)
        [JsonProperty("datastoreIoLatencyThreshold")]
        public System.Int32? DatastoreIoLatencyThreshold { get; set; }

        //      C# -> System.Int32? CpuUtilizationThreshold
        // GraphQL -> cpuUtilizationThreshold: Int (scalar)
        [JsonProperty("cpuUtilizationThreshold")]
        public System.Int32? CpuUtilizationThreshold { get; set; }


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

    } // class VmwareThrottlingSettingsInput
    #endregion

} // namespace RubrikSecurityCloud.Types