// CloudDownloadLocationDetailsInput.cs
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
    #region CloudDownloadLocationDetailsInput

    public class CloudDownloadLocationDetailsInput: IInput
    {
        #region members

        //      C# -> System.String? DownloadLocation
        // GraphQL -> downloadLocation: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("downloadLocation")]
        public System.String? DownloadLocation { get; set; }

        //      C# -> System.Boolean? CreateDownloadLocation
        // GraphQL -> createDownloadLocation: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("createDownloadLocation")]
        public System.Boolean? CreateDownloadLocation { get; set; }

        //      C# -> List<TagType>? Tags
        // GraphQL -> tags: [TagType!] (input)
        [JsonProperty("tags")]
        public List<TagType>? Tags { get; set; }


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

    } // class CloudDownloadLocationDetailsInput
    #endregion

} // namespace RubrikSecurityCloud.Types