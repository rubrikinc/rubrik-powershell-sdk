// DownloadObjectFilesCsvInput.cs
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
    #region DownloadObjectFilesCsvInput

    public class DownloadObjectFilesCsvInput: IInput
    {
        #region members

        //      C# -> ListObjectFilesFiltersInput? Filters
        // GraphQL -> filters: ListObjectFilesFiltersInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("filters")]
        public ListObjectFilesFiltersInput? Filters { get; set; }

        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("day")]
        public System.String? Day { get; set; }

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

    } // class DownloadObjectFilesCsvInput
    #endregion

} // namespace RubrikSecurityCloud.Types