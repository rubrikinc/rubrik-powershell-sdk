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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> List<RiskLevelType>? PreviousRiskLevel
        // GraphQL -> previousRiskLevel: [RiskLevelType!] (enum)
        [JsonProperty("previousRiskLevel")]
        public List<RiskLevelType>? PreviousRiskLevel { get; set; }

        //      C# -> List<PrivilegeType>? PrivilegeTypesFilter
        // GraphQL -> privilegeTypesFilter: [PrivilegeType!] (enum)
        [JsonProperty("privilegeTypesFilter")]
        public List<PrivilegeType>? PrivilegeTypesFilter { get; set; }

        //      C# -> List<IdpType>? IdpTypesFilter
        // GraphQL -> idpTypesFilter: [IdpType!] (enum)
        [JsonProperty("idpTypesFilter")]
        public List<IdpType>? IdpTypesFilter { get; set; }

        //      C# -> List<System.String>? DomainFidsFilter
        // GraphQL -> domainFidsFilter: [String!] (scalar)
        [JsonProperty("domainFidsFilter")]
        public List<System.String>? DomainFidsFilter { get; set; }

        //      C# -> List<System.String>? Title
        // GraphQL -> title: [String!] (scalar)
        [JsonProperty("title")]
        public List<System.String>? Title { get; set; }

        //      C# -> List<System.String>? CloudAccountIds
        // GraphQL -> cloudAccountIds: [String!] (scalar)
        [JsonProperty("cloudAccountIds")]
        public List<System.String>? CloudAccountIds { get; set; }

        //      C# -> List<System.String>? DataTypeIds
        // GraphQL -> dataTypeIds: [String!] (scalar)
        [JsonProperty("dataTypeIds")]
        public List<System.String>? DataTypeIds { get; set; }

        //      C# -> List<ViolationSeverity>? ViolationSeverity
        // GraphQL -> violationSeverity: [ViolationSeverity!] (enum)
        [JsonProperty("violationSeverity")]
        public List<ViolationSeverity>? ViolationSeverity { get; set; }

        //      C# -> PrincipalFeature? FeatureFilter
        // GraphQL -> featureFilter: PrincipalFeature (enum)
        [JsonProperty("featureFilter")]
        public PrincipalFeature? FeatureFilter { get; set; }

        //      C# -> PrincipalStatus? StatusFilter
        // GraphQL -> statusFilter: PrincipalStatus (enum)
        [JsonProperty("statusFilter")]
        public PrincipalStatus? StatusFilter { get; set; }

        //      C# -> List<System.String>? EntityIds
        // GraphQL -> entityIds: [String!] (scalar)
        [JsonProperty("entityIds")]
        public List<System.String>? EntityIds { get; set; }

        //      C# -> List<PrincipalRiskySummaryPrincipalType>? PrincipalTypes
        // GraphQL -> principalTypes: [PrincipalRiskySummaryPrincipalType!] (enum)
        [JsonProperty("principalTypes")]
        public List<PrincipalRiskySummaryPrincipalType>? PrincipalTypes { get; set; }

        //      C# -> List<PrincipalOrigin>? PrincipalOrigins
        // GraphQL -> principalOrigins: [PrincipalOrigin!] (enum)
        [JsonProperty("principalOrigins")]
        public List<PrincipalOrigin>? PrincipalOrigins { get; set; }

        //      C# -> System.String? DirectParentOfPrincipal
        // GraphQL -> directParentOfPrincipal: String (scalar)
        [JsonProperty("directParentOfPrincipal")]
        public System.String? DirectParentOfPrincipal { get; set; }

        //      C# -> List<AccessVia>? AccessTypeFilter
        // GraphQL -> accessTypeFilter: [AccessVia!] (enum)
        [JsonProperty("accessTypeFilter")]
        public List<AccessVia>? AccessTypeFilter { get; set; }

        //      C# -> List<IdentityTag>? IdentityTags
        // GraphQL -> identityTags: [IdentityTag!] (enum)
        [JsonProperty("identityTags")]
        public List<IdentityTag>? IdentityTags { get; set; }

        //      C# -> List<IdentityStatus>? IdentityStatusFilter
        // GraphQL -> identityStatusFilter: [IdentityStatus!] (enum)
        [JsonProperty("identityStatusFilter")]
        public List<IdentityStatus>? IdentityStatusFilter { get; set; }

        //      C# -> List<NativeType>? NativeTypes
        // GraphQL -> nativeTypes: [NativeType!] (enum)
        [JsonProperty("nativeTypes")]
        public List<NativeType>? NativeTypes { get; set; }

        //      C# -> System.Boolean? NewlyAdded
        // GraphQL -> newlyAdded: Boolean (scalar)
        [JsonProperty("newlyAdded")]
        public System.Boolean? NewlyAdded { get; set; }

        //      C# -> List<MfaStrength>? EntraMfaStrength
        // GraphQL -> entraMfaStrength: [MfaStrength!] (enum)
        [JsonProperty("entraMfaStrength")]
        public List<MfaStrength>? EntraMfaStrength { get; set; }

        //      C# -> System.String? LinkedPrincipalId
        // GraphQL -> linkedPrincipalId: String (scalar)
        [JsonProperty("linkedPrincipalId")]
        public System.String? LinkedPrincipalId { get; set; }

        //      C# -> List<System.String>? OwnerPrincipalIds
        // GraphQL -> ownerPrincipalIds: [String!] (scalar)
        [JsonProperty("ownerPrincipalIds")]
        public List<System.String>? OwnerPrincipalIds { get; set; }

        //      C# -> System.Boolean? IncludeDeletedPrincipals
        // GraphQL -> includeDeletedPrincipals: Boolean (scalar)
        [JsonProperty("includeDeletedPrincipals")]
        public System.Boolean? IncludeDeletedPrincipals { get; set; }

        //      C# -> List<GpoStatusEnum>? GpoStatusFilter
        // GraphQL -> gpoStatusFilter: [GpoStatusEnum!] (enum)
        [JsonProperty("gpoStatusFilter")]
        public List<GpoStatusEnum>? GpoStatusFilter { get; set; }

        //      C# -> List<GpoLinkingStatusEnum>? GpoLinkingStatusFilter
        // GraphQL -> gpoLinkingStatusFilter: [GPOLinkingStatusEnum!] (enum)
        [JsonProperty("gpoLinkingStatusFilter")]
        public List<GpoLinkingStatusEnum>? GpoLinkingStatusFilter { get; set; }

        //      C# -> List<System.String>? Departments
        // GraphQL -> departments: [String!] (scalar)
        [JsonProperty("departments")]
        public List<System.String>? Departments { get; set; }

        //      C# -> System.String? EditorsForGpo
        // GraphQL -> editorsForGpo: String (scalar)
        [JsonProperty("editorsForGpo")]
        public System.String? EditorsForGpo { get; set; }

        //      C# -> List<System.String>? PolicyIds
        // GraphQL -> policyIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("policyIds")]
        public List<System.String>? PolicyIds { get; set; }

        //      C# -> TimeRangeInput? NativeCreationTime
        // GraphQL -> nativeCreationTime: TimeRangeInput (input)
        [JsonProperty("nativeCreationTime")]
        public TimeRangeInput? NativeCreationTime { get; set; }

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

    } // class PrincipalSummariesFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types