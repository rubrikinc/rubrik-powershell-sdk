// UpdateTprConfigurationInput.cs
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
    #region UpdateTprConfigurationInput

    public class UpdateTprConfigurationInput: IInput
    {
        #region members

        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String (scalar)
        [JsonProperty("organizationId")]
        public System.String? OrganizationId { get; set; }

        //      C# -> System.Int32? ExecutionMaxTimeoutHours
        // GraphQL -> executionMaxTimeoutHours: Int (scalar)
        [JsonProperty("executionMaxTimeoutHours")]
        public System.Int32? ExecutionMaxTimeoutHours { get; set; }

        //      C# -> System.Int32? RequestTimeoutHours
        // GraphQL -> requestTimeoutHours: Int (scalar)
        [JsonProperty("requestTimeoutHours")]
        public System.Int32? RequestTimeoutHours { get; set; }

        //      C# -> System.Int32? ReminderHours
        // GraphQL -> reminderHours: Int (scalar)
        [JsonProperty("reminderHours")]
        public System.Int32? ReminderHours { get; set; }

        //      C# -> System.Int32? StaticQuorumApprovalsRequirement
        // GraphQL -> staticQuorumApprovalsRequirement: Int (scalar)
        [JsonProperty("staticQuorumApprovalsRequirement")]
        public System.Int32? StaticQuorumApprovalsRequirement { get; set; }


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

    } // class UpdateTprConfigurationInput
    #endregion

} // namespace RubrikSecurityCloud.Types