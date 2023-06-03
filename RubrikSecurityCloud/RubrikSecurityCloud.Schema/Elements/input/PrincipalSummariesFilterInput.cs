// PrincipalSummariesFilterInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region PrincipalSummariesFilterInput

    public class PrincipalSummariesFilterInput: IInput
    {
        #region members

        //      C# -> PrincipalRiskySummaryPrincipalType? PrincipalType
        // GraphQL -> principalType: PrincipalRiskySummaryPrincipalType (enum)
        [JsonProperty("principalType")]
        public PrincipalRiskySummaryPrincipalType? PrincipalType { get; set; }

        //      C# -> List<RiskLevelType>? RiskLevel
        // GraphQL -> riskLevel: [RiskLevelType!] (enum)
        [JsonProperty("riskLevel")]
        public List<RiskLevelType>? RiskLevel { get; set; }

        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String (scalar)
        [JsonProperty("principalName")]
        public System.String? PrincipalName { get; set; }

        //      C# -> List<System.String>? Sids
        // GraphQL -> sids: [String!] (scalar)
        [JsonProperty("sids")]
        public List<System.String>? Sids { get; set; }

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!] (scalar)
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> List<System.String>? PolicyIds
        // GraphQL -> policyIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("policyIds")]
        public List<System.String>? PolicyIds { get; set; }


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

    } // class PrincipalSummariesFilterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types