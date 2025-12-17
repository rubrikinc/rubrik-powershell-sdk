// UpdateIpWhitelistEntryInput.cs
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
    #region UpdateIpWhitelistEntryInput

    public class UpdateIpWhitelistEntryInput: IInput
    {
        #region members

        //      C# -> System.Int64? TargetEntryId
        // GraphQL -> targetEntryId: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetEntryId")]
        public System.Int64? TargetEntryId { get; set; }

        //      C# -> System.String? NewIpCidr
        // GraphQL -> newIpCidr: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("newIpCidr")]
        public System.String? NewIpCidr { get; set; }

        //      C# -> System.String? NewDescription
        // GraphQL -> newDescription: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("newDescription")]
        public System.String? NewDescription { get; set; }


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

    } // class UpdateIpWhitelistEntryInput
    #endregion

} // namespace RubrikSecurityCloud.Types