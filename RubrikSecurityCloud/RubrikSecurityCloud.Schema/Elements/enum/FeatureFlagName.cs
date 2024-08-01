// FeatureFlagName.cs
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
    public enum FeatureFlagName
    {
        [EnumMember(Value = "ACCOUNT_AUTO_UPGRADED_TO_RSC")]
        ACCOUNT_AUTO_UPGRADED_TO_RSC,

        [EnumMember(Value = "ACCOUNT_DEPROVISIONING_ENABLED")]
        ACCOUNT_DEPROVISIONING_ENABLED,

        [EnumMember(Value = "ACCOUNT_DEPROVISIONING_ENABLED_UFF")]
        ACCOUNT_DEPROVISIONING_ENABLED_UFF,

        [EnumMember(Value = "ACTIVE_DIRECTORY_ENABLED")]
        ACTIVE_DIRECTORY_ENABLED,

        [EnumMember(Value = "ACTIVE_DIRECTORY_FOREST_ENABLED")]
        ACTIVE_DIRECTORY_FOREST_ENABLED,

        [EnumMember(Value = "ACTIVE_DIRECTORY_UNIFIED_API_ENABLED")]
        ACTIVE_DIRECTORY_UNIFIED_API_ENABLED,

        [EnumMember(Value = "AGENTLESS_RESTORE_ENABLED")]
        AGENTLESS_RESTORE_ENABLED,

        [EnumMember(Value = "ALLOW_ONLINE_REGISTRATION")]
        ALLOW_ONLINE_REGISTRATION,

        [EnumMember(Value = "ALL_CLUSTER_PRECHECKS_VIEW_ENABLED")]
        ALL_CLUSTER_PRECHECKS_VIEW_ENABLED,

        [EnumMember(Value = "ANNAPURNA_ENABLED")]
        ANNAPURNA_ENABLED,

        [EnumMember(Value = "APPFLOWS_AHV_ENABLED")]
        APPFLOWS_AHV_ENABLED,

        [EnumMember(Value = "APPFLOWS_BULK_RECOVERY_REPORT_ENABLED")]
        APPFLOWS_BULK_RECOVERY_REPORT_ENABLED,

        [EnumMember(Value = "APPFLOWS_CYBER_RECOVERY_EXPORT_ENABLED")]
        APPFLOWS_CYBER_RECOVERY_EXPORT_ENABLED,

        [EnumMember(Value = "APPFLOWS_CYBER_RECOVERY_THREAT_HUNT_ENABLED")]
        APPFLOWS_CYBER_RECOVERY_THREAT_HUNT_ENABLED,

        [EnumMember(Value = "APPFLOWS_DEV_ENABLED")]
        APPFLOWS_DEV_ENABLED,

        [EnumMember(Value = "APPFLOWS_EXCHANGE_BULK_RECOVERY_ENABLED")]
        APPFLOWS_EXCHANGE_BULK_RECOVERY_ENABLED,

        [EnumMember(Value = "APPFLOWS_IRE_PROMOTION_ENABLED")]
        APPFLOWS_IRE_PROMOTION_ENABLED,

        [EnumMember(Value = "APPFLOWS_ONEDRIVE_BULK_RECOVERY_ENABLED")]
        APPFLOWS_ONEDRIVE_BULK_RECOVERY_ENABLED,

        [EnumMember(Value = "APPFLOWS_SCHEDULE_RECOVERIES_ENABLED")]
        APPFLOWS_SCHEDULE_RECOVERIES_ENABLED,

        [EnumMember(Value = "APPFLOWS_SHAREPOINT_BULK_RECOVERY_ENABLED")]
        APPFLOWS_SHAREPOINT_BULK_RECOVERY_ENABLED,

        [EnumMember(Value = "APPFLOWS_SNAPSHOT_BASED_CYBER_RECOVERY_ENABLED")]
        APPFLOWS_SNAPSHOT_BASED_CYBER_RECOVERY_ENABLED,

        [EnumMember(Value = "APPLY_TO_EXISTING_SNAPSHOTS_DISABLED_BY_DEFAULT")]
        APPLY_TO_EXISTING_SNAPSHOTS_DISABLED_BY_DEFAULT,

        [EnumMember(Value = "APP_RECOVERY_PAUSE_BETWEEN_PRIORITY_GROUPS_ENABLED")]
        APP_RECOVERY_PAUSE_BETWEEN_PRIORITY_GROUPS_ENABLED,

        [EnumMember(Value = "ARCHIVAL_BANDWIDTH_STATS_ENABLED")]
        ARCHIVAL_BANDWIDTH_STATS_ENABLED,

        [EnumMember(Value = "ARCHIVAL_GOV_ALLOW_ON_RSC")]
        ARCHIVAL_GOV_ALLOW_ON_RSC,

        [EnumMember(Value = "ARCHIVAL_HIERARCHY_ENABLED")]
        ARCHIVAL_HIERARCHY_ENABLED,

        [EnumMember(Value = "ARCHIVAL_LOCATION_DETAIL_ENABLED")]
        ARCHIVAL_LOCATION_DETAIL_ENABLED,

        [EnumMember(Value = "ARCHIVAL_SUPPORT_LEGACY_GLACIER")]
        ARCHIVAL_SUPPORT_LEGACY_GLACIER,

        [EnumMember(Value = "ASSIGN_SLA_FOR_CDM_ARCHIVAL_SNAPSHOT_DOWNLOAD")]
        ASSIGN_SLA_FOR_CDM_ARCHIVAL_SNAPSHOT_DOWNLOAD,

        [EnumMember(Value = "ATLASSIAN_JIRA_PRODUCT_TRIALS_ENABLED")]
        ATLASSIAN_JIRA_PRODUCT_TRIALS_ENABLED,

        [EnumMember(Value = "AUDIT_REPORT_NG_ENABLED")]
        AUDIT_REPORT_NG_ENABLED,

        [EnumMember(Value = "AUTH0_REPLACEMENT_SSO_WIZARD_ENABLED")]
        AUTH0_REPLACEMENT_SSO_WIZARD_ENABLED,

        [EnumMember(Value = "AUTH0_SSO_NOTIFICATIONS_ENABLED")]
        AUTH0_SSO_NOTIFICATIONS_ENABLED,

        [EnumMember(Value = "AWSAutoProtectByTagsEnabled")]
        AWS_AUTO_PROTECT_BY_TAGS_ENABLED,

        [EnumMember(Value = "AWSCrossRegionReplicationEnabled")]
        AWS_CROSS_REGION_REPLICATION_ENABLED,

        [EnumMember(Value = "AWSCustomKeyPairInExportEnabled")]
        AWS_CUSTOM_KEY_PAIR_IN_EXPORT_ENABLED,

        [EnumMember(Value = "AWSEc2CrashConsistentSnapshotEnabled")]
        AWS_EC2_CRASH_CONSISTENT_SNAPSHOT_ENABLED,

        [EnumMember(Value = "AWSFileIndexingEnabled")]
        AWS_FILE_INDEXING_ENABLED,

        [EnumMember(Value = "AWSOnDemandIndexingEnabled")]
        AWS_ON_DEMAND_INDEXING_ENABLED,

        [EnumMember(Value = "AWSSnapshotIntegrityEnabled")]
        AWS_SNAPSHOT_INTEGRITY_ENABLED,

        [EnumMember(Value = "AWS_APP_CONSISTENCY_ENABLED")]
        AWS_APP_CONSISTENCY_ENABLED,

        [EnumMember(Value = "AWS_CCES_SERVERS_AND_APPS_ENABLED")]
        AWS_CCES_SERVERS_AND_APPS_ENABLED,

        [EnumMember(Value = "AWS_EC2_RADAR")]
        AWS_EC2_RADAR,

        [EnumMember(Value = "AWS_EC2_RANSOMWARE_INVESTIGATION_ENABLED")]
        AWS_EC2_RANSOMWARE_INVESTIGATION_ENABLED,

        [EnumMember(Value = "AWS_EXPORT_IAM_INSTANCE_PROFILE_ENABLED")]
        AWS_EXPORT_IAM_INSTANCE_PROFILE_ENABLED,

        [EnumMember(Value = "AWS_MANUAL_CLOUD_ACCOUNTS_SETUP_ENABLED")]
        AWS_MANUAL_CLOUD_ACCOUNTS_SETUP_ENABLED,

        [EnumMember(Value = "AWS_MULTI_ACCOUNT_ADDITION_ENABLED")]
        AWS_MULTI_ACCOUNT_ADDITION_ENABLED,

        [EnumMember(Value = "AWS_NATIVE_INSTANT_ARCHIVAL_ENABLED")]
        AWS_NATIVE_INSTANT_ARCHIVAL_ENABLED,

        [EnumMember(Value = "AWS_RDS_CROSS_ACCOUNT_REPLICATION_ENABLED")]
        AWS_RDS_CROSS_ACCOUNT_REPLICATION_ENABLED,

        [EnumMember(Value = "AWS_RDS_USE_MANUAL_SNAPSHOT_ENABLED")]
        AWS_RDS_USE_MANUAL_SNAPSHOT_ENABLED,

        [EnumMember(Value = "AWS_S3_RANSOMWARE_INVESTIGATION_ENABLED")]
        AWS_S3_RANSOMWARE_INVESTIGATION_ENABLED,

        [EnumMember(Value = "AWS_S3_V2_ENABLED")]
        AWS_S3_V2_ENABLED,

        [EnumMember(Value = "AWS_SHARED_EXOCOMPUTE_ENABLED")]
        AWS_SHARED_EXOCOMPUTE_ENABLED,

        [EnumMember(Value = "AWS_USER_INDEXING_ENABLED")]
        AWS_USER_INDEXING_ENABLED,

        [EnumMember(Value = "AZURE_AD_GA2_ENABLED")]
        AZURE_AD_GA2_ENABLED,

        [EnumMember(Value = "AZURE_AD_RECOVERY_ENABLED")]
        AZURE_AD_RECOVERY_ENABLED,

        [EnumMember(Value = "AZURE_AD_WORKLOAD_ENABLED")]
        AZURE_AD_WORKLOAD_ENABLED,

        [EnumMember(Value = "AZURE_CCES_MI_ENABLED")]
        AZURE_CCES_MI_ENABLED,

        [EnumMember(Value = "AZURE_CCES_TRANSITION_TO_MI_ENABLED")]
        AZURE_CCES_TRANSITION_TO_MI_ENABLED,

        [EnumMember(Value = "AZURE_CCES_UPGRADE_TO_V2_ENABLED")]
        AZURE_CCES_UPGRADE_TO_V2_ENABLED,

        [EnumMember(Value = "AZURE_GRANULAR_DISK_RECOVERIES_ENABLED")]
        AZURE_GRANULAR_DISK_RECOVERIES_ENABLED,

        [EnumMember(Value = "AZURE_GRANULAR_PERMISSIONS_BETA_ENABLED")]
        AZURE_GRANULAR_PERMISSIONS_BETA_ENABLED,

        [EnumMember(Value = "AZURE_GRANULAR_PERMISSIONS_ENABLED")]
        AZURE_GRANULAR_PERMISSIONS_ENABLED,

        [EnumMember(Value = "AZURE_GRANULAR_PERMISSIONS_GA_ENABLED")]
        AZURE_GRANULAR_PERMISSIONS_GA_ENABLED,

        [EnumMember(Value = "AZURE_MANUAL_CLOUD_ACCOUNTS_SETUP_ENABLED")]
        AZURE_MANUAL_CLOUD_ACCOUNTS_SETUP_ENABLED,

        [EnumMember(Value = "AZURE_SHARED_EXOCOMPUTE_ENABLED")]
        AZURE_SHARED_EXOCOMPUTE_ENABLED,

        [EnumMember(Value = "AZURE_SQL_CDCLESS_BACKUP_ENABLED")]
        AZURE_SQL_CDCLESS_BACKUP_ENABLED,

        [EnumMember(Value = "AZURE_SQL_CONFIGURE_IMMUTABLE_BACKUP_WIZARD_V2")]
        AZURE_SQL_CONFIGURE_IMMUTABLE_BACKUP_WIZARD_V2,

        [EnumMember(Value = "AZURE_SQL_RCV_ENABLED")]
        AZURE_SQL_RCV_ENABLED,

        [EnumMember(Value = "AZURE_SQL_SETUP_PERSISTENT_BACKUP_ENABLED")]
        AZURE_SQL_SETUP_PERSISTENT_BACKUP_ENABLED,

        [EnumMember(Value = "AZURE_SQL_V1_ENABLED")]
        AZURE_SQL_V1_ENABLED,

        [EnumMember(Value = "AZURE_SQL_V2_ENABLED")]
        AZURE_SQL_V2_ENABLED,

        [EnumMember(Value = "AZURE_SQL_V2_GA_ENABLED")]
        AZURE_SQL_V2_GA_ENABLED,

        [EnumMember(Value = "AZURE_VM_RANSOMWARE_INVESTIGATION_ENABLED")]
        AZURE_VM_RANSOMWARE_INVESTIGATION_ENABLED,

        [EnumMember(Value = "AddonsUIEnabled")]
        ADDONS_UI_ENABLED,

        [EnumMember(Value = "AppFlowsEnabled")]
        APP_FLOWS_ENABLED,

        [EnumMember(Value = "AppFlowsGAEnabled")]
        APP_FLOWS_GA_ENABLED,

        [EnumMember(Value = "AutoStorageSettingClusterListEnabled")]
        AUTO_STORAGE_SETTING_CLUSTER_LIST_ENABLED,

        [EnumMember(Value = "AutoStorageSettingEnabled")]
        AUTO_STORAGE_SETTING_ENABLED,

        [EnumMember(Value = "AwsChinaCloudEnabled")]
        AWS_CHINA_CLOUD_ENABLED,

        [EnumMember(Value = "AwsComputeSettingsEnabled")]
        AWS_COMPUTE_SETTINGS_ENABLED,

        [EnumMember(Value = "AwsCrossAccountReplicationEnabled")]
        AWS_CROSS_ACCOUNT_REPLICATION_ENABLED,

        [EnumMember(Value = "AwsExocomputeConfigEnabled")]
        AWS_EXOCOMPUTE_CONFIG_ENABLED,

        [EnumMember(Value = "AwsExportInstanceInPoweredOffStateEnabled")]
        AWS_EXPORT_INSTANCE_IN_POWERED_OFF_STATE_ENABLED,

        [EnumMember(Value = "AwsNativeArchivalEnabled")]
        AWS_NATIVE_ARCHIVAL_ENABLED,

        [EnumMember(Value = "AwsNativeArchivalShortTermRetentionEnabled")]
        AWS_NATIVE_ARCHIVAL_SHORT_TERM_RETENTION_ENABLED,

        [EnumMember(Value = "AwsRDSAutoProtectByTagsEnabled")]
        AWS_RDS_AUTO_PROTECT_BY_TAGS_ENABLED,

        [EnumMember(Value = "AwsRDSCrossRegionReplicationEnabled")]
        AWS_RDS_CROSS_REGION_REPLICATION_ENABLED,

        [EnumMember(Value = "AwsRDSProtectionEnabled")]
        AWS_RDS_PROTECTION_ENABLED,

        [EnumMember(Value = "AwsRoleBasedArchivalLocationsEnabled")]
        AWS_ROLE_BASED_ARCHIVAL_LOCATIONS_ENABLED,

        [EnumMember(Value = "AwsSnsSqsBasedAutomatedFlowEnabled")]
        AWS_SNS_SQS_BASED_AUTOMATED_FLOW_ENABLED,

        [EnumMember(Value = "AzureAppConsistentSnapshotsEnabled")]
        AZURE_APP_CONSISTENT_SNAPSHOTS_ENABLED,

        [EnumMember(Value = "AzureAutoProtectByTagsEnabled")]
        AZURE_AUTO_PROTECT_BY_TAGS_ENABLED,

        [EnumMember(Value = "AzureCommonResourceGroupEnabled")]
        AZURE_COMMON_RESOURCE_GROUP_ENABLED,

        [EnumMember(Value = "AzureCrossRegionReplicationEnabled")]
        AZURE_CROSS_REGION_REPLICATION_ENABLED,

        [EnumMember(Value = "AzureCrossSubscriptionExportEnabled")]
        AZURE_CROSS_SUBSCRIPTION_EXPORT_ENABLED,

        [EnumMember(Value = "AzureFileIndexingEnabled")]
        AZURE_FILE_INDEXING_ENABLED,

        [EnumMember(Value = "AzureLockSnapshotsEnabled")]
        AZURE_LOCK_SNAPSHOTS_ENABLED,

        [EnumMember(Value = "AzureNationalCloudEnabled")]
        AZURE_NATIONAL_CLOUD_ENABLED,

        [EnumMember(Value = "AzureNativeArchivalEnabled")]
        AZURE_NATIVE_ARCHIVAL_ENABLED,

        [EnumMember(Value = "AzureRecoverPoweredOffEnabled")]
        AZURE_RECOVER_POWERED_OFF_ENABLED,

        [EnumMember(Value = "AzureSeparateResourceGroupEnabled")]
        AZURE_SEPARATE_RESOURCE_GROUP_ENABLED,

        [EnumMember(Value = "AzureSnapshotIntegrityEnabled")]
        AZURE_SNAPSHOT_INTEGRITY_ENABLED,

        [EnumMember(Value = "BACKUP_TASK_SUMMARY_REPORT_ENABLED")]
        BACKUP_TASK_SUMMARY_REPORT_ENABLED,

        [EnumMember(Value = "BG_SA_API_ACCESS")]
        BG_SA_API_ACCESS,

        [EnumMember(Value = "BackupFailureRemediationEnabled")]
        BACKUP_FAILURE_REMEDIATION_ENABLED,

        [EnumMember(Value = "CAPACITY_OVERTIME_REPORT_ENABLED")]
        CAPACITY_OVERTIME_REPORT_ENABLED,

        [EnumMember(Value = "CASCADING_ARCHIVAL_ENABLED")]
        CASCADING_ARCHIVAL_ENABLED,

        [EnumMember(Value = "CCES_DELETE_ENABLED")]
        CCES_DELETE_ENABLED,

        [EnumMember(Value = "CCES_DISK_MIGRATION_ENABLED")]
        CCES_DISK_MIGRATION_ENABLED,

        [EnumMember(Value = "CCES_SERVERS_AND_APPS_ENABLED")]
        CCES_SERVERS_AND_APPS_ENABLED,

        [EnumMember(Value = "CCPROVISION_WIZARD_V2_ENABLED")]
        CCPROVISION_WIZARD_V2_ENABLED,

        [EnumMember(Value = "CDM_9_CAMPAIGN_ENABLED")]
        CDM_9_CAMPAIGN_ENABLED,

        [EnumMember(Value = "CDM_9_UPGRADE_ENABLED")]
        CDM_9_UPGRADE_ENABLED,

        [EnumMember(Value = "CDM_API_DATA_IN_PRECHECK_ENABLED")]
        CDM_API_DATA_IN_PRECHECK_ENABLED,

        [EnumMember(Value = "CDM_API_METRICS_BULK_ENABLED")]
        CDM_API_METRICS_BULK_ENABLED,

        [EnumMember(Value = "CDM_CUSTOMER_ADOPTION_ENABLED")]
        CDM_CUSTOMER_ADOPTION_ENABLED,

        [EnumMember(Value = "CDM_ENCRYPTION_MANAGEMENT_ENABLED")]
        CDM_ENCRYPTION_MANAGEMENT_ENABLED,

        [EnumMember(Value = "CDM_LOCATION_UPGRADE_ENABLED")]
        CDM_LOCATION_UPGRADE_ENABLED,

        [EnumMember(Value = "CDM_RSC_RBAC_MIGRATION_ENABLED")]
        CDM_RSC_RBAC_MIGRATION_ENABLED,

        [EnumMember(Value = "CDP_ENABLED")]
        CDP_ENABLED,

        [EnumMember(Value = "CDP_PERFORMANCE_ENABLED")]
        CDP_PERFORMANCE_ENABLED,

        [EnumMember(Value = "CENTRALIZED_SNAPSHOT_MANAGEMENT_ENABLED")]
        CENTRALIZED_SNAPSHOT_MANAGEMENT_ENABLED,

        [EnumMember(Value = "CERTIFICATE_MANAGEMENT_V2_ENABLED")]
        CERTIFICATE_MANAGEMENT_V2_ENABLED,

        [EnumMember(Value = "CHARGE_BACK_REPORT_ENABLED")]
        CHARGE_BACK_REPORT_ENABLED,

        [EnumMember(Value = "CLASSIFICATION_BANNER_ENABLED")]
        CLASSIFICATION_BANNER_ENABLED,

        [EnumMember(Value = "CLASSIFICATION_LOGIN_ENABLED")]
        CLASSIFICATION_LOGIN_ENABLED,

        [EnumMember(Value = "CLOUD_CLUSTER_ES_BETA")]
        CLOUD_CLUSTER_ES_BETA,

        [EnumMember(Value = "CLOUD_CLUSTER_ES_ENABLED")]
        CLOUD_CLUSTER_ES_ENABLED,

        [EnumMember(Value = "CLOUD_COMPUTE_CONNECTIVITY_CHECK_ENABLED")]
        CLOUD_COMPUTE_CONNECTIVITY_CHECK_ENABLED,

        [EnumMember(Value = "CLOUD_DIRECT_CUSTOM_ANALYZERS_ENABLED")]
        CLOUD_DIRECT_CUSTOM_ANALYZERS_ENABLED,

        [EnumMember(Value = "CLOUD_DIRECT_ENABLED")]
        CLOUD_DIRECT_ENABLED,

        [EnumMember(Value = "CLOUD_DIRECT_RSC_INVENTORY_ENABLED")]
        CLOUD_DIRECT_RSC_INVENTORY_ENABLED,

        [EnumMember(Value = "CLOUD_NATIVE_FOR_FEDRAMP_ENABLED")]
        CLOUD_NATIVE_FOR_FEDRAMP_ENABLED,

        [EnumMember(Value = "CLUSTER_CARD_V2_ENABLED")]
        CLUSTER_CARD_V2_ENABLED,

        [EnumMember(Value = "CLUSTER_CONFIG_PROTECTION_ENABLED")]
        CLUSTER_CONFIG_PROTECTION_ENABLED,

        [EnumMember(Value = "CLUSTER_EOS_ENABLED")]
        CLUSTER_EOS_ENABLED,

        [EnumMember(Value = "CLUSTER_MIGRATION_CAMPAIGN_ENABLED")]
        CLUSTER_MIGRATION_CAMPAIGN_ENABLED,

        [EnumMember(Value = "CLUSTER_MODE_SWITCH_ENABLED")]
        CLUSTER_MODE_SWITCH_ENABLED,

        [EnumMember(Value = "CLUSTER_MONITORING_ENABLED")]
        CLUSTER_MONITORING_ENABLED,

        [EnumMember(Value = "CLUSTER_NETWORK_ENABLED")]
        CLUSTER_NETWORK_ENABLED,

        [EnumMember(Value = "CLUSTER_OPERATIONS_ENABLED")]
        CLUSTER_OPERATIONS_ENABLED,

        [EnumMember(Value = "CLUSTER_STATUS_FROM_DB")]
        CLUSTER_STATUS_FROM_DB,

        [EnumMember(Value = "CNP_AKS_CNI_OVERLAY_NETWORKING_ENABLED")]
        CNP_AKS_CNI_OVERLAY_NETWORKING_ENABLED,

        [EnumMember(Value = "CNP_AWS_ARCHIVAL_IMMUTABILITY_ENABLED")]
        CNP_AWS_ARCHIVAL_IMMUTABILITY_ENABLED,

        [EnumMember(Value = "CNP_AWS_AURORA_SUPPORT_ENABLED")]
        CNP_AWS_AURORA_SUPPORT_ENABLED,

        [EnumMember(Value = "CNP_AWS_DIRECT_ARCHIVAL_ENABLED")]
        CNP_AWS_DIRECT_ARCHIVAL_ENABLED,

        [EnumMember(Value = "CNP_AWS_GOV_CLOUD_SUPPORT_ENABLED")]
        CNP_AWS_GOV_CLOUD_SUPPORT_ENABLED,

        [EnumMember(Value = "CNP_AWS_MARKETPLACE_AMI_ENABLED")]
        CNP_AWS_MARKETPLACE_AMI_ENABLED,

        [EnumMember(Value = "CNP_AWS_ORGS_ENABLED")]
        CNP_AWS_ORGS_ENABLED,

        [EnumMember(Value = "CNP_AWS_S3_V1_ENABLED")]
        CNP_AWS_S3_V1_ENABLED,

        [EnumMember(Value = "CNP_AWS_SHARED_EXOCOMPUTE_V2")]
        CNP_AWS_SHARED_EXOCOMPUTE_V2,

        [EnumMember(Value = "CNP_AZURE_AD_IN_SQL_ENABLED")]
        CNP_AZURE_AD_IN_SQL_ENABLED,

        [EnumMember(Value = "CNP_AZURE_ARCHIVAL_IMMUTABILITY_ENABLED")]
        CNP_AZURE_ARCHIVAL_IMMUTABILITY_ENABLED,

        [EnumMember(Value = "CNP_AZURE_BLOB_ALPHA_ENABLED")]
        CNP_AZURE_BLOB_ALPHA_ENABLED,

        [EnumMember(Value = "CNP_AZURE_BLOB_BETA_ENABLED")]
        CNP_AZURE_BLOB_BETA_ENABLED,

        [EnumMember(Value = "CNP_AZURE_BLOB_ENABLED")]
        CNP_AZURE_BLOB_ENABLED,

        [EnumMember(Value = "CNP_AZURE_BLOB_V1_ENABLED")]
        CNP_AZURE_BLOB_V1_ENABLED,

        [EnumMember(Value = "CNP_AZURE_DISK_MOUNT_ENABLED")]
        CNP_AZURE_DISK_MOUNT_ENABLED,

        [EnumMember(Value = "CNP_AZURE_DYNAMIC_IP_ALLOCATION_ENABLED")]
        CNP_AZURE_DYNAMIC_IP_ALLOCATION_ENABLED,

        [EnumMember(Value = "CNP_AZURE_GOV_CLOUD_SUPPORT_ENABLED")]
        CNP_AZURE_GOV_CLOUD_SUPPORT_ENABLED,

        [EnumMember(Value = "CNP_AZURE_INPLACE_FILE_RESTORE_ENABLED")]
        CNP_AZURE_INPLACE_FILE_RESTORE_ENABLED,

        [EnumMember(Value = "CNP_AZURE_PRIVATE_EXO_CLUSTERS_ENABLED")]
        CNP_AZURE_PRIVATE_EXO_CLUSTERS_ENABLED,

        [EnumMember(Value = "CNP_AZURE_SNAPSHOT_PRIVATE_ACCESS_ENABLED")]
        CNP_AZURE_SNAPSHOT_PRIVATE_ACCESS_ENABLED,

        [EnumMember(Value = "CNP_AZURE_SNAPSHOT_PUBLIC_ACCESS_ENABLED")]
        CNP_AZURE_SNAPSHOT_PUBLIC_ACCESS_ENABLED,

        [EnumMember(Value = "CNP_CUSTOMER_MANAGED_EXOCLUSTER_ENABLED")]
        CNP_CUSTOMER_MANAGED_EXOCLUSTER_ENABLED,

        [EnumMember(Value = "CNP_ENABLE_ARCHIVAL_DATA_INTEGRITY_CHECK")]
        CNP_ENABLE_ARCHIVAL_DATA_INTEGRITY_CHECK,

        [EnumMember(Value = "CNP_ENABLE_EXOTASK_RETRY_WITH_CONTAINER_SPEC_ADJUSTMENT")]
        CNP_ENABLE_EXOTASK_RETRY_WITH_CONTAINER_SPEC_ADJUSTMENT,

        [EnumMember(Value = "CNP_EXOCOMPUTE_HEALTH_CHECK_UI_ENABLED")]
        CNP_EXOCOMPUTE_HEALTH_CHECK_UI_ENABLED,

        [EnumMember(Value = "CNP_REPORTING_REVAMP_ENABLED")]
        CNP_REPORTING_REVAMP_ENABLED,

        [EnumMember(Value = "CNP_SNAPSHOT_GC_V2_ENABLED")]
        CNP_SNAPSHOT_GC_V2_ENABLED,

        [EnumMember(Value = "COLOSSUS_METADATA_BACKUP")]
        COLOSSUS_METADATA_BACKUP,

        [EnumMember(Value = "CONNECT_READER_ENABLED")]
        CONNECT_READER_ENABLED,

        [EnumMember(Value = "CONTINUOUS_THREAT_MONITORING_ENABLED")]
        CONTINUOUS_THREAT_MONITORING_ENABLED,

        [EnumMember(Value = "CORS_ENABLED")]
        CORS_ENABLED,

        [EnumMember(Value = "CROSS_ACCOUNT_PAIRING")]
        CROSS_ACCOUNT_PAIRING,

        [EnumMember(Value = "CROWDSTRIKE_PLUGIN_ENABLED")]
        CROWDSTRIKE_PLUGIN_ENABLED,

        [EnumMember(Value = "CTM_CLOUD_SNAPPABLES_ENABLED")]
        CTM_CLOUD_SNAPPABLES_ENABLED,

        [EnumMember(Value = "CTM_THIRD_PARTY_FEEDS_ENABLED")]
        CTM_THIRD_PARTY_FEEDS_ENABLED,

        [EnumMember(Value = "CTM_THREAT_FEED_ENABLED")]
        CTM_THREAT_FEED_ENABLED,

        [EnumMember(Value = "CUSTOMER_CONSENT_ENABLED")]
        CUSTOMER_CONSENT_ENABLED,

        [EnumMember(Value = "CUSTOMER_HOSTED_AZURE_RADAR")]
        CUSTOMER_HOSTED_AZURE_RADAR,

        [EnumMember(Value = "CUSTOMER_HOSTED_AZURE_RADAR_ENABLED_CF")]
        CUSTOMER_HOSTED_AZURE_RADAR_ENABLED_CF,

        [EnumMember(Value = "CUSTOMER_INSIGHTS_ENABLED")]
        CUSTOMER_INSIGHTS_ENABLED,

        [EnumMember(Value = "CUSTOMER_SCOPED_MDS_UPLOAD_ENABLED")]
        CUSTOMER_SCOPED_MDS_UPLOAD_ENABLED,

        [EnumMember(Value = "CUSTOMER_SPECIFIC_SNS_TOPIC_ENABLED")]
        CUSTOMER_SPECIFIC_SNS_TOPIC_ENABLED,

        [EnumMember(Value = "CUSTOMIZABLE_DASHBOARDS_ENABLED")]
        CUSTOMIZABLE_DASHBOARDS_ENABLED,

        [EnumMember(Value = "CUSTOM_THREAT_FEEDS_ENABLED")]
        CUSTOM_THREAT_FEEDS_ENABLED,

        [EnumMember(Value = "CYBER_EVENT_LOCKDOWN_ENABLED")]
        CYBER_EVENT_LOCKDOWN_ENABLED,

        [EnumMember(Value = "CapacityReportNativeSnappableEnabled")]
        CAPACITY_REPORT_NATIVE_SNAPPABLE_ENABLED,

        [EnumMember(Value = "CardPinningEnabled")]
        CARD_PINNING_ENABLED,

        [EnumMember(Value = "CassandraBetaEnabled")]
        CASSANDRA_BETA_ENABLED,

        [EnumMember(Value = "CdmUpgradesEnabled")]
        CDM_UPGRADES_ENABLED,

        [EnumMember(Value = "CdmUpgradesReportNgEnabled")]
        CDM_UPGRADES_REPORT_NG_ENABLED,

        [EnumMember(Value = "CertMgmtEnabled")]
        CERT_MGMT_ENABLED,

        [EnumMember(Value = "CloudAccountsAwsUpgradePermissionEnabled")]
        CLOUD_ACCOUNTS_AWS_UPGRADE_PERMISSION_ENABLED,

        [EnumMember(Value = "CloudAccountsAzureUpgradePermissionEnabled")]
        CLOUD_ACCOUNTS_AZURE_UPGRADE_PERMISSION_ENABLED,

        [EnumMember(Value = "CloudAccountsSeamlessFlowEnabled")]
        CLOUD_ACCOUNTS_SEAMLESS_FLOW_ENABLED,

        [EnumMember(Value = "CloudAccountsStackSetFlowEnabled")]
        CLOUD_ACCOUNTS_STACK_SET_FLOW_ENABLED,

        [EnumMember(Value = "CloudNativeAWSEnabled")]
        CLOUD_NATIVE_AWS_ENABLED,

        [EnumMember(Value = "CloudNativeAzureEnabled")]
        CLOUD_NATIVE_AZURE_ENABLED,

        [EnumMember(Value = "CloudNativeGCPEnabled")]
        CLOUD_NATIVE_GCP_ENABLED,

        [EnumMember(Value = "CloudNativePermissionsVisibilityEnabled")]
        CLOUD_NATIVE_PERMISSIONS_VISIBILITY_ENABLED,

        [EnumMember(Value = "CloudNativeUnmanagedObjectsEnabled")]
        CLOUD_NATIVE_UNMANAGED_OBJECTS_ENABLED,

        [EnumMember(Value = "ClusterAddForbidden")]
        CLUSTER_ADD_FORBIDDEN,

        [EnumMember(Value = "ClusterListFilterEnabled")]
        CLUSTER_LIST_FILTER_ENABLED,

        [EnumMember(Value = "ClusterSyncJobsAlertsEnabled")]
        CLUSTER_SYNC_JOBS_ALERTS_ENABLED,

        [EnumMember(Value = "DASHBOARD_SWITCHER_ENABLED")]
        DASHBOARD_SWITCHER_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_BATCHED_SYNC_ENABLED")]
        DATA_DISCOVERY_BATCHED_SYNC_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_DASHBOARD_UI_OPTIMIZATION_ENABLED")]
        DATA_DISCOVERY_DASHBOARD_UI_OPTIMIZATION_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_ML_ANALYZERS_ENABLED")]
        DATA_DISCOVERY_ML_ANALYZERS_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_OBJECT_DETAILS_COMPUTE_ENABLED")]
        DATA_DISCOVERY_OBJECT_DETAILS_COMPUTE_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_OPTIMIZED_CONTENT_REPORT_ENABLED")]
        DATA_DISCOVERY_OPTIMIZED_CONTENT_REPORT_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_OPTIMIZED_DB_SCHEMA_FOR_API_ENABLED")]
        DATA_DISCOVERY_OPTIMIZED_DB_SCHEMA_FOR_API_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_OPTIMIZED_MANAGEMENT_PAGE_ENABLED")]
        DATA_DISCOVERY_OPTIMIZED_MANAGEMENT_PAGE_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_OPTIMIZED_OBJECTS_LIST_ENABLED")]
        DATA_DISCOVERY_OPTIMIZED_OBJECTS_LIST_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_OPTIMIZED_OBJECT_STATUS_ENABLED")]
        DATA_DISCOVERY_OPTIMIZED_OBJECT_STATUS_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_OPTIMIZED_POLICYOBJ_API_ENABLED")]
        DATA_DISCOVERY_OPTIMIZED_POLICYOBJ_API_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_OPTIMIZED_POLICY_DETAILS_ENABLED")]
        DATA_DISCOVERY_OPTIMIZED_POLICY_DETAILS_ENABLED,

        [EnumMember(Value = "DATA_DISCOVERY_RISK_COMPUTATION_ENABLED")]
        DATA_DISCOVERY_RISK_COMPUTATION_ENABLED,

        [EnumMember(Value = "DATA_SYNC_THROUGH_RSC_PROXY_ENABLED")]
        DATA_SYNC_THROUGH_RSC_PROXY_ENABLED,

        [EnumMember(Value = "DB2_ARCHIVAL_ENABLED")]
        DB2_ARCHIVAL_ENABLED,

        [EnumMember(Value = "DB2_BACKUP_CONFIG_ENABLED")]
        DB2_BACKUP_CONFIG_ENABLED,

        [EnumMember(Value = "DB2_ENABLED")]
        DB2_ENABLED,

        [EnumMember(Value = "DB2_HADR_ENABLED")]
        DB2_HADR_ENABLED,

        [EnumMember(Value = "DB2_LOGARCHMETH2_SUPPORT_ENABLED")]
        DB2_LOGARCHMETH2_SUPPORT_ENABLED,

        [EnumMember(Value = "DB2_PASSWORDLESS_DISCOVERY_ENABLED")]
        DB2_PASSWORDLESS_DISCOVERY_ENABLED,

        [EnumMember(Value = "DB2_REPLICATION_ENABLED")]
        DB2_REPLICATION_ENABLED,

        [EnumMember(Value = "DB2_RETENTION_LOCK_ENABLED")]
        DB2_RETENTION_LOCK_ENABLED,

        [EnumMember(Value = "DB_LOG_REPORTING_ENABLED")]
        DB_LOG_REPORTING_ENABLED,

        [EnumMember(Value = "DELL_ECS_ENABLED")]
        DELL_ECS_ENABLED,

        [EnumMember(Value = "DEPLOY_VIRTUAL_CLUSTER_ENABLED")]
        DEPLOY_VIRTUAL_CLUSTER_ENABLED,

        [EnumMember(Value = "DISABLE_LOW_PERFORMANCE_COMPONENT")]
        DISABLE_LOW_PERFORMANCE_COMPONENT,

        [EnumMember(Value = "DNS_NETWORK_SETTINGS_ENABLED")]
        DNS_NETWORK_SETTINGS_ENABLED,

        [EnumMember(Value = "DOCS_LOCKDOWN")]
        DOCS_LOCKDOWN,

        [EnumMember(Value = "DSAAS_RANSOMWARE_INVESTIGATION_GA_ENABLED")]
        DSAAS_RANSOMWARE_INVESTIGATION_GA_ENABLED,

        [EnumMember(Value = "DSCC_DASHBOARD_ENABLED")]
        DSCC_DASHBOARD_ENABLED,

        [EnumMember(Value = "DSCC_METRICS_COLLECTION_ENABLED")]
        DSCC_METRICS_COLLECTION_ENABLED,

        [EnumMember(Value = "DSCC_METRICS_V2_ENABLED")]
        DSCC_METRICS_V2_ENABLED,

        [EnumMember(Value = "DSCC_PDF_DOWNLOAD_ENABLED")]
        DSCC_PDF_DOWNLOAD_ENABLED,

        [EnumMember(Value = "DSPM_UNIFIED_ASSET_INVENTORY_V1_ENABLED")]
        DSPM_UNIFIED_ASSET_INVENTORY_V1_ENABLED,

        [EnumMember(Value = "DTA_DASHBOARD_ENHANCEMENTS_ENABLED")]
        DTA_DASHBOARD_ENHANCEMENTS_ENABLED,

        [EnumMember(Value = "DarkSiteEnabled")]
        DARK_SITE_ENABLED,

        [EnumMember(Value = "DataClassificationDevEnabled")]
        DATA_CLASSIFICATION_DEV_ENABLED,

        [EnumMember(Value = "DataClassificationEnabled")]
        DATA_CLASSIFICATION_ENABLED,

        [EnumMember(Value = "DatagovNasAuditEnabled")]
        DATAGOV_NAS_AUDIT_ENABLED,

        [EnumMember(Value = "DetailedInventoryCardEnabled")]
        DETAILED_INVENTORY_CARD_ENABLED,

        [EnumMember(Value = "EMPTY_SCHEDULE_SLA_DOMAIN_ENABLED")]
        EMPTY_SCHEDULE_SLA_DOMAIN_ENABLED,

        [EnumMember(Value = "ENABLE_ARCHIVAL_AWS_SECURE_ACCESS")]
        ENABLE_ARCHIVAL_AWS_SECURE_ACCESS,

        [EnumMember(Value = "ENABLE_ARCHIVAL_AZURE_SECURE_ACCESS")]
        ENABLE_ARCHIVAL_AZURE_SECURE_ACCESS,

        [EnumMember(Value = "ENABLE_AWS_MANAGED_POLICIES")]
        ENABLE_AWS_MANAGED_POLICIES,

        [EnumMember(Value = "ENABLE_BULK_REGISTER_HOST_ASYNC_API")]
        ENABLE_BULK_REGISTER_HOST_ASYNC_API,

        [EnumMember(Value = "ENABLE_CHARTS_IN_REPORTS_EMAILS")]
        ENABLE_CHARTS_IN_REPORTS_EMAILS,

        [EnumMember(Value = "ENABLE_LOGIN_REFACTOR")]
        ENABLE_LOGIN_REFACTOR,

        [EnumMember(Value = "ENABLE_MED_COMPLEX_MIGRATION")]
        ENABLE_MED_COMPLEX_MIGRATION,

        [EnumMember(Value = "ENABLE_MY_REPORTS")]
        ENABLE_MY_REPORTS,

        [EnumMember(Value = "ENABLE_RSC_PROXY_BASED_UPGRADES")]
        ENABLE_RSC_PROXY_BASED_UPGRADES,

        [EnumMember(Value = "ENABLE_SENTRY_REPLACE")]
        ENABLE_SENTRY_REPLACE,

        [EnumMember(Value = "ENABLE_SENTRY_REPLAY")]
        ENABLE_SENTRY_REPLAY,

        [EnumMember(Value = "ENABLE_UCL_LAMINAR_INTEGRATION")]
        ENABLE_UCL_LAMINAR_INTEGRATION,

        [EnumMember(Value = "ENABLE_UPGRADE_TYPE")]
        ENABLE_UPGRADE_TYPE,

        [EnumMember(Value = "ENTRAID_ROLES_AND_RELATIONSHIP_RECOVERY_ENABLED")]
        ENTRAID_ROLES_AND_RELATIONSHIP_RECOVERY_ENABLED,

        [EnumMember(Value = "EXPIRATION_ANCESTOR_LEVEL_ENABLED")]
        EXPIRATION_ANCESTOR_LEVEL_ENABLED,

        [EnumMember(Value = "EXTENDED_EVENTS_TIME_RANGE_FILTER")]
        EXTENDED_EVENTS_TIME_RANGE_FILTER,

        [EnumMember(Value = "EnforceMoatOnAPIsEnabled")]
        ENFORCE_MOAT_ON_AP_IS_ENABLED,

        [EnumMember(Value = "FEDERATED_LOGIN_PORT_ENABLED")]
        FEDERATED_LOGIN_PORT_ENABLED,

        [EnumMember(Value = "FEDLOGIN_GRANULAR_RBAC_ENABLED")]
        FEDLOGIN_GRANULAR_RBAC_ENABLED,

        [EnumMember(Value = "FILESET_TEMPLATE_HIERARCHY_ENABLED")]
        FILESET_TEMPLATE_HIERARCHY_ENABLED,

        [EnumMember(Value = "FederatedLoginEnabled")]
        FEDERATED_LOGIN_ENABLED,

        [EnumMember(Value = "FilesetFeatureEnablementEnabled")]
        FILESET_FEATURE_ENABLEMENT_ENABLED,

        [EnumMember(Value = "FilesetInventoryEAEnabled")]
        FILESET_INVENTORY_EA_ENABLED,

        [EnumMember(Value = "FilesetInventoryEnabled")]
        FILESET_INVENTORY_ENABLED,

        [EnumMember(Value = "FilesetRbacEnabled")]
        FILESET_RBAC_ENABLED,

        [EnumMember(Value = "GLOBAL_FILE_SEARCH_ENABLED")]
        GLOBAL_FILE_SEARCH_ENABLED,

        [EnumMember(Value = "GLOBAL_SLA_AUDIT_REPORT_ENABLED")]
        GLOBAL_SLA_AUDIT_REPORT_ENABLED,

        [EnumMember(Value = "GPS_DASH_V2_ENABLED")]
        GPS_DASH_V2_ENABLED,

        [EnumMember(Value = "GPS_ENABLED")]
        GPS_ENABLED,

        [EnumMember(Value = "GSLA_ARCHIVAL_REVAMP_ENABLED")]
        GSLA_ARCHIVAL_REVAMP_ENABLED,

        [EnumMember(Value = "GUEST_OS_CREDENTIAL_ENABLED")]
        GUEST_OS_CREDENTIAL_ENABLED,

        [EnumMember(Value = "GcpNativeAutoProtectByTagsEnabled")]
        GCP_NATIVE_AUTO_PROTECT_BY_TAGS_ENABLED,

        [EnumMember(Value = "GcpNativeCrossProjectInstanceExport")]
        GCP_NATIVE_CROSS_PROJECT_INSTANCE_EXPORT,

        [EnumMember(Value = "GcpNativeDiskProtection")]
        GCP_NATIVE_DISK_PROTECTION,

        [EnumMember(Value = "GcpNativeExportEncryptedInstances")]
        GCP_NATIVE_EXPORT_ENCRYPTED_INSTANCES,

        [EnumMember(Value = "GcpNativeExportInstanceInStoppedState")]
        GCP_NATIVE_EXPORT_INSTANCE_IN_STOPPED_STATE,

        [EnumMember(Value = "GcpNativeExportInstancesInSharedVPC")]
        GCP_NATIVE_EXPORT_INSTANCES_IN_SHARED_VPC,

        [EnumMember(Value = "GcpNativeRestoreEncryptedInstances")]
        GCP_NATIVE_RESTORE_ENCRYPTED_INSTANCES,

        [EnumMember(Value = "GcpNativeSnapshotStorageReport")]
        GCP_NATIVE_SNAPSHOT_STORAGE_REPORT,

        [EnumMember(Value = "GlobalDashboardEntryPointEnabled")]
        GLOBAL_DASHBOARD_ENTRY_POINT_ENABLED,

        [EnumMember(Value = "GlobalDashboardPageEnabled")]
        GLOBAL_DASHBOARD_PAGE_ENABLED,

        [EnumMember(Value = "GlobalSLAForCDMSnappablesEnabled")]
        GLOBAL_SLA_FOR_CDM_SNAPPABLES_ENABLED,

        [EnumMember(Value = "GlobalSLAGPSEnabled")]
        GLOBAL_SLAGPS_ENABLED,

        [EnumMember(Value = "HYPERV_BATCH_ON_DEMAND_BACKUP_ENABLED")]
        HYPERV_BATCH_ON_DEMAND_BACKUP_ENABLED,

        [EnumMember(Value = "HYPERV_ENABLED")]
        HYPERV_ENABLED,

        [EnumMember(Value = "HYPERV_MASS_RECOVERY_ENABLED")]
        HYPERV_MASS_RECOVERY_ENABLED,

        [EnumMember(Value = "HyperVHierarchyEnabled")]
        HYPER_VHIERARCHY_ENABLED,

        [EnumMember(Value = "HyperVInventoryViewEnabled")]
        HYPER_VINVENTORY_VIEW_ENABLED,

        [EnumMember(Value = "IAM_MULTITENANCY_ENABLED")]
        IAM_MULTITENANCY_ENABLED,

        [EnumMember(Value = "IAM_WEB_AUTHN")]
        IAM_WEB_AUTHN,

        [EnumMember(Value = "IBM_COS_ENABLED")]
        IBM_COS_ENABLED,

        [EnumMember(Value = "INDEXING_REPORT_ENABLED")]
        INDEXING_REPORT_ENABLED,

        [EnumMember(Value = "INFINITY_K8S_ENABLED")]
        INFINITY_K8S_ENABLED,

        [EnumMember(Value = "INFRASTRUCTURE_MENU_ENABLED")]
        INFRASTRUCTURE_MENU_ENABLED,

        [EnumMember(Value = "INTEGRATIONS_HUB_ENABLED")]
        INTEGRATIONS_HUB_ENABLED,

        [EnumMember(Value = "INVENTORY_SWITCHER_ENABLED")]
        INVENTORY_SWITCHER_ENABLED,

        [EnumMember(Value = "IS_DIRTY_CHECK_ENABLED")]
        IS_DIRTY_CHECK_ENABLED,

        [EnumMember(Value = "IS_HYBRID_LICENSE_ONLY_CUSTOMER")]
        IS_HYBRID_LICENSE_ONLY_CUSTOMER,

        [EnumMember(Value = "JIRA_ENABLED")]
        JIRA_ENABLED,

        [EnumMember(Value = "JIRA_GA_2_ENABLED")]
        JIRA_GA_2_ENABLED,

        [EnumMember(Value = "JWT_COOKIE_ENABLED")]
        JWT_COOKIE_ENABLED,

        [EnumMember(Value = "JWT_SIZE_REDUCTION_ENABLED")]
        JWT_SIZE_REDUCTION_ENABLED,

        [EnumMember(Value = "JobMonitoringUIEnabled")]
        JOB_MONITORING_UI_ENABLED,

        [EnumMember(Value = "K8S_AWS_CLOUD_ACCOUNTS_ENABLED")]
        K8S_AWS_CLOUD_ACCOUNTS_ENABLED,

        [EnumMember(Value = "KEEP_CCES_RESOURCES_ON_FAILURE")]
        KEEP_CCES_RESOURCES_ON_FAILURE,

        [EnumMember(Value = "KUBERNETES_SSF_ENABLED")]
        KUBERNETES_SSF_ENABLED,

        [EnumMember(Value = "KUPR_GA_ENABLED")]
        KUPR_GA_ENABLED,

        [EnumMember(Value = "KUPR_REPLICATION_ENABLED")]
        KUPR_REPLICATION_ENABLED,

        [EnumMember(Value = "KubernetesInventoryEnabled")]
        KUBERNETES_INVENTORY_ENABLED,

        [EnumMember(Value = "LANGUAGE_CHINESE_SIMPLIFIED_ENABLED")]
        LANGUAGE_CHINESE_SIMPLIFIED_ENABLED,

        [EnumMember(Value = "LANGUAGE_JAPANESE_ENABLED")]
        LANGUAGE_JAPANESE_ENABLED,

        [EnumMember(Value = "LAST_SNAPSHOT_LOGICAL_SIZE_ENABLED")]
        LAST_SNAPSHOT_LOGICAL_SIZE_ENABLED,

        [EnumMember(Value = "LEAKED_PASSWORD_DETECTION_ENABLED")]
        LEAKED_PASSWORD_DETECTION_ENABLED,

        [EnumMember(Value = "LEGACY_SLA_LOOKUP_STRATEGY")]
        LEGACY_SLA_LOOKUP_STRATEGY,

        [EnumMember(Value = "LICENSE_MANAGEMENT_UI_ENABLED")]
        LICENSE_MANAGEMENT_UI_ENABLED,

        [EnumMember(Value = "LICENSE_MANAGEMENT_V2_ENABLED")]
        LICENSE_MANAGEMENT_V2_ENABLED,

        [EnumMember(Value = "LIST_AND_FILTERS_V2_ENABLED")]
        LIST_AND_FILTERS_V2_ENABLED,

        [EnumMember(Value = "LLM_CHAT_ENABLED")]
        LLM_CHAT_ENABLED,

        [EnumMember(Value = "LOG_SLA_OVERRIDE_MSSQL_ENABLED")]
        LOG_SLA_OVERRIDE_MSSQL_ENABLED,

        [EnumMember(Value = "LOG_SLA_OVERRIDE_ORACLE_ENABLED")]
        LOG_SLA_OVERRIDE_ORACLE_ENABLED,

        [EnumMember(Value = "LambdaEnabled")]
        LAMBDA_ENABLED,

        [EnumMember(Value = "LdapEnabled")]
        LDAP_ENABLED,

        [EnumMember(Value = "LegalHoldEnabled")]
        LEGAL_HOLD_ENABLED,

        [EnumMember(Value = "M365_ADVANCED_SETUP_V2")]
        M365_ADVANCED_SETUP_V2,

        [EnumMember(Value = "M365_BACKUP_STORAGE_ENABLED")]
        M365_BACKUP_STORAGE_ENABLED,

        [EnumMember(Value = "M365_BYOK_ENABLED")]
        M365_BYOK_ENABLED,

        [EnumMember(Value = "M365_DELEGATED_PERMISSIONS")]
        M365_DELEGATED_PERMISSIONS,

        [EnumMember(Value = "M365_EXCHANGE_OPERATIONAL_RECOVERY_ENABLED")]
        M365_EXCHANGE_OPERATIONAL_RECOVERY_ENABLED,

        [EnumMember(Value = "M365_EXCHANGE_PARTIAL_RESTORE_ENABLED")]
        M365_EXCHANGE_PARTIAL_RESTORE_ENABLED,

        [EnumMember(Value = "M365_EXCHANGE_RECOVERABLE_ITEMS_FOLDER_ENABLED")]
        M365_EXCHANGE_RECOVERABLE_ITEMS_FOLDER_ENABLED,

        [EnumMember(Value = "M365_EXCHANGE_RECOVERY_TO_SECOND_SUBSCRIPTION_ENABLED")]
        M365_EXCHANGE_RECOVERY_TO_SECOND_SUBSCRIPTION_ENABLED,

        [EnumMember(Value = "M365_FULL_SHAREPOINT_ENABLED")]
        M365_FULL_SHAREPOINT_ENABLED,

        [EnumMember(Value = "M365_IMMUTABILITY_ENABLED")]
        M365_IMMUTABILITY_ENABLED,

        [EnumMember(Value = "M365_INPLACE_BULK_RECOVERY_ENABLED")]
        M365_INPLACE_BULK_RECOVERY_ENABLED,

        [EnumMember(Value = "M365_INPLACE_RESTORE_ENABLED")]
        M365_INPLACE_RESTORE_ENABLED,

        [EnumMember(Value = "M365_L3_ENCRYPTION")]
        M365_L3_ENCRYPTION,

        [EnumMember(Value = "M365_LICENSE_VISIBILITY_ENABLED")]
        M365_LICENSE_VISIBILITY_ENABLED,

        [EnumMember(Value = "M365_MULTI_GEO")]
        M365_MULTI_GEO,

        [EnumMember(Value = "M365_NEW_DASHBOARD")]
        M365_NEW_DASHBOARD,

        [EnumMember(Value = "M365_ONEDRIVE_PARTIAL_RESTORE_ENABLED")]
        M365_ONEDRIVE_PARTIAL_RESTORE_ENABLED,

        [EnumMember(Value = "M365_ONEDRIVE_RANSOMWARE_INVESTIGATION_ENABLED")]
        M365_ONEDRIVE_RANSOMWARE_INVESTIGATION_ENABLED,

        [EnumMember(Value = "M365_ONEDRIVE_RECOVERY_TO_SECOND_SUBSCRIPTION_ENABLED")]
        M365_ONEDRIVE_RECOVERY_TO_SECOND_SUBSCRIPTION_ENABLED,

        [EnumMember(Value = "M365_RESTORE_TO_SECOND_SUBSCRIPTION_ENABLED")]
        M365_RESTORE_TO_SECOND_SUBSCRIPTION_ENABLED,

        [EnumMember(Value = "M365_RSC_GROUP_ENHANCEMENT_ENABLED")]
        M365_RSC_GROUP_ENHANCEMENT_ENABLED,

        [EnumMember(Value = "M365_SHAREPOINTDRIVE_RANSOMWARE_INVESTIGATION_ENABLED")]
        M365_SHAREPOINTDRIVE_RANSOMWARE_INVESTIGATION_ENABLED,

        [EnumMember(Value = "M365_SHAREPOINT_RECOVERY_TO_SECOND_SUBSCRIPTION_ENABLED")]
        M365_SHAREPOINT_RECOVERY_TO_SECOND_SUBSCRIPTION_ENABLED,

        [EnumMember(Value = "M365_SHAREPOINT_RELIC_RESTORE_ENABLED")]
        M365_SHAREPOINT_RELIC_RESTORE_ENABLED,

        [EnumMember(Value = "M365_SINGLE_APP_EXCHANGE")]
        M365_SINGLE_APP_EXCHANGE,

        [EnumMember(Value = "M365_SINGLE_APP_SP_OD")]
        M365_SINGLE_APP_SP_OD,

        [EnumMember(Value = "M365_SKIPPED_ITEM_VISIBILITY_ENABLED")]
        M365_SKIPPED_ITEM_VISIBILITY_ENABLED,

        [EnumMember(Value = "M365_SLA_EXCLUSION")]
        M365_SLA_EXCLUSION,

        [EnumMember(Value = "M365_SP_HIERARCHY_FETCH_OPTIMIZATION_ENABLED")]
        M365_SP_HIERARCHY_FETCH_OPTIMIZATION_ENABLED,

        [EnumMember(Value = "M365_TEAMS_INPLACE_RESTORE_ENABLED")]
        M365_TEAMS_INPLACE_RESTORE_ENABLED,

        [EnumMember(Value = "M365_TEAMS_RECOVERY_TO_SECOND_SUBSCRIPTION_ENABLED")]
        M365_TEAMS_RECOVERY_TO_SECOND_SUBSCRIPTION_ENABLED,

        [EnumMember(Value = "M365_TEAMS_SHARED_CHANNEL_ENABLED")]
        M365_TEAMS_SHARED_CHANNEL_ENABLED,

        [EnumMember(Value = "MANAGED_VOLUME_ENABLED")]
        MANAGED_VOLUME_ENABLED,

        [EnumMember(Value = "MANAGED_VOLUME_LOG_EXPORT_ENABLED")]
        MANAGED_VOLUME_LOG_EXPORT_ENABLED,

        [EnumMember(Value = "MANDATORY_TOTP_ENABLED")]
        MANDATORY_TOTP_ENABLED,

        [EnumMember(Value = "MIGRATION_SLA_BLOCK_MODE")]
        MIGRATION_SLA_BLOCK_MODE,

        [EnumMember(Value = "MINUTE_LEVEL_SLA_FREQUENCY_ENABLED")]
        MINUTE_LEVEL_SLA_FREQUENCY_ENABLED,

        [EnumMember(Value = "MISSING_CLUSTER_MGMT_ENABLED")]
        MISSING_CLUSTER_MGMT_ENABLED,

        [EnumMember(Value = "MODAL_DARK_MODE_ALLOWED")]
        MODAL_DARK_MODE_ALLOWED,

        [EnumMember(Value = "MONGO_BETA_ENABLED")]
        MONGO_BETA_ENABLED,

        [EnumMember(Value = "MONGO_CDM_ARCHIVAL_ENABLED")]
        MONGO_CDM_ARCHIVAL_ENABLED,

        [EnumMember(Value = "MONGO_CDM_ENABLED")]
        MONGO_CDM_ENABLED,

        [EnumMember(Value = "MONGO_CDM_REPLICATION_ENABLED")]
        MONGO_CDM_REPLICATION_ENABLED,

        [EnumMember(Value = "MONGO_OPSMANAGER_ENABLED")]
        MONGO_OPSMANAGER_ENABLED,

        [EnumMember(Value = "MONGO_RETENTION_LOCK_ENABLED")]
        MONGO_RETENTION_LOCK_ENABLED,

        [EnumMember(Value = "MORE_MENU_ENABLED")]
        MORE_MENU_ENABLED,

        [EnumMember(Value = "MSSQL_MULTI_CLUSTER_SLA_ASSIGNMENT_ENABLED")]
        MSSQL_MULTI_CLUSTER_SLA_ASSIGNMENT_ENABLED,

        [EnumMember(Value = "MSSQL_MULTI_DC_AG_ENABLED")]
        MSSQL_MULTI_DC_AG_ENABLED,

        [EnumMember(Value = "MSSQL_SENSITIVE_DATA_DISCOVERY_ENABLED")]
        MSSQL_SENSITIVE_DATA_DISCOVERY_ENABLED,

        [EnumMember(Value = "MSSQL_SNAPSHOT_MANAGEMENT_ENABLED")]
        MSSQL_SNAPSHOT_MANAGEMENT_ENABLED,

        [EnumMember(Value = "MS_EXCHANGE_GA_ENABLED")]
        MS_EXCHANGE_GA_ENABLED,

        [EnumMember(Value = "MS_EXCHANGE_INVENTORY_ENABLED")]
        MS_EXCHANGE_INVENTORY_ENABLED,

        [EnumMember(Value = "MS_EXCHANGE_REPLICATION_ENABLED")]
        MS_EXCHANGE_REPLICATION_ENABLED,

        [EnumMember(Value = "MULTIPLE_ACCOUNT_OWNERS_ENABLED")]
        MULTIPLE_ACCOUNT_OWNERS_ENABLED,

        [EnumMember(Value = "MULTIPLE_ARCHIVAL_ENABLED")]
        MULTIPLE_ARCHIVAL_ENABLED,

        [EnumMember(Value = "MULTITENANCY_ARCHIVAL_PARITY_ENABLED")]
        MULTITENANCY_ARCHIVAL_PARITY_ENABLED,

        [EnumMember(Value = "MULTITENANCY_ORG_BRANDING_ENABLED")]
        MULTITENANCY_ORG_BRANDING_ENABLED,

        [EnumMember(Value = "MULTITENANCY_TENANT_QUOTAS_ENABLED")]
        MULTITENANCY_TENANT_QUOTAS_ENABLED,

        [EnumMember(Value = "MULTITENANCY_TENANT_SLA_SELF_SERVICE_ENABLED")]
        MULTITENANCY_TENANT_SLA_SELF_SERVICE_ENABLED,

        [EnumMember(Value = "MXN_REPLICATION_ENABLED")]
        MXN_REPLICATION_ENABLED,

        [EnumMember(Value = "ManagedVolumeHierarchyEnabled")]
        MANAGED_VOLUME_HIERARCHY_ENABLED,

        [EnumMember(Value = "MetadataPullerPrioritySchedulingEnabled")]
        METADATA_PULLER_PRIORITY_SCHEDULING_ENABLED,

        [EnumMember(Value = "MetadataSyncAdvancedMetricsEnabled")]
        METADATA_SYNC_ADVANCED_METRICS_ENABLED,

        [EnumMember(Value = "MetadataSyncDeletionEnabled")]
        METADATA_SYNC_DELETION_ENABLED,

        [EnumMember(Value = "MssqlBetaEnabled")]
        MSSQL_BETA_ENABLED,

        [EnumMember(Value = "MssqlFeatureEnablementEnabled")]
        MSSQL_FEATURE_ENABLEMENT_ENABLED,

        [EnumMember(Value = "MssqlGAEnabled")]
        MSSQL_GA_ENABLED,

        [EnumMember(Value = "MssqlHierarchyEnabled")]
        MSSQL_HIERARCHY_ENABLED,

        [EnumMember(Value = "NAS_ACKNOWLEDGED_MIGRATION_ENABLED")]
        NAS_ACKNOWLEDGED_MIGRATION_ENABLED,

        [EnumMember(Value = "NAS_ADD_SHARE_NON_GENERIC")]
        NAS_ADD_SHARE_NON_GENERIC,

        [EnumMember(Value = "NAS_CDM_HOST_TAB_ENABLED")]
        NAS_CDM_HOST_TAB_ENABLED,

        [EnumMember(Value = "NAS_CD_DASHBOARD_ENABLED")]
        NAS_CD_DASHBOARD_ENABLED,

        [EnumMember(Value = "NAS_DISCOVER_AND_MIGRATE_ENABLED")]
        NAS_DISCOVER_AND_MIGRATE_ENABLED,

        [EnumMember(Value = "NAS_FEATURE_ENABLEMENT_ENABLED")]
        NAS_FEATURE_ENABLEMENT_ENABLED,

        [EnumMember(Value = "NAS_GENERIC_AUTO_MIGRATION_ENABLED")]
        NAS_GENERIC_AUTO_MIGRATION_ENABLED,

        [EnumMember(Value = "NAS_INVENTORY_ENABLED")]
        NAS_INVENTORY_ENABLED,

        [EnumMember(Value = "NAS_INVENTORY_GA_ENABLED")]
        NAS_INVENTORY_GA_ENABLED,

        [EnumMember(Value = "NAS_MIGRATION_CDM_CONFIG_CHECK_ENABLED")]
        NAS_MIGRATION_CDM_CONFIG_CHECK_ENABLED,

        [EnumMember(Value = "NAS_NUTANIX_FILE_SERVER_ENABLED")]
        NAS_NUTANIX_FILE_SERVER_ENABLED,

        [EnumMember(Value = "NAS_NUTANIX_SYSTEM_ENABLED")]
        NAS_NUTANIX_SYSTEM_ENABLED,

        [EnumMember(Value = "NAS_PURE_SYSTEM_ENABLED")]
        NAS_PURE_SYSTEM_ENABLED,

        [EnumMember(Value = "NAS_RBAC_ENABLED")]
        NAS_RBAC_ENABLED,

        [EnumMember(Value = "NAS_UNDISCOVERABLE_GENERIC_ENABLED")]
        NAS_UNDISCOVERABLE_GENERIC_ENABLED,

        [EnumMember(Value = "NAS_USER_SPECIFIED_SMB_CREDENTIALS_ENABLED")]
        NAS_USER_SPECIFIED_SMB_CREDENTIALS_ENABLED,

        [EnumMember(Value = "NATIVE_ACCOUNT_LOCKOUT_ENABLED")]
        NATIVE_ACCOUNT_LOCKOUT_ENABLED,

        [EnumMember(Value = "NATIVE_ACCOUNT_LOCKOUT_SELF_SERVICE_SUPPORT_ENABLED")]
        NATIVE_ACCOUNT_LOCKOUT_SELF_SERVICE_SUPPORT_ENABLED,

        [EnumMember(Value = "NATIVE_ACCOUNT_LOCKOUT_V2_ENABLED")]
        NATIVE_ACCOUNT_LOCKOUT_V2_ENABLED,

        [EnumMember(Value = "NATIVE_SERVICE_ACCOUNT_AUTHENTICATION_ENABLED")]
        NATIVE_SERVICE_ACCOUNT_AUTHENTICATION_ENABLED,

        [EnumMember(Value = "NATIVE_SSO_ENABLED")]
        NATIVE_SSO_ENABLED,

        [EnumMember(Value = "NAVIGATION_HISTORY_ENABLED")]
        NAVIGATION_HISTORY_ENABLED,

        [EnumMember(Value = "NETAPP_SG_ENABLED")]
        NETAPP_SG_ENABLED,

        [EnumMember(Value = "NETWORK_THROTTLE_ENABLED")]
        NETWORK_THROTTLE_ENABLED,

        [EnumMember(Value = "NETWORK_UPDATE_ENABLE")]
        NETWORK_UPDATE_ENABLE,

        [EnumMember(Value = "NEW_M365_RECOVERY_RBAC_ENABLED")]
        NEW_M365_RECOVERY_RBAC_ENABLED,

        [EnumMember(Value = "NEW_O365_AUTH_ENABLED")]
        NEW_O365_AUTH_ENABLED,

        [EnumMember(Value = "NEW_SETTINGS_MENU_ENABLED")]
        NEW_SETTINGS_MENU_ENABLED,

        [EnumMember(Value = "NEW_THEMES_MIXED_MODE_ENABLED")]
        NEW_THEMES_MIXED_MODE_ENABLED,

        [EnumMember(Value = "NODE_REMOVAL_ENABLED")]
        NODE_REMOVAL_ENABLED,

        [EnumMember(Value = "NODE_REPLACEMENT_ENABLED")]
        NODE_REPLACEMENT_ENABLED,

        [EnumMember(Value = "NOTES_ENABLED")]
        NOTES_ENABLED,

        [EnumMember(Value = "NUTANIX_BULK_TAKE_ON_DEMAND_SNAPSHOT_ENABLED")]
        NUTANIX_BULK_TAKE_ON_DEMAND_SNAPSHOT_ENABLED,

        [EnumMember(Value = "NUTANIX_CATEGORY_ENABLED")]
        NUTANIX_CATEGORY_ENABLED,

        [EnumMember(Value = "NUTANIX_ENABLED")]
        NUTANIX_ENABLED,

        [EnumMember(Value = "NUTANIX_MASS_RECOVERY_ENABLED")]
        NUTANIX_MASS_RECOVERY_ENABLED,

        [EnumMember(Value = "NUTANIX_NETWORK_RESTORE_ENABLED")]
        NUTANIX_NETWORK_RESTORE_ENABLED,

        [EnumMember(Value = "NameSplitRefreshKorgJobEnabled")]
        NAME_SPLIT_REFRESH_KORG_JOB_ENABLED,

        [EnumMember(Value = "NasFilesetRbacEnabled")]
        NAS_FILESET_RBAC_ENABLED,

        [EnumMember(Value = "NewThemesEnabled")]
        NEW_THEMES_ENABLED,

        [EnumMember(Value = "O365CalendarEnabled")]
        O365_CALENDAR_ENABLED,

        [EnumMember(Value = "O365DashboardEnabled")]
        O365_DASHBOARD_ENABLED,

        [EnumMember(Value = "O365DashboardV2Enabled")]
        O365_DASHBOARD_V2_ENABLED,

        [EnumMember(Value = "O365ExchangeAppShardingEnabled")]
        O365_EXCHANGE_APP_SHARDING_ENABLED,

        [EnumMember(Value = "O365InventoryEnabled")]
        O365_INVENTORY_ENABLED,

        [EnumMember(Value = "O365OnedriveEnabled")]
        O365_ONEDRIVE_ENABLED,

        [EnumMember(Value = "O365OnedriveGAEnabled")]
        O365_ONEDRIVE_GA_ENABLED,

        [EnumMember(Value = "O365OnedriveGAOrgSlaAssigmnentEnabled")]
        O365_ONEDRIVE_GA_ORG_SLA_ASSIGMNENT_ENABLED,

        [EnumMember(Value = "O365SharePointEnabled")]
        O365_SHARE_POINT_ENABLED,

        [EnumMember(Value = "O365SharedMailboxEnabled")]
        O365_SHARED_MAILBOX_ENABLED,

        [EnumMember(Value = "O365TeamsEnabled")]
        O365_TEAMS_ENABLED,

        [EnumMember(Value = "O365_ADGROUPS_ENABLED")]
        O365_ADGROUPS_ENABLED,

        [EnumMember(Value = "O365_CONTACTS_ENABLED")]
        O365_CONTACTS_ENABLED,

        [EnumMember(Value = "O365_EXCHANGE_INPLACE_RESTORE_ENABLED")]
        O365_EXCHANGE_INPLACE_RESTORE_ENABLED,

        [EnumMember(Value = "O365_EXPORT_ENABLED")]
        O365_EXPORT_ENABLED,

        [EnumMember(Value = "O365_LICENSE_ENFORCEMENT_V1_ENABLED")]
        O365_LICENSE_ENFORCEMENT_V1_ENABLED,

        [EnumMember(Value = "O365_MAILBOX_DOWNLOAD_ENABLED")]
        O365_MAILBOX_DOWNLOAD_ENABLED,

        [EnumMember(Value = "O365_OBJECT_RBAC_ENABLED")]
        O365_OBJECT_RBAC_ENABLED,

        [EnumMember(Value = "O365_ONEDRIVE_INPLACE_RESTORE_ENABLED")]
        O365_ONEDRIVE_INPLACE_RESTORE_ENABLED,

        [EnumMember(Value = "O365_OPERATIONAL_RECOVERY_EXCHANGE_ENABLED")]
        O365_OPERATIONAL_RECOVERY_EXCHANGE_ENABLED,

        [EnumMember(Value = "O365_OPERATIONAL_RECOVERY_ONEDRIVE_ENABLED")]
        O365_OPERATIONAL_RECOVERY_ONEDRIVE_ENABLED,

        [EnumMember(Value = "O365_OPERATIONAL_RECOVERY_SHAREPOINT_ENABLED")]
        O365_OPERATIONAL_RECOVERY_SHAREPOINT_ENABLED,

        [EnumMember(Value = "O365_SHAREPOINT_INPLACE_RESTORE_ENABLED")]
        O365_SHAREPOINT_INPLACE_RESTORE_ENABLED,

        [EnumMember(Value = "O365_SHAREPOINT_LIST_ENABLED")]
        O365_SHAREPOINT_LIST_ENABLED,

        [EnumMember(Value = "O365_TEAMS_EXPORT_ENABLED")]
        O365_TEAMS_EXPORT_ENABLED,

        [EnumMember(Value = "O365_TEAMS_PRIVATE_CHANNELS_ENABLED")]
        O365_TEAMS_PRIVATE_CHANNELS_ENABLED,

        [EnumMember(Value = "OBJECT_LOCATION_FILTER_ENABLED")]
        OBJECT_LOCATION_FILTER_ENABLED,

        [EnumMember(Value = "OBJECT_NAME_FILTER_ENABLED")]
        OBJECT_NAME_FILTER_ENABLED,

        [EnumMember(Value = "ON_PREM_PREFERENCES_ENABLED")]
        ON_PREM_PREFERENCES_ENABLED,

        [EnumMember(Value = "ORACLE_ON_WINDOWS_ENABLED")]
        ORACLE_ON_WINDOWS_ENABLED,

        [EnumMember(Value = "ORACLE_SECTION_SIZE_ENABLED")]
        ORACLE_SECTION_SIZE_ENABLED,

        [EnumMember(Value = "ORACLE_SECURE_THRIFT_ENABLED")]
        ORACLE_SECURE_THRIFT_ENABLED,

        [EnumMember(Value = "ORGANIZATION_SWITCHER_ENABLED")]
        ORGANIZATION_SWITCHER_ENABLED,

        [EnumMember(Value = "ORG_NETWORKS_ENABLED")]
        ORG_NETWORKS_ENABLED,

        [EnumMember(Value = "ORG_REPORT_ASSIGNMENT_ENABLED")]
        ORG_REPORT_ASSIGNMENT_ENABLED,

        [EnumMember(Value = "ORG_REPORT_SELF_SERVICE_ENABLED")]
        ORG_REPORT_SELF_SERVICE_ENABLED,

        [EnumMember(Value = "ObjectTypeSLAEnhancementEnabled")]
        OBJECT_TYPE_SLA_ENHANCEMENT_ENABLED,

        [EnumMember(Value = "OnDemandCrawlEnabled")]
        ON_DEMAND_CRAWL_ENABLED,

        [EnumMember(Value = "OnDemandSnapshotExpirationEnabled")]
        ON_DEMAND_SNAPSHOT_EXPIRATION_ENABLED,

        [EnumMember(Value = "OnPremNotificationEnabled")]
        ON_PREM_NOTIFICATION_ENABLED,

        [EnumMember(Value = "OracleEnabled")]
        ORACLE_ENABLED,

        [EnumMember(Value = "OracleFeatureEnablementEnabled")]
        ORACLE_FEATURE_ENABLEMENT_ENABLED,

        [EnumMember(Value = "OracleHierarchyEnabled")]
        ORACLE_HIERARCHY_ENABLED,

        [EnumMember(Value = "PACTSAFE_EULA_ENABLED")]
        PACTSAFE_EULA_ENABLED,

        [EnumMember(Value = "PACTSAFE_EULA_V2_ENABLED")]
        PACTSAFE_EULA_V2_ENABLED,

        [EnumMember(Value = "PASSWORD_COMPLEXITY_POLICY_ENABLED")]
        PASSWORD_COMPLEXITY_POLICY_ENABLED,

        [EnumMember(Value = "PAUSE_POLLING_ENABLED")]
        PAUSE_POLLING_ENABLED,

        [EnumMember(Value = "PAUSE_SLA_FEEDBACK_ENABLED")]
        PAUSE_SLA_FEEDBACK_ENABLED,

        [EnumMember(Value = "PDF_IN_SCHEDULED_REPORT_ENABLED")]
        PDF_IN_SCHEDULED_REPORT_ENABLED,

        [EnumMember(Value = "POLARIS2_CC_CNP_ENABLED")]
        POLARIS2_CC_CNP_ENABLED,

        [EnumMember(Value = "POLARIS2_CC_CNP_UX_REDESIGN_ENABLED")]
        POLARIS2_CC_CNP_UX_REDESIGN_ENABLED,

        [EnumMember(Value = "POLARIS2_ONBOARDING_ENABLED")]
        POLARIS2_ONBOARDING_ENABLED,

        [EnumMember(Value = "POLARIS_SNAPSHOT_MANAGEMENT_ENABLED")]
        POLARIS_SNAPSHOT_MANAGEMENT_ENABLED,

        [EnumMember(Value = "POLICYOBJ_CONNECTION_API_LIMIT_CHECK_ENABLED")]
        POLICYOBJ_CONNECTION_API_LIMIT_CHECK_ENABLED,

        [EnumMember(Value = "POSTGRES_ENABLED")]
        POSTGRES_ENABLED,

        [EnumMember(Value = "PRELOAD_CACHE")]
        PRELOAD_CACHE,

        [EnumMember(Value = "PRISM_CENTRAL_ENABLED")]
        PRISM_CENTRAL_ENABLED,

        [EnumMember(Value = "PRIVATE_CONTAINER_REGISTRY_ENABLED")]
        PRIVATE_CONTAINER_REGISTRY_ENABLED,

        [EnumMember(Value = "PRODUCT_ENTITLEMENT_ANOMALY_KORGJOB_ENABLED")]
        PRODUCT_ENTITLEMENT_ANOMALY_KORGJOB_ENABLED,

        [EnumMember(Value = "PRODUCT_NOTIFICATIONS_ENABLED")]
        PRODUCT_NOTIFICATIONS_ENABLED,

        [EnumMember(Value = "PRODUCT_TRIALS_ENABLED")]
        PRODUCT_TRIALS_ENABLED,

        [EnumMember(Value = "PROMPT_RSC_MIGRATION_UI_ENABLED")]
        PROMPT_RSC_MIGRATION_UI_ENABLED,

        [EnumMember(Value = "PUSH_SLA_TO_CLUSTERS_ENABLED")]
        PUSH_SLA_TO_CLUSTERS_ENABLED,

        [EnumMember(Value = "QAUTH_OBJECT_REPORT_ENABLED")]
        QAUTH_OBJECT_REPORT_ENABLED,

        [EnumMember(Value = "QAUTH_ROLE_REPORT_ENABLED")]
        QAUTH_ROLE_REPORT_ENABLED,

        [EnumMember(Value = "RADAR_ANOMALY_BETA_ENABLED")]
        RADAR_ANOMALY_BETA_ENABLED,

        [EnumMember(Value = "RADAR_ANOMALY_MODEL_B_RELEASE_ENABLED")]
        RADAR_ANOMALY_MODEL_B_RELEASE_ENABLED,

        [EnumMember(Value = "RADAR_ANOMALY_MODEL_B_SHADOW_ENABLED")]
        RADAR_ANOMALY_MODEL_B_SHADOW_ENABLED,

        [EnumMember(Value = "RADAR_ANOMALY_RESOLUTION")]
        RADAR_ANOMALY_RESOLUTION,

        [EnumMember(Value = "RADAR_ANOMALY_SNOOZE")]
        RADAR_ANOMALY_SNOOZE,

        [EnumMember(Value = "RADAR_ENCRYPTION_BETA_ENABLED")]
        RADAR_ENCRYPTION_BETA_ENABLED,

        [EnumMember(Value = "RADAR_FOR_NAS_CD_ENABLED")]
        RADAR_FOR_NAS_CD_ENABLED,

        [EnumMember(Value = "RADAR_FOR_NAS_CD_NON_RCV_ENABLED")]
        RADAR_FOR_NAS_CD_NON_RCV_ENABLED,

        [EnumMember(Value = "RADAR_INTERNAL_TEST_MODE_DEV_ONLY_MODE_ENABLED")]
        RADAR_INTERNAL_TEST_MODE_DEV_ONLY_MODE_ENABLED,

        [EnumMember(Value = "RADAR_LLM_ANALYSIS_ENABLED")]
        RADAR_LLM_ANALYSIS_ENABLED,

        [EnumMember(Value = "RADAR_RANSOMWARE_MODEL_B_RELEASE_ENABLED")]
        RADAR_RANSOMWARE_MODEL_B_RELEASE_ENABLED,

        [EnumMember(Value = "RADAR_RANSOMWARE_MODEL_B_SHADOW_ENABLED")]
        RADAR_RANSOMWARE_MODEL_B_SHADOW_ENABLED,

        [EnumMember(Value = "RADAR_RUN_ANOMALY_MODELB_ENABLED")]
        RADAR_RUN_ANOMALY_MODELB_ENABLED,

        [EnumMember(Value = "RADAR_RUN_ENCRYPTION_MODELB_ENABLED")]
        RADAR_RUN_ENCRYPTION_MODELB_ENABLED,

        [EnumMember(Value = "RADAR_USE_POLARIS_HAWKEYE")]
        RADAR_USE_POLARIS_HAWKEYE,

        [EnumMember(Value = "RANSOMWARE_STRAIN_ENABLED")]
        RANSOMWARE_STRAIN_ENABLED,

        [EnumMember(Value = "RBACForCDMSnappablesEnabled")]
        RBAC_FOR_CDM_SNAPPABLES_ENABLED,

        [EnumMember(Value = "RBACForGlobalSLAEnabled")]
        RBAC_FOR_GLOBAL_SLA_ENABLED,

        [EnumMember(Value = "RBAC_ON_CUSTOM_REPORTS_ENABLED")]
        RBAC_ON_CUSTOM_REPORTS_ENABLED,

        [EnumMember(Value = "RCS_ENABLED")]
        RCS_ENABLED,

        [EnumMember(Value = "RCV_ARCHIVE_ENTITLEMENT_ENABLED")]
        RCV_ARCHIVE_ENTITLEMENT_ENABLED,

        [EnumMember(Value = "RCV_AZURE_STORAGE_REDUNDANCY")]
        RCV_AZURE_STORAGE_REDUNDANCY,

        [EnumMember(Value = "RCV_BACKUP_ENTITLEMENT_ENABLED")]
        RCV_BACKUP_ENTITLEMENT_ENABLED,

        [EnumMember(Value = "RCV_BACKUP_LOCATION_ENABLED")]
        RCV_BACKUP_LOCATION_ENABLED,

        [EnumMember(Value = "RCV_CONSUMPTION")]
        RCV_CONSUMPTION,

        [EnumMember(Value = "RCV_EDIT_DELETE_PAUSE_RESUME_ENABLED")]
        RCV_EDIT_DELETE_PAUSE_RESUME_ENABLED,

        [EnumMember(Value = "RCV_GSLA_ENABLED")]
        RCV_GSLA_ENABLED,

        [EnumMember(Value = "RCV_GSLA_REVAMP_ENABLED")]
        RCV_GSLA_REVAMP_ENABLED,

        [EnumMember(Value = "RCV_IMMUTABLE_DELETE_ENABLED")]
        RCV_IMMUTABLE_DELETE_ENABLED,

        [EnumMember(Value = "RCV_IP_ALLOW_LIST_ENABLED")]
        RCV_IP_ALLOW_LIST_ENABLED,

        [EnumMember(Value = "RCV_PERCENTAGE_NOTIFIER")]
        RCV_PERCENTAGE_NOTIFIER,

        [EnumMember(Value = "RCV_PE_SIMPLIFICATION")]
        RCV_PE_SIMPLIFICATION,

        [EnumMember(Value = "RCV_PRIVATE_ENDPOINT_ENABLED")]
        RCV_PRIVATE_ENDPOINT_ENABLED,

        [EnumMember(Value = "RCV_REGION_EXPANSION_ENABLED")]
        RCV_REGION_EXPANSION_ENABLED,

        [EnumMember(Value = "RCV_SFDC_VALIDATIONS_DELETE_ENFORCE_ENABLED")]
        RCV_SFDC_VALIDATIONS_DELETE_ENFORCE_ENABLED,

        [EnumMember(Value = "RCV_TPR")]
        RCV_TPR,

        [EnumMember(Value = "RDP_ENABLED")]
        RDP_ENABLED,

        [EnumMember(Value = "RELEASE_NOTES_DETAILS_ENABLED")]
        RELEASE_NOTES_DETAILS_ENABLED,

        [EnumMember(Value = "RELEASE_NOTES_ENABLED")]
        RELEASE_NOTES_ENABLED,

        [EnumMember(Value = "REPLICATION_AIR_GAPPED_CLUSTER")]
        REPLICATION_AIR_GAPPED_CLUSTER,

        [EnumMember(Value = "REPLICATION_EXPLICIT_CRUD_ENABLED")]
        REPLICATION_EXPLICIT_CRUD_ENABLED,

        [EnumMember(Value = "REPLICATION_MT_V2_ENABLED")]
        REPLICATION_MT_V2_ENABLED,

        [EnumMember(Value = "REPLICATION_NETWORK_UTILISATION_ENABLED")]
        REPLICATION_NETWORK_UTILISATION_ENABLED,

        [EnumMember(Value = "REPLICATION_PAIR_REMOVAL_PRECHECK")]
        REPLICATION_PAIR_REMOVAL_PRECHECK,

        [EnumMember(Value = "REPLICATION_TARGETS_ENABLED")]
        REPLICATION_TARGETS_ENABLED,

        [EnumMember(Value = "REPORT_FOR_NAS_CD_ENABLED")]
        REPORT_FOR_NAS_CD_ENABLED,

        [EnumMember(Value = "REST_API_PRECHECK_ENABLED")]
        REST_API_PRECHECK_ENABLED,

        [EnumMember(Value = "RETENTION_LOCK_FOR_CLOUD_NATIVE_WORKLOADS_ENABLED")]
        RETENTION_LOCK_FOR_CLOUD_NATIVE_WORKLOADS_ENABLED,

        [EnumMember(Value = "RETENTION_LOCK_SLA_CNW_ENABLED")]
        RETENTION_LOCK_SLA_CNW_ENABLED,

        [EnumMember(Value = "RETENTION_LOCK_SLA_ENABLED")]
        RETENTION_LOCK_SLA_ENABLED,

        [EnumMember(Value = "ROLE_ASSIGNMENT_UI_ENHANCEMENT_ENABLED")]
        ROLE_ASSIGNMENT_UI_ENHANCEMENT_ENABLED,

        [EnumMember(Value = "ROLE_SHOPPING_CARTS_ENABLED")]
        ROLE_SHOPPING_CARTS_ENABLED,

        [EnumMember(Value = "RSC_AUTO_UPGRADE_ENABLED")]
        RSC_AUTO_UPGRADE_ENABLED,

        [EnumMember(Value = "RSC_CDM_API_PROXY_ENABLED")]
        RSC_CDM_API_PROXY_ENABLED,

        [EnumMember(Value = "RSC_CLASSIFICATION_UNIFICATION")]
        RSC_CLASSIFICATION_UNIFICATION,

        [EnumMember(Value = "RSC_LAMINAR_INTEGRATION_ENABLED")]
        RSC_LAMINAR_INTEGRATION_ENABLED,

        [EnumMember(Value = "RSC_TO_CDM_USER_CTX_ENABLED")]
        RSC_TO_CDM_USER_CTX_ENABLED,

        [EnumMember(Value = "RSC_UPGRADES_CIAM_INTEGRATION")]
        RSC_UPGRADES_CIAM_INTEGRATION,

        [EnumMember(Value = "RSDD_ON_O365_SHAREPOINT_DRIVE_ENABLED")]
        RSDD_ON_O365_SHAREPOINT_DRIVE_ENABLED,

        [EnumMember(Value = "RSDD_ON_O365_SHAREPOINT_SITE_ENABLED")]
        RSDD_ON_O365_SHAREPOINT_SITE_ENABLED,

        [EnumMember(Value = "RUBRIK_HOSTED_CNP_ENABLED")]
        RUBRIK_HOSTED_CNP_ENABLED,

        [EnumMember(Value = "RUBY_DEMO")]
        RUBY_DEMO,

        [EnumMember(Value = "RUBY_ENABLED")]
        RUBY_ENABLED,

        [EnumMember(Value = "RadarAppFlowsEnabled")]
        RADAR_APP_FLOWS_ENABLED,

        [EnumMember(Value = "RadarDemoEnabled")]
        RADAR_DEMO_ENABLED,

        [EnumMember(Value = "RadarDevEnabled")]
        RADAR_DEV_ENABLED,

        [EnumMember(Value = "RecoverySearchEnabled")]
        RECOVERY_SEARCH_ENABLED,

        [EnumMember(Value = "RemoveClusterEnabled")]
        REMOVE_CLUSTER_ENABLED,

        [EnumMember(Value = "ReportAsyncDownloadEnabled")]
        REPORT_ASYNC_DOWNLOAD_ENABLED,

        [EnumMember(Value = "ReportForecasterEnabled")]
        REPORT_FORECASTER_ENABLED,

        [EnumMember(Value = "ReportLastSyncedDateEnabled")]
        REPORT_LAST_SYNCED_DATE_ENABLED,

        [EnumMember(Value = "RkTableEnabled")]
        RK_TABLE_ENABLED,

        [EnumMember(Value = "RollbackOnSuccessEnabled")]
        ROLLBACK_ON_SUCCESS_ENABLED,

        [EnumMember(Value = "RubrikSEDemoEnabled")]
        RUBRIK_SE_DEMO_ENABLED,

        [EnumMember(Value = "S3_SENSITIVE_DATA_CLASSIFICATION_ENABLED")]
        S3_SENSITIVE_DATA_CLASSIFICATION_ENABLED,

        [EnumMember(Value = "SAAS_ROOM_ENABLED")]
        SAAS_ROOM_ENABLED,

        [EnumMember(Value = "SALESFORCE_ALPHA")]
        SALESFORCE_ALPHA,

        [EnumMember(Value = "SALESFORCE_BETA")]
        SALESFORCE_BETA,

        [EnumMember(Value = "SALESFORCE_ENABLED")]
        SALESFORCE_ENABLED,

        [EnumMember(Value = "SALESFORCE_GA")]
        SALESFORCE_GA,

        [EnumMember(Value = "SAMPLE_FLAG")]
        SAMPLE_FLAG,

        [EnumMember(Value = "SAP_HANA_ARCHIVAL_ENABLED")]
        SAP_HANA_ARCHIVAL_ENABLED,

        [EnumMember(Value = "SAP_HANA_AUTO_ENABLEMENT_ENABLED")]
        SAP_HANA_AUTO_ENABLEMENT_ENABLED,

        [EnumMember(Value = "SAP_HANA_CCES_ACCESS")]
        SAP_HANA_CCES_ACCESS,

        [EnumMember(Value = "SAP_HANA_CROSS_RESTORE_ENABLED")]
        SAP_HANA_CROSS_RESTORE_ENABLED,

        [EnumMember(Value = "SAP_HANA_LEGAL_HOLD_ENABLED")]
        SAP_HANA_LEGAL_HOLD_ENABLED,

        [EnumMember(Value = "SAP_HANA_REPLICATION_DOWNLOAD_ENABLED")]
        SAP_HANA_REPLICATION_DOWNLOAD_ENABLED,

        [EnumMember(Value = "SAP_HANA_REPLICATION_ENABLED")]
        SAP_HANA_REPLICATION_ENABLED,

        [EnumMember(Value = "SAP_HANA_RETENTION_LOCK_ENABLED")]
        SAP_HANA_RETENTION_LOCK_ENABLED,

        [EnumMember(Value = "SAP_HANA_SECURE_STORE_ENABLED")]
        SAP_HANA_SECURE_STORE_ENABLED,

        [EnumMember(Value = "SAP_HANA_STATIC_RETENTION_ENABLED")]
        SAP_HANA_STATIC_RETENTION_ENABLED,

        [EnumMember(Value = "SAP_HANA_STORAGE_SNAPSHOT_ENABLED")]
        SAP_HANA_STORAGE_SNAPSHOT_ENABLED,

        [EnumMember(Value = "SA_ORG_MANAGEMENT_ENABLED")]
        SA_ORG_MANAGEMENT_ENABLED,

        [EnumMember(Value = "SELF_HELP_ENABLED")]
        SELF_HELP_ENABLED,

        [EnumMember(Value = "SENTRY_PERFORMANCE_ENABLED")]
        SENTRY_PERFORMANCE_ENABLED,

        [EnumMember(Value = "SERVICE_NOW_TICKETING_INTEGRATION_ENABLED")]
        SERVICE_NOW_TICKETING_INTEGRATION_ENABLED,

        [EnumMember(Value = "SESSION_MANAGEMENT_ENABLED")]
        SESSION_MANAGEMENT_ENABLED,

        [EnumMember(Value = "SETTINGS_MENU_V2_ENABLED")]
        SETTINGS_MENU_V2_ENABLED,

        [EnumMember(Value = "SINGLE_NODE_CCES_ENABLED")]
        SINGLE_NODE_CCES_ENABLED,

        [EnumMember(Value = "SINGLE_NODE_EXPANSION_ENABLED")]
        SINGLE_NODE_EXPANSION_ENABLED,

        [EnumMember(Value = "SLAHierarchyEnabled")]
        SLA_HIERARCHY_ENABLED,

        [EnumMember(Value = "SLASyncHighFreqEnabled")]
        SLA_SYNC_HIGH_FREQ_ENABLED,

        [EnumMember(Value = "SLA_AND_ARCHIVAL_LOCATION_UPGRADE_INTEGRATION_ENABLED")]
        SLA_AND_ARCHIVAL_LOCATION_UPGRADE_INTEGRATION_ENABLED,

        [EnumMember(Value = "SLA_ASYNC_ASSIGNMENT")]
        SLA_ASYNC_ASSIGNMENT,

        [EnumMember(Value = "SLA_AUTO_MIGRATION_COMPLEX")]
        SLA_AUTO_MIGRATION_COMPLEX,

        [EnumMember(Value = "SLA_AUTO_MIGRATION_DISABLED")]
        SLA_AUTO_MIGRATION_DISABLED,

        [EnumMember(Value = "SLA_AUTO_MIGRATION_PREP_CAMPAIGN_COMPLEX")]
        SLA_AUTO_MIGRATION_PREP_CAMPAIGN_COMPLEX,

        [EnumMember(Value = "SLA_AUTO_MIGRATION_PREP_CAMPAIGN_SIMPLE")]
        SLA_AUTO_MIGRATION_PREP_CAMPAIGN_SIMPLE,

        [EnumMember(Value = "SLA_AUTO_MIGRATION_SIMPLE")]
        SLA_AUTO_MIGRATION_SIMPLE,

        [EnumMember(Value = "SLA_AUTO_MIGRATION_SWITCH")]
        SLA_AUTO_MIGRATION_SWITCH,

        [EnumMember(Value = "SLA_DOMAIN_BULK_UPGRADE_ENABLED")]
        SLA_DOMAIN_BULK_UPGRADE_ENABLED,

        [EnumMember(Value = "SLA_DOMAIN_UPGRADE_ENABLED")]
        SLA_DOMAIN_UPGRADE_ENABLED,

        [EnumMember(Value = "SLA_ONBOARDING_ENABLED")]
        SLA_ONBOARDING_ENABLED,

        [EnumMember(Value = "SLED_ALLOW_FORCE_CLUSTER_REMOVAL")]
        SLED_ALLOW_FORCE_CLUSTER_REMOVAL,

        [EnumMember(Value = "SLED_MIGRATION_NOTIFICATION_ENABLED")]
        SLED_MIGRATION_NOTIFICATION_ENABLED,

        [EnumMember(Value = "SMB_SETTINGS_ENABLED")]
        SMB_SETTINGS_ENABLED,

        [EnumMember(Value = "SNAPMIRROR_FEATURE_ENABLEMENT_ENABLED")]
        SNAPMIRROR_FEATURE_ENABLEMENT_ENABLED,

        [EnumMember(Value = "SNOW_SELF_SERVICE_INTEGRATION_ENABLED")]
        SNOW_SELF_SERVICE_INTEGRATION_ENABLED,

        [EnumMember(Value = "SONAR_AUTOENABLED_POLICY_ENABLED")]
        SONAR_AUTOENABLED_POLICY_ENABLED,

        [EnumMember(Value = "SONAR_BULK_POLICY_ASSIGNMENT")]
        SONAR_BULK_POLICY_ASSIGNMENT,

        [EnumMember(Value = "SONAR_EU_DEFAULT_POLICIES_ENABLED")]
        SONAR_EU_DEFAULT_POLICIES_ENABLED,

        [EnumMember(Value = "SONAR_FOR_AZURE_ENABLED")]
        SONAR_FOR_AZURE_ENABLED,

        [EnumMember(Value = "SONAR_FOR_NAS_CD_ENABLED")]
        SONAR_FOR_NAS_CD_ENABLED,

        [EnumMember(Value = "SONAR_FOR_NAS_FILESET_ENABLED")]
        SONAR_FOR_NAS_FILESET_ENABLED,

        [EnumMember(Value = "SONAR_MSSQL_ENABLED")]
        SONAR_MSSQL_ENABLED,

        [EnumMember(Value = "SONAR_ON_O365_ONEDRIVE_ENABLED")]
        SONAR_ON_O365_ONEDRIVE_ENABLED,

        [EnumMember(Value = "SONAR_REMOVE_WHITELIST_TOGGLE_ENABLED")]
        SONAR_REMOVE_WHITELIST_TOGGLE_ENABLED,

        [EnumMember(Value = "SONAR_ROOM_RENAME_ENABLED")]
        SONAR_ROOM_RENAME_ENABLED,

        [EnumMember(Value = "SONAR_US_DEFAULT_POLICIES_ENABLED")]
        SONAR_US_DEFAULT_POLICIES_ENABLED,

        [EnumMember(Value = "SONAR_WINDOWS_VOLUME_GROUP_ENABLED")]
        SONAR_WINDOWS_VOLUME_GROUP_ENABLED,

        [EnumMember(Value = "SONAR_WORKERPOOL_FILTER_FMD")]
        SONAR_WORKERPOOL_FILTER_FMD,

        [EnumMember(Value = "SSOEnhancementEnabled")]
        SSO_ENHANCEMENT_ENABLED,

        [EnumMember(Value = "SSO_CERT_MANAGEMENT_ENABLED")]
        SSO_CERT_MANAGEMENT_ENABLED,

        [EnumMember(Value = "SSO_SINGLE_USER_AUTHZ_ENABLED")]
        SSO_SINGLE_USER_AUTHZ_ENABLED,

        [EnumMember(Value = "SSO_USER_HIDE_ENABLED")]
        SSO_USER_HIDE_ENABLED,

        [EnumMember(Value = "STORAGE_LOCATIONS_ENABLED")]
        STORAGE_LOCATIONS_ENABLED,

        [EnumMember(Value = "SUPPORT_CASE_ENABLED")]
        SUPPORT_CASE_ENABLED,

        [EnumMember(Value = "SUPPORT_IMPERSONATION_UI")]
        SUPPORT_IMPERSONATION_UI,

        [EnumMember(Value = "SUPPORT_TUNNEL_ENABLED")]
        SUPPORT_TUNNEL_ENABLED,

        [EnumMember(Value = "SapHanaInventoryEnabled")]
        SAP_HANA_INVENTORY_ENABLED,

        [EnumMember(Value = "SapHanaOnGcpEnabled")]
        SAP_HANA_ON_GCP_ENABLED,

        [EnumMember(Value = "SecureUploadEnabled")]
        SECURE_UPLOAD_ENABLED,

        [EnumMember(Value = "ServiceAccountEnabled")]
        SERVICE_ACCOUNT_ENABLED,

        [EnumMember(Value = "SkipFailedEventQueryEnabled")]
        SKIP_FAILED_EVENT_QUERY_ENABLED,

        [EnumMember(Value = "SlaComplianceFilterEnabled")]
        SLA_COMPLIANCE_FILTER_ENABLED,

        [EnumMember(Value = "SlaPauseEnabled")]
        SLA_PAUSE_ENABLED,

        [EnumMember(Value = "SnapMirrorInventoryEnabled")]
        SNAP_MIRROR_INVENTORY_ENABLED,

        [EnumMember(Value = "SonarReplicatedObjectsEnabled")]
        SONAR_REPLICATED_OBJECTS_ENABLED,

        [EnumMember(Value = "SonarUKAnalyzersEnabled")]
        SONAR_UK_ANALYZERS_ENABLED,

        [EnumMember(Value = "SonarVMObjectsEnabled")]
        SONAR_VM_OBJECTS_ENABLED,

        [EnumMember(Value = "SonarVirtualAppliancesEnabled")]
        SONAR_VIRTUAL_APPLIANCES_ENABLED,

        [EnumMember(Value = "SsoEnabled")]
        SSO_ENABLED,

        [EnumMember(Value = "StaticRetentionEnabled")]
        STATIC_RETENTION_ENABLED,

        [EnumMember(Value = "SystemAnnouncementsEnabled")]
        SYSTEM_ANNOUNCEMENTS_ENABLED,

        [EnumMember(Value = "TENANT_ORG_CERTIFICATE_ENABLED")]
        TENANT_ORG_CERTIFICATE_ENABLED,

        [EnumMember(Value = "TENANT_ORG_CLOUD_NATIVE_SELF_SERVICE_ENABLED")]
        TENANT_ORG_CLOUD_NATIVE_SELF_SERVICE_ENABLED,

        [EnumMember(Value = "TENANT_ORG_M365_SELF_SERVICE_ENABLED")]
        TENANT_ORG_M365_SELF_SERVICE_ENABLED,

        [EnumMember(Value = "TEST_FALSE_FLAG")]
        TEST_FALSE_FLAG,

        [EnumMember(Value = "THEME_SWITCHER_ENABLED")]
        THEME_SWITCHER_ENABLED,

        [EnumMember(Value = "THREAT_HUNT_COMPLETE_MATCH_RESULTS_DISABLED")]
        THREAT_HUNT_COMPLETE_MATCH_RESULTS_DISABLED,

        [EnumMember(Value = "THREAT_HUNT_ENABLED")]
        THREAT_HUNT_ENABLED,

        [EnumMember(Value = "THREAT_HUNT_RESULTS_CSV_DOWNLOAD_ENABLED")]
        THREAT_HUNT_RESULTS_CSV_DOWNLOAD_ENABLED,

        [EnumMember(Value = "THREAT_HUNT_V2_ENABLED")]
        THREAT_HUNT_V2_ENABLED,

        [EnumMember(Value = "THREAT_MONITORING_ENTITLED_ENABLED")]
        THREAT_MONITORING_ENTITLED_ENABLED,

        [EnumMember(Value = "TIER_EXISTING_SNAPSHOTS_UNMANAGED_OBJECTS_ENABLED")]
        TIER_EXISTING_SNAPSHOTS_UNMANAGED_OBJECTS_ENABLED,

        [EnumMember(Value = "TPR_ENABLED")]
        TPR_ENABLED,

        [EnumMember(Value = "TRUE_QUORUM_ENABLED")]
        TRUE_QUORUM_ENABLED,

        [EnumMember(Value = "UAPermissionsTabEnabled")]
        UA_PERMISSIONS_TAB_ENABLED,

        [EnumMember(Value = "UI_DISABLE_CTA_FOR_UNSUPPORTED_CDM_VERSIONS")]
        UI_DISABLE_CTA_FOR_UNSUPPORTED_CDM_VERSIONS,

        [EnumMember(Value = "UI_PROMPT_CDM_9_UPGRADE")]
        UI_PROMPT_CDM_9_UPGRADE,

        [EnumMember(Value = "UNIFIED_ENCRYPTION_MANAGEMENT_ENABLED")]
        UNIFIED_ENCRYPTION_MANAGEMENT_ENABLED,

        [EnumMember(Value = "UNSTRUCTURED_DATA_PROTECTION_ENABLED")]
        UNSTRUCTURED_DATA_PROTECTION_ENABLED,

        [EnumMember(Value = "USERS_ROLES_SSO_ONBOARDING_ENABLED")]
        USERS_ROLES_SSO_ONBOARDING_ENABLED,

        [EnumMember(Value = "USER_ACCESS_ENABLED")]
        USER_ACCESS_ENABLED,

        [EnumMember(Value = "USER_ACCESS_INSIGHTS_ENABLED")]
        USER_ACCESS_INSIGHTS_ENABLED,

        [EnumMember(Value = "USER_ACTIVITY_ENABLED")]
        USER_ACTIVITY_ENABLED,

        [EnumMember(Value = "USER_ID_ACTIVITY_SERIES_FILTER_ENABLED")]
        USER_ID_ACTIVITY_SERIES_FILTER_ENABLED,

        [EnumMember(Value = "USE_NEW_IDX_ON_GLOBAL_OBJECTS_PART")]
        USE_NEW_IDX_ON_GLOBAL_OBJECTS_PART,

        [EnumMember(Value = "USE_TIMEZONE_OVER_OFFSET")]
        USE_TIMEZONE_OVER_OFFSET,

        [EnumMember(Value = "UnmanagedObjectEnabled")]
        UNMANAGED_OBJECT_ENABLED,

        [EnumMember(Value = "UserAwarenessV1Enabled")]
        USER_AWARENESS_V1_ENABLED,

        [EnumMember(Value = "UserAwarenessV2Enabled")]
        USER_AWARENESS_V2_ENABLED,

        [EnumMember(Value = "VCD_SNAPPABLE_ENABLED")]
        VCD_SNAPPABLE_ENABLED,

        [EnumMember(Value = "VIEWED_HISTORY_ENABLED")]
        VIEWED_HISTORY_ENABLED,

        [EnumMember(Value = "VMWARE_BULK_RECOVERY_ENABLED")]
        VMWARE_BULK_RECOVERY_ENABLED,

        [EnumMember(Value = "VMWARE_DATASTORE_CLUSTER_ENABLED")]
        VMWARE_DATASTORE_CLUSTER_ENABLED,

        [EnumMember(Value = "VMWARE_RBS_BACKUP_SETTINGS_ENABLED")]
        VMWARE_RBS_BACKUP_SETTINGS_ENABLED,

        [EnumMember(Value = "VMWARE_STANDALONE_HOST_ENABLED")]
        VMWARE_STANDALONE_HOST_ENABLED,

        [EnumMember(Value = "VMWARE_TEMPLATE_ENABLED")]
        VMWARE_TEMPLATE_ENABLED,

        [EnumMember(Value = "VMWARE_VCENTER_DIAGNOSTICS_ENABLED")]
        VMWARE_VCENTER_DIAGNOSTICS_ENABLED,

        [EnumMember(Value = "VMWARE_VDISK_MAPPING_ENABLED")]
        VMWARE_VDISK_MAPPING_ENABLED,

        [EnumMember(Value = "VMWARE_VM_LEVEL_FILE_DOWNLOAD_ENABLED")]
        VMWARE_VM_LEVEL_FILE_DOWNLOAD_ENABLED,

        [EnumMember(Value = "VOLUME_GROUP_RADAR_ENABLED")]
        VOLUME_GROUP_RADAR_ENABLED,

        [EnumMember(Value = "VSPHERE_DUPLICATE_VM_ENABLED")]
        VSPHERE_DUPLICATE_VM_ENABLED,

        [EnumMember(Value = "VSPHERE_FILESETS_NEW_SEARCH_AND_RECOVERY_ENABLED")]
        VSPHERE_FILESETS_NEW_SEARCH_AND_RECOVERY_ENABLED,

        [EnumMember(Value = "VSphereSearchAndRecoveryRolloutEnabled")]
        VSPHERE_SEARCH_AND_RECOVERY_ROLLOUT_ENABLED,

        [EnumMember(Value = "VcdHierarchyEnabled")]
        VCD_HIERARCHY_ENABLED,

        [EnumMember(Value = "WEBAUTHN_ENABLED")]
        WEBAUTHN_ENABLED,

        [EnumMember(Value = "WEBHOOKS_ENABLED")]
        WEBHOOKS_ENABLED,

        [EnumMember(Value = "WINDOWS_VOLUME_GROUP_INVENTORY_ENABLED")]
        WINDOWS_VOLUME_GROUP_INVENTORY_ENABLED,

        [EnumMember(Value = "WINDOWS_VOLUME_GROUP_LIVE_MOUNT_ENABLED")]
        WINDOWS_VOLUME_GROUP_LIVE_MOUNT_ENABLED,

        [EnumMember(Value = "WIPEnabled")]
        WIP_ENABLED,

        [EnumMember(Value = "ZSCALER_DLP_ENABLED")]
        ZSCALER_DLP_ENABLED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FeatureFlagName

} // namespace RubrikSecurityCloud.Types