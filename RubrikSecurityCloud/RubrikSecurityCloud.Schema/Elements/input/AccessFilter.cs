// AccessFilter.cs
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
    #region AccessFilter

    public class AccessFilter: IInput
    {
        #region members

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? ViolationId
        // GraphQL -> violationId: UUID (scalar)
        [JsonProperty("violationId")]
        public System.String? ViolationId { get; set; }

        //      C# -> System.String? IdentityId
        // GraphQL -> identityId: String (scalar)
        [JsonProperty("identityId")]
        public System.String? IdentityId { get; set; }

        //      C# -> System.String? AccessGrantingIdentityId
        // GraphQL -> accessGrantingIdentityId: String (scalar)
        [JsonProperty("accessGrantingIdentityId")]
        public System.String? AccessGrantingIdentityId { get; set; }

        //      C# -> List<RiskLevelType>? SensitivityLevels
        // GraphQL -> sensitivityLevels: [RiskLevelType!] (enum)
        [JsonProperty("sensitivityLevels")]
        public List<RiskLevelType>? SensitivityLevels { get; set; }

        //      C# -> System.String? DataCategoryId
        // GraphQL -> dataCategoryId: UUID (scalar)
        [JsonProperty("dataCategoryId")]
        public System.String? DataCategoryId { get; set; }

        //      C# -> AccessVia? AccessVia
        // GraphQL -> accessVia: AccessVia (enum)
        [JsonProperty("accessVia")]
        public AccessVia? AccessVia { get; set; }

        //      C# -> System.String? SearchNameQuery
        // GraphQL -> searchNameQuery: String (scalar)
        [JsonProperty("searchNameQuery")]
        public System.String? SearchNameQuery { get; set; }

        //      C# -> PrincipalRiskySummaryPrincipalType? PrincipalType
        // GraphQL -> principalType: PrincipalRiskySummaryPrincipalType (enum)
        [JsonProperty("principalType")]
        public PrincipalRiskySummaryPrincipalType? PrincipalType { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? TimelineDate
        // GraphQL -> timelineDate: String (scalar)
        [JsonProperty("timelineDate")]
        public System.String? TimelineDate { get; set; }


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

    } // class AccessFilter
    #endregion

} // namespace RubrikSecurityCloud.Types