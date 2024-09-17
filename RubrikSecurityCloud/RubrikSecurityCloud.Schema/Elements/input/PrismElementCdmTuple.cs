// PrismElementCdmTuple.cs
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
    #region PrismElementCdmTuple

    public class PrismElementCdmTuple: IInput
    {
        #region members

        //      C# -> System.String? NutanixClusterId
        // GraphQL -> nutanixClusterId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nutanixClusterId")]
        public System.String? NutanixClusterId { get; set; }

        //      C# -> System.String? CdmClusterId
        // GraphQL -> cdmClusterId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cdmClusterId")]
        public System.String? CdmClusterId { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }


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

    } // class PrismElementCdmTuple
    #endregion

} // namespace RubrikSecurityCloud.Types