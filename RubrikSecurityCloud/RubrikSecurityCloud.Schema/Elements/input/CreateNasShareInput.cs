// CreateNasShareInput.cs
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
    #region CreateNasShareInput

    public class CreateNasShareInput: IInput
    {
        #region members

        //      C# -> CreateNasShareInputShareType? ShareType
        // GraphQL -> shareType: CreateNasShareInputShareType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("shareType")]
        public CreateNasShareInputShareType? ShareType { get; set; }

        //      C# -> NasShareCredentialsInput? Credentials
        // GraphQL -> credentials: NasShareCredentialsInput (input)
        [JsonProperty("credentials")]
        public NasShareCredentialsInput? Credentials { get; set; }

        //      C# -> System.String? ExportPoint
        // GraphQL -> exportPoint: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("exportPoint")]
        public System.String? ExportPoint { get; set; }


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

    } // class CreateNasShareInput
    #endregion

} // namespace RubrikSecurityCloud.Types