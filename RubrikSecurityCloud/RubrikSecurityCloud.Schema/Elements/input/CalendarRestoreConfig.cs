// CalendarRestoreConfig.cs
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
    #region CalendarRestoreConfig

    public class CalendarRestoreConfig: IInput
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

        //      C# -> System.Boolean? SkipRifItems
        // GraphQL -> skipRifItems: Boolean (scalar)
        [JsonProperty("skipRifItems")]
        public System.Boolean? SkipRifItems { get; set; }


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

} // namespace RubrikSecurityCloud.Types