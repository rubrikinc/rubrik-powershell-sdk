// SetBrandLogoInput.cs
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
    #region SetBrandLogoInput

    public class SetBrandLogoInput: IInput
    {
        #region members

        //      C# -> System.String? ImageBase64
        // GraphQL -> imageBase64: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("imageBase64")]
        public System.String? ImageBase64 { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.Int32? FileSizeBytes
        // GraphQL -> fileSizeBytes: Int (scalar)
        [JsonProperty("fileSizeBytes")]
        public System.Int32? FileSizeBytes { get; set; }

        //      C# -> System.Boolean? IsUrlEnabled
        // GraphQL -> isUrlEnabled: Boolean (scalar)
        [JsonProperty("isUrlEnabled")]
        public System.Boolean? IsUrlEnabled { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: String (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }


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

    } // class SetBrandLogoInput
    #endregion

} // namespace RubrikSecurityCloud.Types