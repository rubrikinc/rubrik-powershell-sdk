// NetworkThrottleUpdateInput.cs
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
    #region NetworkThrottleUpdateInput

    public class NetworkThrottleUpdateInput: IInput
    {
        #region members

        //      C# -> System.Single? DefaultThrottleLimit
        // GraphQL -> defaultThrottleLimit: Float (scalar)
        [JsonProperty("defaultThrottleLimit")]
        public System.Single? DefaultThrottleLimit { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> List<NetworkThrottleScheduleSummaryInput>? ScheduledThrottles
        // GraphQL -> scheduledThrottles: [NetworkThrottleScheduleSummaryInput!] (input)
        [JsonProperty("scheduledThrottles")]
        public List<NetworkThrottleScheduleSummaryInput>? ScheduledThrottles { get; set; }

        //      C# -> System.String? NetworkInterface
        // GraphQL -> networkInterface: String (scalar)
        [JsonProperty("networkInterface")]
        public System.String? NetworkInterface { get; set; }

        //      C# -> System.Int32? ArchivalThrottlePort
        // GraphQL -> archivalThrottlePort: Int (scalar)
        [JsonProperty("archivalThrottlePort")]
        public System.Int32? ArchivalThrottlePort { get; set; }


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

    } // class NetworkThrottleUpdateInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types