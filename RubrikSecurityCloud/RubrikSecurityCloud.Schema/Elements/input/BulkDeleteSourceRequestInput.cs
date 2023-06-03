// BulkDeleteSourceRequestInput.cs
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
    #region BulkDeleteSourceRequestInput

    public class BulkDeleteSourceRequestInput: IInput
    {
        #region members

        //      C# -> System.Boolean? Async
        // GraphQL -> async: Boolean (scalar)
        [JsonProperty("async")]
        public System.Boolean? Async { get; set; }

        //      C# -> List<System.String>? SourceNames
        // GraphQL -> sourceNames: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceNames")]
        public List<System.String>? SourceNames { get; set; }


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

    } // class BulkDeleteSourceRequestInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types