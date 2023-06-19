// JiraIssueFilterInput.cs
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
    #region JiraIssueFilterInput

    public class JiraIssueFilterInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> List<System.String>? AssigneeNaturalIds
        // GraphQL -> assigneeNaturalIds: [String!] (scalar)
        [JsonProperty("assigneeNaturalIds")]
        public List<System.String>? AssigneeNaturalIds { get; set; }

        //      C# -> List<System.String>? IssueTypeNaturalIds
        // GraphQL -> issueTypeNaturalIds: [String!] (scalar)
        [JsonProperty("issueTypeNaturalIds")]
        public List<System.String>? IssueTypeNaturalIds { get; set; }

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }


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

    } // class JiraIssueFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types