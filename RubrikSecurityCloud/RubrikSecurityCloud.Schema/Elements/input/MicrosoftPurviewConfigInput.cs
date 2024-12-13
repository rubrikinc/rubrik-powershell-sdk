// MicrosoftPurviewConfigInput.cs
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
    #region MicrosoftPurviewConfigInput

    public class MicrosoftPurviewConfigInput: IInput
    {
        #region members

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> System.String? O365OrgId
        // GraphQL -> o365OrgId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("o365OrgId")]
        public System.String? O365OrgId { get; set; }


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

    } // class MicrosoftPurviewConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types