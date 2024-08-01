// InviteUsersToTrialInput.cs
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
    #region InviteUsersToTrialInput

    public class InviteUsersToTrialInput: IInput
    {
        #region members

        //      C# -> System.String? TrialId
        // GraphQL -> trialId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("trialId")]
        public System.String? TrialId { get; set; }

        //      C# -> List<System.String>? Emails
        // GraphQL -> emails: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("emails")]
        public List<System.String>? Emails { get; set; }


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

    } // class InviteUsersToTrialInput
    #endregion

} // namespace RubrikSecurityCloud.Types