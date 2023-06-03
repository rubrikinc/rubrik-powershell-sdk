// CreatePolarisReportInput.cs
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
    #region CreatePolarisReportInput

    public class CreatePolarisReportInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("reportViewType")]
        public PolarisReportViewType? ReportViewType { get; set; }

        //      C# -> List<ChartViewType>? Charts
        // GraphQL -> charts: [ChartViewType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("charts")]
        public List<ChartViewType>? Charts { get; set; }

        //      C# -> TableViewType? Table
        // GraphQL -> table: TableViewType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("table")]
        public TableViewType? Table { get; set; }

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

    } // class CreatePolarisReportInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types