// LicenseDetailsInput.cs
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
    #region LicenseDetailsInput

    public class LicenseDetailsInput: IInput
    {
        #region members

        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("product")]
        public LicenseProduct? Product { get; set; }

        //      C# -> List<EntitlementStatus>? StatusFilter
        // GraphQL -> statusFilter: [EntitlementStatus!] (enum)
        [JsonProperty("statusFilter")]
        public List<EntitlementStatus>? StatusFilter { get; set; }

        //      C# -> DateTime? ExpiryDateAfter
        // GraphQL -> expiryDateAfter: DateTime (scalar)
        [JsonProperty("expiryDateAfter")]
        public DateTime? ExpiryDateAfter { get; set; }


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

    } // class LicenseDetailsInput
    #endregion

} // namespace RubrikSecurityCloud.Types