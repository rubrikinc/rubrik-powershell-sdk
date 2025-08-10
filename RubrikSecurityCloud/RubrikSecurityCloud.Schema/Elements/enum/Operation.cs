// Operation.cs
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
    public enum Operation
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_CDM_CLUSTER")]
        ACCESS_CDM_CLUSTER,

        [EnumMember(Value = "ADD_AWS_CLOUD_ACCOUNT")]
        ADD_AWS_CLOUD_ACCOUNT,

        [EnumMember(Value = "ADD_AWS_ROLE_CHAINING_CLOUD_ACCOUNT")]
        ADD_AWS_ROLE_CHAINING_CLOUD_ACCOUNT,

        [EnumMember(Value = "ADD_AZURE_CLOUD_ACCOUNT")]
        ADD_AZURE_CLOUD_ACCOUNT,

        [EnumMember(Value = "ADD_CERTIFICATE")]
        ADD_CERTIFICATE,

        [EnumMember(Value = "ADD_CLUSTER")]
        ADD_CLUSTER,

        [EnumMember(Value = "ADD_CLUSTER_NODES")]
        ADD_CLUSTER_NODES,

        [EnumMember(Value = "ADD_GCP_CLOUD_ACCOUNT")]
        ADD_GCP_CLOUD_ACCOUNT,

        [EnumMember(Value = "ADD_INVENTORY")]
        ADD_INVENTORY,

        [EnumMember(Value = "ADD_KMS_KEY_VAULT")]
        ADD_KMS_KEY_VAULT,

        [EnumMember(Value = "ADD_OCI_CLOUD_ACCOUNT")]
        ADD_OCI_CLOUD_ACCOUNT,

        [EnumMember(Value = "ADD_STORAGE_SETTINGS")]
        ADD_STORAGE_SETTINGS,

        [EnumMember(Value = "ADD_TAG")]
        ADD_TAG,

        [EnumMember(Value = "ALLOW_SUPPORT_USER_SESSIONS")]
        ALLOW_SUPPORT_USER_SESSIONS,

        [EnumMember(Value = "APPROVE_TPR_REQUEST")]
        APPROVE_TPR_REQUEST,

        [EnumMember(Value = "ASSIGN_KMS_KEY_VAULT")]
        ASSIGN_KMS_KEY_VAULT,

        [EnumMember(Value = "ASSIGN_MIP_LABELS")]
        ASSIGN_MIP_LABELS,

        [EnumMember(Value = "ASSIGN_ROLE")]
        ASSIGN_ROLE,

        [EnumMember(Value = "CANCEL_RUNNING_ACTIVITY")]
        CANCEL_RUNNING_ACTIVITY,

        [EnumMember(Value = "CANCEL_TPR_REQUEST")]
        CANCEL_TPR_REQUEST,

        [EnumMember(Value = "CATEGORY_MANAGE_DATA_SOURCE")]
        CATEGORY_MANAGE_DATA_SOURCE,

        [EnumMember(Value = "CATEGORY_PROTECTION")]
        CATEGORY_PROTECTION,

        [EnumMember(Value = "CATEGORY_RECOVERY")]
        CATEGORY_RECOVERY,

        [EnumMember(Value = "CATEGORY_VIEW_DATA_SOURCE")]
        CATEGORY_VIEW_DATA_SOURCE,

        [EnumMember(Value = "CHAT_WITH_CHATBOT")]
        CHAT_WITH_CHATBOT,

        [EnumMember(Value = "CONFIGURE_DATA_CLASS_GLOBAL")]
        CONFIGURE_DATA_CLASS_GLOBAL,

        [EnumMember(Value = "CONFIGURE_DB_LOG_REPORT_PROPERTIES")]
        CONFIGURE_DB_LOG_REPORT_PROPERTIES,

        [EnumMember(Value = "CREATE_CROSS_ACCOUNT_PAIR")]
        CREATE_CROSS_ACCOUNT_PAIR,

        [EnumMember(Value = "CREATE_REPORT")]
        CREATE_REPORT,

        [EnumMember(Value = "CREATE_SLA")]
        CREATE_SLA,

        [EnumMember(Value = "CREATE_THREAT_HUNT")]
        CREATE_THREAT_HUNT,

        [EnumMember(Value = "CROSS_ACCOUNT_REPLICATION")]
        CROSS_ACCOUNT_REPLICATION,

        [EnumMember(Value = "DELETE_AWS_CLOUD_ACCOUNT")]
        DELETE_AWS_CLOUD_ACCOUNT,

        [EnumMember(Value = "DELETE_AWS_ROLE_CHAINING_CLOUD_ACCOUNT")]
        DELETE_AWS_ROLE_CHAINING_CLOUD_ACCOUNT,

        [EnumMember(Value = "DELETE_AZURE_CLOUD_ACCOUNT")]
        DELETE_AZURE_CLOUD_ACCOUNT,

        [EnumMember(Value = "DELETE_GCP_CLOUD_ACCOUNT")]
        DELETE_GCP_CLOUD_ACCOUNT,

        [EnumMember(Value = "DELETE_INVENTORY")]
        DELETE_INVENTORY,

        [EnumMember(Value = "DELETE_OCI_CLOUD_ACCOUNT")]
        DELETE_OCI_CLOUD_ACCOUNT,

        [EnumMember(Value = "DELETE_REPORT")]
        DELETE_REPORT,

        [EnumMember(Value = "DELETE_SLA")]
        DELETE_SLA,

        [EnumMember(Value = "DELETE_SNAPSHOT")]
        DELETE_SNAPSHOT,

        [EnumMember(Value = "DELETE_STORAGE_SETTINGS")]
        DELETE_STORAGE_SETTINGS,

        [EnumMember(Value = "DOWNLOAD")]
        DOWNLOAD,

        [EnumMember(Value = "DOWNLOAD_ANOMALY_FORENSICS")]
        DOWNLOAD_ANOMALY_FORENSICS,

        [EnumMember(Value = "DOWNLOAD_FROM_ARCHIVAL_LOCATION")]
        DOWNLOAD_FROM_ARCHIVAL_LOCATION,

        [EnumMember(Value = "DOWNLOAD_NUTANIX_VDISK")]
        DOWNLOAD_NUTANIX_VDISK,

        [EnumMember(Value = "DOWNLOAD_SNAPSHOT_FROM_REPLICATION_TARGET")]
        DOWNLOAD_SNAPSHOT_FROM_REPLICATION_TARGET,

        [EnumMember(Value = "DOWNLOAD_VIRTUAL_MACHINE_FILE")]
        DOWNLOAD_VIRTUAL_MACHINE_FILE,

        [EnumMember(Value = "EDIT_AWS_CLOUD_ACCOUNT")]
        EDIT_AWS_CLOUD_ACCOUNT,

        [EnumMember(Value = "EDIT_AWS_ROLE_CHAINING_CLOUD_ACCOUNT")]
        EDIT_AWS_ROLE_CHAINING_CLOUD_ACCOUNT,

        [EnumMember(Value = "EDIT_AZURE_CLOUD_ACCOUNT")]
        EDIT_AZURE_CLOUD_ACCOUNT,

        [EnumMember(Value = "EDIT_CDM_NETWORK_SETTING")]
        EDIT_CDM_NETWORK_SETTING,

        [EnumMember(Value = "EDIT_CDM_SUPPORT_SETTING")]
        EDIT_CDM_SUPPORT_SETTING,

        [EnumMember(Value = "EDIT_CDM_SYS_CONFIG")]
        EDIT_CDM_SYS_CONFIG,

        [EnumMember(Value = "EDIT_GCP_CLOUD_ACCOUNT")]
        EDIT_GCP_CLOUD_ACCOUNT,

        [EnumMember(Value = "EDIT_NETWORK_THROTTLE_SETTINGS")]
        EDIT_NETWORK_THROTTLE_SETTINGS,

        [EnumMember(Value = "EDIT_OCI_CLOUD_ACCOUNT")]
        EDIT_OCI_CLOUD_ACCOUNT,

        [EnumMember(Value = "EDIT_ORGANIZATION")]
        EDIT_ORGANIZATION,

        [EnumMember(Value = "EDIT_QUARANTINE")]
        EDIT_QUARANTINE,

        [EnumMember(Value = "EDIT_REPLICATION_SETTINGS")]
        EDIT_REPLICATION_SETTINGS,

        [EnumMember(Value = "EDIT_SECURITY_SETTINGS")]
        EDIT_SECURITY_SETTINGS,

        [EnumMember(Value = "EDIT_STORAGE_SETTINGS")]
        EDIT_STORAGE_SETTINGS,

        [EnumMember(Value = "EDIT_SYSTEM_PREFERENCE")]
        EDIT_SYSTEM_PREFERENCE,

        [EnumMember(Value = "EDIT_USER_MANAGEMENT")]
        EDIT_USER_MANAGEMENT,

        [EnumMember(Value = "ENABLE_ACCESS_LOGGING")]
        ENABLE_ACCESS_LOGGING,

        [EnumMember(Value = "EXPORT")]
        EXPORT,

        [EnumMember(Value = "EXPORT_DATA_CLASS_GLOBAL")]
        EXPORT_DATA_CLASS_GLOBAL,

        [EnumMember(Value = "EXPORT_FILES")]
        EXPORT_FILES,

        [EnumMember(Value = "EXPORT_SNAPSHOTS")]
        EXPORT_SNAPSHOTS,

        [EnumMember(Value = "GRANULAR_RECOVERY")]
        GRANULAR_RECOVERY,

        [EnumMember(Value = "INSTANT_RECOVER")]
        INSTANT_RECOVER,

        [EnumMember(Value = "MANAGE_ACCESS")]
        MANAGE_ACCESS,

        [EnumMember(Value = "MANAGE_ANOMALY_DETECTION")]
        MANAGE_ANOMALY_DETECTION,

        [EnumMember(Value = "MANAGE_ARCHIVAL_NETWORK_THROTTLE_SETTINGS")]
        MANAGE_ARCHIVAL_NETWORK_THROTTLE_SETTINGS,

        [EnumMember(Value = "MANAGE_AUTH_DOMAIN")]
        MANAGE_AUTH_DOMAIN,

        [EnumMember(Value = "MANAGE_CDP_IO_FILTER")]
        MANAGE_CDP_IO_FILTER,

        [EnumMember(Value = "MANAGE_CERTIFICATE")]
        MANAGE_CERTIFICATE,

        [EnumMember(Value = "MANAGE_CHATBOT")]
        MANAGE_CHATBOT,

        [EnumMember(Value = "MANAGE_CLUSTER_DISKS")]
        MANAGE_CLUSTER_DISKS,

        [EnumMember(Value = "MANAGE_CLUSTER_SETTINGS")]
        MANAGE_CLUSTER_SETTINGS,

        [EnumMember(Value = "MANAGE_CORS_SETTINGS")]
        MANAGE_CORS_SETTINGS,

        [EnumMember(Value = "MANAGE_CREDENTIALS")]
        MANAGE_CREDENTIALS,

        [EnumMember(Value = "MANAGE_CROSS_ACCOUNT_PAIR")]
        MANAGE_CROSS_ACCOUNT_PAIR,

        [EnumMember(Value = "MANAGE_CYBER_EVENT_LOCKDOWN")]
        MANAGE_CYBER_EVENT_LOCKDOWN,

        [EnumMember(Value = "MANAGE_DATA_SOURCE")]
        MANAGE_DATA_SOURCE,

        [EnumMember(Value = "MANAGE_DL_EMAIL_SETTINGS")]
        MANAGE_DL_EMAIL_SETTINGS,

        [EnumMember(Value = "MANAGE_DSPM_INTEGRATIONS")]
        MANAGE_DSPM_INTEGRATIONS,

        [EnumMember(Value = "MANAGE_GPS_TO_RSC_UPGRADE")]
        MANAGE_GPS_TO_RSC_UPGRADE,

        [EnumMember(Value = "MANAGE_GUEST_OS_CREDENTIAL")]
        MANAGE_GUEST_OS_CREDENTIAL,

        [EnumMember(Value = "MANAGE_IDENTITY_RESILIENCY")]
        MANAGE_IDENTITY_RESILIENCY,

        [EnumMember(Value = "MANAGE_KMS_KEY_VAULT")]
        MANAGE_KMS_KEY_VAULT,

        [EnumMember(Value = "MANAGE_LEGAL_HOLD")]
        MANAGE_LEGAL_HOLD,

        [EnumMember(Value = "MANAGE_LOCKOUT")]
        MANAGE_LOCKOUT,

        [EnumMember(Value = "MANAGE_LOG_SHIPPING")]
        MANAGE_LOG_SHIPPING,

        [EnumMember(Value = "MANAGE_MIGRATION_DASHBOARD")]
        MANAGE_MIGRATION_DASHBOARD,

        [EnumMember(Value = "MANAGE_OAUTH_APPLICATIONS")]
        MANAGE_OAUTH_APPLICATIONS,

        [EnumMember(Value = "MANAGE_OKTA_INTEGRATION")]
        MANAGE_OKTA_INTEGRATION,

        [EnumMember(Value = "MANAGE_ORCHESTRATED_RECOVERY")]
        MANAGE_ORCHESTRATED_RECOVERY,

        [EnumMember(Value = "MANAGE_ORGANIZATION_NETWORKS")]
        MANAGE_ORGANIZATION_NETWORKS,

        [EnumMember(Value = "MANAGE_PAM_INTEGRATION")]
        MANAGE_PAM_INTEGRATION,

        [EnumMember(Value = "MANAGE_PROTECTION")]
        MANAGE_PROTECTION,

        [EnumMember(Value = "MANAGE_RECOVERY_PLAN")]
        MANAGE_RECOVERY_PLAN,

        [EnumMember(Value = "MANAGE_ROLE")]
        MANAGE_ROLE,

        [EnumMember(Value = "MANAGE_SECURITY_POLICIES")]
        MANAGE_SECURITY_POLICIES,

        [EnumMember(Value = "MANAGE_SECURITY_POLICY")]
        MANAGE_SECURITY_POLICY,

        [EnumMember(Value = "MANAGE_SECURITY_VIOLATIONS")]
        MANAGE_SECURITY_VIOLATIONS,

        [EnumMember(Value = "MANAGE_SERVICENOW_INTEGRATION")]
        MANAGE_SERVICENOW_INTEGRATION,

        [EnumMember(Value = "MANAGE_SERVICE_ACCOUNT")]
        MANAGE_SERVICE_ACCOUNT,

        [EnumMember(Value = "MANAGE_SLA")]
        MANAGE_SLA,

        [EnumMember(Value = "MANAGE_SMB_DOMAIN")]
        MANAGE_SMB_DOMAIN,

        [EnumMember(Value = "MANAGE_SNMP")]
        MANAGE_SNMP,

        [EnumMember(Value = "MANAGE_STORAGE_ENCRYPTION")]
        MANAGE_STORAGE_ENCRYPTION,

        [EnumMember(Value = "MANAGE_SUPPORT_BUNDLE")]
        MANAGE_SUPPORT_BUNDLE,

        [EnumMember(Value = "MANAGE_SUPPORT_TUNNEL")]
        MANAGE_SUPPORT_TUNNEL,

        [EnumMember(Value = "MANAGE_SYSLOG")]
        MANAGE_SYSLOG,

        [EnumMember(Value = "MANAGE_TAG")]
        MANAGE_TAG,

        [EnumMember(Value = "MANAGE_TPR_CONFIGURATION")]
        MANAGE_TPR_CONFIGURATION,

        [EnumMember(Value = "MANAGE_TPR_ENABLEMENT")]
        MANAGE_TPR_ENABLEMENT,

        [EnumMember(Value = "MANAGE_TPR_POLICY")]
        MANAGE_TPR_POLICY,

        [EnumMember(Value = "MANAGE_USER")]
        MANAGE_USER,

        [EnumMember(Value = "MANAGE_USER_CREDENTIALS")]
        MANAGE_USER_CREDENTIALS,

        [EnumMember(Value = "MANAGE_WEBHOOKS")]
        MANAGE_WEBHOOKS,

        [EnumMember(Value = "MANAGE_ZSCALER_DLP_INTEGRATION")]
        MANAGE_ZSCALER_DLP_INTEGRATION,

        [EnumMember(Value = "MODIFY_CLUSTER")]
        MODIFY_CLUSTER,

        [EnumMember(Value = "MODIFY_EVENT_CLUSTER_SETTING")]
        MODIFY_EVENT_CLUSTER_SETTING,

        [EnumMember(Value = "MODIFY_INVENTORY")]
        MODIFY_INVENTORY,

        [EnumMember(Value = "MODIFY_REPORT")]
        MODIFY_REPORT,

        [EnumMember(Value = "MODIFY_SLA")]
        MODIFY_SLA,

        [EnumMember(Value = "MOUNT")]
        MOUNT,

        [EnumMember(Value = "MOUNT_NUTANIX_VDISK")]
        MOUNT_NUTANIX_VDISK,

        [EnumMember(Value = "PROVISION_ON_INFRASTRUCTURE")]
        PROVISION_ON_INFRASTRUCTURE,

        [EnumMember(Value = "RECOVER_CLUSTER")]
        RECOVER_CLUSTER,

        [EnumMember(Value = "RECOVER_FROM_QUARANTINE")]
        RECOVER_FROM_QUARANTINE,

        [EnumMember(Value = "REFRESH_DATA_SOURCE")]
        REFRESH_DATA_SOURCE,

        [EnumMember(Value = "REMEDIATE_IDENTITY_RESILIENCY_VIOLATIONS")]
        REMEDIATE_IDENTITY_RESILIENCY_VIOLATIONS,

        [EnumMember(Value = "REMOVE_CLUSTER")]
        REMOVE_CLUSTER,

        [EnumMember(Value = "REMOVE_CLUSTER_NODES")]
        REMOVE_CLUSTER_NODES,

        [EnumMember(Value = "RESIZE_MANAGED_VOLUME")]
        RESIZE_MANAGED_VOLUME,

        [EnumMember(Value = "RESTORE")]
        RESTORE,

        [EnumMember(Value = "RESTORE_ACTIVE_DIRECTORY_FOREST")]
        RESTORE_ACTIVE_DIRECTORY_FOREST,

        [EnumMember(Value = "RESTORE_TO_ORIGIN")]
        RESTORE_TO_ORIGIN,

        [EnumMember(Value = "SELF_SERVICE_RESTORE")]
        SELF_SERVICE_RESTORE,

        [EnumMember(Value = "TAKE_ON_DEMAND_SNAPSHOT")]
        TAKE_ON_DEMAND_SNAPSHOT,

        [EnumMember(Value = "TAKE_REMEDIATION_ACTIONS")]
        TAKE_REMEDIATION_ACTIONS,

        [EnumMember(Value = "TIER_EXISTING_SNAPSHOTS")]
        TIER_EXISTING_SNAPSHOTS,

        [EnumMember(Value = "TOGGLE_BLACKOUT_WINDOW")]
        TOGGLE_BLACKOUT_WINDOW,

        [EnumMember(Value = "TRANSFER_ACCOUNT_OWNERSHIP")]
        TRANSFER_ACCOUNT_OWNERSHIP,

        [EnumMember(Value = "UPDATE_ACCOUNT_OWNERSHIP")]
        UPDATE_ACCOUNT_OWNERSHIP,

        [EnumMember(Value = "UPGRADE_CLUSTER")]
        UPGRADE_CLUSTER,

        [EnumMember(Value = "USE_AS_REPLICATION_TARGET")]
        USE_AS_REPLICATION_TARGET,

        [EnumMember(Value = "USE_OAUTH_APPLICATIONS")]
        USE_OAUTH_APPLICATIONS,

        [EnumMember(Value = "VIEW_ACCESS")]
        VIEW_ACCESS,

        [EnumMember(Value = "VIEW_ALL_EVENTS")]
        VIEW_ALL_EVENTS,

        [EnumMember(Value = "VIEW_ANOMALY_DETECTION_FILE_DETAILS")]
        VIEW_ANOMALY_DETECTION_FILE_DETAILS,

        [EnumMember(Value = "VIEW_ANOMALY_DETECTION_RESULTS")]
        VIEW_ANOMALY_DETECTION_RESULTS,

        [EnumMember(Value = "VIEW_ARCHIVAL_LOCATION")]
        VIEW_ARCHIVAL_LOCATION,

        [EnumMember(Value = "VIEW_AUDIT_LOG")]
        VIEW_AUDIT_LOG,

        [EnumMember(Value = "VIEW_AWS_CLOUD_ACCOUNT")]
        VIEW_AWS_CLOUD_ACCOUNT,

        [EnumMember(Value = "VIEW_AZURE_CLOUD_ACCOUNT")]
        VIEW_AZURE_CLOUD_ACCOUNT,

        [EnumMember(Value = "VIEW_CDM_NETWORK_SETTING")]
        VIEW_CDM_NETWORK_SETTING,

        [EnumMember(Value = "VIEW_CDM_SUPPORT_SETTING")]
        VIEW_CDM_SUPPORT_SETTING,

        [EnumMember(Value = "VIEW_CDM_SYS_CONFIG")]
        VIEW_CDM_SYS_CONFIG,

        [EnumMember(Value = "VIEW_CERTIFICATE")]
        VIEW_CERTIFICATE,

        [EnumMember(Value = "VIEW_CHATBOT")]
        VIEW_CHATBOT,

        [EnumMember(Value = "VIEW_CLUSTER")]
        VIEW_CLUSTER,

        [EnumMember(Value = "VIEW_CLUSTER_LICENSES")]
        VIEW_CLUSTER_LICENSES,

        [EnumMember(Value = "VIEW_CORS_SETTINGS")]
        VIEW_CORS_SETTINGS,

        [EnumMember(Value = "VIEW_CROSS_ACCOUNT_PAIR")]
        VIEW_CROSS_ACCOUNT_PAIR,

        [EnumMember(Value = "VIEW_DASHBOARD")]
        VIEW_DASHBOARD,

        [EnumMember(Value = "VIEW_DATA_ACCESS_GOVERNANCE")]
        VIEW_DATA_ACCESS_GOVERNANCE,

        [EnumMember(Value = "VIEW_DATA_CLASS_GLOBAL")]
        VIEW_DATA_CLASS_GLOBAL,

        [EnumMember(Value = "VIEW_DATA_DETECTION_AND_RESPONSE_ALERTS")]
        VIEW_DATA_DETECTION_AND_RESPONSE_ALERTS,

        [EnumMember(Value = "VIEW_DATA_SECURITY_DETAILS")]
        VIEW_DATA_SECURITY_DETAILS,

        [EnumMember(Value = "VIEW_DATA_SECURITY_POSTURE_RESULTS")]
        VIEW_DATA_SECURITY_POSTURE_RESULTS,

        [EnumMember(Value = "VIEW_DB_LOG_REPORT_PROPERTIES")]
        VIEW_DB_LOG_REPORT_PROPERTIES,

        [EnumMember(Value = "VIEW_DL_EMAIL_SETTINGS")]
        VIEW_DL_EMAIL_SETTINGS,

        [EnumMember(Value = "VIEW_DSPM_INTEGRATIONS")]
        VIEW_DSPM_INTEGRATIONS,

        [EnumMember(Value = "VIEW_EVENT_CLUSTER_SETTING")]
        VIEW_EVENT_CLUSTER_SETTING,

        [EnumMember(Value = "VIEW_GCP_CLOUD_ACCOUNT")]
        VIEW_GCP_CLOUD_ACCOUNT,

        [EnumMember(Value = "VIEW_GUEST_OS_CREDENTIAL")]
        VIEW_GUEST_OS_CREDENTIAL,

        [EnumMember(Value = "VIEW_IDENTITY_RESILIENCY")]
        VIEW_IDENTITY_RESILIENCY,

        [EnumMember(Value = "VIEW_INVENTORY")]
        VIEW_INVENTORY,

        [EnumMember(Value = "VIEW_IP_ADDRESS_IN_AUDITS")]
        VIEW_IP_ADDRESS_IN_AUDITS,

        [EnumMember(Value = "VIEW_KMS_KEY_VAULT")]
        VIEW_KMS_KEY_VAULT,

        [EnumMember(Value = "VIEW_LICENSE_DASHBOARD")]
        VIEW_LICENSE_DASHBOARD,

        [EnumMember(Value = "VIEW_NETWORK_THROTTLE_SETTINGS")]
        VIEW_NETWORK_THROTTLE_SETTINGS,

        [EnumMember(Value = "VIEW_NON_SYSTEM_EVENT")]
        VIEW_NON_SYSTEM_EVENT,

        [EnumMember(Value = "VIEW_OCI_CLOUD_ACCOUNT")]
        VIEW_OCI_CLOUD_ACCOUNT,

        [EnumMember(Value = "VIEW_OKTA_INTEGRATION")]
        VIEW_OKTA_INTEGRATION,

        [EnumMember(Value = "VIEW_ORCHESTRATED_RECOVERY_APP")]
        VIEW_ORCHESTRATED_RECOVERY_APP,

        [EnumMember(Value = "VIEW_ORGANIZATION")]
        VIEW_ORGANIZATION,

        [EnumMember(Value = "VIEW_ORGANIZATION_NETWORKS")]
        VIEW_ORGANIZATION_NETWORKS,

        [EnumMember(Value = "VIEW_REPLICATION_SETTINGS")]
        VIEW_REPLICATION_SETTINGS,

        [EnumMember(Value = "VIEW_REPORT")]
        VIEW_REPORT,

        [EnumMember(Value = "VIEW_ROLE")]
        VIEW_ROLE,

        [EnumMember(Value = "VIEW_RUBY_INSIGHTS")]
        VIEW_RUBY_INSIGHTS,

        [EnumMember(Value = "VIEW_SECURITY_POLICY")]
        VIEW_SECURITY_POLICY,

        [EnumMember(Value = "VIEW_SECURITY_SETTINGS")]
        VIEW_SECURITY_SETTINGS,

        [EnumMember(Value = "VIEW_SERVICENOW_INTEGRATION")]
        VIEW_SERVICENOW_INTEGRATION,

        [EnumMember(Value = "VIEW_SERVICE_ACCOUNT")]
        VIEW_SERVICE_ACCOUNT,

        [EnumMember(Value = "VIEW_SLA")]
        VIEW_SLA,

        [EnumMember(Value = "VIEW_SMB_DOMAIN")]
        VIEW_SMB_DOMAIN,

        [EnumMember(Value = "VIEW_SNMP")]
        VIEW_SNMP,

        [EnumMember(Value = "VIEW_STORAGE_SETTINGS")]
        VIEW_STORAGE_SETTINGS,

        [EnumMember(Value = "VIEW_SUPPORT_BUNDLE")]
        VIEW_SUPPORT_BUNDLE,

        [EnumMember(Value = "VIEW_SYSLOG")]
        VIEW_SYSLOG,

        [EnumMember(Value = "VIEW_SYSTEM_EVENT")]
        VIEW_SYSTEM_EVENT,

        [EnumMember(Value = "VIEW_SYSTEM_PREFERENCE")]
        VIEW_SYSTEM_PREFERENCE,

        [EnumMember(Value = "VIEW_TAG")]
        VIEW_TAG,

        [EnumMember(Value = "VIEW_THREAT_HUNT_RESULTS")]
        VIEW_THREAT_HUNT_RESULTS,

        [EnumMember(Value = "VIEW_TPR_CONFIGURATION")]
        VIEW_TPR_CONFIGURATION,

        [EnumMember(Value = "VIEW_TPR_POLICY")]
        VIEW_TPR_POLICY,

        [EnumMember(Value = "VIEW_TPR_REQUEST")]
        VIEW_TPR_REQUEST,

        [EnumMember(Value = "VIEW_USER")]
        VIEW_USER,

        [EnumMember(Value = "VIEW_USER_MANAGEMENT")]
        VIEW_USER_MANAGEMENT,

        [EnumMember(Value = "VIEW_WEBHOOKS")]
        VIEW_WEBHOOKS,

        [EnumMember(Value = "VIEW_ZSCALER_DLP_INTEGRATION")]
        VIEW_ZSCALER_DLP_INTEGRATION


    } // enum Operation

} // namespace RubrikSecurityCloud.Types