// SendScheduledReportAsyncInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SendScheduledReportAsyncInput

    public class SendScheduledReportAsyncInput: IInput
    {
        #region members

        //      C# -> System.Int32? ReportId
        // GraphQL -> reportId: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("reportId")]
        public System.Int32? ReportId { get; set; }

        //      C# -> List<System.String>? RubrikUserIds
        // GraphQL -> rubrikUserIds: [String!] (scalar)
        [JsonProperty("rubrikUserIds")]
        public List<System.String>? RubrikUserIds { get; set; }

        //      C# -> List<System.String>? NonRubrikUserEmails
        // GraphQL -> nonRubrikUserEmails: [String!] (scalar)
        [JsonProperty("nonRubrikUserEmails")]
        public List<System.String>? NonRubrikUserEmails { get; set; }


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

    } // class SendScheduledReportAsyncInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types