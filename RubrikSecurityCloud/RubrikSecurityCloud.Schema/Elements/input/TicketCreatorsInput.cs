// TicketCreatorsInput.cs
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
    #region TicketCreatorsInput

    public class TicketCreatorsInput: IInput
    {
        #region members

        //      C# -> TicketingPlatform? PlatformType
        // GraphQL -> platformType: TicketingPlatform! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("platformType")]
        public TicketingPlatform? PlatformType { get; set; }

        //      C# -> System.String? EmailFilter
        // GraphQL -> emailFilter: String (scalar)
        [JsonProperty("emailFilter")]
        public System.String? EmailFilter { get; set; }

        //      C# -> System.Int32? Limit
        // GraphQL -> limit: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("limit")]
        public System.Int32? Limit { get; set; }


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

    } // class TicketCreatorsInput
    #endregion

} // namespace RubrikSecurityCloud.Types