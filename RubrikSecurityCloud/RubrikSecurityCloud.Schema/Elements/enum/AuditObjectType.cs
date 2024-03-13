// AuditObjectType.cs
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
    public enum AuditObjectType
    {
        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN")]
        ACTIVE_DIRECTORY_DOMAIN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN_CONTROLLER")]
        ACTIVE_DIRECTORY_DOMAIN_CONTROLLER,

        [EnumMember(Value = "APP_BLUEPRINT")]
        APP_BLUEPRINT,

        [EnumMember(Value = "ARCHIVAL_LOCATION")]
        ARCHIVAL_LOCATION,

        [EnumMember(Value = "ATLASSIAN_SITE")]
        ATLASSIAN_SITE,

        [EnumMember(Value = "AUDIT_OBJECT_TYPE_UNSPECIFIED")]
        AUDIT_OBJECT_TYPE_UNSPECIFIED,

        [EnumMember(Value = "AUTH_DOMAIN")]
        AUTH_DOMAIN,

        [EnumMember(Value = "AWS_ACCOUNT")]
        AWS_ACCOUNT,

        [EnumMember(Value = "AWS_EVENT_TYPE")]
        AWS_EVENT_TYPE,

        [EnumMember(Value = "AWS_NATIVE_ACCOUNT")]
        AWS_NATIVE_ACCOUNT,

        [EnumMember(Value = "AWS_NATIVE_EBS_VOLUME")]
        AWS_NATIVE_EBS_VOLUME,

        [EnumMember(Value = "AWS_NATIVE_EC2_INSTANCE")]
        AWS_NATIVE_EC2_INSTANCE,

        [EnumMember(Value = "AWS_NATIVE_RDS_INSTANCE")]
        AWS_NATIVE_RDS_INSTANCE,

        [EnumMember(Value = "AWS_NATIVE_S3_BUCKET")]
        AWS_NATIVE_S3_BUCKET,

        [EnumMember(Value = "AZURE_AD_DIRECTORY")]
        AZURE_AD_DIRECTORY,

        [EnumMember(Value = "AZURE_NATIVE_DISK")]
        AZURE_NATIVE_DISK,

        [EnumMember(Value = "AZURE_NATIVE_SUBSCRIPTION")]
        AZURE_NATIVE_SUBSCRIPTION,

        [EnumMember(Value = "AZURE_NATIVE_VM")]
        AZURE_NATIVE_VM,

        [EnumMember(Value = "AZURE_SQL_DATABASE")]
        AZURE_SQL_DATABASE,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE")]
        AZURE_SQL_MANAGED_INSTANCE,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT")]
        AZURE_STORAGE_ACCOUNT,

        [EnumMember(Value = "BLUEPRINT")]
        BLUEPRINT,

        [EnumMember(Value = "CASSANDRA_COLUMN_FAMILY")]
        CASSANDRA_COLUMN_FAMILY,

        [EnumMember(Value = "CASSANDRA_KEYSPACE")]
        CASSANDRA_KEYSPACE,

        [EnumMember(Value = "CASSANDRA_SOURCE")]
        CASSANDRA_SOURCE,

        [EnumMember(Value = "CERTIFICATE_MANAGEMENT")]
        CERTIFICATE_MANAGEMENT,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_EXPORT")]
        CLOUD_DIRECT_NAS_EXPORT,

        [EnumMember(Value = "CLOUD_NATIVE_TAG_RULE")]
        CLOUD_NATIVE_TAG_RULE,

        [EnumMember(Value = "CLUSTER")]
        CLUSTER,

        [EnumMember(Value = "CROSS_ACCOUNT_PAIR")]
        CROSS_ACCOUNT_PAIR,

        [EnumMember(Value = "DATA_CENTER_CLOUD_ACCOUNT")]
        DATA_CENTER_CLOUD_ACCOUNT,

        [EnumMember(Value = "DATA_LOCATION")]
        DATA_LOCATION,

        [EnumMember(Value = "DB2_DATABASE")]
        DB2_DATABASE,

        [EnumMember(Value = "DB2_INSTANCE")]
        DB2_INSTANCE,

        [EnumMember(Value = "EC2_INSTANCE")]
        EC2_INSTANCE,

        [EnumMember(Value = "ENCRYPTION_MANAGEMENT")]
        ENCRYPTION_MANAGEMENT,

        [EnumMember(Value = "EXCHANGE_DAG")]
        EXCHANGE_DAG,

        [EnumMember(Value = "EXCHANGE_DATABASE")]
        EXCHANGE_DATABASE,

        [EnumMember(Value = "EXCHANGE_SERVER")]
        EXCHANGE_SERVER,

        [EnumMember(Value = "EXOCOMPUTE")]
        EXOCOMPUTE,

        [EnumMember(Value = "FAILOVER_CLUSTER_APP")]
        FAILOVER_CLUSTER_APP,

        [EnumMember(Value = "FEDERATED_ACCESS")]
        FEDERATED_ACCESS,

        [EnumMember(Value = "GCP_NATIVE_DISK")]
        GCP_NATIVE_DISK,

        [EnumMember(Value = "GCP_NATIVE_GCE_INSTANCE")]
        GCP_NATIVE_GCE_INSTANCE,

        [EnumMember(Value = "GCP_NATIVE_PROJECT")]
        GCP_NATIVE_PROJECT,

        [EnumMember(Value = "HOST")]
        HOST,

        [EnumMember(Value = "HOST_FAILOVER_CLUSTER")]
        HOST_FAILOVER_CLUSTER,

        [EnumMember(Value = "HYPERV_SCVMM")]
        HYPERV_SCVMM,

        [EnumMember(Value = "HYPERV_SERVER")]
        HYPERV_SERVER,

        [EnumMember(Value = "HYPERV_VM")]
        HYPERV_VM,

        [EnumMember(Value = "IP_WHITELIST")]
        IP_WHITELIST,

        [EnumMember(Value = "JIRA_PROJECT")]
        JIRA_PROJECT,

        [EnumMember(Value = "JIRA_SETTINGS")]
        JIRA_SETTINGS,

        [EnumMember(Value = "JOB_INSTANCE")]
        JOB_INSTANCE,

        [EnumMember(Value = "K8S_CLUSTER")]
        K8S_CLUSTER,

        [EnumMember(Value = "K8S_PROTECTION_SET")]
        K8S_PROTECTION_SET,

        [EnumMember(Value = "LDAP")]
        LDAP,

        [EnumMember(Value = "LINUX_FILESET")]
        LINUX_FILESET,

        [EnumMember(Value = "LINUX_HOST")]
        LINUX_HOST,

        [EnumMember(Value = "MANAGED_VOLUME")]
        MANAGED_VOLUME,

        [EnumMember(Value = "MONGODB_SOURCE")]
        MONGODB_SOURCE,

        [EnumMember(Value = "MONGO_COLLECTION")]
        MONGO_COLLECTION,

        [EnumMember(Value = "MONGO_SOURCE")]
        MONGO_SOURCE,

        [EnumMember(Value = "MOSAIC_STORAGE_LOCATION")]
        MOSAIC_STORAGE_LOCATION,

        [EnumMember(Value = "MSSQL")]
        MSSQL,

        [EnumMember(Value = "MSSQL_DATABASE")]
        MSSQL_DATABASE,

        [EnumMember(Value = "MSSQL_MOUNT")]
        MSSQL_MOUNT,

        [EnumMember(Value = "MSSQL_OBJECT")]
        MSSQL_OBJECT,

        [EnumMember(Value = "NAS_HOST")]
        NAS_HOST,

        [EnumMember(Value = "NUTANIX_CLUSTER")]
        NUTANIX_CLUSTER,

        [EnumMember(Value = "NUTANIX_PRISM_CENTRAL")]
        NUTANIX_PRISM_CENTRAL,

        [EnumMember(Value = "NUTANIX_VM")]
        NUTANIX_VM,

        [EnumMember(Value = "O365_CALENDAR")]
        O365_CALENDAR,

        [EnumMember(Value = "O365_GROUP")]
        O365_GROUP,

        [EnumMember(Value = "O365_MAILBOX")]
        O365_MAILBOX,

        [EnumMember(Value = "O365_ONEDRIVE")]
        O365_ONEDRIVE,

        [EnumMember(Value = "O365_ORGANIZATION")]
        O365_ORGANIZATION,

        [EnumMember(Value = "O365_SHAREPOINT_DRIVE")]
        O365_SHAREPOINT_DRIVE,

        [EnumMember(Value = "O365_SHAREPOINT_LIST")]
        O365_SHAREPOINT_LIST,

        [EnumMember(Value = "O365_SHAREPOINT_SITE")]
        O365_SHAREPOINT_SITE,

        [EnumMember(Value = "O365_TEAM")]
        O365_TEAM,

        [EnumMember(Value = "OAUTH_TOKEN")]
        OAUTH_TOKEN,

        [EnumMember(Value = "ORACLE_DB")]
        ORACLE_DB,

        [EnumMember(Value = "ORACLE_HOST")]
        ORACLE_HOST,

        [EnumMember(Value = "ORACLE_MOUNT")]
        ORACLE_MOUNT,

        [EnumMember(Value = "ORACLE_RAC")]
        ORACLE_RAC,

        [EnumMember(Value = "ORGANIZATION")]
        ORGANIZATION,

        [EnumMember(Value = "PUBLIC_CLOUD_MACHINE_INSTANCE")]
        PUBLIC_CLOUD_MACHINE_INSTANCE,

        [EnumMember(Value = "REPLICATION_PAIR")]
        REPLICATION_PAIR,

        [EnumMember(Value = "SALESFORCE_METADATA")]
        SALESFORCE_METADATA,

        [EnumMember(Value = "SALESFORCE_OBJECT")]
        SALESFORCE_OBJECT,

        [EnumMember(Value = "SALESFORCE_ORGANIZATION")]
        SALESFORCE_ORGANIZATION,

        [EnumMember(Value = "SAP_HANA_DB")]
        SAP_HANA_DB,

        [EnumMember(Value = "SAP_HANA_SYSTEM")]
        SAP_HANA_SYSTEM,

        [EnumMember(Value = "SHARE_FILESET")]
        SHARE_FILESET,

        [EnumMember(Value = "SLA")]
        SLA,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN,

        [EnumMember(Value = "SMB_DOMAIN")]
        SMB_DOMAIN,

        [EnumMember(Value = "SNAPSHOT")]
        SNAPSHOT,

        [EnumMember(Value = "STORAGE_ARRAY")]
        STORAGE_ARRAY,

        [EnumMember(Value = "STORAGE_ARRAY_VOLUME_GROUP")]
        STORAGE_ARRAY_VOLUME_GROUP,

        [EnumMember(Value = "STORAGE_SETTINGS")]
        STORAGE_SETTINGS,

        [EnumMember(Value = "STORM")]
        STORM,

        [EnumMember(Value = "SUPPORT_TUNNEL")]
        SUPPORT_TUNNEL,

        [EnumMember(Value = "SYSTEM_PREFERENCE")]
        SYSTEM_PREFERENCE,

        [EnumMember(Value = "TPR_CONFIG")]
        TPR_CONFIG,

        [EnumMember(Value = "TPR_POLICY")]
        TPR_POLICY,

        [EnumMember(Value = "TPR_REQUEST")]
        TPR_REQUEST,

        [EnumMember(Value = "UPGRADE")]
        UPGRADE,

        [EnumMember(Value = "USER")]
        USER,

        [EnumMember(Value = "USER_ACTION_AUDIT")]
        USER_ACTION_AUDIT,

        [EnumMember(Value = "USER_GROUP")]
        USER_GROUP,

        [EnumMember(Value = "USER_ROLE")]
        USER_ROLE,

        [EnumMember(Value = "VCD")]
        VCD,

        [EnumMember(Value = "VCD_VAPP")]
        VCD_VAPP,

        [EnumMember(Value = "VCENTER")]
        VCENTER,

        [EnumMember(Value = "VMWARE_COMPUTE_CLUSTER")]
        VMWARE_COMPUTE_CLUSTER,

        [EnumMember(Value = "VMWARE_MOUNT")]
        VMWARE_MOUNT,

        [EnumMember(Value = "VMWARE_VM")]
        VMWARE_VM,

        [EnumMember(Value = "VOLUME_GROUP")]
        VOLUME_GROUP,

        [EnumMember(Value = "WINDOWS_FILESET")]
        WINDOWS_FILESET,

        [EnumMember(Value = "WINDOWS_HOST")]
        WINDOWS_HOST


    } // enum AuditObjectType

} // namespace RubrikSecurityCloud.Types