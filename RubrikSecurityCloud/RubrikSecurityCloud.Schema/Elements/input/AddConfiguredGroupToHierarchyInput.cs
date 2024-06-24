// AddConfiguredGroupToHierarchyInput.cs
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
    #region AddConfiguredGroupToHierarchyInput

    public class AddConfiguredGroupToHierarchyInput: IInput
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Wildcard
        // GraphQL -> wildcard: String (scalar)
        [JsonProperty("wildcard")]
        public System.String? Wildcard { get; set; }

        //      C# -> List<System.String>? Pdls
        // GraphQL -> pdls: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("pdls")]
        public List<System.String>? Pdls { get; set; }

        //      C# -> WorkloadLevelHierarchy? Workload
        // GraphQL -> workload: WorkloadLevelHierarchy (enum)
        [JsonProperty("workload")]
        public WorkloadLevelHierarchy? Workload { get; set; }

        //      C# -> List<GroupFilterAttribute>? GroupFilterAttributes
        // GraphQL -> groupFilterAttributes: [GroupFilterAttribute!] (input)
        [JsonProperty("groupFilterAttributes")]
        public List<GroupFilterAttribute>? GroupFilterAttributes { get; set; }


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

    } // class AddConfiguredGroupToHierarchyInput
    #endregion

} // namespace RubrikSecurityCloud.Types