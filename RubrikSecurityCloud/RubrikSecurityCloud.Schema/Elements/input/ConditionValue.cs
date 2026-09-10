// ConditionValue.cs
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
    #region ConditionValue

    public class ConditionValue: IInput
    {
        #region members

        //      C# -> System.Boolean? BoolValue
        // GraphQL -> boolValue: Boolean (scalar)
        [JsonProperty("boolValue")]
        public System.Boolean? BoolValue { get; set; }

        //      C# -> System.Int64? IntValue
        // GraphQL -> intValue: Long (scalar)
        [JsonProperty("intValue")]
        public System.Int64? IntValue { get; set; }

        //      C# -> System.Single? DoubleValue
        // GraphQL -> doubleValue: Float (scalar)
        [JsonProperty("doubleValue")]
        public System.Single? DoubleValue { get; set; }

        //      C# -> System.String? StringValue
        // GraphQL -> stringValue: String (scalar)
        [JsonProperty("stringValue")]
        public System.String? StringValue { get; set; }


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

    } // class ConditionValue
    #endregion

} // namespace RubrikSecurityCloud.Types