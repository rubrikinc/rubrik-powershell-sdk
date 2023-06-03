// ListAccessUsersFilterInput.cs
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
    #region ListAccessUsersFilterInput

    public class ListAccessUsersFilterInput: IInput
    {
        #region members

        //      C# -> List<System.String>? GroupsIds
        // GraphQL -> groupsIds: [String!] (scalar)
        [JsonProperty("groupsIds")]
        public List<System.String>? GroupsIds { get; set; }

        //      C# -> System.String? Search
        // GraphQL -> search: String (scalar)
        [JsonProperty("search")]
        public System.String? Search { get; set; }

        //      C# -> UserTimeRangeInput? TimeRange
        // GraphQL -> timeRange: UserTimeRangeInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("timeRange")]
        public UserTimeRangeInput? TimeRange { get; set; }


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

    } // class ListAccessUsersFilterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types