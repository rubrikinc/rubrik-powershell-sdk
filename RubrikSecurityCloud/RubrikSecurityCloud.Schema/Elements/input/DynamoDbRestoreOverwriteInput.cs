// DynamoDbRestoreOverwriteInput.cs
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
    #region DynamoDbRestoreOverwriteInput

    public class DynamoDbRestoreOverwriteInput: IInput
    {
        #region members

        //      C# -> DynamoDbOverwriteMode? Mode
        // GraphQL -> mode: DynamoDbOverwriteMode! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("mode")]
        public DynamoDbOverwriteMode? Mode { get; set; }

        //      C# -> System.String? ConditionalTimestampField
        // GraphQL -> conditionalTimestampField: String (scalar)
        [JsonProperty("conditionalTimestampField")]
        public System.String? ConditionalTimestampField { get; set; }

        //      C# -> DateTime? ConditionalTimestampValue
        // GraphQL -> conditionalTimestampValue: DateTime (scalar)
        [JsonProperty("conditionalTimestampValue")]
        public DateTime? ConditionalTimestampValue { get; set; }


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

    } // class DynamoDbRestoreOverwriteInput
    #endregion

} // namespace RubrikSecurityCloud.Types