// UpdateO365AppPermissionsInput.cs
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
    #region UpdateO365AppPermissionsInput

    public class UpdateO365AppPermissionsInput: IInput
    {
        #region members

        //      C# -> O365AppType? O365AppType
        // GraphQL -> o365AppType: O365AppType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("o365AppType")]
        public O365AppType? O365AppType { get; set; }

        //      C# -> System.String? O365AppId
        // GraphQL -> o365AppId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("o365AppId")]
        public System.String? O365AppId { get; set; }


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

    } // class UpdateO365AppPermissionsInput
    #endregion

} // namespace RubrikSecurityCloud.Types