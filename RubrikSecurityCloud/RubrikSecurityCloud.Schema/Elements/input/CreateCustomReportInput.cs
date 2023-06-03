// CreateCustomReportInput.cs
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
    #region CreateCustomReportInput

    public class CreateCustomReportInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("focus")]
        public ReportFocusEnum? Focus { get; set; }

        //      C# -> List<ReportChartCreate>? Charts
        // GraphQL -> charts: [ReportChartCreate!] (input)
        [JsonProperty("charts")]
        public List<ReportChartCreate>? Charts { get; set; }

        //      C# -> List<ReportTableCreate>? Tables
        // GraphQL -> tables: [ReportTableCreate!] (input)
        [JsonProperty("tables")]
        public List<ReportTableCreate>? Tables { get; set; }

        //      C# -> CustomReportFiltersConfig? Filters
        // GraphQL -> filters: CustomReportFiltersConfig! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("filters")]
        public CustomReportFiltersConfig? Filters { get; set; }

        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean (scalar)
        [JsonProperty("isHidden")]
        public System.Boolean? IsHidden { get; set; }

        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean (scalar)
        [JsonProperty("isReadOnly")]
        public System.Boolean? IsReadOnly { get; set; }


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

    } // class CreateCustomReportInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types