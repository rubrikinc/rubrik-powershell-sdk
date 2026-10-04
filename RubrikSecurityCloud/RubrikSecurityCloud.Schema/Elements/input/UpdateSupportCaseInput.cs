// UpdateSupportCaseInput.cs
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
    #region UpdateSupportCaseInput

    public class UpdateSupportCaseInput: IInput
    {
        #region members

        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("caseId")]
        public System.String? CaseId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> List<SupportCaseAttachmentInput>? Attachments
        // GraphQL -> attachments: [SupportCaseAttachmentInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("attachments")]
        public List<SupportCaseAttachmentInput>? Attachments { get; set; }


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

    } // class UpdateSupportCaseInput
    #endregion

} // namespace RubrikSecurityCloud.Types