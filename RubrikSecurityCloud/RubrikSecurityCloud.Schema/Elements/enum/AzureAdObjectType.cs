// AzureAdObjectType.cs
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
    public enum AzureAdObjectType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_REVIEW_SCHEDULE_DEFINITION")]
        ACCESS_REVIEW_SCHEDULE_DEFINITION,

        [EnumMember(Value = "ACCOUNT_PROTECTION")]
        ACCOUNT_PROTECTION,

        [EnumMember(Value = "ADMINISTRATIVE_UNIT")]
        ADMINISTRATIVE_UNIT,

        [EnumMember(Value = "ANTIVIRUS")]
        ANTIVIRUS,

        [EnumMember(Value = "APPLICATION")]
        APPLICATION,

        [EnumMember(Value = "APP_CONTROL")]
        APP_CONTROL,

        [EnumMember(Value = "APP_PROTECTION_POLICY")]
        APP_PROTECTION_POLICY,

        [EnumMember(Value = "APP_ROLE_ASSIGNMENT")]
        APP_ROLE_ASSIGNMENT,

        [EnumMember(Value = "ASSIGNMENT_FILTER")]
        ASSIGNMENT_FILTER,

        [EnumMember(Value = "ATTACK_SURFACE_REDUCTION")]
        ATTACK_SURFACE_REDUCTION,

        [EnumMember(Value = "AUTHENTICATION_CONTEXT")]
        AUTHENTICATION_CONTEXT,

        [EnumMember(Value = "AUTHENTICATION_STRENGTH")]
        AUTHENTICATION_STRENGTH,

        [EnumMember(Value = "AUTOPILOT_DEPLOYMENT_PROFILE")]
        AUTOPILOT_DEPLOYMENT_PROFILE,

        [EnumMember(Value = "AZURE_AD_OBJECT_TYPE_UNKNOWN")]
        AZURE_AD_OBJECT_TYPE_UNKNOWN,

        [EnumMember(Value = "BIT_LOCKER_KEY")]
        BIT_LOCKER_KEY,

        [EnumMember(Value = "COMPLIANCE_POLICY")]
        COMPLIANCE_POLICY,

        [EnumMember(Value = "COMPLIANCE_POLICY_ACTION")]
        COMPLIANCE_POLICY_ACTION,

        [EnumMember(Value = "COMPLIANCE_POLICY_ASSIGNMENT")]
        COMPLIANCE_POLICY_ASSIGNMENT,

        [EnumMember(Value = "COMPLIANCE_SCRIPT")]
        COMPLIANCE_SCRIPT,

        [EnumMember(Value = "CONDITIONAL_ACCESS_POLICY")]
        CONDITIONAL_ACCESS_POLICY,

        [EnumMember(Value = "DEVICE")]
        DEVICE,

        [EnumMember(Value = "DEVICE_COMPLIANCE_POLICY")]
        DEVICE_COMPLIANCE_POLICY,

        [EnumMember(Value = "DEVICE_COMPLIANCE_SCRIPT")]
        DEVICE_COMPLIANCE_SCRIPT,

        [EnumMember(Value = "DEVICE_MANAGEMENT_COMPLIANCE_POLICY")]
        DEVICE_MANAGEMENT_COMPLIANCE_POLICY,

        [EnumMember(Value = "DEVICE_MANAGEMENT_CONFIGURATION_POLICY")]
        DEVICE_MANAGEMENT_CONFIGURATION_POLICY,

        [EnumMember(Value = "DISK_ENCRYPTION")]
        DISK_ENCRYPTION,

        [EnumMember(Value = "EM_ACCESS_PACKAGE")]
        EM_ACCESS_PACKAGE,

        [EnumMember(Value = "EM_ASSIGNMENT")]
        EM_ASSIGNMENT,

        [EnumMember(Value = "EM_ASSIGNMENT_POLICY")]
        EM_ASSIGNMENT_POLICY,

        [EnumMember(Value = "EM_CATALOG")]
        EM_CATALOG,

        [EnumMember(Value = "EM_CATALOG_RESOURCE")]
        EM_CATALOG_RESOURCE,

        [EnumMember(Value = "EM_CATALOG_ROLE_ASSIGNMENT")]
        EM_CATALOG_ROLE_ASSIGNMENT,

        [EnumMember(Value = "EM_INCOMPATIBILITIES")]
        EM_INCOMPATIBILITIES,

        [EnumMember(Value = "EM_RESOURCE_ROLE_SCOPE")]
        EM_RESOURCE_ROLE_SCOPE,

        [EnumMember(Value = "ENDPOINT_DETECTION_RESPONSE")]
        ENDPOINT_DETECTION_RESPONSE,

        [EnumMember(Value = "ENDPOINT_PRIVILEGE_MANAGEMENT")]
        ENDPOINT_PRIVILEGE_MANAGEMENT,

        [EnumMember(Value = "FIREWALL")]
        FIREWALL,

        [EnumMember(Value = "GROUP")]
        GROUP,

        [EnumMember(Value = "GROUP_ACTIVE_ASSIGNMENT")]
        GROUP_ACTIVE_ASSIGNMENT,

        [EnumMember(Value = "GROUP_ELIGIBLE_ASSIGNMENT")]
        GROUP_ELIGIBLE_ASSIGNMENT,

        [EnumMember(Value = "INTUNE_POLICY_ASSIGNMENT")]
        INTUNE_POLICY_ASSIGNMENT,

        [EnumMember(Value = "INTUNE_ROLE_ASSIGNMENT")]
        INTUNE_ROLE_ASSIGNMENT,

        [EnumMember(Value = "INTUNE_ROLE_DEFINITION")]
        INTUNE_ROLE_DEFINITION,

        [EnumMember(Value = "INTUNE_SCOPE_TAG")]
        INTUNE_SCOPE_TAG,

        [EnumMember(Value = "INTUNE_SCOPE_TAG_ASSIGNMENT")]
        INTUNE_SCOPE_TAG_ASSIGNMENT,

        [EnumMember(Value = "LOCAL_ADMIN_PASSWORD")]
        LOCAL_ADMIN_PASSWORD,

        [EnumMember(Value = "NAMED_LOCATION")]
        NAMED_LOCATION,

        [EnumMember(Value = "NOTIFICATION_TEMPLATE")]
        NOTIFICATION_TEMPLATE,

        [EnumMember(Value = "REUSABLE_POLICY_SETTING")]
        REUSABLE_POLICY_SETTING,

        [EnumMember(Value = "REUSABLE_POLICY_SETTING_DEVICE_CONTROL")]
        REUSABLE_POLICY_SETTING_DEVICE_CONTROL,

        [EnumMember(Value = "REUSABLE_POLICY_SETTING_MDM_STORE")]
        REUSABLE_POLICY_SETTING_MDM_STORE,

        [EnumMember(Value = "REUSABLE_POLICY_SETTING_PRIVILEGE_MANAGEMENT")]
        REUSABLE_POLICY_SETTING_PRIVILEGE_MANAGEMENT,

        [EnumMember(Value = "ROLE")]
        ROLE,

        [EnumMember(Value = "ROLE_ASSIGNMENT")]
        ROLE_ASSIGNMENT,

        [EnumMember(Value = "ROLE_ELIGIBLE_ASSIGNMENT")]
        ROLE_ELIGIBLE_ASSIGNMENT,

        [EnumMember(Value = "SERVICE_PRINCIPAL")]
        SERVICE_PRINCIPAL,

        [EnumMember(Value = "SUBTYPE_CONFIGURATION_POLICY")]
        SUBTYPE_CONFIGURATION_POLICY,

        [EnumMember(Value = "SUBTYPE_DEVICE_CONFIGURATION")]
        SUBTYPE_DEVICE_CONFIGURATION,

        [EnumMember(Value = "SUBTYPE_DEVICE_MANAGEMENT_INTENT")]
        SUBTYPE_DEVICE_MANAGEMENT_INTENT,

        [EnumMember(Value = "SUBTYPE_GROUP_POLICY_CONFIGURATION")]
        SUBTYPE_GROUP_POLICY_CONFIGURATION,

        [EnumMember(Value = "SUBTYPE_HARDWARE_CONFIGURATION")]
        SUBTYPE_HARDWARE_CONFIGURATION,

        [EnumMember(Value = "SUBTYPE_MOBILE_APP_CONFIGURATION")]
        SUBTYPE_MOBILE_APP_CONFIGURATION,

        [EnumMember(Value = "TERMS_OF_USE")]
        TERMS_OF_USE,

        [EnumMember(Value = "UPDATE_RING")]
        UPDATE_RING,

        [EnumMember(Value = "USER")]
        USER


    } // enum AzureAdObjectType

} // namespace RubrikSecurityCloud.Types