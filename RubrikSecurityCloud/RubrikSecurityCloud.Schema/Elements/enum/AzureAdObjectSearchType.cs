// AzureAdObjectSearchType.cs
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
    public enum AzureAdObjectSearchType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_REVIEW_SCHEDULE_DEFINITION_RESOURCE_TYPE")]
        ACCESS_REVIEW_SCHEDULE_DEFINITION_RESOURCE_TYPE,

        [EnumMember(Value = "ADMINISTRATIVE_UNIT_NAME")]
        ADMINISTRATIVE_UNIT_NAME,

        [EnumMember(Value = "APPLICATION_NAME")]
        APPLICATION_NAME,

        [EnumMember(Value = "APP_PROTECTION_POLICY_NAME")]
        APP_PROTECTION_POLICY_NAME,

        [EnumMember(Value = "ASSIGNMENT_FILTER_NAME")]
        ASSIGNMENT_FILTER_NAME,

        [EnumMember(Value = "AUTHENTICATION_CONTEXT_NAME")]
        AUTHENTICATION_CONTEXT_NAME,

        [EnumMember(Value = "AUTHENTICATION_STRENGTH_NAME")]
        AUTHENTICATION_STRENGTH_NAME,

        [EnumMember(Value = "AUTOPILOT_DEPLOYMENT_PROFILE_NAME")]
        AUTOPILOT_DEPLOYMENT_PROFILE_NAME,

        [EnumMember(Value = "BIT_LOCKER_KEY_DEVICE_NAME")]
        BIT_LOCKER_KEY_DEVICE_NAME,

        [EnumMember(Value = "COMPLIANCE_POLICY_ASSIGNMENT_GROUP_NAME")]
        COMPLIANCE_POLICY_ASSIGNMENT_GROUP_NAME,

        [EnumMember(Value = "COMPLIANCE_POLICY_ASSIGNMENT_POLICY_NAME")]
        COMPLIANCE_POLICY_ASSIGNMENT_POLICY_NAME,

        [EnumMember(Value = "COMPLIANCE_POLICY_ASSIGNMENT_TYPE")]
        COMPLIANCE_POLICY_ASSIGNMENT_TYPE,

        [EnumMember(Value = "COMPLIANCE_POLICY_NAME")]
        COMPLIANCE_POLICY_NAME,

        [EnumMember(Value = "COMPLIANCE_POLICY_TYPE")]
        COMPLIANCE_POLICY_TYPE,

        [EnumMember(Value = "COMPLIANCE_SCRIPT_NAME")]
        COMPLIANCE_SCRIPT_NAME,

        [EnumMember(Value = "CONDITIONAL_ACCESS_POLICY_NAME")]
        CONDITIONAL_ACCESS_POLICY_NAME,

        [EnumMember(Value = "DEVICE_MANAGEMENT_POLICY_NAME")]
        DEVICE_MANAGEMENT_POLICY_NAME,

        [EnumMember(Value = "DEVICE_MANAGEMENT_POLICY_TYPE")]
        DEVICE_MANAGEMENT_POLICY_TYPE,

        [EnumMember(Value = "DEVICE_NAME")]
        DEVICE_NAME,

        [EnumMember(Value = "GROUP_ACTIVE_ASSIGNMENT_GROUP_NAME")]
        GROUP_ACTIVE_ASSIGNMENT_GROUP_NAME,

        [EnumMember(Value = "GROUP_ACTIVE_ASSIGNMENT_PRINCIPAL_NAME")]
        GROUP_ACTIVE_ASSIGNMENT_PRINCIPAL_NAME,

        [EnumMember(Value = "GROUP_ELIGIBLE_ASSIGNMENT_GROUP_NAME")]
        GROUP_ELIGIBLE_ASSIGNMENT_GROUP_NAME,

        [EnumMember(Value = "GROUP_ELIGIBLE_ASSIGNMENT_PRINCIPAL_NAME")]
        GROUP_ELIGIBLE_ASSIGNMENT_PRINCIPAL_NAME,

        [EnumMember(Value = "GROUP_IS_PIM_ENABLED")]
        GROUP_IS_PIM_ENABLED,

        [EnumMember(Value = "GROUP_NAME")]
        GROUP_NAME,

        [EnumMember(Value = "GROUP_TYPE")]
        GROUP_TYPE,

        [EnumMember(Value = "INTUNE_POLICY_ASSIGNMENT_SEARCH_CATEGORY")]
        INTUNE_POLICY_ASSIGNMENT_SEARCH_CATEGORY,

        [EnumMember(Value = "INTUNE_POLICY_ASSIGNMENT_SEARCH_GROUP_NAME")]
        INTUNE_POLICY_ASSIGNMENT_SEARCH_GROUP_NAME,

        [EnumMember(Value = "INTUNE_POLICY_ASSIGNMENT_SEARCH_TYPE")]
        INTUNE_POLICY_ASSIGNMENT_SEARCH_TYPE,

        [EnumMember(Value = "INTUNE_ROLE_ASSIGNMENT_SEARCH_NAME")]
        INTUNE_ROLE_ASSIGNMENT_SEARCH_NAME,

        [EnumMember(Value = "INTUNE_ROLE_DEFINITION_SEARCH_NAME")]
        INTUNE_ROLE_DEFINITION_SEARCH_NAME,

        [EnumMember(Value = "INTUNE_SCOPE_TAG_ASSIGNMENT_SEARCH_GROUP_NAME")]
        INTUNE_SCOPE_TAG_ASSIGNMENT_SEARCH_GROUP_NAME,

        [EnumMember(Value = "INTUNE_SCOPE_TAG_SEARCH_NAME")]
        INTUNE_SCOPE_TAG_SEARCH_NAME,

        [EnumMember(Value = "LOCAL_ADMIN_PASSWORD_DEVICE_NAME")]
        LOCAL_ADMIN_PASSWORD_DEVICE_NAME,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "NAMED_LOCATION_NAME")]
        NAMED_LOCATION_NAME,

        [EnumMember(Value = "NOTIFICATION_TEMPLATE_NAME")]
        NOTIFICATION_TEMPLATE_NAME,

        [EnumMember(Value = "PRINCIPAL_USER_NAME")]
        PRINCIPAL_USER_NAME,

        [EnumMember(Value = "REUSABLE_POLICY_SETTING_NAME")]
        REUSABLE_POLICY_SETTING_NAME,

        [EnumMember(Value = "ROLE_ELIGIBLE_ASSIGNMENT_PRINCIPAL_NAME")]
        ROLE_ELIGIBLE_ASSIGNMENT_PRINCIPAL_NAME,

        [EnumMember(Value = "ROLE_ELIGIBLE_ASSIGNMENT_ROLE_NAME")]
        ROLE_ELIGIBLE_ASSIGNMENT_ROLE_NAME,

        [EnumMember(Value = "ROLE_IS_PIM_ENABLED")]
        ROLE_IS_PIM_ENABLED,

        [EnumMember(Value = "ROLE_NAME")]
        ROLE_NAME,

        [EnumMember(Value = "SERVICE_PRINCIPAL_NAME")]
        SERVICE_PRINCIPAL_NAME,

        [EnumMember(Value = "TERMS_OF_USE_NAME")]
        TERMS_OF_USE_NAME,

        [EnumMember(Value = "USER_NAME")]
        USER_NAME,

        [EnumMember(Value = "USER_TYPE")]
        USER_TYPE


    } // enum AzureAdObjectSearchType

} // namespace RubrikSecurityCloud.Types