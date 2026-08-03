// GpoSettingFilterInput.cs
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
    #region GpoSettingFilterInput

    public class GpoSettingFilterInput: IInput
    {
        #region members

        //      C# -> GpoSettingName? Setting
        // GraphQL -> setting: GpoSettingName! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("setting")]
        public GpoSettingName? Setting { get; set; }

        //      C# -> GpoSetting? State
        // GraphQL -> state: GpoSetting! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("state")]
        public GpoSetting? State { get; set; }


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

    } // class GpoSettingFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types