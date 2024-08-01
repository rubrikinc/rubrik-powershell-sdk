// NotificationListFilterInput.cs
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
    #region NotificationListFilterInput

    public class NotificationListFilterInput: IInput
    {
        #region members

        //      C# -> NotificationReadStatus? ReadStatus
        // GraphQL -> readStatus: NotificationReadStatus (enum)
        [JsonProperty("readStatus")]
        public NotificationReadStatus? ReadStatus { get; set; }

        //      C# -> List<NotificationLevel>? Levels
        // GraphQL -> levels: [NotificationLevel!] (enum)
        [JsonProperty("levels")]
        public List<NotificationLevel>? Levels { get; set; }

        //      C# -> List<NotificationPriority>? Priorities
        // GraphQL -> priorities: [NotificationPriority!] (enum)
        [JsonProperty("priorities")]
        public List<NotificationPriority>? Priorities { get; set; }

        //      C# -> List<NotificationResourceType>? ResourceTypes
        // GraphQL -> resourceTypes: [NotificationResourceType!] (enum)
        [JsonProperty("resourceTypes")]
        public List<NotificationResourceType>? ResourceTypes { get; set; }

        //      C# -> NotificationSubtype? Subtype
        // GraphQL -> subtype: NotificationSubtype (enum)
        [JsonProperty("subtype")]
        public NotificationSubtype? Subtype { get; set; }

        //      C# -> List<NotificationApplication>? Applications
        // GraphQL -> applications: [NotificationApplication!] (enum)
        [JsonProperty("applications")]
        public List<NotificationApplication>? Applications { get; set; }


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

    } // class NotificationListFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types