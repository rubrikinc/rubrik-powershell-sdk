// CalendarRestoreConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:32.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region CalendarRestoreConfig

    public class CalendarRestoreConfig
    {
        #region members
        //      C# -> List<EventInfo>? EventsToRestore
        // GraphQL -> eventsToRestore: [EventInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("eventsToRestore")]
        public List<EventInfo>? EventsToRestore { get; set; }

        //      C# -> List<CalendarInfo>? CalendarsToRestore
        // GraphQL -> calendarsToRestore: [CalendarInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("calendarsToRestore")]
        public List<CalendarInfo>? CalendarsToRestore { get; set; }

        //      C# -> List<CalendarGroupInfo>? CalendarGroupsToRestore
        // GraphQL -> calendarGroupsToRestore: [CalendarGroupInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("calendarGroupsToRestore")]
        public List<CalendarGroupInfo>? CalendarGroupsToRestore { get; set; }

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

    } // class CalendarRestoreConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types