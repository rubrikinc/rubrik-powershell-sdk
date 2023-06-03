// CustomizedRestoreFormConfigurationSmtpInput.cs
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
    #region CustomizedRestoreFormConfigurationSmtpInput

    public class CustomizedRestoreFormConfigurationSmtpInput: IInput
    {
        #region members

        //      C# -> System.String? SmtpPassword
        // GraphQL -> smtpPassword: String (scalar)
        [JsonProperty("smtpPassword")]
        public System.String? SmtpPassword { get; set; }

        //      C# -> System.String? SmtpUsername
        // GraphQL -> smtpUsername: String (scalar)
        [JsonProperty("smtpUsername")]
        public System.String? SmtpUsername { get; set; }

        //      C# -> RestoreFormConfigurationSmtpInput? RestoreFormConfigurationSmtp
        // GraphQL -> restoreFormConfigurationSmtp: RestoreFormConfigurationSmtpInput (input)
        [JsonProperty("restoreFormConfigurationSmtp")]
        public RestoreFormConfigurationSmtpInput? RestoreFormConfigurationSmtp { get; set; }


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

    } // class CustomizedRestoreFormConfigurationSmtpInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types