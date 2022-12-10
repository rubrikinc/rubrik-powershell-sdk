// HierarchyFilterField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:16.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum HierarchyFilterField
    {
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

        [EnumMember(Value = "DB2_DB_TYPE")]
        DB2_DB_TYPE,

        [EnumMember(Value = "DB2_INSTANCE_ID")]
        DB2_INSTANCE_ID,

        [EnumMember(Value = "DB2_INSTANCE_STATUS")]
        DB2_INSTANCE_STATUS,

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

        [EnumMember(Value = "FILESET_SLA")]
        FILESET_SLA,

        [EnumMember(Value = "FILESET_TEMPLATE_ID")]
        FILESET_TEMPLATE_ID,

        [EnumMember(Value = "FILESET_TEMPLATE_OS_TYPE")]
        FILESET_TEMPLATE_OS_TYPE,

        [EnumMember(Value = "GCP_LABEL")]
        GCP_LABEL,

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

        [EnumMember(Value = "GUEST_OS_TYPE_FOR_FILE_RESTORE")]
        GUEST_OS_TYPE_FOR_FILE_RESTORE,

        [EnumMember(Value = "HAS_PARENT_SNAPPABLE")]
        HAS_PARENT_SNAPPABLE,

        [EnumMember(Value = "HAS_UNEXPIRED_SNAPSHOTS")]
        HAS_UNEXPIRED_SNAPSHOTS,

        [EnumMember(Value = "HOST_CBT_STATUS")]
        HOST_CBT_STATUS,

        [EnumMember(Value = "HOST_OPERATING_SYSTEM")]
        HOST_OPERATING_SYSTEM,

        [EnumMember(Value = "HOST_VENDOR_TYPE")]
        HOST_VENDOR_TYPE,

        [EnumMember(Value = "IS_ACTIVE")]
        IS_ACTIVE,

        [EnumMember(Value = "IS_ACTIVE_AMONG_DUPLICATED_OBJECTS")]
        IS_ACTIVE_AMONG_DUPLICATED_OBJECTS,

        [EnumMember(Value = "IS_ARCHIVED")]
        IS_ARCHIVED,

        [EnumMember(Value = "IS_DELETED_IN_CDM")]
        IS_DELETED_IN_CDM,

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

        [EnumMember(Value = "IS_UNMANAGED_OBJECT")]
        IS_UNMANAGED_OBJECT,

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

        [EnumMember(Value = "M365_PREFERRED_DATA_LOCATION")]
        M365_PREFERRED_DATA_LOCATION,

        [EnumMember(Value = "MANAGED_VOLUME_EXPORT_ID")]
        MANAGED_VOLUME_EXPORT_ID,

        [EnumMember(Value = "MANAGED_VOLUME_ID")]
        MANAGED_VOLUME_ID,

        [EnumMember(Value = "MANAGED_VOLUME_TYPE")]
        MANAGED_VOLUME_TYPE,

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

        [EnumMember(Value = "MONGO_SOURCE_ID")]
        MONGO_SOURCE_ID,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "NAME_EXACT_MATCH")]
        NAME_EXACT_MATCH,

        [EnumMember(Value = "NAME_OR_EMAIL_ADDRESS")]
        NAME_OR_EMAIL_ADDRESS,

        [EnumMember(Value = "NAS_NAMESPACE_ID")]
        NAS_NAMESPACE_ID,

        [EnumMember(Value = "NAS_SHARE_HIDDEN")]
        NAS_SHARE_HIDDEN,

        [EnumMember(Value = "NAS_SHARE_NAMESPACE_ID")]
        NAS_SHARE_NAMESPACE_ID,

        [EnumMember(Value = "NAS_SHARE_SLA")]
        NAS_SHARE_SLA,

        [EnumMember(Value = "NAS_SHARE_STALE")]
        NAS_SHARE_STALE,

        [EnumMember(Value = "NAS_SHARE_TYPE")]
        NAS_SHARE_TYPE,

        [EnumMember(Value = "NAS_VENDOR_TYPE")]
        NAS_VENDOR_TYPE,

        [EnumMember(Value = "NAS_VOLUME_EFFECTIVE_SLA")]
        NAS_VOLUME_EFFECTIVE_SLA,

        [EnumMember(Value = "NUTANIX_PRISM_CENTRAL_ID")]
        NUTANIX_PRISM_CENTRAL_ID,

        [EnumMember(Value = "NUTANIX_VM_BY_AGENT_STATUS")]
        NUTANIX_VM_BY_AGENT_STATUS,

        [EnumMember(Value = "NUTANIX_VM_BY_NUTANIX_CLUSTER_CDMID")]
        NUTANIX_VM_BY_NUTANIX_CLUSTER_CDMID,

        [EnumMember(Value = "O365_GROUP_TYPE")]
        O365_GROUP_TYPE,

        [EnumMember(Value = "O365_ORGANIZATION_ID")]
        O365_ORGANIZATION_ID,

        [EnumMember(Value = "O365_SPECIFIC_TYPE")]
        O365_SPECIFIC_TYPE,

        [EnumMember(Value = "ON_OR_ABOVE_CLUSTER_VERSION")]
        ON_OR_ABOVE_CLUSTER_VERSION,

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

        [EnumMember(Value = "PHYSICAL_HOST_ID")]
        PHYSICAL_HOST_ID,

        [EnumMember(Value = "RECOVERY_PLAN_NAME")]
        RECOVERY_PLAN_NAME,

        [EnumMember(Value = "RECOVERY_PLAN_TYPE")]
        RECOVERY_PLAN_TYPE,

        [EnumMember(Value = "RECOVERY_STATUS")]
        RECOVERY_STATUS,

        [EnumMember(Value = "REGEX")]
        REGEX,

        [EnumMember(Value = "RUBRIK_NATIVE_HAS_UNINDEXED_OR_EXPIRED_SNAPSHOT")]
        RUBRIK_NATIVE_HAS_UNINDEXED_OR_EXPIRED_SNAPSHOT,

        [EnumMember(Value = "SAP_HANA_DATABASE_CDM_ID")]
        SAP_HANA_DATABASE_CDM_ID,

        [EnumMember(Value = "SAP_HANA_SYSTEM_ID")]
        SAP_HANA_SYSTEM_ID,

        [EnumMember(Value = "SAP_HANA_SYSTEM_SID")]
        SAP_HANA_SYSTEM_SID,

        [EnumMember(Value = "SAP_HANA_SYSTEM_STATUS")]
        SAP_HANA_SYSTEM_STATUS,

        [EnumMember(Value = "UDF_DATABASE_TYPE")]
        UDF_DATABASE_TYPE,

        [EnumMember(Value = "VCD_VAPP_TYPE")]
        VCD_VAPP_TYPE,

        [EnumMember(Value = "VSPHERE_DATASTORE_IS_LOCAL")]
        VSPHERE_DATASTORE_IS_LOCAL,

        [EnumMember(Value = "VSPHERE_GET_ROOT_RESTORE_HIERARCHY")]
        VSPHERE_GET_ROOT_RESTORE_HIERARCHY


    } // enum HierarchyFilterField

} // namespace Rubrik.SecurityCloud.Types