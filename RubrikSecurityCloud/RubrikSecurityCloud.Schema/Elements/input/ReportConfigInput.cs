// ReportConfigInput.cs
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
    #region ReportConfigInput

    public class ReportConfigInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> DataViewTypeEnum? DataViewType
        // GraphQL -> dataViewType: DataViewTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("dataViewType")]
        public DataViewTypeEnum? DataViewType { get; set; }

        //      C# -> List<System.String>? Columns
        // GraphQL -> columns: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("columns")]
        public List<System.String>? Columns { get; set; }

        //      C# -> ConfigGroupByInput? GroupBy
        // GraphQL -> groupBy: ConfigGroupByInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("groupBy")]
        public ConfigGroupByInput? GroupBy { get; set; }

        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("aggregations")]
        public List<System.String>? Aggregations { get; set; }

        //      C# -> List<ReportFilterInput>? Filters
        // GraphQL -> filters: [ReportFilterInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("filters")]
        public List<ReportFilterInput>? Filters { get; set; }

        //      C# -> System.String? SortBy
        // GraphQL -> sortBy: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sortBy")]
        public System.String? SortBy { get; set; }

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

    } // class ReportConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types