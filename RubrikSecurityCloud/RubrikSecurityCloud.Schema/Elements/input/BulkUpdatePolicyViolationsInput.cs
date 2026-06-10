// BulkUpdatePolicyViolationsInput.cs
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
    #region BulkUpdatePolicyViolationsInput

    public class BulkUpdatePolicyViolationsInput: IInput
    {
        #region members

        //      C# -> List<System.String>? PolicyViolationIds
        // GraphQL -> policyViolationIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("policyViolationIds")]
        public List<System.String>? PolicyViolationIds { get; set; }

        //      C# -> PolicyViolationStatus? NewPolicyViolationStatus
        // GraphQL -> newPolicyViolationStatus: PolicyViolationStatus! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("newPolicyViolationStatus")]
        public PolicyViolationStatus? NewPolicyViolationStatus { get; set; }


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

    } // class BulkUpdatePolicyViolationsInput
    #endregion

} // namespace RubrikSecurityCloud.Types