// WebhookAuditSubscriptionInput.cs
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
    #region WebhookAuditSubscriptionInput

    public class WebhookAuditSubscriptionInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsSubscribedToAllAudits
        // GraphQL -> isSubscribedToAllAudits: Boolean (scalar)
        [JsonProperty("isSubscribedToAllAudits")]
        public System.Boolean? IsSubscribedToAllAudits { get; set; }

        //      C# -> System.Boolean? IsSubscribedToAllObjectTypes
        // GraphQL -> isSubscribedToAllObjectTypes: Boolean (scalar)
        [JsonProperty("isSubscribedToAllObjectTypes")]
        public System.Boolean? IsSubscribedToAllObjectTypes { get; set; }

        //      C# -> List<AuditType>? AuditTypes
        // GraphQL -> auditTypes: [AuditType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("auditTypes")]
        public List<AuditType>? AuditTypes { get; set; }

        //      C# -> List<AuditObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [AuditObjectType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectTypes")]
        public List<AuditObjectType>? ObjectTypes { get; set; }

        //      C# -> List<AuditSeverity>? Severities
        // GraphQL -> severities: [AuditSeverity!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("severities")]
        public List<AuditSeverity>? Severities { get; set; }

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

    } // class WebhookAuditSubscriptionInput
    #endregion

} // namespace RubrikSecurityCloud.Types