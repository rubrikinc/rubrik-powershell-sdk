// AdGroupSpecInput.cs
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
    #region AdGroupSpecInput

    public class AdGroupSpecInput: IInput
    {
        #region members

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> List<GroupFilterAttribute>? FilterAttributes
        // GraphQL -> filterAttributes: [GroupFilterAttribute!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("filterAttributes")]
        public List<GroupFilterAttribute>? FilterAttributes { get; set; }


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

    } // class AdGroupSpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types