// ActivityObjectTypeEnum.cs
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
    public enum ActivityObjectTypeEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN")]
        ACTIVE_DIRECTORY_DOMAIN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN_CONTROLLER")]
        ACTIVE_DIRECTORY_DOMAIN_CONTROLLER,

        [EnumMember(Value = "ACTIVE_DIRECTORY_FOREST")]
        ACTIVE_DIRECTORY_FOREST,

        [EnumMember(Value = "ATLASSIAN_SITE")]
        ATLASSIAN_SITE,

        [EnumMember(Value = "AWS_NATIVE_DYNAMODB_TABLE")]
        AWS_NATIVE_DYNAMODB_TABLE,

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

        [EnumMember(Value = "AZURE_NATIVE_REGION")]
        AZURE_NATIVE_REGION,

        [EnumMember(Value = "AZURE_NATIVE_RESOURCE_GROUP")]
        AZURE_NATIVE_RESOURCE_GROUP,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT")]
        AZURE_STORAGE_ACCOUNT,

        [EnumMember(Value = "AppBlueprint")]
        APP_BLUEPRINT,

        [EnumMember(Value = "AppFlows")]
        APP_FLOWS,

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

        [EnumMember(Value = "AzureSqlDatabaseServer")]
        AZURE_SQL_DATABASE_SERVER,

        [EnumMember(Value = "AzureSqlManagedInstance")]
        AZURE_SQL_MANAGED_INSTANCE,

        [EnumMember(Value = "AzureSqlManagedInstanceDatabase")]
        AZURE_SQL_MANAGED_INSTANCE_DATABASE,

        [EnumMember(Value = "CASSANDRA_COLUMN_FAMILY")]
        CASSANDRA_COLUMN_FAMILY,

        [EnumMember(Value = "CASSANDRA_KEYSPACE")]
        CASSANDRA_KEYSPACE,

        [EnumMember(Value = "CASSANDRA_SOURCE")]
        CASSANDRA_SOURCE,

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

        [EnumMember(Value = "CONFLUENCE_SPACE")]
        CONFLUENCE_SPACE,

        [EnumMember(Value = "CROSS_ACCOUNT_PAIR")]
        CROSS_ACCOUNT_PAIR,

        [EnumMember(Value = "CROWDSTRIKE_INTEGRATION")]
        CROWDSTRIKE_INTEGRATION,

        [EnumMember(Value = "CapacityBundle")]
        CAPACITY_BUNDLE,

        [EnumMember(Value = "Certificate")]
        CERTIFICATE,

        [EnumMember(Value = "CloudNativeVirtualMachine")]
        CLOUD_NATIVE_VIRTUAL_MACHINE,

        [EnumMember(Value = "CloudNativeVm")]
        CLOUD_NATIVE_VM,

        [EnumMember(Value = "Cluster")]
        CLUSTER,

        [EnumMember(Value = "ComputeInstance")]
        COMPUTE_INSTANCE,

        [EnumMember(Value = "D365_DATAVERSE_TABLE")]
        D365_DATAVERSE_TABLE,

        [EnumMember(Value = "D365_METADATA")]
        D365_METADATA,

        [EnumMember(Value = "D365_ORGANIZATION")]
        D365_ORGANIZATION,

        [EnumMember(Value = "DataLocation")]
        DATA_LOCATION,

        [EnumMember(Value = "Db2Database")]
        DB2_DATABASE,

        [EnumMember(Value = "Db2Instance")]
        DB2_INSTANCE,

        [EnumMember(Value = "ENCRYPTION_MANAGEMENT")]
        ENCRYPTION_MANAGEMENT,

        [EnumMember(Value = "Ec2Instance")]
        EC2_INSTANCE,

        [EnumMember(Value = "Envoy")]
        ENVOY,

        [EnumMember(Value = "ExchangeDatabase")]
        EXCHANGE_DATABASE,

        [EnumMember(Value = "Exocompute")]
        EXOCOMPUTE,

        [EnumMember(Value = "FailoverClusterApp")]
        FAILOVER_CLUSTER_APP,

        [EnumMember(Value = "GCP_CLOUD_SQL_INSTANCE")]
        GCP_CLOUD_SQL_INSTANCE,

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

        [EnumMember(Value = "GcpNativeDisk")]
        GCP_NATIVE_DISK,

        [EnumMember(Value = "GcpNativeGceInstance")]
        GCP_NATIVE_GCE_INSTANCE,

        [EnumMember(Value = "GcpNativeProject")]
        GCP_NATIVE_PROJECT,

        [EnumMember(Value = "Hdfs")]
        HDFS,

        [EnumMember(Value = "Host")]
        HOST,

        [EnumMember(Value = "HypervScvmm")]
        HYPERV_SCVMM,

        [EnumMember(Value = "HypervServer")]
        HYPERV_SERVER,

        [EnumMember(Value = "HypervVm")]
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

        [EnumMember(Value = "JobInstance")]
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

        [EnumMember(Value = "KuprCluster")]
        KUPR_CLUSTER,

        [EnumMember(Value = "KuprNamespace")]
        KUPR_NAMESPACE,

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

        [EnumMember(Value = "MYSQLDB_INSTANCE")]
        MYSQLDB_INSTANCE,

        [EnumMember(Value = "ManagedVolume")]
        MANAGED_VOLUME,

        [EnumMember(Value = "Mssql")]
        MSSQL,

        [EnumMember(Value = "NAS_FILESET")]
        NAS_FILESET,

        [EnumMember(Value = "NUTANIX_ERA")]
        NUTANIX_ERA,

        [EnumMember(Value = "NUTANIX_PRISM_CENTRAL")]
        NUTANIX_PRISM_CENTRAL,

        [EnumMember(Value = "NasHost")]
        NAS_HOST,

        [EnumMember(Value = "NasSystem")]
        NAS_SYSTEM,

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

        [EnumMember(Value = "O365SharePointDrive")]
        O365_SHARE_POINT_DRIVE,

        [EnumMember(Value = "O365SharePointList")]
        O365_SHARE_POINT_LIST,

        [EnumMember(Value = "O365Site")]
        O365_SITE,

        [EnumMember(Value = "O365Team")]
        O365_TEAM,

        [EnumMember(Value = "OAUTH_TOKEN")]
        OAUTH_TOKEN,

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

        [EnumMember(Value = "ORGANIZATION")]
        ORGANIZATION,

        [EnumMember(Value = "ORION_THREAT_HUNT")]
        ORION_THREAT_HUNT,

        [EnumMember(Value = "ObjectProtection")]
        OBJECT_PROTECTION,

        [EnumMember(Value = "Oracle")]
        ORACLE,

        [EnumMember(Value = "OracleDb")]
        ORACLE_DB,

        [EnumMember(Value = "OracleHost")]
        ORACLE_HOST,

        [EnumMember(Value = "OracleRac")]
        ORACLE_RAC,

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

        [EnumMember(Value = "PolarisAccount")]
        POLARIS_ACCOUNT,

        [EnumMember(Value = "PublicCloudMachineInstance")]
        PUBLIC_CLOUD_MACHINE_INSTANCE,

        [EnumMember(Value = "REPLICATION_PAIR")]
        REPLICATION_PAIR,

        [EnumMember(Value = "RubrikEbsVolume")]
        RUBRIK_EBS_VOLUME,

        [EnumMember(Value = "RubrikEc2Instance")]
        RUBRIK_EC2_INSTANCE,

        [EnumMember(Value = "SALESFORCE_METADATA")]
        SALESFORCE_METADATA,

        [EnumMember(Value = "SALESFORCE_OBJECT")]
        SALESFORCE_OBJECT,

        [EnumMember(Value = "SALESFORCE_ORGANIZATION")]
        SALESFORCE_ORGANIZATION,

        [EnumMember(Value = "SamlSso")]
        SAML_SSO,

        [EnumMember(Value = "SapHanaDb")]
        SAP_HANA_DB,

        [EnumMember(Value = "SapHanaSystem")]
        SAP_HANA_SYSTEM,

        [EnumMember(Value = "ShareFileset")]
        SHARE_FILESET,

        [EnumMember(Value = "SlaDomain")]
        SLA_DOMAIN,

        [EnumMember(Value = "SmbDomain")]
        SMB_DOMAIN,

        [EnumMember(Value = "SnapMirrorCloud")]
        SNAP_MIRROR_CLOUD,

        [EnumMember(Value = "StorageArray")]
        STORAGE_ARRAY,

        [EnumMember(Value = "StorageArrayVolumeGroup")]
        STORAGE_ARRAY_VOLUME_GROUP,

        [EnumMember(Value = "StorageLocation")]
        STORAGE_LOCATION,

        [EnumMember(Value = "Storm")]
        STORM,

        [EnumMember(Value = "SupportBundle")]
        SUPPORT_BUNDLE,

        [EnumMember(Value = "UnknownObjectType")]
        UNKNOWN_OBJECT_TYPE,

        [EnumMember(Value = "Upgrade")]
        UPGRADE,

        [EnumMember(Value = "User")]
        USER,

        [EnumMember(Value = "VMWARE_HOST")]
        VMWARE_HOST,

        [EnumMember(Value = "Vcd")]
        VCD,

        [EnumMember(Value = "VcdVapp")]
        VCD_VAPP,

        [EnumMember(Value = "Vcenter")]
        VCENTER,

        [EnumMember(Value = "VmwareComputeCluster")]
        VMWARE_COMPUTE_CLUSTER,

        [EnumMember(Value = "VmwareVm")]
        VMWARE_VM,

        [EnumMember(Value = "VolumeGroup")]
        VOLUME_GROUP,

        [EnumMember(Value = "WEBHOOK")]
        WEBHOOK,

        [EnumMember(Value = "WindowsFileset")]
        WINDOWS_FILESET,

        [EnumMember(Value = "WindowsHost")]
        WINDOWS_HOST


    } // enum ActivityObjectTypeEnum

} // namespace RubrikSecurityCloud.Types