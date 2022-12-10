// ActivityObjectTypeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    public enum ActivityObjectTypeEnum
    {
        [EnumMember(Value = "AWS_NATIVE_S3_BUCKET")]
        AWS_NATIVE_S3_BUCKET,

        [EnumMember(Value = "AZURE_AD_TENANT")]
        AZURE_AD_TENANT,

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

        [EnumMember(Value = "CLOUD_DIRECT_NAS_EXPORT")]
        CLOUD_DIRECT_NAS_EXPORT,

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

        [EnumMember(Value = "JobInstance")]
        JOB_INSTANCE,

        [EnumMember(Value = "K8S_CLUSTER")]
        K8S_CLUSTER,

        [EnumMember(Value = "K8S_RESOURCE_SET")]
        K8S_RESOURCE_SET,

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

        [EnumMember(Value = "ManagedVolume")]
        MANAGED_VOLUME,

        [EnumMember(Value = "Mssql")]
        MSSQL,

        [EnumMember(Value = "NAS_FILESET")]
        NAS_FILESET,

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

        [EnumMember(Value = "PolarisAccount")]
        POLARIS_ACCOUNT,

        [EnumMember(Value = "PublicCloudMachineInstance")]
        PUBLIC_CLOUD_MACHINE_INSTANCE,

        [EnumMember(Value = "RubrikEbsVolume")]
        RUBRIK_EBS_VOLUME,

        [EnumMember(Value = "RubrikEc2Instance")]
        RUBRIK_EC2_INSTANCE,

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

} // namespace Rubrik.SecurityCloud.Types