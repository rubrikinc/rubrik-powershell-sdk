// JiraIssueChangeDetailsFilter.cs
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
    #region JiraIssueChangeDetailsFilter

    public class JiraIssueChangeDetailsFilter: IInput
    {
        #region members

        //      C# -> List<System.String>? AssigneeNaturalIds
        // GraphQL -> assigneeNaturalIds: [String!] (scalar)
        [JsonProperty("assigneeNaturalIds")]
        public List<System.String>? AssigneeNaturalIds { get; set; }

        //      C# -> List<System.String>? IssueTypeNaturalIds
        // GraphQL -> issueTypeNaturalIds: [String!] (scalar)
        [JsonProperty("issueTypeNaturalIds")]
        public List<System.String>? IssueTypeNaturalIds { get; set; }

        //      C# -> List<System.String>? ReporterNaturalIds
        // GraphQL -> reporterNaturalIds: [String!] (scalar)
        [JsonProperty("reporterNaturalIds")]
        public List<System.String>? ReporterNaturalIds { get; set; }

        //      C# -> List<System.String>? ComponentNaturalIds
        // GraphQL -> componentNaturalIds: [String!] (scalar)
        [JsonProperty("componentNaturalIds")]
        public List<System.String>? ComponentNaturalIds { get; set; }

        //      C# -> List<System.String>? PriorityNaturalIds
        // GraphQL -> priorityNaturalIds: [String!] (scalar)
        [JsonProperty("priorityNaturalIds")]
        public List<System.String>? PriorityNaturalIds { get; set; }

        //      C# -> List<AppItemActionType>? ActionTypes
        // GraphQL -> actionTypes: [AppItemActionType!] (enum)
        [JsonProperty("actionTypes")]
        public List<AppItemActionType>? ActionTypes { get; set; }

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }

        //      C# -> JiraTimeRangeFilter? CreatedDate
        // GraphQL -> createdDate: JiraTimeRangeFilter (input)
        [JsonProperty("createdDate")]
        public JiraTimeRangeFilter? CreatedDate { get; set; }

        //      C# -> JiraTimeRangeFilter? UpdatedDate
        // GraphQL -> updatedDate: JiraTimeRangeFilter (input)
        [JsonProperty("updatedDate")]
        public JiraTimeRangeFilter? UpdatedDate { get; set; }


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

    } // class JiraIssueChangeDetailsFilter
    #endregion

} // namespace RubrikSecurityCloud.Types