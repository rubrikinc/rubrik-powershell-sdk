// AzureAdReverseRelationshipType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum AzureAdReverseRelationshipType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_PACKAGE_ASSIGNMENT_OF")]
        ACCESS_PACKAGE_ASSIGNMENT_OF,

        [EnumMember(Value = "ACCESS_PACKAGE_POLICY_PRINCIPAL_OF")]
        ACCESS_PACKAGE_POLICY_PRINCIPAL_OF,

        [EnumMember(Value = "ACCESS_PACKAGE_RESOURCE_OF")]
        ACCESS_PACKAGE_RESOURCE_OF,

        [EnumMember(Value = "APPLIED_POLICY")]
        APPLIED_POLICY,

        [EnumMember(Value = "BOUND_TO_CONFIG")]
        BOUND_TO_CONFIG,

        [EnumMember(Value = "CATALOG_ROLE_ASSIGNMENT_OF")]
        CATALOG_ROLE_ASSIGNMENT_OF,

        [EnumMember(Value = "INCLUDED_IN_POLICY")]
        INCLUDED_IN_POLICY,

        [EnumMember(Value = "INCOMPATIBLE_ACCESS_PACKAGE_OF")]
        INCOMPATIBLE_ACCESS_PACKAGE_OF,

        [EnumMember(Value = "INCOMPATIBLE_GROUP_OF")]
        INCOMPATIBLE_GROUP_OF,

        [EnumMember(Value = "INTUNE_ROLE_ASSIGNMENT_MEMBER_OF")]
        INTUNE_ROLE_ASSIGNMENT_MEMBER_OF,

        [EnumMember(Value = "INTUNE_ROLE_ASSIGNMENT_SCOPE_OF")]
        INTUNE_ROLE_ASSIGNMENT_SCOPE_OF,

        [EnumMember(Value = "INTUNE_ROLE_ASSIGNMENT_SCOPE_TAG_OF")]
        INTUNE_ROLE_ASSIGNMENT_SCOPE_TAG_OF,

        [EnumMember(Value = "MEMBER_OF")]
        MEMBER_OF,

        [EnumMember(Value = "OWNER_OF")]
        OWNER_OF,

        [EnumMember(Value = "PIM_POLICY_APPROVER_OF")]
        PIM_POLICY_APPROVER_OF,

        [EnumMember(Value = "POLICY_SCRIPT_OF")]
        POLICY_SCRIPT_OF,

        [EnumMember(Value = "REGISTERED_CATALOG_RESOURCE_OF")]
        REGISTERED_CATALOG_RESOURCE_OF,

        [EnumMember(Value = "RESOURCE_ROLE_SCOPE_OF")]
        RESOURCE_ROLE_SCOPE_OF,

        [EnumMember(Value = "REUSABLE_SETTING_REFERENCE_OF")]
        REUSABLE_SETTING_REFERENCE_OF,

        [EnumMember(Value = "REVERSE_RELATIONSHIP_TYPE_UNKNOWN")]
        REVERSE_RELATIONSHIP_TYPE_UNKNOWN,

        [EnumMember(Value = "ROLE_ASSIGNMENT_OF")]
        ROLE_ASSIGNMENT_OF,

        [EnumMember(Value = "ROLE_SCOPE_TAG_REFERENCE_OF")]
        ROLE_SCOPE_TAG_REFERENCE_OF,

        [EnumMember(Value = "SCOPE_TAG_ASSIGNMENT_OF")]
        SCOPE_TAG_ASSIGNMENT_OF


    } // enum AzureAdReverseRelationshipType

} // namespace RubrikSecurityCloud.Types