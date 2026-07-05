// ActionInput.cs
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
    #region ActionInput

    public class ActionInput: IInput
    {
        #region members

        //      C# -> RemediationType? RemediationType
        // GraphQL -> remediationType: RemediationType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("remediationType")]
        public RemediationType? RemediationType { get; set; }

        //      C# -> RemediationDetailsInput? RemediationDetails
        // GraphQL -> remediationDetails: RemediationDetailsInput (input)
        [JsonProperty("remediationDetails")]
        public RemediationDetailsInput? RemediationDetails { get; set; }


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

    } // class ActionInput
    #endregion

} // namespace RubrikSecurityCloud.Types