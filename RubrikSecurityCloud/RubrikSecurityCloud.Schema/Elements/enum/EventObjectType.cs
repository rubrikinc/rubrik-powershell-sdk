// EventObjectType.cs
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
    public enum EventObjectType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN")]
        ACTIVE_DIRECTORY_DOMAIN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN_CONTROLLER")]
        ACTIVE_DIRECTORY_DOMAIN_CONTROLLER,

        [EnumMember(Value = "ACTIVE_DIRECTORY_FOREST")]
        ACTIVE_DIRECTORY_FOREST,

        [EnumMember(Value = "APP_BLUEPRINT")]
        APP_BLUEPRINT,

        [EnumMember(Value = "APP_FLOWS")]
        APP_FLOWS,

        [EnumMember(Value = "ATLASSIAN_SITE")]
        ATLASSIAN_SITE,

        [EnumMember(Value = "AWS_ACCOUNT")]
        AWS_ACCOUNT,

        [EnumMember(Value = "AWS_EVENT_TYPE")]
        AWS_EVENT_TYPE,

        [EnumMember(Value = "AWS_NATIVE_ACCOUNT")]
        AWS_NATIVE_ACCOUNT,

        [EnumMember(Value = "AWS_NATIVE_DYNAMODB_TABLE")]
        AWS_NATIVE_DYNAMODB_TABLE,

        [EnumMember(Value = "AWS_NATIVE_EBS_VOLUME")]
        AWS_NATIVE_EBS_VOLUME,

        [EnumMember(Value = "AWS_NATIVE_EC2_INSTANCE")]
        AWS_NATIVE_EC2_INSTANCE,

        [EnumMember(Value = "AWS_NATIVE_RDS_INSTANCE")]
        AWS_NATIVE_RDS_INSTANCE,

        [EnumMember(Value = "AWS_NATIVE_REGION")]
        AWS_NATIVE_REGION,

        [EnumMember(Value = "AWS_NATIVE_S3_BUCKET")]
        AWS_NATIVE_S3_BUCKET,

        [EnumMember(Value = "AZURE_AD_DIRECTORY")]
        AZURE_AD_DIRECTORY,

        [EnumMember(Value = "AZURE_DEVOPS_ORGANIZATION")]
        AZURE_DEVOPS_ORGANIZATION,

        [EnumMember(Value = "AZURE_DEVOPS_PROJECT")]
        AZURE_DEVOPS_PROJECT,

        [EnumMember(Value = "AZURE_DEVOPS_REPOSITORY")]
        AZURE_DEVOPS_REPOSITORY,

        [EnumMember(Value = "AZURE_NATIVE_DISK")]
        AZURE_NATIVE_DISK,

        [EnumMember(Value = "AZURE_NATIVE_REGION")]
        AZURE_NATIVE_REGION,

        [EnumMember(Value = "AZURE_NATIVE_RESOURCE_GROUP")]
        AZURE_NATIVE_RESOURCE_GROUP,

        [EnumMember(Value = "AZURE_NATIVE_SUBSCRIPTION")]
        AZURE_NATIVE_SUBSCRIPTION,

        [EnumMember(Value = "AZURE_NATIVE_VM")]
        AZURE_NATIVE_VM,

        [EnumMember(Value = "AZURE_SQL_DATABASE")]
        AZURE_SQL_DATABASE,

        [EnumMember(Value = "AZURE_SQL_DATABASE_SERVER")]
        AZURE_SQL_DATABASE_SERVER,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE")]
        AZURE_SQL_MANAGED_INSTANCE,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE_DATABASE")]
        AZURE_SQL_MANAGED_INSTANCE_DATABASE,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT")]
        AZURE_STORAGE_ACCOUNT,

        [EnumMember(Value = "CAPACITY_BUNDLE")]
        CAPACITY_BUNDLE,

        [EnumMember(Value = "CASSANDRA_COLUMN_FAMILY")]
        CASSANDRA_COLUMN_FAMILY,

        [EnumMember(Value = "CASSANDRA_KEYSPACE")]
        CASSANDRA_KEYSPACE,

        [EnumMember(Value = "CASSANDRA_SOURCE")]
        CASSANDRA_SOURCE,

        [EnumMember(Value = "CERTIFICATE")]
        CERTIFICATE,

        [EnumMember(Value = "CERTIFICATE_MANAGEMENT")]
        CERTIFICATE_MANAGEMENT,

        [EnumMember(Value = "CLOUD_ACCOUNT")]
        CLOUD_ACCOUNT,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_BUCKET")]
        CLOUD_DIRECT_NAS_BUCKET,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_EXPORT")]
        CLOUD_DIRECT_NAS_EXPORT,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_NAMESPACE")]
        CLOUD_DIRECT_NAS_NAMESPACE,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_SHARE")]
        CLOUD_DIRECT_NAS_SHARE,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_SYSTEM")]
        CLOUD_DIRECT_NAS_SYSTEM,

        [EnumMember(Value = "CLUSTER")]
        CLUSTER,

        [EnumMember(Value = "COMPUTE_INSTANCE")]
        COMPUTE_INSTANCE,

        [EnumMember(Value = "CONFLUENCE_SPACE")]
        CONFLUENCE_SPACE,

        [EnumMember(Value = "CROSS_ACCOUNT_PAIR")]
        CROSS_ACCOUNT_PAIR,

        [EnumMember(Value = "CROWDSTRIKE_INTEGRATION")]
        CROWDSTRIKE_INTEGRATION,

        [EnumMember(Value = "D365_DATAVERSE_TABLE")]
        D365_DATAVERSE_TABLE,

        [EnumMember(Value = "D365_METADATA")]
        D365_METADATA,

        [EnumMember(Value = "D365_ORGANIZATION")]
        D365_ORGANIZATION,

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

        [EnumMember(Value = "ENVOY")]
        ENVOY,

        [EnumMember(Value = "EXCHANGE_DATABASE")]
        EXCHANGE_DATABASE,

        [EnumMember(Value = "EXOCOMPUTE")]
        EXOCOMPUTE,

        [EnumMember(Value = "FAILOVER_CLUSTER_APP")]
        FAILOVER_CLUSTER_APP,

        [EnumMember(Value = "GCP_CLOUD_SQL_INSTANCE")]
        GCP_CLOUD_SQL_INSTANCE,

        [EnumMember(Value = "GCP_NATIVE_DISK")]
        GCP_NATIVE_DISK,

        [EnumMember(Value = "GCP_NATIVE_GCE_INSTANCE")]
        GCP_NATIVE_GCE_INSTANCE,

        [EnumMember(Value = "GCP_NATIVE_PROJECT")]
        GCP_NATIVE_PROJECT,

        [EnumMember(Value = "GITHUB_ORGANIZATION")]
        GITHUB_ORGANIZATION,

        [EnumMember(Value = "GITHUB_REPOSITORY")]
        GITHUB_REPOSITORY,

        [EnumMember(Value = "GOOGLE_WORKSPACE_ORGANIZATION")]
        GOOGLE_WORKSPACE_ORGANIZATION,

        [EnumMember(Value = "GOOGLE_WORKSPACE_ORG_UNIT")]
        GOOGLE_WORKSPACE_ORG_UNIT,

        [EnumMember(Value = "GOOGLE_WORKSPACE_SHARED_DRIVE")]
        GOOGLE_WORKSPACE_SHARED_DRIVE,

        [EnumMember(Value = "GOOGLE_WORKSPACE_USER")]
        GOOGLE_WORKSPACE_USER,

        [EnumMember(Value = "GOOGLE_WORKSPACE_USER_DRIVE")]
        GOOGLE_WORKSPACE_USER_DRIVE,

        [EnumMember(Value = "GOOGLE_WORKSPACE_USER_MAILBOX")]
        GOOGLE_WORKSPACE_USER_MAILBOX,

        [EnumMember(Value = "HIGH_AVAILABILITY_POLICY")]
        HIGH_AVAILABILITY_POLICY,

        [EnumMember(Value = "HOST")]
        HOST,

        [EnumMember(Value = "HYPERV_VM")]
        HYPERV_VM,

        [EnumMember(Value = "IDP_AWS")]
        IDP_AWS,

        [EnumMember(Value = "IDP_ENTRA_ID")]
        IDP_ENTRA_ID,

        [EnumMember(Value = "IDP_LOCAL_AD")]
        IDP_LOCAL_AD,

        [EnumMember(Value = "IDP_ON_PREM_AD")]
        IDP_ON_PREM_AD,

        [EnumMember(Value = "IDP_SHAREPOINT")]
        IDP_SHAREPOINT,

        [EnumMember(Value = "INFORMIX_INSTANCE")]
        INFORMIX_INSTANCE,

        [EnumMember(Value = "INTEL_FEED")]
        INTEL_FEED,

        [EnumMember(Value = "JIRA_PROJECT")]
        JIRA_PROJECT,

        [EnumMember(Value = "JIRA_SETTINGS")]
        JIRA_SETTINGS,

        [EnumMember(Value = "JOB_INSTANCE")]
        JOB_INSTANCE,

        [EnumMember(Value = "K8S_CLUSTER")]
        K8S_CLUSTER,

        [EnumMember(Value = "K8S_LABEL")]
        K8S_LABEL,

        [EnumMember(Value = "K8S_NAMESPACE_V2")]
        K8S_NAMESPACE_V2,

        [EnumMember(Value = "K8S_PROTECTION_SET")]
        K8S_PROTECTION_SET,

        [EnumMember(Value = "K8S_VIRTUAL_MACHINE")]
        K8S_VIRTUAL_MACHINE,

        [EnumMember(Value = "KMS_KEY_VAULT")]
        KMS_KEY_VAULT,

        [EnumMember(Value = "KUPR_CLUSTER")]
        KUPR_CLUSTER,

        [EnumMember(Value = "KUPR_NAMESPACE")]
        KUPR_NAMESPACE,

        [EnumMember(Value = "LDAP")]
        LDAP,

        [EnumMember(Value = "LINUX_FILESET")]
        LINUX_FILESET,

        [EnumMember(Value = "LINUX_HOST")]
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

        [EnumMember(Value = "MANAGED_VOLUME")]
        MANAGED_VOLUME,

        [EnumMember(Value = "MONGODB_COLLECTION")]
        MONGODB_COLLECTION,

        [EnumMember(Value = "MONGODB_DATABASE")]
        MONGODB_DATABASE,

        [EnumMember(Value = "MONGODB_SOURCE")]
        MONGODB_SOURCE,

        [EnumMember(Value = "MONGO_COLLECTION")]
        MONGO_COLLECTION,

        [EnumMember(Value = "MONGO_DATABASE")]
        MONGO_DATABASE,

        [EnumMember(Value = "MONGO_SOURCE")]
        MONGO_SOURCE,

        [EnumMember(Value = "MSSQL")]
        MSSQL,

        [EnumMember(Value = "MYSQLDB_INSTANCE")]
        MYSQLDB_INSTANCE,

        [EnumMember(Value = "NAS_FILESET")]
        NAS_FILESET,

        [EnumMember(Value = "NAS_HOST")]
        NAS_HOST,

        [EnumMember(Value = "NAS_SYSTEM")]
        NAS_SYSTEM,

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

        [EnumMember(Value = "O365_SHARE_POINT_DRIVE")]
        O365_SHARE_POINT_DRIVE,

        [EnumMember(Value = "O365_SHARE_POINT_LIST")]
        O365_SHARE_POINT_LIST,

        [EnumMember(Value = "O365_SITE")]
        O365_SITE,

        [EnumMember(Value = "O365_TEAM")]
        O365_TEAM,

        [EnumMember(Value = "OAUTH_TOKEN")]
        OAUTH_TOKEN,

        [EnumMember(Value = "OBJECT_PROTECTION")]
        OBJECT_PROTECTION,

        [EnumMember(Value = "OBJECT_TYPE_AUTH_DOMAIN")]
        OBJECT_TYPE_AUTH_DOMAIN,

        [EnumMember(Value = "OBJECT_TYPE_CLOUD_NATIVE_VIRTUAL_MACHINE")]
        OBJECT_TYPE_CLOUD_NATIVE_VIRTUAL_MACHINE,

        [EnumMember(Value = "OBJECT_TYPE_CLOUD_NATIVE_VM")]
        OBJECT_TYPE_CLOUD_NATIVE_VM,

        [EnumMember(Value = "OBJECT_TYPE_HDFS")]
        OBJECT_TYPE_HDFS,

        [EnumMember(Value = "OBJECT_TYPE_HYPERV_SCVMM")]
        OBJECT_TYPE_HYPERV_SCVMM,

        [EnumMember(Value = "OBJECT_TYPE_HYPERV_SERVER")]
        OBJECT_TYPE_HYPERV_SERVER,

        [EnumMember(Value = "OBJECT_TYPE_NUTANIX_CLUSTER")]
        OBJECT_TYPE_NUTANIX_CLUSTER,

        [EnumMember(Value = "OBJECT_TYPE_NUTANIX_ERA")]
        OBJECT_TYPE_NUTANIX_ERA,

        [EnumMember(Value = "OBJECT_TYPE_NUTANIX_PRISM_CENTRAL")]
        OBJECT_TYPE_NUTANIX_PRISM_CENTRAL,

        [EnumMember(Value = "OBJECT_TYPE_STORAGE_ARRAY")]
        OBJECT_TYPE_STORAGE_ARRAY,

        [EnumMember(Value = "OBJECT_TYPE_UPGRADE")]
        OBJECT_TYPE_UPGRADE,

        [EnumMember(Value = "OBJECT_TYPE_VCD")]
        OBJECT_TYPE_VCD,

        [EnumMember(Value = "OBJECT_TYPE_VCENTER")]
        OBJECT_TYPE_VCENTER,

        [EnumMember(Value = "OBJECT_TYPE_VOLUME_GROUP")]
        OBJECT_TYPE_VOLUME_GROUP,

        [EnumMember(Value = "OKTA_TENANT")]
        OKTA_TENANT,

        [EnumMember(Value = "OLVM_COMPUTE_CLUSTER")]
        OLVM_COMPUTE_CLUSTER,

        [EnumMember(Value = "OLVM_DATACENTER")]
        OLVM_DATACENTER,

        [EnumMember(Value = "OLVM_HOST")]
        OLVM_HOST,

        [EnumMember(Value = "OLVM_MANAGER")]
        OLVM_MANAGER,

        [EnumMember(Value = "OLVM_VIRTUAL_MACHINE")]
        OLVM_VIRTUAL_MACHINE,

        [EnumMember(Value = "OPENSTACK_ENVIRONMENT")]
        OPENSTACK_ENVIRONMENT,

        [EnumMember(Value = "OPENSTACK_VIRTUAL_MACHINE")]
        OPENSTACK_VIRTUAL_MACHINE,

        [EnumMember(Value = "ORACLE")]
        ORACLE,

        [EnumMember(Value = "ORACLE_DB")]
        ORACLE_DB,

        [EnumMember(Value = "ORACLE_HOST")]
        ORACLE_HOST,

        [EnumMember(Value = "ORACLE_RAC")]
        ORACLE_RAC,

        [EnumMember(Value = "ORGANIZATION")]
        ORGANIZATION,

        [EnumMember(Value = "ORION_THREAT_HUNT")]
        ORION_THREAT_HUNT,

        [EnumMember(Value = "POSTGRES_DB_CLUSTER")]
        POSTGRES_DB_CLUSTER,

        [EnumMember(Value = "PRINCIPAL_ACCESS_POLICY")]
        PRINCIPAL_ACCESS_POLICY,

        [EnumMember(Value = "PRINCIPAL_ASSUMABLE_IDENTITY")]
        PRINCIPAL_ASSUMABLE_IDENTITY,

        [EnumMember(Value = "PRINCIPAL_ATTRIBUTE_SCHEMA")]
        PRINCIPAL_ATTRIBUTE_SCHEMA,

        [EnumMember(Value = "PRINCIPAL_CLASS_SCHEMA")]
        PRINCIPAL_CLASS_SCHEMA,

        [EnumMember(Value = "PRINCIPAL_COMPUTER")]
        PRINCIPAL_COMPUTER,

        [EnumMember(Value = "PRINCIPAL_CONTACT")]
        PRINCIPAL_CONTACT,

        [EnumMember(Value = "PRINCIPAL_CONTAINER")]
        PRINCIPAL_CONTAINER,

        [EnumMember(Value = "PRINCIPAL_DOMAIN_DNS")]
        PRINCIPAL_DOMAIN_DNS,

        [EnumMember(Value = "PRINCIPAL_EXTERNAL_ACCOUNT")]
        PRINCIPAL_EXTERNAL_ACCOUNT,

        [EnumMember(Value = "PRINCIPAL_EXTERNAL_PRINCIPAL")]
        PRINCIPAL_EXTERNAL_PRINCIPAL,

        [EnumMember(Value = "PRINCIPAL_FOREIGN_SECURITY_PRINCIPAL")]
        PRINCIPAL_FOREIGN_SECURITY_PRINCIPAL,

        [EnumMember(Value = "PRINCIPAL_GPO")]
        PRINCIPAL_GPO,

        [EnumMember(Value = "PRINCIPAL_GROUP")]
        PRINCIPAL_GROUP,

        [EnumMember(Value = "PRINCIPAL_INFRASTRUCTURE_UPDATE")]
        PRINCIPAL_INFRASTRUCTURE_UPDATE,

        [EnumMember(Value = "PRINCIPAL_INTER_SITE_TRANSPORT")]
        PRINCIPAL_INTER_SITE_TRANSPORT,

        [EnumMember(Value = "PRINCIPAL_INTER_SITE_TRANSPORT_CONTAINER")]
        PRINCIPAL_INTER_SITE_TRANSPORT_CONTAINER,

        [EnumMember(Value = "PRINCIPAL_LICENSING_SITE_SETTINGS")]
        PRINCIPAL_LICENSING_SITE_SETTINGS,

        [EnumMember(Value = "PRINCIPAL_MSDS_QUOTA_CONTAINER")]
        PRINCIPAL_MSDS_QUOTA_CONTAINER,

        [EnumMember(Value = "PRINCIPAL_MSDS_QUOTA_CONTROL")]
        PRINCIPAL_MSDS_QUOTA_CONTROL,

        [EnumMember(Value = "PRINCIPAL_NAMED_LOCATION")]
        PRINCIPAL_NAMED_LOCATION,

        [EnumMember(Value = "PRINCIPAL_NTDS_SITE_SETTINGS")]
        PRINCIPAL_NTDS_SITE_SETTINGS,

        [EnumMember(Value = "PRINCIPAL_ORG_WIDE")]
        PRINCIPAL_ORG_WIDE,

        [EnumMember(Value = "PRINCIPAL_OU")]
        PRINCIPAL_OU,

        [EnumMember(Value = "PRINCIPAL_PASSWORD_SETTINGS")]
        PRINCIPAL_PASSWORD_SETTINGS,

        [EnumMember(Value = "PRINCIPAL_PASSWORD_SETTINGS_CONTAINER")]
        PRINCIPAL_PASSWORD_SETTINGS_CONTAINER,

        [EnumMember(Value = "PRINCIPAL_PRINT_QUEUE")]
        PRINCIPAL_PRINT_QUEUE,

        [EnumMember(Value = "PRINCIPAL_PUBLIC")]
        PRINCIPAL_PUBLIC,

        [EnumMember(Value = "PRINCIPAL_RID_MANAGER")]
        PRINCIPAL_RID_MANAGER,

        [EnumMember(Value = "PRINCIPAL_SERVER")]
        PRINCIPAL_SERVER,

        [EnumMember(Value = "PRINCIPAL_SERVERS_CONTAINER")]
        PRINCIPAL_SERVERS_CONTAINER,

        [EnumMember(Value = "PRINCIPAL_SERVICE_ACCOUNT")]
        PRINCIPAL_SERVICE_ACCOUNT,

        [EnumMember(Value = "PRINCIPAL_SITE")]
        PRINCIPAL_SITE,

        [EnumMember(Value = "PRINCIPAL_SITE_LINK")]
        PRINCIPAL_SITE_LINK,

        [EnumMember(Value = "PRINCIPAL_SITE_LINK_BRIDGE")]
        PRINCIPAL_SITE_LINK_BRIDGE,

        [EnumMember(Value = "PRINCIPAL_SUBNET")]
        PRINCIPAL_SUBNET,

        [EnumMember(Value = "PRINCIPAL_SUBNET_CONTAINER")]
        PRINCIPAL_SUBNET_CONTAINER,

        [EnumMember(Value = "PRINCIPAL_TRUSTED_DOMAIN")]
        PRINCIPAL_TRUSTED_DOMAIN,

        [EnumMember(Value = "PRINCIPAL_VOLUME")]
        PRINCIPAL_VOLUME,

        [EnumMember(Value = "PROXMOX_CLUSTER")]
        PROXMOX_CLUSTER,

        [EnumMember(Value = "PROXMOX_ENVIRONMENT")]
        PROXMOX_ENVIRONMENT,

        [EnumMember(Value = "PROXMOX_NODE")]
        PROXMOX_NODE,

        [EnumMember(Value = "PROXMOX_VIRTUAL_MACHINE")]
        PROXMOX_VIRTUAL_MACHINE,

        [EnumMember(Value = "PUBLIC_CLOUD_MACHINE_INSTANCE")]
        PUBLIC_CLOUD_MACHINE_INSTANCE,

        [EnumMember(Value = "REPLICATION_PAIR")]
        REPLICATION_PAIR,

        [EnumMember(Value = "RSC_CHILD_ACCOUNT")]
        RSC_CHILD_ACCOUNT,

        [EnumMember(Value = "RUBRIK_SAAS_ACCOUNT")]
        RUBRIK_SAAS_ACCOUNT,

        [EnumMember(Value = "RUBRIK_SAAS_EBS_VOLUME")]
        RUBRIK_SAAS_EBS_VOLUME,

        [EnumMember(Value = "RUBRIK_SAAS_EC2_INSTANCE")]
        RUBRIK_SAAS_EC2_INSTANCE,

        [EnumMember(Value = "SALESFORCE_METADATA")]
        SALESFORCE_METADATA,

        [EnumMember(Value = "SALESFORCE_OBJECT")]
        SALESFORCE_OBJECT,

        [EnumMember(Value = "SALESFORCE_ORGANIZATION")]
        SALESFORCE_ORGANIZATION,

        [EnumMember(Value = "SAML_SSO")]
        SAML_SSO,

        [EnumMember(Value = "SAP_HANA_DB")]
        SAP_HANA_DB,

        [EnumMember(Value = "SAP_HANA_SYSTEM")]
        SAP_HANA_SYSTEM,

        [EnumMember(Value = "SHARE_FILESET")]
        SHARE_FILESET,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN,

        [EnumMember(Value = "SMB_DOMAIN")]
        SMB_DOMAIN,

        [EnumMember(Value = "SNAP_MIRROR_CLOUD")]
        SNAP_MIRROR_CLOUD,

        [EnumMember(Value = "STORAGE_ARRAY_VOLUME_GROUP")]
        STORAGE_ARRAY_VOLUME_GROUP,

        [EnumMember(Value = "STORAGE_LOCATION")]
        STORAGE_LOCATION,

        [EnumMember(Value = "STORM")]
        STORM,

        [EnumMember(Value = "SUPPORT_BUNDLE")]
        SUPPORT_BUNDLE,

        [EnumMember(Value = "UNKNOWN_EVENT_OBJECT_TYPE")]
        UNKNOWN_EVENT_OBJECT_TYPE,

        [EnumMember(Value = "USER")]
        USER,

        [EnumMember(Value = "VCD_VAPP")]
        VCD_VAPP,

        [EnumMember(Value = "VMWARE_COMPUTE_CLUSTER")]
        VMWARE_COMPUTE_CLUSTER,

        [EnumMember(Value = "VMWARE_HOST")]
        VMWARE_HOST,

        [EnumMember(Value = "VMWARE_VM")]
        VMWARE_VM,

        [EnumMember(Value = "WEBHOOK")]
        WEBHOOK,

        [EnumMember(Value = "WINDOWS_FILESET")]
        WINDOWS_FILESET,

        [EnumMember(Value = "WINDOWS_HOST")]
        WINDOWS_HOST


    } // enum EventObjectType

} // namespace RubrikSecurityCloud.Types