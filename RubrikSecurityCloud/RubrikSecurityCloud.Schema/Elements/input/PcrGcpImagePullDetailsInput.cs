// PcrGcpImagePullDetailsInput.cs
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
    #region PcrGcpImagePullDetailsInput

    public class PcrGcpImagePullDetailsInput: IInput
    {
        #region members

        //      C# -> System.String? ServiceAccountEmail
        // GraphQL -> serviceAccountEmail: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("serviceAccountEmail")]
        public System.String? ServiceAccountEmail { get; set; }

        //      C# -> System.String? ServiceAccountOwnershipToken
        // GraphQL -> serviceAccountOwnershipToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("serviceAccountOwnershipToken")]
        public System.String? ServiceAccountOwnershipToken { get; set; }


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

    } // class PcrGcpImagePullDetailsInput
    #endregion

} // namespace RubrikSecurityCloud.Types