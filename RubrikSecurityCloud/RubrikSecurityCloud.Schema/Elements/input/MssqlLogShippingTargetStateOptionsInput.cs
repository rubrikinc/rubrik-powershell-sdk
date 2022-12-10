// MssqlLogShippingTargetStateOptionsInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:31.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region MssqlLogShippingTargetStateOptionsInput

    public class MssqlLogShippingTargetStateOptionsInput
    {
        #region members
        //      C# -> System.Boolean? ShouldDisconnectStandbyUsers
        // GraphQL -> shouldDisconnectStandbyUsers: Boolean (scalar)
        [JsonProperty("shouldDisconnectStandbyUsers")]
        public System.Boolean? ShouldDisconnectStandbyUsers { get; set; }

        //      C# -> MssqlLogShippingOkState? State
        // GraphQL -> state: MssqlLogShippingOkState! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("state")]
        public MssqlLogShippingOkState? State { get; set; }

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

    } // class MssqlLogShippingTargetStateOptionsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types