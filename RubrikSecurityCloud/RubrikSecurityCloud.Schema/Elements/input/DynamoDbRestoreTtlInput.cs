// DynamoDbRestoreTtlInput.cs
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
    #region DynamoDbRestoreTtlInput

    public class DynamoDbRestoreTtlInput: IInput
    {
        #region members

        //      C# -> DynamoDbTtlHandling? Handling
        // GraphQL -> handling: DynamoDbTtlHandling! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("handling")]
        public DynamoDbTtlHandling? Handling { get; set; }

        //      C# -> DateTime? CustomExpiry
        // GraphQL -> customExpiry: DateTime (scalar)
        [JsonProperty("customExpiry")]
        public DateTime? CustomExpiry { get; set; }


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

    } // class DynamoDbRestoreTtlInput
    #endregion

} // namespace RubrikSecurityCloud.Types