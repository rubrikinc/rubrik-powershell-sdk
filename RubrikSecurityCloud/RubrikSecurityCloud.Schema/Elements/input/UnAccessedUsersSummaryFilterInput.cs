// UnAccessedUsersSummaryFilterInput.cs
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
    #region UnAccessedUsersSummaryFilterInput

    public class UnAccessedUsersSummaryFilterInput: IInput
    {
        #region members

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? UserNamePrefix
        // GraphQL -> userNamePrefix: String (scalar)
        [JsonProperty("userNamePrefix")]
        public System.String? UserNamePrefix { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? Sid
        // GraphQL -> sid: String (scalar)
        [JsonProperty("sid")]
        public System.String? Sid { get; set; }

        //      C# -> List<ActivityThreshold>? ActivityThresholds
        // GraphQL -> activityThresholds: [ActivityThreshold!] (enum)
        [JsonProperty("activityThresholds")]
        public List<ActivityThreshold>? ActivityThresholds { get; set; }

        //      C# -> RiskLevelType? UserRisk
        // GraphQL -> userRisk: RiskLevelType (enum)
        [JsonProperty("userRisk")]
        public RiskLevelType? UserRisk { get; set; }

        //      C# -> RiskLevelType? FileRisk
        // GraphQL -> fileRisk: RiskLevelType (enum)
        [JsonProperty("fileRisk")]
        public RiskLevelType? FileRisk { get; set; }


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

    } // class UnAccessedUsersSummaryFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types