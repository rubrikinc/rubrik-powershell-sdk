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

        //      C# -> ReadStatus? ReadStatus
        // GraphQL -> readStatus: ReadStatus! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("readStatus")]
        public ReadStatus? ReadStatus { get; set; }

        //      C# -> List<NotificationType>? NotificationTypes
        // GraphQL -> notificationTypes: [NotificationType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("notificationTypes")]
        public List<NotificationType>? NotificationTypes { get; set; }

        //      C# -> List<NotificationPriority>? Priorities
        // GraphQL -> priorities: [NotificationPriority!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("priorities")]
        public List<NotificationPriority>? Priorities { get; set; }

        //      C# -> List<NotificationResourceType>? ResourceTypes
        // GraphQL -> resourceTypes: [NotificationResourceType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("resourceTypes")]
        public List<NotificationResourceType>? ResourceTypes { get; set; }


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