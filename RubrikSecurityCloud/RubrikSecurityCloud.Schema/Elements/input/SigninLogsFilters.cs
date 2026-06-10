// SigninLogsFilters.cs
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
    #region SigninLogsFilters

    public class SigninLogsFilters: IInput
    {
        #region members

        //      C# -> List<System.String>? UserSids
        // GraphQL -> userSids: [String!] (scalar)
        [JsonProperty("userSids")]
        public List<System.String>? UserSids { get; set; }

        //      C# -> List<EventProvider>? Providers
        // GraphQL -> providers: [EventProvider!] (enum)
        [JsonProperty("providers")]
        public List<EventProvider>? Providers { get; set; }

        //      C# -> List<System.String>? EventTypes
        // GraphQL -> eventTypes: [String!] (scalar)
        [JsonProperty("eventTypes")]
        public List<System.String>? EventTypes { get; set; }

        //      C# -> List<SigninLogResult>? Results
        // GraphQL -> results: [SigninLogResult!] (enum)
        [JsonProperty("results")]
        public List<SigninLogResult>? Results { get; set; }

        //      C# -> List<System.String>? TenantIds
        // GraphQL -> tenantIds: [String!] (scalar)
        [JsonProperty("tenantIds")]
        public List<System.String>? TenantIds { get; set; }

        //      C# -> List<SigninLogRiskLevel>? RiskLevels
        // GraphQL -> riskLevels: [SigninLogRiskLevel!] (enum)
        [JsonProperty("riskLevels")]
        public List<SigninLogRiskLevel>? RiskLevels { get; set; }

        //      C# -> List<System.String>? ApplicationNames
        // GraphQL -> applicationNames: [String!] (scalar)
        [JsonProperty("applicationNames")]
        public List<System.String>? ApplicationNames { get; set; }

        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!] (scalar)
        [JsonProperty("ipAddresses")]
        public List<System.String>? IpAddresses { get; set; }

        //      C# -> List<System.String>? Countries
        // GraphQL -> countries: [String!] (scalar)
        [JsonProperty("countries")]
        public List<System.String>? Countries { get; set; }

        //      C# -> List<System.String>? Locations
        // GraphQL -> locations: [String!] (scalar)
        [JsonProperty("locations")]
        public List<System.String>? Locations { get; set; }

        //      C# -> List<System.String>? DisplayNames
        // GraphQL -> displayNames: [String!] (scalar)
        [JsonProperty("displayNames")]
        public List<System.String>? DisplayNames { get; set; }

        //      C# -> System.String? DisplayNameSearchTerm
        // GraphQL -> displayNameSearchTerm: String (scalar)
        [JsonProperty("displayNameSearchTerm")]
        public System.String? DisplayNameSearchTerm { get; set; }

        //      C# -> List<System.String>? UserIds
        // GraphQL -> userIds: [String!] (scalar)
        [JsonProperty("userIds")]
        public List<System.String>? UserIds { get; set; }

        //      C# -> List<System.String>? ErrorCodes
        // GraphQL -> errorCodes: [String!] (scalar)
        [JsonProperty("errorCodes")]
        public List<System.String>? ErrorCodes { get; set; }

        //      C# -> List<System.String>? LogonTypes
        // GraphQL -> logonTypes: [String!] (scalar)
        [JsonProperty("logonTypes")]
        public List<System.String>? LogonTypes { get; set; }

        //      C# -> List<System.String>? DeviceNames
        // GraphQL -> deviceNames: [String!] (scalar)
        [JsonProperty("deviceNames")]
        public List<System.String>? DeviceNames { get; set; }

        //      C# -> List<System.String>? ResourceNames
        // GraphQL -> resourceNames: [String!] (scalar)
        [JsonProperty("resourceNames")]
        public List<System.String>? ResourceNames { get; set; }

        //      C# -> List<System.String>? ProcessNames
        // GraphQL -> processNames: [String!] (scalar)
        [JsonProperty("processNames")]
        public List<System.String>? ProcessNames { get; set; }

        //      C# -> List<System.String>? AuthenticationMethods
        // GraphQL -> authenticationMethods: [String!] (scalar)
        [JsonProperty("authenticationMethods")]
        public List<System.String>? AuthenticationMethods { get; set; }

        //      C# -> List<System.String>? MfaStatuses
        // GraphQL -> mfaStatuses: [String!] (scalar)
        [JsonProperty("mfaStatuses")]
        public List<System.String>? MfaStatuses { get; set; }

        //      C# -> List<SigninLogFailureCategory>? FailureCategories
        // GraphQL -> failureCategories: [SigninLogFailureCategory!] (enum)
        [JsonProperty("failureCategories")]
        public List<SigninLogFailureCategory>? FailureCategories { get; set; }

        //      C# -> List<System.String>? EventIds
        // GraphQL -> eventIds: [String!] (scalar)
        [JsonProperty("eventIds")]
        public List<System.String>? EventIds { get; set; }


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

    } // class SigninLogsFilters
    #endregion

} // namespace RubrikSecurityCloud.Types