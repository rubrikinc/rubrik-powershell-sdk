// ListPolicyViolationsFilter.cs
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
    #region ListPolicyViolationsFilter

    public class ListPolicyViolationsFilter: IInput
    {
        #region members

        //      C# -> List<System.String>? PolicyIds
        // GraphQL -> policyIds: [String!] (scalar)
        [JsonProperty("policyIds")]
        public List<System.String>? PolicyIds { get; set; }

        //      C# -> List<System.String>? ResourceIds
        // GraphQL -> resourceIds: [String!] (scalar)
        [JsonProperty("resourceIds")]
        public List<System.String>? ResourceIds { get; set; }

        //      C# -> List<PolicyViolationStatus>? Statuses
        // GraphQL -> statuses: [PolicyViolationStatus!] (enum)
        [JsonProperty("statuses")]
        public List<PolicyViolationStatus>? Statuses { get; set; }

        //      C# -> List<System.String>? PolicyViolationIds
        // GraphQL -> policyViolationIds: [String!] (scalar)
        [JsonProperty("policyViolationIds")]
        public List<System.String>? PolicyViolationIds { get; set; }

        //      C# -> List<PolicyResourceType>? ResourceTypes
        // GraphQL -> resourceTypes: [PolicyResourceType!] (enum)
        [JsonProperty("resourceTypes")]
        public List<PolicyResourceType>? ResourceTypes { get; set; }

        //      C# -> List<SensitivityLevel>? SensitivityLevels
        // GraphQL -> sensitivityLevels: [SensitivityLevel!] (enum)
        [JsonProperty("sensitivityLevels")]
        public List<SensitivityLevel>? SensitivityLevels { get; set; }

        //      C# -> PolicyDateTimeRange? DetectionDateRange
        // GraphQL -> detectionDateRange: PolicyDateTimeRange (input)
        [JsonProperty("detectionDateRange")]
        public PolicyDateTimeRange? DetectionDateRange { get; set; }

        //      C# -> PolicyDateTimeRange? UpdateDateRange
        // GraphQL -> updateDateRange: PolicyDateTimeRange (input)
        [JsonProperty("updateDateRange")]
        public PolicyDateTimeRange? UpdateDateRange { get; set; }

        //      C# -> PolicyResourceType? ResourceType
        // GraphQL -> resourceType: PolicyResourceType (enum)
        [JsonProperty("resourceType")]
        public PolicyResourceType? ResourceType { get; set; }

        //      C# -> System.String? ParentViolationId
        // GraphQL -> parentViolationId: String (scalar)
        [JsonProperty("parentViolationId")]
        public System.String? ParentViolationId { get; set; }

        //      C# -> List<System.String>? DataCategoryIds
        // GraphQL -> dataCategoryIds: [String!] (scalar)
        [JsonProperty("dataCategoryIds")]
        public List<System.String>? DataCategoryIds { get; set; }

        //      C# -> List<System.String>? DataTypeIds
        // GraphQL -> dataTypeIds: [String!] (scalar)
        [JsonProperty("dataTypeIds")]
        public List<System.String>? DataTypeIds { get; set; }

        //      C# -> List<System.String>? DocumentTypeIds
        // GraphQL -> documentTypeIds: [String!] (scalar)
        [JsonProperty("documentTypeIds")]
        public List<System.String>? DocumentTypeIds { get; set; }

        //      C# -> System.String? OriginId
        // GraphQL -> originId: String (scalar)
        [JsonProperty("originId")]
        public System.String? OriginId { get; set; }

        //      C# -> List<System.String>? OriginIds
        // GraphQL -> originIds: [String!] (scalar)
        [JsonProperty("originIds")]
        public List<System.String>? OriginIds { get; set; }

        //      C# -> System.String? PolicyViolationNameSearch
        // GraphQL -> policyViolationNameSearch: String (scalar)
        [JsonProperty("policyViolationNameSearch")]
        public System.String? PolicyViolationNameSearch { get; set; }

        //      C# -> List<PolicyViolationStatusReason>? StatusReasons
        // GraphQL -> statusReasons: [PolicyViolationStatusReason!] (enum)
        [JsonProperty("statusReasons")]
        public List<PolicyViolationStatusReason>? StatusReasons { get; set; }

        //      C# -> List<System.String>? TicketNumbers
        // GraphQL -> ticketNumbers: [String!] (scalar)
        [JsonProperty("ticketNumbers")]
        public List<System.String>? TicketNumbers { get; set; }

        //      C# -> List<System.String>? ViolationNames
        // GraphQL -> violationNames: [String!] (scalar)
        [JsonProperty("violationNames")]
        public List<System.String>? ViolationNames { get; set; }

        //      C# -> PolicyDateTimeRange? LastSeenAtDateRange
        // GraphQL -> lastSeenAtDateRange: PolicyDateTimeRange (input)
        [JsonProperty("lastSeenAtDateRange")]
        public PolicyDateTimeRange? LastSeenAtDateRange { get; set; }


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

    } // class ListPolicyViolationsFilter
    #endregion

} // namespace RubrikSecurityCloud.Types