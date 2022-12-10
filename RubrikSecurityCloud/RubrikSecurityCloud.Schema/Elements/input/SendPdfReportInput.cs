// SendPdfReportInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:43.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SendPdfReportInput

    public class SendPdfReportInput
    {
        #region members
        //      C# -> List<System.String>? RubrikRecipientUserIds
        // GraphQL -> rubrikRecipientUserIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("rubrikRecipientUserIds")]
        public List<System.String>? RubrikRecipientUserIds { get; set; }

        //      C# -> List<System.String>? NonRubrikRecipientEmailIds
        // GraphQL -> nonRubrikRecipientEmailIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nonRubrikRecipientEmailIds")]
        public List<System.String>? NonRubrikRecipientEmailIds { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("password")]
        public System.String? Password { get; set; }

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

    } // class SendPdfReportInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types