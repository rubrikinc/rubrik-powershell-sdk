// UserAuditObjectTypeEnum.cs
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
    public enum UserAuditObjectTypeEnum
    {
        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN")]
        ACTIVE_DIRECTORY_DOMAIN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN_CONTROLLER")]
        ACTIVE_DIRECTORY_DOMAIN_CONTROLLER,

        [EnumMember(Value = "ACTIVE_DIRECTORY_FOREST")]
        ACTIVE_DIRECTORY_FOREST,

        [EnumMember(Value = "ATLASSIAN_SITE")]
        ATLASSIAN_SITE,

        [EnumMember(Value = "AWS_NATIVE_S3_BUCKET")]
        AWS_NATIVE_S3_BUCKET,

        [EnumMember(Value = "AZURE_AD_DIRECTORY")]
        AZURE_AD_DIRECTORY,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT")]
        AZURE_STORAGE_ACCOUNT,

        [EnumMember(Value = "AppBlueprint")]
        APP_BLUEPRINT,

        [EnumMember(Value = "ArchivalLocation")]
        ARCHIVAL_LOCATION,

        [EnumMember(Value = "AuthDomain")]
        AUTH_DOMAIN,

        [EnumMember(Value = "AwsAccount")]
        AWS_ACCOUNT,

        [EnumMember(Value = "AwsEventType")]
        AWS_EVENT_TYPE,

        [EnumMember(Value = "AwsNativeAccount")]
        AWS_NATIVE_ACCOUNT,

        [EnumMember(Value = "AwsNativeEbsVolume")]
        AWS_NATIVE_EBS_VOLUME,

        [EnumMember(Value = "AwsNativeEc2Instance")]
        AWS_NATIVE_EC2_INSTANCE,

        [EnumMember(Value = "AwsNativeRdsInstance")]
        AWS_NATIVE_RDS_INSTANCE,

        [EnumMember(Value = "AzureNativeDisk")]
        AZURE_NATIVE_DISK,

        [EnumMember(Value = "AzureNativeSubscription")]
        AZURE_NATIVE_SUBSCRIPTION,

        [EnumMember(Value = "AzureNativeVm")]
        AZURE_NATIVE_VM,

        [EnumMember(Value = "AzureSqlDatabase")]
        AZURE_SQL_DATABASE,

        [EnumMember(Value = "AzureSqlManagedInstance")]
        AZURE_SQL_MANAGED_INSTANCE,

        [EnumMember(Value = "Blueprint")]
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

        [EnumMember(Value = "CROSS_ACCOUNT_PAIR")]
        CROSS_ACCOUNT_PAIR,

        [EnumMember(Value = "CloudNativeTagRule")]
        CLOUD_NATIVE_TAG_RULE,

        [EnumMember(Value = "Cluster")]
        CLUSTER,

        [EnumMember(Value = "DATA_CENTER_CLOUD_ACCOUNT")]
        DATA_CENTER_CLOUD_ACCOUNT,

        [EnumMember(Value = "DB2_DATABASE")]
        DB2_DATABASE,

        [EnumMember(Value = "DB2_INSTANCE")]
        DB2_INSTANCE,

        [EnumMember(Value = "DataLocation")]
        DATA_LOCATION,

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

        [EnumMember(Value = "Ec2Instance")]
        EC2_INSTANCE,

        [EnumMember(Value = "FailoverClusterApp")]
        FAILOVER_CLUSTER_APP,

        [EnumMember(Value = "FederatedAccess")]
        FEDERATED_ACCESS,

        [EnumMember(Value = "GcpNativeDisk")]
        GCP_NATIVE_DISK,

        [EnumMember(Value = "GcpNativeGceInstance")]
        GCP_NATIVE_GCE_INSTANCE,

        [EnumMember(Value = "GcpNativeProject")]
        GCP_NATIVE_PROJECT,

        [EnumMember(Value = "Host")]
        HOST,

        [EnumMember(Value = "HostFailoverCluster")]
        HOST_FAILOVER_CLUSTER,

        [EnumMember(Value = "HypervScvmm")]
        HYPERV_SCVMM,

        [EnumMember(Value = "HypervServer")]
        HYPERV_SERVER,

        [EnumMember(Value = "HypervVm")]
        HYPERV_VM,

        [EnumMember(Value = "INTEL_FEED")]
        INTEL_FEED,

        [EnumMember(Value = "IpWhitelist")]
        IP_WHITELIST,

        [EnumMember(Value = "JIRA_PROJECT")]
        JIRA_PROJECT,

        [EnumMember(Value = "JIRA_SETTINGS")]
        JIRA_SETTINGS,

        [EnumMember(Value = "JobInstance")]
        JOB_INSTANCE,

        [EnumMember(Value = "K8S_CLUSTER")]
        K8S_CLUSTER,

        [EnumMember(Value = "K8S_PROTECTION_SET")]
        K8S_PROTECTION_SET,

        [EnumMember(Value = "Ldap")]
        LDAP,

        [EnumMember(Value = "LinuxFileset")]
        LINUX_FILESET,

        [EnumMember(Value = "LinuxHost")]
        LINUX_HOST,

        [EnumMember(Value = "M365_BACKUP_STORAGE_GROUP")]
        M365_BACKUP_STORAGE_GROUP,

        [EnumMember(Value = "M365_BACKUP_STORAGE_MAILBOX")]
        M365_BACKUP_STORAGE_MAILBOX,

        [EnumMember(Value = "M365_BACKUP_STORAGE_ONEDRIVE")]
        M365_BACKUP_STORAGE_ONEDRIVE,

        [EnumMember(Value = "M365_BACKUP_STORAGE_ORG")]
        M365_BACKUP_STORAGE_ORG,

        [EnumMember(Value = "M365_BACKUP_STORAGE_SITE")]
        M365_BACKUP_STORAGE_SITE,

        [EnumMember(Value = "MONGODB_SOURCE")]
        MONGODB_SOURCE,

        [EnumMember(Value = "MONGO_COLLECTION")]
        MONGO_COLLECTION,

        [EnumMember(Value = "MONGO_SOURCE")]
        MONGO_SOURCE,

        [EnumMember(Value = "MOSAIC_STORAGE_LOCATION")]
        MOSAIC_STORAGE_LOCATION,

        [EnumMember(Value = "MSSQL_MOUNT")]
        MSSQL_MOUNT,

        [EnumMember(Value = "MSSQL_OBJECT")]
        MSSQL_OBJECT,

        [EnumMember(Value = "ManagedVolume")]
        MANAGED_VOLUME,

        [EnumMember(Value = "Mssql")]
        MSSQL,

        [EnumMember(Value = "MssqlDatabase")]
        MSSQL_DATABASE,

        [EnumMember(Value = "NAS_FILESET")]
        NAS_FILESET,

        [EnumMember(Value = "NAS_SYSTEM")]
        NAS_SYSTEM,

        [EnumMember(Value = "NUTANIX_ERA")]
        NUTANIX_ERA,

        [EnumMember(Value = "NUTANIX_PRISM_CENTRAL")]
        NUTANIX_PRISM_CENTRAL,

        [EnumMember(Value = "NasHost")]
        NAS_HOST,

        [EnumMember(Value = "NutanixCluster")]
        NUTANIX_CLUSTER,

        [EnumMember(Value = "NutanixVm")]
        NUTANIX_VM,

        [EnumMember(Value = "O365Calendar")]
        O365_CALENDAR,

        [EnumMember(Value = "O365Group")]
        O365_GROUP,

        [EnumMember(Value = "O365Mailbox")]
        O365_MAILBOX,

        [EnumMember(Value = "O365Onedrive")]
        O365_ONEDRIVE,

        [EnumMember(Value = "O365Organization")]
        O365_ORGANIZATION,

        [EnumMember(Value = "O365SharepointDrive")]
        O365_SHAREPOINT_DRIVE,

        [EnumMember(Value = "O365SharepointList")]
        O365_SHAREPOINT_LIST,

        [EnumMember(Value = "O365Team")]
        O365_TEAM,

        [EnumMember(Value = "O365_SHAREPOINT_SITE")]
        O365_SHAREPOINT_SITE,

        [EnumMember(Value = "OAUTH_TOKEN")]
        OAUTH_TOKEN,

        [EnumMember(Value = "ORACLE_MOUNT")]
        ORACLE_MOUNT,

        [EnumMember(Value = "ORGANIZATION")]
        ORGANIZATION,

        [EnumMember(Value = "OracleDb")]
        ORACLE_DB,

        [EnumMember(Value = "OracleHost")]
        ORACLE_HOST,

        [EnumMember(Value = "OracleRac")]
        ORACLE_RAC,

        [EnumMember(Value = "POSTGRES_DB_CLUSTER")]
        POSTGRES_DB_CLUSTER,

        [EnumMember(Value = "PublicCloudMachineInstance")]
        PUBLIC_CLOUD_MACHINE_INSTANCE,

        [EnumMember(Value = "REPLICATION_PAIR")]
        REPLICATION_PAIR,

        [EnumMember(Value = "SapHanaDb")]
        SAP_HANA_DB,

        [EnumMember(Value = "SapHanaSystem")]
        SAP_HANA_SYSTEM,

        [EnumMember(Value = "ShareFileset")]
        SHARE_FILESET,

        [EnumMember(Value = "Sla")]
        SLA,

        [EnumMember(Value = "SlaDomain")]
        SLA_DOMAIN,

        [EnumMember(Value = "SmbDomain")]
        SMB_DOMAIN,

        [EnumMember(Value = "Snapshot")]
        SNAPSHOT,

        [EnumMember(Value = "StorageArray")]
        STORAGE_ARRAY,

        [EnumMember(Value = "StorageArrayVolumeGroup")]
        STORAGE_ARRAY_VOLUME_GROUP,

        [EnumMember(Value = "StorageSettings")]
        STORAGE_SETTINGS,

        [EnumMember(Value = "Storm")]
        STORM,

        [EnumMember(Value = "SupportTunnel")]
        SUPPORT_TUNNEL,

        [EnumMember(Value = "SystemPreference")]
        SYSTEM_PREFERENCE,

        [EnumMember(Value = "TPR_CONFIG")]
        TPR_CONFIG,

        [EnumMember(Value = "TPR_POLICY")]
        TPR_POLICY,

        [EnumMember(Value = "TPR_REQUEST")]
        TPR_REQUEST,

        [EnumMember(Value = "Unknown")]
        UNKNOWN,

        [EnumMember(Value = "Upgrade")]
        UPGRADE,

        [EnumMember(Value = "User")]
        USER,

        [EnumMember(Value = "UserActionAudit")]
        USER_ACTION_AUDIT,

        [EnumMember(Value = "UserGroup")]
        USER_GROUP,

        [EnumMember(Value = "UserRole")]
        USER_ROLE,

        [EnumMember(Value = "VMWARE_COMPUTE_CLUSTER")]
        VMWARE_COMPUTE_CLUSTER,

        [EnumMember(Value = "Vcd")]
        VCD,

        [EnumMember(Value = "VcdVapp")]
        VCD_VAPP,

        [EnumMember(Value = "Vcenter")]
        VCENTER,

        [EnumMember(Value = "VmwareMount")]
        VMWARE_MOUNT,

        [EnumMember(Value = "VmwareVm")]
        VMWARE_VM,

        [EnumMember(Value = "VolumeGroup")]
        VOLUME_GROUP,

        [EnumMember(Value = "WindowsFileset")]
        WINDOWS_FILESET,

        [EnumMember(Value = "WindowsHost")]
        WINDOWS_HOST


    } // enum UserAuditObjectTypeEnum

} // namespace RubrikSecurityCloud.Types