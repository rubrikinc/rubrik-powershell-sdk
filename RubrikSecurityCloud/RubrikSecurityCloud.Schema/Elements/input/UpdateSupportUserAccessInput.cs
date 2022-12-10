// UpdateSupportUserAccessInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:43.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateSupportUserAccessInput

    public class UpdateSupportUserAccessInput
    {
        #region members
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int (scalar)
        [JsonProperty("id")]
        public System.Int32? Id { get; set; }

        //      C# -> System.String? ImpersonatedUserId
        // GraphQL -> impersonatedUserId: String (scalar)
        [JsonProperty("impersonatedUserId")]
        public System.String? ImpersonatedUserId { get; set; }

        //      C# -> System.Int32? NewDurationInHours
        // GraphQL -> newDurationInHours: Int (scalar)
        [JsonProperty("newDurationInHours")]
        public System.Int32? NewDurationInHours { get; set; }

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

    } // class UpdateSupportUserAccessInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types