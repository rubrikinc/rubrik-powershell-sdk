// UpdateNasShareInput.cs
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
    #region UpdateNasShareInput

    public class UpdateNasShareInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsIsilonChangelistEnabled
        // GraphQL -> isIsilonChangelistEnabled: Boolean (scalar)
        [JsonProperty("isIsilonChangelistEnabled")]
        public System.Boolean? IsIsilonChangelistEnabled { get; set; }

        //      C# -> System.String? ExportPoint
        // GraphQL -> exportPoint: String (scalar)
        [JsonProperty("exportPoint")]
        public System.String? ExportPoint { get; set; }

        //      C# -> NasShareCredentialsInput? Credentials
        // GraphQL -> credentials: NasShareCredentialsInput (input)
        [JsonProperty("credentials")]
        public NasShareCredentialsInput? Credentials { get; set; }

        //      C# -> System.String? NasSourceId
        // GraphQL -> nasSourceId: String (scalar)
        [JsonProperty("nasSourceId")]
        public System.String? NasSourceId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }


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

    } // class UpdateNasShareInput
    #endregion

} // namespace RubrikSecurityCloud.Types