// UpdatePactsafeEulaAcceptedInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdatePactsafeEulaAcceptedInput

    public class UpdatePactsafeEulaAcceptedInput: IInput
    {
        #region members

        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("firstName")]
        public System.String? FirstName { get; set; }

        //      C# -> System.String? LastName
        // GraphQL -> lastName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("lastName")]
        public System.String? LastName { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> System.String? CompanyName
        // GraphQL -> companyName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("companyName")]
        public System.String? CompanyName { get; set; }


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

    } // class UpdatePactsafeEulaAcceptedInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types