// CreateSupportCaseInput.cs
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
    #region CreateSupportCaseInput

    public class CreateSupportCaseInput: IInput
    {
        #region members

        //      C# -> System.String? Subject
        // GraphQL -> subject: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subject")]
        public System.String? Subject { get; set; }

        //      C# -> NewCaseType? CaseType
        // GraphQL -> caseType: NewCaseType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("caseType")]
        public NewCaseType? CaseType { get; set; }

        //      C# -> NewCasePriority? Priority
        // GraphQL -> priority: NewCasePriority! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("priority")]
        public NewCasePriority? Priority { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> NewCaseContactMethod? ContactMethod
        // GraphQL -> contactMethod: NewCaseContactMethod! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("contactMethod")]
        public NewCaseContactMethod? ContactMethod { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("description")]
        public System.String? Description { get; set; }


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

    } // class CreateSupportCaseInput
    #endregion

} // namespace RubrikSecurityCloud.Types