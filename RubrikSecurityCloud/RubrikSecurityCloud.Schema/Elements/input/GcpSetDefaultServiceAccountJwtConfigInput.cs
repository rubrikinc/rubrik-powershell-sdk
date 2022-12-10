// GcpSetDefaultServiceAccountJwtConfigInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:23.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region GcpSetDefaultServiceAccountJwtConfigInput

    public class GcpSetDefaultServiceAccountJwtConfigInput
    {
        #region members
        //      C# -> System.String? ServiceAccountName
        // GraphQL -> serviceAccountName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("serviceAccountName")]
        public System.String? ServiceAccountName { get; set; }

        //      C# -> System.String? ServiceAccountJwtConfig
        // GraphQL -> serviceAccountJwtConfig: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("serviceAccountJwtConfig")]
        public System.String? ServiceAccountJwtConfig { get; set; }

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

    } // class GcpSetDefaultServiceAccountJwtConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types