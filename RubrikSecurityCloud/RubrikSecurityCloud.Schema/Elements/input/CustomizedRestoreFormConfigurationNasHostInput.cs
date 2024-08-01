// CustomizedRestoreFormConfigurationNasHostInput.cs
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
    #region CustomizedRestoreFormConfigurationNasHostInput

    public class CustomizedRestoreFormConfigurationNasHostInput: IInput
    {
        #region members

        //      C# -> System.String? ApiPassword
        // GraphQL -> apiPassword: String (scalar)
        [JsonProperty("apiPassword")]
        public System.String? ApiPassword { get; set; }

        //      C# -> System.String? SharePassword
        // GraphQL -> sharePassword: String (scalar)
        [JsonProperty("sharePassword")]
        public System.String? SharePassword { get; set; }

        //      C# -> System.String? ShareUsername
        // GraphQL -> shareUsername: String (scalar)
        [JsonProperty("shareUsername")]
        public System.String? ShareUsername { get; set; }

        //      C# -> RestoreFormConfigurationNasHostInput? RestoreFormConfigurationNasHost
        // GraphQL -> restoreFormConfigurationNasHost: RestoreFormConfigurationNasHostInput (input)
        [JsonProperty("restoreFormConfigurationNasHost")]
        public RestoreFormConfigurationNasHostInput? RestoreFormConfigurationNasHost { get; set; }

        //      C# -> List<CustomizedRestoreFormConfigurationNasShareInput>? Shares
        // GraphQL -> shares: [CustomizedRestoreFormConfigurationNasShareInput!] (input)
        [JsonProperty("shares")]
        public List<CustomizedRestoreFormConfigurationNasShareInput>? Shares { get; set; }


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

    } // class CustomizedRestoreFormConfigurationNasHostInput
    #endregion

} // namespace RubrikSecurityCloud.Types