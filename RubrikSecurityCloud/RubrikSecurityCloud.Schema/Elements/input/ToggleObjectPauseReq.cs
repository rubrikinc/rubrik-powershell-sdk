// ToggleObjectPauseReq.cs
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
    #region ToggleObjectPauseReq

    public class ToggleObjectPauseReq: IInput
    {
        #region members

        //      C# -> List<TogglePauseInfo>? TogglePauseInfo
        // GraphQL -> togglePauseInfo: [TogglePauseInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("togglePauseInfo")]
        public List<TogglePauseInfo>? TogglePauseInfo { get; set; }

        //      C# -> System.String? Note
        // GraphQL -> note: String (scalar)
        [JsonProperty("note")]
        public System.String? Note { get; set; }

        //      C# -> System.Boolean? IsPause
        // GraphQL -> isPause: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isPause")]
        public System.Boolean? IsPause { get; set; }


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

    } // class ToggleObjectPauseReq
    #endregion

} // namespace RubrikSecurityCloud.Types