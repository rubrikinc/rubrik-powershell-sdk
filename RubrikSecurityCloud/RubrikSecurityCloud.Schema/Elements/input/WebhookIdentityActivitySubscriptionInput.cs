// WebhookIdentityActivitySubscriptionInput.cs
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
    #region WebhookIdentityActivitySubscriptionInput

    public class WebhookIdentityActivitySubscriptionInput: IInput
    {
        #region members

        //      C# -> WebhookTemplateInfoInput? TemplateInfo
        // GraphQL -> templateInfo: WebhookTemplateInfoInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("templateInfo")]
        public WebhookTemplateInfoInput? TemplateInfo { get; set; }

        //      C# -> List<LambdaEventActionType>? ActionTypes
        // GraphQL -> actionTypes: [LambdaEventActionType!] (enum)
        [JsonProperty("actionTypes")]
        public List<LambdaEventActionType>? ActionTypes { get; set; }

        //      C# -> List<EventProvider>? ActivityProviders
        // GraphQL -> activityProviders: [EventProvider!] (enum)
        [JsonProperty("activityProviders")]
        public List<EventProvider>? ActivityProviders { get; set; }


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

    } // class WebhookIdentityActivitySubscriptionInput
    #endregion

} // namespace RubrikSecurityCloud.Types