// CalendarSearchFilter.cs
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
    #region CalendarSearchFilter

    public class CalendarSearchFilter: IInput
    {
        #region members

        //      C# -> CalendarSearchKeywordFilter? SearchKeywordFilter
        // GraphQL -> searchKeywordFilter: CalendarSearchKeywordFilter (input)
        [JsonProperty("searchKeywordFilter")]
        public CalendarSearchKeywordFilter? SearchKeywordFilter { get; set; }

        //      C# -> List<CalendarEmailAddressFilter>? EmailAddresses
        // GraphQL -> emailAddresses: [CalendarEmailAddressFilter!] (input)
        [JsonProperty("emailAddresses")]
        public List<CalendarEmailAddressFilter>? EmailAddresses { get; set; }

        //      C# -> TimeRangeFilter? Timerange
        // GraphQL -> timerange: TimeRangeFilter (input)
        [JsonProperty("timerange")]
        public TimeRangeFilter? Timerange { get; set; }

        //      C# -> CalendarSearchObjectFilter? SearchObjectFilter
        // GraphQL -> searchObjectFilter: CalendarSearchObjectFilter (input)
        [JsonProperty("searchObjectFilter")]
        public CalendarSearchObjectFilter? SearchObjectFilter { get; set; }

        //      C# -> CalendarRecurrenceFilter? RecurrenceFilter
        // GraphQL -> recurrenceFilter: CalendarRecurrenceFilter (input)
        [JsonProperty("recurrenceFilter")]
        public CalendarRecurrenceFilter? RecurrenceFilter { get; set; }


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

    } // class CalendarSearchFilter
    #endregion

} // namespace Rubrik.SecurityCloud.Types