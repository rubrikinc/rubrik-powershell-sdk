// WebhookEventSubscriptionInput.cs
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
    #region WebhookEventSubscriptionInput

    public class WebhookEventSubscriptionInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsSubscribedToAllEvents
        // GraphQL -> isSubscribedToAllEvents: Boolean (scalar)
        [JsonProperty("isSubscribedToAllEvents")]
        public System.Boolean? IsSubscribedToAllEvents { get; set; }

        //      C# -> System.Boolean? IsSubscribedToAllObjectTypes
        // GraphQL -> isSubscribedToAllObjectTypes: Boolean (scalar)
        [JsonProperty("isSubscribedToAllObjectTypes")]
        public System.Boolean? IsSubscribedToAllObjectTypes { get; set; }

        //      C# -> List<EventType>? EventTypes
        // GraphQL -> eventTypes: [EventType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("eventTypes")]
        public List<EventType>? EventTypes { get; set; }

        //      C# -> List<EventObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [EventObjectType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectTypes")]
        public List<EventObjectType>? ObjectTypes { get; set; }

        //      C# -> List<EventSeverity>? Severities
        // GraphQL -> severities: [EventSeverity!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("severities")]
        public List<EventSeverity>? Severities { get; set; }

        //      C# -> WebhookTemplateInfoInput? TemplateInfo
        // GraphQL -> templateInfo: WebhookTemplateInfoInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("templateInfo")]
        public WebhookTemplateInfoInput? TemplateInfo { get; set; }


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

    } // class WebhookEventSubscriptionInput
    #endregion

} // namespace RubrikSecurityCloud.Types