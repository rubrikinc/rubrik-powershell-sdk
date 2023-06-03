// ExcludeSharepointObjectsFromProtectionInput.cs
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
    #region ExcludeSharepointObjectsFromProtectionInput

    public class ExcludeSharepointObjectsFromProtectionInput: IInput
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> List<O365FullSpSiteExclusions>? Exclusions
        // GraphQL -> exclusions: [O365FullSpSiteExclusions!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("exclusions")]
        public List<O365FullSpSiteExclusions>? Exclusions { get; set; }


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

    } // class ExcludeSharepointObjectsFromProtectionInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types