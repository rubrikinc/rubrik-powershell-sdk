// HierarchyFilterField.cs
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
    public enum HierarchyFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN_NAME")]
        ACTIVE_DIRECTORY_DOMAIN_NAME,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN_SID")]
        ACTIVE_DIRECTORY_DOMAIN_SID,

        [EnumMember(Value = "ACTIVE_DIRECTORY_FOREST_BY_ROOT_DOMAIN_SID")]
        ACTIVE_DIRECTORY_FOREST_BY_ROOT_DOMAIN_SID,

        [EnumMember(Value = "ANCESTOR_ID")]
        ANCESTOR_ID,

        [EnumMember(Value = "AWS_INSTANCE_CC_OR_CNP_RBS_CONNECTION_STATUS")]
        AWS_INSTANCE_CC_OR_CNP_RBS_CONNECTION_STATUS,

        [EnumMember(Value = "AWS_NATIVE_ACCOUNT_ENABLED_FEATURE")]
        AWS_NATIVE_ACCOUNT_ENABLED_FEATURE,

        [EnumMember(Value = "AWS_NATIVE_ACCOUNT_ID")]
        AWS_NATIVE_ACCOUNT_ID,

        [EnumMember(Value = "AWS_NATIVE_CLOUD_TYPE")]
        AWS_NATIVE_CLOUD_TYPE,

        [EnumMember(Value = "AWS_NATIVE_EC2_INSTANCE_ID")]
        AWS_NATIVE_EC2_INSTANCE_ID,

        [EnumMember(Value = "AWS_NATIVE_FEATURE_CONNECTED_STATUS")]
        AWS_NATIVE_FEATURE_CONNECTED_STATUS,

        [EnumMember(Value = "AWS_NATIVE_IS_ELIGIBLE_FOR_EC2_PROTECTION")]
        AWS_NATIVE_IS_ELIGIBLE_FOR_EC2_PROTECTION,

        [EnumMember(Value = "AWS_NATIVE_IS_ELIGIBLE_FOR_RDS_PROTECTION")]
        AWS_NATIVE_IS_ELIGIBLE_FOR_RDS_PROTECTION,

        [EnumMember(Value = "AWS_NATIVE_IS_ELIGIBLE_FOR_S3_PROTECTION")]
        AWS_NATIVE_IS_ELIGIBLE_FOR_S3_PROTECTION,

        [EnumMember(Value = "AWS_NATIVE_RDS_DB_ENGINE")]
        AWS_NATIVE_RDS_DB_ENGINE,

        [EnumMember(Value = "AWS_NATIVE_RDS_DB_INSTANCE_CLASS")]
        AWS_NATIVE_RDS_DB_INSTANCE_CLASS,

        [EnumMember(Value = "AWS_REGION")]
        AWS_REGION,

        [EnumMember(Value = "AWS_TAG")]
        AWS_TAG,

        [EnumMember(Value = "AWS_VPC_ID")]
        AWS_VPC_ID,

        [EnumMember(Value = "AZURE_BLOB_STORAGE_ACCOUNT_ACCESS_TIER")]
        AZURE_BLOB_STORAGE_ACCOUNT_ACCESS_TIER,

        [EnumMember(Value = "AZURE_BLOB_STORAGE_ACCOUNT_HNS_STATUS")]
        AZURE_BLOB_STORAGE_ACCOUNT_HNS_STATUS,

        [EnumMember(Value = "AZURE_BLOB_STORAGE_ACCOUNT_RG_NAME")]
        AZURE_BLOB_STORAGE_ACCOUNT_RG_NAME,

        [EnumMember(Value = "AZURE_BLOB_STORAGE_ACCOUNT_SUBSCRIPTION_ID")]
        AZURE_BLOB_STORAGE_ACCOUNT_SUBSCRIPTION_ID,

        [EnumMember(Value = "AZURE_DISK_ATTACHED_VM")]
        AZURE_DISK_ATTACHED_VM,

        [EnumMember(Value = "AZURE_DISK_CRG_NAME")]
        AZURE_DISK_CRG_NAME,

        [EnumMember(Value = "AZURE_DISK_CRG_SUBSCRIPTION_ID")]
        AZURE_DISK_CRG_SUBSCRIPTION_ID,

        [EnumMember(Value = "AZURE_DISK_SIZE")]
        AZURE_DISK_SIZE,

        [EnumMember(Value = "AZURE_DISK_SUBSCRIPTION_ID")]
        AZURE_DISK_SUBSCRIPTION_ID,

        [EnumMember(Value = "AZURE_DISK_TYPE")]
        AZURE_DISK_TYPE,

        [EnumMember(Value = "AZURE_NATIVE_DISK_EXOCOMPUTE_CONNECTED")]
        AZURE_NATIVE_DISK_EXOCOMPUTE_CONNECTED,

        [EnumMember(Value = "AZURE_NATIVE_DISK_INDEXING_STATUS")]
        AZURE_NATIVE_DISK_INDEXING_STATUS,

        [EnumMember(Value = "AZURE_NATIVE_SUBSCRIPTION_ENABLED_FEATURE")]
        AZURE_NATIVE_SUBSCRIPTION_ENABLED_FEATURE,

        [EnumMember(Value = "AZURE_NATIVE_VM_EXOCOMPUTE_CONNECTED")]
        AZURE_NATIVE_VM_EXOCOMPUTE_CONNECTED,

        [EnumMember(Value = "AZURE_NATIVE_VM_INDEXING_STATUS")]
        AZURE_NATIVE_VM_INDEXING_STATUS,

        [EnumMember(Value = "AZURE_REGION")]
        AZURE_REGION,

        [EnumMember(Value = "AZURE_RG_DISK_OR_VM_SLA")]
        AZURE_RG_DISK_OR_VM_SLA,

        [EnumMember(Value = "AZURE_RG_SUBSCRIPTION_ID")]
        AZURE_RG_SUBSCRIPTION_ID,

        [EnumMember(Value = "AZURE_RG_WORKLOAD_TYPES_SLA_DOMAIN")]
        AZURE_RG_WORKLOAD_TYPES_SLA_DOMAIN,

        [EnumMember(Value = "AZURE_SQL_DB_RG_NAME")]
        AZURE_SQL_DB_RG_NAME,

        [EnumMember(Value = "AZURE_SQL_DB_SERVER_RG_NAME")]
        AZURE_SQL_DB_SERVER_RG_NAME,

        [EnumMember(Value = "AZURE_SQL_DB_SERVER_SUBSCRIPTION_ID")]
        AZURE_SQL_DB_SERVER_SUBSCRIPTION_ID,

        [EnumMember(Value = "AZURE_SQL_DB_SUBSCRIPTION_ID")]
        AZURE_SQL_DB_SUBSCRIPTION_ID,

        [EnumMember(Value = "AZURE_SQL_MI_DB_RG_NAME")]
        AZURE_SQL_MI_DB_RG_NAME,

        [EnumMember(Value = "AZURE_SQL_MI_DB_SUBSCRIPTION_ID")]
        AZURE_SQL_MI_DB_SUBSCRIPTION_ID,

        [EnumMember(Value = "AZURE_SQL_MI_SERVER_RG_NAME")]
        AZURE_SQL_MI_SERVER_RG_NAME,

        [EnumMember(Value = "AZURE_SQL_MI_SERVER_SUBSCRIPTION_ID")]
        AZURE_SQL_MI_SERVER_SUBSCRIPTION_ID,

        [EnumMember(Value = "AZURE_TAG")]
        AZURE_TAG,

        [EnumMember(Value = "AZURE_VM_CC_OR_CNP_RBS_CONNECTION_STATUS")]
        AZURE_VM_CC_OR_CNP_RBS_CONNECTION_STATUS,

        [EnumMember(Value = "AZURE_VM_CRG_NAME")]
        AZURE_VM_CRG_NAME,

        [EnumMember(Value = "AZURE_VM_CRG_SUBSCRIPTION_ID")]
        AZURE_VM_CRG_SUBSCRIPTION_ID,

        [EnumMember(Value = "AZURE_VM_SIZE")]
        AZURE_VM_SIZE,

        [EnumMember(Value = "AZURE_VM_SUBSCRIPTION_ID")]
        AZURE_VM_SUBSCRIPTION_ID,

        [EnumMember(Value = "AZURE_VNET_NAME")]
        AZURE_VNET_NAME,

        [EnumMember(Value = "CASSANDRA_KEYSPACE_ID")]
        CASSANDRA_KEYSPACE_ID,

        [EnumMember(Value = "CASSANDRA_SOURCE_ID")]
        CASSANDRA_SOURCE_ID,

        [EnumMember(Value = "CASSANDRA_SOURCE_STATUS")]
        CASSANDRA_SOURCE_STATUS,

        [EnumMember(Value = "CDP_IO_FILTER_STATUS")]
        CDP_IO_FILTER_STATUS,

        [EnumMember(Value = "CDP_LOCAL_STATUS")]
        CDP_LOCAL_STATUS,

        [EnumMember(Value = "CDP_REPLICATION_STATUS")]
        CDP_REPLICATION_STATUS,

        [EnumMember(Value = "CDP_VMS")]
        CDP_VMS,

        [EnumMember(Value = "CDP_VM_EFFECTIVE_SLA_ID")]
        CDP_VM_EFFECTIVE_SLA_ID,

        [EnumMember(Value = "CDP_VM_NAME")]
        CDP_VM_NAME,

        [EnumMember(Value = "CDP_VM_SOURCE_CLUSTER_ID")]
        CDP_VM_SOURCE_CLUSTER_ID,

        [EnumMember(Value = "CLOUDDIRECT_NAS_NAMESPACE_NAME")]
        CLOUDDIRECT_NAS_NAMESPACE_NAME,

        [EnumMember(Value = "CLOUDDIRECT_NAS_NAMESPACE_SYSTEM_NAME")]
        CLOUDDIRECT_NAS_NAMESPACE_SYSTEM_NAME,

        [EnumMember(Value = "CLOUDDIRECT_NAS_NAMESPACE_VENDOR_TYPE")]
        CLOUDDIRECT_NAS_NAMESPACE_VENDOR_TYPE,

        [EnumMember(Value = "CLOUDDIRECT_NAS_SHARE_HIDDEN")]
        CLOUDDIRECT_NAS_SHARE_HIDDEN,

        [EnumMember(Value = "CLOUDDIRECT_NAS_SHARE_ID")]
        CLOUDDIRECT_NAS_SHARE_ID,

        [EnumMember(Value = "CLOUDDIRECT_NAS_SHARE_NAMESPACE_NAME")]
        CLOUDDIRECT_NAS_SHARE_NAMESPACE_NAME,

        [EnumMember(Value = "CLOUDDIRECT_NAS_SHARE_PARENT_ID")]
        CLOUDDIRECT_NAS_SHARE_PARENT_ID,

        [EnumMember(Value = "CLOUDDIRECT_NAS_SHARE_PROTOCOL")]
        CLOUDDIRECT_NAS_SHARE_PROTOCOL,

        [EnumMember(Value = "CLOUDDIRECT_NAS_SHARE_SYSTEM_NAME")]
        CLOUDDIRECT_NAS_SHARE_SYSTEM_NAME,

        [EnumMember(Value = "CLOUDDIRECT_NAS_SHARE_VENDOR_TYPE")]
        CLOUDDIRECT_NAS_SHARE_VENDOR_TYPE,

        [EnumMember(Value = "CLOUDDIRECT_NAS_SYSTEM_NAME")]
        CLOUDDIRECT_NAS_SYSTEM_NAME,

        [EnumMember(Value = "CLOUDDIRECT_NAS_VENDOR_TYPE")]
        CLOUDDIRECT_NAS_VENDOR_TYPE,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_SHARE_POLICY_NAME")]
        CLOUD_DIRECT_NAS_SHARE_POLICY_NAME,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_SHARE_STALE")]
        CLOUD_DIRECT_NAS_SHARE_STALE,

        [EnumMember(Value = "CLOUD_INSTANCE_CDM_APP_PROTECTION_SETUP")]
        CLOUD_INSTANCE_CDM_APP_PROTECTION_SETUP,

        [EnumMember(Value = "CLOUD_INSTANCE_HOST_DESCENDANT_OBJECT_TYPE")]
        CLOUD_INSTANCE_HOST_DESCENDANT_OBJECT_TYPE,

        [EnumMember(Value = "CLOUD_NATIVE_SERVER_NAME_FILTER")]
        CLOUD_NATIVE_SERVER_NAME_FILTER,

        [EnumMember(Value = "CLUSTER_ID")]
        CLUSTER_ID,

        [EnumMember(Value = "CLUSTER_TYPE")]
        CLUSTER_TYPE,

        [EnumMember(Value = "D365_TABLE_TYPE")]
        D365_TABLE_TYPE,

        [EnumMember(Value = "DB2_CDM_DATABASE_ID")]
        DB2_CDM_DATABASE_ID,

        [EnumMember(Value = "DB2_DB_TYPE")]
        DB2_DB_TYPE,

        [EnumMember(Value = "DB2_HOST_ID")]
        DB2_HOST_ID,

        [EnumMember(Value = "DB2_INSTANCE_ID")]
        DB2_INSTANCE_ID,

        [EnumMember(Value = "DB2_INSTANCE_STATUS")]
        DB2_INSTANCE_STATUS,

        [EnumMember(Value = "DEDUPE_NUTANIX_PRISM_CENTRAL_OBJECTS")]
        DEDUPE_NUTANIX_PRISM_CENTRAL_OBJECTS,

        [EnumMember(Value = "DOES_NAS_SHARE_HAVE_RELIC_FILESETS")]
        DOES_NAS_SHARE_HAVE_RELIC_FILESETS,

        [EnumMember(Value = "DOES_NAS_VOLUME_HAVE_SMC")]
        DOES_NAS_VOLUME_HAVE_SMC,

        [EnumMember(Value = "DOES_PHYSICAL_HOST_HAVE_PROTECTED_FILESETS")]
        DOES_PHYSICAL_HOST_HAVE_PROTECTED_FILESETS,

        [EnumMember(Value = "DOES_PHYSICAL_HOST_HAVE_PROTECTED_VOLUME_GROUP")]
        DOES_PHYSICAL_HOST_HAVE_PROTECTED_VOLUME_GROUP,

        [EnumMember(Value = "DOES_PHYSICAL_HOST_HAVE_RELIC_FILESETS")]
        DOES_PHYSICAL_HOST_HAVE_RELIC_FILESETS,

        [EnumMember(Value = "DOES_PHYSICAL_HOST_HAVE_RELIC_VOLUME_GROUP")]
        DOES_PHYSICAL_HOST_HAVE_RELIC_VOLUME_GROUP,

        [EnumMember(Value = "DOES_SHAREPOINT_HAVE_RELIC_OBJECTS")]
        DOES_SHAREPOINT_HAVE_RELIC_OBJECTS,

        [EnumMember(Value = "DOMAIN_CONTROLLER_CONNECTION_STATUS")]
        DOMAIN_CONTROLLER_CONNECTION_STATUS,

        [EnumMember(Value = "DOMAIN_CONTROLLER_DOMAIN_SID")]
        DOMAIN_CONTROLLER_DOMAIN_SID,

        [EnumMember(Value = "DOMAIN_CONTROLLER_FSMO_ROLE")]
        DOMAIN_CONTROLLER_FSMO_ROLE,

        [EnumMember(Value = "DOMAIN_HAS_FOREST")]
        DOMAIN_HAS_FOREST,

        [EnumMember(Value = "EBS_VOLUME_ID")]
        EBS_VOLUME_ID,

        [EnumMember(Value = "EBS_VOLUME_INDEXING_STATUS")]
        EBS_VOLUME_INDEXING_STATUS,

        [EnumMember(Value = "EBS_VOLUME_NAME")]
        EBS_VOLUME_NAME,

        [EnumMember(Value = "EBS_VOLUME_NAME_OR_VOLUME_ID")]
        EBS_VOLUME_NAME_OR_VOLUME_ID,

        [EnumMember(Value = "EBS_VOLUME_TYPE")]
        EBS_VOLUME_TYPE,

        [EnumMember(Value = "EC2_INSTANCE_ID")]
        EC2_INSTANCE_ID,

        [EnumMember(Value = "EC2_INSTANCE_INDEXING_STATUS")]
        EC2_INSTANCE_INDEXING_STATUS,

        [EnumMember(Value = "EC2_INSTANCE_NAME")]
        EC2_INSTANCE_NAME,

        [EnumMember(Value = "EC2_INSTANCE_NAME_OR_INSTANCE_ID")]
        EC2_INSTANCE_NAME_OR_INSTANCE_ID,

        [EnumMember(Value = "EC2_INSTANCE_TYPE")]
        EC2_INSTANCE_TYPE,

        [EnumMember(Value = "EFFECTIVE_RETENTION_SLA")]
        EFFECTIVE_RETENTION_SLA,

        [EnumMember(Value = "EFFECTIVE_SLA")]
        EFFECTIVE_SLA,

        [EnumMember(Value = "EFFECTIVE_SLA_SOURCE_OBJECT")]
        EFFECTIVE_SLA_SOURCE_OBJECT,

        [EnumMember(Value = "EFFECTIVE_SLA_TYPE")]
        EFFECTIVE_SLA_TYPE,

        [EnumMember(Value = "EFFECTIVE_SLA_WITH_RETENTION_SLA")]
        EFFECTIVE_SLA_WITH_RETENTION_SLA,

        [EnumMember(Value = "EXCHANGE_DATABASE_BY_DAG_ID")]
        EXCHANGE_DATABASE_BY_DAG_ID,

        [EnumMember(Value = "EXCHANGE_DATABASE_BY_HOST_ID")]
        EXCHANGE_DATABASE_BY_HOST_ID,

        [EnumMember(Value = "EXCHANGE_DATABASE_BY_SERVER_ID")]
        EXCHANGE_DATABASE_BY_SERVER_ID,

        [EnumMember(Value = "EXCHANGE_SERVER_BY_DAG_ID")]
        EXCHANGE_SERVER_BY_DAG_ID,

        [EnumMember(Value = "EXCLUDED_ROOT_RESOURCE_POOL_TYPE")]
        EXCLUDED_ROOT_RESOURCE_POOL_TYPE,

        [EnumMember(Value = "EXCLUDED_SHAREPOINT_LIBRARY_TYPE")]
        EXCLUDED_SHAREPOINT_LIBRARY_TYPE,

        [EnumMember(Value = "FAILOVER_CLUSTERS_BY_MSSQL_EFFECTIVE_SLA")]
        FAILOVER_CLUSTERS_BY_MSSQL_EFFECTIVE_SLA,

        [EnumMember(Value = "FAILOVER_CLUSTER_APP_CONNECTION_STATUS")]
        FAILOVER_CLUSTER_APP_CONNECTION_STATUS,

        [EnumMember(Value = "FAILOVER_CLUSTER_APP_ID")]
        FAILOVER_CLUSTER_APP_ID,

        [EnumMember(Value = "FAILOVER_CLUSTER_CONNECTION_STATUS")]
        FAILOVER_CLUSTER_CONNECTION_STATUS,

        [EnumMember(Value = "FAILOVER_CLUSTER_ID")]
        FAILOVER_CLUSTER_ID,

        [EnumMember(Value = "FILESET_MIGRATION_STATUS")]
        FILESET_MIGRATION_STATUS,

        [EnumMember(Value = "FILESET_SLA")]
        FILESET_SLA,

        [EnumMember(Value = "FILESET_TEMPLATE_ID")]
        FILESET_TEMPLATE_ID,

        [EnumMember(Value = "FILESET_TEMPLATE_OS_TYPE")]
        FILESET_TEMPLATE_OS_TYPE,

        [EnumMember(Value = "GCP_LABEL")]
        GCP_LABEL,

        [EnumMember(Value = "GCP_NATIVE_DISK_INDEXING_STATUS")]
        GCP_NATIVE_DISK_INDEXING_STATUS,

        [EnumMember(Value = "GCP_NATIVE_DISK_LOCATION")]
        GCP_NATIVE_DISK_LOCATION,

        [EnumMember(Value = "GCP_NATIVE_DISK_NAME_OR_NATIVE_ID")]
        GCP_NATIVE_DISK_NAME_OR_NATIVE_ID,

        [EnumMember(Value = "GCP_NATIVE_DISK_PROJECT")]
        GCP_NATIVE_DISK_PROJECT,

        [EnumMember(Value = "GCP_NATIVE_DISK_TYPE")]
        GCP_NATIVE_DISK_TYPE,

        [EnumMember(Value = "GCP_NATIVE_INSTANCE_NAME_OR_NATIVE_ID")]
        GCP_NATIVE_INSTANCE_NAME_OR_NATIVE_ID,

        [EnumMember(Value = "GCP_NATIVE_INSTANCE_NETWORK_NAME")]
        GCP_NATIVE_INSTANCE_NETWORK_NAME,

        [EnumMember(Value = "GCP_NATIVE_INSTANCE_TYPE")]
        GCP_NATIVE_INSTANCE_TYPE,

        [EnumMember(Value = "GCP_NATIVE_PROJECT_ID")]
        GCP_NATIVE_PROJECT_ID,

        [EnumMember(Value = "GCP_NATIVE_PROJECT_NAME_OR_PROJECT_NUMBER")]
        GCP_NATIVE_PROJECT_NAME_OR_PROJECT_NUMBER,

        [EnumMember(Value = "GCP_NATIVE_PROJECT_NATIVE_ID")]
        GCP_NATIVE_PROJECT_NATIVE_ID,

        [EnumMember(Value = "GCP_NATIVE_REGION")]
        GCP_NATIVE_REGION,

        [EnumMember(Value = "GCP_NATIVE_VM_INDEXING_STATUS")]
        GCP_NATIVE_VM_INDEXING_STATUS,

        [EnumMember(Value = "GCP_REGION")]
        GCP_REGION,

        [EnumMember(Value = "GUEST_OS_TYPE_FOR_FILE_RESTORE")]
        GUEST_OS_TYPE_FOR_FILE_RESTORE,

        [EnumMember(Value = "HAS_EXPIRED_INDEXED_SNAPSHOTS")]
        HAS_EXPIRED_INDEXED_SNAPSHOTS,

        [EnumMember(Value = "HAS_EXPIRED_NON_GCED_SNAPSHOTS")]
        HAS_EXPIRED_NON_GCED_SNAPSHOTS,

        [EnumMember(Value = "HAS_EXPIRED_NON_GCED_SNAPSHOT_COUNT_UNSET")]
        HAS_EXPIRED_NON_GCED_SNAPSHOT_COUNT_UNSET,

        [EnumMember(Value = "HAS_PARENT_SNAPPABLE")]
        HAS_PARENT_SNAPPABLE,

        [EnumMember(Value = "HAS_UNEXPIRED_SNAPSHOTS")]
        HAS_UNEXPIRED_SNAPSHOTS,

        [EnumMember(Value = "HOST_BY_AGENT_ID")]
        HOST_BY_AGENT_ID,

        [EnumMember(Value = "HOST_CBT_STATUS")]
        HOST_CBT_STATUS,

        [EnumMember(Value = "HOST_DOMAIN_CONTROLLER_FID")]
        HOST_DOMAIN_CONTROLLER_FID,

        [EnumMember(Value = "HOST_MIGRATION_STATUS")]
        HOST_MIGRATION_STATUS,

        [EnumMember(Value = "HOST_OPERATING_SYSTEM")]
        HOST_OPERATING_SYSTEM,

        [EnumMember(Value = "HOST_SHARE_MIGRATION_STATUS")]
        HOST_SHARE_MIGRATION_STATUS,

        [EnumMember(Value = "HOST_VENDOR_TYPE")]
        HOST_VENDOR_TYPE,

        [EnumMember(Value = "HYPERV_HOST_OR_SERVER_NAME")]
        HYPERV_HOST_OR_SERVER_NAME,

        [EnumMember(Value = "HYPERV_VM_BY_AGENT_STATUS")]
        HYPERV_VM_BY_AGENT_STATUS,

        [EnumMember(Value = "HYPERV_VM_MAC_ADDRESS")]
        HYPERV_VM_MAC_ADDRESS,

        [EnumMember(Value = "INCLUDE_DIRECT_ASSIGN_OBJECT")]
        INCLUDE_DIRECT_ASSIGN_OBJECT,

        [EnumMember(Value = "INCLUDE_INDEPENDENT_REPLICA")]
        INCLUDE_INDEPENDENT_REPLICA,

        [EnumMember(Value = "IS_ACTIVE")]
        IS_ACTIVE,

        [EnumMember(Value = "IS_ACTIVE_AMONG_DUPLICATED_OBJECTS")]
        IS_ACTIVE_AMONG_DUPLICATED_OBJECTS,

        [EnumMember(Value = "IS_ARCHIVED")]
        IS_ARCHIVED,

        [EnumMember(Value = "IS_DELETED_IN_CDM")]
        IS_DELETED_IN_CDM,

        [EnumMember(Value = "IS_DOMAIN_CONTROLLER")]
        IS_DOMAIN_CONTROLLER,

        [EnumMember(Value = "IS_GHOST")]
        IS_GHOST,

        [EnumMember(Value = "IS_HOST_PROTECTED")]
        IS_HOST_PROTECTED,

        [EnumMember(Value = "IS_KUPR_HOST")]
        IS_KUPR_HOST,

        [EnumMember(Value = "IS_LOG_SHIPPING_SECONDARY")]
        IS_LOG_SHIPPING_SECONDARY,

        [EnumMember(Value = "IS_MAIN_MOUNT")]
        IS_MAIN_MOUNT,

        [EnumMember(Value = "IS_MANAGED_VOLUME_ARCHIVED")]
        IS_MANAGED_VOLUME_ARCHIVED,

        [EnumMember(Value = "IS_MOUNT")]
        IS_MOUNT,

        [EnumMember(Value = "IS_NAS_SHARE_PROTECTED")]
        IS_NAS_SHARE_PROTECTED,

        [EnumMember(Value = "IS_NOT_BLUEPRINT_CHILD")]
        IS_NOT_BLUEPRINT_CHILD,

        [EnumMember(Value = "IS_PROTECTED")]
        IS_PROTECTED,

        [EnumMember(Value = "IS_RECOVERY_PLAN_VISIBLE")]
        IS_RECOVERY_PLAN_VISIBLE,

        [EnumMember(Value = "IS_RELIC")]
        IS_RELIC,

        [EnumMember(Value = "IS_REPLICATED")]
        IS_REPLICATED,

        [EnumMember(Value = "IS_SAP_HANA_SYSTEMDB")]
        IS_SAP_HANA_SYSTEMDB,

        [EnumMember(Value = "IS_UNACCESSED")]
        IS_UNACCESSED,

        [EnumMember(Value = "IS_UNMANAGED_OBJECT")]
        IS_UNMANAGED_OBJECT,

        [EnumMember(Value = "JIRA_PROJECT_KEY_OR_NAME")]
        JIRA_PROJECT_KEY_OR_NAME,

        [EnumMember(Value = "JIRA_PROJECT_LEAD")]
        JIRA_PROJECT_LEAD,

        [EnumMember(Value = "JIRA_PROJECT_TYPE")]
        JIRA_PROJECT_TYPE,

        [EnumMember(Value = "K8S_CLUSTER_ID")]
        K8S_CLUSTER_ID,

        [EnumMember(Value = "K8S_CLUSTER_ID_ON_NAMESPACE")]
        K8S_CLUSTER_ID_ON_NAMESPACE,

        [EnumMember(Value = "K8S_CLUSTER_NAME")]
        K8S_CLUSTER_NAME,

        [EnumMember(Value = "K8S_CLUSTER_STATUS")]
        K8S_CLUSTER_STATUS,

        [EnumMember(Value = "K8S_NAMESPACE_ID")]
        K8S_NAMESPACE_ID,

        [EnumMember(Value = "KUPR_CDM_CLUSTER_ID")]
        KUPR_CDM_CLUSTER_ID,

        [EnumMember(Value = "KUPR_CLUSTER_STATUS")]
        KUPR_CLUSTER_STATUS,

        [EnumMember(Value = "KUPR_NAMESPACE_CDM_CLUSTER_ID")]
        KUPR_NAMESPACE_CDM_CLUSTER_ID,

        [EnumMember(Value = "KUPR_NAMESPACE_CLUSTER_STATUS")]
        KUPR_NAMESPACE_CLUSTER_STATUS,

        [EnumMember(Value = "LOCATION")]
        LOCATION,

        [EnumMember(Value = "M365_BACKUP_STORAGE_PROTECTION_STATUS_MISMATCH")]
        M365_BACKUP_STORAGE_PROTECTION_STATUS_MISMATCH,

        [EnumMember(Value = "M365_PREFERRED_DATA_LOCATION")]
        M365_PREFERRED_DATA_LOCATION,

        [EnumMember(Value = "MANAGED_VOLUME_EXPORT_ID")]
        MANAGED_VOLUME_EXPORT_ID,

        [EnumMember(Value = "MANAGED_VOLUME_EXPORT_MOUNT_TYPE")]
        MANAGED_VOLUME_EXPORT_MOUNT_TYPE,

        [EnumMember(Value = "MANAGED_VOLUME_HOST_CONNECTION_STATUS")]
        MANAGED_VOLUME_HOST_CONNECTION_STATUS,

        [EnumMember(Value = "MANAGED_VOLUME_HOST_ID")]
        MANAGED_VOLUME_HOST_ID,

        [EnumMember(Value = "MANAGED_VOLUME_ID")]
        MANAGED_VOLUME_ID,

        [EnumMember(Value = "MANAGED_VOLUME_TYPE")]
        MANAGED_VOLUME_TYPE,

        [EnumMember(Value = "MIGRATED_HOSTS_WITH_GHOST_OBJECTS")]
        MIGRATED_HOSTS_WITH_GHOST_OBJECTS,

        [EnumMember(Value = "MIGRATED_HOST_SHARES_WITH_GHOST_OBJECTS")]
        MIGRATED_HOST_SHARES_WITH_GHOST_OBJECTS,

        [EnumMember(Value = "MONGODB_DATABASE_ID")]
        MONGODB_DATABASE_ID,

        [EnumMember(Value = "MONGODB_SOURCE_ID")]
        MONGODB_SOURCE_ID,

        [EnumMember(Value = "MONGODB_SOURCE_STATUS")]
        MONGODB_SOURCE_STATUS,

        [EnumMember(Value = "MONGO_COLLECTION_PROTECTED")]
        MONGO_COLLECTION_PROTECTED,

        [EnumMember(Value = "MONGO_DATABASE_ID")]
        MONGO_DATABASE_ID,

        [EnumMember(Value = "MONGO_MANAGEMENT_TYPE")]
        MONGO_MANAGEMENT_TYPE,

        [EnumMember(Value = "MONGO_SOURCE_ID")]
        MONGO_SOURCE_ID,

        [EnumMember(Value = "MSSQL_HOST_BY_MSSQL_EFFECTIVE_SLA")]
        MSSQL_HOST_BY_MSSQL_EFFECTIVE_SLA,

        [EnumMember(Value = "MSSQL_HOST_CBT_STATUS")]
        MSSQL_HOST_CBT_STATUS,

        [EnumMember(Value = "MSSQL_HOST_CONNECTION_STATUS")]
        MSSQL_HOST_CONNECTION_STATUS,

        [EnumMember(Value = "MSSQL_IS_FAILOVER_CLUSTER_PROTECTED")]
        MSSQL_IS_FAILOVER_CLUSTER_PROTECTED,

        [EnumMember(Value = "MSSQL_IS_FAILOVER_CLUSTER_UNPROTECTABLE")]
        MSSQL_IS_FAILOVER_CLUSTER_UNPROTECTABLE,

        [EnumMember(Value = "MSSQL_IS_HOST_PROTECTED")]
        MSSQL_IS_HOST_PROTECTED,

        [EnumMember(Value = "MYSQLDB_HOST_CONNECTION_STATUS")]
        MYSQLDB_HOST_CONNECTION_STATUS,

        [EnumMember(Value = "MYSQLDB_INSTANCE_ID")]
        MYSQLDB_INSTANCE_ID,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "NAME_EXACT_MATCH")]
        NAME_EXACT_MATCH,

        [EnumMember(Value = "NAME_OR_EMAIL_ADDRESS")]
        NAME_OR_EMAIL_ADDRESS,

        [EnumMember(Value = "NAS_NAMESPACE_ID")]
        NAS_NAMESPACE_ID,

        [EnumMember(Value = "NAS_NAMESPACE_SYSTEM_NAME")]
        NAS_NAMESPACE_SYSTEM_NAME,

        [EnumMember(Value = "NAS_NAMESPACE_VENDOR_TYPE")]
        NAS_NAMESPACE_VENDOR_TYPE,

        [EnumMember(Value = "NAS_SHARE_HIDDEN")]
        NAS_SHARE_HIDDEN,

        [EnumMember(Value = "NAS_SHARE_NAMESPACE_ID")]
        NAS_SHARE_NAMESPACE_ID,

        [EnumMember(Value = "NAS_SHARE_SLA")]
        NAS_SHARE_SLA,

        [EnumMember(Value = "NAS_SHARE_STALE")]
        NAS_SHARE_STALE,

        [EnumMember(Value = "NAS_SHARE_SYSTEM_NAME")]
        NAS_SHARE_SYSTEM_NAME,

        [EnumMember(Value = "NAS_SHARE_TYPE")]
        NAS_SHARE_TYPE,

        [EnumMember(Value = "NAS_SHARE_VENDOR_TYPE")]
        NAS_SHARE_VENDOR_TYPE,

        [EnumMember(Value = "NAS_SYSTEM_FOR_NAS_MIGRATION")]
        NAS_SYSTEM_FOR_NAS_MIGRATION,

        [EnumMember(Value = "NAS_VENDOR_TYPE")]
        NAS_VENDOR_TYPE,

        [EnumMember(Value = "NAS_VOLUME_EFFECTIVE_SLA")]
        NAS_VOLUME_EFFECTIVE_SLA,

        [EnumMember(Value = "NUTANIX_PRISM_CENTRAL_ID")]
        NUTANIX_PRISM_CENTRAL_ID,

        [EnumMember(Value = "NUTANIX_SHOW_ONLY_STANDALONE_CLUSTERS")]
        NUTANIX_SHOW_ONLY_STANDALONE_CLUSTERS,

        [EnumMember(Value = "NUTANIX_VM_BY_AGENT_STATUS")]
        NUTANIX_VM_BY_AGENT_STATUS,

        [EnumMember(Value = "NUTANIX_VM_BY_CAT_VAL_ID")]
        NUTANIX_VM_BY_CAT_VAL_ID,

        [EnumMember(Value = "NUTANIX_VM_BY_NUTANIX_CLUSTER_CDMID")]
        NUTANIX_VM_BY_NUTANIX_CLUSTER_CDMID,

        [EnumMember(Value = "O365_GROUP_TYPE")]
        O365_GROUP_TYPE,

        [EnumMember(Value = "O365_ORGANIZATION_ID")]
        O365_ORGANIZATION_ID,

        [EnumMember(Value = "O365_SITE_NAME_OR_URL")]
        O365_SITE_NAME_OR_URL,

        [EnumMember(Value = "O365_SPECIFIC_TYPE")]
        O365_SPECIFIC_TYPE,

        [EnumMember(Value = "ON_OR_ABOVE_CLUSTER_VERSION")]
        ON_OR_ABOVE_CLUSTER_VERSION,

        [EnumMember(Value = "ORACLE_OS_TYPE")]
        ORACLE_OS_TYPE,

        [EnumMember(Value = "ORGANIZATION_ID")]
        ORGANIZATION_ID,

        [EnumMember(Value = "OS_NAME")]
        OS_NAME,

        [EnumMember(Value = "OS_TYPE")]
        OS_TYPE,

        [EnumMember(Value = "PHYSICAL_HOST_BY_CLOUD_INSTANCE_ID")]
        PHYSICAL_HOST_BY_CLOUD_INSTANCE_ID,

        [EnumMember(Value = "PHYSICAL_HOST_BY_MSSQL_EFFECTIVE_SLA")]
        PHYSICAL_HOST_BY_MSSQL_EFFECTIVE_SLA,

        [EnumMember(Value = "PHYSICAL_HOST_BY_VOLUME_GROUP_EFFECTIVE_SLA")]
        PHYSICAL_HOST_BY_VOLUME_GROUP_EFFECTIVE_SLA,

        [EnumMember(Value = "PHYSICAL_HOST_CONNECTION_STATUS")]
        PHYSICAL_HOST_CONNECTION_STATUS,

        [EnumMember(Value = "PHYSICAL_HOST_EFFECTIVE_SLA")]
        PHYSICAL_HOST_EFFECTIVE_SLA,

        [EnumMember(Value = "PHYSICAL_HOST_EXCLUDE_IDS")]
        PHYSICAL_HOST_EXCLUDE_IDS,

        [EnumMember(Value = "PHYSICAL_HOST_ID")]
        PHYSICAL_HOST_ID,

        [EnumMember(Value = "PHYSICAL_HOST_RBS_UPGRADE_STATUS")]
        PHYSICAL_HOST_RBS_UPGRADE_STATUS,

        [EnumMember(Value = "POSTGRES_DB_CLUSTER_HOST_CONNECTION_STATUS")]
        POSTGRES_DB_CLUSTER_HOST_CONNECTION_STATUS,

        [EnumMember(Value = "POSTGRES_DB_CLUSTER_ID")]
        POSTGRES_DB_CLUSTER_ID,

        [EnumMember(Value = "PROTECTION_STATUS")]
        PROTECTION_STATUS,

        [EnumMember(Value = "RECOVERY_PLAN_AZURE_REGION")]
        RECOVERY_PLAN_AZURE_REGION,

        [EnumMember(Value = "RECOVERY_PLAN_AZURE_SOURCE_SUBSCRIPTION")]
        RECOVERY_PLAN_AZURE_SOURCE_SUBSCRIPTION,

        [EnumMember(Value = "RECOVERY_PLAN_AZURE_TARGET_SUBSCRIPTION")]
        RECOVERY_PLAN_AZURE_TARGET_SUBSCRIPTION,

        [EnumMember(Value = "RECOVERY_PLAN_NAME")]
        RECOVERY_PLAN_NAME,

        [EnumMember(Value = "RECOVERY_PLAN_SOURCE_LOCATION")]
        RECOVERY_PLAN_SOURCE_LOCATION,

        [EnumMember(Value = "RECOVERY_PLAN_STATUS")]
        RECOVERY_PLAN_STATUS,

        [EnumMember(Value = "RECOVERY_PLAN_TARGET_LOCATION")]
        RECOVERY_PLAN_TARGET_LOCATION,

        [EnumMember(Value = "RECOVERY_PLAN_TYPE")]
        RECOVERY_PLAN_TYPE,

        [EnumMember(Value = "RECOVERY_PLAN_WORKLOAD_TYPE")]
        RECOVERY_PLAN_WORKLOAD_TYPE,

        [EnumMember(Value = "RECOVERY_STATUS")]
        RECOVERY_STATUS,

        [EnumMember(Value = "REGEX")]
        REGEX,

        [EnumMember(Value = "RSC_TAG_ID")]
        RSC_TAG_ID,

        [EnumMember(Value = "RUBRIK_NATIVE_HAS_AT_LEAST_ONE_SNAPSHOT")]
        RUBRIK_NATIVE_HAS_AT_LEAST_ONE_SNAPSHOT,

        [EnumMember(Value = "RUBRIK_NATIVE_HAS_UNINDEXED_OR_EXPIRED_SNAPSHOT")]
        RUBRIK_NATIVE_HAS_UNINDEXED_OR_EXPIRED_SNAPSHOT,

        [EnumMember(Value = "SAASAPPS_IS_RECOVERY_TARGET_ONLY")]
        SAASAPPS_IS_RECOVERY_TARGET_ONLY,

        [EnumMember(Value = "SAASAPPS_NATURAL_ID")]
        SAASAPPS_NATURAL_ID,

        [EnumMember(Value = "SAASAPPS_ORGANIZATION_SCOPE")]
        SAASAPPS_ORGANIZATION_SCOPE,

        [EnumMember(Value = "SALESFORCE_NAME_OR_LABEL")]
        SALESFORCE_NAME_OR_LABEL,

        [EnumMember(Value = "SALESFORCE_OBJECT_TYPE")]
        SALESFORCE_OBJECT_TYPE,

        [EnumMember(Value = "SAP_HANA_DATABASE_CDM_ID")]
        SAP_HANA_DATABASE_CDM_ID,

        [EnumMember(Value = "SAP_HANA_SYSTEM_ID")]
        SAP_HANA_SYSTEM_ID,

        [EnumMember(Value = "SAP_HANA_SYSTEM_SID")]
        SAP_HANA_SYSTEM_SID,

        [EnumMember(Value = "SAP_HANA_SYSTEM_STATUS")]
        SAP_HANA_SYSTEM_STATUS,

        [EnumMember(Value = "SENSITIVITY_STATUS")]
        SENSITIVITY_STATUS,

        [EnumMember(Value = "TOP_LEVEL_SITES_OF_O365_ORG")]
        TOP_LEVEL_SITES_OF_O365_ORG,

        [EnumMember(Value = "UDF_DATABASE_TYPE")]
        UDF_DATABASE_TYPE,

        [EnumMember(Value = "VCD_VAPP_TYPE")]
        VCD_VAPP_TYPE,

        [EnumMember(Value = "VMWARE_DATASTORE_DEVICE_NAME")]
        VMWARE_DATASTORE_DEVICE_NAME,

        [EnumMember(Value = "VMWARE_DATASTORE_ID")]
        VMWARE_DATASTORE_ID,

        [EnumMember(Value = "VMWARE_IS_STANDALONE_HOST")]
        VMWARE_IS_STANDALONE_HOST,

        [EnumMember(Value = "VMWARE_SNAPSHOT_CONSISTENCY")]
        VMWARE_SNAPSHOT_CONSISTENCY,

        [EnumMember(Value = "VMWARE_VCD_HOSTNAME")]
        VMWARE_VCD_HOSTNAME,

        [EnumMember(Value = "VMWARE_VM_MAC_ADDRESS")]
        VMWARE_VM_MAC_ADDRESS,

        [EnumMember(Value = "VMWARE_VM_MOID")]
        VMWARE_VM_MOID,

        [EnumMember(Value = "VMWARE_VM_TEMPLATE_TYPE")]
        VMWARE_VM_TEMPLATE_TYPE,

        [EnumMember(Value = "VSPHERE_DATASTORE_IS_LOCAL")]
        VSPHERE_DATASTORE_IS_LOCAL,

        [EnumMember(Value = "VSPHERE_GET_ROOT_RESTORE_HIERARCHY")]
        VSPHERE_GET_ROOT_RESTORE_HIERARCHY


    } // enum HierarchyFilterField

} // namespace RubrikSecurityCloud.Types