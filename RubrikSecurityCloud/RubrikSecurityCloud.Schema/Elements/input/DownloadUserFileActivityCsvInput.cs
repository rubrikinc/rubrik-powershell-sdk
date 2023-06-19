// DownloadUserFileActivityCsvInput.cs
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
    #region DownloadUserFileActivityCsvInput

    public class DownloadUserFileActivityCsvInput: IInput
    {
        #region members

        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("userId")]
        public System.String? UserId { get; set; }

        //      C# -> ResourceInput? Snapshot
        // GraphQL -> snapshot: ResourceInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshot")]
        public ResourceInput? Snapshot { get; set; }

        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nativePath")]
        public System.String? NativePath { get; set; }

        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("timezone")]
        public System.String? Timezone { get; set; }

        //      C# -> System.String? StartDay
        // GraphQL -> startDay: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("startDay")]
        public System.String? StartDay { get; set; }


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

    } // class DownloadUserFileActivityCsvInput
    #endregion

} // namespace RubrikSecurityCloud.Types