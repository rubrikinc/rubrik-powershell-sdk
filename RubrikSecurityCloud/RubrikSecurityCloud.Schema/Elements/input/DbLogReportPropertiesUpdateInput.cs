// DbLogReportPropertiesUpdateInput.cs
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
    #region DbLogReportPropertiesUpdateInput

    public class DbLogReportPropertiesUpdateInput: IInput
    {
        #region members

        //      C# -> System.Boolean? EnableDelayNotification
        // GraphQL -> enableDelayNotification: Boolean (scalar)
        [JsonProperty("enableDelayNotification")]
        public System.Boolean? EnableDelayNotification { get; set; }

        //      C# -> System.Int64? LogDelayThresholdInMin
        // GraphQL -> logDelayThresholdInMin: Long (scalar)
        [JsonProperty("logDelayThresholdInMin")]
        public System.Int64? LogDelayThresholdInMin { get; set; }

        //      C# -> System.Int64? LogDelayNotificationFrequencyInMin
        // GraphQL -> logDelayNotificationFrequencyInMin: Long (scalar)
        [JsonProperty("logDelayNotificationFrequencyInMin")]
        public System.Int64? LogDelayNotificationFrequencyInMin { get; set; }


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

    } // class DbLogReportPropertiesUpdateInput
    #endregion

} // namespace RubrikSecurityCloud.Types