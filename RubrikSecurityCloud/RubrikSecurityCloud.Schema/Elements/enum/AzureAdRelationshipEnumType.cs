// AzureAdRelationshipEnumType.cs
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
    public enum AzureAdRelationshipEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_PACKAGE_POLICY_PRINCIPAL")]
        ACCESS_PACKAGE_POLICY_PRINCIPAL,

        [EnumMember(Value = "APP_ROLE_ASSIGNED_TO")]
        APP_ROLE_ASSIGNED_TO,

        [EnumMember(Value = "APP_ROLE_ASSIGNMENT")]
        APP_ROLE_ASSIGNMENT,

        [EnumMember(Value = "CONFIG_BINDING")]
        CONFIG_BINDING,

        [EnumMember(Value = "EM_CATALOG_ACCESS_PACKAGES")]
        EM_CATALOG_ACCESS_PACKAGES,

        [EnumMember(Value = "EM_CATALOG_RESOURCES")]
        EM_CATALOG_RESOURCES,

        [EnumMember(Value = "EM_CATALOG_ROLE_ASSIGNMENTS")]
        EM_CATALOG_ROLE_ASSIGNMENTS,

        [EnumMember(Value = "EM_PACKAGE_ASSIGNMENTS")]
        EM_PACKAGE_ASSIGNMENTS,

        [EnumMember(Value = "EM_PACKAGE_ASSIGNMENT_POLICIES")]
        EM_PACKAGE_ASSIGNMENT_POLICIES,

        [EnumMember(Value = "EM_PACKAGE_INCOMPATIBILITIES")]
        EM_PACKAGE_INCOMPATIBILITIES,

        [EnumMember(Value = "EM_PACKAGE_RESOURCE_ROLE_SCOPES")]
        EM_PACKAGE_RESOURCE_ROLE_SCOPES,

        [EnumMember(Value = "FILTER_POLICY_ASSIGNMENT")]
        FILTER_POLICY_ASSIGNMENT,

        [EnumMember(Value = "GROUP_ACTIVE_ASSIGNMENT")]
        GROUP_ACTIVE_ASSIGNMENT,

        [EnumMember(Value = "GROUP_ELIGIBLE_ASSIGNMENT")]
        GROUP_ELIGIBLE_ASSIGNMENT,

        [EnumMember(Value = "GROUP_POLICY_ACTION")]
        GROUP_POLICY_ACTION,

        [EnumMember(Value = "GROUP_POLICY_ASSIGNMENT")]
        GROUP_POLICY_ASSIGNMENT,

        [EnumMember(Value = "INTUNE_ROLE_ASSIGNMENT")]
        INTUNE_ROLE_ASSIGNMENT,

        [EnumMember(Value = "INTUNE_ROLE_ASSIGNMENT_SCOPE")]
        INTUNE_ROLE_ASSIGNMENT_SCOPE,

        [EnumMember(Value = "INTUNE_ROLE_ASSIGNMENT_SCOPE_TAG")]
        INTUNE_ROLE_ASSIGNMENT_SCOPE_TAG,

        [EnumMember(Value = "MEMBER")]
        MEMBER,

        [EnumMember(Value = "NOTIFICATION_POLICY_ACTION")]
        NOTIFICATION_POLICY_ACTION,

        [EnumMember(Value = "OWNER")]
        OWNER,

        [EnumMember(Value = "PIM_POLICY_APPROVER")]
        PIM_POLICY_APPROVER,

        [EnumMember(Value = "POLICY_ACTION")]
        POLICY_ACTION,

        [EnumMember(Value = "POLICY_APPLIED_TO")]
        POLICY_APPLIED_TO,

        [EnumMember(Value = "POLICY_ASSIGNMENT")]
        POLICY_ASSIGNMENT,

        [EnumMember(Value = "POLICY_INCLUDES")]
        POLICY_INCLUDES,

        [EnumMember(Value = "POLICY_SCRIPT")]
        POLICY_SCRIPT,

        [EnumMember(Value = "PRINCIPAL_GROUP_ACTIVE_ASSIGNMENT")]
        PRINCIPAL_GROUP_ACTIVE_ASSIGNMENT,

        [EnumMember(Value = "PRINCIPAL_GROUP_ELIGIBLE_ASSIGNMENT")]
        PRINCIPAL_GROUP_ELIGIBLE_ASSIGNMENT,

        [EnumMember(Value = "PRINCIPAL_ROLE_ASSIGNMENT")]
        PRINCIPAL_ROLE_ASSIGNMENT,

        [EnumMember(Value = "PRINCIPAL_ROLE_ELIGIBLE_ASSIGNMENT")]
        PRINCIPAL_ROLE_ELIGIBLE_ASSIGNMENT,

        [EnumMember(Value = "REUSABLE_SETTING_REFERENCE")]
        REUSABLE_SETTING_REFERENCE,

        [EnumMember(Value = "ROLE_ASSIGNMENT")]
        ROLE_ASSIGNMENT,

        [EnumMember(Value = "ROLE_ELIGIBLE_ASSIGNMENT")]
        ROLE_ELIGIBLE_ASSIGNMENT,

        [EnumMember(Value = "ROLE_SCOPE_TAG_REFERENCE")]
        ROLE_SCOPE_TAG_REFERENCE,

        [EnumMember(Value = "SCOPE_ROLE_ASSIGNMENT")]
        SCOPE_ROLE_ASSIGNMENT,

        [EnumMember(Value = "SCOPE_ROLE_ELIGIBLE_ASSIGNMENT")]
        SCOPE_ROLE_ELIGIBLE_ASSIGNMENT,

        [EnumMember(Value = "SCOPE_TAG_ASSIGNMENT")]
        SCOPE_TAG_ASSIGNMENT


    } // enum AzureAdRelationshipEnumType

} // namespace RubrikSecurityCloud.Types