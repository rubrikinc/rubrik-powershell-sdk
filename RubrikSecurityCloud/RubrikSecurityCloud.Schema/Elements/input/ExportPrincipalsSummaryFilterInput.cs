// ExportPrincipalsSummaryFilterInput.cs
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
    #region ExportPrincipalsSummaryFilterInput

    public class ExportPrincipalsSummaryFilterInput: IInput
    {
        #region members

        //      C# -> List<RiskLevelType>? RiskLevel
        // GraphQL -> riskLevel: [RiskLevelType!] (enum)
        [JsonProperty("riskLevel")]
        public List<RiskLevelType>? RiskLevel { get; set; }

        //      C# -> List<System.String>? PolicyIds
        // GraphQL -> policyIds: [String!] (scalar)
        [JsonProperty("policyIds")]
        public List<System.String>? PolicyIds { get; set; }

        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String (scalar)
        [JsonProperty("principalName")]
        public System.String? PrincipalName { get; set; }

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!] (scalar)
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> PrincipalSummaryCategoryType? PrincipalSummaryCategory
        // GraphQL -> principalSummaryCategory: PrincipalSummaryCategoryType (enum)
        [JsonProperty("principalSummaryCategory")]
        public PrincipalSummaryCategoryType? PrincipalSummaryCategory { get; set; }


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

    } // class ExportPrincipalsSummaryFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types