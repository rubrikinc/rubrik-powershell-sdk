// WebhookTemplateInput.cs
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
    #region WebhookTemplateInput

    public class WebhookTemplateInput: IInput
    {
        #region members

        //      C# -> System.Int32? TemplateId
        // GraphQL -> templateId: Int (scalar)
        [JsonProperty("templateId")]
        public System.Int32? TemplateId { get; set; }

        //      C# -> System.String? CustomTemplate
        // GraphQL -> customTemplate: String (scalar)
        [JsonProperty("customTemplate")]
        public System.String? CustomTemplate { get; set; }


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

    } // class WebhookTemplateInput
    #endregion

} // namespace RubrikSecurityCloud.Types