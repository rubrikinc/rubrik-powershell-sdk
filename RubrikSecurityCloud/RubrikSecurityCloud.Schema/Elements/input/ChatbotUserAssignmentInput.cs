// ChatbotUserAssignmentInput.cs
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
    #region ChatbotUserAssignmentInput

    public class ChatbotUserAssignmentInput: IInput
    {
        #region members

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String (scalar)
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }

        //      C# -> System.String? RoleDescription
        // GraphQL -> roleDescription: String (scalar)
        [JsonProperty("roleDescription")]
        public System.String? RoleDescription { get; set; }

        //      C# -> List<System.String>? UserIds
        // GraphQL -> userIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("userIds")]
        public List<System.String>? UserIds { get; set; }

        //      C# -> List<System.String>? UserGroupIds
        // GraphQL -> userGroupIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("userGroupIds")]
        public List<System.String>? UserGroupIds { get; set; }


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

    } // class ChatbotUserAssignmentInput
    #endregion

} // namespace RubrikSecurityCloud.Types