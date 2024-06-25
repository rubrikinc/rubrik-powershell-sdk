// MssqlRecoveryPointInput.cs
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
    #region MssqlRecoveryPointInput

    public class MssqlRecoveryPointInput: IInput
    {
        #region members

        //      C# -> System.Int64? TimestampMs
        // GraphQL -> timestampMs: Long (scalar)
        [JsonProperty("timestampMs")]
        public System.Int64? TimestampMs { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> LsnRecoveryPointInput? LsnPoint
        // GraphQL -> lsnPoint: LsnRecoveryPointInput (input)
        [JsonProperty("lsnPoint")]
        public LsnRecoveryPointInput? LsnPoint { get; set; }


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

    } // class MssqlRecoveryPointInput
    #endregion

} // namespace RubrikSecurityCloud.Types