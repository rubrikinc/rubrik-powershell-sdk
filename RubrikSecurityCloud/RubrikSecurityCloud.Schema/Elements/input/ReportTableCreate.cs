// ReportTableCreate.cs
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
    #region ReportTableCreate

    public class ReportTableCreate: IInput
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

        //      C# -> List<GroupByFieldEnum>? GroupBy
        // GraphQL -> groupBy: [GroupByFieldEnum!] (enum)
        [JsonProperty("groupBy")]
        public List<GroupByFieldEnum>? GroupBy { get; set; }

        //      C# -> List<ReportTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [ReportTableColumnEnum!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("selectedColumns")]
        public List<ReportTableColumnEnum>? SelectedColumns { get; set; }

        //      C# -> SortByFieldEnum? SortBy
        // GraphQL -> sortBy: SortByFieldEnum (enum)
        [JsonProperty("sortBy")]
        public SortByFieldEnum? SortBy { get; set; }

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

    } // class ReportTableCreate
    #endregion

} // namespace RubrikSecurityCloud.Types