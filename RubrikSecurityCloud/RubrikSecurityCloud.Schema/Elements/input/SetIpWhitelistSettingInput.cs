// SetIpWhitelistSettingInput.cs
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
    #region SetIpWhitelistSettingInput

    public class SetIpWhitelistSettingInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsIpWhitelistEnabled
        // GraphQL -> isIpWhitelistEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isIpWhitelistEnabled")]
        public System.Boolean? IsIpWhitelistEnabled { get; set; }

        //      C# -> System.String? CurrentIpDescription
        // GraphQL -> currentIpDescription: String (scalar)
        [JsonProperty("currentIpDescription")]
        public System.String? CurrentIpDescription { get; set; }

        //      C# -> WhitelistModeEnum? Mode
        // GraphQL -> mode: WhitelistModeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("mode")]
        public WhitelistModeEnum? Mode { get; set; }


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

    } // class SetIpWhitelistSettingInput
    #endregion

} // namespace RubrikSecurityCloud.Types