// ExportPolicyViolationsCsvInput.cs
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
    #region ExportPolicyViolationsCsvInput

    public class ExportPolicyViolationsCsvInput: IInput
    {
        #region members

        //      C# -> ListPolicyViolationsFilter? Filter
        // GraphQL -> filter: ListPolicyViolationsFilter (input)
        [JsonProperty("filter")]
        public ListPolicyViolationsFilter? Filter { get; set; }

        //      C# -> PolicyFilters? PolicyFilters
        // GraphQL -> policyFilters: PolicyFilters (input)
        [JsonProperty("policyFilters")]
        public PolicyFilters? PolicyFilters { get; set; }

        //      C# -> ResourceMetadataFiltersInput? ResourceMetadataFilters
        // GraphQL -> resourceMetadataFilters: ResourceMetadataFiltersInput (input)
        [JsonProperty("resourceMetadataFilters")]
        public ResourceMetadataFiltersInput? ResourceMetadataFilters { get; set; }

        //      C# -> List<PolicyViolationCsvColumn>? Columns
        // GraphQL -> columns: [PolicyViolationCsvColumn!] (enum)
        [JsonProperty("columns")]
        public List<PolicyViolationCsvColumn>? Columns { get; set; }

        //      C# -> PolicyViolationGroupBy? GroupBy
        // GraphQL -> groupBy: PolicyViolationGroupBy (enum)
        [JsonProperty("groupBy")]
        public PolicyViolationGroupBy? GroupBy { get; set; }

        //      C# -> List<PolicyType>? PolicyTypes
        // GraphQL -> policyTypes: [PolicyType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("policyTypes")]
        public List<PolicyType>? PolicyTypes { get; set; }

        //      C# -> PolicyViolationSortField? SortField
        // GraphQL -> sortField: PolicyViolationSortField (enum)
        [JsonProperty("sortField")]
        public PolicyViolationSortField? SortField { get; set; }

        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        [JsonProperty("sortOrder")]
        public SortOrder? SortOrder { get; set; }


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

    } // class ExportPolicyViolationsCsvInput
    #endregion

} // namespace RubrikSecurityCloud.Types