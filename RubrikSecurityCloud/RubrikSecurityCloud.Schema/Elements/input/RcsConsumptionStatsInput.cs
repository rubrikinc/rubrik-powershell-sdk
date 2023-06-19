// RcsConsumptionStatsInput.cs
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
    #region RcsConsumptionStatsInput

    public class RcsConsumptionStatsInput: IInput
    {
        #region members

        //      C# -> List<System.String>? LocationIds
        // GraphQL -> locationIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("locationIds")]
        public List<System.String>? LocationIds { get; set; }

        //      C# -> RcsConsumptionMetricNameType? MetricName
        // GraphQL -> metricName: RcsConsumptionMetricNameType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("metricName")]
        public RcsConsumptionMetricNameType? MetricName { get; set; }

        //      C# -> System.Boolean? DoForecasting
        // GraphQL -> doForecasting: Boolean (scalar)
        [JsonProperty("doForecasting")]
        public System.Boolean? DoForecasting { get; set; }


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

    } // class RcsConsumptionStatsInput
    #endregion

} // namespace RubrikSecurityCloud.Types