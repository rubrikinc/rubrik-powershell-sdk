// SetCustomerTagsInput.cs
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
    #region SetCustomerTagsInput

    public class SetCustomerTagsInput: IInput
    {
        #region members

        //      C# -> CloudVendor? CloudVendor
        // GraphQL -> cloudVendor: CloudVendor! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudVendor")]
        public CloudVendor? CloudVendor { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> TagsInput? CustomerTags
        // GraphQL -> customerTags: TagsInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("customerTags")]
        public TagsInput? CustomerTags { get; set; }

        //      C# -> System.Boolean? ShouldOverrideResourceTags
        // GraphQL -> shouldOverrideResourceTags: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldOverrideResourceTags")]
        public System.Boolean? ShouldOverrideResourceTags { get; set; }


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

    } // class SetCustomerTagsInput
    #endregion

} // namespace RubrikSecurityCloud.Types