// UpdateConfiguredGroupInput.cs
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
    #region UpdateConfiguredGroupInput

    public class UpdateConfiguredGroupInput: IInput
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? UpdatedDisplayName
        // GraphQL -> updatedDisplayName: String (scalar)
        [JsonProperty("updatedDisplayName")]
        public System.String? UpdatedDisplayName { get; set; }

        //      C# -> System.String? UpdatedWildcard
        // GraphQL -> updatedWildcard: String (scalar)
        [JsonProperty("updatedWildcard")]
        public System.String? UpdatedWildcard { get; set; }

        //      C# -> List<System.String>? UpdatedPdls
        // GraphQL -> updatedPdls: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("updatedPdls")]
        public List<System.String>? UpdatedPdls { get; set; }

        //      C# -> List<GroupFilterAttribute>? UpdatedGroupFilterAttributes
        // GraphQL -> updatedGroupFilterAttributes: [GroupFilterAttribute!] (input)
        [JsonProperty("updatedGroupFilterAttributes")]
        public List<GroupFilterAttribute>? UpdatedGroupFilterAttributes { get; set; }

        //      C# -> System.Boolean? PerformArchival
        // GraphQL -> performArchival: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("performArchival")]
        public System.Boolean? PerformArchival { get; set; }


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

    } // class UpdateConfiguredGroupInput
    #endregion

} // namespace RubrikSecurityCloud.Types