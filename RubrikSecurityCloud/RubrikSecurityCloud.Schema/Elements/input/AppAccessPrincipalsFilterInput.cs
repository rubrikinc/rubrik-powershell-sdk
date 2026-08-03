// AppAccessPrincipalsFilterInput.cs
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
    #region AppAccessPrincipalsFilterInput

    public class AppAccessPrincipalsFilterInput: IInput
    {
        #region members

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String (scalar)
        [JsonProperty("domainId")]
        public System.String? DomainId { get; set; }

        //      C# -> PrincipalRiskySummaryPrincipalType? PrincipalType
        // GraphQL -> principalType: PrincipalRiskySummaryPrincipalType (enum)
        [JsonProperty("principalType")]
        public PrincipalRiskySummaryPrincipalType? PrincipalType { get; set; }

        //      C# -> System.String? NameFilter
        // GraphQL -> nameFilter: String (scalar)
        [JsonProperty("nameFilter")]
        public System.String? NameFilter { get; set; }

        //      C# -> System.String? AppFilter
        // GraphQL -> appFilter: String (scalar)
        [JsonProperty("appFilter")]
        public System.String? AppFilter { get; set; }

        //      C# -> System.String? ParentPrincipalId
        // GraphQL -> parentPrincipalId: String (scalar)
        [JsonProperty("parentPrincipalId")]
        public System.String? ParentPrincipalId { get; set; }

        //      C# -> AccessPathType? AccessPathType
        // GraphQL -> accessPathType: AccessPathType (enum)
        [JsonProperty("accessPathType")]
        public AccessPathType? AccessPathType { get; set; }

        //      C# -> System.String? TimelineDate
        // GraphQL -> timelineDate: String (scalar)
        [JsonProperty("timelineDate")]
        public System.String? TimelineDate { get; set; }

        //      C# -> System.String? ActivityTimestamp
        // GraphQL -> activityTimestamp: String (scalar)
        [JsonProperty("activityTimestamp")]
        public System.String? ActivityTimestamp { get; set; }

        //      C# -> System.String? ActivityId
        // GraphQL -> activityId: String (scalar)
        [JsonProperty("activityId")]
        public System.String? ActivityId { get; set; }

        //      C# -> AppAccessNodeId? NodeId
        // GraphQL -> nodeId: AppAccessNodeId (enum)
        [JsonProperty("nodeId")]
        public AppAccessNodeId? NodeId { get; set; }

        //      C# -> IdentityAlertEventType? ActivityType
        // GraphQL -> activityType: IdentityAlertEventType (enum)
        [JsonProperty("activityType")]
        public IdentityAlertEventType? ActivityType { get; set; }

        //      C# -> System.String? TargetGroupId
        // GraphQL -> targetGroupId: String (scalar)
        [JsonProperty("targetGroupId")]
        public System.String? TargetGroupId { get; set; }

        //      C# -> System.String? TargetAppId
        // GraphQL -> targetAppId: String (scalar)
        [JsonProperty("targetAppId")]
        public System.String? TargetAppId { get; set; }


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

    } // class AppAccessPrincipalsFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types