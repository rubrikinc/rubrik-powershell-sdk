// GlobalFileSearchQueryInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:34.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region GlobalFileSearchQueryInput

    public class GlobalFileSearchQueryInput
    {
        #region members
        //      C# -> System.String? Regex
        // GraphQL -> regex: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("regex")]
        public System.String? Regex { get; set; }

        //      C# -> List<System.String>? SnappableIds
        // GraphQL -> snappableIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snappableIds")]
        public List<System.String>? SnappableIds { get; set; }

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

    } // class GlobalFileSearchQueryInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types