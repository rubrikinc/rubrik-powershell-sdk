// AnomalyDetectionConfigInput.cs
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
    #region AnomalyDetectionConfigInput

    public class AnomalyDetectionConfigInput: IInput
    {
        #region members

        //      C# -> System.Int64? Threshold
        // GraphQL -> threshold: Long (scalar)
        [JsonProperty("threshold")]
        public System.Int64? Threshold { get; set; }

        //      C# -> System.Int32? QuietPeriodMinutes
        // GraphQL -> quietPeriodMinutes: Int (scalar)
        [JsonProperty("quietPeriodMinutes")]
        public System.Int32? QuietPeriodMinutes { get; set; }

        //      C# -> System.Int32? LatenessBufferMinutes
        // GraphQL -> latenessBufferMinutes: Int (scalar)
        [JsonProperty("latenessBufferMinutes")]
        public System.Int32? LatenessBufferMinutes { get; set; }

        //      C# -> System.Int32? WindowMinutes
        // GraphQL -> windowMinutes: Int (scalar)
        [JsonProperty("windowMinutes")]
        public System.Int32? WindowMinutes { get; set; }

        //      C# -> List<System.Int32>? ErrorCodes
        // GraphQL -> errorCodes: [Int!] (scalar)
        [JsonProperty("errorCodes")]
        public List<System.Int32>? ErrorCodes { get; set; }

        //      C# -> List<System.String>? Results
        // GraphQL -> results: [String!] (scalar)
        [JsonProperty("results")]
        public List<System.String>? Results { get; set; }


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

    } // class AnomalyDetectionConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types