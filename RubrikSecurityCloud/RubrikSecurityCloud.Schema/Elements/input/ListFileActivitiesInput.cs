// ListFileActivitiesInput.cs
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
    #region ListFileActivitiesInput

    public class ListFileActivitiesInput: IInput
    {
        #region members

        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snappableFid")]
        public System.String? SnappableFid { get; set; }

        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("stdPath")]
        public System.String? StdPath { get; set; }

        //      C# -> System.String? StartDateTime
        // GraphQL -> startDateTime: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("startDateTime")]
        public System.String? StartDateTime { get; set; }

        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("timezone")]
        public System.String? Timezone { get; set; }


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

    } // class ListFileActivitiesInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types