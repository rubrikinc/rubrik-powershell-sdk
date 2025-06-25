// ServiceAccountInputInput.cs
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
    #region ServiceAccountInputInput

    public class ServiceAccountInputInput: IInput
    {
        #region members

        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("accessToken")]
        public System.String? AccessToken { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clientSecret")]
        public System.String? ClientSecret { get; set; }

        //      C# -> System.String? ServiceAccountName
        // GraphQL -> serviceAccountName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("serviceAccountName")]
        public System.String? ServiceAccountName { get; set; }


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

    } // class ServiceAccountInputInput
    #endregion

} // namespace RubrikSecurityCloud.Types