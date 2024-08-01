// AwsNativeProtectionAccountAddRequest.cs
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
    #region AwsNativeProtectionAccountAddRequest

    public class AwsNativeProtectionAccountAddRequest: IInput
    {
        #region members

        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("accountId")]
        public System.String? AccountId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? Regions
        // GraphQL -> regions: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("regions")]
        public List<System.String>? Regions { get; set; }


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

    } // class AwsNativeProtectionAccountAddRequest
    #endregion

} // namespace RubrikSecurityCloud.Types