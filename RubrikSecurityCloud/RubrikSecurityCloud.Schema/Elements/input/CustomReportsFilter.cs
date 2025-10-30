// CustomReportsFilter.cs
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
    #region CustomReportsFilter

    public class CustomReportsFilter: IInput
    {
        #region members

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }

        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType (enum)
        [JsonProperty("reportViewType")]
        public PolarisReportViewType? ReportViewType { get; set; }

        //      C# -> ReportCategory? ReportCategory
        // GraphQL -> reportCategory: ReportCategory (enum)
        [JsonProperty("reportCategory")]
        public ReportCategory? ReportCategory { get; set; }

        //      C# -> ReportRoomType? ReportRoom
        // GraphQL -> reportRoom: ReportRoomType (enum)
        [JsonProperty("reportRoom")]
        public ReportRoomType? ReportRoom { get; set; }

        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String (scalar)
        [JsonProperty("createdBy")]
        public System.String? CreatedBy { get; set; }


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

    } // class CustomReportsFilter
    #endregion

} // namespace RubrikSecurityCloud.Types